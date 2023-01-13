// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRouterRouteTablesRequest : TeaModel {
        /// <summary>
        /// The number of entries to return on each page. Valid values: **1** to **100**. Default value: **20**.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token that determines the start point of the query. Valid values:
        /// 
        /// *   If this is your first query or no subsequent query is to be sent, ignore this parameter.
        /// *   If a next query is to be sent, set the value to the value of **NextToken** that is returned from the last call.
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

        [NameInMap("RouteTableOptions")]
        [Validation(Required=false)]
        public ListTransitRouterRouteTablesRequestRouteTableOptions RouteTableOptions { get; set; }
        public class ListTransitRouterRouteTablesRequestRouteTableOptions : TeaModel {
            [NameInMap("MultiRegionECMP")]
            [Validation(Required=false)]
            public string MultiRegionECMP { get; set; }

        }

        /// <summary>
        /// The tags.
        /// 
        /// You can specify at most 20 tags.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListTransitRouterRouteTablesRequestTag> Tag { get; set; }
        public class ListTransitRouterRouteTablesRequestTag : TeaModel {
            /// <summary>
            /// The tag keys of the resources. 
            /// 
            /// The tag keys cannot be an empty string. The tag keys can be up to 64 characters in length and cannot start with `acs:` or `aliyun`. It cannot contain `http://` or `https://`.  
            /// 
            /// You can specify at most 20 tag keys.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag values of the resources.
            /// 
            /// The tag values can be 0 to 128 characters in length, and cannot start with `aliyun` or `acs:`. It cannot contain `http://` or `https://`.
            /// 
            /// Each tag key has a unique tag value. You can specify at most 20 tag values in each call.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The ID of the Enterprise Edition transit router.
        /// </summary>
        [NameInMap("TransitRouterId")]
        [Validation(Required=false)]
        public string TransitRouterId { get; set; }

        /// <summary>
        /// The IDs of the route tables.
        /// 
        /// You can query at most 20 route tables in each call.
        /// </summary>
        [NameInMap("TransitRouterRouteTableIds")]
        [Validation(Required=false)]
        public List<string> TransitRouterRouteTableIds { get; set; }

        /// <summary>
        /// The names of the route tables.
        /// 
        /// You can query multiple route tables in each call. Maximum value of **N**: **20**.
        /// 
        /// >  If you specify set both **TransitRouterRouteTableNames.N** and **TransitRouterRouteTableIds.N**, make sure that the specified name and ID belong to the same route table.
        /// </summary>
        [NameInMap("TransitRouterRouteTableNames")]
        [Validation(Required=false)]
        public List<string> TransitRouterRouteTableNames { get; set; }

        /// <summary>
        /// The status of the route table. Valid values:
        /// 
        /// *   **Creating**: being created
        /// *   **Deleting**: being deleted
        /// *   **Active**: available
        /// </summary>
        [NameInMap("TransitRouterRouteTableStatus")]
        [Validation(Required=false)]
        public string TransitRouterRouteTableStatus { get; set; }

        /// <summary>
        /// The type of the route table. Valid values:
        /// 
        /// *   **Custom**: a custom route table
        /// *   **System**: the default route table
        /// </summary>
        [NameInMap("TransitRouterRouteTableType")]
        [Validation(Required=false)]
        public string TransitRouterRouteTableType { get; set; }

    }

}
