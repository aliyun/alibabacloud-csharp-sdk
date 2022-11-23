// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDNSSLBSubDomainsResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SlbSubDomains")]
        [Validation(Required=false)]
        public DescribeDNSSLBSubDomainsResponseBodySlbSubDomains SlbSubDomains { get; set; }
        public class DescribeDNSSLBSubDomainsResponseBodySlbSubDomains : TeaModel {
            [NameInMap("SlbSubDomain")]
            [Validation(Required=false)]
            public List<DescribeDNSSLBSubDomainsResponseBodySlbSubDomainsSlbSubDomain> SlbSubDomain { get; set; }
            public class DescribeDNSSLBSubDomainsResponseBodySlbSubDomainsSlbSubDomain : TeaModel {
                [NameInMap("LineAlgorithms")]
                [Validation(Required=false)]
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

                [NameInMap("Open")]
                [Validation(Required=false)]
                public bool? Open { get; set; }

                [NameInMap("RecordCount")]
                [Validation(Required=false)]
                public long? RecordCount { get; set; }

                [NameInMap("SubDomain")]
                [Validation(Required=false)]
                public string SubDomain { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
