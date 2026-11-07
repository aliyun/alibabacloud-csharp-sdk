// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListModelProviderLlmCodesResponseBody : TeaModel {
        /// <summary>
        /// <para>The paginated data object that contains the list of LLM information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListModelProviderLlmCodesResponseBodyData Data { get; set; }
        public class ListModelProviderLlmCodesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of LLM information.</para>
            /// </summary>
            [NameInMap("LlmInfoList")]
            [Validation(Required=false)]
            public List<ListModelProviderLlmCodesResponseBodyDataLlmInfoList> LlmInfoList { get; set; }
            public class ListModelProviderLlmCodesResponseBodyDataLlmInfoList : TeaModel {
                /// <summary>
                /// <para>The credit consumption multiplier. An empty value indicates that the model does not participate in credit billing.</para>
                /// </summary>
                [NameInMap("CreditMultiplier")]
                [Validation(Required=false)]
                public ListModelProviderLlmCodesResponseBodyDataLlmInfoListCreditMultiplier CreditMultiplier { get; set; }
                public class ListModelProviderLlmCodesResponseBodyDataLlmInfoListCreditMultiplier : TeaModel {
                    /// <summary>
                    /// <para>The upper limit of the multiplier. An empty value indicates no upper limit. For example, if the minimum multiplier is 1 and the maximum multiplier is empty, it is displayed as starting from 1x.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("Max")]
                    [Validation(Required=false)]
                    public float? Max { get; set; }

                    /// <summary>
                    /// <para>The lower limit of the multiplier. If this value is equal to the maximum multiplier, it is a fixed multiplier. For example, if both the minimum and maximum multipliers are 2, it is displayed as 2x.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("Min")]
                    [Validation(Required=false)]
                    public float? Min { get; set; }

                }

                /// <summary>
                /// <para>The model description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Qwen image generation model that supports text-to-image and image editing capabilities</para>
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
                public ListModelProviderLlmCodesResponseBodyDataLlmInfoListInferenceMetadata InferenceMetadata { get; set; }
                public class ListModelProviderLlmCodesResponseBodyDataLlmInfoListInferenceMetadata : TeaModel {
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
                /// <para>The LLM code, such as qwen-image-2.0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>qwen-image-2.0</para>
                /// </summary>
                [NameInMap("LlmCode")]
                [Validation(Required=false)]
                public string LlmCode { get; set; }

                /// <summary>
                /// <para>The model brand, such as Qwen, Wanx, or DeepSeek. This parameter is returned only for models annotated in the platform-side model pool.</para>
                /// 
                /// <b>Example:</b>
                /// <para>qwen</para>
                /// </summary>
                [NameInMap("ModelBrand")]
                [Validation(Required=false)]
                public string ModelBrand { get; set; }

                /// <summary>
                /// <para>The model information, such as the context window size and the maximum number of input/output tokens.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;contextWindow&quot;:1000000,&quot;maxInputTokens&quot;:991808,&quot;maxReasoningTokens&quot;:262144,&quot;reasoningMaxInputTokens&quot;:983616,&quot;maxOutputTokens&quot;:131072,&quot;reasoningMaxOutputTokens&quot;:131072}</para>
                /// </summary>
                [NameInMap("ModelInfo")]
                [Validation(Required=false)]
                public Dictionary<string, object> ModelInfo { get; set; }

                /// <summary>
                /// <para>The model series, such as Qwen-Max or DeepSeek. This parameter is returned only for the wuying-credit provider.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Qwen-Max</para>
                /// </summary>
                [NameInMap("ModelSeries")]
                [Validation(Required=false)]
                public string ModelSeries { get; set; }

                /// <summary>
                /// <para>The model name, such as Qwen-Image-2.0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Qwen-Image-2.0</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The list of price information.</para>
                /// </summary>
                [NameInMap("Prices")]
                [Validation(Required=false)]
                public List<ListModelProviderLlmCodesResponseBodyDataLlmInfoListPrices> Prices { get; set; }
                public class ListModelProviderLlmCodesResponseBodyDataLlmInfoListPrices : TeaModel {
                    /// <summary>
                    /// <para>The list of prices within the range.</para>
                    /// </summary>
                    [NameInMap("Prices")]
                    [Validation(Required=false)]
                    public List<ListModelProviderLlmCodesResponseBodyDataLlmInfoListPricesPrices> Prices { get; set; }
                    public class ListModelProviderLlmCodesResponseBodyDataLlmInfoListPricesPrices : TeaModel {
                        /// <summary>
                        /// <para>The price in string format, such as 0.2.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0.2</para>
                        /// </summary>
                        [NameInMap("Price")]
                        [Validation(Required=false)]
                        public string Price { get; set; }

                        /// <summary>
                        /// <para>The name of the price item, such as input, output, or image generation.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Input</para>
                        /// </summary>
                        [NameInMap("PriceName")]
                        [Validation(Required=false)]
                        public string PriceName { get; set; }

                        /// <summary>
                        /// <para>The price unit, such as per image or per 1,000 tokens.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Per image</para>
                        /// </summary>
                        [NameInMap("PriceUnit")]
                        [Validation(Required=false)]
                        public string PriceUnit { get; set; }

                    }

                    /// <summary>
                    /// <para>The name of the range, such as Default or 0-1M tokens.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Default</para>
                    /// </summary>
                    [NameInMap("RangeName")]
                    [Validation(Required=false)]
                    public string RangeName { get; set; }

                }

                /// <summary>
                /// <para>The time when the model was published, in ISO 8601 format, such as 2026-03-04T06:25:17.000+00:00.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-03-04T06:25:17.000+00:00</para>
                /// </summary>
                [NameInMap("PublishedTime")]
                [Validation(Required=false)]
                public string PublishedTime { get; set; }

                /// <summary>
                /// <para>Indicates whether the model is recommended. Valid values: true (recommended), false (explicitly not recommended), and null (not applicable, such as non-Bailian or unannotated models).</para>
                /// </summary>
                [NameInMap("Recommended")]
                [Validation(Required=false)]
                public bool? Recommended { get; set; }

                /// <summary>
                /// <para>The model risk type. This parameter is returned only when includeRiskInfo is set to true.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("RiskType")]
                [Validation(Required=false)]
                public string RiskType { get; set; }

            }

        }

        /// <summary>
        /// <para>The current page number.</para>
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
        /// <para>The unique ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records after filtering.</para>
        /// 
        /// <b>Example:</b>
        /// <para>128</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
