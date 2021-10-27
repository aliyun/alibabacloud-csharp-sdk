// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeEvaluateTaskReportResponseBody : TeaModel {
        [NameInMap("EvaluateResult")]
        [Validation(Required=false)]
        public DescribeEvaluateTaskReportResponseBodyEvaluateResult EvaluateResult { get; set; }
        public class DescribeEvaluateTaskReportResponseBodyEvaluateResult : TeaModel {
            [NameInMap("AllSqlCount")]
            [Validation(Required=false)]
            public int? AllSqlCount { get; set; }
            [NameInMap("DbName")]
            [Validation(Required=false)]
            public string DbName { get; set; }
            [NameInMap("DrdsCount")]
            [Validation(Required=false)]
            public int? DrdsCount { get; set; }
            [NameInMap("DrdsType")]
            [Validation(Required=false)]
            public string DrdsType { get; set; }
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }
            [NameInMap("InstId")]
            [Validation(Required=false)]
            public int? InstId { get; set; }
            [NameInMap("RdsCount")]
            [Validation(Required=false)]
            public int? RdsCount { get; set; }
            [NameInMap("RdsInstInfos")]
            [Validation(Required=false)]
            public DescribeEvaluateTaskReportResponseBodyEvaluateResultRdsInstInfos RdsInstInfos { get; set; }
            public class DescribeEvaluateTaskReportResponseBodyEvaluateResultRdsInstInfos : TeaModel {
                [NameInMap("RdsInstInfos")]
                [Validation(Required=false)]
                public List<DescribeEvaluateTaskReportResponseBodyEvaluateResultRdsInstInfosRdsInstInfos> RdsInstInfos { get; set; }
                public class DescribeEvaluateTaskReportResponseBodyEvaluateResultRdsInstInfosRdsInstInfos : TeaModel {
                    [NameInMap("AvgQpsGrowthScale")]
                    [Validation(Required=false)]
                    public int? AvgQpsGrowthScale { get; set; }

                    [NameInMap("DataGrowthScale")]
                    [Validation(Required=false)]
                    public int? DataGrowthScale { get; set; }

                    [NameInMap("InstId")]
                    [Validation(Required=false)]
                    public string InstId { get; set; }

                    [NameInMap("RdsPeakIopsWeekly")]
                    [Validation(Required=false)]
                    public int? RdsPeakIopsWeekly { get; set; }

                    [NameInMap("RdsPeakQpsWeekly")]
                    [Validation(Required=false)]
                    public int? RdsPeakQpsWeekly { get; set; }

                    [NameInMap("RdsPeakSessionsWeekly")]
                    [Validation(Required=false)]
                    public int? RdsPeakSessionsWeekly { get; set; }

                    [NameInMap("RdsUsedSpace")]
                    [Validation(Required=false)]
                    public int? RdsUsedSpace { get; set; }

                }

            }
            [NameInMap("RdsTotalSpace")]
            [Validation(Required=false)]
            public string RdsTotalSpace { get; set; }
            [NameInMap("RdsType")]
            [Validation(Required=false)]
            public string RdsType { get; set; }
            [NameInMap("SlowSqlCount")]
            [Validation(Required=false)]
            public int? SlowSqlCount { get; set; }
            [NameInMap("TableShardResults")]
            [Validation(Required=false)]
            public DescribeEvaluateTaskReportResponseBodyEvaluateResultTableShardResults TableShardResults { get; set; }
            public class DescribeEvaluateTaskReportResponseBodyEvaluateResultTableShardResults : TeaModel {
                [NameInMap("TableShardResults")]
                [Validation(Required=false)]
                public List<DescribeEvaluateTaskReportResponseBodyEvaluateResultTableShardResultsTableShardResults> TableShardResults { get; set; }
                public class DescribeEvaluateTaskReportResponseBodyEvaluateResultTableShardResultsTableShardResults : TeaModel {
                    [NameInMap("CreateTableSql")]
                    [Validation(Required=false)]
                    public string CreateTableSql { get; set; }

                    [NameInMap("DbShardKey")]
                    [Validation(Required=false)]
                    public string DbShardKey { get; set; }

                    [NameInMap("DbShardMethod")]
                    [Validation(Required=false)]
                    public string DbShardMethod { get; set; }

                    [NameInMap("Dbpartitions")]
                    [Validation(Required=false)]
                    public int? Dbpartitions { get; set; }

                    [NameInMap("OriginDbShardMethod")]
                    [Validation(Required=false)]
                    public string OriginDbShardMethod { get; set; }

                    [NameInMap("OriginTbShardMethod")]
                    [Validation(Required=false)]
                    public string OriginTbShardMethod { get; set; }

                    [NameInMap("RowCount")]
                    [Validation(Required=false)]
                    public int? RowCount { get; set; }

                    [NameInMap("ShardKeyType")]
                    [Validation(Required=false)]
                    public string ShardKeyType { get; set; }

                    [NameInMap("ShardType")]
                    [Validation(Required=false)]
                    public string ShardType { get; set; }

                    [NameInMap("SqlCount")]
                    [Validation(Required=false)]
                    public int? SqlCount { get; set; }

                    [NameInMap("Table")]
                    [Validation(Required=false)]
                    public string Table { get; set; }

                    [NameInMap("TbShardKey")]
                    [Validation(Required=false)]
                    public string TbShardKey { get; set; }

                    [NameInMap("TbShardMethod")]
                    [Validation(Required=false)]
                    public string TbShardMethod { get; set; }

                    [NameInMap("Tbpartitions")]
                    [Validation(Required=false)]
                    public int? Tbpartitions { get; set; }

                }

            }
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public int? TaskId { get; set; }
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
