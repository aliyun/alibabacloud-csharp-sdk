// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class FlightCancelOrderResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public FlightCancelOrderResponseBodyModule Module { get; set; }
        public class FlightCancelOrderResponseBodyModule : TeaModel {
            [NameInMap("cancel_time")]
            [Validation(Required=false)]
            public string CancelTime { get; set; }

            [NameInMap("fail_code")]
            [Validation(Required=false)]
            public string FailCode { get; set; }

            [NameInMap("fail_reason")]
            [Validation(Required=false)]
            public string FailReason { get; set; }

            [NameInMap("order_status")]
            [Validation(Required=false)]
            public string OrderStatus { get; set; }

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
