// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudGameAPI20200728.Models
{
    public class CreateOrderRequest : TeaModel {
        [NameInMap("AccountDomain")]
        [Validation(Required=false)]
        public string AccountDomain { get; set; }

        [NameInMap("Amount")]
        [Validation(Required=false)]
        public long? Amount { get; set; }

        [NameInMap("BuyerAccountId")]
        [Validation(Required=false)]
        public string BuyerAccountId { get; set; }

        [NameInMap("IdempotentCode")]
        [Validation(Required=false)]
        public string IdempotentCode { get; set; }

        [NameInMap("ItemId")]
        [Validation(Required=false)]
        public string ItemId { get; set; }

        [NameInMap("OriginPrice")]
        [Validation(Required=false)]
        public long? OriginPrice { get; set; }

        [NameInMap("SettlementPrice")]
        [Validation(Required=false)]
        public long? SettlementPrice { get; set; }

        [NameInMap("SkuId")]
        [Validation(Required=false)]
        public string SkuId { get; set; }

    }

}
