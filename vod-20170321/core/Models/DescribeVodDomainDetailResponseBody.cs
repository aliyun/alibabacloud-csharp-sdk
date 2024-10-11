// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodDomainDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The basic information about the domain name for CDN.</para>
        /// </summary>
        [NameInMap("DomainDetail")]
        [Validation(Required=false)]
        public DescribeVodDomainDetailResponseBodyDomainDetail DomainDetail { get; set; }
        public class DescribeVodDomainDetailResponseBodyDomainDetail : TeaModel {
            /// <summary>
            /// <para>The name of the certificate. The value of this parameter is returned if HTTPS is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testCertName</para>
            /// </summary>
            [NameInMap("CertName")]
            [Validation(Required=false)]
            public string CertName { get; set; }

            /// <summary>
            /// <para>The CNAME that is assigned to the domain name for CDN. You must add a CNAME record in the system of your Domain Name System (DNS) service provider to map the domain name for CDN to the CNAME.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com.w.alikunlun.net</para>
            /// </summary>
            [NameInMap("Cname")]
            [Validation(Required=false)]
            public string Cname { get; set; }

            /// <summary>
            /// <para>The description of the domain name for CDN.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testDescription</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The domain name for CDN.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// <para>The status of the domain name for CDN. Value values:</para>
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
            /// <para>The time when the domain name for CDN was added. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-11-27T06:51:26Z</para>
            /// </summary>
            [NameInMap("GmtCreated")]
            [Validation(Required=false)]
            public string GmtCreated { get; set; }

            /// <summary>
            /// <para>The last time when the domain name for CDN was modified. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-11-27T06:55:26Z</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>Indicates whether the Secure Sockets Layer (SSL) certificate is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>on</b>: indicates that the SSL certificate is enabled.</description></item>
            /// <item><description><b>off</b>: indicates that the SSL certificate is disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("SSLProtocol")]
            [Validation(Required=false)]
            public string SSLProtocol { get; set; }

            /// <summary>
            /// <para>The public key of the certificate. The value of this parameter is returned if HTTPS is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yourSSLPub</para>
            /// </summary>
            [NameInMap("SSLPub")]
            [Validation(Required=false)]
            public string SSLPub { get; set; }

            /// <summary>
            /// <para>This parameter is applicable to users of level 3 or higher in mainland China and users outside mainland China. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>domestic</b>: mainland China. This is the default value.</description></item>
            /// <item><description><b>overseas</b>: outside mainland China.</description></item>
            /// <item><description><b>global</b>: regions in and outside mainland China.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>domestic</para>
            /// </summary>
            [NameInMap("Scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            /// <summary>
            /// <para>The information about the origin server.</para>
            /// </summary>
            [NameInMap("Sources")]
            [Validation(Required=false)]
            public DescribeVodDomainDetailResponseBodyDomainDetailSources Sources { get; set; }
            public class DescribeVodDomainDetailResponseBodyDomainDetailSources : TeaModel {
                [NameInMap("Source")]
                [Validation(Required=false)]
                public List<DescribeVodDomainDetailResponseBodyDomainDetailSourcesSource> Source { get; set; }
                public class DescribeVodDomainDetailResponseBodyDomainDetailSourcesSource : TeaModel {
                    /// <summary>
                    /// <para>The address of the origin server.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>****.oss-cn-hangzhou.aliyuncs.com</para>
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <para>The status of the origin server. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>online</b>: indicates that the origin server is enabled.</description></item>
                    /// <item><description><b>offline</b>: indicates that the origin server is disabled.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>online</para>
                    /// </summary>
                    [NameInMap("Enabled")]
                    [Validation(Required=false)]
                    public string Enabled { get; set; }

                    /// <summary>
                    /// <para>The port number. Valid values: 443 and 80.</para>
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
                    /// <para>50</para>
                    /// </summary>
                    [NameInMap("Priority")]
                    [Validation(Required=false)]
                    public string Priority { get; set; }

                    /// <summary>
                    /// <para>The type of the origin server. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>ipaddr</b>: a server that you can access by using an IP address.</description></item>
                    /// <item><description><b>domain</b>: a server that you can access by using a domain name.</description></item>
                    /// <item><description><b>oss</b>: the URL of an Object Storage Service (OSS) bucket.</description></item>
                    /// </list>
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
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Weight")]
                    [Validation(Required=false)]
                    public string Weight { get; set; }

                }

            }

            /// <summary>
            /// <para>The weight of the origin server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Weight")]
            [Validation(Required=false)]
            public string Weight { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>09ABE829-6CD3-4FE0-556113E2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
