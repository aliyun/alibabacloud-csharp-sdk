// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeSQLLogByQueryIdResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeSQLLogByQueryIdResponseBodyItems> Items { get; set; }
        public class DescribeSQLLogByQueryIdResponseBodyItems : TeaModel {
            [NameInMap("OperationClass")]
            [Validation(Required=false)]
            public string OperationClass { get; set; }

            [NameInMap("ExecuteState")]
            [Validation(Required=false)]
            public string ExecuteState { get; set; }

            [NameInMap("ExecuteCost")]
            [Validation(Required=false)]
            public float? ExecuteCost { get; set; }

            [NameInMap("SQLText")]
            [Validation(Required=false)]
            public string SQLText { get; set; }

            [NameInMap("SourcePort")]
            [Validation(Required=false)]
            public int? SourcePort { get; set; }

            [NameInMap("DBRole")]
            [Validation(Required=false)]
            public string DBRole { get; set; }

            [NameInMap("OperationType")]
            [Validation(Required=false)]
            public string OperationType { get; set; }

            [NameInMap("SourceIP")]
            [Validation(Required=false)]
            public string SourceIP { get; set; }

            [NameInMap("SQLPlan")]
            [Validation(Required=false)]
            public string SQLPlan { get; set; }

            [NameInMap("ReturnRowCounts")]
            [Validation(Required=false)]
            public long? ReturnRowCounts { get; set; }

            [NameInMap("DBName")]
            [Validation(Required=false)]
            public string DBName { get; set; }

            [NameInMap("OperationExecuteTime")]
            [Validation(Required=false)]
            public string OperationExecuteTime { get; set; }

            [NameInMap("ScanRowCounts")]
            [Validation(Required=false)]
            public long? ScanRowCounts { get; set; }

            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            [NameInMap("QueryId")]
            [Validation(Required=false)]
            public string QueryId { get; set; }

            [NameInMap("SliceIds")]
            [Validation(Required=false)]
            public List<string> SliceIds { get; set; }

        }

    }

}
