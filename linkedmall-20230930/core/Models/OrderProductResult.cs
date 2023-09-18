// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class OrderProductResult : TeaModel {
        [NameInMap("canSell")]
        [Validation(Required=false)]
        public bool? CanSell { get; set; }

        [NameInMap("features")]
        [Validation(Required=false)]
        public Dictionary<string, object> Features { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("price")]
        [Validation(Required=false)]
        public long? Price { get; set; }

        [NameInMap("productId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        [NameInMap("productPicUrl")]
        [Validation(Required=false)]
        public string ProductPicUrl { get; set; }

        [NameInMap("productTitle")]
        [Validation(Required=false)]
        public string ProductTitle { get; set; }

        [NameInMap("purchaserId")]
        [Validation(Required=false)]
        public string PurchaserId { get; set; }

        [NameInMap("quantity")]
        [Validation(Required=false)]
        public int? Quantity { get; set; }

        [NameInMap("skuId")]
        [Validation(Required=false)]
        public string SkuId { get; set; }

        [NameInMap("skuTitle")]
        [Validation(Required=false)]
        public string SkuTitle { get; set; }

    }

}
