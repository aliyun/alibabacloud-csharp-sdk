// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class GetHistoricalCampaignReportResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetHistoricalCampaignReportResponseBodyData Data { get; set; }
        public class GetHistoricalCampaignReportResponseBodyData : TeaModel {
            [NameInMap("AbandonRate")]
            [Validation(Required=false)]
            public float? AbandonRate { get; set; }

            [NameInMap("AbandonedRate")]
            [Validation(Required=false)]
            public float? AbandonedRate { get; set; }

            [NameInMap("AnswerRate")]
            [Validation(Required=false)]
            public float? AnswerRate { get; set; }

            [NameInMap("CallsAbandoned")]
            [Validation(Required=false)]
            public long? CallsAbandoned { get; set; }

            [NameInMap("CallsConnected")]
            [Validation(Required=false)]
            public long? CallsConnected { get; set; }

            [NameInMap("CallsDialed")]
            [Validation(Required=false)]
            public long? CallsDialed { get; set; }

            [NameInMap("ConnectedRate")]
            [Validation(Required=false)]
            public float? ConnectedRate { get; set; }

            [NameInMap("OccupancyRate")]
            [Validation(Required=false)]
            public float? OccupancyRate { get; set; }

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
