// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRouterRouteEntriesRequest : TeaModel {
        /// <summary>
        /// The number of entries per page. Valid values: **1** to **100**. Default value: **20**.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results. Valid values:
        /// 
        /// *   You do not need to specify this parameter for the first request.
        /// *   You must specify the token that is obtained from the previous query as the value of **NextToken**.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The prefix list ID.
        /// </summary>
        [NameInMap("PrefixListId")]
        [Validation(Required=false)]
        public string PrefixListId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The filter conditions for route CIDR blocks.
        /// </summary>
        [NameInMap("RouteFilter")]
        [Validation(Required=false)]
        public List<ListTransitRouterRouteEntriesRequestRouteFilter> RouteFilter { get; set; }
        public class ListTransitRouterRouteEntriesRequestRouteFilter : TeaModel {
            /// <summary>
            /// The match pattern for filtering CIDR blocks. Valid values:
            /// 
            /// *   **PrefixExactMatchCidrs**: exact matching.
            /// *   **LongestPrefixMatchCidrs**: longest prefix matching. The specified IP address and CIDR block are considered a match.
            /// *   **SubnetOfMatchCidrs**: subnet matching. The specified CIDR block is considered a match.
            /// *   **SupernetOfMatchCidrs**: supernet matching. The specified CIDR block is considered a match.
            /// 
            /// By default, the logical operator among filter conditions is **AND**. Information about a route entry is returned only if the route entry matches all filter conditions. Filter conditions must be unique.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The filter value.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

        }

        /// <summary>
        /// The destination CIDR block of the route. **This parameter is to be deprecated. We recommend that you use the RouteFilter parameter**.
        /// </summary>
        [NameInMap("TransitRouterRouteEntryDestinationCidrBlock")]
        [Validation(Required=false)]
        [Obsolete]
        public string TransitRouterRouteEntryDestinationCidrBlock { get; set; }

        /// <summary>
        /// The route ID.
        /// 
        /// >  You can use this parameter to query only static routes in the specified route table. This parameter is incompatible with query conditions other than TransitRouterRouteEntryNames.
        /// </summary>
        [NameInMap("TransitRouterRouteEntryIds")]
        [Validation(Required=false)]
        public List<string> TransitRouterRouteEntryIds { get; set; }

        /// <summary>
        /// The route name.
        /// 
        /// The name must be 0 to 128 characters in length, and can contain letters, digits, and the following special characters: , . ; / @ \_ -.
        /// 
        /// >  You can use this parameter to query only static routes in the specified route table. This parameter is incompatible with query conditions other than TransitRouterRouteEntryIds.
        /// </summary>
        [NameInMap("TransitRouterRouteEntryNames")]
        [Validation(Required=false)]
        public List<string> TransitRouterRouteEntryNames { get; set; }

        /// <summary>
        /// The ID of the network instance connection that you want to specify as the next hop.
        /// </summary>
        [NameInMap("TransitRouterRouteEntryNextHopId")]
        [Validation(Required=false)]
        public string TransitRouterRouteEntryNextHopId { get; set; }

        /// <summary>
        /// The next hop ID.
        /// </summary>
        [NameInMap("TransitRouterRouteEntryNextHopResourceId")]
        [Validation(Required=false)]
        public string TransitRouterRouteEntryNextHopResourceId { get; set; }

        /// <summary>
        /// The next hop type. Valid values:
        /// 
        /// *   **VPC**
        /// *   **VBR**
        /// *   **TR**
        /// *   **VPN**
        /// </summary>
        [NameInMap("TransitRouterRouteEntryNextHopResourceType")]
        [Validation(Required=false)]
        public string TransitRouterRouteEntryNextHopResourceType { get; set; }

        /// <summary>
        /// The next hop type. Valid values:
        /// 
        /// *   **BlackHole**: routes network traffic to a black hole.
        /// *   **Attachment**: routes network traffic to a network instance connection.
        /// </summary>
        [NameInMap("TransitRouterRouteEntryNextHopType")]
        [Validation(Required=false)]
        public string TransitRouterRouteEntryNextHopType { get; set; }

        /// <summary>
        /// The source instance ID.
        /// </summary>
        [NameInMap("TransitRouterRouteEntryOriginResourceId")]
        [Validation(Required=false)]
        public string TransitRouterRouteEntryOriginResourceId { get; set; }

        /// <summary>
        /// The source instance type. Valid values:
        /// 
        /// *   **VPC**
        /// *   **VBR**
        /// *   **TR**
        /// *   **VPN**
        /// </summary>
        [NameInMap("TransitRouterRouteEntryOriginResourceType")]
        [Validation(Required=false)]
        public string TransitRouterRouteEntryOriginResourceType { get; set; }

        /// <summary>
        /// The status of the route. Valid values:
        /// 
        /// *   **All**
        /// *   **Active** (default)
        /// *   **Rejected**
        /// *   **Prohibited**
        /// *   **Standby**
        /// *   **Candidate**
        /// 
        /// If you do not specify a value, routes in the active state are queried.
        /// </summary>
        [NameInMap("TransitRouterRouteEntryStatus")]
        [Validation(Required=false)]
        public string TransitRouterRouteEntryStatus { get; set; }

        /// <summary>
        /// The route type. Valid values:
        /// 
        /// *   **Propagated**: automatically learned by the route table.
        /// *   **Static**: static routes.
        /// </summary>
        [NameInMap("TransitRouterRouteEntryType")]
        [Validation(Required=false)]
        public string TransitRouterRouteEntryType { get; set; }

        /// <summary>
        /// The ID of the route table of the Enterprise Edition transit router.
        /// </summary>
        [NameInMap("TransitRouterRouteTableId")]
        [Validation(Required=false)]
        public string TransitRouterRouteTableId { get; set; }

    }

}
