// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class Product : TeaModel {
        /// <summary>
        /// <para>The brand name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Apple/苹果</para>
        /// </summary>
        [NameInMap("brandName")]
        [Validation(Required=false)]
        public string BrandName { get; set; }

        /// <summary>
        /// <para>Indicates whether the product is available for sale. This is a calculated value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("canSell")]
        [Validation(Required=false)]
        public bool? CanSell { get; set; }

        /// <summary>
        /// <para>The category chain.</para>
        /// </summary>
        [NameInMap("categoryChain")]
        [Validation(Required=false)]
        public List<Category> CategoryChain { get; set; }

        /// <summary>
        /// <para>The leaf category ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>201****501</para>
        /// </summary>
        [NameInMap("categoryLeafId")]
        [Validation(Required=false)]
        public long? CategoryLeafId { get; set; }

        /// <summary>
        /// <para>The product description URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://img.alicdn.com/descpath/O1CN01wciRDp22AEU1*******f34">https://img.alicdn.com/descpath/O1CN01wciRDp22AEU1*******f34</a></para>
        /// </summary>
        [NameInMap("descPath")]
        [Validation(Required=false)]
        public string DescPath { get; set; }

        /// <summary>
        /// <para>The region code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>110000</para>
        /// </summary>
        [NameInMap("divisionCode")]
        [Validation(Required=false)]
        public string DivisionCode { get; set; }

        /// <summary>
        /// <para>The product\&quot;s extended properties.</para>
        /// </summary>
        [NameInMap("extendProperties")]
        [Validation(Required=false)]
        public List<ProductExtendProperty> ExtendProperties { get; set; }

        /// <summary>
        /// <para>The stock status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>有货</para>
        /// </summary>
        [NameInMap("fuzzyQuantity")]
        [Validation(Required=false)]
        public string FuzzyQuantity { get; set; }

        /// <summary>
        /// <para>The product images.</para>
        /// </summary>
        [NameInMap("images")]
        [Validation(Required=false)]
        public List<string> Images { get; set; }

        /// <summary>
        /// <para>The warehousing status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("inGroup")]
        [Validation(Required=false)]
        public bool? InGroup { get; set; }

        /// <summary>
        /// <para>The purchase limit rules.</para>
        /// </summary>
        [NameInMap("limitRules")]
        [Validation(Required=false)]
        public List<LimitRule> LimitRules { get; set; }

        /// <summary>
        /// <para>The LM product ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2100<b><b>7-458</b></b>812</para>
        /// </summary>
        [NameInMap("lmItemId")]
        [Validation(Required=false)]
        public string LmItemId { get; set; }

        /// <summary>
        /// <para>The main product image URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://img.alicdn.com/imgextra/i3/221*******988/O1CN01w4vomR1QYYEx6nyr5_!!221******988.jpg">https://img.alicdn.com/imgextra/i3/221*******988/O1CN01w4vomR1QYYEx6nyr5_!!221******988.jpg</a></para>
        /// </summary>
        [NameInMap("picUrl")]
        [Validation(Required=false)]
        public string PicUrl { get; set; }

        /// <summary>
        /// <para>The product ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>660460842******080</para>
        /// </summary>
        [NameInMap("productId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        /// <summary>
        /// <para>The product specifications.</para>
        /// </summary>
        [NameInMap("productSpecs")]
        [Validation(Required=false)]
        public List<ProductSpec> ProductSpecs { get; set; }

        /// <summary>
        /// <para>The product status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Online</para>
        /// </summary>
        [NameInMap("productStatus")]
        [Validation(Required=false)]
        public string ProductStatus { get; set; }

        /// <summary>
        /// <para>The product type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("productType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The product attributes.</para>
        /// </summary>
        [NameInMap("properties")]
        [Validation(Required=false)]
        public List<ProductProperty> Properties { get; set; }

        /// <summary>
        /// <para>The inventory.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is fixed at -1 and can be ignored.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("quantity")]
        [Validation(Required=false)]
        public long? Quantity { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3239281273******823</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The service promises.&gt;Notice:  Suppliers maintain all service promises. If a supplier fails to update this information in a timely manner, the service promise labels for some products may be inaccurate. Distributors should display this information to their customers with caution.</para>
        /// </summary>
        [NameInMap("servicePromises")]
        [Validation(Required=false)]
        public List<string> ServicePromises { get; set; }

        /// <summary>
        /// <para>The channel shop ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>210*****7</para>
        /// </summary>
        [NameInMap("shopId")]
        [Validation(Required=false)]
        public string ShopId { get; set; }

        /// <summary>
        /// <para>The product SKUs.</para>
        /// </summary>
        [NameInMap("skus")]
        [Validation(Required=false)]
        public List<Sku> Skus { get; set; }

        /// <summary>
        /// <para>The quantity sold.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100+</para>
        /// </summary>
        [NameInMap("soldQuantity")]
        [Validation(Required=false)]
        public string SoldQuantity { get; set; }

        /// <summary>
        /// <para>The tax code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3040203000*******000</para>
        /// </summary>
        [NameInMap("taxCode")]
        [Validation(Required=false)]
        public string TaxCode { get; set; }

        /// <summary>
        /// <para>The tax rate.</para>
        /// 
        /// <b>Example:</b>
        /// <para>600</para>
        /// </summary>
        [NameInMap("taxRate")]
        [Validation(Required=false)]
        public int? TaxRate { get; set; }

        /// <summary>
        /// <para>The product title.</para>
        /// 
        /// <b>Example:</b>
        /// <para>发财树</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
