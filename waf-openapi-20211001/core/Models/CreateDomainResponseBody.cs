// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class CreateDomainResponseBody : TeaModel {
        [NameInMap("DomainInfo")]
        [Validation(Required=false)]
        public CreateDomainResponseBodyDomainInfo DomainInfo { get; set; }
        public class CreateDomainResponseBodyDomainInfo : TeaModel {
            [NameInMap("Cname")]
            [Validation(Required=false)]
            public string Cname { get; set; }

            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
