// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class ApplyRefundWithDesignatedTbUidShrinkRequest : TeaModel {
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("DisputeId")]
        [Validation(Required=false)]
        public long? DisputeId { get; set; }

        [NameInMap("GoodsStatus")]
        [Validation(Required=false)]
        public int? GoodsStatus { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Proofs")]
        [Validation(Required=false)]
        public string ProofsShrink { get; set; }

        [NameInMap("ReasonId")]
        [Validation(Required=false)]
        public long? ReasonId { get; set; }

        [NameInMap("RefundCode")]
        [Validation(Required=false)]
        public int? RefundCode { get; set; }

        [NameInMap("RefundCount")]
        [Validation(Required=false)]
        public int? RefundCount { get; set; }

        [NameInMap("RefundFee")]
        [Validation(Required=false)]
        public long? RefundFee { get; set; }

        [NameInMap("SubLmOrderId")]
        [Validation(Required=false)]
        public string SubLmOrderId { get; set; }

        [NameInMap("TbAccountType")]
        [Validation(Required=false)]
        public string TbAccountType { get; set; }

        [NameInMap("TbUserId")]
        [Validation(Required=false)]
        public long? TbUserId { get; set; }

        [NameInMap("ThirdPartyUserId")]
        [Validation(Required=false)]
        public string ThirdPartyUserId { get; set; }

    }

}
