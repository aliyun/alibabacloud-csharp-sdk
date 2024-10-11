// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodUserDomainsResponseBody : TeaModel {
        /// <summary>
        /// <para>The detailed information about each domain name for CDN. The returned information is displayed in the format that is specified by the PageData parameter.</para>
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
                /// <para>The CNAME that is assigned to the domain name for CDN.</para>
                /// 
                /// <b>Example:</b>
                /// <para>learn.developer.aliyundoc.com</para>
                /// </summary>
                [NameInMap("Cname")]
                [Validation(Required=false)]
                public string Cname { get; set; }

                /// <summary>
                /// <para>The remarks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Zhejiang ICP Filing No. ****</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The domain name for CDN.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.aliyundoc.com</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <para>The status of the domain name for CDN. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>online</b>: indicates that the domain name is enabled.</description></item>
                /// <item><description><b>offline</b>: indicates that the domain name is disabled.</description></item>
                /// <item><description><b>configuring</b>: indicates that the domain name is being configured.</description></item>
                /// <item><description><b>configure_failed</b>: indicates that the domain name failed to be configured.</description></item>
                /// <item><description><b>checking</b>: indicates that the domain name is under review.</description></item>
                /// <item><description><b>check_failed</b>: indicates that the domain name failed the review.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>online</para>
                /// </summary>
                [NameInMap("DomainStatus")]
                [Validation(Required=false)]
                public string DomainStatus { get; set; }

                /// <summary>
                /// <para>The time when the domain name for CDN was added. The time is in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2017-08-29T08:40:53Z</para>
                /// </summary>
                [NameInMap("GmtCreated")]
                [Validation(Required=false)]
                public string GmtCreated { get; set; }

                /// <summary>
                /// <para>The last time when the domain name for CDN was modified. The time is in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2017-12-29T09:24:12Z</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

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
                public DescribeVodUserDomainsResponseBodyDomainsPageDataSources Sources { get; set; }
                public class DescribeVodUserDomainsResponseBodyDomainsPageDataSources : TeaModel {
                    [NameInMap("Source")]
                    [Validation(Required=false)]
                    public List<DescribeVodUserDomainsResponseBodyDomainsPageDataSourcesSource> Source { get; set; }
                    public class DescribeVodUserDomainsResponseBodyDomainsPageDataSourcesSource : TeaModel {
                        /// <summary>
                        /// <para>The address of the origin server.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>192.168.0.1</para>
                        /// </summary>
                        [NameInMap("Content")]
                        [Validation(Required=false)]
                        public string Content { get; set; }

                        /// <summary>
                        /// <para>The port number. Valid values: <b>443</b> and <b>80</b>.</para>
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
                        /// <para>5</para>
                        /// </summary>
                        [NameInMap("Priority")]
                        [Validation(Required=false)]
                        public string Priority { get; set; }

                        /// <summary>
                        /// <para>The type of the origin server. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>ipaddr</b>: an IP address.</description></item>
                        /// <item><description><b>domain</b>: an origin domain name</description></item>
                        /// <item><description><b>oss</b>: the OSS domain of an Object Storage Service (OSS) bucket</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>oss</para>
                        /// </summary>
                        [NameInMap("Type")]
                        [Validation(Required=false)]
                        public string Type { get; set; }

                    }

                }

                /// <summary>
                /// <para>Indicates whether HTTPS is enabled.</para>
                /// <list type="bullet">
                /// <item><description><b>on</b>: HTTPS is enabled.</description></item>
                /// <item><description><b>off</b>: HTTPS is not eabled.</description></item>
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
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
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
        /// <para>E4EBD2BF-5EB0-4476-****-9D94E1B15267</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
