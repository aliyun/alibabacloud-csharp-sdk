// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeExposedStatisticsResponseBody : TeaModel {
        [NameInMap("ExposedAsapVulCount")]
        [Validation(Required=false)]
        public int? ExposedAsapVulCount { get; set; }

        /// <summary>
        /// The total number of low-risk vulnerabilities that are exposed on the Internet and can be exploited by attackers.
        /// </summary>
        [NameInMap("ExposedComponentCount")]
        [Validation(Required=false)]
        public int? ExposedComponentCount { get; set; }

        /// <summary>
        /// DescribeExposedStatistics
        /// </summary>
        [NameInMap("ExposedInstanceCount")]
        [Validation(Required=false)]
        public int? ExposedInstanceCount { get; set; }

        [NameInMap("ExposedIpCount")]
        [Validation(Required=false)]
        public int? ExposedIpCount { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("ExposedLaterVulCount")]
        [Validation(Required=false)]
        public int? ExposedLaterVulCount { get; set; }

        [NameInMap("ExposedNntfVulCount")]
        [Validation(Required=false)]
        public int? ExposedNntfVulCount { get; set; }

        /// <summary>
        /// Queries the exposure statistics of the assets on the Internet.
        /// </summary>
        [NameInMap("ExposedPortCount")]
        [Validation(Required=false)]
        public int? ExposedPortCount { get; set; }

        [NameInMap("ExposedWeekPasswordMachineCount")]
        [Validation(Required=false)]
        public int? ExposedWeekPasswordMachineCount { get; set; }

        [NameInMap("GatewayAssetCount")]
        [Validation(Required=false)]
        public int? GatewayAssetCount { get; set; }

        /// <summary>
        /// The total number of servers that are exposed on the Internet.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
