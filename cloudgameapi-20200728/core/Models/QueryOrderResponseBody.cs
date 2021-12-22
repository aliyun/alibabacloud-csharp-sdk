// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudGameAPI20200728.Models
{
    public class QueryOrderResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryOrderResponseBodyData Data { get; set; }
        public class QueryOrderResponseBodyData : TeaModel {
            [NameInMap("AccountDomain")]
            [Validation(Required=false)]
            public string AccountDomain { get; set; }
            [NameInMap("Amount")]
            [Validation(Required=false)]
            public long? Amount { get; set; }
            [NameInMap("ApplyDeliveryTime")]
            [Validation(Required=false)]
            public long? ApplyDeliveryTime { get; set; }
            [NameInMap("AutoUnlockTime")]
            [Validation(Required=false)]
            public long? AutoUnlockTime { get; set; }
            [NameInMap("BuyerAccountId")]
            [Validation(Required=false)]
            public string BuyerAccountId { get; set; }
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }
            [NameInMap("FinishTime")]
            [Validation(Required=false)]
            public long? FinishTime { get; set; }
            [NameInMap("ItemId")]
            [Validation(Required=false)]
            public string ItemId { get; set; }
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public string OrderId { get; set; }
            [NameInMap("OriginPrice")]
            [Validation(Required=false)]
            public long? OriginPrice { get; set; }
            [NameInMap("SettlementPrice")]
            [Validation(Required=false)]
            public long? SettlementPrice { get; set; }
            [NameInMap("SkuId")]
            [Validation(Required=false)]
            public string SkuId { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
        };

        [NameInMap("DeliveryStatus")]
        [Validation(Required=false)]
        public string DeliveryStatus { get; set; }

        [NameInMap("RefundStatus")]
        [Validation(Required=false)]
        public string RefundStatus { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
