// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeSlowLogsResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5xxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The end date of the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2011-05-30Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The database engine of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>An array that consists of the information about each slow query log.</para>
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
                /// <para>The average execution duration per SQL statement in the query. Unit: seconds.</para>
                /// <remarks>
                /// <para> This parameter is returned only for instances that run SQL Server.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AvgExecutionTime")]
                [Validation(Required=false)]
                public long? AvgExecutionTime { get; set; }

                /// <summary>
                /// <para>The average number of I/O writes per SQL statement in the query.</para>
                /// <remarks>
                /// <para> This parameter is returned only for instances that run SQL Server.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AvgIOWriteCounts")]
                [Validation(Required=false)]
                public long? AvgIOWriteCounts { get; set; }

                /// <summary>
                /// <para>The average number of rows that were affected by the last SQL statement in the query.</para>
                /// <remarks>
                /// <para> This parameter is returned only for instances that run SQL Server.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AvgLastRowsAffectedCounts")]
                [Validation(Required=false)]
                public long? AvgLastRowsAffectedCounts { get; set; }

                /// <summary>
                /// <para>The average number of logical reads per SQL statement in the query.</para>
                /// <remarks>
                /// <para> This parameter is returned only for instances that run SQL Server.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AvgLogicalReadCounts")]
                [Validation(Required=false)]
                public long? AvgLogicalReadCounts { get; set; }

                /// <summary>
                /// <para>The average number of physical reads per SQL statement in the query.</para>
                /// <remarks>
                /// <para> This parameter is returned only for instances that run SQL Server.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AvgPhysicalReadCounts")]
                [Validation(Required=false)]
                public long? AvgPhysicalReadCounts { get; set; }

                /// <summary>
                /// <para>The average number of rows that were affected per SQL statement in the query.</para>
                /// <remarks>
                /// <para> This parameter is returned only for instances that run SQL Server.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AvgRowsAffectedCounts")]
                [Validation(Required=false)]
                public long? AvgRowsAffectedCounts { get; set; }

                /// <summary>
                /// <para>The date when the data was generated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2011-05-30Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The name of the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RDS_MySQL</para>
                /// </summary>
                [NameInMap("DBName")]
                [Validation(Required=false)]
                public string DBName { get; set; }

                /// <summary>
                /// <para>The longest execution duration of a specific SQL statement in the query. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("MaxExecutionTime")]
                [Validation(Required=false)]
                public long? MaxExecutionTime { get; set; }

                /// <summary>
                /// <para>The longest execution duration of a specific SQL statement in the query. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60000</para>
                /// </summary>
                [NameInMap("MaxExecutionTimeMS")]
                [Validation(Required=false)]
                public long? MaxExecutionTimeMS { get; set; }

                /// <summary>
                /// <para>The largest number of I/O writes that were performed by a specific SQL statement in the query.</para>
                /// <remarks>
                /// <para> This parameter is returned only for instances that run SQL Server.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MaxIOWriteCounts")]
                [Validation(Required=false)]
                public long? MaxIOWriteCounts { get; set; }

                /// <summary>
                /// <para>The largest number of rows that were affected by the last SQL statement in the query.</para>
                /// <remarks>
                /// <para> This parameter is returned only for instances that run SQL Server.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MaxLastRowsAffectedCounts")]
                [Validation(Required=false)]
                public long? MaxLastRowsAffectedCounts { get; set; }

                /// <summary>
                /// <para>The longest lock duration that was caused by a specific SQL statement in the query. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MaxLockTime")]
                [Validation(Required=false)]
                public long? MaxLockTime { get; set; }

                /// <summary>
                /// <para>The longest lock duration that was caused by a specific SQL statement in the query. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("MaxLockTimeMS")]
                [Validation(Required=false)]
                public long? MaxLockTimeMS { get; set; }

                /// <summary>
                /// <para>The largest number of logical reads that were performed by a specific SQL statement in the query.</para>
                /// <remarks>
                /// <para> This parameter is returned only for instances that run SQL Server.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MaxLogicalReadCounts")]
                [Validation(Required=false)]
                public long? MaxLogicalReadCounts { get; set; }

                /// <summary>
                /// <para>The largest number of physical reads that were performed by a specific SQL statement in the query.</para>
                /// <remarks>
                /// <para> This parameter is returned only for instances that run SQL Server.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MaxPhysicalReadCounts")]
                [Validation(Required=false)]
                public long? MaxPhysicalReadCounts { get; set; }

                /// <summary>
                /// <para>The largest number of rows that were affected by a specific SQL statement in the query.</para>
                /// <remarks>
                /// <para> This parameter is returned only for instances that run SQL Server.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MaxRowsAffectedCounts")]
                [Validation(Required=false)]
                public long? MaxRowsAffectedCounts { get; set; }

                /// <summary>
                /// <para>The smallest number of I/O writes that were performed by a specific SQL statement in the query.</para>
                /// <remarks>
                /// <para> This parameter is returned only for instances that run SQL Server.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MinIOWriteCounts")]
                [Validation(Required=false)]
                public long? MinIOWriteCounts { get; set; }

                /// <summary>
                /// <para>The smallest number of rows that were affected by the last SQL statement in the query.</para>
                /// <remarks>
                /// <para> This parameter is returned only for instances that run SQL Server.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MinLastRowsAffectedCounts")]
                [Validation(Required=false)]
                public long? MinLastRowsAffectedCounts { get; set; }

                /// <summary>
                /// <para>The smallest number of logical reads that were performed by a specific SQL statement in the query.</para>
                /// <remarks>
                /// <para> This parameter is returned only for instances that run SQL Server.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MinLogicalReadCounts")]
                [Validation(Required=false)]
                public long? MinLogicalReadCounts { get; set; }

                /// <summary>
                /// <para>The smallest number of physical reads that were performed by a specific SQL statement in the query.</para>
                /// <remarks>
                /// <para> This parameter is returned only for instances that run SQL Server.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MinPhysicalReadCounts")]
                [Validation(Required=false)]
                public long? MinPhysicalReadCounts { get; set; }

                /// <summary>
                /// <para>The smallest number of rows that were affected by a specific SQL statement in the query.</para>
                /// <remarks>
                /// <para> This parameter is returned only for instances that run SQL Server.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MinRowsAffectedCounts")]
                [Validation(Required=false)]
                public long? MinRowsAffectedCounts { get; set; }

                /// <summary>
                /// <para>The total number of SQL statements that were executed in the query. This parameter is returned only for instances that run MySQL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MySQLTotalExecutionCounts")]
                [Validation(Required=false)]
                public long? MySQLTotalExecutionCounts { get; set; }

                /// <summary>
                /// <para>The total execution duration of all SQL statements in the query. Unit: seconds. This parameter is returned only for instances that run MySQL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MySQLTotalExecutionTimes")]
                [Validation(Required=false)]
                public long? MySQLTotalExecutionTimes { get; set; }

                /// <summary>
                /// <para>The largest number of rows that were parsed by a specific SQL statement in the query.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ParseMaxRowCount")]
                [Validation(Required=false)]
                public long? ParseMaxRowCount { get; set; }

                /// <summary>
                /// <para>The total number of rows that were parsed by all SQL statements in the query.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ParseTotalRowCounts")]
                [Validation(Required=false)]
                public long? ParseTotalRowCounts { get; set; }

                /// <summary>
                /// <para>The date on which the data report was generated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2011-05-30Z</para>
                /// </summary>
                [NameInMap("ReportTime")]
                [Validation(Required=false)]
                public string ReportTime { get; set; }

                /// <summary>
                /// <para>The largest number of rows that were returned by a specific SQL statement in the query.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ReturnMaxRowCount")]
                [Validation(Required=false)]
                public long? ReturnMaxRowCount { get; set; }

                /// <summary>
                /// <para>The total number of rows that were returned by all SQL statements in the query.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ReturnTotalRowCounts")]
                [Validation(Required=false)]
                public long? ReturnTotalRowCounts { get; set; }

                /// <summary>
                /// <para>The unique ID of the SQL statement. The ID is used to obtain the slow query logs of the SQL statement.</para>
                /// 
                /// <b>Example:</b>
                /// <para>U2FsdGVkxxxx</para>
                /// </summary>
                [NameInMap("SQLHASH")]
                [Validation(Required=false)]
                public string SQLHASH { get; set; }

                /// <summary>
                /// <para>The ID of the SQL statement in the statistical template of slow query logs. This parameter is replaced by the <b>SQLHASH</b> parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>521584</para>
                /// </summary>
                [NameInMap("SQLIdStr")]
                [Validation(Required=false)]
                public string SQLIdStr { get; set; }

                /// <summary>
                /// <para>The average amount of CPU time per SQL statement in the query. Unit: seconds.</para>
                /// <remarks>
                /// <para> This parameter is returned only for instances that run SQL Server.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SQLServerAvgCpuTime")]
                [Validation(Required=false)]
                public long? SQLServerAvgCpuTime { get; set; }

                /// <summary>
                /// <para>The average execution duration per SQL statement in the query. Unit: seconds.</para>
                /// <remarks>
                /// <para> This parameter is returned only for instances that run SQL Server.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SQLServerAvgExecutionTime")]
                [Validation(Required=false)]
                public long? SQLServerAvgExecutionTime { get; set; }

                /// <summary>
                /// <para>The largest amount of CPU time that was used by a specific SQL statement in the query. Unit: seconds.</para>
                /// <remarks>
                /// <para> This parameter is returned only for instances that run SQL Server.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SQLServerMaxCpuTime")]
                [Validation(Required=false)]
                public long? SQLServerMaxCpuTime { get; set; }

                /// <summary>
                /// <para>The smallest amount of CPU time that was used by a specific SQL statement in the query. Unit: seconds.</para>
                /// <remarks>
                /// <para> This parameter is returned only for instances that run SQL Server.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SQLServerMinCpuTime")]
                [Validation(Required=false)]
                public long? SQLServerMinCpuTime { get; set; }

                /// <summary>
                /// <para>The smallest execution duration of a specific SQL statement in the query. Unit: seconds.</para>
                /// <remarks>
                /// <para> This parameter is returned only for instances that run SQL Server.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SQLServerMinExecutionTime")]
                [Validation(Required=false)]
                public long? SQLServerMinExecutionTime { get; set; }

                /// <summary>
                /// <para>The total amount of CPU time that was used by all SQL statements in the query. Unit: seconds.</para>
                /// <remarks>
                /// <para> This parameter is returned only for instances that run SQL Server.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SQLServerTotalCpuTime")]
                [Validation(Required=false)]
                public long? SQLServerTotalCpuTime { get; set; }

                /// <summary>
                /// <para>The total number of SQL statements that were executed in the query. This parameter is returned only for instances that run SQL Server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SQLServerTotalExecutionCounts")]
                [Validation(Required=false)]
                public long? SQLServerTotalExecutionCounts { get; set; }

                /// <summary>
                /// <para>The total execution duration of all SQL statements in the query. This parameter is returned only for instances that run SQL Server. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("SQLServerTotalExecutionTimes")]
                [Validation(Required=false)]
                public long? SQLServerTotalExecutionTimes { get; set; }

                /// <summary>
                /// <para>The SQL statement that was executed in the query.</para>
                /// 
                /// <b>Example:</b>
                /// <para>select id,name from tb_table</para>
                /// </summary>
                [NameInMap("SQLText")]
                [Validation(Required=false)]
                public string SQLText { get; set; }

                /// <summary>
                /// <para>The ID of the slow query log summary.</para>
                /// 
                /// <b>Example:</b>
                /// <para>26584213</para>
                /// </summary>
                [NameInMap("SlowLogId")]
                [Validation(Required=false)]
                public long? SlowLogId { get; set; }

                /// <summary>
                /// <para>The total number of I/O writes that were performed by all SQL statements in the query.</para>
                /// <remarks>
                /// <para> This parameter is returned only for instances that run SQL Server.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalIOWriteCounts")]
                [Validation(Required=false)]
                public long? TotalIOWriteCounts { get; set; }

                /// <summary>
                /// <para>The total number of rows that were affected by the last SQL statement in the query.</para>
                /// <remarks>
                /// <para> This parameter is returned only for instances that run SQL Server.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalLastRowsAffectedCounts")]
                [Validation(Required=false)]
                public long? TotalLastRowsAffectedCounts { get; set; }

                /// <summary>
                /// <para>The total lock duration that was caused by all SQL statements in the query. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalLockTimes")]
                [Validation(Required=false)]
                public long? TotalLockTimes { get; set; }

                /// <summary>
                /// <para>The total number of logical reads that were performed by all SQL statements in the query.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TotalLogicalReadCounts")]
                [Validation(Required=false)]
                public long? TotalLogicalReadCounts { get; set; }

                /// <summary>
                /// <para>The total number of physical reads that were performed by all SQL statements in the query.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("TotalPhysicalReadCounts")]
                [Validation(Required=false)]
                public long? TotalPhysicalReadCounts { get; set; }

                /// <summary>
                /// <para>The total number of rows that were affected by all SQL statements in the query.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalRowsAffectedCounts")]
                [Validation(Required=false)]
                public long? TotalRowsAffectedCounts { get; set; }

            }

        }

        /// <summary>
        /// <para>The number of the page returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of SQL statements that are returned on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2553A660-E4EB-4AF4-A402-8AFF70A49143</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The start date of the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2011-05-30Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The total number of entries that are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
