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
            /// <para>The credit consumption multiplier (rate). A null value indicates that the model does not participate in credit-based billing.</para>
            /// </summary>
            [NameInMap("CreditMultiplier")]
            [Validation(Required=false)]
            public ListLlmTemplatesResponseBodyDataCreditMultiplier CreditMultiplier { get; set; }
            public class ListLlmTemplatesResponseBodyDataCreditMultiplier : TeaModel {
                /// <summary>
                /// <para>The maximum multiplier. A null value indicates no upper limit. For example, Min=1 with Max as null is displayed as 1x and above.</para>
                /// </summary>
                [NameInMap("Max")]
                [Validation(Required=false)]
                public float? Max { get; set; }

                /// <summary>
                /// <para>The minimum multiplier. When equal to Max, it represents a fixed multiplier. For example, Min=Max=2 is displayed as 2x.</para>
                /// </summary>
                [NameInMap("Min")]
                [Validation(Required=false)]
                public float? Min { get; set; }

            }

            /// <summary>
            /// <para>The template description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Qwen Plus series models</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The list of model features, such as function-calling, web-search, and structured-outputs.</para>
            /// </summary>
            [NameInMap("Features")]
            [Validation(Required=false)]
            public List<string> Features { get; set; }

            /// <summary>
            /// <para>The inference metadata, including request and response modalities.</para>
            /// </summary>
            [NameInMap("InferenceMetadata")]
            [Validation(Required=false)]
            public ListLlmTemplatesResponseBodyDataInferenceMetadata InferenceMetadata { get; set; }
            public class ListLlmTemplatesResponseBodyDataInferenceMetadata : TeaModel {
                /// <summary>
                /// <para>The list of request modalities, such as Text, Image, and Audio.</para>
                /// </summary>
                [NameInMap("RequestModality")]
                [Validation(Required=false)]
                public List<string> RequestModality { get; set; }

                /// <summary>
                /// <para>The list of response modalities, such as Text, Image, and Audio.</para>
                /// </summary>
                [NameInMap("ResponseModality")]
                [Validation(Required=false)]
                public List<string> ResponseModality { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether this is the default model under the associated model group.</para>
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
            /// <para>The model information, including context window size and maximum input/output tokens.</para>
            /// </summary>
            [NameInMap("ModelInfo")]
            [Validation(Required=false)]
            public Dictionary<string, object> ModelInfo { get; set; }

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
            /// <para>The list of price information.</para>
            /// </summary>
            [NameInMap("Prices")]
            [Validation(Required=false)]
            public List<ListLlmTemplatesResponseBodyDataPrices> Prices { get; set; }
            public class ListLlmTemplatesResponseBodyDataPrices : TeaModel {
                /// <summary>
                /// <para>The list of prices within the range.</para>
                /// </summary>
                [NameInMap("Prices")]
                [Validation(Required=false)]
                public List<ListLlmTemplatesResponseBodyDataPricesPrices> Prices { get; set; }
                public class ListLlmTemplatesResponseBodyDataPricesPrices : TeaModel {
                    /// <summary>
                    /// <para>The price in string format, such as 0.2.</para>
                    /// </summary>
                    [NameInMap("Price")]
                    [Validation(Required=false)]
                    public string Price { get; set; }

                    /// <summary>
                    /// <para>The price name, such as Input, Output, or Image Generation.</para>
                    /// </summary>
                    [NameInMap("PriceName")]
                    [Validation(Required=false)]
                    public string PriceName { get; set; }

                    /// <summary>
                    /// <para>The price unit, such as per image or per thousand tokens.</para>
                    /// </summary>
                    [NameInMap("PriceUnit")]
                    [Validation(Required=false)]
                    public string PriceUnit { get; set; }

                }

                /// <summary>
                /// <para>The range name, such as Default or 0-1M tokens.</para>
                /// </summary>
                [NameInMap("RangeName")]
                [Validation(Required=false)]
                public string RangeName { get; set; }

            }

            /// <summary>
            /// <para>The ID of the model provider template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mpt-xxxx</para>
            /// </summary>
            [NameInMap("ProviderTemplateId")]
            [Validation(Required=false)]
            public string ProviderTemplateId { get; set; }

            /// <summary>
            /// <para>The publish time in ISO 8601 format, such as 2026-03-04T06:25:17.000+00:00.</para>
            /// </summary>
            [NameInMap("PublishedTime")]
            [Validation(Required=false)]
            public string PublishedTime { get; set; }

            /// <summary>
            /// <para>The authorization scope of the associated model group. Valid values: ALL_USER (all users), USER_MIXED (specified users and user groups), RESOURCE_MIXED (specified resources). Returned only when SmartModel is set to true.</para>
            /// </summary>
            [NameInMap("RefScope")]
            [Validation(Required=false)]
            public string RefScope { get; set; }

            /// <summary>
            /// <para>The number of route policies configured under this model tier. Returned only when SmartModel is set to true. Returns 0 for tiers without configured policies.</para>
            /// </summary>
            [NameInMap("RoutePolicyCount")]
            [Validation(Required=false)]
            public int? RoutePolicyCount { get; set; }

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
        /// <para>The number of query results per page.</para>
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
        /// <para>The total number of query results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
