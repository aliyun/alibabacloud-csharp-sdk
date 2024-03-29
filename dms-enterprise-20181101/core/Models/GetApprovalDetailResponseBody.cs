// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetApprovalDetailResponseBody : TeaModel {
        /// <summary>
        /// The approval details of the ticket.
        /// </summary>
        [NameInMap("ApprovalDetail")]
        [Validation(Required=false)]
        public GetApprovalDetailResponseBodyApprovalDetail ApprovalDetail { get; set; }
        public class GetApprovalDetailResponseBodyApprovalDetail : TeaModel {
            /// <summary>
            /// The ID of the approval process.
            /// </summary>
            [NameInMap("AuditId")]
            [Validation(Required=false)]
            public long? AuditId { get; set; }

            /// <summary>
            /// The time when the approval process was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The information about the approver.
            /// </summary>
            [NameInMap("CurrentHandlers")]
            [Validation(Required=false)]
            public GetApprovalDetailResponseBodyApprovalDetailCurrentHandlers CurrentHandlers { get; set; }
            public class GetApprovalDetailResponseBodyApprovalDetailCurrentHandlers : TeaModel {
                [NameInMap("CurrentHandler")]
                [Validation(Required=false)]
                public List<GetApprovalDetailResponseBodyApprovalDetailCurrentHandlersCurrentHandler> CurrentHandler { get; set; }
                public class GetApprovalDetailResponseBodyApprovalDetailCurrentHandlersCurrentHandler : TeaModel {
                    /// <summary>
                    /// The ID of the user.
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// The nickname of the user.
                    /// </summary>
                    [NameInMap("NickName")]
                    [Validation(Required=false)]
                    public string NickName { get; set; }

                }

            }

            /// <summary>
            /// The description of the approval process.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The ID of the ticket.
            /// </summary>
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public long? OrderId { get; set; }

            /// <summary>
            /// The type of the ticket. Valid values:
            /// 
            /// *   **NDDL**: a schema design ticket
            /// *   **DATA_TRACK**: a data tracking ticket
            /// *   **TABLE_SYNC**: a table synchronization ticket
            /// *   **PERM_APPLY**: a permission application ticket
            /// *   **DATA_EXPORT**: a data export ticket
            /// *   **DATA_CORRECT**: a data change ticket
            /// *   **OWNER_APPLY**: an owner role application ticket
            /// *   **SENSITIVITY**: a column sensitivity level change ticket
            /// </summary>
            [NameInMap("OrderType")]
            [Validation(Required=false)]
            public string OrderType { get; set; }

            /// <summary>
            /// The reasons for the approval.
            /// </summary>
            [NameInMap("ReasonList")]
            [Validation(Required=false)]
            public GetApprovalDetailResponseBodyApprovalDetailReasonList ReasonList { get; set; }
            public class GetApprovalDetailResponseBodyApprovalDetailReasonList : TeaModel {
                [NameInMap("Reasons")]
                [Validation(Required=false)]
                public List<string> Reasons { get; set; }

            }

            /// <summary>
            /// The ID of the workflow template.
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public long? TemplateId { get; set; }

            /// <summary>
            /// The title of the approval process.
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// The approval status of the ticket. Valid values:
            /// 
            /// *   **AUDITING**: The ticket is being reviewed.
            /// *   **REJECT**: The ticket was rejected.
            /// *   **CANCEL**: The ticket was revoked.
            /// *   **APPROVED**: The ticket was approved.
            /// 
            /// > An approval process contains multiple approval nodes, and this parameter is returned for each approval node.
            /// </summary>
            [NameInMap("WorkflowInsCode")]
            [Validation(Required=false)]
            public string WorkflowInsCode { get; set; }

            /// <summary>
            /// The details of approval nodes.
            /// </summary>
            [NameInMap("WorkflowNodes")]
            [Validation(Required=false)]
            public GetApprovalDetailResponseBodyApprovalDetailWorkflowNodes WorkflowNodes { get; set; }
            public class GetApprovalDetailResponseBodyApprovalDetailWorkflowNodes : TeaModel {
                [NameInMap("WorkflowNode")]
                [Validation(Required=false)]
                public List<GetApprovalDetailResponseBodyApprovalDetailWorkflowNodesWorkflowNode> WorkflowNode { get; set; }
                public class GetApprovalDetailResponseBodyApprovalDetailWorkflowNodesWorkflowNode : TeaModel {
                    /// <summary>
                    /// The IDs of the approvers.
                    /// </summary>
                    [NameInMap("AuditUserIdList")]
                    [Validation(Required=false)]
                    public GetApprovalDetailResponseBodyApprovalDetailWorkflowNodesWorkflowNodeAuditUserIdList AuditUserIdList { get; set; }
                    public class GetApprovalDetailResponseBodyApprovalDetailWorkflowNodesWorkflowNodeAuditUserIdList : TeaModel {
                        [NameInMap("AuditUserIds")]
                        [Validation(Required=false)]
                        public List<string> AuditUserIds { get; set; }

                    }

                    /// <summary>
                    /// The name of the approval node.
                    /// </summary>
                    [NameInMap("NodeName")]
                    [Validation(Required=false)]
                    public string NodeName { get; set; }

                    /// <summary>
                    /// The remarks of the approval.
                    /// </summary>
                    [NameInMap("OperateComment")]
                    [Validation(Required=false)]
                    public string OperateComment { get; set; }

                    /// <summary>
                    /// The time when the ticket was submitted.
                    /// </summary>
                    [NameInMap("OperateTime")]
                    [Validation(Required=false)]
                    public string OperateTime { get; set; }

                    /// <summary>
                    /// The ID of the user who submitted the ticket.
                    /// </summary>
                    [NameInMap("OperatorId")]
                    [Validation(Required=false)]
                    public long? OperatorId { get; set; }

                    /// <summary>
                    /// The approval status of the ticket. Valid values:
                    /// 
                    /// *   **START**: The ticket was submitted.
                    /// *   **ERROR**: An error occurred.
                    /// *   **AUDITING**: The ticket is being reviewed.
                    /// *   **REJECT**: The ticket was rejected.
                    /// *   **CANCEL**: The ticket was revoked.
                    /// *   **APPROVED**: The ticket was approved.
                    /// </summary>
                    [NameInMap("WorkflowInsCode")]
                    [Validation(Required=false)]
                    public string WorkflowInsCode { get; set; }

                }

            }

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
        /// Indicates whether the request is successful. Valid values:
        /// 
        /// *   **true**: The request is successful.
        /// *   **false**: The request fails.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
