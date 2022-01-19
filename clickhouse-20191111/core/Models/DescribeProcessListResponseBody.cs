// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class DescribeProcessListResponseBody : TeaModel {
        [NameInMap("ProcessList")]
        [Validation(Required=false)]
        public DescribeProcessListResponseBodyProcessList ProcessList { get; set; }
        public class DescribeProcessListResponseBodyProcessList : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public DescribeProcessListResponseBodyProcessListData Data { get; set; }
            public class DescribeProcessListResponseBodyProcessListData : TeaModel {
                [NameInMap("ResultSet")]
                [Validation(Required=false)]
                public List<DescribeProcessListResponseBodyProcessListDataResultSet> ResultSet { get; set; }
                public class DescribeProcessListResponseBodyProcessListDataResultSet : TeaModel {
                    [NameInMap("InitialAddress")]
                    [Validation(Required=false)]
                    public string InitialAddress { get; set; }

                    [NameInMap("InitialQueryId")]
                    [Validation(Required=false)]
                    public string InitialQueryId { get; set; }

                    [NameInMap("InitialUser")]
                    [Validation(Required=false)]
                    public string InitialUser { get; set; }

                    [NameInMap("Query")]
                    [Validation(Required=false)]
                    public string Query { get; set; }

                    [NameInMap("QueryDurationMs")]
                    [Validation(Required=false)]
                    public string QueryDurationMs { get; set; }

                    [NameInMap("QueryStartTime")]
                    [Validation(Required=false)]
                    public string QueryStartTime { get; set; }

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
            public DescribeProcessListResponseBodyProcessListStatistics Statistics { get; set; }
            public class DescribeProcessListResponseBodyProcessListStatistics : TeaModel {
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
            public DescribeProcessListResponseBodyProcessListTableSchema TableSchema { get; set; }
            public class DescribeProcessListResponseBodyProcessListTableSchema : TeaModel {
                [NameInMap("ResultSet")]
                [Validation(Required=false)]
                public List<DescribeProcessListResponseBodyProcessListTableSchemaResultSet> ResultSet { get; set; }
                public class DescribeProcessListResponseBodyProcessListTableSchemaResultSet : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
