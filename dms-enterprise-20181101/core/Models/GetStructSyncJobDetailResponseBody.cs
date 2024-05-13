// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetStructSyncJobDetailResponseBody : TeaModel {
        /// <summary>
        /// The error code.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The details of the schema synchronization task.
        /// </summary>
        [NameInMap("StructSyncJobDetail")]
        [Validation(Required=false)]
        public GetStructSyncJobDetailResponseBodyStructSyncJobDetail StructSyncJobDetail { get; set; }
        public class GetStructSyncJobDetailResponseBodyStructSyncJobDetail : TeaModel {
            /// <summary>
            /// The ID of the SQL task group.
            /// </summary>
            [NameInMap("DBTaskGroupId")]
            [Validation(Required=false)]
            public long? DBTaskGroupId { get; set; }

            /// <summary>
            /// The number of SQL statements that have been executed.
            /// </summary>
            [NameInMap("ExecuteCount")]
            [Validation(Required=false)]
            public long? ExecuteCount { get; set; }

            /// <summary>
            /// The status of the task. Valid values:
            /// 
            /// *   **NEW**: The task was created.
            /// *   **COMPARING**: The schemas of tables were being compared.
            /// *   **COMPARE_BREAK**: The schema comparison was interrupted.
            /// *   **COMPARE_FINISH**: The comparison was finished.
            /// *   **NOT_SCRIPTS**: The comparison was finished but no executable script was available.
            /// *   **SUBMITED_DBTASK**: The task was submitted.
            /// *   **DBTASK_SUCCESS**: The task was complete.
            /// *   **SUBMITED_WORKFLOW**: The ticket was submitted.
            /// *   **WORKFLOW_SUCCESS**: The ticket was approved.
            /// </summary>
            [NameInMap("JobStatus")]
            [Validation(Required=false)]
            public string JobStatus { get; set; }

            /// <summary>
            /// The description of the task.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// The type of security rule. Valid values:
            /// 
            /// *   **CANNOT_SYNC**: Synchronization cannot be performed.
            /// *   **WITH_APPROVE**: The schema synchronization can be performed after the ticket is approved. You can call the [SubmitStructSyncOrderApproval](https://help.aliyun.com/document_detail/206166.html) operation to submit the ticket for approval.
            /// *   **WITHOUT_APPROVE**: The schema synchronization can be performed without approval.
            /// </summary>
            [NameInMap("SecurityRule")]
            [Validation(Required=false)]
            public string SecurityRule { get; set; }

            /// <summary>
            /// The total number of SQL statements.
            /// </summary>
            [NameInMap("SqlCount")]
            [Validation(Required=false)]
            public long? SqlCount { get; set; }

            /// <summary>
            /// The number of tables that have been analyzed.
            /// </summary>
            [NameInMap("TableAnalyzed")]
            [Validation(Required=false)]
            public long? TableAnalyzed { get; set; }

            /// <summary>
            /// The total number of tables.
            /// </summary>
            [NameInMap("TableCount")]
            [Validation(Required=false)]
            public long? TableCount { get; set; }

        }

        /// <summary>
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
