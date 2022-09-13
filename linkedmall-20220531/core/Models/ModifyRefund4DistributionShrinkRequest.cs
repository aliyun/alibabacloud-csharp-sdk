// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20220531.Models
{
    public class ModifyRefund4DistributionShrinkRequest : TeaModel {
        [NameInMap("ApplyReasonTextId")]
        [Validation(Required=false)]
        public long? ApplyReasonTextId { get; set; }

        [NameInMap("ApplyRefundCount")]
        [Validation(Required=false)]
        public int? ApplyRefundCount { get; set; }

        [NameInMap("ApplyRefundFee")]
        [Validation(Required=false)]
        public long? ApplyRefundFee { get; set; }

        [NameInMap("BizClaimType")]
        [Validation(Required=false)]
        public int? BizClaimType { get; set; }

        [NameInMap("DisputeId")]
        [Validation(Required=false)]
        public long? DisputeId { get; set; }

        [NameInMap("DistributorId")]
        [Validation(Required=false)]
        public string DistributorId { get; set; }

        [NameInMap("GoodsStatus")]
        [Validation(Required=false)]
        public int? GoodsStatus { get; set; }

        [NameInMap("LeaveMessage")]
        [Validation(Required=false)]
        public string LeaveMessage { get; set; }

        [NameInMap("LeavePictureLists")]
        [Validation(Required=false)]
        public string LeavePictureListsShrink { get; set; }

        [NameInMap("SubDistributionOrderId")]
        [Validation(Required=false)]
        public string SubDistributionOrderId { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
