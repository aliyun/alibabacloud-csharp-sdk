// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnIpaUserDomainsResponseBody : TeaModel {
        /// <summary>
        /// The status of the accelerated domain name. Valid values:
        /// 
        /// *   **online**: enabled
        /// *   **offline**: disabled
        /// *   **configuring**: configuring
        /// *   **configure_failed**: configuration failed
        /// *   **checking**: reviewing
        /// *   **check_failed**: review failed
        /// </summary>
        [NameInMap("Domains")]
        [Validation(Required=false)]
        public DescribeDcdnIpaUserDomainsResponseBodyDomains Domains { get; set; }
        public class DescribeDcdnIpaUserDomainsResponseBodyDomains : TeaModel {
            [NameInMap("PageData")]
            [Validation(Required=false)]
            public List<DescribeDcdnIpaUserDomainsResponseBodyDomainsPageData> PageData { get; set; }
            public class DescribeDcdnIpaUserDomainsResponseBodyDomainsPageData : TeaModel {
                /// <summary>
                /// The priority of the origin server.
                /// </summary>
                [NameInMap("Cname")]
                [Validation(Required=false)]
                public string Cname { get; set; }

                /// <summary>
                /// The time when the accelerated domain name was modified.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The address of the origin server.
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// The weight of the origin server if multiple origin servers have been specified.
                /// </summary>
                [NameInMap("DomainStatus")]
                [Validation(Required=false)]
                public string DomainStatus { get; set; }

                /// <summary>
                /// The CNAME assigned to the accelerated domain name.
                /// </summary>
                [NameInMap("GmtCreated")]
                [Validation(Required=false)]
                public string GmtCreated { get; set; }

                /// <summary>
                /// The port of the origin server.
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// The information about the origin server.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The accelerated domain name.
                /// </summary>
                [NameInMap("SSLProtocol")]
                [Validation(Required=false)]
                public string SSLProtocol { get; set; }

                /// <summary>
                /// The type of the origin server.
                /// </summary>
                [NameInMap("Sandbox")]
                [Validation(Required=false)]
                public string Sandbox { get; set; }

                /// <summary>
                /// >  You can call this operation up to 30 times per second per account.
                /// </summary>
                [NameInMap("Sources")]
                [Validation(Required=false)]
                public DescribeDcdnIpaUserDomainsResponseBodyDomainsPageDataSources Sources { get; set; }
                public class DescribeDcdnIpaUserDomainsResponseBodyDomainsPageDataSources : TeaModel {
                    [NameInMap("Source")]
                    [Validation(Required=false)]
                    public List<DescribeDcdnIpaUserDomainsResponseBodyDomainsPageDataSourcesSource> Source { get; set; }
                    public class DescribeDcdnIpaUserDomainsResponseBodyDomainsPageDataSourcesSource : TeaModel {
                        [NameInMap("Content")]
                        [Validation(Required=false)]
                        public string Content { get; set; }

                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public int? Port { get; set; }

                        [NameInMap("Priority")]
                        [Validation(Required=false)]
                        public string Priority { get; set; }

                        /// <summary>
                        /// Queries information about all domain names that are accelerated by IPA in your account.
                        ///                   Fuzzy search and filtering by domain name status are supported.
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        [NameInMap("Weight")]
                        [Validation(Required=false)]
                        public string Weight { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// The status of HTTPS.
        /// 
        /// *   **on**
        /// *   **off**
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The reason why the accelerated domain name failed the review.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the accelerated domain name was in a sandbox.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
