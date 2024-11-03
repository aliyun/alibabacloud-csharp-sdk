// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeUserDomainsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of the accelerated domain names returned.</para>
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
                /// <para>The type of the workload accelerated by Alibaba Cloud CDN. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>web</b>: images and small files</description></item>
                /// <item><description><b>download</b>: large files</description></item>
                /// <item><description><b>video</b>: on-demand video and audio streaming</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>download</para>
                /// </summary>
                [NameInMap("CdnType")]
                [Validation(Required=false)]
                public string CdnType { get; set; }

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
                /// <para>The acceleration region. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>domestic</b>: Chinese mainland</description></item>
                /// <item><description><b>global</b>: global</description></item>
                /// <item><description><b>overseas</b>: outside the Chinese mainland</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>domestic</para>
                /// </summary>
                [NameInMap("Coverage")]
                [Validation(Required=false)]
                public string Coverage { get; set; }

                /// <summary>
                /// <para>The information about Internet Content Provider (ICP) filing.</para>
                /// 
                /// <b>Example:</b>
                /// <para>filing description</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The ID of the accelerated domain name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11223344</para>
                /// </summary>
                [NameInMap("DomainId")]
                [Validation(Required=false)]
                public long? DomainId { get; set; }

                /// <summary>
                /// <para>The accelerated domain.</para>
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
                /// <item><description><b>stopping</b></description></item>
                /// <item><description><b>deleting</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>configure_failed</para>
                /// </summary>
                [NameInMap("DomainStatus")]
                [Validation(Required=false)]
                public string DomainStatus { get; set; }

                /// <summary>
                /// <para>The time when the accelerated domain name was added.</para>
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
                /// <para>abcd1234abcd1234</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>Indicates whether the accelerated domain name is in a sandbox.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Sandbox")]
                [Validation(Required=false)]
                public string Sandbox { get; set; }

                /// <summary>
                /// <para>The information about the origin server.</para>
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
                        /// <para>The address of the origin server.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>***.oss-cn-hangzhou.aliyuncs.com</para>
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
                        /// <para>15</para>
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
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BDA62CE4-3477-439A-B52E-D2D7C829D7C1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
