// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRouterRouteTablesResponseBody : TeaModel {
        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token that determines the start point of the query. Valid values:
        /// 
        /// *   If **NextToken** was not returned in the previous query, it indicates that no additional results exist.
        /// *   If **NextToken** was returned in the previous query, specify the value to obtain the next set of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// A list of route tables.
        /// </summary>
        [NameInMap("TransitRouterRouteTables")]
        [Validation(Required=false)]
        public List<ListTransitRouterRouteTablesResponseBodyTransitRouterRouteTables> TransitRouterRouteTables { get; set; }
        public class ListTransitRouterRouteTablesResponseBodyTransitRouterRouteTables : TeaModel {
            /// <summary>
            /// The time when the route table was created.
            /// 
            /// The time follows the ISO8601 standard in the YYYY-MM-DDThh:mmZ format. The time is displayed in UTC.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("RouteTableOptions")]
            [Validation(Required=false)]
            public ListTransitRouterRouteTablesResponseBodyTransitRouterRouteTablesRouteTableOptions RouteTableOptions { get; set; }
            public class ListTransitRouterRouteTablesResponseBodyTransitRouterRouteTablesRouteTableOptions : TeaModel {
                [NameInMap("MultiRegionECMP")]
                [Validation(Required=false)]
                public string MultiRegionECMP { get; set; }

            }

            /// <summary>
            /// The tags of the resource.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListTransitRouterRouteTablesResponseBodyTransitRouterRouteTablesTags> Tags { get; set; }
            public class ListTransitRouterRouteTablesResponseBodyTransitRouterRouteTablesTags : TeaModel {
                /// <summary>
                /// The key of the tag.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The value of the tag.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The description of the route table.
            /// </summary>
            [NameInMap("TransitRouterRouteTableDescription")]
            [Validation(Required=false)]
            public string TransitRouterRouteTableDescription { get; set; }

            /// <summary>
            /// The ID of the route table.
            /// </summary>
            [NameInMap("TransitRouterRouteTableId")]
            [Validation(Required=false)]
            public string TransitRouterRouteTableId { get; set; }

            /// <summary>
            /// The name of the route table.
            /// </summary>
            [NameInMap("TransitRouterRouteTableName")]
            [Validation(Required=false)]
            public string TransitRouterRouteTableName { get; set; }

            /// <summary>
            /// The status of the route table.
            /// 
            /// *   **Creating**: being created
            /// *   **Deleting**: being deleted
            /// *   **Active**: available
            /// </summary>
            [NameInMap("TransitRouterRouteTableStatus")]
            [Validation(Required=false)]
            public string TransitRouterRouteTableStatus { get; set; }

            /// <summary>
            /// The type of the route table.
            /// 
            /// *   **Custom**: a custom route table
            /// *   **System**: the default route table
            /// </summary>
            [NameInMap("TransitRouterRouteTableType")]
            [Validation(Required=false)]
            public string TransitRouterRouteTableType { get; set; }

        }

    }

}
