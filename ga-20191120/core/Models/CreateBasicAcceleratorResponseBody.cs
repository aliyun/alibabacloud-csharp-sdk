// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class CreateBasicAcceleratorResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the basic GA instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ga-bp17frjjh0udz4qz****</para>
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        /// <summary>
        /// <para>The order ID.</para>
        /// <para>This parameter is returned only if ChargeType is set to PREPAY.</para>
        /// <para>If <b>AutoPay</b> is set to <b>false</b>, go to <a href="https://usercenter2-intl.aliyun.com/order/list">Order Center</a> to complete the payment after an order is generated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2082574365</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F591955F-5CB5-4CCE-A75D-17CF2085CE22</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
