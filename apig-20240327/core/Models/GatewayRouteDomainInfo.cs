// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GatewayRouteDomainInfo : TeaModel {
        [NameInMap("domains")]
        [Validation(Required=false)]
        public List<GatewayRouteDomainInfoDomains> Domains { get; set; }
        public class GatewayRouteDomainInfoDomains : TeaModel {
            [NameInMap("domainId")]
            [Validation(Required=false)]
            public string DomainId { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

        }

    }

}
