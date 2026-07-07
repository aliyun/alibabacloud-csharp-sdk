// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class PurchaseOrderRenderResult : TeaModel {
        /// <summary>
        /// <para>A collection of addresses.</para>
        /// </summary>
        [NameInMap("addressList")]
        [Validation(Required=false)]
        public List<AddressInfo> AddressList { get; set; }

        /// <summary>
        /// <para>Indicates whether the item can be sold.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("canSell")]
        [Validation(Required=false)]
        public bool? CanSell { get; set; }

        /// <summary>
        /// <para>Extended information.</para>
        /// </summary>
        [NameInMap("extInfo")]
        [Validation(Required=false)]
        public Dictionary<string, object> ExtInfo { get; set; }

        /// <summary>
        /// <para>The reason why the item cannot be sold.</para>
        /// 
        /// <b>Example:</b>
        /// <para>库存为0</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>A collection of sellable main orders.</para>
        /// </summary>
        [NameInMap("orderList")]
        [Validation(Required=false)]
        public List<OrderRenderResult> OrderList { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>841471F6-5D61-1331-8C38-2****B55</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>A collection of unsellable main orders.</para>
        /// </summary>
        [NameInMap("unsellableOrderList")]
        [Validation(Required=false)]
        public List<OrderRenderResult> UnsellableOrderList { get; set; }

    }

}
