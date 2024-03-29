// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class OrderRenderProductDTO : TeaModel {
        [NameInMap("productId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        [NameInMap("purchaserId")]
        [Validation(Required=false)]
        public string PurchaserId { get; set; }

        [NameInMap("quantity")]
        [Validation(Required=false)]
        public int? Quantity { get; set; }

        [NameInMap("skuId")]
        [Validation(Required=false)]
        public string SkuId { get; set; }

    }

}
