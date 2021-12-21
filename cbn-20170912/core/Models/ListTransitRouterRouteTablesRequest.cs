// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRouterRouteTablesRequest : TeaModel {
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

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

        [NameInMap("TransitRouterId")]
        [Validation(Required=false)]
        public string TransitRouterId { get; set; }

        [NameInMap("TransitRouterRouteTableIds")]
        [Validation(Required=false)]
        public List<string> TransitRouterRouteTableIds { get; set; }

        [NameInMap("TransitRouterRouteTableNames")]
        [Validation(Required=false)]
        public List<string> TransitRouterRouteTableNames { get; set; }

        [NameInMap("TransitRouterRouteTableStatus")]
        [Validation(Required=false)]
        public string TransitRouterRouteTableStatus { get; set; }

        [NameInMap("TransitRouterRouteTableType")]
        [Validation(Required=false)]
        public string TransitRouterRouteTableType { get; set; }

    }

}
