// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRouterRouteTablesResponseBody : TeaModel {
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("TransitRouterRouteTables")]
        [Validation(Required=false)]
        public List<ListTransitRouterRouteTablesResponseBodyTransitRouterRouteTables> TransitRouterRouteTables { get; set; }
        public class ListTransitRouterRouteTablesResponseBodyTransitRouterRouteTables : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListTransitRouterRouteTablesResponseBodyTransitRouterRouteTablesTags> Tags { get; set; }
            public class ListTransitRouterRouteTablesResponseBodyTransitRouterRouteTablesTags : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("TransitRouterRouteTableDescription")]
            [Validation(Required=false)]
            public string TransitRouterRouteTableDescription { get; set; }

            [NameInMap("TransitRouterRouteTableId")]
            [Validation(Required=false)]
            public string TransitRouterRouteTableId { get; set; }

            [NameInMap("TransitRouterRouteTableName")]
            [Validation(Required=false)]
            public string TransitRouterRouteTableName { get; set; }

            [NameInMap("TransitRouterRouteTableStatus")]
            [Validation(Required=false)]
            public string TransitRouterRouteTableStatus { get; set; }

            [NameInMap("TransitRouterRouteTableType")]
            [Validation(Required=false)]
            public string TransitRouterRouteTableType { get; set; }

        }

    }

}
