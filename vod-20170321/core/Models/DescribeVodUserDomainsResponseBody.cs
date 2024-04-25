// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodUserDomainsResponseBody : TeaModel {
        /// <summary>
        /// The detailed information about each domain name for CDN. The returned information is displayed in the format that is specified by the PageData parameter.
        /// </summary>
        [NameInMap("Domains")]
        [Validation(Required=false)]
        public DescribeVodUserDomainsResponseBodyDomains Domains { get; set; }
        public class DescribeVodUserDomainsResponseBodyDomains : TeaModel {
            [NameInMap("PageData")]
            [Validation(Required=false)]
            public List<DescribeVodUserDomainsResponseBodyDomainsPageData> PageData { get; set; }
            public class DescribeVodUserDomainsResponseBodyDomainsPageData : TeaModel {
                /// <summary>
                /// The CNAME that is assigned to the domain name for CDN.
                /// </summary>
                [NameInMap("Cname")]
                [Validation(Required=false)]
                public string Cname { get; set; }

                /// <summary>
                /// The remarks.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The domain name for CDN.
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// The status of the domain name for CDN. Valid values:
                /// 
                /// *   **online**: indicates that the domain name is enabled.
                /// *   **offline**: indicates that the domain name is disabled.
                /// *   **configuring**: indicates that the domain name is being configured.
                /// *   **configure_failed**: indicates that the domain name failed to be configured.
                /// *   **checking**: indicates that the domain name is under review.
                /// *   **check_failed**: indicates that the domain name failed the review.
                /// </summary>
                [NameInMap("DomainStatus")]
                [Validation(Required=false)]
                public string DomainStatus { get; set; }

                /// <summary>
                /// The time when the domain name for CDN was added. The time is in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("GmtCreated")]
                [Validation(Required=false)]
                public string GmtCreated { get; set; }

                /// <summary>
                /// The last time when the domain name for CDN was modified. The time is in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

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
                public DescribeVodUserDomainsResponseBodyDomainsPageDataSources Sources { get; set; }
                public class DescribeVodUserDomainsResponseBodyDomainsPageDataSources : TeaModel {
                    [NameInMap("Source")]
                    [Validation(Required=false)]
                    public List<DescribeVodUserDomainsResponseBodyDomainsPageDataSourcesSource> Source { get; set; }
                    public class DescribeVodUserDomainsResponseBodyDomainsPageDataSourcesSource : TeaModel {
                        /// <summary>
                        /// The address of the origin server.
                        /// </summary>
                        [NameInMap("Content")]
                        [Validation(Required=false)]
                        public string Content { get; set; }

                        /// <summary>
                        /// The port number. Valid values: **443** and **80**.
                        /// </summary>
                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public int? Port { get; set; }

                        /// <summary>
                        /// The priority of the origin server.
                        /// </summary>
                        [NameInMap("Priority")]
                        [Validation(Required=false)]
                        public string Priority { get; set; }

                        /// <summary>
                        /// The type of the origin server. Valid values:
                        /// 
                        /// *   **ipaddr**: an IP address.
                        /// *   **domain**: an origin domain name
                        /// *   **oss**: the OSS domain of an Object Storage Service (OSS) bucket
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                }

                /// <summary>
                /// Indicates whether HTTPS is enabled.
                /// 
                /// *   **on**: HTTPS is enabled.
                /// *   **off**: HTTPS is not eabled.
                /// </summary>
                [NameInMap("SslProtocol")]
                [Validation(Required=false)]
                public string SslProtocol { get; set; }

            }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
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
        /// The total number of entries.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
