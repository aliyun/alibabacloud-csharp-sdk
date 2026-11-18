// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DescribeVodDomainDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The basic configuration information of the domain name.</para>
        /// </summary>
        [NameInMap("DomainDetail")]
        [Validation(Required=false)]
        public DescribeVodDomainDetailResponseBodyDomainDetail DomainDetail { get; set; }
        public class DescribeVodDomainDetailResponseBodyDomainDetail : TeaModel {
            /// <summary>
            /// <para>The name of the HTTPS certificate if HTTPS secure acceleration is enabled. This parameter is not returned if HTTPS secure acceleration is disabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testCertName</para>
            /// </summary>
            [NameInMap("CertName")]
            [Validation(Required=false)]
            public string CertName { get; set; }

            /// <summary>
            /// <para>The CNAME domain name generated for the accelerated domain name. You must add a CNAME record at your DNS provider to resolve the accelerated domain name to this CNAME domain name. For more information, see <a href="https://help.aliyun.com/document_detail/86075.html">Configure CNAME</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com.w.alikunlun.net</para>
            /// </summary>
            [NameInMap("Cname")]
            [Validation(Required=false)]
            public string Cname { get; set; }

            /// <summary>
            /// <para>The description of the ApsaraVideo VOD accelerated domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testDescription</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ApsaraVideo VOD accelerated domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// <para>The running status of the accelerated domain name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>online</b>: Enabled.</description></item>
            /// <item><description><b>offline</b>: Disabled.</description></item>
            /// <item><description><b>configuring</b>: Configuring.</description></item>
            /// <item><description><b>configure_failed</b>: Configuration failed.</description></item>
            /// <item><description><b>checking</b>: Under review.</description></item>
            /// <item><description><b>check_failed</b>: Review failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>online</para>
            /// </summary>
            [NameInMap("DomainStatus")]
            [Validation(Required=false)]
            public string DomainStatus { get; set; }

            /// <summary>
            /// <para>The creation time. The format is <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-11-27T06:51:26Z</para>
            /// </summary>
            [NameInMap("GmtCreated")]
            [Validation(Required=false)]
            public string GmtCreated { get; set; }

            /// <summary>
            /// <para>The last modification time. The format is <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2017-11-27T06:55:26Z</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>Specifies whether the SSL certificate is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>on</b>: Enabled.</description></item>
            /// <item><description><b>off</b>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>on</para>
            /// </summary>
            [NameInMap("SSLProtocol")]
            [Validation(Required=false)]
            public string SSLProtocol { get; set; }

            /// <summary>
            /// <para>The public key of the HTTPS certificate if HTTPS secure acceleration is enabled. This parameter is not returned if HTTPS secure acceleration is disabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yourSSLPub</para>
            /// </summary>
            [NameInMap("SSLPub")]
            [Validation(Required=false)]
            public string SSLPub { get; set; }

            /// <summary>
            /// <para>The accelerated region. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>domestic</b> (default): The Chinese mainland.</description></item>
            /// <item><description><b>overseas</b>: Global (excluding the Chinese mainland).</description></item>
            /// <item><description><b>global</b>: Global.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>domestic</para>
            /// </summary>
            [NameInMap("Scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

            [NameInMap("Sources")]
            [Validation(Required=false)]
            public DescribeVodDomainDetailResponseBodyDomainDetailSources Sources { get; set; }
            public class DescribeVodDomainDetailResponseBodyDomainDetailSources : TeaModel {
                [NameInMap("Source")]
                [Validation(Required=false)]
                public List<DescribeVodDomainDetailResponseBodyDomainDetailSourcesSource> Source { get; set; }
                public class DescribeVodDomainDetailResponseBodyDomainDetailSourcesSource : TeaModel {
                    [NameInMap("Content")]
                    [Validation(Required=false)]
                    public string Content { get; set; }

                    [NameInMap("Enabled")]
                    [Validation(Required=false)]
                    public string Enabled { get; set; }

                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    [NameInMap("Priority")]
                    [Validation(Required=false)]
                    public string Priority { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    [NameInMap("Weight")]
                    [Validation(Required=false)]
                    public string Weight { get; set; }

                }

            }

            /// <summary>
            /// <para>The back-to-origin weight.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Weight")]
            [Validation(Required=false)]
            public string Weight { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>09ABE829-6CD3-4FE0-556113E2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
