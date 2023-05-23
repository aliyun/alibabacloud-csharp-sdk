// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class DescribeCenRouteMapsRequest : TeaModel {
        /// <summary>
        /// The number of the page to return. Default value: **1**.
        /// </summary>
        [NameInMap("CenId")]
        [Validation(Required=false)]
        public string CenId { get; set; }

        /// <summary>
        /// The match method that is used to match routes based on the AS path.
        /// 
        /// *   **Include**: fuzzy match. A route is a match if the AS path of the route overlaps with the AS path specified in the match condition.
        /// *   **Complete**: exact match. A route is a match only if the AS path of the route is the same as the AS path specified in the match condition.
        /// </summary>
        [NameInMap("CenRegionId")]
        [Validation(Required=false)]
        public string CenRegionId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The route table ID of the transit router with which the routing policy is associated.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The IDs of the destination network instances to which the routes belong.
        /// 
        /// >  The destination network instance IDs are valid only when the routing policy is applied to scenarios where routes are advertised from the gateway in the current region to network instances in the current region.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// Indicates whether the destination network instance IDs are excluded.
        /// 
        /// *   **false** (default): A route is a match if its destination network instance ID is in the list specified by **DestinationInstanceIds.N**.
        /// *   **true**: A route is a match if its destination network instance ID is not in the list specified by **DestinationInstanceIds.N**.
        /// </summary>
        [NameInMap("RouteMapId")]
        [Validation(Required=false)]
        public string RouteMapId { get; set; }

        /// <summary>
        /// The priority of the routing policy that you want to associate with the current one.
        /// </summary>
        [NameInMap("TransitRouterRouteTableId")]
        [Validation(Required=false)]
        public string TransitRouterRouteTableId { get; set; }

        /// <summary>
        /// The match method that is used to match routes based on the community.
        /// 
        /// *   **Include**: fuzzy match. A route is a match if the community of the route overlaps with the community specified in the match condition.
        /// *   **Complete**: exact match. A route is a match only if the community of the route is the same as the community specified in the match condition.
        /// </summary>
        [NameInMap("TransmitDirection")]
        [Validation(Required=false)]
        public string TransmitDirection { get; set; }

    }

}
