// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class GetInstanceTrendingReportResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetInstanceTrendingReportResponseBodyData Data { get; set; }
        public class GetInstanceTrendingReportResponseBodyData : TeaModel {
            [NameInMap("Inbound")]
            [Validation(Required=false)]
            public List<GetInstanceTrendingReportResponseBodyDataInbound> Inbound { get; set; }
            public class GetInstanceTrendingReportResponseBodyDataInbound : TeaModel {
                [NameInMap("CallsAbandonedInIVR")]
                [Validation(Required=false)]
                public long? CallsAbandonedInIVR { get; set; }

                [NameInMap("CallsAbandonedInQueue")]
                [Validation(Required=false)]
                public long? CallsAbandonedInQueue { get; set; }

                [NameInMap("CallsAbandonedInRing")]
                [Validation(Required=false)]
                public long? CallsAbandonedInRing { get; set; }

                [NameInMap("CallsHandled")]
                [Validation(Required=false)]
                public long? CallsHandled { get; set; }

                [NameInMap("CallsQueued")]
                [Validation(Required=false)]
                public long? CallsQueued { get; set; }

                [NameInMap("StatsTime")]
                [Validation(Required=false)]
                public long? StatsTime { get; set; }

                [NameInMap("TotalCalls")]
                [Validation(Required=false)]
                public long? TotalCalls { get; set; }

            }

            [NameInMap("Outbound")]
            [Validation(Required=false)]
            public List<GetInstanceTrendingReportResponseBodyDataOutbound> Outbound { get; set; }
            public class GetInstanceTrendingReportResponseBodyDataOutbound : TeaModel {
                [NameInMap("CallsAnswered")]
                [Validation(Required=false)]
                public long? CallsAnswered { get; set; }

                [NameInMap("StatsTime")]
                [Validation(Required=false)]
                public long? StatsTime { get; set; }

                [NameInMap("TotalCalls")]
                [Validation(Required=false)]
                public long? TotalCalls { get; set; }

            }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
