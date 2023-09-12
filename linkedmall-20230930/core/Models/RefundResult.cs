// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class RefundResult : TeaModel {
        [NameInMap("applyDisputeDesc")]
        [Validation(Required=false)]
        public string ApplyDisputeDesc { get; set; }

        [NameInMap("applyReason")]
        [Validation(Required=false)]
        public ApplyReason ApplyReason { get; set; }

        [NameInMap("bizClaimType")]
        [Validation(Required=false)]
        public int? BizClaimType { get; set; }

        [NameInMap("disputeCreateTime")]
        [Validation(Required=false)]
        public string DisputeCreateTime { get; set; }

        [NameInMap("disputeDesc")]
        [Validation(Required=false)]
        public string DisputeDesc { get; set; }

        [NameInMap("disputeEndTime")]
        [Validation(Required=false)]
        public string DisputeEndTime { get; set; }

        [NameInMap("disputeId")]
        [Validation(Required=false)]
        public string DisputeId { get; set; }

        [NameInMap("disputeStatus")]
        [Validation(Required=false)]
        public int? DisputeStatus { get; set; }

        [NameInMap("disputeType")]
        [Validation(Required=false)]
        public int? DisputeType { get; set; }

        [NameInMap("orderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        [NameInMap("orderLineId")]
        [Validation(Required=false)]
        public string OrderLineId { get; set; }

        [NameInMap("orderLogisticsStatus")]
        [Validation(Required=false)]
        public int? OrderLogisticsStatus { get; set; }

        [NameInMap("refundFee")]
        [Validation(Required=false)]
        public long? RefundFee { get; set; }

        [NameInMap("refundFeeData")]
        [Validation(Required=false)]
        public RefundFeeData RefundFeeData { get; set; }

        [NameInMap("refunderAddress")]
        [Validation(Required=false)]
        public string RefunderAddress { get; set; }

        [NameInMap("refunderName")]
        [Validation(Required=false)]
        public string RefunderName { get; set; }

        [NameInMap("refunderTel")]
        [Validation(Required=false)]
        public string RefunderTel { get; set; }

        [NameInMap("refunderZipCode")]
        [Validation(Required=false)]
        public string RefunderZipCode { get; set; }

        [NameInMap("returnGoodLogisticsStatus")]
        [Validation(Required=false)]
        public int? ReturnGoodLogisticsStatus { get; set; }

        [NameInMap("sellerAgreeMsg")]
        [Validation(Required=false)]
        public string SellerAgreeMsg { get; set; }

        [NameInMap("sellerRefuseAgreementMessage")]
        [Validation(Required=false)]
        public string SellerRefuseAgreementMessage { get; set; }

        [NameInMap("sellerRefuseReason")]
        [Validation(Required=false)]
        public string SellerRefuseReason { get; set; }

    }

}
