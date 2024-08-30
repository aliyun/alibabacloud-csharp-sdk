// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class Product : TeaModel {
        [NameInMap("brandName")]
        [Validation(Required=false)]
        public string BrandName { get; set; }

        [NameInMap("canSell")]
        [Validation(Required=false)]
        public bool? CanSell { get; set; }

        [NameInMap("categoryChain")]
        [Validation(Required=false)]
        public List<Category> CategoryChain { get; set; }

        [NameInMap("categoryLeafId")]
        [Validation(Required=false)]
        public long? CategoryLeafId { get; set; }

        [NameInMap("descPath")]
        [Validation(Required=false)]
        public string DescPath { get; set; }

        [NameInMap("divisionCode")]
        [Validation(Required=false)]
        public string DivisionCode { get; set; }

        [NameInMap("extendProperties")]
        [Validation(Required=false)]
        public List<ProductExtendProperty> ExtendProperties { get; set; }

        [NameInMap("fuzzyQuantity")]
        [Validation(Required=false)]
        public string FuzzyQuantity { get; set; }

        [NameInMap("images")]
        [Validation(Required=false)]
        public List<string> Images { get; set; }

        [NameInMap("limitRules")]
        [Validation(Required=false)]
        public List<LimitRule> LimitRules { get; set; }

        [NameInMap("lmItemId")]
        [Validation(Required=false)]
        public string LmItemId { get; set; }

        [NameInMap("picUrl")]
        [Validation(Required=false)]
        public string PicUrl { get; set; }

        [NameInMap("productId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        [NameInMap("productSpecs")]
        [Validation(Required=false)]
        public List<ProductSpec> ProductSpecs { get; set; }

        [NameInMap("productStatus")]
        [Validation(Required=false)]
        public string ProductStatus { get; set; }

        [NameInMap("productType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        [NameInMap("properties")]
        [Validation(Required=false)]
        public List<ProductProperty> Properties { get; set; }

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
        public List<Sku> Skus { get; set; }

        [NameInMap("soldQuantity")]
        [Validation(Required=false)]
        public string SoldQuantity { get; set; }

        [NameInMap("taxCode")]
        [Validation(Required=false)]
        public string TaxCode { get; set; }

        [NameInMap("taxRate")]
        [Validation(Required=false)]
        public int? TaxRate { get; set; }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
