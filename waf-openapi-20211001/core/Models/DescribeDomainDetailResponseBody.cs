// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeDomainDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the SSL certificate.</para>
        /// </summary>
        [NameInMap("CertDetail")]
        [Validation(Required=false)]
        public DescribeDomainDetailResponseBodyCertDetail CertDetail { get; set; }
        public class DescribeDomainDetailResponseBodyCertDetail : TeaModel {
            /// <summary>
            /// <para>The common name of the SSL certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test.aliyundoc.com</para>
            /// </summary>
            [NameInMap("CommonName")]
            [Validation(Required=false)]
            public string CommonName { get; set; }

            /// <summary>
            /// <para>The end of the validity period of the SSL certificate. This value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1685590400000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The ID of the SSL certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123-cn-hangzhou</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The name of the SSL certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-cert-name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The domain names that are bound to the certificate.</para>
            /// </summary>
            [NameInMap("Sans")]
            [Validation(Required=false)]
            public List<string> Sans { get; set; }

            /// <summary>
            /// <para>The beginning of the validity period of the SSL certificate. This value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1677772800000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

        /// <summary>
        /// <para>The CNAME assigned by WAF to the domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxxxcvdaf.****.com</para>
        /// </summary>
        [NameInMap("Cname")]
        [Validation(Required=false)]
        public string Cname { get; set; }

        /// <summary>
        /// <para>The domain name that is onboarded to WAF.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.aliyundoc.com">www.aliyundoc.com</a></para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The ID of the domain name that is onboarded to WAF.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.aliyundoc.com-waf">www.aliyundoc.com-waf</a></para>
        /// </summary>
        [NameInMap("DomainId")]
        [Validation(Required=false)]
        public string DomainId { get; set; }

        /// <summary>
        /// <para>The listener configurations.</para>
        /// </summary>
        [NameInMap("Listen")]
        [Validation(Required=false)]
        public DescribeDomainDetailResponseBodyListen Listen { get; set; }
        public class DescribeDomainDetailResponseBodyListen : TeaModel {
            /// <summary>
            /// <para>The ID of the certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
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
            /// <para>2</para>
            /// </summary>
            [NameInMap("CipherSuite")]
            [Validation(Required=false)]
            public long? CipherSuite { get; set; }

            /// <summary>
            /// <para>The custom cipher suites.</para>
            /// </summary>
            [NameInMap("CustomCiphers")]
            [Validation(Required=false)]
            public List<string> CustomCiphers { get; set; }

            /// <summary>
            /// <para>Indicates whether TLS 1.3 is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: TLS 1.3 is supported.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: TLS 1.3 is not supported.</para>
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
            /// <para>Indicates whether an exclusive IP address is enabled for the domain name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: An exclusive IP address is enabled for the domain name.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: An exclusive IP address is not enabled for the domain name.</para>
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
            /// <para>Indicates whether HTTP to HTTPS redirection is enabled for the domain name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: HTTP to HTTPS redirection is enabled for the domain name.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: HTTP to HTTPS redirection is not enabled for the domain name.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("FocusHttps")]
            [Validation(Required=false)]
            public bool? FocusHttps { get; set; }

            /// <summary>
            /// <para>Indicates whether HSTS includes subdomains. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: HSTS includes subdomains.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: HSTS does not include subdomains.</para>
            /// </description></item>
            /// </list>
            /// </summary>
            [NameInMap("HstsIncludeSubDomain")]
            [Validation(Required=false)]
            public bool? HstsIncludeSubDomain { get; set; }

            /// <summary>
            /// <para>The maximum age value of the HSTS policy. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>365000</para>
            /// </summary>
            [NameInMap("HstsMaxAge")]
            [Validation(Required=false)]
            public long? HstsMaxAge { get; set; }

            /// <summary>
            /// <para>Indicates whether HSTS preload is enabled. Default value: false. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: HSTS preload is enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: HSTS preload is disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("HstsPreload")]
            [Validation(Required=false)]
            public bool? HstsPreload { get; set; }

            /// <summary>
            /// <para>Indicates whether HTTP/2 is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: HTTP/2 is enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: HTTP/2 is not enabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Http2Enabled")]
            [Validation(Required=false)]
            public bool? Http2Enabled { get; set; }

            /// <summary>
            /// <para>The HTTP listener ports.</para>
            /// </summary>
            [NameInMap("HttpPorts")]
            [Validation(Required=false)]
            public List<long?> HttpPorts { get; set; }

            /// <summary>
            /// <para>The HTTPS listener ports.</para>
            /// </summary>
            [NameInMap("HttpsPorts")]
            [Validation(Required=false)]
            public List<long?> HttpsPorts { get; set; }

            /// <summary>
            /// <para>Indicates whether IPv6 is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: IPv6 is enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: IPv6 is not enabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("IPv6Enabled")]
            [Validation(Required=false)]
            public bool? IPv6Enabled { get; set; }

            /// <summary>
            /// <para>The type of the protection resource. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>share</b>: shared cluster.</para>
            /// </description></item>
            /// <item><description><para><b>gslb</b>: intelligent load balancing for shared clusters.</para>
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
            /// <para>Indicates whether only SM certificate-based clients can access the domain name. This parameter is available only if you set SM2Enabled to true. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Only SM certificate-based clients can access the domain name.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Both SM certificate-based and non-SM certificate-based clients can access the domain name.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SM2AccessOnly")]
            [Validation(Required=false)]
            public bool? SM2AccessOnly { get; set; }

            /// <summary>
            /// <para>The ID of the SM certificate. This parameter is available only if you set SM2Enabled to true.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123-cn-hangzhou</para>
            /// </summary>
            [NameInMap("SM2CertId")]
            [Validation(Required=false)]
            public string SM2CertId { get; set; }

            /// <summary>
            /// <para>Indicates whether SM certificate-based verification is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: SM certificate-based verification is enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: SM certificate-based verification is not enabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SM2Enabled")]
            [Validation(Required=false)]
            public bool? SM2Enabled { get; set; }

            /// <summary>
            /// <para>The version of the Transport Layer Security (TLS) protocol. Valid values:</para>
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
            /// <para>The method that WAF uses to obtain the originating IP address of a client. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: The client traffic is not forwarded by a Layer 7 proxy before the traffic reaches WAF.</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: WAF reads the first value of the X-Forwarded-For (XFF) field in the request header as the client IP address.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: WAF reads the value of a custom field that you specify in the request header as the client IP address.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("XffHeaderMode")]
            [Validation(Required=false)]
            public long? XffHeaderMode { get; set; }

            /// <summary>
            /// <para>The custom header fields used to obtain the actual IP address of a client.</para>
            /// </summary>
            [NameInMap("XffHeaders")]
            [Validation(Required=false)]
            public List<string> XffHeaders { get; set; }

        }

        /// <summary>
        /// <para>The forwarding configurations.</para>
        /// </summary>
        [NameInMap("Redirect")]
        [Validation(Required=false)]
        public DescribeDomainDetailResponseBodyRedirect Redirect { get; set; }
        public class DescribeDomainDetailResponseBodyRedirect : TeaModel {
            /// <summary>
            /// <para>The list of IP addresses or domain names of the backup origin servers for the domain name.</para>
            /// </summary>
            [NameInMap("BackUpBackendList")]
            [Validation(Required=false)]
            public List<string> BackUpBackendList { get; set; }

            /// <summary>
            /// <para>The list of IP addresses or domain names of the origin servers for the domain name.</para>
            /// </summary>
            [NameInMap("BackendList")]
            [Validation(Required=false)]
            public List<string> BackendList { get; set; }

            /// <summary>
            /// <para>The custom back-to-origin port mappings. By default, the back-to-origin port is the same as the listener port.</para>
            /// </summary>
            [NameInMap("BackendPorts")]
            [Validation(Required=false)]
            public List<DescribeDomainDetailResponseBodyRedirectBackendPorts> BackendPorts { get; set; }
            public class DescribeDomainDetailResponseBodyRedirectBackendPorts : TeaModel {
                /// <summary>
                /// <para>The back-to-origin port.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("BackendPort")]
                [Validation(Required=false)]
                public int? BackendPort { get; set; }

                /// <summary>
                /// <para>The listener port.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("ListenPort")]
                [Validation(Required=false)]
                public int? ListenPort { get; set; }

                /// <summary>
                /// <para>The protocol of the back-to-origin port. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>http</b>: HTTP.</para>
                /// </description></item>
                /// <item><description><para><b>https</b>: HTTPS.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>http</para>
                /// </summary>
                [NameInMap("Protocol")]
                [Validation(Required=false)]
                public string Protocol { get; set; }

            }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>The addresses of origin servers.</para>
            /// <remarks>
            /// <para>This parameter will be deprecated. We recommend that you use <b>BackendList</b> instead.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("Backends")]
            [Validation(Required=false)]
            [Obsolete]
            public List<DescribeDomainDetailResponseBodyRedirectBackends> Backends { get; set; }
            public class DescribeDomainDetailResponseBodyRedirectBackends : TeaModel {
                /// <summary>
                /// <para>The IP address or domain name of the origin server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1.1.XX.XX</para>
                /// </summary>
                [NameInMap("Backend")]
                [Validation(Required=false)]
                public string Backend { get; set; }

            }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>The addresses of backup origin servers.</para>
            /// <remarks>
            /// <para>This parameter will be deprecated. We recommend that you use <b>BackUpBackendList</b> instead.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("BackupBackends")]
            [Validation(Required=false)]
            [Obsolete]
            public List<DescribeDomainDetailResponseBodyRedirectBackupBackends> BackupBackends { get; set; }
            public class DescribeDomainDetailResponseBodyRedirectBackupBackends : TeaModel {
                /// <summary>
                /// <para>The backup IP address or domain name of the origin server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[
                ///     &quot;1.1.XX.XX&quot;,
                ///     &quot;2.2.XX.XX&quot;
                /// ]</para>
                /// </summary>
                [NameInMap("Backend")]
                [Validation(Required=false)]
                public string Backend { get; set; }

            }

            /// <summary>
            /// <para>The timeout period for connections. Unit: seconds. Valid values: 5 to 120.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("ConnectTimeout")]
            [Validation(Required=false)]
            public int? ConnectTimeout { get; set; }

            /// <summary>
            /// <para>Indicates whether back-to-origin requests are forced to use HTTP. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Requests are forced to use HTTP.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Requests are not forced to use HTTP.</para>
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
            /// <para>Indicates whether HTTP/2 is enabled for back-to-origin requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Http2Origin")]
            [Validation(Required=false)]
            public bool? Http2Origin { get; set; }

            /// <summary>
            /// <para>The maximum number of concurrent connections for HTTP/2 back-to-origin requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>128</para>
            /// </summary>
            [NameInMap("Http2OriginMaxConcurrency")]
            [Validation(Required=false)]
            public int? Http2OriginMaxConcurrency { get; set; }

            /// <summary>
            /// <para>Indicates whether persistent connections are enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b> (default): Persistent connections are enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Persistent connections are disabled.</para>
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
            /// <para>The maximum number of requests that reuse a persistent connection. Valid values: 60 to 1,000.</para>
            /// <remarks>
            /// <para>The number of reused persistent connections after the persistent connection feature is enabled.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("KeepaliveRequests")]
            [Validation(Required=false)]
            public int? KeepaliveRequests { get; set; }

            /// <summary>
            /// <para>The timeout period for idle persistent connections. Valid values: 1 to 60. Default value: 15. Unit: seconds.</para>
            /// <remarks>
            /// <para>The period of time during which a reused persistent connection is allowed to remain idle before the connection is closed.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("KeepaliveTimeout")]
            [Validation(Required=false)]
            public int? KeepaliveTimeout { get; set; }

            /// <summary>
            /// <para>The load balancing algorithm used when WAF forwards requests to the origin server. Valid values:</para>
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
            /// <para>The maximum size of a request body. Valid values: 2 to 10. Default value: 2. Unit: GB.</para>
            /// <remarks>
            /// <para>This feature is available only for the Ultimate edition.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("MaxBodySize")]
            [Validation(Required=false)]
            public int? MaxBodySize { get; set; }

            /// <summary>
            /// <para>Indicates whether the Proxy Protocol feature is enabled for back-to-origin requests. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: The Proxy Protocol feature is enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The Proxy Protocol feature is disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("ProxyProtocol")]
            [Validation(Required=false)]
            public bool? ProxyProtocol { get; set; }

            /// <summary>
            /// <para>The timeout period for read operations. Unit: seconds. Valid values: 5 to 1,800.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("ReadTimeout")]
            [Validation(Required=false)]
            public int? ReadTimeout { get; set; }

            /// <summary>
            /// <para>The custom header fields used to mark requests that pass through WAF.</para>
            /// </summary>
            [NameInMap("RequestHeaders")]
            [Validation(Required=false)]
            public List<DescribeDomainDetailResponseBodyRedirectRequestHeaders> RequestHeaders { get; set; }
            public class DescribeDomainDetailResponseBodyRedirectRequestHeaders : TeaModel {
                /// <summary>
                /// <para>The key of the custom header field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>aaa</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of the custom header field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bbb</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether WAF retries forwarding requests to the origin server upon failure. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b> (default): WAF retries.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: WAF does not retry.</para>
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
            /// <para>Indicates whether origin Server Name Indication (SNI) is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Origin SNI is enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b> (default): Origin SNI is not enabled.</para>
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
            /// <para>The value of the SNI field.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.aliyundoc.com">www.aliyundoc.com</a></para>
            /// </summary>
            [NameInMap("SniHost")]
            [Validation(Required=false)]
            public string SniHost { get; set; }

            /// <summary>
            /// <para>Indicates whether the WL-Proxy-Client-IP header is included in back-to-origin requests. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b> (default): The WL-Proxy-Client-IP header is included.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The WL-Proxy-Client-IP header is not included.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("WLProxyClientIp")]
            [Validation(Required=false)]
            public bool? WLProxyClientIp { get; set; }

            /// <summary>
            /// <para>Indicates whether the Web-Server-Type header is included in back-to-origin requests. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b> (default): The Web-Server-Type header is included.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The Web-Server-Type header is not included.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("WebServerType")]
            [Validation(Required=false)]
            public bool? WebServerType { get; set; }

            /// <summary>
            /// <para>The timeout period for write operations. Unit: seconds. Valid values: 5 to 1,800.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("WriteTimeout")]
            [Validation(Required=false)]
            public int? WriteTimeout { get; set; }

            /// <summary>
            /// <para>Indicates whether the X-Client-IP header is included in back-to-origin requests. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b> (default): The X-Client-IP header is included.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The X-Client-IP header is not included.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("XClientIp")]
            [Validation(Required=false)]
            public bool? XClientIp { get; set; }

            /// <summary>
            /// <para>Indicates whether the X-True-IP header is included in back-to-origin requests. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b> (default): The X-True-IP header is included.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The X-True-IP header is not included.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("XTrueIp")]
            [Validation(Required=false)]
            public bool? XTrueIp { get; set; }

            /// <summary>
            /// <para>Indicates whether the X-Forward-For-Proto header is included in back-to-origin requests to pass the protocol used by WAF. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b> (default): The X-Forward-For-Proto header is included.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The X-Forward-For-Proto header is not included.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("XffProto")]
            [Validation(Required=false)]
            public bool? XffProto { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BAEF9CA9-66A0-533E-BD09-5D5D7AA8****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm***q</para>
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

        /// <summary>
        /// <para>The details of the SM certificate.</para>
        /// </summary>
        [NameInMap("SM2CertDetail")]
        [Validation(Required=false)]
        public DescribeDomainDetailResponseBodySM2CertDetail SM2CertDetail { get; set; }
        public class DescribeDomainDetailResponseBodySM2CertDetail : TeaModel {
            /// <summary>
            /// <para>The common name of the SM certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test.aliyundoc.com</para>
            /// </summary>
            [NameInMap("CommonName")]
            [Validation(Required=false)]
            public string CommonName { get; set; }

            /// <summary>
            /// <para>The end of the validity period of the SM certificate. This value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1665590400000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The ID of the SM certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123-cn-hangzhou</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The name of the SM certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-sm2-cert-name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The domain names that are bound to the SM certificate.</para>
            /// </summary>
            [NameInMap("Sans")]
            [Validation(Required=false)]
            public List<string> Sans { get; set; }

            /// <summary>
            /// <para>The beginning of the validity period of the SM certificate. This value is a UNIX timestamp. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1657551525000</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

        }

        /// <summary>
        /// <para>The status of the domain name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: The domain name is in normal status.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: The domain name is being created.</para>
        /// </description></item>
        /// <item><description><para><b>3</b>: The domain name is being modified.</para>
        /// </description></item>
        /// <item><description><para><b>4</b>: The domain name is being released.</para>
        /// </description></item>
        /// <item><description><para><b>5</b>: The domain name stops forwarding traffic.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
