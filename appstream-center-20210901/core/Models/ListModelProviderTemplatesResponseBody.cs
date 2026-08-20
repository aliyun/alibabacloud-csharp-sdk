// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListModelProviderTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of returned data objects.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListModelProviderTemplatesResponseBodyData> Data { get; set; }
        public class ListModelProviderTemplatesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The model provider configuration JSON object.</para>
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
            /// <para>The model provider template description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alibaba Cloud Bailian provider</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Indicates whether the WUYING secure gateway proxy is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableWuyingProxy")]
            [Validation(Required=false)]
            public bool? EnableWuyingProxy { get; set; }

            /// <summary>
            /// <para>The model provider template name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alibaba Cloud Bailian</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The model provider name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>bailian</para>
            /// </summary>
            [NameInMap("ProviderName")]
            [Validation(Required=false)]
            public string ProviderName { get; set; }

            /// <summary>
            /// <para>The model provider template ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mpt-xxxx</para>
            /// </summary>
            [NameInMap("ProviderTemplateId")]
            [Validation(Required=false)]
            public string ProviderTemplateId { get; set; }

            /// <summary>
            /// <para>The model provider type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WuyingCredit</para>
            /// </summary>
            [NameInMap("ProviderType")]
            [Validation(Required=false)]
            public string ProviderType { get; set; }

            /// <summary>
            /// <para>The WUYING secure gateway proxy ProviderKey.</para>
            /// 
            /// <b>Example:</b>
            /// <para>wuying-key-12345</para>
            /// </summary>
            [NameInMap("WuyingProviderKey")]
            [Validation(Required=false)]
            public string WuyingProviderKey { get; set; }

        }

        /// <summary>
        /// <para>The current page number of the query results.</para>
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
        /// <para>20</para>
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
        /// <para>The total number of query results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
