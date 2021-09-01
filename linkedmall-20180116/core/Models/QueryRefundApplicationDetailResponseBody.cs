// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QueryRefundApplicationDetailResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RefundApplicationDetail")]
        [Validation(Required=false)]
        public QueryRefundApplicationDetailResponseBodyRefundApplicationDetail RefundApplicationDetail { get; set; }
        public class QueryRefundApplicationDetailResponseBodyRefundApplicationDetail : TeaModel {
            [NameInMap("DisputeType")]
            [Validation(Required=false)]
            public int? DisputeType { get; set; }
            [NameInMap("LmOrderId")]
            [Validation(Required=false)]
            public string LmOrderId { get; set; }
            [NameInMap("RefunderName")]
            [Validation(Required=false)]
            public string RefunderName { get; set; }
            [NameInMap("SellerAgreeMsg")]
            [Validation(Required=false)]
            public string SellerAgreeMsg { get; set; }
            [NameInMap("ReturnGoodLogisticsStatus")]
            [Validation(Required=false)]
            public int? ReturnGoodLogisticsStatus { get; set; }
            [NameInMap("DisputeDesc")]
            [Validation(Required=false)]
            public string DisputeDesc { get; set; }
            [NameInMap("RefunderAddress")]
            [Validation(Required=false)]
            public string RefunderAddress { get; set; }
            [NameInMap("ReturnGoodCount")]
            [Validation(Required=false)]
            public int? ReturnGoodCount { get; set; }
            [NameInMap("DisputeId")]
            [Validation(Required=false)]
            public long? DisputeId { get; set; }
            [NameInMap("DisputeEndTime")]
            [Validation(Required=false)]
            public string DisputeEndTime { get; set; }
            [NameInMap("OrderLogisticsStatus")]
            [Validation(Required=false)]
            public int? OrderLogisticsStatus { get; set; }
            [NameInMap("BizClaimType")]
            [Validation(Required=false)]
            public int? BizClaimType { get; set; }
            [NameInMap("RealRefundFee")]
            [Validation(Required=false)]
            public long? RealRefundFee { get; set; }
            [NameInMap("RefundFee")]
            [Validation(Required=false)]
            public long? RefundFee { get; set; }
            [NameInMap("SellerRefuseAgreementMessage")]
            [Validation(Required=false)]
            public string SellerRefuseAgreementMessage { get; set; }
            [NameInMap("DisputeCreateTime")]
            [Validation(Required=false)]
            public string DisputeCreateTime { get; set; }
            [NameInMap("RefunderTel")]
            [Validation(Required=false)]
            public string RefunderTel { get; set; }
            [NameInMap("SellerRefuseReason")]
            [Validation(Required=false)]
            public string SellerRefuseReason { get; set; }
            [NameInMap("SubLmOrderId")]
            [Validation(Required=false)]
            public string SubLmOrderId { get; set; }
            [NameInMap("ApplyDisputeDesc")]
            [Validation(Required=false)]
            public string ApplyDisputeDesc { get; set; }
            [NameInMap("DisputeStatus")]
            [Validation(Required=false)]
            public int? DisputeStatus { get; set; }
            [NameInMap("RefunderZipCode")]
            [Validation(Required=false)]
            public string RefunderZipCode { get; set; }
            [NameInMap("MaxRefundFeeData")]
            [Validation(Required=false)]
            public QueryRefundApplicationDetailResponseBodyRefundApplicationDetailMaxRefundFeeData MaxRefundFeeData { get; set; }
            public class QueryRefundApplicationDetailResponseBodyRefundApplicationDetailMaxRefundFeeData : TeaModel {
                [NameInMap("MaxRefundFee")]
                [Validation(Required=false)]
                public int? MaxRefundFee { get; set; }

                [NameInMap("MinRefundFee")]
                [Validation(Required=false)]
                public int? MinRefundFee { get; set; }

            }
            [NameInMap("ApplyReasonText")]
            [Validation(Required=false)]
            public QueryRefundApplicationDetailResponseBodyRefundApplicationDetailApplyReasonText ApplyReasonText { get; set; }
            public class QueryRefundApplicationDetailResponseBodyRefundApplicationDetailApplyReasonText : TeaModel {
                [NameInMap("ReasonTips")]
                [Validation(Required=false)]
                public string ReasonTips { get; set; }

                [NameInMap("ReasonTextId")]
                [Validation(Required=false)]
                public long? ReasonTextId { get; set; }

            }
        };

    }

}
