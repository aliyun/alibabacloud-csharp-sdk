// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class RefundOrderRequest : TeaModel {
        [NameInMap("OutRequestNo")]
        [Validation(Required=false)]
        public string OutRequestNo { get; set; }

        [NameInMap("OutTradeNo")]
        [Validation(Required=false)]
        public string OutTradeNo { get; set; }

        [NameInMap("TradeNo")]
        [Validation(Required=false)]
        public string TradeNo { get; set; }

        [NameInMap("RefundReason")]
        [Validation(Required=false)]
        public string RefundReason { get; set; }

        [NameInMap("RefundAmount")]
        [Validation(Required=false)]
        public string RefundAmount { get; set; }

        [NameInMap("RefundRoyaltyParameters")]
        [Validation(Required=false)]
        public string RefundRoyaltyParameters { get; set; }

        [NameInMap("ExtInfo")]
        [Validation(Required=false)]
        public string ExtInfo { get; set; }

        [NameInMap("MerchantId")]
        [Validation(Required=false)]
        public string MerchantId { get; set; }

    }

}
