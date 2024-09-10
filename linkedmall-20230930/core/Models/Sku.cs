// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class Sku : TeaModel {
        [NameInMap("barcode")]
        [Validation(Required=false)]
        public string Barcode { get; set; }

        [NameInMap("canSell")]
        [Validation(Required=false)]
        public bool? CanSell { get; set; }

        [NameInMap("divisionCode")]
        [Validation(Required=false)]
        public string DivisionCode { get; set; }

        [NameInMap("fuzzyQuantity")]
        [Validation(Required=false)]
        public string FuzzyQuantity { get; set; }

        [NameInMap("markPrice")]
        [Validation(Required=false)]
        public long? MarkPrice { get; set; }

        [NameInMap("picUrl")]
        [Validation(Required=false)]
        public string PicUrl { get; set; }

        [NameInMap("platformPrice")]
        [Validation(Required=false)]
        public long? PlatformPrice { get; set; }

        [NameInMap("price")]
        [Validation(Required=false)]
        public long? Price { get; set; }

        [NameInMap("productId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        [NameInMap("quantity")]
        [Validation(Required=false)]
        public long? Quantity { get; set; }

        [NameInMap("rankValue")]
        [Validation(Required=false)]
        public long? RankValue { get; set; }

        [NameInMap("shopId")]
        [Validation(Required=false)]
        public string ShopId { get; set; }

        [NameInMap("skuId")]
        [Validation(Required=false)]
        public string SkuId { get; set; }

        [NameInMap("skuSpecs")]
        [Validation(Required=false)]
        public List<SkuSpec> SkuSpecs { get; set; }

        [NameInMap("skuSpecsCode")]
        [Validation(Required=false)]
        public string SkuSpecsCode { get; set; }

        [NameInMap("skuStatus")]
        [Validation(Required=false)]
        public string SkuStatus { get; set; }

        [NameInMap("suggestedRetailPrice")]
        [Validation(Required=false)]
        public long? SuggestedRetailPrice { get; set; }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
