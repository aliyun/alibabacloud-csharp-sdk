// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class OrderProductResult : TeaModel {
        /// <summary>
        /// <para>Indicates whether the product is available for sale</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("canSell")]
        [Validation(Required=false)]
        public bool? CanSell { get; set; }

        /// <summary>
        /// <para>Additional product information</para>
        /// </summary>
        [NameInMap("features")]
        [Validation(Required=false)]
        public Dictionary<string, object> Features { get; set; }

        /// <summary>
        /// <para>Reason for unavailability</para>
        /// 
        /// <b>Example:</b>
        /// <para>库存为0</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Product price (unit: cent)</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("price")]
        [Validation(Required=false)]
        public long? Price { get; set; }

        /// <summary>
        /// <para>Product ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>6600****6736</para>
        /// </summary>
        [NameInMap("productId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        /// <summary>
        /// <para>Product image link</para>
        /// 
        /// <b>Example:</b>
        /// <para>//img.alicdn.com/imgextra/i4/2216003305543/O1CN01bip3Un1qokG0</para>
        /// </summary>
        [NameInMap("productPicUrl")]
        [Validation(Required=false)]
        public string ProductPicUrl { get; set; }

        /// <summary>
        /// <para>Product title</para>
        /// 
        /// <b>Example:</b>
        /// <para>儿童学习桌</para>
        /// </summary>
        [NameInMap("productTitle")]
        [Validation(Required=false)]
        public string ProductTitle { get; set; }

        /// <summary>
        /// <para>Purchaser ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>PID56****2304</para>
        /// </summary>
        [NameInMap("purchaserId")]
        [Validation(Required=false)]
        public string PurchaserId { get; set; }

        /// <summary>
        /// <para>Quantity</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("quantity")]
        [Validation(Required=false)]
        public int? Quantity { get; set; }

        /// <summary>
        /// <para>SKUID</para>
        /// 
        /// <b>Example:</b>
        /// <para>6600****6737</para>
        /// </summary>
        [NameInMap("skuId")]
        [Validation(Required=false)]
        public string SkuId { get; set; }

        /// <summary>
        /// <para>SKU title</para>
        /// 
        /// <b>Example:</b>
        /// <para>浅绿色</para>
        /// </summary>
        [NameInMap("skuTitle")]
        [Validation(Required=false)]
        public string SkuTitle { get; set; }

    }

}
