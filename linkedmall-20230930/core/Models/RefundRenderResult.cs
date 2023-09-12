// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class RefundRenderResult : TeaModel {
        [NameInMap("bizClaimType")]
        [Validation(Required=false)]
        public int? BizClaimType { get; set; }

        [NameInMap("mainOrderRefund")]
        [Validation(Required=false)]
        public bool? MainOrderRefund { get; set; }

        [NameInMap("maxRefundFeeData")]
        [Validation(Required=false)]
        public DistributionMaxRefundFee MaxRefundFeeData { get; set; }

        [NameInMap("orderLineId")]
        [Validation(Required=false)]
        public string OrderLineId { get; set; }

        [NameInMap("refundReasonList")]
        [Validation(Required=false)]
        public List<RefundReason> RefundReasonList { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
