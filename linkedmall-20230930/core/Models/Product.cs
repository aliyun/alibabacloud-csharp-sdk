// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class Product : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Apple/苹果</para>
        /// </summary>
        [NameInMap("brandName")]
        [Validation(Required=false)]
        public string BrandName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("canSell")]
        [Validation(Required=false)]
        public bool? CanSell { get; set; }

        [NameInMap("categoryChain")]
        [Validation(Required=false)]
        public List<Category> CategoryChain { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>201856501</para>
        /// </summary>
        [NameInMap("categoryLeafId")]
        [Validation(Required=false)]
        public long? CategoryLeafId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://img.alicdn.com/descpath/O1CN01wciRDp22AEU14435dsf34">https://img.alicdn.com/descpath/O1CN01wciRDp22AEU14435dsf34</a></para>
        /// </summary>
        [NameInMap("descPath")]
        [Validation(Required=false)]
        public string DescPath { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>110000</para>
        /// </summary>
        [NameInMap("divisionCode")]
        [Validation(Required=false)]
        public string DivisionCode { get; set; }

        [NameInMap("extendProperties")]
        [Validation(Required=false)]
        public List<ProductExtendProperty> ExtendProperties { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100+</para>
        /// </summary>
        [NameInMap("fuzzyQuantity")]
        [Validation(Required=false)]
        public string FuzzyQuantity { get; set; }

        [NameInMap("images")]
        [Validation(Required=false)]
        public List<string> Images { get; set; }

        [NameInMap("inGroup")]
        [Validation(Required=false)]
        public bool? InGroup { get; set; }

        [NameInMap("limitRules")]
        [Validation(Required=false)]
        public List<LimitRule> LimitRules { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>21000017-4580902812</para>
        /// </summary>
        [NameInMap("lmItemId")]
        [Validation(Required=false)]
        public string LmItemId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://img.alicdn.com/imgextra/i3/2214281521988/O1CN01w4vomR1QYYEx6nyr5_!!2214281521988.jpg">https://img.alicdn.com/imgextra/i3/2214281521988/O1CN01w4vomR1QYYEx6nyr5_!!2214281521988.jpg</a></para>
        /// </summary>
        [NameInMap("picUrl")]
        [Validation(Required=false)]
        public string PicUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>660460842235822080</para>
        /// </summary>
        [NameInMap("productId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        [NameInMap("productSpecs")]
        [Validation(Required=false)]
        public List<ProductSpec> ProductSpecs { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Online</para>
        /// </summary>
        [NameInMap("productStatus")]
        [Validation(Required=false)]
        public string ProductStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("productType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        [NameInMap("properties")]
        [Validation(Required=false)]
        public List<ProductProperty> Properties { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("quantity")]
        [Validation(Required=false)]
        public long? Quantity { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3239281273464326823</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("servicePromises")]
        [Validation(Required=false)]
        public List<string> ServicePromises { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>21000017</para>
        /// </summary>
        [NameInMap("shopId")]
        [Validation(Required=false)]
        public string ShopId { get; set; }

        [NameInMap("skus")]
        [Validation(Required=false)]
        public List<Sku> Skus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100+</para>
        /// </summary>
        [NameInMap("soldQuantity")]
        [Validation(Required=false)]
        public string SoldQuantity { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3040203000000000000</para>
        /// </summary>
        [NameInMap("taxCode")]
        [Validation(Required=false)]
        public string TaxCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>600</para>
        /// </summary>
        [NameInMap("taxRate")]
        [Validation(Required=false)]
        public int? TaxRate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>发财树</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
