// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class CreateIstioGatewayDomainsRequest : TeaModel {
        /// <summary>
        /// The name of the secret that contains the Transport Layer Security (TLS) certificate and certificate authority (CA) certificate.
        /// </summary>
        [NameInMap("Credential")]
        [Validation(Required=false)]
        public string Credential { get; set; }

        /// <summary>
        /// Specifies whether to forcibly use TLS to protect connection security.
        /// 
        /// *   `true`: forcibly uses TLS to protect connection security.
        /// *   `false`: does not forcibly use TLS to protect connection security.
        /// </summary>
        [NameInMap("ForceHttps")]
        [Validation(Required=false)]
        public bool? ForceHttps { get; set; }

        /// <summary>
        /// The one or more domain names that are exposed by the ASM gateway. Separate multiple domain names with commas (,).
        /// </summary>
        [NameInMap("Hosts")]
        [Validation(Required=false)]
        public string Hosts { get; set; }

        /// <summary>
        /// The name of the ASM gateway.
        /// </summary>
        [NameInMap("IstioGatewayName")]
        [Validation(Required=false)]
        public string IstioGatewayName { get; set; }

        /// <summary>
        /// The maximum number of ASM gateways to query.
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public string Limit { get; set; }

        /// <summary>
        /// The name of the namespace.
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// The port that is provided by the ASM gateway.
        /// </summary>
        [NameInMap("Number")]
        [Validation(Required=false)]
        public int? Number { get; set; }

        /// <summary>
        /// The name of the port.
        /// </summary>
        [NameInMap("PortName")]
        [Validation(Required=false)]
        public string PortName { get; set; }

        /// <summary>
        /// The type of the protocol. Valid values: `HTTP`, `HTTPS`, `GRPC`, `HTTP2`, `MONGO`, `TCP`, and `TLS`.
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// The ASM instance ID.
        /// </summary>
        [NameInMap("ServiceMeshId")]
        [Validation(Required=false)]
        public string ServiceMeshId { get; set; }

    }

}
