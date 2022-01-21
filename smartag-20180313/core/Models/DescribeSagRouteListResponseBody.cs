// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeSagRouteListResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Routes")]
        [Validation(Required=false)]
        public List<DescribeSagRouteListResponseBodyRoutes> Routes { get; set; }
        public class DescribeSagRouteListResponseBodyRoutes : TeaModel {
            [NameInMap("ConflictCidrs")]
            [Validation(Required=false)]
            public List<string> ConflictCidrs { get; set; }

            [NameInMap("Cost")]
            [Validation(Required=false)]
            public string Cost { get; set; }

            [NameInMap("DestinationCidr")]
            [Validation(Required=false)]
            public string DestinationCidr { get; set; }

            [NameInMap("NextHop")]
            [Validation(Required=false)]
            public string NextHop { get; set; }

            [NameInMap("PortName")]
            [Validation(Required=false)]
            public string PortName { get; set; }

            [NameInMap("RouteProtocol")]
            [Validation(Required=false)]
            public string RouteProtocol { get; set; }

        }

    }

}
