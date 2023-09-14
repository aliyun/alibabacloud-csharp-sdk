// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class CreateListenerRequest : TeaModel {
        /// <summary>
        /// A list of certificates.
        /// </summary>
        [NameInMap("CaCertificates")]
        [Validation(Required=false)]
        public List<CreateListenerRequestCaCertificates> CaCertificates { get; set; }
        public class CreateListenerRequestCaCertificates : TeaModel {
        }

        /// <summary>
        /// Specifies whether to enable mutual authentication. Valid values:
        /// 
        /// *   **true**
        /// *   **false** (default):
        /// </summary>
        [NameInMap("CaEnabled")]
        [Validation(Required=false)]
        public bool? CaEnabled { get; set; }

        /// <summary>
        /// A list of certificates.
        /// </summary>
        [NameInMap("Certificates")]
        [Validation(Required=false)]
        public List<CreateListenerRequestCertificates> Certificates { get; set; }
        public class CreateListenerRequestCertificates : TeaModel {
            /// <summary>
            /// The ID of the certificate. Only server certificates are supported. You can specify a maximum of 20 certificate IDs.
            /// 
            /// > This parameter is required if **ListenerProtocol** is set to **HTTPS** or **QUIC**.
            /// </summary>
            [NameInMap("CertificateId")]
            [Validation(Required=false)]
            public string CertificateId { get; set; }

        }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.
        /// 
        /// > If you do not specify this parameter, the system automatically uses the **request ID** as the **client token**. The **request ID** may be different for each request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The actions of the forwarding rule.
        /// </summary>
        [NameInMap("DefaultActions")]
        [Validation(Required=false)]
        public List<CreateListenerRequestDefaultActions> DefaultActions { get; set; }
        public class CreateListenerRequestDefaultActions : TeaModel {
            /// <summary>
            /// Specifies the configurations of the forwarding action. You can specify a maximum of 20 configurations.
            /// </summary>
            [NameInMap("ForwardGroupConfig")]
            [Validation(Required=false)]
            public CreateListenerRequestDefaultActionsForwardGroupConfig ForwardGroupConfig { get; set; }
            public class CreateListenerRequestDefaultActionsForwardGroupConfig : TeaModel {
                /// <summary>
                /// The server group to which requests are forwarded.
                /// </summary>
                [NameInMap("ServerGroupTuples")]
                [Validation(Required=false)]
                public List<CreateListenerRequestDefaultActionsForwardGroupConfigServerGroupTuples> ServerGroupTuples { get; set; }
                public class CreateListenerRequestDefaultActionsForwardGroupConfigServerGroupTuples : TeaModel {
                    /// <summary>
                    /// The ID of the server group to which requests are forwarded.
                    /// </summary>
                    [NameInMap("ServerGroupId")]
                    [Validation(Required=false)]
                    public string ServerGroupId { get; set; }

                }

            }

            /// <summary>
            /// The type of the action. You can specify only one action type.
            /// 
            /// Set the value to **ForwardGroup** to forward requests to multiple vServer groups.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// Specifies whether to perform only a dry run, without performing the actual request. Valid values:
        /// 
        /// *   **true**: performs only a dry run. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and service limits. If the request fails the dry run, an error code is returned. If the request passes the dry run, the `DryRunOperation` error code is returned.
        /// *   **false** (default): performs a dry run and performs the actual request. If the request passes the dry run, a 2xx HTTP status code is returned and the operation is performed.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// Specifies whether to enable `GZIP` compression to compress specific types of files. Valid values:
        /// 
        /// *   **true** (default)
        /// *   **false**
        /// </summary>
        [NameInMap("GzipEnabled")]
        [Validation(Required=false)]
        public bool? GzipEnabled { get; set; }

        /// <summary>
        /// Specifies whether to enable `HTTP/2`. Valid values:
        /// 
        /// *   **true** (default)
        /// *   **false**
        /// 
        /// > This parameter is available only when you create an HTTPS listener.
        /// </summary>
        [NameInMap("Http2Enabled")]
        [Validation(Required=false)]
        public bool? Http2Enabled { get; set; }

        /// <summary>
        /// The timeout period of an idle connection. Unit: seconds.
        /// 
        /// Valid values: **1 to 60**.
        /// 
        /// Default value: **15**.
        /// 
        /// If no requests are received within the specified timeout period, ALB closes the current connection. When a new request is received, ALB establishes a new connection.
        /// </summary>
        [NameInMap("IdleTimeout")]
        [Validation(Required=false)]
        public int? IdleTimeout { get; set; }

        /// <summary>
        /// The name of the listener.
        /// 
        /// The description must be 2 to 256 characters in length, and can contain letters, digits, hyphens (-), forward slashes (/), periods (.), and underscores (\_). Regular expressions are supported.
        /// </summary>
        [NameInMap("ListenerDescription")]
        [Validation(Required=false)]
        public string ListenerDescription { get; set; }

        /// <summary>
        /// The frontend port that is used by the ALB instance.
        /// 
        /// Valid values: **1 to 65535**.
        /// </summary>
        [NameInMap("ListenerPort")]
        [Validation(Required=false)]
        public int? ListenerPort { get; set; }

        /// <summary>
        /// The listener protocol.
        /// 
        /// Valid values: **HTTP**, **HTTPS**, and **QUIC**.
        /// </summary>
        [NameInMap("ListenerProtocol")]
        [Validation(Required=false)]
        public string ListenerProtocol { get; set; }

        /// <summary>
        /// The ALB instance ID.
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// Selects a QUIC listener and associates it with the HTTPS listener of the ALB instance.
        /// </summary>
        [NameInMap("QuicConfig")]
        [Validation(Required=false)]
        public CreateListenerRequestQuicConfig QuicConfig { get; set; }
        public class CreateListenerRequestQuicConfig : TeaModel {
            /// <summary>
            /// The ID of the QUIC listener that you want to associate with the HTTPS listener. Only HTTPS listeners support this parameter. This parameter is required when **QuicUpgradeEnabled** is set to **true**.
            /// 
            /// > You must add the HTTPS listener and the QUIC listener to the same ALB instance. In addition, make sure that the QUIC listener has never been associated with another listener.
            /// </summary>
            [NameInMap("QuicListenerId")]
            [Validation(Required=false)]
            public string QuicListenerId { get; set; }

            /// <summary>
            /// Specifies whether to enable QUIC upgrade. Valid values:
            /// 
            /// *   **true**
            /// *   **false** (default)
            /// 
            /// > This parameter is available only when you create an HTTPS listener.
            /// </summary>
            [NameInMap("QuicUpgradeEnabled")]
            [Validation(Required=false)]
            public bool? QuicUpgradeEnabled { get; set; }

        }

        /// <summary>
        /// The timeout period of a request. Unit: seconds.
        /// 
        /// Valid values: **1 to 180**.
        /// 
        /// Default value: **60**.
        /// 
        /// If no response is received from the backend server during the request timeout period, ALB sends an `HTTP 504` error code to the client.
        /// </summary>
        [NameInMap("RequestTimeout")]
        [Validation(Required=false)]
        public int? RequestTimeout { get; set; }

        /// <summary>
        /// The ID of the security policy. System and custom security policies are supported.
        /// 
        /// Default value: **tls_cipher_policy\_1\_0** (system security policy).
        /// 
        /// > This parameter is available only when you create an HTTPS listener.
        /// </summary>
        [NameInMap("SecurityPolicyId")]
        [Validation(Required=false)]
        public string SecurityPolicyId { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateListenerRequestTag> Tag { get; set; }
        public class CreateListenerRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The configuration of the XForward header.
        /// </summary>
        [NameInMap("XForwardedForConfig")]
        [Validation(Required=false)]
        public CreateListenerRequestXForwardedForConfig XForwardedForConfig { get; set; }
        public class CreateListenerRequestXForwardedForConfig : TeaModel {
            /// <summary>
            /// The name of the custom header. This parameter takes effect only when **XForwardedForClientCertClientVerifyEnabled** is set to **true**.
            /// 
            /// The name must be 1 to 40 characters in length, and can contain letters, hyphens (-), underscores (\_), and digits.
            /// 
            /// > This parameter is available only when you create an HTTPS listener.
            /// </summary>
            [NameInMap("XForwardedForClientCertClientVerifyAlias")]
            [Validation(Required=false)]
            public string XForwardedForClientCertClientVerifyAlias { get; set; }

            /// <summary>
            /// Specifies whether to use the `X-Forwarded-Clientcert-clientverify` header to retrieve the verification result of the client certificate. Valid values:
            /// 
            /// *   **true**
            /// *   **false** (default)
            /// 
            /// > This parameter is available only when you create an HTTPS listener.
            /// </summary>
            [NameInMap("XForwardedForClientCertClientVerifyEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForClientCertClientVerifyEnabled { get; set; }

            /// <summary>
            /// The name of the custom header. This parameter takes effect only when **XForwardedForClientCertFingerprintEnabled** is set to **true**.
            /// 
            /// The name must be 1 to 40 characters in length, and can contain letters, hyphens (-), underscores (\_), and digits.
            /// 
            /// > This parameter is available only when you create an HTTPS listener.
            /// </summary>
            [NameInMap("XForwardedForClientCertFingerprintAlias")]
            [Validation(Required=false)]
            public string XForwardedForClientCertFingerprintAlias { get; set; }

            /// <summary>
            /// Specifies whether to use the `X-Forwarded-Clientcert-fingerprint` header to retrieve the fingerprint of the client certificate. Valid values:
            /// 
            /// *   **true**
            /// *   **false** (default)
            /// 
            /// > This parameter is available only when you create an HTTPS listener.
            /// </summary>
            [NameInMap("XForwardedForClientCertFingerprintEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForClientCertFingerprintEnabled { get; set; }

            /// <summary>
            /// The name of the custom header. This parameter takes effect only when **XForwardedForClientCertIssuerDNEnabled** is set to **true**.
            /// 
            /// The name must be 1 to 40 characters in length, and can contain letters, hyphens (-), underscores (\_), and digits.
            /// 
            /// > This parameter is available only when you create an HTTPS listener.
            /// </summary>
            [NameInMap("XForwardedForClientCertIssuerDNAlias")]
            [Validation(Required=false)]
            public string XForwardedForClientCertIssuerDNAlias { get; set; }

            /// <summary>
            /// Specifies whether to use the `X-Forwarded-Clientcert-issuerdn` header to retrieve information about the authority that issues the client certificate. Valid values:
            /// 
            /// *   **true**
            /// *   **false** (default)
            /// 
            /// > This parameter is available only when you create an HTTPS listener.
            /// </summary>
            [NameInMap("XForwardedForClientCertIssuerDNEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForClientCertIssuerDNEnabled { get; set; }

            /// <summary>
            /// The name of the custom header. This parameter takes effect only when **XForwardedForClientCertSubjectDNEnabled** is set to **true**.
            /// 
            /// The name must be 1 to 40 characters in length, and can contain letters, hyphens (-), underscores (\_), and digits.
            /// 
            /// > This parameter is available only when you create an HTTPS listener.
            /// </summary>
            [NameInMap("XForwardedForClientCertSubjectDNAlias")]
            [Validation(Required=false)]
            public string XForwardedForClientCertSubjectDNAlias { get; set; }

            /// <summary>
            /// Specifies whether to use the `X-Forwarded-Clientcert-subjectdn` header to retrieve information about the owner of the client certificate. Valid values:
            /// 
            /// *   **true**
            /// *   **false** (default)
            /// 
            /// > This parameter is available only when you create an HTTPS listener.
            /// </summary>
            [NameInMap("XForwardedForClientCertSubjectDNEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForClientCertSubjectDNEnabled { get; set; }

            /// <summary>
            /// Specifies whether to use the `X-Forwarded-Client-Ip` header to obtain the source IP address of the ALB instance. Valid values:
            /// 
            /// *   **true**
            /// *   **false** (default)
            /// 
            /// > This parameter is available only when you create an HTTP, HTTPS, or QUIC listener. The feature specified by this parameter is unavailable by default. To use the feature, contact your account manager.
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
            /// Specifies whether to use the `X-Forwarded-Client-Port` header to retrieve the client port. Valid values:
            /// 
            /// *   **true**
            /// *   **false** (default)
            /// 
            /// > This parameter is available only when you create an HTTP or HTTPS listener.
            /// </summary>
            [NameInMap("XForwardedForClientSrcPortEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForClientSrcPortEnabled { get; set; }

            /// <summary>
            /// Specifies whether to use the `X-Forwarded-For` header to retrieve client IP addresses. Valid values:
            /// 
            /// *   **true** (default)
            /// *   **false**
            /// 
            /// > This parameter is available only when you create an HTTP or HTTPS listener.
            /// </summary>
            [NameInMap("XForwardedForEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForEnabled { get; set; }

            /// <summary>
            /// Specifies whether to use the `X-Forwarded-Proto` header to retrieve the listener protocol. Valid values:
            /// 
            /// *   **true**
            /// *   **false** (default)
            /// 
            /// > This parameter is available only when you create an HTTP, HTTPS, or QUIC listener.
            /// </summary>
            [NameInMap("XForwardedForProtoEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForProtoEnabled { get; set; }

            /// <summary>
            /// Specifies whether to use the `SLB-ID` header to retrieve the ID of the CLB instance. Valid values:
            /// 
            /// *   **true**
            /// *   **false** (default)
            /// 
            /// > This parameter is available only when you create an HTTP, HTTPS, or QUIC listener.
            /// </summary>
            [NameInMap("XForwardedForSLBIdEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForSLBIdEnabled { get; set; }

            /// <summary>
            /// Specifies whether to use the `X-Forwarded-Port` header to retrieve the listener port of the ALB instance. Valid values:
            /// 
            /// *   **true**
            /// *   **false** (default)
            /// 
            /// > This parameter is available only when you create an HTTP, HTTPS, or QUIC listener.
            /// </summary>
            [NameInMap("XForwardedForSLBPortEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForSLBPortEnabled { get; set; }

        }

    }

}
