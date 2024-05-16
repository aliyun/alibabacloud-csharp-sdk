// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ApprovePermissionApplyOrderRequest : TeaModel {
        /// <summary>
        /// The approval action. Valid values:
        /// 
        /// *   1: Approve the permission request order.
        /// *   2: Reject the permission request order.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ApproveAction")]
        [Validation(Required=false)]
        public int? ApproveAction { get; set; }

        /// <summary>
        /// The comment on the approval.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ApproveComment")]
        [Validation(Required=false)]
        public string ApproveComment { get; set; }

        /// <summary>
        /// The ID of the permission request order. You can call the ListPermissionApplyOrders operation to obtain the order ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FlowId")]
        [Validation(Required=false)]
        public string FlowId { get; set; }

    }

}
