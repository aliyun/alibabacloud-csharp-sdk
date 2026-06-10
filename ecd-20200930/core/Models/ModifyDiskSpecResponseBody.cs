// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class ModifyDiskSpecResponseBody : TeaModel {
        /// <summary>
        /// <para>The order ID. You can find the order ID in &lt;props=&quot;china&quot;&gt;<a href="https://billing-cost.console.aliyun.com/order/list">Expenses and Costs &gt; My Orders</a>. &lt;props=&quot;intl&quot;&gt;<a href="https://usercenter2-intl.aliyun.com/order/list">Expenses and Costs &gt; Order Management</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>219861020660568</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F89BBB13-8B3B-5C8A-A700-EEFDC17B8227</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
