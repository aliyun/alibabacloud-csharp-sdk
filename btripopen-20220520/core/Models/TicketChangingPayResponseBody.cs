// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TicketChangingPayResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public TicketChangingPayResponseBodyModule Module { get; set; }
        public class TicketChangingPayResponseBodyModule : TeaModel {
            [NameInMap("can_retry")]
            [Validation(Required=false)]
            public bool? CanRetry { get; set; }

            [NameInMap("pay_price")]
            [Validation(Required=false)]
            public long? PayPrice { get; set; }

            [NameInMap("pay_status")]
            [Validation(Required=false)]
            public int? PayStatus { get; set; }

            [NameInMap("pay_time")]
            [Validation(Required=false)]
            public string PayTime { get; set; }

            [NameInMap("trade_no")]
            [Validation(Required=false)]
            public string TradeNo { get; set; }

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
