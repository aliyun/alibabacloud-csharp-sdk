// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeCenRouteMapsResponseBody : TeaModel {
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
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the routing policy.
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
                /// The match method that is used to match routes based on the AS path.
                /// 
                /// *   **Include**: fuzzy match. A route is a match if the AS path of the route overlaps with the AS path specified in the match condition.
                /// *   **Complete**: exact match. A route is a match only if the AS path of the route is the same as an AS path specified in the match condition.
                /// </summary>
                [NameInMap("AsPathMatchMode")]
                [Validation(Required=false)]
                public string AsPathMatchMode { get; set; }

                /// <summary>
                /// The CEN instance ID.
                /// </summary>
                [NameInMap("CenId")]
                [Validation(Required=false)]
                public string CenId { get; set; }

                /// <summary>
                /// The region ID of the routing policy.
                /// </summary>
                [NameInMap("CenRegionId")]
                [Validation(Required=false)]
                public string CenRegionId { get; set; }

                /// <summary>
                /// The match method that is used to evaluate routes based on the prefix. Valid values:
                /// 
                /// *   **Include**: fuzzy match. A route is a match if the route prefix is included in the match conditions.
                /// 
                /// For example, if you set the match condition to 10.10.0.0/16 and fuzzy match is applied, the route whose prefix is 10.10.1.0/24 meets the match condition.
                /// 
                /// *   **Complete**: exact match. A route is a match only if the route prefix is the same as the prefix specified in the match condition.
                /// 
                /// For example, if you set the match condition to 10.10.0.0/16 and exact match is enabled, a route is a match only if the prefix is 10.10.0.0/16.
                /// </summary>
                [NameInMap("CidrMatchMode")]
                [Validation(Required=false)]
                public string CidrMatchMode { get; set; }

                /// <summary>
                /// The match method that is used to match routes against the community.
                /// 
                /// *   **Include**: fuzzy match. A route is a match if the community of the route overlaps with the community specified in the match condition.
                /// *   **Complete**: exact match. A route meets the match condition only if the community of the route is the same as the community specified in the match condition.
                /// </summary>
                [NameInMap("CommunityMatchMode")]
                [Validation(Required=false)]
                public string CommunityMatchMode { get; set; }

                /// <summary>
                /// The action that is performed on the community of the route.
                /// 
                /// *   **Additive**: adds the community to the route.
                /// *   **Replace**: replaces the original community of the route.
                /// 
                /// This parameter specifies the action to be performed when a route meets the match condition.
                /// </summary>
                [NameInMap("CommunityOperateMode")]
                [Validation(Required=false)]
                public string CommunityOperateMode { get; set; }

                /// <summary>
                /// The description of the routing policy.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The types of destination network instances to which the routes belong.
                /// 
                /// *   **VPC**
                /// *   **VBR**
                /// *   **CCN**
                /// *   **VPN**
                /// 
                /// >  The destination route tables take effect only if the routing policy is applied to the egress gateway direction, and the type of the destination route tables is the same as that of the network instance in the current region.
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
                /// The prefixes of the routes.
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
                /// The IDs of the destination network instances to which the routes point.
                /// 
                /// >  The destination route tables take effect only if the routing policy is applied to the egress gateway direction, and the ID the destination instance is the same as that of the network instance in the current region.
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
                /// Indicates whether the destination network instance IDs are excluded.
                /// 
                /// *   **false** (default): A route is a match if its destination network instance ID is in the list specified by **DestinationInstanceIds.N**.
                /// *   **true**: A route is a match if its destination network instance ID is not in the list specified by **DestinationInstanceIds.N**.
                /// </summary>
                [NameInMap("DestinationInstanceIdsReverseMatch")]
                [Validation(Required=false)]
                public bool? DestinationInstanceIdsReverseMatch { get; set; }

                /// <summary>
                /// The IDs of the destination route tables to which the routes belong. You can enter at most 32 route table IDs.
                /// 
                /// >  The destination route tables take effect only if the routing policy is applied to the egress gateway direction, and the destination route table IDs are in the current region.
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
                /// The action performed on a route that meets the match conditions.
                /// 
                /// *   **Permit**: the route is permitted.
                /// *   **Deny**: the route is denied.
                /// </summary>
                [NameInMap("MapResult")]
                [Validation(Required=false)]
                public string MapResult { get; set; }

                /// <summary>
                /// The type of IP address to be matched against the match condition. Valid values:
                /// 
                /// *   **IPv4**: IPv4 addresses
                /// *   **IPv6**: IPv6 addresses
                /// *   If no value is returned, both IPv4 and IPv6 addresses are matched against the match condition.
                /// </summary>
                [NameInMap("MatchAddressType")]
                [Validation(Required=false)]
                public string MatchAddressType { get; set; }

                /// <summary>
                /// The AS paths against which routes are matched.
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
                /// The community set against which routes are matched.
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
                /// The priority of the routing policy that you want to associate with the current one.
                /// </summary>
                [NameInMap("NextPriority")]
                [Validation(Required=false)]
                public int? NextPriority { get; set; }

                /// <summary>
                /// The community set on which actions are performed.
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
                /// The new priority of the route.
                /// 
                /// A smaller value indicates a higher priority.
                /// 
                /// This parameter indicates the action to be performed when a route meets the match condition.
                /// </summary>
                [NameInMap("Preference")]
                [Validation(Required=false)]
                public int? Preference { get; set; }

                /// <summary>
                /// The AS paths that are prepended by using an action statement when regional gateways receive or advertise routes.
                /// 
                /// This parameter indicates the action to be performed when a route meets the match condition.
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
                /// The priority of the routing policy. A smaller value indicates a higher priority.
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// The routing policy ID.
                /// </summary>
                [NameInMap("RouteMapId")]
                [Validation(Required=false)]
                public string RouteMapId { get; set; }

                /// <summary>
                /// The type of route that is compared. Valid values:
                /// 
                /// *   **System**: system routes that are automatically generated by the system.
                /// *   **Custom**: custom routes that are manually added.
                /// *   **BGP**: routes that are advertised over BGP.
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
                /// The types of source network instances to which the routes belong.
                /// 
                /// *   **VPC**
                /// *   **VBR**
                /// *   **CCN**
                /// *   **VPN**
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
                /// The IDs of the source network instances to which the routes belong.
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
                /// Indicates whether the source network instance IDs are excluded.
                /// 
                /// *   **false** (default): A route is a match if its source network instance ID is in the list specified by **SourceInstanceIds.N**.
                /// *   **true**: A route is match if its source network instance ID is not in the list specified by **SourceInstanceIds.N**.
                /// </summary>
                [NameInMap("SourceInstanceIdsReverseMatch")]
                [Validation(Required=false)]
                public bool? SourceInstanceIdsReverseMatch { get; set; }

                /// <summary>
                /// The IDs of the source regions to which the routes belong.
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
                /// The IDs of the source route tables to which the routes belong.
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
                /// The status of the routing policy. Valid values:
                /// 
                /// *   **Creating**
                /// *   **Active**
                /// *   **Deleting**
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The route table ID of the transit router with which the routing policy is associated.
                /// </summary>
                [NameInMap("TransitRouterRouteTableId")]
                [Validation(Required=false)]
                public string TransitRouterRouteTableId { get; set; }

                /// <summary>
                /// The direction in which the routing policy is applied.
                /// </summary>
                [NameInMap("TransmitDirection")]
                [Validation(Required=false)]
                public string TransmitDirection { get; set; }

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
