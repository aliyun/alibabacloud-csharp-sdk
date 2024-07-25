// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class UpdateGatewayRouteRequest : TeaModel {
        [NameInMap("backendConfig")]
        [Validation(Required=false)]
        public GatewayRouteBackendConfig BackendConfig { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("domainConfig")]
        [Validation(Required=false)]
        public GatewayRouteDomainConfig DomainConfig { get; set; }

        [NameInMap("match")]
        [Validation(Required=false)]
        public HttpRouteMatch Match { get; set; }

    }

}
