// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class OrderRenderProductDTO : TeaModel {
        /// <summary>
        /// <para>Product ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6600****6736</para>
        /// </summary>
        [NameInMap("productId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

        /// <summary>
        /// <para>Purchaser ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PID56****2304</para>
        /// </summary>
        [NameInMap("purchaserId")]
        [Validation(Required=false)]
        public string PurchaserId { get; set; }

        /// <summary>
        /// <para>Quantity</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("quantity")]
        [Validation(Required=false)]
        public int? Quantity { get; set; }

        /// <summary>
        /// <para>skuID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6600****6737</para>
        /// </summary>
        [NameInMap("skuId")]
        [Validation(Required=false)]
        public string SkuId { get; set; }

    }

}
