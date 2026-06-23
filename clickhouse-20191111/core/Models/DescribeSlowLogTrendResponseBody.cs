// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class DescribeSlowLogTrendResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7D3ECB0E-98CA-5E08-A9CA-F70C5A1E9BDF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result set of the slow SQL queries.</para>
        /// </summary>
        [NameInMap("SlowLogTrend")]
        [Validation(Required=false)]
        public DescribeSlowLogTrendResponseBodySlowLogTrend SlowLogTrend { get; set; }
        public class DescribeSlowLogTrendResponseBodySlowLogTrend : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public DescribeSlowLogTrendResponseBodySlowLogTrendData Data { get; set; }
            public class DescribeSlowLogTrendResponseBodySlowLogTrendData : TeaModel {
                [NameInMap("ResultSet")]
                [Validation(Required=false)]
                public List<DescribeSlowLogTrendResponseBodySlowLogTrendDataResultSet> ResultSet { get; set; }
                public class DescribeSlowLogTrendResponseBodySlowLogTrendDataResultSet : TeaModel {
                    [NameInMap("AvgQueryDurationMs")]
                    [Validation(Required=false)]
                    public string AvgQueryDurationMs { get; set; }

                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public string Count { get; set; }

                    [NameInMap("MaxQueryDurationMs")]
                    [Validation(Required=false)]
                    public string MaxQueryDurationMs { get; set; }

                    [NameInMap("MinQueryDurationMs")]
                    [Validation(Required=false)]
                    public string MinQueryDurationMs { get; set; }

                    [NameInMap("QueryStartTime")]
                    [Validation(Required=false)]
                    public string QueryStartTime { get; set; }

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
            /// <para>The minimum number of rows that are returned before the \<c>LIMIT\\</c> clause is applied.</para>
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
            public DescribeSlowLogTrendResponseBodySlowLogTrendStatistics Statistics { get; set; }
            public class DescribeSlowLogTrendResponseBodySlowLogTrendStatistics : TeaModel {
                /// <summary>
                /// <para>The amount of data read. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>697899</para>
                /// </summary>
                [NameInMap("BytesRead")]
                [Validation(Required=false)]
                public int? BytesRead { get; set; }

                /// <summary>
                /// <para>The query execution duration. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.001703578</para>
                /// </summary>
                [NameInMap("ElapsedTime")]
                [Validation(Required=false)]
                public float? ElapsedTime { get; set; }

                /// <summary>
                /// <para>The number of rows read.</para>
                /// 
                /// <b>Example:</b>
                /// <para>14721</para>
                /// </summary>
                [NameInMap("RowsRead")]
                [Validation(Required=false)]
                public int? RowsRead { get; set; }

            }

            [NameInMap("TableSchema")]
            [Validation(Required=false)]
            public DescribeSlowLogTrendResponseBodySlowLogTrendTableSchema TableSchema { get; set; }
            public class DescribeSlowLogTrendResponseBodySlowLogTrendTableSchema : TeaModel {
                [NameInMap("ResultSet")]
                [Validation(Required=false)]
                public List<DescribeSlowLogTrendResponseBodySlowLogTrendTableSchemaResultSet> ResultSet { get; set; }
                public class DescribeSlowLogTrendResponseBodySlowLogTrendTableSchemaResultSet : TeaModel {
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
