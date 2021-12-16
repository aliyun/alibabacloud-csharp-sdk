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
                public long? CallsAbandonedInIVR { get; set; }
                public long? CallsAbandonedInQueue { get; set; }
                public long? CallsAbandonedInRing { get; set; }
                public long? CallsHandled { get; set; }
                public long? CallsQueued { get; set; }
                public long? StatsTime { get; set; }
                public long? TotalCalls { get; set; }
            }
            [NameInMap("Outbound")]
            [Validation(Required=false)]
            public List<GetInstanceTrendingReportResponseBodyDataOutbound> Outbound { get; set; }
            public class GetInstanceTrendingReportResponseBodyDataOutbound : TeaModel {
                public long? CallsAnswered { get; set; }
                public long? StatsTime { get; set; }
                public long? TotalCalls { get; set; }
            }
        };

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
