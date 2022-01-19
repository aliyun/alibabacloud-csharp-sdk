// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Clickhouse20191111.Models
{
    public class DescribeSlowLogTrendResponseBody : TeaModel {
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
            [NameInMap("Rows")]
            [Validation(Required=false)]
            public string Rows { get; set; }
            [NameInMap("RowsBeforeLimitAtLeast")]
            [Validation(Required=false)]
            public string RowsBeforeLimitAtLeast { get; set; }
            [NameInMap("Statistics")]
            [Validation(Required=false)]
            public DescribeSlowLogTrendResponseBodySlowLogTrendStatistics Statistics { get; set; }
            public class DescribeSlowLogTrendResponseBodySlowLogTrendStatistics : TeaModel {
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
        };

    }

}
