// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class CreateBandwidthPackageResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the bandwidth plan.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gbwp-bp1sgzldyj6b4q7cx****</para>
        /// </summary>
        [NameInMap("BandwidthPackageId")]
        [Validation(Required=false)]
        public string BandwidthPackageId { get; set; }

        /// <summary>
        /// <para>The order ID.</para>
        /// <para>If bills are not automatically paid, you must go to the Order Center to complete the payments.</para>
        /// <para>This parameter is returned only if ChargeType is set to PREPAY. If AutoPay is set to false, you must go to the <a href="https://usercenter2-intl.aliyun.com/order/list">Order Center</a> to complete the payment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>208257****</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4B6DBBB0-2D01-4C6A-A384-4129266E6B78</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
