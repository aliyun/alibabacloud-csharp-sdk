// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeDomainDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The SSL certificate details.</para>
        /// </summary>
        [NameInMap("CertDetail")]
        [Validation(Required=false)]
        public DescribeDomainDetailResponseBodyCertDetail CertDetail { get; set; }
        public class DescribeDomainDetailResponseBodyCertDetail : TeaModel {
            /// <summary>
            /// <para>The common name (CN).</para>
            /// 
            /// <b>Example:</b>
            /// <para>test.aliyundoc.com</para>
            /// </summary>
            [NameInMap("CommonName")]
            [Validation(Required=false)]
            public string CommonName { get; set; }

            /// <summary>
            /// <para>The time when the certificate expires. The value is a UNIX timestamp in UTC. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1685590400000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The SSL certificate ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123-cn-hangzhou</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The certificate name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-cert-name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>All domain names bound to the certificate.</para>
            /// </summary>
            [NameInMap("Sans")]
            [Validation(Required=false)]
            public List<string> Sans { get; set; }

            /// <summary>
            /// <para>The effective period of the certificate. The value is in the format of a UNIX timestamp (UTC). Unit: milliseconds.</para>
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
        /// <para>The domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.aliyundoc.com">www.aliyundoc.com</a></para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The domain name ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.aliyundoc.com-waf">www.aliyundoc.com-waf</a></para>
        /// </summary>
        [NameInMap("DomainId")]
        [Validation(Required=false)]
        public string DomainId { get; set; }

        /// <summary>
        /// <para>The listener configuration.</para>
        /// </summary>
        [NameInMap("Listen")]
        [Validation(Required=false)]
        public DescribeDomainDetailResponseBodyListen Listen { get; set; }
        public class DescribeDomainDetailResponseBodyListen : TeaModel {
            /// <summary>
            /// <para>The certificate ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("CertId")]
            [Validation(Required=false)]
            public string CertId { get; set; }

            /// <summary>
            /// <para>The type of the cipher suite. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: all cipher suites are added.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: strong cipher suites are added.</para>
            /// </description></item>
            /// <item><description><para><b>99</b>: custom cipher suites are added.</para>
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
            /// <para>Indicates whether an exclusive IP address is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: An exclusive IP address is enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: An exclusive IP address is not enabled.</para>
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
            /// <item><description><para><b>true</b>: HTTPS forced redirect is enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: HTTPS forced redirect is not enabled.</para>
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
            /// <item><description><para><b>true</b>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Not enabled.</para>
            /// </description></item>
            /// </list>
            /// </summary>
            [NameInMap("HstsIncludeSubDomain")]
            [Validation(Required=false)]
            public bool? HstsIncludeSubDomain { get; set; }

            /// <summary>
            /// <para>The HSTS expiration time. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>365000</para>
            /// </summary>
            [NameInMap("HstsMaxAge")]
            [Validation(Required=false)]
            public long? HstsMaxAge { get; set; }

            /// <summary>
            /// <para>Indicates whether HSTS preloading is enabled. This feature is disabled by default. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Enabled.</description></item>
            /// <item><description>false: Disabled.</description></item>
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
            /// <para>The listening ports for the HTTP protocol.</para>
            /// </summary>
            [NameInMap("HttpPorts")]
            [Validation(Required=false)]
            public List<long?> HttpPorts { get; set; }

            /// <summary>
            /// <para>The listening ports for the HTTPS protocol.</para>
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
            /// <para>The type of protection resource to use. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>share</b>: shared cluster.</para>
            /// </description></item>
            /// <item><description><para><b>gslb</b>: shared cluster with intelligent load balancing.</para>
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
            /// <para>Indicates whether only SM-compliant clients can access the domain name. This parameter is used only when SM2Enable is set to true.</para>
            /// <list type="bullet">
            /// <item><description><para>true: Only SM-compliant clients can access the domain name.</para>
            /// </description></item>
            /// <item><description><para>false: Both SM-compliant and non-SM-compliant clients can access the domain name.</para>
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
            /// <para>The ID of the SM certificate to add. This parameter is used only when SM2Enable is set to true.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123-cn-hangzhou</para>
            /// </summary>
            [NameInMap("SM2CertId")]
            [Validation(Required=false)]
            public string SM2CertId { get; set; }

            /// <summary>
            /// <para>Indicates whether the China Encryption Standard (SM) certificate is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: The SM certificate is enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The SM certificate is not enabled.</para>
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
            /// <para>2</para>
            /// </summary>
            [NameInMap("XffHeaderMode")]
            [Validation(Required=false)]
            public long? XffHeaderMode { get; set; }

            /// <summary>
            /// <para>The list of custom header fields used to obtain the client IP address.</para>
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
        public DescribeDomainDetailResponseBodyRedirect Redirect { get; set; }
        public class DescribeDomainDetailResponseBodyRedirect : TeaModel {
            /// <summary>
            /// <para>The list of secondary origin server IP addresses or back-to-origin domain names for the domain name.</para>
            /// </summary>
            [NameInMap("BackUpBackendList")]
            [Validation(Required=false)]
            public List<string> BackUpBackendList { get; set; }

            /// <summary>
            /// <para>The list of origin server IP addresses or back-to-origin domain names for the domain name.</para>
            /// </summary>
            [NameInMap("BackendList")]
            [Validation(Required=false)]
            public List<string> BackendList { get; set; }

            /// <summary>
            /// <para>The custom port configuration. By default, this is the same as the listening port.</para>
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
                /// <para>The listening port.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("ListenPort")]
                [Validation(Required=false)]
                public int? ListenPort { get; set; }

                /// <summary>
                /// <para>The protocol type of the listening port. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>http</b>: HTTP protocol.</description></item>
                /// <item><description><b>https</b>: HTTPS protocol.</description></item>
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
            /// <para>The back-to-origin addresses of the domain name.</para>
            /// <remarks>
            /// <para>This parameter will be deprecated. Use <b>BackendList</b> instead.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("Backends")]
            [Validation(Required=false)]
            [Obsolete]
            public List<DescribeDomainDetailResponseBodyRedirectBackends> Backends { get; set; }
            public class DescribeDomainDetailResponseBodyRedirectBackends : TeaModel {
                /// <summary>
                /// <para>The IP address or domain name of the origin server for the domain name.</para>
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
            /// <para>The secondary back-to-origin addresses of the domain name.</para>
            /// <remarks>
            /// <para>This parameter will be deprecated. Use <b>BackUpBackendList</b> instead.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("BackupBackends")]
            [Validation(Required=false)]
            [Obsolete]
            public List<DescribeDomainDetailResponseBodyRedirectBackupBackends> BackupBackends { get; set; }
            public class DescribeDomainDetailResponseBodyRedirectBackupBackends : TeaModel {
                /// <summary>
                /// <para>The IP address or domain name of the secondary origin server for the domain name.</para>
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
            /// <para>The connection timeout period. Unit: seconds.
            /// Valid values: 5 to 120.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("ConnectTimeout")]
            [Validation(Required=false)]
            public int? ConnectTimeout { get; set; }

            /// <summary>
            /// <para>Indicates whether forced HTTP back-to-origin is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Forced HTTP back-to-origin is enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Forced HTTP back-to-origin is not enabled.</para>
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
            /// <para>The HTTP/2 back-to-origin setting.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Http2Origin")]
            [Validation(Required=false)]
            public bool? Http2Origin { get; set; }

            /// <summary>
            /// <para>The maximum number of concurrent connections for HTTP/2 back-to-origin.</para>
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
            /// <item><description><para><b>false</b>: Persistent connections are not enabled.</para>
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
            /// <para>The number of requests that can reuse a persistent connection. Valid values: 60 to 1000.</para>
            /// <remarks>
            /// <para>After persistent connections are enabled, this parameter specifies how many persistent connections can be reused.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("KeepaliveRequests")]
            [Validation(Required=false)]
            public int? KeepaliveRequests { get; set; }

            /// <summary>
            /// <para>The idle timeout period for persistent connections. Valid values: 1 to 60. Default value: 15. Unit: seconds.</para>
            /// <remarks>
            /// <para>Specifies how long an idle persistent connection can remain open before it is released.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("KeepaliveTimeout")]
            [Validation(Required=false)]
            public int? KeepaliveTimeout { get; set; }

            /// <summary>
            /// <para>The load balancing algorithm used for back-to-origin. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>iphash</b>: IP hash algorithm.</para>
            /// </description></item>
            /// <item><description><para><b>roundRobin</b>: round-robin algorithm.</para>
            /// </description></item>
            /// <item><description><para><b>leastTime</b>: least-time back-to-origin algorithm.</para>
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
            /// <para>The maximum request body size. Valid values: 2 to 10. Default value: 2. Unit: GB.</para>
            /// <remarks>
            /// <para>Only Ultimate Edition supports this feature.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("MaxBodySize")]
            [Validation(Required=false)]
            public int? MaxBodySize { get; set; }

            /// <summary>
            /// <para>Indicates whether the client source IP preservation feature is enabled.</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The client source IP preservation feature is enabled. After this feature is enabled, the backend service can view the originating IP address of the client.</description></item>
            /// <item><description><b>false</b>: The client source IP preservation feature is not enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("ProxyProtocol")]
            [Validation(Required=false)]
            public bool? ProxyProtocol { get; set; }

            /// <summary>
            /// <para>The read timeout period. Unit: seconds.
            /// Valid values: 5 to 1800.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("ReadTimeout")]
            [Validation(Required=false)]
            public int? ReadTimeout { get; set; }

            /// <summary>
            /// <para>The traffic tag fields and values of the domain name, which are used to mark traffic processed by WAF.</para>
            /// </summary>
            [NameInMap("RequestHeaders")]
            [Validation(Required=false)]
            public List<DescribeDomainDetailResponseBodyRedirectRequestHeaders> RequestHeaders { get; set; }
            public class DescribeDomainDetailResponseBodyRedirectRequestHeaders : TeaModel {
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
            /// <para>Indicates whether WAF retries when back-to-origin fails. Valid values:</para>
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
            /// <para>Indicates whether back-to-origin SNI is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Back-to-origin SNI is enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b> (default): Back-to-origin SNI is not enabled.</para>
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
            /// <para>The value of the custom SNI extension field.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.aliyundoc.com">www.aliyundoc.com</a></para>
            /// </summary>
            [NameInMap("SniHost")]
            [Validation(Required=false)]
            public string SniHost { get; set; }

            /// <summary>
            /// <para>Indicates whether WAF is allowed to overwrite the WL-Proxy-Client-IP header. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b> (default): WAF is allowed to overwrite the header.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: WAF is not allowed to overwrite the header.</para>
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
            /// <para>Indicates whether WAF is allowed to overwrite the Web-Server-Type header. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b> (default): WAF is allowed to overwrite the header.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: WAF is not allowed to overwrite the header.</para>
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
            /// <para>The write timeout period. Unit: seconds.
            /// Valid values: 5 to 1800.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("WriteTimeout")]
            [Validation(Required=false)]
            public int? WriteTimeout { get; set; }

            /// <summary>
            /// <para>Indicates whether WAF is allowed to overwrite the X-Client-IP header. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b> (default): WAF is allowed to overwrite the header.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: WAF is not allowed to overwrite the header.</para>
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
            /// <para>Indicates whether WAF is allowed to overwrite the X-True-IP header. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b> (default): WAF is allowed to overwrite the header.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: WAF is not allowed to overwrite the header.</para>
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
            /// <para>Indicates whether the X-Forward-For-Proto header is used to pass the protocol used by WAF. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b> (default): The protocol used by WAF is passed.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The protocol used by WAF is not passed.</para>
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
        /// <para>The Alibaba Cloud resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm***q</para>
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

        /// <summary>
        /// <para>The SM certificate information.</para>
        /// </summary>
        [NameInMap("SM2CertDetail")]
        [Validation(Required=false)]
        public DescribeDomainDetailResponseBodySM2CertDetail SM2CertDetail { get; set; }
        public class DescribeDomainDetailResponseBodySM2CertDetail : TeaModel {
            /// <summary>
            /// <para>The common name (CN).</para>
            /// 
            /// <b>Example:</b>
            /// <para>test.aliyundoc.com</para>
            /// </summary>
            [NameInMap("CommonName")]
            [Validation(Required=false)]
            public string CommonName { get; set; }

            /// <summary>
            /// <para>The time when the certificate expires. The value is a UNIX timestamp in UTC. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1665590400000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>The SSL certificate ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123-cn-hangzhou</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The certificate name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-sm2-cert-name</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>All domain names bound to the certificate.</para>
            /// </summary>
            [NameInMap("Sans")]
            [Validation(Required=false)]
            public List<string> Sans { get; set; }

            /// <summary>
            /// <para>The effective period of the certificate. The value is in the format of a UNIX timestamp (UTC). Unit: milliseconds.</para>
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
        /// <item><description><para><b>1</b>: The domain name is in a normal state.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: The domain name is being created.</para>
        /// </description></item>
        /// <item><description><para><b>3</b>: The domain name is being modified.</para>
        /// </description></item>
        /// <item><description><para><b>4</b>: The domain name is being released.</para>
        /// </description></item>
        /// <item><description><para><b>5</b>: The domain name has stopped forwarding traffic.</para>
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
