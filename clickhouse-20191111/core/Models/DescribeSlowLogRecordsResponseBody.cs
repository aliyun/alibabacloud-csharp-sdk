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
        /// <para>The details of the slow query logs.</para>
        /// </summary>
        [NameInMap("SlowLogRecords")]
        [Validation(Required=false)]
        public DescribeSlowLogRecordsResponseBodySlowLogRecords SlowLogRecords { get; set; }
        public class DescribeSlowLogRecordsResponseBodySlowLogRecords : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public DescribeSlowLogRecordsResponseBodySlowLogRecordsData Data { get; set; }
            public class DescribeSlowLogRecordsResponseBodySlowLogRecordsData : TeaModel {
                [NameInMap("ResultSet")]
                [Validation(Required=false)]
                public List<DescribeSlowLogRecordsResponseBodySlowLogRecordsDataResultSet> ResultSet { get; set; }
                public class DescribeSlowLogRecordsResponseBodySlowLogRecordsDataResultSet : TeaModel {
                    [NameInMap("InitialAddress")]
                    [Validation(Required=false)]
                    public string InitialAddress { get; set; }

                    [NameInMap("InitialQueryId")]
                    [Validation(Required=false)]
                    public string InitialQueryId { get; set; }

                    [NameInMap("InitialUser")]
                    [Validation(Required=false)]
                    public string InitialUser { get; set; }

                    [NameInMap("MemoryUsage")]
                    [Validation(Required=false)]
                    public string MemoryUsage { get; set; }

                    [NameInMap("Query")]
                    [Validation(Required=false)]
                    public string Query { get; set; }

                    [NameInMap("QueryDurationMs")]
                    [Validation(Required=false)]
                    public string QueryDurationMs { get; set; }

                    [NameInMap("QueryStartTime")]
                    [Validation(Required=false)]
                    public string QueryStartTime { get; set; }

                    [NameInMap("ReadBytes")]
                    [Validation(Required=false)]
                    public string ReadBytes { get; set; }

                    [NameInMap("ReadRows")]
                    [Validation(Required=false)]
                    public string ReadRows { get; set; }

                    [NameInMap("ResultBytes")]
                    [Validation(Required=false)]
                    public string ResultBytes { get; set; }

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
            /// <para>The number of entries on each page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RowsBeforeLimitAtLeast")]
            [Validation(Required=false)]
            public string RowsBeforeLimitAtLeast { get; set; }

            /// <summary>
            /// <para>The statistics of the query results.</para>
            /// </summary>
            [NameInMap("Statistics")]
            [Validation(Required=false)]
            public DescribeSlowLogRecordsResponseBodySlowLogRecordsStatistics Statistics { get; set; }
            public class DescribeSlowLogRecordsResponseBodySlowLogRecordsStatistics : TeaModel {
                /// <summary>
                /// <para>The amount of data read, in bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("BytesRead")]
                [Validation(Required=false)]
                public int? BytesRead { get; set; }

                /// <summary>
                /// <para>The time elapsed for the slow query, in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>21.35</para>
                /// </summary>
                [NameInMap("ElapsedTime")]
                [Validation(Required=false)]
                public float? ElapsedTime { get; set; }

                /// <summary>
                /// <para>The number of rows read.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2016722</para>
                /// </summary>
                [NameInMap("RowsRead")]
                [Validation(Required=false)]
                public int? RowsRead { get; set; }

            }

            [NameInMap("TableSchema")]
            [Validation(Required=false)]
            public DescribeSlowLogRecordsResponseBodySlowLogRecordsTableSchema TableSchema { get; set; }
            public class DescribeSlowLogRecordsResponseBodySlowLogRecordsTableSchema : TeaModel {
                [NameInMap("ResultSet")]
                [Validation(Required=false)]
                public List<DescribeSlowLogRecordsResponseBodySlowLogRecordsTableSchemaResultSet> ResultSet { get; set; }
                public class DescribeSlowLogRecordsResponseBodySlowLogRecordsTableSchemaResultSet : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

        }

    }

}
