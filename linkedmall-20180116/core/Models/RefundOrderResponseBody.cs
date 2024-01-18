// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class RefundOrderResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RefundResponse")]
        [Validation(Required=false)]
        public RefundOrderResponseBodyRefundResponse RefundResponse { get; set; }
        public class RefundOrderResponseBodyRefundResponse : TeaModel {
            [NameInMap("FundChange")]
            [Validation(Required=false)]
            public string FundChange { get; set; }

            [NameInMap("GmtRefundPay")]
            [Validation(Required=false)]
            public string GmtRefundPay { get; set; }

            [NameInMap("OutRequestNo")]
            [Validation(Required=false)]
            public string OutRequestNo { get; set; }

            [NameInMap("OutTradeNo")]
            [Validation(Required=false)]
            public string OutTradeNo { get; set; }

            [NameInMap("TradeNo")]
            [Validation(Required=false)]
            public string TradeNo { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
