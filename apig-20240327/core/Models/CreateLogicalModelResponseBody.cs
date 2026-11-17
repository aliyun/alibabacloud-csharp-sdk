// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreateLogicalModelResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code. Returns Ok upon success or a specific business error code upon failure.</para>
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
        public CreateLogicalModelResponseBodyData Data { get; set; }
        public class CreateLogicalModelResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The intersection of all supported paths for the primary targets.</para>
            /// </summary>
            [NameInMap("availablePaths")]
            [Validation(Required=false)]
            public List<CreateLogicalModelResponseBodyDataAvailablePaths> AvailablePaths { get; set; }
            public class CreateLogicalModelResponseBodyDataAvailablePaths : TeaModel {
                /// <summary>
                /// <para>The invocation path of the model.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/v1/chat/completions</para>
                /// </summary>
                [NameInMap("path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <para>The protocol type used by the invocation path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>OpenAI/v1</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The call strategy returned in the new Auto mode. Valid values: balanced, cheap, fast, and quality. Omitted for legacy configurations, where the base name remains balanced. Omitted in Mapping or Weighted modes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>balanced</para>
            /// </summary>
            [NameInMap("callStrategy")]
            [Validation(Required=false)]
            public string CallStrategy { get; set; }

            /// <summary>
            /// <para>The deployment of the independent configuration corresponding to the save intent. Acceptance does not indicate that the configuration has taken effect.</para>
            /// </summary>
            [NameInMap("deployment")]
            [Validation(Required=false)]
            public CreateLogicalModelResponseBodyDataDeployment Deployment { get; set; }
            public class CreateLogicalModelResponseBodyDataDeployment : TeaModel {
                /// <summary>
                /// <para>The ID of the current shared configuration deployment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>op-d00000000000000000000</para>
                /// </summary>
                [NameInMap("operationId")]
                [Validation(Required=false)]
                public string OperationId { get; set; }

                /// <summary>
                /// <para>The version of the object configuration.</para>
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
            /// <para>An ordered list of up to 5 fallback targets. The targets are deduplicated by actual card ID and can be an empty array.</para>
            /// </summary>
            [NameInMap("fallbackTargets")]
            [Validation(Required=false)]
            public List<CreateLogicalModelResponseBodyDataFallbackTargets> FallbackTargets { get; set; }
            public class CreateLogicalModelResponseBodyDataFallbackTargets : TeaModel {
                /// <summary>
                /// <para>The actual source card ID within the same instance.</para>
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
            /// <para>The associated instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>gw-d00000000000000000000</para>
            /// </summary>
            [NameInMap("gatewayId")]
            [Validation(Required=false)]
            public string GatewayId { get; set; }

            /// <summary>
            /// <para>The ID of the logical model for the dedicated VM.</para>
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
            public CreateLogicalModelResponseBodyDataMeta Meta { get; set; }
            public class CreateLogicalModelResponseBodyDataMeta : TeaModel {
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
            /// <para>The client logical call name. It can be up to 256 bytes in UTF-8, must not contain spaces or slashes, and must not start with auto.</para>
            /// 
            /// <b>Example:</b>
            /// <para>beta-chat</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Specifies whether activation is required. Returned only in Auto mode. Set to true if the AI Credits Router product is not activated, and false if it is activated. Omitted if the read fails, the status is unknown, or the mode is Mapping or Weighted.</para>
            /// </summary>
            [NameInMap("requiresActivation")]
            [Validation(Required=false)]
            public bool? RequiresActivation { get; set; }

            /// <summary>
            /// <para>If set to Actual, the public name of the actual model is returned. If set to Logical, the entry name is returned, including SSE.</para>
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
            /// <para>The routing policy. Valid values: Mapping, Weighted, and Auto. When set to Auto, targets must be an empty array and slots is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Weighted</para>
            /// </summary>
            [NameInMap("routingPolicy")]
            [Validation(Required=false)]
            public string RoutingPolicy { get; set; }

            /// <summary>
            /// <para>The slots returned only in Auto mode. Includes 1 to 3 source cards for simple, standard, or complex types, globally deduplicated across the three slots by modelCardId. Omitted in Mapping or Weighted modes.</para>
            /// </summary>
            [NameInMap("slots")]
            [Validation(Required=false)]
            public CreateLogicalModelResponseBodyDataSlots Slots { get; set; }
            public class CreateLogicalModelResponseBodyDataSlots : TeaModel {
                /// <summary>
                /// <para>The complex slot requires 1 to 3 source cards. The three slots are globally deduplicated by modelCardId.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("complex")]
                [Validation(Required=false)]
                public List<CreateLogicalModelResponseBodyDataSlotsComplex> Complex { get; set; }
                public class CreateLogicalModelResponseBodyDataSlotsComplex : TeaModel {
                    /// <summary>
                    /// <para>The actual source card ID within the same instance, which starts with msc-. VM or service overrides are not supported.</para>
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
                /// <para>The simple slot requires 1 to 3 source cards. The three slots are globally deduplicated by modelCardId.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("simple")]
                [Validation(Required=false)]
                public List<CreateLogicalModelResponseBodyDataSlotsSimple> Simple { get; set; }
                public class CreateLogicalModelResponseBodyDataSlotsSimple : TeaModel {
                    /// <summary>
                    /// <para>The actual source card ID within the same instance, which starts with msc-. VM or service overrides are not supported.</para>
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
                /// <para>The standard slot requires 1 to 3 source cards. The three slots are globally deduplicated by modelCardId.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("standard")]
                [Validation(Required=false)]
                public List<CreateLogicalModelResponseBodyDataSlotsStandard> Standard { get; set; }
                public class CreateLogicalModelResponseBodyDataSlotsStandard : TeaModel {
                    /// <summary>
                    /// <para>The actual source card ID within the same instance, which starts with msc-. VM or service overrides are not supported.</para>
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
            /// <para>The primary targets. For Mapping, exactly one item is required. For Weighted, the sum of the original relative weights must be greater than 0. For Auto, this must be an empty array.</para>
            /// </summary>
            [NameInMap("targets")]
            [Validation(Required=false)]
            public List<CreateLogicalModelResponseBodyDataTargets> Targets { get; set; }
            public class CreateLogicalModelResponseBodyDataTargets : TeaModel {
                /// <summary>
                /// <para>The actual source model card ID within the same instance, which starts with msc-. VM or service overrides are not supported.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>msc-d00000000000000000000</para>
                /// </summary>
                [NameInMap("modelCardId")]
                [Validation(Required=false)]
                public string ModelCardId { get; set; }

                /// <summary>
                /// <para>An integer from 0 to 10000, saved as the original value. A value of 0 is allowed for Mapping.</para>
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
            /// <para>The time when the business was modified. Dry runs do not update this time. The time is formatted in ISO 8601 (RFC 3339) in the UTC time zone, such as 2026-11-12T00:00:00Z.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-11-12T00:00:00Z</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The response message that describes the result of the request.</para>
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
