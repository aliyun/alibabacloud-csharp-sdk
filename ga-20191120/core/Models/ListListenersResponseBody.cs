// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListListenersResponseBody : TeaModel {
        /// <summary>
        /// The information about the listeners.
        /// </summary>
        [NameInMap("Listeners")]
        [Validation(Required=false)]
        public List<ListListenersResponseBodyListeners> Listeners { get; set; }
        public class ListListenersResponseBodyListeners : TeaModel {
            /// <summary>
            /// The ID of the GA instance.
            /// </summary>
            [NameInMap("AcceleratorId")]
            [Validation(Required=false)]
            public string AcceleratorId { get; set; }

            /// <summary>
            /// The range of ports that are used by backend servers.
            /// </summary>
            [NameInMap("BackendPorts")]
            [Validation(Required=false)]
            public List<ListListenersResponseBodyListenersBackendPorts> BackendPorts { get; set; }
            public class ListListenersResponseBodyListenersBackendPorts : TeaModel {
                /// <summary>
                /// The first port in the range of ports that are used by backend servers.
                /// </summary>
                [NameInMap("FromPort")]
                [Validation(Required=false)]
                public string FromPort { get; set; }

                /// <summary>
                /// The last port in the range of ports that are used by backend servers.
                /// </summary>
                [NameInMap("ToPort")]
                [Validation(Required=false)]
                public string ToPort { get; set; }

            }

            /// <summary>
            /// The information about the SSL certificates.
            /// </summary>
            [NameInMap("Certificates")]
            [Validation(Required=false)]
            public List<ListListenersResponseBodyListenersCertificates> Certificates { get; set; }
            public class ListListenersResponseBodyListenersCertificates : TeaModel {
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
            /// *   If **NONE** is returned, client affinity is disabled. When client affinity is disabled, requests from the same client may be forwarded to different endpoints.
            /// *   If **SOURCE_IP** is returned, client affinity is enabled. When a client accesses stateful applications, requests from the same client are forwarded to the same endpoint regardless of the source port or protocol.
            /// </summary>
            [NameInMap("ClientAffinity")]
            [Validation(Required=false)]
            public string ClientAffinity { get; set; }

            /// <summary>
            /// The timestamp that indicates when the listener was created. Unit: milliseconds.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

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
            public List<ListListenersResponseBodyListenersPortRanges> PortRanges { get; set; }
            public class ListListenersResponseBodyListenersPortRanges : TeaModel {
                /// <summary>
                /// The first port in the listener port range that is used to receive and forward requests to endpoints.
                /// </summary>
                [NameInMap("FromPort")]
                [Validation(Required=false)]
                public int? FromPort { get; set; }

                /// <summary>
                /// The last port in the listener port range that is used to receive and forward requests to endpoints.
                /// </summary>
                [NameInMap("ToPort")]
                [Validation(Required=false)]
                public int? ToPort { get; set; }

            }

            /// <summary>
            /// The network transmission protocol that is used by the listener. Valid values:
            /// 
            /// *   **tcp**
            /// *   **udp**
            /// *   **http**
            /// *   **https**
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// Indicates whether client IP address preservation is enabled. Valid values:
            /// 
            /// *   **true**: Client IP address preservation is enabled. This feature allows you to view client IP addresses on backend servers.
            /// *   **false**: Client IP address preservation is disabled.
            /// </summary>
            [NameInMap("ProxyProtocol")]
            [Validation(Required=false)]
            public bool? ProxyProtocol { get; set; }

            /// <summary>
            /// The timeout period of HTTP or HTTPS requests. Unit: seconds.
            /// 
            /// >  This parameter is returned only for HTTP and HTTPS listeners. If no responses are received from the backend server within the timeout period, GA returns an HTTP 504 error code to the client.
            /// </summary>
            [NameInMap("RequestTimeout")]
            [Validation(Required=false)]
            public int? RequestTimeout { get; set; }

            /// <summary>
            /// The ID of the security policy.
            /// 
            /// *   **tls_cipher_policy_1_0**
            /// 
            ///     *   Supported Transport Layer Security (TLS) versions: TLS 1.0, TLS 1.1, and TLS 1.2.
            ///     *   Supported cipher suites: ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, AES128-GCM-SHA256, AES256-GCM-SHA384, AES128-SHA256, AES256-SHA256, ECDHE-RSA-AES128-SHA, ECDHE-RSA-AES256-SHA, AES128-SHA, AES256-SHA, and DES-CBC3-SHA.
            /// 
            /// *   **tls_cipher_policy_1_1**
            /// 
            ///     *   Supported TLS versions: TLS 1.1 and TLS 1.2.
            ///     *   Supported cipher suites: ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, AES128-GCM-SHA256, AES256-GCM-SHA384, AES128-SHA256, AES256-SHA256, ECDHE-RSA-AES128-SHA, ECDHE-RSA-AES256-SHA, AES128-SHA, AES256-SHA, and DES-CBC3-SHA.
            /// 
            /// *   **tls_cipher_policy_1_2**
            /// 
            ///     *   Supported TLS version: TLS 1.2.
            ///     *   Supported cipher suites: ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, AES128-GCM-SHA256, AES256-GCM-SHA384, AES128-SHA256, AES256-SHA256, ECDHE-RSA-AES128-SHA, ECDHE-RSA-AES256-SHA, AES128-SHA, AES256-SHA, and DES-CBC3-SHA.
            /// 
            /// *   **tls_cipher_policy_1_2_strict**
            /// 
            ///     *   Supported TLS version: TLS 1.2.
            ///     *   Supported cipher suites: ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, ECDHE-RSA-AES128-SHA, and ECDHE-RSA-AES256-SHA.
            /// 
            /// *   **tls_cipher_policy_1_2_strict_with_1_3**
            /// 
            ///     *   Supported TLS versions: TLS 1.2 and TLS 1.3.
            ///     *   Supported cipher suites: TLS_AES_128_GCM_SHA256, TLS_AES_256_GCM_SHA384, TLS_CHACHA20_POLY1305_SHA256, TLS_AES_128_CCM_SHA256, TLS_AES_128_CCM_8_SHA256, ECDHE-ECDSA-AES128-GCM-SHA256, ECDHE-ECDSA-AES256-GCM-SHA384, ECDHE-ECDSA-AES128-SHA256, ECDHE-ECDSA-AES256-SHA384, ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, ECDHE-ECDSA-AES128-SHA, ECDHE-ECDSA-AES256-SHA, ECDHE-RSA-AES128-SHA, and ECDHE-RSA-AES256-SHA.
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
            /// > *   This parameter is returned only if the value of **ServiceManaged** is **true**.
            /// > *   Users can perform only specific actions on a managed instance.
            /// </summary>
            [NameInMap("ServiceManagedInfos")]
            [Validation(Required=false)]
            public List<ListListenersResponseBodyListenersServiceManagedInfos> ServiceManagedInfos { get; set; }
            public class ListListenersResponseBodyListenersServiceManagedInfos : TeaModel {
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
                /// *   **Listener**: listener.
                /// *   **IpSet**: acceleration region.
                /// *   **EndpointGroup**: endpoint group.
                /// *   **ForwardingRule**: forwarding rule.
                /// *   **Endpoint**: endpoint.
                /// *   **EndpointGroupDestination**: protocol mapping of an endpoint group associated with a custom routing listener.
                /// *   **EndpointPolicy**: traffic policy of an endpoint associated with a custom routing listener.
                /// 
                /// >  This parameter takes effect only if the value of **Action** is **CreateChild**.
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
            /// *   **active**
            /// *   **init**
            /// *   **updating**
            /// *   **deleting**
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
            public ListListenersResponseBodyListenersXForwardedForConfig XForwardedForConfig { get; set; }
            public class ListListenersResponseBodyListenersXForwardedForConfig : TeaModel {
                /// <summary>
                /// Indicates whether the `GA-AP` header is used to retrieve the information about acceleration regions. Valid values:
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

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

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
