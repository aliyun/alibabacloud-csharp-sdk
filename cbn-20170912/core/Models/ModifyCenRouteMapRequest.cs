// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ModifyCenRouteMapRequest : TeaModel {
        /// <summary>
        /// The AS paths against which routes are matched.
        /// 
        /// > Only the AS-SEQUENCE parameter is supported. The AS-SET, AS-CONFED-SEQUENCE, and AS-CONFED-SET parameters are not supported. In other words, only the AS number list is supported. Sets and sub-lists are not supported.
        /// </summary>
        [NameInMap("AsPathMatchMode")]
        [Validation(Required=false)]
        public string AsPathMatchMode { get; set; }

        /// <summary>
        /// The ID of the routing policy.
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// 22
        /// </summary>
        [NameInMap("CenRegionId")]
        [Validation(Required=false)]
        public string CenRegionId { get; set; }

        /// <summary>
        /// vtb-adfg53c322v****
        /// </summary>
        [NameInMap("CidrMatchMode")]
        [Validation(Required=false)]
        public string CidrMatchMode { get; set; }

        /// <summary>
        /// The description of the routing policy.
        /// 
        /// The description cannot start with `http://` or `https://`. It must start with a letter and can contain letters, digits, hyphens (-), periods (.), and underscores (\_).
        /// </summary>
        [NameInMap("CommunityMatchMode")]
        [Validation(Required=false)]
        public string CommunityMatchMode { get; set; }

        /// <summary>
        /// The match method that is used to match routes against the AS paths. Valid values:
        /// 
        /// *   **Include**: fuzzy match. A route meets the match condition if the AS path of the route overlaps with the AS paths specified in the match condition.
        /// *   **Complete**: exact match. A route is a match only if the AS path of the route is the same as an AS path specified in the match condition.
        /// </summary>
        [NameInMap("CommunityOperateMode")]
        [Validation(Required=false)]
        public string CommunityOperateMode { get; set; }

        /// <summary>
        /// cn-beijing
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// VPC
        /// </summary>
        [NameInMap("DestinationChildInstanceTypes")]
        [Validation(Required=false)]
        public List<string> DestinationChildInstanceTypes { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("DestinationCidrBlocks")]
        [Validation(Required=false)]
        public List<string> DestinationCidrBlocks { get; set; }

        /// <summary>
        /// vtb-acdbvtbr342cd****
        /// </summary>
        [NameInMap("DestinationInstanceIds")]
        [Validation(Required=false)]
        public List<string> DestinationInstanceIds { get; set; }

        /// <summary>
        /// System
        /// </summary>
        [NameInMap("DestinationInstanceIdsReverseMatch")]
        [Validation(Required=false)]
        public bool? DestinationInstanceIdsReverseMatch { get; set; }

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
        [NameInMap("DestinationRouteTableIds")]
        [Validation(Required=false)]
        public List<string> DestinationRouteTableIds { get; set; }

        /// <summary>
        /// Specifies whether to exclude the destination network instance IDs. Valid values:
        /// 
        /// *   **false** (default value): A route is a match if its destination network instance ID is in the list specified by **DestinationInstanceIds.N**.
        /// *   **true**: A route meets the match condition if its destination network instance ID is not in the list specified by **DestinationInstanceIds.N**.
        /// </summary>
        [NameInMap("MapResult")]
        [Validation(Required=false)]
        public string MapResult { get; set; }

        /// <summary>
        /// cn-beijing
        /// </summary>
        [NameInMap("MatchAddressType")]
        [Validation(Required=false)]
        public string MatchAddressType { get; set; }

        /// <summary>
        /// The ID of the CEN instance.
        /// </summary>
        [NameInMap("MatchAsns")]
        [Validation(Required=false)]
        public List<int?> MatchAsns { get; set; }

        /// <summary>
        /// The ID of the routing policy.
        /// </summary>
        [NameInMap("MatchCommunitySet")]
        [Validation(Required=false)]
        public List<string> MatchCommunitySet { get; set; }

        /// <summary>
        /// 10.10.10.0/24
        /// </summary>
        [NameInMap("NextPriority")]
        [Validation(Required=false)]
        public int? NextPriority { get; set; }

        /// <summary>
        /// The action to be performed on a route that meets all match conditions. Valid values:
        /// 
        /// *   **Permit**: the route is permitted.
        /// *   **Deny**: the route is denied.
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
        /// The community against which routes are matched.
        /// 
        /// Specify the community in the format of n:m. Valid values of n and m: **1** to **65535**. Each community must comply with the RFC 1997 standard. The RFC 8092 standard that defines BGP large communities is not supported.
        /// 
        /// You can specify at most 32 communities.
        /// 
        /// **
        /// 
        /// **If the configurations of the communities are incorrect, routes may fail to be advertised to your data center.
        /// </summary>
        [NameInMap("Preference")]
        [Validation(Required=false)]
        public int? Preference { get; set; }

        /// <summary>
        /// The match method that is used to match routes against the prefix list. Valid values:
        /// 
        /// *   **Include**: fuzzy match. A route is a match if the route prefix is included in the match conditions.
        /// 
        /// For example, if you set the match condition to 10.10.0.0/16 and fuzzy match is enabled, the route whose prefix is 10.10.1.0/24 is a match.
        /// 
        /// *   **Complete**: exact match. A route is a match only if the route prefix is the same as the prefix specified in the match condition.
        /// 
        /// For example, if you set the match condition to 10.10.0.0/16 and exact match is enabled, a route is a match only if the prefix is 10.10.0.0/16.
        /// </summary>
        [NameInMap("PrependAsPath")]
        [Validation(Required=false)]
        public List<long?> PrependAsPath { get; set; }

        /// <summary>
        /// VPC
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
        /// vpc-avcdsg34ds****
        /// </summary>
        [NameInMap("RouteMapId")]
        [Validation(Required=false)]
        public string RouteMapId { get; set; }

        /// <summary>
        /// Modifies a routing policy of a Cloud Enterprise Network (CEN) instance.
        /// </summary>
        [NameInMap("RouteTypes")]
        [Validation(Required=false)]
        public List<string> RouteTypes { get; set; }

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
        [NameInMap("SourceChildInstanceTypes")]
        [Validation(Required=false)]
        public List<string> SourceChildInstanceTypes { get; set; }

        /// <summary>
        /// 20
        /// </summary>
        [NameInMap("SourceInstanceIds")]
        [Validation(Required=false)]
        public List<string> SourceInstanceIds { get; set; }

        /// <summary>
        /// The IDs of the destination route tables to which the routes belong. You can enter at most 32 route table IDs.
        /// 
        /// > The destination route table IDs take effect only when Direction is set to Export from Regional Gateway and the destination route tables belong to network instances deployed in the current region.
        /// </summary>
        [NameInMap("SourceInstanceIdsReverseMatch")]
        [Validation(Required=false)]
        public bool? SourceInstanceIdsReverseMatch { get; set; }

        /// <summary>
        /// The IDs of the source route tables to which the routes belong. You can enter at most 32 route table IDs.
        /// </summary>
        [NameInMap("SourceRegionIds")]
        [Validation(Required=false)]
        public List<string> SourceRegionIds { get; set; }

        /// <summary>
        /// The action that is performed on the community. Valid values:
        /// 
        /// *   **Additive**: adds the community to the route.
        /// *   **Replace**: replaces the original community of the route.
        /// 
        /// This parameter specifies the action to be performed when a route meets the match condition.
        /// </summary>
        [NameInMap("SourceRouteTableIds")]
        [Validation(Required=false)]
        public List<string> SourceRouteTableIds { get; set; }

    }

}
