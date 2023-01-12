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
            /// Details about the ports that can be used by the backend server.
            /// </summary>
            [NameInMap("BackendPorts")]
            [Validation(Required=false)]
            public List<ListListenersResponseBodyListenersBackendPorts> BackendPorts { get; set; }
            public class ListListenersResponseBodyListenersBackendPorts : TeaModel {
                /// <summary>
                /// The start port in the range of ports used by the backend server.
                /// </summary>
                [NameInMap("FromPort")]
                [Validation(Required=false)]
                public string FromPort { get; set; }

                /// <summary>
                /// The end port in the range of ports used by the backend server.
                /// </summary>
                [NameInMap("ToPort")]
                [Validation(Required=false)]
                public string ToPort { get; set; }

            }

            /// <summary>
            /// Details about the SSL certificates.
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
                /// The type of the certificate.
                /// 
                /// Only **Server** can be returned, which indicates a server certificate.
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
            /// The timestamp that indicates that the listener was created. Unit: milliseconds.
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
            public List<ListListenersResponseBodyListenersPortRanges> PortRanges { get; set; }
            public class ListListenersResponseBodyListenersPortRanges : TeaModel {
                /// <summary>
                /// The start port in the range of listener ports used to receive and forward requests to endpoints.
                /// </summary>
                [NameInMap("FromPort")]
                [Validation(Required=false)]
                public int? FromPort { get; set; }

                /// <summary>
                /// The start port in the range of listener ports used to receive and forward requests to endpoints.
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
            /// The state of the listener. Valid values:
            /// 
            /// *   **active**: The listener is normal.
            /// *   **init**: The listener is being initialized.
            /// *   **updating**: The listener is being configured.
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
            public ListListenersResponseBodyListenersXForwardedForConfig XForwardedForConfig { get; set; }
            public class ListListenersResponseBodyListenersXForwardedForConfig : TeaModel {
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
                /// *   **true**: yes
                /// *   **false**: no
                /// 
                /// >  This parameter is returned only for HTTP and HTTPS listeners.
                /// </summary>
                [NameInMap("XRealIpEnabled")]
                [Validation(Required=false)]
                public bool? XRealIpEnabled { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
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
