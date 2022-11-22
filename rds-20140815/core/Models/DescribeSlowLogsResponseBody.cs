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
                [NameInMap("AvgExecutionTime")]
                [Validation(Required=false)]
                public long? AvgExecutionTime { get; set; }

                [NameInMap("AvgIOWriteCounts")]
                [Validation(Required=false)]
                public long? AvgIOWriteCounts { get; set; }

                [NameInMap("AvgLastRowsAffectedCounts")]
                [Validation(Required=false)]
                public long? AvgLastRowsAffectedCounts { get; set; }

                [NameInMap("AvgLogicalReadCounts")]
                [Validation(Required=false)]
                public long? AvgLogicalReadCounts { get; set; }

                [NameInMap("AvgPhysicalReadCounts")]
                [Validation(Required=false)]
                public long? AvgPhysicalReadCounts { get; set; }

                [NameInMap("AvgRowsAffectedCounts")]
                [Validation(Required=false)]
                public long? AvgRowsAffectedCounts { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("DBName")]
                [Validation(Required=false)]
                public string DBName { get; set; }

                [NameInMap("MaxExecutionTime")]
                [Validation(Required=false)]
                public long? MaxExecutionTime { get; set; }

                [NameInMap("MaxIOWriteCounts")]
                [Validation(Required=false)]
                public long? MaxIOWriteCounts { get; set; }

                [NameInMap("MaxLastRowsAffectedCounts")]
                [Validation(Required=false)]
                public long? MaxLastRowsAffectedCounts { get; set; }

                [NameInMap("MaxLockTime")]
                [Validation(Required=false)]
                public long? MaxLockTime { get; set; }

                [NameInMap("MaxLogicalReadCounts")]
                [Validation(Required=false)]
                public long? MaxLogicalReadCounts { get; set; }

                [NameInMap("MaxPhysicalReadCounts")]
                [Validation(Required=false)]
                public long? MaxPhysicalReadCounts { get; set; }

                [NameInMap("MaxRowsAffectedCounts")]
                [Validation(Required=false)]
                public long? MaxRowsAffectedCounts { get; set; }

                [NameInMap("MinIOWriteCounts")]
                [Validation(Required=false)]
                public long? MinIOWriteCounts { get; set; }

                [NameInMap("MinLastRowsAffectedCounts")]
                [Validation(Required=false)]
                public long? MinLastRowsAffectedCounts { get; set; }

                [NameInMap("MinLogicalReadCounts")]
                [Validation(Required=false)]
                public long? MinLogicalReadCounts { get; set; }

                [NameInMap("MinPhysicalReadCounts")]
                [Validation(Required=false)]
                public long? MinPhysicalReadCounts { get; set; }

                [NameInMap("MinRowsAffectedCounts")]
                [Validation(Required=false)]
                public long? MinRowsAffectedCounts { get; set; }

                [NameInMap("MySQLTotalExecutionCounts")]
                [Validation(Required=false)]
                public long? MySQLTotalExecutionCounts { get; set; }

                [NameInMap("MySQLTotalExecutionTimes")]
                [Validation(Required=false)]
                public long? MySQLTotalExecutionTimes { get; set; }

                [NameInMap("ParseMaxRowCount")]
                [Validation(Required=false)]
                public long? ParseMaxRowCount { get; set; }

                [NameInMap("ParseTotalRowCounts")]
                [Validation(Required=false)]
                public long? ParseTotalRowCounts { get; set; }

                [NameInMap("ReportTime")]
                [Validation(Required=false)]
                public string ReportTime { get; set; }

                [NameInMap("ReturnMaxRowCount")]
                [Validation(Required=false)]
                public long? ReturnMaxRowCount { get; set; }

                [NameInMap("ReturnTotalRowCounts")]
                [Validation(Required=false)]
                public long? ReturnTotalRowCounts { get; set; }

                [NameInMap("SQLHASH")]
                [Validation(Required=false)]
                public string SQLHASH { get; set; }

                [NameInMap("SQLIdStr")]
                [Validation(Required=false)]
                public string SQLIdStr { get; set; }

                [NameInMap("SQLServerAvgCpuTime")]
                [Validation(Required=false)]
                public long? SQLServerAvgCpuTime { get; set; }

                [NameInMap("SQLServerAvgExecutionTime")]
                [Validation(Required=false)]
                public long? SQLServerAvgExecutionTime { get; set; }

                [NameInMap("SQLServerMaxCpuTime")]
                [Validation(Required=false)]
                public long? SQLServerMaxCpuTime { get; set; }

                [NameInMap("SQLServerMinCpuTime")]
                [Validation(Required=false)]
                public long? SQLServerMinCpuTime { get; set; }

                [NameInMap("SQLServerMinExecutionTime")]
                [Validation(Required=false)]
                public long? SQLServerMinExecutionTime { get; set; }

                [NameInMap("SQLServerTotalCpuTime")]
                [Validation(Required=false)]
                public long? SQLServerTotalCpuTime { get; set; }

                [NameInMap("SQLServerTotalExecutionCounts")]
                [Validation(Required=false)]
                public long? SQLServerTotalExecutionCounts { get; set; }

                [NameInMap("SQLServerTotalExecutionTimes")]
                [Validation(Required=false)]
                public long? SQLServerTotalExecutionTimes { get; set; }

                [NameInMap("SQLText")]
                [Validation(Required=false)]
                public string SQLText { get; set; }

                [NameInMap("SlowLogId")]
                [Validation(Required=false)]
                public long? SlowLogId { get; set; }

                [NameInMap("TotalIOWriteCounts")]
                [Validation(Required=false)]
                public long? TotalIOWriteCounts { get; set; }

                [NameInMap("TotalLastRowsAffectedCounts")]
                [Validation(Required=false)]
                public long? TotalLastRowsAffectedCounts { get; set; }

                [NameInMap("TotalLockTimes")]
                [Validation(Required=false)]
                public long? TotalLockTimes { get; set; }

                [NameInMap("TotalLogicalReadCounts")]
                [Validation(Required=false)]
                public long? TotalLogicalReadCounts { get; set; }

                [NameInMap("TotalPhysicalReadCounts")]
                [Validation(Required=false)]
                public long? TotalPhysicalReadCounts { get; set; }

                [NameInMap("TotalRowsAffectedCounts")]
                [Validation(Required=false)]
                public long? TotalRowsAffectedCounts { get; set; }

            }

        }

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
