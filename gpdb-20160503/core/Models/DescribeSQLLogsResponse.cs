// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeSQLLogsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=true)]
        public int? PageNumber { get; set; }

        [NameInMap("PageRecordCount")]
        [Validation(Required=true)]
        public int? PageRecordCount { get; set; }

        [NameInMap("Items")]
        [Validation(Required=true)]
        public List<DescribeSQLLogsResponseItems> Items { get; set; }
        public class DescribeSQLLogsResponseItems : TeaModel {
            [NameInMap("DBName")]
            [Validation(Required=true)]
            public string DBName { get; set; }

            [NameInMap("AccountName")]
            [Validation(Required=true)]
            public string AccountName { get; set; }

            [NameInMap("OperationExecuteTime")]
            [Validation(Required=true)]
            public string OperationExecuteTime { get; set; }

            [NameInMap("SQLText")]
            [Validation(Required=true)]
            public string SQLText { get; set; }

            [NameInMap("ReturnRowCounts")]
            [Validation(Required=true)]
            public long ReturnRowCounts { get; set; }

            [NameInMap("ExecuteCost")]
            [Validation(Required=true)]
            public float? ExecuteCost { get; set; }

            [NameInMap("DBRole")]
            [Validation(Required=true)]
            public string DBRole { get; set; }

            [NameInMap("SourceIP")]
            [Validation(Required=true)]
            public string SourceIP { get; set; }

            [NameInMap("SourcePort")]
            [Validation(Required=true)]
            public int? SourcePort { get; set; }

            [NameInMap("ExecuteState")]
            [Validation(Required=true)]
            public string ExecuteState { get; set; }

            [NameInMap("OperationClass")]
            [Validation(Required=true)]
            public string OperationClass { get; set; }

            [NameInMap("OperationType")]
            [Validation(Required=true)]
            public string OperationType { get; set; }

            [NameInMap("ScanRowCounts")]
            [Validation(Required=true)]
            public long ScanRowCounts { get; set; }

            [NameInMap("SQLPlan")]
            [Validation(Required=true)]
            public string SQLPlan { get; set; }

        }

    }

}
