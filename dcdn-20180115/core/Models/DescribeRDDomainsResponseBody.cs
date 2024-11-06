// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeRDDomainsResponseBody : TeaModel {
        /// <summary>
        /// <para>The status information about the accelerated domain name.</para>
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
                /// <para>The CNAME assigned to the accelerated domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>image.developer.aliyundoc.com</para>
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
                /// <item><description>online: The domain name is enabled.</description></item>
                /// <item><description>offline: The domain name is disabled.</description></item>
                /// <item><description>configuring: The domain name is being configured.</description></item>
                /// <item><description>configure_failed: The domain name failed to be configured.</description></item>
                /// <item><description>checking: The domain name is being reviewed.</description></item>
                /// <item><description>check_failed: The domain name failed the review.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>online</para>
                /// </summary>
                [NameInMap("DomainStatus")]
                [Validation(Required=false)]
                public string DomainStatus { get; set; }

                /// <summary>
                /// <para>The time when the accelerated domain name was added to DCDN.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2015-10-27T06:26:34Z</para>
                /// </summary>
                [NameInMap("GmtCreated")]
                [Validation(Required=false)]
                public string GmtCreated { get; set; }

                /// <summary>
                /// <para>The time when the accelerated domain name was modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2015-10-23T09:30:00Z</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>The ID of the resource group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abcd1234abcd1234</para>
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

                [NameInMap("ServiceCode")]
                [Validation(Required=false)]
                public string ServiceCode { get; set; }

                /// <summary>
                /// <para>The information about the origin server.</para>
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
                        /// <para>The address of the origin server.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>example.aliyundoc.com</para>
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
                        /// <para>The origin server weight if multiple origin servers have been specified.</para>
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
                /// <para>Indicates whether HTTPS is enabled.</para>
                /// <list type="bullet">
                /// <item><description>on</description></item>
                /// <item><description>off</description></item>
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
        /// <para>The request ID.</para>
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
