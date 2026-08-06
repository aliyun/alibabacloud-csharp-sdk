// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class UpdateModelTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The model group configuration JSON object. You can use this field to modify the default model. The configuration format varies depending on the agent provider (AgentProvider):</para>
        /// <list type="bullet">
        /// <item><description><para><b>OpenClaw / AgenticComputer scenarios:</b>
        /// Set the default model by using the <c>defaults.model.primary</c> field. The format is <c>ProviderName/ModelCode</c>.</para>
        /// </description></item>
        /// <item><description><para><b>HermesAgent scenario:</b>
        /// Specify the provider name by using <c>model.provider</c> and specify the model code by using <c>model.default</c>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>:</para>
        /// <list type="bullet">
        /// <item><description>When you modify the default model, the system verifies whether the specified provider and model code already exist in the model group.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>OpenClaw：
        /// {&quot;defaults&quot;:{&quot;model&quot;:{&quot;primary&quot;:&quot;bailian/qwen3.5-plus&quot;}}}</para>
        /// <para>HermesAgent：
        /// {&quot;model&quot;:{&quot;provider&quot;:&quot;bailian&quot;,&quot;default&quot;:&quot;qwen3.5-plus&quot;}}</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The template group description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>测试模型分组</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The model group ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mt-xxxx</para>
        /// </summary>
        [NameInMap("ModelTemplateId")]
        [Validation(Required=false)]
        public string ModelTemplateId { get; set; }

        /// <summary>
        /// <para>The template group name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>model-template-001</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
