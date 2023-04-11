// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListDBTaskSQLJobResponseBody : TeaModel {
        /// <summary>
        /// The list of the SQL tasks.
        /// </summary>
        [NameInMap("DBTaskSQLJobList")]
        [Validation(Required=false)]
        public List<ListDBTaskSQLJobResponseBodyDBTaskSQLJobList> DBTaskSQLJobList { get; set; }
        public class ListDBTaskSQLJobResponseBodyDBTaskSQLJobList : TeaModel {
            /// <summary>
            /// The description of the SQL task.
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// The time when the SQL task was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The ID of the database.
            /// </summary>
            [NameInMap("DbId")]
            [Validation(Required=false)]
            public long? DbId { get; set; }

            /// <summary>
            /// The name that is used to search for the database.
            /// </summary>
            [NameInMap("DbSearchName")]
            [Validation(Required=false)]
            public string DbSearchName { get; set; }

            /// <summary>
            /// The ID of the SQL task group.
            /// </summary>
            [NameInMap("DbTaskGroupId")]
            [Validation(Required=false)]
            public long? DbTaskGroupId { get; set; }

            /// <summary>
            /// The ID of the SQL task.
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public long? JobId { get; set; }

            /// <summary>
            /// The type of the SQL task.
            /// </summary>
            [NameInMap("JobType")]
            [Validation(Required=false)]
            public string JobType { get; set; }

            /// <summary>
            /// The time when the SQL task was last executed.
            /// </summary>
            [NameInMap("LastExecTime")]
            [Validation(Required=false)]
            public string LastExecTime { get; set; }

            /// <summary>
            /// Indicates whether the database is a logical database. Valid values:
            /// 
            /// *   **true**: The database is a logical database.
            /// *   **false**: The database is a logical database.
            /// </summary>
            [NameInMap("Logic")]
            [Validation(Required=false)]
            public bool? Logic { get; set; }

            /// <summary>
            /// The state of the SQL task. Valid values:
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
            /// Indicates whether the SQL task is executed as a transaction. Valid values:
            /// 
            /// *   **true**: The SQL task is executed as a transaction.
            /// *   **false**: The SQL task is not executed as a transaction.
            /// </summary>
            [NameInMap("Transactional")]
            [Validation(Required=false)]
            public bool? Transactional { get; set; }

        }

        /// <summary>
        /// The error code returned if the request failed.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message returned if the request failed.
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
        /// Indicates whether the request is successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The total number of the SQL tasks.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
