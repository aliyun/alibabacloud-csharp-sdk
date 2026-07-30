// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class InsureOrderCreateResponseBody : TeaModel {
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
        public InsureOrderCreateResponseBodyModule Module { get; set; }
        public class InsureOrderCreateResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The number of insurance copies.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("copies")]
            [Validation(Required=false)]
            public int? Copies { get; set; }

            /// <summary>
            /// <para>The insurance order details.</para>
            /// </summary>
            [NameInMap("insure_order_detail_list")]
            [Validation(Required=false)]
            public List<InsureOrderCreateResponseBodyModuleInsureOrderDetailList> InsureOrderDetailList { get; set; }
            public class InsureOrderCreateResponseBodyModuleInsureOrderDetailList : TeaModel {
                /// <summary>
                /// <para>The external sub-order ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1992939412431231</para>
                /// </summary>
                [NameInMap("out_sub_ins_order_id")]
                [Validation(Required=false)]
                public string OutSubInsOrderId { get; set; }

                /// <summary>
                /// <para>The policy number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>121234444</para>
                /// </summary>
                [NameInMap("policy_no")]
                [Validation(Required=false)]
                public string PolicyNo { get; set; }

                /// <summary>
                /// <para>The status.</para>
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
                /// <para>1022196500378001</para>
                /// </summary>
                [NameInMap("sub_ins_order_id")]
                [Validation(Required=false)]
                public string SubInsOrderId { get; set; }

            }

            /// <summary>
            /// <para>The insurance order ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1021000196500370001</para>
            /// </summary>
            [NameInMap("insure_order_id")]
            [Validation(Required=false)]
            public string InsureOrderId { get; set; }

            /// <summary>
            /// <para>The premium amount in cents.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3000</para>
            /// </summary>
            [NameInMap("premium")]
            [Validation(Required=false)]
            public long? Premium { get; set; }

        }

        /// <summary>
        /// <para>The unique request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C6055EA5-C566-511D-9FC4-5E4D45182711</para>
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
        /// <para>The log trace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>210f079916782711059363565d6be1</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
