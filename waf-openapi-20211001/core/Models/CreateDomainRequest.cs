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
        /// <item><description><para><b>share</b> (default): CNAME access.</para>
        /// </description></item>
        /// <item><description><para><b>hybrid_cloud_cname</b>: hybrid cloud CNAME access.</para>
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
        /// <para>The domain name to query.</para>
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
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> to query the ID of the current WAF instance.</para>
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
        /// <para>The listening configuration.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Listen")]
        [Validation(Required=false)]
        public CreateDomainRequestListen Listen { get; set; }
        public class CreateDomainRequestListen : TeaModel {
            /// <summary>
            /// <para>The ID of the certificate to add. This parameter is used only when <b>HttpsPorts</b> is not empty, which indicates that the domain name uses HTTPS.</para>
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
            /// <para>The type of cipher suite to add. This parameter is used only when <b>HttpsPorts</b> is not empty, which indicates that the domain name uses HTTPS. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: all cipher suites.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: strong cipher suites. This value is available only when <b>TLSVersion</b> is set to <b>tlsv1.2</b>.</para>
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
            public int? CipherSuite { get; set; }

            /// <summary>
            /// <para>The custom cipher suites to add.</para>
            /// </summary>
            [NameInMap("CustomCiphers")]
            [Validation(Required=false)]
            public List<string> CustomCiphers { get; set; }

            /// <summary>
            /// <para>Specifies whether to support TLS 1.3. This parameter is used only when <b>HttpsPorts</b> is not empty, which indicates that the domain name uses HTTPS. Valid values:</para>
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
            /// <para>Specifies whether to enable an exclusive IP address. This parameter is used only when <b>IPv6Enabled</b> is set to <b>false</b> (which indicates that IPv6 is not enabled) and <b>ProtectionResource</b> is set to <b>share</b> (which indicates that a shared cluster is used). Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: An exclusive IP address is enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b> (default): An exclusive IP address is not enabled.</para>
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
            /// <para>Specifies whether to enable forced HTTPS redirect. This parameter is used only when HttpsPorts is not empty (which indicates that the domain name uses HTTPS) and HttpPorts is empty (which indicates that the domain name does not use HTTP). Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Forced HTTPS redirect is enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Forced HTTPS redirect is not enabled.</para>
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
            /// <para>Specifies whether HSTS includes subdomains. Valid values:</para>
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
            /// <para>Specifies whether to enable HSTS preloading. This feature is disabled by default. Valid values:</para>
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
            /// <para>Specifies whether to enable HTTP/2. This parameter is used only when <b>HttpsPorts</b> is not empty, which indicates that the domain name uses HTTPS. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: HTTP/2 is enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b> (default): HTTP/2 is not enabled.</para>
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
            /// <para>Specifies whether to enable IPv6. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: IPv6 is enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b> (default): IPv6 is not enabled.</para>
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
            /// <item><description><para><b>share</b> (default): shared cluster.</para>
            /// </description></item>
            /// <item><description><para><b>gslb</b>: shared cluster-based intelligent load balancing.</para>
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
            /// <para>Specifies whether only China Encryption (SM) clients can access the domain name. This parameter is used only when SM2Enabled is set to true.</para>
            /// <list type="bullet">
            /// <item><description><para>true: Only China Encryption (SM) clients can access the domain name.</para>
            /// </description></item>
            /// <item><description><para>false: Both China Encryption (SM) and non-China Encryption (SM) clients can access the domain name.</para>
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
            /// <para>The ID of the China Encryption (SM) certificate to add. This parameter is used only when SM2Enabled is set to true.</para>
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
            /// <para>Specifies whether to enable the China Encryption (SM) certificate.</para>
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
            /// <para>The TLS version to add. This parameter is used only when <b>HttpsPorts</b> is not empty, which indicates that the domain name uses HTTPS. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>tlsv1</b></description></item>
            /// <item><description><b>tlsv1.1</b></description></item>
            /// <item><description><b>tlsv1.2</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>tlsv1</para>
            /// </summary>
            [NameInMap("TLSVersion")]
            [Validation(Required=false)]
            public string TLSVersion { get; set; }

            /// <summary>
            /// <para>The method that WAF uses to obtain the originating IP address of the client. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b> (default): The client traffic has not been forwarded by any Layer 7 proxy before reaching WAF.</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: WAF reads the first value in the X-Forwarded-For (XFF) header as the client IP address.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: WAF reads the value of a custom header field that you specify as the client IP address.</para>
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
            /// <para>The list of custom header fields used to obtain the client IP address.</para>
            /// </summary>
            [NameInMap("XffHeaders")]
            [Validation(Required=false)]
            public List<string> XffHeaders { get; set; }

        }

        /// <summary>
        /// <para>The forwarding configuration.</para>
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
                /// <para>The listening port.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("ListenPort")]
                [Validation(Required=false)]
                public int? ListenPort { get; set; }

                /// <summary>
                /// <para>The protocol of the listening port. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>http</b>: The protocol of the listening port is HTTP.</para>
                /// </description></item>
                /// <item><description><para><b>https</b>: The protocol of the listening port is HTTPS.</para>
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
            /// <para>The IP addresses or back-to-origin domain names of the origin server corresponding to the domain name.</para>
            /// </summary>
            [NameInMap("Backends")]
            [Validation(Required=false)]
            public List<string> Backends { get; set; }

            /// <summary>
            /// <para>The backup origin server IP addresses or back-to-origin domain names corresponding to the domain name.</para>
            /// </summary>
            [NameInMap("BackupBackends")]
            [Validation(Required=false)]
            public List<string> BackupBackends { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable public cloud disaster recovery. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Public cloud disaster recovery is enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b> (default): Public cloud disaster recovery is not enabled.</para>
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
            /// Valid values: 1 to 3600.
            /// Default value: 5.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("ConnectTimeout")]
            [Validation(Required=false)]
            public int? ConnectTimeout { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable forced HTTP back-to-origin. This parameter is used only when <b>HttpsPorts</b> is not empty, which indicates that the domain name uses HTTPS. Valid values:</para>
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
            /// <para>Specifies whether to enable HTTP/2 back-to-origin. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: HTTP/2 back-to-origin is enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: HTTP/2 back-to-origin is not enabled.</para>
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
            /// <para>The maximum number of concurrent connections for HTTP/2 back-to-origin. Valid values: 1 to 512. Default value: 128.</para>
            /// 
            /// <b>Example:</b>
            /// <para>128</para>
            /// </summary>
            [NameInMap("Http2OriginMaxConcurrency")]
            [Validation(Required=false)]
            public int? Http2OriginMaxConcurrency { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable persistent connections. Valid values:</para>
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
            /// <para>The number of requests that reuse persistent connections. Valid values: 60 to 1000. Default value: 1000.</para>
            /// <remarks>
            /// <para>The number of persistent connections to reuse after persistent connections are enabled.</para>
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
            /// <para>The idle time after which a reused persistent connection is released.</para>
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
            /// <item><description><para><b>leastTime</b>: Least Time algorithm. This value is available only when <b>ProtectionResource</b> is set to <b>gslb</b>, which indicates that the shared cluster-based intelligent load balancing is used.</para>
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
            /// <para>The maximum request body size. Valid values: 2 to 10. Default value: 2. Unit: GB.</para>
            /// <remarks>
            /// <para>Only the Ultimate Edition supports this feature.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("MaxBodySize")]
            [Validation(Required=false)]
            public int? MaxBodySize { get; set; }

            /// <summary>
            /// <para>Specifies whether the client source IP preservation feature is enabled.</para>
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
            /// Valid values: 1 to 3600.
            /// Default value: 120.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("ReadTimeout")]
            [Validation(Required=false)]
            public int? ReadTimeout { get; set; }

            /// <summary>
            /// <para>The traffic mark field and value of the domain name, used to mark traffic processed by WAF.</para>
            /// <para>By specifying custom request header fields and corresponding values, when the access traffic of the domain name passes through WAF, WAF automatically adds the specified custom field values to the request header as traffic marks, which helps the backend service collect relevant information.</para>
            /// </summary>
            [NameInMap("RequestHeaders")]
            [Validation(Required=false)]
            public List<CreateDomainRequestRedirectRequestHeaders> RequestHeaders { get; set; }
            public class CreateDomainRequestRedirectRequestHeaders : TeaModel {
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
                /// <para>The value set for the custom request header field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bbb</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to retry when WAF fails to forward requests to the origin server. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b> (default): Retry is enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Retry is not enabled.</para>
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
            /// <para>The hybrid cloud forwarding rules. The value is a string converted from a JSON array. Each element in the JSON array is a structure that contains the following fields:</para>
            /// <list type="bullet">
            /// <item><description><para><b>rs</b>: Array type | The list of back-to-origin IP addresses or back-to-origin CNAMEs.</para>
            /// </description></item>
            /// <item><description><para><b>backupRs</b>: Array type | The list of backup back-to-origin IP addresses or back-to-origin CNAMEs. This field is required. Use [] to indicate that no backup is set.</para>
            /// </description></item>
            /// <item><description><para><b>location</b>: String type | The name of the protection node.</para>
            /// </description></item>
            /// <item><description><para><b>locationId</b>: Long type | The ID of the protection node.</para>
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
            /// <para>Specifies whether to enable back-to-origin SNI. This parameter is used only when <b>HttpsPorts</b> is not empty, which indicates that the domain name uses HTTPS. Valid values:</para>
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
            /// <para>The value of the custom SNI extension field. If this parameter is not set, the value of the <b>Host</b> field in the request header is used as the SNI extension field value by default.
            /// In most cases, you do not need to customize the SNI unless your service has special configuration requirements and you want WAF to use an SNI that is different from the actual request Host in back-to-origin requests (the custom SNI set here).</para>
            /// <remarks>
            /// <para>This parameter is required only when <b>SniEnabled</b> is set to <b>true</b>, which indicates that back-to-origin SNI is enabled.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.aliyundoc.com">www.aliyundoc.com</a></para>
            /// </summary>
            [NameInMap("SniHost")]
            [Validation(Required=false)]
            public string SniHost { get; set; }

            /// <summary>
            /// <para>Specifies whether to allow WAF to overwrite WL-Proxy-Client-IP. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b> (default): WAF is allowed to overwrite.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: WAF is not allowed to overwrite.</para>
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
            /// <para>Specifies whether to allow WAF to overwrite Web-Server-Type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b> (default): WAF is allowed to overwrite.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: WAF is not allowed to overwrite.</para>
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
            /// Valid values: 1 to 3600.
            /// Default value: 120.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("WriteTimeout")]
            [Validation(Required=false)]
            public int? WriteTimeout { get; set; }

            /// <summary>
            /// <para>Specifies whether to allow WAF to overwrite X-Client-IP. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b> (default): WAF is allowed to overwrite.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: WAF is not allowed to overwrite.</para>
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
            /// <para>Specifies whether to allow WAF to overwrite X-True-IP. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b> (default): WAF is allowed to overwrite.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: WAF is not allowed to overwrite.</para>
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
            /// <para>Specifies whether to use X-Forward-For-Proto to pass the protocol used by WAF. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b> (default): The protocol used by WAF is passed.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The protocol used by WAF is not passed.</para>
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
        /// <para>The region where the WAF instance is deployed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>cn-hangzhou</b>: the Chinese mainland.</para>
        /// </description></item>
        /// <item><description><para><b>ap-southeast-1</b>: outside the Chinese mainland.</para>
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
        /// <para>The Alibaba Cloud resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm***q</para>
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

        /// <summary>
        /// <para>The tag list, which contains a maximum of 20 items.</para>
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
