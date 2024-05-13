// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListDDLPublishRecordsResponseBody : TeaModel {
        /// <summary>
        /// The details of the publishing records.
        /// </summary>
        [NameInMap("DDLPublishRecordList")]
        [Validation(Required=false)]
        public List<ListDDLPublishRecordsResponseBodyDDLPublishRecordList> DDLPublishRecordList { get; set; }
        public class ListDDLPublishRecordsResponseBodyDDLPublishRecordList : TeaModel {
            /// <summary>
            /// The time when the approval expires.
            /// </summary>
            [NameInMap("AuditExpireTime")]
            [Validation(Required=false)]
            public string AuditExpireTime { get; set; }

            /// <summary>
            /// The approval state of the ticket. Valid values:
            /// 
            /// *   **EXEMPT_PASS**: The ticket passes without approval.
            /// *   **TO_AUDIT**: The ticket is pending for approval.
            /// *   **CANCEL**: The ticket is canceled.
            /// *   **SUCCESS**: The ticket is approved.
            /// *   **FAIL**: The ticket fails to pass the approval.
            /// </summary>
            [NameInMap("AuditStatus")]
            [Validation(Required=false)]
            public string AuditStatus { get; set; }

            /// <summary>
            /// Release remarks.
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// The ID of the user who creates the ticket. You can obtain the user ID by calling the [GetUser](https://help.aliyun.com/document_detail/147098.html) operation and querying the value of the UserId parameter. The value is not the unique ID (UID) of the Alibaba Cloud account.
            /// </summary>
            [NameInMap("CreatorId")]
            [Validation(Required=false)]
            public long? CreatorId { get; set; }

            /// <summary>
            /// Indicates whether the approval is terminated. Valid values:
            /// 
            /// *   **true**: The approval is terminated.
            /// *   **false**: The approval is not terminated.
            /// 
            /// > Multiple reasons can terminate the approval. For example, you withdraw the application or your ticket is not approved before the specified time.
            /// </summary>
            [NameInMap("Finality")]
            [Validation(Required=false)]
            public bool? Finality { get; set; }

            /// <summary>
            /// The reason for the termination.
            /// </summary>
            [NameInMap("FinalityReason")]
            [Validation(Required=false)]
            public string FinalityReason { get; set; }

            /// <summary>
            /// The publishing state of the ticket. Valid values:
            /// 
            /// *   **START**: The ticket is created.
            /// *   **ANALYZE**: The ticket is under analysis.
            /// *   **AUDIT**: The ticket is under approval.
            /// *   **DISPATCH**: A task is generated for the ticket.
            /// *   **SUCCESS**: The task is successful.
            /// </summary>
            [NameInMap("PublishStatus")]
            [Validation(Required=false)]
            public string PublishStatus { get; set; }

            /// <summary>
            /// The list of publishing tasks.
            /// </summary>
            [NameInMap("PublishTaskInfoList")]
            [Validation(Required=false)]
            public List<ListDDLPublishRecordsResponseBodyDDLPublishRecordListPublishTaskInfoList> PublishTaskInfoList { get; set; }
            public class ListDDLPublishRecordsResponseBodyDDLPublishRecordListPublishTaskInfoList : TeaModel {
                /// <summary>
                /// The ID of the database.
                /// </summary>
                [NameInMap("DbId")]
                [Validation(Required=false)]
                public long? DbId { get; set; }

                /// <summary>
                /// Indicates whether the database is a logical database. Valid values:
                /// 
                /// *   **true**: The database is a logical database.
                /// *   **false**: the database is not a logical database.
                /// </summary>
                [NameInMap("Logic")]
                [Validation(Required=false)]
                public bool? Logic { get; set; }

                /// <summary>
                /// The time to publish the ticket.
                /// </summary>
                [NameInMap("PlanTime")]
                [Validation(Required=false)]
                public string PlanTime { get; set; }

                /// <summary>
                /// The list of the publishing tasks.
                /// </summary>
                [NameInMap("PublishJobList")]
                [Validation(Required=false)]
                public List<ListDDLPublishRecordsResponseBodyDDLPublishRecordListPublishTaskInfoListPublishJobList> PublishJobList { get; set; }
                public class ListDDLPublishRecordsResponseBodyDDLPublishRecordListPublishTaskInfoListPublishJobList : TeaModel {
                    /// <summary>
                    /// The ID of the SQL task group.
                    /// </summary>
                    [NameInMap("DBTaskGroupId")]
                    [Validation(Required=false)]
                    public long? DBTaskGroupId { get; set; }

                    /// <summary>
                    /// The number of SQL statements that are executed.
                    /// </summary>
                    [NameInMap("ExecuteCount")]
                    [Validation(Required=false)]
                    public long? ExecuteCount { get; set; }

                    /// <summary>
                    /// The script for data changes.
                    /// </summary>
                    [NameInMap("Scripts")]
                    [Validation(Required=false)]
                    public string Scripts { get; set; }

                    /// <summary>
                    /// The description of the state.
                    /// </summary>
                    [NameInMap("StatusDesc")]
                    [Validation(Required=false)]
                    public string StatusDesc { get; set; }

                    /// <summary>
                    /// The name of the table after the change.
                    /// </summary>
                    [NameInMap("TableName")]
                    [Validation(Required=false)]
                    public string TableName { get; set; }

                    /// <summary>
                    /// The state of the publishing task. Valid values:
                    /// 
                    /// *   **NONE**: The state of the task is unknown.
                    /// *   **SUCCESS**: The task is successful.
                    /// *   **FAIL**: The task fails.
                    /// </summary>
                    [NameInMap("TaskJobStatus")]
                    [Validation(Required=false)]
                    public string TaskJobStatus { get; set; }

                }

                /// <summary>
                /// The publishing policy. Valid values:
                /// 
                /// *   **IMMEDIATELY**: immediately publishes the ticket.
                /// *   **REGULARLY**: publishes the ticket at a scheduled time.
                /// </summary>
                [NameInMap("PublishStrategy")]
                [Validation(Required=false)]
                public string PublishStrategy { get; set; }

                /// <summary>
                /// The description of the state.
                /// </summary>
                [NameInMap("StatusDesc")]
                [Validation(Required=false)]
                public string StatusDesc { get; set; }

                /// <summary>
                /// The state of the task.
                /// </summary>
                [NameInMap("TaskJobStatus")]
                [Validation(Required=false)]
                public string TaskJobStatus { get; set; }

            }

            /// <summary>
            /// The risk level of the operation. Valid values:
            /// 
            /// *   **NONE_RISK**: The operation does not have risks.
            /// *   **LOW_RISK**: The operation is at low risk.
            /// *   **MIDDLE_RISK**: The operation is at medium risk.
            /// *   **HIGH_RISK**: The operation is at high risk.
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            /// <summary>
            /// The description of the publishing state.
            /// </summary>
            [NameInMap("StatusDesc")]
            [Validation(Required=false)]
            public string StatusDesc { get; set; }

            /// <summary>
            /// The ID of the approval process.
            /// </summary>
            [NameInMap("WorkflowInstanceId")]
            [Validation(Required=false)]
            public long? WorkflowInstanceId { get; set; }

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

    }

}
