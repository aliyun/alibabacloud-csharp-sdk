// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class DescribeSlowLogRecordsResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The details about the slow query logs.
        /// </summary>
        [NameInMap("SlowLogRecords")]
        [Validation(Required=false)]
        public DescribeSlowLogRecordsResponseBodySlowLogRecords SlowLogRecords { get; set; }
        public class DescribeSlowLogRecordsResponseBodySlowLogRecords : TeaModel {
            /// <summary>
            /// Details about the slow query logs.
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
                    /// The IP address of the client that initiated the query.
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
                    /// The username that is used to initiate the query.
                    /// </summary>
                    [NameInMap("InitialUser")]
                    [Validation(Required=false)]
                    public string InitialUser { get; set; }

                    /// <summary>
                    /// The peak memory usage for the query. Unit: bytes.
                    /// </summary>
                    [NameInMap("MemoryUsage")]
                    [Validation(Required=false)]
                    public string MemoryUsage { get; set; }

                    /// <summary>
                    /// The statement that was executed in the query.
                    /// </summary>
                    [NameInMap("Query")]
                    [Validation(Required=false)]
                    public string Query { get; set; }

                    /// <summary>
                    /// The duration of the query. Unit: milliseconds.
                    /// </summary>
                    [NameInMap("QueryDurationMs")]
                    [Validation(Required=false)]
                    public string QueryDurationMs { get; set; }

                    /// <summary>
                    /// The beginning of the time range to query. The time is in the yyyy-MM-dd hh:mm:ss format. The time is displayed in UTC.
                    /// </summary>
                    [NameInMap("QueryStartTime")]
                    [Validation(Required=false)]
                    public string QueryStartTime { get; set; }

                    /// <summary>
                    /// The size of the data read by executing the statement. Unit: bytes.
                    /// </summary>
                    [NameInMap("ReadBytes")]
                    [Validation(Required=false)]
                    public string ReadBytes { get; set; }

                    /// <summary>
                    /// The number of rows read by executing the statement.
                    /// </summary>
                    [NameInMap("ReadRows")]
                    [Validation(Required=false)]
                    public string ReadRows { get; set; }

                    /// <summary>
                    /// The size of the result data. Unit: bytes.
                    /// </summary>
                    [NameInMap("ResultBytes")]
                    [Validation(Required=false)]
                    public string ResultBytes { get; set; }

                    /// <summary>
                    /// The query status. Valid values:
                    /// 
                    /// *   **QueryFinish**: The query is complete.
                    /// *   **Processing**: The query is running.
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            /// <summary>
            /// The number of rows in the result set.
            /// </summary>
            [NameInMap("Rows")]
            [Validation(Required=false)]
            public string Rows { get; set; }

            /// <summary>
            /// The number of entries per page.
            /// </summary>
            [NameInMap("RowsBeforeLimitAtLeast")]
            [Validation(Required=false)]
            public string RowsBeforeLimitAtLeast { get; set; }

            /// <summary>
            /// The statistics of the results.
            /// </summary>
            [NameInMap("Statistics")]
            [Validation(Required=false)]
            public DescribeSlowLogRecordsResponseBodySlowLogRecordsStatistics Statistics { get; set; }
            public class DescribeSlowLogRecordsResponseBodySlowLogRecordsStatistics : TeaModel {
                /// <summary>
                /// The total size of data that were read. Unit: bytes.
                /// </summary>
                [NameInMap("BytesRead")]
                [Validation(Required=false)]
                public int? BytesRead { get; set; }

                /// <summary>
                /// The time consumed by the slow query. Unit: milliseconds.
                /// </summary>
                [NameInMap("ElapsedTime")]
                [Validation(Required=false)]
                public float? ElapsedTime { get; set; }

                /// <summary>
                /// The total number of rows that were read.
                /// </summary>
                [NameInMap("RowsRead")]
                [Validation(Required=false)]
                public int? RowsRead { get; set; }

            }

            /// <summary>
            /// The schema of the table in the database.
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
                    /// The name of the column.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The type of the column.
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

        }

    }

}
