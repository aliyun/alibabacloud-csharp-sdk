// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ListListenersResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of Application Load Balancing (ALB) listeners.</para>
        /// </summary>
        [NameInMap("Listeners")]
        [Validation(Required=false)]
        public List<ListListenersResponseBodyListeners> Listeners { get; set; }
        public class ListListenersResponseBodyListeners : TeaModel {
            /// <summary>
            /// <para>The list of default rule actions.</para>
            /// </summary>
            [NameInMap("DefaultActions")]
            [Validation(Required=false)]
            public List<ListListenersResponseBodyListenersDefaultActions> DefaultActions { get; set; }
            public class ListListenersResponseBodyListenersDefaultActions : TeaModel {
                /// <summary>
                /// <para>The configuration of the forwarding rule action. This parameter is valid when the action type is <b>ForwardGroup</b>.</para>
                /// </summary>
                [NameInMap("ForwardGroupConfig")]
                [Validation(Required=false)]
                public ListListenersResponseBodyListenersDefaultActionsForwardGroupConfig ForwardGroupConfig { get; set; }
                public class ListListenersResponseBodyListenersDefaultActionsForwardGroupConfig : TeaModel {
                    /// <summary>
                    /// <para>The destination server groups to which requests are forwarded.</para>
                    /// </summary>
                    [NameInMap("ServerGroupTuples")]
                    [Validation(Required=false)]
                    public List<ListListenersResponseBodyListenersDefaultActionsForwardGroupConfigServerGroupTuples> ServerGroupTuples { get; set; }
                    public class ListListenersResponseBodyListenersDefaultActionsForwardGroupConfigServerGroupTuples : TeaModel {
                        /// <summary>
                        /// <para>The ID of the destination server group to which requests are forwarded.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>sgp-i5qt20******</para>
                        /// </summary>
                        [NameInMap("ServerGroupId")]
                        [Validation(Required=false)]
                        public string ServerGroupId { get; set; }

                    }

                }

                /// <summary>
                /// <para>The action type. Value: <b>ForwardGroup</b>, which indicates that requests are forwarded to multiple server groups.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ForwardGroup</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether Gzip compression is enabled to compress specific file types. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Enabled.</description></item>
            /// <item><description><b>false</b>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("GzipEnabled")]
            [Validation(Required=false)]
            public bool? GzipEnabled { get; set; }

            /// <summary>
            /// <para>Indicates whether HTTP/2 is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Enabled.</description></item>
            /// <item><description><b>false</b>: Disabled.</description></item>
            /// </list>
            /// <remarks>
            /// <para>Only HTTPS listeners support this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Http2Enabled")]
            [Validation(Required=false)]
            public bool? Http2Enabled { get; set; }

            /// <summary>
            /// <para>The connection idle timeout period. Unit: seconds. Valid values: <b>1 to 60</b>.</para>
            /// <para>If no access request is accepted within the timeout period, load balancing temporarily breaks the current connection and re-establishes a new connection when the next request is accepted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("IdleTimeout")]
            [Validation(Required=false)]
            public int? IdleTimeout { get; set; }

            /// <summary>
            /// <para>The custom listener name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP_80</para>
            /// </summary>
            [NameInMap("ListenerDescription")]
            [Validation(Required=false)]
            public string ListenerDescription { get; set; }

            /// <summary>
            /// <para>The listener ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lsn-o4u34y73wq7b******</para>
            /// </summary>
            [NameInMap("ListenerId")]
            [Validation(Required=false)]
            public string ListenerId { get; set; }

            /// <summary>
            /// <para>The frontend port used by the Application Load Balancing (ALB) instance. Valid values: <b>1 to 65535</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("ListenerPort")]
            [Validation(Required=false)]
            public int? ListenerPort { get; set; }

            /// <summary>
            /// <para>The listener protocol. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>HTTP</b>: Protocol Type is HTTP.</description></item>
            /// <item><description><b>HTTPS</b>: Protocol Type is HTTPS.</description></item>
            /// <item><description><b>QUIC</b>: Protocol Type is QUIC.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP</para>
            /// </summary>
            [NameInMap("ListenerProtocol")]
            [Validation(Required=false)]
            public string ListenerProtocol { get; set; }

            /// <summary>
            /// <para>The status of the listener. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Provisioning</b>: Being created.</para>
            /// </description></item>
            /// <item><description><para><b>Running</b>: Running.</para>
            /// </description></item>
            /// <item><description><para><b>Configuring</b>: Being configured.</para>
            /// </description></item>
            /// <item><description><para><b>Stopped</b>: Stopped.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("ListenerStatus")]
            [Validation(Required=false)]
            public string ListenerStatus { get; set; }

            /// <summary>
            /// <para>The Application Load Balancing (ALB) instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>alb-bd6oylbckp6k9x****</para>
            /// </summary>
            [NameInMap("LoadBalancerId")]
            [Validation(Required=false)]
            public string LoadBalancerId { get; set; }

            /// <summary>
            /// <para>The log configuration.</para>
            /// </summary>
            [NameInMap("LogConfig")]
            [Validation(Required=false)]
            public ListListenersResponseBodyListenersLogConfig LogConfig { get; set; }
            public class ListListenersResponseBodyListenersLogConfig : TeaModel {
                /// <summary>
                /// <para>Indicates whether access logs carry custom headers. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: Enabled.</description></item>
                /// <item><description><b>false</b>: Disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AccessLogRecordCustomizedHeadersEnabled")]
                [Validation(Required=false)]
                public bool? AccessLogRecordCustomizedHeadersEnabled { get; set; }

                /// <summary>
                /// <para>The Xtrace configuration for access logs.</para>
                /// </summary>
                [NameInMap("AccessLogTracingConfig")]
                [Validation(Required=false)]
                public ListListenersResponseBodyListenersLogConfigAccessLogTracingConfig AccessLogTracingConfig { get; set; }
                public class ListListenersResponseBodyListenersLogConfigAccessLogTracingConfig : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether Xtrace is enabled. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b>: Enabled.</description></item>
                    /// <item><description><b>false</b>: Disabled.</description></item>
                    /// </list>
                    /// <remarks>
                    /// <para>You can set this parameter to <b>true</b> only when the instance access log switch <b>AccessLogEnabled</b> is turned on.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("TracingEnabled")]
                    [Validation(Required=false)]
                    public bool? TracingEnabled { get; set; }

                    /// <summary>
                    /// <para>The sampling rate of Xtrace. Valid values: <b>1 to 10000</b>.</para>
                    /// <remarks>
                    /// <para>This value takes effect only when <b>TracingEnabled</b> is set to <b>true</b>.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("TracingSample")]
                    [Validation(Required=false)]
                    public int? TracingSample { get; set; }

                    /// <summary>
                    /// <para>The Xtrace type. The valid value is <b>Zipkin</b>.</para>
                    /// <remarks>
                    /// <para>This value takes effect only when <b>TracingEnabled</b> is set to <b>true</b>.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Zipkin</para>
                    /// </summary>
                    [NameInMap("TracingType")]
                    [Validation(Required=false)]
                    public string TracingType { get; set; }

                }

            }

            /// <summary>
            /// <para>The configuration for associating a QUIC listener.</para>
            /// </summary>
            [NameInMap("QuicConfig")]
            [Validation(Required=false)]
            public ListListenersResponseBodyListenersQuicConfig QuicConfig { get; set; }
            public class ListListenersResponseBodyListenersQuicConfig : TeaModel {
                /// <summary>
                /// <para>The ID of the QUIC listener to be associated. This parameter is required when <b>QuicUpgradeEnabled</b> is set to <b>true</b>. This parameter is valid for HTTPS listeners.</para>
                /// <remarks>
                /// <para>The original listener and the associated QUIC listener must belong to the same ALB instance, and the QUIC listener must not have been previously associated.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>lsn-o4u54y73wq7b******</para>
                /// </summary>
                [NameInMap("QuicListenerId")]
                [Validation(Required=false)]
                public string QuicListenerId { get; set; }

                /// <summary>
                /// <para>Indicates whether QUIC upgrade is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: Enabled.</description></item>
                /// <item><description><b>false</b>: Disabled.</description></item>
                /// </list>
                /// <remarks>
                /// <para>This parameter is valid only for HTTPS listeners.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("QuicUpgradeEnabled")]
                [Validation(Required=false)]
                public bool? QuicUpgradeEnabled { get; set; }

            }

            /// <summary>
            /// <para>The request timeout period. Unit: seconds. Valid values: <b>1 to 180</b>.</para>
            /// <para>If no response is received from the backend server within the timeout period, load balancing stops waiting and returns an <c>HTTP 504</c> error code to the client.</para>
            /// 
            /// <b>Example:</b>
            /// <para>34</para>
            /// </summary>
            [NameInMap("RequestTimeout")]
            [Validation(Required=false)]
            public int? RequestTimeout { get; set; }

            /// <summary>
            /// <para>The security policy.</para>
            /// <remarks>
            /// <para>Only HTTPS listeners support this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>tls_cipher_policy_1_1</para>
            /// </summary>
            [NameInMap("SecurityPolicyId")]
            [Validation(Required=false)]
            public string SecurityPolicyId { get; set; }

            /// <summary>
            /// <para>The tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListListenersResponseBodyListenersTags> Tags { get; set; }
            public class ListListenersResponseBodyListenersTags : TeaModel {
                /// <summary>
                /// <para>The tag key. The tag key can be up to 128 characters in length and cannot start with aliyun or acs:. It cannot contain http:// or https://.</para>
                /// 
                /// <b>Example:</b>
                /// <para>env</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value. The tag value can be up to 128 characters in length and cannot start with aliyun or acs:. It cannot contain http:// or https://.</para>
                /// 
                /// <b>Example:</b>
                /// <para>product</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The <c>XForward</c> header field configuration.</para>
            /// </summary>
            [NameInMap("XForwardedForConfig")]
            [Validation(Required=false)]
            public ListListenersResponseBodyListenersXForwardedForConfig XForwardedForConfig { get; set; }
            public class ListListenersResponseBodyListenersXForwardedForConfig : TeaModel {
                /// <summary>
                /// <para>The custom header field name. This value takes effect only when <b>XForwardedForClientCertClientVerifyEnabled</b> is set to <b>true</b>. Otherwise, this value does not take effect.</para>
                /// <para>Value constraints: 1 to 40 characters in length. Lowercase letters a-z, digits, hyphens (-), and underscores (_) are supported.</para>
                /// <remarks>
                /// <para>Only HTTPS listeners support this parameter.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>test_client-verify-alias_123456</para>
                /// </summary>
                [NameInMap("XForwardedForClientCertClientVerifyAlias")]
                [Validation(Required=false)]
                public string XForwardedForClientCertClientVerifyAlias { get; set; }

                /// <summary>
                /// <para>Indicates whether the <c>X-Forwarded-Clientcert-clientverify</c> header field is used to retrieve the verification result of the client certificate that accesses the load balancing instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: Enabled.</description></item>
                /// <item><description><b>false</b>: Disabled.</description></item>
                /// </list>
                /// <remarks>
                /// <para>Only HTTPS listeners support this parameter.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("XForwardedForClientCertClientVerifyEnabled")]
                [Validation(Required=false)]
                public bool? XForwardedForClientCertClientVerifyEnabled { get; set; }

                /// <summary>
                /// <para>The custom header name. This value takes effect only when <b>XForwardedForClientCertFingerprintEnabled</b> is set to <b>true</b>.</para>
                /// <para>Value constraints: 1 to 40 characters in length. Lowercase letters a-z, digits, hyphens (-), and underscores (_) are supported.</para>
                /// <remarks>
                /// <para>Only HTTPS listeners support this parameter.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>test_finger-print-alias_123456</para>
                /// </summary>
                [NameInMap("XForwardedForClientCertFingerprintAlias")]
                [Validation(Required=false)]
                public string XForwardedForClientCertFingerprintAlias { get; set; }

                /// <summary>
                /// <para>Indicates whether the <c>X-Forwarded-Clientcert-fingerprint</c> header field is used to retrieve the fingerprint of the client certificate that accesses the load balancing instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: Enabled.</description></item>
                /// <item><description><b>false</b>: Disabled.</description></item>
                /// </list>
                /// <remarks>
                /// <para>Only HTTPS listeners support this parameter.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("XForwardedForClientCertFingerprintEnabled")]
                [Validation(Required=false)]
                public bool? XForwardedForClientCertFingerprintEnabled { get; set; }

                /// <summary>
                /// <para>The custom header name. This value takes effect only when <b>XForwardedForClientCertIssuerDNEnabled</b> is set to <b>true</b>.</para>
                /// <para>Value constraints: 1 to 40 characters in length. Lowercase letters a-z, digits, hyphens (-), and underscores (_) are supported.</para>
                /// <remarks>
                /// <para>Only HTTPS listeners support this parameter.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>test_issue-dn-alias_123456</para>
                /// </summary>
                [NameInMap("XForwardedForClientCertIssuerDNAlias")]
                [Validation(Required=false)]
                public string XForwardedForClientCertIssuerDNAlias { get; set; }

                /// <summary>
                /// <para>Indicates whether the <c>X-Forwarded-Clientcert-issuerdn</c> header field is used to retrieve the issuer information of the client certificate that accesses the load balancing instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: Enabled.</description></item>
                /// <item><description><b>false</b>: Disabled.</description></item>
                /// </list>
                /// <remarks>
                /// <para>Only HTTPS listeners support this parameter.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("XForwardedForClientCertIssuerDNEnabled")]
                [Validation(Required=false)]
                public bool? XForwardedForClientCertIssuerDNEnabled { get; set; }

                /// <summary>
                /// <para>The custom header name. This value takes effect only when <b>XForwardedForClientCertSubjectDNEnabled</b> is set to <b>true</b>.</para>
                /// <para>Value constraints: 1 to 40 characters in length. Lowercase letters a-z, digits, hyphens (-), and underscores (_) are supported.</para>
                /// <remarks>
                /// <para>Only HTTPS listeners support this parameter.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>test_subject-dn-alias_123456</para>
                /// </summary>
                [NameInMap("XForwardedForClientCertSubjectDNAlias")]
                [Validation(Required=false)]
                public string XForwardedForClientCertSubjectDNAlias { get; set; }

                /// <summary>
                /// <para>Indicates whether the <c>X-Forwarded-Clientcert-subjectdn</c> header field is used to retrieve the owner information of the client certificate that accesses the load balancing instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: Enabled.</description></item>
                /// <item><description><b>false</b>: Disabled.</description></item>
                /// </list>
                /// <remarks>
                /// <para>Only HTTPS listeners support this parameter.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("XForwardedForClientCertSubjectDNEnabled")]
                [Validation(Required=false)]
                public bool? XForwardedForClientCertSubjectDNEnabled { get; set; }

                /// <summary>
                /// <para>Indicates whether ALB is allowed to look up the originating client IP address from the X-Forwarded-For header. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b>: Enabled.</para>
                /// </description></item>
                /// <item><description><para><b>false</b>: Not enabled.</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <para>HTTP and HTTPS listeners support this parameter.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("XForwardedForClientSourceIpsEnabled")]
                [Validation(Required=false)]
                public bool? XForwardedForClientSourceIpsEnabled { get; set; }

                /// <summary>
                /// <para>The trusted proxy IP addresses.</para>
                /// <para>Application Load Balancing (ALB) traverses the <c>X-Forwarded-For</c> header from right to left and selects the first IP address that is not in the trusted IP list as the originating client IP address. This IP address is used for source IP-based rate limiting.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.1.1.0/24</para>
                /// </summary>
                [NameInMap("XForwardedForClientSourceIpsTrusted")]
                [Validation(Required=false)]
                public string XForwardedForClientSourceIpsTrusted { get; set; }

                /// <summary>
                /// <para>Indicates whether the <c>X-Forwarded-Client-Port</c> header field is used to retrieve the port of the client that accesses the load balancing instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: Enabled.</description></item>
                /// <item><description><b>false</b>: Disabled.</description></item>
                /// </list>
                /// <remarks>
                /// <para>HTTP and HTTPS listeners support this parameter.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("XForwardedForClientSrcPortEnabled")]
                [Validation(Required=false)]
                public bool? XForwardedForClientSrcPortEnabled { get; set; }

                /// <summary>
                /// <para>Indicates whether the <c>X-Forwarded-For</c> header field is used to retrieve the originating IP address of the client. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b> (default): Enabled.</description></item>
                /// <item><description><b>false</b>: Disabled.</description></item>
                /// </list>
                /// <remarks>
                /// <ol>
                /// <item><description>If set to <b>true</b>, <b>XForwardedForProcessingMode</b> defaults to <b>append</b> and can be changed to <b>remove</b>.</description></item>
                /// <item><description>If set to <b>false</b>, the <c>X-Forwarded-For</c> header field is preserved without additional processing before the request is sent to the backend server.</description></item>
                /// <item><description>HTTP and HTTPS listeners support this parameter.</description></item>
                /// </ol>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("XForwardedForEnabled")]
                [Validation(Required=false)]
                public bool? XForwardedForEnabled { get; set; }

                /// <summary>
                /// <para>Indicates whether the <c>X-Forwarded-Host</c> header is used to retrieve the domain name of the client that accesses the load balancing instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: Enabled.</description></item>
                /// <item><description><b>false</b> (default): Not enabled.</description></item>
                /// </list>
                /// <remarks>
                /// <para>HTTP, HTTPS, and QUIC listeners support this parameter.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("XForwardedForHostEnabled")]
                [Validation(Required=false)]
                public bool? XForwardedForHostEnabled { get; set; }

                /// <summary>
                /// <para>The mode for processing the <c>X-Forwarded-For</c> header field. This value takes effect only when <b>XForwardedForEnabled</b> is set to <b>true</b>. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>append</b> (default): Append.</description></item>
                /// <item><description><b>remove</b>: Remove.</description></item>
                /// </list>
                /// <remarks>
                /// <ol>
                /// <item><description>If set to <b>append</b>, the last-hop IP address is appended to the <c>X-Forwarded-For</c> header field before the request is sent to the backend server.</description></item>
                /// <item><description>If set to <b>remove</b>, the <c>X-Forwarded-For</c> header is removed before the request is sent to the backend server, regardless of whether the request carries the <c>X-Forwarded-For</c> header field.</description></item>
                /// <item><description>HTTP and HTTPS listeners support this parameter.</description></item>
                /// </ol>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>append</para>
                /// </summary>
                [NameInMap("XForwardedForProcessingMode")]
                [Validation(Required=false)]
                public string XForwardedForProcessingMode { get; set; }

                /// <summary>
                /// <para>Indicates whether the <c>X-Forwarded-Proto</c> header is used to retrieve the listener protocol of the load balancing instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: Enabled.</description></item>
                /// <item><description><b>false</b>: Not enabled.</description></item>
                /// </list>
                /// <remarks>
                /// <para>HTTP, HTTPS, and QUIC listeners support this parameter.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("XForwardedForProtoEnabled")]
                [Validation(Required=false)]
                public bool? XForwardedForProtoEnabled { get; set; }

                /// <summary>
                /// <para>Indicates whether the <c>SLB-ID</c> header is used to retrieve the load balancing instance ID. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: Enabled.</description></item>
                /// <item><description><b>false</b>: Not enabled.</description></item>
                /// </list>
                /// <remarks>
                /// <para>HTTP, HTTPS, and QUIC listeners support this parameter.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("XForwardedForSLBIdEnabled")]
                [Validation(Required=false)]
                public bool? XForwardedForSLBIdEnabled { get; set; }

                /// <summary>
                /// <para>Indicates whether the <c>X-Forwarded-Port</c> header is used to retrieve the listener port of the load balancing instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: Enabled.</description></item>
                /// <item><description><b>false</b>: Not enabled.</description></item>
                /// </list>
                /// <remarks>
                /// <para>HTTP, HTTPS, and QUIC listeners support this parameter.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("XForwardedForSLBPortEnabled")]
                [Validation(Required=false)]
                public bool? XForwardedForSLBPortEnabled { get; set; }

            }

        }

        /// <summary>
        /// <para>The maximum number of records returned for this request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The position from which the current call starts reading. An empty value indicates that all data has been read.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>365F4154-92F6-4AE4-92F8-7FF3******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries that match the request conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
