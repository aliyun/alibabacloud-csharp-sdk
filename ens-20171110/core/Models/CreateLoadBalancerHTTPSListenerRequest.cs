// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateLoadBalancerHTTPSListenerRequest : TeaModel {
        /// <summary>
        /// The listening port that is used by the backend instances. Valid values: 1 to 65535.
        /// </summary>
        [NameInMap("BackendServerPort")]
        [Validation(Required=false)]
        public int? BackendServerPort { get; set; }

        /// <summary>
        /// The cookie that is configured on the server. The cookie must be **1** to **200** characters in length and contain only ASCII characters and digits.
        /// 
        /// >  This parameter is required if you set StickySession to on and StickySessionType to server.
        /// </summary>
        [NameInMap("Cookie")]
        [Validation(Required=false)]
        public string Cookie { get; set; }

        /// <summary>
        /// The timeout period of a cookie. Valid values: **1** to **86400**. Unit: seconds.
        /// 
        /// >  This parameter is required if you set StickySession to on and StickySessionType to insert.
        /// </summary>
        [NameInMap("CookieTimeout")]
        [Validation(Required=false)]
        public int? CookieTimeout { get; set; }

        /// <summary>
        /// The description of the listener. The description must be **1** to **80** characters in length.
        /// 
        /// >  The value cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The listener port that is used to redirect HTTP requests to HTTPS.
        /// </summary>
        [NameInMap("ForwardPort")]
        [Validation(Required=false)]
        public int? ForwardPort { get; set; }

        /// <summary>
        /// Specifies whether to enable the health check feature. Valid values:
        /// 
        /// *   **on**
        /// *   **off**
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("HealthCheck")]
        [Validation(Required=false)]
        public string HealthCheck { get; set; }

        /// <summary>
        /// The port that is used for health checks. Valid values: **1** to **65535**. If you leave this parameter empty, the port specified by BackendServerPort is used for health checks.
        /// 
        /// >  This parameter takes effect only if you set HealthCheck to on.
        /// </summary>
        [NameInMap("HealthCheckConnectPort")]
        [Validation(Required=false)]
        public int? HealthCheckConnectPort { get; set; }

        /// <summary>
        /// The domain name that you want to use for health checks.
        /// 
        /// >  This parameter takes effect only if you set HealthCheck to on.
        /// </summary>
        [NameInMap("HealthCheckDomain")]
        [Validation(Required=false)]
        public string HealthCheckDomain { get; set; }

        /// <summary>
        /// The HTTP status code for a successful health check. Valid values:
        /// 
        /// *   **http_2xx** (default)
        /// *   **http_3xx**
        /// *   **http_4xx**
        /// *   **http_5xx**
        /// 
        /// >  This parameter takes effect only if you set HealthCheck to on.
        /// </summary>
        [NameInMap("HealthCheckHttpCode")]
        [Validation(Required=false)]
        public string HealthCheckHttpCode { get; set; }

        /// <summary>
        /// The interval at which health checks are performed. Valid values: **1** to **50**. Default value: **2**. Unit: seconds.
        /// 
        /// >  This parameter takes effect only if you set HealthCheck to on.
        /// </summary>
        [NameInMap("HealthCheckInterval")]
        [Validation(Required=false)]
        public int? HealthCheckInterval { get; set; }

        /// <summary>
        /// The health check method used by HTTP listeners. Valid values:
        /// 
        /// *   **head** (default): requests the head of the page.
        /// *   **get**: requests the specified part of the page and returns the entity body.
        /// 
        /// >  This parameter takes effect only if you set HealthCheck to on.
        /// </summary>
        [NameInMap("HealthCheckMethod")]
        [Validation(Required=false)]
        public string HealthCheckMethod { get; set; }

        /// <summary>
        /// The timeout period of a health check response. If a backend server does not respond within the specified timeout period, the server fails to pass the health check.
        /// 
        /// *   Default value: 5.
        /// *   Valid values: **1** to **300**.
        /// *   Unit: seconds.
        /// 
        /// > 
        /// 
        /// *   This parameter takes effect only if the HealthCheck parameter is set to on.
        /// 
        /// *   If the value of HealthCheckTimeout is smaller than the value of HealthCheckInterval, the timeout period specified by HealthCheckTimeout becomes invalid, and the value of HealthCheckInterval is used as the timeout period.
        /// </summary>
        [NameInMap("HealthCheckTimeout")]
        [Validation(Required=false)]
        public int? HealthCheckTimeout { get; set; }

        /// <summary>
        /// The URI used for health checks. The URI must be **1** to **80** characters in length.
        /// 
        /// >  A URL must start with a forward slash (`/`) but cannot contain only forward slashes (`/`).
        /// </summary>
        [NameInMap("HealthCheckURI")]
        [Validation(Required=false)]
        public string HealthCheckURI { get; set; }

        /// <summary>
        /// The number of consecutive successful health checks that must occur before an unhealthy and inaccessible backend server is declared healthy and accessible. Valid values: **2** to **10**. Default value: **3**.
        /// 
        /// >  This parameter takes effect only if you set HealthCheck to on.
        /// </summary>
        [NameInMap("HealthyThreshold")]
        [Validation(Required=false)]
        public int? HealthyThreshold { get; set; }

        /// <summary>
        /// The timeout period for idle connections. Default value: 15. Valid values: **1** to **60**. Unit: seconds.
        /// 
        /// >  If no request is received within the specified timeout period, ELB closes the connection. When another request is received, ELB establishes a new connection.
        /// </summary>
        [NameInMap("IdleTimeout")]
        [Validation(Required=false)]
        public int? IdleTimeout { get; set; }

        /// <summary>
        /// Specifies whether to enable HTTP-to-HTTPS redirection. Valid values:
        /// 
        /// *   **on**
        /// *   **off** (default)
        /// </summary>
        [NameInMap("ListenerForward")]
        [Validation(Required=false)]
        public string ListenerForward { get; set; }

        /// <summary>
        /// The listening port that is used by Edge Load Balancer (ELB) to receive requests and forward the requests to backend servers. Valid values: **1** to **65535**.
        /// 
        /// >  We recommend that you use port 443 for HTTPS.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ListenerPort")]
        [Validation(Required=false)]
        public int? ListenerPort { get; set; }

        /// <summary>
        /// The ID of the Edge Load Balancer (ELB) instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// The timeout period of requests. Default value: 60. Valid values: **1** to **180**. Unit: seconds.
        /// 
        /// >  If no response is received from the backend server within the specified timeout period, ELB returns an HTTP 504 error code to the client.
        /// </summary>
        [NameInMap("RequestTimeout")]
        [Validation(Required=false)]
        public int? RequestTimeout { get; set; }

        /// <summary>
        /// The routing algorithm. Valid values:
        /// 
        /// *   **wrr** (default): Backend servers with higher weights receive more requests than backend servers with lower weights.
        /// *   **wlc**: Requests are distributed based on the weight and load of each backend server. The load refers to the number of connections on a backend server. If two backend servers have the same weight, the backend server that has fewer connections receives more requests.
        /// *   **rr**: Requests are distributed to backend servers in sequence.
        /// *   **sch**: consistent hashing that is based on source IP addresses. Requests from the same source IP address are distributed to the same backend server.
        /// *   **qch**: consistent hashing that is based on QUIC connection IDs. Requests that contain the same QUIC connection ID are distributed to the same backend server.
        /// *   **iqch**: consistent hashing that is based on specific three bytes of the iQUIC CIDs. Requests whose second to fourth bytes are the same are distributed to the same backend server.
        /// </summary>
        [NameInMap("Scheduler")]
        [Validation(Required=false)]
        public string Scheduler { get; set; }

        /// <summary>
        /// The ID of the server certificate.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ServerCertificateId")]
        [Validation(Required=false)]
        public string ServerCertificateId { get; set; }

        /// <summary>
        /// The method that is used to handle a cookie. Valid values:
        /// 
        /// *   **insert**: inserts a cookie. ELB inserts a session cookie (SERVERID) into the first HTTP or HTTPS response that is sent to a client. Subsequent requests to ELB carry this cookie, and ELB determines the destination servers of the requests based on the cookies.
        /// *   **server**: rewrites a cookie. When ELB detects a user-defined cookie, it overwrites the original cookie with the user-defined cookie. The next request from the client carries the user-defined cookie, and the listener forwards this request to the recorded backend server.
        /// 
        /// >  This parameter is required if you set StickySession to on.
        /// </summary>
        [NameInMap("StickySessionType")]
        [Validation(Required=false)]
        public string StickySessionType { get; set; }

        /// <summary>
        /// The number of consecutive failed health checks that must occur before a healthy and accessible backend server is declared unhealthy and inaccessible. Valid values: **2** to **10**. Default value: **3**.
        /// 
        /// >  This parameter takes effect only if you set HealthCheck to on.
        /// </summary>
        [NameInMap("UnhealthyThreshold")]
        [Validation(Required=false)]
        public int? UnhealthyThreshold { get; set; }

    }

}
