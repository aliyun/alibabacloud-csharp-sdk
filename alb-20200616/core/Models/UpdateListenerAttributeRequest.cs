// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class UpdateListenerAttributeRequest : TeaModel {
        /// <summary>
        /// The information about the CA certificate.
        /// </summary>
        [NameInMap("CaCertificates")]
        [Validation(Required=false)]
        public List<UpdateListenerAttributeRequestCaCertificates> CaCertificates { get; set; }
        public class UpdateListenerAttributeRequestCaCertificates : TeaModel {
            /// <summary>
            /// The ID of the CA certificate. You can specify only one CA certificate.
            /// 
            /// >  This parameter is required if **CaEnabled** is set to **true**.
            /// </summary>
            [NameInMap("CertificateId")]
            [Validation(Required=false)]
            public string CertificateId { get; set; }

        }

        /// <summary>
        /// Specifies whether to enable mutual authentication. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("CaEnabled")]
        [Validation(Required=false)]
        public bool? CaEnabled { get; set; }

        /// <summary>
        /// The details about the certificates.
        /// </summary>
        [NameInMap("Certificates")]
        [Validation(Required=false)]
        public List<UpdateListenerAttributeRequestCertificates> Certificates { get; set; }
        public class UpdateListenerAttributeRequestCertificates : TeaModel {
            /// <summary>
            /// The ID of the certificate. Only server certificates are supported. You can specify at most 20 certificate IDs.
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
        /// >  If you do not specify this parameter, the system automatically uses the **request ID** as the **client token**. The **request ID** may be different for each request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The actions of the default forwarding rule.
        /// </summary>
        [NameInMap("DefaultActions")]
        [Validation(Required=false)]
        public List<UpdateListenerAttributeRequestDefaultActions> DefaultActions { get; set; }
        public class UpdateListenerAttributeRequestDefaultActions : TeaModel {
            /// <summary>
            /// The forwarding action. This parameter takes effect only when you set **Type** to **ForwardGroup**. You can specify at most 20 actions.
            /// </summary>
            [NameInMap("ForwardGroupConfig")]
            [Validation(Required=false)]
            public UpdateListenerAttributeRequestDefaultActionsForwardGroupConfig ForwardGroupConfig { get; set; }
            public class UpdateListenerAttributeRequestDefaultActionsForwardGroupConfig : TeaModel {
                /// <summary>
                /// The server groups to which requests are forwarded.
                /// 
                /// This parameter is required.
                /// </summary>
                [NameInMap("ServerGroupTuples")]
                [Validation(Required=false)]
                public List<UpdateListenerAttributeRequestDefaultActionsForwardGroupConfigServerGroupTuples> ServerGroupTuples { get; set; }
                public class UpdateListenerAttributeRequestDefaultActionsForwardGroupConfigServerGroupTuples : TeaModel {
                    /// <summary>
                    /// The ID of the server group to which requests are forwarded.
                    /// 
                    /// This parameter is required.
                    /// </summary>
                    [NameInMap("ServerGroupId")]
                    [Validation(Required=false)]
                    public string ServerGroupId { get; set; }

                }

            }

            /// <summary>
            /// The action type. You can specify only one type.
            /// 
            /// Set the value to **ForwardGroup**, which specifies that requests are forwarded to multiple server groups.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// Specifies whether to perform only a dry run, without performing the actual request. Valid values:
        /// 
        /// *   **true**: performs only a dry run. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and service limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the `DryRunOperation` error code is returned.
        /// *   **false** (default): performs a dry run and performs the actual request. If the request passes the dry run, a `2xx HTTP` status code is returned and the operation is performed.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// Specifies whether to enable GZIP compression for specific types of files. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("GzipEnabled")]
        [Validation(Required=false)]
        public bool? GzipEnabled { get; set; }

        /// <summary>
        /// Specifies whether to enable HTTP/2. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// 
        /// > This parameter is available only when you create an HTTPS listener.
        /// </summary>
        [NameInMap("Http2Enabled")]
        [Validation(Required=false)]
        public bool? Http2Enabled { get; set; }

        /// <summary>
        /// The timeout period of an idle connection. Unit: seconds. Valid values: **1 to 60**.
        /// 
        /// If no request is received within the specified timeout period, ALB closes the current connection. When another request is received, ALB establishes a new connection.
        /// </summary>
        [NameInMap("IdleTimeout")]
        [Validation(Required=false)]
        public int? IdleTimeout { get; set; }

        /// <summary>
        /// The name of the listener.
        /// 
        /// The name must be 2 to 256 characters in length, and can contain letters, digits, and the following special characters: , . ; / @ _ -.
        /// </summary>
        [NameInMap("ListenerDescription")]
        [Validation(Required=false)]
        public string ListenerDescription { get; set; }

        /// <summary>
        /// The ID of the Application Load Balancer (ALB) instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        /// <summary>
        /// The configuration information when the listener is associated with a QUIC listener.
        /// </summary>
        [NameInMap("QuicConfig")]
        [Validation(Required=false)]
        public UpdateListenerAttributeRequestQuicConfig QuicConfig { get; set; }
        public class UpdateListenerAttributeRequestQuicConfig : TeaModel {
            /// <summary>
            /// The QUIC listener ID. This parameter is required if **QuicUpgradeEnabled** is set to **true**. Only HTTPS listeners support this parameter.
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
            /// *   **false**
            /// 
            /// > Only HTTPS listeners support this parameter.
            /// </summary>
            [NameInMap("QuicUpgradeEnabled")]
            [Validation(Required=false)]
            public bool? QuicUpgradeEnabled { get; set; }

        }

        /// <summary>
        /// The timeout period of a request. Unit: seconds. Valid values: **1 to 180**.
        /// 
        /// If no response is received from the backend server within the specified timeout period, ALB returns an `HTTP 504` error code to the client.
        /// </summary>
        [NameInMap("RequestTimeout")]
        [Validation(Required=false)]
        public int? RequestTimeout { get; set; }

        /// <summary>
        /// The security policy ID. System security policies and custom security policies are supported.
        /// 
        /// > This parameter is available only when you create an HTTPS listener.
        /// </summary>
        [NameInMap("SecurityPolicyId")]
        [Validation(Required=false)]
        public string SecurityPolicyId { get; set; }

        /// <summary>
        /// The configurations of the X-Forwarded-For header.
        /// </summary>
        [NameInMap("XForwardedForConfig")]
        [Validation(Required=false)]
        public UpdateListenerAttributeRequestXForwardedForConfig XForwardedForConfig { get; set; }
        public class UpdateListenerAttributeRequestXForwardedForConfig : TeaModel {
            /// <summary>
            /// The name of the custom header. The header takes effect only when you set **XForwardedForClientCertClientVerifyEnabled** to **true**.
            /// 
            /// The name must be 1 to 40 characters in length. The name can contain lowercase letters, digits, hyphens (-), and underscores (-).
            /// 
            /// >  Only HTTPS listeners support this parameter.
            /// </summary>
            [NameInMap("XForwardedForClientCertClientVerifyAlias")]
            [Validation(Required=false)]
            public string XForwardedForClientCertClientVerifyAlias { get; set; }

            /// <summary>
            /// Specifies whether to use the `X-Forwarded-Clientcert-clientverify` header to retrieve the verification result of the client certificate. Valid values:
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
            /// The name of the custom header. The header takes effect only when you set **XForwardedForClientCertFingerprintEnabled** to **true**.
            /// 
            /// The name must be 1 to 40 characters in length. The name can contain lowercase letters, digits, hyphens (-), and underscores (-).
            /// 
            /// >  Only HTTPS listeners support this parameter.
            /// </summary>
            [NameInMap("XForwardedForClientCertFingerprintAlias")]
            [Validation(Required=false)]
            public string XForwardedForClientCertFingerprintAlias { get; set; }

            /// <summary>
            /// Specifies whether to use the `X-Forwarded-Clientcert-fingerprint` header to retrieve the fingerprint of the client certificate. Valid values:
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
            /// The name of the custom header. The header takes effect only when you set **XForwardedForClientCertIssuerDNEnabled** to **true**.
            /// 
            /// The name must be 1 to 40 characters in length. The name can contain lowercase letters, digits, hyphens (-), and underscores (-).
            /// 
            /// >  Only HTTPS listeners support this parameter.
            /// </summary>
            [NameInMap("XForwardedForClientCertIssuerDNAlias")]
            [Validation(Required=false)]
            public string XForwardedForClientCertIssuerDNAlias { get; set; }

            /// <summary>
            /// Specifies whether to use the `X-Forwarded-Clientcert-issuerdn` header to retrieve information about the authority that issues the client certificate. Valid values:
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
            /// The name of the custom header. This parameter is valid only if the **XForwardedForClientCertSubjectDNEnabled** parameter is set to true.****
            /// 
            /// The name must be 1 to 40 characters in length, The name can contain lowercase letters, digits, hyphens (-), and underscores (-).
            /// 
            /// >  Only HTTPS listeners support this parameter.
            /// </summary>
            [NameInMap("XForwardedForClientCertSubjectDNAlias")]
            [Validation(Required=false)]
            public string XForwardedForClientCertSubjectDNAlias { get; set; }

            /// <summary>
            /// Specifies whether to use the `X-Forwarded-Clientcert-subjectdn` header to retrieve information about the owner of the client certificate. Valid values:
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
            /// Specifies whether to use the X-Forwarded-For header to preserve client IP addresses. Valid values:
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
            /// Specifies whether to use the `X-Forwarded-Client-Port` header to retrieve the client port. Valid values:
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
            /// Specifies whether to use the `X-Forwarded-Proto` header to retrieve the listener protocol. Valid values:
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
            /// Specifies whether to use the `X-Forwarded-Port` header to retrieve the listener port of the ALB instance. Valid values:
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

}
