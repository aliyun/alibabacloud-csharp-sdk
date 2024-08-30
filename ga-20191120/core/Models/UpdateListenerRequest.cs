// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class UpdateListenerRequest : TeaModel {
        /// <summary>
        /// The range of ports that are used by backend servers to receive requests.
        /// </summary>
        [NameInMap("BackendPorts")]
        [Validation(Required=false)]
        public List<UpdateListenerRequestBackendPorts> BackendPorts { get; set; }
        public class UpdateListenerRequestBackendPorts : TeaModel {
            /// <summary>
            /// The first port in the range of ports that are used by backend servers to receive requests.
            /// 
            /// > This parameter is required only when you configure an HTTPS or HTTP listener and the listener port is different from the service port of the backend servers. In this case, the first port that is used by the backend servers to receive requests must be the same as the last port.
            /// </summary>
            [NameInMap("FromPort")]
            [Validation(Required=false)]
            public int? FromPort { get; set; }

            /// <summary>
            /// The last port in the range of ports that are used by backend servers to receive requests.
            /// 
            /// > This parameter is required only when you configure an HTTPS or HTTP listener and the listener port is different from the service port of the backend servers. In this case, the first port that is used by the backend servers to receive requests must be the same as the last port.
            /// </summary>
            [NameInMap("ToPort")]
            [Validation(Required=false)]
            public int? ToPort { get; set; }

        }

        /// <summary>
        /// The SSL certificate.
        /// </summary>
        [NameInMap("Certificates")]
        [Validation(Required=false)]
        public List<UpdateListenerRequestCertificates> Certificates { get; set; }
        public class UpdateListenerRequestCertificates : TeaModel {
            /// <summary>
            /// The ID of the SSL certificate.
            /// 
            /// > This parameter is required only when you configure an HTTPS listener.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

        }

        /// <summary>
        /// Indicates whether client affinity is enabled for the listener. Valid values:
        /// 
        /// *   **NONE**: Client affinity is disabled. Requests from the same client may be forwarded to different endpoints.
        /// *   **SOURCE_IP**: Client affinity is enabled. When a client accesses stateful applications, requests from the same client are forwarded to the same endpoint regardless of the source port or protocol.
        /// </summary>
        [NameInMap("ClientAffinity")]
        [Validation(Required=false)]
        public string ClientAffinity { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the token, but you must make sure that the token is unique among different requests. The client token can contain only ASCII characters.
        /// 
        /// >  If you do not specify this parameter, the system automatically uses the **request ID** as the **client token**. The **request ID** may be different for each request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The description of the listener.
        /// 
        /// The description can be up to 200 characters in length and cannot start with `http://` or `https://`.
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
        /// >  Only HTTPS listeners support this parameter.
        /// </summary>
        [NameInMap("HttpVersion")]
        [Validation(Required=false)]
        public string HttpVersion { get; set; }

        /// <summary>
        /// The timeout period for idle connections. Unit: seconds.
        /// 
        /// *   TCP: 10-900. Default value: 900. Unit: seconds.
        /// *   UDP: 10-20. Default value: 20. Unit: seconds.
        /// *   HTTP/HTTPS: 1-60. Default value: 15. Unit: seconds.
        /// </summary>
        [NameInMap("IdleTimeout")]
        [Validation(Required=false)]
        public int? IdleTimeout { get; set; }

        /// <summary>
        /// The ID of the listener.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ListenerId")]
        [Validation(Required=false)]
        public string ListenerId { get; set; }

        /// <summary>
        /// The name of the listener.
        /// 
        /// The name must be 1 to 128 characters in length and can contain letters, digits, periods (.), underscores (_), and hyphens (-). The name must start with a letter.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The listener ports that are used to receive requests and forward the requests to endpoints.
        /// 
        /// Valid values: **1** to **65499**.
        /// 
        /// The maximum number of ports that can be configured varies based on the routing type and protocol of the listener. For more information, see [Listener overview](https://help.aliyun.com/document_detail/153216.html).
        /// </summary>
        [NameInMap("PortRanges")]
        [Validation(Required=false)]
        public List<UpdateListenerRequestPortRanges> PortRanges { get; set; }
        public class UpdateListenerRequestPortRanges : TeaModel {
            /// <summary>
            /// The first port of the listener port range that is used to receive and forward requests to endpoints.
            /// 
            /// Valid values: **1** to **65499**. The **FromPort** value must be smaller than or equal to the **ToPort** value.
            /// 
            /// The maximum number of ports that can be configured varies based on the routing type and protocol of the listener. For more information, see [Listener overview](https://help.aliyun.com/document_detail/153216.html).
            /// 
            /// > You can configure only one listener port for an HTTP or HTTPS listener. In this case, the first port is the same as the last port.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("FromPort")]
            [Validation(Required=false)]
            public int? FromPort { get; set; }

            /// <summary>
            /// The last port of the listener port range that is used to receive and forward requests to endpoints.
            /// 
            /// Valid values: **1** to **65499**. The **FromPort** value must be smaller than or equal to the **ToPort** value.
            /// 
            /// The maximum number of ports that can be configured varies based on the routing type and protocol of the listener. For more information, see [Listener overview](https://help.aliyun.com/document_detail/153216.html).
            /// 
            /// > You can configure only one listener port for an HTTP or HTTPS listener. In this case, the first port is the same as the last port.
            /// 
            /// This parameter is required.
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
        /// Specifies whether to reserve client IP addresses. Default value: false. Valid values:
        /// 
        /// *   **true**: enables client IP preservation. After client IP addresses are reserved, you can view client IP addresses on the endpoints.
        /// *   **false** (default): disables client IP preservation.
        /// 
        /// > This parameter will be deprecated in the API operations that are used to configure listeners. We recommend that you set this parameter when you call API operations to configure endpoint groups. For more information about the **ProxyProtocol** parameter, see [CreateEndpointGroup](https://help.aliyun.com/document_detail/153259.html) and [UpdateEndpointGroup](https://help.aliyun.com/document_detail/153262.html).
        /// </summary>
        [NameInMap("ProxyProtocol")]
        [Validation(Required=false)]
        public string ProxyProtocol { get; set; }

        /// <summary>
        /// The region ID of the GA instance. Set the value to **cn-hangzhou**.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The timeout period for HTTP or HTTPS requests.
        /// 
        /// Valid values: 1 to 180. Default value: 60. Unit: seconds.
        /// 
        /// >  This parameter takes effect only for HTTP or HTTPS listeners. If the backend server does not respond within the timeout period, GA returns an HTTP 504 error code to the client.
        /// </summary>
        [NameInMap("RequestTimeout")]
        [Validation(Required=false)]
        public int? RequestTimeout { get; set; }

        /// <summary>
        /// The ID of the security policy. Valid values:
        /// 
        /// *   **tls_cipher_policy_1_0**
        /// 
        ///     *   Supported Transport Layer Security (TLS) versions: TLS 1.0, TLS 1.1, and TLS 1.2
        ///     *   Supported cipher suites: ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, AES128-GCM-SHA256, AES256-GCM-SHA384, AES128-SHA256, AES256-SHA256, ECDHE-RSA-AES128-SHA, ECDHE-RSA-AES256-SHA, AES128-SHA, AES256-SHA, and DES-CBC3-SHA
        /// 
        /// *   **tls_cipher_policy_1_1**
        /// 
        ///     *   Supported TLS versions: TLS 1.1 and TLS 1.2
        ///     *   Supported cipher suites: ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, AES128-GCM-SHA256, AES256-GCM-SHA384, AES128-SHA256, AES256-SHA256, ECDHE-RSA-AES128-SHA, ECDHE-RSA-AES256-SHA, AES128-SHA, AES256-SHA, and DES-CBC3-SHA
        /// 
        /// *   **tls_cipher_policy_1_2**
        /// 
        ///     *   Supported TLS version: TLS 1.2
        ///     *   Supported cipher suites: ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, AES128-GCM-SHA256, AES256-GCM-SHA384, AES128-SHA256, AES256-SHA256, ECDHE-RSA-AES128-SHA, ECDHE-RSA-AES256-SHA, AES128-SHA, AES256-SHA, and DES-CBC3-SHA
        /// 
        /// *   **tls_cipher_policy_1_2_strict**
        /// 
        ///     *   Supported TLS version: TLS 1.2
        ///     *   Supported cipher suites: ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, ECDHE-RSA-AES128-SHA, and ECDHE-RSA-AES256-SHA
        /// 
        /// *   **tls_cipher_policy_1_2_strict_with_1_3**
        /// 
        ///     *   Supported TLS versions: TLS 1.2 and TLS 1.3
        ///     *   Supported cipher suites: TLS_AES_128_GCM_SHA256, TLS_AES_256_GCM_SHA384, TLS_CHACHA20_POLY1305_SHA256, TLS_AES_128_CCM_SHA256, TLS_AES_128_CCM_8_SHA256, ECDHE-ECDSA-AES128-GCM-SHA256, ECDHE-ECDSA-AES256-GCM-SHA384, ECDHE-ECDSA-AES128-SHA256, ECDHE-ECDSA-AES256-SHA384, ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, ECDHE-ECDSA-AES128-SHA, ECDHE-ECDSA-AES256-SHA, ECDHE-RSA-AES128-SHA, and ECDHE-RSA-AES256-SHA
        /// 
        /// > This parameter is available only when you create an HTTPS listener.
        /// </summary>
        [NameInMap("SecurityPolicyId")]
        [Validation(Required=false)]
        public string SecurityPolicyId { get; set; }

        /// <summary>
        /// The `XForward` headers.
        /// </summary>
        [NameInMap("XForwardedForConfig")]
        [Validation(Required=false)]
        public UpdateListenerRequestXForwardedForConfig XForwardedForConfig { get; set; }
        public class UpdateListenerRequestXForwardedForConfig : TeaModel {
            /// <summary>
            /// Specifies whether to use the `GA-AP` header to retrieve information about acceleration regions. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false** (default): no
            /// 
            /// > This parameter is available only when you create an HTTPS or HTTP listener.
            /// </summary>
            [NameInMap("XForwardedForGaApEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForGaApEnabled { get; set; }

            /// <summary>
            /// Specifies whether to use the `GA-ID` header to retrieve the ID of the GA instance. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false** (default): no
            /// 
            /// > This parameter is available only when you create an HTTPS or HTTP listener.
            /// </summary>
            [NameInMap("XForwardedForGaIdEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForGaIdEnabled { get; set; }

            /// <summary>
            /// Specifies whether to use the `GA-X-Forward-Port` header to retrieve the listener ports of the GA instance. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false** (default): no
            /// 
            /// > This parameter is available only when you create an HTTPS or HTTP listener.
            /// </summary>
            [NameInMap("XForwardedForPortEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForPortEnabled { get; set; }

            /// <summary>
            /// Specifies whether to use the `GA-X-Forward-Proto` header to retrieve the listener protocol of the GA instance. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false** (default): no
            /// 
            /// > This parameter is available only when you create an HTTPS or HTTP listener.
            /// </summary>
            [NameInMap("XForwardedForProtoEnabled")]
            [Validation(Required=false)]
            public bool? XForwardedForProtoEnabled { get; set; }

            /// <summary>
            /// Specifies whether to use the `X-Real-IP` header to retrieve client IP addresses. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false** (default): no
            /// 
            /// > This parameter is available only when you create an HTTPS or HTTP listener.
            /// </summary>
            [NameInMap("XRealIpEnabled")]
            [Validation(Required=false)]
            public bool? XRealIpEnabled { get; set; }

        }

    }

}
