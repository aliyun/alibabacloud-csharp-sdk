// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeIntranetAttributeResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether auto-renewal is enabled for the extra internal bandwidth that you purchased. Valid values:
        /// 
        /// *   **true**: Auto-renewal is enabled.
        /// *   **false**: Auto-renewal is disabled.
        /// 
        /// > If no extra internal bandwidth is purchased, this parameter is not returned.
        /// </summary>
        [NameInMap("AutoRenewal")]
        [Validation(Required=false)]
        public bool? AutoRenewal { get; set; }

        /// <summary>
        /// The expiration time of the purchased bandwidth. The time follows the ISO 8601 standard in the *yyyy-MM-dd* T *HH:mm:ss* Z format.
        /// 
        /// > If no extra internal bandwidth is purchased, this parameter is not returned.
        /// </summary>
        [NameInMap("BandwidthExpireTime")]
        [Validation(Required=false)]
        public string BandwidthExpireTime { get; set; }

        /// <summary>
        /// The billing methods of unexpired bandwith plans. Valid values:
        /// - **0**: Pay-as-you-go
        /// - **1**: Subscription
        /// </summary>
        [NameInMap("BandwidthPrePaid")]
        [Validation(Required=false)]
        public string BandwidthPrePaid { get; set; }

        /// <summary>
        /// The time when the extra internal bandwidth that you purchased for temporary use expires. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
        /// 
        /// > If no extra internal bandwidth for temporary use is purchased or the extra internal bandwidth that you purchased for temporary use has expired, **0** is returned for this parameter.
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// Specifies whether the instance has unexpired bandwidth plans. Valid values:
        /// 
        /// *   **true**: The instance has unexpired bandwidth plans.
        /// *   **false**: The instance does not have unexpired bandwidth plans.
        /// 
        /// > If no extra internal bandwidth is purchased, this parameter is not returned.
        /// </summary>
        [NameInMap("HasPrePaidBandWidthOrderRunning")]
        [Validation(Required=false)]
        public bool? HasPrePaidBandWidthOrderRunning { get; set; }

        /// <summary>
        /// The current internal bandwidth of the instance. Unit: Mbit/s.
        /// </summary>
        [NameInMap("IntranetBandwidth")]
        [Validation(Required=false)]
        public int? IntranetBandwidth { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
