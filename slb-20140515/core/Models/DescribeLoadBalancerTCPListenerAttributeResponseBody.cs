// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Slb20140515.Models
{
    public class DescribeLoadBalancerTCPListenerAttributeResponseBody : TeaModel {
        /// <summary>
        /// The ID of the network ACL that is associated with the listener.
        /// 
        /// If **AclStatus** is set to **on**, this parameter is returned.
        /// </summary>
        [NameInMap("AclId")]
        [Validation(Required=false)]
        public string AclId { get; set; }

        [NameInMap("AclIds")]
        [Validation(Required=false)]
        public DescribeLoadBalancerTCPListenerAttributeResponseBodyAclIds AclIds { get; set; }
        public class DescribeLoadBalancerTCPListenerAttributeResponseBodyAclIds : TeaModel {
            [NameInMap("AclId")]
            [Validation(Required=false)]
            public List<string> AclId { get; set; }

        }

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
        /// The type of the ACL. Valid values:
        /// 
        /// *   **white**: a whitelist. Only requests from the IP addresses or CIDR blocks in the network ACL are forwarded. Whitelists apply to scenarios in which you want to allow only specific IP addresses to access an application.
        /// 
        ///     Your service may be adversely affected if the whitelist is not properly configured. After a whitelist is configured, only requests from IP addresses that are added to the whitelist are forwarded by the listener.
        /// 
        ///     If you enable a whitelist but do not add an IP address to the ACL, the listener forwards all requests.
        /// 
        /// *   **black**: a blacklist. All requests from the IP addresses or CIDR blocks in the network ACL are rejected. Blacklists apply to scenarios in which you want to block access from specified IP addresses to an application.
        /// 
        ///     If a blacklist is configured for a listener but no IP address is added to the blacklist, the listener forwards all requests.
        /// 
        /// >  If **AclStatus** is set to **on**, this parameter is returned.
        /// </summary>
        [NameInMap("AclType")]
        [Validation(Required=false)]
        public string AclType { get; set; }

        /// <summary>
        /// The backend port used by the CLB instance.
        /// 
        /// >  If the listener is associated with a vServer group, this parameter is not returned.
        /// </summary>
        [NameInMap("BackendServerPort")]
        [Validation(Required=false)]
        public int? BackendServerPort { get; set; }

        /// <summary>
        /// The maximum bandwidth of the listener. Unit: Mbit/s. Valid values:
        /// 
        /// *   **-1**: For a pay-by-data-transfer Internet-facing CLB instance, this parameter is set to -1. This indicates that the bandwidth of the listener is unlimited.
        /// *   **1** to **5120**: For a pay-by-bandwidth Internet-facing CLB instance, you can specify the maximum bandwidth of each listener. The sum of maximum bandwidth of all listeners cannot exceed the maximum bandwidth of the CLB instance.
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// Indicates whether connection draining is enabled. If **ConnectionDrain** is set to **on**, the parameter is returned. Valid values:
        /// 
        /// *   **on**: yes
        /// *   **off**: no
        /// </summary>
        [NameInMap("ConnectionDrain")]
        [Validation(Required=false)]
        public string ConnectionDrain { get; set; }

        /// <summary>
        /// The timeout period of connection draining. If **ConnectionDrain** is set to **on**, the parameter is returned.
        /// 
        /// Valid values: 10 to 900. Unit: seconds.
        /// </summary>
        [NameInMap("ConnectionDrainTimeout")]
        [Validation(Required=false)]
        public int? ConnectionDrainTimeout { get; set; }

        /// <summary>
        /// The description of the listener.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The timeout period of a connection.
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
        /// The port that is used for health checks. Valid values: **1** to **65535**. If this parameter is not set, the port specified by BackendServerPort is used for health checks.
        /// </summary>
        [NameInMap("HealthCheckConnectPort")]
        [Validation(Required=false)]
        public int? HealthCheckConnectPort { get; set; }

        /// <summary>
        /// The timeout period.
        /// </summary>
        [NameInMap("HealthCheckConnectTimeout")]
        [Validation(Required=false)]
        public int? HealthCheckConnectTimeout { get; set; }

        /// <summary>
        /// The domain name that is used for health checks. Valid values:
        /// 
        /// *   **$_ip**: the private IP addresses of backend servers. If you do not set the HealthCheckDomain parameter or set the parameter to $_ip, the CLB instance uses the private IP address of each backend server for health checks.
        /// *   **domain**: The domain name is 1 to 80 characters in length, and can contain letters, digits, periods (.), and hyphens (-).
        /// </summary>
        [NameInMap("HealthCheckDomain")]
        [Validation(Required=false)]
        public string HealthCheckDomain { get; set; }

        /// <summary>
        /// The HTTP status code for a successful health check.
        /// </summary>
        [NameInMap("HealthCheckHttpCode")]
        [Validation(Required=false)]
        public string HealthCheckHttpCode { get; set; }

        /// <summary>
        /// The interval between two consecutive health checks. Valid values: **1** to **50**. Unit: seconds.
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
        /// The health check method that is used by the TCP listener.
        /// 
        /// Valid values: **tcp** and **http**.
        /// </summary>
        [NameInMap("HealthCheckType")]
        [Validation(Required=false)]
        public string HealthCheckType { get; set; }

        /// <summary>
        /// The URL that is used for health checks. The URL must be 1 to 80 characters in length, and can contain letters, digits, hyphens (-), forward slashes (/), periods (.), percent signs (%), question marks (?), number signs (#), and ampersands (&). The URL is not a single forward slash (/) but it starts with a forward slash (/).
        /// </summary>
        [NameInMap("HealthCheckURI")]
        [Validation(Required=false)]
        public string HealthCheckURI { get; set; }

        /// <summary>
        /// The healthy threshold. The number of times that an unhealthy backend server must consecutively pass health checks before it is declared healthy. In this case, the health status is changed from **fail** to **success**. Valid values: **2** to **10**.
        /// </summary>
        [NameInMap("HealthyThreshold")]
        [Validation(Required=false)]
        public int? HealthyThreshold { get; set; }

        /// <summary>
        /// The frontend port used by the CLB instance.
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
        /// The ID of the primary/secondary server group that is associated with the listener.
        /// </summary>
        [NameInMap("MasterSlaveServerGroupId")]
        [Validation(Required=false)]
        public string MasterSlaveServerGroupId { get; set; }

        /// <summary>
        /// The timeout period of session persistence.
        /// 
        /// Valid values: **0** to **3600**. Unit: seconds. Default value: **0**. If the default value is used, the system disables session persistence.
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
        public bool? ProxyProtocolV2Enabled { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The scheduling algorithm.
        /// 
        /// *   **wrr** (default): Backend servers with higher weights receive more requests than backend servers with lower weights.
        /// *   **rr**: Requests are distributed to backend servers in sequence.
        /// </summary>
        [NameInMap("Scheduler")]
        [Validation(Required=false)]
        public string Scheduler { get; set; }

        /// <summary>
        /// The status of the listener. Valid values:
        /// 
        /// *   **running**
        /// *   **stopped**
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// Indicates whether the SynProxy feature of CLB is enabled for protection.
        /// 
        /// We recommend that you use the default value of this parameter. Valid values:
        /// 
        /// *   **enable**: yes
        /// *   **disable**: no
        /// </summary>
        [NameInMap("SynProxy")]
        [Validation(Required=false)]
        public string SynProxy { get; set; }

        /// <summary>
        /// The tags.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public DescribeLoadBalancerTCPListenerAttributeResponseBodyTags Tags { get; set; }
        public class DescribeLoadBalancerTCPListenerAttributeResponseBodyTags : TeaModel {
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<DescribeLoadBalancerTCPListenerAttributeResponseBodyTagsTag> Tag { get; set; }
            public class DescribeLoadBalancerTCPListenerAttributeResponseBodyTagsTag : TeaModel {
                /// <summary>
                /// The tags.
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// The tag value.
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

        }

        /// <summary>
        /// The unhealthy threshold. The number of times that a healthy backend server must consecutively fail health checks before it is declared unhealthy. In this case, the health status is changed from **success** to **fail**. Valid values: **2** to **10**.
        /// </summary>
        [NameInMap("UnhealthyThreshold")]
        [Validation(Required=false)]
        public int? UnhealthyThreshold { get; set; }

        /// <summary>
        /// The ID of the associated server group.
        /// </summary>
        [NameInMap("VServerGroupId")]
        [Validation(Required=false)]
        public string VServerGroupId { get; set; }

    }

}
