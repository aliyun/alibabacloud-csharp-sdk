// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeGatewaySecretDetailsResponseBody : TeaModel {
        [NameInMap("GatewaySecretDetails")]
        [Validation(Required=false)]
        public List<DescribeGatewaySecretDetailsResponseBodyGatewaySecretDetails> GatewaySecretDetails { get; set; }
        public class DescribeGatewaySecretDetailsResponseBodyGatewaySecretDetails : TeaModel {
            [NameInMap("ExpiredTime")]
            [Validation(Required=false)]
            public string ExpiredTime { get; set; }

            [NameInMap("GatewayName")]
            [Validation(Required=false)]
            public string GatewayName { get; set; }

            [NameInMap("IssueTime")]
            [Validation(Required=false)]
            public string IssueTime { get; set; }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("SNI")]
            [Validation(Required=false)]
            public string SNI { get; set; }

            [NameInMap("SecretName")]
            [Validation(Required=false)]
            public string SecretName { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
