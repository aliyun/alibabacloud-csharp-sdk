// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeVsDomainDetailResponseBody : TeaModel {
        [NameInMap("DomainConfig")]
        [Validation(Required=false)]
        public DescribeVsDomainDetailResponseBodyDomainConfig DomainConfig { get; set; }
        public class DescribeVsDomainDetailResponseBodyDomainConfig : TeaModel {
            [NameInMap("Cname")]
            [Validation(Required=false)]
            public string Cname { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }
            [NameInMap("DomainStatus")]
            [Validation(Required=false)]
            public string DomainStatus { get; set; }
            [NameInMap("DomainType")]
            [Validation(Required=false)]
            public string DomainType { get; set; }
            [NameInMap("GmtCreated")]
            [Validation(Required=false)]
            public string GmtCreated { get; set; }
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }
            [NameInMap("SSLProtocol")]
            [Validation(Required=false)]
            public string SSLProtocol { get; set; }
            [NameInMap("Scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
