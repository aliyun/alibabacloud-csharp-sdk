// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodUserDomainsResponseBody : TeaModel {
        /// <summary>
        /// The status of the domain name. The value of this parameter is used as a condition to filter domain names. Value values:
        /// 
        /// *   **online**: indicates that the domain name is enabled.
        /// *   **offline**: indicates that the domain name is disabled.
        /// *   **configuring**: indicates that the domain name is being configured.
        /// *   **configure_failed**: indicates that the domain name failed to be configured.
        /// *   **checking**: indicates that the domain name is under review.
        /// *   **check_failed**: indicates that the domain name failed the review.
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
                /// Queries the domain names for CDN within your Alibaba Cloud account. You can filter domain names by name or by state. When you filter domain names by name, a fuzzy match is supported.
                /// </summary>
                [NameInMap("Cname")]
                [Validation(Required=false)]
                public string Cname { get; set; }

                /// <summary>
                /// The number of entries returned per page.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                [NameInMap("DomainStatus")]
                [Validation(Required=false)]
                public string DomainStatus { get; set; }

                /// <summary>
                /// The page number of the returned page.
                /// </summary>
                [NameInMap("GmtCreated")]
                [Validation(Required=false)]
                public string GmtCreated { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// The ID of the request.
                /// </summary>
                [NameInMap("Sandbox")]
                [Validation(Required=false)]
                public string Sandbox { get; set; }

                [NameInMap("Sources")]
                [Validation(Required=false)]
                public DescribeVodUserDomainsResponseBodyDomainsPageDataSources Sources { get; set; }
                public class DescribeVodUserDomainsResponseBodyDomainsPageDataSources : TeaModel {
                    [NameInMap("Source")]
                    [Validation(Required=false)]
                    public List<DescribeVodUserDomainsResponseBodyDomainsPageDataSourcesSource> Source { get; set; }
                    public class DescribeVodUserDomainsResponseBodyDomainsPageDataSourcesSource : TeaModel {
                        [NameInMap("Content")]
                        [Validation(Required=false)]
                        public string Content { get; set; }

                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public int? Port { get; set; }

                        [NameInMap("Priority")]
                        [Validation(Required=false)]
                        public string Priority { get; set; }

                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                }

                /// <summary>
                /// The key of tag N. Valid values of N: **1** to **20**.
                /// 
                /// If you do not specify this parameter, all tag keys are queried.
                /// </summary>
                [NameInMap("SslProtocol")]
                [Validation(Required=false)]
                public string SslProtocol { get; set; }

            }

        }

        /// <summary>
        /// The domain name. The value of this parameter is used as a filter condition for a fuzzy match.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// The time when the domain name for CDN was added. The time follows the ISO 8601 standard in the *yyyy-MM-dd*T*HH:mm:ss*Z format. The time is displayed in UTC.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether HTTPS is enabled.
        /// 
        /// - **on**: indicates that HTTPS is enabled.
        /// - **off**: indicates that HTTPS is disabled.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
