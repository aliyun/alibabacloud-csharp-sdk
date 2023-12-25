// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class CreateBandwidthPackageResponseBody : TeaModel {
        /// <summary>
        /// The ID of the bandwidth plan.
        /// </summary>
        [NameInMap("BandwidthPackageId")]
        [Validation(Required=false)]
        public string BandwidthPackageId { get; set; }

        /// <summary>
        /// The order ID.
        /// 
        /// If bills are not automatically paid, you must go to the Order Center to complete the payments.
        /// 
        /// This parameter is returned only if ChargeType is set to PREPAY. If AutoPay is set to false, you must go to the [Order Center](https://usercenter2-intl.aliyun.com/order/list) to complete the payment.
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
