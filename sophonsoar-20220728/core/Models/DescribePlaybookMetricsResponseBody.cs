// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribePlaybookMetricsResponseBody : TeaModel {
        [NameInMap("Metrics")]
        [Validation(Required=false)]
        public DescribePlaybookMetricsResponseBodyMetrics Metrics { get; set; }
        public class DescribePlaybookMetricsResponseBodyMetrics : TeaModel {
            [NameInMap("Active")]
            [Validation(Required=false)]
            public int? Active { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            [NameInMap("FailNum")]
            [Validation(Required=false)]
            public int? FailNum { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            [NameInMap("HistoryMd5")]
            [Validation(Required=false)]
            public int? HistoryMd5 { get; set; }

            [NameInMap("LastRuntime")]
            [Validation(Required=false)]
            public long? LastRuntime { get; set; }

            [NameInMap("OwnType")]
            [Validation(Required=false)]
            public string OwnType { get; set; }

            [NameInMap("PlaybookUuid")]
            [Validation(Required=false)]
            public string PlaybookUuid { get; set; }

            [NameInMap("SuccNum")]
            [Validation(Required=false)]
            public int? SuccNum { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
