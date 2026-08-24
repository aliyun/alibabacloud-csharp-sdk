// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeSlowLogRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code returned.</para>
        /// 
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
            /// <para>The numeric ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("DbInstanceId")]
            [Validation(Required=false)]
            public long? DbInstanceId { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-bp157g54vy772****</para>
            /// </summary>
            [NameInMap("DbInstanceName")]
            [Validation(Required=false)]
            public string DbInstanceName { get; set; }

            /// <summary>
            /// <para>The end time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1672617600000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The number of items in the query log list on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("ItemsNumbers")]
            [Validation(Required=false)]
            public long? ItemsNumbers { get; set; }

            /// <summary>
            /// <para>The returned data.</para>
            /// </summary>
            [NameInMap("Logs")]
            [Validation(Required=false)]
            public List<DescribeSlowLogRecordsResponseBodyDataLogs> Logs { get; set; }
            public class DescribeSlowLogRecordsResponseBodyDataLogs : TeaModel {
                /// <summary>
                /// <para>The username.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user1</para>
                /// </summary>
                [NameInMap("AccountName")]
                [Validation(Required=false)]
                public string AccountName { get; set; }

                /// <summary>
                /// <para>The application name.</para>
                /// <remarks>
                /// <para>Only ApsaraDB RDS for SQL Server instances are supported.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>MyApp</para>
                /// </summary>
                [NameInMap("ApplicationName")]
                [Validation(Required=false)]
                public string ApplicationName { get; set; }

                /// <summary>
                /// <para>The CPU query time.</para>
                /// <remarks>
                /// <para>Only ApsaraDB RDS for SQL Server instances are supported.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("CPUTime")]
                [Validation(Required=false)]
                public double? CPUTime { get; set; }

                /// <summary>
                /// <para>The CPU query time, in seconds.</para>
                /// <remarks>
                /// <para>Only ApsaraDB RDS for SQL Server instances are supported.</para>
                /// </remarks>
                /// 
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
                /// <para>The slow query statement.</para>
                /// <remarks>
                /// <para>Only ApsaraDB for Tair (Redis® OSS-Compatible) database instances are supported.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>SELECT</para>
                /// </summary>
                [NameInMap("Command")]
                [Validation(Required=false)]
                public string Command { get; set; }

                /// <summary>
                /// <para>The database name.</para>
                /// 
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
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rm-2zebg30mk056g****</para>
                /// </summary>
                [NameInMap("DbInstanceName")]
                [Validation(Required=false)]
                public string DbInstanceName { get; set; }

                /// <summary>
                /// <para>The number of documents scanned during the MongoDB operation.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("DocsExamined")]
                [Validation(Required=false)]
                public string DocsExamined { get; set; }

                [NameInMap("ExtText")]
                [Validation(Required=false)]
                public string ExtText { get; set; }

                [NameInMap("Fail")]
                [Validation(Required=false)]
                public string Fail { get; set; }

                /// <summary>
                /// <para>The number of rows fetched by the compute node (CN) of the ApsaraDB PolarDB-X 2.0 database instance.</para>
                /// <remarks>
                /// <para>Only ApsaraDB PolarDB-X 2.0 instances are supported.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Frows")]
                [Validation(Required=false)]
                public long? Frows { get; set; }

                /// <summary>
                /// <para>The source host address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.1.1</para>
                /// </summary>
                [NameInMap("HostAddress")]
                [Validation(Required=false)]
                public string HostAddress { get; set; }

                /// <summary>
                /// <para>The number of I/O writes.</para>
                /// <remarks>
                /// <para>Only ApsaraDB RDS for SQL Server instances are supported.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("IOWrites")]
                [Validation(Required=false)]
                public long? IOWrites { get; set; }

                /// <summary>
                /// <para>The instance name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("InsName")]
                [Validation(Required=false)]
                public string InsName { get; set; }

                /// <summary>
                /// <para>The number of index rows scanned in MongoDB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>valueA</para>
                /// </summary>
                [NameInMap("KeysExamined")]
                [Validation(Required=false)]
                public string KeysExamined { get; set; }

                /// <summary>
                /// <para>The number of rows affected by the last statement.</para>
                /// <remarks>
                /// <para>Only ApsaraDB RDS for SQL Server instances are supported.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("LastRowsCountAffected")]
                [Validation(Required=false)]
                public long? LastRowsCountAffected { get; set; }

                /// <summary>
                /// <para>The lock wait time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("LockTime")]
                [Validation(Required=false)]
                public double? LockTime { get; set; }

                /// <summary>
                /// <para>The lock wait time, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("LockTimeSeconds")]
                [Validation(Required=false)]
                public double? LockTimeSeconds { get; set; }

                /// <summary>
                /// <para>The number of logical reads.</para>
                /// <remarks>
                /// <para>Only ApsaraDB RDS for SQL Server instances are supported.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("LogicalIOReads")]
                [Validation(Required=false)]
                public long? LogicalIOReads { get; set; }

                /// <summary>
                /// <para>The namespace.</para>
                /// <remarks>
                /// <para>Only ApsaraDB for MongoDB instances are supported.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>pro-test</para>
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                [NameInMap("NodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                [NameInMap("OpType")]
                [Validation(Required=false)]
                public string OpType { get; set; }

                [NameInMap("OriginTime")]
                [Validation(Required=false)]
                public string OriginTime { get; set; }

                [NameInMap("Params")]
                [Validation(Required=false)]
                public string Params { get; set; }

                /// <summary>
                /// <para>The number of physical reads.</para>
                /// <remarks>
                /// <para>Only ApsaraDB RDS for SQL Server instances are supported.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PhysicalIOReads")]
                [Validation(Required=false)]
                public long? PhysicalIOReads { get; set; }

                /// <summary>
                /// <para>The SQL template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SELECT * FROM my_table WHERE ROWNUM &lt;= 10</para>
                /// </summary>
                [NameInMap("Psql")]
                [Validation(Required=false)]
                public string Psql { get; set; }

                /// <summary>
                /// <para>The query ID.</para>
                /// <remarks>
                /// <para>Only ApsaraDB for MongoDB instances are supported.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>sq-1pzcdMwRb</para>
                /// </summary>
                [NameInMap("QueryId")]
                [Validation(Required=false)]
                public string QueryId { get; set; }

                /// <summary>
                /// <para>The time when the query started. Format: yyyy-MM-dd hh:mm:ss (UTC).</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-04-01 11:00:00</para>
                /// </summary>
                [NameInMap("QueryStartTime")]
                [Validation(Required=false)]
                public string QueryStartTime { get; set; }

                /// <summary>
                /// <para>The query duration.</para>
                /// 
                /// <b>Example:</b>
                /// <para>121</para>
                /// </summary>
                [NameInMap("QueryTime")]
                [Validation(Required=false)]
                public long? QueryTime { get; set; }

                /// <summary>
                /// <para>The query duration, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("QueryTimeSeconds")]
                [Validation(Required=false)]
                public double? QueryTimeSeconds { get; set; }

                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

                [NameInMap("ReqId")]
                [Validation(Required=false)]
                public string ReqId { get; set; }

                [NameInMap("RequestSize")]
                [Validation(Required=false)]
                public long? RequestSize { get; set; }

                [NameInMap("ResponseSize")]
                [Validation(Required=false)]
                public long? ResponseSize { get; set; }

                /// <summary>
                /// <para>The number of returned items.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("ReturnItemNumbers")]
                [Validation(Required=false)]
                public string ReturnItemNumbers { get; set; }

                /// <summary>
                /// <para>The number of rows returned.</para>
                /// <remarks>
                /// <para>Only ApsaraDB for MongoDB instances are supported.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("ReturnNum")]
                [Validation(Required=false)]
                public string ReturnNum { get; set; }

                /// <summary>
                /// <para>The total number of rows updated or returned by the compute nodes of the ApsaraDB PolarDB-X 2.0 database instance.</para>
                /// <remarks>
                /// <para>Only ApsaraDB PolarDB-X 2.0 instances are supported.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Rows")]
                [Validation(Required=false)]
                public long? Rows { get; set; }

                /// <summary>
                /// <para>The number of rows affected.</para>
                /// <remarks>
                /// <para>Only ApsaraDB RDS for SQL Server instances are supported.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("RowsCountAffected")]
                [Validation(Required=false)]
                public long? RowsCountAffected { get; set; }

                /// <summary>
                /// <para>The number of rows scanned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("RowsExamined")]
                [Validation(Required=false)]
                public long? RowsExamined { get; set; }

                /// <summary>
                /// <para>The number of rows returned.</para>
                /// 
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
                /// <para>The SQL text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>SELECT * FROM my_table WHERE ROWNUM &lt;= 10</para>
                /// </summary>
                [NameInMap("SQLText")]
                [Validation(Required=false)]
                public string SQLText { get; set; }

                /// <summary>
                /// <para>The data schema.</para>
                /// 
                /// <b>Example:</b>
                /// <para>HTTPS</para>
                /// </summary>
                [NameInMap("Scheme")]
                [Validation(Required=false)]
                public string Scheme { get; set; }

                /// <summary>
                /// <para>The number of DN requests from the compute node (CN) of the ApsaraDB PolarDB-X 2.0 database instance.</para>
                /// <remarks>
                /// <para>Only ApsaraDB PolarDB-X 2.0 instances are supported.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Scnt")]
                [Validation(Required=false)]
                public long? Scnt { get; set; }

                /// <summary>
                /// <para>The SQL template ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sqlId</para>
                /// </summary>
                [NameInMap("SqlId")]
                [Validation(Required=false)]
                public string SqlId { get; set; }

                /// <summary>
                /// <para>The tag.</para>
                /// </summary>
                [NameInMap("SqlTag")]
                [Validation(Required=false)]
                public DescribeSlowLogRecordsResponseBodyDataLogsSqlTag SqlTag { get; set; }
                public class DescribeSlowLogRecordsResponseBodyDataLogsSqlTag : TeaModel {
                    /// <summary>
                    /// <para>The remarks.</para>
                    /// 
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
                    /// <para>Multiple tags separated by commas.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DAS_IMPORTANT,DAS_IN_PLAN</para>
                    /// </summary>
                    [NameInMap("Tags")]
                    [Validation(Required=false)]
                    public string Tags { get; set; }

                }

                /// <summary>
                /// <para>The SQL statement type. Valid values:</para>
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
                /// <para>The child instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>r-8vb219d10038****</para>
                /// </summary>
                [NameInMap("SubInstanceId")]
                [Validation(Required=false)]
                public string SubInstanceId { get; set; }

                /// <summary>
                /// <para>The table name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tableNameExample</para>
                /// </summary>
                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

                /// <summary>
                /// <para>The template ID of the ApsaraDB PolarDB-X 2.0 database instance.</para>
                /// <remarks>
                /// <para>Only ApsaraDB PolarDB-X 2.0 instances are supported.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>6a63b6ac4572abfaef7d1163f684****</para>
                /// </summary>
                [NameInMap("TemplateId")]
                [Validation(Required=false)]
                public string TemplateId { get; set; }

                /// <summary>
                /// <para>The thread ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>57472578</para>
                /// </summary>
                [NameInMap("ThreadId")]
                [Validation(Required=false)]
                public string ThreadId { get; set; }

                /// <summary>
                /// <para>The timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1747118812</para>
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

                /// <summary>
                /// <para>The trace ID of PolarDB-X 2.0, which is the execute ID of the SQL statement on the ApsaraDB PolarDB-X 2.0 database node.</para>
                /// <remarks>
                /// <para>Only ApsaraDB PolarDB-X 2.0 instances are supported.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>074ce334-5247-40b9-b0c1-158aea5d****</para>
                /// </summary>
                [NameInMap("TraceId")]
                [Validation(Required=false)]
                public string TraceId { get; set; }

            }

            /// <summary>
            /// <para>The maximum number of records per page for the paged query. Valid values: 5 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("MaxRecordsPerPage")]
            [Validation(Required=false)]
            public int? MaxRecordsPerPage { get; set; }

            /// <summary>
            /// <para>The node ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>node123</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <para>The page number for the paged query. Pages start from page 1. Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumbers")]
            [Validation(Required=false)]
            public int? PageNumbers { get; set; }

            /// <summary>
            /// <para>The start time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1672531200000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The total number of records.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("TotalRecords")]
            [Validation(Required=false)]
            public long? TotalRecords { get; set; }

        }

        /// <summary>
        /// <para>The message returned for the request.</para>
        /// <remarks>
        /// <para> This parameter returns <b>Successful</b> when the request succeeds. If the request fails, an exception message is returned, such as an error code.</para>
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
        /// <para>A1C79EE2-D04D-571B-8C60-961FAF8E****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: failed.</para>
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
