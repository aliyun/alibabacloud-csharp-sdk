// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetLogicalModelResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code. Ok is returned upon success, and a specific business error code is returned upon failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The business result returned by the logical model operation.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetLogicalModelResponseBodyData Data { get; set; }
        public class GetLogicalModelResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The intersection of supported paths for all primary targets.</para>
            /// </summary>
            [NameInMap("availablePaths")]
            [Validation(Required=false)]
            public List<GetLogicalModelResponseBodyDataAvailablePaths> AvailablePaths { get; set; }
            public class GetLogicalModelResponseBodyDataAvailablePaths : TeaModel {
                /// <summary>
                /// <para>The call path of the model.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/v1/chat/completions</para>
                /// </summary>
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <para>The protocol type used by the call path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OpenAI/v1</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The call strategy. For the new version of Auto, valid values are balanced, cheap, fast, and quality. For legacy configurations, this field can be omitted and the base name remains balanced. This field is omitted for Mapping and Weighted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>balanced</para>
            /// </summary>
            [NameInMap("callStrategy")]
            [Validation(Required=false)]
            public string CallStrategy { get; set; }

            /// <summary>
            /// <para>The deployment. Saving the intent corresponds to independent configuration delivery. Acceptance does not indicate that the configuration has taken effect.</para>
            /// </summary>
            [NameInMap("deployment")]
            [Validation(Required=false)]
            public GetLogicalModelResponseBodyDataDeployment Deployment { get; set; }
            public class GetLogicalModelResponseBodyDataDeployment : TeaModel {
                /// <summary>
                /// <para>The ID of the current shared configuration delivery.</para>
                /// 
                /// <b>Example:</b>
                /// <para>op-d00000000000000000000</para>
                /// </summary>
                [NameInMap("operationId")]
                [Validation(Required=false)]
                public string OperationId { get; set; }

                /// <summary>
                /// <para>The object configuration version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("revision")]
                [Validation(Required=false)]
                public long? Revision { get; set; }

                /// <summary>
                /// <para>The deployment status. Valid values: Pending, Running, Succeeded, PartiallyFailed, and Failed. This is not the API release status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Succeeded</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The ordered fallback targets. A maximum of 5 targets are supported. They are deduplicated by the actual card ID and can be an empty array.</para>
            /// </summary>
            [NameInMap("fallbackTargets")]
            [Validation(Required=false)]
            public List<GetLogicalModelResponseBodyDataFallbackTargets> FallbackTargets { get; set; }
            public class GetLogicalModelResponseBodyDataFallbackTargets : TeaModel {
                /// <summary>
                /// <para>The ID of the actual source card in the same instance.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>msc-d00000000000000000000</para>
                /// </summary>
                [NameInMap("modelCardId")]
                [Validation(Required=false)]
                public string ModelCardId { get; set; }

            }

            /// <summary>
            /// <para>The intersection of boolean features for the primary targets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;nativeStreaming&quot;:true}</para>
            /// </summary>
            [NameInMap("features")]
            [Validation(Required=false)]
            public Dictionary<string, object> Features { get; set; }

            /// <summary>
            /// <para>The ID of the instance to which the logical model belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gw-d00000000000000000000</para>
            /// </summary>
            [NameInMap("gatewayId")]
            [Validation(Required=false)]
            public string GatewayId { get; set; }

            /// <summary>
            /// <para>The independent logical model ID, which starts with vm-.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vm-d00000000000000000000</para>
            /// </summary>
            [NameInMap("logicalModelId")]
            [Validation(Required=false)]
            public string LogicalModelId { get; set; }

            /// <summary>
            /// <para>The capabilities of the primary targets.</para>
            /// </summary>
            [NameInMap("meta")]
            [Validation(Required=false)]
            public GetLogicalModelResponseBodyDataMeta Meta { get; set; }
            public class GetLogicalModelResponseBodyDataMeta : TeaModel {
                /// <summary>
                /// <para>The maximum number of input tokens. It takes the minimum value when all primary targets are known. Otherwise, it is omitted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>32768</para>
                /// </summary>
                [NameInMap("maxInputTokens")]
                [Validation(Required=false)]
                public long? MaxInputTokens { get; set; }

                /// <summary>
                /// <para>The maximum number of input tokens. It takes the minimum value when all primary targets are known. Otherwise, it is omitted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8192</para>
                /// </summary>
                [NameInMap("maxOutputTokens")]
                [Validation(Required=false)]
                public long? MaxOutputTokens { get; set; }

                /// <summary>
                /// <para>The maximum number of input tokens. It takes the minimum value when all primary targets are known. Otherwise, it is omitted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>40960</para>
                /// </summary>
                [NameInMap("maxTokens")]
                [Validation(Required=false)]
                public long? MaxTokens { get; set; }

                /// <summary>
                /// <para>The intersection of supported input modalities for the primary targets.</para>
                /// </summary>
                [NameInMap("supportedInputModalities")]
                [Validation(Required=false)]
                public List<string> SupportedInputModalities { get; set; }

                /// <summary>
                /// <para>The intersection of supported input modalities for the primary targets.</para>
                /// </summary>
                [NameInMap("supportedOutputModalities")]
                [Validation(Required=false)]
                public List<string> SupportedOutputModalities { get; set; }

            }

            /// <summary>
            /// <para>The client logical call name. It supports up to 256 bytes in UTF-8, cannot contain spaces or slashes, and must not start with auto.</para>
            /// 
            /// <b>Example:</b>
            /// <para>beta-chat</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Specifies whether activation is required. This field is returned only for Auto. It is set to true if the AI Credits Router commodity is not activated, and false if it is activated. It is omitted if the read fails or the status is unknown, or for Mapping and Weighted.</para>
            /// </summary>
            [NameInMap("requiresActivation")]
            [Validation(Required=false)]
            public bool? RequiresActivation { get; set; }

            /// <summary>
            /// <para>The response model. Actual returns the public name of the actual model, and Logical returns the entry name, including SSE.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Actual</para>
            /// </summary>
            [NameInMap("responseModel")]
            [Validation(Required=false)]
            public string ResponseModel { get; set; }

            /// <summary>
            /// <para>The revision number. It is set to 1 upon creation and increments upon each successful update.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("revision")]
            [Validation(Required=false)]
            public long? Revision { get; set; }

            /// <summary>
            /// <para>The routing policy. Valid values: Mapping, Weighted, or Auto. If Auto is selected, targets must be an empty array and slots is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Weighted</para>
            /// </summary>
            [NameInMap("routingPolicy")]
            [Validation(Required=false)]
            public string RoutingPolicy { get; set; }

            /// <summary>
            /// <para>The slots. This field is returned only for Auto. Each of the simple, standard, and complex slots contains 1 to 3 source cards. The three slots are globally deduplicated by modelCardId. This field is omitted for Mapping and Weighted.</para>
            /// </summary>
            [NameInMap("slots")]
            [Validation(Required=false)]
            public GetLogicalModelResponseBodyDataSlots Slots { get; set; }
            public class GetLogicalModelResponseBodyDataSlots : TeaModel {
                /// <summary>
                /// <para>The complex slot, which contains 1 to 3 source cards. The three slots are globally deduplicated by modelCardId.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("complex")]
                [Validation(Required=false)]
                public List<GetLogicalModelResponseBodyDataSlotsComplex> Complex { get; set; }
                public class GetLogicalModelResponseBodyDataSlotsComplex : TeaModel {
                    /// <summary>
                    /// <para>The ID of the actual source card in the same instance, which starts with msc-. VM or service overrides are not supported.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>msc-d00000000000000000000</para>
                    /// </summary>
                    [NameInMap("modelCardId")]
                    [Validation(Required=false)]
                    public string ModelCardId { get; set; }

                }

                /// <summary>
                /// <para>The simple slot, which contains 1 to 3 source cards. The three slots are globally deduplicated by modelCardId.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("simple")]
                [Validation(Required=false)]
                public List<GetLogicalModelResponseBodyDataSlotsSimple> Simple { get; set; }
                public class GetLogicalModelResponseBodyDataSlotsSimple : TeaModel {
                    /// <summary>
                    /// <para>The ID of the actual source card in the same instance, which starts with msc-. VM or service overrides are not supported.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>msc-d00000000000000000000</para>
                    /// </summary>
                    [NameInMap("modelCardId")]
                    [Validation(Required=false)]
                    public string ModelCardId { get; set; }

                }

                /// <summary>
                /// <para>The standard slot, which contains 1 to 3 source cards. The three slots are globally deduplicated by modelCardId.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("standard")]
                [Validation(Required=false)]
                public List<GetLogicalModelResponseBodyDataSlotsStandard> Standard { get; set; }
                public class GetLogicalModelResponseBodyDataSlotsStandard : TeaModel {
                    /// <summary>
                    /// <para>The ID of the actual source card in the same instance, which starts with msc-. VM or service overrides are not supported.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>msc-d00000000000000000000</para>
                    /// </summary>
                    [NameInMap("modelCardId")]
                    [Validation(Required=false)]
                    public string ModelCardId { get; set; }

                }

            }

            /// <summary>
            /// <para>The primary targets. For Mapping, exactly one item is allowed. For Weighted, the sum of original relative weights must be greater than 0. For Auto, it must be an empty array.</para>
            /// </summary>
            [NameInMap("targets")]
            [Validation(Required=false)]
            public List<GetLogicalModelResponseBodyDataTargets> Targets { get; set; }
            public class GetLogicalModelResponseBodyDataTargets : TeaModel {
                /// <summary>
                /// <para>The ID of the actual source model card in the same instance, which starts with msc-. VM or service overrides are not supported.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>msc-d00000000000000000000</para>
                /// </summary>
                [NameInMap("modelCardId")]
                [Validation(Required=false)]
                public string ModelCardId { get; set; }

                /// <summary>
                /// <para>The weight. It is an integer from 0 to 10000 and is saved as the original value. A value of 0 is allowed for Mapping.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

            /// <summary>
            /// <para>The business modification time. Dry runs do not advance this time. The format is ISO 8601 (RFC 3339) in the UTC time zone, such as 2026-11-12T00:00:00Z.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-11-12T00:00:00Z</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The response message that describes the request processing result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID generated by the system to trace the call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
