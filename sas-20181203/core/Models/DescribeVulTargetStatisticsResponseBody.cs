// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeVulTargetStatisticsResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The configurations of the vulnerability scan feature.
        /// </summary>
        [NameInMap("TargetStats")]
        [Validation(Required=false)]
        public List<DescribeVulTargetStatisticsResponseBodyTargetStats> TargetStats { get; set; }
        public class DescribeVulTargetStatisticsResponseBodyTargetStats : TeaModel {
            /// <summary>
            /// The information about the server.
            /// </summary>
            [NameInMap("Targets")]
            [Validation(Required=false)]
            public List<DescribeVulTargetStatisticsResponseBodyTargetStatsTargets> Targets { get; set; }
            public class DescribeVulTargetStatisticsResponseBodyTargetStatsTargets : TeaModel {
                /// <summary>
                /// The group ID or UUID of the server to which the configurations are applied.
                /// </summary>
                [NameInMap("Flag")]
                [Validation(Required=false)]
                public string Flag { get; set; }

                /// <summary>
                /// The condition by which the configurations are applied to the server. Valid values:
                /// 
                /// *   **uuid**: the UUID of the server
                /// *   **groupId**: the ID of the server group
                /// </summary>
                [NameInMap("Target")]
                [Validation(Required=false)]
                public string Target { get; set; }

                [NameInMap("TargetType")]
                [Validation(Required=false)]
                public string TargetType { get; set; }

            }

            /// <summary>
            /// The number of servers to which the configurations are applied.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

            /// <summary>
            /// An array that consists of available servers.
            /// </summary>
            [NameInMap("UuidCount")]
            [Validation(Required=false)]
            public int? UuidCount { get; set; }

            /// <summary>
            /// The total number of servers.
            /// </summary>
            [NameInMap("VulType")]
            [Validation(Required=false)]
            public string VulType { get; set; }

        }

        /// <summary>
        /// An array that consists of the configurations of the vulnerability scan feature.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
