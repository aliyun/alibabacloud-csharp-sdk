// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRouterRouteEntriesRequest : TeaModel {
        /// <summary>
        /// The number of entries to return on each page. Valid values: **1** to **100**. Default value: **20**.
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

        [NameInMap("PrefixListId")]
        [Validation(Required=false)]
        public string PrefixListId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("RouteFilter")]
        [Validation(Required=false)]
        public List<ListTransitRouterRouteEntriesRequestRouteFilter> RouteFilter { get; set; }
        public class ListTransitRouterRouteEntriesRequestRouteFilter : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

        }

        /// <summary>
        /// The destination CIDR block of the route.
        /// </summary>
        [NameInMap("TransitRouterRouteEntryDestinationCidrBlock")]
        [Validation(Required=false)]
        [Obsolete]
        public string TransitRouterRouteEntryDestinationCidrBlock { get; set; }

        /// <summary>
        /// The route entry ID.
        /// 
        /// You can specify at most 20 route IDs in each call.
        /// 
        /// >  You can use only this parameter to query static routes.
        /// </summary>
        [NameInMap("TransitRouterRouteEntryIds")]
        [Validation(Required=false)]
        public List<string> TransitRouterRouteEntryIds { get; set; }

        /// <summary>
        /// The route name.
        /// 
        /// The name must be 0 to 128 characters in length, and can contain letters, digits, and the following special characters: , . ; / @ \_ -.
        /// 
        /// You can specify at most 20 route names in each call.
        /// 
        /// >  You can use only this parameter to query static routes.
        /// </summary>
        [NameInMap("TransitRouterRouteEntryNames")]
        [Validation(Required=false)]
        public List<string> TransitRouterRouteEntryNames { get; set; }

        [NameInMap("TransitRouterRouteEntryNextHopId")]
        [Validation(Required=false)]
        public string TransitRouterRouteEntryNextHopId { get; set; }

        [NameInMap("TransitRouterRouteEntryNextHopResourceId")]
        [Validation(Required=false)]
        public string TransitRouterRouteEntryNextHopResourceId { get; set; }

        [NameInMap("TransitRouterRouteEntryNextHopResourceType")]
        [Validation(Required=false)]
        public string TransitRouterRouteEntryNextHopResourceType { get; set; }

        [NameInMap("TransitRouterRouteEntryNextHopType")]
        [Validation(Required=false)]
        public string TransitRouterRouteEntryNextHopType { get; set; }

        [NameInMap("TransitRouterRouteEntryOriginResourceId")]
        [Validation(Required=false)]
        public string TransitRouterRouteEntryOriginResourceId { get; set; }

        [NameInMap("TransitRouterRouteEntryOriginResourceType")]
        [Validation(Required=false)]
        public string TransitRouterRouteEntryOriginResourceType { get; set; }

        /// <summary>
        /// The status of the route. Valid values:
        /// 
        /// *   **Creating**: The route is being created.
        /// *   **Active**: The route is available.
        /// *   **Deleting**: The route is being deleted.
        /// </summary>
        [NameInMap("TransitRouterRouteEntryStatus")]
        [Validation(Required=false)]
        public string TransitRouterRouteEntryStatus { get; set; }

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
