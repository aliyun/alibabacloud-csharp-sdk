// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GatewayService : TeaModel {
        [NameInMap("addresses")]
        [Validation(Required=false)]
        public List<string> Addresses { get; set; }

        [NameInMap("createTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        [NameInMap("gatewayServiceId")]
        [Validation(Required=false)]
        public string GatewayServiceId { get; set; }

        [NameInMap("healthCheck")]
        [Validation(Required=false)]
        public ServiceHealthCheck HealthCheck { get; set; }

        [NameInMap("healthStatus")]
        [Validation(Required=false)]
        public string HealthStatus { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("ports")]
        [Validation(Required=false)]
        public List<GatewayServicePorts> Ports { get; set; }
        public class GatewayServicePorts : TeaModel {
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            [NameInMap("protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

        }

        [NameInMap("qualifier")]
        [Validation(Required=false)]
        public string Qualifier { get; set; }

        [NameInMap("sourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        [NameInMap("unhealthyEndpoints")]
        [Validation(Required=false)]
        public List<string> UnhealthyEndpoints { get; set; }

        [NameInMap("updateTimestamp")]
        [Validation(Required=false)]
        public long? UpdateTimestamp { get; set; }

    }

}
