// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeCenChildInstanceRouteEntriesResponseBody : TeaModel {
        /// <summary>
        /// The array of routes.
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
                /// The route maps that the routes match.
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
                        /// The ID of the region where the route map is applied.
                        /// </summary>
                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                        /// <summary>
                        /// The ID of the route map.
                        /// </summary>
                        [NameInMap("RouteMapId")]
                        [Validation(Required=false)]
                        public string RouteMapId { get; set; }

                    }

                }

                /// <summary>
                /// The community attributes of the routes.
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
                /// The array of conflicting routes.
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
                        /// The type of the peer network instance on which conflicting routes are found. 
                        /// 
                        /// - **VPC**
                        /// - **VBR**
                        /// - **CCN**
                        /// </summary>
                        [NameInMap("InstanceType")]
                        [Validation(Required=false)]
                        public string InstanceType { get; set; }

                        /// <summary>
                        /// The ID of the region where the peer network instance on which conflicting routes are found is deployed.
                        /// </summary>
                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                        /// <summary>
                        /// The cause of the route error. Valid values: 
                        /// 
                        /// - **conflict**: Two routes have the same destination CIDR block.
                        /// - **overflow**: The number of routes in the route table configured on another network instance reached the upper limit.
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
                /// The ID of the region where the instance specified as the next hop in the route belongs.
                /// </summary>
                [NameInMap("NextHopRegionId")]
                [Validation(Required=false)]
                public string NextHopRegionId { get; set; }

                /// <summary>
                /// The type of the instance specified as the next hop in the route. 
                /// 
                /// - **Instance**: ECS instance
                /// - **HaVip**: HAVIP
                /// - **RouterInterface**: router interface
                /// - **NetworkInterface**: ENI
                /// - **VpnGateway**: VPN gateway
                /// - **IPv6Gateway**: IPv6 gateway
                /// - **NatGateway**: NAT gateway
                /// - **Attachment**: network instance connection
                /// - **service**: cloud service
                /// - **VBR**: virtual border router
                /// - **CCN**: CCN instance
                /// - **VPC**: virtual private cloud
                /// - **local**: system route. No next hop is specified.
                /// - **TR**: transit router
                /// - **BlackHole**: blackhole route. No next hop is specified.
                /// - **EcRouterInterface**: router interface for Express Connect
                /// - **HealthCheck**: health check
                /// - **AS**: access gateway for CCN
                /// - **classic**: classic network-type instance
                /// - **GatewayEndpoint**: gateway endpoint
                /// - **CPE**: data center connected by VBRs
                /// </summary>
                [NameInMap("NextHopType")]
                [Validation(Required=false)]
                public string NextHopType { get; set; }

                /// <summary>
                /// Indicates whether the route is allowed to be advertised to or withdrawn from the CEN instance. Valid values:  
                /// 
                /// - **true**: The route is allowed to be advertised to or withdrawn from the CEN instance.
                /// - **false**: The route is not allowed to be advertised to or withdrawn from the CEN instance.
                /// </summary>
                [NameInMap("OperationalMode")]
                [Validation(Required=false)]
                public bool? OperationalMode { get; set; }

                /// <summary>
                /// Indicates whether the route is advertised to the CEN instance. Valid values: 
                /// 
                /// - **Published**: The route is advertised to the CEN instance.
                /// - **NonPublished**: The route is not advertised to the CEN instance.
                /// </summary>
                [NameInMap("PublishStatus")]
                [Validation(Required=false)]
                public string PublishStatus { get; set; }

                /// <summary>
                /// The ID of the route table.
                /// </summary>
                [NameInMap("RouteTableId")]
                [Validation(Required=false)]
                public string RouteTableId { get; set; }

                /// <summary>
                /// The status of the route. Valid values: 
                /// 
                /// - **Active**: The route is active.
                /// - **Candidate**: The route is a standby route.
                /// - **Rejected**: The route is rejected.
                /// - **Prohibited**: The route is prohibited.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The type of the route. Valid values: 
                /// 
                /// - **CEN**: route that is advertised through CEN
                /// - **System**: system route
                /// - **Custom**: custom route
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
