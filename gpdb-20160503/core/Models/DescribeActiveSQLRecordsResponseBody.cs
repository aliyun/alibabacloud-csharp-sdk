// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeActiveSQLRecordsResponseBody : TeaModel {
        /// <summary>
        /// The instance ID.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The queried SQL records.
        /// </summary>
        [NameInMap("Queries")]
        [Validation(Required=false)]
        public List<DescribeActiveSQLRecordsResponseBodyQueries> Queries { get; set; }
        public class DescribeActiveSQLRecordsResponseBodyQueries : TeaModel {
            /// <summary>
            /// The IP address of the client.
            /// </summary>
            [NameInMap("ClientAddr")]
            [Validation(Required=false)]
            public string ClientAddr { get; set; }

            /// <summary>
            /// The name of the database.
            /// </summary>
            [NameInMap("Database")]
            [Validation(Required=false)]
            public string Database { get; set; }

            /// <summary>
            /// The progress ID.
            /// </summary>
            [NameInMap("PID")]
            [Validation(Required=false)]
            public string PID { get; set; }

            /// <summary>
            /// The SQL statement of the query.
            /// </summary>
            [NameInMap("Query")]
            [Validation(Required=false)]
            public string Query { get; set; }

            /// <summary>
            /// The execution duration of the query. Unit: seconds.
            /// </summary>
            [NameInMap("QueryDuration")]
            [Validation(Required=false)]
            public string QueryDuration { get; set; }

            /// <summary>
            /// The start time of the query.
            /// </summary>
            [NameInMap("QueryStart")]
            [Validation(Required=false)]
            public string QueryStart { get; set; }

            /// <summary>
            /// The session ID.
            /// </summary>
            [NameInMap("SessionID")]
            [Validation(Required=false)]
            public string SessionID { get; set; }

            /// <summary>
            /// Indicates whether the SQL statement is truncated. Valid values:
            /// 
            /// *   true
            /// *   false
            /// </summary>
            [NameInMap("SqlTruncated")]
            [Validation(Required=false)]
            public string SqlTruncated { get; set; }

            /// <summary>
            /// The threshold that is used to truncate the SQL statement.
            /// </summary>
            [NameInMap("SqlTruncatedThreshold")]
            [Validation(Required=false)]
            public string SqlTruncatedThreshold { get; set; }

            /// <summary>
            /// The status of the asynchronous request. Valid values:
            /// 
            /// *   **running**
            /// *   **block**
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// The name of the database account.
            /// </summary>
            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
