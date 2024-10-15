// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightRefundApplyResponseBody : TeaModel {
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
        public FlightRefundApplyResponseBodyModule Module { get; set; }
        public class FlightRefundApplyResponseBodyModule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>dis123</para>
            /// </summary>
            [NameInMap("dis_order_id")]
            [Validation(Required=false)]
            public string DisOrderId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>refun1234</para>
            /// </summary>
            [NameInMap("dis_sub_order_id")]
            [Validation(Required=false)]
            public string DisSubOrderId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1231231</para>
            /// </summary>
            [NameInMap("refund_apply_id")]
            [Validation(Required=false)]
            public long? RefundApplyId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("refund_fee")]
            [Validation(Required=false)]
            public long? RefundFee { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("refund_money")]
            [Validation(Required=false)]
            public long? RefundMoney { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A5009956-1077-52FB-B520-EA8C7E91D722</para>
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
        /// <para>21041ce316577904808056433edbb2</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
