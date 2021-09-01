// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QueryWithholdTradeResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("QueryWithholdTradeResponse")]
        [Validation(Required=false)]
        public QueryWithholdTradeResponseBodyQueryWithholdTradeResponse QueryWithholdTradeResponse { get; set; }
        public class QueryWithholdTradeResponseBodyQueryWithholdTradeResponse : TeaModel {
            [NameInMap("SettleStatus")]
            [Validation(Required=false)]
            public string SettleStatus { get; set; }
            [NameInMap("TradeStatus")]
            [Validation(Required=false)]
            public string TradeStatus { get; set; }
            [NameInMap("TotalAmount")]
            [Validation(Required=false)]
            public string TotalAmount { get; set; }
            [NameInMap("TradeNo")]
            [Validation(Required=false)]
            public string TradeNo { get; set; }
            [NameInMap("PaymentDate")]
            [Validation(Required=false)]
            public string PaymentDate { get; set; }
            [NameInMap("OutTradeNo")]
            [Validation(Required=false)]
            public string OutTradeNo { get; set; }
        };

    }

}
