// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class CreateModelProviderTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The agent platform.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ENTERPRISE</para>
        /// </summary>
        [NameInMap("AgentPlatform")]
        [Validation(Required=false)]
        public string AgentPlatform { get; set; }

        /// <summary>
        /// <para>The name of the agent provider.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OpenClaw</para>
        /// </summary>
        [NameInMap("AgentProvider")]
        [Validation(Required=false)]
        public string AgentProvider { get; set; }

        /// <summary>
        /// <para>The business type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public int? BizType { get; set; }

        /// <summary>
        /// <para>The JSON configuration of the model provider, which includes connection information such as baseUrl, apiKey, and api. The apiKey is encrypted and stored after creation. When ProviderType is WuyingCredit, this parameter is not required and will be copied from the system template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;api&quot;: &quot;openai-completions&quot;,
        ///     &quot;apiKey&quot;: &quot;sk-xxxx&quot;,
        ///     &quot;baseUrl&quot;: &quot;<a href="https://dashscope.aliyuncs.com/compatible-mode/v1">https://dashscope.aliyuncs.com/compatible-mode/v1</a>&quot;
        /// }</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The description of the model provider template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alibaba Cloud Bailian provider</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the Wuying secure proxy. This parameter must be set to true when ProviderType is WuyingCredit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableWuyingProxy")]
        [Validation(Required=false)]
        public bool? EnableWuyingProxy { get; set; }

        /// <summary>
        /// <para>The ID of the associated model group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mt-xxxx</para>
        /// </summary>
        [NameInMap("ModelTemplateId")]
        [Validation(Required=false)]
        public string ModelTemplateId { get; set; }

        /// <summary>
        /// <para>The name of the model provider template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alibaba Cloud Bailian</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The name of the model provider. The name must be unique within the same model template. The naming conventions vary based on the ProviderType. For more information, see the description of ProviderType.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bailian</para>
        /// </summary>
        [NameInMap("ProviderName")]
        [Validation(Required=false)]
        public string ProviderName { get; set; }

        /// <summary>
        /// <para>The type of the model provider. Different types have different constraints on ProviderName and Config:</para>
        /// <list type="bullet">
        /// <item><description>WuyingCredit: Wuying credit package. The ProviderName must be wuying-credit. The template is created by copying from a system template, and Config is not required.</description></item>
        /// <item><description>Managed: Managed provider. System-reserved names such as wuying-credit cannot be used, and Config is required.</description></item>
        /// <item><description>Custom: Custom provider. The ProviderName must start with the provider- prefix, and Config is required.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Managed</para>
        /// </summary>
        [NameInMap("ProviderType")]
        [Validation(Required=false)]
        public string ProviderType { get; set; }

    }

}
