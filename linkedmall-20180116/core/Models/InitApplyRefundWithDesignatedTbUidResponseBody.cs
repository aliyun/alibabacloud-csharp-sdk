// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class InitApplyRefundWithDesignatedTbUidResponseBody : TeaModel {
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
        public InitApplyRefundWithDesignatedTbUidResponseBodyModel Model { get; set; }
        public class InitApplyRefundWithDesignatedTbUidResponseBodyModel : TeaModel {
            [NameInMap("BizClaimType")]
            [Validation(Required=false)]
            public int? BizClaimType { get; set; }

            [NameInMap("LmOrderId")]
            [Validation(Required=false)]
            public string LmOrderId { get; set; }

            [NameInMap("MainOrderRefund")]
            [Validation(Required=false)]
            public bool? MainOrderRefund { get; set; }

            [NameInMap("MaxRefundFeeData")]
            [Validation(Required=false)]
            public InitApplyRefundWithDesignatedTbUidResponseBodyModelMaxRefundFeeData MaxRefundFeeData { get; set; }
            public class InitApplyRefundWithDesignatedTbUidResponseBodyModelMaxRefundFeeData : TeaModel {
                [NameInMap("MaxRefundFee")]
                [Validation(Required=false)]
                public long? MaxRefundFee { get; set; }

                [NameInMap("MinRefundFee")]
                [Validation(Required=false)]
                public long? MinRefundFee { get; set; }

            }

            [NameInMap("RefundReasonList")]
            [Validation(Required=false)]
            public List<InitApplyRefundWithDesignatedTbUidResponseBodyModelRefundReasonList> RefundReasonList { get; set; }
            public class InitApplyRefundWithDesignatedTbUidResponseBodyModelRefundReasonList : TeaModel {
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
