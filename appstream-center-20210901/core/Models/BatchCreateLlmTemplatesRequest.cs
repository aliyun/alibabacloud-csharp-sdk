// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class BatchCreateLlmTemplatesRequest : TeaModel {
        /// <summary>
        /// <para>The list of model configurations to create.</para>
        /// </summary>
        [NameInMap("LlmTemplateItems")]
        [Validation(Required=false)]
        public List<BatchCreateLlmTemplatesRequestLlmTemplateItems> LlmTemplateItems { get; set; }
        public class BatchCreateLlmTemplatesRequestLlmTemplateItems : TeaModel {
            /// <summary>
            /// <para>The model configuration JSON object.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///     &quot;id&quot;: &quot;qwen3.6-plus&quot;,
            ///     &quot;cost&quot;: {
            ///         &quot;input&quot;: 0,
            ///         &quot;output&quot;: 0,
            ///         &quot;cacheRead&quot;: 0,
            ///         &quot;cacheWrite&quot;: 0
            ///     },
            ///     &quot;name&quot;: &quot;Qwen3.6-Plus&quot;,
            ///     &quot;input&quot;: [&quot;image&quot;, &quot;text&quot;],
            ///     &quot;compat&quot;: {
            ///         &quot;supportsUsageInStreaming&quot;: true
            ///     },
            ///     &quot;maxTokens&quot;: 65536,
            ///     &quot;reasoning&quot;: false,
            ///     &quot;contextWindow&quot;: 1000000
            /// }</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// <para>The model description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>千问Plus系列模型</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Specifies whether to set this model as the default model. Each model group can have at most one default model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsDefaultModel")]
            [Validation(Required=false)]
            public bool? IsDefaultModel { get; set; }

            /// <summary>
            /// <para>The model code, which must be unique within the same provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen3.6-plus</para>
            /// </summary>
            [NameInMap("LlmCode")]
            [Validation(Required=false)]
            public string LlmCode { get; set; }

            /// <summary>
            /// <para>The model name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Qwen3.6-Plus</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The ID of the associated model group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mt-xxxx</para>
        /// </summary>
        [NameInMap("ModelTemplateId")]
        [Validation(Required=false)]
        public string ModelTemplateId { get; set; }

        /// <summary>
        /// <para>The ID of the model provider template to which the models belong.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mpt-xxxx</para>
        /// </summary>
        [NameInMap("ProviderTemplateId")]
        [Validation(Required=false)]
        public string ProviderTemplateId { get; set; }

    }

}
