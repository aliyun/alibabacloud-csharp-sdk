// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class ModifyDomainRequest : TeaModel {
        /// <summary>
        /// <para>The access mode of the WAF instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>share</b>: CNAME access. This is the default value.</para>
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
        /// <para>The domain name to manage.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.aliyundoc.com">www.aliyundoc.com</a></para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The ID of the domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://www.aliyundoc.com-waf">www.aliyundoc.com-waf</a></para>
        /// </summary>
        [NameInMap("DomainId")]
        [Validation(Required=false)]
        public string DomainId { get; set; }

        /// <summary>
        /// <para>The ID of the WAF instance.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to query the ID of the WAF instance.</para>
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
        /// <para>The listener settings.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Listen")]
        [Validation(Required=false)]
        public ModifyDomainRequestListen Listen { get; set; }
        public class ModifyDomainRequestListen : TeaModel {
            /// <summary>
            /// <para>The ID of the certificate to add.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("CertId")]
            [Validation(Required=false)]
            public string CertId { get; set; }

            /// <summary>
            /// <para>The type of cipher suite to add. This parameter takes effect only when <b>HttpsPorts</b> is not empty, which indicates that the domain name uses HTTPS. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: adds all cipher suites.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: adds strong cipher suites. You can select this value only when <b>TLSVersion</b> is set to <b>tlsv1.2</b>.</para>
            /// </description></item>
            /// <item><description><para><b>99</b>: adds custom cipher suites. You can select this value only when <b>TLSVersion</b> is not set to <b>tlsv1.3</b>.</para>
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
            /// <para>The custom cipher suites to add. This parameter takes effect only when <b>CipherSuite</b> is set to <b>99</b>.</para>
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
            /// <para>This parameter takes effect only when HttpsPorts is not empty, which indicates that the domain name uses HTTPS. If TLSVersion is set to tlsv1.3, this parameter must be set to true.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnableTLSv3")]
            [Validation(Required=false)]
            public bool? EnableTLSv3 { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable an exclusive IP address. This parameter takes effect only when <b>IPv6Enabled</b> is set to false, which indicates that IPv6 is disabled, and <b>ProtectionResource</b> is set to <b>share</b>, which indicates that a shared cluster is used. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: enables an exclusive IP address.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: disables an exclusive IP address. This is the default value.</para>
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
            /// <para>Specifies whether to enable force redirect to HTTPS. This parameter takes effect only when <b>HttpsPorts</b> is not empty, which indicates that the domain name uses HTTPS, and <b>HttpPorts</b> is empty, which indicates that the domain name does not use HTTP. Valid values:</para>
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
            /// <item><description><para><b>true</b>: includes subdomains.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: does not include subdomains.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("HstsIncludeSubDomain")]
            [Validation(Required=false)]
            public bool? HstsIncludeSubDomain { get; set; }

            /// <summary>
            /// <para>The expiration time of HSTS. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>365000</para>
            /// </summary>
            [NameInMap("HstsMaxAge")]
            [Validation(Required=false)]
            public long? HstsMaxAge { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable HSTS preload. Default value: false. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: enables HSTS preload.</description></item>
            /// <item><description>false: disables HSTS preload.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("HstsPreload")]
            [Validation(Required=false)]
            public bool? HstsPreload { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable HTTP/2. This parameter takes effect only when <b>HttpsPorts</b> is not empty, which indicates that the domain name uses HTTPS. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: enables HTTP/2.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: disables HTTP/2. This is the default value.</para>
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
            /// <para>The listening ports for HTTP. Specify the ports in the [<b>port1,port2,...</b>] format.</para>
            /// </summary>
            [NameInMap("HttpPorts")]
            [Validation(Required=false)]
            public List<int?> HttpPorts { get; set; }

            /// <summary>
            /// <para>The listening ports for HTTPS. Specify the ports in the [<b>port1,port2,...</b>] format.</para>
            /// </summary>
            [NameInMap("HttpsPorts")]
            [Validation(Required=false)]
            public List<int?> HttpsPorts { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable IPv6. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: enables IPv6.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: disables IPv6. This is the default value.</para>
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
            /// <item><description><para><b>share</b>: uses a shared cluster. This is the default value.</para>
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
            /// <para>Specifies whether to allow access only from SM2 clients. This parameter takes effect only when SM2Enabled is set to true. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: allows access only from SM2 clients.</para>
            /// </description></item>
            /// <item><description><para>false: allows access from both SM2 and non-SM2 clients.</para>
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
            /// <para>The ID of the SM2 certificate to add. This parameter takes effect only when SM2Enabled is set to true.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123-cn-hangzhou</para>
            /// </summary>
            [NameInMap("SM2CertId")]
            [Validation(Required=false)]
            public string SM2CertId { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the SM2 certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SM2Enabled")]
            [Validation(Required=false)]
            public bool? SM2Enabled { get; set; }

            /// <summary>
            /// <para>The TLS version to add. This parameter takes effect only when <b>HttpsPorts</b> is not empty, which indicates that the domain name uses HTTPS. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>tlsv1</b>: supports TLS 1.0 and later. This version provides the highest compatibility but lower security.</description></item>
            /// <item><description><b>tlsv1.1</b>: supports TLS 1.1 and later. This version provides good compatibility and security.</description></item>
            /// <item><description><b>tlsv1.2</b>: supports TLS 1.2 and later. This version provides good compatibility and the highest security.</description></item>
            /// <item><description><b>tlsv1.3</b>: supports only TLS 1.3. This version provides the highest security but lower compatibility.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>tlsv1</para>
            /// </summary>
            [NameInMap("TLSVersion")]
            [Validation(Required=false)]
            public string TLSVersion { get; set; }

            /// <summary>
            /// <para>The method that WAF uses to obtain the actual IP address of the client.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("XffHeaderMode")]
            [Validation(Required=false)]
            public int? XffHeaderMode { get; set; }

            /// <summary>
            /// <para>The list of custom fields used to obtain the client IP address. Specify the fields in the [<b>&quot;header1&quot;,&quot;header2&quot;,...</b>] format.</para>
            /// <remarks>
            /// <para>You need to set this parameter only when <b>XffHeaderMode</b> is set to 2, which indicates that WAF reads the value of a custom field that you specified in the request header as the client IP address.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("XffHeaders")]
            [Validation(Required=false)]
            public List<string> XffHeaders { get; set; }

        }

        /// <summary>
        /// <para>The forwarding settings.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Redirect")]
        [Validation(Required=false)]
        public ModifyDomainRequestRedirect Redirect { get; set; }
        public class ModifyDomainRequestRedirect : TeaModel {
            /// <summary>
            /// <para>The custom port configurations.</para>
            /// </summary>
            [NameInMap("BackendPorts")]
            [Validation(Required=false)]
            public List<ModifyDomainRequestRedirectBackendPorts> BackendPorts { get; set; }
            public class ModifyDomainRequestRedirectBackendPorts : TeaModel {
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
                /// <item><description><para><b>http</b>: the protocol of the listening port is HTTP.</para>
                /// </description></item>
                /// <item><description><para><b>https</b>: the protocol of the listening port is HTTPS.</para>
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
            /// <para>The IP addresses of the origin servers or the back-to-origin domain names for the domain name. You can specify either origin server IP addresses or back-to-origin domain names. If the back-to-origin address is a domain name, only IPv4 is supported. IPv6 is not supported.</para>
            /// <list type="bullet">
            /// <item><description><para>To specify origin server IP addresses, use the [<b>&quot;ip1&quot;,&quot;ip2&quot;,...</b>] format. You can add up to 20 IP addresses.</para>
            /// </description></item>
            /// <item><description><para>To specify back-to-origin domain names, use the [<b>&quot;domain&quot;</b>] format. You can add up to 20 domain names.</para>
            /// </description></item>
            /// </list>
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
            /// <item><description><para><b>false</b>: disables public cloud disaster recovery. This is the default value.</para>
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
            /// <para>Specifies whether to enable force back-to-origin over HTTP. This parameter takes effect only when <b>HttpsPorts</b> is not empty, which indicates that the domain name uses HTTPS. Valid values:</para>
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
            /// <para>The maximum number of concurrent HTTP/2 back-to-origin connections. Valid values: 1 to 512. Default value: 2. Unit: connections.</para>
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
            /// <item><description><para><b>true</b>: maintains persistent connections. This is the default value.</para>
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
            /// <para>The number of requests that reuse a persistent connection. Valid values: 60 to 1000. Default value: 1000. Unit: requests.</para>
            /// <remarks>
            /// <para>This parameter specifies the number of requests that can reuse a persistent connection after persistent connections are enabled.</para>
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
            /// <para>This parameter specifies the duration after which an idle persistent connection is released.</para>
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
            /// <item><description><para><b>leastTime</b>: the least time algorithm. You can select this value only when <b>ProtectionResource</b> is set to <b>gslb</b>, which indicates that intelligent load balancing of a shared cluster is used.</para>
            /// </description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>iphash</para>
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
            /// <para>Specifies whether to enable the feature of preserving the originating IP address of the client. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: enables the feature. After this feature is enabled, backend services can view the originating IP address of the client.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: disables the feature.</para>
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
            /// <para>By specifying custom request header fields and their corresponding values, WAF automatically adds the specified custom field values to the request headers as traffic marks when the access traffic of the domain name passes through WAF. This facilitates the collection of relevant information by backend services.</para>
            /// </summary>
            [NameInMap("RequestHeaders")]
            [Validation(Required=false)]
            public List<ModifyDomainRequestRedirectRequestHeaders> RequestHeaders { get; set; }
            public class ModifyDomainRequestRedirectRequestHeaders : TeaModel {
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
                /// <para>The value set for the specified custom request header field.</para>
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
            /// <item><description><para><b>true</b>: retries. This is the default value.</para>
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
            /// <item><description><para><b>backupRs</b>: Array | The list of secondary back-to-origin IP addresses or back-to-origin CNAMEs. This field is required. An empty array [] indicates that no secondary back-to-origin addresses are set.</para>
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
            /// <para>Specifies whether to enable back-to-origin Server Name Indication (SNI). This parameter takes effect only when <b>HttpsPorts</b> is not empty, which indicates that the domain name uses HTTPS. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: enables back-to-origin SNI.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: disables back-to-origin SNI. This is the default value.</para>
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
            /// <para>The value of the custom SNI extension field. If you do not set this parameter, the value of the <b>Host</b> field in the request header is used as the value of the SNI extension field by default.
            /// In most cases, you do not need to customize the SNI unless your service has special configuration requirements and you want WAF to use an SNI that is different from the actual request Host in the back-to-origin request.</para>
            /// <remarks>
            /// <para>You need to set this parameter only when <b>SniEnabled</b> is set to true, which indicates that a custom back-to-origin SNI is used.</para>
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
            /// <item><description><para><b>true</b>: allows WAF to overwrite the header. This is the default value.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: does not allow WAF to overwrite the header.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("WLProxyClientIp")]
            [Validation(Required=false)]
            public bool? WLProxyClientIp { get; set; }

            /// <summary>
            /// <para>Specifies whether to allow WAF to overwrite the Web-Server-Type header. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: allows WAF to overwrite the header. This is the default value.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: does not allow WAF to overwrite the header.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
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
            /// <item><description><para><b>true</b>: allows WAF to overwrite the header. This is the default value.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: does not allow WAF to overwrite the header.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("XClientIp")]
            [Validation(Required=false)]
            public bool? XClientIp { get; set; }

            /// <summary>
            /// <para>Specifies whether to allow WAF to overwrite the X-True-IP header. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: allows WAF to overwrite the header. This is the default value.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: does not allow WAF to overwrite the header.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("XTrueIp")]
            [Validation(Required=false)]
            public bool? XTrueIp { get; set; }

            /// <summary>
            /// <para>Specifies whether to pass the WAF protocol in the X-Forwarded-Proto header. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: passes the WAF protocol. This is the default value.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: does not pass the WAF protocol.</para>
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

    }

}
