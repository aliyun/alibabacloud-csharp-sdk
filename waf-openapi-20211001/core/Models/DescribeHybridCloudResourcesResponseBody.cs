// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeHybridCloudResourcesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of domain names.</para>
        /// </summary>
        [NameInMap("Domains")]
        [Validation(Required=false)]
        public List<DescribeHybridCloudResourcesResponseBodyDomains> Domains { get; set; }
        public class DescribeHybridCloudResourcesResponseBodyDomains : TeaModel {
            /// <summary>
            /// <para>The CNAME that is assigned by WAF to the domain name.</para>
            /// <remarks>
            /// <para>This parameter is returned only when <b>CnameEnabled</b> is set to true.</para>
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
            /// <para>The ID of the domain name configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12345</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The listener configuration.</para>
            /// </summary>
            [NameInMap("Listen")]
            [Validation(Required=false)]
            public DescribeHybridCloudResourcesResponseBodyDomainsListen Listen { get; set; }
            public class DescribeHybridCloudResourcesResponseBodyDomainsListen : TeaModel {
                /// <summary>
                /// <para>The ID of the certificate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>72***76-cn-hangzhou</para>
                /// </summary>
                [NameInMap("CertId")]
                [Validation(Required=false)]
                public string CertId { get; set; }

                /// <summary>
                /// <para>The type of the cipher suite. Valid values:</para>
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
                /// <para>The custom cipher suites to be added.</para>
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
                /// <item><description><para><b>true</b></para>
                /// </description></item>
                /// <item><description><para><b>false</b></para>
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
                /// <para>Indicates whether an exclusive IP address is used. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b></para>
                /// </description></item>
                /// <item><description><para><b>false</b></para>
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
                /// <para>Indicates whether HTTPS to HTTP redirection is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b></para>
                /// </description></item>
                /// <item><description><para><b>false</b></para>
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
                /// <item><description><para><b>true</b></para>
                /// </description></item>
                /// <item><description><para><b>false</b></para>
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
                /// <para>The list of HTTP listener ports.</para>
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
                /// <item><description><para><b>true</b></para>
                /// </description></item>
                /// <item><description><para><b>false</b></para>
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
                /// <para>The type of the protection resource. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>share</b>: shared cluster.</para>
                /// </description></item>
                /// <item><description><para><b>gslb</b>: intelligent load balancing for a shared cluster.</para>
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
                /// <para>The method that WAF uses to obtain the client IP address. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>0</b>: No Layer 7 proxies are deployed in front of WAF.</para>
                /// </description></item>
                /// <item><description><para><b>1</b>: WAF reads the first value of the X-Forwarded-For (XFF) header field as the client IP address.</para>
                /// </description></item>
                /// <item><description><para><b>2</b>: WAF reads the value of a custom header field as the client IP address.</para>
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
                /// <para>The list of custom header fields that are used to obtain the client IP address. The value is in the \<c>[&quot;header1&quot;,&quot;header2&quot;,...]\\</c> format.</para>
                /// <remarks>
                /// <para>This parameter is returned only when XffHeaderMode is set to <b>2</b>.</para>
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
                /// <para>The IP addresses or domain names of the origin servers for back-to-origin.</para>
                /// </summary>
                [NameInMap("Backends")]
                [Validation(Required=false)]
                public List<string> Backends { get; set; }

                /// <summary>
                /// <para>Indicates whether public cloud disaster recovery is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b></para>
                /// </description></item>
                /// <item><description><para><b>false</b></para>
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
                /// <para>The connection timeout period. Unit: seconds. Valid values: 5 to 120.</para>
                /// 
                /// <b>Example:</b>
                /// <para>120</para>
                /// </summary>
                [NameInMap("ConnectTimeout")]
                [Validation(Required=false)]
                public long? ConnectTimeout { get; set; }

                /// <summary>
                /// <para>Indicates whether back-to-origin requests are forcefully sent over HTTP. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b></para>
                /// </description></item>
                /// <item><description><para><b>false</b></para>
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
                /// <item><description><para><b>true</b></para>
                /// </description></item>
                /// <item><description><para><b>false</b></para>
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
                /// <para>The maximum number of requests that can be sent over a persistent connection. Valid values: 60 to 1000.</para>
                /// <remarks>
                /// <para>After the specified number of requests are sent, the persistent connection is closed and a new connection is established.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("KeepaliveRequests")]
                [Validation(Required=false)]
                public long? KeepaliveRequests { get; set; }

                /// <summary>
                /// <para>The timeout period for an idle persistent connection. Valid values: 1 to 60. Default value: 15. Unit: seconds.</para>
                /// <remarks>
                /// <para>An idle persistent connection is released after the timeout period expires.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>15</para>
                /// </summary>
                [NameInMap("KeepaliveTimeout")]
                [Validation(Required=false)]
                public long? KeepaliveTimeout { get; set; }

                /// <summary>
                /// <para>The load balancing algorithm for back-to-origin requests. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>iphash</b>: the IP hash algorithm.</para>
                /// </description></item>
                /// <item><description><para><b>roundRobin</b>: the round-robin algorithm.</para>
                /// </description></item>
                /// <item><description><para><b>leastTime</b>: the least time algorithm.</para>
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
                /// <para>The read timeout period. Unit: seconds. Valid values: 5 to 1800.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("ReadTimeout")]
                [Validation(Required=false)]
                public long? ReadTimeout { get; set; }

                /// <summary>
                /// <para>The custom header field and value that are used to mark the traffic that is processed by WAF.</para>
                /// </summary>
                [NameInMap("RequestHeaders")]
                [Validation(Required=false)]
                public List<DescribeHybridCloudResourcesResponseBodyDomainsRedirectRequestHeaders> RequestHeaders { get; set; }
                public class DescribeHybridCloudResourcesResponseBodyDomainsRedirectRequestHeaders : TeaModel {
                    /// <summary>
                    /// <para>The custom request header field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>aaa</para>
                    /// </summary>
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    /// <summary>
                    /// <para>The value of the custom request header field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>bbb</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                /// <summary>
                /// <para>Indicates whether WAF retries forwarding requests when a back-to-origin request fails. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b></para>
                /// </description></item>
                /// <item><description><para><b>false</b></para>
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
                /// <para>The forwarding rules for the hybrid cloud. The value is a string that consists of a JSON array. Each element in the array is a struct that contains the following fields:</para>
                /// <list type="bullet">
                /// <item><description><para><b>rs</b>: The back-to-origin IP addresses or CNAMEs. This field is of the Array type.</para>
                /// </description></item>
                /// <item><description><para><b>location</b>: The name of the protection node. This field is of the String type.</para>
                /// </description></item>
                /// <item><description><para><b>locationId</b>: The ID of the protection node. This field is of the Long type.</para>
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
                /// <item><description><para><b>true</b></para>
                /// </description></item>
                /// <item><description><para><b>false</b></para>
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
                /// <para>The custom value of the SNI extension field. If this parameter is not specified, the value of the <b>Host</b> field in the request header is used as the value of the SNI extension field by default.</para>
                /// <remarks>
                /// <para>This parameter is returned only when <b>SniEnabled</b> is set to <b>true</b>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.aliyundoc.com">www.aliyundoc.com</a></para>
                /// </summary>
                [NameInMap("SniHost")]
                [Validation(Required=false)]
                public string SniHost { get; set; }

                /// <summary>
                /// <para>The write timeout period. Unit: seconds. Valid values: 5 to 1800.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("WriteTimeout")]
                [Validation(Required=false)]
                public long? WriteTimeout { get; set; }

            }

            /// <summary>
            /// <para>The ID of the resource group.</para>
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
            /// <item><description><para><b>1</b>: The domain name is in a normal state.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: The domain name is being created.</para>
            /// </description></item>
            /// <item><description><para><b>3</b>: The domain name is being modified.</para>
            /// </description></item>
            /// <item><description><para><b>4</b>: The domain name is being released.</para>
            /// </description></item>
            /// <item><description><para><b>5</b>: Forwarding is disabled for the domain name.</para>
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
            /// <para>The ID of the Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>130715431409****</para>
            /// </summary>
            [NameInMap("Uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
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
