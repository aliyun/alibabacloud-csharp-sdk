// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeIstioGatewayDomainsResponseBody : TeaModel {
        /// <summary>
        /// The domain names that are exposed by the ASM gateway.
        /// </summary>
        [NameInMap("GatewaySecretDetails")]
        [Validation(Required=false)]
        public List<DescribeIstioGatewayDomainsResponseBodyGatewaySecretDetails> GatewaySecretDetails { get; set; }
        public class DescribeIstioGatewayDomainsResponseBodyGatewaySecretDetails : TeaModel {
            /// <summary>
            /// The name of the secret that contains the Transport Layer Security (TLS) certificate and certificate authority (CA) certificate.
            /// </summary>
            [NameInMap("CredentialName")]
            [Validation(Required=false)]
            public string CredentialName { get; set; }

            /// <summary>
            /// The details of the domain name in the JSON format.
            /// </summary>
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public string Detail { get; set; }

            /// <summary>
            /// The domain name.
            /// </summary>
            [NameInMap("Domains")]
            [Validation(Required=false)]
            public List<string> Domains { get; set; }

            /// <summary>
            /// The namespace in which the ASM gateway resides.
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

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

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
