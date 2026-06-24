// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListLlmTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of returned data objects.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListLlmTemplatesResponseBodyData> Data { get; set; }
        public class ListLlmTemplatesResponseBodyData : TeaModel {
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
            /// <para>The template description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>千问Plus系列模型</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Indicates whether this is the default model in the associated model group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsDefaultModel")]
            [Validation(Required=false)]
            public bool? IsDefaultModel { get; set; }

            /// <summary>
            /// <para>The model code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen3.6-plus</para>
            /// </summary>
            [NameInMap("LlmCode")]
            [Validation(Required=false)]
            public string LlmCode { get; set; }

            /// <summary>
            /// <para>The model template ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>llmt-xxxx</para>
            /// </summary>
            [NameInMap("LlmTemplateId")]
            [Validation(Required=false)]
            public string LlmTemplateId { get; set; }

            /// <summary>
            /// <para>The template name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Qwen3.6-Plus</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the model provider template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mpt-xxxx</para>
            /// </summary>
            [NameInMap("ProviderTemplateId")]
            [Validation(Required=false)]
            public string ProviderTemplateId { get; set; }

        }

        /// <summary>
        /// <para>The page number of the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
