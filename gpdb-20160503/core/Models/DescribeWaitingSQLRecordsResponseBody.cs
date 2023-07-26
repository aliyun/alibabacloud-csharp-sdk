// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeWaitingSQLRecordsResponseBody : TeaModel {
        /// <summary>
        /// The list of lock diagnostics records.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeWaitingSQLRecordsResponseBodyItems> Items { get; set; }
        public class DescribeWaitingSQLRecordsResponseBodyItems : TeaModel {
            /// <summary>
            /// The name of the database.
            /// </summary>
            [NameInMap("Database")]
            [Validation(Required=false)]
            public string Database { get; set; }

            /// <summary>
            /// The ID of the process that uniquely identifies the query.
            /// </summary>
            [NameInMap("PID")]
            [Validation(Required=false)]
            public string PID { get; set; }

            /// <summary>
            /// The SQL statement of the query.
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
            /// The start time of the query. This value is in the timestamp format. Unit: milliseconds.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// The waiting state of the query. Valid values:
            /// 
            /// *   **LockWaiting**
            /// *   **ResourceWaiting**
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The database account that is used to perform the query.
            /// </summary>
            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

            /// <summary>
            /// The waiting period of the query. Unit: milliseconds.
            /// </summary>
            [NameInMap("WaitingTime")]
            [Validation(Required=false)]
            public long? WaitingTime { get; set; }

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
