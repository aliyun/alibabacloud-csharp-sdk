// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeVpnRouteEntriesResponseBody : TeaModel {
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
        /// The list of route entries.
        /// </summary>
        [NameInMap("VpnRouteEntries")]
        [Validation(Required=false)]
        public DescribeVpnRouteEntriesResponseBodyVpnRouteEntries VpnRouteEntries { get; set; }
        public class DescribeVpnRouteEntriesResponseBodyVpnRouteEntries : TeaModel {
            [NameInMap("VpnRouteEntry")]
            [Validation(Required=false)]
            public List<DescribeVpnRouteEntriesResponseBodyVpnRouteEntriesVpnRouteEntry> VpnRouteEntry { get; set; }
            public class DescribeVpnRouteEntriesResponseBodyVpnRouteEntriesVpnRouteEntry : TeaModel {
                /// <summary>
                /// The AS path of the route entry.
                /// </summary>
                [NameInMap("AsPath")]
                [Validation(Required=false)]
                public string AsPath { get; set; }

                /// <summary>
                /// The community attributes of the route entry.
                /// </summary>
                [NameInMap("Community")]
                [Validation(Required=false)]
                public string Community { get; set; }

                /// <summary>
                /// The timestamp when the route entry was created.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                /// <summary>
                /// The next hop of the route entry.
                /// </summary>
                [NameInMap("NextHop")]
                [Validation(Required=false)]
                public string NextHop { get; set; }

                [NameInMap("NextHopTunnelId")]
                [Validation(Required=false)]
                public string NextHopTunnelId { get; set; }

                /// <summary>
                /// The destination CIDR block of the route entry.
                /// </summary>
                [NameInMap("RouteDest")]
                [Validation(Required=false)]
                public string RouteDest { get; set; }

                /// <summary>
                /// The type of the route entry. Valid values:
                /// 
                /// *   **Custom**: custom
                /// *   **System**: system
                /// </summary>
                [NameInMap("RouteEntryType")]
                [Validation(Required=false)]
                public string RouteEntryType { get; set; }

                /// <summary>
                /// The source CIDR block of the route entry.
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                /// <summary>
                /// The status of the route entry. Valid values:
                /// 
                /// *   **published**: advertised
                /// *   **normal**: not advertised
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
                /// The weight of the route entry. Valid values: **0** and **100**.
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

}
