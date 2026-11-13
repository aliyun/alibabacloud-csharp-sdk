// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class UpdateLogicalModelRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>balanced</para>
        /// </summary>
        [NameInMap("callStrategy")]
        [Validation(Required=false)]
        public string CallStrategy { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("fallbackTargets")]
        [Validation(Required=false)]
        public List<UpdateLogicalModelRequestFallbackTargets> FallbackTargets { get; set; }
        public class UpdateLogicalModelRequestFallbackTargets : TeaModel {
            /// <summary>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>beta-chat</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Actual</para>
        /// </summary>
        [NameInMap("responseModel")]
        [Validation(Required=false)]
        public string ResponseModel { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Weighted</para>
        /// </summary>
        [NameInMap("routingPolicy")]
        [Validation(Required=false)]
        public string RoutingPolicy { get; set; }

        [NameInMap("slots")]
        [Validation(Required=false)]
        public UpdateLogicalModelRequestSlots Slots { get; set; }
        public class UpdateLogicalModelRequestSlots : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("complex")]
            [Validation(Required=false)]
            public List<UpdateLogicalModelRequestSlotsComplex> Complex { get; set; }
            public class UpdateLogicalModelRequestSlotsComplex : TeaModel {
                /// <summary>
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
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("simple")]
            [Validation(Required=false)]
            public List<UpdateLogicalModelRequestSlotsSimple> Simple { get; set; }
            public class UpdateLogicalModelRequestSlotsSimple : TeaModel {
                /// <summary>
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
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("standard")]
            [Validation(Required=false)]
            public List<UpdateLogicalModelRequestSlotsStandard> Standard { get; set; }
            public class UpdateLogicalModelRequestSlotsStandard : TeaModel {
                /// <summary>
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
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("targets")]
        [Validation(Required=false)]
        public List<UpdateLogicalModelRequestTargets> Targets { get; set; }
        public class UpdateLogicalModelRequestTargets : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>msc-d00000000000000000000</para>
            /// </summary>
            [NameInMap("modelCardId")]
            [Validation(Required=false)]
            public string ModelCardId { get; set; }

            /// <summary>
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
        /// <b>Example:</b>
        /// <para>6b8e7d61b3a94c7285cf0d9ee1a72c836b8e7d61b3a94c7285cf0d9ee1a72c83</para>
        /// </summary>
        [NameInMap("confirmationToken")]
        [Validation(Required=false)]
        public string ConfirmationToken { get; set; }

        /// <summary>
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
