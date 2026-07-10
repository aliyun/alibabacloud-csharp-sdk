// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ElectronicItineraryGetApplyResultResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public ElectronicItineraryGetApplyResultResponseBodyModule Module { get; set; }
        public class ElectronicItineraryGetApplyResultResponseBodyModule : TeaModel {
            [NameInMap("apply_ticket_list")]
            [Validation(Required=false)]
            public List<ElectronicItineraryGetApplyResultResponseBodyModuleApplyTicketList> ApplyTicketList { get; set; }
            public class ElectronicItineraryGetApplyResultResponseBodyModuleApplyTicketList : TeaModel {
                [NameInMap("failed_code")]
                [Validation(Required=false)]
                public int? FailedCode { get; set; }

                [NameInMap("failed_reason")]
                [Validation(Required=false)]
                public string FailedReason { get; set; }

                [NameInMap("itinerary_status")]
                [Validation(Required=false)]
                public int? ItineraryStatus { get; set; }

                [NameInMap("remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                [NameInMap("ticket_no")]
                [Validation(Required=false)]
                public string TicketNo { get; set; }

            }

            [NameInMap("batch_apply_no")]
            [Validation(Required=false)]
            public string BatchApplyNo { get; set; }

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
