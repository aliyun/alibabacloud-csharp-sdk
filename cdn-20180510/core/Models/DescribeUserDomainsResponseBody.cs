// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeUserDomainsResponseBody : TeaModel {
        /// <summary>
        /// The list of the accelerated domain names returned.
        /// </summary>
        [NameInMap("Domains")]
        [Validation(Required=false)]
        public DescribeUserDomainsResponseBodyDomains Domains { get; set; }
        public class DescribeUserDomainsResponseBodyDomains : TeaModel {
            [NameInMap("PageData")]
            [Validation(Required=false)]
            public List<DescribeUserDomainsResponseBodyDomainsPageData> PageData { get; set; }
            public class DescribeUserDomainsResponseBodyDomainsPageData : TeaModel {
                /// <summary>
                /// The type of the workload accelerated by Alibaba Cloud CDN. Valid values:
                /// 
                /// *   **web**: images and small files
                /// *   **download**: large files
                /// *   **video**: on-demand video and audio streaming
                /// </summary>
                [NameInMap("CdnType")]
                [Validation(Required=false)]
                public string CdnType { get; set; }

                /// <summary>
                /// The CNAME assigned to the accelerated domain name.
                /// </summary>
                [NameInMap("Cname")]
                [Validation(Required=false)]
                public string Cname { get; set; }

                /// <summary>
                /// The acceleration region. Valid values:
                /// 
                /// *   **domestic**: Chinese mainland
                /// *   **global**: global
                /// *   **overseas**: outside the Chinese mainland
                /// </summary>
                [NameInMap("Coverage")]
                [Validation(Required=false)]
                public string Coverage { get; set; }

                /// <summary>
                /// The information about Internet Content Provider (ICP) filing.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The ID of the accelerated domain name.
                /// </summary>
                [NameInMap("DomainId")]
                [Validation(Required=false)]
                public long? DomainId { get; set; }

                /// <summary>
                /// The accelerated domain.
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
                /// *   **stopping**
                /// *   **deleting**
                /// </summary>
                [NameInMap("DomainStatus")]
                [Validation(Required=false)]
                public string DomainStatus { get; set; }

                [NameInMap("GlobalResourcePlan")]
                [Validation(Required=false)]
                public string GlobalResourcePlan { get; set; }

                /// <summary>
                /// The time when the accelerated domain name was added.
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
                /// Indicates whether the accelerated domain name is in a sandbox.
                /// </summary>
                [NameInMap("Sandbox")]
                [Validation(Required=false)]
                public string Sandbox { get; set; }

                /// <summary>
                /// The information about the origin server.
                /// </summary>
                [NameInMap("Sources")]
                [Validation(Required=false)]
                public DescribeUserDomainsResponseBodyDomainsPageDataSources Sources { get; set; }
                public class DescribeUserDomainsResponseBodyDomainsPageDataSources : TeaModel {
                    [NameInMap("Source")]
                    [Validation(Required=false)]
                    public List<DescribeUserDomainsResponseBodyDomainsPageDataSourcesSource> Source { get; set; }
                    public class DescribeUserDomainsResponseBodyDomainsPageDataSourcesSource : TeaModel {
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
        /// The ID of the request.
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
