// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class DescribeProcessListResponseBody : TeaModel {
        /// <summary>
        /// The queries.
        /// </summary>
        [NameInMap("ProcessList")]
        [Validation(Required=false)]
        public DescribeProcessListResponseBodyProcessList ProcessList { get; set; }
        public class DescribeProcessListResponseBodyProcessList : TeaModel {
            /// <summary>
            /// The details of the query.
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
                    /// The IP address of the client that initiates the query.
                    /// </summary>
                    [NameInMap("InitialAddress")]
                    [Validation(Required=false)]
                    public string InitialAddress { get; set; }

                    /// <summary>
                    /// The query ID.
                    /// </summary>
                    [NameInMap("InitialQueryId")]
                    [Validation(Required=false)]
                    public string InitialQueryId { get; set; }

                    /// <summary>
                    /// The database account.
                    /// </summary>
                    [NameInMap("InitialUser")]
                    [Validation(Required=false)]
                    public string InitialUser { get; set; }

                    /// <summary>
                    /// The SQL statement that is executed in the query.
                    /// </summary>
                    [NameInMap("Query")]
                    [Validation(Required=false)]
                    public string Query { get; set; }

                    /// <summary>
                    /// The execution duration of the query. Unit: milliseconds.
                    /// </summary>
                    [NameInMap("QueryDurationMs")]
                    [Validation(Required=false)]
                    public string QueryDurationMs { get; set; }

                    /// <summary>
                    /// The beginning of the time range to query. The value is in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in Coordinated Universal Time (UTC).
                    /// </summary>
                    [NameInMap("QueryStartTime")]
                    [Validation(Required=false)]
                    public string QueryStartTime { get; set; }

                }

            }

            /// <summary>
            /// The number of rows returned for the query.
            /// </summary>
            [NameInMap("Rows")]
            [Validation(Required=false)]
            public string Rows { get; set; }

            /// <summary>
            /// The number of entries returned per page.
            /// </summary>
            [NameInMap("RowsBeforeLimitAtLeast")]
            [Validation(Required=false)]
            public string RowsBeforeLimitAtLeast { get; set; }

            /// <summary>
            /// The statistics of the results.
            /// </summary>
            [NameInMap("Statistics")]
            [Validation(Required=false)]
            public DescribeProcessListResponseBodyProcessListStatistics Statistics { get; set; }
            public class DescribeProcessListResponseBodyProcessListStatistics : TeaModel {
                /// <summary>
                /// The size of the data that was scanned. Unit: bytes.
                /// </summary>
                [NameInMap("BytesRead")]
                [Validation(Required=false)]
                public int? BytesRead { get; set; }

                /// <summary>
                /// The average response time.
                /// </summary>
                [NameInMap("ElapsedTime")]
                [Validation(Required=false)]
                public float? ElapsedTime { get; set; }

                /// <summary>
                /// The number of scanned rows.
                /// </summary>
                [NameInMap("RowsRead")]
                [Validation(Required=false)]
                public int? RowsRead { get; set; }

            }

            /// <summary>
            /// Details of the columns.
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
                    /// The column name.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The column type.
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
