// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRouterRouteEntriesResponseBody : TeaModel {
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

        [NameInMap("TransitRouterRouteEntries")]
        [Validation(Required=false)]
        public List<ListTransitRouterRouteEntriesResponseBodyTransitRouterRouteEntries> TransitRouterRouteEntries { get; set; }
        public class ListTransitRouterRouteEntriesResponseBodyTransitRouterRouteEntries : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("TransitRouterRouteEntryDescription")]
            [Validation(Required=false)]
            public string TransitRouterRouteEntryDescription { get; set; }

            [NameInMap("TransitRouterRouteEntryDestinationCidrBlock")]
            [Validation(Required=false)]
            public string TransitRouterRouteEntryDestinationCidrBlock { get; set; }

            [NameInMap("TransitRouterRouteEntryId")]
            [Validation(Required=false)]
            public string TransitRouterRouteEntryId { get; set; }

            [NameInMap("TransitRouterRouteEntryName")]
            [Validation(Required=false)]
            public string TransitRouterRouteEntryName { get; set; }

            [NameInMap("TransitRouterRouteEntryNextHopId")]
            [Validation(Required=false)]
            public string TransitRouterRouteEntryNextHopId { get; set; }

            [NameInMap("TransitRouterRouteEntryNextHopType")]
            [Validation(Required=false)]
            public string TransitRouterRouteEntryNextHopType { get; set; }

            [NameInMap("TransitRouterRouteEntryStatus")]
            [Validation(Required=false)]
            public string TransitRouterRouteEntryStatus { get; set; }

            [NameInMap("TransitRouterRouteEntryType")]
            [Validation(Required=false)]
            public string TransitRouterRouteEntryType { get; set; }

        }

    }

}
