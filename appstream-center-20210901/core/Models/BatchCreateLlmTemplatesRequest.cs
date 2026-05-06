// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class BatchCreateLlmTemplatesRequest : TeaModel {
        [NameInMap("LlmTemplateItems")]
        [Validation(Required=false)]
        public List<BatchCreateLlmTemplatesRequestLlmTemplateItems> LlmTemplateItems { get; set; }
        public class BatchCreateLlmTemplatesRequestLlmTemplateItems : TeaModel {
            /// <summary>
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

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsDefaultModel")]
            [Validation(Required=false)]
            public bool? IsDefaultModel { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>qwen3.6-plus</para>
            /// </summary>
            [NameInMap("LlmCode")]
            [Validation(Required=false)]
            public string LlmCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Qwen3.6-Plus</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>mt-xxxx</para>
        /// </summary>
        [NameInMap("ModelTemplateId")]
        [Validation(Required=false)]
        public string ModelTemplateId { get; set; }

        /// <summary>
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
