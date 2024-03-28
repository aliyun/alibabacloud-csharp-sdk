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
        /// *   **white**: a whitelist. Only requests from the IP addresses or CIDR blocks in the ACL are forwarded. Whitelists are suitable for scenarios in which you want to allow only specific IP addresses to access an application. If a whitelist is improperly configured, risks may arise. After a whitelist is configured for a listener, only requests from the IP addresses that are added to the whitelist are distributed by the listener. If the whitelist is enabled but no IP addresses are added to the ACL, the listener does not forward requests.
        /// *   **black**: a blacklist. All requests from the IP addresses or CIDR blocks in the ACL are blocked. Blacklists are suitable for scenarios in which you want to deny access from specific IP addresses to an application. If the blacklist is enabled but no IP addresses are added to the ACL, the listener forwards all requests.
        /// 
        /// This parameter is returned only if the value of **Status** is **on**.
        /// </summary>
        [NameInMap("AclType")]
        [Validation(Required=false)]
        public string AclType { get; set; }

        /// <summary>
        /// The information about the backend ports.
        /// </summary>
        [NameInMap("BackendPorts")]
        [Validation(Required=false)]
        public List<DescribeListenerResponseBodyBackendPorts> BackendPorts { get; set; }
        public class DescribeListenerResponseBodyBackendPorts : TeaModel {
            /// <summary>
            /// The first port in the range of ports that are used by the backend server to receive requests.
            /// 
            /// This parameter is returned only if an HTTPS listener is configured and the listener port is the same as the service port of the backend server.
            /// </summary>
            [NameInMap("FromPort")]
            [Validation(Required=false)]
            public string FromPort { get; set; }

            /// <summary>
            /// The last port in the range of ports that are used by the backend server to receive requests.
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
            /// The type of the SSL certificate.
            /// 
            /// Only **Server** may be returned, which indicates a server certificate.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// Indicates whether client affinity is enabled for the listener.
        /// 
        /// *   If **NONE** is returned, client affinity is disabled. Requests from the same client may be forwarded to different endpoints.
        /// *   If **SOURCE_IP** is returned, client affinity is enabled. When a client accesses stateful applications, requests from the same client are forwarded to the same endpoint regardless of the source port or protocol.
        /// </summary>
        [NameInMap("ClientAffinity")]
        [Validation(Required=false)]
        public string ClientAffinity { get; set; }

        /// <summary>
        /// The time when the listener was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC. Unit: milliseconds.
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

        /// <summary>
        /// The maximum version of the HTTP protocol. Valid values:
        /// 
        /// *   **http3**
        /// *   **http2**
        /// *   **http1.1**
        /// 
        /// >  This parameter is returned only for HTTPS listeners.
        /// </summary>
        [NameInMap("HttpVersion")]
        [Validation(Required=false)]
        public string HttpVersion { get; set; }

        /// <summary>
        /// The timeout period of idle connections. Unit: seconds.
        /// </summary>
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
        /// The information about the listener ports.
        /// </summary>
        [NameInMap("PortRanges")]
        [Validation(Required=false)]
        public List<DescribeListenerResponseBodyPortRanges> PortRanges { get; set; }
        public class DescribeListenerResponseBodyPortRanges : TeaModel {
            /// <summary>
            /// The first port in the range of listener ports that are used to receive and forward requests to endpoints.
            /// </summary>
            [NameInMap("FromPort")]
            [Validation(Required=false)]
            public int? FromPort { get; set; }

            /// <summary>
            /// The last port in the range of listener ports that are used to receive and forward requests to endpoints.
            /// </summary>
            [NameInMap("ToPort")]
            [Validation(Required=false)]
            public int? ToPort { get; set; }

        }

        /// <summary>
        /// The network transmission protocol that is used by the listener. Valid values:
        /// 
        /// *   **tcp**: TCP.
        /// *   **udp**: UDP.
        /// *   **http**: HTTP.
        /// *   **https**: HTTPS.
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// Indicates whether the client IP address preservation feature is enabled. Valid values:
        /// 
        /// *   **true** You can view the source IP addresses of clients over the backend service.
        /// *   **false**
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
            /// *   **on**: enabled.
            /// *   **off**: disabled.
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

        /// <summary>
        /// The timeout period of HTTP or HTTPS requests. Unit: seconds.
        /// 
        /// >  This parameter is returned only for HTTP and HTTPS listeners. If no responses are received from the backend server within the specified timeout period, GA returns the HTTP 504 error code to the client.
        /// </summary>
        [NameInMap("RequestTimeout")]
        [Validation(Required=false)]
        public int? RequestTimeout { get; set; }

        /// <summary>
        /// The ID of the security policy.
        /// 
        /// *   **tls_cipher_policy\_1\_0**
        /// 
        ///     *   Supported Transport Layer Security (TLS) versions: TLS 1.0, TLS 1.1, and TLS 1.2.
        ///     *   Supported cipher suites: ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, AES128-GCM-SHA256, AES256-GCM-SHA384, AES128-SHA256, AES256-SHA256, ECDHE-RSA-AES128-SHA, ECDHE-RSA-AES256-SHA, AES128-SHA, AES256-SHA, and DES-CBC3-SHA.
        /// 
        /// *   **tls_cipher_policy\_1\_1**
        /// 
        ///     *   Supported TLS versions: TLS 1.1 and TLS 1.2.
        ///     *   Supported cipher suites: ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, AES128-GCM-SHA256, AES256-GCM-SHA384, AES128-SHA256, AES256-SHA256, ECDHE-RSA-AES128-SHA, ECDHE-RSA-AES256-SHA, AES128-SHA, AES256-SHA, and DES-CBC3-SHA.
        /// 
        /// *   **tls_cipher_policy\_1\_2**
        /// 
        ///     *   Supported TLS version: TLS 1.2.
        ///     *   Supported cipher suites: ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, AES128-GCM-SHA256, AES256-GCM-SHA384, AES128-SHA256, AES256-SHA256, ECDHE-RSA-AES128-SHA, ECDHE-RSA-AES256-SHA, AES128-SHA, AES256-SHA, and DES-CBC3-SHA.
        /// 
        /// *   **tls_cipher_policy\_1\_2\_strict**
        /// 
        ///     *   Supported TLS version: TLS 1.2.
        ///     *   Supported cipher suites: ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, ECDHE-RSA-AES128-SHA, and ECDHE-RSA-AES256-SHA.
        /// 
        /// *   **tls_cipher_policy\_1\_2\_strict_with\_1\_3**
        /// 
        ///     *   Supported TLS versions: TLS 1.2 and TLS 1.3.
        ///     *   Supported cipher suites: TLS_AES\_128\_GCM_SHA256, TLS_AES\_256\_GCM_SHA384, TLS_CHACHA20\_POLY1305\_SHA256, TLS_AES\_128\_CCM_SHA256, TLS_AES\_128\_CCM\_8\_SHA256, ECDHE-ECDSA-AES128-GCM-SHA256, ECDHE-ECDSA-AES256-GCM-SHA384, ECDHE-ECDSA-AES128-SHA256, ECDHE-ECDSA-AES256-SHA384, ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, ECDHE-ECDSA-AES128-SHA, ECDHE-ECDSA-AES256-SHA, ECDHE-RSA-AES128-SHA, and ECDHE-RSA-AES256-SHA.
        /// 
        /// >  This parameter is returned only for HTTPS listeners.
        /// </summary>
        [NameInMap("SecurityPolicyId")]
        [Validation(Required=false)]
        public string SecurityPolicyId { get; set; }

        /// <summary>
        /// The ID of the service that manages the instance.
        /// 
        /// >  This parameter is returned only if the value of **ServiceManaged** is **true**.
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// Indicates whether the instance is managed. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("ServiceManaged")]
        [Validation(Required=false)]
        public bool? ServiceManaged { get; set; }

        /// <summary>
        /// The actions that users can perform on the managed instance.
        /// >*   This parameter is returned only if the value of **ServiceManaged** is **true**.
        /// >*   Users can perform only specific actions on a managed instance.
        /// </summary>
        [NameInMap("ServiceManagedInfos")]
        [Validation(Required=false)]
        public List<DescribeListenerResponseBodyServiceManagedInfos> ServiceManagedInfos { get; set; }
        public class DescribeListenerResponseBodyServiceManagedInfos : TeaModel {
            /// <summary>
            /// The name of the action on the managed instance. Valid values:
            /// 
            /// *   **Create**
            /// *   **Update**
            /// *   **Delete**
            /// *   **Associate**
            /// *   **UserUnmanaged**
            /// *   **CreateChild**
            /// </summary>
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            /// <summary>
            /// The type of the child resource. Valid values:
            /// 
            /// *   **Listener**: a listener.
            /// *   **IpSet**: an acceleration region.
            /// *   **EndpointGroup**: an endpoint group.
            /// *   **ForwardingRule**: a forwarding rule.
            /// *   **Endpoint**: an endpoint.
            /// *   **EndpointGroupDestination**: a protocol mapping of an endpoint group associated with a custom routing listener.
            /// *   **EndpointPolicy**: a traffic policy of an endpoint associated with a custom routing listener.
            /// 
            /// >  This parameter is returned only if the value of **Action** is **CreateChild**.
            /// </summary>
            [NameInMap("ChildType")]
            [Validation(Required=false)]
            public string ChildType { get; set; }

            /// <summary>
            /// Indicates whether the specified actions are managed.
            /// 
            /// *   **true**: The specified actions are managed, and users cannot perform the specified actions on the managed instance.
            /// *   **false**: The specified actions are not managed, and users can perform the specified actions on the managed instance.
            /// </summary>
            [NameInMap("IsManaged")]
            [Validation(Required=false)]
            public bool? IsManaged { get; set; }

        }

        /// <summary>
        /// The status of the listener. Valid values:
        /// 
        /// *   **configuring**: The listener is being configured.
        /// *   **init**: The listener is being initialized.
        /// *   **updating**: The listener is being updated.
        /// *   **deleting:** The listener is being deleted.
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// The routing type of the listener. Valid values:
        /// 
        /// *   **Standard**: intelligent routing.
        /// *   **CustomRouting**: custom routing.
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
            /// Indicates whether the `GA-AP` header is used to retrieve information about acceleration regions. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// 
            /// >  This parameter is returned only for HTTP and HTTPS listeners.
            /// </summary>
            [NameInMap("XForwardedForGaApEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForGaApEnabled { get; set; }

            /// <summary>
            /// Indicates whether the `GA-ID` header is used to retrieve the ID of the GA instance. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// 
            /// >  This parameter is returned only for HTTP and HTTPS listeners.
            /// </summary>
            [NameInMap("XForwardedForGaIdEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForGaIdEnabled { get; set; }

            /// <summary>
            /// Indicates whether the `GA-X-Forward-Port` header is used to retrieve the listener ports of the GA instance. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// 
            /// >  This parameter is returned only for HTTP and HTTPS listeners.
            /// </summary>
            [NameInMap("XForwardedForPortEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForPortEnabled { get; set; }

            /// <summary>
            /// Indicates whether the `GA-X-Forward-Proto` header is used to retrieve the listener protocol of the GA instance. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
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
