// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class UpdateLogicalModelRequest : TeaModel {
        /// <summary>
        /// <para>The call strategy. This parameter is required for new Auto write requests. Valid values: balanced, cheap, fast, and quality. The new version uses only the basic call name. Do not submit this parameter for Mapping and Weighted. The server performs conditional validation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>balanced</para>
        /// </summary>
        [NameInMap("callStrategy")]
        [Validation(Required=false)]
        public string CallStrategy { get; set; }

        /// <summary>
        /// <para>The ordered fallback targets. A maximum of 5 targets are supported. The targets are deduplicated by actual card ID. This can be an empty array.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("fallbackTargets")]
        [Validation(Required=false)]
        public List<UpdateLogicalModelRequestFallbackTargets> FallbackTargets { get; set; }
        public class UpdateLogicalModelRequestFallbackTargets : TeaModel {
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
        /// <para>The client logical call name. It can be up to 256 bytes in UTF-8 encoding, must not contain spaces or slashes, and must not start with auto.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>beta-chat</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The response model. Actual returns the public name of the actual model, and Logical returns the entry name, including Server-Sent Events (SSE).</para>
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
        /// <para>The slots. This parameter is submitted only for Auto. Each of the simple, standard, and complex slots requires 1 to 3 source cards. The three slots are globally deduplicated by modelCardId. Omit this parameter for Mapping and Weighted.</para>
        /// </summary>
        [NameInMap("slots")]
        [Validation(Required=false)]
        public UpdateLogicalModelRequestSlots Slots { get; set; }
        public class UpdateLogicalModelRequestSlots : TeaModel {
            /// <summary>
            /// <para>The complex slot. It requires 1 to 3 source cards. The three slots are globally deduplicated by modelCardId.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("complex")]
            [Validation(Required=false)]
            public List<UpdateLogicalModelRequestSlotsComplex> Complex { get; set; }
            public class UpdateLogicalModelRequestSlotsComplex : TeaModel {
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
            public List<UpdateLogicalModelRequestSlotsSimple> Simple { get; set; }
            public class UpdateLogicalModelRequestSlotsSimple : TeaModel {
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
            public List<UpdateLogicalModelRequestSlotsStandard> Standard { get; set; }
            public class UpdateLogicalModelRequestSlotsStandard : TeaModel {
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
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("targets")]
        [Validation(Required=false)]
        public List<UpdateLogicalModelRequestTargets> Targets { get; set; }
        public class UpdateLogicalModelRequestTargets : TeaModel {
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
        /// <para>The confirmation token returned by the configuration update dry run. Pass this token as is when submitting the update.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6b8e7d61b3a94c7285cf0d9ee1a72c836b8e7d61b3a94c7285cf0d9ee1a72c83</para>
        /// </summary>
        [NameInMap("confirmationToken")]
        [Validation(Required=false)]
        public string ConfirmationToken { get; set; }

        /// <summary>
        /// <para>The expected configuration revision number. Use the revision returned by the most recent query or dry run.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("expectedRevision")]
        [Validation(Required=false)]
        public long? ExpectedRevision { get; set; }

    }

}
