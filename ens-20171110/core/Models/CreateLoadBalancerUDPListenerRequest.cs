// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateLoadBalancerUDPListenerRequest : TeaModel {
        /// <summary>
        /// The backend port that is used by the ELB instance. Valid values: **1** to **65535**.
        /// </summary>
        [NameInMap("BackendServerPort")]
        [Validation(Required=false)]
        public int? BackendServerPort { get; set; }

        /// <summary>
        /// The description of the listener. The description must be **1** to **80** characters in length.
        /// 
        /// >  The value cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies whether to enable elastic IP address (EIP) pass-through. Valid values:
        /// 
        /// *   **on**
        /// *   **off** (default)
        /// </summary>
        [NameInMap("EipTransmit")]
        [Validation(Required=false)]
        public string EipTransmit { get; set; }

        /// <summary>
        /// The port that is used for health checks. Valid values: **1** to **65535**. If you leave this parameter empty, the port specified by BackendServerPort is used for health checks.
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
        /// >  If the value that you specified for HealthCheckConnectTimeout is smaller than the value of HealthCheckInterval, HealthCheckConnectTimeout becomes invalid and the timeout period that you specified for HealthCheckInterval is used.
        /// </summary>
        [NameInMap("HealthCheckConnectTimeout")]
        [Validation(Required=false)]
        public int? HealthCheckConnectTimeout { get; set; }

        /// <summary>
        /// The response string for UDP listener health checks. The string can be up to 64 characters in length and can contain only letters and digits.
        /// </summary>
        [NameInMap("HealthCheckExp")]
        [Validation(Required=false)]
        public string HealthCheckExp { get; set; }

        /// <summary>
        /// The interval at which health checks are performed. Valid values: **1** to **50**. Default value: **2**. Unit: seconds.
        /// </summary>
        [NameInMap("HealthCheckInterval")]
        [Validation(Required=false)]
        public int? HealthCheckInterval { get; set; }

        /// <summary>
        /// The request string for UDP listener health checks. The string can be up to 64 characters in length and can contain only letters and digits.
        /// </summary>
        [NameInMap("HealthCheckReq")]
        [Validation(Required=false)]
        public string HealthCheckReq { get; set; }

        /// <summary>
        /// The number of consecutive successful health checks that must occur before an unhealthy and inaccessible backend server is declared healthy and accessible. Valid values: **2** to **10**. Default value: **3**.
        /// </summary>
        [NameInMap("HealthyThreshold")]
        [Validation(Required=false)]
        public int? HealthyThreshold { get; set; }

        /// <summary>
        /// The frontend port that is used by the ELB instance. Valid values: **1** to **65535**.
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
        /// The number of consecutive failed health checks that must occur before a healthy and accessible backend server is declared unhealthy and inaccessible. Valid values: **2** to **10**. Default value: **3**.
        /// </summary>
        [NameInMap("UnhealthyThreshold")]
        [Validation(Required=false)]
        public int? UnhealthyThreshold { get; set; }

    }

}
