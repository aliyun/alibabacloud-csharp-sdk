// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnDomainDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the accelerated domain name.</para>
        /// </summary>
        [NameInMap("DomainDetail")]
        [Validation(Required=false)]
        public DescribeDcdnDomainDetailResponseBodyDomainDetail DomainDetail { get; set; }
        public class DescribeDcdnDomainDetailResponseBodyDomainDetail : TeaModel {
            /// <summary>
            /// <para>The CNAME that is assigned to the accelerated domain name. You must add the CNAME record to the system of your Domain Name System (DNS) provider to map the accelerated domain name to the CNAME.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.aliyundoc.com</para>
            /// </summary>
            [NameInMap("Cname")]
            [Validation(Required=false)]
            public string Cname { get; set; }

            /// <summary>
            /// <para>The information about the Internet content provider (ICP) filing of the domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Beijing ICP Filing No. 1703xxxx</para>
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
            /// <para>online</para>
            /// </summary>
            [NameInMap("DomainStatus")]
            [Validation(Required=false)]
            public string DomainStatus { get; set; }

            /// <summary>
            /// <para>Computing service type. Valid values:</para>
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
            /// <para>The time when the domain name was added.</para>
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
            /// <para>2017-11-27T06:51:25Z</para>
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
            /// <para>Indicates whether the Security Socket Layer (SSL) certificate is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>on</b>: <b>enabled</b></description></item>
            /// <item><description><b>off</b>: <b>disabled</b></description></item>
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
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("SSLPub")]
            [Validation(Required=false)]
            public string SSLPub { get; set; }

            /// <summary>
            /// <para>Acceleration scenario. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>apiscene</b>: API acceleration.</description></item>
            /// <item><description><b>webservicescene</b>: website acceleration.</description></item>
            /// <item><description><b>staticscene</b>: video, image, and text acceleration.</description></item>
            /// <item><description><b>an empty string</b>: no acceleration scenario is used.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>apiscene</para>
            /// </summary>
            [NameInMap("Scene")]
            [Validation(Required=false)]
            public string Scene { get; set; }

            /// <summary>
            /// <para>The acceleration region. Default value: domestic. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>domestic</b>: Chinese mainland</description></item>
            /// <item><description><b>overseas</b>: global (excluding the Chinese mainland)</description></item>
            /// <item><description><b>global</b>: global</description></item>
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
            public DescribeDcdnDomainDetailResponseBodyDomainDetailSources Sources { get; set; }
            public class DescribeDcdnDomainDetailResponseBodyDomainDetailSources : TeaModel {
                [NameInMap("Source")]
                [Validation(Required=false)]
                public List<DescribeDcdnDomainDetailResponseBodyDomainDetailSourcesSource> Source { get; set; }
                public class DescribeDcdnDomainDetailResponseBodyDomainDetailSourcesSource : TeaModel {
                    /// <summary>
                    /// <para>The address of the origin server.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>example.org</para>
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
                    /// <para>The port over which requests are redirected to the origin server. Ports 443 and 80 are supported.</para>
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
                    /// <item><description><b>ipaddr</b>: an IP address</description></item>
                    /// <item><description><b>domain</b>: an origin domain name</description></item>
                    /// <item><description><b>oss</b>: the domain name of an Object Storage Service (OSS) bucket</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>oss</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    /// <summary>
                    /// <para>The weight of the origin server if multiple origin servers are specified.</para>
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
