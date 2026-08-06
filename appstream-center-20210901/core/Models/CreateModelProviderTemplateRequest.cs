// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class CreateModelProviderTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The Agent platform.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ENTERPRISE</para>
        /// </summary>
        [NameInMap("AgentPlatform")]
        [Validation(Required=false)]
        public string AgentPlatform { get; set; }

        /// <summary>
        /// <para>The Agent provider name.</para>
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
        /// <para>The model provider configuration in JSON format, which contains connection information such as baseUrl, apiKey, and api. The apiKey is encrypted after creation. When ProviderType is set to WuyingCredit, this parameter is not required because the configuration is copied from the system template.</para>
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
        /// <para>阿里云百炼服务商</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the WUYING secure proxy. This parameter must be set to true when ProviderType is set to WuyingCredit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableWuyingProxy")]
        [Validation(Required=false)]
        public bool? EnableWuyingProxy { get; set; }

        /// <summary>
        /// <para>The ID of the associated model template.</para>
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
        /// <para>阿里云百炼</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The model provider name. The name must be unique within the same model template. The naming rules vary based on the value of ProviderType. For more information, see the description of ProviderType.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bailian</para>
        /// </summary>
        [NameInMap("ProviderName")]
        [Validation(Required=false)]
        public string ProviderName { get; set; }

        /// <summary>
        /// <para>The model provider type. Different types impose different constraints on ProviderName and Config. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>WuyingCredit: WUYING credit plan. ProviderName must be set to wuying-credit. The template is created by copying from a system template, and Config is not required.</description></item>
        /// <item><description>Managed: managed provider. System-reserved names such as wuying-credit cannot be used. Config is required.</description></item>
        /// <item><description>Custom: user-defined provider. ProviderName must start with the prefix provider-. Config is required.</description></item>
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
