// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVcoRouteEntriesResponseBody : TeaModel {
        /// <summary>
        /// The number of the returned page.
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
        /// The number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// The list of routes.
        /// </summary>
        [NameInMap("VcoRouteEntries")]
        [Validation(Required=false)]
        public List<DescribeVcoRouteEntriesResponseBodyVcoRouteEntries> VcoRouteEntries { get; set; }
        public class DescribeVcoRouteEntriesResponseBodyVcoRouteEntries : TeaModel {
            /// <summary>
            /// The list of autonomous system (AS) numbers that the BGP route goes through.
            /// </summary>
            [NameInMap("AsPath")]
            [Validation(Required=false)]
            public string AsPath { get; set; }

            /// <summary>
            /// The community value carried by the BGP route.
            /// </summary>
            [NameInMap("Community")]
            [Validation(Required=false)]
            public string Community { get; set; }

            /// <summary>
            /// The timestamp when the route was created.
            /// 
            /// This value is a UNIX timestamp representing the number of milliseconds that have elapsed since the epoch time January 1, 1970, 00:00:00 UTC.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// The next hop of the route.
            /// </summary>
            [NameInMap("NextHop")]
            [Validation(Required=false)]
            public string NextHop { get; set; }

            /// <summary>
            /// The destination CIDR block of the route.
            /// </summary>
            [NameInMap("RouteDest")]
            [Validation(Required=false)]
            public string RouteDest { get; set; }

            /// <summary>
            /// The route type. Valid values:
            /// 
            /// *   **custom**: a destination-based route
            /// *   **bgp**: a BGP route
            /// </summary>
            [NameInMap("RouteEntryType")]
            [Validation(Required=false)]
            public string RouteEntryType { get; set; }

            /// <summary>
            /// The source of the BGP route. Valid values:
            /// 
            /// *   **CLOUD**: indicates that the current BGP route is learned by the IPsec-VPN connection from the transit router.
            /// *   **VPN_BGP**: indicates that the current BGP route is learned by the IPsec-VPN connection from the data center.
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// The status of the route.
            /// 
            /// *   **published**: indicates that the current route is advertised to the transit router.
            /// *   **Active**: indicates that the current BGP route is available.
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// The ID of the IPsec-VPN connection.
            /// </summary>
            [NameInMap("VpnConnectionId")]
            [Validation(Required=false)]
            public string VpnConnectionId { get; set; }

            /// <summary>
            /// The weight of the destination-based route. Valid values:
            /// 
            /// *   **0**: a low priority
            /// *   **100**: a high priority
            /// </summary>
            [NameInMap("Weight")]
            [Validation(Required=false)]
            public int? Weight { get; set; }

        }

    }

}
