// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ModifyCenRouteMapRequest : TeaModel {
        /// <summary>
        /// The match method that is used to match routes against the AS paths. Valid values:
        /// 
        /// *   **Include**: fuzzy match. A route meets the match condition if the AS path of the route overlaps with the AS paths specified in the match condition.
        /// *   **Complete**: exact match. A route is a match only if the AS path of the route is the same as an AS path specified in the match condition.
        /// </summary>
        [NameInMap("AsPathMatchMode")]
        [Validation(Required=false)]
        public string AsPathMatchMode { get; set; }

        /// <summary>
        /// The ID of the CEN instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// The ID of the region in which the routing policy is applied.
        /// 
        /// You can call the [DescribeChildInstanceRegions](https://help.aliyun.com/document_detail/132080.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CenRegionId")]
        [Validation(Required=false)]
        public string CenRegionId { get; set; }

        /// <summary>
        /// The match method that is used to match routes against the prefix list. Valid values:
        /// 
        /// *   **Include**: fuzzy match. A route is a match if the route prefix is included in the match conditions.
        /// 
        ///     For example, if you set the match condition to 10.10.0.0/16 and fuzzy match is enabled, the route whose prefix is 10.10.1.0/24 is a match.
        /// 
        /// *   **Complete**: exact match. A route is a match only if the route prefix is the same as the prefix specified in the match condition.
        /// 
        ///     For example, if you set the match condition to 10.10.0.0/16 and exact match is enabled, a route is a match only if the prefix is 10.10.0.0/16.
        /// </summary>
        [NameInMap("CidrMatchMode")]
        [Validation(Required=false)]
        public string CidrMatchMode { get; set; }

        /// <summary>
        /// The match method that is sed to match routes based on the community. Valid values:
        /// 
        /// *   **Include**: fuzzy match. A route meets the match condition if the community of the route overlaps with the community specified in the match condition.
        /// *   **Complete**: exact match. A route meets the match condition only if the community of the route is the same as the community specified in the match condition.
        /// </summary>
        [NameInMap("CommunityMatchMode")]
        [Validation(Required=false)]
        public string CommunityMatchMode { get; set; }

        /// <summary>
        /// The action that is performed on the community. Valid values:
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
        /// 
        /// The description cannot start with `http://` or `https://`. It must start with a letter and can contain letters, digits, hyphens (-), periods (.), and underscores (_).
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The types of destination network instance to which the routes belong. The following types of network instances are supported:
        /// 
        /// *   **VPC**: VPC
        /// 
        /// *   **VBR**: VBR
        /// 
        /// *   **CCN**: CCN instance
        /// 
        /// *   **VPN**: IPsec connection
        /// 
        ///     > This parameter does not take effect if the IPsec-VPN connection or SSL client is associated with a transit router through a VPN gateway and a VPC. This parameter takes effect only if the IPsec connection is directly connected to the transit router.
        /// 
        /// The destination network instance types are valid only if the routing policy is applied to scenarios where routes are advertised from the gateway in the current region to network instances in the current region.
        /// </summary>
        [NameInMap("DestinationChildInstanceTypes")]
        [Validation(Required=false)]
        public List<string> DestinationChildInstanceTypes { get; set; }

        /// <summary>
        /// The prefix list against which routes are matched.
        /// 
        /// You must specify the IP addresses in CIDR notation. You can enter at most 32 CIDR blocks.
        /// </summary>
        [NameInMap("DestinationCidrBlocks")]
        [Validation(Required=false)]
        public List<string> DestinationCidrBlocks { get; set; }

        /// <summary>
        /// The IDs of the destination network instances to which the routes belong. The following network instance types are supported:
        /// 
        /// *   VPC
        /// *   VBR
        /// *   CCN instance
        /// *   SAG instance
        /// *   The ID of the IPsec-VPN connection.
        /// 
        /// You can enter at most 32 IDs.
        /// 
        /// > The destination instance IDs take effect only when Direction is set to Export from Regional Gateway and the destination instances are deployed in the current region.
        /// </summary>
        [NameInMap("DestinationInstanceIds")]
        [Validation(Required=false)]
        public List<string> DestinationInstanceIds { get; set; }

        /// <summary>
        /// Specifies whether to exclude the destination network instance IDs. Valid values:
        /// 
        /// *   **false** (default value): A route is a match if its destination network instance ID is in the list specified by **DestinationInstanceIds.N**.
        /// *   **true**: A route meets the match condition if its destination network instance ID is not in the list specified by **DestinationInstanceIds.N**.
        /// </summary>
        [NameInMap("DestinationInstanceIdsReverseMatch")]
        [Validation(Required=false)]
        public bool? DestinationInstanceIdsReverseMatch { get; set; }

        /// <summary>
        /// The IDs of the destination route tables to which the routes belong. You can enter at most 32 route table IDs.
        /// 
        /// > The destination route table IDs take effect only when Direction is set to Export from Regional Gateway and the destination route tables belong to network instances deployed in the current region.
        /// </summary>
        [NameInMap("DestinationRouteTableIds")]
        [Validation(Required=false)]
        public List<string> DestinationRouteTableIds { get; set; }

        /// <summary>
        /// The action to be performed on a route that meets all match conditions. Valid values:
        /// 
        /// *   **Permit**: the route is permitted.
        /// *   **Deny**: the route is denied.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("MapResult")]
        [Validation(Required=false)]
        public string MapResult { get; set; }

        /// <summary>
        /// The type of IP address in the match condition. Valid values:
        /// 
        /// *   **IPv4**: IPv4 address
        /// *   **IPv6**: IPv6 address
        /// 
        /// This parameter can be empty. If no value is specified, all types of IP address are a match.
        /// </summary>
        [NameInMap("MatchAddressType")]
        [Validation(Required=false)]
        public string MatchAddressType { get; set; }

        /// <summary>
        /// The AS paths against which routes are matched.
        /// 
        /// > Only the AS-SEQUENCE parameter is supported. The AS-SET, AS-CONFED-SEQUENCE, and AS-CONFED-SET parameters are not supported. In other words, only the AS number list is supported. Sets and sub-lists are not supported.
        /// </summary>
        [NameInMap("MatchAsns")]
        [Validation(Required=false)]
        public List<int?> MatchAsns { get; set; }

        /// <summary>
        /// The community against which routes are matched.
        /// 
        /// Specify the community in the format of n:m. Valid values of n and m: **1** to **65535**. Each community must comply with the RFC 1997 standard. The RFC 8092 standard that defines BGP large communities is not supported.
        /// 
        /// You can specify at most 32 communities.
        /// 
        /// > If the configurations of the communities are incorrect, routes may fail to be advertised to your data center.
        /// </summary>
        [NameInMap("MatchCommunitySet")]
        [Validation(Required=false)]
        public List<string> MatchCommunitySet { get; set; }

        /// <summary>
        /// The priority of the routing policy that you want to associate with the current one.
        /// 
        /// *   This parameter takes effect only when the **MapResult** parameter is set to **Permit**. This way, the permitted route is matched against the next routing policy.
        /// *   The region and direction of the routing policy to be associated must be the same as those of the current routing policy.
        /// *   The priority of the routing policy to be associated must be lower than the priority of the current routing policy.
        /// </summary>
        [NameInMap("NextPriority")]
        [Validation(Required=false)]
        public int? NextPriority { get; set; }

        /// <summary>
        /// The community set on which actions are performed.
        /// 
        /// Specify the community in the format of n:m. Valid values of n and m: **1** to **65535**. Each community must comply with RFC 1997. The RFC 8092 standard that defines BGP large communities is not supported.
        /// 
        /// You can specify at most 32 communities.
        /// 
        /// > If the configurations of the communities are incorrect, routes may fail to be advertised to your data center.
        /// </summary>
        [NameInMap("OperateCommunitySet")]
        [Validation(Required=false)]
        public List<string> OperateCommunitySet { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The new priority of the route.
        /// 
        /// Valid values: **1** to **100**. The default priority is **50**. A smaller value indicates a higher priority.
        /// 
        /// This parameter specifies the action to be performed when a route meets the match condition.
        /// </summary>
        [NameInMap("Preference")]
        [Validation(Required=false)]
        public int? Preference { get; set; }

        /// <summary>
        /// The AS paths that are prepended by using an action statement when regional gateways receive or advertise routes.
        /// 
        /// The AS paths vary based on the direction in which the routing policy is applied:
        /// 
        /// *   If AS paths are prepended to a routing policy that is applied in the inbound direction, you must specify source network instance IDs and the source region in the match condition. In addition, the source region must be the same as the region where the routing policy is applied.
        /// *   If AS paths are prepended to a routing policy that is applied in the outbound direction, you must specify destination network instance IDs in the match condition.
        /// 
        /// This parameter specifies the action to be performed when a route meets the match condition.
        /// </summary>
        [NameInMap("PrependAsPath")]
        [Validation(Required=false)]
        public List<long?> PrependAsPath { get; set; }

        /// <summary>
        /// The priority of the routing policy. Valid values: **1** to **100**. A smaller value indicates a higher priority.
        /// 
        /// > You cannot specify the same priority for routing policies that apply in the same region and direction. The system matches routes against the match conditions of routing policies in descending order of priority. A smaller value indicates a higher priority. You must set the priorities to proper values.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The ID of the routing policy.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RouteMapId")]
        [Validation(Required=false)]
        public string RouteMapId { get; set; }

        /// <summary>
        /// The type of route to be matched against the match condition. The following route types are supported:
        /// 
        /// *   **System**: system routes that are automatically generated by the system.
        /// *   **Custom**: custom routes that are manually added.
        /// *   **BGP**: routes that are advertised over BGP.
        /// </summary>
        [NameInMap("RouteTypes")]
        [Validation(Required=false)]
        public List<string> RouteTypes { get; set; }

        /// <summary>
        /// The types of source network instance to which the routes belong. The following types of network instances are supported:
        /// 
        /// *   **VPC**: VPC
        /// 
        /// *   **VBR**: VBR
        /// 
        /// *   **CCN**: CCN instance
        /// 
        /// *   **VPN** :VPN gateway or IPsec-VPN connection
        /// 
        ///     *   If the IPsec-VPN connection or SSL client is associated with a VPN gateway, the VPC associated with the VPN gateway must be connected to a transit router, and the VPN gateway must use Border Gateway Protocol (BGP) dynamic routing. Otherwise, this parameter cannot take effect.
        ///     *   This parameter takes effect if the IPsec connection is directly connected to a transit router.
        /// </summary>
        [NameInMap("SourceChildInstanceTypes")]
        [Validation(Required=false)]
        public List<string> SourceChildInstanceTypes { get; set; }

        /// <summary>
        /// The IDs of the source network instances to which the routes belong. The following network instance types are supported:
        /// 
        /// *   Virtual private cloud (VPC)
        /// *   Virtual border router (VBR)
        /// *   Cloud Connect Network (CCN) instance
        /// *   Smart Access Gateway (SAG) instance
        /// *   The ID of the IPsec-VPN connection.
        /// 
        /// You can enter at most 32 IDs.
        /// </summary>
        [NameInMap("SourceInstanceIds")]
        [Validation(Required=false)]
        public List<string> SourceInstanceIds { get; set; }

        /// <summary>
        /// Specifies whether to exclude the source network instance IDs. Valid values:
        /// 
        /// *   **false** (default value): A route is a match if its source network instance ID is in the list specified by **SourceInstanceIds.N**.
        /// *   **true**: A route is a match if its source network instance ID is not in the list specified by **SourceInstanceIds.N**.
        /// </summary>
        [NameInMap("SourceInstanceIdsReverseMatch")]
        [Validation(Required=false)]
        public bool? SourceInstanceIdsReverseMatch { get; set; }

        /// <summary>
        /// The IDs of the source regions to which the routes belong. You can enter at most 32 region IDs.
        /// 
        /// You can call the [DescribeChildInstanceRegions](https://help.aliyun.com/document_detail/132080.html) operation to query the most recent region list.
        /// </summary>
        [NameInMap("SourceRegionIds")]
        [Validation(Required=false)]
        public List<string> SourceRegionIds { get; set; }

        /// <summary>
        /// The IDs of the source route tables to which the routes belong. You can enter at most 32 route table IDs.
        /// </summary>
        [NameInMap("SourceRouteTableIds")]
        [Validation(Required=false)]
        public List<string> SourceRouteTableIds { get; set; }

    }

}
