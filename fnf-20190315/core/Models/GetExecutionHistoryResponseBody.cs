// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Fnf20190315.Models
{
    public class GetExecutionHistoryResponseBody : TeaModel {
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Events")]
        [Validation(Required=false)]
        public List<GetExecutionHistoryResponseBodyEvents> Events { get; set; }
        public class GetExecutionHistoryResponseBodyEvents : TeaModel {
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("EventId")]
            [Validation(Required=false)]
            public long? EventId { get; set; }

            [NameInMap("Time")]
            [Validation(Required=false)]
            public string Time { get; set; }

            [NameInMap("ScheduleEventId")]
            [Validation(Required=false)]
            public long? ScheduleEventId { get; set; }

            [NameInMap("EventDetail")]
            [Validation(Required=false)]
            public string EventDetail { get; set; }

            [NameInMap("StepName")]
            [Validation(Required=false)]
            public string StepName { get; set; }

        }

    }

}
