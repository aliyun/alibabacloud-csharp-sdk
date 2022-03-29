// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeIstioGatewayDomainsResponseBody : TeaModel {
        [NameInMap("GatewaySecretDetails")]
        [Validation(Required=false)]
        public List<DescribeIstioGatewayDomainsResponseBodyGatewaySecretDetails> GatewaySecretDetails { get; set; }
        public class DescribeIstioGatewayDomainsResponseBodyGatewaySecretDetails : TeaModel {
            [NameInMap("CredentialName")]
            [Validation(Required=false)]
            public string CredentialName { get; set; }

            [NameInMap("Detail")]
            [Validation(Required=false)]
            public string Detail { get; set; }

            [NameInMap("Domains")]
            [Validation(Required=false)]
            public List<string> Domains { get; set; }

            [NameInMap("PortName")]
            [Validation(Required=false)]
            public string PortName { get; set; }

            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
