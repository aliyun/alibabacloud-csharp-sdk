// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class UpdateLogicalModelResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code. Returns Ok on success and a specific business error code on failure.</para>
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
        public UpdateLogicalModelResponseBodyData Data { get; set; }
        public class UpdateLogicalModelResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The intersection of all supported paths for the primary targets.</para>
            /// </summary>
            [NameInMap("availablePaths")]
            [Validation(Required=false)]
            public List<UpdateLogicalModelResponseBodyDataAvailablePaths> AvailablePaths { get; set; }
            public class UpdateLogicalModelResponseBodyDataAvailablePaths : TeaModel {
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
            /// <para>Returned for the new Auto version as balanced, cheap, fast, or quality. Omitted for legacy configurations, where the base name remains balanced. Omitted for Mapping and Weighted configurations.</para>
            /// 
            /// <b>Example:</b>
            /// <para>balanced</para>
            /// </summary>
            [NameInMap("callStrategy")]
            [Validation(Required=false)]
            public string CallStrategy { get; set; }

            /// <summary>
            /// <para>The independent configuration delivery corresponding to the save intent. Acceptance does not indicate that the configuration has taken effect.</para>
            /// </summary>
            [NameInMap("deployment")]
            [Validation(Required=false)]
            public UpdateLogicalModelResponseBodyDataDeployment Deployment { get; set; }
            public class UpdateLogicalModelResponseBodyDataDeployment : TeaModel {
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
                /// <para>The configuration version of the object.</para>
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
            /// <para>The ordered fallback targets. A maximum of 5 targets are supported. The targets are deduplicated by actual card ID. This can be an empty array.</para>
            /// </summary>
            [NameInMap("fallbackTargets")]
            [Validation(Required=false)]
            public List<UpdateLogicalModelResponseBodyDataFallbackTargets> FallbackTargets { get; set; }
            public class UpdateLogicalModelResponseBodyDataFallbackTargets : TeaModel {
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
            /// <para>The intersection of Boolean features for the primary targets.</para>
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
            /// <para>The logical model ID of the independent VM.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vm-d00000000000000000000</para>
            /// </summary>
            [NameInMap("logicalModelId")]
            [Validation(Required=false)]
            public string LogicalModelId { get; set; }

            /// <summary>
            /// <para>The capabilities of the primary target.</para>
            /// </summary>
            [NameInMap("meta")]
            [Validation(Required=false)]
            public UpdateLogicalModelResponseBodyDataMeta Meta { get; set; }
            public class UpdateLogicalModelResponseBodyDataMeta : TeaModel {
                /// <summary>
                /// <para>The minimum value when all primary targets are known. Otherwise, this field is omitted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>32768</para>
                /// </summary>
                [NameInMap("maxInputTokens")]
                [Validation(Required=false)]
                public long? MaxInputTokens { get; set; }

                /// <summary>
                /// <para>The minimum value when all primary targets are known. Otherwise, this field is omitted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8192</para>
                /// </summary>
                [NameInMap("maxOutputTokens")]
                [Validation(Required=false)]
                public long? MaxOutputTokens { get; set; }

                /// <summary>
                /// <para>The minimum value when all primary targets are known. Otherwise, this field is omitted.</para>
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
            /// <para>The client logical call name. It can be up to 256 bytes in UTF-8 encoding, must not contain spaces or slashes, and must not start with auto.</para>
            /// 
            /// <b>Example:</b>
            /// <para>beta-chat</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Returned only for Auto. Set to true if the AI Credits Router commodity is not activated, and false if it is activated. Omitted if the read fails or the status is unknown. Omitted for Mapping and Weighted configurations.</para>
            /// </summary>
            [NameInMap("requiresActivation")]
            [Validation(Required=false)]
            public bool? RequiresActivation { get; set; }

            /// <summary>
            /// <para>The response model. Actual returns the public name of the actual model, and Logical returns the entry name, including Server-Sent Events (SSE).</para>
            /// 
            /// <b>Example:</b>
            /// <para>Actual</para>
            /// </summary>
            [NameInMap("responseModel")]
            [Validation(Required=false)]
            public string ResponseModel { get; set; }

            /// <summary>
            /// <para>The revision number. Initialized to 1 upon creation and incremented upon each successful update.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("revision")]
            [Validation(Required=false)]
            public long? Revision { get; set; }

            /// <summary>
            /// <para>The routing policy. Valid values: Mapping, Weighted, and Auto. If you set this parameter to Auto, targets must be an empty array and slots is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Weighted</para>
            /// </summary>
            [NameInMap("routingPolicy")]
            [Validation(Required=false)]
            public string RoutingPolicy { get; set; }

            /// <summary>
            /// <para>Returned only for Auto. Includes 1 to 3 source cards for simple, standard, or complex configurations. The three slots are globally deduplicated by modelCardId. Omitted for Mapping and Weighted configurations.</para>
            /// </summary>
            [NameInMap("slots")]
            [Validation(Required=false)]
            public UpdateLogicalModelResponseBodyDataSlots Slots { get; set; }
            public class UpdateLogicalModelResponseBodyDataSlots : TeaModel {
                /// <summary>
                /// <para>The complex slot. It requires 1 to 3 source cards. The three slots are globally deduplicated by modelCardId.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("complex")]
                [Validation(Required=false)]
                public List<UpdateLogicalModelResponseBodyDataSlotsComplex> Complex { get; set; }
                public class UpdateLogicalModelResponseBodyDataSlotsComplex : TeaModel {
                    /// <summary>
                    /// <para>The ID of the actual source card in the same instance. The ID starts with msc-. Virtual machines or service overrides are not supported.</para>
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
                /// <para>The simple slot. It requires 1 to 3 source cards. The three slots are globally deduplicated by modelCardId.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("simple")]
                [Validation(Required=false)]
                public List<UpdateLogicalModelResponseBodyDataSlotsSimple> Simple { get; set; }
                public class UpdateLogicalModelResponseBodyDataSlotsSimple : TeaModel {
                    /// <summary>
                    /// <para>The ID of the actual source card in the same instance. The ID starts with msc-. Virtual machines or service overrides are not supported.</para>
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
                /// <para>The standard slot. It requires 1 to 3 source cards. The three slots are globally deduplicated by modelCardId.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("standard")]
                [Validation(Required=false)]
                public List<UpdateLogicalModelResponseBodyDataSlotsStandard> Standard { get; set; }
                public class UpdateLogicalModelResponseBodyDataSlotsStandard : TeaModel {
                    /// <summary>
                    /// <para>The ID of the actual source card in the same instance. The ID starts with msc-. Virtual machines or service overrides are not supported.</para>
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
            /// <para>The primary targets. For Mapping, exactly one item is allowed. For Weighted, the sum of original relative weights must be greater than 0. For Auto, this must be an empty array.</para>
            /// </summary>
            [NameInMap("targets")]
            [Validation(Required=false)]
            public List<UpdateLogicalModelResponseBodyDataTargets> Targets { get; set; }
            public class UpdateLogicalModelResponseBodyDataTargets : TeaModel {
                /// <summary>
                /// <para>The ID of the actual source model card in the same instance. The ID starts with msc-. Virtual machines or service overrides are not supported.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>msc-d00000000000000000000</para>
                /// </summary>
                [NameInMap("modelCardId")]
                [Validation(Required=false)]
                public string ModelCardId { get; set; }

                /// <summary>
                /// <para>The weight. Valid values: integers from 0 to 10000. The original value is saved. For Mapping, 0 is allowed.</para>
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
            /// <para>The business modification time. Dry runs do not advance this time. The time is formatted in ISO 8601 (RFC 3339) in the UTC time zone, such as 2026-11-12T00:00:00Z.</para>
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
