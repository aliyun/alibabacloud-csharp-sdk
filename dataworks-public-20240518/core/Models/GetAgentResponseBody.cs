// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetAgentResponseBody : TeaModel {
        /// <summary>
        /// <para>The agent details.</para>
        /// </summary>
        [NameInMap("Agent")]
        [Validation(Required=false)]
        public GetAgentResponseBodyAgent Agent { get; set; }
        public class GetAgentResponseBodyAgent : TeaModel {
            /// <summary>
            /// <para>本次读取的定义版本。更新当前定义时，将该值作为 UpdateAgent 的 ExpectedVersion，可拒绝覆盖其他调用者已提交的新版本。读取历史快照的版本不代表当前版本。</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("AgentVersion")]
            [Validation(Required=false)]
            public int? AgentVersion { get; set; }

            /// <summary>
            /// <para>A list of callable sub-agents.</para>
            /// </summary>
            [NameInMap("CallableAgents")]
            [Validation(Required=false)]
            public List<GetAgentResponseBodyAgentCallableAgents> CallableAgents { get; set; }
            public class GetAgentResponseBodyAgentCallableAgents : TeaModel {
                /// <summary>
                /// <para>The sub-agent display name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Sub-assistant</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>The sub-agent name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sub-agent</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The sub-agent source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>custom</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <para>The sub-agent version.</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public int? Version { get; set; }

            }

            /// <summary>
            /// <para>The creator ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("CreatorId")]
            [Validation(Required=false)]
            public string CreatorId { get; set; }

            /// <summary>
            /// <para><b>The description.</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>Data analysis assistant</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para><b>The display name.</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>My assistant</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>Agent 定义绑定的专家套件及固定发布版本。</para>
            /// </summary>
            [NameInMap("ExpertSuites")]
            [Validation(Required=false)]
            public List<GetAgentResponseBodyAgentExpertSuites> ExpertSuites { get; set; }
            public class GetAgentResponseBodyAgentExpertSuites : TeaModel {
                /// <summary>
                /// <para>套件已删除、发布快照缺失或调用者无权查看时，不返回套件摘要，仅保留 ID 和版本号。</para>
                /// 
                /// <b>Example:</b>
                /// <para>数据分析专家能力集合</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>数据分析专家套件</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>analysis-suite</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>显式查询 Agent 已发布版本时返回固定的官方制品版本；查询草稿或自定义套件时不返回。</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.1.0.202610211408</para>
                /// </summary>
                [NameInMap("PackageVersion")]
                [Validation(Required=false)]
                public string PackageVersion { get; set; }

                /// <summary>
                /// <para>可选套件摘要字段，当前新 DataAgent 应用不返回；缺省不表示版本 0。不可作为 UpdateAgent 的 Version，回写引用时必须省略。官方制品的固定版本请读取 PackageVersion。</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.2.0</para>
                /// </summary>
                [NameInMap("SemanticVersion")]
                [Validation(Required=false)]
                public string SemanticVersion { get; set; }

                /// <summary>
                /// <para>OFFICIAL 表示官方目录资源；省略或 DB 表示个人或企业资源。</para>
                /// 
                /// <b>Example:</b>
                /// <para>OFFICIAL</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>suite_example</para>
                /// </summary>
                [NameInMap("SuiteId")]
                [Validation(Required=false)]
                public string SuiteId { get; set; }

                /// <summary>
                /// <para>仅个人或企业套件在引用明确指定版本或读取发布快照时返回；官方套件不返回。未返回不是 0；SDK 若将缺省整数初始化为 0，回写时必须省略。官方项只回写 Source 和 SuiteId，不传 Version、SemanticVersion 或 PackageVersion。</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public int? Version { get; set; }

            }

            /// <summary>
            /// <para>The creation time, as a Unix timestamp in milliseconds.</para>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>1780555634000</para>
            /// </summary>
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            /// <summary>
            /// <para>The last modification time, as a Unix timestamp in milliseconds.</para>
            /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
            /// 
            /// <b>Example:</b>
            /// <para>1780555634000</para>
            /// </summary>
            [NameInMap("GmtModifiedTime")]
            [Validation(Required=false)]
            public string GmtModifiedTime { get; set; }

            /// <summary>
            /// <para><b>Additional metadata.</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Metadata")]
            [Validation(Required=false)]
            public Dictionary<string, object> Metadata { get; set; }

            /// <summary>
            /// <para><b>The model configuration.</b></para>
            /// </summary>
            [NameInMap("Model")]
            [Validation(Required=false)]
            public GetAgentResponseBodyAgentModel Model { get; set; }
            public class GetAgentResponseBodyAgentModel : TeaModel {
                /// <summary>
                /// <para>Additional configuration for the model.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("Config")]
                [Validation(Required=false)]
                public Dictionary<string, object> Config { get; set; }

                /// <summary>
                /// <para>The maximum number of tokens to generate in one response.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8192</para>
                /// </summary>
                [NameInMap("MaxTokens")]
                [Validation(Required=false)]
                public int? MaxTokens { get; set; }

                /// <summary>
                /// <para>The model name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>qwen3-max</para>
                /// </summary>
                [NameInMap("ModelName")]
                [Validation(Required=false)]
                public string ModelName { get; set; }

                /// <summary>
                /// <para>Indicates whether streaming output is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Stream")]
                [Validation(Required=false)]
                public bool? Stream { get; set; }

                /// <summary>
                /// <para>The temperature.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Temperature")]
                [Validation(Required=false)]
                public double? Temperature { get; set; }

                /// <summary>
                /// <para>The top-p.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TopP")]
                [Validation(Required=false)]
                public double? TopP { get; set; }

            }

            /// <summary>
            /// <para>The ID of the last modifier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("ModifierId")]
            [Validation(Required=false)]
            public string ModifierId { get; set; }

            /// <summary>
            /// <para><b>The agent name.</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>my-agent</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The runtime dependencies.</para>
            /// </summary>
            [NameInMap("RequiredRuntime")]
            [Validation(Required=false)]
            public List<string> RequiredRuntime { get; set; }

            /// <summary>
            /// <para>A list of skills.</para>
            /// </summary>
            [NameInMap("Skills")]
            [Validation(Required=false)]
            public List<GetAgentResponseBodyAgentSkills> Skills { get; set; }
            public class GetAgentResponseBodyAgentSkills : TeaModel {
                /// <summary>
                /// <para>The skill name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my-skill</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>指定 AgentVersion 查询已发布快照时返回固定的官方制品版本；查询草稿或自定义 Skill 时不返回。</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.6.0.202608201110</para>
                /// </summary>
                [NameInMap("PackageVersion")]
                [Validation(Required=false)]
                public string PackageVersion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>dataworks-semantic</para>
                /// </summary>
                [NameInMap("SkillId")]
                [Validation(Required=false)]
                public string SkillId { get; set; }

                /// <summary>
                /// <para>OFFICIAL 表示官方目录资源；省略或 DB 表示原有个人或企业资源。</para>
                /// 
                /// <b>Example:</b>
                /// <para>OFFICIAL</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <para>The skill version.</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public int? Version { get; set; }

            }

            /// <summary>
            /// <para><b>The system prompt.</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>You are a data analysis assistant.</para>
            /// </summary>
            [NameInMap("SystemPrompt")]
            [Validation(Required=false)]
            public string SystemPrompt { get; set; }

            /// <summary>
            /// <para><b>A list of tools.</b></para>
            /// </summary>
            [NameInMap("Tools")]
            [Validation(Required=false)]
            public List<GetAgentResponseBodyAgentTools> Tools { get; set; }
            public class GetAgentResponseBodyAgentTools : TeaModel {
                /// <summary>
                /// <para><b>The name of the built-in tool. This parameter applies only when <c>Kind</c> is set to <c>builtin</c>.</b></para>
                /// 
                /// <b>Example:</b>
                /// <para>builtin_sql</para>
                /// </summary>
                [NameInMap("BuiltinName")]
                [Validation(Required=false)]
                public string BuiltinName { get; set; }

                /// <summary>
                /// <para><b>The tool type.</b></para>
                /// 
                /// <b>Example:</b>
                /// <para>builtin</para>
                /// </summary>
                [NameInMap("Kind")]
                [Validation(Required=false)]
                public string Kind { get; set; }

                /// <summary>
                /// <para><b>The selected MCP tool items. This parameter applies only when <c>Kind</c> is set to <c>mcp</c>.</b></para>
                /// </summary>
                [NameInMap("McpItems")]
                [Validation(Required=false)]
                public List<string> McpItems { get; set; }

                /// <summary>
                /// <para><b>The name of the associated MCP server. This parameter applies only when <c>Kind</c> is set to <c>mcp</c>.</b></para>
                /// 
                /// <b>Example:</b>
                /// <para>server-name</para>
                /// </summary>
                [NameInMap("McpServerName")]
                [Validation(Required=false)]
                public string McpServerName { get; set; }

            }

            /// <summary>
            /// <para><b>The visibility level.</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>TENANT</para>
            /// </summary>
            [NameInMap("Visibility")]
            [Validation(Required=false)]
            public string Visibility { get; set; }

            /// <summary>
            /// <para>The visibility scope.</para>
            /// </summary>
            [NameInMap("VisibilityScope")]
            [Validation(Required=false)]
            public GetAgentResponseBodyAgentVisibilityScope VisibilityScope { get; set; }
            public class GetAgentResponseBodyAgentVisibilityScope : TeaModel {
                /// <summary>
                /// <para>A list of project IDs that can view the agent.</para>
                /// </summary>
                [NameInMap("ProjectIds")]
                [Validation(Required=false)]
                public List<string> ProjectIds { get; set; }

                /// <summary>
                /// <para>A list of user IDs that can view the agent.</para>
                /// </summary>
                [NameInMap("UserIds")]
                [Validation(Required=false)]
                public List<string> UserIds { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>824F80BA-1778-5D8A-BAFF-668A4D9C4CC7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
