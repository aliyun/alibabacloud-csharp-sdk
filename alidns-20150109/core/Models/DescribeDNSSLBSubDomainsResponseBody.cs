// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDNSSLBSubDomainsResponseBody : TeaModel {
        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The total number of subdomains returned.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The details of the subdomains.
        /// </summary>
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

                /// <summary>
                /// Indicates whether weighted round-robin is enabled for the subdomain.
                /// </summary>
                [NameInMap("Open")]
                [Validation(Required=false)]
                public bool? Open { get; set; }

                /// <summary>
                /// The number of DNS records added for the subdomain.
                /// </summary>
                [NameInMap("RecordCount")]
                [Validation(Required=false)]
                public long? RecordCount { get; set; }

                /// <summary>
                /// The subdomain.
                /// </summary>
                [NameInMap("SubDomain")]
                [Validation(Required=false)]
                public string SubDomain { get; set; }

                /// <summary>
                /// The type of the DNS record that supports weighted round-robin. Valid values: A, AAAA, and CNAME.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// The number of domain name groups.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
