// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class ProductSaleInfo : TeaModel {
        [NameInMap("canSell")]
        [Validation(Required=false)]
        public bool? CanSell { get; set; }

        [NameInMap("divisionCode")]
        [Validation(Required=false)]
        public string DivisionCode { get; set; }

        [NameInMap("fuzzyQuantity")]
        [Validation(Required=false)]
        public string FuzzyQuantity { get; set; }

        [NameInMap("limitRules")]
        [Validation(Required=false)]
        public List<LimitRule> LimitRules { get; set; }

        [NameInMap("lmItemId")]
        [Validation(Required=false)]
        public string LmItemId { get; set; }

        [NameInMap("productId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        [NameInMap("productStatus")]
        [Validation(Required=false)]
        public string ProductStatus { get; set; }

        [NameInMap("quantity")]
        [Validation(Required=false)]
        public long? Quantity { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("shopId")]
        [Validation(Required=false)]
        public string ShopId { get; set; }

        [NameInMap("skus")]
        [Validation(Required=false)]
        public List<SkuSaleInfo> Skus { get; set; }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
