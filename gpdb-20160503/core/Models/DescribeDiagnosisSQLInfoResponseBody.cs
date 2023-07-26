// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDiagnosisSQLInfoResponseBody : TeaModel {
        /// <summary>
        /// The name of the database.
        /// </summary>
        [NameInMap("Database")]
        [Validation(Required=false)]
        public string Database { get; set; }

        /// <summary>
        /// The execution duration of the query. Unit: seconds.
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// The maximum number of output rows.
        /// </summary>
        [NameInMap("MaxOutputRows")]
        [Validation(Required=false)]
        public string MaxOutputRows { get; set; }

        /// <summary>
        /// The ID of the query.
        /// </summary>
        [NameInMap("QueryID")]
        [Validation(Required=false)]
        public string QueryID { get; set; }

        /// <summary>
        /// The information of the operator.
        /// </summary>
        [NameInMap("QueryPlan")]
        [Validation(Required=false)]
        public string QueryPlan { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The SQL statement.
        /// </summary>
        [NameInMap("SQLStmt")]
        [Validation(Required=false)]
        public string SQLStmt { get; set; }

        /// <summary>
        /// The ID of the session that contains the query.
        /// </summary>
        [NameInMap("SessionID")]
        [Validation(Required=false)]
        public string SessionID { get; set; }

        /// <summary>
        /// The sequence of metrics.
        /// </summary>
        [NameInMap("SortedMetrics")]
        [Validation(Required=false)]
        public string SortedMetrics { get; set; }

        /// <summary>
        /// The start time of the query. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// The execution state of the query. Valid values:
        /// 
        /// *   **running**: The query is being executed.
        /// *   **finished**: The query execution is complete.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The information of the execution plan.
        /// </summary>
        [NameInMap("TextPlan")]
        [Validation(Required=false)]
        public string TextPlan { get; set; }

        /// <summary>
        /// The name of the database account.
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public string User { get; set; }

    }

}
