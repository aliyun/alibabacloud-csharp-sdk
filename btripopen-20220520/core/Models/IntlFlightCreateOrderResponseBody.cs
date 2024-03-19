// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IntlFlightCreateOrderResponseBody : TeaModel {
        [NameInMap("http_status_code")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public IntlFlightCreateOrderResponseBodyModule Module { get; set; }
        public class IntlFlightCreateOrderResponseBodyModule : TeaModel {
            [NameInMap("async_create_order_key")]
            [Validation(Required=false)]
            public string AsyncCreateOrderKey { get; set; }

            [NameInMap("latest_pay_time")]
            [Validation(Required=false)]
            public string LatestPayTime { get; set; }

            [NameInMap("order_id")]
            [Validation(Required=false)]
            public long? OrderId { get; set; }

            [NameInMap("out_order_id")]
            [Validation(Required=false)]
            public string OutOrderId { get; set; }

            [NameInMap("pay_status")]
            [Validation(Required=false)]
            public int? PayStatus { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("total_price")]
            [Validation(Required=false)]
            public long? TotalPrice { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result_code")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("result_msg")]
        [Validation(Required=false)]
        public string ResultMsg { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
