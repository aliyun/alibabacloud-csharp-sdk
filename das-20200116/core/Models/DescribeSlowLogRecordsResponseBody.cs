// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeSlowLogRecordsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>DBLogRecords<SlowLogItem></para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeSlowLogRecordsResponseBodyData Data { get; set; }
        public class DescribeSlowLogRecordsResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("DbInstanceId")]
            [Validation(Required=false)]
            public long? DbInstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rm-bp157g54vy772****</para>
            /// </summary>
            [NameInMap("DbInstanceName")]
            [Validation(Required=false)]
            public string DbInstanceName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1672617600000</para>
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
            public List<DescribeSlowLogRecordsResponseBodyDataLogs> Logs { get; set; }
            public class DescribeSlowLogRecordsResponseBodyDataLogs : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>user1</para>
                /// </summary>
                [NameInMap("AccountName")]
                [Validation(Required=false)]
                public string AccountName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>MyApp</para>
                /// </summary>
                [NameInMap("ApplicationName")]
                [Validation(Required=false)]
                public string ApplicationName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("CPUTime")]
                [Validation(Required=false)]
                public double? CPUTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("CPUTimeSeconds")]
                [Validation(Required=false)]
                public double? CPUTimeSeconds { get; set; }

                [NameInMap("ClientIp")]
                [Validation(Required=false)]
                public string ClientIp { get; set; }

                [NameInMap("Cmd")]
                [Validation(Required=false)]
                public string Cmd { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>SELECT</para>
                /// </summary>
                [NameInMap("Command")]
                [Validation(Required=false)]
                public string Command { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("DBName")]
                [Validation(Required=false)]
                public string DBName { get; set; }

                [NameInMap("DbId")]
                [Validation(Required=false)]
                public string DbId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>rm-2zebg30mk056g****</para>
                /// </summary>
                [NameInMap("DbInstanceName")]
                [Validation(Required=false)]
                public string DbInstanceName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("DocsExamined")]
                [Validation(Required=false)]
                public string DocsExamined { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Frows")]
                [Validation(Required=false)]
                public long? Frows { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>192.168.1.1</para>
                /// </summary>
                [NameInMap("HostAddress")]
                [Validation(Required=false)]
                public string HostAddress { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("IOWrites")]
                [Validation(Required=false)]
                public long? IOWrites { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("InsName")]
                [Validation(Required=false)]
                public string InsName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>valueA</para>
                /// </summary>
                [NameInMap("KeysExamined")]
                [Validation(Required=false)]
                public string KeysExamined { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("LastRowsCountAffected")]
                [Validation(Required=false)]
                public long? LastRowsCountAffected { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("LockTime")]
                [Validation(Required=false)]
                public double? LockTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("LockTimeSeconds")]
                [Validation(Required=false)]
                public double? LockTimeSeconds { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("LogicalIOReads")]
                [Validation(Required=false)]
                public long? LogicalIOReads { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>pro-test</para>
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                [NameInMap("OriginTime")]
                [Validation(Required=false)]
                public string OriginTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PhysicalIOReads")]
                [Validation(Required=false)]
                public long? PhysicalIOReads { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>SELECT * FROM my_table WHERE ROWNUM &lt;= 10</para>
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
                /// <para>2024-04-01 11:00:00</para>
                /// </summary>
                [NameInMap("QueryStartTime")]
                [Validation(Required=false)]
                public string QueryStartTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>121</para>
                /// </summary>
                [NameInMap("QueryTime")]
                [Validation(Required=false)]
                public long? QueryTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("QueryTimeSeconds")]
                [Validation(Required=false)]
                public double? QueryTimeSeconds { get; set; }

                [NameInMap("RequestSize")]
                [Validation(Required=false)]
                public long? RequestSize { get; set; }

                [NameInMap("ResponseSize")]
                [Validation(Required=false)]
                public long? ResponseSize { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ReturnItemNumbers")]
                [Validation(Required=false)]
                public string ReturnItemNumbers { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("ReturnNum")]
                [Validation(Required=false)]
                public string ReturnNum { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Rows")]
                [Validation(Required=false)]
                public long? Rows { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("RowsCountAffected")]
                [Validation(Required=false)]
                public long? RowsCountAffected { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("RowsExamined")]
                [Validation(Required=false)]
                public long? RowsExamined { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("RowsSent")]
                [Validation(Required=false)]
                public long? RowsSent { get; set; }

                [NameInMap("Rt")]
                [Validation(Required=false)]
                public long? Rt { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>SELECT * FROM my_table WHERE ROWNUM &lt;= 10</para>
                /// </summary>
                [NameInMap("SQLText")]
                [Validation(Required=false)]
                public string SQLText { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>HTTPS</para>
                /// </summary>
                [NameInMap("Scheme")]
                [Validation(Required=false)]
                public string Scheme { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Scnt")]
                [Validation(Required=false)]
                public long? Scnt { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>sqlId</para>
                /// </summary>
                [NameInMap("SqlId")]
                [Validation(Required=false)]
                public string SqlId { get; set; }

                [NameInMap("SqlTag")]
                [Validation(Required=false)]
                public DescribeSlowLogRecordsResponseBodyDataLogsSqlTag SqlTag { get; set; }
                public class DescribeSlowLogRecordsResponseBodyDataLogsSqlTag : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("Comments")]
                    [Validation(Required=false)]
                    public string Comments { get; set; }

                    /// <summary>
                    /// <para>sqlid。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8ad7069f236bcdaaa9b3ae4b6299****</para>
                    /// </summary>
                    [NameInMap("SqlId")]
                    [Validation(Required=false)]
                    public string SqlId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>DAS_IMPORTANT,DAS_IN_PLAN</para>
                    /// </summary>
                    [NameInMap("Tags")]
                    [Validation(Required=false)]
                    public string Tags { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>SELECT</para>
                /// </summary>
                [NameInMap("SqlType")]
                [Validation(Required=false)]
                public string SqlType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>r-8vb219d10038****</para>
                /// </summary>
                [NameInMap("SubInstanceId")]
                [Validation(Required=false)]
                public string SubInstanceId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>tableNameExample</para>
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>6a63b6ac4572abfaef7d1163f684****</para>
                /// </summary>
                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public string TemplateId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>57472578</para>
                /// </summary>
                [NameInMap("ThreadId")]
                [Validation(Required=false)]
                public string ThreadId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1747118812</para>
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>074ce334-5247-40b9-b0c1-158aea5d****</para>
                /// </summary>
                [NameInMap("TraceId")]
                [Validation(Required=false)]
                public string TraceId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("MaxRecordsPerPage")]
            [Validation(Required=false)]
            public int? MaxRecordsPerPage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>node123</para>
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
            /// <para>1672531200000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalRecords")]
            [Validation(Required=false)]
            public long? TotalRecords { get; set; }

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
        /// <para>A1C79EE2-D04D-571B-8C60-961FAF8E****</para>
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
