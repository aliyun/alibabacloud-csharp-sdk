// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeRouteTablesResponseBody : TeaModel {
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
        /// Details about the route table.
        /// </summary>
        [NameInMap("RouteTables")]
        [Validation(Required=false)]
        public DescribeRouteTablesResponseBodyRouteTables RouteTables { get; set; }
        public class DescribeRouteTablesResponseBodyRouteTables : TeaModel {
            [NameInMap("RouteTable")]
            [Validation(Required=false)]
            public List<DescribeRouteTablesResponseBodyRouteTablesRouteTable> RouteTable { get; set; }
            public class DescribeRouteTablesResponseBodyRouteTablesRouteTable : TeaModel {
                /// <summary>
                /// The time when the route table was created.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The ID of the resource group to which the elastic IP address (EIP) belongs.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// Detailed information about the route entry.
                /// </summary>
                [NameInMap("RouteEntrys")]
                [Validation(Required=false)]
                public DescribeRouteTablesResponseBodyRouteTablesRouteTableRouteEntrys RouteEntrys { get; set; }
                public class DescribeRouteTablesResponseBodyRouteTablesRouteTableRouteEntrys : TeaModel {
                    [NameInMap("RouteEntry")]
                    [Validation(Required=false)]
                    public List<DescribeRouteTablesResponseBodyRouteTablesRouteTableRouteEntrysRouteEntry> RouteEntry { get; set; }
                    public class DescribeRouteTablesResponseBodyRouteTablesRouteTableRouteEntrysRouteEntry : TeaModel {
                        /// <summary>
                        /// The description of the router entry.
                        /// </summary>
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// The destination CIDR block of the route entry.
                        /// </summary>
                        [NameInMap("DestinationCidrBlock")]
                        [Validation(Required=false)]
                        public string DestinationCidrBlock { get; set; }

                        /// <summary>
                        /// The ID of the next hop.
                        /// </summary>
                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                        /// <summary>
                        /// The type of the route.
                        /// 
                        /// *   **local**: a vSwitch route
                        /// *   **service**: a cloud service route
                        /// *   **classicLink**: a route added by the system after ClassicLink is enabled
                        /// </summary>
                        [NameInMap("NextHopType")]
                        [Validation(Required=false)]
                        public string NextHopType { get; set; }

                        /// <summary>
                        /// The list of next hops of equal-cost multi-path routing (ECMP) routes.
                        /// </summary>
                        [NameInMap("NextHops")]
                        [Validation(Required=false)]
                        public DescribeRouteTablesResponseBodyRouteTablesRouteTableRouteEntrysRouteEntryNextHops NextHops { get; set; }
                        public class DescribeRouteTablesResponseBodyRouteTablesRouteTableRouteEntrysRouteEntryNextHops : TeaModel {
                            [NameInMap("NextHop")]
                            [Validation(Required=false)]
                            public List<DescribeRouteTablesResponseBodyRouteTablesRouteTableRouteEntrysRouteEntryNextHopsNextHop> NextHop { get; set; }
                            public class DescribeRouteTablesResponseBodyRouteTablesRouteTableRouteEntrysRouteEntryNextHopsNextHop : TeaModel {
                                /// <summary>
                                /// Indicates whether the next hop feature is enabled.
                                /// 
                                /// *   **0**: The next hop feature is disabled.
                                /// *   **1**: The next hop feature is enabled.
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
                                /// The type of the next hop.
                                /// 
                                /// *   **Instance**: The next hop is an Elastic Compute Service (ECS) instance.
                                /// *   **HaVip**: The next hop is a high-availability virtual IP address (HAVIP).
                                /// *   **VpnGateway**: The next hop is a VPN gateway.
                                /// *   **NatGateway**: The next hop is a NAT gateway.
                                /// *   **NetworkInterface**: The next hop is a secondary elastic network interface (ENI).
                                /// *   **RouterInterface**: The next hop is a router interface.
                                /// *   **IPv6Gateway**: The next hop is an IPv6 gateway.
                                /// </summary>
                                [NameInMap("NextHopType")]
                                [Validation(Required=false)]
                                public string NextHopType { get; set; }

                                /// <summary>
                                /// The route weight of the next hop.
                                /// </summary>
                                [NameInMap("Weight")]
                                [Validation(Required=false)]
                                public int? Weight { get; set; }

                            }

                        }

                        [NameInMap("RouteEntryId")]
                        [Validation(Required=false)]
                        public string RouteEntryId { get; set; }

                        /// <summary>
                        /// The name of the route entry.
                        /// </summary>
                        [NameInMap("RouteEntryName")]
                        [Validation(Required=false)]
                        public string RouteEntryName { get; set; }

                        /// <summary>
                        /// The ID of the route table to which the route entry belongs.
                        /// </summary>
                        [NameInMap("RouteTableId")]
                        [Validation(Required=false)]
                        public string RouteTableId { get; set; }

                        /// <summary>
                        /// The state of the route entry.
                        /// 
                        /// *   **Pending**: The route entry is being configured.
                        /// *   **Available**: The route entry is available.
                        /// *   **Modifying**: The route entry is being modified.
                        /// </summary>
                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                        /// <summary>
                        /// The type of the route entry.
                        /// 
                        /// *   **System** : a system route entry
                        /// *   **Custom**: a custom route entry
                        /// *   **BGP**: a BGP route entry
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                }

                /// <summary>
                /// The ID of the route table to which the route entry belongs.
                /// </summary>
                [NameInMap("RouteTableId")]
                [Validation(Required=false)]
                public string RouteTableId { get; set; }

                [NameInMap("RouteTableType")]
                [Validation(Required=false)]
                public string RouteTableType { get; set; }

                /// <summary>
                /// The state of the route table.
                /// 
                /// *   **Pending**: The route table is being configured.
                /// *   **Available**: The route table is available.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The ID of the vRouter.
                /// </summary>
                [NameInMap("VRouterId")]
                [Validation(Required=false)]
                public string VRouterId { get; set; }

                /// <summary>
                /// The list of vSwitches that belong to the VPC.
                /// </summary>
                [NameInMap("VSwitchIds")]
                [Validation(Required=false)]
                public DescribeRouteTablesResponseBodyRouteTablesRouteTableVSwitchIds VSwitchIds { get; set; }
                public class DescribeRouteTablesResponseBodyRouteTablesRouteTableVSwitchIds : TeaModel {
                    [NameInMap("VSwitchId")]
                    [Validation(Required=false)]
                    public List<string> VSwitchId { get; set; }

                }

            }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
