// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateAgentRequest : TeaModel {
        /// <summary>
        /// <para>The list of child Agents that can be called by this Agent.</para>
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
            /// <para>The Agent name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>agent-1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The description of the Agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Data analytics assistant</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The display name of the Agent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyAssistant.</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The extended metadata (key-value pairs).</para>
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
        /// <para>The Agent name, which must be unique within the current account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-agent</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

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
            /// <para>The skill name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>skill-1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The system prompt.</para>
        /// 
        /// <b>Example:</b>
        /// <para>You are a data analytics assistant.</para>
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
            /// <para>The McpServer name.</para>
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
        /// <para>The visibility scope. The corresponding field is determined by the Visibility parameter.</para>
        /// </summary>
        [NameInMap("VisibilityScope")]
        [Validation(Required=false)]
        public CreateAgentRequestVisibilityScope VisibilityScope { get; set; }
        public class CreateAgentRequestVisibilityScope : TeaModel {
            /// <summary>
            /// <para>The list of project IDs that have visibility. This parameter takes effect when Visibility is set to <c>PROJECT</c>.</para>
            /// </summary>
            [NameInMap("ProjectIds")]
            [Validation(Required=false)]
            public List<string> ProjectIds { get; set; }

            /// <summary>
            /// <para>The list of user IDs that have visibility. This parameter takes effect when Visibility is set to <c>USER</c>.</para>
            /// </summary>
            [NameInMap("UserIds")]
            [Validation(Required=false)]
            public List<string> UserIds { get; set; }

        }

    }

}
