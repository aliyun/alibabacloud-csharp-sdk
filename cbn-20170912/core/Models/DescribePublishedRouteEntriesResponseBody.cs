// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribePublishedRouteEntriesResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>A list of routes.</para>
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
                /// <para>The ID of the route table configured on the network instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vtb-il7qut3mjgtlcbpk2****</para>
                /// </summary>
                [NameInMap("ChildInstanceRouteTableId")]
                [Validation(Required=false)]
                public string ChildInstanceRouteTableId { get; set; }

                /// <summary>
                /// <para>A list of conflicting routes.</para>
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
                        /// <para>The destination CIDR block of the conflicting route.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>192.168.20.0/24</para>
                        /// </summary>
                        [NameInMap("DestinationCidrBlock")]
                        [Validation(Required=false)]
                        public string DestinationCidrBlock { get; set; }

                        /// <summary>
                        /// <para>The ID of the peer network instance on which conflicting routes are found.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ccn-0q3b7oviikmm9h****</para>
                        /// </summary>
                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                        /// <summary>
                        /// <para>The type of the peer network instance on which the conflicting routes are found. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>VPC</b>: VPC</description></item>
                        /// <item><description><b>VBR</b>: VBR</description></item>
                        /// <item><description><b>CCN</b>: CCN instance</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CCN</para>
                        /// </summary>
                        [NameInMap("InstanceType")]
                        [Validation(Required=false)]
                        public string InstanceType { get; set; }

                        /// <summary>
                        /// <para>The ID of the region where the peer network instance on which the conflicting routes are found is deployed.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ccn-cn-shanghai</para>
                        /// </summary>
                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                        /// <summary>
                        /// <para>The cause of the route confliction. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>conflict</b>: The routes have the same destination CIDR block.</description></item>
                        /// <item><description><b>overflow</b>: The number of routes in the route table configured on another network instance has reached the upper limit.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>conflict</para>
                        /// </summary>
                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                    }

                }

                /// <summary>
                /// <para>The destination CIDR block of the route.</para>
                /// 
                /// <b>Example:</b>
                /// <para>172.16.0.0/16</para>
                /// </summary>
                [NameInMap("DestinationCidrBlock")]
                [Validation(Required=false)]
                public string DestinationCidrBlock { get; set; }

                /// <summary>
                /// <para>The ID of the instance specified as the next hop in the route.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ecs-bp18sth14qii3pn****</para>
                /// </summary>
                [NameInMap("NextHopId")]
                [Validation(Required=false)]
                public string NextHopId { get; set; }

                /// <summary>
                /// <para>The type of the instance specified as the next hop in the route.</para>
                /// <list type="bullet">
                /// <item><description><b>Instance</b>: ECS instance</description></item>
                /// <item><description><b>HaVip</b>: high-availability virtual IP address (HAVIP).</description></item>
                /// <item><description><b>RouterInterface</b>: router interface.</description></item>
                /// <item><description><b>NetworkInterface</b>: elastic network interface (ENI).</description></item>
                /// <item><description><b>VpnGateway</b>: VPN gateway.</description></item>
                /// <item><description><b>IPv6Gateway</b>: IPv6 gateway.</description></item>
                /// <item><description><b>NatGateway</b>: NAT gateway.</description></item>
                /// <item><description><b>Attachment</b>: network instance connection</description></item>
                /// <item><description><b>service</b>: cloud service</description></item>
                /// <item><description><b>VBR</b>: VBR</description></item>
                /// <item><description><b>CCN</b>: CCN instance</description></item>
                /// <item><description><b>VPC</b>: VPC</description></item>
                /// <item><description><b>local</b>: system route. No next hop is specified.</description></item>
                /// <item><description><b>TR</b>: transit router</description></item>
                /// <item><description><b>BlackHole</b>: blackhole route. No next hop is specified.</description></item>
                /// <item><description><b>EcRouterInterface</b>: router interface for Express Connect</description></item>
                /// <item><description><b>HealthCheck</b>: health check</description></item>
                /// <item><description><b>AS</b>: access gateway for CCN</description></item>
                /// <item><description><b>classicLink</b>: classic network-type instance</description></item>
                /// <item><description><b>GatewayEndpoint</b>: gateway endpoint</description></item>
                /// <item><description><b>CPE</b>: data center connected to the VBR</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Instance</para>
                /// </summary>
                [NameInMap("NextHopType")]
                [Validation(Required=false)]
                public string NextHopType { get; set; }

                /// <summary>
                /// <para>Indicates whether the route is allowed to be advertised to or withdrawn from the CEN instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: The route is allowed to be advertised to or withdrawn from the CEN instance.</description></item>
                /// <item><description><b>false</b>: The route is not allowed to be advertised to or withdrawn from the CEN instance.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("OperationalMode")]
                [Validation(Required=false)]
                public bool? OperationalMode { get; set; }

                /// <summary>
                /// <para>Indicates whether the route is advertised to the CEN instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Published</b>: The route is advertised to the CEN instance.</description></item>
                /// <item><description><b>NonPublished</b>: The route is not advertised to the CEN instance.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Published</para>
                /// </summary>
                [NameInMap("PublishStatus")]
                [Validation(Required=false)]
                public string PublishStatus { get; set; }

                /// <summary>
                /// <para>The type of the route. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>CEN</b>: route that is advertised through CEN</description></item>
                /// <item><description><b>System</b>: system route</description></item>
                /// <item><description><b>Custom</b>: custom route</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>System</para>
                /// </summary>
                [NameInMap("RouteType")]
                [Validation(Required=false)]
                public string RouteType { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FF1A7B2A-677F-4F71-96EA-6002B329F437</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
