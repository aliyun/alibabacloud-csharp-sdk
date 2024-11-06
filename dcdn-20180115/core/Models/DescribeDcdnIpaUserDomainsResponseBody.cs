// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnIpaUserDomainsResponseBody : TeaModel {
        /// <summary>
        /// <para>The array that consists of multiple PageData parameters. The details about each accelerated domain name are included in a separate PageData parameter.</para>
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
                /// <para>The CNAME assigned to the accelerated domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com.*.com</para>
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
                /// <item><description><b>online</b>: enabled</description></item>
                /// <item><description><b>offline</b>: disabled</description></item>
                /// <item><description><b>configuring</b>: configuring</description></item>
                /// <item><description><b>configure_failed</b>: configuration failed</description></item>
                /// <item><description><b>checking</b>: reviewing</description></item>
                /// <item><description><b>check_failed:</b> review failed</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>online</para>
                /// </summary>
                [NameInMap("DomainStatus")]
                [Validation(Required=false)]
                public string DomainStatus { get; set; }

                /// <summary>
                /// <para>The time when the accelerated domain name was added to Alibaba Cloud CDN.</para>
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
                /// <para>2015-10-28T11:05:52Z</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The ID of the resource group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abcd1234abcd****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The status of HTTPS.</para>
                /// <list type="bullet">
                /// <item><description><b>on</b></description></item>
                /// <item><description><b>off</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("SSLProtocol")]
                [Validation(Required=false)]
                public string SSLProtocol { get; set; }

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
                /// <para>The information about the origin server.</para>
                /// </summary>
                [NameInMap("Sources")]
                [Validation(Required=false)]
                public DescribeDcdnIpaUserDomainsResponseBodyDomainsPageDataSources Sources { get; set; }
                public class DescribeDcdnIpaUserDomainsResponseBodyDomainsPageDataSources : TeaModel {
                    [NameInMap("Source")]
                    [Validation(Required=false)]
                    public List<DescribeDcdnIpaUserDomainsResponseBodyDomainsPageDataSourcesSource> Source { get; set; }
                    public class DescribeDcdnIpaUserDomainsResponseBodyDomainsPageDataSourcesSource : TeaModel {
                        /// <summary>
                        /// <para>The address of the origin server.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>*.aliyuncs.com</para>
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
                        /// <para>OSS Domain</para>
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
        /// <para>The number of domain names returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
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
        /// <para>The total number of domain names returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
