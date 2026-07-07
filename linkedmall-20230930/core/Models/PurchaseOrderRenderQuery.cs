// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class PurchaseOrderRenderQuery : TeaModel {
        /// <summary>
        /// <para>The ID of the end buyer.&gt;Notice: Assign a unique ID to each buyer.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test1234567</para>
        /// </summary>
        [NameInMap("buyerId")]
        [Validation(Required=false)]
        public string BuyerId { get; set; }

        /// <summary>
        /// <para>Delivery address information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("deliveryAddress")]
        [Validation(Required=false)]
        public AddressInfo DeliveryAddress { get; set; }

        /// <summary>
        /// <para>Extended information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("extInfo")]
        [Validation(Required=false)]
        public Dictionary<string, object> ExtInfo { get; set; }

        /// <summary>
        /// <para>A collection of products.</para>
        /// <remarks>
        /// <para>A single purchase order can contain a maximum of 20 SKUs.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("productList")]
        [Validation(Required=false)]
        public List<OrderRenderProductDTO> ProductList { get; set; }

    }

}
