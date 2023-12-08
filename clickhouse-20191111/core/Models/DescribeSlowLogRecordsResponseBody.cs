// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class DescribeSlowLogRecordsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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

            [NameInMap("Rows")]
            [Validation(Required=false)]
            public string Rows { get; set; }

            [NameInMap("RowsBeforeLimitAtLeast")]
            [Validation(Required=false)]
            public string RowsBeforeLimitAtLeast { get; set; }

            [NameInMap("Statistics")]
            [Validation(Required=false)]
            public DescribeSlowLogRecordsResponseBodySlowLogRecordsStatistics Statistics { get; set; }
            public class DescribeSlowLogRecordsResponseBodySlowLogRecordsStatistics : TeaModel {
                [NameInMap("BytesRead")]
                [Validation(Required=false)]
                public int? BytesRead { get; set; }

                [NameInMap("ElapsedTime")]
                [Validation(Required=false)]
                public float? ElapsedTime { get; set; }

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
