// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnUserDomainsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the queried domains.</para>
        /// </summary>
        [NameInMap("Domains")]
        [Validation(Required=false)]
        public DescribeDcdnUserDomainsResponseBodyDomains Domains { get; set; }
        public class DescribeDcdnUserDomainsResponseBodyDomains : TeaModel {
            [NameInMap("PageData")]
            [Validation(Required=false)]
            public List<DescribeDcdnUserDomainsResponseBodyDomainsPageData> PageData { get; set; }
            public class DescribeDcdnUserDomainsResponseBodyDomainsPageData : TeaModel {
                /// <summary>
                /// <para>The CNAME of the domain.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test.aliyun.com.w.alikunlun.com</para>
                /// </summary>
                [NameInMap("Cname")]
                [Validation(Required=false)]
                public string Cname { get; set; }

                /// <summary>
                /// <para>The reason why the domain failed the review.</para>
                /// 
                /// <b>Example:</b>
                /// <para>audit failed</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The domain ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11223344</para>
                /// </summary>
                [NameInMap("DomainId")]
                [Validation(Required=false)]
                public long? DomainId { get; set; }

                /// <summary>
                /// <para>The domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.example.com">www.example.com</a></para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <para>The domain status.</para>
                /// <list type="bullet">
                /// <item><description><b>online</b>: The domain is active.</description></item>
                /// <item><description><b>offline</b>: The domain is suspended.</description></item>
                /// <item><description><b>configuring</b>: The domain is being configured.</description></item>
                /// <item><description><b>configure_failed</b>: The domain failed to be configured.</description></item>
                /// <item><description><b>checking</b>: The domain is under review.</description></item>
                /// <item><description><b>check_failed</b>: The domain failed the review.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>online</para>
                /// </summary>
                [NameInMap("DomainStatus")]
                [Validation(Required=false)]
                public string DomainStatus { get; set; }

                /// <summary>
                /// <para>The computing service type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>routine</b></description></item>
                /// <item><description><b>image</b></description></item>
                /// <item><description><b>cloudFunction</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>routine</para>
                /// </summary>
                [NameInMap("FunctionType")]
                [Validation(Required=false)]
                public string FunctionType { get; set; }

                /// <summary>
                /// <para>The time when the domain was added to DCDN.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2015-10-28T11:05:50Z</para>
                /// </summary>
                [NameInMap("GmtCreated")]
                [Validation(Required=false)]
                public string GmtCreated { get; set; }

                /// <summary>
                /// <para>The time when the domain was modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2015-10-28T09:31:59Z</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The ID of the resource group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-acfmv6jutt**</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>Indicates whether HTTPS was enabled.</para>
                /// <list type="bullet">
                /// <item><description><b>on</b>: enabled.</description></item>
                /// <item><description><b>off</b>: disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("SSLProtocol")]
                [Validation(Required=false)]
                public string SSLProtocol { get; set; }

                /// <summary>
                /// <para>The sandbox status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>normal</para>
                /// </summary>
                [NameInMap("Sandbox")]
                [Validation(Required=false)]
                public string Sandbox { get; set; }

                /// <summary>
                /// <para>The acceleration scenario. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>apiscene</b>: accelerates response to API calls.</description></item>
                /// <item><description><b>webservicescene</b>: accelerates content delivery for websites.</description></item>
                /// <item><description><b>staticscene</b>: accelerates the delivery of videos, images, and text.</description></item>
                /// <item><description>**If you leave this parameter empty, no scenarios are supported.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>apiscene</para>
                /// </summary>
                [NameInMap("Scene")]
                [Validation(Required=false)]
                public string Scene { get; set; }

                /// <summary>
                /// <para>The information about the origin servers.</para>
                /// </summary>
                [NameInMap("Sources")]
                [Validation(Required=false)]
                public DescribeDcdnUserDomainsResponseBodyDomainsPageDataSources Sources { get; set; }
                public class DescribeDcdnUserDomainsResponseBodyDomainsPageDataSources : TeaModel {
                    [NameInMap("Source")]
                    [Validation(Required=false)]
                    public List<DescribeDcdnUserDomainsResponseBodyDomainsPageDataSourcesSource> Source { get; set; }
                    public class DescribeDcdnUserDomainsResponseBodyDomainsPageDataSourcesSource : TeaModel {
                        /// <summary>
                        /// <para>The address of the origin server.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>example.com</para>
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
                        /// <para>The priority of the origin server.</para>
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
                        /// <para>The weight of the origin server.</para>
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
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
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
        /// <para>12</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
