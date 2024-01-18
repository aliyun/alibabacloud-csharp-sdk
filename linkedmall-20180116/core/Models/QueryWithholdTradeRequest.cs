// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class QueryWithholdTradeRequest : TeaModel {
        [NameInMap("MerchantId")]
        [Validation(Required=false)]
        public string MerchantId { get; set; }

        [NameInMap("OutTradeNo")]
        [Validation(Required=false)]
        public string OutTradeNo { get; set; }

        [NameInMap("TradeNo")]
        [Validation(Required=false)]
        public string TradeNo { get; set; }

    }

}
