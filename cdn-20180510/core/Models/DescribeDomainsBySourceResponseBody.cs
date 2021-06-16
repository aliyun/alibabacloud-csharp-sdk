// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainsBySourceResponseBody : TeaModel {
        [NameInMap("Sources")]
        [Validation(Required=false)]
        public string Sources { get; set; }

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
                public string Source { get; set; }
                public DescribeDomainsBySourceResponseBodyDomainsListDomainsDataDomainInfos DomainInfos { get; set; }
                public class DescribeDomainsBySourceResponseBodyDomainsListDomainsDataDomainInfos : TeaModel {
                    [NameInMap("domainInfo")]
                    [Validation(Required=false)]
                    public List<DescribeDomainsBySourceResponseBodyDomainsListDomainsDataDomainInfosDomainInfo> DomainInfo { get; set; }
                    public class DescribeDomainsBySourceResponseBodyDomainsListDomainsDataDomainInfosDomainInfo : TeaModel {
                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                        [NameInMap("UpdateTime")]
                        [Validation(Required=false)]
                        public string UpdateTime { get; set; }

                        [NameInMap("DomainCname")]
                        [Validation(Required=false)]
                        public string DomainCname { get; set; }

                        [NameInMap("DomainName")]
                        [Validation(Required=false)]
                        public string DomainName { get; set; }

                        [NameInMap("CreateTime")]
                        [Validation(Required=false)]
                        public string CreateTime { get; set; }

                    }

                }
                public DescribeDomainsBySourceResponseBodyDomainsListDomainsDataDomains Domains { get; set; }
                public class DescribeDomainsBySourceResponseBodyDomainsListDomainsDataDomains : TeaModel {
                    [NameInMap("domainNames")]
                    [Validation(Required=false)]
                    public List<string> DomainNames { get; set; }

                }
            }
        };

    }

}
