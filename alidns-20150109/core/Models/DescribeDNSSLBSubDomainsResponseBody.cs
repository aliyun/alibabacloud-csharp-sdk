// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDNSSLBSubDomainsResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("SlbSubDomains")]
        [Validation(Required=false)]
        public DescribeDNSSLBSubDomainsResponseBodySlbSubDomains SlbSubDomains { get; set; }
        public class DescribeDNSSLBSubDomainsResponseBodySlbSubDomains : TeaModel {
            [NameInMap("SlbSubDomain")]
            [Validation(Required=false)]
            public List<DescribeDNSSLBSubDomainsResponseBodySlbSubDomainsSlbSubDomain> SlbSubDomain { get; set; }
            public class DescribeDNSSLBSubDomainsResponseBodySlbSubDomainsSlbSubDomain : TeaModel {
                public string Type { get; set; }
                public long? RecordCount { get; set; }
                public bool? Open { get; set; }
                public string SubDomain { get; set; }
                public DescribeDNSSLBSubDomainsResponseBodySlbSubDomainsSlbSubDomainLineAlgorithms LineAlgorithms { get; set; }
                public class DescribeDNSSLBSubDomainsResponseBodySlbSubDomainsSlbSubDomainLineAlgorithms : TeaModel {
                    [NameInMap("LineAlgorithm")]
                    [Validation(Required=false)]
                    public List<DescribeDNSSLBSubDomainsResponseBodySlbSubDomainsSlbSubDomainLineAlgorithmsLineAlgorithm> LineAlgorithm { get; set; }
                    public class DescribeDNSSLBSubDomainsResponseBodySlbSubDomainsSlbSubDomainLineAlgorithmsLineAlgorithm : TeaModel {
                        [NameInMap("Line")]
                        [Validation(Required=false)]
                        public string Line { get; set; }

                        [NameInMap("Open")]
                        [Validation(Required=false)]
                        public bool? Open { get; set; }

                    }

                }
            }
        };

    }

}
