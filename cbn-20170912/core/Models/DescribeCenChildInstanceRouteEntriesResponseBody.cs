// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeCenChildInstanceRouteEntriesResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the route.</para>
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
                /// <para>The AS paths of the routes.</para>
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
                /// <para>The routing policy that the routes match.</para>
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
                        /// <para>The region ID of the routing policy.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cn-hangzhou</para>
                        /// </summary>
                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                        /// <summary>
                        /// <para>The routing policy ID.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cenrmap-w4yf7toozfol3q****</para>
                        /// </summary>
                        [NameInMap("RouteMapId")]
                        [Validation(Required=false)]
                        public string RouteMapId { get; set; }

                    }

                }

                /// <summary>
                /// <para>The community attributes of the route entries.</para>
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
                /// <para>A list of overlapping routes.</para>
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
                        /// <para>The destination CIDR block of the overlapping route.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>192.168.1.0/24</para>
                        /// </summary>
                        [NameInMap("DestinationCidrBlock")]
                        [Validation(Required=false)]
                        public string DestinationCidrBlock { get; set; }

                        /// <summary>
                        /// <para>The ID of the peer network instance on which the overlapping routes are found.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ccn-0q3b7oviikmm9h****</para>
                        /// </summary>
                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                        /// <summary>
                        /// <para>The type of the peer network instance on which the overlapping routes are found. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>VPC</b>: VPC</description></item>
                        /// <item><description><b>VBR</b>: VBR</description></item>
                        /// <item><description><b>CCN</b>: CCN instance</description></item>
                        /// <item><description><b>ECR</b>: ECR</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CCN</para>
                        /// </summary>
                        [NameInMap("InstanceType")]
                        [Validation(Required=false)]
                        public string InstanceType { get; set; }

                        /// <summary>
                        /// <para>The region ID of the peer network instance on which the overlapping routes are found.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ccn-cn-shanghai</para>
                        /// </summary>
                        [NameInMap("RegionId")]
                        [Validation(Required=false)]
                        public string RegionId { get; set; }

                        /// <summary>
                        /// <para>The cause of the route error. Valid values:</para>
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
                /// <para>10.0.0.0/24</para>
                /// </summary>
                [NameInMap("DestinationCidrBlock")]
                [Validation(Required=false)]
                public string DestinationCidrBlock { get; set; }

                /// <summary>
                /// <para>The ID of the instance specified as the next hop in the route.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vbr-bp13gtbhdp0pfqg6s****</para>
                /// </summary>
                [NameInMap("NextHopInstanceId")]
                [Validation(Required=false)]
                public string NextHopInstanceId { get; set; }

                /// <summary>
                /// <para>The region ID of the instance specified as the next hop in the route.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("NextHopRegionId")]
                [Validation(Required=false)]
                public string NextHopRegionId { get; set; }

                /// <summary>
                /// <para>The type of the instance specified as the next hop in the route. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Instance</b>: an ECS instance</description></item>
                /// <item><description><b>HaVip</b>: an HAVIP</description></item>
                /// <item><description><b>RouterInterface</b>: a router interface</description></item>
                /// <item><description><b>NetworkInterface</b>: an ENI</description></item>
                /// <item><description><b>VpnGateway</b>: a VPN gateway</description></item>
                /// <item><description><b>IPv6Gateway</b>: an IPv6 gateway</description></item>
                /// <item><description><b>Ipv4Gateway</b>: an IPv4 gateway</description></item>
                /// <item><description><b>NatGateway</b>: a NAT gateway</description></item>
                /// <item><description><b>Attachment</b>: a network instance connection</description></item>
                /// <item><description><b>service</b>: a cloud service</description></item>
                /// <item><description><b>VBR</b>: a VBR</description></item>
                /// <item><description><b>CCN</b>: a CCN instance</description></item>
                /// <item><description><b>VPC</b>: a VPC</description></item>
                /// <item><description><b>local</b>: a system route (no next hop is specified)</description></item>
                /// <item><description><b>TR</b>: a transit router</description></item>
                /// <item><description><b>BlackHole</b>: a blackhole route (no next hop is specified)</description></item>
                /// <item><description><b>EcRouterInterface</b>: a router interface for Express Connect</description></item>
                /// <item><description><b>HealthCheck</b>: a health check</description></item>
                /// <item><description><b>AS</b>: an access gateway for CCN</description></item>
                /// <item><description><b>classic</b>: a classic network-type instance</description></item>
                /// <item><description><b>GatewayEndpoint</b>: a gateway endpoint</description></item>
                /// <item><description><b>CPE</b>: a data center connected to a VBR</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>VBR</para>
                /// </summary>
                [NameInMap("NextHopType")]
                [Validation(Required=false)]
                public string NextHopType { get; set; }

                /// <summary>
                /// <para>Indicates whether the route is allowed to be advertised to or withdrawn from the CEN instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
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
                /// <item><description><b>Published</b></description></item>
                /// <item><description><b>NonPublished</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Published</para>
                /// </summary>
                [NameInMap("PublishStatus")]
                [Validation(Required=false)]
                public string PublishStatus { get; set; }

                /// <summary>
                /// <para>The route table ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vtb-bp1r9pvl4xen8s9ju****</para>
                /// </summary>
                [NameInMap("RouteTableId")]
                [Validation(Required=false)]
                public string RouteTableId { get; set; }

                /// <summary>
                /// <para>The route status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Active</b>: available routes</description></item>
                /// <item><description><b>Candidate</b>: standby routes</description></item>
                /// <item><description><b>Rejected</b>: rejected routes</description></item>
                /// <item><description><b>Prohibited</b>: prohibited routes</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Active</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The route type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>CEN</b>: route that is advertised through CEN</description></item>
                /// <item><description><b>System</b>: system route</description></item>
                /// <item><description><b>Custom</b>: custom route</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CEN</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17A57456-EF48-419D-9AE6-9B03D9996018</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
