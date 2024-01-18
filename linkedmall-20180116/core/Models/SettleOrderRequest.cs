// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class SettleOrderRequest : TeaModel {
        [NameInMap("ExtInfo")]
        [Validation(Required=false)]
        public string ExtInfo { get; set; }

        [NameInMap("MerchantId")]
        [Validation(Required=false)]
        public string MerchantId { get; set; }

        [NameInMap("OutRequestNo")]
        [Validation(Required=false)]
        public string OutRequestNo { get; set; }

        [NameInMap("OutTradeNo")]
        [Validation(Required=false)]
        public string OutTradeNo { get; set; }

        [NameInMap("RoyaltyParameters")]
        [Validation(Required=false)]
        public string RoyaltyParameters { get; set; }

        [NameInMap("TradeNo")]
        [Validation(Required=false)]
        public string TradeNo { get; set; }

    }

}
