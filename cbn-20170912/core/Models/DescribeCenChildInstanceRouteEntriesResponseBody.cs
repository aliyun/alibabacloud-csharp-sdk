// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeCenChildInstanceRouteEntriesResponseBody : TeaModel {
        /// <summary>
        /// The information about the route.
        /// </summary>
        [NameInMap("CenRouteEntries")]
        [Validation(Required=false)]
        public DescribeCenChildInstanceRouteEntriesResponseBodyCenRouteEntries CenRouteEntries { get; set; }
        public class DescribeCenChildInstanceRouteEntriesResponseBodyCenRouteEntries : TeaModel {
            [NameInMap("CenRouteEntry")]
            [Validation(Required=false)]
            public List<DescribeCenChildInstanceRouteEntriesResponseBodyCenRouteEntriesCenRouteEntry> CenRouteEntry { get; set; }
            public class DescribeCenChildInstanceRouteEntriesResponseBodyCenRouteEntriesCenRouteEntry : TeaModel {
                /// <summary>
                /// The AS paths of the routes.
                /// </summary>
                [NameInMap("AsPaths")]
                [Validation(Required=false)]
                public DescribeCenChildInstanceRouteEntriesResponseBodyCenRouteEntriesCenRouteEntryAsPaths AsPaths { get; set; }
                public class DescribeCenChildInstanceRouteEntriesResponseBodyCenRouteEntriesCenRouteEntryAsPaths : TeaModel {
                    [NameInMap("AsPath")]
                    [Validation(Required=false)]
                    public List<string> AsPath { get; set; }

                }

                /// <summary>
                /// The routing policy that the routes match.
                /// </summary>
                [NameInMap("CenRouteMapRecords")]
                [Validation(Required=false)]
                public DescribeCenChildInstanceRouteEntriesResponseBodyCenRouteEntriesCenRouteEntryCenRouteMapRecords CenRouteMapRecords { get; set; }
                public class DescribeCenChildInstanceRouteEntriesResponseBodyCenRouteEntriesCenRouteEntryCenRouteMapRecords : TeaModel {
                    [NameInMap("CenRouteMapRecord")]
                    [Validation(Required=false)]
                    public List<DescribeCenChildInstanceRouteEntriesResponseBodyCenRouteEntriesCenRouteEntryCenRouteMapRecordsCenRouteMapRecord> CenRouteMapRecord { get; set; }
                    public class DescribeCenChildInstanceRouteEntriesResponseBodyCenRouteEntriesCenRouteEntryCenRouteMapRecordsCenRouteMapRecord : TeaModel {
                        /// <summary>
                        /// The region ID of the routing policy.
                        /// </summary>
                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                        /// <summary>
                        /// The routing policy ID.
                        /// </summary>
                        [NameInMap("RouteMapId")]
                        [Validation(Required=false)]
                        public string RouteMapId { get; set; }

                    }

                }

                /// <summary>
                /// The community attributes of the route entries.
                /// </summary>
                [NameInMap("Communities")]
                [Validation(Required=false)]
                public DescribeCenChildInstanceRouteEntriesResponseBodyCenRouteEntriesCenRouteEntryCommunities Communities { get; set; }
                public class DescribeCenChildInstanceRouteEntriesResponseBodyCenRouteEntriesCenRouteEntryCommunities : TeaModel {
                    [NameInMap("Community")]
                    [Validation(Required=false)]
                    public List<string> Community { get; set; }

                }

                /// <summary>
                /// A list of overlapping routes.
                /// </summary>
                [NameInMap("Conflicts")]
                [Validation(Required=false)]
                public DescribeCenChildInstanceRouteEntriesResponseBodyCenRouteEntriesCenRouteEntryConflicts Conflicts { get; set; }
                public class DescribeCenChildInstanceRouteEntriesResponseBodyCenRouteEntriesCenRouteEntryConflicts : TeaModel {
                    [NameInMap("Conflict")]
                    [Validation(Required=false)]
                    public List<DescribeCenChildInstanceRouteEntriesResponseBodyCenRouteEntriesCenRouteEntryConflictsConflict> Conflict { get; set; }
                    public class DescribeCenChildInstanceRouteEntriesResponseBodyCenRouteEntriesCenRouteEntryConflictsConflict : TeaModel {
                        /// <summary>
                        /// The destination CIDR block of the overlapping route.
                        /// </summary>
                        [NameInMap("DestinationCidrBlock")]
                        [Validation(Required=false)]
                        public string DestinationCidrBlock { get; set; }

                        /// <summary>
                        /// The ID of the peer network instance on which the overlapping routes are found.
                        /// </summary>
                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                        /// <summary>
                        /// The type of the peer network instance on which the overlapping routes are found. Valid values:
                        /// 
                        /// *   **VPC**
                        /// *   **VBR**
                        /// *   **CCN**
                        /// </summary>
                        [NameInMap("InstanceType")]
                        [Validation(Required=false)]
                        public string InstanceType { get; set; }

                        /// <summary>
                        /// The region ID of the peer network instance on which the overlapping routes are found.
                        /// </summary>
                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                        /// <summary>
                        /// The cause of the route error. Valid values:
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
                [NameInMap("NextHopInstanceId")]
                [Validation(Required=false)]
                public string NextHopInstanceId { get; set; }

                /// <summary>
                /// The region ID of the instance specified as the next hop in the route.
                /// </summary>
                [NameInMap("NextHopRegionId")]
                [Validation(Required=false)]
                public string NextHopRegionId { get; set; }

                /// <summary>
                /// The type of the instance specified as the next hop in the route. Valid values:
                /// 
                /// *   **Instance**: an ECS instance
                /// *   **HaVip**: an HAVIP
                /// *   **RouterInterface**: a router interface
                /// *   **NetworkInterface**: an ENI
                /// *   **VpnGateway**: a VPN gateway
                /// *   **IPv6Gateway**: an IPv6 gateway
                /// *   **Ipv4Gateway**: an IPv4 gateway
                /// *   **NatGateway**: a NAT gateway
                /// *   **Attachment**: a network instance connection
                /// *   **service**: a cloud service
                /// *   **VBR**: a VBR
                /// *   **CCN**: a CCN instance
                /// *   **VPC**: a VPC
                /// *   **local**: a system route (no next hop is specified)
                /// *   **TR**: a transit router
                /// *   **BlackHole**: a blackhole route (no next hop is specified)
                /// *   **EcRouterInterface**: a router interface for Express Connect
                /// *   **HealthCheck**: a health check
                /// *   **AS**: an access gateway for CCN
                /// *   **classic**: a classic network-type instance
                /// *   **GatewayEndpoint**: a gateway endpoint
                /// *   **CPE**: a data center connected to a VBR
                /// </summary>
                [NameInMap("NextHopType")]
                [Validation(Required=false)]
                public string NextHopType { get; set; }

                /// <summary>
                /// Indicates whether the route is allowed to be advertised to or withdrawn from the CEN instance. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// </summary>
                [NameInMap("OperationalMode")]
                [Validation(Required=false)]
                public bool? OperationalMode { get; set; }

                /// <summary>
                /// Indicates whether the route is advertised to the CEN instance. Valid values:
                /// 
                /// *   **Published**
                /// *   **NonPublished**
                /// </summary>
                [NameInMap("PublishStatus")]
                [Validation(Required=false)]
                public string PublishStatus { get; set; }

                /// <summary>
                /// The route table ID.
                /// </summary>
                [NameInMap("RouteTableId")]
                [Validation(Required=false)]
                public string RouteTableId { get; set; }

                /// <summary>
                /// The route status. Valid values:
                /// 
                /// *   **Active**: available routes
                /// *   **Candidate**: standby routes
                /// *   **Rejected**: rejected routes
                /// *   **Prohibited**: prohibited routes
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The route type. Valid values:
                /// 
                /// *   **CEN**: route that is advertised through CEN
                /// *   **System**: system route
                /// *   **Custom**: custom route
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

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

    }

}
