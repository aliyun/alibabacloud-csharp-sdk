// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ApproveOrderRequest : TeaModel {
        /// <summary>
        /// If ApprovalType is set to ADD_APPROVAL_NODE, you need to specify this parameter. The ID of the user that is added as the new approval node. This node must be a user-defined approval node. You can call the ListUserDefineWorkFlowNodes operation to obtain the value of this parameter.
        /// </summary>
        [NameInMap("ApprovalNodeId")]
        [Validation(Required=false)]
        public long? ApprovalNodeId { get; set; }

        /// <summary>
        /// If ApprovalType is set to ADD_APPROVAL_NODE, you need to specify this parameter. The position of the new approval node. Valid values:
        /// 
        /// *   **PRE_ADD_APPROVAL_NODE**: before the current approval node.
        /// *   **POST_ADD_APPROVAL_NODE**: after the current approval node.
        /// </summary>
        [NameInMap("ApprovalNodePos")]
        [Validation(Required=false)]
        public string ApprovalNodePos { get; set; }

        /// <summary>
        /// The action that you want to perform on the ticket. Valid values:
        /// 
        /// *   **AGREE**
        /// *   **CANCEL**
        /// *   **REJECT**
        /// *   **TRANSFER**
        /// *   **ADD_APPROVAL_NODE**
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ApprovalType")]
        [Validation(Required=false)]
        public string ApprovalType { get; set; }

        /// <summary>
        /// The description of the ticket.
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// The ID of the user to which the ticket is transferred. If ApprovalType is set to TRANSFER, you need to specify this parameter.
        /// </summary>
        [NameInMap("NewApprover")]
        [Validation(Required=false)]
        public long? NewApprover { get; set; }

        [NameInMap("NewApproverList")]
        [Validation(Required=false)]
        public string NewApproverList { get; set; }

        /// <summary>
        /// The ID of the user that transfers the ticket to another user. The default value is the ID of the current user. If the current user is an administrator or a database administrator (DBA), the user can change the value of this parameter to the ID of another user.
        /// </summary>
        [NameInMap("OldApprover")]
        [Validation(Required=false)]
        public long? OldApprover { get; set; }

        [NameInMap("RealLoginUserUid")]
        [Validation(Required=false)]
        public string RealLoginUserUid { get; set; }

        /// <summary>
        /// The ID of the tenant. You can call the [GetUserActiveTenant](https://help.aliyun.com/document_detail/198073.html) operation to obtain the tenant ID.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

        /// <summary>
        /// The ID of the approval process. You can call the [GetOrderBaseInfo](https://help.aliyun.com/document_detail/144642.html) operation to obtain the ID of the approval process.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("WorkflowInstanceId")]
        [Validation(Required=false)]
        public long? WorkflowInstanceId { get; set; }

    }

}
