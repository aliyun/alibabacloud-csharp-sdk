// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ModelStudio20260210.Models
{
    public class ListModelsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>The specified parameter is invalid</para>
        /// </summary>
        [NameInMap("errorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public long? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("maxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        [NameInMap("models")]
        [Validation(Required=false)]
        public List<ListModelsResponseBodyModels> Models { get; set; }
        public class ListModelsResponseBodyModels : TeaModel {
            [NameInMap("capabilities")]
            [Validation(Required=false)]
            public List<string> Capabilities { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>provided by qwen</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("features")]
            [Validation(Required=false)]
            public List<string> Features { get; set; }

            [NameInMap("inferenceMetadata")]
            [Validation(Required=false)]
            public ListModelsResponseBodyModelsInferenceMetadata InferenceMetadata { get; set; }
            public class ListModelsResponseBodyModelsInferenceMetadata : TeaModel {
                [NameInMap("requestModality")]
                [Validation(Required=false)]
                public List<string> RequestModality { get; set; }

                [NameInMap("responseModality")]
                [Validation(Required=false)]
                public List<string> ResponseModality { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>qwen-plus</para>
            /// </summary>
            [NameInMap("model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            [NameInMap("modelInfo")]
            [Validation(Required=false)]
            public ListModelsResponseBodyModelsModelInfo ModelInfo { get; set; }
            public class ListModelsResponseBodyModelsModelInfo : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("contextWindow")]
                [Validation(Required=false)]
                public long? ContextWindow { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("maxInputTokens")]
                [Validation(Required=false)]
                public long? MaxInputTokens { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("maxOutputTokens")]
                [Validation(Required=false)]
                public long? MaxOutputTokens { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("maxReasoningTokens")]
                [Validation(Required=false)]
                public long? MaxReasoningTokens { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("reasoningMaxInputTokens")]
                [Validation(Required=false)]
                public long? ReasoningMaxInputTokens { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("reasoningMaxOutputTokens")]
                [Validation(Required=false)]
                public long? ReasoningMaxOutputTokens { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>qwen-plus</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("prices")]
            [Validation(Required=false)]
            public List<ListModelsResponseBodyModelsPrices> Prices { get; set; }
            public class ListModelsResponseBodyModelsPrices : TeaModel {
                [NameInMap("prices")]
                [Validation(Required=false)]
                public List<ListModelsResponseBodyModelsPricesPrices> Prices { get; set; }
                public class ListModelsResponseBodyModelsPricesPrices : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>12</para>
                    /// </summary>
                    [NameInMap("price")]
                    [Validation(Required=false)]
                    public string Price { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>input</para>
                    /// </summary>
                    [NameInMap("priceName")]
                    [Validation(Required=false)]
                    public string PriceName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Per 1M tokens</para>
                    /// </summary>
                    [NameInMap("priceUnit")]
                    [Validation(Required=false)]
                    public string PriceUnit { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Default</para>
                /// </summary>
                [NameInMap("rangeName")]
                [Validation(Required=false)]
                public string RangeName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>qwen</para>
            /// </summary>
            [NameInMap("provider")]
            [Validation(Required=false)]
            public string Provider { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1779268196000</para>
            /// </summary>
            [NameInMap("publishedTime")]
            [Validation(Required=false)]
            public long? PublishedTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>lwytFRtLdNk=</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>36045E0A-551D-592D-B1BC-4C56596CE59E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
