// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeRDDomainsResponseBody : TeaModel {
        /// <summary>
        /// The status information about the accelerated domain name.
        /// </summary>
        [NameInMap("Domains")]
        [Validation(Required=false)]
        public DescribeRDDomainsResponseBodyDomains Domains { get; set; }
        public class DescribeRDDomainsResponseBodyDomains : TeaModel {
            [NameInMap("PageData")]
            [Validation(Required=false)]
            public List<DescribeRDDomainsResponseBodyDomainsPageData> PageData { get; set; }
            public class DescribeRDDomainsResponseBodyDomainsPageData : TeaModel {
                [NameInMap("BizName")]
                [Validation(Required=false)]
                public string BizName { get; set; }

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
                /// *   online: The domain name is enabled.
                /// *   offline: The domain name is disabled.
                /// *   configuring: The domain name is being configured.
                /// *   configure_failed: The domain name failed to be configured.
                /// *   checking: The domain name is being reviewed.
                /// *   check_failed: The domain name failed the review.
                /// </summary>
                [NameInMap("DomainStatus")]
                [Validation(Required=false)]
                public string DomainStatus { get; set; }

                /// <summary>
                /// The time when the accelerated domain name was added to DCDN.
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

                [NameInMap("ServiceCode")]
                [Validation(Required=false)]
                public string ServiceCode { get; set; }

                /// <summary>
                /// The information about the origin server.
                /// </summary>
                [NameInMap("Sources")]
                [Validation(Required=false)]
                public DescribeRDDomainsResponseBodyDomainsPageDataSources Sources { get; set; }
                public class DescribeRDDomainsResponseBodyDomainsPageDataSources : TeaModel {
                    [NameInMap("Source")]
                    [Validation(Required=false)]
                    public List<DescribeRDDomainsResponseBodyDomainsPageDataSourcesSource> Source { get; set; }
                    public class DescribeRDDomainsResponseBodyDomainsPageDataSourcesSource : TeaModel {
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
                        /// The origin server weight if multiple origin servers have been specified.
                        /// </summary>
                        [NameInMap("Weight")]
                        [Validation(Required=false)]
                        public string Weight { get; set; }

                    }

                }

                /// <summary>
                /// Indicates whether HTTPS is enabled.
                /// 
                /// *   on
                /// *   off
                /// </summary>
                [NameInMap("SslProtocol")]
                [Validation(Required=false)]
                public string SslProtocol { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page.
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
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
