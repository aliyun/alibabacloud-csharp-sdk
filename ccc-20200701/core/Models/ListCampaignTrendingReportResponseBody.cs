// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListCampaignTrendingReportResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListCampaignTrendingReportResponseBodyData> Data { get; set; }
        public class ListCampaignTrendingReportResponseBodyData : TeaModel {
            [NameInMap("BreakAgents")]
            [Validation(Required=false)]
            public long? BreakAgents { get; set; }

            [NameInMap("Concurrency")]
            [Validation(Required=false)]
            public long? Concurrency { get; set; }

            [NameInMap("Datetime")]
            [Validation(Required=false)]
            public long? Datetime { get; set; }

            [NameInMap("LoggedInAgents")]
            [Validation(Required=false)]
            public long? LoggedInAgents { get; set; }

            [NameInMap("ReadyAgents")]
            [Validation(Required=false)]
            public long? ReadyAgents { get; set; }

            [NameInMap("TalkAgents")]
            [Validation(Required=false)]
            public long? TalkAgents { get; set; }

            [NameInMap("WorkAgents")]
            [Validation(Required=false)]
            public long? WorkAgents { get; set; }

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
