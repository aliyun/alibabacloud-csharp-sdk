// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeExposedStatisticsResponseBody : TeaModel {
        /// <summary>
        /// The total number of high-risk vulnerabilities that are exposed on the Internet and can be exploited by attackers.
        /// </summary>
        [NameInMap("ExposedAsapVulCount")]
        [Validation(Required=false)]
        public int? ExposedAsapVulCount { get; set; }

        /// <summary>
        /// The total number of system components that are exposed on the Internet. The components include OpenSSL and OpenSSH.
        /// </summary>
        [NameInMap("ExposedComponentCount")]
        [Validation(Required=false)]
        public int? ExposedComponentCount { get; set; }

        /// <summary>
        /// The total number of servers that are exposed on the Internet.
        /// </summary>
        [NameInMap("ExposedInstanceCount")]
        [Validation(Required=false)]
        public int? ExposedInstanceCount { get; set; }

        /// <summary>
        /// The total number of IP addresses that are exposed on the Internet.
        /// </summary>
        [NameInMap("ExposedIpCount")]
        [Validation(Required=false)]
        public int? ExposedIpCount { get; set; }

        /// <summary>
        /// The total number of medium-risk vulnerabilities that are exposed on the Internet and can be exploited by attackers.
        /// </summary>
        [NameInMap("ExposedLaterVulCount")]
        [Validation(Required=false)]
        public int? ExposedLaterVulCount { get; set; }

        /// <summary>
        /// The total number of low-risk vulnerabilities that are exposed on the Internet and can be exploited by attackers.
        /// </summary>
        [NameInMap("ExposedNntfVulCount")]
        [Validation(Required=false)]
        public int? ExposedNntfVulCount { get; set; }

        /// <summary>
        /// The total number of ports that are exposed on the Internet.
        /// </summary>
        [NameInMap("ExposedPortCount")]
        [Validation(Required=false)]
        public int? ExposedPortCount { get; set; }

        /// <summary>
        /// The total number of system keys that are detected on your servers and are exposed on the Internet.
        /// </summary>
        [NameInMap("ExposedWeekPasswordMachineCount")]
        [Validation(Required=false)]
        public int? ExposedWeekPasswordMachineCount { get; set; }

        /// <summary>
        /// The total number of gateway assets that are exposed on the Internet. The gateway assets include NAT gateways and Server Load Balancer (SLB) instances.
        /// </summary>
        [NameInMap("GatewayAssetCount")]
        [Validation(Required=false)]
        public int? GatewayAssetCount { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
