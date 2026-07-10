// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class ElectronicItineraryBatchApplyResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public ElectronicItineraryBatchApplyResponseBodyModule Module { get; set; }
        public class ElectronicItineraryBatchApplyResponseBodyModule : TeaModel {
            [NameInMap("apply_failed_ticket_list")]
            [Validation(Required=false)]
            public List<ElectronicItineraryBatchApplyResponseBodyModuleApplyFailedTicketList> ApplyFailedTicketList { get; set; }
            public class ElectronicItineraryBatchApplyResponseBodyModuleApplyFailedTicketList : TeaModel {
                [NameInMap("failed_code")]
                [Validation(Required=false)]
                public int? FailedCode { get; set; }

                [NameInMap("failed_reason")]
                [Validation(Required=false)]
                public string FailedReason { get; set; }

                [NameInMap("ticket_no")]
                [Validation(Required=false)]
                public string TicketNo { get; set; }

            }

            [NameInMap("batch_no")]
            [Validation(Required=false)]
            public string BatchNo { get; set; }

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
