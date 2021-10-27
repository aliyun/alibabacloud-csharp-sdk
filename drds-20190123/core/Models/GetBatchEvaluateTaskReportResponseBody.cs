// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class GetBatchEvaluateTaskReportResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetBatchEvaluateTaskReportResponseBodyData Data { get; set; }
        public class GetBatchEvaluateTaskReportResponseBodyData : TeaModel {
            [NameInMap("EvaluateResults")]
            [Validation(Required=false)]
            public List<GetBatchEvaluateTaskReportResponseBodyDataEvaluateResults> EvaluateResults { get; set; }
            public class GetBatchEvaluateTaskReportResponseBodyDataEvaluateResults : TeaModel {
                public int? AllSqlCount { get; set; }
                public string DbName { get; set; }
                public int? DrdsCount { get; set; }
                public string DrdsType { get; set; }
                public string GmtCreate { get; set; }
                public string GmtModified { get; set; }
                public int? InstId { get; set; }
                public int? RdsCount { get; set; }
                public GetBatchEvaluateTaskReportResponseBodyDataEvaluateResultsRdsInstInfos RdsInstInfos { get; set; }
                public class GetBatchEvaluateTaskReportResponseBodyDataEvaluateResultsRdsInstInfos : TeaModel {
                    [NameInMap("RdsInstInfos")]
                    [Validation(Required=false)]
                    public List<GetBatchEvaluateTaskReportResponseBodyDataEvaluateResultsRdsInstInfosRdsInstInfos> RdsInstInfos { get; set; }
                    public class GetBatchEvaluateTaskReportResponseBodyDataEvaluateResultsRdsInstInfosRdsInstInfos : TeaModel {
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
                public string RdsTotalSpace { get; set; }
                public string RdsType { get; set; }
                public int? SlowSqlCount { get; set; }
                public GetBatchEvaluateTaskReportResponseBodyDataEvaluateResultsTableShardResults TableShardResults { get; set; }
                public class GetBatchEvaluateTaskReportResponseBodyDataEvaluateResultsTableShardResults : TeaModel {
                    [NameInMap("TableShardResults")]
                    [Validation(Required=false)]
                    public List<GetBatchEvaluateTaskReportResponseBodyDataEvaluateResultsTableShardResultsTableShardResults> TableShardResults { get; set; }
                    public class GetBatchEvaluateTaskReportResponseBodyDataEvaluateResultsTableShardResultsTableShardResults : TeaModel {
                        [NameInMap("CreateTableSql")]
                        [Validation(Required=false)]
                        public string CreateTableSql { get; set; }

                        [NameInMap("DbShardKey")]
                        [Validation(Required=false)]
                        public string DbShardKey { get; set; }

                        [NameInMap("Dbpartitions")]
                        [Validation(Required=false)]
                        public int? Dbpartitions { get; set; }

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

                        [NameInMap("Tbpartitions")]
                        [Validation(Required=false)]
                        public int? Tbpartitions { get; set; }

                    }

                }
                public int? TaskId { get; set; }
                public string TaskName { get; set; }
                public string TaskStatus { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
