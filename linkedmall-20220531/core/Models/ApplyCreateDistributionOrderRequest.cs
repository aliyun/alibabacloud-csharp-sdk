/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20220531.Models
{
    public class ApplyCreateDistributionOrderRequest : TeaModel {
        [NameInMap("BuyerId")]
        [Validation(Required=false)]
        public string BuyerId { get; set; }

        [NameInMap("DeliveryAddress")]
        [Validation(Required=false)]
        public string DeliveryAddress { get; set; }

        [NameInMap("DistributionOutTradeId")]
        [Validation(Required=false)]
        public string DistributionOutTradeId { get; set; }

        [NameInMap("DistributionSupplierId")]
        [Validation(Required=false)]
        public string DistributionSupplierId { get; set; }

        [NameInMap("DistributorId")]
        [Validation(Required=false)]
        public string DistributorId { get; set; }

        [NameInMap("ExtInfo")]
        [Validation(Required=false)]
        public string ExtInfo { get; set; }

        [NameInMap("ItemInfoLists")]
        [Validation(Required=false)]
        public List<ApplyCreateDistributionOrderRequestItemInfoLists> ItemInfoLists { get; set; }
        public class ApplyCreateDistributionOrderRequestItemInfoLists : TeaModel {
            [NameInMap("DistributionMallId")]
            [Validation(Required=false)]
            public string DistributionMallId { get; set; }

            [NameInMap("LmItemId")]
            [Validation(Required=false)]
            public string LmItemId { get; set; }

            [NameInMap("Price")]
            [Validation(Required=false)]
            public long? Price { get; set; }

            [NameInMap("Quantity")]
            [Validation(Required=false)]
            public int? Quantity { get; set; }

            /// <summary>
            /// SKU
            /// </summary>
            [NameInMap("SkuId")]
            [Validation(Required=false)]
            public string SkuId { get; set; }

        }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
