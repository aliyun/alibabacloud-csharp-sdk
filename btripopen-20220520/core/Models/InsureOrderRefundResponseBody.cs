// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class InsureOrderRefundResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public InsureOrderRefundResponseBodyModule Module { get; set; }
        public class InsureOrderRefundResponseBodyModule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>118526587</para>
            /// </summary>
            [NameInMap("apply_id")]
            [Validation(Required=false)]
            public string ApplyId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1423041410342678003</para>
            /// </summary>
            [NameInMap("ins_order_id")]
            [Validation(Required=false)]
            public string InsOrderId { get; set; }

            [NameInMap("ins_refund_list")]
            [Validation(Required=false)]
            public List<InsureOrderRefundResponseBodyModuleInsRefundList> InsRefundList { get; set; }
            public class InsureOrderRefundResponseBodyModuleInsRefundList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>po102000399221</para>
                /// </summary>
                [NameInMap("policy_refund_no")]
                [Validation(Required=false)]
                public string PolicyRefundNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>REFUND_SUCCESS</para>
                /// </summary>
                [NameInMap("refund_status")]
                [Validation(Required=false)]
                public string RefundStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1230012499921</para>
                /// </summary>
                [NameInMap("sub_ins_order_id")]
                [Validation(Required=false)]
                public string SubInsOrderId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1423041410342678022</para>
            /// </summary>
            [NameInMap("out_apply_id")]
            [Validation(Required=false)]
            public string OutApplyId { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2103ad3116824902540648188de7ac</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>210e846c16726306481681232d441f</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
