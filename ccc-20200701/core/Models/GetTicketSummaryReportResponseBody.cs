// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class GetTicketSummaryReportResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetTicketSummaryReportResponseBodyData Data { get; set; }
        public class GetTicketSummaryReportResponseBodyData : TeaModel {
            [NameInMap("TicketsAssigned")]
            [Validation(Required=false)]
            public string TicketsAssigned { get; set; }

            [NameInMap("TicketsCreated")]
            [Validation(Required=false)]
            public string TicketsCreated { get; set; }

            [NameInMap("TicketsParticipated")]
            [Validation(Required=false)]
            public string TicketsParticipated { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public long? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
