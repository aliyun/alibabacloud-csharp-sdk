// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightRefundDetailResponseBody : TeaModel {
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
        public FlightRefundDetailResponseBodyModule Module { get; set; }
        public class FlightRefundDetailResponseBodyModule : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("btrip_order_id")]
            [Validation(Required=false)]
            public long? BtripOrderId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("btrip_sub_order_id")]
            [Validation(Required=false)]
            public long? BtripSubOrderId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dis1234</para>
            /// </summary>
            [NameInMap("dis_order_id")]
            [Validation(Required=false)]
            public string DisOrderId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>refun123</para>
            /// </summary>
            [NameInMap("dis_sub_order_id")]
            [Validation(Required=false)]
            public string DisSubOrderId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("is_voluntary")]
            [Validation(Required=false)]
            public int? IsVoluntary { get; set; }

            [NameInMap("reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("refund_fee")]
            [Validation(Required=false)]
            public long? RefundFee { get; set; }

            [NameInMap("refund_fee_list")]
            [Validation(Required=false)]
            public List<FlightRefundDetailResponseBodyModuleRefundFeeList> RefundFeeList { get; set; }
            public class FlightRefundDetailResponseBodyModuleRefundFeeList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>293982882881999</para>
                /// </summary>
                [NameInMap("alipay_trade_no")]
                [Validation(Required=false)]
                public string AlipayTradeNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("refund_fee")]
                [Validation(Required=false)]
                public long? RefundFee { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("refund_price")]
                [Validation(Required=false)]
                public long? RefundPrice { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("refund_price")]
            [Validation(Required=false)]
            public long? RefundPrice { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>407543AF-2BD9-5890-BD92-9D1AB7218B27</para>
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
