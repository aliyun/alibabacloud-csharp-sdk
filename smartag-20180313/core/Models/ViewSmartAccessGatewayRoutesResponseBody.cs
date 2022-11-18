// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class ViewSmartAccessGatewayRoutesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Routes")]
        [Validation(Required=false)]
        public List<ViewSmartAccessGatewayRoutesResponseBodyRoutes> Routes { get; set; }
        public class ViewSmartAccessGatewayRoutesResponseBodyRoutes : TeaModel {
            [NameInMap("ConflictCidrs")]
            [Validation(Required=false)]
            public List<string> ConflictCidrs { get; set; }

            [NameInMap("Cost")]
            [Validation(Required=false)]
            public string Cost { get; set; }

            [NameInMap("Dst")]
            [Validation(Required=false)]
            public string Dst { get; set; }

            [NameInMap("Idx")]
            [Validation(Required=false)]
            public int? Idx { get; set; }

            [NameInMap("Nexthop")]
            [Validation(Required=false)]
            public string Nexthop { get; set; }

            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
