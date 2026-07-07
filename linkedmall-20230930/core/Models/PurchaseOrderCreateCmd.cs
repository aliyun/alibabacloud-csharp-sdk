// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class PurchaseOrderCreateCmd : TeaModel {
        /// <summary>
        /// <para>User ID in the distributor\&quot;s business, customized by the distributor.</para>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>Allocate different buyer IDs for different buyers.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>buyer123456</para>
        /// </summary>
        [NameInMap("buyerId")]
        [Validation(Required=false)]
        public string BuyerId { get; set; }

        /// <summary>
        /// <para>Address information.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("deliveryAddress")]
        [Validation(Required=false)]
        public AddressInfo DeliveryAddress { get; set; }

        /// <summary>
        /// <para>Extension information.</para>
        /// </summary>
        [NameInMap("extInfo")]
        [Validation(Required=false)]
        public Dictionary<string, object> ExtInfo { get; set; }

        /// <summary>
        /// <para>Order ID in the distributor\&quot;s business, customized by the distributor.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>outer123456</para>
        /// </summary>
        [NameInMap("outerPurchaseOrderId")]
        [Validation(Required=false)]
        public string OuterPurchaseOrderId { get; set; }

        /// <summary>
        /// <para>Product collection.</para>
        /// <remarks>
        /// <para>Maximum number of SKUs per purchase order: 20.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("productList")]
        [Validation(Required=false)]
        public List<ProductDTO> ProductList { get; set; }

    }

}
