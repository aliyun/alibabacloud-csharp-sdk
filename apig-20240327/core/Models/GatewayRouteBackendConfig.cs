// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GatewayRouteBackendConfig : TeaModel {
        [NameInMap("services")]
        [Validation(Required=false)]
        public List<GatewayRouteBackendConfigServices> Services { get; set; }
        public class GatewayRouteBackendConfigServices : TeaModel {
            [NameInMap("gatewayServiceId")]
            [Validation(Required=false)]
            public string GatewayServiceId { get; set; }

            [NameInMap("port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            [NameInMap("protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            [NameInMap("sourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            [NameInMap("weight")]
            [Validation(Required=false)]
            public float? Weight { get; set; }

        }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
