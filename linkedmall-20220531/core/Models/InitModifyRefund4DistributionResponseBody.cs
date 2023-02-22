// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20220531.Models
{
    public class InitModifyRefund4DistributionResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("LogsId")]
        [Validation(Required=false)]
        public string LogsId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Model")]
        [Validation(Required=false)]
        public InitModifyRefund4DistributionResponseBodyModel Model { get; set; }
        public class InitModifyRefund4DistributionResponseBodyModel : TeaModel {
            [NameInMap("BizClaimType")]
            [Validation(Required=false)]
            public int? BizClaimType { get; set; }

            [NameInMap("MainOrderRefund")]
            [Validation(Required=false)]
            public bool? MainOrderRefund { get; set; }

            [NameInMap("MaxRefundFeeData")]
            [Validation(Required=false)]
            public InitModifyRefund4DistributionResponseBodyModelMaxRefundFeeData MaxRefundFeeData { get; set; }
            public class InitModifyRefund4DistributionResponseBodyModelMaxRefundFeeData : TeaModel {
                [NameInMap("MaxRefundFee")]
                [Validation(Required=false)]
                public long? MaxRefundFee { get; set; }

                [NameInMap("MinRefundFee")]
                [Validation(Required=false)]
                public long? MinRefundFee { get; set; }

            }

            [NameInMap("RefundReasonList")]
            [Validation(Required=false)]
            public List<InitModifyRefund4DistributionResponseBodyModelRefundReasonList> RefundReasonList { get; set; }
            public class InitModifyRefund4DistributionResponseBodyModelRefundReasonList : TeaModel {
                [NameInMap("ProofRequired")]
                [Validation(Required=false)]
                public bool? ProofRequired { get; set; }

                [NameInMap("ReasonTextId")]
                [Validation(Required=false)]
                public string ReasonTextId { get; set; }

                [NameInMap("ReasonTips")]
                [Validation(Required=false)]
                public string ReasonTips { get; set; }

                [NameInMap("RefundDescRequired")]
                [Validation(Required=false)]
                public bool? RefundDescRequired { get; set; }

            }

            [NameInMap("SubDistributionOrderId")]
            [Validation(Required=false)]
            public string SubDistributionOrderId { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// pageSize
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SubCode")]
        [Validation(Required=false)]
        public string SubCode { get; set; }

        [NameInMap("SubMessage")]
        [Validation(Required=false)]
        public string SubMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
