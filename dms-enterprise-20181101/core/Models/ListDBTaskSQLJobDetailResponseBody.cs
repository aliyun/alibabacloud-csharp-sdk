// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListDBTaskSQLJobDetailResponseBody : TeaModel {
        /// <summary>
        /// The details of SQL tasks.
        /// </summary>
        [NameInMap("DBTaskSQLJobDetailList")]
        [Validation(Required=false)]
        public List<ListDBTaskSQLJobDetailResponseBodyDBTaskSQLJobDetailList> DBTaskSQLJobDetailList { get; set; }
        public class ListDBTaskSQLJobDetailResponseBodyDBTaskSQLJobDetailList : TeaModel {
            /// <summary>
            /// The number of rows affected by the SQL task.
            /// </summary>
            [NameInMap("AffectRows")]
            [Validation(Required=false)]
            public long? AffectRows { get; set; }

            /// <summary>
            /// The SQL statement that was executed in the SQL task.
            /// </summary>
            [NameInMap("CurrentSql")]
            [Validation(Required=false)]
            public string CurrentSql { get; set; }

            /// <summary>
            /// The ID of the physical database.
            /// </summary>
            [NameInMap("DbId")]
            [Validation(Required=false)]
            public long? DbId { get; set; }

            /// <summary>
            /// The point in time when the SQL task ended.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// The number of times that the SQL statement was executed.
            /// </summary>
            [NameInMap("ExecuteCount")]
            [Validation(Required=false)]
            public long? ExecuteCount { get; set; }

            /// <summary>
            /// The ID of the details of the SQL task.
            /// </summary>
            [NameInMap("JobDetailId")]
            [Validation(Required=false)]
            public long? JobDetailId { get; set; }

            /// <summary>
            /// The ID of the SQL task.
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public long? JobId { get; set; }

            /// <summary>
            /// The details of the operational log.
            /// </summary>
            [NameInMap("Log")]
            [Validation(Required=false)]
            public string Log { get; set; }

            /// <summary>
            /// Indicates whether the database is a logical database. Valid values:
            /// 
            /// *   **true**: The database is a logical database.
            /// *   **false**: The database is a physical database.
            /// </summary>
            [NameInMap("Logic")]
            [Validation(Required=false)]
            public bool? Logic { get; set; }

            /// <summary>
            /// Indicates whether the SQL statement was skipped. Valid values:
            /// 
            /// *   **true**: The SQL statement was skipped.
            /// *   **false**: The SQL statement was not skipped.
            /// </summary>
            [NameInMap("Skip")]
            [Validation(Required=false)]
            public bool? Skip { get; set; }

            /// <summary>
            /// The type of the SQL statement, such as DELETE, UPDATE, or ALTER_TABLE.
            /// </summary>
            [NameInMap("SqlType")]
            [Validation(Required=false)]
            public string SqlType { get; set; }

            /// <summary>
            /// The point in time when the SQL task started.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// The status of the SQL task. Valid values:
            /// 
            /// *   **INIT**: The SQL task was initialized.
            /// *   **PENDING**: The SQL task waited to be run.
            /// *   **BE_SCHEDULED**: The SQL task waited to be scheduled.
            /// *   **FAIL**: The SQL task failed.
            /// *   **SUCCESS**: The SQL task was successful.
            /// *   **PAUSE**: The SQL task was paused.
            /// *   **DELETE**: The SQL task was deleted.
            /// *   **RUNNING**: The SQL task was being run.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The duration of the SQL task. Unit: milliseconds.
            /// </summary>
            [NameInMap("TimeDelay")]
            [Validation(Required=false)]
            public long? TimeDelay { get; set; }

        }

        /// <summary>
        /// The error code that is returned.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message that is returned.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request is successful. Valid values:
        /// 
        /// *   **true**: The request is successful.
        /// *   **false**: The request fails.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The total number of SQL tasks.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
