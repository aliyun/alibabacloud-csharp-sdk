// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class PreviewLogicalModelUpdateRequest : TeaModel {
        /// <summary>
        /// <para>The call strategy, which is required for new Auto write requests. Valid values: balanced, cheap, fast, and quality. The new version uses only the basic call name. Do not submit this parameter for Mapping or Weighted. The server performs conditional validation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>balanced</para>
        /// </summary>
        [NameInMap("callStrategy")]
        [Validation(Required=false)]
        public string CallStrategy { get; set; }

        /// <summary>
        /// <para>An ordered list of up to 5 fallback targets. The targets are deduplicated by the actual card ID. This can be an empty array.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("fallbackTargets")]
        [Validation(Required=false)]
        public List<PreviewLogicalModelUpdateRequestFallbackTargets> FallbackTargets { get; set; }
        public class PreviewLogicalModelUpdateRequestFallbackTargets : TeaModel {
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
        /// <para>The client logical call name. The value can be up to 256 bytes in UTF-8 encoding, must not contain spaces or slashes, and must not start with auto.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>beta-chat</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The response model type. If set to Actual, the public name of the actual model is returned. If set to Logical, the entry name is returned, including SSE.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Actual</para>
        /// </summary>
        [NameInMap("responseModel")]
        [Validation(Required=false)]
        public string ResponseModel { get; set; }

        /// <summary>
        /// <para>The routing policy. Valid values: Mapping, Weighted, and Auto. If you set this parameter to Auto, targets must be an empty array and slots is required.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Weighted</para>
        /// </summary>
        [NameInMap("routingPolicy")]
        [Validation(Required=false)]
        public string RoutingPolicy { get; set; }

        /// <summary>
        /// <para>The slots configuration, which is submitted only for Auto. Each of the simple, standard, and complex slots requires 1 to 3 source cards. Cards across the three slots are globally deduplicated by modelCardId. Omit this parameter for Mapping or Weighted.</para>
        /// </summary>
        [NameInMap("slots")]
        [Validation(Required=false)]
        public PreviewLogicalModelUpdateRequestSlots Slots { get; set; }
        public class PreviewLogicalModelUpdateRequestSlots : TeaModel {
            /// <summary>
            /// <para>The complex slot, which requires 1 to 3 source cards. Cards across the three slots are globally deduplicated by modelCardId.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("complex")]
            [Validation(Required=false)]
            public List<PreviewLogicalModelUpdateRequestSlotsComplex> Complex { get; set; }
            public class PreviewLogicalModelUpdateRequestSlotsComplex : TeaModel {
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
            /// <para>The simple slot, which requires 1 to 3 source cards. Cards across the three slots are globally deduplicated by modelCardId.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("simple")]
            [Validation(Required=false)]
            public List<PreviewLogicalModelUpdateRequestSlotsSimple> Simple { get; set; }
            public class PreviewLogicalModelUpdateRequestSlotsSimple : TeaModel {
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
            /// <para>The standard slot, which requires 1 to 3 source cards. Cards across the three slots are globally deduplicated by modelCardId.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("standard")]
            [Validation(Required=false)]
            public List<PreviewLogicalModelUpdateRequestSlotsStandard> Standard { get; set; }
            public class PreviewLogicalModelUpdateRequestSlotsStandard : TeaModel {
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
        public List<PreviewLogicalModelUpdateRequestTargets> Targets { get; set; }
        public class PreviewLogicalModelUpdateRequestTargets : TeaModel {
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
            /// <para>The weight value. Valid values: integers from 0 to 10000. The original value is preserved. For Mapping, 0 is allowed.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

    }

}
