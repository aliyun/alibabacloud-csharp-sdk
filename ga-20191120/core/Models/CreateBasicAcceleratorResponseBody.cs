// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class CreateBasicAcceleratorResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance ID of the basic Alibaba Cloud Global Accelerator (GA) instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ga-bp17frjjh0udz4qz****</para>
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        /// <summary>
        /// <para>The order ID.</para>
        /// <para>This parameter is returned only when ChargeType is set to PREPAY (upfront).</para>
        /// <para>If <b>AutoPay</b> is set to <b>false</b>, which means automatic payment of the bill is not enabled, go to the &lt;props=&quot;china&quot;&gt;<a href="https://usercenter2.aliyun.com/order/list">Order Center</a>
        /// &lt;props=&quot;intl&quot;&gt;<a href="https://usercenter2-intl.aliyun.com/order/list">Order Center</a> to complete the payment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2082574365</para>
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
