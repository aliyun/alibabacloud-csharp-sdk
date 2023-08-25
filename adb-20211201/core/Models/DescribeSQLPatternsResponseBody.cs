// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeSQLPatternsResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PatternDetails")]
        [Validation(Required=false)]
        public List<DescribeSQLPatternsResponseBodyPatternDetails> PatternDetails { get; set; }
        public class DescribeSQLPatternsResponseBodyPatternDetails : TeaModel {
            [NameInMap("AccessIp")]
            [Validation(Required=false)]
            public string AccessIp { get; set; }

            [NameInMap("AverageExecutionTime")]
            [Validation(Required=false)]
            public double? AverageExecutionTime { get; set; }

            [NameInMap("AveragePeakMemory")]
            [Validation(Required=false)]
            public double? AveragePeakMemory { get; set; }

            [NameInMap("AverageQueryTime")]
            [Validation(Required=false)]
            public double? AverageQueryTime { get; set; }

            [NameInMap("AverageScanSize")]
            [Validation(Required=false)]
            public double? AverageScanSize { get; set; }

            [NameInMap("Blockable")]
            [Validation(Required=false)]
            public bool? Blockable { get; set; }

            [NameInMap("FailedCount")]
            [Validation(Required=false)]
            public long? FailedCount { get; set; }

            [NameInMap("MaxExecutionTime")]
            [Validation(Required=false)]
            public long? MaxExecutionTime { get; set; }

            [NameInMap("MaxPeakMemory")]
            [Validation(Required=false)]
            public long? MaxPeakMemory { get; set; }

            [NameInMap("MaxQueryTime")]
            [Validation(Required=false)]
            public long? MaxQueryTime { get; set; }

            [NameInMap("MaxScanSize")]
            [Validation(Required=false)]
            public long? MaxScanSize { get; set; }

            [NameInMap("PatternCreationTime")]
            [Validation(Required=false)]
            public string PatternCreationTime { get; set; }

            [NameInMap("PatternId")]
            [Validation(Required=false)]
            public string PatternId { get; set; }

            [NameInMap("QueryCount")]
            [Validation(Required=false)]
            public long? QueryCount { get; set; }

            [NameInMap("SQLPattern")]
            [Validation(Required=false)]
            public string SQLPattern { get; set; }

            [NameInMap("Tables")]
            [Validation(Required=false)]
            public string Tables { get; set; }

            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
