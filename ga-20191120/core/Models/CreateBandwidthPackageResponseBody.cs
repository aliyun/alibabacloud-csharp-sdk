// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class CreateBandwidthPackageResponseBody : TeaModel {
        /// <summary>
        /// <para>The bandwidth plan ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gbwp-bp1sgzldyj6b4q7cx****</para>
        /// </summary>
        [NameInMap("BandwidthPackageId")]
        [Validation(Required=false)]
        public string BandwidthPackageId { get; set; }

        /// <summary>
        /// <para>The order ID.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;This parameter is returned only when you set ChargeType to PREPAY. If you set AutoPay to false, go to the <a href="https://usercenter2.aliyun.com/order/list">Order Hub</a> to complete the payment.</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <para>This parameter is returned only when you set ChargeType to PREPAY. If you set AutoPay to false, go to the <a href="https://usercenter2-intl.aliyun.com/order/list">Order Hub</a> to complete the payment.</para>
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
        /// <para>4B6DBBB0-2D01-4C6A-A384-4129266E6B78</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
