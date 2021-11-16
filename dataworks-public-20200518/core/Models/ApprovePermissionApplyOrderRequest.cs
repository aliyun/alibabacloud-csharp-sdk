// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ApprovePermissionApplyOrderRequest : TeaModel {
        [NameInMap("ApproveAction")]
        [Validation(Required=false)]
        public int? ApproveAction { get; set; }

        [NameInMap("ApproveComment")]
        [Validation(Required=false)]
        public string ApproveComment { get; set; }

        [NameInMap("FlowId")]
        [Validation(Required=false)]
        public string FlowId { get; set; }

    }

}
