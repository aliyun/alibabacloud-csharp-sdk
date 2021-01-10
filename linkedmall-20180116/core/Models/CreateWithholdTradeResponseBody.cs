// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class CreateWithholdTradeResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("WithholdTradeResponse")]
        [Validation(Required=false)]
        public CreateWithholdTradeResponseBodyWithholdTradeResponse WithholdTradeResponse { get; set; }
        public class CreateWithholdTradeResponseBodyWithholdTradeResponse : TeaModel {
            [NameInMap("PaymentDate")]
            [Validation(Required=false)]
            public string PaymentDate { get; set; }
            [NameInMap("TradeNo")]
            [Validation(Required=false)]
            public string TradeNo { get; set; }
            [NameInMap("OutRequestNo")]
            [Validation(Required=false)]
            public string OutRequestNo { get; set; }
            [NameInMap("OutTradeNo")]
            [Validation(Required=false)]
            public string OutTradeNo { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
