// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeRouteEntryListResponseBody : TeaModel {
        /// <summary>
        /// A pagination token. It can be used in the next request to retrieve a new page of results. Valid values:
        /// 
        /// *   If no value is returned for **NextToken**, no next queries are sent.
        /// *   If a value is returned for **NextToken**, the value is used to retrieve a new page of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the route.
        /// </summary>
        [NameInMap("RouteEntrys")]
        [Validation(Required=false)]
        public DescribeRouteEntryListResponseBodyRouteEntrys RouteEntrys { get; set; }
        public class DescribeRouteEntryListResponseBodyRouteEntrys : TeaModel {
            [NameInMap("RouteEntry")]
            [Validation(Required=false)]
            public List<DescribeRouteEntryListResponseBodyRouteEntrysRouteEntry> RouteEntry { get; set; }
            public class DescribeRouteEntryListResponseBodyRouteEntrysRouteEntry : TeaModel {
                /// <summary>
                /// The description of the route.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The destination CIDR block of the route.
                /// </summary>
                [NameInMap("DestinationCidrBlock")]
                [Validation(Required=false)]
                public string DestinationCidrBlock { get; set; }

                /// <summary>
                /// The time when the route was modified. Specify the time in the `YYYY-MM-DDThh:mm:ssZ` format. The time must be in UTC.
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// The IP version. Valid values:
                /// 
                /// *   **ipv4**
                /// *   **ipv6**
                /// </summary>
                [NameInMap("IpVersion")]
                [Validation(Required=false)]
                public string IpVersion { get; set; }

                /// <summary>
                /// The information about the next hops.
                /// </summary>
                [NameInMap("NextHops")]
                [Validation(Required=false)]
                public DescribeRouteEntryListResponseBodyRouteEntrysRouteEntryNextHops NextHops { get; set; }
                public class DescribeRouteEntryListResponseBodyRouteEntrysRouteEntryNextHops : TeaModel {
                    [NameInMap("NextHop")]
                    [Validation(Required=false)]
                    public List<DescribeRouteEntryListResponseBodyRouteEntrysRouteEntryNextHopsNextHop> NextHop { get; set; }
                    public class DescribeRouteEntryListResponseBodyRouteEntrysRouteEntryNextHopsNextHop : TeaModel {
                        /// <summary>
                        /// Indicates whether the route is available. Valid values:
                        /// 
                        /// *   **0**: unavailable
                        /// *   **1**: available
                        /// 
                        /// >  This parameter is returned when the next hop type is set to **RouterInterface**.
                        /// </summary>
                        [NameInMap("Enabled")]
                        [Validation(Required=false)]
                        public int? Enabled { get; set; }

                        /// <summary>
                        /// The ID of the next hop.
                        /// </summary>
                        [NameInMap("NextHopId")]
                        [Validation(Required=false)]
                        public string NextHopId { get; set; }

                        /// <summary>
                        /// The ID of the region where the next hop is deployed.
                        /// 
                        /// >  This parameter is returned when the next hop type is set to **RouterInterface**.
                        /// </summary>
                        [NameInMap("NextHopRegionId")]
                        [Validation(Required=false)]
                        public string NextHopRegionId { get; set; }

                        /// <summary>
                        /// The information about the next hop.
                        /// </summary>
                        [NameInMap("NextHopRelatedInfo")]
                        [Validation(Required=false)]
                        public DescribeRouteEntryListResponseBodyRouteEntrysRouteEntryNextHopsNextHopNextHopRelatedInfo NextHopRelatedInfo { get; set; }
                        public class DescribeRouteEntryListResponseBodyRouteEntrysRouteEntryNextHopsNextHopNextHopRelatedInfo : TeaModel {
                            /// <summary>
                            /// The ID of the instance that is associated with the next hop.
                            /// </summary>
                            [NameInMap("InstanceId")]
                            [Validation(Required=false)]
                            public string InstanceId { get; set; }

                            /// <summary>
                            /// The type of the instance associated with the next hop. Valid values:
                            /// 
                            /// *   **VPC**: a VPC
                            /// *   **VBR**: a VBR
                            /// *   **PCONN**: an Express Connect circuit
                            /// </summary>
                            [NameInMap("InstanceType")]
                            [Validation(Required=false)]
                            public string InstanceType { get; set; }

                            /// <summary>
                            /// The region ID of the instance associated with the next hop. Valid values:
                            /// </summary>
                            [NameInMap("RegionId")]
                            [Validation(Required=false)]
                            public string RegionId { get; set; }

                        }

                        /// <summary>
                        /// The type of the next hop. Valid values:
                        /// 
                        /// *   **Instance**: an Elastic Compute Service (ECS) instance
                        /// *   **HaVip**: a high-availability virtual IP address (HAVIP)
                        /// *   **VpnGateway**: a VPN gateway
                        /// *   **NatGateway**: a NAT gateway
                        /// *   **NetworkInterface**: a secondary elastic network interface (ENI)
                        /// *   **RouterInterface**: a router interface
                        /// *   **IPv6Gateway**: an IPv6 gateway
                        /// *   **Attachment**: a transit router
                        /// </summary>
                        [NameInMap("NextHopType")]
                        [Validation(Required=false)]
                        public string NextHopType { get; set; }

                        /// <summary>
                        /// The weight of the route.
                        /// 
                        /// >  This parameter is returned when the next hop type is set to **RouterInterface**.
                        /// </summary>
                        [NameInMap("Weight")]
                        [Validation(Required=false)]
                        public int? Weight { get; set; }

                    }

                }

                /// <summary>
                /// The route origin. Valid values:
                /// * **RoutePropagation**: The route is created by a dynamic propagation source.
                /// * **SystemCreate**: The route is created by the system.
                /// * **CustomCreate**: The route is created by a user.
                /// </summary>
                [NameInMap("Origin")]
                [Validation(Required=false)]
                public string Origin { get; set; }

                /// <summary>
                /// The ID of the route.
                /// </summary>
                [NameInMap("RouteEntryId")]
                [Validation(Required=false)]
                public string RouteEntryId { get; set; }

                /// <summary>
                /// The route name.
                /// </summary>
                [NameInMap("RouteEntryName")]
                [Validation(Required=false)]
                public string RouteEntryName { get; set; }

                /// <summary>
                /// The ID of the route table.
                /// </summary>
                [NameInMap("RouteTableId")]
                [Validation(Required=false)]
                public string RouteTableId { get; set; }

                /// <summary>
                /// Indicates whether the route is hosted. If the parameter is empty, the route is not hosted.
                /// 
                /// If **TR** is returned, the route is hosted by a transit router.
                /// </summary>
                [NameInMap("ServiceType")]
                [Validation(Required=false)]
                public string ServiceType { get; set; }

                /// <summary>
                /// The route status. Valid values:
                /// 
                /// *   **Pending**
                /// *   **Available**
                /// *   **Modifying**: The Internet Shared Bandwidth instance is being modified.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The route type. Valid values:
                /// 
                /// *   **Custom**
                /// *   **System**
                /// *   **BGP**
                /// *   **CEN**
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

    }

}
