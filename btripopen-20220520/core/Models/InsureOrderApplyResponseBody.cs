// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class InsureOrderApplyResponseBody : TeaModel {
        /// <summary>
        /// <para>The result code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>成功</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public InsureOrderApplyResponseBodyModule Module { get; set; }
        public class InsureOrderApplyResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The insurance order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1021000196500370003</para>
            /// </summary>
            [NameInMap("ins_order_id")]
            [Validation(Required=false)]
            public string InsOrderId { get; set; }

            /// <summary>
            /// <para>The insurance policy details.</para>
            /// </summary>
            [NameInMap("ins_order_policy_list")]
            [Validation(Required=false)]
            public List<InsureOrderApplyResponseBodyModuleInsOrderPolicyList> InsOrderPolicyList { get; set; }
            public class InsureOrderApplyResponseBodyModuleInsOrderPolicyList : TeaModel {
                /// <summary>
                /// <para>The external sub-order ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1022196500378006</para>
                /// </summary>
                [NameInMap("out_sub_ins_order_id")]
                [Validation(Required=false)]
                public string OutSubInsOrderId { get; set; }

                /// <summary>
                /// <para>The policy number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>po10002300201</para>
                /// </summary>
                [NameInMap("policy_no")]
                [Validation(Required=false)]
                public string PolicyNo { get; set; }

                /// <summary>
                /// <para>The status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>INIT: Initialized.</description></item>
                /// <item><description>CLOSED: Order closed.</description></item>
                /// <item><description>REFUNDED: Refunded.</description></item>
                /// <item><description>WAIT_PAY: Pending payment.</description></item>
                /// <item><description>PAID: Paid.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>INIT</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The sub-order ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1022196500378003</para>
                /// </summary>
                [NameInMap("sub_ins_order_id")]
                [Validation(Required=false)]
                public string SubInsOrderId { get; set; }

            }

        }

        /// <summary>
        /// <para>The unique request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B72B39C8-32DE-558D-AD1C-D53F11F6ADFE</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The trace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>210e800316781571635951548d1e9d</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
