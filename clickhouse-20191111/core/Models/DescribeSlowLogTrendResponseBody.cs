// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class DescribeSlowLogTrendResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>7D3ECB0E-98CA-5E08-A9CA-F70C5A1E9BDF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2000</para>
                    /// </summary>
                    [NameInMap("AvgQueryDurationMs")]
                    [Validation(Required=false)]
                    public string AvgQueryDurationMs { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>4000</para>
                    /// </summary>
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public string Count { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>3000</para>
                    /// </summary>
                    [NameInMap("MaxQueryDurationMs")]
                    [Validation(Required=false)]
                    public string MaxQueryDurationMs { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("MinQueryDurationMs")]
                    [Validation(Required=false)]
                    public string MinQueryDurationMs { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2022-05-22 20:00:01</para>
                    /// </summary>
                    [NameInMap("QueryStartTime")]
                    [Validation(Required=false)]
                    public string QueryStartTime { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Rows")]
            [Validation(Required=false)]
            public string Rows { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RowsBeforeLimitAtLeast")]
            [Validation(Required=false)]
            public string RowsBeforeLimitAtLeast { get; set; }

            [NameInMap("Statistics")]
            [Validation(Required=false)]
            public DescribeSlowLogTrendResponseBodySlowLogTrendStatistics Statistics { get; set; }
            public class DescribeSlowLogTrendResponseBodySlowLogTrendStatistics : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>697899</para>
                /// </summary>
                [NameInMap("BytesRead")]
                [Validation(Required=false)]
                public int? BytesRead { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.001703578</para>
                /// </summary>
                [NameInMap("ElapsedTime")]
                [Validation(Required=false)]
                public float? ElapsedTime { get; set; }

                /// <summary>
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
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>query_start_time</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>UInt64</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

        }

    }

}
