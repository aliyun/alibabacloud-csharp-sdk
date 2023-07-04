// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListGatewayRouteTableEntriesResponseBody : TeaModel {
        /// <summary>
        /// The ID of the next hop.
        /// </summary>
        [NameInMap("GatewayRouteEntryModels")]
        [Validation(Required=false)]
        public List<ListGatewayRouteTableEntriesResponseBodyGatewayRouteEntryModels> GatewayRouteEntryModels { get; set; }
        public class ListGatewayRouteTableEntriesResponseBodyGatewayRouteEntryModels : TeaModel {
            /// <summary>
            /// The destination CIDR block of the route.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The information about the next hop.
            /// </summary>
            [NameInMap("DestinationCidrBlock")]
            [Validation(Required=false)]
            public string DestinationCidrBlock { get; set; }

            /// <summary>
            /// The ID of the next hop.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The type of the next hop. Valid values:
            /// 
            /// *   **EcsInstance**: an Elastic Compute Service (ECS) instance
            /// *   **NetworkInterface**: an elastic network interface (ENI)
            /// *   **Local**: a local next hop
            /// </summary>
            [NameInMap("NextHopId")]
            [Validation(Required=false)]
            public string NextHopId { get; set; }

            /// <summary>
            /// The name of the route.
            /// 
            /// The name must be 2 to 128 characters in length, and can contain letters, digits, periods (.), underscores (\_), and hyphens (-). It must start with a letter.
            /// </summary>
            [NameInMap("NextHopType")]
            [Validation(Required=false)]
            public string NextHopType { get; set; }

            /// <summary>
            /// The type of the next hop. Valid values:
            /// 
            /// *   **Instance** (default): an ECS instance
            /// *   **HaVip**: a high-availability virtual IP address (HAVIP)
            /// *   **VpnGateway**: a VPN gateway
            /// *   **NatGateway**: a NAT gateway
            /// *   **NetworkInterface**: a secondary ENI
            /// *   **RouterInterface**: a router interface
            /// *   **IPv6Gateway**: an IPv6 gateway
            /// *   **Attachment**: a transit router
            /// </summary>
            [NameInMap("NextHops")]
            [Validation(Required=false)]
            public List<ListGatewayRouteTableEntriesResponseBodyGatewayRouteEntryModelsNextHops> NextHops { get; set; }
            public class ListGatewayRouteTableEntriesResponseBodyGatewayRouteEntryModelsNextHops : TeaModel {
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public string Enabled { get; set; }

                /// <summary>
                /// The weight of the route.
                /// </summary>
                [NameInMap("NextHopId")]
                [Validation(Required=false)]
                public string NextHopId { get; set; }

                /// <summary>
                /// Indicates whether the route is available. Valid values:
                /// 
                /// *   **0**: unavailable
                /// *   **1**: available
                /// </summary>
                [NameInMap("NextHopType")]
                [Validation(Required=false)]
                public string NextHopType { get; set; }

                [NameInMap("Weight")]
                [Validation(Required=false)]
                public string Weight { get; set; }

            }

            /// <summary>
            /// The name of the route.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The details of the routes in the gateway route table.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The status of the route. Valid values:
        /// 
        /// *   **Pending**
        /// *   **Available**
        /// *   **Modifying**
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
