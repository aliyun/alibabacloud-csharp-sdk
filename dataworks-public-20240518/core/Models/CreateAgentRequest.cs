// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateAgentRequest : TeaModel {
        /// <summary>
        /// <para>The list of child agents that can be called by this agent.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("CallableAgents")]
        [Validation(Required=false)]
        public List<CreateAgentRequestCallableAgents> CallableAgents { get; set; }
        public class CreateAgentRequestCallableAgents : TeaModel {
            /// <summary>
            /// <para>The name of the agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>agent-1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The description of the agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Data analytics assistant</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The display name of the agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>My Assistant</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>Agent 绑定的已发布专家套件。个人或企业套件使用 SuiteId，可选 Version；官方套件必须显式指定 Source=OFFICIAL 和官方目录中的 SuiteId，不传 Version。未传时创建为空，不会默认加载所有官方套件。</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Source&quot;:&quot;OFFICIAL&quot;,&quot;SuiteId&quot;:&quot;dataworks-data-analysis-extension&quot;},{&quot;SuiteId&quot;:&quot;suite_example&quot;,&quot;Version&quot;:1}]</para>
        /// </summary>
        [NameInMap("ExpertSuites")]
        [Validation(Required=false)]
        public List<CreateAgentRequestExpertSuites> ExpertSuites { get; set; }
        public class CreateAgentRequestExpertSuites : TeaModel {
            /// <summary>
            /// <para>OFFICIAL 表示官方目录资源；DB 表示个人或企业资源。省略时保持原有数据库资源查询语义。官方资源在 Agent 发布时固定制品版本。</para>
            /// 
            /// <b>Example:</b>
            /// <para>OFFICIAL</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>传入专家套件引用时，每项需提供 SuiteId，由服务端校验。Source=OFFICIAL 时为官方目录 ID；其他情况为专家套件管理返回的 ID。引用资源必须对调用者可见。</para>
            /// 
            /// <b>Example:</b>
            /// <para>dataworks-data-analysis-extension</para>
            /// </summary>
            [NameInMap("SuiteId")]
            [Validation(Required=false)]
            public string SuiteId { get; set; }

            /// <summary>
            /// <para>仅用于个人或企业套件，必须为已发布快照的整数版本号。省略时在 Agent 发布时固定当前已发布版本。Source=OFFICIAL 时不传此字段。</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public int? Version { get; set; }

        }

        /// <summary>
        /// <para>The extended metadata in key-value pairs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public Dictionary<string, object> Metadata { get; set; }

        /// <summary>
        /// <para>The model configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///           &quot;modelName&quot;: &quot;dataworks-public-bailian/qwen-max&quot;
        ///         }</para>
        /// </summary>
        [NameInMap("Model")]
        [Validation(Required=false)]
        public Dictionary<string, object> Model { get; set; }

        /// <summary>
        /// <para>The name of the agent. The name must be unique within the current account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-agent</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>是否在创建 Agent 后立即发布。true 发布创建的版本；false 或省略保持原有仅创建草稿行为。保存与发布不是原子操作，发布失败时草稿可能已存在；重试前应先查询 Agent，避免重复创建。</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("PublishImmediately")]
        [Validation(Required=false)]
        public bool? PublishImmediately { get; set; }

        /// <summary>
        /// <para>The list of skills.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("Skills")]
        [Validation(Required=false)]
        public List<CreateAgentRequestSkills> Skills { get; set; }
        public class CreateAgentRequestSkills : TeaModel {
            /// <summary>
            /// <para>The name of the skill.</para>
            /// 
            /// <b>Example:</b>
            /// <para>skill-1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Source=OFFICIAL 时传官方目录 ID，不传 Name 或 Version。个人或企业 Skill 不传此字段。</para>
            /// 
            /// <b>Example:</b>
            /// <para>dataworks-semantic</para>
            /// </summary>
            [NameInMap("SkillId")]
            [Validation(Required=false)]
            public string SkillId { get; set; }

            /// <summary>
            /// <para>OFFICIAL 表示官方目录资源；DB 表示个人或企业资源，省略时保持原有按名称查询语义。</para>
            /// 
            /// <b>Example:</b>
            /// <para>OFFICIAL</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>仅用于个人或企业 Skill，必须为已发布快照的整数版本。省略时在 Agent 发布时固定当前已发布版本；Source=OFFICIAL 时不传。</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public int? Version { get; set; }

        }

        /// <summary>
        /// <para>The system prompt.</para>
        /// 
        /// <b>Example:</b>
        /// <para>You are a data analytics assistant</para>
        /// </summary>
        [NameInMap("SystemPrompt")]
        [Validation(Required=false)]
        public string SystemPrompt { get; set; }

        /// <summary>
        /// <para>The list of tools.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("Tools")]
        [Validation(Required=false)]
        public List<CreateAgentRequestTools> Tools { get; set; }
        public class CreateAgentRequestTools : TeaModel {
            /// <summary>
            /// <para>The name of the McpServer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>server-1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The visibility level.<br>
        /// <c>TENANT</c>: Visible within the account.<br>
        /// <c>PROJECT</c>: Visible to specified projects.<br>
        /// <c>USER</c>: Visible to specified users.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TENANT</para>
        /// </summary>
        [NameInMap("Visibility")]
        [Validation(Required=false)]
        public string Visibility { get; set; }

        /// <summary>
        /// <para>The visibility scope. The corresponding field is used based on the visibility level.</para>
        /// </summary>
        [NameInMap("VisibilityScope")]
        [Validation(Required=false)]
        public CreateAgentRequestVisibilityScope VisibilityScope { get; set; }
        public class CreateAgentRequestVisibilityScope : TeaModel {
            /// <summary>
            /// <para>The list of visible project IDs. This parameter takes effect when Visibility is set to <c>PROJECT</c>.</para>
            /// </summary>
            [NameInMap("ProjectIds")]
            [Validation(Required=false)]
            public List<string> ProjectIds { get; set; }

            /// <summary>
            /// <para>The list of visible user IDs. This parameter takes effect when Visibility is set to <c>USER</c>.</para>
            /// </summary>
            [NameInMap("UserIds")]
            [Validation(Required=false)]
            public List<string> UserIds { get; set; }

        }

    }

}
