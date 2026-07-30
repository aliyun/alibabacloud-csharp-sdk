// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeSlowLogStatisticResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>AsyncResult\&lt;DBLogRecords\<SlowLogStat>&gt;</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeSlowLogStatisticResponseBodyData Data { get; set; }
        public class DescribeSlowLogStatisticResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The data.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public DescribeSlowLogStatisticResponseBodyDataData Data { get; set; }
            public class DescribeSlowLogStatisticResponseBodyDataData : TeaModel {
                /// <summary>
                /// <para>The numeric ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-k2ja51w7cnusg5a1x</para>
                /// </summary>
                [NameInMap("DbInstanceId")]
                [Validation(Required=false)]
                public long? DbInstanceId { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DbInstanceName")]
                [Validation(Required=false)]
                public string DbInstanceName { get; set; }

                /// <summary>
                /// <para>The end time of the query. This value is a UNIX timestamp. Unit: milliseconds.</para>
                /// <remarks>
                /// <para>The end time must be later than the start time.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2024-08-08T02:15:00Z</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The number of items in the slow query log list on the current page.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("ItemsNumbers")]
                [Validation(Required=false)]
                public long? ItemsNumbers { get; set; }

                /// <summary>
                /// <para>The name of the operation object.</para>
                /// </summary>
                [NameInMap("Logs")]
                [Validation(Required=false)]
                public List<DescribeSlowLogStatisticResponseBodyDataDataLogs> Logs { get; set; }
                public class DescribeSlowLogStatisticResponseBodyDataDataLogs : TeaModel {
                    /// <summary>
                    /// <para>The database account.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>edu_admin</para>
                    /// </summary>
                    [NameInMap("AccountName")]
                    [Validation(Required=false)]
                    public string AccountName { get; set; }

                    /// <summary>
                    /// <para>This parameter is deprecated.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <list type="bullet">
                    /// <item><description></description></item>
                    /// </list>
                    /// </summary>
                    [NameInMap("AvgCPUTime")]
                    [Validation(Required=false)]
                    public double? AvgCPUTime { get; set; }

                    /// <summary>
                    /// <para>The average CPU time for the query in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>456</para>
                    /// </summary>
                    [NameInMap("AvgCPUTimeSeconds")]
                    [Validation(Required=false)]
                    public double? AvgCPUTimeSeconds { get; set; }

                    /// <summary>
                    /// <para>The average number of scanned documents.</para>
                    /// <remarks>
                    /// <para>This parameter is supported only by ApsaraDB for MongoDB instances.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10000</para>
                    /// </summary>
                    [NameInMap("AvgDocExamined")]
                    [Validation(Required=false)]
                    public double? AvgDocExamined { get; set; }

                    /// <summary>
                    /// <para>The average number of pulled rows.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("AvgFrows")]
                    [Validation(Required=false)]
                    public double? AvgFrows { get; set; }

                    /// <summary>
                    /// <para>The average number of I/O writes.</para>
                    /// <remarks>
                    /// <para>This parameter is supported only by ApsaraDB RDS for SQL Server instances.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("AvgIOWrites")]
                    [Validation(Required=false)]
                    public double? AvgIOWrites { get; set; }

                    /// <summary>
                    /// <para>The average number of index scans.</para>
                    /// <remarks>
                    /// <para>This parameter is supported only by ApsaraDB for MongoDB instances.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20000</para>
                    /// </summary>
                    [NameInMap("AvgKeysExamined")]
                    [Validation(Required=false)]
                    public double? AvgKeysExamined { get; set; }

                    /// <summary>
                    /// <para>The average number of rows affected by the last statement.</para>
                    /// <remarks>
                    /// <para>This parameter is supported only by ApsaraDB RDS for SQL Server instances.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("AvgLastRowsCountAffected")]
                    [Validation(Required=false)]
                    public double? AvgLastRowsCountAffected { get; set; }

                    /// <summary>
                    /// <para>This parameter is deprecated.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <list type="bullet">
                    /// <item><description></description></item>
                    /// </list>
                    /// </summary>
                    [NameInMap("AvgLockTime")]
                    [Validation(Required=false)]
                    public double? AvgLockTime { get; set; }

                    /// <summary>
                    /// <para>The average lock wait time in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.0</para>
                    /// </summary>
                    [NameInMap("AvgLockTimeSeconds")]
                    [Validation(Required=false)]
                    public double? AvgLockTimeSeconds { get; set; }

                    /// <summary>
                    /// <para>The average number of logical reads.</para>
                    /// <remarks>
                    /// <para>This parameter is supported only by ApsaraDB RDS for SQL Server instances.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("AvgLogicalIOReads")]
                    [Validation(Required=false)]
                    public double? AvgLogicalIOReads { get; set; }

                    /// <summary>
                    /// <para>The average number of physical reads.</para>
                    /// <remarks>
                    /// <para>This parameter is supported only by ApsaraDB RDS for SQL Server instances.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("AvgPhysicalIOReads")]
                    [Validation(Required=false)]
                    public double? AvgPhysicalIOReads { get; set; }

                    /// <summary>
                    /// <para>This parameter is deprecated.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <list type="bullet">
                    /// <item><description></description></item>
                    /// </list>
                    /// </summary>
                    [NameInMap("AvgQueryTime")]
                    [Validation(Required=false)]
                    public double? AvgQueryTime { get; set; }

                    /// <summary>
                    /// <para>The average query duration in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>6.211</para>
                    /// </summary>
                    [NameInMap("AvgQueryTimeSeconds")]
                    [Validation(Required=false)]
                    public double? AvgQueryTimeSeconds { get; set; }

                    /// <summary>
                    /// <para>The average size of the request in bytes. This parameter is valid only for Redis.</para>
                    /// </summary>
                    [NameInMap("AvgRequestSize")]
                    [Validation(Required=false)]
                    public double? AvgRequestSize { get; set; }

                    /// <summary>
                    /// <para>The average size of the response in bytes. This parameter is valid only for Redis.</para>
                    /// </summary>
                    [NameInMap("AvgResponseSize")]
                    [Validation(Required=false)]
                    public double? AvgResponseSize { get; set; }

                    /// <summary>
                    /// <para>The average number of returned rows.</para>
                    /// <remarks>
                    /// <para>This parameter is supported only by MongoDB instances.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("AvgReturnNum")]
                    [Validation(Required=false)]
                    public double? AvgReturnNum { get; set; }

                    /// <summary>
                    /// <para>The average number of rows.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("AvgRows")]
                    [Validation(Required=false)]
                    public double? AvgRows { get; set; }

                    /// <summary>
                    /// <para>The average number of affected rows.</para>
                    /// <remarks>
                    /// <para>This parameter is supported only by ApsaraDB RDS for SQL Server instances.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("AvgRowsCountAffected")]
                    [Validation(Required=false)]
                    public double? AvgRowsCountAffected { get; set; }

                    /// <summary>
                    /// <para>The average number of scanned rows.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>53421.0</para>
                    /// </summary>
                    [NameInMap("AvgRowsExamined")]
                    [Validation(Required=false)]
                    public double? AvgRowsExamined { get; set; }

                    /// <summary>
                    /// <para>The average number of returned rows.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2.0</para>
                    /// </summary>
                    [NameInMap("AvgRowsSent")]
                    [Validation(Required=false)]
                    public double? AvgRowsSent { get; set; }

                    /// <summary>
                    /// <para>The average execution duration.</para>
                    /// </summary>
                    [NameInMap("AvgRt")]
                    [Validation(Required=false)]
                    public double? AvgRt { get; set; }

                    /// <summary>
                    /// <para>The average number of requests.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("AvgScnt")]
                    [Validation(Required=false)]
                    public double? AvgScnt { get; set; }

                    /// <summary>
                    /// <para>This parameter is deprecated.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <list type="bullet">
                    /// <item><description></description></item>
                    /// </list>
                    /// </summary>
                    [NameInMap("CPUTime")]
                    [Validation(Required=false)]
                    public double? CPUTime { get; set; }

                    /// <summary>
                    /// <para>The CPU time for the query in seconds.</para>
                    /// <remarks>
                    /// <para>This parameter is supported only by ApsaraDB RDS for SQL Server instances.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>456</para>
                    /// </summary>
                    [NameInMap("CPUTimeSeconds")]
                    [Validation(Required=false)]
                    public double? CPUTimeSeconds { get; set; }

                    /// <summary>
                    /// <para>The client\&quot;s IP address.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10.57.84.109</para>
                    /// </summary>
                    [NameInMap("ClientIp")]
                    [Validation(Required=false)]
                    public string ClientIp { get; set; }

                    /// <summary>
                    /// <para>The executed command. This parameter is valid only for Redis.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>systemctl restart nginx.service</para>
                    /// </summary>
                    [NameInMap("Cmd")]
                    [Validation(Required=false)]
                    public string Cmd { get; set; }

                    /// <summary>
                    /// <para>The slow query statement.</para>
                    /// <remarks>
                    /// <para>This parameter is supported only by Tair (Redis OSS-compatible) instances.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SELECT b?.id,b?.t?,b?.id,b?.t? FROM testtb? b? JOIN testtb? b? ON b?.id=b?.id WHERE b?.t? LIKE ? ORDER BY b?.t? DESC</para>
                    /// </summary>
                    [NameInMap("Command")]
                    [Validation(Required=false)]
                    public string Command { get; set; }

                    /// <summary>
                    /// <para>The number of elements that correspond to the key.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12</para>
                    /// </summary>
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public long? Count { get; set; }

                    /// <summary>
                    /// <para>The execution ratio.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.2034</para>
                    /// </summary>
                    [NameInMap("CountRate")]
                    [Validation(Required=false)]
                    public double? CountRate { get; set; }

                    /// <summary>
                    /// <para>The database name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>member_score</para>
                    /// </summary>
                    [NameInMap("DBName")]
                    [Validation(Required=false)]
                    public string DBName { get; set; }

                    /// <summary>
                    /// <para>The database name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>work-wechat-api</para>
                    /// </summary>
                    [NameInMap("Database")]
                    [Validation(Required=false)]
                    public string Database { get; set; }

                    /// <summary>
                    /// <para>The database ID. This parameter is valid only for Redis.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("DbId")]
                    [Validation(Required=false)]
                    public string DbId { get; set; }

                    /// <summary>
                    /// <para>The instance ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("DbInstanceName")]
                    [Validation(Required=false)]
                    public string DbInstanceName { get; set; }

                    /// <summary>
                    /// <para>The number of scanned documents.</para>
                    /// <remarks>
                    /// <para>This parameter is supported only by ApsaraDB for MongoDB instances.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2000000</para>
                    /// </summary>
                    [NameInMap("DocExamined")]
                    [Validation(Required=false)]
                    public long? DocExamined { get; set; }

                    /// <summary>
                    /// <para>The number of documents scanned during the operation on the ApsaraDB for MongoDB instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("DocsExamined")]
                    [Validation(Required=false)]
                    public long? DocsExamined { get; set; }

                    /// <summary>
                    /// <para>The number of rows pulled by the compute nodes (CNs) of the PolarDB-X 2.0 instance.</para>
                    /// <remarks>
                    /// <para>This parameter is supported only by PolarDB-X 2.0 instances.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Frows")]
                    [Validation(Required=false)]
                    public long? Frows { get; set; }

                    /// <summary>
                    /// <para>The trend chart data.</para>
                    /// </summary>
                    [NameInMap("Histogram")]
                    [Validation(Required=false)]
                    public DescribeSlowLogStatisticResponseBodyDataDataLogsHistogram Histogram { get; set; }
                    public class DescribeSlowLogStatisticResponseBodyDataDataLogsHistogram : TeaModel {
                        /// <summary>
                        /// <para>The average lock wait time in seconds.</para>
                        /// </summary>
                        [NameInMap("AvgLockTime")]
                        [Validation(Required=false)]
                        public List<double?> AvgLockTime { get; set; }

                        /// <summary>
                        /// <para>The average number of scanned rows.</para>
                        /// </summary>
                        [NameInMap("AvgRowsExamined")]
                        [Validation(Required=false)]
                        public List<double?> AvgRowsExamined { get; set; }

                        /// <summary>
                        /// <para>The average number of returned rows.</para>
                        /// </summary>
                        [NameInMap("AvgRowsSent")]
                        [Validation(Required=false)]
                        public List<double?> AvgRowsSent { get; set; }

                        /// <summary>
                        /// <para>The average execution duration.</para>
                        /// </summary>
                        [NameInMap("AvgRt")]
                        [Validation(Required=false)]
                        public List<double?> AvgRt { get; set; }

                        /// <summary>
                        /// <para>The number of slow query logs.</para>
                        /// </summary>
                        [NameInMap("Count")]
                        [Validation(Required=false)]
                        public List<long?> Count { get; set; }

                        /// <summary>
                        /// <para>The task status.</para>
                        /// </summary>
                        [NameInMap("Item")]
                        [Validation(Required=false)]
                        public List<DescribeSlowLogStatisticResponseBodyDataDataLogsHistogramItem> Item { get; set; }
                        public class DescribeSlowLogStatisticResponseBodyDataDataLogsHistogramItem : TeaModel {
                            /// <summary>
                            /// <para>The number of slow query logs.</para>
                            /// </summary>
                            [NameInMap("Count")]
                            [Validation(Required=false)]
                            public List<long?> Count { get; set; }

                            /// <summary>
                            /// <para>The node ID.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>r-bp1s1m8hwzrm77kfvz-db-0</para>
                            /// </summary>
                            [NameInMap("NodeId")]
                            [Validation(Required=false)]
                            public string NodeId { get; set; }

                        }

                        /// <summary>
                        /// <para>The lock wait time in milliseconds.</para>
                        /// </summary>
                        [NameInMap("LockTime")]
                        [Validation(Required=false)]
                        public List<double?> LockTime { get; set; }

                        /// <summary>
                        /// <para>The maximum lock wait time in seconds.</para>
                        /// </summary>
                        [NameInMap("MaxLockTime")]
                        [Validation(Required=false)]
                        public List<double?> MaxLockTime { get; set; }

                        /// <summary>
                        /// <para>The maximum number of scanned rows.</para>
                        /// </summary>
                        [NameInMap("MaxRowsExamined")]
                        [Validation(Required=false)]
                        public List<long?> MaxRowsExamined { get; set; }

                        /// <summary>
                        /// <para>The maximum number of returned rows.</para>
                        /// </summary>
                        [NameInMap("MaxRowsSent")]
                        [Validation(Required=false)]
                        public List<long?> MaxRowsSent { get; set; }

                        /// <summary>
                        /// <para>The maximum response time (RT) in milliseconds.</para>
                        /// </summary>
                        [NameInMap("MaxRt")]
                        [Validation(Required=false)]
                        public List<double?> MaxRt { get; set; }

                        /// <summary>
                        /// <para>The total number of scanned rows.</para>
                        /// <remarks>
                        /// <para>This parameter is supported by ApsaraDB RDS for MySQL, ApsaraDB RDS for PostgreSQL, and PolarDB for MySQL.</para>
                        /// </remarks>
                        /// </summary>
                        [NameInMap("RowsExamined")]
                        [Validation(Required=false)]
                        public List<long?> RowsExamined { get; set; }

                        /// <summary>
                        /// <para>The number of returned rows.</para>
                        /// </summary>
                        [NameInMap("RowsSent")]
                        [Validation(Required=false)]
                        public List<long?> RowsSent { get; set; }

                        /// <summary>
                        /// <para>The execution duration in seconds.</para>
                        /// </summary>
                        [NameInMap("Rt")]
                        [Validation(Required=false)]
                        public List<double?> Rt { get; set; }

                        /// <summary>
                        /// <para>The total number of entries returned for the query.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>7</para>
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                        /// <summary>
                        /// <para>The execution timestamp.</para>
                        /// </summary>
                        [NameInMap("Ts")]
                        [Validation(Required=false)]
                        public List<long?> Ts { get; set; }

                        /// <summary>
                        /// <para>This parameter is deprecated.</para>
                        /// </summary>
                        [NameInMap("TsEnd")]
                        [Validation(Required=false)]
                        public List<long?> TsEnd { get; set; }

                    }

                    /// <summary>
                    /// <para>The client IP address.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>172.23.142.178</para>
                    /// </summary>
                    [NameInMap("HostAddress")]
                    [Validation(Required=false)]
                    public string HostAddress { get; set; }

                    /// <summary>
                    /// <para>The ID of the host instance.</para>
                    /// <remarks>
                    /// <para>This parameter is supported only by ApsaraDB for MongoDB instances.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>mongo-abc123456</para>
                    /// </summary>
                    [NameInMap("HostInsId")]
                    [Validation(Required=false)]
                    public string HostInsId { get; set; }

                    /// <summary>
                    /// <para>The number of I/O writes.</para>
                    /// <remarks>
                    /// <para>This parameter is supported only by ApsaraDB RDS for SQL Server instances.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("IOWrites")]
                    [Validation(Required=false)]
                    public long? IOWrites { get; set; }

                    /// <summary>
                    /// <para>The shard name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rm-uf6zix1z2jh1y6fe5</para>
                    /// </summary>
                    [NameInMap("InsName")]
                    [Validation(Required=false)]
                    public string InsName { get; set; }

                    /// <summary>
                    /// <para>The instance role.</para>
                    /// <remarks>
                    /// <para>This parameter is supported only by MongoDB instances.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>__system</para>
                    /// </summary>
                    [NameInMap("InsRole")]
                    [Validation(Required=false)]
                    public string InsRole { get; set; }

                    /// <summary>
                    /// <para>The number of index scans on the ApsaraDB for MongoDB instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>20000</para>
                    /// </summary>
                    [NameInMap("KeysExamined")]
                    [Validation(Required=false)]
                    public long? KeysExamined { get; set; }

                    /// <summary>
                    /// <para>The number of rows affected by the last statement.</para>
                    /// <remarks>
                    /// <para>This parameter is supported only by ApsaraDB RDS for SQL Server instances.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("LastRowsCountAffected")]
                    [Validation(Required=false)]
                    public long? LastRowsCountAffected { get; set; }

                    /// <summary>
                    /// <para>This parameter is deprecated.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <list type="bullet">
                    /// <item><description></description></item>
                    /// </list>
                    /// </summary>
                    [NameInMap("LockTime")]
                    [Validation(Required=false)]
                    public double? LockTime { get; set; }

                    /// <summary>
                    /// <para>The lock wait time in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.0</para>
                    /// </summary>
                    [NameInMap("LockTimeSeconds")]
                    [Validation(Required=false)]
                    public double? LockTimeSeconds { get; set; }

                    /// <summary>
                    /// <para>The number of logical reads.</para>
                    /// <remarks>
                    /// <para>This parameter is supported only by ApsaraDB RDS for SQL Server instances.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("LogicalIOReads")]
                    [Validation(Required=false)]
                    public long? LogicalIOReads { get; set; }

                    /// <summary>
                    /// <para>This parameter is deprecated.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <list type="bullet">
                    /// <item><description></description></item>
                    /// </list>
                    /// </summary>
                    [NameInMap("MaxCPUTime")]
                    [Validation(Required=false)]
                    public double? MaxCPUTime { get; set; }

                    /// <summary>
                    /// <para>The longest CPU time for the query in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>456</para>
                    /// </summary>
                    [NameInMap("MaxCPUTimeSeconds")]
                    [Validation(Required=false)]
                    public double? MaxCPUTimeSeconds { get; set; }

                    /// <summary>
                    /// <para>The maximum number of scanned documents.</para>
                    /// <remarks>
                    /// <para>This parameter is supported only by ApsaraDB for MongoDB instances.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000000</para>
                    /// </summary>
                    [NameInMap("MaxDocExamined")]
                    [Validation(Required=false)]
                    public long? MaxDocExamined { get; set; }

                    /// <summary>
                    /// <para>The maximum number of pulled rows.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("MaxFrows")]
                    [Validation(Required=false)]
                    public long? MaxFrows { get; set; }

                    /// <summary>
                    /// <para>The maximum number of I/O writes.</para>
                    /// <remarks>
                    /// <para>This parameter is supported only by ApsaraDB RDS for SQL Server instances.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("MaxIOWrites")]
                    [Validation(Required=false)]
                    public long? MaxIOWrites { get; set; }

                    /// <summary>
                    /// <para>The maximum number of index scans.</para>
                    /// <remarks>
                    /// <para>This parameter is supported only by ApsaraDB for MongoDB instances.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2000000</para>
                    /// </summary>
                    [NameInMap("MaxKeysExamined")]
                    [Validation(Required=false)]
                    public long? MaxKeysExamined { get; set; }

                    /// <summary>
                    /// <para>The maximum number of rows affected by the last statement.</para>
                    /// <remarks>
                    /// <para>This parameter is supported only by ApsaraDB RDS for SQL Server instances.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("MaxLastRowsCountAffected")]
                    [Validation(Required=false)]
                    public long? MaxLastRowsCountAffected { get; set; }

                    /// <summary>
                    /// <para>This parameter is deprecated.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <list type="bullet">
                    /// <item><description></description></item>
                    /// </list>
                    /// </summary>
                    [NameInMap("MaxLockTime")]
                    [Validation(Required=false)]
                    public double? MaxLockTime { get; set; }

                    /// <summary>
                    /// <para>The maximum lock wait time in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.0</para>
                    /// </summary>
                    [NameInMap("MaxLockTimeSeconds")]
                    [Validation(Required=false)]
                    public double? MaxLockTimeSeconds { get; set; }

                    /// <summary>
                    /// <para>The maximum number of logical reads.</para>
                    /// <remarks>
                    /// <para>This parameter is supported only by ApsaraDB RDS for SQL Server instances.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("MaxLogicalIOReads")]
                    [Validation(Required=false)]
                    public long? MaxLogicalIOReads { get; set; }

                    /// <summary>
                    /// <para>The maximum number of physical reads.</para>
                    /// <remarks>
                    /// <para>This parameter is supported only by ApsaraDB RDS for SQL Server instances.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("MaxPhysicalIOReads")]
                    [Validation(Required=false)]
                    public long? MaxPhysicalIOReads { get; set; }

                    /// <summary>
                    /// <para>This parameter is deprecated.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <list type="bullet">
                    /// <item><description></description></item>
                    /// </list>
                    /// </summary>
                    [NameInMap("MaxQueryTime")]
                    [Validation(Required=false)]
                    public double? MaxQueryTime { get; set; }

                    /// <summary>
                    /// <para>The maximum query duration in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>14.402</para>
                    /// </summary>
                    [NameInMap("MaxQueryTimeSeconds")]
                    [Validation(Required=false)]
                    public double? MaxQueryTimeSeconds { get; set; }

                    /// <summary>
                    /// <para>The maximum size of the request in bytes. This parameter is valid only for Redis.</para>
                    /// </summary>
                    [NameInMap("MaxRequestSize")]
                    [Validation(Required=false)]
                    public double? MaxRequestSize { get; set; }

                    /// <summary>
                    /// <para>The maximum size of the response in bytes. This parameter is valid only for Redis.</para>
                    /// </summary>
                    [NameInMap("MaxResponseSize")]
                    [Validation(Required=false)]
                    public double? MaxResponseSize { get; set; }

                    /// <summary>
                    /// <para>The maximum number of returned rows.</para>
                    /// <remarks>
                    /// <para>This parameter is supported only by ApsaraDB for MongoDB instances.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("MaxReturnNum")]
                    [Validation(Required=false)]
                    public long? MaxReturnNum { get; set; }

                    /// <summary>
                    /// <para>The maximum number of rows.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("MaxRows")]
                    [Validation(Required=false)]
                    public long? MaxRows { get; set; }

                    /// <summary>
                    /// <para>The maximum number of affected rows.</para>
                    /// <remarks>
                    /// <para>This parameter is supported only by ApsaraDB RDS for SQL Server instances.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("MaxRowsCountAffected")]
                    [Validation(Required=false)]
                    public long? MaxRowsCountAffected { get; set; }

                    /// <summary>
                    /// <para>The maximum number of scanned rows.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>318613</para>
                    /// </summary>
                    [NameInMap("MaxRowsExamined")]
                    [Validation(Required=false)]
                    public long? MaxRowsExamined { get; set; }

                    /// <summary>
                    /// <para>The maximum number of returned rows.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>256</para>
                    /// </summary>
                    [NameInMap("MaxRowsSent")]
                    [Validation(Required=false)]
                    public long? MaxRowsSent { get; set; }

                    /// <summary>
                    /// <para>The maximum execution duration in seconds.</para>
                    /// </summary>
                    [NameInMap("MaxRt")]
                    [Validation(Required=false)]
                    public double? MaxRt { get; set; }

                    /// <summary>
                    /// <para>The maximum number of requests.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("MaxScnt")]
                    [Validation(Required=false)]
                    public long? MaxScnt { get; set; }

                    /// <summary>
                    /// <para>The namespace.</para>
                    /// <remarks>
                    /// <para>This parameter is supported only by ApsaraDB for MongoDB instances.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>database.collection</para>
                    /// </summary>
                    [NameInMap("Namespace")]
                    [Validation(Required=false)]
                    public string Namespace { get; set; }

                    /// <summary>
                    /// <para>The node type.</para>
                    /// <remarks>
                    /// <para>This parameter is supported by MongoDB and Tair (Redis-compatible).</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DLNode</para>
                    /// </summary>
                    [NameInMap("NodeType")]
                    [Validation(Required=false)]
                    public string NodeType { get; set; }

                    /// <summary>
                    /// <para>The operation type.</para>
                    /// <remarks>
                    /// <para>This parameter is supported only by MongoDB instances.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Insert</para>
                    /// </summary>
                    [NameInMap("OpType")]
                    [Validation(Required=false)]
                    public string OpType { get; set; }

                    /// <summary>
                    /// <para>The alias of the source.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>order-1</para>
                    /// </summary>
                    [NameInMap("OriginAlias")]
                    [Validation(Required=false)]
                    public string OriginAlias { get; set; }

                    /// <summary>
                    /// <para>The number of physical reads.</para>
                    /// <remarks>
                    /// <para>This parameter is supported only by ApsaraDB RDS for SQL Server instances.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("PhysicalIOReads")]
                    [Validation(Required=false)]
                    public long? PhysicalIOReads { get; set; }

                    /// <summary>
                    /// <para>The SQL template.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SELECT b?.id,b?.t?,b?.id,b?.t? FROM testtb? b? JOIN testtb? b? ON b?.id=b?.id WHERE b?.t? LIKE ? ORDER BY b?.id DESC</para>
                    /// </summary>
                    [NameInMap("Psql")]
                    [Validation(Required=false)]
                    public string Psql { get; set; }

                    /// <summary>
                    /// <para>The query ID.</para>
                    /// <remarks>
                    /// <para>This parameter is supported only by ApsaraDB for MongoDB instances.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sq-1pzcdMwRb</para>
                    /// </summary>
                    [NameInMap("QueryId")]
                    [Validation(Required=false)]
                    public string QueryId { get; set; }

                    /// <summary>
                    /// <para>The time when the query started. The time is in the yyyy-MM-dd hh:mm:ss format and is in UTC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2024-12-25T03:00:00Z</para>
                    /// </summary>
                    [NameInMap("QueryStartTime")]
                    [Validation(Required=false)]
                    public string QueryStartTime { get; set; }

                    /// <summary>
                    /// <para>The threshold for the query execution time. Unit: milliseconds (ms).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>272.444</para>
                    /// </summary>
                    [NameInMap("QueryTime")]
                    [Validation(Required=false)]
                    public long? QueryTime { get; set; }

                    /// <summary>
                    /// <para>The ratio of the query duration.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.1018</para>
                    /// </summary>
                    [NameInMap("QueryTimeRate")]
                    [Validation(Required=false)]
                    public double? QueryTimeRate { get; set; }

                    /// <summary>
                    /// <para>The query duration in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>25.472</para>
                    /// </summary>
                    [NameInMap("QueryTimeSeconds")]
                    [Validation(Required=false)]
                    public double? QueryTimeSeconds { get; set; }

                    /// <summary>
                    /// <para>The number of items returned.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>暂无</para>
                    /// </summary>
                    [NameInMap("ReturnItemNumbers")]
                    [Validation(Required=false)]
                    public string ReturnItemNumbers { get; set; }

                    /// <summary>
                    /// <para>The number of returned rows.</para>
                    /// <remarks>
                    /// <para>This parameter is supported only by ApsaraDB for MongoDB instances.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("ReturnNum")]
                    [Validation(Required=false)]
                    public long? ReturnNum { get; set; }

                    /// <summary>
                    /// <para>The total number of rows updated or returned by the compute nodes of the PolarDB-X 2.0 instance.</para>
                    /// <remarks>
                    /// <para>This parameter is supported only by PolarDB-X 2.0 instances.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>105</para>
                    /// </summary>
                    [NameInMap("Rows")]
                    [Validation(Required=false)]
                    public long? Rows { get; set; }

                    /// <summary>
                    /// <para>The number of affected rows.</para>
                    /// <remarks>
                    /// <para>This parameter is supported only by ApsaraDB RDS for SQL Server instances.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("RowsCountAffected")]
                    [Validation(Required=false)]
                    public long? RowsCountAffected { get; set; }

                    /// <summary>
                    /// <para>The total number of scanned rows.</para>
                    /// <remarks>
                    /// <para>This parameter is supported by ApsaraDB RDS for MySQL, ApsaraDB RDS for PostgreSQL, and PolarDB for MySQL.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2444081</para>
                    /// </summary>
                    [NameInMap("RowsExamined")]
                    [Validation(Required=false)]
                    public long? RowsExamined { get; set; }

                    /// <summary>
                    /// <para>The number of returned rows.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>772</para>
                    /// </summary>
                    [NameInMap("RowsSent")]
                    [Validation(Required=false)]
                    public long? RowsSent { get; set; }

                    /// <summary>
                    /// <para>The rule ID. For more information, see <a href="https://help.aliyun.com/document_detail/290038.html">Query Governance</a>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>181**47</para>
                    /// </summary>
                    [NameInMap("RuleId")]
                    [Validation(Required=false)]
                    public string RuleId { get; set; }

                    /// <summary>
                    /// <para>The details of the SQL statement.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SELECT \&quot;Hello, World!\&quot; FROM DUAL</para>
                    /// </summary>
                    [NameInMap("SQLText")]
                    [Validation(Required=false)]
                    public string SQLText { get; set; }

                    /// <summary>
                    /// <para>HTTP or HTTPS.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>HTTP</para>
                    /// </summary>
                    [NameInMap("Scheme")]
                    [Validation(Required=false)]
                    public string Scheme { get; set; }

                    /// <summary>
                    /// <para>The number of requests sent from the compute nodes (CNs) to data nodes (DNs) in the PolarDB-X 2.0 instance.</para>
                    /// <remarks>
                    /// <para>This parameter is supported only by PolarDB-X 2.0 instances.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Scnt")]
                    [Validation(Required=false)]
                    public long? Scnt { get; set; }

                    /// <summary>
                    /// <para>The SQL ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2dca88762ec6b3812504ab8a4b******</para>
                    /// </summary>
                    [NameInMap("SqlId")]
                    [Validation(Required=false)]
                    public string SqlId { get; set; }

                    /// <summary>
                    /// <para>The tags.</para>
                    /// </summary>
                    [NameInMap("SqlTag")]
                    [Validation(Required=false)]
                    public DescribeSlowLogStatisticResponseBodyDataDataLogsSqlTag SqlTag { get; set; }
                    public class DescribeSlowLogStatisticResponseBodyDataDataLogsSqlTag : TeaModel {
                        /// <summary>
                        /// <para>The remarks.</para>
                        /// <para>The value can be 1 to 300 characters in length.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>dba 归档</para>
                        /// </summary>
                        [NameInMap("Comments")]
                        [Validation(Required=false)]
                        public string Comments { get; set; }

                        /// <summary>
                        /// <para>The SQL ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>a3931d8c3a9315dd5ed016d71cf*****</para>
                        /// </summary>
                        [NameInMap("SqlId")]
                        [Validation(Required=false)]
                        public string SqlId { get; set; }

                        /// <summary>
                        /// <para>The tags. Multiple tags are separated by commas (,).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>DAS_IN_PLAN</para>
                        /// </summary>
                        [NameInMap("Tags")]
                        [Validation(Required=false)]
                        public string Tags { get; set; }

                    }

                    /// <summary>
                    /// <para>The type of the SQL statement.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>LOGIN</para>
                    /// </summary>
                    [NameInMap("SqlType")]
                    [Validation(Required=false)]
                    public string SqlType { get; set; }

                    /// <summary>
                    /// <para>The ID of the sub-instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>r-8vba51c588ba3a94</para>
                    /// </summary>
                    [NameInMap("SubInstanceId")]
                    [Validation(Required=false)]
                    public string SubInstanceId { get; set; }

                    /// <summary>
                    /// <para>The table name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>users\nifconfig\n</para>
                    /// </summary>
                    [NameInMap("TableName")]
                    [Validation(Required=false)]
                    public string TableName { get; set; }

                    /// <summary>
                    /// <para>The thread ID. This parameter is returned only for PolarDB for MySQL instances.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("ThreadId")]
                    [Validation(Required=false)]
                    public string ThreadId { get; set; }

                    /// <summary>
                    /// <para>The execution time. This value is a UNIX timestamp. Unit: milliseconds (ms).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1708568930</para>
                    /// </summary>
                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public long? Timestamp { get; set; }

                    /// <summary>
                    /// <para>The total number of records. This parameter is valid only for Redis engines.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("TotalCount")]
                    [Validation(Required=false)]
                    public long? TotalCount { get; set; }

                    /// <summary>
                    /// <para>The slow log trends.</para>
                    /// </summary>
                    [NameInMap("Trend")]
                    [Validation(Required=false)]
                    public List<DescribeSlowLogStatisticResponseBodyDataDataLogsTrend> Trend { get; set; }
                    public class DescribeSlowLogStatisticResponseBodyDataDataLogsTrend : TeaModel {
                        /// <summary>
                        /// <para>The execution time. This value is a UNIX timestamp. Unit: milliseconds (ms).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1723775362</para>
                        /// </summary>
                        [NameInMap("Timestamp")]
                        [Validation(Required=false)]
                        public long? Timestamp { get; set; }

                        /// <summary>
                        /// <para>The value of the filter parameter.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>tf-testacc-oos-parameter</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public object Value { get; set; }

                    }

                    /// <summary>
                    /// <para>The user.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>user-1</para>
                    /// </summary>
                    [NameInMap("User")]
                    [Validation(Required=false)]
                    public string User { get; set; }

                }

                /// <summary>
                /// <para>The maximum number of entries to return on each page. Valid values: 5 to 100.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("MaxRecordsPerPage")]
                [Validation(Required=false)]
                public int? MaxRecordsPerPage { get; set; }

                /// <summary>
                /// <para>The node ID.</para>
                /// <para>For MongoDB instances, use this parameter to specify a node for storage analysis. Call the <a href="https://help.aliyun.com/document_detail/123802.html">DescribeRoleZoneInfo</a> operation to query the details of the nodes in a MongoDB instance.</para>
                /// <list type="bullet">
                /// <item><description><para>If you specify the <b>InsName</b> (node ID) of the destination node, such as <c>d-bp1872fa24d5****</c>, the system analyzes the corresponding hidden node.</para>
                /// </description></item>
                /// <item><description><para>If you specify <c>InsName#RoleId</c> of the destination node, such as <c>d-bp1872fa24d5****#299****5</c>, the system analyzes the specified node.</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <para>Notice: </para>
                /// </remarks>
                /// <para>For a MongoDB replica set instance, if you do not specify this parameter, the system analyzes the only hidden node by default. For a MongoDB sharded cluster instance, specify this parameter to select a destination node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pi-wz99g5rn7w1x8h0sf</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <para>The page number of the paged query. Pages start from 1. The default value is 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PageNumbers")]
                [Validation(Required=false)]
                public int? PageNumbers { get; set; }

                /// <summary>
                /// <para>The start time. This value is a UNIX timestamp. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-10-08T02:01:00Z</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The total number of entries.</para>
                /// 
                /// <b>Example:</b>
                /// <para>13</para>
                /// </summary>
                [NameInMap("TotalRecords")]
                [Validation(Required=false)]
                public long? TotalRecords { get; set; }

            }

            /// <summary>
            /// <para>The error code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10910</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public int? ErrorCode { get; set; }

            /// <summary>
            /// <para>Indicates whether the asynchronous request is complete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsFinish")]
            [Validation(Required=false)]
            public bool? IsFinish { get; set; }

            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Successful</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The key of the request parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456789</para>
            /// </summary>
            [NameInMap("RequestKey")]
            [Validation(Required=false)]
            public string RequestKey { get; set; }

            /// <summary>
            /// <para>The result ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>async__665ee69612f1627c7fd9f3c85075****</para>
            /// </summary>
            [NameInMap("ResultId")]
            [Validation(Required=false)]
            public string ResultId { get; set; }

            /// <summary>
            /// <para>The status of the asynchronous request. Valid values:</para>
            /// <para>-<b>RUNNING</b>: The request is in progress.</para>
            /// <para>-<b>SUCCESS</b>: The request is successful.</para>
            /// <para>-<b>FAIL</b>: The request failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The timestamp of the request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1735104224250</para>
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// <remarks>
        /// <para>If the request is successful, <b>Successful</b> is returned. If the request fails, an error message, such as an error code, is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>52D540CF-C517-1F57-BB42-9035F96******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b></para>
        /// </description></item>
        /// <item><description><para><b>false</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
