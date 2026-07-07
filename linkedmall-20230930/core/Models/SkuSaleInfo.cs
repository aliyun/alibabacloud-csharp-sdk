// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class SkuSaleInfo : TeaModel {
        /// <summary>
        /// <para>Reason for not being sellable</para>
        /// 
        /// <b>Example:</b>
        /// <para>不可售</para>
        /// </summary>
        [NameInMap("canNotSellReason")]
        [Validation(Required=false)]
        public string CanNotSellReason { get; set; }

        /// <summary>
        /// <para>Indicates whether the SKU is sellable</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("canSell")]
        [Validation(Required=false)]
        public bool? CanSell { get; set; }

        /// <summary>
        /// <para>Area code</para>
        /// 
        /// <b>Example:</b>
        /// <para>330106109</para>
        /// </summary>
        [NameInMap("divisionCode")]
        [Validation(Required=false)]
        public string DivisionCode { get; set; }

        /// <summary>
        /// <para>Blur inventory availability</para>
        /// 
        /// <b>Example:</b>
        /// <para>有货</para>
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
        /// <para>Available inventory</para>
        /// 
        /// <b>Example:</b>
        /// <para>-1</para>
        /// </summary>
        [NameInMap("quantity")]
        [Validation(Required=false)]
        public long? Quantity { get; set; }

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
        /// <para>skuId</para>
        /// 
        /// <b>Example:</b>
        /// <para>660460842235822081</para>
        /// </summary>
        [NameInMap("skuId")]
        [Validation(Required=false)]
        public string SkuId { get; set; }

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
        /// <para>SKU title</para>
        /// 
        /// <b>Example:</b>
        /// <para>天蓝色</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
