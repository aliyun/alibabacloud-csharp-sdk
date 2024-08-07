// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class GetPermissionApplyOrderDetailRequest : TeaModel {
        /// <summary>
        /// The ID of the permission request order. You can call the [ListPermissionApplyOrders](https://help.aliyun.com/document_detail/211008.html) operation to obtain the ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("FlowId")]
        [Validation(Required=false)]
        public string FlowId { get; set; }

    }

}
