// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeRuleAttributeResponseBody : TeaModel {
        /// <summary>
        /// The cookie to be configured on the backend server.
        /// 
        /// The cookie must be 1 to 200 characters in length and can contain ASCII letters and digits. It cannot contain commas (,), semicolons (;), or whitespace characters. It cannot start with a dollar sign ($).
        /// 
        /// If you set the **StickySession** parameter to **on** and the **StickySessionType** parameter to **server**, this parameter is required.
        /// </summary>
        [NameInMap("Cookie")]
        [Validation(Required=false)]
        public string Cookie { get; set; }

        /// <summary>
        /// The timeout period of a cookie.
        /// 
        /// Valid values: **1 to 86400**. Unit: seconds.
        /// 
        /// >  If you set the **StickySession** parameter to **on** and the **StickySessionType** parameter to **insert**, this parameter is required.
        /// </summary>
        [NameInMap("CookieTimeout")]
        [Validation(Required=false)]
        public int? CookieTimeout { get; set; }

        /// <summary>
        /// The domain name that is configured in the forwarding rule.
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// Specifies whether to enable health checks.
        /// 
        /// Valid values: **on** and **off**.
        /// 
        /// >  If you set the **ListenerSync** parameter to **off**, this parameter is required. If you set the parameter to **on**, the configuration of the listener is used.
        /// </summary>
        [NameInMap("HealthCheck")]
        [Validation(Required=false)]
        public string HealthCheck { get; set; }

        /// <summary>
        /// The port of the backend server that is used for health checks.
        /// 
        /// Valid values: **1** to **65535**.
        /// 
        /// >  If you set the **HealthCheck** parameter to **on**, this parameter is required. If you left this parameter empty and the **HealthCheck** parameter is set to **on**, the backend port configuration of the listener is used by default.
        /// </summary>
        [NameInMap("HealthCheckConnectPort")]
        [Validation(Required=false)]
        public int? HealthCheckConnectPort { get; set; }

        /// <summary>
        /// The domain name that is used for health checks. Valid values:
        /// 
        /// *   **$\_ip**: The private IP address of the backend server. If the $\_ip parameter is set or the HealthCheckDomain parameter is not set, SLB uses the private IP addresses of backend servers as the domain names for health checks.
        /// *   **domain**: The domain name must be 1 to 80 characters in length. It can contain only letters, digits, periods (.),and hyphens (-).
        /// 
        /// >  If you set the **HealthCheck** parameter to **on**, this parameter is required.
        /// </summary>
        [NameInMap("HealthCheckDomain")]
        [Validation(Required=false)]
        public string HealthCheckDomain { get; set; }

        /// <summary>
        /// The HTTP status code that indicates a successful health check. Separate multiple HTTP status codes with commas (,). Default value: **http\_2xx**.
        /// 
        /// Valid values: **http\_2xx**, **http\_3xx**, **http\_4xx**, and **http\_5xx**.
        /// 
        /// >  If you set the **HealthCheck** parameter to **on**, this parameter is required.
        /// </summary>
        [NameInMap("HealthCheckHttpCode")]
        [Validation(Required=false)]
        public string HealthCheckHttpCode { get; set; }

        /// <summary>
        /// The time interval between two consecutive health checks.
        /// 
        /// Valid values: **1** to **50**. Unit: seconds.
        /// 
        /// >  If you set the **HealthCheck** parameter to **on**, this parameter is required.
        /// </summary>
        [NameInMap("HealthCheckInterval")]
        [Validation(Required=false)]
        public int? HealthCheckInterval { get; set; }

        /// <summary>
        /// The timeout period of a health check response. If a backend ECS instance does not send an expected response within the specified period of time, the ECS instance is considered unhealthy.
        /// 
        /// Valid values: **1** to **300**. Unit: seconds.
        /// 
        /// >  If the value of the **HealthCHeckTimeout** parameter is smaller than that of the **HealthCheckInterval** parameter, the value of the **HealthCHeckTimeout** parameter is ignored and the value of the **HealthCheckInterval** parameter is regarded as the waiting period. If you set the **HealthCheck** parameter to **on**, this parameter is required.
        /// </summary>
        [NameInMap("HealthCheckTimeout")]
        [Validation(Required=false)]
        public int? HealthCheckTimeout { get; set; }

        /// <summary>
        /// The URI that is used for health checks.
        /// 
        /// >  If you set the **HealthCheck** parameter to **on**, this parameter is required.
        /// </summary>
        [NameInMap("HealthCheckURI")]
        [Validation(Required=false)]
        public string HealthCheckURI { get; set; }

        /// <summary>
        /// The number of consecutive successful health checks that must occur before an unhealthy backend server is declared healthy. In this case, the health check state is changed from **fail** to **success**.
        /// 
        /// Valid values: **2** to **10**.
        /// 
        /// >  If you set the **HealthCheck** parameter to **on**, this parameter is required.
        /// </summary>
        [NameInMap("HealthyThreshold")]
        [Validation(Required=false)]
        public int? HealthyThreshold { get; set; }

        /// <summary>
        /// The listener port that is used by the SLB instance.
        /// </summary>
        [NameInMap("ListenerPort")]
        [Validation(Required=false)]
        public string ListenerPort { get; set; }

        /// <summary>
        /// Indicates whether the forwarding rule uses the scheduling algorithm, session persistence, and health check configurations of the listener.
        /// 
        /// Valid values: **on** and **off**.
        /// 
        /// *   **off**: does not use the configurations of the listener. You can customize health check and session persistence configurations for the forwarding rule.
        /// *   **on**: uses the configurations of the listener.
        /// </summary>
        [NameInMap("ListenerSync")]
        [Validation(Required=false)]
        public string ListenerSync { get; set; }

        /// <summary>
        /// The ID of the SLB instance.
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the forwarding rule.
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

        /// <summary>
        /// The name of the forwarding rule.
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// The scheduling algorithm. Valid values:
        /// 
        /// *   **wrr** (default): Backend servers that have higher weights receive more requests than backend servers that have lower weights.
        /// *   **rr**: Requests are distributed to backend servers in sequence.
        /// 
        /// >  If you set the **ListenerSync** parameter to **off**, this parameter is required. If you set the parameter to **on**, the configuration of the listener is used.
        /// </summary>
        [NameInMap("Scheduler")]
        [Validation(Required=false)]
        public string Scheduler { get; set; }

        /// <summary>
        /// Indicates whether session persistence is enabled.
        /// 
        /// Valid values: **on** and **off**.
        /// 
        /// >  If you set the **ListenerSync** parameter to **off**, this parameter is required. If you set the parameter to **on**, the configuration of the listener is used.
        /// </summary>
        [NameInMap("StickySession")]
        [Validation(Required=false)]
        public string StickySession { get; set; }

        /// <summary>
        /// The method that is used to handle a cookie. Valid values:
        /// 
        /// *   **insert**: inserts a cookie into the response. SLB inserts a cookie (SERVERID) into the first HTTP or HTTPS response packet that is sent to a client. The next request from the client will contain this cookie, and the listener will distribute this request to the recorded backend server.
        /// *   **server**: rewrites a cookie. When SLB detects a user-defined cookie, SLB overwrites the original cookie with the user-defined cookie. The next request from the client contains the user-defined cookie, and the listener distributes the request to the recorded backend server.
        /// 
        /// >  If you set the **StickySession** parameter to **on**, this parameter is required.
        /// </summary>
        [NameInMap("StickySessionType")]
        [Validation(Required=false)]
        public string StickySessionType { get; set; }

        /// <summary>
        /// The number of consecutive failed health checks that must occur before a healthy backend server is declared unhealthy. In this case, the health check state is changed from **success** to **fail**.
        /// 
        /// Valid values: **2** to **10**.
        /// 
        /// >  If you set the **HealthCheck** parameter to **on**, this parameter is required.
        /// </summary>
        [NameInMap("UnhealthyThreshold")]
        [Validation(Required=false)]
        public int? UnhealthyThreshold { get; set; }

        /// <summary>
        /// The URL that is configured in the forwarding rule.
        /// </summary>
        [NameInMap("Url")]
        [Validation(Required=false)]
        public string Url { get; set; }

        /// <summary>
        /// The ID of the vServer group that is associated with the forwarding rule.
        /// </summary>
        [NameInMap("VServerGroupId")]
        [Validation(Required=false)]
        public string VServerGroupId { get; set; }

    }

}
