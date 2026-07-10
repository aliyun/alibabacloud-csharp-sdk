// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class QueryCompenInfosForOpResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public List<QueryCompenInfosForOpResponseBodyModule> Module { get; set; }
        public class QueryCompenInfosForOpResponseBodyModule : TeaModel {
            [NameInMap("amount")]
            [Validation(Required=false)]
            public long? Amount { get; set; }

            [NameInMap("category")]
            [Validation(Required=false)]
            public int? Category { get; set; }

            [NameInMap("compen_id")]
            [Validation(Required=false)]
            public string CompenId { get; set; }

            [NameInMap("compensation_type")]
            [Validation(Required=false)]
            public string CompensationType { get; set; }

            [NameInMap("order_id")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

            [NameInMap("settle_time")]
            [Validation(Required=false)]
            public string SettleTime { get; set; }

            [NameInMap("settle_type")]
            [Validation(Required=false)]
            public int? SettleType { get; set; }

            [NameInMap("ticket_no")]
            [Validation(Required=false)]
            public string TicketNo { get; set; }

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
