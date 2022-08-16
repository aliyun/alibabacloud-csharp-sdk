// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CC5G20220314.Models
{
    public class ListIoTCloudConnectorBackhaulRouteResponseBody : TeaModel {
        [NameInMap("NetLinkId")]
        [Validation(Required=false)]
        public string NetLinkId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Routes")]
        [Validation(Required=false)]
        public List<ListIoTCloudConnectorBackhaulRouteResponseBodyRoutes> Routes { get; set; }
        public class ListIoTCloudConnectorBackhaulRouteResponseBodyRoutes : TeaModel {
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

    }

}
