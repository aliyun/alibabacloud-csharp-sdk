// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribePublishedRouteEntriesResponseBody : TeaModel {
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
        /// A list of routes.
        /// </summary>
        [NameInMap("PublishedRouteEntries")]
        [Validation(Required=false)]
        public DescribePublishedRouteEntriesResponseBodyPublishedRouteEntries PublishedRouteEntries { get; set; }
        public class DescribePublishedRouteEntriesResponseBodyPublishedRouteEntries : TeaModel {
            [NameInMap("PublishedRouteEntry")]
            [Validation(Required=false)]
            public List<DescribePublishedRouteEntriesResponseBodyPublishedRouteEntriesPublishedRouteEntry> PublishedRouteEntry { get; set; }
            public class DescribePublishedRouteEntriesResponseBodyPublishedRouteEntriesPublishedRouteEntry : TeaModel {
                /// <summary>
                /// The ID of the route table configured on the network instance.
                /// </summary>
                [NameInMap("ChildInstanceRouteTableId")]
                [Validation(Required=false)]
                public string ChildInstanceRouteTableId { get; set; }

                /// <summary>
                /// A list of conflicting routes.
                /// </summary>
                [NameInMap("Conflicts")]
                [Validation(Required=false)]
                public DescribePublishedRouteEntriesResponseBodyPublishedRouteEntriesPublishedRouteEntryConflicts Conflicts { get; set; }
                public class DescribePublishedRouteEntriesResponseBodyPublishedRouteEntriesPublishedRouteEntryConflicts : TeaModel {
                    [NameInMap("Conflict")]
                    [Validation(Required=false)]
                    public List<DescribePublishedRouteEntriesResponseBodyPublishedRouteEntriesPublishedRouteEntryConflictsConflict> Conflict { get; set; }
                    public class DescribePublishedRouteEntriesResponseBodyPublishedRouteEntriesPublishedRouteEntryConflictsConflict : TeaModel {
                        /// <summary>
                        /// The destination CIDR block of the conflicting route.
                        /// </summary>
                        [NameInMap("DestinationCidrBlock")]
                        [Validation(Required=false)]
                        public string DestinationCidrBlock { get; set; }

                        /// <summary>
                        /// The ID of the peer network instance on which conflicting routes are found.
                        /// </summary>
                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                        /// <summary>
                        /// The type of the peer network instance on which the conflicting routes are found. Valid values:
                        /// 
                        /// *   **VPC**: VPC
                        /// *   **VBR**: VBR
                        /// *   **CCN**: CCN instance
                        /// </summary>
                        [NameInMap("InstanceType")]
                        [Validation(Required=false)]
                        public string InstanceType { get; set; }

                        /// <summary>
                        /// The ID of the region where the peer network instance on which the conflicting routes are found is deployed.
                        /// </summary>
                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                        /// <summary>
                        /// The cause of the route confliction. Valid values:
                        /// 
                        /// *   **conflict**: The routes have the same destination CIDR block.
                        /// *   **overflow**: The number of routes in the route table configured on another network instance has reached the upper limit.
                        /// </summary>
                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                    }

                }

                /// <summary>
                /// The destination CIDR block of the route.
                /// </summary>
                [NameInMap("DestinationCidrBlock")]
                [Validation(Required=false)]
                public string DestinationCidrBlock { get; set; }

                /// <summary>
                /// The ID of the instance specified as the next hop in the route.
                /// </summary>
                [NameInMap("NextHopId")]
                [Validation(Required=false)]
                public string NextHopId { get; set; }

                /// <summary>
                /// The type of the instance specified as the next hop in the route.
                /// 
                /// *   **Instance**: ECS instance
                /// *   **HaVip**: high-availability virtual IP address (HAVIP).
                /// *   **RouterInterface**: router interface.
                /// *   **NetworkInterface**: elastic network interface (ENI).
                /// *   **VpnGateway**: VPN gateway.
                /// *   **IPv6Gateway**: IPv6 gateway.
                /// *   **NatGateway**: NAT gateway.
                /// *   **Attachment**: network instance connection
                /// *   **service**: cloud service
                /// *   **VBR**: VBR
                /// *   **CCN**: CCN instance
                /// *   **VPC**: VPC
                /// *   **local**: system route. No next hop is specified.
                /// *   **TR**: transit router
                /// *   \*\*BlackHole\*\*: blackhole route. No next hop is specified.
                /// *   \*\*EcRouterInterface\*\*: router interface for Express Connect
                /// *   **HealthCheck**: health check
                /// *   **AS**: access gateway for CCN
                /// *   **classicLink**: classic network-type instance
                /// *   **GatewayEndpoint**: gateway endpoint
                /// *   **CPE**: data center connected to the VBR
                /// </summary>
                [NameInMap("NextHopType")]
                [Validation(Required=false)]
                public string NextHopType { get; set; }

                /// <summary>
                /// Indicates whether the route is allowed to be advertised to or withdrawn from the CEN instance. Valid values:
                /// 
                /// *   **true**: The route is allowed to be advertised to or withdrawn from the CEN instance.
                /// *   **false**: The route is not allowed to be advertised to or withdrawn from the CEN instance.
                /// </summary>
                [NameInMap("OperationalMode")]
                [Validation(Required=false)]
                public bool? OperationalMode { get; set; }

                /// <summary>
                /// Indicates whether the route is advertised to the CEN instance. Valid values:
                /// 
                /// *   **Published**: The route is advertised to the CEN instance.
                /// *   **NonPublished**: The route is not advertised to the CEN instance.
                /// </summary>
                [NameInMap("PublishStatus")]
                [Validation(Required=false)]
                public string PublishStatus { get; set; }

                /// <summary>
                /// The type of the route. Valid values:
                /// 
                /// *   **CEN**: route that is advertised through CEN
                /// *   **System**: system route
                /// *   **Custom**: custom route
                /// </summary>
                [NameInMap("RouteType")]
                [Validation(Required=false)]
                public string RouteType { get; set; }

            }

        }

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

    }

}
