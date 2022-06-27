// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDiagnosisMonitorPerformanceResponseBody : TeaModel {
        [NameInMap("Performances")]
        [Validation(Required=false)]
        public List<DescribeDiagnosisMonitorPerformanceResponseBodyPerformances> Performances { get; set; }
        public class DescribeDiagnosisMonitorPerformanceResponseBodyPerformances : TeaModel {
            [NameInMap("Cost")]
            [Validation(Required=false)]
            public int? Cost { get; set; }

            [NameInMap("Database")]
            [Validation(Required=false)]
            public string Database { get; set; }

            [NameInMap("QueryID")]
            [Validation(Required=false)]
            public string QueryID { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

        }

        [NameInMap("PerformancesThreshold")]
        [Validation(Required=false)]
        public int? PerformancesThreshold { get; set; }

        [NameInMap("PerformancesTruncated")]
        [Validation(Required=false)]
        public bool? PerformancesTruncated { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
