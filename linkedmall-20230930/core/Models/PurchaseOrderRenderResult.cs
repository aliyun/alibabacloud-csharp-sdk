// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class PurchaseOrderRenderResult : TeaModel {
        /// <summary>
        /// <para>The address list.</para>
        /// </summary>
        [NameInMap("addressList")]
        [Validation(Required=false)]
        public List<AddressInfo> AddressList { get; set; }

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
        /// <para>The extended information.</para>
        /// </summary>
        [NameInMap("extInfo")]
        [Validation(Required=false)]
        public Dictionary<string, object> ExtInfo { get; set; }

        /// <summary>
        /// <para>The reason why the item is unsellable.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Out of stock</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The list of sellable primary orders.</para>
        /// </summary>
        [NameInMap("orderList")]
        [Validation(Required=false)]
        public List<OrderRenderResult> OrderList { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>841471F6-5D61-1331-8C38-2****B55</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of unsellable primary orders.</para>
        /// </summary>
        [NameInMap("unsellableOrderList")]
        [Validation(Required=false)]
        public List<OrderRenderResult> UnsellableOrderList { get; set; }

    }

}
