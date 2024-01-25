// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiops20200806.Models
{
    public class ListReportsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListReportsResponseBodyData> Data { get; set; }
        public class ListReportsResponseBodyData : TeaModel {
            [NameInMap("bid")]
            [Validation(Required=false)]
            public string Bid { get; set; }

            [NameInMap("cid")]
            [Validation(Required=false)]
            public long? Cid { get; set; }

            [NameInMap("costCount")]
            [Validation(Required=false)]
            public long? CostCount { get; set; }

            [NameInMap("costCountTrendJson")]
            [Validation(Required=false)]
            public string CostCountTrendJson { get; set; }

            [NameInMap("criticalCount")]
            [Validation(Required=false)]
            public long? CriticalCount { get; set; }

            [NameInMap("criticalCountTrendJson")]
            [Validation(Required=false)]
            public string CriticalCountTrendJson { get; set; }

            [NameInMap("customerName")]
            [Validation(Required=false)]
            public string CustomerName { get; set; }

            [NameInMap("gcLevel")]
            [Validation(Required=false)]
            public string GcLevel { get; set; }

            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("normalCount")]
            [Validation(Required=false)]
            public long? NormalCount { get; set; }

            [NameInMap("normalCountTrendJson")]
            [Validation(Required=false)]
            public string NormalCountTrendJson { get; set; }

            [NameInMap("score")]
            [Validation(Required=false)]
            public long? Score { get; set; }

            [NameInMap("scoreTrendJson")]
            [Validation(Required=false)]
            public string ScoreTrendJson { get; set; }

            [NameInMap("trendJson")]
            [Validation(Required=false)]
            public string TrendJson { get; set; }

            [NameInMap("uid")]
            [Validation(Required=false)]
            public long? Uid { get; set; }

            [NameInMap("warningCount")]
            [Validation(Required=false)]
            public long? WarningCount { get; set; }

            [NameInMap("warningCountTrendJson")]
            [Validation(Required=false)]
            public string WarningCountTrendJson { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageTotal")]
        [Validation(Required=false)]
        public long? PageTotal { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
