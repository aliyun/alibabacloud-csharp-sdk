// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreateLogicalModelRequest : TeaModel {
        /// <summary>
        /// <para>The call strategy. This parameter is required for new write requests when the routing policy is Auto. Valid values: balanced, cheap, fast, and quality. The new version uses only the basic call name. Do not submit this parameter if the routing policy is Mapping or Weighted. The server performs conditional validation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>balanced</para>
        /// </summary>
        [NameInMap("callStrategy")]
        [Validation(Required=false)]
        public string CallStrategy { get; set; }

        /// <summary>
        /// <para>The ordered fallback targets. You can specify up to 5 fallback targets. They are deduplicated by the actual card ID and can be an empty array.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("fallbackTargets")]
        [Validation(Required=false)]
        public List<CreateLogicalModelRequestFallbackTargets> FallbackTargets { get; set; }
        public class CreateLogicalModelRequestFallbackTargets : TeaModel {
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
        /// <para>The AI gateway to which the logical model belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-d00000000000000000000</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>The client logical call name. The name can be up to 256 bytes in UTF-8 encoding, must not contain spaces or slashes, and must not start with &quot;auto&quot;.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>beta-chat</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The response model. If you set this parameter to Actual, the public name of the actual model is returned. If you set this parameter to Logical, the entry name is returned, including Server-Sent Events (SSE).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Actual</para>
        /// </summary>
        [NameInMap("responseModel")]
        [Validation(Required=false)]
        public string ResponseModel { get; set; }

        /// <summary>
        /// <para>The routing policy. Valid values: Mapping, Weighted, and Auto. If you set this parameter to Auto, the targets parameter must be an empty array and the slots parameter is required.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Weighted</para>
        /// </summary>
        [NameInMap("routingPolicy")]
        [Validation(Required=false)]
        public string RoutingPolicy { get; set; }

        /// <summary>
        /// <para>The slots. This parameter is submitted only when the routing policy is Auto. Each of the simple, standard, and complex slots must contain 1 to 3 source cards. The three slots are globally deduplicated by modelCardId. Omit this parameter if the routing policy is Mapping or Weighted.</para>
        /// </summary>
        [NameInMap("slots")]
        [Validation(Required=false)]
        public CreateLogicalModelRequestSlots Slots { get; set; }
        public class CreateLogicalModelRequestSlots : TeaModel {
            /// <summary>
            /// <para>The complex slot. It must contain 1 to 3 source cards. The three slots are globally deduplicated by modelCardId.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("complex")]
            [Validation(Required=false)]
            public List<CreateLogicalModelRequestSlotsComplex> Complex { get; set; }
            public class CreateLogicalModelRequestSlotsComplex : TeaModel {
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
            public List<CreateLogicalModelRequestSlotsSimple> Simple { get; set; }
            public class CreateLogicalModelRequestSlotsSimple : TeaModel {
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
            public List<CreateLogicalModelRequestSlotsStandard> Standard { get; set; }
            public class CreateLogicalModelRequestSlotsStandard : TeaModel {
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
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("targets")]
        [Validation(Required=false)]
        public List<CreateLogicalModelRequestTargets> Targets { get; set; }
        public class CreateLogicalModelRequestTargets : TeaModel {
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
        /// <para>The client token that is generated by the caller to ensure idempotence. It is used to identify the same creation or retry operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b1907ca4-952c-4c5f-8d1f-0aa6ae339c96</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
