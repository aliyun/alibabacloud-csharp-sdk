// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class DescribeDataImportTasksResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeDataImportTasksResponseBodyData Data { get; set; }
        public class DescribeDataImportTasksResponseBodyData : TeaModel {
            [NameInMap("DataImportTask")]
            [Validation(Required=false)]
            public List<DescribeDataImportTasksResponseBodyDataDataImportTask> DataImportTask { get; set; }
            public class DescribeDataImportTasksResponseBodyDataDataImportTask : TeaModel {
                public int? BatchEvaluateTaskId { get; set; }
                public int? CreateDbProgress { get; set; }
                public int? CreateTablesProgress { get; set; }
                public string DstDbName { get; set; }
                public string DstInstId { get; set; }
                public int? EvaluateTaskId { get; set; }
                public string GmtCreate { get; set; }
                public string GmtModified { get; set; }
                public int? Id { get; set; }
                public DescribeDataImportTasksResponseBodyDataDataImportTaskJingweiProgress JingweiProgress { get; set; }
                public class DescribeDataImportTasksResponseBodyDataDataImportTaskJingweiProgress : TeaModel {
                    [NameInMap("Full")]
                    [Validation(Required=false)]
                    public DescribeDataImportTasksResponseBodyDataDataImportTaskJingweiProgressFull Full { get; set; }
                    public class DescribeDataImportTasksResponseBodyDataDataImportTaskJingweiProgressFull : TeaModel {
                        [NameInMap("NeedTime")]
                        [Validation(Required=false)]
                        public int? NeedTime { get; set; }
                        [NameInMap("Progress")]
                        [Validation(Required=false)]
                        public int? Progress { get; set; }
                        [NameInMap("Tps")]
                        [Validation(Required=false)]
                        public int? Tps { get; set; }
                        [NameInMap("TransferCount")]
                        [Validation(Required=false)]
                        public int? TransferCount { get; set; }
                    };

                    [NameInMap("FullRunning")]
                    [Validation(Required=false)]
                    public bool? FullRunning { get; set; }

                    [NameInMap("Increment")]
                    [Validation(Required=false)]
                    public DescribeDataImportTasksResponseBodyDataDataImportTaskJingweiProgressIncrement Increment { get; set; }
                    public class DescribeDataImportTasksResponseBodyDataDataImportTaskJingweiProgressIncrement : TeaModel {
                        [NameInMap("Delay")]
                        [Validation(Required=false)]
                        public int? Delay { get; set; }
                        [NameInMap("Tps")]
                        [Validation(Required=false)]
                        public int? Tps { get; set; }
                        [NameInMap("TransferCount")]
                        [Validation(Required=false)]
                        public int? TransferCount { get; set; }
                    };

                    [NameInMap("IncrementRunning")]
                    [Validation(Required=false)]
                    public bool? IncrementRunning { get; set; }

                }
                public int? Progress { get; set; }
                public string SrcDbName { get; set; }
                public string SrcInstId { get; set; }
                public string Stage { get; set; }
                public string Status { get; set; }
                public string TaskName { get; set; }
                public int? Type { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
