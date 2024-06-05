// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class GetListenerAttributeResponseBody : TeaModel {
        /// <summary>
        /// The configurations of the access control lists (ACLs).
        /// </summary>
        [NameInMap("AclConfig")]
        [Validation(Required=false)]
        public GetListenerAttributeResponseBodyAclConfig AclConfig { get; set; }
        public class GetListenerAttributeResponseBodyAclConfig : TeaModel {
            /// <summary>
            /// The IDs of the ACLs that are associated with the listener.
            /// </summary>
            [NameInMap("AclRelations")]
            [Validation(Required=false)]
            public List<GetListenerAttributeResponseBodyAclConfigAclRelations> AclRelations { get; set; }
            public class GetListenerAttributeResponseBodyAclConfigAclRelations : TeaModel {
                /// <summary>
                /// The ID of the ACL that is associated with the listener.
                /// </summary>
                [NameInMap("AclId")]
                [Validation(Required=false)]
                public string AclId { get; set; }

                /// <summary>
                /// Indicates whether the ACL is associated with the listener. Valid values:
                /// 
                /// *   **Associating**
                /// *   **Associated**
                /// *   **Dissociating**
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// The type of the ACL. Valid values:
            /// 
            /// *   **White**: a whitelist. Only requests from the IP addresses or CIDR blocks in the network ACL are forwarded. Whitelists are applicable to scenarios in which you want to allow only specific IP addresses to access an application. Your service may be adversely affected if the whitelist is not properly configured. If a whitelist is configured for a listener, only requests from IP addresses that are on the whitelist are forwarded by the listener.
            /// 
            ///     If you enable a whitelist but do not add an IP address to the whitelist, the listener forwards all requests.
            /// 
            /// *   **Black**: a blacklist. Requests from the IP addresses or CIDR blocks in the network ACL are denied. Blacklists are suitable for scenarios in which you want to deny access from specific IP addresses or CIDR blocks to an application.
            /// 
            ///     If a blacklist is configured for a listener but no IP addresses are added to the blacklist, the listener forwards all requests.
            /// </summary>
            [NameInMap("AclType")]
            [Validation(Required=false)]
            public string AclType { get; set; }

        }

        /// <summary>
        /// A list of default CA certificates.
        /// </summary>
        [NameInMap("CaCertificates")]
        [Validation(Required=false)]
        public List<GetListenerAttributeResponseBodyCaCertificates> CaCertificates { get; set; }
        public class GetListenerAttributeResponseBodyCaCertificates : TeaModel {
            /// <summary>
            /// The ID of the default CA certificate.
            /// </summary>
            [NameInMap("CertificateId")]
            [Validation(Required=false)]
            public string CertificateId { get; set; }

            /// <summary>
            /// Indicates whether the certificate is a default certificate: Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

            /// <summary>
            /// The status of the certificate.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// Indicates whether mutual authentication is enabled. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("CaEnabled")]
        [Validation(Required=false)]
        public bool? CaEnabled { get; set; }

        /// <summary>
        /// A list of certificates.
        /// </summary>
        [NameInMap("Certificates")]
        [Validation(Required=false)]
        public List<GetListenerAttributeResponseBodyCertificates> Certificates { get; set; }
        public class GetListenerAttributeResponseBodyCertificates : TeaModel {
            /// <summary>
            /// The ID of the certificate. Only server certificates are supported.
            /// </summary>
            [NameInMap("CertificateId")]
            [Validation(Required=false)]
            public string CertificateId { get; set; }

        }

        /// <summary>
        /// The actions of the default forwarding rule.
        /// </summary>
        [NameInMap("DefaultActions")]
        [Validation(Required=false)]
        public List<GetListenerAttributeResponseBodyDefaultActions> DefaultActions { get; set; }
        public class GetListenerAttributeResponseBodyDefaultActions : TeaModel {
            /// <summary>
            /// The configuration of the ForwardGroup action. This parameter is returned and takes effect when Type is set to **ForwardGroup**.
            /// </summary>
            [NameInMap("ForwardGroupConfig")]
            [Validation(Required=false)]
            public GetListenerAttributeResponseBodyDefaultActionsForwardGroupConfig ForwardGroupConfig { get; set; }
            public class GetListenerAttributeResponseBodyDefaultActionsForwardGroupConfig : TeaModel {
                /// <summary>
                /// The server group to which requests are forwarded.
                /// </summary>
                [NameInMap("ServerGroupTuples")]
                [Validation(Required=false)]
                public List<GetListenerAttributeResponseBodyDefaultActionsForwardGroupConfigServerGroupTuples> ServerGroupTuples { get; set; }
                public class GetListenerAttributeResponseBodyDefaultActionsForwardGroupConfigServerGroupTuples : TeaModel {
                    /// <summary>
                    /// The ID of the server group to which requests are forwarded.
                    /// </summary>
                    [NameInMap("ServerGroupId")]
                    [Validation(Required=false)]
                    public string ServerGroupId { get; set; }

                }

            }

            /// <summary>
            /// The type of the action.
            /// 
            /// If **ForwardGroup** is returned, requests are forwarded to multiple vServer groups.
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
        /// > This parameter is available only when you create an HTTPS listener.
        /// </summary>
        [NameInMap("Http2Enabled")]
        [Validation(Required=false)]
        public bool? Http2Enabled { get; set; }

        /// <summary>
        /// The timeout period of an idle connection. Unit: seconds.
        /// 
        /// If no requests are received within the specified timeout period, Application Load Balancer (ALB) closes the current connection. When a request is received, ALB establishes a new connection.
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
        /// The frontend port that is used by the ALB instance.
        /// </summary>
        [NameInMap("ListenerPort")]
        [Validation(Required=false)]
        public int? ListenerPort { get; set; }

        /// <summary>
        /// The listener protocol. Valid values: **HTTP**, **HTTPS**, and **QUIC**.
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
        /// The ALB instance ID.
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// The logging configuration.
        /// </summary>
        [NameInMap("LogConfig")]
        [Validation(Required=false)]
        public GetListenerAttributeResponseBodyLogConfig LogConfig { get; set; }
        public class GetListenerAttributeResponseBodyLogConfig : TeaModel {
            /// <summary>
            /// Indicates whether custom headers are recorded in the access log. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("AccessLogRecordCustomizedHeadersEnabled")]
            [Validation(Required=false)]
            public bool? AccessLogRecordCustomizedHeadersEnabled { get; set; }

            /// <summary>
            /// The configuration of Xtrace. Xtrace is used to record requests sent to ALB.
            /// </summary>
            [NameInMap("AccessLogTracingConfig")]
            [Validation(Required=false)]
            public GetListenerAttributeResponseBodyLogConfigAccessLogTracingConfig AccessLogTracingConfig { get; set; }
            public class GetListenerAttributeResponseBodyLogConfigAccessLogTracingConfig : TeaModel {
                /// <summary>
                /// Indicates whether Xtrace is enabled. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// 
                /// > You can set this parameter to **true** only if the AccessLogEnabled parameter is set to true.
                /// </summary>
                [NameInMap("TracingEnabled")]
                [Validation(Required=false)]
                public bool? TracingEnabled { get; set; }

                /// <summary>
                /// The sampling rate of Xtrace. Valid values: 1 to 10000.
                /// 
                /// > If **TracingEnabled** is set to **true**, this parameter is valid.
                /// </summary>
                [NameInMap("TracingSample")]
                [Validation(Required=false)]
                public int? TracingSample { get; set; }

                /// <summary>
                /// The Xtrace type. Supported Xtrace type: **Zipkin**.
                /// 
                /// > If **TracingEnabled** is set to **true**, this parameter is valid.
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
        public GetListenerAttributeResponseBodyQuicConfig QuicConfig { get; set; }
        public class GetListenerAttributeResponseBodyQuicConfig : TeaModel {
            /// <summary>
            /// The ID of the QUIC listener. This parameter is returned when **QuicUpgradeEnabled** is set to **true**. Only HTTPS listeners support this parameter.
            /// 
            /// > You must associate the HTTPS listener and the QUIC listener with the same ALB instance. In addition, make sure that the QUIC listener has never been associated with another listener.
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
            /// > Only HTTPS listeners support this parameter.
            /// </summary>
            [NameInMap("QuicUpgradeEnabled")]
            [Validation(Required=false)]
            public bool? QuicUpgradeEnabled { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The timeout period of a request. Unit: seconds.
        /// 
        /// If no responses are received from the backend server within the specified timeout period, ALB returns an `HTTP 504` error code to the client.
        /// </summary>
        [NameInMap("RequestTimeout")]
        [Validation(Required=false)]
        public int? RequestTimeout { get; set; }

        /// <summary>
        /// The security policy.
        /// 
        /// > This parameter is available only when you create an HTTPS listener.
        /// </summary>
        [NameInMap("SecurityPolicyId")]
        [Validation(Required=false)]
        public string SecurityPolicyId { get; set; }

        /// <summary>
        /// The tags.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<GetListenerAttributeResponseBodyTags> Tags { get; set; }
        public class GetListenerAttributeResponseBodyTags : TeaModel {
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

        /// <summary>
        /// The configuration of the XForward headers.
        /// </summary>
        [NameInMap("XForwardedForConfig")]
        [Validation(Required=false)]
        public GetListenerAttributeResponseBodyXForwardedForConfig XForwardedForConfig { get; set; }
        public class GetListenerAttributeResponseBodyXForwardedForConfig : TeaModel {
            /// <summary>
            /// The name of the custom header. This parameter takes effect only when **XForwardedForClientCertClientVerifyEnabled** is set to **true**.
            /// 
            /// The name is 1 to 40 characters in length, and can contain lowercase letters, hyphens (-), underscores (_), and digits.
            /// 
            /// > This parameter is available only when you create an HTTPS listener.
            /// </summary>
            [NameInMap("XForwardedForClientCertClientVerifyAlias")]
            [Validation(Required=false)]
            public string XForwardedForClientCertClientVerifyAlias { get; set; }

            /// <summary>
            /// Indicates whether the `X-Forwarded-Clientcert-clientverify` header is used to retrieve the verification result of the client certificate. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// 
            /// > This parameter is available only when you create an HTTPS listener.
            /// </summary>
            [NameInMap("XForwardedForClientCertClientVerifyEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForClientCertClientVerifyEnabled { get; set; }

            /// <summary>
            /// The name of the custom header. This parameter takes effect only when **XForwardedForClientCertFingerprintEnabled** is set to **true**.
            /// 
            /// The name is 1 to 40 characters in length, and can contain lowercase letters, hyphens (-), underscores (_), and digits.
            /// 
            /// > This parameter is available only when you create an HTTPS listener.
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
            /// > This parameter is available only when you create an HTTPS listener.
            /// </summary>
            [NameInMap("XForwardedForClientCertFingerprintEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForClientCertFingerprintEnabled { get; set; }

            /// <summary>
            /// The name of the custom header. This parameter takes effect only when **XForwardedForClientCertIssuerDNEnabled** is set to **true**.
            /// 
            /// The name is 1 to 40 characters in length, and can contain lowercase letters, hyphens (-), underscores (_), and digits.
            /// 
            /// > This parameter is available only when you create an HTTPS listener.
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
            /// > This parameter is available only when you create an HTTPS listener.
            /// </summary>
            [NameInMap("XForwardedForClientCertIssuerDNEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForClientCertIssuerDNEnabled { get; set; }

            /// <summary>
            /// The name of the custom header. This parameter takes effect only when **XForwardedForClientCertSubjectDNEnabled** is set to **true**.
            /// 
            /// The name is 1 to 40 characters in length, and can contain lowercase letters, hyphens (-), underscores (_), and digits.
            /// 
            /// > This parameter is available only when you create an HTTPS listener.
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
            /// > This parameter is available only when you create an HTTPS listener.
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
            /// > This parameter is available only when you create an HTTP, HTTPS, or QUIC listener.
            /// </summary>
            [NameInMap("XForwardedForClientSourceIpsEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForClientSourceIpsEnabled { get; set; }

            /// <summary>
            /// The trusted proxy IP address.
            /// 
            /// ALB traverses `X-Forwarded-For` backward and selects the first IP address that is not on the trusted IP address list as the real IP address of the client. The IP address is used in source IP address throttling.
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
            /// > This parameter is available only when you create an HTTP or HTTPS listener.
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
            /// > This parameter is available only when you create an HTTP or HTTPS listener.
            /// </summary>
            [NameInMap("XForwardedForEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForEnabled { get; set; }

            /// <summary>
            /// Indicates whether the `X-Forwarded-Proto` header is used to retrieve the listening protocol. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// 
            /// > This parameter is available only when you create an HTTP, HTTPS, or QUIC listener.
            /// </summary>
            [NameInMap("XForwardedForProtoEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForProtoEnabled { get; set; }

            /// <summary>
            /// Indicates whether the `SLB-ID` header is used to retrieve the ID of the CLB instance. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// 
            /// > This parameter is available only when you create an HTTP, HTTPS, or QUIC listener.
            /// </summary>
            [NameInMap("XForwardedForSLBIdEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForSLBIdEnabled { get; set; }

            /// <summary>
            /// Indicates whether the `X-Forwarded-Port` header is used to retrieve the listening port of the ALB instance. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// 
            /// > This parameter is available only when you create an HTTP, HTTPS, or QUIC listener.
            /// </summary>
            [NameInMap("XForwardedForSLBPortEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForSLBPortEnabled { get; set; }

        }

    }

}
