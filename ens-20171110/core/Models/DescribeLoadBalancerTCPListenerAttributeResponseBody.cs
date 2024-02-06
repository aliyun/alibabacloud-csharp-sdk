// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeLoadBalancerTCPListenerAttributeResponseBody : TeaModel {
        /// <summary>
        /// The backend port that is used by the ELB instance. Valid values: **1** to **65535**.
        /// </summary>
        [NameInMap("BackendServerPort")]
        [Validation(Required=false)]
        public int? BackendServerPort { get; set; }

        /// <summary>
        /// The maximum bandwidth of the elastic IP address (EIP). Default value: 5. Valid values: **5** to **10000**. Unit: Mbit/s.
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
        /// Indicates whether EIP pass-through is enabled. Valid values:
        /// 
        /// *   **on**
        /// *   **off** (default)
        /// </summary>
        [NameInMap("EipTransmit")]
        [Validation(Required=false)]
        public string EipTransmit { get; set; }

        /// <summary>
        /// The timeout period of a connection. Valid values: **10** to **900**. Unit: seconds.
        /// </summary>
        [NameInMap("EstablishedTimeout")]
        [Validation(Required=false)]
        public int? EstablishedTimeout { get; set; }

        /// <summary>
        /// Indicates whether the health check feature is enabled. Valid values:
        /// 
        /// *   **on**
        /// *   **off**
        /// </summary>
        [NameInMap("HealthCheck")]
        [Validation(Required=false)]
        public string HealthCheck { get; set; }

        /// <summary>
        /// The port that is used for health checks. Valid values: **1** to **65535**. If an empty string is returned for this parameter, the port specified by BackendServerPort is used for health checks.
        /// 
        /// >  This parameter is returned only if you set HealthCheck to on.
        /// </summary>
        [NameInMap("HealthCheckConnectPort")]
        [Validation(Required=false)]
        public int? HealthCheckConnectPort { get; set; }

        /// <summary>
        /// The timeout period of a health check response. If a backend server does not respond within the specified timeout period, the server fails to pass the health check.
        /// 
        /// *   Default value: 5.
        /// *   Valid values: **1** to **300**.
        /// *   Unit: seconds.
        /// 
        /// > 
        /// 
        /// *   This parameter is returned only if you set HealthCheck to on.
        /// 
        /// *   If the value of the HealthCheckConnectTimeout parameter is smaller than that of the HealthCheckInterval parameter, the timeout period specified by the HealthCheckConnectTimeout parameter becomes invalid and the value of the HealthCheckInterval parameter is used as the timeout period.
        /// </summary>
        [NameInMap("HealthCheckConnectTimeout")]
        [Validation(Required=false)]
        public int? HealthCheckConnectTimeout { get; set; }

        /// <summary>
        /// The domain name that is used for health checks.
        /// 
        /// >  This parameter is returned only if you set HealthCheck to on.
        /// </summary>
        [NameInMap("HealthCheckDomain")]
        [Validation(Required=false)]
        public string HealthCheckDomain { get; set; }

        /// <summary>
        /// The HTTP status codes for a successful health check. Valid values:
        /// 
        /// *   **http\_2xx** (default)
        /// *   **http\_3xx**
        /// *   **http\_4xx**
        /// *   **http\_5xx**
        /// 
        /// >  This parameter is returned only if you set HealthCheck to on.
        /// </summary>
        [NameInMap("HealthCheckHttpCode")]
        [Validation(Required=false)]
        public string HealthCheckHttpCode { get; set; }

        /// <summary>
        /// The interval at which health checks are performed. Valid values: **1** to **50**. Unit: seconds.
        /// </summary>
        [NameInMap("HealthCheckInterval")]
        [Validation(Required=false)]
        public int? HealthCheckInterval { get; set; }

        /// <summary>
        /// The type of health checks. Valid values:
        /// 
        /// *   **tcp** (default)
        /// *   **http**
        /// </summary>
        [NameInMap("HealthCheckType")]
        [Validation(Required=false)]
        public string HealthCheckType { get; set; }

        /// <summary>
        /// The Uniform Resource Identifier (URI) that is used for health checks. The URI must be **1** to **80** characters in length.
        /// 
        /// > 
        /// 
        /// *   The URL must start with a forward slash (`/`) and contain characters other than forward slashes (`/`).
        /// 
        /// *   This parameter is returned only if you set HealthCheck to on.
        /// </summary>
        [NameInMap("HealthCheckURI")]
        [Validation(Required=false)]
        public string HealthCheckURI { get; set; }

        /// <summary>
        /// The number of consecutive successful health checks that must occur before an unhealthy and inaccessible backend server is declared healthy and accessible. Valid values: **2** to **10**.
        /// 
        /// >  This parameter is returned only if you set HealthCheck to on.
        /// </summary>
        [NameInMap("HealthyThreshold")]
        [Validation(Required=false)]
        public int? HealthyThreshold { get; set; }

        /// <summary>
        /// The frontend port that is used by the ELB instance.
        /// </summary>
        [NameInMap("ListenerPort")]
        [Validation(Required=false)]
        public int? ListenerPort { get; set; }

        /// <summary>
        /// The timeout period of session persistence.
        /// 
        /// *   Default value: 0. If the default value is used, the system disables session persistence.
        /// *   Valid values: **0** to **3600**.
        /// *   Unit: seconds.
        /// </summary>
        [NameInMap("PersistenceTimeout")]
        [Validation(Required=false)]
        public int? PersistenceTimeout { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The routing algorithm. Valid values:
        /// 
        /// *   **wrr**: Backend servers with higher weights receive more requests than those with lower weights.
        /// *   **wlc**: Requests are distributed based on the weight and load of each backend server. The load refers to the number of connections to a backend server. If two backend servers have the same weight, the backend server that has fewer connections receives more requests.
        /// *   **rr**: Requests are distributed to backend servers in sequence.
        /// *   **sch**: consistent hashing that is based on source IP addresses. Requests from the same source IP address are distributed to the same backend server.
        /// *   **qch**: consistent hashing that is based on QUIC connection IDs. Requests that contain the same QUIC connection ID are distributed to the same backend server.
        /// *   **iqch**: consistent hashing that is based on specific three bytes of the iQUIC CIDs. Requests whose second to fourth bytes are the same are distributed to the same backend server.
        /// </summary>
        [NameInMap("Scheduler")]
        [Validation(Required=false)]
        public string Scheduler { get; set; }

        /// <summary>
        /// The status of the listener. Valid values:
        /// 
        /// *   **Running**
        /// *   **Stopped**
        /// *   **Starting**
        /// *   **Configuring**
        /// *   **Stopping**
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The number of consecutive failed health checks that must occur before a healthy and accessible backend server is declared unhealthy and inaccessible. Valid values: **2** to **10**.
        /// 
        /// >  This parameter is returned only if you set HealthCheck to on.
        /// </summary>
        [NameInMap("UnhealthyThreshold")]
        [Validation(Required=false)]
        public int? UnhealthyThreshold { get; set; }

    }

}
