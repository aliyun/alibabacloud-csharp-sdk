// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnUserDomainsByFuncResponseBody : TeaModel {
        /// <summary>
        /// The array that consists of multiple PageData parameters. The details about each accelerated domain name are included in a separate PageData parameter.
        /// </summary>
        [NameInMap("Domains")]
        [Validation(Required=false)]
        public DescribeDcdnUserDomainsByFuncResponseBodyDomains Domains { get; set; }
        public class DescribeDcdnUserDomainsByFuncResponseBodyDomains : TeaModel {
            [NameInMap("PageData")]
            [Validation(Required=false)]
            public List<DescribeDcdnUserDomainsByFuncResponseBodyDomainsPageData> PageData { get; set; }
            public class DescribeDcdnUserDomainsByFuncResponseBodyDomainsPageData : TeaModel {
                /// <summary>
                /// The CNAME assigned to the accelerated domain name.
                /// </summary>
                [NameInMap("Cname")]
                [Validation(Required=false)]
                public string Cname { get; set; }

                /// <summary>
                /// The reason why the accelerated domain name failed the review.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The accelerated domain name.
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// The status of the accelerated domain name. Valid values:
                /// 
                /// *   **online**
                /// *   **offline**
                /// *   **configuring**
                /// *   **configure_failed**
                /// *   **checking**
                /// *   **check_failed**
                /// </summary>
                [NameInMap("DomainStatus")]
                [Validation(Required=false)]
                public string DomainStatus { get; set; }

                /// <summary>
                /// The time when the accelerated domain name was added to Dynamic Content Delivery Network (DCDN).
                /// </summary>
                [NameInMap("GmtCreated")]
                [Validation(Required=false)]
                public string GmtCreated { get; set; }

                /// <summary>
                /// The time when the accelerated domain name was modified.
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// The ID of the resource group.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// Indicates whether the accelerated domain name was in a sandbox.
                /// </summary>
                [NameInMap("Sandbox")]
                [Validation(Required=false)]
                public string Sandbox { get; set; }

                /// <summary>
                /// The information about the origin server.
                /// </summary>
                [NameInMap("Sources")]
                [Validation(Required=false)]
                public DescribeDcdnUserDomainsByFuncResponseBodyDomainsPageDataSources Sources { get; set; }
                public class DescribeDcdnUserDomainsByFuncResponseBodyDomainsPageDataSources : TeaModel {
                    [NameInMap("Source")]
                    [Validation(Required=false)]
                    public List<DescribeDcdnUserDomainsByFuncResponseBodyDomainsPageDataSourcesSource> Source { get; set; }
                    public class DescribeDcdnUserDomainsByFuncResponseBodyDomainsPageDataSourcesSource : TeaModel {
                        /// <summary>
                        /// The address of the origin server.
                        /// </summary>
                        [NameInMap("Content")]
                        [Validation(Required=false)]
                        public string Content { get; set; }

                        /// <summary>
                        /// The port of the origin server.
                        /// </summary>
                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public int? Port { get; set; }

                        /// <summary>
                        /// The priority.
                        /// </summary>
                        [NameInMap("Priority")]
                        [Validation(Required=false)]
                        public string Priority { get; set; }

                        /// <summary>
                        /// The type of the origin server.
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        /// <summary>
                        /// The weight of the origin server if multiple origin servers have been specified.
                        /// </summary>
                        [NameInMap("Weight")]
                        [Validation(Required=false)]
                        public string Weight { get; set; }

                    }

                }

                /// <summary>
                /// Indicates whether HTTPS is enabled. Valid values:
                /// 
                /// *   **on**
                /// *   **off**
                /// </summary>
                [NameInMap("SslProtocol")]
                [Validation(Required=false)]
                public string SslProtocol { get; set; }

            }

        }

        /// <summary>
        /// The number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
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
        /// The total number of domain names returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
