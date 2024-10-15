// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightCreateOrderResponseBody : TeaModel {
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
        public FlightCreateOrderResponseBodyModule Module { get; set; }
        public class FlightCreateOrderResponseBodyModule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>3287177727711</para>
            /// </summary>
            [NameInMap("alipay_trade_no")]
            [Validation(Required=false)]
            public string AlipayTradeNo { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("btrip_order_id")]
            [Validation(Required=false)]
            public long? BtripOrderId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dis123</para>
            /// </summary>
            [NameInMap("dis_order_id")]
            [Validation(Required=false)]
            public string DisOrderId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2000-00-00 00:00:00</para>
            /// </summary>
            [NameInMap("last_pay_time")]
            [Validation(Required=false)]
            public string LastPayTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("order_status")]
            [Validation(Required=false)]
            public int? OrderStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("pay_status")]
            [Validation(Required=false)]
            public int? PayStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("payment_price")]
            [Validation(Required=false)]
            public long? PaymentPrice { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("total_price")]
            [Validation(Required=false)]
            public long? TotalPrice { get; set; }

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
