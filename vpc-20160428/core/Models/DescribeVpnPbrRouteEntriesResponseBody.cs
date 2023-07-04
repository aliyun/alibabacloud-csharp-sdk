// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVpnPbrRouteEntriesResponseBody : TeaModel {
        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

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
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// The list of policy-based routes.
        /// </summary>
        [NameInMap("VpnPbrRouteEntries")]
        [Validation(Required=false)]
        public DescribeVpnPbrRouteEntriesResponseBodyVpnPbrRouteEntries VpnPbrRouteEntries { get; set; }
        public class DescribeVpnPbrRouteEntriesResponseBodyVpnPbrRouteEntries : TeaModel {
            [NameInMap("VpnPbrRouteEntry")]
            [Validation(Required=false)]
            public List<DescribeVpnPbrRouteEntriesResponseBodyVpnPbrRouteEntriesVpnPbrRouteEntry> VpnPbrRouteEntry { get; set; }
            public class DescribeVpnPbrRouteEntriesResponseBodyVpnPbrRouteEntriesVpnPbrRouteEntry : TeaModel {
                /// <summary>
                /// The timestamp generated when the policy-based route was created. Unit: milliseconds.
                /// 
                /// This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// The next hop of the policy-based route.
                /// </summary>
                [NameInMap("NextHop")]
                [Validation(Required=false)]
                public string NextHop { get; set; }

                [NameInMap("NextHopTunnelId")]
                [Validation(Required=false)]
                public string NextHopTunnelId { get; set; }

                /// <summary>
                /// The priority of the policy-based route.
                /// 
                /// A smaller value indicates a higher priority.
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// The destination CIDR block of the policy-based route.
                /// </summary>
                [NameInMap("RouteDest")]
                [Validation(Required=false)]
                public string RouteDest { get; set; }

                /// <summary>
                /// The source CIDR block of the policy-based route.
                /// </summary>
                [NameInMap("RouteSource")]
                [Validation(Required=false)]
                public string RouteSource { get; set; }

                /// <summary>
                /// The status of the policy-based route. Valid values:
                /// 
                /// *   **published**: advertised to the VPC route table.
                /// *   **normal**: not advertised to the VPC route table.
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// The ID of the VPN gateway.
                /// </summary>
                [NameInMap("VpnInstanceId")]
                [Validation(Required=false)]
                public string VpnInstanceId { get; set; }

                /// <summary>
                /// The weight of the policy-based route. Valid values:
                /// 
                /// *   **100**: The IPsec-VPN connection associated with the policy-based route serves as an active connection.
                /// *   **0**: The IPsec-VPN connection associated with the policy-based route serves as a standby connection.
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public int? Weight { get; set; }

            }

        }

    }

}
