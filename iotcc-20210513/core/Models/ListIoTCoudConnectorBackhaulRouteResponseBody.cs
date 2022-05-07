// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IoTCC20210513.Models
{
    public class ListIoTCoudConnectorBackhaulRouteResponseBody : TeaModel {
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Routes")]
        [Validation(Required=false)]
        public List<ListIoTCoudConnectorBackhaulRouteResponseBodyRoutes> Routes { get; set; }
        public class ListIoTCoudConnectorBackhaulRouteResponseBodyRoutes : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("DestinationCidrBlock")]
            [Validation(Required=false)]
            public string DestinationCidrBlock { get; set; }

            [NameInMap("NextHopId")]
            [Validation(Required=false)]
            public string NextHopId { get; set; }

            [NameInMap("NextHopType")]
            [Validation(Required=false)]
            public string NextHopType { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
