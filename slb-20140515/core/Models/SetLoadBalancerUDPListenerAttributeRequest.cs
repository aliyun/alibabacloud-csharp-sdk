// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class SetLoadBalancerUDPListenerAttributeRequest : TeaModel {
        /// <summary>
        /// The ID of the network access control list (ACL) that is associated with the listener.
        /// 
        /// >  If **AclStatus** is set to **on**, this parameter is required.
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
        /// *   **white**: a whitelist. Only requests from the IP addresses or CIDR blocks in the network ACL are forwarded. Whitelists apply to scenarios where you want to allow only specific IP addresses to access an application. Your service may be adversely affected if the whitelist is not properly configured. After a whitelist is configured, only requests from IP addresses that are added to the whitelist are forwarded by the listener.
        /// 
        ///     If you enable a whitelist but do not add an IP address to the ACL, the listener forwards all requests.
        /// 
        /// *   **black**: a blacklist. All requests from the IP addresses or CIDR blocks in the network ACL are denied. Blacklists apply to scenarios where you want to block access from specified IP addresses to an application.
        /// 
        ///     If a blacklist is configured for a listener but no IP address is added to the blacklist, the listener forwards all requests.
        /// 
        /// >  If **AclStatus** is set to **on**, this parameter is required.
        /// </summary>
        [NameInMap("AclType")]
        [Validation(Required=false)]
        public string AclType { get; set; }

        /// <summary>
        /// The maximum bandwidth of the listener. Unit: Mbit/s. Valid values:
        /// 
        /// *   **-1**: For a pay-by-data-transfer Internet-facing CLB instance, you can set this parameter to **-1**. This way, the bandwidth of the listener is unlimited.
        /// *   **1** to **5120**: For a pay-by-bandwidth Internet-facing CLB instance, you can specify the maximum bandwidth of each listener. The sum of bandwidth limits that you set for all listeners cannot exceed the maximum bandwidth of the CLB instance.
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// The name of the listener.
        /// 
        /// The name must be 1 to 256 characters in length and can contain letters, digits, hyphens (-), forward slashes (/), periods (.), and underscores (_).
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The port that is used for health checks.
        /// 
        /// Valid values: **1** to **65535**.
        /// </summary>
        [NameInMap("HealthCheckConnectPort")]
        [Validation(Required=false)]
        public int? HealthCheckConnectPort { get; set; }

        /// <summary>
        /// The timeout period of a health check. If a backend server, such as an Elastic Compute Service (ECS) instance, does not return a health check response within the specified timeout period, the server fails the health check. Unit: seconds.
        /// 
        /// Valid values: **1** to **300**.
        /// 
        /// >  If the value of the **HealthCheckConnectTimeout** parameter is smaller than that of the **HealthCheckInterval** parameter, the timeout period specified by the **HealthCheckConnectTimeout** parameter is ignored and the period of time specified by the **HealthCheckInterval** parameter is used as the timeout period.
        /// </summary>
        [NameInMap("HealthCheckConnectTimeout")]
        [Validation(Required=false)]
        public int? HealthCheckConnectTimeout { get; set; }

        /// <summary>
        /// The interval at which health checks are performed. Unit: seconds.
        /// 
        /// Valid values: **1** to **50**.
        /// </summary>
        [NameInMap("HealthCheckInterval")]
        [Validation(Required=false)]
        public int? HealthCheckInterval { get; set; }

        /// <summary>
        /// Specifies whether to enable the health check feature. Valid values:
        /// 
        /// *   **on** (default): yes
        /// *   **off**: no
        /// </summary>
        [NameInMap("HealthCheckSwitch")]
        [Validation(Required=false)]
        public string HealthCheckSwitch { get; set; }

        /// <summary>
        /// The number of times that an unhealthy backend server must consecutively pass health checks before it can be declared healthy (from **fail** to **success**).
        /// 
        /// Valid values: **1** to **10**.
        /// </summary>
        [NameInMap("HealthyThreshold")]
        [Validation(Required=false)]
        public int? HealthyThreshold { get; set; }

        /// <summary>
        /// The frontend port used by the CLB instance.
        /// 
        /// Valid values: **1** to **65535**.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ListenerPort")]
        [Validation(Required=false)]
        public int? ListenerPort { get; set; }

        /// <summary>
        /// The ID of the CLB instance.
        /// 
        /// This parameter is required.
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
        /// >  You cannot set **VserverGroup** and **MasterSlaveServerGroup** both to **on**.
        /// </summary>
        [NameInMap("MasterSlaveServerGroup")]
        [Validation(Required=false)]
        public string MasterSlaveServerGroup { get; set; }

        /// <summary>
        /// The ID of the primary/secondary server group.
        /// 
        /// >  You cannot specify both VServerGroupId and MasterSlaveServerGroupId.
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
        /// Specifies whether to use the Proxy protocol to pass client IP addresses to backend servers. Valid values:
        /// 
        /// *   **true**: yes
        /// *   **false** (default): no
        /// </summary>
        [NameInMap("ProxyProtocolV2Enabled")]
        [Validation(Required=false)]
        public bool? ProxyProtocolV2Enabled { get; set; }

        /// <summary>
        /// The region ID of the CLB instance.
        /// 
        /// You can call the [DescribeRegions](https://help.aliyun.com/document_detail/36063.html) operation to query the most recent region list.
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
        /// *   **wrr**: Backend servers with higher weights receive more requests than those with lower weights.
        /// 
        ///     If two backend servers have the same weight, the backend server that has fewer connections is expected to receive more requests.
        /// 
        /// *   **rr**: Requests are distributed to backend servers in sequence.
        /// 
        /// *   **sch**: specifies consistent hashing that is based on source IP addresses. Requests from the same source IP address are distributed to the same backend server.
        /// 
        /// *   **tch**: specifies consistent hashing that is based on the following parameters: source IP address, destination IP address, source port, and destination port. Requests that contain the same preceding information are distributed to the same backend server.
        /// 
        /// *   **qch**: specifies consistent hashing that is based on QUIC connection IDs. Requests that contain the same QUIC connection ID are distributed to the same backend server.
        /// 
        /// > 
        /// *   Only high-performance CLB instances support **sch**, **tch**, and **qch**.
        /// *   You cannot switch the algorithm used by a CLB instance from **wrr** or **rr** to consistent hashing or from consistent hashing to weighted round robin or round robin.
        /// </summary>
        [NameInMap("Scheduler")]
        [Validation(Required=false)]
        public string Scheduler { get; set; }

        /// <summary>
        /// The number of times that a healthy backend server must consecutively fail health checks before it is declared unhealthy. In this case, the health status is changed from **success** to **fail**.
        /// 
        /// Valid values: **1** to **10**.
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

        /// <summary>
        /// The response string for UDP listener health checks. The string must be 1 to 64 characters in length and can contain only letters and digits.
        /// </summary>
        [NameInMap("healthCheckExp")]
        [Validation(Required=false)]
        public string HealthCheckExp { get; set; }

        /// <summary>
        /// The request string for UDP listener health checks. The string must be 1 to 64 characters in length and can contain only letters and digits.
        /// </summary>
        [NameInMap("healthCheckReq")]
        [Validation(Required=false)]
        public string HealthCheckReq { get; set; }

    }

}
