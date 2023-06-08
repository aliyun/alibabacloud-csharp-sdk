// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeDomainsBySourceResponseBody : TeaModel {
        /// <summary>
        /// The domain names corresponding to each origin server.
        /// </summary>
        [NameInMap("DomainsList")]
        [Validation(Required=false)]
        public DescribeDomainsBySourceResponseBodyDomainsList DomainsList { get; set; }
        public class DescribeDomainsBySourceResponseBodyDomainsList : TeaModel {
            [NameInMap("DomainsData")]
            [Validation(Required=false)]
            public List<DescribeDomainsBySourceResponseBodyDomainsListDomainsData> DomainsData { get; set; }
            public class DescribeDomainsBySourceResponseBodyDomainsListDomainsData : TeaModel {
                /// <summary>
                /// Information about the domain name.
                /// </summary>
                [NameInMap("DomainInfos")]
                [Validation(Required=false)]
                public DescribeDomainsBySourceResponseBodyDomainsListDomainsDataDomainInfos DomainInfos { get; set; }
                public class DescribeDomainsBySourceResponseBodyDomainsListDomainsDataDomainInfos : TeaModel {
                    [NameInMap("domainInfo")]
                    [Validation(Required=false)]
                    public List<DescribeDomainsBySourceResponseBodyDomainsListDomainsDataDomainInfosDomainInfo> DomainInfo { get; set; }
                    public class DescribeDomainsBySourceResponseBodyDomainsListDomainsDataDomainInfosDomainInfo : TeaModel {
                        /// <summary>
                        /// The workload type of the accelerated domain name. Valid values:
                        /// 
                        /// *   **web**: images and small files
                        /// *   **download**: large files
                        /// *   **video**: on-demand video and audio streaming
                        /// </summary>
                        [NameInMap("CdnType")]
                        [Validation(Required=false)]
                        public string CdnType { get; set; }

                        /// <summary>
                        /// The creation time.
                        /// </summary>
                        [NameInMap("CreateTime")]
                        [Validation(Required=false)]
                        public string CreateTime { get; set; }

                        /// <summary>
                        /// The CNAME record assigned to the domain name.
                        /// </summary>
                        [NameInMap("DomainCname")]
                        [Validation(Required=false)]
                        public string DomainCname { get; set; }

                        /// <summary>
                        /// The domain name.
                        /// </summary>
                        [NameInMap("DomainName")]
                        [Validation(Required=false)]
                        public string DomainName { get; set; }

                        /// <summary>
                        /// The status of the domain name. Valid values:
                        /// 
                        /// *   **applying**: The domain name is under review.
                        /// *   **configuring**: The domain name is being configured.
                        /// *   **online**: The domain name is working as expected.
                        /// *   **stopping**: The domain name is being stopped.
                        /// *   **offline**: The domain name is disabled.
                        /// *   **disabling**: The domain name is being removed.
                        /// </summary>
                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                        /// <summary>
                        /// The update time.
                        /// </summary>
                        [NameInMap("UpdateTime")]
                        [Validation(Required=false)]
                        public string UpdateTime { get; set; }

                    }

                }

                /// <summary>
                /// The domain names that correspond to each origin server.
                /// </summary>
                [NameInMap("Domains")]
                [Validation(Required=false)]
                public DescribeDomainsBySourceResponseBodyDomainsListDomainsDataDomains Domains { get; set; }
                public class DescribeDomainsBySourceResponseBodyDomainsListDomainsDataDomains : TeaModel {
                    [NameInMap("domainNames")]
                    [Validation(Required=false)]
                    public List<string> DomainNames { get; set; }

                }

                /// <summary>
                /// The origin server.
                /// </summary>
                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The origin servers.
        /// </summary>
        [NameInMap("Sources")]
        [Validation(Required=false)]
        public string Sources { get; set; }

    }

}
