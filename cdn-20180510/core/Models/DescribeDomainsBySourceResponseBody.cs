// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainsBySourceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DomainsList")]
        [Validation(Required=false)]
        public DescribeDomainsBySourceResponseBodyDomainsList DomainsList { get; set; }
        public class DescribeDomainsBySourceResponseBodyDomainsList : TeaModel {
            [NameInMap("DomainsData")]
            [Validation(Required=false)]
            public List<DescribeDomainsBySourceResponseBodyDomainsListDomainsData> DomainsData { get; set; }
            public class DescribeDomainsBySourceResponseBodyDomainsListDomainsData : TeaModel {
                [NameInMap("domainNames")]
                [Validation(Required=false)]
                public List<string> DomainNames { get; set; }

            }
        };

        [NameInMap("Sources")]
        [Validation(Required=false)]
        public string Sources { get; set; }

    }

}
