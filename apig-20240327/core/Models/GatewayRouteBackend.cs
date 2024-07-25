// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GatewayRouteBackend : TeaModel {
        [NameInMap("services")]
        [Validation(Required=false)]
        public List<GatewayRouteBackendServices> Services { get; set; }
        public class GatewayRouteBackendServices : TeaModel {
            [NameInMap("gatewayServiceId")]
            [Validation(Required=false)]
            public string GatewayServiceId { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            [NameInMap("protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            [NameInMap("weight")]
            [Validation(Required=false)]
            public float? Weight { get; set; }

        }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
