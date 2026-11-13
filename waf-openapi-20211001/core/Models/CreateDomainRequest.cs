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
        /// <remarks>
        /// <para>If the value is <b>share</b>, or the value is <b>hybrid_cloud_cname</b> and public cloud disaster recovery is enabled, you must invoke the <a href="https://help.aliyun.com/document_detail/2985193.html">DescribeVerifyContent</a> and <a href="https://help.aliyun.com/document_detail/2985192.html">VerifyDomainOwner</a> operations to authenticate the domain name ownership first. If the website config is added to a region in the Chinese mainland, it must also have an ICP filing.</para>
        /// <para>If the value is <b>hybrid_cloud_cname</b> and public cloud disaster recovery is disabled, you do not need to authenticate the domain name ownership and can directly invoke this operation.</para>
        /// </remarks>
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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to query the ID of the current WAF instance.</para>
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
        /// <para>The listener configuration.</para>
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
            /// <item><description><para><b>1</b>: adds all cipher suites.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: adds strong cipher suites. This value is available only when <b>TLSVersion</b> is set to <b>tlsv1.2</b>.</para>
            /// </description></item>
            /// <item><description><para><b>99</b>: adds custom cipher suites. This value is available only when <b>TLSVersion</b> is not set to <b>tlsv1.3</b>.</para>
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
            /// <para>Specifies whether to support TLS 1.3. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: supports TLS 1.3.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: does not support TLS 1.3.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is used only when HttpsPorts is not empty, which indicates that the domain name uses HTTPS. When TLSVersion is set to tlsv1.3, this parameter must be set to true.</para>
            /// </remarks>
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
            /// <para>Specifies whether to enable an exclusive IP address. This parameter is used only when <b>IPv6Enabled</b> is set to <b>false</b>, which indicates that IPv6 is disabled, and <b>ProtectionResource</b> is set to <b>share</b>, which indicates that a shared cluster is used. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: enables an exclusive IP address.</para>
            /// </description></item>
            /// <item><description><para><b>false</b> (default): disables an exclusive IP address.</para>
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
            /// <para>Specifies whether to enable force redirect to HTTPS. This parameter is used only when HttpsPorts is not empty, which indicates that the domain name uses HTTPS, and HttpPorts is empty, which indicates that the domain name does not use HTTP. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: enables force redirect to HTTPS.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: disables force redirect to HTTPS.</para>
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
            /// <para>Specifies whether HTTP Strict Transport Security (HSTS) includes subdomains. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
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
            /// <para>Specifies whether to enable HSTS preload. Default value: disabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: enabled.</description></item>
            /// <item><description>false: disabled.</description></item>
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
            /// <item><description><para><b>true</b>: enables HTTP/2.</para>
            /// </description></item>
            /// <item><description><para><b>false</b> (default): disables HTTP/2.</para>
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
            /// <item><description><para><b>true</b>: enables IPv6.</para>
            /// </description></item>
            /// <item><description><para><b>false</b> (default): disables IPv6.</para>
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
            /// <item><description><para><b>share</b> (default): uses a shared cluster.</para>
            /// </description></item>
            /// <item><description><para><b>gslb</b>: uses intelligent load balancing of a shared cluster.</para>
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
            /// <para>Specifies whether to allow access only from SM2 clients. This parameter is used only when SM2Enabled is set to true. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: allows access only from SM2 clients.</para>
            /// </description></item>
            /// <item><description><para>false: allows access from both SM2 and non-SM2 clients.</para>
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
            /// <para>The ID of the SM2 certificate to add. This parameter is used only when SM2Enabled is set to true.</para>
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
            /// <para>Specifies whether to enable the SM2 certificate.</para>
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
            /// <item><description><b>tlsv1</b>: supports TLS 1.0 and later versions. This value provides the highest compatibility but lower security.</description></item>
            /// <item><description><b>tlsv1.1</b>: supports TLS 1.1 and later versions. This value provides good compatibility and security.</description></item>
            /// <item><description><b>tlsv1.2</b>: supports TLS 1.2 and later versions. This value provides good compatibility and the highest security.</description></item>
            /// <item><description><b>tlsv1.3</b>: supports only TLS 1.3. This value provides the highest security but lower compatibility.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>tlsv1</para>
            /// </summary>
            [NameInMap("TLSVersion")]
            [Validation(Required=false)]
            public string TLSVersion { get; set; }

            /// <summary>
            /// <para>The method for WAF to obtain the actual IP address of the client. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b> (default): The client access traffic is not forwarded by other Layer 7 proxies before it reaches WAF.</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: WAF reads the first value of the X-Forwarded-For (XFF) field in the request header as the client IP address.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: WAF reads the value of a custom field that you specified in the request header as the client IP address.</para>
            /// </description></item>
            /// <item><description><para><b>3</b>: WAF reads the Client IP field in the Proxy Protocol header as the client IP address.</para>
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
            /// <para>The list of custom fields used to obtain the client IP address.</para>
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
            /// <para>The IP addresses of the origin servers or the back-to-origin domain names for the domain name.</para>
            /// </summary>
            [NameInMap("Backends")]
            [Validation(Required=false)]
            public List<string> Backends { get; set; }

            /// <summary>
            /// <para>The IP addresses of the secondary origin servers or the secondary back-to-origin domain names for the domain name.</para>
            /// </summary>
            [NameInMap("BackupBackends")]
            [Validation(Required=false)]
            public List<string> BackupBackends { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable public cloud disaster recovery. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: enables public cloud disaster recovery.</para>
            /// </description></item>
            /// <item><description><para><b>false</b> (default): disables public cloud disaster recovery.</para>
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
            /// <para>Specifies whether to enable force back-to-origin over HTTP. This parameter is used only when <b>HttpsPorts</b> is not empty, which indicates that the domain name uses HTTPS. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: enables force back-to-origin over HTTP.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: disables force back-to-origin over HTTP.</para>
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
            /// <item><description><para><b>true</b>: enables HTTP/2 back-to-origin.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: disables HTTP/2 back-to-origin.</para>
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
            /// <para>The maximum number of concurrent HTTP/2 back-to-origin connections. Valid values: 1 to 512. Default value: 128.</para>
            /// 
            /// <b>Example:</b>
            /// <para>128</para>
            /// </summary>
            [NameInMap("Http2OriginMaxConcurrency")]
            [Validation(Required=false)]
            public int? Http2OriginMaxConcurrency { get; set; }

            /// <summary>
            /// <para>Specifies whether to maintain persistent connections. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b> (default): maintains persistent connections.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: does not maintain persistent connections.</para>
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
            /// <para>The number of requests that reuse a persistent connection. Valid values: 60 to 1000. Default value: 1000.</para>
            /// <remarks>
            /// <para>The maximum number of requests that can be served over a single persistent connection after persistent connections are enabled.</para>
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
            /// <para>The duration after which an idle persistent connection is released.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("KeepaliveTimeout")]
            [Validation(Required=false)]
            public int? KeepaliveTimeout { get; set; }

            /// <summary>
            /// <para>The load balancing algorithm used for back-to-origin requests. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>iphash</b>: the IP hash algorithm.</para>
            /// </description></item>
            /// <item><description><para><b>roundRobin</b>: the round-robin algorithm.</para>
            /// </description></item>
            /// <item><description><para><b>leastTime</b>: the least time algorithm. This value is available only when <b>ProtectionResource</b> is set to <b>gslb</b>, which indicates that intelligent load balancing of a shared cluster is used.</para>
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
            /// <para>The maximum size of the request body. Valid values: 2 to 10. Default value: 2. Unit: GB.</para>
            /// <remarks>
            /// <para>This parameter is supported only by the Ultimate Edition.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("MaxBodySize")]
            [Validation(Required=false)]
            public int? MaxBodySize { get; set; }

            /// <summary>
            /// <para>Specifies whether the feature to preserve the client source IP address is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The feature is enabled. After this feature is enabled, backend services can view the original IP address of the client.</description></item>
            /// <item><description><b>false</b>: The feature is disabled.</description></item>
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
            /// <para>The traffic marking fields and values for the domain name, which are used to mark the traffic processed by WAF.</para>
            /// <para>By specifying custom request header fields and their corresponding values, WAF automatically adds the specified custom field values to the request headers as traffic marks when the access traffic of the domain name passes through WAF. This facilitates the collection of related information by backend services.</para>
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
            /// <item><description><para><b>true</b> (default): retries.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: does not retry.</para>
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
            /// <para>The hybrid cloud forwarding rules. The value is a string transformed from a JSON array. Each element in the JSON array is a struct that contains the following fields:</para>
            /// <list type="bullet">
            /// <item><description><para><b>rs</b>: Array | The list of back-to-origin IP addresses or back-to-origin CNAMEs.</para>
            /// </description></item>
            /// <item><description><para><b>backupRs</b>: Array | The list of secondary back-to-origin IP addresses or back-to-origin CNAMEs. This field is required. An empty array [] indicates that no secondary back-to-origin addresses are configured.</para>
            /// </description></item>
            /// <item><description><para><b>location</b>: String | The name of the protection node.</para>
            /// </description></item>
            /// <item><description><para><b>locationId</b>: Long | The ID of the protection node.</para>
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
            /// <para>Specifies whether to enable back-to-origin Server Name Indication (SNI). This parameter is used only when <b>HttpsPorts</b> is not empty, which indicates that the domain name uses HTTPS. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: enables back-to-origin SNI.</para>
            /// </description></item>
            /// <item><description><para><b>false</b> (default): disables back-to-origin SNI.</para>
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
            /// <para>The value of the custom SNI extension field. If you do not specify this parameter, the value of the <b>Host</b> field in the request header is used as the value of the SNI extension field by default.
            /// In most cases, you do not need to customize the SNI unless your business has special configuration requirements and you want WAF to use an SNI that is different from the actual request Host in back-to-origin requests.</para>
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
            /// <para>Specifies whether to allow WAF to overwrite the WL-Proxy-Client-IP header. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b> (default): allows WAF to overwrite the header.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: does not allow WAF to overwrite the header.</para>
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
            /// <para>Specifies whether to allow WAF to overwrite the Web-Server-Type header. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b> (default): allows WAF to overwrite the header.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: does not allow WAF to overwrite the header.</para>
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
            /// <para>Specifies whether to allow WAF to overwrite the X-Client-IP header. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b> (default): allows WAF to overwrite the header.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: does not allow WAF to overwrite the header.</para>
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
            /// <para>Specifies whether to allow WAF to overwrite the X-True-IP header. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b> (default): allows WAF to overwrite the header.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: does not allow WAF to overwrite the header.</para>
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
            /// <para>Specifies whether to pass the WAF protocol in the X-Forwarded-Proto header. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b> (default): passes the WAF protocol.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: does not pass the WAF protocol.</para>
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
        /// <para>The ID of the Alibaba Cloud resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm***q</para>
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

        /// <summary>
        /// <para>The list of tags, which can contain up to 20 items.</para>
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
