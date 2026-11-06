// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class GetAgentResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the created agent.</para>
        /// </summary>
        [NameInMap("Agent")]
        [Validation(Required=false)]
        public GetAgentResponseBodyAgent Agent { get; set; }
        public class GetAgentResponseBodyAgent : TeaModel {
            /// <summary>
            /// <para>The definition version read in this request. When updating the current definition, use this value as the ExpectedVersion for UpdateAgent to prevent overwriting new versions submitted by other callers. The version read from a historical snapshot does not represent the current version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("AgentVersion")]
            [Validation(Required=false)]
            public int? AgentVersion { get; set; }

            /// <summary>
            /// <para>The list of callable sub-agents.</para>
            /// </summary>
            [NameInMap("CallableAgents")]
            [Validation(Required=false)]
            public List<GetAgentResponseBodyAgentCallableAgents> CallableAgents { get; set; }
            public class GetAgentResponseBodyAgentCallableAgents : TeaModel {
                /// <summary>
                /// <para>The display name of the sub-agent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Sub-assistant</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>The name of the sub-agent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sub-agent</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The source of the sub-agent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>custom</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <para>The version number of the sub-agent.</para>
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
            /// <para>The ID of the creator.</para>
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
            /// <para>Data analytics assistant</para>
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
            /// <para>The expert suites bound to the agent definition, including a fixed integer revision number or a version selection policy. Official resources continue to use PackageVersion to indicate the artifact version.</para>
            /// </summary>
            [NameInMap("ExpertSuites")]
            [Validation(Required=false)]
            public List<GetAgentResponseBodyAgentExpertSuites> ExpertSuites { get; set; }
            public class GetAgentResponseBodyAgentExpertSuites : TeaModel {
                /// <summary>
                /// <para>If the suite is deleted, the published snapshot is missing, or the caller does not have permission to view it, the suite summary is not returned, and only the ID and version number are retained.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Data analytics expert capability set</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The display name of the bound version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Data analytics expert suite</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>The suite name of the bound version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>analysis-suite</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Returns the fixed official artifact version when explicitly querying a published version of the agent. Not returned when querying a draft or a custom suite.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.1.0.202610211408</para>
                /// </summary>
                [NameInMap("PackageVersion")]
                [Validation(Required=false)]
                public string PackageVersion { get; set; }

                /// <summary>
                /// <para>An optional suite summary field that is not returned by current new DataAgent applications. A missing value does not indicate version 0. This field cannot be used as the Version for UpdateAgent and must be omitted when writing back references. For the fixed version of official artifacts, read PackageVersion.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.2.0</para>
                /// </summary>
                [NameInMap("SemanticVersion")]
                [Validation(Required=false)]
                public string SemanticVersion { get; set; }

                /// <summary>
                /// <para>OFFICIAL indicates an official catalog resource. Omitted or DB indicates a personal or enterprise resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OFFICIAL</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <para>The ID of the expert suite.</para>
                /// 
                /// <b>Example:</b>
                /// <para>suite_example</para>
                /// </summary>
                [NameInMap("SuiteId")]
                [Validation(Required=false)]
                public string SuiteId { get; set; }

                /// <summary>
                /// <para>Returned only when a personal or enterprise suite explicitly specifies a fixed integer version in the reference. Not returned for official suites. A missing value is not 0. If the SDK initializes a missing integer to 0, it must be omitted when writing back. For official items, only Source and SuiteId are written back, and Version, VersionSelector, SemanticVersion, or PackageVersion are not passed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public int? Version { get; set; }

                /// <summary>
                /// <para>Returned only for personal or enterprise resources to indicate the saved version selection policy, which is mutually exclusive with the fixed integer Version. It does not represent the specific revision actually loaded in the session. Not returned for official resources.</para>
                /// 
                /// <b>Example:</b>
                /// <para>^1.2.3</para>
                /// </summary>
                [NameInMap("VersionSelector")]
                [Validation(Required=false)]
                public string VersionSelector { get; set; }

            }

            /// <summary>
            /// <para>The creation time, expressed as a timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1780555634000</para>
            /// </summary>
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public long? GmtCreateTime { get; set; }

            /// <summary>
            /// <para>The last modified time, expressed as a timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1780555634000</para>
            /// </summary>
            [NameInMap("GmtModifiedTime")]
            [Validation(Required=false)]
            public long? GmtModifiedTime { get; set; }

            /// <summary>
            /// <para><b>The extended metadata.</b></para>
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
                /// <para>The additional configuration of the model.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("Config")]
                [Validation(Required=false)]
                public Dictionary<string, object> Config { get; set; }

                /// <summary>
                /// <para>The maximum number of output tokens per request.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8192</para>
                /// </summary>
                [NameInMap("MaxTokens")]
                [Validation(Required=false)]
                public int? MaxTokens { get; set; }

                /// <summary>
                /// <para>The name of the model.</para>
                /// 
                /// <b>Example:</b>
                /// <para>qwen3-max</para>
                /// </summary>
                [NameInMap("ModelName")]
                [Validation(Required=false)]
                public string ModelName { get; set; }

                /// <summary>
                /// <para>Specifies whether to use streaming output.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Stream")]
                [Validation(Required=false)]
                public bool? Stream { get; set; }

                /// <summary>
                /// <para>The sampling temperature.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Temperature")]
                [Validation(Required=false)]
                public double? Temperature { get; set; }

                /// <summary>
                /// <para>The top-P value for nucleus sampling.</para>
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
            /// <para>The environment dependencies required for runtime.</para>
            /// </summary>
            [NameInMap("RequiredRuntime")]
            [Validation(Required=false)]
            public List<string> RequiredRuntime { get; set; }

            /// <summary>
            /// <para>The list of skills.</para>
            /// </summary>
            [NameInMap("Skills")]
            [Validation(Required=false)]
            public List<GetAgentResponseBodyAgentSkills> Skills { get; set; }
            public class GetAgentResponseBodyAgentSkills : TeaModel {
                /// <summary>
                /// <para>The name of the skill.</para>
                /// 
                /// <b>Example:</b>
                /// <para>my-skill</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Returns the fixed official artifact version when querying a published snapshot with a specified AgentVersion. Not returned when querying a draft or a custom skill.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.6.0.202608201110</para>
                /// </summary>
                [NameInMap("PackageVersion")]
                [Validation(Required=false)]
                public string PackageVersion { get; set; }

                /// <summary>
                /// <para>The ID of the official skill.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dataworks-semantic</para>
                /// </summary>
                [NameInMap("SkillId")]
                [Validation(Required=false)]
                public string SkillId { get; set; }

                /// <summary>
                /// <para>OFFICIAL indicates an official catalog resource. Omitted or DB indicates an original personal or enterprise resource.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OFFICIAL</para>
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <para>The version number of the skill.</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public int? Version { get; set; }

                /// <summary>
                /// <para>Returned only for personal or enterprise resources to indicate the saved version selection policy, which is mutually exclusive with the fixed integer Version. It does not represent the specific revision actually loaded in the session. Not returned for official resources.</para>
                /// 
                /// <b>Example:</b>
                /// <para>^1.2.3</para>
                /// </summary>
                [NameInMap("VersionSelector")]
                [Validation(Required=false)]
                public string VersionSelector { get; set; }

            }

            /// <summary>
            /// <para><b>The system prompt.</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>You are a data analytics assistant.</para>
            /// </summary>
            [NameInMap("SystemPrompt")]
            [Validation(Required=false)]
            public string SystemPrompt { get; set; }

            /// <summary>
            /// <para><b>The list of tools.</b></para>
            /// </summary>
            [NameInMap("Tools")]
            [Validation(Required=false)]
            public List<GetAgentResponseBodyAgentTools> Tools { get; set; }
            public class GetAgentResponseBodyAgentTools : TeaModel {
                /// <summary>
                /// <para><b>The name of the built-in tool. Valid when Kind is builtin.</b></para>
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
                /// <para><b>The selected MCP tool items. Valid when Kind is mcp.</b></para>
                /// </summary>
                [NameInMap("McpItems")]
                [Validation(Required=false)]
                public List<string> McpItems { get; set; }

                /// <summary>
                /// <para><b>The name of the associated MCP server. Valid when Kind is mcp.</b></para>
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
                /// <para>The list of visible project IDs.</para>
                /// </summary>
                [NameInMap("ProjectIds")]
                [Validation(Required=false)]
                public List<string> ProjectIds { get; set; }

                /// <summary>
                /// <para>The list of visible user IDs.</para>
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
