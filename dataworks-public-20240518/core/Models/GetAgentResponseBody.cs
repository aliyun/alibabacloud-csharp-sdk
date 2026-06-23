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
                /// <para>子助手</para>
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
            /// <para>数据分析助手</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para><b>The display name.</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>我的助手</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

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
            /// <para>你是一个数据分析助手。</para>
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
