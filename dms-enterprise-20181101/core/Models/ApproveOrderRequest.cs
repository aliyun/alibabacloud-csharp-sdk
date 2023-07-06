// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ApproveOrderRequest : TeaModel {
        [NameInMap("ApprovalNodeId")]
        [Validation(Required=false)]
        public long? ApprovalNodeId { get; set; }

        [NameInMap("ApprovalNodePos")]
        [Validation(Required=false)]
        public string ApprovalNodePos { get; set; }

        /// <summary>
        /// The action that you want to perform on the ticket. Valid values:
        /// 
        /// *   AGREE: approve
        /// *   CANCEL: cancel
        /// *   REJECT: reject
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

        [NameInMap("NewApprover")]
        [Validation(Required=false)]
        public long? NewApprover { get; set; }

        [NameInMap("OldApprover")]
        [Validation(Required=false)]
        public long? OldApprover { get; set; }

        /// <summary>
        /// The ID of the tenant. You can call the [GetUserActiveTenant](~~198073~~) operation to obtain the tenant ID.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

        /// <summary>
        /// The ID of the approval process. You can call the [GetOrderBaseInfo](~~144642~~) operation to obtain the ID of the approval process.
        /// </summary>
        [NameInMap("WorkflowInstanceId")]
        [Validation(Required=false)]
        public long? WorkflowInstanceId { get; set; }

    }

}
