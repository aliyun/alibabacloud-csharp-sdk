// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class ProductSaleInfo : TeaModel {
        /// <summary>
        /// <para>Is sellable, calculated value</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("canSell")]
        [Validation(Required=false)]
        public bool? CanSell { get; set; }

        /// <summary>
        /// <para>Region code</para>
        /// 
        /// <b>Example:</b>
        /// <para>330106109</para>
        /// </summary>
        [NameInMap("divisionCode")]
        [Validation(Required=false)]
        public string DivisionCode { get; set; }

        /// <summary>
        /// <para>Fuzzy inventory quantity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>有货</para>
        /// </summary>
        [NameInMap("fuzzyQuantity")]
        [Validation(Required=false)]
        public string FuzzyQuantity { get; set; }

        /// <summary>
        /// <para>Purchase limit configuration</para>
        /// </summary>
        [NameInMap("limitRules")]
        [Validation(Required=false)]
        public List<LimitRule> LimitRules { get; set; }

        /// <summary>
        /// <para>LM product ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>21000017-4580902812</para>
        /// </summary>
        [NameInMap("lmItemId")]
        [Validation(Required=false)]
        public string LmItemId { get; set; }

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
        /// <para>Product status</para>
        /// 
        /// <b>Example:</b>
        /// <para>Online</para>
        /// </summary>
        [NameInMap("productStatus")]
        [Validation(Required=false)]
        public string ProductStatus { get; set; }

        /// <summary>
        /// <para>Inventory</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("quantity")]
        [Validation(Required=false)]
        public long? Quantity { get; set; }

        /// <summary>
        /// <para>API request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>3239281273464326823</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Channel shop ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>21000017</para>
        /// </summary>
        [NameInMap("shopId")]
        [Validation(Required=false)]
        public string ShopId { get; set; }

        /// <summary>
        /// <para>SKU collection</para>
        /// </summary>
        [NameInMap("skus")]
        [Validation(Required=false)]
        public List<SkuSaleInfo> Skus { get; set; }

        /// <summary>
        /// <para>Title</para>
        /// 
        /// <b>Example:</b>
        /// <para>发财树</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
