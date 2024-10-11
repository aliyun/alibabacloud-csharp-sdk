// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class DescribeSlowLogRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DF203CC8-5F68-5E3F-8050-3C77DD65731A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details about the slow query logs.</para>
        /// </summary>
        [NameInMap("SlowLogRecords")]
        [Validation(Required=false)]
        public DescribeSlowLogRecordsResponseBodySlowLogRecords SlowLogRecords { get; set; }
        public class DescribeSlowLogRecordsResponseBodySlowLogRecords : TeaModel {
            /// <summary>
            /// <para>Details about the slow query logs.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public DescribeSlowLogRecordsResponseBodySlowLogRecordsData Data { get; set; }
            public class DescribeSlowLogRecordsResponseBodySlowLogRecordsData : TeaModel {
                [NameInMap("ResultSet")]
                [Validation(Required=false)]
                public List<DescribeSlowLogRecordsResponseBodySlowLogRecordsDataResultSet> ResultSet { get; set; }
                public class DescribeSlowLogRecordsResponseBodySlowLogRecordsDataResultSet : TeaModel {
                    /// <summary>
                    /// <para>The IP address of the client that initiated the query.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>::ffff:100.104.XX.XX</para>
                    /// </summary>
                    [NameInMap("InitialAddress")]
                    [Validation(Required=false)]
                    public string InitialAddress { get; set; }

                    /// <summary>
                    /// <para>The query ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>\&quot;b51496f2-6b0b-4546-aff9-e17951cb9410\&quot;</para>
                    /// </summary>
                    [NameInMap("InitialQueryId")]
                    [Validation(Required=false)]
                    public string InitialQueryId { get; set; }

                    /// <summary>
                    /// <para>The username that is used to initiate the query.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test_users</para>
                    /// </summary>
                    [NameInMap("InitialUser")]
                    [Validation(Required=false)]
                    public string InitialUser { get; set; }

                    /// <summary>
                    /// <para>The peak memory usage for the query. Unit: bytes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1048576</para>
                    /// </summary>
                    [NameInMap("MemoryUsage")]
                    [Validation(Required=false)]
                    public string MemoryUsage { get; set; }

                    /// <summary>
                    /// <para>The statement that was executed in the query.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Select * from table</para>
                    /// </summary>
                    [NameInMap("Query")]
                    [Validation(Required=false)]
                    public string Query { get; set; }

                    /// <summary>
                    /// <para>The duration of the query. Unit: milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2000</para>
                    /// </summary>
                    [NameInMap("QueryDurationMs")]
                    [Validation(Required=false)]
                    public string QueryDurationMs { get; set; }

                    /// <summary>
                    /// <para>The beginning of the time range to query. The time is in the yyyy-MM-dd hh:mm:ss format. The time is displayed in UTC.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2022-05-22 20:00:01</para>
                    /// </summary>
                    [NameInMap("QueryStartTime")]
                    [Validation(Required=false)]
                    public string QueryStartTime { get; set; }

                    /// <summary>
                    /// <para>The size of the data read by executing the statement. Unit: bytes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1048576</para>
                    /// </summary>
                    [NameInMap("ReadBytes")]
                    [Validation(Required=false)]
                    public string ReadBytes { get; set; }

                    /// <summary>
                    /// <para>The number of rows read by executing the statement.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10027008</para>
                    /// </summary>
                    [NameInMap("ReadRows")]
                    [Validation(Required=false)]
                    public string ReadRows { get; set; }

                    /// <summary>
                    /// <para>The size of the result data. Unit: bytes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1024</para>
                    /// </summary>
                    [NameInMap("ResultBytes")]
                    [Validation(Required=false)]
                    public string ResultBytes { get; set; }

                    /// <summary>
                    /// <para>The query status. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>QueryFinish</b>: The query is complete.</description></item>
                    /// <item><description><b>Processing</b>: The query is running.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>QueryFinish</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            /// <summary>
            /// <para>The number of rows in the result set.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Rows")]
            [Validation(Required=false)]
            public string Rows { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RowsBeforeLimitAtLeast")]
            [Validation(Required=false)]
            public string RowsBeforeLimitAtLeast { get; set; }

            /// <summary>
            /// <para>The statistics of the results.</para>
            /// </summary>
            [NameInMap("Statistics")]
            [Validation(Required=false)]
            public DescribeSlowLogRecordsResponseBodySlowLogRecordsStatistics Statistics { get; set; }
            public class DescribeSlowLogRecordsResponseBodySlowLogRecordsStatistics : TeaModel {
                /// <summary>
                /// <para>The total size of data that were read. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("BytesRead")]
                [Validation(Required=false)]
                public int? BytesRead { get; set; }

                /// <summary>
                /// <para>The time consumed by the slow query. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>21.35</para>
                /// </summary>
                [NameInMap("ElapsedTime")]
                [Validation(Required=false)]
                public float? ElapsedTime { get; set; }

                /// <summary>
                /// <para>The total number of rows that were read.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2016722</para>
                /// </summary>
                [NameInMap("RowsRead")]
                [Validation(Required=false)]
                public int? RowsRead { get; set; }

            }

            /// <summary>
            /// <para>The schema of the table in the database.</para>
            /// </summary>
            [NameInMap("TableSchema")]
            [Validation(Required=false)]
            public DescribeSlowLogRecordsResponseBodySlowLogRecordsTableSchema TableSchema { get; set; }
            public class DescribeSlowLogRecordsResponseBodySlowLogRecordsTableSchema : TeaModel {
                [NameInMap("ResultSet")]
                [Validation(Required=false)]
                public List<DescribeSlowLogRecordsResponseBodySlowLogRecordsTableSchemaResultSet> ResultSet { get; set; }
                public class DescribeSlowLogRecordsResponseBodySlowLogRecordsTableSchemaResultSet : TeaModel {
                    /// <summary>
                    /// <para>The name of the column.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>name</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The type of the column.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>String</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

        }

    }

}
