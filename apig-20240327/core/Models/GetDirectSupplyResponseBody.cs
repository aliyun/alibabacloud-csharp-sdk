// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetDirectSupplyResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetDirectSupplyResponseBodyData Data { get; set; }
        public class GetDirectSupplyResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of candidate models that can be added to direct supply.</para>
            /// </summary>
            [NameInMap("candidateModels")]
            [Validation(Required=false)]
            public List<GetDirectSupplyResponseBodyDataCandidateModels> CandidateModels { get; set; }
            public class GetDirectSupplyResponseBodyDataCandidateModels : TeaModel {
                /// <summary>
                /// <para>The list of available invocation paths.</para>
                /// </summary>
                [NameInMap("availablePaths")]
                [Validation(Required=false)]
                public List<GetDirectSupplyResponseBodyDataCandidateModelsAvailablePaths> AvailablePaths { get; set; }
                public class GetDirectSupplyResponseBodyDataCandidateModelsAvailablePaths : TeaModel {
                    /// <summary>
                    /// <para>The invocation path.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/v1/chat/completions</para>
                    /// </summary>
                    [NameInMap("path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// <para>The path type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>type-xxxxxxxx</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The billing information of the model.</para>
                /// </summary>
                [NameInMap("credit")]
                [Validation(Required=false)]
                public GetDirectSupplyResponseBodyDataCandidateModelsCredit Credit { get; set; }
                public class GetDirectSupplyResponseBodyDataCandidateModelsCredit : TeaModel {
                    /// <summary>
                    /// <para>The unit price of cache-hit tokens.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.001</para>
                    /// </summary>
                    [NameInMap("cacheCost")]
                    [Validation(Required=false)]
                    public float? CacheCost { get; set; }

                    /// <summary>
                    /// <para>The unit price of input tokens.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.004</para>
                    /// </summary>
                    [NameInMap("inputCost")]
                    [Validation(Required=false)]
                    public float? InputCost { get; set; }

                    /// <summary>
                    /// <para>The unit price of output tokens.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.012</para>
                    /// </summary>
                    [NameInMap("outputCost")]
                    [Validation(Required=false)]
                    public float? OutputCost { get; set; }

                    /// <summary>
                    /// <para>The billing type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>type-xxxxxxxx</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The capabilities and features supported by the model.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;nativeStreaming&quot;:true}</para>
                /// </summary>
                [NameInMap("features")]
                [Validation(Required=false)]
                public Dictionary<string, object> Features { get; set; }

                /// <summary>
                /// <para>The ID of the gateway instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gw-xxxxxxxx</para>
                /// </summary>
                [NameInMap("gatewayId")]
                [Validation(Required=false)]
                public string GatewayId { get; set; }

                /// <summary>
                /// <para>The capability information of the model.</para>
                /// </summary>
                [NameInMap("meta")]
                [Validation(Required=false)]
                public GetDirectSupplyResponseBodyDataCandidateModelsMeta Meta { get; set; }
                public class GetDirectSupplyResponseBodyDataCandidateModelsMeta : TeaModel {
                    /// <summary>
                    /// <para>The maximum number of input tokens.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>128000</para>
                    /// </summary>
                    [NameInMap("maxInputTokens")]
                    [Validation(Required=false)]
                    public long? MaxInputTokens { get; set; }

                    /// <summary>
                    /// <para>The maximum number of output tokens.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>16384</para>
                    /// </summary>
                    [NameInMap("maxOutputTokens")]
                    [Validation(Required=false)]
                    public long? MaxOutputTokens { get; set; }

                    /// <summary>
                    /// <para>The maximum total number of tokens.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>16384</para>
                    /// </summary>
                    [NameInMap("maxTokens")]
                    [Validation(Required=false)]
                    public long? MaxTokens { get; set; }

                    /// <summary>
                    /// <para>The list of supported input modalities.</para>
                    /// </summary>
                    [NameInMap("supportedInputModalities")]
                    [Validation(Required=false)]
                    public List<string> SupportedInputModalities { get; set; }

                    /// <summary>
                    /// <para>The list of supported output modalities.</para>
                    /// </summary>
                    [NameInMap("supportedOutputModalities")]
                    [Validation(Required=false)]
                    public List<string> SupportedOutputModalities { get; set; }

                }

                /// <summary>
                /// <para>The ID of the model card, which starts with msc-.</para>
                /// 
                /// <b>Example:</b>
                /// <para>msc-xxxxxxxx</para>
                /// </summary>
                [NameInMap("modelCardId")]
                [Validation(Required=false)]
                public string ModelCardId { get; set; }

                /// <summary>
                /// <para>The name of the model.</para>
                /// 
                /// <b>Example:</b>
                /// <para>qwen-max</para>
                /// </summary>
                [NameInMap("modelName")]
                [Validation(Required=false)]
                public string ModelName { get; set; }

                /// <summary>
                /// <para>The model provider.</para>
                /// 
                /// <b>Example:</b>
                /// <para>qwen</para>
                /// </summary>
                [NameInMap("modelProvider")]
                [Validation(Required=false)]
                public string ModelProvider { get; set; }

                /// <summary>
                /// <para>The ID of the model source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>model-source-xxxxxxxx</para>
                /// </summary>
                [NameInMap("modelSourceId")]
                [Validation(Required=false)]
                public string ModelSourceId { get; set; }

                /// <summary>
                /// <para>The source of the model.</para>
                /// 
                /// <b>Example:</b>
                /// <para>source-xxxxxxxx</para>
                /// </summary>
                [NameInMap("source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <para>The last update time in ISO 8601 (RFC 3339) format in the UTC time zone, such as 2026-05-15T10:00:00Z.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-05-15T10:00:00Z</para>
                /// </summary>
                [NameInMap("updateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

            /// <summary>
            /// <para>The error message returned when the model catalog query fails. This parameter is not returned if the query succeeds.</para>
            /// </summary>
            [NameInMap("catalogError")]
            [Validation(Required=false)]
            public GetDirectSupplyResponseBodyDataCatalogError CatalogError { get; set; }
            public class GetDirectSupplyResponseBodyDataCatalogError : TeaModel {
                /// <summary>
                /// <para>The error code.</para>
                /// 
                /// <b>Example:</b>
                /// <para>InvalidParameter</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The error message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Failed to query the model catalog</para>
                /// </summary>
                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The request ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>393E2630-DBE7-5221-AB35-9E740675491A</para>
                /// </summary>
                [NameInMap("requestId")]
                [Validation(Required=false)]
                public string RequestId { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether direct supply is enabled.</para>
            /// </summary>
            [NameInMap("enabled")]
            [Validation(Required=false)]
            public bool? Enabled { get; set; }

            /// <summary>
            /// <para>The ID of the gateway instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gw-xxxxxxxx</para>
            /// </summary>
            [NameInMap("gatewayId")]
            [Validation(Required=false)]
            public string GatewayId { get; set; }

            /// <summary>
            /// <para>The list of models for which direct supply is enabled.</para>
            /// </summary>
            [NameInMap("models")]
            [Validation(Required=false)]
            public List<GetDirectSupplyResponseBodyDataModels> Models { get; set; }
            public class GetDirectSupplyResponseBodyDataModels : TeaModel {
                /// <summary>
                /// <para>The list of available invocation paths.</para>
                /// </summary>
                [NameInMap("availablePaths")]
                [Validation(Required=false)]
                public List<GetDirectSupplyResponseBodyDataModelsAvailablePaths> AvailablePaths { get; set; }
                public class GetDirectSupplyResponseBodyDataModelsAvailablePaths : TeaModel {
                    /// <summary>
                    /// <para>The invocation path.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/v1/chat/completions</para>
                    /// </summary>
                    [NameInMap("path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// <para>The path type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>type-xxxxxxxx</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The billing information of the model.</para>
                /// </summary>
                [NameInMap("credit")]
                [Validation(Required=false)]
                public GetDirectSupplyResponseBodyDataModelsCredit Credit { get; set; }
                public class GetDirectSupplyResponseBodyDataModelsCredit : TeaModel {
                    /// <summary>
                    /// <para>The unit price of cache-hit tokens.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.001</para>
                    /// </summary>
                    [NameInMap("cacheCost")]
                    [Validation(Required=false)]
                    public float? CacheCost { get; set; }

                    /// <summary>
                    /// <para>The unit price of input tokens.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.004</para>
                    /// </summary>
                    [NameInMap("inputCost")]
                    [Validation(Required=false)]
                    public float? InputCost { get; set; }

                    /// <summary>
                    /// <para>The unit price of output tokens.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.012</para>
                    /// </summary>
                    [NameInMap("outputCost")]
                    [Validation(Required=false)]
                    public float? OutputCost { get; set; }

                    /// <summary>
                    /// <para>The billing type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>type-xxxxxxxx</para>
                    /// </summary>
                    [NameInMap("type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

                /// <summary>
                /// <para>The capabilities and features supported by the model.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;nativeStreaming&quot;:true}</para>
                /// </summary>
                [NameInMap("features")]
                [Validation(Required=false)]
                public Dictionary<string, object> Features { get; set; }

                /// <summary>
                /// <para>The ID of the gateway instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gw-xxxxxxxx</para>
                /// </summary>
                [NameInMap("gatewayId")]
                [Validation(Required=false)]
                public string GatewayId { get; set; }

                /// <summary>
                /// <para>The capability information of the model.</para>
                /// </summary>
                [NameInMap("meta")]
                [Validation(Required=false)]
                public GetDirectSupplyResponseBodyDataModelsMeta Meta { get; set; }
                public class GetDirectSupplyResponseBodyDataModelsMeta : TeaModel {
                    /// <summary>
                    /// <para>The maximum number of input tokens.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>128000</para>
                    /// </summary>
                    [NameInMap("maxInputTokens")]
                    [Validation(Required=false)]
                    public long? MaxInputTokens { get; set; }

                    /// <summary>
                    /// <para>The maximum number of output tokens.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>16384</para>
                    /// </summary>
                    [NameInMap("maxOutputTokens")]
                    [Validation(Required=false)]
                    public long? MaxOutputTokens { get; set; }

                    /// <summary>
                    /// <para>The maximum total number of tokens.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>16384</para>
                    /// </summary>
                    [NameInMap("maxTokens")]
                    [Validation(Required=false)]
                    public long? MaxTokens { get; set; }

                    /// <summary>
                    /// <para>The list of supported input modalities.</para>
                    /// </summary>
                    [NameInMap("supportedInputModalities")]
                    [Validation(Required=false)]
                    public List<string> SupportedInputModalities { get; set; }

                    /// <summary>
                    /// <para>The list of supported output modalities.</para>
                    /// </summary>
                    [NameInMap("supportedOutputModalities")]
                    [Validation(Required=false)]
                    public List<string> SupportedOutputModalities { get; set; }

                }

                /// <summary>
                /// <para>The ID of the model card, which starts with msc-.</para>
                /// 
                /// <b>Example:</b>
                /// <para>msc-xxxxxxxx</para>
                /// </summary>
                [NameInMap("modelCardId")]
                [Validation(Required=false)]
                public string ModelCardId { get; set; }

                /// <summary>
                /// <para>The name of the model.</para>
                /// 
                /// <b>Example:</b>
                /// <para>qwen-max</para>
                /// </summary>
                [NameInMap("modelName")]
                [Validation(Required=false)]
                public string ModelName { get; set; }

                /// <summary>
                /// <para>The model provider.</para>
                /// 
                /// <b>Example:</b>
                /// <para>qwen</para>
                /// </summary>
                [NameInMap("modelProvider")]
                [Validation(Required=false)]
                public string ModelProvider { get; set; }

                /// <summary>
                /// <para>The ID of the model source.</para>
                /// 
                /// <b>Example:</b>
                /// <para>model-source-xxxxxxxx</para>
                /// </summary>
                [NameInMap("modelSourceId")]
                [Validation(Required=false)]
                public string ModelSourceId { get; set; }

                /// <summary>
                /// <para>The source of the model.</para>
                /// 
                /// <b>Example:</b>
                /// <para>source-xxxxxxxx</para>
                /// </summary>
                [NameInMap("source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// <para>The last update time in ISO 8601 (RFC 3339) format in the UTC time zone, such as 2026-05-15T10:00:00Z.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-05-15T10:00:00Z</para>
                /// </summary>
                [NameInMap("updateTime")]
                [Validation(Required=false)]
                public string UpdateTime { get; set; }

            }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>393E2630-DBE7-5221-AB35-9E740675491A</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
