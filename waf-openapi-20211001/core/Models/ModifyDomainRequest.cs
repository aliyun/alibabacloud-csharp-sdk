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
        /// <para>The domain name whose configurations you want to modify.</para>
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
        /// <para>The listening settings.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Listen")]
        [Validation(Required=false)]
        public ModifyDomainRequestListen Listen { get; set; }
        public class ModifyDomainRequestListen : TeaModel {
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
            /// <para>The type of the cipher suite. This parameter is available only when <b>HttpsPorts</b> is not empty, which indicates that the domain uses HTTPS. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: all cipher suites.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: strong cipher suites. You can select this value only when you set <b>TLSVersion</b> to <b>tlsv1.2</b>.</para>
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
            /// <para>The custom cipher suites. This parameter is available only when you set <b>CipherSuite</b> to <b>99</b>.</para>
            /// </summary>
            [NameInMap("CustomCiphers")]
            [Validation(Required=false)]
            public List<string> CustomCiphers { get; set; }

            /// <summary>
            /// <para>Indicates whether TLS 1.3 is supported. This parameter is available only when <b>HttpsPorts</b> is not empty, which indicates that the domain uses HTTPS. Valid values:</para>
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
            /// <para>Indicates whether an exclusive IP address is enabled. This parameter is available only when you set <b>IPv6Enabled</b> to false and <b>ProtectionResource</b> to <b>share</b>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: An exclusive IP address is enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b> (default): An exclusive IP address is disabled.</para>
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
            /// <para>Indicates whether forced HTTPS redirection is enabled. This parameter is available only when the domain uses HTTPS but not HTTP. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Forced HTTPS redirection is enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Forced HTTPS redirection is disabled.</para>
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
            /// <para>Indicates whether subdomains are included in the HTTP Strict Transport Security (HSTS) policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Subdomains are included.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Subdomains are not included.</para>
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
            /// <para>The time-to-live (TTL) of the HSTS policy. Unit: seconds.</para>
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
            /// <item><description><para>true: HSTS preload is enabled.</para>
            /// </description></item>
            /// <item><description><para>false: HSTS preload is disabled.</para>
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
            /// <para>Indicates whether HTTP/2 is enabled. This parameter is available only when <b>HttpsPorts</b> is not empty, which indicates that the domain uses HTTPS. Valid values:</para>
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
            /// <para>The HTTP listening ports. The format is [<b>port1,port2,...</b>].</para>
            /// </summary>
            [NameInMap("HttpPorts")]
            [Validation(Required=false)]
            public List<int?> HttpPorts { get; set; }

            /// <summary>
            /// <para>The HTTPS listening ports. The format is [<b>port1,port2,...</b>].</para>
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
            /// <para>The type of the protection resource. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>share</b> (default): a shared cluster.</para>
            /// </description></item>
            /// <item><description><para><b>gslb</b>: a shared cluster with global server load balancing.</para>
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
            /// <para>Indicates whether access is allowed only from SM clients. This parameter is available only when SM2Enabled is set to true. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true: Only SM clients can access the website.</para>
            /// </description></item>
            /// <item><description><para>false: Both SM and non-SM clients can access the website.</para>
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
            /// <para>The ID of the SM certificate. This parameter is required only when SM2Enabled is set to true.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123-cn-hangzhou</para>
            /// </summary>
            [NameInMap("SM2CertId")]
            [Validation(Required=false)]
            public string SM2CertId { get; set; }

            /// <summary>
            /// <para>Indicates whether SM certificates are enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SM2Enabled")]
            [Validation(Required=false)]
            public bool? SM2Enabled { get; set; }

            /// <summary>
            /// <para>The TLS version. This parameter is available only when <b>HttpsPorts</b> is not empty, which indicates that the domain uses HTTPS. Valid values:</para>
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
            /// <para>The method that WAF uses to obtain the real IP address of a client. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b> (default): WAF obtains the client IP address from the TCP connection. This option is suitable if no Layer 7 proxies are deployed in front of WAF.</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: WAF obtains the client IP address from the first value of the X-Forwarded-For (XFF) header.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: WAF obtains the client IP address from a custom header field.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("XffHeaderMode")]
            [Validation(Required=false)]
            public int? XffHeaderMode { get; set; }

            /// <summary>
            /// <para>The custom header fields that are used to obtain the client IP address. The format is [<b>&quot;header1&quot;,&quot;header2&quot;,...</b>].</para>
            /// <remarks>
            /// <para>This parameter is required only when you set <b>XffHeaderMode</b> to 2.</para>
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
            /// <para>The custom port mappings for back-to-origin.</para>
            /// </summary>
            [NameInMap("BackendPorts")]
            [Validation(Required=false)]
            public List<ModifyDomainRequestRedirectBackendPorts> BackendPorts { get; set; }
            public class ModifyDomainRequestRedirectBackendPorts : TeaModel {
                /// <summary>
                /// <para>The port of the origin server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("BackendPort")]
                [Validation(Required=false)]
                public int? BackendPort { get; set; }

                /// <summary>
                /// <para>The WAF listening port.</para>
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
            /// <para>The IP addresses or domain names of the origin server. You can specify only one type of address. If you specify a domain name, only IPv4 is supported. IPv6 is not supported.</para>
            /// <list type="bullet">
            /// <item><description><para>IP addresses: The format is [<b>&quot;ip1&quot;,&quot;ip2&quot;,...</b>]. You can specify up to 20 IP addresses.</para>
            /// </description></item>
            /// <item><description><para>Domain names: The format is [<b>&quot;domain&quot;</b>]. You can specify up to 20 domain names.</para>
            /// </description></item>
            /// </list>
            /// </summary>
            [NameInMap("Backends")]
            [Validation(Required=false)]
            public List<string> Backends { get; set; }

            /// <summary>
            /// <para>The IP addresses or domain names of the backup origin server.</para>
            /// </summary>
            [NameInMap("BackupBackends")]
            [Validation(Required=false)]
            public List<string> BackupBackends { get; set; }

            /// <summary>
            /// <para>Indicates whether public cloud disaster recovery is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Public cloud disaster recovery is enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b> (default): Public cloud disaster recovery is disabled.</para>
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
            /// <para>The connection timeout period. Unit: seconds. Valid values: 1 to 3600. Default value: 5.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("ConnectTimeout")]
            [Validation(Required=false)]
            public int? ConnectTimeout { get; set; }

            /// <summary>
            /// <para>Indicates whether forced HTTP back-to-origin is enabled. This parameter is available only when you specify <b>HttpsPorts</b>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Forced HTTP back-to-origin is enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Forced HTTP back-to-origin is disabled.</para>
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
            /// <para>Indicates whether HTTP/2 is enabled for back-to-origin requests. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: HTTP/2 is enabled for back-to-origin requests.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: HTTP/2 is disabled for back-to-origin requests.</para>
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
            /// <para>The maximum number of concurrent HTTP/2 back-to-origin requests. Valid values: 1 to 512. Default value: 2.</para>
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
            /// <para>The number of requests that can be reused in a persistent connection. Valid values: 60 to 1000. Default value: 1000.</para>
            /// <remarks>
            /// <para>This parameter is available only when you enable persistent connections.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("KeepaliveRequests")]
            [Validation(Required=false)]
            public int? KeepaliveRequests { get; set; }

            /// <summary>
            /// <para>The idle timeout for a persistent connection. Unit: seconds. Valid values: 1 to 60. Default value: 15.</para>
            /// <remarks>
            /// <para>This parameter specifies the amount of time that an idle persistent connection can remain open.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("KeepaliveTimeout")]
            [Validation(Required=false)]
            public int? KeepaliveTimeout { get; set; }

            /// <summary>
            /// <para>The load balancing algorithm for back-to-origin requests. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>iphash</b>: the IP hash algorithm.</para>
            /// </description></item>
            /// <item><description><para><b>roundRobin</b>: the round-robin algorithm.</para>
            /// </description></item>
            /// <item><description><para><b>leastTime</b>: the least time algorithm. This value is available only when you set <b>ProtectionResource</b> to <b>gslb</b>.</para>
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
            /// <para>The maximum size of a request body. Unit: GB. Valid values: 2 to 10. Default value: 2.</para>
            /// <remarks>
            /// <para>This parameter is supported only by the WAF Ultimate edition.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("MaxBodySize")]
            [Validation(Required=false)]
            public int? MaxBodySize { get; set; }

            /// <summary>
            /// <para>Indicates whether the Proxy Protocol is enabled to preserve client IP addresses.</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: The Proxy Protocol is enabled. If you select this option, you can view the client IP address on the origin server.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The Proxy Protocol is disabled.</para>
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
            /// <para>The read timeout period. Unit: seconds. Valid values: 1 to 3600. Default value: 120.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("ReadTimeout")]
            [Validation(Required=false)]
            public int? ReadTimeout { get; set; }

            /// <summary>
            /// <para>The custom header fields and their values for traffic marking.</para>
            /// <para>WAF adds these fields and values to the request headers when traffic passes through WAF. This helps backend services identify and collect statistics on WAF-processed traffic.</para>
            /// </summary>
            [NameInMap("RequestHeaders")]
            [Validation(Required=false)]
            public List<ModifyDomainRequestRedirectRequestHeaders> RequestHeaders { get; set; }
            public class ModifyDomainRequestRedirectRequestHeaders : TeaModel {
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
            /// <para>Indicates whether forwarding requests to the origin server are retried when the requests fail. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b> (default): Requests are retried.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Requests are not retried.</para>
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
            /// <para>The forwarding rules for a hybrid cloud deployment. This parameter is a string that contains a JSON array. Each element in the array is a struct that contains the following fields:</para>
            /// <list type="bullet">
            /// <item><description><para><b>rs</b>: an array of strings. The back-to-origin IP addresses or CNAMEs.</para>
            /// </description></item>
            /// <item><description><para><b>backupRs</b>: an array of strings. The backup back-to-origin IP addresses or CNAMEs. This field is required. If you do not want to specify backup addresses, set it to [].</para>
            /// </description></item>
            /// <item><description><para><b>location</b>: a string. The name of the protection node.</para>
            /// </description></item>
            /// <item><description><para><b>locationId</b>: a long integer. The ID of the protection node.</para>
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
            /// <para>Indicates whether back-to-origin Server Name Indication (SNI) is enabled. This parameter is available only when you specify <b>HttpsPorts</b>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Back-to-origin SNI is enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b> (default): Back-to-origin SNI is disabled.</para>
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
            /// <para>The value of the custom SNI field. If you do not set this parameter, the value of the <b>Host</b> field from the request header is used by default. You typically do not need to set this parameter unless your business requires a custom SNI value for back-to-origin requests.</para>
            /// <remarks>
            /// <para>This parameter is available only when you set <b>SniEnabled</b> to true.</para>
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
            /// <item><description><para><b>true</b> (default): WAF is allowed to overwrite the header.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: WAF is not allowed to overwrite the header.</para>
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
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("WebServerType")]
            [Validation(Required=false)]
            public bool? WebServerType { get; set; }

            /// <summary>
            /// <para>The write timeout period. Unit: seconds. Valid values: 1 to 3600. Default value: 120.</para>
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
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
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
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("XTrueIp")]
            [Validation(Required=false)]
            public bool? XTrueIp { get; set; }

            /// <summary>
            /// <para>Indicates whether the X-Forwarded-Proto header is used to pass the protocol used by WAF to the origin server. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b> (default): The WAF protocol is passed.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: The WAF protocol is not passed.</para>
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
