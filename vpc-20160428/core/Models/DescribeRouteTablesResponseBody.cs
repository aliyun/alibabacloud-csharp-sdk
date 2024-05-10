// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeRouteTablesResponseBody : TeaModel {
        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The detailed information about the route tables.
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
                /// 
                /// The time is displayed in the `YYYY-MM-DDThh:mm:ssZ` format in UTC.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// The ID of the resource group to which the route table belongs.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The information about the route.
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
                        /// The description of the route. The description must be 2 to 256 characters in length. It must start with a letter but cannot start with `http://` or `https://`.
                        /// </summary>
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// The destination CIDR block of the route. The destination CIDR block supports IPv4 and IPv6. Make sure that the destination CIDR block meets the following requirements:
                        /// 
                        /// *   The destination CIDR block is not 100.64.0.0/10 or a subset of 100.64.0.0/10.
                        /// *   The destination CIDR block of each route in the route table is unique.
                        /// </summary>
                        [NameInMap("DestinationCidrBlock")]
                        [Validation(Required=false)]
                        public string DestinationCidrBlock { get; set; }

                        /// <summary>
                        /// The ID of the instance associated with the next hop.
                        /// </summary>
                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                        /// <summary>
                        /// The type of the next hop. Valid values:
                        /// 
                        /// *   **Instance** (default): an Elastic Compute Service (ECS) instance
                        /// *   **HaVip**: a high-availability virtual IP address (HAVIP).
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
                        /// The information about the next hop.
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
                                /// Indicates whether the route is available. Valid values:
                                /// 
                                /// *   **0**: unavailable
                                /// *   **1**: available
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
                                /// The type of the next hop. Valid values:
                                /// 
                                /// *   **Instance**: an ECS instance
                                /// *   **HaVip**: an HAVIP
                                /// *   **VpnGateway**: a VPN gateway
                                /// *   **NatGateway**: a NAT gateway
                                /// *   **NetworkInterface**: a secondary ENI
                                /// *   **RouterInterface**: a router interface
                                /// *   **IPv6Gateway**: an IPv6 gateway
                                /// *   **Attachment**: a transit router
                                /// </summary>
                                [NameInMap("NextHopType")]
                                [Validation(Required=false)]
                                public string NextHopType { get; set; }

                                /// <summary>
                                /// The weight of the route.
                                /// </summary>
                                [NameInMap("Weight")]
                                [Validation(Required=false)]
                                public int? Weight { get; set; }

                            }

                        }

                        /// <summary>
                        /// The ID of the route.
                        /// </summary>
                        [NameInMap("RouteEntryId")]
                        [Validation(Required=false)]
                        public string RouteEntryId { get; set; }

                        /// <summary>
                        /// The route name.
                        /// 
                        /// The name must be 2 to 128 characters in length, and can contain letters, digits, periods (.), underscores (_), and hyphens (-).
                        /// </summary>
                        [NameInMap("RouteEntryName")]
                        [Validation(Required=false)]
                        public string RouteEntryName { get; set; }

                        /// <summary>
                        /// The route table ID.
                        /// </summary>
                        [NameInMap("RouteTableId")]
                        [Validation(Required=false)]
                        public string RouteTableId { get; set; }

                        /// <summary>
                        /// The route status. Valid values:
                        /// 
                        /// *   **Pending**
                        /// *   **Available**
                        /// *   **Modifying**
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

                /// <summary>
                /// The ID of the route table.
                /// </summary>
                [NameInMap("RouteTableId")]
                [Validation(Required=false)]
                public string RouteTableId { get; set; }

                /// <summary>
                /// The type of the route table. Valid values:
                /// 
                /// *   **Custom**
                /// *   **System**
                /// </summary>
                [NameInMap("RouteTableType")]
                [Validation(Required=false)]
                public string RouteTableType { get; set; }

                /// <summary>
                /// The status of the route table. Valid values:
                /// 
                /// *   **Pending**
                /// *   **Available**
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The vRouter ID.
                /// </summary>
                [NameInMap("VRouterId")]
                [Validation(Required=false)]
                public string VRouterId { get; set; }

                /// <summary>
                /// The vSwitch ID.
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

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
