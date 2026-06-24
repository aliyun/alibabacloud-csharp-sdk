// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class CreateModelProviderTemplateRequest : TeaModel {
        /// <summary>
        /// <para>Agent platform.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ENTERPRISE</para>
        /// </summary>
        [NameInMap("AgentPlatform")]
        [Validation(Required=false)]
        public string AgentPlatform { get; set; }

        /// <summary>
        /// <para>Agent provider name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OpenClaw</para>
        /// </summary>
        [NameInMap("AgentProvider")]
        [Validation(Required=false)]
        public string AgentProvider { get; set; }

        /// <summary>
        /// <para>Business type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public int? BizType { get; set; }

        /// <summary>
        /// <para>Model provider configuration JSON, containing connection information such as baseUrl, apiKey, and api. The apiKey is encrypted after creation. Not required when ProviderType is WuyingCredit, as it is copied from the system template.</para>
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
        /// <para>Model provider template description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>阿里云百炼服务商</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Whether to enable Wuying security proxy. Must be true when ProviderType is WuyingCredit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableWuyingProxy")]
        [Validation(Required=false)]
        public bool? EnableWuyingProxy { get; set; }

        /// <summary>
        /// <para>Associated model group ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mt-xxxx</para>
        /// </summary>
        [NameInMap("ModelTemplateId")]
        [Validation(Required=false)]
        public string ModelTemplateId { get; set; }

        /// <summary>
        /// <para>Model provider template name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>阿里云百炼</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Model provider name. Must be unique within the same model template. Naming rules vary by ProviderType. For details, see the ProviderType description.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bailian</para>
        /// </summary>
        [NameInMap("ProviderName")]
        [Validation(Required=false)]
        public string ProviderName { get; set; }

        /// <summary>
        /// <para>Model provider type. Different types impose different constraints on ProviderName and Config:</para>
        /// <list type="bullet">
        /// <item><description>WuyingCredit: Wuying credit package. ProviderName must be wuying-credit. Created by copying from the system template. Config is not required.</description></item>
        /// <item><description>Managed: Managed provider. System-reserved names such as wuying-credit cannot be used. Config is required.</description></item>
        /// <item><description>Custom: User-defined provider. ProviderName must start with the provider- prefix. Config is required.</description></item>
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
