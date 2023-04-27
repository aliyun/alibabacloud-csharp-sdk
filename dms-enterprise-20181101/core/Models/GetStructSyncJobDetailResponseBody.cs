// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetStructSyncJobDetailResponseBody : TeaModel {
        /// <summary>
        /// The description of the task.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The ID of the ticket.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The status of the task. Valid values:
        /// 
        /// *   **NEW**: The task was created.
        /// *   **COMPARING**: The schemas of tables were being compared.
        /// *   **COMPARE_BREAK**: The schema comparison was interrupted.
        /// *   **COMPARE_FINISH**: The schema comparison was complete.
        /// *   **NOT_SCRIPTS**: The schema comparison was complete. No scripts were available.
        /// *   **SUBMITED_DBTASK**: The task was submitted.
        /// *   **DBTASK_SUCCESS**: The task was complete.
        /// *   **SUBMITED_WORKFLOW**: The ticket was submitted for approval.
        /// *   **WORKFLOW_SUCCESS**: The ticket was approved.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [NameInMap("StructSyncJobDetail")]
        [Validation(Required=false)]
        public GetStructSyncJobDetailResponseBodyStructSyncJobDetail StructSyncJobDetail { get; set; }
        public class GetStructSyncJobDetailResponseBodyStructSyncJobDetail : TeaModel {
            [NameInMap("DBTaskGroupId")]
            [Validation(Required=false)]
            public long? DBTaskGroupId { get; set; }

            [NameInMap("ExecuteCount")]
            [Validation(Required=false)]
            public long? ExecuteCount { get; set; }

            /// <summary>
            /// The number of SQL statements that have been executed.
            /// </summary>
            [NameInMap("JobStatus")]
            [Validation(Required=false)]
            public string JobStatus { get; set; }

            /// <summary>
            /// The details of the schema synchronization task.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("SecurityRule")]
            [Validation(Required=false)]
            public string SecurityRule { get; set; }

            /// <summary>
            /// The number of tables that have been analyzed.
            /// </summary>
            [NameInMap("SqlCount")]
            [Validation(Required=false)]
            public long? SqlCount { get; set; }

            /// <summary>
            /// The type of security rule. Valid values:
            /// 
            /// *   **CANNOT_SYNC**: The schema synchronization is not allowed.
            /// *   **WITH_APPROVE**: The schema synchronization can be performed after the ticket is approved. You can call the [SubmitStructSyncOrderApproval](~~206166~~) operation to submit the ticket for approval.
            /// *   **WITHOUT_APPROVE**: The schema synchronization can be performed without approval.
            /// </summary>
            [NameInMap("TableAnalyzed")]
            [Validation(Required=false)]
            public long? TableAnalyzed { get; set; }

            /// <summary>
            /// The ID of the request.
            /// </summary>
            [NameInMap("TableCount")]
            [Validation(Required=false)]
            public long? TableCount { get; set; }

        }

        /// <summary>
        /// The total number of SQL statements.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
