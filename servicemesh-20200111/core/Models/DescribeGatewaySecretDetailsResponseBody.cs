// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeGatewaySecretDetailsResponseBody : TeaModel {
        /// <summary>
        /// The detailed information about the secret of the ASM gateway.
        /// </summary>
        [NameInMap("GatewaySecretDetails")]
        [Validation(Required=false)]
        public List<DescribeGatewaySecretDetailsResponseBodyGatewaySecretDetails> GatewaySecretDetails { get; set; }
        public class DescribeGatewaySecretDetailsResponseBodyGatewaySecretDetails : TeaModel {
            /// <summary>
            /// The time when the certificate expires.
            /// </summary>
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            /// <summary>
            /// The name of the gateway.
            /// </summary>
            [NameInMap("GatewayName")]
            [Validation(Required=false)]
            public string GatewayName { get; set; }

            /// <summary>
            /// The time when the certificate was issued.
            /// </summary>
            [NameInMap("IssueTime")]
            [Validation(Required=false)]
            public string IssueTime { get; set; }

            /// <summary>
            /// *   An error message is returned if the status of the gateway is abnormal. Examples: `tls.crt not exist`, `tls.key not exist`, and `secret type must be kubernetes.io/tls`.
            /// *   An empty value is returned if the status of the gateway is normal.
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// The Server Name Indication (SNI) value.
            /// </summary>
            [NameInMap("SNI")]
            [Validation(Required=false)]
            public string SNI { get; set; }

            /// <summary>
            /// The name of the secret.
            /// </summary>
            [NameInMap("SecretName")]
            [Validation(Required=false)]
            public string SecretName { get; set; }

            /// <summary>
            /// The status of the certificate. Valid values:
            /// 
            /// *   `normal`
            /// *   `abnormal`
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
