// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeHybridCloudResourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of domain names returned.</para>
        /// </summary>
        [NameInMap("Domains")]
        [Validation(Required=false)]
        public List<DescribeHybridCloudResourcesResponseBodyDomains> Domains { get; set; }
        public class DescribeHybridCloudResourcesResponseBodyDomains : TeaModel {
            /// <summary>
            /// <para>The CNAME assigned by WAF to the domain name.</para>
            /// <remarks>
            /// <para>This parameter is returned only when <b>CnameEnabled</b> is set to true, which indicates that public cloud disaster recovery is enabled.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>50fqmu1ci7g0xtiyxnrhgx6qdhmn****.yundunwaf5.com</para>
            /// </summary>
            [NameInMap("Cname")]
            [Validation(Required=false)]
            public string Cname { get; set; }

            /// <summary>
            /// <para>The domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.aliyundoc.com">www.aliyundoc.com</a></para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The access ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The listening configuration.</para>
            /// </summary>
            [NameInMap("Listen")]
            [Validation(Required=false)]
            public DescribeHybridCloudResourcesResponseBodyDomainsListen Listen { get; set; }
            public class DescribeHybridCloudResourcesResponseBodyDomainsListen : TeaModel {
                /// <summary>
                /// <para>The certificate ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>72***76-cn-hangzhou</para>
                /// </summary>
                [NameInMap("CertId")]
                [Validation(Required=false)]
                public string CertId { get; set; }

                /// <summary>
                /// <para>The type of cipher suite. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>1</b>: all cipher suites.</para>
                /// </description></item>
                /// <item><description><para><b>2</b>: strong cipher suites.</para>
                /// </description></item>
                /// <item><description><para><b>99</b>: custom cipher suites.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CipherSuite")]
                [Validation(Required=false)]
                public int? CipherSuite { get; set; }

                /// <summary>
                /// <para>The specific custom cipher suites to add.</para>
                /// <remarks>
                /// <para>This parameter is returned only when <b>CipherSuite</b> is set to <b>99</b>.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("CustomCiphers")]
                [Validation(Required=false)]
                public List<string> CustomCiphers { get; set; }

                /// <summary>
                /// <para>Indicates whether TLS 1.3 is supported. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b>: Supported.</para>
                /// </description></item>
                /// <item><description><para><b>false</b>: Not supported.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("EnableTLSv3")]
                [Validation(Required=false)]
                public bool? EnableTLSv3 { get; set; }

                /// <summary>
                /// <para>Indicates whether an exclusive IP address is supported. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b>: Supported.</para>
                /// </description></item>
                /// <item><description><para><b>false</b>: Not supported.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ExclusiveIp")]
                [Validation(Required=false)]
                public bool? ExclusiveIp { get; set; }

                /// <summary>
                /// <para>Indicates whether HTTPS forced redirect is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b>: Enabled.</para>
                /// </description></item>
                /// <item><description><para><b>false</b>: Disabled.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("FocusHttps")]
                [Validation(Required=false)]
                public bool? FocusHttps { get; set; }

                /// <summary>
                /// <para>Indicates whether HTTP/2 is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b>: Enabled.</para>
                /// </description></item>
                /// <item><description><para><b>false</b>: Disabled.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Http2Enabled")]
                [Validation(Required=false)]
                public bool? Http2Enabled { get; set; }

                /// <summary>
                /// <para>The list of HTTP listening ports.</para>
                /// </summary>
                [NameInMap("HttpPorts")]
                [Validation(Required=false)]
                public List<long?> HttpPorts { get; set; }

                /// <summary>
                /// <para>The list of HTTPS ports.</para>
                /// </summary>
                [NameInMap("HttpsPorts")]
                [Validation(Required=false)]
                public List<long?> HttpsPorts { get; set; }

                /// <summary>
                /// <para>Indicates whether IPv6 is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b>: Enabled.</para>
                /// </description></item>
                /// <item><description><para><b>false</b>: Disabled.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IPv6Enabled")]
                [Validation(Required=false)]
                public bool? IPv6Enabled { get; set; }

                /// <summary>
                /// <para>The type of protection resource to use. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>share</b>: shared cluster.</para>
                /// </description></item>
                /// <item><description><para><b>gslb</b>: intelligent load balancing of the shared cluster.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>share</para>
                /// </summary>
                [NameInMap("ProtectionResource")]
                [Validation(Required=false)]
                public string ProtectionResource { get; set; }

                /// <summary>
                /// <para>The TLS version. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>tlsv1</b></para>
                /// </description></item>
                /// <item><description><para><b>tlsv1.1</b></para>
                /// </description></item>
                /// <item><description><para><b>tlsv1.2</b></para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>tlsv1.2</para>
                /// </summary>
                [NameInMap("TLSVersion")]
                [Validation(Required=false)]
                public string TLSVersion { get; set; }

                /// <summary>
                /// <para>The method that WAF uses to obtain the originating IP address of the client. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>0</b>: No Layer 7 proxy is deployed in front of WAF.</para>
                /// </description></item>
                /// <item><description><para><b>1</b>: WAF reads the first value of the X-Forwarded-For (XFF) header field as the client IP address.</para>
                /// </description></item>
                /// <item><description><para><b>2</b>: WAF reads the value of a custom header field that you specify as the client IP address.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("XffHeaderMode")]
                [Validation(Required=false)]
                public int? XffHeaderMode { get; set; }

                /// <summary>
                /// <para>The list of custom header fields used to obtain the client IP address, in the format of <b>[&quot;header1&quot;,&quot;header2&quot;,...]</b>.</para>
                /// <remarks>
                /// <para>This parameter is returned only when <b>XffHeaderMode</b> is set to 2, which indicates that WAF reads the value of a custom header field that you specify in the request header as the client IP address.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("XffHeaders")]
                [Validation(Required=false)]
                public List<string> XffHeaders { get; set; }

            }

            /// <summary>
            /// <para>The forwarding configuration.</para>
            /// </summary>
            [NameInMap("Redirect")]
            [Validation(Required=false)]
            public DescribeHybridCloudResourcesResponseBodyDomainsRedirect Redirect { get; set; }
            public class DescribeHybridCloudResourcesResponseBodyDomainsRedirect : TeaModel {
                /// <summary>
                /// <para>The IP address or domain name of the origin server that corresponds to the domain name.</para>
                /// </summary>
                [NameInMap("Backends")]
                [Validation(Required=false)]
                public List<string> Backends { get; set; }

                /// <summary>
                /// <para>Specifies whether to enable public cloud disaster recovery. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b>: Enabled.</para>
                /// </description></item>
                /// <item><description><para><b>false</b>: Disabled.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("CnameEnabled")]
                [Validation(Required=false)]
                public bool? CnameEnabled { get; set; }

                /// <summary>
                /// <para>The connection timeout period. Unit: seconds.
                /// Valid values: 5 to 120.</para>
                /// 
                /// <b>Example:</b>
                /// <para>120</para>
                /// </summary>
                [NameInMap("ConnectTimeout")]
                [Validation(Required=false)]
                public long? ConnectTimeout { get; set; }

                /// <summary>
                /// <para>Indicates whether forced HTTP back-to-origin is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b>: Enabled.</para>
                /// </description></item>
                /// <item><description><para><b>false</b>: Disabled.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("FocusHttpBackend")]
                [Validation(Required=false)]
                public bool? FocusHttpBackend { get; set; }

                /// <summary>
                /// <para>Indicates whether persistent connections are enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b>: Enabled.</para>
                /// </description></item>
                /// <item><description><para><b>false</b>: Disabled.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Keepalive")]
                [Validation(Required=false)]
                public bool? Keepalive { get; set; }

                /// <summary>
                /// <para>The number of requests that reuse persistent connections. Valid values: 60 to 1000.</para>
                /// <remarks>
                /// <para>The number of persistent connections to reuse after persistent connections are enabled.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("KeepaliveRequests")]
                [Validation(Required=false)]
                public long? KeepaliveRequests { get; set; }

                /// <summary>
                /// <para>The idle timeout period for persistent connections. Valid values: 1 to 60. Default value: 15. Unit: seconds.</para>
                /// <remarks>
                /// <para>Specifies how long an idle reused persistent connection is kept before it is released.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>15</para>
                /// </summary>
                [NameInMap("KeepaliveTimeout")]
                [Validation(Required=false)]
                public long? KeepaliveTimeout { get; set; }

                /// <summary>
                /// <para>The load balancing algorithm used for back-to-origin. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>iphash</b>: IP Hash algorithm.</para>
                /// </description></item>
                /// <item><description><para><b>roundRobin</b>: round-robin algorithm.</para>
                /// </description></item>
                /// <item><description><para><b>leastTime</b>: Least Time algorithm.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>iphash</para>
                /// </summary>
                [NameInMap("Loadbalance")]
                [Validation(Required=false)]
                public string Loadbalance { get; set; }

                /// <summary>
                /// <para>The read timeout period. Unit: seconds.
                /// Valid values: 5 to 1800.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("ReadTimeout")]
                [Validation(Required=false)]
                public long? ReadTimeout { get; set; }

                /// <summary>
                /// <para>The traffic tag fields and values of the domain name, used to tag traffic processed by WAF.</para>
                /// </summary>
                [NameInMap("RequestHeaders")]
                [Validation(Required=false)]
                public List<DescribeHybridCloudResourcesResponseBodyDomainsRedirectRequestHeaders> RequestHeaders { get; set; }
                public class DescribeHybridCloudResourcesResponseBodyDomainsRedirectRequestHeaders : TeaModel {
                    /// <summary>
                    /// <para>The specified custom request header field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>aaa</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The value of the specified custom request header field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>bbb</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>Indicates whether WAF retries when back-to-origin fails. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b>: Retries.</para>
                /// </description></item>
                /// <item><description><para><b>false</b>: Does not retry.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Retry")]
                [Validation(Required=false)]
                public bool? Retry { get; set; }

                /// <summary>
                /// <para>The hybrid cloud forwarding rules, represented as a string converted from a JSON array. Each element in the JSON array is a struct that contains the following fields:</para>
                /// <list type="bullet">
                /// <item><description><para><b>rs</b>: Array type. The list of back-to-origin IP addresses or back-to-origin CNAMEs.</para>
                /// </description></item>
                /// <item><description><para><b>location</b>: String type. The name of the protection node.</para>
                /// </description></item>
                /// <item><description><para><b>locationId</b>: Long type. The ID of the protection node.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>[
                ///       {
                ///             &quot;rs&quot;: [
                ///                   &quot;1.1.XX.XX&quot;
                ///             ],
                ///             &quot;locationId&quot;: 535,
                ///             &quot;location&quot;: &quot;test1111&quot;
                ///       }
                /// ]</para>
                /// </summary>
                [NameInMap("RoutingRules")]
                [Validation(Required=false)]
                public string RoutingRules { get; set; }

                /// <summary>
                /// <para>Indicates whether back-to-origin Server Name Indication (SNI) is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b>: Enabled.</para>
                /// </description></item>
                /// <item><description><para><b>false</b>: Disabled.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("SniEnabled")]
                [Validation(Required=false)]
                public bool? SniEnabled { get; set; }

                /// <summary>
                /// <para>The custom value of the SNI extension field. An empty value indicates that no custom SNI value is set. By default, the value of the <b>Host</b> field in the request header is used as the value of the SNI extension field.</para>
                /// <remarks>
                /// <para>This parameter is returned only when <b>SniEnabled</b> is set to <b>true</b>, which indicates that back-to-origin SNI is enabled.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.aliyundoc.com">www.aliyundoc.com</a></para>
                /// </summary>
                [NameInMap("SniHost")]
                [Validation(Required=false)]
                public string SniHost { get; set; }

                /// <summary>
                /// <para>The write timeout period. Unit: seconds.
                /// Valid values: 5 to 1800.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("WriteTimeout")]
                [Validation(Required=false)]
                public long? WriteTimeout { get; set; }

            }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmvtc5z52****</para>
            /// </summary>
            [NameInMap("ResourceManagerResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceManagerResourceGroupId { get; set; }

            /// <summary>
            /// <para>The status of the domain name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: normal.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: being created.</para>
            /// </description></item>
            /// <item><description><para><b>3</b>: being modified.</para>
            /// </description></item>
            /// <item><description><para><b>4</b>: being released.</para>
            /// </description></item>
            /// <item><description><para><b>5</b>: forwarding stopped.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>130715431409****</para>
            /// </summary>
            [NameInMap("Uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>98D2AA9A-5959-5CCD-83E3-B6606232A2BE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
