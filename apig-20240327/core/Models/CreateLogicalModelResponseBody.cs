// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreateLogicalModelResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code. The value is Ok for a successful request, or a specific business error code for a failed request.</para>
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
            /// <para>For the new version of Auto, the value is balanced, cheap, fast, or quality. For legacy configurations, this field may be omitted and the base name remains balanced. This field is omitted for Mapping and Weighted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>balanced</para>
            /// </summary>
            [NameInMap("callStrategy")]
            [Validation(Required=false)]
            public string CallStrategy { get; set; }

            /// <summary>
            /// <para>The independent configuration delivery that corresponds to the save intent. Acceptance does not mean that the configuration has taken effect.</para>
            /// </summary>
            [NameInMap("deployment")]
            [Validation(Required=false)]
            public CreateLogicalModelResponseBodyDataDeployment Deployment { get; set; }
            public class CreateLogicalModelResponseBodyDataDeployment : TeaModel {
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
                /// <para>The deployment status. Valid values: Pending, Running, Succeeded, PartiallyFailed, and Failed. This is not the API publishing status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Succeeded</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The ordered fallback targets. You can specify up to 5 fallback targets. They are deduplicated by the actual card ID and can be an empty array.</para>
            /// </summary>
            [NameInMap("fallbackTargets")]
            [Validation(Required=false)]
            public List<CreateLogicalModelResponseBodyDataFallbackTargets> FallbackTargets { get; set; }
            public class CreateLogicalModelResponseBodyDataFallbackTargets : TeaModel {
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
            /// <para>The intersection of the boolean features of the primary targets.</para>
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
            /// <para>The logical model ID of the independent virtual machine.</para>
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
                /// <para>The intersection of the supported input modalities of the primary targets.</para>
                /// </summary>
                [NameInMap("supportedInputModalities")]
                [Validation(Required=false)]
                public List<string> SupportedInputModalities { get; set; }

                /// <summary>
                /// <para>The intersection of the supported input modalities of the primary targets.</para>
                /// </summary>
                [NameInMap("supportedOutputModalities")]
                [Validation(Required=false)]
                public List<string> SupportedOutputModalities { get; set; }

            }

            /// <summary>
            /// <para>The client logical call name. The name can be up to 256 bytes in UTF-8 encoding, must not contain spaces or slashes, and must not start with &quot;auto&quot;.</para>
            /// 
            /// <b>Example:</b>
            /// <para>beta-chat</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Returned only for Auto. The value is true if the AI Credits Router commodity is not activated, and false if it is activated. This field is omitted if the read operation fails, the status is unknown, or the type is Mapping or Weighted.</para>
            /// </summary>
            [NameInMap("requiresActivation")]
            [Validation(Required=false)]
            public bool? RequiresActivation { get; set; }

            /// <summary>
            /// <para>The response model. If you set this parameter to Actual, the public name of the actual model is returned. If you set this parameter to Logical, the entry name is returned, including Server-Sent Events (SSE).</para>
            /// 
            /// <b>Example:</b>
            /// <para>Actual</para>
            /// </summary>
            [NameInMap("responseModel")]
            [Validation(Required=false)]
            public string ResponseModel { get; set; }

            /// <summary>
            /// <para>The revision number. The value is 1 upon creation and increments after each successful update.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("revision")]
            [Validation(Required=false)]
            public long? Revision { get; set; }

            /// <summary>
            /// <para>The routing policy. Valid values: Mapping, Weighted, and Auto. If you set this parameter to Auto, the targets parameter must be an empty array and the slots parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Weighted</para>
            /// </summary>
            [NameInMap("routingPolicy")]
            [Validation(Required=false)]
            public string RoutingPolicy { get; set; }

            /// <summary>
            /// <para>Returned only for Auto. This field includes one to three source cards for each of the simple, standard, and complex types. The three slots are globally deduplicated by modelCardId. This field is omitted for Mapping and Weighted.</para>
            /// </summary>
            [NameInMap("slots")]
            [Validation(Required=false)]
            public CreateLogicalModelResponseBodyDataSlots Slots { get; set; }
            public class CreateLogicalModelResponseBodyDataSlots : TeaModel {
                /// <summary>
                /// <para>The complex slot. It must contain 1 to 3 source cards. The three slots are globally deduplicated by modelCardId.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("complex")]
                [Validation(Required=false)]
                public List<CreateLogicalModelResponseBodyDataSlotsComplex> Complex { get; set; }
                public class CreateLogicalModelResponseBodyDataSlotsComplex : TeaModel {
                    /// <summary>
                    /// <para>The ID of the actual source card in the same instance. The ID starts with &quot;msc-&quot;. VMs or service overrides are not supported.</para>
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
                /// <para>The simple slot. It must contain 1 to 3 source cards. The three slots are globally deduplicated by modelCardId.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("simple")]
                [Validation(Required=false)]
                public List<CreateLogicalModelResponseBodyDataSlotsSimple> Simple { get; set; }
                public class CreateLogicalModelResponseBodyDataSlotsSimple : TeaModel {
                    /// <summary>
                    /// <para>The ID of the actual source card in the same instance. The ID starts with &quot;msc-&quot;. VMs or service overrides are not supported.</para>
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
                /// <para>The standard slot. It must contain 1 to 3 source cards. The three slots are globally deduplicated by modelCardId.</para>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("standard")]
                [Validation(Required=false)]
                public List<CreateLogicalModelResponseBodyDataSlotsStandard> Standard { get; set; }
                public class CreateLogicalModelResponseBodyDataSlotsStandard : TeaModel {
                    /// <summary>
                    /// <para>The ID of the actual source card in the same instance. The ID starts with &quot;msc-&quot;. VMs or service overrides are not supported.</para>
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
            /// <para>The primary targets. If the routing policy is Mapping, exactly one target is allowed. If the routing policy is Weighted, the sum of the original relative weights must be greater than 0. If the routing policy is Auto, this parameter must be an empty array.</para>
            /// </summary>
            [NameInMap("targets")]
            [Validation(Required=false)]
            public List<CreateLogicalModelResponseBodyDataTargets> Targets { get; set; }
            public class CreateLogicalModelResponseBodyDataTargets : TeaModel {
                /// <summary>
                /// <para>The ID of the actual source model card in the same instance. The ID starts with &quot;msc-&quot;. VMs or service overrides are not supported.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>msc-d00000000000000000000</para>
                /// </summary>
                [NameInMap("modelCardId")]
                [Validation(Required=false)]
                public string ModelCardId { get; set; }

                /// <summary>
                /// <para>The weight. The value must be an integer from 0 to 10000 and is saved as the original value. If the routing policy is Mapping, 0 is allowed.</para>
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
            /// <para>The business modification time. This time is not updated during dry runs.</para>
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
