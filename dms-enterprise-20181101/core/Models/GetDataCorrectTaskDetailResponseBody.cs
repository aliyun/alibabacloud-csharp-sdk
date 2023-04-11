// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetDataCorrectTaskDetailResponseBody : TeaModel {
        /// <summary>
        /// The details of the data change task.
        /// </summary>
        [NameInMap("DataCorrectTaskDetail")]
        [Validation(Required=false)]
        public GetDataCorrectTaskDetailResponseBodyDataCorrectTaskDetail DataCorrectTaskDetail { get; set; }
        public class GetDataCorrectTaskDetailResponseBodyDataCorrectTaskDetail : TeaModel {
            /// <summary>
            /// The number of rows affected by the SQL statement.
            /// </summary>
            [NameInMap("ActualAffectRows")]
            [Validation(Required=false)]
            public long? ActualAffectRows { get; set; }

            /// <summary>
            /// The time when the task was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The ID of the SQL task group.
            /// </summary>
            [NameInMap("DBTaskGroupId")]
            [Validation(Required=false)]
            public long? DBTaskGroupId { get; set; }

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
            [NameInMap("jobStatus")]
            [Validation(Required=false)]
            public string JobStatus { get; set; }

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
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
