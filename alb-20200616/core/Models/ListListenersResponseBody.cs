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
                /// The configuration of the forwarding rule action. This parameter is required and takes effect only if the type of the action is **ForwardGroup**.
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
                /// The type of the action. If **ForwardGroup** is returned, requests are forwarded to multiple vServer groups.
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
            /// >  This parameter is returned only for HTTPS listeners.
            /// </summary>
            [NameInMap("Http2Enabled")]
            [Validation(Required=false)]
            public bool? Http2Enabled { get; set; }

            /// <summary>
            /// The timeout period of an idle connection. Unit: seconds. Valid values: **1 to 60**.
            /// 
            /// If no request is received within the specified timeout period, ALB closes the connection. ALB re-establishes the connection when a new connection request is received.
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
            /// The ID of the listener.
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
            /// The listener protocol. Valid values:
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
            /// *   **Provisioning**
            /// *   **Running**
            /// *   **Configuring**
            /// *   **Stopped**
            /// </summary>
            [NameInMap("ListenerStatus")]
            [Validation(Required=false)]
            public string ListenerStatus { get; set; }

            /// <summary>
            /// The ID of the ALB instance.
            /// </summary>
            [NameInMap("LoadBalancerId")]
            [Validation(Required=false)]
            public string LoadBalancerId { get; set; }

            /// <summary>
            /// The configuration of logs.
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
                /// The configuration of Xtrace. Xtrace is used to record the requests that are sent to ALB.
                /// </summary>
                [NameInMap("AccessLogTracingConfig")]
                [Validation(Required=false)]
                public ListListenersResponseBodyListenersLogConfigAccessLogTracingConfig AccessLogTracingConfig { get; set; }
                public class ListListenersResponseBodyListenersLogConfigAccessLogTracingConfig : TeaModel {
                    /// <summary>
                    /// Indicates whether Xtrace is enabled. Valid values:
                    /// 
                    /// *   **true**
                    /// *   **false**
                    /// 
                    /// >  This parameter can be set to **true** only if **AccessLogEnabled** is set to true.
                    /// </summary>
                    [NameInMap("TracingEnabled")]
                    [Validation(Required=false)]
                    public bool? TracingEnabled { get; set; }

                    /// <summary>
                    /// The sampling rate of Xtrace. Valid values: **1 to 10000**.
                    /// 
                    /// >  This parameter takes effect only if **TracingEnabled** is set to **true**.
                    /// </summary>
                    [NameInMap("TracingSample")]
                    [Validation(Required=false)]
                    public int? TracingSample { get; set; }

                    /// <summary>
                    /// The Xtrace type. Only **Zipkin** may be returned.
                    /// 
                    /// >  This parameter takes effect only if **TracingEnabled** is set to **true**.
                    /// </summary>
                    [NameInMap("TracingType")]
                    [Validation(Required=false)]
                    public string TracingType { get; set; }

                }

            }

            /// <summary>
            /// The configuration information when the listener is associated with a QUIC listener.
            /// </summary>
            [NameInMap("QuicConfig")]
            [Validation(Required=false)]
            public ListListenersResponseBodyListenersQuicConfig QuicConfig { get; set; }
            public class ListListenersResponseBodyListenersQuicConfig : TeaModel {
                /// <summary>
                /// The ID of the QUIC listener. This parameter is required when **QuicUpgradeEnabled** is set to **true**. Only HTTPS listeners support this parameter.
                /// 
                /// >  The HTTPS listener and the associated QUIC listener must belong to the same ALB instance. The QUIC listener cannot be associated with another listener.
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
                /// >  This parameter takes effect only for HTTPS listeners.
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
            /// >  This parameter is returned only for HTTPS listeners.
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
                /// The tag key.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The tag value.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The configuration of the `XForward` headers.
            /// </summary>
            [NameInMap("XForwardedForConfig")]
            [Validation(Required=false)]
            public ListListenersResponseBodyListenersXForwardedForConfig XForwardedForConfig { get; set; }
            public class ListListenersResponseBodyListenersXForwardedForConfig : TeaModel {
                /// <summary>
                /// The name of the custom header. This parameter takes effect only if **XForwardedForClientCertClientVerifyEnabled** is set to **true**.
                /// 
                /// The name is 1 to 40 characters in length, and can contain letters, digits, hyphens (-), and underscores (_).
                /// 
                /// >  This parameter is returned only for HTTPS listeners.
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
                /// >  This parameter is returned only for HTTPS listeners.
                /// </summary>
                [NameInMap("XForwardedForClientCertClientVerifyEnabled")]
                [Validation(Required=false)]
                public bool? XForwardedForClientCertClientVerifyEnabled { get; set; }

                /// <summary>
                /// The name of the custom header. This parameter takes effect only if **XForwardedForClientCertFingerprintEnabled** is set to **true**.
                /// 
                /// The name is 1 to 40 characters in length, and can contain letters, digits, hyphens (-), and underscores (_).
                /// 
                /// >  This parameter is returned only for HTTPS listeners.
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
                /// >  This parameter is returned only for HTTPS listeners.
                /// </summary>
                [NameInMap("XForwardedForClientCertFingerprintEnabled")]
                [Validation(Required=false)]
                public bool? XForwardedForClientCertFingerprintEnabled { get; set; }

                /// <summary>
                /// The name of the custom header. This parameter takes effect only if **XForwardedForClientCertIssuerDNEnabled** is set to **true**.
                /// 
                /// The name is 1 to 40 characters in length, and can contain letters, digits, hyphens (-), and underscores (_).
                /// 
                /// >  This parameter is returned only for HTTPS listeners.
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
                /// >  This parameter is returned only for HTTPS listeners.
                /// </summary>
                [NameInMap("XForwardedForClientCertIssuerDNEnabled")]
                [Validation(Required=false)]
                public bool? XForwardedForClientCertIssuerDNEnabled { get; set; }

                /// <summary>
                /// The name of the custom header. This parameter takes effect only if **XForwardedForClientCertSubjectDNEnabled** is set to **true**.
                /// 
                /// The name is 1 to 40 characters in length, and can contain letters, digits, hyphens (-), and underscores (_).
                /// 
                /// >  This parameter is returned only for HTTPS listeners.
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
                /// >  This parameter is returned only for HTTPS listeners.
                /// </summary>
                [NameInMap("XForwardedForClientCertSubjectDNEnabled")]
                [Validation(Required=false)]
                public bool? XForwardedForClientCertSubjectDNEnabled { get; set; }

                /// <summary>
                /// Indicates whether the `X-Forwarded-Client-Ip` header is used to retrieve the source port of the ALB instance. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// 
                /// >  HTTP, HTTPS, and QUIC listeners support this parameter.
                /// </summary>
                [NameInMap("XForwardedForClientSourceIpsEnabled")]
                [Validation(Required=false)]
                public bool? XForwardedForClientSourceIpsEnabled { get; set; }

                /// <summary>
                /// The trusted proxy IP address.
                /// 
                /// ALB traverses `X-Forwarded-For` backward and selects the first IP address that is not in the trusted IP address list as the real IP address of the client. The IP address is used in source IP address throttling.
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
                /// Indicates whether the `X-Forwarded-For` header is used to retrieve the client IP address. Valid values:
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
                /// >  HTTP, HTTPS, and QUIC listeners support this parameter.
                /// </summary>
                [NameInMap("XForwardedForProtoEnabled")]
                [Validation(Required=false)]
                public bool? XForwardedForProtoEnabled { get; set; }

                /// <summary>
                /// Indicates whether the `SLB-ID` header is used to retrieve the ID of the ALB instance. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// 
                /// >  HTTP, HTTPS, and QUIC listeners support this parameter.
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
                /// >  HTTP, HTTPS, and QUIC listeners support this parameter.
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
