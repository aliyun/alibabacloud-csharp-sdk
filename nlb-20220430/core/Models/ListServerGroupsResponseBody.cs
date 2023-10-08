// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlb20220430.Models
{
    public class ListServerGroupsResponseBody : TeaModel {
        /// <summary>
        /// The number of entries per page. Valid values: **1** to **100**.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// A pagination token. It can be used in the next request to retrieve a new page of results. Valid values:
        /// 
        /// *   If **NextToken** is empty, no next page exists.
        /// *   If a value is returned for **NextToken**, the value is the token that determines the start point of the next query.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// A list of server groups.
        /// </summary>
        [NameInMap("ServerGroups")]
        [Validation(Required=false)]
        public List<ListServerGroupsResponseBodyServerGroups> ServerGroups { get; set; }
        public class ListServerGroupsResponseBodyServerGroups : TeaModel {
            /// <summary>
            /// The IP version. Valid values:
            /// 
            /// *   **ipv4**
            /// *   **DualStack**
            /// </summary>
            [NameInMap("AddressIPVersion")]
            [Validation(Required=false)]
            public string AddressIPVersion { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account.
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// Indicates whether the feature of forwarding requests to all ports is enabled. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("AnyPortEnabled")]
            [Validation(Required=false)]
            public bool? AnyPortEnabled { get; set; }

            /// <summary>
            /// Indicates whether connection draining is enabled. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("ConnectionDrainEnabled")]
            [Validation(Required=false)]
            public bool? ConnectionDrainEnabled { get; set; }

            /// <summary>
            /// The timeout period of connection draining. Unit: seconds. Valid values: **10** to **900**.
            /// </summary>
            [NameInMap("ConnectionDrainTimeout")]
            [Validation(Required=false)]
            public int? ConnectionDrainTimeout { get; set; }

            /// <summary>
            /// The configurations of health checks.
            /// </summary>
            [NameInMap("HealthCheck")]
            [Validation(Required=false)]
            public ListServerGroupsResponseBodyServerGroupsHealthCheck HealthCheck { get; set; }
            public class ListServerGroupsResponseBodyServerGroupsHealthCheck : TeaModel {
                /// <summary>
                /// The backend port that is used for health checks.
                /// 
                /// Valid values: **0** to **65535**.
                /// 
                /// A value of **0** indicates that the port on a backend server is used for health checks.
                /// </summary>
                [NameInMap("HealthCheckConnectPort")]
                [Validation(Required=false)]
                public int? HealthCheckConnectPort { get; set; }

                /// <summary>
                /// The maximum timeout period of a health check. Unit: seconds. Valid values: **1** to **300**.
                /// </summary>
                [NameInMap("HealthCheckConnectTimeout")]
                [Validation(Required=false)]
                public int? HealthCheckConnectTimeout { get; set; }

                /// <summary>
                /// The domain name that you want to use for health checks. Valid values:
                /// 
                /// *   **$SERVER_IP**: the private IP address of a backend server.
                /// *   **domain**: a specified domain name. The domain name must be 1 to 80 characters in length, and can contain lowercase letters, digits, hyphens (-), and periods (.).
                /// 
                /// > This parameter takes effect only when **HealthCheckType** is set to **HTTP**.
                /// </summary>
                [NameInMap("HealthCheckDomain")]
                [Validation(Required=false)]
                public string HealthCheckDomain { get; set; }

                /// <summary>
                /// Indicates whether the health check feature is enabled. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// </summary>
                [NameInMap("HealthCheckEnabled")]
                [Validation(Required=false)]
                public bool? HealthCheckEnabled { get; set; }

                /// <summary>
                /// The HTTP status codes returned for health checks. Multiple HTTP status codes are separated by commas (,). Valid values: **http\_2xx**, **http\_3xx**, **http\_4xx**, and **http\_5xx**.
                /// 
                /// > This parameter takes effect only when **HealthCheckType** is set to **HTTP**.
                /// </summary>
                [NameInMap("HealthCheckHttpCode")]
                [Validation(Required=false)]
                public List<string> HealthCheckHttpCode { get; set; }

                /// <summary>
                /// The interval at which health checks are performed. Unit: seconds.
                /// 
                /// Valid values: **5** to **50**.
                /// </summary>
                [NameInMap("HealthCheckInterval")]
                [Validation(Required=false)]
                public int? HealthCheckInterval { get; set; }

                /// <summary>
                /// The protocol that is used for health checks. Valid values: **TCP** and **HTTP**.
                /// </summary>
                [NameInMap("HealthCheckType")]
                [Validation(Required=false)]
                public string HealthCheckType { get; set; }

                /// <summary>
                /// The path to which health check probes are sent.
                /// 
                /// > This parameter takes effect only when **HealthCheckType** is set to **HTTP**.
                /// </summary>
                [NameInMap("HealthCheckUrl")]
                [Validation(Required=false)]
                public string HealthCheckUrl { get; set; }

                /// <summary>
                /// The number of times that an unhealthy backend server must consecutively pass health checks before it is declared healthy. In this case, the health status changes from **fail** to **success**.
                /// 
                /// Valid values: **2** to **10**.
                /// </summary>
                [NameInMap("HealthyThreshold")]
                [Validation(Required=false)]
                public int? HealthyThreshold { get; set; }

                /// <summary>
                /// The HTTP method that is used for health checks. Valid values: **GET** and **HEAD**.
                /// 
                /// > This parameter takes effect only when **HealthCheckType** is set to **HTTP**.
                /// </summary>
                [NameInMap("HttpCheckMethod")]
                [Validation(Required=false)]
                public string HttpCheckMethod { get; set; }

                /// <summary>
                /// The number of times that a healthy backend server must consecutively fail health checks before it is declared unhealthy. In this case, the health status changes from **success** to **fail**.
                /// 
                /// Valid values: **2** to **10**.
                /// </summary>
                [NameInMap("UnhealthyThreshold")]
                [Validation(Required=false)]
                public int? UnhealthyThreshold { get; set; }

            }

            /// <summary>
            /// Indicates whether client IP preservation is enabled. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// 
            /// > This parameter is set to **true** by default when **AddressIPVersion** is set to **ipv4**. This parameter is set to **false** when **AddressIPVersion** is set to **ipv6**. **true** will be supported by later versions.
            /// </summary>
            [NameInMap("PreserveClientIpEnabled")]
            [Validation(Required=false)]
            public bool? PreserveClientIpEnabled { get; set; }

            /// <summary>
            /// The protocol used to forward requests to the backend servers. Valid values: **TCP**, **UDP**, and **TCPSSL**.
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// The region ID of the NLB instance.
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// The NLB instances.
            /// </summary>
            [NameInMap("RelatedLoadBalancerIds")]
            [Validation(Required=false)]
            public List<string> RelatedLoadBalancerIds { get; set; }

            /// <summary>
            /// The ID of the resource group to which the server group belongs.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The routing algorithm. Valid values:
            /// 
            /// *   **Wrr**: Backend servers with higher weights receive more requests than backend servers with lower weights.
            /// *   **rr**: Requests are forwarded to the backend servers in sequence. sch: Requests are forwarded to the backend servers based on source IP address hashing.
            /// *   **sch**: Requests from the same source IP address are forwarded to the same backend server.
            /// *   **tch**: Four-element hashing, which specifies consistent hashing that is based on four factors: source IP address, destination IP address, source port, and destination port. Requests that contain the same information based on the four factors are forwarded to the same backend server.
            /// *   **qch**: QUIC ID hashing. Requests that contain the same QUIC ID are forwarded to the same backend server.
            /// </summary>
            [NameInMap("Scheduler")]
            [Validation(Required=false)]
            public string Scheduler { get; set; }

            /// <summary>
            /// The number of server groups associated with the NLB instances.
            /// </summary>
            [NameInMap("ServerCount")]
            [Validation(Required=false)]
            public int? ServerCount { get; set; }

            /// <summary>
            /// The server group ID.
            /// </summary>
            [NameInMap("ServerGroupId")]
            [Validation(Required=false)]
            public string ServerGroupId { get; set; }

            /// <summary>
            /// The server group name.
            /// </summary>
            [NameInMap("ServerGroupName")]
            [Validation(Required=false)]
            public string ServerGroupName { get; set; }

            /// <summary>
            /// The status of the server group. Valid values:
            /// 
            /// *   **Creating**
            /// *   **Available**
            /// *   **Configuring**
            /// </summary>
            [NameInMap("ServerGroupStatus")]
            [Validation(Required=false)]
            public string ServerGroupStatus { get; set; }

            /// <summary>
            /// The type of server group. Valid values:
            /// 
            /// *   **Instance** : contains servers of the **Ecs**, **Ens**, and **Eci** types.
            /// *   **Ip**: contains servers specified by IP addresses.
            /// </summary>
            [NameInMap("ServerGroupType")]
            [Validation(Required=false)]
            public string ServerGroupType { get; set; }

            /// <summary>
            /// The tag.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListServerGroupsResponseBodyServerGroupsTags> Tags { get; set; }
            public class ListServerGroupsResponseBodyServerGroupsTags : TeaModel {
                /// <summary>
                /// The tag key. At most 10 tag keys are returned.
                /// 
                /// The tag key can be up to 64 characters in length, and cannot contain `http://` or `https://`. It cannot start with `aliyun` or `acs:`.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The tag value. At most 10 tag values are returned.
                /// 
                /// The tag value can be up to 128 characters in length, and cannot contain `http://` or `https://`. It cannot start with `aliyun` or `acs:`.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The ID of the VPC to which the server group belongs.
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
