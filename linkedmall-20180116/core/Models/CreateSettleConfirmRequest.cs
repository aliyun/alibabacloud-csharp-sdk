// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class CreateSettleConfirmRequest : TeaModel {
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

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

        [NameInMap("SettleInfo")]
        [Validation(Required=false)]
        public string SettleInfo { get; set; }

        [NameInMap("TradeNo")]
        [Validation(Required=false)]
        public string TradeNo { get; set; }

    }

}
