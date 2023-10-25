// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class SetRuleRequest : TeaModel {
        /// <summary>
        /// The cookie that is configured on the server.
        /// 
        /// The cookie must be 1 to 200 characters in length and can contain only ASCII characters and digits. It cannot contain commas (,), semicolons (;), or space characters. It cannot start with a dollar sign ($).
        /// 
        /// >  This parameter is required and takes effect if **StickySession** is set to **on** and **StickySessionType** is set to **server**.
        /// </summary>
        [NameInMap("Cookie")]
        [Validation(Required=false)]
        public string Cookie { get; set; }

        /// <summary>
        /// The timeout period of a cookie. Unit: seconds. Valid values: **1** to **86400**.
        /// 
        /// >  This parameter is required and takes effect if **StickySession** is set to **on** and **StickySessionType** is set to **insert**.
        /// </summary>
        [NameInMap("CookieTimeout")]
        [Validation(Required=false)]
        public int? CookieTimeout { get; set; }

        /// <summary>
        /// Specifies whether to enable the health check feature. Valid values:
        /// 
        /// *   **on**: yes
        /// *   **off**: no
        /// 
        /// >  This parameter is required and takes effect if the **ListenerSync** parameter is set to **off**.
        /// </summary>
        [NameInMap("HealthCheck")]
        [Validation(Required=false)]
        public string HealthCheck { get; set; }

        /// <summary>
        /// The port that is used for health checks. Valid values: **1** to **65535**.
        /// 
        /// >  This parameter takes effect when the **HealthCheck** parameter is set to **on**.
        /// </summary>
        [NameInMap("HealthCheckConnectPort")]
        [Validation(Required=false)]
        public int? HealthCheckConnectPort { get; set; }

        /// <summary>
        /// The domain name that is used for health checks. Valid values:
        /// 
        /// *   **$\_ip**: the private IP address of a backend server. If you do not set this parameter or set the parameter to $\_ip, the SLB instance uses the private IP address of each backend server for health checks.
        /// *   **domain**: The domain name must be 1 to 80 characters in length, and can contain letters, digits, periods (.), and hyphens (-).
        /// 
        /// >  This parameter takes effect if the **HealthCheck** parameter is set to **on**.
        /// </summary>
        [NameInMap("HealthCheckDomain")]
        [Validation(Required=false)]
        public string HealthCheckDomain { get; set; }

        /// <summary>
        /// The HTTP status code for a successful health check. Multiple HTTP status codes are separated by commas (,).
        /// 
        /// Valid values: **http\_2xx**, **http\_3xx**, **http\_4xx**, and **http\_5xx**.
        /// 
        /// >  This parameter is required and takes effect if the **HealthCheck** parameter is set to **on**.
        /// </summary>
        [NameInMap("HealthCheckHttpCode")]
        [Validation(Required=false)]
        public string HealthCheckHttpCode { get; set; }

        /// <summary>
        /// The interval between two consecutive health checks. Unit: seconds. Valid values: **1** to **50**.
        /// 
        /// >  This parameter is required and takes effect if the **HealthCheck** parameter is set to **on**.
        /// </summary>
        [NameInMap("HealthCheckInterval")]
        [Validation(Required=false)]
        public int? HealthCheckInterval { get; set; }

        /// <summary>
        /// The timeout period of a health check response. If a backend server, such as an Elastic Compute Service (ECS) instance, does not return a health check response within the specified timeout period, the server fails the health check. Unit: seconds. Valid values: **1** to **300**.
        /// 
        /// >  This parameter is required and takes effect if the **HealthCheck** parameter is set to **on**.
        /// </summary>
        [NameInMap("HealthCheckTimeout")]
        [Validation(Required=false)]
        public int? HealthCheckTimeout { get; set; }

        /// <summary>
        /// The URI that is used for health checks.
        /// 
        /// >  This parameter is required and takes effect if the **HealthCheck** parameter is set to **on**.
        /// </summary>
        [NameInMap("HealthCheckURI")]
        [Validation(Required=false)]
        public string HealthCheckURI { get; set; }

        /// <summary>
        /// The number of times that an unhealthy backend server must consecutively pass health checks before it is declared healthy. In this case, the health status is changed from **fail** to **success**.
        /// 
        /// Valid values: **2** to **10**.
        /// 
        /// >  This parameter is required and takes effect if the **HealthCheck** parameter is set to **on**.
        /// </summary>
        [NameInMap("HealthyThreshold")]
        [Validation(Required=false)]
        public int? HealthyThreshold { get; set; }

        /// <summary>
        /// Specifies whether to use the scheduling algorithm, session persistence, and health check configurations of the listener. Valid values:
        /// 
        /// *   **on**: uses the configurations of the listener.
        /// *   **off**: does not use the configurations of the listener. You can customize the health check and session persistence configurations for the forwarding rule.
        /// </summary>
        [NameInMap("ListenerSync")]
        [Validation(Required=false)]
        public string ListenerSync { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The ID of the region where the Classic Load Balancer (CLB) instance is deployed.
        /// 
        /// You can call the [DescribeRegions](~~27584~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The ID of the forwarding rule.
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public string RuleId { get; set; }

        /// <summary>
        /// The name of the forwarding rule. The name must be 1 to 80 characters in length and can contain letters, digits, hyphens (-), forward slashes (/), periods (.), and underscores (\_).
        /// 
        /// >  Forwarding rule names must be unique within the same listener.
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// The scheduling algorithm. Valid values:
        /// 
        /// *   **wrr**: Backend servers with higher weights receive more requests than those with lower weights.
        /// *   **rr**: Requests are distributed to backend servers in sequence.
        /// 
        /// >  This parameter is required and takes effect if the **ListenerSync** parameter is set to **off**.
        /// </summary>
        [NameInMap("Scheduler")]
        [Validation(Required=false)]
        public string Scheduler { get; set; }

        /// <summary>
        /// Specifies whether to enable session persistence. Valid values:
        /// 
        /// *   **on**: yes
        /// *   **off**: no
        /// 
        /// This parameter is required and takes effect if the **ListenerSync** parameter is set to **off**.
        /// </summary>
        [NameInMap("StickySession")]
        [Validation(Required=false)]
        public string StickySession { get; set; }

        /// <summary>
        /// The method that is used to handle a cookie. Valid values:
        /// 
        /// *   **insert**: inserts a cookie.
        /// 
        ///     CLB inserts the backend server ID as a cookie into the first HTTP or HTTPS response that is sent to a client. The next request from the client will contain this cookie, and the listener will distribute this request to the recorded backend server.
        /// 
        /// *   **server**: rewrites a cookie.
        /// 
        ///     When CLB detects a user-defined cookie, it overwrites the original cookie with the user-defined cookie. The next request from the client will contain the user-defined cookie, and the listener will distribute this request to the recorded backend server.
        /// 
        /// >  This parameter is required and takes effect if the **StickySession** parameter is set to **on**.
        /// </summary>
        [NameInMap("StickySessionType")]
        [Validation(Required=false)]
        public string StickySessionType { get; set; }

        /// <summary>
        /// The number of times that a healthy backend server must consecutively fail health checks before it is declared unhealthy. In this case, the health status is changed from **success** to **fail**.
        /// 
        /// Valid values: **2** to **10**.
        /// 
        /// >  This parameter is required and takes effect if the **HealthCheck** parameter is set to **on**.
        /// </summary>
        [NameInMap("UnhealthyThreshold")]
        [Validation(Required=false)]
        public int? UnhealthyThreshold { get; set; }

        /// <summary>
        /// The ID of the vServer group that is associated with the forwarding rule.
        /// </summary>
        [NameInMap("VServerGroupId")]
        [Validation(Required=false)]
        public string VServerGroupId { get; set; }

    }

}
