// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreateLogicalModelRequest : TeaModel {
        /// <summary>
        /// <para>Required for new Auto write requests. Valid values: balanced, cheap, fast, and quality. The new version only uses the basic call name. Do not submit this parameter for Mapping or Weighted. The server performs conditional validation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>balanced</para>
        /// </summary>
        [NameInMap("callStrategy")]
        [Validation(Required=false)]
        public string CallStrategy { get; set; }

        /// <summary>
        /// <para>An ordered list of up to 5 fallback targets. The targets are deduplicated by actual card ID and can be an empty array.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("fallbackTargets")]
        [Validation(Required=false)]
        public List<CreateLogicalModelRequestFallbackTargets> FallbackTargets { get; set; }
        public class CreateLogicalModelRequestFallbackTargets : TeaModel {
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
        /// <para>The associated AI gateway.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gw-d00000000000000000000</para>
        /// </summary>
        [NameInMap("gatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// <para>The client logical call name. It can be up to 256 bytes in UTF-8, must not contain spaces or slashes, and must not start with auto.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>beta-chat</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>If set to Actual, the public name of the actual model is returned. If set to Logical, the entry name is returned, including SSE.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Actual</para>
        /// </summary>
        [NameInMap("responseModel")]
        [Validation(Required=false)]
        public string ResponseModel { get; set; }

        /// <summary>
        /// <para>The routing policy. Valid values: Mapping, Weighted, and Auto. When set to Auto, targets must be an empty array and slots is required.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Weighted</para>
        /// </summary>
        [NameInMap("routingPolicy")]
        [Validation(Required=false)]
        public string RoutingPolicy { get; set; }

        /// <summary>
        /// <para>Submitted only for Auto. Each of the simple, standard, and complex slots requires 1 to 3 source cards. The three slots are globally deduplicated by modelCardId. Omit this parameter for Mapping and Weighted.</para>
        /// </summary>
        [NameInMap("slots")]
        [Validation(Required=false)]
        public CreateLogicalModelRequestSlots Slots { get; set; }
        public class CreateLogicalModelRequestSlots : TeaModel {
            /// <summary>
            /// <para>The complex slot requires 1 to 3 source cards. The three slots are globally deduplicated by modelCardId.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("complex")]
            [Validation(Required=false)]
            public List<CreateLogicalModelRequestSlotsComplex> Complex { get; set; }
            public class CreateLogicalModelRequestSlotsComplex : TeaModel {
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
            public List<CreateLogicalModelRequestSlotsSimple> Simple { get; set; }
            public class CreateLogicalModelRequestSlotsSimple : TeaModel {
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
            public List<CreateLogicalModelRequestSlotsStandard> Standard { get; set; }
            public class CreateLogicalModelRequestSlotsStandard : TeaModel {
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
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("targets")]
        [Validation(Required=false)]
        public List<CreateLogicalModelRequestTargets> Targets { get; set; }
        public class CreateLogicalModelRequestTargets : TeaModel {
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
        /// <para>The request idempotency identity generated by the invoker to identify the same creation or retry operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b1907ca4-952c-4c5f-8d1f-0aa6ae339c96</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
