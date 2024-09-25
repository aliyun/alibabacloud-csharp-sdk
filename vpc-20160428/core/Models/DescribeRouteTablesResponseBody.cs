// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeRouteTablesResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DC668356-BCB4-42FD-9BC3-FA2B2E04B634</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The detailed information about the route tables.</para>
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
                /// <para>The time when the route table was created.</para>
                /// <para>The time is displayed in the <c>YYYY-MM-DDThh:mm:ssZ</c> format in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2017-08-22T10:40:25Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The ID of the resource group to which the route table belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-acfmxazb4ph****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The information about the route.</para>
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
                        /// <para>The description of the route. The description must be 2 to 256 characters in length. It must start with a letter but cannot start with <c>http://</c> or <c>https://</c>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>RouteEntryDescription</para>
                        /// </summary>
                        [NameInMap("Description")]
                        [Validation(Required=false)]
                        public string Description { get; set; }

                        /// <summary>
                        /// <para>The destination CIDR block of the route. The destination CIDR block supports IPv4 and IPv6. Make sure that the destination CIDR block meets the following requirements:</para>
                        /// <list type="bullet">
                        /// <item><description>The destination CIDR block is not 100.64.0.0/10 or a subset of 100.64.0.0/10.</description></item>
                        /// <item><description>The destination CIDR block of each route in the route table is unique.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>192.168.0.1/24</para>
                        /// </summary>
                        [NameInMap("DestinationCidrBlock")]
                        [Validation(Required=false)]
                        public string DestinationCidrBlock { get; set; }

                        /// <summary>
                        /// <para>The ID of the instance associated with the next hop.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ri-2zeo3xzyf38r4urzd****</para>
                        /// </summary>
                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                        /// <summary>
                        /// <para>The type of the next hop. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>Instance</b> (default): an Elastic Compute Service (ECS) instance</description></item>
                        /// <item><description><b>HaVip</b>: a high-availability virtual IP address (HAVIP).</description></item>
                        /// <item><description><b>VpnGateway</b>: a VPN gateway</description></item>
                        /// <item><description><b>NatGateway</b>: a NAT gateway</description></item>
                        /// <item><description><b>NetworkInterface</b>: a secondary elastic network interface (ENI)</description></item>
                        /// <item><description><b>RouterInterface</b>: a router interface</description></item>
                        /// <item><description><b>IPv6Gateway</b>: an IPv6 gateway</description></item>
                        /// <item><description><b>Attachment</b>: a transit router</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>local</para>
                        /// </summary>
                        [NameInMap("NextHopType")]
                        [Validation(Required=false)]
                        public string NextHopType { get; set; }

                        /// <summary>
                        /// <para>The information about the next hop.</para>
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
                                /// <para>Indicates whether the route is available. Valid values:</para>
                                /// <list type="bullet">
                                /// <item><description><b>0</b>: unavailable</description></item>
                                /// <item><description><b>1</b>: available</description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>0</para>
                                /// </summary>
                                [NameInMap("Enabled")]
                                [Validation(Required=false)]
                                public int? Enabled { get; set; }

                                /// <summary>
                                /// <para>The ID of the next hop.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>ri-2zeo3xzyf38r4urzdpvqw</para>
                                /// </summary>
                                [NameInMap("NextHopId")]
                                [Validation(Required=false)]
                                public string NextHopId { get; set; }

                                /// <summary>
                                /// <para>The type of the next hop. Valid values:</para>
                                /// <list type="bullet">
                                /// <item><description><b>Instance</b>: an ECS instance</description></item>
                                /// <item><description><b>HaVip</b>: an HAVIP</description></item>
                                /// <item><description><b>VpnGateway</b>: a VPN gateway</description></item>
                                /// <item><description><b>NatGateway</b>: a NAT gateway</description></item>
                                /// <item><description><b>NetworkInterface</b>: a secondary ENI</description></item>
                                /// <item><description><b>RouterInterface</b>: a router interface</description></item>
                                /// <item><description><b>IPv6Gateway</b>: an IPv6 gateway</description></item>
                                /// <item><description><b>Attachment</b>: a transit router</description></item>
                                /// </list>
                                /// 
                                /// <b>Example:</b>
                                /// <para>HaVip</para>
                                /// </summary>
                                [NameInMap("NextHopType")]
                                [Validation(Required=false)]
                                public string NextHopType { get; set; }

                                /// <summary>
                                /// <para>The weight of the route.</para>
                                /// 
                                /// <b>Example:</b>
                                /// <para>80</para>
                                /// </summary>
                                [NameInMap("Weight")]
                                [Validation(Required=false)]
                                public int? Weight { get; set; }

                            }

                        }

                        /// <summary>
                        /// <para>The ID of the route.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>rte-bp1mnnr2al0naomnpxxx</para>
                        /// </summary>
                        [NameInMap("RouteEntryId")]
                        [Validation(Required=false)]
                        public string RouteEntryId { get; set; }

                        /// <summary>
                        /// <para>The route name.</para>
                        /// <para>The name must be 2 to 128 characters in length, and can contain letters, digits, periods (.), underscores (_), and hyphens (-).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("RouteEntryName")]
                        [Validation(Required=false)]
                        public string RouteEntryName { get; set; }

                        /// <summary>
                        /// <para>The route table ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>vtb-bp145q7glnuzdvzu2****</para>
                        /// </summary>
                        [NameInMap("RouteTableId")]
                        [Validation(Required=false)]
                        public string RouteTableId { get; set; }

                        /// <summary>
                        /// <para>The route status. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>Pending</b></description></item>
                        /// <item><description><b>Available</b></description></item>
                        /// <item><description><b>Modifying</b></description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Pending</para>
                        /// </summary>
                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                        /// <summary>
                        /// <para>The route type. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>Custom</b></description></item>
                        /// <item><description><b>System</b></description></item>
                        /// <item><description><b>BGP</b></description></item>
                        /// <item><description><b>CEN</b></description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>System</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                }

                /// <summary>
                /// <para>The ID of the route table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vtb-bp145q7glnuzdvzu2****</para>
                /// </summary>
                [NameInMap("RouteTableId")]
                [Validation(Required=false)]
                public string RouteTableId { get; set; }

                /// <summary>
                /// <para>The type of the route table. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Custom</b></description></item>
                /// <item><description><b>System</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>System</para>
                /// </summary>
                [NameInMap("RouteTableType")]
                [Validation(Required=false)]
                public string RouteTableType { get; set; }

                /// <summary>
                /// <para>The status of the route table. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Pending</b></description></item>
                /// <item><description><b>Available</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Available</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The vRouter ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vrt-bp1lhl0taikrteen8****</para>
                /// </summary>
                [NameInMap("VRouterId")]
                [Validation(Required=false)]
                public string VRouterId { get; set; }

                /// <summary>
                /// <para>The vSwitch ID.</para>
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
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
