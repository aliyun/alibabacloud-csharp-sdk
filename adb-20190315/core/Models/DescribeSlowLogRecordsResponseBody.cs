// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeSlowLogRecordsResponseBody : TeaModel {
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeSlowLogRecordsResponseBodyItems Items { get; set; }
        public class DescribeSlowLogRecordsResponseBodyItems : TeaModel {
            [NameInMap("SlowLogRecord")]
            [Validation(Required=false)]
            public List<DescribeSlowLogRecordsResponseBodyItemsSlowLogRecord> SlowLogRecord { get; set; }
            public class DescribeSlowLogRecordsResponseBodyItemsSlowLogRecord : TeaModel {
                public string DBName { get; set; }
                public string ExecutionStartTime { get; set; }
                public string HostAddress { get; set; }
                public string OutputSize { get; set; }
                public long? ParseRowCounts { get; set; }
                public string PeakMemoryUsage { get; set; }
                public long? PlanningTime { get; set; }
                public string ProcessID { get; set; }
                public long? QueryTime { get; set; }
                public long? QueueTime { get; set; }
                public long? ReturnRowCounts { get; set; }
                public string SQLText { get; set; }
                public long? ScanRows { get; set; }
                public string ScanSize { get; set; }
                public long? ScanTime { get; set; }
                public string State { get; set; }
                public string UserName { get; set; }
                public long? WallTime { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
