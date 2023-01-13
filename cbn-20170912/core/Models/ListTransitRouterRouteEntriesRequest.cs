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
        /// The token that determines the start point of the query. Valid values:
        /// 
        /// - If this is your first query or no subsequent query is to be sent, ignore this parameter.
        /// - If a subsequent query is to be sent, set the value to the value of **NextToken** that was returned from the last call.
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

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The destination CIDR block of the route.
        /// </summary>
        [NameInMap("TransitRouterRouteEntryDestinationCidrBlock")]
        [Validation(Required=false)]
        public string TransitRouterRouteEntryDestinationCidrBlock { get; set; }

        /// <summary>
        /// The IDs of the route entries.
        /// 
        /// You can query at most 20 route entries in each call.
        /// 
        /// >  You can call this operation to query only static routes.
        /// </summary>
        [NameInMap("TransitRouterRouteEntryIds")]
        [Validation(Required=false)]
        public List<string> TransitRouterRouteEntryIds { get; set; }

        /// <summary>
        /// The names of the routes.
        /// 
        /// The name must be 1 to 128 characters in length, and can contain letters, digits, and the following special characters: `, . ; / @ \_ -`. You can also leave the name empty.
        /// 
        /// You can query multiple route entries in each call. Maximum value of **N**: **20**.
        /// 
        /// >  You can call this operation to query only static routes.
        /// </summary>
        [NameInMap("TransitRouterRouteEntryNames")]
        [Validation(Required=false)]
        public List<string> TransitRouterRouteEntryNames { get; set; }

        /// <summary>
        /// The status of the route. Valid values: Valid values:
        /// 
        /// - **Creating**: The route is being created.
        /// - **Active**: The rule is available.
        /// - **Deleting**: The rule is being deleted.
        /// </summary>
        [NameInMap("TransitRouterRouteEntryStatus")]
        [Validation(Required=false)]
        public string TransitRouterRouteEntryStatus { get; set; }

        /// <summary>
        /// The ID of the route table of the Enterprise Edition transit router.
        /// </summary>
        [NameInMap("TransitRouterRouteTableId")]
        [Validation(Required=false)]
        public string TransitRouterRouteTableId { get; set; }

    }

}
