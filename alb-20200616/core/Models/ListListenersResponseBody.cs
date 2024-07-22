// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ListListenersResponseBody : TeaModel {
        /// <summary>
        /// The listeners.
        /// </summary>
        [NameInMap("Listeners")]
        [Validation(Required=false)]
        public List<ListListenersResponseBodyListeners> Listeners { get; set; }
        public class ListListenersResponseBodyListeners : TeaModel {
            /// <summary>
            /// The default actions in the forwarding rules.
            /// </summary>
            [NameInMap("DefaultActions")]
            [Validation(Required=false)]
            public List<ListListenersResponseBodyListenersDefaultActions> DefaultActions { get; set; }
            public class ListListenersResponseBodyListenersDefaultActions : TeaModel {
                /// <summary>
                /// The configuration of the forwarding rule action. This parameter takes effect only when the action is **ForwardGroup**.
                /// </summary>
                [NameInMap("ForwardGroupConfig")]
                [Validation(Required=false)]
                public ListListenersResponseBodyListenersDefaultActionsForwardGroupConfig ForwardGroupConfig { get; set; }
                public class ListListenersResponseBodyListenersDefaultActionsForwardGroupConfig : TeaModel {
                    /// <summary>
                    /// The server groups to which requests are forwarded.
                    /// </summary>
                    [NameInMap("ServerGroupTuples")]
                    [Validation(Required=false)]
                    public List<ListListenersResponseBodyListenersDefaultActionsForwardGroupConfigServerGroupTuples> ServerGroupTuples { get; set; }
                    public class ListListenersResponseBodyListenersDefaultActionsForwardGroupConfigServerGroupTuples : TeaModel {
                        /// <summary>
                        /// The ID of the server group to which requests are forwarded.
                        /// </summary>
                        [NameInMap("ServerGroupId")]
                        [Validation(Required=false)]
                        public string ServerGroupId { get; set; }

                    }

                }

                /// <summary>
                /// The action. **ForwardGroup**: forwards requests to multiple server groups.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// Indicates whether GZIP compression is enabled to compress specific types of files. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("GzipEnabled")]
            [Validation(Required=false)]
            public bool? GzipEnabled { get; set; }

            /// <summary>
            /// Indicates whether HTTP/2 is enabled. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// 
            /// >  Only HTTPS listeners support this parameter.
            /// </summary>
            [NameInMap("Http2Enabled")]
            [Validation(Required=false)]
            public bool? Http2Enabled { get; set; }

            /// <summary>
            /// The timeout period of an idle connection. Unit: seconds. Valid values: **1 to 60**.
            /// 
            /// If no request is received within the specified timeout period, ALB closes the connection. ALB establishes the connection again when a new connection request is received.
            /// </summary>
            [NameInMap("IdleTimeout")]
            [Validation(Required=false)]
            public int? IdleTimeout { get; set; }

            /// <summary>
            /// The name of the listener.
            /// </summary>
            [NameInMap("ListenerDescription")]
            [Validation(Required=false)]
            public string ListenerDescription { get; set; }

            /// <summary>
            /// The listener ID.
            /// </summary>
            [NameInMap("ListenerId")]
            [Validation(Required=false)]
            public string ListenerId { get; set; }

            /// <summary>
            /// The frontend port that is used by the ALB instance. Valid values: **1 to 65535**.
            /// </summary>
            [NameInMap("ListenerPort")]
            [Validation(Required=false)]
            public int? ListenerPort { get; set; }

            /// <summary>
            /// The listener protocol of the instance. Valid values:
            /// 
            /// *   **HTTP**
            /// *   **HTTPS**
            /// *   **QUIC**
            /// </summary>
            [NameInMap("ListenerProtocol")]
            [Validation(Required=false)]
            public string ListenerProtocol { get; set; }

            /// <summary>
            /// The status of the listener. Valid values:
            /// 
            /// *   **Provisioning**: The listener is being created.
            /// *   **Running**: The listener is running.
            /// *   **Configuring**: The listener is being configured.
            /// *   **Stopped**: The listener is disabled.
            /// </summary>
            [NameInMap("ListenerStatus")]
            [Validation(Required=false)]
            public string ListenerStatus { get; set; }

            /// <summary>
            /// The ALB instance ID.
            /// </summary>
            [NameInMap("LoadBalancerId")]
            [Validation(Required=false)]
            public string LoadBalancerId { get; set; }

            /// <summary>
            /// The logging configurations.
            /// </summary>
            [NameInMap("LogConfig")]
            [Validation(Required=false)]
            public ListListenersResponseBodyListenersLogConfig LogConfig { get; set; }
            public class ListListenersResponseBodyListenersLogConfig : TeaModel {
                /// <summary>
                /// Indicates whether custom headers are carried in the access log. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// </summary>
                [NameInMap("AccessLogRecordCustomizedHeadersEnabled")]
                [Validation(Required=false)]
                public bool? AccessLogRecordCustomizedHeadersEnabled { get; set; }

                /// <summary>
                /// The configurations of xtrace.
                /// </summary>
                [NameInMap("AccessLogTracingConfig")]
                [Validation(Required=false)]
                public ListListenersResponseBodyListenersLogConfigAccessLogTracingConfig AccessLogTracingConfig { get; set; }
                public class ListListenersResponseBodyListenersLogConfigAccessLogTracingConfig : TeaModel {
                    /// <summary>
                    /// Indicates whether xtrace is enabled. Valid values:
                    /// 
                    /// *   **true**
                    /// *   **false**
                    /// 
                    /// >  This parameter can be set to **true** only when the access log feature of ALB is enabled by setting **AccessLogEnabled** to true.
                    /// </summary>
                    [NameInMap("TracingEnabled")]
                    [Validation(Required=false)]
                    public bool? TracingEnabled { get; set; }

                    /// <summary>
                    /// The sampling rate of xtrace. Valid values: **1 to 10000**.
                    /// 
                    /// >  This parameter takes effect when **TracingEnabled** is set to **true**.
                    /// </summary>
                    [NameInMap("TracingSample")]
                    [Validation(Required=false)]
                    public int? TracingSample { get; set; }

                    /// <summary>
                    /// The type of xtrace. The value is set to **Zipkin**.
                    /// 
                    /// >  This parameter takes effect when **TracingEnabled** is set to **true**.
                    /// </summary>
                    [NameInMap("TracingType")]
                    [Validation(Required=false)]
                    public string TracingType { get; set; }

                }

            }

            /// <summary>
            /// The configurations of the QUIC listener associated with the ALB instance.
            /// </summary>
            [NameInMap("QuicConfig")]
            [Validation(Required=false)]
            public ListListenersResponseBodyListenersQuicConfig QuicConfig { get; set; }
            public class ListListenersResponseBodyListenersQuicConfig : TeaModel {
                /// <summary>
                /// The ID of the QUIC listener associated with the ALB instance. This parameter is required if the **QuicUpgradeEnabled** parameter is set to **true**. Only HTTPS listeners support this parameter.
                /// 
                /// >  The existing listener and QUIC listener must be to the same ALB instance, and the QUIC listener has not been associated with an ALB instance.
                /// </summary>
                [NameInMap("QuicListenerId")]
                [Validation(Required=false)]
                public string QuicListenerId { get; set; }

                /// <summary>
                /// Indicates whether QUIC upgrade is enabled. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// 
                /// >  Only HTTPS listeners support this parameter.
                /// </summary>
                [NameInMap("QuicUpgradeEnabled")]
                [Validation(Required=false)]
                public bool? QuicUpgradeEnabled { get; set; }

            }

            /// <summary>
            /// The timeout period of a request. Unit: seconds. Valid values: **1 to 180**.
            /// 
            /// If no responses are received from the backend server within the specified timeout period, ALB returns an `HTTP 504` error code to the client.
            /// </summary>
            [NameInMap("RequestTimeout")]
            [Validation(Required=false)]
            public int? RequestTimeout { get; set; }

            /// <summary>
            /// The security policy.
            /// 
            /// >  Only HTTPS listeners support this parameter.
            /// </summary>
            [NameInMap("SecurityPolicyId")]
            [Validation(Required=false)]
            public string SecurityPolicyId { get; set; }

            /// <summary>
            /// The tags.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListListenersResponseBodyListenersTags> Tags { get; set; }
            public class ListListenersResponseBodyListenersTags : TeaModel {
                /// <summary>
                /// The tag key. The tag key can be up to 128 characters in length. It cannot start with aliyun or acs: and cannot contain http:// or https://.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The tag value. The tag value can be up to 128 characters in length. It cannot start with aliyun or acs: and cannot contain http:// or https://.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The configuration of the `XForward` header.
            /// </summary>
            [NameInMap("XForwardedForConfig")]
            [Validation(Required=false)]
            public ListListenersResponseBodyListenersXForwardedForConfig XForwardedForConfig { get; set; }
            public class ListListenersResponseBodyListenersXForwardedForConfig : TeaModel {
                /// <summary>
                /// The name of the custom header. This parameter takes effect only when **XForwardedForClientCertClientVerifyEnabled** is set to **true**.
                /// 
                /// The name must be 1 to 40 characters in length, and can contain lowercase letters, digits, hyphens (-), and underscores (_).
                /// 
                /// >  Only HTTPS listeners support this parameter.
                /// </summary>
                [NameInMap("XForwardedForClientCertClientVerifyAlias")]
                [Validation(Required=false)]
                public string XForwardedForClientCertClientVerifyAlias { get; set; }

                /// <summary>
                /// Indicates whether the `X-Forwarded-Clientcert-clientverify` header is used to obtain the verification result of the client certificate. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// 
                /// >  Only HTTPS listeners support this parameter.
                /// </summary>
                [NameInMap("XForwardedForClientCertClientVerifyEnabled")]
                [Validation(Required=false)]
                public bool? XForwardedForClientCertClientVerifyEnabled { get; set; }

                /// <summary>
                /// The name of the custom header. This parameter takes effect only when **XForwardedForClientCertFingerprintEnabled** is set to **true**.
                /// 
                /// The name must be 1 to 40 characters in length, and can contain lowercase letters, digits, hyphens (-), and underscores (_).
                /// 
                /// >  Only HTTPS listeners support this parameter.
                /// </summary>
                [NameInMap("XForwardedForClientCertFingerprintAlias")]
                [Validation(Required=false)]
                public string XForwardedForClientCertFingerprintAlias { get; set; }

                /// <summary>
                /// Indicates whether the `X-Forwarded-Clientcert-fingerprint` header is used to retrieve the fingerprint of the client certificate. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// 
                /// >  Only HTTPS listeners support this parameter.
                /// </summary>
                [NameInMap("XForwardedForClientCertFingerprintEnabled")]
                [Validation(Required=false)]
                public bool? XForwardedForClientCertFingerprintEnabled { get; set; }

                /// <summary>
                /// The name of the custom header. This parameter takes effect only when **XForwardedForClientCertIssuerDNEnabled** is set to **true**.
                /// 
                /// The name must be 1 to 40 characters in length, and can contain lowercase letters, digits, hyphens (-), and underscores (_).
                /// 
                /// >  Only HTTPS listeners support this parameter.
                /// </summary>
                [NameInMap("XForwardedForClientCertIssuerDNAlias")]
                [Validation(Required=false)]
                public string XForwardedForClientCertIssuerDNAlias { get; set; }

                /// <summary>
                /// Indicates whether the `X-Forwarded-Clientcert-issuerdn` header is used to retrieve information about the authority that issues the client certificate. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// 
                /// >  Only HTTPS listeners support this parameter.
                /// </summary>
                [NameInMap("XForwardedForClientCertIssuerDNEnabled")]
                [Validation(Required=false)]
                public bool? XForwardedForClientCertIssuerDNEnabled { get; set; }

                /// <summary>
                /// The name of the custom header. This parameter takes effect only when **XForwardedForClientCertSubjectDNEnabled** is set to **true**.
                /// 
                /// The name must be 1 to 40 characters in length, and can contain lowercase letters, digits, hyphens (-), and underscores (_).
                /// 
                /// >  Only HTTPS listeners support this parameter.
                /// </summary>
                [NameInMap("XForwardedForClientCertSubjectDNAlias")]
                [Validation(Required=false)]
                public string XForwardedForClientCertSubjectDNAlias { get; set; }

                /// <summary>
                /// Indicates whether the `X-Forwarded-Clientcert-subjectdn` header is used to retrieve information about the owner of the client certificate. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// 
                /// >  Only HTTPS listeners support this parameter.
                /// </summary>
                [NameInMap("XForwardedForClientCertSubjectDNEnabled")]
                [Validation(Required=false)]
                public bool? XForwardedForClientCertSubjectDNEnabled { get; set; }

                /// <summary>
                /// Indicates whether the X-Forwarded-For header is used to preserver client IP addresses for the ALB instance. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// 
                /// >  This parameter is returned only for HTTP and HTTPS listeners.
                /// </summary>
                [NameInMap("XForwardedForClientSourceIpsEnabled")]
                [Validation(Required=false)]
                public bool? XForwardedForClientSourceIpsEnabled { get; set; }

                /// <summary>
                /// The trusted proxy IP address.
                /// 
                /// ALB instances traverse the IP addresses in the `X-Forwarded-For` header from the rightmost IP address to the leftmost IP address. The first IP address that is not on the trusted IP address list is considered the client IP address. Requests from the client IP address are throttled.
                /// </summary>
                [NameInMap("XForwardedForClientSourceIpsTrusted")]
                [Validation(Required=false)]
                public string XForwardedForClientSourceIpsTrusted { get; set; }

                /// <summary>
                /// Indicates whether the `X-Forwarded-Client-Port` header is used to retrieve the client port. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// 
                /// >  This parameter is returned only for HTTP and HTTPS listeners.
                /// </summary>
                [NameInMap("XForwardedForClientSrcPortEnabled")]
                [Validation(Required=false)]
                public bool? XForwardedForClientSrcPortEnabled { get; set; }

                /// <summary>
                /// Specifies whether to use the `X-Forwarded-For` header to retrieve client IP addresses. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// 
                /// >  This parameter is returned only for HTTP and HTTPS listeners.
                /// </summary>
                [NameInMap("XForwardedForEnabled")]
                [Validation(Required=false)]
                public bool? XForwardedForEnabled { get; set; }

                /// <summary>
                /// Indicates whether the `X-Forwarded-Proto` header is used to retrieve the listener protocol. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// 
                /// >  This parameter is supported by HTTP, HTTPS, and QUIC listeners.
                /// </summary>
                [NameInMap("XForwardedForProtoEnabled")]
                [Validation(Required=false)]
                public bool? XForwardedForProtoEnabled { get; set; }

                /// <summary>
                /// Specifies whether to use the `SLB-ID` header to retrieve the ID of the ALB instance. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// 
                /// >  This parameter is supported by HTTP, HTTPS, and QUIC listeners.
                /// </summary>
                [NameInMap("XForwardedForSLBIdEnabled")]
                [Validation(Required=false)]
                public bool? XForwardedForSLBIdEnabled { get; set; }

                /// <summary>
                /// Indicates whether the `X-Forwarded-Port` header is used to retrieve the listener port of the ALB instance. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// 
                /// >  This parameter is supported by HTTP, HTTPS, and QUIC listeners.
                /// </summary>
                [NameInMap("XForwardedForSLBPortEnabled")]
                [Validation(Required=false)]
                public bool? XForwardedForSLBPortEnabled { get; set; }

            }

        }

        /// <summary>
        /// The maximum number of entries returned.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The position where the query stopped. If this parameter is not returned, all data is queried.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
