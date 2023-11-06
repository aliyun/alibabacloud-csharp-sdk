// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class DescribeListenerResponseBody : TeaModel {
        /// <summary>
        /// The ID of the GA instance.
        /// </summary>
        [NameInMap("AcceleratorId")]
        [Validation(Required=false)]
        public string AcceleratorId { get; set; }

        /// <summary>
        /// The type of the ACL. Valid values:
        /// 
        /// *   **white**: a whitelist. Only requests from the IP addresses or CIDR blocks in the ACL are forwarded. Whitelists apply to scenarios in which you want to allow only specified IP addresses to access an application. Your service may be adversely affected if the whitelist is not properly configured. After you configure a whitelist for a listener, only requests from the IP addresses that are added to the whitelist are forwarded by the listener. If the whitelist is enabled but no IP addresses are added to the ACL, the listener does not forward requests.
        /// *   **black**: a blacklist. All requests from the IP addresses or CIDR blocks in the ACL are blocked. Blacklists apply to scenarios in which you want to deny access from specific IP addresses to an application. If the blacklist is enabled but no IP addresses are added to the ACL, the listener forwards all requests.
        /// 
        /// If the value of **Status** is **on**, this parameter is returned.
        /// </summary>
        [NameInMap("AclType")]
        [Validation(Required=false)]
        public string AclType { get; set; }

        /// <summary>
        /// Details about the backend ports.
        /// </summary>
        [NameInMap("BackendPorts")]
        [Validation(Required=false)]
        public List<DescribeListenerResponseBodyBackendPorts> BackendPorts { get; set; }
        public class DescribeListenerResponseBodyBackendPorts : TeaModel {
            /// <summary>
            /// The start port in the range of ports used by the backend server to receive requests.
            /// 
            /// This parameter is returned only when you configure an HTTPS listener and the listening port is the same port used by the backend server to provide services.
            /// </summary>
            [NameInMap("FromPort")]
            [Validation(Required=false)]
            public string FromPort { get; set; }

            /// <summary>
            /// The end port in the range of ports used by the backend server to receive requests.
            /// </summary>
            [NameInMap("ToPort")]
            [Validation(Required=false)]
            public string ToPort { get; set; }

        }

        /// <summary>
        /// The SSL certificates.
        /// </summary>
        [NameInMap("Certificates")]
        [Validation(Required=false)]
        public List<DescribeListenerResponseBodyCertificates> Certificates { get; set; }
        public class DescribeListenerResponseBodyCertificates : TeaModel {
            /// <summary>
            /// The ID of the SSL certificate.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The type of the certificate.
            /// 
            /// Only **Server** can be returned. This value Server indicates a server certificate.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// Indicates whether client affinity is enabled for the listener.
        /// 
        /// *   If **NONE** is returned, client affinity is disabled. In this case, requests from the same client may be forwarded to different endpoints.
        /// *   If **SOURCE_IP** is returned, client affinity is enabled. In this case, when a client accesses stateful applications, requests from the same client are always forwarded to the same endpoint regardless of the source port or protocol.
        /// </summary>
        [NameInMap("ClientAffinity")]
        [Validation(Required=false)]
        public string ClientAffinity { get; set; }

        /// <summary>
        /// The timestamp when the listener was created. Unit: milliseconds.
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// The description of the listener.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("IdleTimeout")]
        [Validation(Required=false)]
        public int? IdleTimeout { get; set; }

        /// <summary>
        /// The ID of the listener.
        /// </summary>
        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        /// <summary>
        /// The name of the listener.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// Details about the listener ports.
        /// </summary>
        [NameInMap("PortRanges")]
        [Validation(Required=false)]
        public List<DescribeListenerResponseBodyPortRanges> PortRanges { get; set; }
        public class DescribeListenerResponseBodyPortRanges : TeaModel {
            /// <summary>
            /// The start port in the range of listening ports used to receive and forward requests to endpoints.
            /// </summary>
            [NameInMap("FromPort")]
            [Validation(Required=false)]
            public int? FromPort { get; set; }

            /// <summary>
            /// The end port in the range of listening ports used to receive and forward requests to endpoints.
            /// </summary>
            [NameInMap("ToPort")]
            [Validation(Required=false)]
            public int? ToPort { get; set; }

        }

        /// <summary>
        /// The network transmission protocol that is used by the listener. Valid values:
        /// 
        /// *   **tcp**: TCP
        /// *   **udp**: UDP
        /// *   **http**: HTTP
        /// *   **https**: HTTPS
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// Indicates whether the client IP address preservation feature is enabled. Valid values:
        /// 
        /// *   **true**: The client IP address preservation feature is enabled. After client IP addresses are reserved, you can view the source IP addresses of clients over the backend service.
        /// *   **false**: The client IP address preservation feature is disabled.
        /// </summary>
        [NameInMap("ProxyProtocol")]
        [Validation(Required=false)]
        public bool? ProxyProtocol { get; set; }

        /// <summary>
        /// The information about the access control list (ACL) that is associated with the listener.
        /// </summary>
        [NameInMap("RelatedAcls")]
        [Validation(Required=false)]
        public List<DescribeListenerResponseBodyRelatedAcls> RelatedAcls { get; set; }
        public class DescribeListenerResponseBodyRelatedAcls : TeaModel {
            /// <summary>
            /// The ID of the ACL that is associated with the listener.
            /// </summary>
            [NameInMap("AclId")]
            [Validation(Required=false)]
            public string AclId { get; set; }

            /// <summary>
            /// Indicates whether the access control feature is enabled. Valid values:
            /// 
            /// *   **on**: enabled
            /// *   **off**: disabled
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RequestTimeout")]
        [Validation(Required=false)]
        public int? RequestTimeout { get; set; }

        /// <summary>
        /// The ID of the security policy.
        /// 
        /// *   **tls_cipher_policy\_1\_0**
        /// 
        ///     *   Supported Transport Layer Security (TLS) versions: TLS 1.0, TLS 1.1, and TLS 1.2
        ///     *   Supported cipher suites: ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, AES128-GCM-SHA256, AES256-GCM-SHA384, AES128-SHA256, AES256-SHA256, ECDHE-RSA-AES128-SHA, ECDHE-RSA-AES256-SHA, AES128-SHA, AES256-SHA, and DES-CBC3-SHA
        /// 
        /// *   **tls_cipher_policy\_1\_1**
        /// 
        ///     *   Supported TLS versions: TLS 1.1 and TLS 1.2
        ///     *   Supported cipher suites: ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, AES128-GCM-SHA256, AES256-GCM-SHA384, AES128-SHA256, AES256-SHA256, ECDHE-RSA-AES128-SHA, ECDHE-RSA-AES256-SHA, AES128-SHA, AES256-SHA, and DES-CBC3-SHA
        /// 
        /// *   **tls_cipher_policy\_1\_2**
        /// 
        ///     *   Supported TLS version: TLS 1.2
        ///     *   Supported cipher suites: ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, AES128-GCM-SHA256, AES256-GCM-SHA384, AES128-SHA256, AES256-SHA256, ECDHE-RSA-AES128-SHA, ECDHE-RSA-AES256-SHA, AES128-SHA, AES256-SHA, and DES-CBC3-SHA
        /// 
        /// *   **tls_cipher_policy\_1\_2\_strict**
        /// 
        ///     *   Supported TLS version: TLS 1.2
        ///     *   Supported cipher suites: ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, ECDHE-RSA-AES128-SHA, and ECDHE-RSA-AES256-SHA
        /// 
        /// *   **tls_cipher_policy\_1\_2\_strict_with\_1\_3**
        /// 
        ///     *   Supported TLS versions: TLS 1.2 and TLS 1.3
        ///     *   Supported cipher suites: TLS_AES\_128\_GCM_SHA256, TLS_AES\_256\_GCM_SHA384, TLS_CHACHA20\_POLY1305\_SHA256, TLS_AES\_128\_CCM_SHA256, TLS_AES\_128\_CCM\_8\_SHA256, ECDHE-ECDSA-AES128-GCM-SHA256, ECDHE-ECDSA-AES256-GCM-SHA384, ECDHE-ECDSA-AES128-SHA256, ECDHE-ECDSA-AES256-SHA384, ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, ECDHE-ECDSA-AES128-SHA, ECDHE-ECDSA-AES256-SHA, ECDHE-RSA-AES128-SHA, and ECDHE-RSA-AES256-SHA
        /// 
        /// >  This parameter is returned only for HTTPS listeners.
        /// </summary>
        [NameInMap("SecurityPolicyId")]
        [Validation(Required=false)]
        public string SecurityPolicyId { get; set; }

        /// <summary>
        /// The service ID to which the managed instance belongs.
        /// 
        /// >  Valid only when the ServiceManaged parameter is True.
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// Is it a managed instance. Valid values:
        /// 
        /// - true
        /// - false
        /// </summary>
        [NameInMap("ServiceManaged")]
        [Validation(Required=false)]
        public bool? ServiceManaged { get; set; }

        /// <summary>
        /// A list of action policies that users can execute on this managed instance.
        /// </summary>
        [NameInMap("ServiceManagedInfos")]
        [Validation(Required=false)]
        public List<DescribeListenerResponseBodyServiceManagedInfos> ServiceManagedInfos { get; set; }
        public class DescribeListenerResponseBodyServiceManagedInfos : TeaModel {
            /// <summary>
            /// Managed policy action name, Valid values:
            /// 
            /// - Create
            /// - Update
            /// - Delete
            /// - Associate
            /// - UserUnmanaged
            /// - CreateChild
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// Sub resource type, Valid values:
            /// 
            /// - Listener
            /// - IpSet
            /// - EndpointGroup
            /// - ForwardingRule
            /// - Endpoint
            /// - EndpointGroupDestination
            /// - EndpointPolicy
            /// 
            /// >Only valid when the Action parameter is CreateChild.
            /// </summary>
            [NameInMap("ChildType")]
            [Validation(Required=false)]
            public string ChildType { get; set; }

            /// <summary>
            /// Is the managed policy action managed, Valid values:
            /// - **true**: The managed policy action is managed, and users do not have permission to perform the operation specified in the Action on the managed instance.
            /// - **false**: The managed policy action is not managed, and users have permission to perform the operation specified in the Action on the managed instance.
            /// </summary>
            [NameInMap("IsManaged")]
            [Validation(Required=false)]
            public bool? IsManaged { get; set; }

        }

        /// <summary>
        /// The state of the listener. Valid values:
        /// 
        /// *   **configuring**: The listener is being configured.
        /// *   **init**: The listener is being initialized.
        /// *   **updating**: The listener is being updated.
        /// *   **deleting**: The listener is being deleted.
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// The routing type of the listener. Valid values:
        /// 
        /// *   **Standard**: intelligent routing
        /// *   **CustomRouting**: custom routing
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// The configurations of the `XForward` headers.
        /// </summary>
        [NameInMap("XForwardedForConfig")]
        [Validation(Required=false)]
        public DescribeListenerResponseBodyXForwardedForConfig XForwardedForConfig { get; set; }
        public class DescribeListenerResponseBodyXForwardedForConfig : TeaModel {
            /// <summary>
            /// Indicates whether the `GA-AP` header is used to retrieve the information about acceleration regions. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false**: no
            /// 
            /// >  This parameter is returned only for HTTP and HTTPS listeners.
            /// </summary>
            [NameInMap("XForwardedForGaApEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForGaApEnabled { get; set; }

            /// <summary>
            /// Indicates whether the `GA-ID` header is used to retrieve the ID of the GA instance. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false**: no
            /// 
            /// >  This parameter is returned only for HTTP and HTTPS listeners.
            /// </summary>
            [NameInMap("XForwardedForGaIdEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForGaIdEnabled { get; set; }

            /// <summary>
            /// Indicates whether the `GA-X-Forward-Port` header is used to retrieve the listener ports of the GA instance. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false**: no
            /// 
            /// >  This parameter is returned only for HTTP and HTTPS listeners.
            /// </summary>
            [NameInMap("XForwardedForPortEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForPortEnabled { get; set; }

            /// <summary>
            /// Indicates whether the `GA-X-Forward-Proto` header is used to retrieve the listener protocol of the GA instance. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false**: no
            /// 
            /// >  This parameter is returned only for HTTP and HTTPS listeners.
            /// </summary>
            [NameInMap("XForwardedForProtoEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForProtoEnabled { get; set; }

            /// <summary>
            /// Indicates whether the `X-Real-IP` header is used to retrieve client IP addresses. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// 
            /// >  This parameter is returned only for HTTP and HTTPS listeners.
            /// </summary>
            [NameInMap("XRealIpEnabled")]
            [Validation(Required=false)]
            public bool? XRealIpEnabled { get; set; }

        }

    }

}
