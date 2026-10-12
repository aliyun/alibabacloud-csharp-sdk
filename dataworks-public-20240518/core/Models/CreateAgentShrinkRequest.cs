// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20240518.Models
{
    public class CreateAgentShrinkRequest : TeaModel {
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
        /// <para>The extended metadata in key-value pairs.</para>
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
        /// <para>The list of skills.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("Skills")]
        [Validation(Required=false)]
        public string SkillsShrink { get; set; }

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
        public string ToolsShrink { get; set; }

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
        public string VisibilityScopeShrink { get; set; }

    }

}
