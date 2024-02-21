// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetPfsSqlSummariesResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code returned.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetPfsSqlSummariesResponseBodyData Data { get; set; }
        public class GetPfsSqlSummariesResponseBodyData : TeaModel {
            /// <summary>
            /// The reserved parameter.
            /// </summary>
            [NameInMap("Extra")]
            [Validation(Required=false)]
            public object Extra { get; set; }

            /// <summary>
            /// The detailed information.
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<GetPfsSqlSummariesResponseBodyDataList> List { get; set; }
            public class GetPfsSqlSummariesResponseBodyDataList : TeaModel {
                /// <summary>
                /// The average execution latency. Unit: millisecond.
                /// </summary>
                [NameInMap("AvgLatency")]
                [Validation(Required=false)]
                public double? AvgLatency { get; set; }

                /// <summary>
                /// The total number of executions.
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// The percentage of the number of executions.
                /// </summary>
                [NameInMap("CountRate")]
                [Validation(Required=false)]
                public double? CountRate { get; set; }

                /// <summary>
                /// The ratio of the CPU execution duration to the total execution duration of the SQL statement.
                /// </summary>
                [NameInMap("CpuRate")]
                [Validation(Required=false)]
                public double? CpuRate { get; set; }

                /// <summary>
                /// The CPU execution duration. Unit: millisecond.
                /// </summary>
                [NameInMap("CpuTime")]
                [Validation(Required=false)]
                public double? CpuTime { get; set; }

                /// <summary>
                /// The data read duration. Unit: millisecond.
                /// </summary>
                [NameInMap("DataReadTime")]
                [Validation(Required=false)]
                public double? DataReadTime { get; set; }

                /// <summary>
                /// The number of nodes from which data can be read.
                /// </summary>
                [NameInMap("DataReads")]
                [Validation(Required=false)]
                public int? DataReads { get; set; }

                /// <summary>
                /// The data write duration. Unit: millisecond.
                /// </summary>
                [NameInMap("DataWriteTime")]
                [Validation(Required=false)]
                public double? DataWriteTime { get; set; }

                /// <summary>
                /// The number of nodes to which data can be written.
                /// </summary>
                [NameInMap("DataWrites")]
                [Validation(Required=false)]
                public int? DataWrites { get; set; }

                /// <summary>
                /// The name of the database.
                /// </summary>
                [NameInMap("Db")]
                [Validation(Required=false)]
                public string Db { get; set; }

                /// <summary>
                /// The execution duration. Unit: millisecond.
                /// </summary>
                [NameInMap("ElapsedTime")]
                [Validation(Required=false)]
                public double? ElapsedTime { get; set; }

                /// <summary>
                /// The number of errors.
                /// </summary>
                [NameInMap("ErrCount")]
                [Validation(Required=false)]
                public long? ErrCount { get; set; }

                /// <summary>
                /// The time when the SQL statement was executed for the first time. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
                /// </summary>
                [NameInMap("FirstTime")]
                [Validation(Required=false)]
                public long? FirstTime { get; set; }

                /// <summary>
                /// Indicates whether full table scan was enabled. Valid values:
                /// 
                /// * **true**
                /// * **false**
                /// </summary>
                [NameInMap("FullScan")]
                [Validation(Required=false)]
                public bool? FullScan { get; set; }

                /// <summary>
                /// The primary key ID.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// The instance ID.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The time when the SQL statement was last modified. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
                /// </summary>
                [NameInMap("LastTime")]
                [Validation(Required=false)]
                public long? LastTime { get; set; }

                /// <summary>
                /// The average lock wait latency. Unit: millisecond.
                /// </summary>
                [NameInMap("LockLatencyAvg")]
                [Validation(Required=false)]
                public double? LockLatencyAvg { get; set; }

                /// <summary>
                /// The logical database ID.
                /// </summary>
                [NameInMap("LogicId")]
                [Validation(Required=false)]
                public long? LogicId { get; set; }

                /// <summary>
                /// The number of logical nodes.
                /// </summary>
                [NameInMap("LogicReads")]
                [Validation(Required=false)]
                public long? LogicReads { get; set; }

                /// <summary>
                /// The maximum execution latency. Unit: millisecond.
                /// </summary>
                [NameInMap("MaxLatency")]
                [Validation(Required=false)]
                public double? MaxLatency { get; set; }

                /// <summary>
                /// The number of mutex spins.
                /// </summary>
                [NameInMap("MutexSpins")]
                [Validation(Required=false)]
                public int? MutexSpins { get; set; }

                /// <summary>
                /// The number of mutex waits.
                /// </summary>
                [NameInMap("MutexWaits")]
                [Validation(Required=false)]
                public int? MutexWaits { get; set; }

                /// <summary>
                /// The node ID.
                /// 
                /// > This parameter is returned only if the database instance is an ApsaraDB RDS for MySQL Cluster Edition instance or a PolarDB for MySQL cluster.
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// The number of physical asynchronous nodes.
                /// </summary>
                [NameInMap("PhysicalAsyncReads")]
                [Validation(Required=false)]
                public long? PhysicalAsyncReads { get; set; }

                /// <summary>
                /// The number of physical nodes.
                /// </summary>
                [NameInMap("PhysicalReads")]
                [Validation(Required=false)]
                public long? PhysicalReads { get; set; }

                /// <summary>
                /// The SQL template.
                /// </summary>
                [NameInMap("Psql")]
                [Validation(Required=false)]
                public string Psql { get; set; }

                /// <summary>
                /// The number of redo nodes.
                /// </summary>
                [NameInMap("RedoWrites")]
                [Validation(Required=false)]
                public long? RedoWrites { get; set; }

                /// <summary>
                /// The number of rows that are affected by the SQL statement.
                /// </summary>
                [NameInMap("RowsAffected")]
                [Validation(Required=false)]
                public long? RowsAffected { get; set; }

                /// <summary>
                /// The average number of rows affected by the SQL statement.
                /// </summary>
                [NameInMap("RowsAffectedAvg")]
                [Validation(Required=false)]
                public double? RowsAffectedAvg { get; set; }

                /// <summary>
                /// The total number of scanned rows.
                /// </summary>
                [NameInMap("RowsExamined")]
                [Validation(Required=false)]
                public long? RowsExamined { get; set; }

                /// <summary>
                /// The average number of scanned rows.
                /// </summary>
                [NameInMap("RowsExaminedAvg")]
                [Validation(Required=false)]
                public double? RowsExaminedAvg { get; set; }

                /// <summary>
                /// The average number of returned rows.
                /// </summary>
                [NameInMap("RowsSendAvg")]
                [Validation(Required=false)]
                public double? RowsSendAvg { get; set; }

                /// <summary>
                /// The number of rows returned by the SQL statement.
                /// </summary>
                [NameInMap("RowsSent")]
                [Validation(Required=false)]
                public long? RowsSent { get; set; }

                /// <summary>
                /// The average number of rows returned for the SQL statement.
                /// </summary>
                [NameInMap("RowsSentAvg")]
                [Validation(Required=false)]
                public double? RowsSentAvg { get; set; }

                /// <summary>
                /// The number of sorted rows.
                /// </summary>
                [NameInMap("RowsSorted")]
                [Validation(Required=false)]
                public long? RowsSorted { get; set; }

                /// <summary>
                /// The execution duration percentage.
                /// </summary>
                [NameInMap("RtRate")]
                [Validation(Required=false)]
                public double? RtRate { get; set; }

                /// <summary>
                /// Indicates whether read/write splitting was enabled. Valid values:
                /// 
                /// * **0:** Read/write splitting was disabled.
                /// * **1:** Read/write splitting was enabled.
                /// </summary>
                [NameInMap("RwlockOsWaits")]
                [Validation(Required=false)]
                public int? RwlockOsWaits { get; set; }

                /// <summary>
                /// The read/write splitting parameters.
                /// </summary>
                [NameInMap("RwlockSpinRounds")]
                [Validation(Required=false)]
                public int? RwlockSpinRounds { get; set; }

                /// <summary>
                /// Indices whether multi-index scanning was enabled. Valid values:
                /// 
                /// * **0:** Multi-index scanning was disabled.
                /// * **1:** Multi-index scanning was enabled.
                /// </summary>
                [NameInMap("RwlockSpinWaits")]
                [Validation(Required=false)]
                public int? RwlockSpinWaits { get; set; }

                /// <summary>
                /// The average number of joins that performed table scans without using indexes.
                /// 
                /// > If the value of this parameter is not 0, check the table indexes.
                /// </summary>
                [NameInMap("SelectFullJoinAvg")]
                [Validation(Required=false)]
                public double? SelectFullJoinAvg { get; set; }

                /// <summary>
                /// The average number of joins that selected a range.
                /// </summary>
                [NameInMap("SelectFullRangeJoinAvg")]
                [Validation(Required=false)]
                public double? SelectFullRangeJoinAvg { get; set; }

                /// <summary>
                /// The average selected range.
                /// </summary>
                [NameInMap("SelectRangeAvg")]
                [Validation(Required=false)]
                public double? SelectRangeAvg { get; set; }

                /// <summary>
                /// The average number of scanned rows.
                /// </summary>
                [NameInMap("SelectScanAvg")]
                [Validation(Required=false)]
                public double? SelectScanAvg { get; set; }

                /// <summary>
                /// The semi-synchronous replication latency. Unit: millisecond.
                /// </summary>
                [NameInMap("SemisyncDelayTime")]
                [Validation(Required=false)]
                public double? SemisyncDelayTime { get; set; }

                /// <summary>
                /// The amount of time consumed for locking the server. Unit: millisecond.
                /// </summary>
                [NameInMap("ServerLockTime")]
                [Validation(Required=false)]
                public double? ServerLockTime { get; set; }

                /// <summary>
                /// The number of merges that the sorting algorithm must perform.
                /// </summary>
                [NameInMap("SortMergePasses")]
                [Validation(Required=false)]
                public long? SortMergePasses { get; set; }

                /// <summary>
                /// The average number of sorts that were performed by using a range.
                /// </summary>
                [NameInMap("SortRangeAvg")]
                [Validation(Required=false)]
                public double? SortRangeAvg { get; set; }

                /// <summary>
                /// The average number of sorted rows.
                /// </summary>
                [NameInMap("SortRowsAvg")]
                [Validation(Required=false)]
                public double? SortRowsAvg { get; set; }

                /// <summary>
                /// The average number of sorts that were performed during table scans.
                /// </summary>
                [NameInMap("SortScanAvg")]
                [Validation(Required=false)]
                public double? SortScanAvg { get; set; }

                /// <summary>
                /// The SQL template ID.
                /// </summary>
                [NameInMap("SqlId")]
                [Validation(Required=false)]
                public string SqlId { get; set; }

                /// <summary>
                /// The type of the SQL statement. Valid values:
                /// 
                /// * **SELECT**
                /// * **UPDATE**
                /// * **DELETE**
                /// </summary>
                [NameInMap("SqlType")]
                [Validation(Required=false)]
                public string SqlType { get; set; }

                /// <summary>
                /// The names of tables in the database.
                /// </summary>
                [NameInMap("Tables")]
                [Validation(Required=false)]
                public List<string> Tables { get; set; }

                /// <summary>
                /// The reserved parameter.
                /// </summary>
                [NameInMap("TimerWaitAvg")]
                [Validation(Required=false)]
                public double? TimerWaitAvg { get; set; }

                /// <summary>
                /// The data timestamp. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

                /// <summary>
                /// The number of on-disk temporary tables.
                /// </summary>
                [NameInMap("TmpDiskTables")]
                [Validation(Required=false)]
                public long? TmpDiskTables { get; set; }

                /// <summary>
                /// The average number of on-disk temporary tables.
                /// </summary>
                [NameInMap("TmpDiskTablesAvg")]
                [Validation(Required=false)]
                public double? TmpDiskTablesAvg { get; set; }

                /// <summary>
                /// The number of temporary tables.
                /// </summary>
                [NameInMap("TmpTables")]
                [Validation(Required=false)]
                public long? TmpTables { get; set; }

                /// <summary>
                /// The average number of temporary tables.
                /// </summary>
                [NameInMap("TmpTablesAvg")]
                [Validation(Required=false)]
                public double? TmpTablesAvg { get; set; }

                /// <summary>
                /// The execution latency. Unit: millisecond.
                /// </summary>
                [NameInMap("TotalLatency")]
                [Validation(Required=false)]
                public double? TotalLatency { get; set; }

                /// <summary>
                /// The amount of time consumed for locking the storage transaction. Unit: millisecond.
                /// </summary>
                [NameInMap("TransactionLockTime")]
                [Validation(Required=false)]
                public double? TransactionLockTime { get; set; }

                /// <summary>
                /// The user ID.
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// The number of warnings.
                /// </summary>
                [NameInMap("WarnCount")]
                [Validation(Required=false)]
                public long? WarnCount { get; set; }

            }

            /// <summary>
            /// The page number.
            /// </summary>
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public long? PageNo { get; set; }

            /// <summary>
            /// The number of entries per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// The returned message.
        /// 
        /// >  If the request was successful, **Successful** is returned. If the request failed, an error message such as an error code is returned.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
