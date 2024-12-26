// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeSlowLogStatisticResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>AsyncResult&lt;DBLogRecords<SlowLogStat>&gt;</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeSlowLogStatisticResponseBodyData Data { get; set; }
        public class DescribeSlowLogStatisticResponseBodyData : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public DescribeSlowLogStatisticResponseBodyDataData Data { get; set; }
            public class DescribeSlowLogStatisticResponseBodyDataData : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>rm-k2ja51w7cnusg5a1x</para>
                /// </summary>
                [NameInMap("DbInstanceId")]
                [Validation(Required=false)]
                public long? DbInstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DbInstanceName")]
                [Validation(Required=false)]
                public string DbInstanceName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-08-08T02:15:00Z</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("ItemsNumbers")]
                [Validation(Required=false)]
                public long? ItemsNumbers { get; set; }

                [NameInMap("Logs")]
                [Validation(Required=false)]
                public List<DescribeSlowLogStatisticResponseBodyDataDataLogs> Logs { get; set; }
                public class DescribeSlowLogStatisticResponseBodyDataDataLogs : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>edu_admin</para>
                    /// </summary>
                    [NameInMap("AccountName")]
                    [Validation(Required=false)]
                    public string AccountName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <list type="bullet">
                    /// <item><description></description></item>
                    /// </list>
                    /// </summary>
                    [NameInMap("AvgCPUTime")]
                    [Validation(Required=false)]
                    public double? AvgCPUTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10000</para>
                    /// </summary>
                    [NameInMap("AvgDocExamined")]
                    [Validation(Required=false)]
                    public double? AvgDocExamined { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("AvgIOWrites")]
                    [Validation(Required=false)]
                    public double? AvgIOWrites { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>20000</para>
                    /// </summary>
                    [NameInMap("AvgKeysExamined")]
                    [Validation(Required=false)]
                    public double? AvgKeysExamined { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("AvgLastRowsCountAffected")]
                    [Validation(Required=false)]
                    public double? AvgLastRowsCountAffected { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <list type="bullet">
                    /// <item><description></description></item>
                    /// </list>
                    /// </summary>
                    [NameInMap("AvgLockTime")]
                    [Validation(Required=false)]
                    public double? AvgLockTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.0</para>
                    /// </summary>
                    [NameInMap("AvgLockTimeSeconds")]
                    [Validation(Required=false)]
                    public double? AvgLockTimeSeconds { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("AvgLogicalIOReads")]
                    [Validation(Required=false)]
                    public double? AvgLogicalIOReads { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("AvgPhysicalIOReads")]
                    [Validation(Required=false)]
                    public double? AvgPhysicalIOReads { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <list type="bullet">
                    /// <item><description></description></item>
                    /// </list>
                    /// </summary>
                    [NameInMap("AvgQueryTime")]
                    [Validation(Required=false)]
                    public double? AvgQueryTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>6.211</para>
                    /// </summary>
                    [NameInMap("AvgQueryTimeSeconds")]
                    [Validation(Required=false)]
                    public double? AvgQueryTimeSeconds { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("AvgReturnNum")]
                    [Validation(Required=false)]
                    public double? AvgReturnNum { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("AvgRowsCountAffected")]
                    [Validation(Required=false)]
                    public double? AvgRowsCountAffected { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>53421.0</para>
                    /// </summary>
                    [NameInMap("AvgRowsExamined")]
                    [Validation(Required=false)]
                    public double? AvgRowsExamined { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2.0</para>
                    /// </summary>
                    [NameInMap("AvgRowsSent")]
                    [Validation(Required=false)]
                    public double? AvgRowsSent { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <list type="bullet">
                    /// <item><description></description></item>
                    /// </list>
                    /// </summary>
                    [NameInMap("CPUTime")]
                    [Validation(Required=false)]
                    public double? CPUTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>SELECT b?.id,b?.t?,b?.id,b?.t? FROM testtb? b? JOIN testtb? b? ON b?.id=b?.id WHERE b?.t? LIKE ? ORDER BY b?.t? DESC</para>
                    /// </summary>
                    [NameInMap("Command")]
                    [Validation(Required=false)]
                    public string Command { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>12</para>
                    /// </summary>
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public long? Count { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.2034</para>
                    /// </summary>
                    [NameInMap("CountRate")]
                    [Validation(Required=false)]
                    public double? CountRate { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>member_score</para>
                    /// </summary>
                    [NameInMap("DBName")]
                    [Validation(Required=false)]
                    public string DBName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>work-wechat-api</para>
                    /// </summary>
                    [NameInMap("Database")]
                    [Validation(Required=false)]
                    public string Database { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("DbInstanceName")]
                    [Validation(Required=false)]
                    public string DbInstanceName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2000000</para>
                    /// </summary>
                    [NameInMap("DocExamined")]
                    [Validation(Required=false)]
                    public long? DocExamined { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("DocsExamined")]
                    [Validation(Required=false)]
                    public long? DocsExamined { get; set; }

                    [NameInMap("Histogram")]
                    [Validation(Required=false)]
                    public DescribeSlowLogStatisticResponseBodyDataDataLogsHistogram Histogram { get; set; }
                    public class DescribeSlowLogStatisticResponseBodyDataDataLogsHistogram : TeaModel {
                        [NameInMap("AvgLockTime")]
                        [Validation(Required=false)]
                        public List<double?> AvgLockTime { get; set; }

                        [NameInMap("AvgRowsExamined")]
                        [Validation(Required=false)]
                        public List<double?> AvgRowsExamined { get; set; }

                        [NameInMap("AvgRowsSent")]
                        [Validation(Required=false)]
                        public List<double?> AvgRowsSent { get; set; }

                        [NameInMap("AvgRt")]
                        [Validation(Required=false)]
                        public List<double?> AvgRt { get; set; }

                        [NameInMap("Count")]
                        [Validation(Required=false)]
                        public List<long?> Count { get; set; }

                        [NameInMap("Item")]
                        [Validation(Required=false)]
                        public List<DescribeSlowLogStatisticResponseBodyDataDataLogsHistogramItem> Item { get; set; }
                        public class DescribeSlowLogStatisticResponseBodyDataDataLogsHistogramItem : TeaModel {
                            [NameInMap("Count")]
                            [Validation(Required=false)]
                            public List<long?> Count { get; set; }

                            /// <summary>
                            /// <b>Example:</b>
                            /// <para>r-bp1s1m8hwzrm77kfvz-db-0</para>
                            /// </summary>
                            [NameInMap("NodeId")]
                            [Validation(Required=false)]
                            public string NodeId { get; set; }

                        }

                        [NameInMap("LockTime")]
                        [Validation(Required=false)]
                        public List<double?> LockTime { get; set; }

                        [NameInMap("MaxLockTime")]
                        [Validation(Required=false)]
                        public List<double?> MaxLockTime { get; set; }

                        [NameInMap("MaxRowsExamined")]
                        [Validation(Required=false)]
                        public List<long?> MaxRowsExamined { get; set; }

                        [NameInMap("MaxRowsSent")]
                        [Validation(Required=false)]
                        public List<long?> MaxRowsSent { get; set; }

                        [NameInMap("MaxRt")]
                        [Validation(Required=false)]
                        public List<double?> MaxRt { get; set; }

                        [NameInMap("RowsExamined")]
                        [Validation(Required=false)]
                        public List<long?> RowsExamined { get; set; }

                        [NameInMap("RowsSent")]
                        [Validation(Required=false)]
                        public List<long?> RowsSent { get; set; }

                        [NameInMap("Rt")]
                        [Validation(Required=false)]
                        public List<double?> Rt { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>7</para>
                        /// </summary>
                        [NameInMap("Total")]
                        [Validation(Required=false)]
                        public long? Total { get; set; }

                        [NameInMap("Ts")]
                        [Validation(Required=false)]
                        public List<long?> Ts { get; set; }

                        [NameInMap("TsEnd")]
                        [Validation(Required=false)]
                        public List<long?> TsEnd { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>172.23.142.178</para>
                    /// </summary>
                    [NameInMap("HostAddress")]
                    [Validation(Required=false)]
                    public string HostAddress { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>mongo-abc123456</para>
                    /// </summary>
                    [NameInMap("HostInsId")]
                    [Validation(Required=false)]
                    public string HostInsId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("IOWrites")]
                    [Validation(Required=false)]
                    public long? IOWrites { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>rm-uf6zix1z2jh1y6fe5</para>
                    /// </summary>
                    [NameInMap("InsName")]
                    [Validation(Required=false)]
                    public string InsName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>__system</para>
                    /// </summary>
                    [NameInMap("InsRole")]
                    [Validation(Required=false)]
                    public string InsRole { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>20000</para>
                    /// </summary>
                    [NameInMap("KeysExamined")]
                    [Validation(Required=false)]
                    public long? KeysExamined { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("LastRowsCountAffected")]
                    [Validation(Required=false)]
                    public long? LastRowsCountAffected { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <list type="bullet">
                    /// <item><description></description></item>
                    /// </list>
                    /// </summary>
                    [NameInMap("LockTime")]
                    [Validation(Required=false)]
                    public double? LockTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.0</para>
                    /// </summary>
                    [NameInMap("LockTimeSeconds")]
                    [Validation(Required=false)]
                    public double? LockTimeSeconds { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("LogicalIOReads")]
                    [Validation(Required=false)]
                    public long? LogicalIOReads { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <list type="bullet">
                    /// <item><description></description></item>
                    /// </list>
                    /// </summary>
                    [NameInMap("MaxCPUTime")]
                    [Validation(Required=false)]
                    public double? MaxCPUTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1000000</para>
                    /// </summary>
                    [NameInMap("MaxDocExamined")]
                    [Validation(Required=false)]
                    public long? MaxDocExamined { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("MaxIOWrites")]
                    [Validation(Required=false)]
                    public long? MaxIOWrites { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2000000</para>
                    /// </summary>
                    [NameInMap("MaxKeysExamined")]
                    [Validation(Required=false)]
                    public long? MaxKeysExamined { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("MaxLastRowsCountAffected")]
                    [Validation(Required=false)]
                    public long? MaxLastRowsCountAffected { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <list type="bullet">
                    /// <item><description></description></item>
                    /// </list>
                    /// </summary>
                    [NameInMap("MaxLockTime")]
                    [Validation(Required=false)]
                    public double? MaxLockTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.0</para>
                    /// </summary>
                    [NameInMap("MaxLockTimeSeconds")]
                    [Validation(Required=false)]
                    public double? MaxLockTimeSeconds { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("MaxLogicalIOReads")]
                    [Validation(Required=false)]
                    public long? MaxLogicalIOReads { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("MaxPhysicalIOReads")]
                    [Validation(Required=false)]
                    public long? MaxPhysicalIOReads { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <list type="bullet">
                    /// <item><description></description></item>
                    /// </list>
                    /// </summary>
                    [NameInMap("MaxQueryTime")]
                    [Validation(Required=false)]
                    public double? MaxQueryTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>14.402</para>
                    /// </summary>
                    [NameInMap("MaxQueryTimeSeconds")]
                    [Validation(Required=false)]
                    public double? MaxQueryTimeSeconds { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("MaxReturnNum")]
                    [Validation(Required=false)]
                    public long? MaxReturnNum { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("MaxRowsCountAffected")]
                    [Validation(Required=false)]
                    public long? MaxRowsCountAffected { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>318613</para>
                    /// </summary>
                    [NameInMap("MaxRowsExamined")]
                    [Validation(Required=false)]
                    public long? MaxRowsExamined { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>256</para>
                    /// </summary>
                    [NameInMap("MaxRowsSent")]
                    [Validation(Required=false)]
                    public long? MaxRowsSent { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>database.collection</para>
                    /// </summary>
                    [NameInMap("Namespace")]
                    [Validation(Required=false)]
                    public string Namespace { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>DLNode</para>
                    /// </summary>
                    [NameInMap("NodeType")]
                    [Validation(Required=false)]
                    public string NodeType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Insert</para>
                    /// </summary>
                    [NameInMap("OpType")]
                    [Validation(Required=false)]
                    public string OpType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>order-1</para>
                    /// </summary>
                    [NameInMap("OriginAlias")]
                    [Validation(Required=false)]
                    public string OriginAlias { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("PhysicalIOReads")]
                    [Validation(Required=false)]
                    public long? PhysicalIOReads { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>SELECT b?.id,b?.t?,b?.id,b?.t? FROM testtb? b? JOIN testtb? b? ON b?.id=b?.id WHERE b?.t? LIKE ? ORDER BY b?.id DESC</para>
                    /// </summary>
                    [NameInMap("Psql")]
                    [Validation(Required=false)]
                    public string Psql { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>sq-1pzcdMwRb</para>
                    /// </summary>
                    [NameInMap("QueryId")]
                    [Validation(Required=false)]
                    public string QueryId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2024-12-25T03:00:00Z</para>
                    /// </summary>
                    [NameInMap("QueryStartTime")]
                    [Validation(Required=false)]
                    public string QueryStartTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>272.444</para>
                    /// </summary>
                    [NameInMap("QueryTime")]
                    [Validation(Required=false)]
                    public long? QueryTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.1018</para>
                    /// </summary>
                    [NameInMap("QueryTimeRate")]
                    [Validation(Required=false)]
                    public double? QueryTimeRate { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>25.472</para>
                    /// </summary>
                    [NameInMap("QueryTimeSeconds")]
                    [Validation(Required=false)]
                    public double? QueryTimeSeconds { get; set; }

                    [NameInMap("ReturnItemNumbers")]
                    [Validation(Required=false)]
                    public string ReturnItemNumbers { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("ReturnNum")]
                    [Validation(Required=false)]
                    public long? ReturnNum { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("RowsCountAffected")]
                    [Validation(Required=false)]
                    public long? RowsCountAffected { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2444081</para>
                    /// </summary>
                    [NameInMap("RowsExamined")]
                    [Validation(Required=false)]
                    public long? RowsExamined { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>772</para>
                    /// </summary>
                    [NameInMap("RowsSent")]
                    [Validation(Required=false)]
                    public long? RowsSent { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>SELECT \&quot;Hello, World!\&quot; FROM DUAL</para>
                    /// </summary>
                    [NameInMap("SQLText")]
                    [Validation(Required=false)]
                    public string SQLText { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>HTTP</para>
                    /// </summary>
                    [NameInMap("Scheme")]
                    [Validation(Required=false)]
                    public string Scheme { get; set; }

                    /// <summary>
                    /// <para>SQL ID。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2dca88762ec6b3812504ab8a4b******</para>
                    /// </summary>
                    [NameInMap("SqlId")]
                    [Validation(Required=false)]
                    public string SqlId { get; set; }

                    [NameInMap("SqlTag")]
                    [Validation(Required=false)]
                    public DescribeSlowLogStatisticResponseBodyDataDataLogsSqlTag SqlTag { get; set; }
                    public class DescribeSlowLogStatisticResponseBodyDataDataLogsSqlTag : TeaModel {
                        [NameInMap("Comments")]
                        [Validation(Required=false)]
                        public string Comments { get; set; }

                        /// <summary>
                        /// <para>SQL ID。</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>a3931d8c3a9315dd5ed016d71cf*****</para>
                        /// </summary>
                        [NameInMap("SqlId")]
                        [Validation(Required=false)]
                        public string SqlId { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>DAS_IN_PLAN</para>
                        /// </summary>
                        [NameInMap("Tags")]
                        [Validation(Required=false)]
                        public string Tags { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>LOGIN</para>
                    /// </summary>
                    [NameInMap("SqlType")]
                    [Validation(Required=false)]
                    public string SqlType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>r-8vba51c588ba3a94</para>
                    /// </summary>
                    [NameInMap("SubInstanceId")]
                    [Validation(Required=false)]
                    public string SubInstanceId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>users\nifconfig\n</para>
                    /// </summary>
                    [NameInMap("TableName")]
                    [Validation(Required=false)]
                    public string TableName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("ThreadId")]
                    [Validation(Required=false)]
                    public string ThreadId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1708568930</para>
                    /// </summary>
                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public long? Timestamp { get; set; }

                    [NameInMap("Trend")]
                    [Validation(Required=false)]
                    public List<DescribeSlowLogStatisticResponseBodyDataDataLogsTrend> Trend { get; set; }
                    public class DescribeSlowLogStatisticResponseBodyDataDataLogsTrend : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>1723775362</para>
                        /// </summary>
                        [NameInMap("Timestamp")]
                        [Validation(Required=false)]
                        public long? Timestamp { get; set; }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>tf-testacc-oos-parameter</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public object Value { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>user-1</para>
                    /// </summary>
                    [NameInMap("User")]
                    [Validation(Required=false)]
                    public string User { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("MaxRecordsPerPage")]
                [Validation(Required=false)]
                public int? MaxRecordsPerPage { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>pi-wz99g5rn7w1x8h0sf</para>
                /// </summary>
                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PageNumbers")]
                [Validation(Required=false)]
                public int? PageNumbers { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-10-08T02:01:00Z</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>13</para>
                /// </summary>
                [NameInMap("TotalRecords")]
                [Validation(Required=false)]
                public long? TotalRecords { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10910</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public int? ErrorCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IsFinish")]
            [Validation(Required=false)]
            public bool? IsFinish { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Successful</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123456789</para>
            /// </summary>
            [NameInMap("RequestKey")]
            [Validation(Required=false)]
            public string RequestKey { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>async__665ee69612f1627c7fd9f3c85075****</para>
            /// </summary>
            [NameInMap("ResultId")]
            [Validation(Required=false)]
            public string ResultId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1735104224250</para>
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>52D540CF-C517-1F57-BB42-9035F96******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
