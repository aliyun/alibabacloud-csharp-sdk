// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class SetLoadBalancerTCPListenerAttributeRequest : TeaModel {
        /// <summary>
        /// The ID of the network access control list (ACL) that is associated with the listener.
        /// 
        /// If **AclStatus** is set to **on**, this parameter is required.
        /// </summary>
        [NameInMap("AclId")]
        [Validation(Required=false)]
        public string AclId { get; set; }

        /// <summary>
        /// Specifies whether to enable access control. Valid values:
        /// 
        /// *   **on**: yes
        /// *   **off**: no
        /// </summary>
        [NameInMap("AclStatus")]
        [Validation(Required=false)]
        public string AclStatus { get; set; }

        /// <summary>
        /// The type of the network ACL. Valid values:
        /// 
        /// *   **white**: a whitelist. Only requests from the IP addresses or CIDR blocks in the network ACL are forwarded. Whitelists apply to scenarios where you want to allow only specific IP addresses to access an application. Your service may be adversely affected if the allowlist is not properly configured. After a whitelist is configured, only requests from IP addresses that are added to the whitelist are forwarded by the listener.
        /// 
        ///     If you enable a whitelist but do not add an IP address to the ACL, the listener forwards all requests.
        /// 
        /// *   **black**: a blacklist. All requests from the IP addresses or CIDR blocks in the ACL are rejected. Blacklists apply to scenarios where you want to block access from specified IP addresses to an application.
        /// 
        ///     If a blacklist is configured for a listener but no IP address is added to the blacklist, the listener forwards all requests.
        /// 
        /// >  If **AclStatus** is set to **on**, this parameter is required.
        /// </summary>
        [NameInMap("AclType")]
        [Validation(Required=false)]
        public string AclType { get; set; }

        /// <summary>
        /// The maximum bandwidth of the listener. Unit: Mbit/s. Valid values: **-1** and **1** to **5120**.
        /// 
        /// *   **-1**: For a pay-by-data-transfer Internet-facing CLB instance, you can set this parameter to **-1**, which specifies unlimited bandwidth.
        /// *   **1** to **5120**: For a pay-by-bandwidth Internet-facing CLB instance, you can specify the maximum bandwidth of each listener. The sum of the maximum bandwidth values of all listeners cannot exceed the maximum bandwidth of the CLB instance.
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// Specifies whether to enable connection draining. Valid values:
        /// 
        /// *   **on**: yes
        /// *   **off**: no
        /// </summary>
        [NameInMap("ConnectionDrain")]
        [Validation(Required=false)]
        public string ConnectionDrain { get; set; }

        /// <summary>
        /// The timeout period of connection draining. This parameter is required if **ConnectionDrain** is set to **on**. Unit: seconds.
        /// 
        /// Valid values: **10** to **900**.
        /// </summary>
        [NameInMap("ConnectionDrainTimeout")]
        [Validation(Required=false)]
        public int? ConnectionDrainTimeout { get; set; }

        /// <summary>
        /// The name of the listener.
        /// 
        /// The name must be 1 to 256 characters in length and can contain letters, digits, hyphens (-), forward slashes (/), periods (.), and underscores (\_).
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The timeout period of a connection. Unit: seconds. Valid values: **10** to **900**.
        /// </summary>
        [NameInMap("EstablishedTimeout")]
        [Validation(Required=false)]
        public int? EstablishedTimeout { get; set; }

        /// <summary>
        /// The port that is used for health checks. Valid values: **1** to **65535**.
        /// 
        /// If you do not set this parameter, the port specified by the **BackendServerPort** parameter is used.
        /// </summary>
        [NameInMap("HealthCheckConnectPort")]
        [Validation(Required=false)]
        public int? HealthCheckConnectPort { get; set; }

        /// <summary>
        /// The timeout period of a health check.
        /// 
        /// If a backend ECS instance does not return a health check response within the specified timeout period, the server fails the health check.
        /// 
        /// Valid values: **1** to **300**. Unit: seconds.
        /// 
        /// >  If the value of the **HealthCheckConnectTimeout** parameter is smaller than that of the **HealthCheckInterval** parameter, the timeout period specified by the **HCTimeout** parameter is ignored and the period of time specified by the **HealthCheckInterval** parameter is used as the timeout period.
        /// </summary>
        [NameInMap("HealthCheckConnectTimeout")]
        [Validation(Required=false)]
        public int? HealthCheckConnectTimeout { get; set; }

        /// <summary>
        /// The domain name that is used for health checks. You can set this parameter when the TCP listener requires HTTP health checks. If you do not set this parameter, TCP health checks are performed.
        /// 
        /// *   **$\_ip**: the private IP addresses of the backend servers.
        /// 
        ///     If you do not set the HealthCheckHost parameter or set the parameter to $SERVER_IP, the CLB instance uses the private IP addresses of backend servers for health checks.
        /// 
        /// *   **domain**: The domain name is 1 to 80 characters in length, and can contain letters, digits, periods (.), and hyphens (-).
        /// </summary>
        [NameInMap("HealthCheckDomain")]
        [Validation(Required=false)]
        public string HealthCheckDomain { get; set; }

        /// <summary>
        /// The HTTP status code for a successful health check. Separate multiple HTTP status codes with commas (,).
        /// 
        /// Valid values: **http\_2xx**, **http\_3xx**, **http\_4xx**, and **http\_5xx**.
        /// </summary>
        [NameInMap("HealthCheckHttpCode")]
        [Validation(Required=false)]
        public string HealthCheckHttpCode { get; set; }

        /// <summary>
        /// The interval between two consecutive health checks. Unit: seconds.
        /// 
        /// Valid values: **1** to **50**.
        /// </summary>
        [NameInMap("HealthCheckInterval")]
        [Validation(Required=false)]
        public int? HealthCheckInterval { get; set; }

        /// <summary>
        /// Specifies whether to enable the health check feature. Valid values:
        /// 
        /// *   **on**: yes
        /// *   **off**: no
        /// </summary>
        [NameInMap("HealthCheckSwitch")]
        [Validation(Required=false)]
        public string HealthCheckSwitch { get; set; }

        /// <summary>
        /// The type of the health check. Valid values: **tcp** and **http**.
        /// </summary>
        [NameInMap("HealthCheckType")]
        [Validation(Required=false)]
        public string HealthCheckType { get; set; }

        /// <summary>
        /// The URI that is used for health checks. The URI must be 1 to 80 characters in length, and can contain letters, digits, hyphens (-), forward slashes (/), periods (.), percent signs (%), question marks (?), number signs (#), and ampersands (&). The URI must start with a forward slash (/) but cannot be a single forward slash (/).
        /// 
        /// You can set this parameter when the TCP listener requires HTTP health checks.
        /// 
        /// If you do not set this parameter, TCP health checks are performed.
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
        /// The frontend port used by the CLB instance.
        /// 
        /// Valid values: **1** to **65535**.
        /// </summary>
        [NameInMap("ListenerPort")]
        [Validation(Required=false)]
        public int? ListenerPort { get; set; }

        /// <summary>
        /// The ID of the CLB instance.
        /// </summary>
        [NameInMap("LoadBalancerId")]
        [Validation(Required=false)]
        public string LoadBalancerId { get; set; }

        /// <summary>
        /// Specifies whether to use a primary/secondary server group. Valid values:
        /// 
        /// *   **on**: yes
        /// *   **off**: no
        /// 
        /// You cannot set both **VserverGroup** and **MasterSlaveServerGroup** to **on**.
        /// </summary>
        [NameInMap("MasterSlaveServerGroup")]
        [Validation(Required=false)]
        public string MasterSlaveServerGroup { get; set; }

        /// <summary>
        /// The ID of the primary/secondary server group.
        /// 
        /// >  You can set only one of the VServerGroupId and MasterSlaveServerGroupId parameters.
        /// </summary>
        [NameInMap("MasterSlaveServerGroupId")]
        [Validation(Required=false)]
        public string MasterSlaveServerGroupId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The timeout period of session persistence. Valid values: **0** to **3600**. Unit: seconds.
        /// 
        /// Default value: **0**. If the default value is used, the system disables session persistence.
        /// </summary>
        [NameInMap("PersistenceTimeout")]
        [Validation(Required=false)]
        public int? PersistenceTimeout { get; set; }

        /// <summary>
        /// Specifies whether to use the Proxy protocol to pass client IP addresses to backend servers. Valid values:
        /// 
        /// *   **true**: yes
        /// *   **false**: no
        /// </summary>
        [NameInMap("ProxyProtocolV2Enabled")]
        [Validation(Required=false)]
        public bool? ProxyProtocolV2Enabled { get; set; }

        /// <summary>
        /// The region ID of the CLB instance.
        /// 
        /// You can query the region ID from the [Regions and zones](~~40654~~) list or by calling the [DescribeRegions](~~DescribeRegions~~) operation.
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
        /// The scheduling algorithm. Valid values:
        /// 
        /// *   **wrr**: Backend servers that have higher weights receive more requests than backend servers that have lower weights.
        /// *   **rr**: Requests are distributed to backend servers in sequence.
        /// *   **sch**: specifies consistent hashing that is based on source IP addresses. Requests from the same source IP address are distributed to the same backend server.
        /// *   **tch**: specifies consistent hashing that is based on four factors: source IP address, destination IP address, source port, and destination port. Requests that contain the same information based on the four factors are distributed to the same backend server.
        /// 
        /// > 
        /// *   Only high-performance CLB instances support the **sch** and **tch** algorithms.
        /// *   CLB does not support converting the **wrr** and **rr** algorithms to sch or tch. You cannot switch the hash algorithm from one to another.
        /// </summary>
        [NameInMap("Scheduler")]
        [Validation(Required=false)]
        public string Scheduler { get; set; }

        /// <summary>
        /// Specifies whether to enable the SynProxy feature of CLB for protection. Valid values:
        /// 
        /// *   **enable**: yes
        /// *   **disable**: no
        /// 
        /// We recommend that you use the default value of this parameter.
        /// </summary>
        [NameInMap("SynProxy")]
        [Validation(Required=false)]
        public string SynProxy { get; set; }

        /// <summary>
        /// The number of times that a healthy backend server must consecutively fail health checks before it is declared unhealthy. In this case, the health status is changed from **success** to **fail**.
        /// 
        /// Valid values: **2** to **10**.
        /// </summary>
        [NameInMap("UnhealthyThreshold")]
        [Validation(Required=false)]
        public int? UnhealthyThreshold { get; set; }

        /// <summary>
        /// Specifies whether to use a vServer group. Valid values:
        /// 
        /// *   **on**: yes
        /// *   **off**: no
        /// 
        /// >  You cannot set both **VserverGroup** and **MasterSlaveServerGroup** to **on**.
        /// </summary>
        [NameInMap("VServerGroup")]
        [Validation(Required=false)]
        public string VServerGroup { get; set; }

        /// <summary>
        /// The ID of the vServer group.
        /// </summary>
        [NameInMap("VServerGroupId")]
        [Validation(Required=false)]
        public string VServerGroupId { get; set; }

    }

}
