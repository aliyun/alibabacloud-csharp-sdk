// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class ListOutboundCallNumbersResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("OutboundCallNumbers")]
        [Validation(Required=false)]
        public ListOutboundCallNumbersResponseBodyOutboundCallNumbers OutboundCallNumbers { get; set; }
        public class ListOutboundCallNumbersResponseBodyOutboundCallNumbers : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListOutboundCallNumbersResponseBodyOutboundCallNumbersList> List { get; set; }
            public class ListOutboundCallNumbersResponseBodyOutboundCallNumbersList : TeaModel {
                [NameInMap("Number")]
                [Validation(Required=false)]
                public string Number { get; set; }

                [NameInMap("OutboundCallNumberId")]
                [Validation(Required=false)]
                public string OutboundCallNumberId { get; set; }

                [NameInMap("RateLimitCount")]
                [Validation(Required=false)]
                public string RateLimitCount { get; set; }

                [NameInMap("RateLimitPeriod")]
                [Validation(Required=false)]
                public string RateLimitPeriod { get; set; }

            }

            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
