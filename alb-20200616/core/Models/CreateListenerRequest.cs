// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class CreateListenerRequest : TeaModel {
        [NameInMap("CaCertificates")]
        [Validation(Required=false)]
        public List<CreateListenerRequestCaCertificates> CaCertificates { get; set; }
        public class CreateListenerRequestCaCertificates : TeaModel {
            [NameInMap("CertificateId")]
            [Validation(Required=false)]
            public string CertificateId { get; set; }

        }

        /// <summary>
        /// Specifies whether to enable mutual authentication. Valid values:
        /// 
        /// *   **true**: enables mutual authentication.
        /// *   **false** (default): disables mutual authentication.
        /// </summary>
        [NameInMap("CaEnabled")]
        [Validation(Required=false)]
        public bool? CaEnabled { get; set; }

        [NameInMap("Certificates")]
        [Validation(Required=false)]
        public List<CreateListenerRequestCertificates> Certificates { get; set; }
        public class CreateListenerRequestCertificates : TeaModel {
            /// <summary>
            /// The ID of the certificate. Only server certificates are supported. You can specify up to 20 certificate IDs.
            /// </summary>
            [NameInMap("CertificateId")]
            [Validation(Required=false)]
            public string CertificateId { get; set; }

        }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the value, but you must make sure that it is unique among all requests. The token can contain only ASCII characters.
        /// 
        /// >  If you do not set this parameter, the system automatically uses the value of **RequestId** as the value of **ClientToken**. **RequestId** may be different for each API request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("DefaultActions")]
        [Validation(Required=false)]
        public List<CreateListenerRequestDefaultActions> DefaultActions { get; set; }
        public class CreateListenerRequestDefaultActions : TeaModel {
            [NameInMap("ForwardGroupConfig")]
            [Validation(Required=false)]
            public CreateListenerRequestDefaultActionsForwardGroupConfig ForwardGroupConfig { get; set; }
            public class CreateListenerRequestDefaultActionsForwardGroupConfig : TeaModel {
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
            /// The action type. You can specify only one action type. Valid value:
            /// 
            /// **ForwardGroup**: forwards requests to multiple vServer groups.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// Specifies whether to perform only a precheck. Valid values:
        /// 
        /// *   **true**: prechecks the request without creating a listener. The system checks the required parameters, request syntax, and limits. If the request fails the precheck, an error code is returned based on the cause of the failure. If the request passes the precheck, the `DryRunOperation` error code is returned.
        /// *   **false** (default): sends the API request. If the request passes the precheck, a 2xx HTTP status code is returned and the system proceeds to create a listener.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// Specifies whether to enable `Gzip` compression to compress specific types of files. Valid values:
        /// 
        /// *   **true** (default): enables Gzip compression.
        /// *   **false**: disables Gzip compression.
        /// </summary>
        [NameInMap("GzipEnabled")]
        [Validation(Required=false)]
        public bool? GzipEnabled { get; set; }

        /// <summary>
        /// Specifies whether to enable `HTTP/2`. Valid values:
        /// 
        /// *   **true** (default): enables HTTP/2.
        /// *   **false**: disables HTTP/2.
        /// 
        /// >  Only HTTPS listeners support this parameter.
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
        /// The ID of the ALB instance.
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        [NameInMap("QuicConfig")]
        [Validation(Required=false)]
        public CreateListenerRequestQuicConfig QuicConfig { get; set; }
        public class CreateListenerRequestQuicConfig : TeaModel {
            /// <summary>
            /// The ID of the QUIC listener that you want to associate with the HTTPS listener. Only HTTPS listeners support this parameter. This parameter is required when **QuicUpgradeEnabled** is set to **true**.
            /// 
            /// >  The HTTPS listener and the QUIC listener must be added to the same ALB instance. Make sure that the QUIC listener is not associated with any other listeners.
            /// </summary>
            [NameInMap("QuicListenerId")]
            [Validation(Required=false)]
            public string QuicListenerId { get; set; }

            /// <summary>
            /// Specifies whether to enable QUIC upgrade. Valid values:
            /// 
            /// *   **true**: enables QUIC upgrade.
            /// *   **false** (default): disables QUIC upgrade.
            /// 
            /// >  Only HTTPS listeners support this parameter.
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
        /// The ID of the security policy. System security policies and custom security policies are supported.
        /// 
        /// Default value: **tls_cipher_policy\_1\_0** (system security policy).
        /// 
        /// >  Only HTTPS listeners support this parameter.
        /// </summary>
        [NameInMap("SecurityPolicyId")]
        [Validation(Required=false)]
        public string SecurityPolicyId { get; set; }

        /// <summary>
        /// The tags.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateListenerRequestTag> Tag { get; set; }
        public class CreateListenerRequestTag : TeaModel {
            /// <summary>
            /// The tag key. The tag key can be up to 128 characters in length and cannot start with `acs:` or `aliyun`. It cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value. The tag value can be up to 128 characters in length and cannot start with `acs:` or `aliyun`. It cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("XForwardedForConfig")]
        [Validation(Required=false)]
        public CreateListenerRequestXForwardedForConfig XForwardedForConfig { get; set; }
        public class CreateListenerRequestXForwardedForConfig : TeaModel {
            /// <summary>
            /// The name of the custom header. This parameter takes effect only when **XForwardedForClientCertClientVerifyEnabled** is set to **true**.
            /// 
            /// The name must be 1 to 40 characters in length, and can contain lowercase letters, hyphens (-), underscores (\_), and digits.
            /// 
            /// >  Only HTTPS listeners support this parameter.
            /// </summary>
            [NameInMap("XForwardedForClientCertClientVerifyAlias")]
            [Validation(Required=false)]
            public string XForwardedForClientCertClientVerifyAlias { get; set; }

            /// <summary>
            /// Specifies whether to use the `X-Forwarded-Clientcert-clientverify` header to retrieve the verification result of the client certificate. Valid values:
            /// 
            /// *   **true**: uses the X-Forwarded-Clientcert-clientverify header.
            /// *   **false** (default): does not use the X-Forwarded-Clientcert-clientverify header.
            /// 
            /// >  Only HTTPS listeners support this parameter.
            /// </summary>
            [NameInMap("XForwardedForClientCertClientVerifyEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForClientCertClientVerifyEnabled { get; set; }

            /// <summary>
            /// The name of the custom header. This parameter takes effect only when **XForwardedForClientCertFingerprintEnabled** is set to **true**.
            /// 
            /// The name must be 1 to 40 characters in length, and can contain lowercase letters, hyphens (-), underscores (\_), and digits.
            /// 
            /// >  Only HTTPS listeners support this parameter.
            /// </summary>
            [NameInMap("XForwardedForClientCertFingerprintAlias")]
            [Validation(Required=false)]
            public string XForwardedForClientCertFingerprintAlias { get; set; }

            /// <summary>
            /// Specifies whether to use the `X-Forwarded-Clientcert-fingerprint` header to retrieve the fingerprint of the client certificate. Valid values:
            /// 
            /// *   **true**: uses the X-Forwarded-Clientcert-fingerprint header.
            /// *   **false** (default): does not use the X-Forwarded-Clientcert-fingerprint header.
            /// 
            /// >  Only HTTPS listeners support this parameter.
            /// </summary>
            [NameInMap("XForwardedForClientCertFingerprintEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForClientCertFingerprintEnabled { get; set; }

            /// <summary>
            /// The name of the custom header. This parameter takes effect only when **XForwardedForClientCertIssuerDNEnabled** is set to **true**.
            /// 
            /// The name must be 1 to 40 characters in length, and can contain lowercase letters, hyphens (-), underscores (\_), and digits.
            /// 
            /// >  Only HTTPS listeners support this parameter.
            /// </summary>
            [NameInMap("XForwardedForClientCertIssuerDNAlias")]
            [Validation(Required=false)]
            public string XForwardedForClientCertIssuerDNAlias { get; set; }

            /// <summary>
            /// Specifies whether to use the `X-Forwarded-Clientcert-issuerdn` header to retrieve information about the authority that issues the client certificate. Valid values:
            /// 
            /// *   **true**: uses the X-Forwarded-Clientcert-issuerdn header.
            /// *   **false** (default): does not use the X-Forwarded-Clientcert-issuerdn header.
            /// 
            /// >  Only HTTPS listeners support this parameter.
            /// </summary>
            [NameInMap("XForwardedForClientCertIssuerDNEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForClientCertIssuerDNEnabled { get; set; }

            /// <summary>
            /// The name of the custom header. This parameter takes effect only when **XForwardedForClientCertSubjectDNEnabled** is set to **true**.
            /// 
            /// The name must be 1 to 40 characters in length, and can contain lowercase letters, hyphens (-), underscores (\_), and digits.
            /// 
            /// >  Only HTTPS listeners support this parameter.
            /// </summary>
            [NameInMap("XForwardedForClientCertSubjectDNAlias")]
            [Validation(Required=false)]
            public string XForwardedForClientCertSubjectDNAlias { get; set; }

            /// <summary>
            /// Specifies whether to use the `X-Forwarded-Clientcert-subjectdn` header to retrieve information about the owner of the client certificate. Valid values:
            /// 
            /// *   **true**: uses the X-Forwarded-Clientcert-subjectdn header.
            /// *   **false** (default): does not use the X-Forwarded-Clientcert-subjectdn header.
            /// 
            /// >  Only HTTPS listeners support this parameter.
            /// </summary>
            [NameInMap("XForwardedForClientCertSubjectDNEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForClientCertSubjectDNEnabled { get; set; }

            /// <summary>
            /// Specifies whether to use the `X-Forwarded-Client-Ip` header to obtain the source IP address of the ALB instance. Valid values:
            /// 
            /// *   **true**: uses the X-Forwarded-Client-Ip header.
            /// *   **false** (default): does not use the X-Forwarded-Client-Ip header.
            /// 
            /// >  HTTP, HTTPS, and QUIC listeners support this parameter. The feature corresponding to this parameter is not available by default. If you want to use this feature, submit a ticket.
            /// </summary>
            [NameInMap("XForwardedForClientSourceIpsEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForClientSourceIpsEnabled { get; set; }

            /// <summary>
            /// The trusted proxy IP address.
            /// 
            /// ALB traverses `X-Forwarded-For` backwards and selects the first IP address that is not in the trusted IP list as the originating IP address of the client, which will be throttled if source IP address throttling is enabled.
            /// </summary>
            [NameInMap("XForwardedForClientSourceIpsTrusted")]
            [Validation(Required=false)]
            public string XForwardedForClientSourceIpsTrusted { get; set; }

            /// <summary>
            /// Specifies whether to use the `X-Forwarded-Client-Port` header to retrieve the client port. Valid values:
            /// 
            /// *   **true**: uses the X-Forwarded-Client-Port header.
            /// *   **false** (default): does not use the X-Forwarded-Client-Port header.
            /// 
            /// >  HTTP and HTTPS listeners support this parameter.
            /// </summary>
            [NameInMap("XForwardedForClientSrcPortEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForClientSrcPortEnabled { get; set; }

            /// <summary>
            /// Specifies whether to use the `X-Forwarded-For` header to retrieve client IP addresses. Valid values:
            /// 
            /// *   **true** (default): uses the X-Forwarded-For header.
            /// *   **false**: does not use the X-Forwarded-For header.
            /// 
            /// >  HTTP and HTTPS listeners support this parameter.
            /// </summary>
            [NameInMap("XForwardedForEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForEnabled { get; set; }

            /// <summary>
            /// Specifies whether to use the `X-Forwarded-Proto` header to retrieve the listening protocol of the ALB instance. Valid values:
            /// 
            /// *   **true**: uses the X-Forwarded-Proto header.
            /// *   **false** (default): does not use the X-Forwarded-Proto header.
            /// 
            /// >  HTTP, HTTPS, and QUIC listeners support this parameter.
            /// </summary>
            [NameInMap("XForwardedForProtoEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForProtoEnabled { get; set; }

            /// <summary>
            /// Specifies whether to use the `SLB-ID` header to retrieve the ID of the ALB instance. Valid values:
            /// 
            /// *   **true**: uses the SLB-ID header.
            /// *   **false** (default): does not use the SLB-ID header.
            /// 
            /// >  HTTP, HTTPS, and QUIC listeners support this parameter.
            /// </summary>
            [NameInMap("XForwardedForSLBIdEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForSLBIdEnabled { get; set; }

            /// <summary>
            /// Specifies whether to use the `X-Forwarded-Port` header to retrieve the listening port of the ALB instance. Valid values:
            /// 
            /// *   **true**: uses the X-Forwarded-Port header.
            /// *   **false** (default): does not use the X-Forwarded-Port header.
            /// 
            /// >  HTTP, HTTPS, and QUIC listeners support this parameter.
            /// </summary>
            [NameInMap("XForwardedForSLBPortEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForSLBPortEnabled { get; set; }

        }

    }

}
