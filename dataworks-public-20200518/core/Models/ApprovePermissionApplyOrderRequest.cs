// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ApprovePermissionApplyOrderRequest : TeaModel {
        [NameInMap("FlowId")]
        [Validation(Required=true)]
        public string FlowId { get; set; }

        [NameInMap("ApproveComment")]
        [Validation(Required=true)]
        public string ApproveComment { get; set; }

        [NameInMap("ApproveAction")]
        [Validation(Required=true)]
        public int? ApproveAction { get; set; }

    }

}
