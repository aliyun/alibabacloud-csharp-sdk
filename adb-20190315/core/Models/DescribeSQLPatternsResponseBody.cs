// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeSQLPatternsResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("PatternDetails")]
        [Validation(Required=false)]
        public List<DescribeSQLPatternsResponseBodyPatternDetails> PatternDetails { get; set; }
        public class DescribeSQLPatternsResponseBodyPatternDetails : TeaModel {
            [NameInMap("SQLPattern")]
            [Validation(Required=false)]
            public string SQLPattern { get; set; }

            [NameInMap("PatternId")]
            [Validation(Required=false)]
            public string PatternId { get; set; }

            [NameInMap("Tables")]
            [Validation(Required=false)]
            public string Tables { get; set; }

            [NameInMap("PatternCreationDate")]
            [Validation(Required=false)]
            public string PatternCreationDate { get; set; }

            [NameInMap("TotalQueryTime")]
            [Validation(Required=false)]
            public string TotalQueryTime { get; set; }

            [NameInMap("AverageQueryTime")]
            [Validation(Required=false)]
            public string AverageQueryTime { get; set; }

            [NameInMap("QueryTimePercentage")]
            [Validation(Required=false)]
            public string QueryTimePercentage { get; set; }

            [NameInMap("AverageMemory")]
            [Validation(Required=false)]
            public string AverageMemory { get; set; }

            [NameInMap("TotalScanSize")]
            [Validation(Required=false)]
            public string TotalScanSize { get; set; }

            [NameInMap("ScanSizePercentage")]
            [Validation(Required=false)]
            public string ScanSizePercentage { get; set; }

            [NameInMap("QueryCount")]
            [Validation(Required=false)]
            public long? QueryCount { get; set; }

            [NameInMap("ErrorCount")]
            [Validation(Required=false)]
            public long? ErrorCount { get; set; }

            [NameInMap("Blockable")]
            [Validation(Required=false)]
            public bool? Blockable { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
