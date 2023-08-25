// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeAuditLogRecordsResponseBody : TeaModel {
        /// <summary>
        /// The ID of the AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The queried SQL audit logs.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<DescribeAuditLogRecordsResponseBodyItems> Items { get; set; }
        public class DescribeAuditLogRecordsResponseBodyItems : TeaModel {
            /// <summary>
            /// The connection ID.
            /// </summary>
            [NameInMap("ConnId")]
            [Validation(Required=false)]
            public string ConnId { get; set; }

            /// <summary>
            /// The name of the database on which the SQL statement was executed.
            /// </summary>
            [NameInMap("DBName")]
            [Validation(Required=false)]
            public string DBName { get; set; }

            /// <summary>
            /// The start time of the execution of the SQL statement. The time is displayed in the ISO 8601 standard in the yyyy-MM-dd HH:mm:ss format. The time must be in UTC.
            /// </summary>
            [NameInMap("ExecuteTime")]
            [Validation(Required=false)]
            public string ExecuteTime { get; set; }

            /// <summary>
            /// The IP address and port number of the client that is used to execute the SQL statement.
            /// </summary>
            [NameInMap("HostAddress")]
            [Validation(Required=false)]
            public string HostAddress { get; set; }

            /// <summary>
            /// The task ID.
            /// </summary>
            [NameInMap("ProcessID")]
            [Validation(Required=false)]
            public string ProcessID { get; set; }

            /// <summary>
            /// The SQL statement.
            /// </summary>
            [NameInMap("SQLText")]
            [Validation(Required=false)]
            public string SQLText { get; set; }

            /// <summary>
            /// The type of the SQL statement.
            /// </summary>
            [NameInMap("SQLType")]
            [Validation(Required=false)]
            public string SQLType { get; set; }

            /// <summary>
            /// Indicates whether the SQL statement was successfully executed. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("Succeed")]
            [Validation(Required=false)]
            public string Succeed { get; set; }

            /// <summary>
            /// The amount of time that is consumed to execute the SQL statement. Unit: milliseconds.
            /// </summary>
            [NameInMap("TotalTime")]
            [Validation(Required=false)]
            public string TotalTime { get; set; }

            /// <summary>
            /// The username that is used to execute the SQL statement.
            /// </summary>
            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
