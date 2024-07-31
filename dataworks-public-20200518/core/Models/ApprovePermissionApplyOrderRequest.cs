// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ApprovePermissionApplyOrderRequest : TeaModel {
        /// <summary>
        /// The action for the permission request order. Valid values:
        /// 
        /// *   1: approve
        /// *   2: reject
        /// 
        /// <!---->
        /// 
        /// *   0
        /// *   1
        /// *   2\\.
        /// *   3\\.
        /// *   4
        /// *   5
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ApproveAction")]
        [Validation(Required=false)]
        public int? ApproveAction { get; set; }

        /// <summary>
        /// The comment on the order.
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
