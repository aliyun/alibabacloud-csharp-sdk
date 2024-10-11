// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class DescribeProcessListResponseBody : TeaModel {
        /// <summary>
        /// <para>The queries.</para>
        /// </summary>
        [NameInMap("ProcessList")]
        [Validation(Required=false)]
        public DescribeProcessListResponseBodyProcessList ProcessList { get; set; }
        public class DescribeProcessListResponseBodyProcessList : TeaModel {
            /// <summary>
            /// <para>The details of the query.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public DescribeProcessListResponseBodyProcessListData Data { get; set; }
            public class DescribeProcessListResponseBodyProcessListData : TeaModel {
                [NameInMap("ResultSet")]
                [Validation(Required=false)]
                public List<DescribeProcessListResponseBodyProcessListDataResultSet> ResultSet { get; set; }
                public class DescribeProcessListResponseBodyProcessListDataResultSet : TeaModel {
                    /// <summary>
                    /// <para>The IP address of the client that initiates the query.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>::ffff:10.1.XX.XX</para>
                    /// </summary>
                    [NameInMap("InitialAddress")]
                    [Validation(Required=false)]
                    public string InitialAddress { get; set; }

                    /// <summary>
                    /// <para>The query ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2dd144fd-4230-4249-b15c-e63f964fbb5a</para>
                    /// </summary>
                    [NameInMap("InitialQueryId")]
                    [Validation(Required=false)]
                    public string InitialQueryId { get; set; }

                    /// <summary>
                    /// <para>The database account.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("InitialUser")]
                    [Validation(Required=false)]
                    public string InitialUser { get; set; }

                    /// <summary>
                    /// <para>The SQL statement that is executed in the query.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>select * from test order by score limit 1;</para>
                    /// </summary>
                    [NameInMap("Query")]
                    [Validation(Required=false)]
                    public string Query { get; set; }

                    /// <summary>
                    /// <para>The execution duration of the query. Unit: milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2000</para>
                    /// </summary>
                    [NameInMap("QueryDurationMs")]
                    [Validation(Required=false)]
                    public string QueryDurationMs { get; set; }

                    /// <summary>
                    /// <para>The beginning of the time range to query. The value is in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in Coordinated Universal Time (UTC).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2021-02-02T09:14:48Z</para>
                    /// </summary>
                    [NameInMap("QueryStartTime")]
                    [Validation(Required=false)]
                    public string QueryStartTime { get; set; }

                }

            }

            /// <summary>
            /// <para>The number of rows returned for the query.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1145700</para>
            /// </summary>
            [NameInMap("Rows")]
            [Validation(Required=false)]
            public string Rows { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
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
            public DescribeProcessListResponseBodyProcessListStatistics Statistics { get; set; }
            public class DescribeProcessListResponseBodyProcessListStatistics : TeaModel {
                /// <summary>
                /// <para>The size of the data that was scanned. Unit: bytes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9141300000</para>
                /// </summary>
                [NameInMap("BytesRead")]
                [Validation(Required=false)]
                public int? BytesRead { get; set; }

                /// <summary>
                /// <para>The average response time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4156</para>
                /// </summary>
                [NameInMap("ElapsedTime")]
                [Validation(Required=false)]
                public float? ElapsedTime { get; set; }

                /// <summary>
                /// <para>The number of scanned rows.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000000</para>
                /// </summary>
                [NameInMap("RowsRead")]
                [Validation(Required=false)]
                public int? RowsRead { get; set; }

            }

            /// <summary>
            /// <para>Details of the columns.</para>
            /// </summary>
            [NameInMap("TableSchema")]
            [Validation(Required=false)]
            public DescribeProcessListResponseBodyProcessListTableSchema TableSchema { get; set; }
            public class DescribeProcessListResponseBodyProcessListTableSchema : TeaModel {
                [NameInMap("ResultSet")]
                [Validation(Required=false)]
                public List<DescribeProcessListResponseBodyProcessListTableSchemaResultSet> ResultSet { get; set; }
                public class DescribeProcessListResponseBodyProcessListTableSchemaResultSet : TeaModel {
                    /// <summary>
                    /// <para>The column name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>InitialUser</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The column type.</para>
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

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FD61BB0D-788A-5185-A8E3-1B90BA8F6F04</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
