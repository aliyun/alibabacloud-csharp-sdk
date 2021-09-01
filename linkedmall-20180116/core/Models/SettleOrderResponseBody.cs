// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class SettleOrderResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TradeOrderSettleResponse")]
        [Validation(Required=false)]
        public SettleOrderResponseBodyTradeOrderSettleResponse TradeOrderSettleResponse { get; set; }
        public class SettleOrderResponseBodyTradeOrderSettleResponse : TeaModel {
            [NameInMap("TradeNo")]
            [Validation(Required=false)]
            public string TradeNo { get; set; }
            [NameInMap("OutRequestNo")]
            [Validation(Required=false)]
            public string OutRequestNo { get; set; }
        };

    }

}
