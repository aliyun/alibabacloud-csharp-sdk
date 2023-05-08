// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeVulTargetStatisticsResponseBody : TeaModel {
        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// An array that consists of the configurations of the vulnerability scan feature.
        /// </summary>
        [NameInMap("TargetStats")]
        [Validation(Required=false)]
        public List<DescribeVulTargetStatisticsResponseBodyTargetStats> TargetStats { get; set; }
        public class DescribeVulTargetStatisticsResponseBodyTargetStats : TeaModel {
            /// <summary>
            /// An array that consists of available servers.
            /// </summary>
            [NameInMap("Targets")]
            [Validation(Required=false)]
            public List<DescribeVulTargetStatisticsResponseBodyTargetStatsTargets> Targets { get; set; }
            public class DescribeVulTargetStatisticsResponseBodyTargetStatsTargets : TeaModel {
                /// <summary>
                /// Indicates whether the configurations are applied to the server. Valid values:
                /// 
                /// *   **add**: yes
                /// *   **del**: no
                /// </summary>
                [NameInMap("Flag")]
                [Validation(Required=false)]
                public string Flag { get; set; }

                /// <summary>
                /// The group ID or UUID of the server to which the configurations are applied.
                /// </summary>
                [NameInMap("Target")]
                [Validation(Required=false)]
                public string Target { get; set; }

                /// <summary>
                /// The condition by which the configurations are applied to the server. Valid values:
                /// 
                /// *   **uuid**: the UUID of the server
                /// *   **groupId**: the ID of the server group
                /// </summary>
                [NameInMap("TargetType")]
                [Validation(Required=false)]
                public string TargetType { get; set; }

            }

            /// <summary>
            /// The total number of servers.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            /// <summary>
            /// The number of servers to which the configurations are applied.
            /// </summary>
            [NameInMap("UuidCount")]
            [Validation(Required=false)]
            public int? UuidCount { get; set; }

            /// <summary>
            /// The type of the vulnerabilities. Valid values:
            /// 
            /// *   cve: Linux software vulnerabilities
            /// *   sys: Windows system vulnerabilities
            /// *   cms: Web-CMS vulnerabilities
            /// *   emg: urgent vulnerabilities
            /// </summary>
            [NameInMap("VulType")]
            [Validation(Required=false)]
            public string VulType { get; set; }

        }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
