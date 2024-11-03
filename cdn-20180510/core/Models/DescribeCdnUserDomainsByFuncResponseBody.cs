// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnUserDomainsByFuncResponseBody : TeaModel {
        /// <summary>
        /// <para>The configurations of the accelerated domain name.</para>
        /// </summary>
        [NameInMap("Domains")]
        [Validation(Required=false)]
        public DescribeCdnUserDomainsByFuncResponseBodyDomains Domains { get; set; }
        public class DescribeCdnUserDomainsByFuncResponseBodyDomains : TeaModel {
            [NameInMap("PageData")]
            [Validation(Required=false)]
            public List<DescribeCdnUserDomainsByFuncResponseBodyDomainsPageData> PageData { get; set; }
            public class DescribeCdnUserDomainsByFuncResponseBodyDomainsPageData : TeaModel {
                /// <summary>
                /// <para>The type of workload accelerated by Alibaba Cloud CDN. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>web</b>: image and small file distribution</description></item>
                /// <item><description><b>download</b>: large file distribution</description></item>
                /// <item><description><b>video</b>: on-demand video and audio streaming</description></item>
                /// <item><description><b>liveStream</b>: live streaming</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>web</para>
                /// </summary>
                [NameInMap("CdnType")]
                [Validation(Required=false)]
                public string CdnType { get; set; }

                /// <summary>
                /// <para>The CNAME assigned to the accelerated domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com.w.alikunlun.com</para>
                /// </summary>
                [NameInMap("Cname")]
                [Validation(Required=false)]
                public string Cname { get; set; }

                /// <summary>
                /// <para>The description of the status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>audit failed</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The accelerated domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <para>The status of the accelerated domain name. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>online</b>: The domain name is enabled.</description></item>
                /// <item><description><b>offline</b>: The domain is disabled.</description></item>
                /// <item><description><b>configuring</b>: The endpoint group is being configured.</description></item>
                /// <item><description><b>configure_failed</b>: The domain failed to be configured.</description></item>
                /// <item><description><b>checking</b>: The domain name is under review.</description></item>
                /// <item><description><b>check_failed</b>: The domain name failed the review.</description></item>
                /// <item><description><b>stopping</b>: The domain name is be disabled.</description></item>
                /// <item><description><b>deleting</b>: being deleted</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>configure_failed</para>
                /// </summary>
                [NameInMap("DomainStatus")]
                [Validation(Required=false)]
                public string DomainStatus { get; set; }

                /// <summary>
                /// <para>The time when the accelerated domain name was added to Alibaba Cloud CDN.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2015-10-28T11:05:52Z</para>
                /// </summary>
                [NameInMap("GmtCreated")]
                [Validation(Required=false)]
                public string GmtCreated { get; set; }

                /// <summary>
                /// <para>The last time when the accelerated domain was modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2015-10-29T10:15:31Z</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The ID of the resource group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-xxxxx</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The information about the origin server.</para>
                /// </summary>
                [NameInMap("Sources")]
                [Validation(Required=false)]
                public DescribeCdnUserDomainsByFuncResponseBodyDomainsPageDataSources Sources { get; set; }
                public class DescribeCdnUserDomainsByFuncResponseBodyDomainsPageDataSources : TeaModel {
                    [NameInMap("Source")]
                    [Validation(Required=false)]
                    public List<DescribeCdnUserDomainsByFuncResponseBodyDomainsPageDataSourcesSource> Source { get; set; }
                    public class DescribeCdnUserDomainsByFuncResponseBodyDomainsPageDataSourcesSource : TeaModel {
                        /// <summary>
                        /// <para>The address of the origin server.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1.1.1.1</para>
                        /// </summary>
                        [NameInMap("Content")]
                        [Validation(Required=false)]
                        public string Content { get; set; }

                        /// <summary>
                        /// <para>The port of the origin server.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>80</para>
                        /// </summary>
                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public int? Port { get; set; }

                        /// <summary>
                        /// <para>The priority of the configuration item.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>20</para>
                        /// </summary>
                        [NameInMap("Priority")]
                        [Validation(Required=false)]
                        public string Priority { get; set; }

                        /// <summary>
                        /// <para>The type of the origin server.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>ipaddr</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        /// <summary>
                        /// <para>The weight of the origin server if multiple origin servers have been specified.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("Weight")]
                        [Validation(Required=false)]
                        public string Weight { get; set; }

                    }

                }

                /// <summary>
                /// <para>Indicates whether HTTPS is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>on</b></description></item>
                /// <item><description><b>off</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("SslProtocol")]
                [Validation(Required=false)]
                public string SslProtocol { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AA75AADB-5E25-4970-B480-EAA1F5658483</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
