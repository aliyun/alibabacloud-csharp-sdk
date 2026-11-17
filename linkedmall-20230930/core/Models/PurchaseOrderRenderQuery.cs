// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class PurchaseOrderRenderQuery : TeaModel {
        /// <summary>
        /// <para>The actual buyer ID for distribution. <notice>Assign a unique ID to each buyer. Do not use the same ID for different buyers.</notice></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test1234567</para>
        /// </summary>
        [NameInMap("buyerId")]
        [Validation(Required=false)]
        public string BuyerId { get; set; }

        /// <summary>
        /// <para>The address information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("deliveryAddress")]
        [Validation(Required=false)]
        public AddressInfo DeliveryAddress { get; set; }

        /// <summary>
        /// <para>The extension information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("extInfo")]
        [Validation(Required=false)]
        public Dictionary<string, object> ExtInfo { get; set; }

        /// <summary>
        /// <para>The product list.</para>
        /// <remarks>
        /// <para>Maximum number of SKUs per purchase order: 20.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("productList")]
        [Validation(Required=false)]
        public List<OrderRenderProductDTO> ProductList { get; set; }

    }

}
