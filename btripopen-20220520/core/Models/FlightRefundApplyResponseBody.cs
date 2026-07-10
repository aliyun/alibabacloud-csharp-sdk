// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightRefundApplyResponseBody : TeaModel {
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
            [NameInMap("dis_order_id")]
            [Validation(Required=false)]
            public string DisOrderId { get; set; }

            [NameInMap("dis_sub_order_id")]
            [Validation(Required=false)]
            public string DisSubOrderId { get; set; }

            [NameInMap("refund_apply_id")]
            [Validation(Required=false)]
            public long? RefundApplyId { get; set; }

            [NameInMap("refund_fee")]
            [Validation(Required=false)]
            public long? RefundFee { get; set; }

            [NameInMap("refund_money")]
            [Validation(Required=false)]
            public long? RefundMoney { get; set; }

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
