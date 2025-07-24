// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class DescribeRouteEntryListResponseBody : TeaModel {
        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If no value is returned for <b>NextToken</b>, no next queries are sent.</description></item>
        /// <item><description>If a value is returned for <b>NextToken</b>, the value is used to retrieve a new page of results.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>14A07460-EBE7-47CA-9757-12CC4761D47A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the routes.</para>
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
                /// <para>The description of the route.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RouteEntryDescription</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The destination CIDR block of the route.</para>
                /// 
                /// <b>Example:</b>
                /// <para>192.168.2.0/24</para>
                /// </summary>
                [NameInMap("DestinationCidrBlock")]
                [Validation(Required=false)]
                public string DestinationCidrBlock { get; set; }

                /// <summary>
                /// <para>The time when the route was modified. The time follows the ISO 8601 standard in the <c>YYYY-MM-DDThh:mm:ssZ</c> format. The time is displayed in UTC.</para>
                /// <para>Use the UTC time format: yyyy-MM-ddTHH:mmZ</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-05-09T03:00:07Z</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The IP version. Valid values: Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>ipv4</b></description></item>
                /// <item><description><b>ipv6</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>IPv4</para>
                /// </summary>
                [NameInMap("IpVersion")]
                [Validation(Required=false)]
                public string IpVersion { get; set; }

                /// <summary>
                /// <para>The information about the next hops.</para>
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
                        /// <para>Indicates whether the route is available. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>0</b>: unavailable</description></item>
                        /// <item><description><b>1</b>: available</description></item>
                        /// </list>
                        /// <remarks>
                        /// <para> This parameter is returned when the next hop type is set to <b>RouterInterface</b>.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Enabled")]
                        [Validation(Required=false)]
                        public int? Enabled { get; set; }

                        /// <summary>
                        /// <para>The ID of the next hop.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>vpn-bp10zyaph5cc8b7c7****</para>
                        /// </summary>
                        [NameInMap("NextHopId")]
                        [Validation(Required=false)]
                        public string NextHopId { get; set; }

                        /// <summary>
                        /// <para>The ID of the region where the next hop is deployed.</para>
                        /// <remarks>
                        /// <para> This parameter is returned when the next hop type is set to <b>RouterInterface</b>.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cn-hangzhou</para>
                        /// </summary>
                        [NameInMap("NextHopRegionId")]
                        [Validation(Required=false)]
                        public string NextHopRegionId { get; set; }

                        /// <summary>
                        /// <para>The information about the next hop.</para>
                        /// </summary>
                        [NameInMap("NextHopRelatedInfo")]
                        [Validation(Required=false)]
                        public DescribeRouteEntryListResponseBodyRouteEntrysRouteEntryNextHopsNextHopNextHopRelatedInfo NextHopRelatedInfo { get; set; }
                        public class DescribeRouteEntryListResponseBodyRouteEntrysRouteEntryNextHopsNextHopNextHopRelatedInfo : TeaModel {
                            /// <summary>
                            /// <para>The ID of the instance that is associated with the next hop.</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>vpc-bp1t36rn9l53iwbsf****</para>
                            /// </summary>
                            [NameInMap("InstanceId")]
                            [Validation(Required=false)]
                            public string InstanceId { get; set; }

                            /// <summary>
                            /// <para>The type of the instance associated with the next hop. Valid values:</para>
                            /// <list type="bullet">
                            /// <item><description><b>VPC</b>: a VPC</description></item>
                            /// <item><description><b>VBR</b>: a VBR</description></item>
                            /// <item><description><b>PCONN</b>: an Express Connect circuit</description></item>
                            /// </list>
                            /// 
                            /// <b>Example:</b>
                            /// <para>VPC</para>
                            /// </summary>
                            [NameInMap("InstanceType")]
                            [Validation(Required=false)]
                            public string InstanceType { get; set; }

                            /// <summary>
                            /// <para>The region ID of the instance associated with the next hop. Valid values:</para>
                            /// 
                            /// <b>Example:</b>
                            /// <para>ch-hangzhou</para>
                            /// </summary>
                            [NameInMap("RegionId")]
                            [Validation(Required=false)]
                            public string RegionId { get; set; }

                        }

                        /// <summary>
                        /// <para>The next hop type. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>Instance</b>: an ECS instance.</description></item>
                        /// <item><description><b>HaVip</b>: an HaVip.</description></item>
                        /// <item><description><b>VpnGateway</b>: a VPN gateway.</description></item>
                        /// <item><description><b>NatGateway</b>: a NAT gateway.</description></item>
                        /// <item><description><b>NetworkInterface</b>: a secondary ENI.</description></item>
                        /// <item><description><b>RouterInterface</b>: a router interface.</description></item>
                        /// <item><description><b>IPv6Gateway</b>: an IPv6 gateway.</description></item>
                        /// <item><description><b>Attachment</b>: a transit router.</description></item>
                        /// <item><description><b>Ipv4Gateway</b>: an IPv4 gateway.</description></item>
                        /// <item><description><b>GatewayEndpoint</b>: a gateway endpoint.</description></item>
                        /// <item><description><b>CenBasic</b>: CEN does not support transit routers.</description></item>
                        /// <item><description><b>Ecr</b>: ECR.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Instance</para>
                        /// </summary>
                        [NameInMap("NextHopType")]
                        [Validation(Required=false)]
                        public string NextHopType { get; set; }

                        /// <summary>
                        /// <para>The weight of the route.</para>
                        /// <remarks>
                        /// <para> This parameter is returned when the next hop type is set to <b>RouterInterface</b>.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("Weight")]
                        [Validation(Required=false)]
                        public int? Weight { get; set; }

                    }

                }

                /// <summary>
                /// <para>The route origin. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>RoutePropagation</b>: The route is created by a dynamic propagation source.</description></item>
                /// <item><description><b>SystemCreate</b>: The route is created by the system.</description></item>
                /// <item><description><b>CustomCreate</b>: The route is created by a user.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>RoutePropagation</para>
                /// </summary>
                [NameInMap("Origin")]
                [Validation(Required=false)]
                public string Origin { get; set; }

                /// <summary>
                /// <para>The ID of the route.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rte-bp1mnnr2al0naomnp****</para>
                /// </summary>
                [NameInMap("RouteEntryId")]
                [Validation(Required=false)]
                public string RouteEntryId { get; set; }

                /// <summary>
                /// <para>The name of the route.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aaa</para>
                /// </summary>
                [NameInMap("RouteEntryName")]
                [Validation(Required=false)]
                public string RouteEntryName { get; set; }

                /// <summary>
                /// <para>The ID of the route table.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vtb-bp15w5q90d2rk3bww****</para>
                /// </summary>
                [NameInMap("RouteTableId")]
                [Validation(Required=false)]
                public string RouteTableId { get; set; }

                /// <summary>
                /// <para>Indicates whether the route is hosted. If the parameter is empty, the route is not hosted.</para>
                /// <para>If <b>TR</b> is returned, the route is hosted by a transit router.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TR</para>
                /// </summary>
                [NameInMap("ServiceType")]
                [Validation(Required=false)]
                public string ServiceType { get; set; }

                /// <summary>
                /// <para>The status of the route entry. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Pending</b></description></item>
                /// <item><description><b>Available</b></description></item>
                /// <item><description><b>Modifying</b></description></item>
                /// <item><description><b>Deleting</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Available</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The route type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Custom</b>: custom routes.</description></item>
                /// <item><description><b>System</b>: system routes.</description></item>
                /// <item><description><b>BGP</b>: BGP routes.</description></item>
                /// <item><description><b>CEN</b>: CEN routes.</description></item>
                /// <item><description><b>ECR</b>: ECR routes.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Custom</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

    }

}
