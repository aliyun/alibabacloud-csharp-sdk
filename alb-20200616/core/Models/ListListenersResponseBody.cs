// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ListListenersResponseBody : TeaModel {
        /// <summary>
        /// <para>The listeners.</para>
        /// </summary>
        [NameInMap("Listeners")]
        [Validation(Required=false)]
        public List<ListListenersResponseBodyListeners> Listeners { get; set; }
        public class ListListenersResponseBodyListeners : TeaModel {
            /// <summary>
            /// <para>The default actions in the forwarding rules.</para>
            /// </summary>
            [NameInMap("DefaultActions")]
            [Validation(Required=false)]
            public List<ListListenersResponseBodyListenersDefaultActions> DefaultActions { get; set; }
            public class ListListenersResponseBodyListenersDefaultActions : TeaModel {
                /// <summary>
                /// <para>The configuration of the forwarding rule action. This parameter takes effect only when the action is <b>ForwardGroup</b>.</para>
                /// </summary>
                [NameInMap("ForwardGroupConfig")]
                [Validation(Required=false)]
                public ListListenersResponseBodyListenersDefaultActionsForwardGroupConfig ForwardGroupConfig { get; set; }
                public class ListListenersResponseBodyListenersDefaultActionsForwardGroupConfig : TeaModel {
                    /// <summary>
                    /// <para>The server groups to which requests are forwarded.</para>
                    /// </summary>
                    [NameInMap("ServerGroupTuples")]
                    [Validation(Required=false)]
                    public List<ListListenersResponseBodyListenersDefaultActionsForwardGroupConfigServerGroupTuples> ServerGroupTuples { get; set; }
                    public class ListListenersResponseBodyListenersDefaultActionsForwardGroupConfigServerGroupTuples : TeaModel {
                        /// <summary>
                        /// <para>The ID of the server group to which requests are forwarded.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>rsp-cige6j****</para>
                        /// </summary>
                        [NameInMap("ServerGroupId")]
                        [Validation(Required=false)]
                        public string ServerGroupId { get; set; }

                    }

                }

                /// <summary>
                /// <para>The action. <b>ForwardGroup</b>: forwards requests to multiple server groups.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ForwardGroup</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether GZIP compression is enabled to compress specific types of files. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
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
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// <remarks>
            /// <para> Only HTTPS listeners support this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Http2Enabled")]
            [Validation(Required=false)]
            public bool? Http2Enabled { get; set; }

            /// <summary>
            /// <para>The timeout period of an idle connection. Unit: seconds. Valid values: <b>1 to 60</b>.</para>
            /// <para>If no request is received within the specified timeout period, ALB closes the connection. ALB establishes the connection again when a new connection request is received.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("IdleTimeout")]
            [Validation(Required=false)]
            public int? IdleTimeout { get; set; }

            /// <summary>
            /// <para>The name of the listener.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ListenerDescription")]
            [Validation(Required=false)]
            public string ListenerDescription { get; set; }

            /// <summary>
            /// <para>The listener ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lsr-bp1bpn0kn908w4nbw****</para>
            /// </summary>
            [NameInMap("ListenerId")]
            [Validation(Required=false)]
            public string ListenerId { get; set; }

            /// <summary>
            /// <para>The frontend port that is used by the ALB instance. Valid values: <b>1 to 65535</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("ListenerPort")]
            [Validation(Required=false)]
            public int? ListenerPort { get; set; }

            /// <summary>
            /// <para>The listener protocol of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>HTTP</b></description></item>
            /// <item><description><b>HTTPS</b></description></item>
            /// <item><description><b>QUIC</b></description></item>
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
            /// <item><description><b>Provisioning</b>: The listener is being created.</description></item>
            /// <item><description><b>Running</b>: The listener is running.</description></item>
            /// <item><description><b>Configuring</b>: The listener is being configured.</description></item>
            /// <item><description><b>Stopped</b>: The listener is disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("ListenerStatus")]
            [Validation(Required=false)]
            public string ListenerStatus { get; set; }

            /// <summary>
            /// <para>The ALB instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lb-bp1b6c719dfa08ex*****</para>
            /// </summary>
            [NameInMap("LoadBalancerId")]
            [Validation(Required=false)]
            public string LoadBalancerId { get; set; }

            /// <summary>
            /// <para>The logging configurations.</para>
            /// </summary>
            [NameInMap("LogConfig")]
            [Validation(Required=false)]
            public ListListenersResponseBodyListenersLogConfig LogConfig { get; set; }
            public class ListListenersResponseBodyListenersLogConfig : TeaModel {
                /// <summary>
                /// <para>Indicates whether custom headers are carried in the access log. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("AccessLogRecordCustomizedHeadersEnabled")]
                [Validation(Required=false)]
                public bool? AccessLogRecordCustomizedHeadersEnabled { get; set; }

                /// <summary>
                /// <para>The configurations of xtrace.</para>
                /// </summary>
                [NameInMap("AccessLogTracingConfig")]
                [Validation(Required=false)]
                public ListListenersResponseBodyListenersLogConfigAccessLogTracingConfig AccessLogTracingConfig { get; set; }
                public class ListListenersResponseBodyListenersLogConfigAccessLogTracingConfig : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether xtrace is enabled. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b></description></item>
                    /// <item><description><b>false</b></description></item>
                    /// </list>
                    /// <remarks>
                    /// <para> This parameter can be set to <b>true</b> only when the access log feature of ALB is enabled by setting <b>AccessLogEnabled</b> to true.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("TracingEnabled")]
                    [Validation(Required=false)]
                    public bool? TracingEnabled { get; set; }

                    /// <summary>
                    /// <para>The sampling rate of xtrace. Valid values: <b>1 to 10000</b>.</para>
                    /// <remarks>
                    /// <para> This parameter takes effect when <b>TracingEnabled</b> is set to <b>true</b>.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("TracingSample")]
                    [Validation(Required=false)]
                    public int? TracingSample { get; set; }

                    /// <summary>
                    /// <para>The type of xtrace. The value is set to <b>Zipkin</b>.</para>
                    /// <remarks>
                    /// <para> This parameter takes effect when <b>TracingEnabled</b> is set to <b>true</b>.</para>
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
            /// <para>The configurations of the QUIC listener associated with the ALB instance.</para>
            /// </summary>
            [NameInMap("QuicConfig")]
            [Validation(Required=false)]
            public ListListenersResponseBodyListenersQuicConfig QuicConfig { get; set; }
            public class ListListenersResponseBodyListenersQuicConfig : TeaModel {
                /// <summary>
                /// <para>The ID of the QUIC listener associated with the ALB instance. This parameter is required if the <b>QuicUpgradeEnabled</b> parameter is set to <b>true</b>. Only HTTPS listeners support this parameter.</para>
                /// <remarks>
                /// <para> The existing listener and QUIC listener must be to the same ALB instance, and the QUIC listener has not been associated with an ALB instance.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>lsr-bp1bpn908w4nbw****</para>
                /// </summary>
                [NameInMap("QuicListenerId")]
                [Validation(Required=false)]
                public string QuicListenerId { get; set; }

                /// <summary>
                /// <para>Indicates whether QUIC upgrade is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// <remarks>
                /// <para> Only HTTPS listeners support this parameter.</para>
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
            /// <para>The timeout period of a request. Unit: seconds. Valid values: <b>1 to 180</b>.</para>
            /// <para>If no responses are received from the backend server within the specified timeout period, ALB returns an <c>HTTP 504</c> error code to the client.</para>
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
            /// <para> Only HTTPS listeners support this parameter.</para>
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
                /// <para>The tag key. The tag key can be up to 128 characters in length. It cannot start with aliyun or acs: and cannot contain http:// or https://.</para>
                /// 
                /// <b>Example:</b>
                /// <para>env</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value. The tag value can be up to 128 characters in length. It cannot start with aliyun or acs: and cannot contain http:// or https://.</para>
                /// 
                /// <b>Example:</b>
                /// <para>product</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The configuration of the <c>XForward</c> header.</para>
            /// </summary>
            [NameInMap("XForwardedForConfig")]
            [Validation(Required=false)]
            public ListListenersResponseBodyListenersXForwardedForConfig XForwardedForConfig { get; set; }
            public class ListListenersResponseBodyListenersXForwardedForConfig : TeaModel {
                /// <summary>
                /// <para>The name of the custom header. This parameter takes effect only when <b>XForwardedForClientCertClientVerifyEnabled</b> is set to <b>true</b>.</para>
                /// <para>The name must be 1 to 40 characters in length, and can contain lowercase letters, digits, hyphens (-), and underscores (_).</para>
                /// <remarks>
                /// <para> Only HTTPS listeners support this parameter.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>test_client-verify-alias_123456</para>
                /// </summary>
                [NameInMap("XForwardedForClientCertClientVerifyAlias")]
                [Validation(Required=false)]
                public string XForwardedForClientCertClientVerifyAlias { get; set; }

                /// <summary>
                /// <para>Indicates whether the <c>X-Forwarded-Clientcert-clientverify</c> header is used to obtain the verification result of the client certificate. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// <remarks>
                /// <para> Only HTTPS listeners support this parameter.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("XForwardedForClientCertClientVerifyEnabled")]
                [Validation(Required=false)]
                public bool? XForwardedForClientCertClientVerifyEnabled { get; set; }

                /// <summary>
                /// <para>The name of the custom header. This parameter takes effect only when <b>XForwardedForClientCertFingerprintEnabled</b> is set to <b>true</b>.</para>
                /// <para>The name must be 1 to 40 characters in length, and can contain lowercase letters, digits, hyphens (-), and underscores (_).</para>
                /// <remarks>
                /// <para> Only HTTPS listeners support this parameter.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>test_finger-print-alias_123456</para>
                /// </summary>
                [NameInMap("XForwardedForClientCertFingerprintAlias")]
                [Validation(Required=false)]
                public string XForwardedForClientCertFingerprintAlias { get; set; }

                /// <summary>
                /// <para>Indicates whether the <c>X-Forwarded-Clientcert-fingerprint</c> header is used to retrieve the fingerprint of the client certificate. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// <remarks>
                /// <para> Only HTTPS listeners support this parameter.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("XForwardedForClientCertFingerprintEnabled")]
                [Validation(Required=false)]
                public bool? XForwardedForClientCertFingerprintEnabled { get; set; }

                /// <summary>
                /// <para>The name of the custom header. This parameter takes effect only when <b>XForwardedForClientCertIssuerDNEnabled</b> is set to <b>true</b>.</para>
                /// <para>The name must be 1 to 40 characters in length, and can contain lowercase letters, digits, hyphens (-), and underscores (_).</para>
                /// <remarks>
                /// <para> Only HTTPS listeners support this parameter.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>test_issue-dn-alias_123456</para>
                /// </summary>
                [NameInMap("XForwardedForClientCertIssuerDNAlias")]
                [Validation(Required=false)]
                public string XForwardedForClientCertIssuerDNAlias { get; set; }

                /// <summary>
                /// <para>Indicates whether the <c>X-Forwarded-Clientcert-issuerdn</c> header is used to retrieve information about the authority that issues the client certificate. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// <remarks>
                /// <para> Only HTTPS listeners support this parameter.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("XForwardedForClientCertIssuerDNEnabled")]
                [Validation(Required=false)]
                public bool? XForwardedForClientCertIssuerDNEnabled { get; set; }

                /// <summary>
                /// <para>The name of the custom header. This parameter takes effect only when <b>XForwardedForClientCertSubjectDNEnabled</b> is set to <b>true</b>.</para>
                /// <para>The name must be 1 to 40 characters in length, and can contain lowercase letters, digits, hyphens (-), and underscores (_).</para>
                /// <remarks>
                /// <para> Only HTTPS listeners support this parameter.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>test_subject-dn-alias_123456</para>
                /// </summary>
                [NameInMap("XForwardedForClientCertSubjectDNAlias")]
                [Validation(Required=false)]
                public string XForwardedForClientCertSubjectDNAlias { get; set; }

                /// <summary>
                /// <para>Indicates whether the <c>X-Forwarded-Clientcert-subjectdn</c> header is used to retrieve information about the owner of the client certificate. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// <remarks>
                /// <para> Only HTTPS listeners support this parameter.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("XForwardedForClientCertSubjectDNEnabled")]
                [Validation(Required=false)]
                public bool? XForwardedForClientCertSubjectDNEnabled { get; set; }

                /// <summary>
                /// <para>Indicates whether the X-Forwarded-For header is used to preserver client IP addresses for the ALB instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// <remarks>
                /// <para> This parameter is returned only for HTTP and HTTPS listeners.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("XForwardedForClientSourceIpsEnabled")]
                [Validation(Required=false)]
                public bool? XForwardedForClientSourceIpsEnabled { get; set; }

                /// <summary>
                /// <para>The trusted proxy IP address.</para>
                /// <para>ALB instances traverse the IP addresses in the <c>X-Forwarded-For</c> header from the rightmost IP address to the leftmost IP address. The first IP address that is not on the trusted IP address list is considered the client IP address. Requests from the client IP address are throttled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.1.1.0/24</para>
                /// </summary>
                [NameInMap("XForwardedForClientSourceIpsTrusted")]
                [Validation(Required=false)]
                public string XForwardedForClientSourceIpsTrusted { get; set; }

                /// <summary>
                /// <para>Indicates whether the <c>X-Forwarded-Client-Port</c> header is used to retrieve the client port. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// <remarks>
                /// <para> This parameter is returned only for HTTP and HTTPS listeners.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("XForwardedForClientSrcPortEnabled")]
                [Validation(Required=false)]
                public bool? XForwardedForClientSrcPortEnabled { get; set; }

                /// <summary>
                /// <para>Specifies whether to use the <c>X-Forwarded-For</c> header to retrieve client IP addresses. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// <remarks>
                /// <para> This parameter is returned only for HTTP and HTTPS listeners.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("XForwardedForEnabled")]
                [Validation(Required=false)]
                public bool? XForwardedForEnabled { get; set; }

                /// <summary>
                /// <para>Indicates whether the <c>X-Forwarded-Proto</c> header is used to retrieve the listener protocol. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// <remarks>
                /// <para> This parameter is supported by HTTP, HTTPS, and QUIC listeners.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("XForwardedForProtoEnabled")]
                [Validation(Required=false)]
                public bool? XForwardedForProtoEnabled { get; set; }

                /// <summary>
                /// <para>Specifies whether to use the <c>SLB-ID</c> header to retrieve the ID of the ALB instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// <remarks>
                /// <para> This parameter is supported by HTTP, HTTPS, and QUIC listeners.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("XForwardedForSLBIdEnabled")]
                [Validation(Required=false)]
                public bool? XForwardedForSLBIdEnabled { get; set; }

                /// <summary>
                /// <para>Indicates whether the <c>X-Forwarded-Port</c> header is used to retrieve the listener port of the ALB instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// <remarks>
                /// <para> This parameter is supported by HTTP, HTTPS, and QUIC listeners.</para>
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
        /// <para>The maximum number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The position where the query stopped. If this parameter is not returned, all data is queried.</para>
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
        /// <para>365F4154-92F6-4AE4-92F8-7FF34B540710</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
