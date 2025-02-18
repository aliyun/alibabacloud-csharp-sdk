// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class Sku : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>6922454329176</para>
        /// </summary>
        [NameInMap("barcode")]
        [Validation(Required=false)]
        public string Barcode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("canSell")]
        [Validation(Required=false)]
        public bool? CanSell { get; set; }

        [NameInMap("discountRetailPrice")]
        [Validation(Required=false)]
        public long? DiscountRetailPrice { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>110000</para>
        /// </summary>
        [NameInMap("divisionCode")]
        [Validation(Required=false)]
        public string DivisionCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>有货</para>
        /// </summary>
        [NameInMap("fuzzyQuantity")]
        [Validation(Required=false)]
        public string FuzzyQuantity { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>999900</para>
        /// </summary>
        [NameInMap("markPrice")]
        [Validation(Required=false)]
        public long? MarkPrice { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>https:////img.alicdn.com/imgextra///img.alicdn.com/imgextra/i2/2216003305543/O1CN010DEQCX1qokFYGRfPE_!!2216003305543.png</para>
        /// </summary>
        [NameInMap("picUrl")]
        [Validation(Required=false)]
        public string PicUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>999900</para>
        /// </summary>
        [NameInMap("platformPrice")]
        [Validation(Required=false)]
        public long? PlatformPrice { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>19800</para>
        /// </summary>
        [NameInMap("price")]
        [Validation(Required=false)]
        public long? Price { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>660460842235822080</para>
        /// </summary>
        [NameInMap("productId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("quantity")]
        [Validation(Required=false)]
        public long? Quantity { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("rankValue")]
        [Validation(Required=false)]
        public long? RankValue { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>21000017</para>
        /// </summary>
        [NameInMap("shopId")]
        [Validation(Required=false)]
        public string ShopId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>660460842235822081</para>
        /// </summary>
        [NameInMap("skuId")]
        [Validation(Required=false)]
        public string SkuId { get; set; }

        [NameInMap("skuSpecs")]
        [Validation(Required=false)]
        public List<SkuSpec> SkuSpecs { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>颜色分类:天蓝色</para>
        /// </summary>
        [NameInMap("skuSpecsCode")]
        [Validation(Required=false)]
        public string SkuSpecsCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Online</para>
        /// </summary>
        [NameInMap("skuStatus")]
        [Validation(Required=false)]
        public string SkuStatus { get; set; }

        [NameInMap("suggestedRetailPrice")]
        [Validation(Required=false)]
        public long? SuggestedRetailPrice { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>天蓝色</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
