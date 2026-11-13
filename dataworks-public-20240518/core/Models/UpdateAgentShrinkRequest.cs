// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class UpdateAgentShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of callable sub-agent references. For non-empty references, the referenced sub-agents must be visible. The agent cannot reference itself or form a call loop. Omit this parameter if no modification is required. Do not use an empty array to express general retention or clearing semantics.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Name&quot;:&quot;data-analysis&quot;}]</para>
        /// </summary>
        [NameInMap("CallableAgents")]
        [Validation(Required=false)]
        public string CallableAgentsShrink { get; set; }

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
        /// <para>The agent definition version used for concurrency control. We recommend explicitly specifying the AgentVersion you just obtained from GetAgent for each call. The update is rejected if the version does not match the current version on the server. To ensure compatibility with different deployment versions, do not rely on the server-side processing when this parameter is omitted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("ExpectedVersion")]
        [Validation(Required=false)]
        public int? ExpectedVersion { get; set; }

        /// <summary>
        /// <para>The list of expert suite references. If omitted, the existing references are retained. An explicit empty array clears the references. For official suites, specify only Source=OFFICIAL and SuiteId. Version, VersionSelector, or client artifact fields are not accepted. For custom suites, use SuiteId, and you can explicitly specify an existing integer Version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;SuiteId&quot;:&quot;suite_example&quot;,&quot;Version&quot;:3}]</para>
        /// </summary>
        [NameInMap("ExpertSuites")]
        [Validation(Required=false)]
        public string ExpertSuitesShrink { get; set; }

        /// <summary>
        /// <para>The extended metadata. If omitted, the existing metadata is retained. If provided, the business metadata is updated, and the server retains the protected system metadata.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public string MetadataShrink { get; set; }

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
        public string ModelShrink { get; set; }

        /// <summary>
        /// <para>The name of the agent to be updated. Use the Name returned by GetAgent. This field is used to locate the target agent and is not used for renaming.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-agent</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Specifies whether to publish the agent immediately after the update. If this parameter is set to true, the operation saves a new draft version before requesting publication. If this parameter is set to false or omitted, it saves only the definition. Saving and publishing are not atomic operations. If the operation fails, call GetAgent to read the current version before retrying to avoid blindly repeating the update.</para>
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
        public string SkillsShrink { get; set; }

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
        /// <para>The list of tool references. Omit this parameter if no modification is required. The current new backend retains existing tools even for an empty array. A non-empty array replaces the references. Each item must include Kind and the corresponding configuration, and cannot include only Name. Replace the MCP service and tool names in the example with actual values available to the current identity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;Kind&quot;:&quot;MCP_TOOLSET&quot;,&quot;McpServerName&quot;:&quot;mcp-a&quot;,&quot;McpItems&quot;:[&quot;only-this-tool&quot;]}]</para>
        /// </summary>
        [NameInMap("Tools")]
        [Validation(Required=false)]
        public string ToolsShrink { get; set; }

        /// <summary>
        /// <para>The visibility level.<br>TENANT: visible within the account.<br>PROJECT: visible to specified projects.<br>USER: visible to specified users.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TENANT</para>
        /// </summary>
        [NameInMap("Visibility")]
        [Validation(Required=false)]
        public string Visibility { get; set; }

        /// <summary>
        /// <para>The visibility scope. The corresponding field is used based on the Visibility value.</para>
        /// </summary>
        [NameInMap("VisibilityScope")]
        [Validation(Required=false)]
        public string VisibilityScopeShrink { get; set; }

    }

}
