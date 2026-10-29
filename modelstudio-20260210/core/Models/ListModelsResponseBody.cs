// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ModelStudio20260210.Models
{
    public class ListModelsResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code. This field is empty when the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The error message. This field is empty when the call is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The specified parameter is invalid</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public long? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The maximum number of records returned per request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The list of models.</para>
        /// </summary>
        [NameInMap("models")]
        [Validation(Required=false)]
        public List<ListModelsResponseBodyModels> Models { get; set; }
        public class ListModelsResponseBodyModels : TeaModel {
            /// <summary>
            /// <para>The model type.</para>
            /// </summary>
            [NameInMap("capabilities")]
            [Validation(Required=false)]
            public List<string> Capabilities { get; set; }

            /// <summary>
            /// <para>The model description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>provided by qwen</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The list of model capabilities.</para>
            /// </summary>
            [NameInMap("features")]
            [Validation(Required=false)]
            public List<string> Features { get; set; }

            /// <summary>
            /// <para>The modality type.</para>
            /// </summary>
            [NameInMap("inferenceMetadata")]
            [Validation(Required=false)]
            public ListModelsResponseBodyModelsInferenceMetadata InferenceMetadata { get; set; }
            public class ListModelsResponseBodyModelsInferenceMetadata : TeaModel {
                /// <summary>
                /// <para>The input modality. Valid values: Text, Image, Audio, and Video.</para>
                /// </summary>
                [NameInMap("requestModality")]
                [Validation(Required=false)]
                public List<string> RequestModality { get; set; }

                /// <summary>
                /// <para>The output modality. Valid values: Text, Image, Audio, and Video.</para>
                /// </summary>
                [NameInMap("responseModality")]
                [Validation(Required=false)]
                public List<string> ResponseModality { get; set; }

            }

            /// <summary>
            /// <para>The model name for exact match.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen-plus</para>
            /// </summary>
            [NameInMap("model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            /// <summary>
            /// <para>The model information, including various context lengths.</para>
            /// </summary>
            [NameInMap("modelInfo")]
            [Validation(Required=false)]
            public ListModelsResponseBodyModelsModelInfo ModelInfo { get; set; }
            public class ListModelsResponseBodyModelsModelInfo : TeaModel {
                /// <summary>
                /// <para>The context length.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("contextWindow")]
                [Validation(Required=false)]
                public long? ContextWindow { get; set; }

                /// <summary>
                /// <para>The maximum input length.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("maxInputTokens")]
                [Validation(Required=false)]
                public long? MaxInputTokens { get; set; }

                /// <summary>
                /// <para>The maximum output length.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("maxOutputTokens")]
                [Validation(Required=false)]
                public long? MaxOutputTokens { get; set; }

                /// <summary>
                /// <para>The maximum chain-of-thought length.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("maxReasoningTokens")]
                [Validation(Required=false)]
                public long? MaxReasoningTokens { get; set; }

                /// <summary>
                /// <para>The maximum input length in thinking mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("reasoningMaxInputTokens")]
                [Validation(Required=false)]
                public long? ReasoningMaxInputTokens { get; set; }

                /// <summary>
                /// <para>The maximum output length in thinking mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("reasoningMaxOutputTokens")]
                [Validation(Required=false)]
                public long? ReasoningMaxOutputTokens { get; set; }

            }

            /// <summary>
            /// <para>The model name for fuzzy match.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen-plus</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The list of model pricing.</para>
            /// </summary>
            [NameInMap("prices")]
            [Validation(Required=false)]
            public List<ListModelsResponseBodyModelsPrices> Prices { get; set; }
            public class ListModelsResponseBodyModelsPrices : TeaModel {
                /// <summary>
                /// <para>The model pricing.</para>
                /// </summary>
                [NameInMap("prices")]
                [Validation(Required=false)]
                public List<ListModelsResponseBodyModelsPricesPrices> Prices { get; set; }
                public class ListModelsResponseBodyModelsPricesPrices : TeaModel {
                    /// <summary>
                    /// <para>The price. The currency unit depends on the account type: ￥ for accounts in the Chinese mainland and $ for international accounts.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12</para>
                    /// </summary>
                    [NameInMap("price")]
                    [Validation(Required=false)]
                    public string Price { get; set; }

                    /// <summary>
                    /// <para>The price type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>input</para>
                    /// </summary>
                    [NameInMap("priceName")]
                    [Validation(Required=false)]
                    public string PriceName { get; set; }

                    /// <summary>
                    /// <para>The billing method.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Per 1M tokens</para>
                    /// </summary>
                    [NameInMap("priceUnit")]
                    [Validation(Required=false)]
                    public string PriceUnit { get; set; }

                    /// <summary>
                    /// <para>The time band. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>peak: Peak hours.</description></item>
                    /// <item><description>offpeak: Off-peak hours.</description></item>
                    /// <item><description>standard: No time-based tiering.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>standard</para>
                    /// </summary>
                    [NameInMap("timeBand")]
                    [Validation(Required=false)]
                    public string TimeBand { get; set; }

                }

                /// <summary>
                /// <para>The tier name. If tiered pricing is not used, the value is Default.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Default</para>
                /// </summary>
                [NameInMap("rangeName")]
                [Validation(Required=false)]
                public string RangeName { get; set; }

            }

            /// <summary>
            /// <para>The model provider.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen</para>
            /// </summary>
            [NameInMap("provider")]
            [Validation(Required=false)]
            public string Provider { get; set; }

            /// <summary>
            /// <para>The release time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1779268196000</para>
            /// </summary>
            [NameInMap("publishedTime")]
            [Validation(Required=false)]
            public long? PublishedTime { get; set; }

        }

        /// <summary>
        /// <para>The token for the next request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lwytFRtLdNk=</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The unique identifier of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>36045E0A-551D-592D-B1BC-4C56596CE59E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the API call was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
