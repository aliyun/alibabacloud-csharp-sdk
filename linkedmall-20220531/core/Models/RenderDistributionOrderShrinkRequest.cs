// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20220531.Models
{
    public class RenderDistributionOrderShrinkRequest : TeaModel {
        [NameInMap("BuyerId")]
        [Validation(Required=false)]
        public string BuyerId { get; set; }

        [NameInMap("DeliveryAddress")]
        [Validation(Required=false)]
        public string DeliveryAddress { get; set; }

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
        public string ItemInfoListsShrink { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
