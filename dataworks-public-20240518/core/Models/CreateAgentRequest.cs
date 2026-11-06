// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateAgentRequest : TeaModel {
        /// <summary>
        /// <para>The list of sub-agents that can be called by this agent.</para>
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
        /// <para>The published expert suites bound to the agent. For personal or enterprise suites, use SuiteId, and optionally specify a fixed Version or VersionSelector. For official suites, you must explicitly specify Source=OFFICIAL and the SuiteId from the official catalog, and do not specify Version or VersionSelector. If not specified, an empty list is created, and all official suites are not loaded by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Source&quot;:&quot;OFFICIAL&quot;,&quot;SuiteId&quot;:&quot;dataworks-data-analysis-extension&quot;},{&quot;SuiteId&quot;:&quot;suite_example&quot;,&quot;Version&quot;:1}]</para>
        /// </summary>
        [NameInMap("ExpertSuites")]
        [Validation(Required=false)]
        public List<CreateAgentRequestExpertSuites> ExpertSuites { get; set; }
        public class CreateAgentRequestExpertSuites : TeaModel {
            /// <summary>
            /// <para>OFFICIAL indicates an official catalog resource. DB indicates a personal or enterprise resource. If omitted, the original database resource query semantics are maintained. For official resources, the artifact version is fixed when the agent is published.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OFFICIAL</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>When passing expert suite references, each item must provide a SuiteId, which is validated by the server. When Source is OFFICIAL, this is the official catalog ID. Otherwise, this is the ID returned by expert suite management. The referenced resource must be visible to the caller.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dataworks-data-analysis-extension</para>
            /// </summary>
            [NameInMap("SuiteId")]
            [Validation(Required=false)]
            public string SuiteId { get; set; }

            /// <summary>
            /// <para>Used only for personal or enterprise suites. Specifies the fixed integer revision number of a published snapshot. This parameter is mutually exclusive with VersionSelector. Publishing a new version does not change the fixed reference. If both are omitted, the latest version is used for each new session. Do not specify this parameter when Source is OFFICIAL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public int? Version { get; set; }

            /// <summary>
            /// <para>Used only for personal or enterprise resources. This parameter is mutually exclusive with Version. Supports exact semantic versions, latest, and full npm/node-semver range syntax, such as 1.2.*, ^1.2.3, ~1.2.3, &gt;=1.0.0 &lt;2.0.0, and 1.x || 2.x. If both are omitted, the latest version is used, and the highest matching published version is selected for each new session. Existing fixed integer references remain unchanged. Do not specify this parameter when Source is OFFICIAL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>^1.2.3</para>
            /// </summary>
            [NameInMap("VersionSelector")]
            [Validation(Required=false)]
            public string VersionSelector { get; set; }

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
        /// <para>Specifies whether to publish the agent immediately after creation. A value of true publishes the created version. A value of false or omitting this parameter maintains the original behavior of creating a draft only. Saving and publishing are not atomic operations. If publishing fails, the draft may already exist. Before retrying, query the agent first to avoid duplicate creation.</para>
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
            /// <para>When Source is OFFICIAL, specify the official catalog ID. Do not specify Name, Version, or VersionSelector. Do not specify this field for personal or enterprise skills.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dataworks-semantic</para>
            /// </summary>
            [NameInMap("SkillId")]
            [Validation(Required=false)]
            public string SkillId { get; set; }

            /// <summary>
            /// <para>OFFICIAL indicates an official catalog resource. DB indicates a personal or enterprise resource. If omitted, the original query-by-name semantics are maintained.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OFFICIAL</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>Used only for personal or enterprise skills. Specifies the fixed integer revision number of a published snapshot. This parameter is mutually exclusive with VersionSelector. Publishing a new version does not change the fixed reference. If both are omitted, the latest version is used for each new session. Do not specify this parameter when Source is OFFICIAL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public int? Version { get; set; }

            /// <summary>
            /// <para>Used only for personal or enterprise resources. This parameter is mutually exclusive with Version. Supports exact semantic versions, latest, and full npm/node-semver range syntax, such as 1.2.*, ^1.2.3, ~1.2.3, &gt;=1.0.0 &lt;2.0.0, and 1.x || 2.x. If both are omitted, the latest version is used, and the highest matching published version is selected for each new session. Existing fixed integer references remain unchanged. Do not specify this parameter when Source is OFFICIAL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>^1.2.3</para>
            /// </summary>
            [NameInMap("VersionSelector")]
            [Validation(Required=false)]
            public string VersionSelector { get; set; }

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
            /// <para>Required when Kind is BUILTIN_TOOLSET. Specifies the name of the built-in toolset supported by the target server. Omit this parameter when Kind is MCP_TOOLSET.</para>
            /// 
            /// <b>Example:</b>
            /// <para>web_search</para>
            /// </summary>
            [NameInMap("BuiltinName")]
            [Validation(Required=false)]
            public string BuiltinName { get; set; }

            /// <summary>
            /// <para>Required for valid tool references. BUILTIN_TOOLSET indicates a built-in toolset, and BuiltinName must be specified. MCP_TOOLSET indicates an MCP toolset, and McpServerName must be specified. The target server validates the parameter based on the tool type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MCP_TOOLSET</para>
            /// </summary>
            [NameInMap("Kind")]
            [Validation(Required=false)]
            public string Kind { get; set; }

            /// <summary>
            /// <para>Optional when Kind is MCP_TOOLSET. If specified, only the listed tools are used. If omitted or left as an empty array, tools are not filtered by name. Each item must be the name of an actual tool in the target MCP service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;only-this-tool&quot;]</para>
            /// </summary>
            [NameInMap("McpItems")]
            [Validation(Required=false)]
            public List<string> McpItems { get; set; }

            /// <summary>
            /// <para>Required when Kind is MCP_TOOLSET. Specifies the MCP service name that the current caller has permission to reference and that has an active published version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mcp-a</para>
            /// </summary>
            [NameInMap("McpServerName")]
            [Validation(Required=false)]
            public string McpServerName { get; set; }

            /// <summary>
            /// <para>The name of the MCP server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>server-1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The visibility level. Valid values:<br>
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
        /// <para>The visibility scope. Specify the corresponding fields based on the Visibility value.</para>
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
