// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetPfsSqlSummariesResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetPfsSqlSummariesResponseBodyData Data { get; set; }
        public class GetPfsSqlSummariesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The reserved parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("Extra")]
            [Validation(Required=false)]
            public object Extra { get; set; }

            /// <summary>
            /// <para>The details of the data returned.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<GetPfsSqlSummariesResponseBodyDataList> List { get; set; }
            public class GetPfsSqlSummariesResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>The average execution latency. Unit: millisecond.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.1717</para>
                /// </summary>
                [NameInMap("AvgLatency")]
                [Validation(Required=false)]
                public double? AvgLatency { get; set; }

                /// <summary>
                /// <para>The total number of executions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100000</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>The percentage of the number of executions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0586</para>
                /// </summary>
                [NameInMap("CountRate")]
                [Validation(Required=false)]
                public double? CountRate { get; set; }

                /// <summary>
                /// <para>The ratio of the CPU execution duration to the total execution duration of the SQL statement.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CpuRate")]
                [Validation(Required=false)]
                public double? CpuRate { get; set; }

                /// <summary>
                /// <para>The CPU execution duration. Unit: millisecond.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CpuTime")]
                [Validation(Required=false)]
                public double? CpuTime { get; set; }

                /// <summary>
                /// <para>The data read duration. Unit: millisecond.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DataReadTime")]
                [Validation(Required=false)]
                public double? DataReadTime { get; set; }

                /// <summary>
                /// <para>The number of nodes from which data can be read.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DataReads")]
                [Validation(Required=false)]
                public int? DataReads { get; set; }

                /// <summary>
                /// <para>The data write duration. Unit: millisecond.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DataWriteTime")]
                [Validation(Required=false)]
                public double? DataWriteTime { get; set; }

                /// <summary>
                /// <para>The number of nodes to which data can be written.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DataWrites")]
                [Validation(Required=false)]
                public int? DataWrites { get; set; }

                /// <summary>
                /// <para>The name of the database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testDB</para>
                /// </summary>
                [NameInMap("Db")]
                [Validation(Required=false)]
                public string Db { get; set; }

                /// <summary>
                /// <para>The execution duration. Unit: millisecond.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ElapsedTime")]
                [Validation(Required=false)]
                public double? ElapsedTime { get; set; }

                /// <summary>
                /// <para>The number of errors.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ErrCount")]
                [Validation(Required=false)]
                public long? ErrCount { get; set; }

                /// <summary>
                /// <para>The time when the SQL statement was executed for the first time. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1659308149000</para>
                /// </summary>
                [NameInMap("FirstTime")]
                [Validation(Required=false)]
                public long? FirstTime { get; set; }

                /// <summary>
                /// <para>Indicates whether full table scan was enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("FullScan")]
                [Validation(Required=false)]
                public bool? FullScan { get; set; }

                /// <summary>
                /// <para>The primary key ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>26186357</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-2ze8g2am97624****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The time when the SQL statement was last modified. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1661306520000</para>
                /// </summary>
                [NameInMap("LastTime")]
                [Validation(Required=false)]
                public long? LastTime { get; set; }

                /// <summary>
                /// <para>The average lock wait latency. Unit: millisecond.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("LockLatencyAvg")]
                [Validation(Required=false)]
                public double? LockLatencyAvg { get; set; }

                /// <summary>
                /// <para>The logical database ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>58275984</para>
                /// </summary>
                [NameInMap("LogicId")]
                [Validation(Required=false)]
                public long? LogicId { get; set; }

                /// <summary>
                /// <para>The number of logical nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("LogicReads")]
                [Validation(Required=false)]
                public long? LogicReads { get; set; }

                /// <summary>
                /// <para>The maximum execution latency. Unit: millisecond.</para>
                /// 
                /// <b>Example:</b>
                /// <para>36.233</para>
                /// </summary>
                [NameInMap("MaxLatency")]
                [Validation(Required=false)]
                public double? MaxLatency { get; set; }

                /// <summary>
                /// <para>The number of mutex spins.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MutexSpins")]
                [Validation(Required=false)]
                public int? MutexSpins { get; set; }

                /// <summary>
                /// <para>The number of mutex waits.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MutexWaits")]
                [Validation(Required=false)]
                public int? MutexWaits { get; set; }

                /// <summary>
                /// <para>The node ID.</para>
                /// <remarks>
                /// <para> This parameter is returned only if the database instance is an ApsaraDB RDS for MySQL Cluster Edition instance or a PolarDB for MySQL cluster.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>r-x****-db-0</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <para>The number of physical asynchronous nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PhysicalAsyncReads")]
                [Validation(Required=false)]
                public long? PhysicalAsyncReads { get; set; }

                /// <summary>
                /// <para>The number of physical nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PhysicalReads")]
                [Validation(Required=false)]
                public long? PhysicalReads { get; set; }

                /// <summary>
                /// <para>The SQL template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>select ?</para>
                /// </summary>
                [NameInMap("Psql")]
                [Validation(Required=false)]
                public string Psql { get; set; }

                /// <summary>
                /// <para>The number of redo nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RedoWrites")]
                [Validation(Required=false)]
                public long? RedoWrites { get; set; }

                /// <summary>
                /// <para>The number of rows that are affected by the SQL statement.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RowsAffected")]
                [Validation(Required=false)]
                public long? RowsAffected { get; set; }

                /// <summary>
                /// <para>The average number of rows affected by the SQL statement.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RowsAffectedAvg")]
                [Validation(Required=false)]
                public double? RowsAffectedAvg { get; set; }

                /// <summary>
                /// <para>The total number of scanned rows.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("RowsExamined")]
                [Validation(Required=false)]
                public long? RowsExamined { get; set; }

                /// <summary>
                /// <para>The average number of scanned rows.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RowsExaminedAvg")]
                [Validation(Required=false)]
                public double? RowsExaminedAvg { get; set; }

                /// <summary>
                /// <para>The average number of returned rows.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RowsSendAvg")]
                [Validation(Required=false)]
                public double? RowsSendAvg { get; set; }

                /// <summary>
                /// <para>The number of rows returned by the SQL statement.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RowsSent")]
                [Validation(Required=false)]
                public long? RowsSent { get; set; }

                /// <summary>
                /// <para>The average number of rows returned for the SQL statement.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.52</para>
                /// </summary>
                [NameInMap("RowsSentAvg")]
                [Validation(Required=false)]
                public double? RowsSentAvg { get; set; }

                /// <summary>
                /// <para>The number of sorted rows.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RowsSorted")]
                [Validation(Required=false)]
                public long? RowsSorted { get; set; }

                /// <summary>
                /// <para>The execution duration percentage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.1384</para>
                /// </summary>
                [NameInMap("RtRate")]
                [Validation(Required=false)]
                public double? RtRate { get; set; }

                /// <summary>
                /// <para>Indicates whether read/write splitting was enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0:</b> Read/write splitting was disabled.</description></item>
                /// <item><description><b>1:</b> Read/write splitting was enabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RwlockOsWaits")]
                [Validation(Required=false)]
                public int? RwlockOsWaits { get; set; }

                /// <summary>
                /// <para>The read/write splitting parameters.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RwlockSpinRounds")]
                [Validation(Required=false)]
                public int? RwlockSpinRounds { get; set; }

                /// <summary>
                /// <para>Indices whether multi-index scanning was enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0:</b> Multi-index scanning was disabled.</description></item>
                /// <item><description><b>1:</b> Multi-index scanning was enabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RwlockSpinWaits")]
                [Validation(Required=false)]
                public int? RwlockSpinWaits { get; set; }

                /// <summary>
                /// <para>The average number of joins that performed table scans without using indexes.</para>
                /// <remarks>
                /// <para>If the value of this parameter is not 0, check the table indexes.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SelectFullJoinAvg")]
                [Validation(Required=false)]
                public double? SelectFullJoinAvg { get; set; }

                /// <summary>
                /// <para>The average number of joins that selected a range.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SelectFullRangeJoinAvg")]
                [Validation(Required=false)]
                public double? SelectFullRangeJoinAvg { get; set; }

                /// <summary>
                /// <para>The average selected range.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SelectRangeAvg")]
                [Validation(Required=false)]
                public double? SelectRangeAvg { get; set; }

                /// <summary>
                /// <para>The average number of scanned rows.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SelectScanAvg")]
                [Validation(Required=false)]
                public double? SelectScanAvg { get; set; }

                /// <summary>
                /// <para>The semi-synchronous replication latency. Unit: millisecond.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.12</para>
                /// </summary>
                [NameInMap("SemisyncDelayTime")]
                [Validation(Required=false)]
                public double? SemisyncDelayTime { get; set; }

                /// <summary>
                /// <para>The amount of time consumed for locking the server. Unit: millisecond.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ServerLockTime")]
                [Validation(Required=false)]
                public double? ServerLockTime { get; set; }

                /// <summary>
                /// <para>The number of merges that the sorting algorithm must perform.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SortMergePasses")]
                [Validation(Required=false)]
                public long? SortMergePasses { get; set; }

                /// <summary>
                /// <para>The average number of sorts that were performed by using a range.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SortRangeAvg")]
                [Validation(Required=false)]
                public double? SortRangeAvg { get; set; }

                /// <summary>
                /// <para>The average number of sorted rows.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SortRowsAvg")]
                [Validation(Required=false)]
                public double? SortRowsAvg { get; set; }

                /// <summary>
                /// <para>The average number of sorts that were performed during table scans.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SortScanAvg")]
                [Validation(Required=false)]
                public double? SortScanAvg { get; set; }

                /// <summary>
                /// <para>The SQL template ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2e8147b5ca2dfc640dfd5e43d96a****</para>
                /// </summary>
                [NameInMap("SqlId")]
                [Validation(Required=false)]
                public string SqlId { get; set; }

                /// <summary>
                /// <para>The type of the SQL statement. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>SELECT</b></description></item>
                /// <item><description><b>UPDATE</b></description></item>
                /// <item><description><b>DELETE</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SELECT</para>
                /// </summary>
                [NameInMap("SqlType")]
                [Validation(Required=false)]
                public string SqlType { get; set; }

                /// <summary>
                /// <para>The names of tables in the database.</para>
                /// </summary>
                [NameInMap("Tables")]
                [Validation(Required=false)]
                public List<string> Tables { get; set; }

                /// <summary>
                /// <para>The reserved parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>None</para>
                /// </summary>
                [NameInMap("TimerWaitAvg")]
                [Validation(Required=false)]
                public double? TimerWaitAvg { get; set; }

                /// <summary>
                /// <para>The data timestamp. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1643040000000</para>
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

                /// <summary>
                /// <para>The number of on-disk temporary tables.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TmpDiskTables")]
                [Validation(Required=false)]
                public long? TmpDiskTables { get; set; }

                /// <summary>
                /// <para>The average number of on-disk temporary tables.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TmpDiskTablesAvg")]
                [Validation(Required=false)]
                public double? TmpDiskTablesAvg { get; set; }

                /// <summary>
                /// <para>The number of temporary tables.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TmpTables")]
                [Validation(Required=false)]
                public long? TmpTables { get; set; }

                /// <summary>
                /// <para>The average number of temporary tables.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TmpTablesAvg")]
                [Validation(Required=false)]
                public double? TmpTablesAvg { get; set; }

                /// <summary>
                /// <para>The execution latency. Unit: millisecond.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60913.256</para>
                /// </summary>
                [NameInMap("TotalLatency")]
                [Validation(Required=false)]
                public double? TotalLatency { get; set; }

                /// <summary>
                /// <para>The amount of time consumed for locking the storage transaction. Unit: millisecond.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TransactionLockTime")]
                [Validation(Required=false)]
                public double? TransactionLockTime { get; set; }

                /// <summary>
                /// <para>The user ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>196278346919****</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>The number of warnings.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("WarnCount")]
                [Validation(Required=false)]
                public long? WarnCount { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public long? PageNo { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>264</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// <remarks>
        /// <para> If the request was successful, <b>Successful</b> is returned. If the request failed, an error message such as an error code is returned.</para>
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
        /// <para>54F3DBAE-9420-511A-9C29-265E8C04****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
