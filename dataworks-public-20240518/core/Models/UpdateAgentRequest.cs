// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateAgentRequest : TeaModel {
        /// <summary>
        /// <para>The list of callable sub-agent references. For non-empty references, the referenced sub-agents must be visible. The agent cannot reference itself or form a call loop. Omit this parameter if no modification is required. Do not use an empty array to express general retention or clearing semantics.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Name&quot;:&quot;data-analysis&quot;}]</para>
        /// </summary>
        [NameInMap("CallableAgents")]
        [Validation(Required=false)]
        public List<UpdateAgentRequestCallableAgents> CallableAgents { get; set; }
        public class UpdateAgentRequestCallableAgents : TeaModel {
            /// <summary>
            /// <para>The name of the called sub-agent. The agent must be one that the current caller has permissions to use.</para>
            /// 
            /// <b>Example:</b>
            /// <para>data-analysis</para>
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
        /// <para>The agent definition version used for concurrency control. We recommend that you explicitly specify the AgentVersion just obtained from GetAgent for each call. The update is rejected if the version does not match the current version on the server. To ensure compatibility with different deployment versions, do not rely on the server-side processing when this parameter is omitted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ExpectedVersion")]
        [Validation(Required=false)]
        public int? ExpectedVersion { get; set; }

        /// <summary>
        /// <para>The list of expert suite references. If omitted, existing references are retained. An explicit empty array clears the references. For official suites, specify only Source=OFFICIAL and SuiteId. Version, VersionSelector, or client artifact fields are not accepted. For custom suites, use SuiteId, and you can explicitly specify an existing integer Version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;SuiteId&quot;:&quot;suite_example&quot;,&quot;Version&quot;:3}]</para>
        /// </summary>
        [NameInMap("ExpertSuites")]
        [Validation(Required=false)]
        public List<UpdateAgentRequestExpertSuites> ExpertSuites { get; set; }
        public class UpdateAgentRequestExpertSuites : TeaModel {
            /// <summary>
            /// <para>The source of the expert suite. OFFICIAL: official suite. DB or omitted: custom suite. Both types of references use SuiteId. Version fields apply only to custom resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OFFICIAL</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The ID of the target expert suite. The suite must be one that the current caller has permissions to reference.</para>
            /// 
            /// <b>Example:</b>
            /// <para>suite_example</para>
            /// </summary>
            [NameInMap("SuiteId")]
            [Validation(Required=false)]
            public string SuiteId { get; set; }

            /// <summary>
            /// <para>The published integer version number of the custom expert suite, used to explicitly select an existing version. Do not pass this field when Source is set to OFFICIAL. This parameter is mutually exclusive with VersionSelector. To obtain explicit and reproducible references, do not rely on the default selection when the version is omitted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public int? Version { get; set; }

            /// <summary>
            /// <para>The semantic version selection expression of the custom expert suite, such as ^1.2.3. Use this parameter only when the custom resource version selection capability is deployed on the target server. This parameter is mutually exclusive with Version. This field is not accepted when Source is set to OFFICIAL. To ensure compatibility with servers whose version capabilities are unconfirmed, use an existing integer Version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>^1.2.3</para>
            /// </summary>
            [NameInMap("VersionSelector")]
            [Validation(Required=false)]
            public string VersionSelector { get; set; }

        }

        /// <summary>
        /// <para>The extended metadata. If omitted, existing metadata is retained. If passed, business metadata is updated, and the server retains protected system metadata.</para>
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
        /// <para>The name of the agent to be updated. Use the Name returned by GetAgent. This field is used to locate the target agent and cannot be used to rename the agent.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-agent</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Specifies whether to publish the agent immediately after the update. Valid values: true: saves a new draft version first and then requests publishing. false or omitted: saves only the definition. Saving and publishing are not atomic operations. If the operation fails, call GetAgent to read the current version back before retrying, to avoid blindly repeating the update.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("PublishImmediately")]
        [Validation(Required=false)]
        public bool? PublishImmediately { get; set; }

        /// <summary>
        /// <para>The list of skill references. Omit this parameter if no modification is required. Do not use an empty array to indicate retention or clearing. For official skills, specify only Source=OFFICIAL and SkillId. Name, Version, VersionSelector, or client artifact fields are not accepted. For custom skills, specify Name, and you can explicitly specify an existing integer Version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Source&quot;:&quot;OFFICIAL&quot;,&quot;SkillId&quot;:&quot;dataworks-semantic&quot;}]</para>
        /// </summary>
        [NameInMap("Skills")]
        [Validation(Required=false)]
        public List<UpdateAgentRequestSkills> Skills { get; set; }
        public class UpdateAgentRequestSkills : TeaModel {
            /// <summary>
            /// <para>The name of the custom skill. Use the Name of a visible custom skill. For official skills, use SkillId.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-business-skill</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The resource ID of the official skill. This parameter is used when Source is set to OFFICIAL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dataworks-semantic</para>
            /// </summary>
            [NameInMap("SkillId")]
            [Validation(Required=false)]
            public string SkillId { get; set; }

            /// <summary>
            /// <para>The source of the skill. OFFICIAL: official skill, used with SkillId. DB or omitted: custom skill, used with Name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OFFICIAL</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The published integer version number of the custom skill, used to explicitly select an existing version. Do not pass this field when Source is set to OFFICIAL. This parameter is mutually exclusive with VersionSelector.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public int? Version { get; set; }

            /// <summary>
            /// <para>The semantic version selection expression of the custom skill, such as ^1.2.3. Use this parameter only when the custom resource version selection capability is deployed on the target server. This parameter is mutually exclusive with Version. This field is not accepted when Source is set to OFFICIAL. To ensure compatibility with servers whose version capabilities are unconfirmed, use an existing integer Version.</para>
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
        /// <para>You are an excellent ETL engineer</para>
        /// </summary>
        [NameInMap("SystemPrompt")]
        [Validation(Required=false)]
        public string SystemPrompt { get; set; }

        /// <summary>
        /// <para>The list of tool references. Omit this parameter if no modification is required. The current new backend retains existing tools even if an empty array is passed. A non-empty array replaces the references. Each item must include Kind and the corresponding configuration, and cannot include only Name. Replace the MCP service and tool names in the example with actual values available to the current identity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Kind&quot;:&quot;MCP_TOOLSET&quot;,&quot;McpServerName&quot;:&quot;mcp-a&quot;,&quot;McpItems&quot;:[&quot;only-this-tool&quot;]}]</para>
        /// </summary>
        [NameInMap("Tools")]
        [Validation(Required=false)]
        public List<UpdateAgentRequestTools> Tools { get; set; }
        public class UpdateAgentRequestTools : TeaModel {
            /// <summary>
            /// <para>The name of the built-in toolset. This parameter is required when Kind is set to BUILTIN_TOOLSET. Use a name supported by the target server. Omit this parameter when Kind is set to MCP_TOOLSET.</para>
            /// 
            /// <b>Example:</b>
            /// <para>web_search</para>
            /// </summary>
            [NameInMap("BuiltinName")]
            [Validation(Required=false)]
            public string BuiltinName { get; set; }

            /// <summary>
            /// <para>The tool type. A valid tool reference must specify BUILTIN_TOOLSET or MCP_TOOLSET. For BUILTIN_TOOLSET, BuiltinName must also be specified. For MCP_TOOLSET, McpServerName must also be specified. The target server validates the reference based on the tool type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MCP_TOOLSET</para>
            /// </summary>
            [NameInMap("Kind")]
            [Validation(Required=false)]
            public string Kind { get; set; }

            /// <summary>
            /// <para>The list of selected MCP tool names. If this parameter is omitted or an empty array is passed, tools are not filtered by name. Each item must be the name of a tool that actually exists in the target service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;only-this-tool&quot;]</para>
            /// </summary>
            [NameInMap("McpItems")]
            [Validation(Required=false)]
            public List<string> McpItems { get; set; }

            /// <summary>
            /// <para>The MCP service name. This parameter is required when Kind is set to MCP_TOOLSET. The service must be one that the current invoker has permissions to reference and that has an active published version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mcp-a</para>
            /// </summary>
            [NameInMap("McpServerName")]
            [Validation(Required=false)]
            public string McpServerName { get; set; }

            /// <summary>
            /// <para>A field retained from the legacy model. Specifying only Name does not constitute a valid tool configuration and cannot replace Kind, BuiltinName, or McpServerName.</para>
            /// 
            /// <b>Example:</b>
            /// <para>search_tables</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The visibility level. Valid values: <br><c>TENANT</c>: visible within the account. <br><c>PROJECT</c>: visible to specified projects. <br><c>USER</c>: visible to specified users.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TENANT</para>
        /// </summary>
        [NameInMap("Visibility")]
        [Validation(Required=false)]
        public string Visibility { get; set; }

        /// <summary>
        /// <para>The visibility scope. The corresponding field is used based on the Visibility parameter.</para>
        /// </summary>
        [NameInMap("VisibilityScope")]
        [Validation(Required=false)]
        public UpdateAgentRequestVisibilityScope VisibilityScope { get; set; }
        public class UpdateAgentRequestVisibilityScope : TeaModel {
            /// <summary>
            /// <para>The list of visible project IDs. This parameter takes effect when Visibility is set to <c>PROJECT</c>.</para>
            /// </summary>
            [NameInMap("ProjectIds")]
            [Validation(Required=false)]
            public List<string> ProjectIds { get; set; }

            /// <summary>
            /// <para>The list of visible user IDs. This parameter is used when Visibility is set to USER.</para>
            /// </summary>
            [NameInMap("UserIds")]
            [Validation(Required=false)]
            public List<string> UserIds { get; set; }

        }

    }

}
