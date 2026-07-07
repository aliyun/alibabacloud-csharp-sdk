// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class OrderLineResult : TeaModel {
        /// <summary>
        /// <para>A list of electronic vouchers.</para>
        /// </summary>
        [NameInMap("eticketInfos")]
        [Validation(Required=false)]
        public List<EticketInfo> EticketInfos { get; set; }

        /// <summary>
        /// <para>The logistics status of the order line.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("logisticsStatus")]
        [Validation(Required=false)]
        public string LogisticsStatus { get; set; }

        /// <summary>
        /// <para>The number of items.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("number")]
        [Validation(Required=false)]
        public string Number { get; set; }

        /// <summary>
        /// <para>The unique ID of the main order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6692****5457</para>
        /// </summary>
        [NameInMap("orderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>The unique ID of the order line.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6692****5458</para>
        /// </summary>
        [NameInMap("orderLineId")]
        [Validation(Required=false)]
        public string OrderLineId { get; set; }

        /// <summary>
        /// <para>The status of the order line.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("orderLineStatus")]
        [Validation(Required=false)]
        public string OrderLineStatus { get; set; }

        /// <summary>
        /// <para>The payable amount for the order line.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("payFee")]
        [Validation(Required=false)]
        public long? PayFee { get; set; }

        /// <summary>
        /// <para>The unique ID of the product.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6600****6736</para>
        /// </summary>
        [NameInMap("productId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        /// <summary>
        /// <para>The URL of the product image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>//img.alicdn.com/imgextra/i4/2216003305543/O1CN01bip3Un1qokG0</para>
        /// </summary>
        [NameInMap("productPic")]
        [Validation(Required=false)]
        public string ProductPic { get; set; }

        /// <summary>
        /// <para>The product name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>儿童学习桌</para>
        /// </summary>
        [NameInMap("productTitle")]
        [Validation(Required=false)]
        public string ProductTitle { get; set; }

        /// <summary>
        /// <para>The unique ID of the SKU.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6600****6737</para>
        /// </summary>
        [NameInMap("skuId")]
        [Validation(Required=false)]
        public string SkuId { get; set; }

        /// <summary>
        /// <para>The SKU name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>浅绿色</para>
        /// </summary>
        [NameInMap("skuTitle")]
        [Validation(Required=false)]
        public string SkuTitle { get; set; }

    }

}
