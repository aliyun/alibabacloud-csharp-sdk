// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class CreateAcceleratorResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the GA instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ga-bp17frjjh0udz4qz****</para>
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        /// <summary>
        /// <para>Order ID.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <para>The order ID. This parameter is returned when \<c>InstanceChargeType\\</c> is set to \<c>PREPAY\\</c> (subscription). If \<c>AutoPay\\</c> is set to \<c>false\\</c>, go to the <a href="https://usercenter2.aliyun.com/order/list">Order Hub</a> on the Alibaba Cloud China site to complete the payment.</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <para>If you are using the Alibaba Cloud International site and \<c>AutoPay\\</c> is set to \<c>false\\</c>, go to the <a href="https://usercenter2-intl.aliyun.com/order/list">Order Hub</a> to complete the payment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>208257****</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F591955F-5CB5-4CCE-A75D-17CF2085CE22</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
