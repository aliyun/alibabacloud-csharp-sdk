// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnOriginSiteHealthStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the origin server of the accelerated domain name.</para>
        /// </summary>
        [NameInMap("OriginSiteStatus")]
        [Validation(Required=false)]
        public List<DescribeDcdnOriginSiteHealthStatusResponseBodyOriginSiteStatus> OriginSiteStatus { get; set; }
        public class DescribeDcdnOriginSiteHealthStatusResponseBodyOriginSiteStatus : TeaModel {
            /// <summary>
            /// <para>The health status of the origin server. Each point of presence (POP) periodically initiates a probe request to the configured origin domain name. If the POP receives a response from the origin server in 5 seconds, the probe is considered successful. After the probe data for each POP is collected, the health status of the origin server is calculated based on the proportion of successful probes. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>unknown: The probe data of the origin server is not obtained because the configurations of the origin server have been changed recently. Try again later.</description></item>
            /// <item><description>healthy: The proportion of successful probes is higher than 80%.</description></item>
            /// <item><description>degraded: The proportion of successful probes is higher than 0% and lower than or equal to 80%.</description></item>
            /// <item><description>critical: All probing requests to the origin server failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>healthy</para>
            /// </summary>
            [NameInMap("HealthStatus")]
            [Validation(Required=false)]
            public string HealthStatus { get; set; }

            /// <summary>
            /// <para>The origin domain name that you configured in the DCDN console, which can be an IPv4 address, IPv6 address, common domain name, or Object Storage Service (OSS) domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>host.com</para>
            /// </summary>
            [NameInMap("Host")]
            [Validation(Required=false)]
            public string Host { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0AEDAF20-4DDF-4165-8750-47FF9C1929C9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
