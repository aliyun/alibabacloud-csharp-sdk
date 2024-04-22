// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeSQLLogsResponseBody : TeaModel {
        /// <summary>
        /// The queried SQL execution logs.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeSQLLogsResponseBodyItems> Items { get; set; }
        public class DescribeSQLLogsResponseBodyItems : TeaModel {
            /// <summary>
            /// The database account that executes the SQL statement.
            /// </summary>
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// The name of the database.
            /// </summary>
            [NameInMap("DBName")]
            [Validation(Required=false)]
            public string DBName { get; set; }

            /// <summary>
            /// The role of the database.
            /// </summary>
            [NameInMap("DBRole")]
            [Validation(Required=false)]
            public string DBRole { get; set; }

            /// <summary>
            /// The execution duration of the SQL statement.
            /// </summary>
            [NameInMap("ExecuteCost")]
            [Validation(Required=false)]
            public float? ExecuteCost { get; set; }

            /// <summary>
            /// The execution status of the SQL statement. Valid values:
            /// 
            /// *   **success**
            /// *   **fail**
            /// </summary>
            [NameInMap("ExecuteState")]
            [Validation(Required=false)]
            public string ExecuteState { get; set; }

            /// <summary>
            /// The type of the query language.
            /// </summary>
            [NameInMap("OperationClass")]
            [Validation(Required=false)]
            public string OperationClass { get; set; }

            /// <summary>
            /// The time when the SQL statement was executed.
            /// </summary>
            [NameInMap("OperationExecuteTime")]
            [Validation(Required=false)]
            public string OperationExecuteTime { get; set; }

            /// <summary>
            /// The type of the SQL statement.
            /// </summary>
            [NameInMap("OperationType")]
            [Validation(Required=false)]
            public string OperationType { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("ReturnRowCounts")]
            [Validation(Required=false)]
            public long? ReturnRowCounts { get; set; }

            /// <summary>
            /// The SQL execution plan.
            /// </summary>
            [NameInMap("SQLPlan")]
            [Validation(Required=false)]
            public string SQLPlan { get; set; }

            /// <summary>
            /// The SQL statement.
            /// </summary>
            [NameInMap("SQLText")]
            [Validation(Required=false)]
            public string SQLText { get; set; }

            /// <summary>
            /// The number of entries scanned.
            /// </summary>
            [NameInMap("ScanRowCounts")]
            [Validation(Required=false)]
            public long? ScanRowCounts { get; set; }

            /// <summary>
            /// The source IP address.
            /// </summary>
            [NameInMap("SourceIP")]
            [Validation(Required=false)]
            public string SourceIP { get; set; }

            /// <summary>
            /// The number of the source port.
            /// </summary>
            [NameInMap("SourcePort")]
            [Validation(Required=false)]
            public int? SourcePort { get; set; }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
