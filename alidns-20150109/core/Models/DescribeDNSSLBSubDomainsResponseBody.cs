// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDNSSLBSubDomainsResponseBody : TeaModel {
        /// <summary>
        /// The page number. Pages start from page **1**. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Valid values: **1 to 100**. Default value: **20**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The subdomains for which weighted round-robin is enabled.
        /// </summary>
        [NameInMap("SlbSubDomains")]
        [Validation(Required=false)]
        public DescribeDNSSLBSubDomainsResponseBodySlbSubDomains SlbSubDomains { get; set; }
        public class DescribeDNSSLBSubDomainsResponseBodySlbSubDomains : TeaModel {
            [NameInMap("SlbSubDomain")]
            [Validation(Required=false)]
            public List<DescribeDNSSLBSubDomainsResponseBodySlbSubDomainsSlbSubDomain> SlbSubDomain { get; set; }
            public class DescribeDNSSLBSubDomainsResponseBodySlbSubDomainsSlbSubDomain : TeaModel {
                /// <summary>
                /// The lines for which weighted round-robin is enabled.
                /// </summary>
                [NameInMap("LineAlgorithms")]
                [Validation(Required=false)]
                public DescribeDNSSLBSubDomainsResponseBodySlbSubDomainsSlbSubDomainLineAlgorithms LineAlgorithms { get; set; }
                public class DescribeDNSSLBSubDomainsResponseBodySlbSubDomainsSlbSubDomainLineAlgorithms : TeaModel {
                    [NameInMap("LineAlgorithm")]
                    [Validation(Required=false)]
                    public List<DescribeDNSSLBSubDomainsResponseBodySlbSubDomainsSlbSubDomainLineAlgorithmsLineAlgorithm> LineAlgorithm { get; set; }
                    public class DescribeDNSSLBSubDomainsResponseBodySlbSubDomainsSlbSubDomainLineAlgorithmsLineAlgorithm : TeaModel {
                        /// <summary>
                        /// The DNS resolution line. The line can be China Telecom, China Mobile, and China Unicom.
                        /// </summary>
                        [NameInMap("Line")]
                        [Validation(Required=false)]
                        public string Line { get; set; }

                        /// <summary>
                        /// Indicates whether weighted round-robin is enabled for the line. Valid values:
                        /// 
                        /// *   **true** (default): Weighted round-robin is enabled.
                        /// *   **false**: Weighted round-robin is disabled.
                        /// </summary>
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
                /// The subdomain name.
                /// </summary>
                [NameInMap("SubDomain")]
                [Validation(Required=false)]
                public string SubDomain { get; set; }

                /// <summary>
                /// The type of the Domain Name System (DNS) record that supports weighted round-robin. Valid values: A, AAAA, and CNAME.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
