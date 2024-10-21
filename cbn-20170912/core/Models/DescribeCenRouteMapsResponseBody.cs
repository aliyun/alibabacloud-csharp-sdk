// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeCenRouteMapsResponseBody : TeaModel {
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24CE1987-D1D1-5324-9BAD-2750B60E6ABB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information about the routing policy.</para>
        /// </summary>
        [NameInMap("RouteMaps")]
        [Validation(Required=false)]
        public DescribeCenRouteMapsResponseBodyRouteMaps RouteMaps { get; set; }
        public class DescribeCenRouteMapsResponseBodyRouteMaps : TeaModel {
            [NameInMap("RouteMap")]
            [Validation(Required=false)]
            public List<DescribeCenRouteMapsResponseBodyRouteMapsRouteMap> RouteMap { get; set; }
            public class DescribeCenRouteMapsResponseBodyRouteMapsRouteMap : TeaModel {
                /// <summary>
                /// <para>The match method that is used to match routes based on the AS path.</para>
                /// <list type="bullet">
                /// <item><description><b>Include</b>: fuzzy match. A route is a match if the AS path of the route overlaps with the AS path specified in the match condition.</description></item>
                /// <item><description><b>Complete</b>: exact match. A route is a match only if the AS path of the route is the same as an AS path specified in the match condition.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Include</para>
                /// </summary>
                [NameInMap("AsPathMatchMode")]
                [Validation(Required=false)]
                public string AsPathMatchMode { get; set; }

                /// <summary>
                /// <para>The CEN instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cen-wx12mmlt17ld82****</para>
                /// </summary>
                [NameInMap("CenId")]
                [Validation(Required=false)]
                public string CenId { get; set; }

                /// <summary>
                /// <para>The region ID of the routing policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("CenRegionId")]
                [Validation(Required=false)]
                public string CenRegionId { get; set; }

                /// <summary>
                /// <para>The match method that is used to evaluate routes based on the prefix. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Include</b>: fuzzy match. A route is a match if the route prefix is included in the match conditions.</description></item>
                /// </list>
                /// <para>For example, if you set the match condition to 10.10.0.0/16 and fuzzy match is applied, the route whose prefix is 10.10.1.0/24 meets the match condition.</para>
                /// <list type="bullet">
                /// <item><description><b>Complete</b>: exact match. A route is a match only if the route prefix is the same as the prefix specified in the match condition.</description></item>
                /// </list>
                /// <para>For example, if you set the match condition to 10.10.0.0/16 and exact match is enabled, a route is a match only if the prefix is 10.10.0.0/16.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Include</para>
                /// </summary>
                [NameInMap("CidrMatchMode")]
                [Validation(Required=false)]
                public string CidrMatchMode { get; set; }

                /// <summary>
                /// <para>The match method that is used to match routes against the community.</para>
                /// <list type="bullet">
                /// <item><description><b>Include</b>: fuzzy match. A route is a match if the community of the route overlaps with the community specified in the match condition.</description></item>
                /// <item><description><b>Complete</b>: exact match. A route meets the match condition only if the community of the route is the same as the community specified in the match condition.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Include</para>
                /// </summary>
                [NameInMap("CommunityMatchMode")]
                [Validation(Required=false)]
                public string CommunityMatchMode { get; set; }

                /// <summary>
                /// <para>The action that is performed on the community of the route.</para>
                /// <list type="bullet">
                /// <item><description><b>Additive</b>: adds the community to the route.</description></item>
                /// <item><description><b>Replace</b>: replaces the original community of the route.</description></item>
                /// </list>
                /// <para>This parameter specifies the action to be performed when a route meets the match condition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Additive</para>
                /// </summary>
                [NameInMap("CommunityOperateMode")]
                [Validation(Required=false)]
                public string CommunityOperateMode { get; set; }

                /// <summary>
                /// <para>The description of the routing policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>desctest</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The types of destination network instances to which the routes belong.</para>
                /// <list type="bullet">
                /// <item><description><b>VPC</b></description></item>
                /// <item><description><b>VBR</b></description></item>
                /// <item><description><b>CCN</b></description></item>
                /// <item><description><b>VPN</b></description></item>
                /// </list>
                /// <remarks>
                /// <para> The destination route tables take effect only if the routing policy is applied to the egress gateway direction, and the type of the destination route tables is the same as that of the network instance in the current region.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("DestinationChildInstanceTypes")]
                [Validation(Required=false)]
                public DescribeCenRouteMapsResponseBodyRouteMapsRouteMapDestinationChildInstanceTypes DestinationChildInstanceTypes { get; set; }
                public class DescribeCenRouteMapsResponseBodyRouteMapsRouteMapDestinationChildInstanceTypes : TeaModel {
                    [NameInMap("DestinationChildInstanceType")]
                    [Validation(Required=false)]
                    public List<string> DestinationChildInstanceType { get; set; }

                }

                /// <summary>
                /// <para>The prefixes of the routes.</para>
                /// </summary>
                [NameInMap("DestinationCidrBlocks")]
                [Validation(Required=false)]
                public DescribeCenRouteMapsResponseBodyRouteMapsRouteMapDestinationCidrBlocks DestinationCidrBlocks { get; set; }
                public class DescribeCenRouteMapsResponseBodyRouteMapsRouteMapDestinationCidrBlocks : TeaModel {
                    [NameInMap("DestinationCidrBlock")]
                    [Validation(Required=false)]
                    public List<string> DestinationCidrBlock { get; set; }

                }

                /// <summary>
                /// <para>The IDs of the destination network instances to which the routes point.</para>
                /// <remarks>
                /// <para> The destination route tables take effect only if the routing policy is applied to the egress gateway direction, and the ID the destination instance is the same as that of the network instance in the current region.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("DestinationInstanceIds")]
                [Validation(Required=false)]
                public DescribeCenRouteMapsResponseBodyRouteMapsRouteMapDestinationInstanceIds DestinationInstanceIds { get; set; }
                public class DescribeCenRouteMapsResponseBodyRouteMapsRouteMapDestinationInstanceIds : TeaModel {
                    [NameInMap("DestinationInstanceId")]
                    [Validation(Required=false)]
                    public List<string> DestinationInstanceId { get; set; }

                }

                /// <summary>
                /// <para>Indicates whether the destination network instance IDs are excluded.</para>
                /// <list type="bullet">
                /// <item><description><b>false</b> (default): A route is a match if its destination network instance ID is in the list specified by <b>DestinationInstanceIds.N</b>.</description></item>
                /// <item><description><b>true</b>: A route is a match if its destination network instance ID is not in the list specified by <b>DestinationInstanceIds.N</b>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("DestinationInstanceIdsReverseMatch")]
                [Validation(Required=false)]
                public bool? DestinationInstanceIdsReverseMatch { get; set; }

                [NameInMap("DestinationRegionIds")]
                [Validation(Required=false)]
                public DescribeCenRouteMapsResponseBodyRouteMapsRouteMapDestinationRegionIds DestinationRegionIds { get; set; }
                public class DescribeCenRouteMapsResponseBodyRouteMapsRouteMapDestinationRegionIds : TeaModel {
                    [NameInMap("DestinationRegionId")]
                    [Validation(Required=false)]
                    public List<string> DestinationRegionId { get; set; }

                }

                /// <summary>
                /// <para>The IDs of the destination route tables to which the routes belong. You can enter at most 32 route table IDs.</para>
                /// <remarks>
                /// <para> The destination route tables take effect only if the routing policy is applied to the egress gateway direction, and the destination route table IDs are in the current region.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("DestinationRouteTableIds")]
                [Validation(Required=false)]
                public DescribeCenRouteMapsResponseBodyRouteMapsRouteMapDestinationRouteTableIds DestinationRouteTableIds { get; set; }
                public class DescribeCenRouteMapsResponseBodyRouteMapsRouteMapDestinationRouteTableIds : TeaModel {
                    [NameInMap("DestinationRouteTableId")]
                    [Validation(Required=false)]
                    public List<string> DestinationRouteTableId { get; set; }

                }

                /// <summary>
                /// <para>The action performed on a route that meets the match conditions.</para>
                /// <list type="bullet">
                /// <item><description><b>Permit</b>: the route is permitted.</description></item>
                /// <item><description><b>Deny</b>: the route is denied.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Deny</para>
                /// </summary>
                [NameInMap("MapResult")]
                [Validation(Required=false)]
                public string MapResult { get; set; }

                /// <summary>
                /// <para>The type of IP address to be matched against the match condition. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>IPv4</b>: IPv4 addresses</description></item>
                /// <item><description><b>IPv6</b>: IPv6 addresses</description></item>
                /// <item><description>If no value is returned, both IPv4 and IPv6 addresses are matched against the match condition.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>IPv4</para>
                /// </summary>
                [NameInMap("MatchAddressType")]
                [Validation(Required=false)]
                public string MatchAddressType { get; set; }

                /// <summary>
                /// <para>The AS paths against which routes are matched.</para>
                /// </summary>
                [NameInMap("MatchAsns")]
                [Validation(Required=false)]
                public DescribeCenRouteMapsResponseBodyRouteMapsRouteMapMatchAsns MatchAsns { get; set; }
                public class DescribeCenRouteMapsResponseBodyRouteMapsRouteMapMatchAsns : TeaModel {
                    [NameInMap("MatchAsn")]
                    [Validation(Required=false)]
                    public List<string> MatchAsn { get; set; }

                }

                /// <summary>
                /// <para>The community set against which routes are matched.</para>
                /// </summary>
                [NameInMap("MatchCommunitySet")]
                [Validation(Required=false)]
                public DescribeCenRouteMapsResponseBodyRouteMapsRouteMapMatchCommunitySet MatchCommunitySet { get; set; }
                public class DescribeCenRouteMapsResponseBodyRouteMapsRouteMapMatchCommunitySet : TeaModel {
                    [NameInMap("MatchCommunity")]
                    [Validation(Required=false)]
                    public List<string> MatchCommunity { get; set; }

                }

                /// <summary>
                /// <para>The priority of the routing policy that you want to associate with the current one.</para>
                /// 
                /// <b>Example:</b>
                /// <para>33</para>
                /// </summary>
                [NameInMap("NextPriority")]
                [Validation(Required=false)]
                public int? NextPriority { get; set; }

                /// <summary>
                /// <para>The community set on which actions are performed.</para>
                /// </summary>
                [NameInMap("OperateCommunitySet")]
                [Validation(Required=false)]
                public DescribeCenRouteMapsResponseBodyRouteMapsRouteMapOperateCommunitySet OperateCommunitySet { get; set; }
                public class DescribeCenRouteMapsResponseBodyRouteMapsRouteMapOperateCommunitySet : TeaModel {
                    [NameInMap("OperateCommunity")]
                    [Validation(Required=false)]
                    public List<string> OperateCommunity { get; set; }

                }

                /// <summary>
                /// <para>The new priority of the route.</para>
                /// <para>A smaller value indicates a higher priority.</para>
                /// <para>This parameter indicates the action to be performed when a route meets the match condition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Preference")]
                [Validation(Required=false)]
                public int? Preference { get; set; }

                /// <summary>
                /// <para>The AS paths that are prepended by using an action statement when regional gateways receive or advertise routes.</para>
                /// <para>This parameter indicates the action to be performed when a route meets the match condition.</para>
                /// </summary>
                [NameInMap("PrependAsPath")]
                [Validation(Required=false)]
                public DescribeCenRouteMapsResponseBodyRouteMapsRouteMapPrependAsPath PrependAsPath { get; set; }
                public class DescribeCenRouteMapsResponseBodyRouteMapsRouteMapPrependAsPath : TeaModel {
                    [NameInMap("AsPath")]
                    [Validation(Required=false)]
                    public List<string> AsPath { get; set; }

                }

                /// <summary>
                /// <para>The priority of the routing policy. A smaller value indicates a higher priority.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5000</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// <para>The routing policy ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cenrmap-y40mxdvf7joc12****</para>
                /// </summary>
                [NameInMap("RouteMapId")]
                [Validation(Required=false)]
                public string RouteMapId { get; set; }

                /// <summary>
                /// <para>The type of route that is compared. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>System</b>: system routes that are automatically generated by the system.</description></item>
                /// <item><description><b>Custom</b>: custom routes that are manually added.</description></item>
                /// <item><description><b>BGP</b>: routes that are advertised over BGP.</description></item>
                /// </list>
                /// </summary>
                [NameInMap("RouteTypes")]
                [Validation(Required=false)]
                public DescribeCenRouteMapsResponseBodyRouteMapsRouteMapRouteTypes RouteTypes { get; set; }
                public class DescribeCenRouteMapsResponseBodyRouteMapsRouteMapRouteTypes : TeaModel {
                    [NameInMap("RouteType")]
                    [Validation(Required=false)]
                    public List<string> RouteType { get; set; }

                }

                /// <summary>
                /// <para>The types of source network instances to which the routes belong.</para>
                /// <list type="bullet">
                /// <item><description><b>VPC</b></description></item>
                /// <item><description><b>VBR</b></description></item>
                /// <item><description><b>CCN</b></description></item>
                /// <item><description><b>VPN</b></description></item>
                /// </list>
                /// </summary>
                [NameInMap("SourceChildInstanceTypes")]
                [Validation(Required=false)]
                public DescribeCenRouteMapsResponseBodyRouteMapsRouteMapSourceChildInstanceTypes SourceChildInstanceTypes { get; set; }
                public class DescribeCenRouteMapsResponseBodyRouteMapsRouteMapSourceChildInstanceTypes : TeaModel {
                    [NameInMap("SourceChildInstanceType")]
                    [Validation(Required=false)]
                    public List<string> SourceChildInstanceType { get; set; }

                }

                /// <summary>
                /// <para>The IDs of the source network instances to which the routes belong.</para>
                /// </summary>
                [NameInMap("SourceInstanceIds")]
                [Validation(Required=false)]
                public DescribeCenRouteMapsResponseBodyRouteMapsRouteMapSourceInstanceIds SourceInstanceIds { get; set; }
                public class DescribeCenRouteMapsResponseBodyRouteMapsRouteMapSourceInstanceIds : TeaModel {
                    [NameInMap("SourceInstanceId")]
                    [Validation(Required=false)]
                    public List<string> SourceInstanceId { get; set; }

                }

                /// <summary>
                /// <para>Indicates whether the source network instance IDs are excluded.</para>
                /// <list type="bullet">
                /// <item><description><b>false</b> (default): A route is a match if its source network instance ID is in the list specified by <b>SourceInstanceIds.N</b>.</description></item>
                /// <item><description><b>true</b>: A route is match if its source network instance ID is not in the list specified by <b>SourceInstanceIds.N</b>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("SourceInstanceIdsReverseMatch")]
                [Validation(Required=false)]
                public bool? SourceInstanceIdsReverseMatch { get; set; }

                /// <summary>
                /// <para>The IDs of the source regions to which the routes belong.</para>
                /// </summary>
                [NameInMap("SourceRegionIds")]
                [Validation(Required=false)]
                public DescribeCenRouteMapsResponseBodyRouteMapsRouteMapSourceRegionIds SourceRegionIds { get; set; }
                public class DescribeCenRouteMapsResponseBodyRouteMapsRouteMapSourceRegionIds : TeaModel {
                    [NameInMap("SourceRegionId")]
                    [Validation(Required=false)]
                    public List<string> SourceRegionId { get; set; }

                }

                /// <summary>
                /// <para>The IDs of the source route tables to which the routes belong.</para>
                /// </summary>
                [NameInMap("SourceRouteTableIds")]
                [Validation(Required=false)]
                public DescribeCenRouteMapsResponseBodyRouteMapsRouteMapSourceRouteTableIds SourceRouteTableIds { get; set; }
                public class DescribeCenRouteMapsResponseBodyRouteMapsRouteMapSourceRouteTableIds : TeaModel {
                    [NameInMap("SourceRouteTableId")]
                    [Validation(Required=false)]
                    public List<string> SourceRouteTableId { get; set; }

                }

                /// <summary>
                /// <para>The status of the routing policy. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Creating</b></description></item>
                /// <item><description><b>Active</b></description></item>
                /// <item><description><b>Deleting</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Active</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The route table ID of the transit router with which the routing policy is associated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vtb-gw8nx3515m1mbd1z1****</para>
                /// </summary>
                [NameInMap("TransitRouterRouteTableId")]
                [Validation(Required=false)]
                public string TransitRouterRouteTableId { get; set; }

                /// <summary>
                /// <para>The direction in which the routing policy is applied.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RegionOut</para>
                /// </summary>
                [NameInMap("TransmitDirection")]
                [Validation(Required=false)]
                public string TransmitDirection { get; set; }

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
