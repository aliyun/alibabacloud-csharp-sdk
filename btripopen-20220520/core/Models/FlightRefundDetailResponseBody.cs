// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightRefundDetailResponseBody : TeaModel {
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
            [NameInMap("btrip_order_id")]
            [Validation(Required=false)]
            public long? BtripOrderId { get; set; }

            [NameInMap("btrip_sub_order_id")]
            [Validation(Required=false)]
            public long? BtripSubOrderId { get; set; }

            [NameInMap("dis_order_id")]
            [Validation(Required=false)]
            public string DisOrderId { get; set; }

            [NameInMap("dis_sub_order_id")]
            [Validation(Required=false)]
            public string DisSubOrderId { get; set; }

            [NameInMap("is_voluntary")]
            [Validation(Required=false)]
            public int? IsVoluntary { get; set; }

            [NameInMap("reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            [NameInMap("refund_fee")]
            [Validation(Required=false)]
            public long? RefundFee { get; set; }

            [NameInMap("refund_fee_list")]
            [Validation(Required=false)]
            public List<FlightRefundDetailResponseBodyModuleRefundFeeList> RefundFeeList { get; set; }
            public class FlightRefundDetailResponseBodyModuleRefundFeeList : TeaModel {
                [NameInMap("alipay_trade_no")]
                [Validation(Required=false)]
                public string AlipayTradeNo { get; set; }

                [NameInMap("refund_fee")]
                [Validation(Required=false)]
                public long? RefundFee { get; set; }

                [NameInMap("refund_price")]
                [Validation(Required=false)]
                public long? RefundPrice { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            [NameInMap("refund_price")]
            [Validation(Required=false)]
            public long? RefundPrice { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
