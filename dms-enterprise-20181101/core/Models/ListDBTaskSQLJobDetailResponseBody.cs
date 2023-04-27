// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListDBTaskSQLJobDetailResponseBody : TeaModel {
        /// <summary>
        /// The point in time when the SQL task ended.
        /// </summary>
        [NameInMap("DBTaskSQLJobDetailList")]
        [Validation(Required=false)]
        public List<ListDBTaskSQLJobDetailResponseBodyDBTaskSQLJobDetailList> DBTaskSQLJobDetailList { get; set; }
        public class ListDBTaskSQLJobDetailResponseBodyDBTaskSQLJobDetailList : TeaModel {
            [NameInMap("AffectRows")]
            [Validation(Required=false)]
            public long? AffectRows { get; set; }

            /// <summary>
            /// The duration of the SQL task. Unit: milliseconds.
            /// </summary>
            [NameInMap("CurrentSql")]
            [Validation(Required=false)]
            public string CurrentSql { get; set; }

            /// <summary>
            /// The number of entries to return on each page.
            /// </summary>
            [NameInMap("DbId")]
            [Validation(Required=false)]
            public long? DbId { get; set; }

            /// <summary>
            /// The ID of the request.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// The point in time when the SQL task started.
            /// </summary>
            [NameInMap("ExecuteCount")]
            [Validation(Required=false)]
            public long? ExecuteCount { get; set; }

            /// <summary>
            /// The ID of the SQL task.
            /// </summary>
            [NameInMap("JobDetailId")]
            [Validation(Required=false)]
            public long? JobDetailId { get; set; }

            /// <summary>
            /// The number of the page to return.
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
            /// The details of SQL tasks.
            /// </summary>
            [NameInMap("Logic")]
            [Validation(Required=false)]
            public bool? Logic { get; set; }

            /// <summary>
            /// The error message that is returned.
            /// </summary>
            [NameInMap("Skip")]
            [Validation(Required=false)]
            public bool? Skip { get; set; }

            /// <summary>
            /// The ID of the details of the SQL task.
            /// </summary>
            [NameInMap("SqlType")]
            [Validation(Required=false)]
            public string SqlType { get; set; }

            /// <summary>
            /// The ID of the tenant. You can call the [GetUserActiveTenant](~~198073~~) operation to query the tenant ID.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// Indicates whether the SQL statement was skipped. Valid values:
            /// 
            /// *   **true**: The SQL statement was skipped.
            /// *   **false**: The SQL statement was not skipped.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TimeDelay")]
            [Validation(Required=false)]
            public long? TimeDelay { get; set; }

        }

        /// <summary>
        /// The type of the SQL statement, such as DELETE, UPDATE, or ALTER_TABLE.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The ID of the SQL task. You can call the [ListDBTaskSQLJob](~~207049~~) operation to query the SQL task ID.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The operation that you want to perform. Set the value to **ListDBTaskSQLJobDetail**.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The SQL statement that was executed in the SQL task.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
