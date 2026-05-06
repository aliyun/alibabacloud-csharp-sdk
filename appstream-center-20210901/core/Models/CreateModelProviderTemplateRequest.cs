// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class CreateModelProviderTemplateRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ENTERPRISE</para>
        /// </summary>
        [NameInMap("AgentPlatform")]
        [Validation(Required=false)]
        public string AgentPlatform { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OpenClaw</para>
        /// </summary>
        [NameInMap("AgentProvider")]
        [Validation(Required=false)]
        public string AgentProvider { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public int? BizType { get; set; }

        /// <summary>
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

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableWuyingProxy")]
        [Validation(Required=false)]
        public bool? EnableWuyingProxy { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mt-xxxx</para>
        /// </summary>
        [NameInMap("ModelTemplateId")]
        [Validation(Required=false)]
        public string ModelTemplateId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bailian</para>
        /// </summary>
        [NameInMap("ProviderName")]
        [Validation(Required=false)]
        public string ProviderName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Managed</para>
        /// </summary>
        [NameInMap("ProviderType")]
        [Validation(Required=false)]
        public string ProviderType { get; set; }

    }

}
