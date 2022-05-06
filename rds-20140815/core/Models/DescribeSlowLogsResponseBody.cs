// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeSlowLogsResponseBody : TeaModel {
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeSlowLogsResponseBodyItems Items { get; set; }
        public class DescribeSlowLogsResponseBodyItems : TeaModel {
            [NameInMap("SQLSlowLog")]
            [Validation(Required=false)]
            public List<DescribeSlowLogsResponseBodyItemsSQLSlowLog> SQLSlowLog { get; set; }
            public class DescribeSlowLogsResponseBodyItemsSQLSlowLog : TeaModel {
                public long? AvgExecutionTime { get; set; }
                public long? AvgIOWriteCounts { get; set; }
                public long? AvgLastRowsAffectedCounts { get; set; }
                public long? AvgLogicalReadCounts { get; set; }
                public long? AvgPhysicalReadCounts { get; set; }
                public long? AvgRowsAffectedCounts { get; set; }
                public string CreateTime { get; set; }
                public string DBName { get; set; }
                public long? MaxExecutionTime { get; set; }
                public long? MaxIOWriteCounts { get; set; }
                public long? MaxLastRowsAffectedCounts { get; set; }
                public long? MaxLockTime { get; set; }
                public long? MaxLogicalReadCounts { get; set; }
                public long? MaxPhysicalReadCounts { get; set; }
                public long? MaxRowsAffectedCounts { get; set; }
                public long? MinIOWriteCounts { get; set; }
                public long? MinLastRowsAffectedCounts { get; set; }
                public long? MinLogicalReadCounts { get; set; }
                public long? MinPhysicalReadCounts { get; set; }
                public long? MinRowsAffectedCounts { get; set; }
                public long? MySQLTotalExecutionCounts { get; set; }
                public long? MySQLTotalExecutionTimes { get; set; }
                public long? ParseMaxRowCount { get; set; }
                public long? ParseTotalRowCounts { get; set; }
                public string ReportTime { get; set; }
                public long? ReturnMaxRowCount { get; set; }
                public long? ReturnTotalRowCounts { get; set; }
                public string SQLHASH { get; set; }
                public string SQLIdStr { get; set; }
                public long? SQLServerAvgCpuTime { get; set; }
                public long? SQLServerAvgExecutionTime { get; set; }
                public long? SQLServerMaxCpuTime { get; set; }
                public long? SQLServerMinCpuTime { get; set; }
                public long? SQLServerMinExecutionTime { get; set; }
                public long? SQLServerTotalCpuTime { get; set; }
                public long? SQLServerTotalExecutionCounts { get; set; }
                public long? SQLServerTotalExecutionTimes { get; set; }
                public string SQLText { get; set; }
                public long? SlowLogId { get; set; }
                public long? TotalIOWriteCounts { get; set; }
                public long? TotalLastRowsAffectedCounts { get; set; }
                public long? TotalLockTimes { get; set; }
                public long? TotalLogicalReadCounts { get; set; }
                public long? TotalPhysicalReadCounts { get; set; }
                public long? TotalRowsAffectedCounts { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
