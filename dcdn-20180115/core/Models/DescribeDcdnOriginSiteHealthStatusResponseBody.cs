// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnOriginSiteHealthStatusResponseBody : TeaModel {
        /// <summary>
        /// The information about the origin server of the accelerated domain name.
        /// </summary>
        [NameInMap("OriginSiteStatus")]
        [Validation(Required=false)]
        public List<DescribeDcdnOriginSiteHealthStatusResponseBodyOriginSiteStatus> OriginSiteStatus { get; set; }
        public class DescribeDcdnOriginSiteHealthStatusResponseBodyOriginSiteStatus : TeaModel {
            /// <summary>
            /// The health status of the origin server. Each point of presence (POP) periodically initiates a probe request to the configured origin domain name. If the POP receives a response from the origin server in 5 seconds, the probe is considered successful. After the probe data for each POP is collected, the health status of the origin server is calculated based on the proportion of successful probes. Valid values:
            /// 
            /// *   unknown: The probe data of the origin server is not obtained because the configurations of the origin server have been changed recently. Try again later.
            /// *   healthy: The proportion of successful probes is higher than 80%.
            /// *   degraded: The proportion of successful probes is higher than 0% and lower than or equal to 80%.
            /// *   critical: All probing requests to the origin server failed.
            /// </summary>
            [NameInMap("HealthStatus")]
            [Validation(Required=false)]
            public string HealthStatus { get; set; }

            /// <summary>
            /// The origin domain name that you configured in the DCDN console, which can be an IPv4 address, IPv6 address, common domain name, or Object Storage Service (OSS) domain name.
            /// </summary>
            [NameInMap("Host")]
            [Validation(Required=false)]
            public string Host { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
