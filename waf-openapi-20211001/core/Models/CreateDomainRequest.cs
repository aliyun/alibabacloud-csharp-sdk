// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class CreateDomainRequest : TeaModel {
        /// <summary>
        /// <para>The access type of the WAF instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>share</b> (default): onboarding by using a CNAME record.</para>
        /// </description></item>
        /// <item><description><para><b>hybrid_cloud_cname</b>: onboarding by using a hybrid cloud CNAME record.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>share</para>
        /// </summary>
        [NameInMap("AccessType")]
        [Validation(Required=false)]
        public string AccessType { get; set; }

        /// <summary>
        /// <para>The domain name that you want to add.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.aliyundoc.com">www.aliyundoc.com</a></para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The ID of the WAF instance.</para>
        /// <remarks>
        /// <para>Call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to query the ID of the WAF instance.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf_cdnsdf3****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The listening configurations.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Listen")]
        [Validation(Required=false)]
        public CreateDomainRequestListen Listen { get; set; }
        public class CreateDomainRequestListen : TeaModel {
            /// <summary>
            /// <para>The ID of the certificate. This parameter is available only if you specify <b>HttpsPorts</b> (indicating that the domain name uses HTTPS).</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("CertId")]
            [Validation(Required=false)]
            public string CertId { get; set; }

            /// <summary>
            /// <para>The type of the cipher suite. This parameter is available only if you specify <b>HttpsPorts</b> (indicating that the domain name uses HTTPS). Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: All cipher suites.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: Strong cipher suites. This value is available only if you set <b>TLSVersion</b> to <b>tlsv1.2</b>.</para>
            /// </description></item>
            /// <item><description><para><b>99</b>: Custom cipher suites.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("CipherSuite")]
            [Validation(Required=false)]
            public int? CipherSuite { get; set; }

            /// <summary>
            /// <para>The custom cipher suites.</para>
            /// </summary>
            [NameInMap("CustomCiphers")]
            [Validation(Required=false)]
            public List<string> CustomCiphers { get; set; }

            /// <summary>
            /// <para>Indicates whether TLS 1.3 is supported. This parameter is available only if you specify <b>HttpsPorts</b> (indicating that the domain name uses HTTPS). Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: TLS 1.3 is supported.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: TLS 1.3 is not supported.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("EnableTLSv3")]
            [Validation(Required=false)]
            public bool? EnableTLSv3 { get; set; }

            /// <summary>
            /// <para>Indicates whether the exclusive IP address feature is enabled. This parameter is available only if you set <b>IPv6Enabled</b> to <b>false</b> (indicating that IPv6 is disabled) and <b>ProtectionResource</b> to <b>share</b> (indicating that a shared cluster is used). Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: The exclusive IP address feature is enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b> (default): The exclusive IP address feature is disabled.</para>
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
            /// <para>Indicates whether force redirect from HTTP to HTTPS is enabled for received requests. This parameter is available only if you specify HttpsPorts and leave HttpPorts empty. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Force redirect from HTTP to HTTPS is enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Force redirect from HTTP to HTTPS is disabled.</para>
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
            /// <para>The time-to-live (TTL) for HSTS. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>365000</para>
            /// </summary>
            [NameInMap("HstsMaxAge")]
            [Validation(Required=false)]
            public long? HstsMaxAge { get; set; }

            /// <summary>
            /// <para>Indicates whether HSTS preloading is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: HSTS preloading is enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: HSTS preloading is disabled.</para>
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
            /// <para>Indicates whether HTTP/2 is enabled. This parameter is available only if you specify <b>HttpsPorts</b> (indicating that the domain name uses HTTPS). Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: HTTP/2 is enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b> (default): HTTP/2 is disabled.</para>
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
            /// <para>The listening ports for HTTP.</para>
            /// </summary>
            [NameInMap("HttpPorts")]
            [Validation(Required=false)]
            public List<int?> HttpPorts { get; set; }

            /// <summary>
            /// <para>The listening ports for HTTPS.</para>
            /// </summary>
            [NameInMap("HttpsPorts")]
            [Validation(Required=false)]
            public List<int?> HttpsPorts { get; set; }

            /// <summary>
            /// <para>Indicates whether IPv6 is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: IPv6 is enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b> (default): IPv6 is disabled.</para>
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
            /// <para>The type of protection resource. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>share</b> (default): Shared cluster.</para>
            /// </description></item>
            /// <item><description><para><b>gslb</b>: Intelligent load balancing for a shared cluster.</para>
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
            /// <para>Indicates whether access is restricted to SM certificate-based clients only. This parameter is available only if you set SM2Enabled to true. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Only SM certificate-based clients can access the domain.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Both SM certificate-based and non-SM certificate-based clients can access the domain.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("SM2AccessOnly")]
            [Validation(Required=false)]
            public bool? SM2AccessOnly { get; set; }

            /// <summary>
            /// <para>The ID of the SM certificate. This parameter is available only if you set SM2Enabled to true.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123-cn-hangzhou</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("SM2CertId")]
            [Validation(Required=false)]
            public string SM2CertId { get; set; }

            /// <summary>
            /// <para>Indicates whether SM certificate-based encryption is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("SM2Enabled")]
            [Validation(Required=false)]
            public bool? SM2Enabled { get; set; }

            /// <summary>
            /// <para>The minimum Transport Layer Security (TLS) version. This parameter is available only if you specify <b>HttpsPorts</b> (indicating that the domain name uses HTTPS). Valid values:</para>
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
            /// <para>tlsv1</para>
            /// </summary>
            [NameInMap("TLSVersion")]
            [Validation(Required=false)]
            public string TLSVersion { get; set; }

            /// <summary>
            /// <para>The method that WAF uses to obtain the originating IP address of a client. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b> (default): The client traffic does not pass through other Layer 7 proxies before it reaches WAF.</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: WAF uses the first value in the X-Forwarded-For (XFF) header as the client IP address.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: WAF uses the value of a custom header field that you specify as the client IP address.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("XffHeaderMode")]
            [Validation(Required=false)]
            public int? XffHeaderMode { get; set; }

            /// <summary>
            /// <para>The custom header fields that are used to obtain the originating IP address of a client.</para>
            /// </summary>
            [NameInMap("XffHeaders")]
            [Validation(Required=false)]
            public List<string> XffHeaders { get; set; }

        }

        /// <summary>
        /// <para>The forwarding configurations.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Redirect")]
        [Validation(Required=false)]
        public CreateDomainRequestRedirect Redirect { get; set; }
        public class CreateDomainRequestRedirect : TeaModel {
            /// <summary>
            /// <para>The custom port configuration.</para>
            /// </summary>
            [NameInMap("BackendPorts")]
            [Validation(Required=false)]
            public List<CreateDomainRequestRedirectBackendPorts> BackendPorts { get; set; }
            public class CreateDomainRequestRedirectBackendPorts : TeaModel {
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
                /// <para>The protocol of the listener port. Valid values:</para>
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

            /// <summary>
            /// <para>The IP address or domain name of the origin server.</para>
            /// </summary>
            [NameInMap("Backends")]
            [Validation(Required=false)]
            public List<string> Backends { get; set; }

            /// <summary>
            /// <para>The secondary IP address or domain name of the origin server.</para>
            /// </summary>
            [NameInMap("BackupBackends")]
            [Validation(Required=false)]
            public List<string> BackupBackends { get; set; }

            /// <summary>
            /// <para>Indicates whether the public cloud disaster recovery feature is enabled for the domain name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: The public cloud disaster recovery feature is enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b> (default): The public cloud disaster recovery feature is disabled.</para>
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
            /// <para>The timeout period for connections. Unit: seconds. Valid values: 1 to 3600. Default value: 5.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("ConnectTimeout")]
            [Validation(Required=false)]
            public int? ConnectTimeout { get; set; }

            /// <summary>
            /// <para>Indicates whether force redirect from HTTPS to HTTP is enabled for back-to-origin requests. This parameter is available only if you specify <b>HttpsPorts</b> (indicating that the domain name uses HTTPS). Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Force redirect from HTTPS to HTTP is enabled for back-to-origin requests.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Force redirect from HTTPS to HTTP is disabled for back-to-origin requests.</para>
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
            /// <para>Indicates whether HTTP/2 is enabled for back-to-origin traffic. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: HTTP/2 is enabled for back-to-origin traffic.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: HTTP/2 is disabled for back-to-origin traffic.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Http2Origin")]
            [Validation(Required=false)]
            public bool? Http2Origin { get; set; }

            /// <summary>
            /// <para>The maximum number of concurrent HTTP/2 back-to-origin requests. Valid values: 1 to 512. Default value: 128.</para>
            /// 
            /// <b>Example:</b>
            /// <para>128</para>
            /// </summary>
            [NameInMap("Http2OriginMaxConcurrency")]
            [Validation(Required=false)]
            public int? Http2OriginMaxConcurrency { get; set; }

            /// <summary>
            /// <para>Indicates whether the persistent connection feature is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b> (default): The persistent connection feature is enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The persistent connection feature is disabled.</para>
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
            /// <para>The number of reused persistent connections. Valid values: 60 to 1000. Default value: 1000.</para>
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
            /// <para>The timeout period of idle persistent connections. Valid values: 1 to 60. Default value: 15. Unit: seconds.</para>
            /// <remarks>
            /// <para>This parameter specifies the time for which a reused persistent connection can remain in the Idle state before the persistent connection is closed.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("KeepaliveTimeout")]
            [Validation(Required=false)]
            public int? KeepaliveTimeout { get; set; }

            /// <summary>
            /// <para>The load balancing algorithm that you want to use when WAF forwards requests to the origin server. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>iphash</b>: IP hash algorithm.</para>
            /// </description></item>
            /// <item><description><para><b>roundRobin</b>: Round-robin algorithm.</para>
            /// </description></item>
            /// <item><description><para><b>leastTime</b>: Least Time algorithm. This value is available only if you set <b>ProtectionResource</b> to <b>gslb</b> (indicating that intelligent load balancing for a shared cluster is used).</para>
            /// </description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>roundRobin</para>
            /// </summary>
            [NameInMap("Loadbalance")]
            [Validation(Required=false)]
            public string Loadbalance { get; set; }

            /// <summary>
            /// <para>The maximum size of a request body. Valid values: 2 to 10. Default value: 2. Unit: GB.</para>
            /// <remarks>
            /// <para>This parameter is supported only by the Ultimate edition.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("MaxBodySize")]
            [Validation(Required=false)]
            public int? MaxBodySize { get; set; }

            /// <summary>
            /// <para>Indicates whether the Proxy Protocol feature is enabled to preserve the client\&quot;s source IP address. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: The Proxy Protocol feature is enabled. After this feature is enabled, backend services can view the original IP address of the client.</para>
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
            /// <para>The timeout period for read operations. Unit: seconds. Valid values: 1 to 3600. Default value: 120.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("ReadTimeout")]
            [Validation(Required=false)]
            public int? ReadTimeout { get; set; }

            /// <summary>
            /// <para>The key-value pairs that you want to use to label the requests that pass through the WAF instance.</para>
            /// <para>When a request passes through WAF, WAF automatically adds the custom header fields to the request to mark the request. This way, the backend service can identify requests that are processed by WAF.</para>
            /// </summary>
            [NameInMap("RequestHeaders")]
            [Validation(Required=false)]
            public List<CreateDomainRequestRedirectRequestHeaders> RequestHeaders { get; set; }
            public class CreateDomainRequestRedirectRequestHeaders : TeaModel {
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
            /// <para>Indicates whether WAF retries when WAF fails to forward requests to the origin server. Valid values:</para>
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
            /// <para>The forwarding rules for hybrid cloud mode. The value contains the following fields:</para>
            /// <list type="bullet">
            /// <item><description><para><b>rs</b>: The IP addresses or canonical names of the origin servers.</para>
            /// </description></item>
            /// <item><description><para><b>backupRs</b>: The backup IP addresses or canonical names of the origin servers. Required. An empty array [] means no backup is configured.</para>
            /// </description></item>
            /// <item><description><para><b>location</b>: The name of the protection node.</para>
            /// </description></item>
            /// <item><description><para><b>locationId</b>: The ID of the protection node.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>[
            ///     {
            ///         &quot;rs&quot;:
            ///         [
            ///             &quot;1.1.XX.XX&quot;
            ///         ],
            ///         &quot;backupRs&quot;:
            ///         [
            ///             &quot;2.2.XX.XX&quot;
            ///         ],
            ///         &quot;locationId&quot;: 535,
            ///         &quot;location&quot;: &quot;test1111&quot;
            ///     }
            /// ]</para>
            /// </summary>
            [NameInMap("RoutingRules")]
            [Validation(Required=false)]
            public string RoutingRules { get; set; }

            /// <summary>
            /// <para>Indicates whether the Server Name Indication (SNI) feature is enabled for back-to-origin requests. This parameter is available only if you specify <b>HttpsPorts</b> (indicating that the domain name uses HTTPS). Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: The SNI feature is enabled for back-to-origin requests.</para>
            /// </description></item>
            /// <item><description><para><b>false</b> (default): The SNI feature is disabled for back-to-origin requests.</para>
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
            /// <para>The custom value of the SNI field. If you do not specify this parameter, the value of the <b>Host</b> header in the request is used as the value of the SNI field. This parameter is optional. If you want WAF to use an SNI field value that is different from the Host field value in back-to-origin requests, you can specify a custom value for the SNI field.</para>
            /// <remarks>
            /// <para>This parameter is required only if you set <b>SniEnabled</b> to <b>true</b> (indicating that the SNI feature is enabled for back-to-origin requests).</para>
            /// </remarks>
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
            /// <item><description><para><b>true</b> (default): WAF overwrites the header.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: WAF does not overwrite the header.</para>
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
            /// <item><description><para><b>true</b> (default): WAF overwrites the header.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: WAF does not overwrite the header.</para>
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
            /// <para>The timeout period for write operations. Unit: seconds. Valid values: 1 to 3600. Default value: 120.</para>
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
            /// <item><description><para><b>true</b> (default): WAF overwrites the header.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: WAF does not overwrite the header.</para>
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
            /// <item><description><para><b>true</b> (default): WAF overwrites the header.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: WAF does not overwrite the header.</para>
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
            /// <para>Indicates whether the X-Forward-For-Proto header is used to identify the protocol used by WAF to forward requests to the origin server. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b> (default): The X-Forward-For-Proto header is used to identify the protocol.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The X-Forward-For-Proto header is not used.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("XffProto")]
            [Validation(Required=false)]
            public bool? XffProto { get; set; }

        }

        /// <summary>
        /// <para>The region where the WAF instance resides. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>cn-hangzhou</b>: The Chinese mainland.</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-1</b>: Outside the Chinese mainland.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

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
        /// <para>The tags. You can specify up to 20 tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateDomainRequestTag> Tag { get; set; }
        public class CreateDomainRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Tagkey1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TagValue1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
