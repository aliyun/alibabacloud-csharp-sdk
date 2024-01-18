// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class InitModifyRefundResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("InitApplyRefundData")]
        [Validation(Required=false)]
        public InitModifyRefundResponseBodyInitApplyRefundData InitApplyRefundData { get; set; }
        public class InitModifyRefundResponseBodyInitApplyRefundData : TeaModel {
            [NameInMap("BizClaimType")]
            [Validation(Required=false)]
            public int? BizClaimType { get; set; }

            [NameInMap("MainOrderRefund")]
            [Validation(Required=false)]
            public bool? MainOrderRefund { get; set; }

            [NameInMap("MaxRefundFeeData")]
            [Validation(Required=false)]
            public InitModifyRefundResponseBodyInitApplyRefundDataMaxRefundFeeData MaxRefundFeeData { get; set; }
            public class InitModifyRefundResponseBodyInitApplyRefundDataMaxRefundFeeData : TeaModel {
                [NameInMap("MaxRefundFee")]
                [Validation(Required=false)]
                public int? MaxRefundFee { get; set; }

                [NameInMap("MinRefundFee")]
                [Validation(Required=false)]
                public int? MinRefundFee { get; set; }

            }

            [NameInMap("RefundReasonList")]
            [Validation(Required=false)]
            public InitModifyRefundResponseBodyInitApplyRefundDataRefundReasonList RefundReasonList { get; set; }
            public class InitModifyRefundResponseBodyInitApplyRefundDataRefundReasonList : TeaModel {
                [NameInMap("RefundReasonList")]
                [Validation(Required=false)]
                public List<InitModifyRefundResponseBodyInitApplyRefundDataRefundReasonListRefundReasonList> RefundReasonList { get; set; }
                public class InitModifyRefundResponseBodyInitApplyRefundDataRefundReasonListRefundReasonList : TeaModel {
                    [NameInMap("ProofRequired")]
                    [Validation(Required=false)]
                    public bool? ProofRequired { get; set; }

                    [NameInMap("ReasonTextId")]
                    [Validation(Required=false)]
                    public long? ReasonTextId { get; set; }

                    [NameInMap("ReasonTips")]
                    [Validation(Required=false)]
                    public string ReasonTips { get; set; }

                    [NameInMap("RefundDescRequired")]
                    [Validation(Required=false)]
                    public bool? RefundDescRequired { get; set; }

                }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SubLmOrderId")]
        [Validation(Required=false)]
        public string SubLmOrderId { get; set; }

    }

}
