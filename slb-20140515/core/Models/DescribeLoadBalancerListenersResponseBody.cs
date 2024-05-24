// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeLoadBalancerListenersResponseBody : TeaModel {
        /// <summary>
        /// The list of listeners on the CLB instance.
        /// 
        /// >  This parameter is not returned if no listener is created on the CLB instance.
        /// </summary>
        [NameInMap("Listeners")]
        [Validation(Required=false)]
        public List<DescribeLoadBalancerListenersResponseBodyListeners> Listeners { get; set; }
        public class DescribeLoadBalancerListenersResponseBodyListeners : TeaModel {
            /// <summary>
            /// The ID of the network ACL.
            /// </summary>
            [NameInMap("AclId")]
            [Validation(Required=false)]
            public string AclId { get; set; }

            /// <summary>
            /// Indicates whether access control is enabled. Valid values:
            /// 
            /// *   **on**: yes
            /// *   **off**: no
            /// </summary>
            [NameInMap("AclStatus")]
            [Validation(Required=false)]
            public string AclStatus { get; set; }

            /// <summary>
            /// The type of the network access control list (ACL). Valid values:
            /// 
            /// *   **white**: a whitelist. Only requests from the IP addresses or CIDR blocks in the network ACL are forwarded. Whitelists apply to scenarios in which you want to allow only specific IP addresses to access an application. Your service may be adversely affected if the whitelist is not properly configured. After a whitelist is configured, only requests from IP addresses that are added to the whitelist are forwarded by the listener.
            /// 
            /// If you enable a whitelist but do not add an IP address to the whitelist, the listener forwards all requests.
            /// 
            /// *   **black**: a blacklist. All requests from the IP addresses or CIDR blocks in the network ACL are denied. A blacklist applies to scenarios in which you want to deny access from specific IP addresses.
            /// 
            /// If a blacklist is configured for a listener but no IP address is added to the blacklist, the listener forwards all requests.
            /// </summary>
            [NameInMap("AclType")]
            [Validation(Required=false)]
            public string AclType { get; set; }

            /// <summary>
            /// The port of the backend server.
            /// 
            /// >  This parameter takes effect when the `VServerGroupId` parameter and the `MasterSlaveServerGroupId` parameter are empty.
            /// </summary>
            [NameInMap("BackendServerPort")]
            [Validation(Required=false)]
            public int? BackendServerPort { get; set; }

            /// <summary>
            /// The maximum bandwidth of the listener. Unit: Mbit/s. Valid values:
            /// 
            /// *   **-1**: If -1 is returned, it indicates that the bandwidth of the listener is unlimited.
            /// *   **1 to 5120**: If a value from 1 to 5120 is returned, the value indicates the maximum bandwidth of the listener. The sum of the maximum bandwidth of all listeners added to a CLB instance does not exceed the maximum bandwidth of the CLB instance.
            /// </summary>
            [NameInMap("Bandwidth")]
            [Validation(Required=false)]
            public int? Bandwidth { get; set; }

            /// <summary>
            /// The description of the listener.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The configuration of the HTTP listener.
            /// </summary>
            [NameInMap("HTTPListenerConfig")]
            [Validation(Required=false)]
            public DescribeLoadBalancerListenersResponseBodyListenersHTTPListenerConfig HTTPListenerConfig { get; set; }
            public class DescribeLoadBalancerListenersResponseBodyListenersHTTPListenerConfig : TeaModel {
                /// <summary>
                /// The cookie that is configured on the server.
                /// </summary>
                [NameInMap("Cookie")]
                [Validation(Required=false)]
                public string Cookie { get; set; }

                /// <summary>
                /// The timeout period of a cookie. Unit: seconds.
                /// 
                /// Valid values: **1** to **86400**.
                /// </summary>
                [NameInMap("CookieTimeout")]
                [Validation(Required=false)]
                public int? CookieTimeout { get; set; }

                /// <summary>
                /// The listening port that is used to redirect HTTP requests to HTTPS.
                /// 
                /// >  If the **ListenerForward** parameter is set to **off**, this parameter is not displayed.
                /// </summary>
                [NameInMap("ForwardPort")]
                [Validation(Required=false)]
                public int? ForwardPort { get; set; }

                /// <summary>
                /// Indicates whether Gzip compression is enabled. Valid values:
                /// 
                /// *   **on**: yes
                /// *   **off**: no
                /// </summary>
                [NameInMap("Gzip")]
                [Validation(Required=false)]
                public string Gzip { get; set; }

                /// <summary>
                /// Indicates whether the health check feature is enabled. Valid values:
                /// 
                /// *   **on**: yes
                /// *   **off**: no
                /// </summary>
                [NameInMap("HealthCheck")]
                [Validation(Required=false)]
                public string HealthCheck { get; set; }

                /// <summary>
                /// The port that is used for health checks.
                /// 
                /// >  This parameter takes effect when the **HealthCheck** parameter is set to **on**.
                /// </summary>
                [NameInMap("HealthCheckConnectPort")]
                [Validation(Required=false)]
                public int? HealthCheckConnectPort { get; set; }

                /// <summary>
                /// The domain name that is used for health checks.
                /// </summary>
                [NameInMap("HealthCheckDomain")]
                [Validation(Required=false)]
                public string HealthCheckDomain { get; set; }

                /// <summary>
                /// The HTTP status codes that are used to determine whether the backend server passes the health check.
                /// </summary>
                [NameInMap("HealthCheckHttpCode")]
                [Validation(Required=false)]
                public string HealthCheckHttpCode { get; set; }

                /// <summary>
                /// The HTTP version that is used for health checks.
                /// </summary>
                [NameInMap("HealthCheckHttpVersion")]
                [Validation(Required=false)]
                public string HealthCheckHttpVersion { get; set; }

                /// <summary>
                /// The interval at which health checks are performed. Unit: seconds.
                /// </summary>
                [NameInMap("HealthCheckInterval")]
                [Validation(Required=false)]
                public int? HealthCheckInterval { get; set; }

                /// <summary>
                /// The health check method. Valid values: **head** and **get**.
                /// </summary>
                [NameInMap("HealthCheckMethod")]
                [Validation(Required=false)]
                public string HealthCheckMethod { get; set; }

                /// <summary>
                /// The maximum timeout period of a health check. Unit: seconds.
                /// </summary>
                [NameInMap("HealthCheckTimeout")]
                [Validation(Required=false)]
                public int? HealthCheckTimeout { get; set; }

                /// <summary>
                /// The protocol that is used for health checks.
                /// </summary>
                [NameInMap("HealthCheckType")]
                [Validation(Required=false)]
                public string HealthCheckType { get; set; }

                /// <summary>
                /// The URI that is used for health checks.
                /// </summary>
                [NameInMap("HealthCheckURI")]
                [Validation(Required=false)]
                public string HealthCheckURI { get; set; }

                /// <summary>
                /// The number of times that an unhealthy backend server must consecutively pass health checks before it is declared healthy. In this case, the health status is changed from **fail** to **success**.
                /// 
                /// Valid values: **2** to **10**.
                /// </summary>
                [NameInMap("HealthyThreshold")]
                [Validation(Required=false)]
                public int? HealthyThreshold { get; set; }

                /// <summary>
                /// The timeout period of an idle connection. Unit: seconds. Valid values: **1** to **60**.
                /// 
                /// If no request is received within the specified timeout period, CLB closes the connection. When a request is received, CLB establishes a new connection.
                /// </summary>
                [NameInMap("IdleTimeout")]
                [Validation(Required=false)]
                public int? IdleTimeout { get; set; }

                /// <summary>
                /// Indicates whether HTTP-to-HTTPS redirection is enabled. Valid values:
                /// 
                /// *   **on**: yes
                /// *   **off**: no
                /// </summary>
                [NameInMap("ListenerForward")]
                [Validation(Required=false)]
                public string ListenerForward { get; set; }

                /// <summary>
                /// The timeout period of a request. Unit: seconds. Valid values: **1** to **180**.
                /// 
                /// If no response is received from a backend server during the request timeout period, CLB sends the `HTTP 504` status code to the client.
                /// </summary>
                [NameInMap("RequestTimeout")]
                [Validation(Required=false)]
                public int? RequestTimeout { get; set; }

                /// <summary>
                /// Indicates whether session persistence is enabled. Valid values:
                /// 
                /// *   **on**: yes
                /// *   **off**: no
                /// </summary>
                [NameInMap("StickySession")]
                [Validation(Required=false)]
                public string StickySession { get; set; }

                /// <summary>
                /// The method that is used to handle a cookie. Valid values:
                /// 
                /// *   **insert**: inserts a cookie. CLB inserts a cookie (SERVERID) into the first HTTP or HTTPS response that is sent to a client. The next request from the client contains this cookie, and the listener forwards this request to the recorded backend server.
                /// *   **server**: rewrites a cookie. When CLB detects a user-defined cookie, it overwrites the original cookie with the user-defined cookie. The next request from the client carries the user-defined cookie, and the listener will distribute the request to the recorded backend server.
                /// </summary>
                [NameInMap("StickySessionType")]
                [Validation(Required=false)]
                public string StickySessionType { get; set; }

                /// <summary>
                /// The number of times that a healthy backend server must consecutively fail health checks before it is declared unhealthy. In this case, the health status is changed from **success** to **fail**.
                /// 
                /// Valid values: **2** to **10**.
                /// </summary>
                [NameInMap("UnhealthyThreshold")]
                [Validation(Required=false)]
                public int? UnhealthyThreshold { get; set; }

                /// <summary>
                /// Indicates whether the `XForwardedFor` header is used to retrieve client IP addresses. Valid values:
                /// 
                /// *   **on**: yes
                /// *   **off**: no
                /// </summary>
                [NameInMap("XForwardedFor")]
                [Validation(Required=false)]
                public string XForwardedFor { get; set; }

                /// <summary>
                /// Indicates whether the `XForwardedFor_ClientSrcPort` header is used to retrieve the client port. Valid values:
                /// 
                /// *   **on**: yes
                /// *   **off**: no
                /// </summary>
                [NameInMap("XForwardedFor_ClientSrcPort")]
                [Validation(Required=false)]
                public string XForwardedFor_ClientSrcPort { get; set; }

                /// <summary>
                /// Indicates whether the `SLB-ID` header is used to retrieve the ID of the CLB instance. Valid values:
                /// 
                /// *   **on**: yes
                /// *   **off**: no
                /// </summary>
                [NameInMap("XForwardedFor_SLBID")]
                [Validation(Required=false)]
                public string XForwardedFor_SLBID { get; set; }

                /// <summary>
                /// Indicates whether the `SLB-IP` header is used to retrieve the virtual IP address requested by the client. Valid values:
                /// 
                /// *   **on**: yes
                /// *   **off**: no
                /// </summary>
                [NameInMap("XForwardedFor_SLBIP")]
                [Validation(Required=false)]
                public string XForwardedFor_SLBIP { get; set; }

                /// <summary>
                /// Indicates whether the `XForwardedFor_SLBPORT` header is used to retrieve the listening port. Valid values:
                /// 
                /// *   **on**: yes
                /// *   **off**: no
                /// </summary>
                [NameInMap("XForwardedFor_SLBPORT")]
                [Validation(Required=false)]
                public string XForwardedFor_SLBPORT { get; set; }

                /// <summary>
                /// Indicates whether the `X-Forwarded-Proto` header is used to retrieve the listening protocol. Valid values:
                /// 
                /// *   **on**: yes
                /// *   **off**: no
                /// </summary>
                [NameInMap("XForwardedFor_proto")]
                [Validation(Required=false)]
                public string XForwardedFor_proto { get; set; }

            }

            /// <summary>
            /// The configuration of the HTTPS listener.
            /// </summary>
            [NameInMap("HTTPSListenerConfig")]
            [Validation(Required=false)]
            public DescribeLoadBalancerListenersResponseBodyListenersHTTPSListenerConfig HTTPSListenerConfig { get; set; }
            public class DescribeLoadBalancerListenersResponseBodyListenersHTTPSListenerConfig : TeaModel {
                /// <summary>
                /// The ID of the certificate authority (CA) certificate.
                /// </summary>
                [NameInMap("CACertificateId")]
                [Validation(Required=false)]
                public string CACertificateId { get; set; }

                /// <summary>
                /// The cookie that is configured on the server.
                /// </summary>
                [NameInMap("Cookie")]
                [Validation(Required=false)]
                public string Cookie { get; set; }

                /// <summary>
                /// The timeout period of a cookie. Unit: seconds.
                /// 
                /// Valid values: **1** to **86400**.
                /// </summary>
                [NameInMap("CookieTimeout")]
                [Validation(Required=false)]
                public int? CookieTimeout { get; set; }

                /// <summary>
                /// Indicates whether `HTTP 2.0` is enabled. Valid values:
                /// 
                /// *   **on**: yes
                /// *   **off**: no
                /// </summary>
                [NameInMap("EnableHttp2")]
                [Validation(Required=false)]
                public string EnableHttp2 { get; set; }

                /// <summary>
                /// Indicates whether Gzip compression is enabled. Valid values:
                /// 
                /// *   **on**: yes
                /// *   **off**: no
                /// </summary>
                [NameInMap("Gzip")]
                [Validation(Required=false)]
                public string Gzip { get; set; }

                /// <summary>
                /// Indicates whether the health check feature is enabled. Valid values:
                /// 
                /// *   **on**: yes
                /// *   **off**: no
                /// </summary>
                [NameInMap("HealthCheck")]
                [Validation(Required=false)]
                public string HealthCheck { get; set; }

                /// <summary>
                /// The port that is used for health checks.
                /// </summary>
                [NameInMap("HealthCheckConnectPort")]
                [Validation(Required=false)]
                public int? HealthCheckConnectPort { get; set; }

                /// <summary>
                /// The domain name that is used for health checks.
                /// </summary>
                [NameInMap("HealthCheckDomain")]
                [Validation(Required=false)]
                public string HealthCheckDomain { get; set; }

                /// <summary>
                /// The HTTP status codes that are used to determine whether the backend server passes the health check.
                /// </summary>
                [NameInMap("HealthCheckHttpCode")]
                [Validation(Required=false)]
                public string HealthCheckHttpCode { get; set; }

                /// <summary>
                /// The HTTP version that is used for health checks.
                /// </summary>
                [NameInMap("HealthCheckHttpVersion")]
                [Validation(Required=false)]
                public string HealthCheckHttpVersion { get; set; }

                /// <summary>
                /// The interval at which health checks are performed. Unit: seconds.
                /// </summary>
                [NameInMap("HealthCheckInterval")]
                [Validation(Required=false)]
                public int? HealthCheckInterval { get; set; }

                /// <summary>
                /// The health check method.
                /// </summary>
                [NameInMap("HealthCheckMethod")]
                [Validation(Required=false)]
                public string HealthCheckMethod { get; set; }

                /// <summary>
                /// The maximum timeout period of a health check. Unit: seconds.
                /// </summary>
                [NameInMap("HealthCheckTimeout")]
                [Validation(Required=false)]
                public int? HealthCheckTimeout { get; set; }

                /// <summary>
                /// The protocol that is used for health checks.
                /// </summary>
                [NameInMap("HealthCheckType")]
                [Validation(Required=false)]
                public string HealthCheckType { get; set; }

                /// <summary>
                /// The URI that is used for health checks.
                /// </summary>
                [NameInMap("HealthCheckURI")]
                [Validation(Required=false)]
                public string HealthCheckURI { get; set; }

                /// <summary>
                /// The number of times that an unhealthy backend server must consecutively pass health checks before it is declared healthy. In this case, the health status is changed from **fail** to **success**.
                /// 
                /// Valid values: **2** to **10**.
                /// </summary>
                [NameInMap("HealthyThreshold")]
                [Validation(Required=false)]
                public int? HealthyThreshold { get; set; }

                /// <summary>
                /// The timeout period of an idle connection. Unit: seconds. Valid values: **1** to **60**.
                /// 
                /// If no request is received within the specified timeout period, CLB closes the connection. When a request is received, CLB establishes a new connection.
                /// </summary>
                [NameInMap("IdleTimeout")]
                [Validation(Required=false)]
                public int? IdleTimeout { get; set; }

                /// <summary>
                /// The request timeout period. Unit: seconds. Valid values: **1** to **180**.
                /// 
                /// If no response is received from a backend server during the request timeout period, CLB sends the `HTTP 504` status code to the client.
                /// </summary>
                [NameInMap("RequestTimeout")]
                [Validation(Required=false)]
                public int? RequestTimeout { get; set; }

                /// <summary>
                /// The ID of the server certificate.
                /// </summary>
                [NameInMap("ServerCertificateId")]
                [Validation(Required=false)]
                public string ServerCertificateId { get; set; }

                /// <summary>
                /// Indicates whether session persistence is enabled. Valid values:
                /// 
                /// *   **on**: yes
                /// *   **off**: no
                /// </summary>
                [NameInMap("StickySession")]
                [Validation(Required=false)]
                public string StickySession { get; set; }

                /// <summary>
                /// The method that is used to handle a cookie.
                /// 
                /// *   **insert**: inserts a cookie. CLB inserts a cookie (SERVERID) into the first HTTP or HTTPS response that is sent to a client. The next request from the client contains this cookie, and the listener forwards this request to the recorded backend server.
                /// *   **server**: rewrites a cookie. When CLB detects a user-defined cookie, it overwrites the original cookie with the user-defined cookie. The next request from the client carries the user-defined cookie, and the listener will distribute the request to the recorded backend server.
                /// </summary>
                [NameInMap("StickySessionType")]
                [Validation(Required=false)]
                public string StickySessionType { get; set; }

                /// <summary>
                /// The Transport Layer Security (TLS) security policy. Each security policy contains TLS protocol versions and cipher suites available for HTTPS.
                /// 
                /// *   **tls_cipher_policy_1_0**:
                /// 
                ///     Supported TLS versions: TLS 1.0, TLS 1.1, and TLS 1.2
                /// 
                ///     Supported cipher suites: ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, AES128-GCM-SHA256, AES256-GCM-SHA384, AES128-SHA256, AES256-SHA256, ECDHE-RSA-AES128-SHA, ECDHE-RSA-AES256-SHA, AES128-SHA, AES256-SHA, and DES-CBC3-SHA
                /// 
                /// *   **tls_cipher_policy_1_1**:
                /// 
                ///     Supported TLS versions: TLS 1.1 and TLS 1.2
                /// 
                ///     Supported cipher suites: ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, AES128-GCM-SHA256, AES256-GCM-SHA384, AES128-SHA256, AES256-SHA256, ECDHE-RSA-AES128-SHA, ECDHE-RSA-AES256-SHA, AES128-SHA, AES256-SHA, and DES-CBC3-SHA
                /// 
                /// *   **tls_cipher_policy_1_2**
                /// 
                ///     Supported TLS version: TLS 1.2
                /// 
                ///     Supported cipher suites: ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, AES128-GCM-SHA256, AES256-GCM-SHA384, AES128-SHA256, AES256-SHA256, ECDHE-RSA-AES128-SHA, ECDHE-RSA-AES256-SHA, AES128-SHA, AES256-SHA, and DES-CBC3-SHA
                /// 
                /// *   **tls_cipher_policy_1_2_strict**
                /// 
                ///     Supported TLS version: TLS 1.2
                /// 
                ///     Supported cipher suites: ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, ECDHE-RSA-AES128-SHA, and ECDHE-RSA-AES256-SHA
                /// 
                /// *   **tls_cipher_policy_1_2_strict_with_1_3**
                /// 
                ///     Supported TLS versions: TLS 1.2 and TLS 1.3
                /// 
                ///     Supported cipher suites: TLS_AES_128_GCM_SHA256, TLS_AES_256_GCM_SHA384, TLS_CHACHA20_POLY1305_SHA256, TLS_AES_128_CCM_SHA256, TLS_AES_128_CCM_8_SHA256, ECDHE-ECDSA-AES128-GCM-SHA256, ECDHE-ECDSA-AES256-GCM-SHA384, ECDHE-ECDSA-AES128-SHA256, ECDHE-ECDSA-AES256-SHA384, ECDHE-RSA-AES128-GCM-SHA256, ECDHE-RSA-AES256-GCM-SHA384, ECDHE-RSA-AES128-SHA256, ECDHE-RSA-AES256-SHA384, ECDHE-ECDSA-AES128-SHA, ECDHE-ECDSA-AES256-SHA, ECDHE-RSA-AES128-SHA, and ECDHE-RSA-AES256-SHA
                /// </summary>
                [NameInMap("TLSCipherPolicy")]
                [Validation(Required=false)]
                public string TLSCipherPolicy { get; set; }

                /// <summary>
                /// The number of times that a healthy backend server must consecutively fail health checks before it is declared unhealthy. In this case, the health status is changed from **success** to **fail**.
                /// 
                /// Valid values: **2** to **10**.
                /// </summary>
                [NameInMap("UnhealthyThreshold")]
                [Validation(Required=false)]
                public int? UnhealthyThreshold { get; set; }

                /// <summary>
                /// Indicates whether the `XForwardedFor` header is used to retrieve client IP addresses. Valid values:
                /// 
                /// *   **on**: yes
                /// *   **off**: no
                /// </summary>
                [NameInMap("XForwardedFor")]
                [Validation(Required=false)]
                public string XForwardedFor { get; set; }

                /// <summary>
                /// Indicates whether the `XForwardedFor_ClientCertClientVerify` header is used to retrieve the verification result of the client certificate. Valid values:
                /// 
                /// *   **on**: yes
                /// *   **off**: no
                /// </summary>
                [NameInMap("XForwardedFor_ClientCertClientVerify")]
                [Validation(Required=false)]
                public string XForwardedFor_ClientCertClientVerify { get; set; }

                /// <summary>
                /// Indicates whether the `XForwardedFor_ClientCertFingerprint` header is used to retrieve the fingerprint of the client certificate. Valid values:
                /// 
                /// *   **on**: yes
                /// *   **off**: no
                /// </summary>
                [NameInMap("XForwardedFor_ClientCertFingerprint")]
                [Validation(Required=false)]
                public string XForwardedFor_ClientCertFingerprint { get; set; }

                /// <summary>
                /// Indicates whether the `XForwardedFor_ClientCertIssuerDN` header is used to retrieve information about the authority that issues the client certificate. Valid values:
                /// 
                /// *   **on**: yes
                /// *   **off**: no
                /// </summary>
                [NameInMap("XForwardedFor_ClientCertIssuerDN")]
                [Validation(Required=false)]
                public string XForwardedFor_ClientCertIssuerDN { get; set; }

                /// <summary>
                /// Indicates whether the `XForwardedFor_ClientCertSubjectDN` header is used to retrieve information about the owner of the client certificate. Valid values:
                /// 
                /// *   **on**: yes
                /// *   **off**: no
                /// </summary>
                [NameInMap("XForwardedFor_ClientCertSubjectDN")]
                [Validation(Required=false)]
                public string XForwardedFor_ClientCertSubjectDN { get; set; }

                /// <summary>
                /// Indicates whether the `XForwardedFor_ClientSrcPort` header is used to retrieve the client port. Valid values:
                /// 
                /// *   **on**: yes
                /// *   **off**: no
                /// </summary>
                [NameInMap("XForwardedFor_ClientSrcPort")]
                [Validation(Required=false)]
                public string XForwardedFor_ClientSrcPort { get; set; }

                /// <summary>
                /// Indicates whether the `SLB-ID` header is used to retrieve the ID of the CLB instance. Valid values:
                /// 
                /// *   **on**: yes
                /// *   **off**: no
                /// </summary>
                [NameInMap("XForwardedFor_SLBID")]
                [Validation(Required=false)]
                public string XForwardedFor_SLBID { get; set; }

                /// <summary>
                /// Indicates whether the `SLB-IP` header is used to retrieve the virtual IP address requested by the client. Valid values:
                /// 
                /// *   **on**: yes
                /// *   **off**: no
                /// </summary>
                [NameInMap("XForwardedFor_SLBIP")]
                [Validation(Required=false)]
                public string XForwardedFor_SLBIP { get; set; }

                /// <summary>
                /// Indicates whether the `XForwardedFor_SLBPORT` header is used to retrieve the listening port. Valid values:
                /// 
                /// *   **on**: yes
                /// *   **off**: no
                /// </summary>
                [NameInMap("XForwardedFor_SLBPORT")]
                [Validation(Required=false)]
                public string XForwardedFor_SLBPORT { get; set; }

                /// <summary>
                /// Indicates whether the `X-Forwarded-Proto` header is used to retrieve the listening protocol. Valid values:
                /// 
                /// *   **on**: yes
                /// *   **off**: no
                /// </summary>
                [NameInMap("XForwardedFor_proto")]
                [Validation(Required=false)]
                public string XForwardedFor_proto { get; set; }

            }

            /// <summary>
            /// The listening port.
            /// </summary>
            [NameInMap("ListenerPort")]
            [Validation(Required=false)]
            public int? ListenerPort { get; set; }

            /// <summary>
            /// The protocol used by the listener.
            /// </summary>
            [NameInMap("ListenerProtocol")]
            [Validation(Required=false)]
            public string ListenerProtocol { get; set; }

            /// <summary>
            /// The ID of the CLB instance.
            /// </summary>
            [NameInMap("LoadBalancerId")]
            [Validation(Required=false)]
            public string LoadBalancerId { get; set; }

            /// <summary>
            /// The scheduling algorithm. Valid values:
            /// 
            /// *   **wrr**: Backend servers with higher weights receive more requests than those with lower weights.
            /// *   **rr**: Requests are distributed to backend servers in sequence.
            /// </summary>
            [NameInMap("Scheduler")]
            [Validation(Required=false)]
            public string Scheduler { get; set; }

            /// <summary>
            /// The status of the listener. Valid values:
            /// 
            /// *   **running**: The listener runs as expected.
            /// *   **stopped**: The listener is disabled.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The configuration of the TCP listener.
            /// </summary>
            [NameInMap("TCPListenerConfig")]
            [Validation(Required=false)]
            public DescribeLoadBalancerListenersResponseBodyListenersTCPListenerConfig TCPListenerConfig { get; set; }
            public class DescribeLoadBalancerListenersResponseBodyListenersTCPListenerConfig : TeaModel {
                /// <summary>
                /// Indicates whether connection draining is enabled. Valid values:
                /// 
                /// *   **on**: yes
                /// *   **off**: no
                /// </summary>
                [NameInMap("ConnectionDrain")]
                [Validation(Required=false)]
                public string ConnectionDrain { get; set; }

                /// <summary>
                /// The timeout period of connection draining. Unit: seconds.
                /// 
                /// Value values: **10 to 900**.
                /// </summary>
                [NameInMap("ConnectionDrainTimeout")]
                [Validation(Required=false)]
                public int? ConnectionDrainTimeout { get; set; }

                /// <summary>
                /// The timeout period of a connection. Unit: seconds.
                /// </summary>
                [NameInMap("EstablishedTimeout")]
                [Validation(Required=false)]
                public int? EstablishedTimeout { get; set; }

                /// <summary>
                /// Indicates whether the health check feature is enabled. Valid values:
                /// 
                /// *   **on**: yes
                /// *   **off**: no
                /// </summary>
                [NameInMap("HealthCheck")]
                [Validation(Required=false)]
                public string HealthCheck { get; set; }

                /// <summary>
                /// The port that is used for health checks.
                /// </summary>
                [NameInMap("HealthCheckConnectPort")]
                [Validation(Required=false)]
                public int? HealthCheckConnectPort { get; set; }

                /// <summary>
                /// The timeout period of health checks. Unit: seconds.
                /// 
                /// Valid values: **1** to **300**.
                /// </summary>
                [NameInMap("HealthCheckConnectTimeout")]
                [Validation(Required=false)]
                public int? HealthCheckConnectTimeout { get; set; }

                /// <summary>
                /// The domain name that is used for health checks.
                /// </summary>
                [NameInMap("HealthCheckDomain")]
                [Validation(Required=false)]
                public string HealthCheckDomain { get; set; }

                /// <summary>
                /// The HTTP status codes that are used to determine whether the backend server passes the health check.
                /// </summary>
                [NameInMap("HealthCheckHttpCode")]
                [Validation(Required=false)]
                public string HealthCheckHttpCode { get; set; }

                /// <summary>
                /// The interval between two consecutive health checks. Unit: seconds.
                /// </summary>
                [NameInMap("HealthCheckInterval")]
                [Validation(Required=false)]
                public int? HealthCheckInterval { get; set; }

                /// <summary>
                /// The health check method.
                /// </summary>
                [NameInMap("HealthCheckMethod")]
                [Validation(Required=false)]
                public string HealthCheckMethod { get; set; }

                /// <summary>
                /// The protocol that is used for health checks.
                /// </summary>
                [NameInMap("HealthCheckType")]
                [Validation(Required=false)]
                public string HealthCheckType { get; set; }

                /// <summary>
                /// The URI that is used for health checks.
                /// </summary>
                [NameInMap("HealthCheckURI")]
                [Validation(Required=false)]
                public string HealthCheckURI { get; set; }

                /// <summary>
                /// The number of times that an unhealthy backend server must consecutively pass health checks before it is declared healthy. In this case, the health status is changed from **fail** to **success**.
                /// 
                /// Valid values: **2** to **10**.
                /// </summary>
                [NameInMap("HealthyThreshold")]
                [Validation(Required=false)]
                public int? HealthyThreshold { get; set; }

                /// <summary>
                /// The ID of the primary/secondary server group that is associated with the listener.
                /// </summary>
                [NameInMap("MasterSlaveServerGroupId")]
                [Validation(Required=false)]
                public string MasterSlaveServerGroupId { get; set; }

                /// <summary>
                /// Indicates whether session persistence is enabled. Unit: seconds.
                /// 
                /// Valid values: **0** to **3600**.
                /// 
                /// **0** indicates that session persistence is disabled.
                /// </summary>
                [NameInMap("PersistenceTimeout")]
                [Validation(Required=false)]
                public int? PersistenceTimeout { get; set; }

                /// <summary>
                /// Indicates whether the Proxy protocol is used to pass client IP addresses to backend servers. Valid values:
                /// 
                /// *   **true**: yes
                /// *   **false**: no
                /// </summary>
                [NameInMap("ProxyProtocolV2Enabled")]
                [Validation(Required=false)]
                public string ProxyProtocolV2Enabled { get; set; }

                /// <summary>
                /// The number of times that a healthy backend server must consecutively fail health checks before it is declared unhealthy. In this case, the health status is changed from **success** to **fail**.
                /// 
                /// Valid values: **2** to **10**.
                /// </summary>
                [NameInMap("UnhealthyThreshold")]
                [Validation(Required=false)]
                public int? UnhealthyThreshold { get; set; }

            }

            /// <summary>
            /// The tags.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeLoadBalancerListenersResponseBodyListenersTags> Tags { get; set; }
            public class DescribeLoadBalancerListenersResponseBodyListenersTags : TeaModel {
                /// <summary>
                /// The tag key.
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// The tag value.
                /// 
                /// For more information about how to obtain a tag value, see [DescribeTagKeyList](https://help.aliyun.com/document_detail/145557.html).
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// The configuration of the UDP listener.
            /// </summary>
            [NameInMap("UDPListenerConfig")]
            [Validation(Required=false)]
            public DescribeLoadBalancerListenersResponseBodyListenersUDPListenerConfig UDPListenerConfig { get; set; }
            public class DescribeLoadBalancerListenersResponseBodyListenersUDPListenerConfig : TeaModel {
                /// <summary>
                /// Indicates whether connection draining is enabled. Valid values:
                /// 
                /// *   **on**: yes
                /// *   **off**: no
                /// </summary>
                [NameInMap("ConnectionDrain")]
                [Validation(Required=false)]
                public string ConnectionDrain { get; set; }

                /// <summary>
                /// The timeout period of connection draining. Unit: seconds.
                /// 
                /// Value values: **10 to 900**.
                /// </summary>
                [NameInMap("ConnectionDrainTimeout")]
                [Validation(Required=false)]
                public int? ConnectionDrainTimeout { get; set; }

                /// <summary>
                /// Indicates whether the health check feature is enabled. Valid values:
                /// 
                /// *   **on**: yes
                /// *   **off**: no
                /// </summary>
                [NameInMap("HealthCheck")]
                [Validation(Required=false)]
                public string HealthCheck { get; set; }

                /// <summary>
                /// The port that is used for health checks.
                /// </summary>
                [NameInMap("HealthCheckConnectPort")]
                [Validation(Required=false)]
                public int? HealthCheckConnectPort { get; set; }

                /// <summary>
                /// The timeout period for a health check response.
                /// </summary>
                [NameInMap("HealthCheckConnectTimeout")]
                [Validation(Required=false)]
                public int? HealthCheckConnectTimeout { get; set; }

                /// <summary>
                /// The response string for UDP listener health checks.
                /// </summary>
                [NameInMap("HealthCheckExp")]
                [Validation(Required=false)]
                public string HealthCheckExp { get; set; }

                /// <summary>
                /// The interval between two consecutive health checks. Unit: seconds.
                /// </summary>
                [NameInMap("HealthCheckInterval")]
                [Validation(Required=false)]
                public int? HealthCheckInterval { get; set; }

                /// <summary>
                /// The request string for UDP listener health checks.
                /// </summary>
                [NameInMap("HealthCheckReq")]
                [Validation(Required=false)]
                public string HealthCheckReq { get; set; }

                /// <summary>
                /// The number of times that a backend server must consecutively pass health checks before it is declared healthy.
                /// </summary>
                [NameInMap("HealthyThreshold")]
                [Validation(Required=false)]
                public int? HealthyThreshold { get; set; }

                /// <summary>
                /// The ID of the primary/secondary server group that is associated with the listener.
                /// </summary>
                [NameInMap("MasterSlaveServerGroupId")]
                [Validation(Required=false)]
                public string MasterSlaveServerGroupId { get; set; }

                /// <summary>
                /// Indicates whether the Proxy protocol is used to pass client IP addresses to backend servers. Valid values:
                /// 
                /// *   **true**: yes
                /// *   **false**: no
                /// </summary>
                [NameInMap("ProxyProtocolV2Enabled")]
                [Validation(Required=false)]
                public string ProxyProtocolV2Enabled { get; set; }

                /// <summary>
                /// The number of times that a backend server must consecutively fail health checks before it is declared unhealthy.
                /// </summary>
                [NameInMap("UnhealthyThreshold")]
                [Validation(Required=false)]
                public int? UnhealthyThreshold { get; set; }

            }

            /// <summary>
            /// The ID of the vServer group that is associated with the listener.
            /// </summary>
            [NameInMap("VServerGroupId")]
            [Validation(Required=false)]
            public string VServerGroupId { get; set; }

        }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token that determines the start point of the query. Valid values:
        /// 
        /// *   If **NextToken** is empty, it indicates that no subsequent query is to be sent.
        /// *   If a value is returned for **NextToken**, the value is the token that determines the start point of the next query.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

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
