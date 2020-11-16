// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDomainDetailResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("DomainDetail")]
        [Validation(Required=true)]
        public DescribeLiveDomainDetailResponseDomainDetail DomainDetail { get; set; }
        public class DescribeLiveDomainDetailResponseDomainDetail : TeaModel {
            [NameInMap("GmtCreated")]
            [Validation(Required=true)]
            public string GmtCreated { get; set; }
            [NameInMap("GmtModified")]
            [Validation(Required=true)]
            public string GmtModified { get; set; }
            [NameInMap("DomainStatus")]
            [Validation(Required=true)]
            public string DomainStatus { get; set; }
            [NameInMap("Cname")]
            [Validation(Required=true)]
            public string Cname { get; set; }
            [NameInMap("DomainName")]
            [Validation(Required=true)]
            public string DomainName { get; set; }
            [NameInMap("LiveDomainType")]
            [Validation(Required=true)]
            public string LiveDomainType { get; set; }
            [NameInMap("Region")]
            [Validation(Required=true)]
            public string Region { get; set; }
            [NameInMap("Description")]
            [Validation(Required=true)]
            public string Description { get; set; }
            [NameInMap("SSLProtocol")]
            [Validation(Required=true)]
            public string SSLProtocol { get; set; }
            [NameInMap("SSLPub")]
            [Validation(Required=true)]
            public string SSLPub { get; set; }
            [NameInMap("Scope")]
            [Validation(Required=true)]
            public string Scope { get; set; }
            [NameInMap("CertName")]
            [Validation(Required=true)]
            public string CertName { get; set; }
        };

    }

}
