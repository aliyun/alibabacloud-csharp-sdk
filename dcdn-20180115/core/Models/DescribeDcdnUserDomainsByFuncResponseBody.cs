// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnUserDomainsByFuncResponseBody : TeaModel {
        /// <summary>
        /// <para>The array that consists of multiple PageData parameters. The details about each accelerated domain name are included in a separate PageData parameter.</para>
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
                /// <para>The CNAME assigned to the accelerated domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com.w.alikunlun.net</para>
                /// </summary>
                [NameInMap("Cname")]
                [Validation(Required=false)]
                public string Cname { get; set; }

                /// <summary>
                /// <para>The reason why the accelerated domain name failed the review.</para>
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
                /// <item><description><b>online</b></description></item>
                /// <item><description><b>offline</b></description></item>
                /// <item><description><b>configuring</b></description></item>
                /// <item><description><b>configure_failed</b></description></item>
                /// <item><description><b>checking</b></description></item>
                /// <item><description><b>check_failed</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>configure_failed</para>
                /// </summary>
                [NameInMap("DomainStatus")]
                [Validation(Required=false)]
                public string DomainStatus { get; set; }

                /// <summary>
                /// <para>The time when the accelerated domain name was added to Dynamic Content Delivery Network (DCDN).</para>
                /// 
                /// <b>Example:</b>
                /// <para>2015-10-28T09:32:51Z</para>
                /// </summary>
                [NameInMap("GmtCreated")]
                [Validation(Required=false)]
                public string GmtCreated { get; set; }

                /// <summary>
                /// <para>The time when the accelerated domain name was modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2015-10-28T11:05:50Z</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The ID of the resource group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-acfmyuji4b6r4**</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>Indicates whether the accelerated domain name was in a sandbox.</para>
                /// 
                /// <b>Example:</b>
                /// <para>normal</para>
                /// </summary>
                [NameInMap("Sandbox")]
                [Validation(Required=false)]
                public string Sandbox { get; set; }

                /// <summary>
                /// <para>The information about the origin servers.</para>
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
                        /// <para>The origin server address.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>image.developer.aliyundoc.com</para>
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
                        /// <para>The priority.</para>
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
                        /// <para>oss</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                        /// <summary>
                        /// <para>The weight of the origin server if multiple origin servers have been specified.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>20</para>
                        /// </summary>
                        [NameInMap("Weight")]
                        [Validation(Required=false)]
                        public string Weight { get; set; }

                    }

                }

                /// <summary>
                /// <para>Indicates whether HTTPS is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>on</b>: HTTPS is enabled.</description></item>
                /// <item><description><b>off</b>: HTTPS is disabled.</description></item>
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
        /// <para>The page number of the page returned.</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AA75AADB-5E25-4970-B480-EAA1F5658483</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of domain names returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
