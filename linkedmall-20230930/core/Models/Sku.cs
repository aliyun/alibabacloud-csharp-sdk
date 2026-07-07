// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class Sku : TeaModel {
        /// <summary>
        /// <para>69 barcode</para>
        /// 
        /// <b>Example:</b>
        /// <para>6922454329176</para>
        /// </summary>
        [NameInMap("barcode")]
        [Validation(Required=false)]
        public string Barcode { get; set; }

        /// <summary>
        /// <para>Indicates whether the SKU is available for sale</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("canSell")]
        [Validation(Required=false)]
        public bool? CanSell { get; set; }

        /// <summary>
        /// <para>Reserved field</para>
        /// </summary>
        [NameInMap("discountRetailPrice")]
        [Validation(Required=false)]
        public long? DiscountRetailPrice { get; set; }

        /// <summary>
        /// <para>Region code</para>
        /// 
        /// <b>Example:</b>
        /// <para>110000</para>
        /// </summary>
        [NameInMap("divisionCode")]
        [Validation(Required=false)]
        public string DivisionCode { get; set; }

        /// <summary>
        /// <para>Fuzzy inventory availability</para>
        /// 
        /// <b>Example:</b>
        /// <para>有货
        /// 无货
        /// 库存紧张</para>
        /// </summary>
        [NameInMap("fuzzyQuantity")]
        [Validation(Required=false)]
        public string FuzzyQuantity { get; set; }

        /// <summary>
        /// <para>Strikethrough price, in cents</para>
        /// 
        /// <b>Example:</b>
        /// <para>999900</para>
        /// </summary>
        [NameInMap("markPrice")]
        [Validation(Required=false)]
        public long? MarkPrice { get; set; }

        /// <summary>
        /// <para>SKU image URL</para>
        /// 
        /// <b>Example:</b>
        /// <para>https:////img.alicdn.com/imgextra///img.alicdn.com/imgextra/i2/2216003305543/O1CN010DEQCX1qokFYGRfPE_!!2216003305543.png</para>
        /// </summary>
        [NameInMap("picUrl")]
        [Validation(Required=false)]
        public string PicUrl { get; set; }

        /// <summary>
        /// <para>Suggested retail price, in cents</para>
        /// 
        /// <b>Example:</b>
        /// <para>999900</para>
        /// </summary>
        [NameInMap("platformPrice")]
        [Validation(Required=false)]
        public long? PlatformPrice { get; set; }

        /// <summary>
        /// <para>Distributor purchase price, in cents</para>
        /// 
        /// <b>Example:</b>
        /// <para>19800</para>
        /// </summary>
        [NameInMap("price")]
        [Validation(Required=false)]
        public long? Price { get; set; }

        /// <summary>
        /// <para>Product ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>660460842235822080</para>
        /// </summary>
        [NameInMap("productId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        /// <summary>
        /// <para>Available inventory. Note: This field is currently set to -1 for all SKUs and has no practical meaning.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("quantity")]
        [Validation(Required=false)]
        public long? Quantity { get; set; }

        /// <summary>
        /// <para>SKU sort order</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("rankValue")]
        [Validation(Required=false)]
        public long? RankValue { get; set; }

        /// <summary>
        /// <para>Shop ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>21000017</para>
        /// </summary>
        [NameInMap("shopId")]
        [Validation(Required=false)]
        public string ShopId { get; set; }

        /// <summary>
        /// <para>SKU note</para>
        /// </summary>
        [NameInMap("skuAlias")]
        [Validation(Required=false)]
        public string SkuAlias { get; set; }

        /// <summary>
        /// <para>SKU ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>660460842235822081</para>
        /// </summary>
        [NameInMap("skuId")]
        [Validation(Required=false)]
        public string SkuId { get; set; }

        /// <summary>
        /// <para>SKU specifications</para>
        /// </summary>
        [NameInMap("skuSpecs")]
        [Validation(Required=false)]
        public List<SkuSpec> SkuSpecs { get; set; }

        /// <summary>
        /// <para>SKU sales specification code. Used by the frontend to filter SKUs</para>
        /// 
        /// <b>Example:</b>
        /// <para>颜色分类:天蓝色</para>
        /// </summary>
        [NameInMap("skuSpecsCode")]
        [Validation(Required=false)]
        public string SkuSpecsCode { get; set; }

        /// <summary>
        /// <para>SKU control status</para>
        /// 
        /// <b>Example:</b>
        /// <para>Online</para>
        /// </summary>
        [NameInMap("skuStatus")]
        [Validation(Required=false)]
        public string SkuStatus { get; set; }

        /// <summary>
        /// <para>Reserved field</para>
        /// </summary>
        [NameInMap("suggestedRetailPrice")]
        [Validation(Required=false)]
        public long? SuggestedRetailPrice { get; set; }

        /// <summary>
        /// <para>SKU title. Note: We recommend that distributors build the customer-facing SKU title by concatenating the value or valueAlias field from the SkuSpec struct (use <c>valueAlias</c> if it is present). Do not use this field directly as the customer-facing SKU title.</para>
        /// 
        /// <b>Example:</b>
        /// <para>天蓝色</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
