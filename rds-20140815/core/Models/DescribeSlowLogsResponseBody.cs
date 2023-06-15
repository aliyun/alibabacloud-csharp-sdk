// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeSlowLogsResponseBody : TeaModel {
        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The end date of the time range that was queried.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The database engine of the instance.
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// An array that consists of the information about each slow query.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeSlowLogsResponseBodyItems Items { get; set; }
        public class DescribeSlowLogsResponseBodyItems : TeaModel {
            [NameInMap("SQLSlowLog")]
            [Validation(Required=false)]
            public List<DescribeSlowLogsResponseBodyItemsSQLSlowLog> SQLSlowLog { get; set; }
            public class DescribeSlowLogsResponseBodyItemsSQLSlowLog : TeaModel {
                /// <summary>
                /// The average execution duration per SQL statement in the query. Unit: seconds.
                /// 
                /// >  This parameter is returned only for instances that run SQL Server.
                /// </summary>
                [NameInMap("AvgExecutionTime")]
                [Validation(Required=false)]
                public long? AvgExecutionTime { get; set; }

                /// <summary>
                /// The average number of I/O writes per SQL statement in the query.
                /// 
                /// >  This parameter is returned only for instances that run SQL Server.
                /// </summary>
                [NameInMap("AvgIOWriteCounts")]
                [Validation(Required=false)]
                public long? AvgIOWriteCounts { get; set; }

                /// <summary>
                /// The average number of rows that are affected by the last SQL statement in the query.
                /// 
                /// >  This parameter is returned only for instances that run SQL Server.
                /// </summary>
                [NameInMap("AvgLastRowsAffectedCounts")]
                [Validation(Required=false)]
                public long? AvgLastRowsAffectedCounts { get; set; }

                /// <summary>
                /// The average number of logical reads per SQL statement in the query.
                /// 
                /// >  This parameter is returned only for instances that run SQL Server.
                /// </summary>
                [NameInMap("AvgLogicalReadCounts")]
                [Validation(Required=false)]
                public long? AvgLogicalReadCounts { get; set; }

                /// <summary>
                /// The average number of physical reads per SQL statement in the query.
                /// 
                /// >  This parameter is returned only for instances that run SQL Server.
                /// </summary>
                [NameInMap("AvgPhysicalReadCounts")]
                [Validation(Required=false)]
                public long? AvgPhysicalReadCounts { get; set; }

                /// <summary>
                /// The average number of rows that were affected per SQL statement in the query.
                /// 
                /// >  This parameter is returned only for instances that run SQL Server.
                /// </summary>
                [NameInMap("AvgRowsAffectedCounts")]
                [Validation(Required=false)]
                public long? AvgRowsAffectedCounts { get; set; }

                /// <summary>
                /// The date when the data was generated.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// The name of the database that was queried.
                /// </summary>
                [NameInMap("DBName")]
                [Validation(Required=false)]
                public string DBName { get; set; }

                /// <summary>
                /// The longest execution duration of a specific SQL statement in the query. Unit: seconds.
                /// </summary>
                [NameInMap("MaxExecutionTime")]
                [Validation(Required=false)]
                public long? MaxExecutionTime { get; set; }

                [NameInMap("MaxExecutionTimeMS")]
                [Validation(Required=false)]
                public long? MaxExecutionTimeMS { get; set; }

                /// <summary>
                /// The largest number of I/O writes that were performed by a specific SQL statement in the query.
                /// 
                /// >  This parameter is returned only for instances that run SQL Server.
                /// </summary>
                [NameInMap("MaxIOWriteCounts")]
                [Validation(Required=false)]
                public long? MaxIOWriteCounts { get; set; }

                /// <summary>
                /// The largest number of rows that were affected by the last SQL statement in the query.
                /// 
                /// >  This parameter is returned only for instances that run SQL Server.
                /// </summary>
                [NameInMap("MaxLastRowsAffectedCounts")]
                [Validation(Required=false)]
                public long? MaxLastRowsAffectedCounts { get; set; }

                /// <summary>
                /// The longest lock duration that was caused by a specific SQL statement in the query. Unit: seconds.
                /// </summary>
                [NameInMap("MaxLockTime")]
                [Validation(Required=false)]
                public long? MaxLockTime { get; set; }

                [NameInMap("MaxLockTimeMS")]
                [Validation(Required=false)]
                public long? MaxLockTimeMS { get; set; }

                /// <summary>
                /// The largest number of logical reads that were performed by a specific SQL statement in the query.
                /// 
                /// >  This parameter is returned only for instances that run SQL Server.
                /// </summary>
                [NameInMap("MaxLogicalReadCounts")]
                [Validation(Required=false)]
                public long? MaxLogicalReadCounts { get; set; }

                /// <summary>
                /// The largest number of physical reads that were performed by a specific SQL statement in the query.
                /// 
                /// >  This parameter is returned only for instances that run SQL Server.
                /// </summary>
                [NameInMap("MaxPhysicalReadCounts")]
                [Validation(Required=false)]
                public long? MaxPhysicalReadCounts { get; set; }

                /// <summary>
                /// The largest number of rows that were affected by a specific SQL statement in the query.
                /// 
                /// >  This parameter is returned only for instances that run SQL Server.
                /// </summary>
                [NameInMap("MaxRowsAffectedCounts")]
                [Validation(Required=false)]
                public long? MaxRowsAffectedCounts { get; set; }

                /// <summary>
                /// The smallest number of I/O writes that were performed by a specific SQL statement in the query.
                /// 
                /// >  This parameter is returned only for instances that run SQL Server.
                /// </summary>
                [NameInMap("MinIOWriteCounts")]
                [Validation(Required=false)]
                public long? MinIOWriteCounts { get; set; }

                /// <summary>
                /// The smallest number of rows that were affected by the last SQL statement in the query.
                /// 
                /// >  This parameter is returned only for instances that run SQL Server.
                /// </summary>
                [NameInMap("MinLastRowsAffectedCounts")]
                [Validation(Required=false)]
                public long? MinLastRowsAffectedCounts { get; set; }

                /// <summary>
                /// The smallest number of logical reads that were performed by a specific SQL statement in the query.
                /// 
                /// >  This parameter is returned only for instances that run SQL Server.
                /// </summary>
                [NameInMap("MinLogicalReadCounts")]
                [Validation(Required=false)]
                public long? MinLogicalReadCounts { get; set; }

                /// <summary>
                /// The smallest number of physical reads that were performed by a specific SQL statement in the query.
                /// 
                /// >  This parameter is returned only for instances that run SQL Server.
                /// </summary>
                [NameInMap("MinPhysicalReadCounts")]
                [Validation(Required=false)]
                public long? MinPhysicalReadCounts { get; set; }

                /// <summary>
                /// The smallest number of rows that were affected by a specific SQL statement in the query.
                /// 
                /// >  This parameter is returned only for instances that run SQL Server.
                /// </summary>
                [NameInMap("MinRowsAffectedCounts")]
                [Validation(Required=false)]
                public long? MinRowsAffectedCounts { get; set; }

                /// <summary>
                /// The total number of SQL statements that were executed in the query. This parameter is returned only for instances that run MySQL.
                /// </summary>
                [NameInMap("MySQLTotalExecutionCounts")]
                [Validation(Required=false)]
                public long? MySQLTotalExecutionCounts { get; set; }

                /// <summary>
                /// The total execution duration of all SQL statements in the query. This parameter is returned only for instances that run MySQL. Unit: seconds.
                /// </summary>
                [NameInMap("MySQLTotalExecutionTimes")]
                [Validation(Required=false)]
                public long? MySQLTotalExecutionTimes { get; set; }

                /// <summary>
                /// The largest number of rows that were parsed by a specific SQL statement in the query.
                /// </summary>
                [NameInMap("ParseMaxRowCount")]
                [Validation(Required=false)]
                public long? ParseMaxRowCount { get; set; }

                /// <summary>
                /// The total number of rows that were parsed by all SQL statements in the query.
                /// </summary>
                [NameInMap("ParseTotalRowCounts")]
                [Validation(Required=false)]
                public long? ParseTotalRowCounts { get; set; }

                /// <summary>
                /// The date on which the data report was generated.
                /// </summary>
                [NameInMap("ReportTime")]
                [Validation(Required=false)]
                public string ReportTime { get; set; }

                /// <summary>
                /// The largest number of rows that were returned by a specific SQL statement in the query.
                /// </summary>
                [NameInMap("ReturnMaxRowCount")]
                [Validation(Required=false)]
                public long? ReturnMaxRowCount { get; set; }

                /// <summary>
                /// The total number of rows that were returned by all SQL statements in the query.
                /// </summary>
                [NameInMap("ReturnTotalRowCounts")]
                [Validation(Required=false)]
                public long? ReturnTotalRowCounts { get; set; }

                /// <summary>
                /// The unique ID of the SQL statement. The ID is used to obtain the slow query logs of the SQL statement.
                /// </summary>
                [NameInMap("SQLHASH")]
                [Validation(Required=false)]
                public string SQLHASH { get; set; }

                /// <summary>
                /// The ID of the SQL statement in the statistical template of slow query logs. This parameter is replaced by the **SQLHASH** parameter.
                /// </summary>
                [NameInMap("SQLIdStr")]
                [Validation(Required=false)]
                public string SQLIdStr { get; set; }

                /// <summary>
                /// The average amount of CPU time per SQL statement in the query. Unit: seconds.
                /// 
                /// >  This parameter is returned only for instances that run SQL Server.
                /// </summary>
                [NameInMap("SQLServerAvgCpuTime")]
                [Validation(Required=false)]
                public long? SQLServerAvgCpuTime { get; set; }

                /// <summary>
                /// The average execution duration per SQL statement in the query. Unit: seconds.
                /// 
                /// >  This parameter is returned only for instances that run SQL Server.
                /// </summary>
                [NameInMap("SQLServerAvgExecutionTime")]
                [Validation(Required=false)]
                public long? SQLServerAvgExecutionTime { get; set; }

                /// <summary>
                /// The largest amount of CPU time that was used by a specific SQL statement in the query. Unit: seconds.
                /// 
                /// >  This parameter is returned only for instances that run SQL Server.
                /// </summary>
                [NameInMap("SQLServerMaxCpuTime")]
                [Validation(Required=false)]
                public long? SQLServerMaxCpuTime { get; set; }

                /// <summary>
                /// The smallest amount of CPU time that was used by a specific SQL statement. Unit: seconds.
                /// 
                /// >  This parameter is returned only for instances that run SQL Server.
                /// </summary>
                [NameInMap("SQLServerMinCpuTime")]
                [Validation(Required=false)]
                public long? SQLServerMinCpuTime { get; set; }

                /// <summary>
                /// The smallest execution duration of a specific SQL statement in the query. Unit: seconds.
                /// 
                /// >  This parameter is returned only for instances that run SQL Server.
                /// </summary>
                [NameInMap("SQLServerMinExecutionTime")]
                [Validation(Required=false)]
                public long? SQLServerMinExecutionTime { get; set; }

                /// <summary>
                /// The total amount of CPU time that was used by all SQL statements in the query. Unit: seconds.
                /// 
                /// >  This parameter is returned only for instances that run SQL Server.
                /// </summary>
                [NameInMap("SQLServerTotalCpuTime")]
                [Validation(Required=false)]
                public long? SQLServerTotalCpuTime { get; set; }

                /// <summary>
                /// The total number of SQL statements that were executed in the query. This parameter is returned only for instances that run SQL Server.
                /// </summary>
                [NameInMap("SQLServerTotalExecutionCounts")]
                [Validation(Required=false)]
                public long? SQLServerTotalExecutionCounts { get; set; }

                /// <summary>
                /// The total execution duration of all SQL statements in the query. This parameter is returned only for instances that run SQL Server. Unit: milliseconds.
                /// </summary>
                [NameInMap("SQLServerTotalExecutionTimes")]
                [Validation(Required=false)]
                public long? SQLServerTotalExecutionTimes { get; set; }

                /// <summary>
                /// The SQL statement that was executed in the query.
                /// </summary>
                [NameInMap("SQLText")]
                [Validation(Required=false)]
                public string SQLText { get; set; }

                /// <summary>
                /// The ID of the slow query log summary.
                /// </summary>
                [NameInMap("SlowLogId")]
                [Validation(Required=false)]
                public long? SlowLogId { get; set; }

                /// <summary>
                /// The total number of I/O writes that were performed by all SQL statements in the query.
                /// 
                /// >  This parameter is returned only for instances that run SQL Server.
                /// </summary>
                [NameInMap("TotalIOWriteCounts")]
                [Validation(Required=false)]
                public long? TotalIOWriteCounts { get; set; }

                /// <summary>
                /// The total number of rows that were affected by the last SQL statement in the query.
                /// 
                /// >  This parameter is returned only for instances that run SQL Server.
                /// </summary>
                [NameInMap("TotalLastRowsAffectedCounts")]
                [Validation(Required=false)]
                public long? TotalLastRowsAffectedCounts { get; set; }

                /// <summary>
                /// The total lock duration that was caused by all SQL statements in the query. Unit: seconds.
                /// </summary>
                [NameInMap("TotalLockTimes")]
                [Validation(Required=false)]
                public long? TotalLockTimes { get; set; }

                /// <summary>
                /// The total number of logical reads that were performed by all SQL statements in the query.
                /// </summary>
                [NameInMap("TotalLogicalReadCounts")]
                [Validation(Required=false)]
                public long? TotalLogicalReadCounts { get; set; }

                /// <summary>
                /// The total number of physical reads that were performed by all SQL statements in the query.
                /// </summary>
                [NameInMap("TotalPhysicalReadCounts")]
                [Validation(Required=false)]
                public long? TotalPhysicalReadCounts { get; set; }

                /// <summary>
                /// The total number of rows that were affected by all SQL statements in the query.
                /// </summary>
                [NameInMap("TotalRowsAffectedCounts")]
                [Validation(Required=false)]
                public long? TotalRowsAffectedCounts { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of SQL statements that are returned on the current page.
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The start date of the time range that was queried.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The total number of entries that are returned.
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
