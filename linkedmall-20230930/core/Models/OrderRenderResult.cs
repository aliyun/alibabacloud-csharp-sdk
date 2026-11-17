// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class OrderRenderResult : TeaModel {
        /// <summary>
        /// <para>Indicates whether the item is sellable.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("canSell")]
        [Validation(Required=false)]
        public bool? CanSell { get; set; }

        /// <summary>
        /// <para>The fulfillment information.</para>
        /// </summary>
        [NameInMap("deliveryInfoList")]
        [Validation(Required=false)]
        public List<DeliveryInfo> DeliveryInfoList { get; set; }

        /// <summary>
        /// <para>The extension information.</para>
        /// </summary>
        [NameInMap("extInfo")]
        [Validation(Required=false)]
        public Dictionary<string, object> ExtInfo { get; set; }

        /// <summary>
        /// <para>The unsellable reason.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Inventory is 0</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The product collection.</para>
        /// </summary>
        [NameInMap("productList")]
        [Validation(Required=false)]
        public List<OrderProductResult> ProductList { get; set; }

    }

}
