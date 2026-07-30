// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class GetPfsSqlSummariesResponseBody : TeaModel {
        /// <summary>
        /// <para>Response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// <para>Response data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetPfsSqlSummariesResponseBodyData Data { get; set; }
        public class GetPfsSqlSummariesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Reserved parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("Extra")]
            [Validation(Required=false)]
            public object Extra { get; set; }

            /// <summary>
            /// <para>Detailed information list.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<GetPfsSqlSummariesResponseBodyDataList> List { get; set; }
            public class GetPfsSqlSummariesResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>Average SQL execution duration, in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.1717</para>
                /// </summary>
                [NameInMap("AvgLatency")]
                [Validation(Required=false)]
                public double? AvgLatency { get; set; }

                /// <summary>
                /// <para>Total number of executions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100000</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public long? Count { get; set; }

                /// <summary>
                /// <para>Percentage of total executions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0586</para>
                /// </summary>
                [NameInMap("CountRate")]
                [Validation(Required=false)]
                public double? CountRate { get; set; }

                /// <summary>
                /// <para>Ratio of CPU execution time to total SQL execution time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CpuRate")]
                [Validation(Required=false)]
                public double? CpuRate { get; set; }

                /// <summary>
                /// <para>CPU runtime, in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CpuTime")]
                [Validation(Required=false)]
                public double? CpuTime { get; set; }

                /// <summary>
                /// <para>Data read time, in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DataReadTime")]
                [Validation(Required=false)]
                public double? DataReadTime { get; set; }

                /// <summary>
                /// <para>Number of readable data nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DataReads")]
                [Validation(Required=false)]
                public int? DataReads { get; set; }

                /// <summary>
                /// <para>Data write time, in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DataWriteTime")]
                [Validation(Required=false)]
                public double? DataWriteTime { get; set; }

                /// <summary>
                /// <para>Number of writable data nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DataWrites")]
                [Validation(Required=false)]
                public int? DataWrites { get; set; }

                /// <summary>
                /// <para>Database name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testDB</para>
                /// </summary>
                [NameInMap("Db")]
                [Validation(Required=false)]
                public string Db { get; set; }

                /// <summary>
                /// <para>Actual runtime, in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ElapsedTime")]
                [Validation(Required=false)]
                public double? ElapsedTime { get; set; }

                /// <summary>
                /// <para>Number of errors.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ErrCount")]
                [Validation(Required=false)]
                public long? ErrCount { get; set; }

                /// <summary>
                /// <para>First execution time, in Unix time format, in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1659308149000</para>
                /// </summary>
                [NameInMap("FirstTime")]
                [Validation(Required=false)]
                public long? FirstTime { get; set; }

                /// <summary>
                /// <para>Indicates whether a full table scan occurred. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b>: Yes.</para>
                /// </description></item>
                /// <item><description><para><b>false</b>: No.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("FullScan")]
                [Validation(Required=false)]
                public bool? FullScan { get; set; }

                /// <summary>
                /// <para>Primary key ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>26186357</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// <para>Instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-2ze8g2am97624****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>Last update time, in Unix time format, in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1661306520000</para>
                /// </summary>
                [NameInMap("LastTime")]
                [Validation(Required=false)]
                public long? LastTime { get; set; }

                /// <summary>
                /// <para>Average lock wait time, in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("LockLatencyAvg")]
                [Validation(Required=false)]
                public double? LockLatencyAvg { get; set; }

                /// <summary>
                /// <para>Logical database ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>58275984</para>
                /// </summary>
                [NameInMap("LogicId")]
                [Validation(Required=false)]
                public long? LogicId { get; set; }

                /// <summary>
                /// <para>Number of logical nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("LogicReads")]
                [Validation(Required=false)]
                public long? LogicReads { get; set; }

                /// <summary>
                /// <para>Maximum execution duration, in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>36.233</para>
                /// </summary>
                [NameInMap("MaxLatency")]
                [Validation(Required=false)]
                public double? MaxLatency { get; set; }

                /// <summary>
                /// <para>Number of mutex spins.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MutexSpins")]
                [Validation(Required=false)]
                public int? MutexSpins { get; set; }

                /// <summary>
                /// <para>Number of mutex waits.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MutexWaits")]
                [Validation(Required=false)]
                public int? MutexWaits { get; set; }

                /// <summary>
                /// <para>Node ID.</para>
                /// <remarks>
                /// <para>This parameter is returned for ApsaraDB RDS for MySQL Cluster Edition or PolarDB for MySQL database instances.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>r-x****-db-0</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <para>Number of physical asynchronous nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PhysicalAsyncReads")]
                [Validation(Required=false)]
                public long? PhysicalAsyncReads { get; set; }

                /// <summary>
                /// <para>Number of physical nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PhysicalReads")]
                [Validation(Required=false)]
                public long? PhysicalReads { get; set; }

                /// <summary>
                /// <para>SQL template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>select ?</para>
                /// </summary>
                [NameInMap("Psql")]
                [Validation(Required=false)]
                public string Psql { get; set; }

                /// <summary>
                /// <para>Number of redo nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RedoWrites")]
                [Validation(Required=false)]
                public long? RedoWrites { get; set; }

                /// <summary>
                /// <para>Number of rows affected.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RowsAffected")]
                [Validation(Required=false)]
                public long? RowsAffected { get; set; }

                /// <summary>
                /// <para>Average number of rows affected.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RowsAffectedAvg")]
                [Validation(Required=false)]
                public double? RowsAffectedAvg { get; set; }

                /// <summary>
                /// <para>Total number of rows scanned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("RowsExamined")]
                [Validation(Required=false)]
                public long? RowsExamined { get; set; }

                /// <summary>
                /// <para>Average number of rows scanned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RowsExaminedAvg")]
                [Validation(Required=false)]
                public double? RowsExaminedAvg { get; set; }

                /// <summary>
                /// <para>Average number of rows sent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RowsSendAvg")]
                [Validation(Required=false)]
                public double? RowsSendAvg { get; set; }

                /// <summary>
                /// <para>Number of rows returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RowsSent")]
                [Validation(Required=false)]
                public long? RowsSent { get; set; }

                /// <summary>
                /// <para>Average number of rows returned per SQL statement.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.52</para>
                /// </summary>
                [NameInMap("RowsSentAvg")]
                [Validation(Required=false)]
                public double? RowsSentAvg { get; set; }

                /// <summary>
                /// <para>Number of rows sorted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RowsSorted")]
                [Validation(Required=false)]
                public long? RowsSorted { get; set; }

                /// <summary>
                /// <para>Percentage of total execution duration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.1384</para>
                /// </summary>
                [NameInMap("RtRate")]
                [Validation(Required=false)]
                public double? RtRate { get; set; }

                /// <summary>
                /// <para>Indicates whether read/write splitting is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>0</b>: Disabled.</para>
                /// </description></item>
                /// <item><description><para><b>1</b>: Enabled.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RwlockOsWaits")]
                [Validation(Required=false)]
                public int? RwlockOsWaits { get; set; }

                /// <summary>
                /// <para>Read/write splitting parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RwlockSpinRounds")]
                [Validation(Required=false)]
                public int? RwlockSpinRounds { get; set; }

                /// <summary>
                /// <para>Indicates whether multiple index scans are enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>0</b>: Disabled.</para>
                /// </description></item>
                /// <item><description><para><b>1</b>: Enabled.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RwlockSpinWaits")]
                [Validation(Required=false)]
                public int? RwlockSpinWaits { get; set; }

                /// <summary>
                /// <para>The average number of connections that perform table scans without using an index.</para>
                /// <remarks>
                /// <para>Notice: If this parameter value is not 0, carefully check the indexes of the table.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SelectFullJoinAvg")]
                [Validation(Required=false)]
                public double? SelectFullJoinAvg { get; set; }

                /// <summary>
                /// <para>Average number of range joins.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SelectFullRangeJoinAvg")]
                [Validation(Required=false)]
                public double? SelectFullRangeJoinAvg { get; set; }

                /// <summary>
                /// <para>Average range selection.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SelectRangeAvg")]
                [Validation(Required=false)]
                public double? SelectRangeAvg { get; set; }

                /// <summary>
                /// <para>Average number of scans.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SelectScanAvg")]
                [Validation(Required=false)]
                public double? SelectScanAvg { get; set; }

                /// <summary>
                /// <para>Semi-synchronous replication delay, in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.12</para>
                /// </summary>
                [NameInMap("SemisyncDelayTime")]
                [Validation(Required=false)]
                public double? SemisyncDelayTime { get; set; }

                /// <summary>
                /// <para>Server lock time, in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ServerLockTime")]
                [Validation(Required=false)]
                public double? ServerLockTime { get; set; }

                /// <summary>
                /// <para>Number of merge passes required by the sort algorithm.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SortMergePasses")]
                [Validation(Required=false)]
                public long? SortMergePasses { get; set; }

                /// <summary>
                /// <para>Average number of range-based sorts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SortRangeAvg")]
                [Validation(Required=false)]
                public double? SortRangeAvg { get; set; }

                /// <summary>
                /// <para>Average number of sorted rows.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SortRowsAvg")]
                [Validation(Required=false)]
                public double? SortRowsAvg { get; set; }

                /// <summary>
                /// <para>Average number of sorted scans.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SortScanAvg")]
                [Validation(Required=false)]
                public double? SortScanAvg { get; set; }

                /// <summary>
                /// <para>SQL template ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2e8147b5ca2dfc640dfd5e43d96a****</para>
                /// </summary>
                [NameInMap("SqlId")]
                [Validation(Required=false)]
                public string SqlId { get; set; }

                /// <summary>
                /// <para>SQL type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>SELECT</b></para>
                /// </description></item>
                /// <item><description><para><b>UPDATE</b></para>
                /// </description></item>
                /// <item><description><para><b>DELETE</b></para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SELECT</para>
                /// </summary>
                [NameInMap("SqlType")]
                [Validation(Required=false)]
                public string SqlType { get; set; }

                /// <summary>
                /// <para>Database table names.</para>
                /// </summary>
                [NameInMap("Tables")]
                [Validation(Required=false)]
                public List<string> Tables { get; set; }

                /// <summary>
                /// <para>Reserved parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>None</para>
                /// </summary>
                [NameInMap("TimerWaitAvg")]
                [Validation(Required=false)]
                public double? TimerWaitAvg { get; set; }

                /// <summary>
                /// <para>Data timestamp in Unix time format, in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1643040000000</para>
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

                /// <summary>
                /// <para>Number of temporary disk tables.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TmpDiskTables")]
                [Validation(Required=false)]
                public long? TmpDiskTables { get; set; }

                /// <summary>
                /// <para>Average number of temporary disk tables.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TmpDiskTablesAvg")]
                [Validation(Required=false)]
                public double? TmpDiskTablesAvg { get; set; }

                /// <summary>
                /// <para>Number of temporary tables.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TmpTables")]
                [Validation(Required=false)]
                public long? TmpTables { get; set; }

                /// <summary>
                /// <para>Average number of temporary tables.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TmpTablesAvg")]
                [Validation(Required=false)]
                public double? TmpTablesAvg { get; set; }

                /// <summary>
                /// <para>Total execution duration, in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60913.256</para>
                /// </summary>
                [NameInMap("TotalLatency")]
                [Validation(Required=false)]
                public double? TotalLatency { get; set; }

                /// <summary>
                /// <para>Transaction lock time, in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TransactionLockTime")]
                [Validation(Required=false)]
                public double? TransactionLockTime { get; set; }

                /// <summary>
                /// <para>User ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>196278346919****</para>
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                /// <summary>
                /// <para>Number of warnings.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("WarnCount")]
                [Validation(Required=false)]
                public long? WarnCount { get; set; }

            }

            /// <summary>
            /// <para>Page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public long? PageNo { get; set; }

            /// <summary>
            /// <para>Maximum number of records per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>Total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>264</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>Response message.</para>
        /// <remarks>
        /// <para>If the request succeeds, this parameter returns <b>Successful</b>. If it fails, it returns error details such as an error code.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>54F3DBAE-9420-511A-9C29-265E8C04****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request succeeded:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Succeeded.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Failed.</para>
        /// </description></item>
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
