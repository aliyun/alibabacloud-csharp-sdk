// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class RefundOrderCmd : TeaModel {
        [NameInMap("applyReasonTextId")]
        [Validation(Required=false)]
        public long? ApplyReasonTextId { get; set; }

        [NameInMap("applyReasonTips")]
        [Validation(Required=false)]
        public string ApplyReasonTips { get; set; }

        [NameInMap("applyRefundCount")]
        [Validation(Required=false)]
        public int? ApplyRefundCount { get; set; }

        [NameInMap("applyRefundFee")]
        [Validation(Required=false)]
        public long? ApplyRefundFee { get; set; }

        [NameInMap("bizClaimType")]
        [Validation(Required=false)]
        public int? BizClaimType { get; set; }

        [NameInMap("goodsStatus")]
        [Validation(Required=false)]
        public int? GoodsStatus { get; set; }

        [NameInMap("leaveMessage")]
        [Validation(Required=false)]
        public string LeaveMessage { get; set; }

        [NameInMap("leavePictureLists")]
        [Validation(Required=false)]
        public List<LeavePictureList> LeavePictureLists { get; set; }

        [NameInMap("orderLineId")]
        [Validation(Required=false)]
        public string OrderLineId { get; set; }

    }

}
