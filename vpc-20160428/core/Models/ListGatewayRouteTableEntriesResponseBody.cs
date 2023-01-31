// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ListGatewayRouteTableEntriesResponseBody : TeaModel {
        [NameInMap("GatewayRouteEntryModels")]
        [Validation(Required=false)]
        public List<ListGatewayRouteTableEntriesResponseBodyGatewayRouteEntryModels> GatewayRouteEntryModels { get; set; }
        public class ListGatewayRouteTableEntriesResponseBodyGatewayRouteEntryModels : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("DestinationCidrBlock")]
            [Validation(Required=false)]
            public string DestinationCidrBlock { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("NextHopId")]
            [Validation(Required=false)]
            public string NextHopId { get; set; }

            [NameInMap("NextHopType")]
            [Validation(Required=false)]
            public string NextHopType { get; set; }

            [NameInMap("NextHops")]
            [Validation(Required=false)]
            public List<ListGatewayRouteTableEntriesResponseBodyGatewayRouteEntryModelsNextHops> NextHops { get; set; }
            public class ListGatewayRouteTableEntriesResponseBodyGatewayRouteEntryModelsNextHops : TeaModel {
                [NameInMap("Enabled")]
                [Validation(Required=false)]
                public string Enabled { get; set; }

                [NameInMap("NextHopId")]
                [Validation(Required=false)]
                public string NextHopId { get; set; }

                [NameInMap("NextHopType")]
                [Validation(Required=false)]
                public string NextHopType { get; set; }

                [NameInMap("Weight")]
                [Validation(Required=false)]
                public string Weight { get; set; }

            }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
