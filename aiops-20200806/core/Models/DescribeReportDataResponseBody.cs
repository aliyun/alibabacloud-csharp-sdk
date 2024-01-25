// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiops20200806.Models
{
    public class DescribeReportDataResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeReportDataResponseBodyData Data { get; set; }
        public class DescribeReportDataResponseBodyData : TeaModel {
            [NameInMap("HeathScore")]
            [Validation(Required=false)]
            public long? HeathScore { get; set; }

            [NameInMap("HeathScoreTrendList")]
            [Validation(Required=false)]
            public List<long?> HeathScoreTrendList { get; set; }

            [NameInMap("PreUpdateTime")]
            [Validation(Required=false)]
            public string PreUpdateTime { get; set; }

            [NameInMap("RiskCount")]
            [Validation(Required=false)]
            public long? RiskCount { get; set; }

            [NameInMap("RiskCountTrendList")]
            [Validation(Required=false)]
            public List<long?> RiskCountTrendList { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
