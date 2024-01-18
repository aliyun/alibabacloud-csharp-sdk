// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20180116.Models
{
    public class CreateWithholdTradeRequest : TeaModel {
        [NameInMap("AgreementNo")]
        [Validation(Required=false)]
        public string AgreementNo { get; set; }

        [NameInMap("Body")]
        [Validation(Required=false)]
        public string Body { get; set; }

        [NameInMap("BuyerId")]
        [Validation(Required=false)]
        public string BuyerId { get; set; }

        [NameInMap("ExtInfo")]
        [Validation(Required=false)]
        public string ExtInfo { get; set; }

        [NameInMap("GoodsDetail")]
        [Validation(Required=false)]
        public string GoodsDetail { get; set; }

        [NameInMap("MerchantId")]
        [Validation(Required=false)]
        public string MerchantId { get; set; }

        [NameInMap("OutRequestNo")]
        [Validation(Required=false)]
        public string OutRequestNo { get; set; }

        [NameInMap("OutTradeNo")]
        [Validation(Required=false)]
        public string OutTradeNo { get; set; }

        [NameInMap("SettleMode")]
        [Validation(Required=false)]
        public string SettleMode { get; set; }

        [NameInMap("Subject")]
        [Validation(Required=false)]
        public string Subject { get; set; }

        [NameInMap("TotalAmount")]
        [Validation(Required=false)]
        public string TotalAmount { get; set; }

    }

}
