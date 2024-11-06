// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnIpaDomainDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the accelerated domain name.</para>
        /// </summary>
        [NameInMap("DomainDetail")]
        [Validation(Required=false)]
        public DescribeDcdnIpaDomainDetailResponseBodyDomainDetail DomainDetail { get; set; }
        public class DescribeDcdnIpaDomainDetailResponseBodyDomainDetail : TeaModel {
            /// <summary>
            /// <para>Indicates the name of the certificate if the HTTPS protocol is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yourCertName</para>
            /// </summary>
            [NameInMap("CertName")]
            [Validation(Required=false)]
            public string CertName { get; set; }

            /// <summary>
            /// <para>The CNAME assigned to the domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("Cname")]
            [Validation(Required=false)]
            public string Cname { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>audit failed</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The accelerated domain names.</para>
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
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-11-27T06:51:26Z</para>
            /// </summary>
            [NameInMap("GmtCreated")]
            [Validation(Required=false)]
            public string GmtCreated { get; set; }

            /// <summary>
            /// <para>The time when the domain name was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-11-27T06:51:26Z</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The ID of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmyuji4b6xxxx</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>Indicates whether the Security Socket Layer (SSL) certificate is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>on</b></description></item>
            /// <item><description><b>off</b>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("SSLProtocol")]
            [Validation(Required=false)]
            public string SSLProtocol { get; set; }

            /// <summary>
            /// <para>The public key of the certificate if HTTPS is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SSLPub</para>
            /// </summary>
            [NameInMap("SSLPub")]
            [Validation(Required=false)]
            public string SSLPub { get; set; }

            /// <summary>
            /// <para>The acceleration region. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>domestic: Chinese mainland</description></item>
            /// <item><description>overseas: outside the Chinese mainland</description></item>
            /// <item><description>global: global</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>overseas</para>
            /// </summary>
            [NameInMap("Scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            /// <summary>
            /// <para>The information about the origin server.</para>
            /// </summary>
            [NameInMap("Sources")]
            [Validation(Required=false)]
            public DescribeDcdnIpaDomainDetailResponseBodyDomainDetailSources Sources { get; set; }
            public class DescribeDcdnIpaDomainDetailResponseBodyDomainDetailSources : TeaModel {
                [NameInMap("Source")]
                [Validation(Required=false)]
                public List<DescribeDcdnIpaDomainDetailResponseBodyDomainDetailSourcesSource> Source { get; set; }
                public class DescribeDcdnIpaDomainDetailResponseBodyDomainDetailSourcesSource : TeaModel {
                    /// <summary>
                    /// <para>The address of the origin server.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>xxx.oss-cn-hangzhou.aliyuncs.com</para>
                    /// </summary>
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    /// <summary>
                    /// <para>The status.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>online</para>
                    /// </summary>
                    [NameInMap("Enabled")]
                    [Validation(Required=false)]
                    public string Enabled { get; set; }

                    /// <summary>
                    /// <para>The custom port. Valid values: <b>0</b> to <b>65535</b>.</para>
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
                    /// <para>50</para>
                    /// </summary>
                    [NameInMap("Priority")]
                    [Validation(Required=false)]
                    public string Priority { get; set; }

                    /// <summary>
                    /// <para>The type of the origin server. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>ipaddr</b>: an origin IP address</description></item>
                    /// <item><description><b>domain</b>: a domain name.</description></item>
                    /// <item><description><b>oss</b>: Object Storage Service (OSS) buckets are not supported.</description></item>
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

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>09ABE829-6CD3-4FE0-AFEE-556113E29727</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
