// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDiagnosisRecordsResponseBody : TeaModel {
        /// <summary>
        /// Details of SQL queries.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeDiagnosisRecordsResponseBodyItems> Items { get; set; }
        public class DescribeDiagnosisRecordsResponseBodyItems : TeaModel {
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
            /// The ID of the query. It is a unique identifier of the query.
            /// </summary>
            [NameInMap("QueryID")]
            [Validation(Required=false)]
            public string QueryID { get; set; }

            /// <summary>
            /// The SQL statement.
            /// </summary>
            [NameInMap("SQLStmt")]
            [Validation(Required=false)]
            public string SQLStmt { get; set; }

            /// <summary>
            /// Indicates whether the SQL statement needs to be truncated. Valid values:
            /// 
            /// *   **true**: The SQL statement needs to be truncated.
            /// *   **false**: The SQL statement does not need to be truncated.
            /// </summary>
            [NameInMap("SQLTruncated")]
            [Validation(Required=false)]
            public bool? SQLTruncated { get; set; }

            /// <summary>
            /// The threshold used to determine whether an SQL statement must be truncated. The value is the number of characters.
            /// </summary>
            [NameInMap("SQLTruncatedThreshold")]
            [Validation(Required=false)]
            public int? SQLTruncatedThreshold { get; set; }

            /// <summary>
            /// The ID of the session that contains the query.
            /// </summary>
            [NameInMap("SessionID")]
            [Validation(Required=false)]
            public string SessionID { get; set; }

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
            /// *   **finished**: The query is complete.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The name of the database account.
            /// </summary>
            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
