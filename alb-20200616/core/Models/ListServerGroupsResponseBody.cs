// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ListServerGroupsResponseBody : TeaModel {
        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results. Valid values:
        /// 
        /// *   If **NextToken** is empty, no next page exists.
        /// *   If **NextToken** is not empty, the value of NextToken can be used in the next request to retrieve a new page of results.
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
            /// Indicates whether configuration management is enabled. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("ConfigManagedEnabled")]
            [Validation(Required=false)]
            public bool? ConfigManagedEnabled { get; set; }

            /// <summary>
            /// The configurations of connection draining.
            /// 
            /// After connection draining is enabled, ALB maintains data transmission for a period of time after the backend server is removed or declared unhealthy.
            /// 
            /// > 
            /// 
            /// *   By default, connection draining is disabled. To enable connection draining, contact your account manager.
            /// 
            /// *   Basic ALB instances do not support connection draining. Standard and WAF-enabled ALB instances support connection draining.
            /// 
            /// *   Server groups of the instance and IP types support connection draining. Server groups of the Function Compute type do not support connection draining.
            /// </summary>
            [NameInMap("ConnectionDrainConfig")]
            [Validation(Required=false)]
            public ListServerGroupsResponseBodyServerGroupsConnectionDrainConfig ConnectionDrainConfig { get; set; }
            public class ListServerGroupsResponseBodyServerGroupsConnectionDrainConfig : TeaModel {
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
                /// The timeout period of connection draining.
                /// </summary>
                [NameInMap("ConnectionDrainTimeout")]
                [Validation(Required=false)]
                public int? ConnectionDrainTimeout { get; set; }

            }

            /// <summary>
            /// The time when the resource was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The health check configurations.
            /// </summary>
            [NameInMap("HealthCheckConfig")]
            [Validation(Required=false)]
            public ListServerGroupsResponseBodyServerGroupsHealthCheckConfig HealthCheckConfig { get; set; }
            public class ListServerGroupsResponseBodyServerGroupsHealthCheckConfig : TeaModel {
                /// <summary>
                /// The HTTP status codes that indicate healthy backend servers.
                /// </summary>
                [NameInMap("HealthCheckCodes")]
                [Validation(Required=false)]
                public List<string> HealthCheckCodes { get; set; }

                /// <summary>
                /// The backend port that is used for health checks. Valid values: **0** to **65535**.
                /// 
                /// A value of **0** indicates that the port of a backend server is used for health checks.
                /// </summary>
                [NameInMap("HealthCheckConnectPort")]
                [Validation(Required=false)]
                public int? HealthCheckConnectPort { get; set; }

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
                /// The domain name that is used for health checks. The domain name meets the following requirements:
                /// 
                /// *   The domain name must be 1 to 80 characters in length.
                /// *   The domain name can contain lowercase letters, digits, hyphens (-), and periods (.).
                /// *   The domain name can contain at least one period (.) but cannot start or end with a period (.).
                /// *   The rightmost domain label of the domain name can contain only letters, and cannot contain digits or hyphens (-).
                /// *   The domain name cannot start or end with a hyphen (-).
                /// 
                /// >  This parameter takes effect only when **HealthCheckProtocol** is set to **HTTP** or **HTTPS**. HTTPS is unavailable by default. If you want to use HTTPS, log on to the SLB console, go to the Quota Center page, click the **ALB** tab, and then apply for the privilege to use HTTPS.
                /// </summary>
                [NameInMap("HealthCheckHost")]
                [Validation(Required=false)]
                public string HealthCheckHost { get; set; }

                /// <summary>
                /// The HTTP version that is used for health checks.
                /// 
                /// Valid values: **HTTP1.0** and **HTTP1.1**.
                /// 
                /// >  This parameter takes effect only when **HealthCheckProtocol** is set to **HTTP** or **HTTPS**. HTTPS is unavailable by default. If you want to use HTTPS, log on to the SLB console, go to the Quota Center page, click the **ALB** tab, and then apply for the privilege to use HTTPS.
                /// </summary>
                [NameInMap("HealthCheckHttpVersion")]
                [Validation(Required=false)]
                public string HealthCheckHttpVersion { get; set; }

                /// <summary>
                /// The interval at which health checks are performed. Unit: seconds. Valid values: **1** to **50**.
                /// </summary>
                [NameInMap("HealthCheckInterval")]
                [Validation(Required=false)]
                public int? HealthCheckInterval { get; set; }

                /// <summary>
                /// The HTTP method that is used for health checks. Valid values:
                /// 
                /// *   **GET**: If the length of a response exceeds 8 KB, the response is truncated. However, the health check result is not affected.
                /// *   **POST**: gRPC health checks use the POST method by default.
                /// *   **HEAD**: HTTP and HTTPS health checks use the HEAD method by default.
                /// 
                /// >  This parameter takes effect only when **HealthCheckProtocol** is set to **HTTP**, **HTTPS**, or **gRPC**. HTTPS is unavailable by default. If you want to use HTTPS, log on to the SLB console, go to the Quota Center page, click the **ALB** tab, and then apply for the privilege to use HTTPS.
                /// </summary>
                [NameInMap("HealthCheckMethod")]
                [Validation(Required=false)]
                public string HealthCheckMethod { get; set; }

                /// <summary>
                /// The URL that is used for health checks.
                /// 
                /// >  This parameter takes effect only when **HealthCheckProtocol** is set to **HTTP** or **HTTPS**. HTTPS is unavailable by default. If you want to use HTTPS, log on to the SLB console, go to the Quota Center page, click the **ALB** tab, and then apply for the privilege to use HTTPS.
                /// </summary>
                [NameInMap("HealthCheckPath")]
                [Validation(Required=false)]
                public string HealthCheckPath { get; set; }

                /// <summary>
                /// The protocol that is used for health checks. Valid values:
                /// 
                /// *   **HTTP**: HTTP health checks simulate browser behaviors by sending HEAD or GET requests to probe the availability of backend servers.
                /// *   **HTTPS**: HTTPS health checks simulate browser behaviors by sending HEAD or GET requests to probe the availability of backend servers. HTTPS supports encryption and provides higher security than HTTP.
                /// *   **TCP**: TCP health checks send TCP SYN packets to a backend server to check whether the port of the backend server is reachable.
                /// *   **gRPC**: gRPC health checks send POST or GET requests to a backend server to check whether the backend server is healthy.
                /// 
                /// >  HTTPS is unavailable by default. If you want to use HTTPS, log on to the SLB console, go to the Quota Center page, click the **ALB** tab, and then apply for the privilege to use HTTPS.
                /// </summary>
                [NameInMap("HealthCheckProtocol")]
                [Validation(Required=false)]
                public string HealthCheckProtocol { get; set; }

                /// <summary>
                /// The timeout period of a health check response. If a backend server does not respond within the specified timeout period, the backend server is declared unhealthy. Unit: seconds.
                /// </summary>
                [NameInMap("HealthCheckTimeout")]
                [Validation(Required=false)]
                public int? HealthCheckTimeout { get; set; }

                /// <summary>
                /// The number of times that an unhealthy backend server must consecutively pass health checks before it is declared healthy. In this case, the health status is changed from **fail** to **success**.
                /// </summary>
                [NameInMap("HealthyThreshold")]
                [Validation(Required=false)]
                public int? HealthyThreshold { get; set; }

                /// <summary>
                /// The number of times that a healthy backend server must consecutively fail health checks before it is declared unhealthy. In this case, the health status is changed from **success** to **fail**.
                /// </summary>
                [NameInMap("UnhealthyThreshold")]
                [Validation(Required=false)]
                public int? UnhealthyThreshold { get; set; }

            }

            /// <summary>
            /// Indicates whether IPv6 is supported. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("Ipv6Enabled")]
            [Validation(Required=false)]
            public bool? Ipv6Enabled { get; set; }

            /// <summary>
            /// The backend protocol. Valid values:
            /// 
            /// *   **HTTP**: allows you to associate HTTPS, HTTP, or QUIC listeners with backend servers.
            /// *   **HTTPS**: allows you to associate HTTPS listeners with backend servers.
            /// *   **GRPC**: allows you to associate HTTPS and QUIC listeners with backend servers.
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// The ID of the ALB instance associated with the server group.
            /// </summary>
            [NameInMap("RelatedLoadBalancerIds")]
            [Validation(Required=false)]
            public List<string> RelatedLoadBalancerIds { get; set; }

            /// <summary>
            /// The ID of the resource group to which the instance belongs.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The scheduling algorithm. Valid values:
            /// 
            /// *   **Wrr**: weighted round-robin. Backend servers with higher weights receive more requests than backend servers with lower weights.
            /// *   **Wlc**: weighted least connections. Requests are distributed based on the weight and load of each backend server. The load refers to the number of connections on a backend server. If multiple backend servers have the same weight, requests are forwarded to the backend server with the least number of connections.
            /// *   **Sch**: consistent hashing. Requests that have the same hash factors are distributed to the same backend server. If you do not specify the UchConfig parameter, the source IP address is used as the hash factor by default. Requests that are from the same IP address are distributed to the same backend server. If you specify the UchConfig parameter, the URL string is used as the hash factor. Requests that have the same URL string are distributed to the same backend server.
            /// </summary>
            [NameInMap("Scheduler")]
            [Validation(Required=false)]
            public string Scheduler { get; set; }

            /// <summary>
            /// The number of backend servers in the server group.
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
            /// *   **Creating**.
            /// *   **Available**
            /// *   **Configuring**
            /// </summary>
            [NameInMap("ServerGroupStatus")]
            [Validation(Required=false)]
            public string ServerGroupStatus { get; set; }

            /// <summary>
            /// The server group type. Valid values:
            /// 
            /// *   **Instance**: instances, including ECS instances, ENIs, and elastic container instances.
            /// *   **Ip**: IP addresses.
            /// *   **Fc**: Function Compute
            /// </summary>
            [NameInMap("ServerGroupType")]
            [Validation(Required=false)]
            public string ServerGroupType { get; set; }

            /// <summary>
            /// The name of the server group.
            /// </summary>
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            /// <summary>
            /// The configurations of slow starts.
            /// 
            /// After slow starts are enabled, ALB prefetches data to newly added backend servers. Requests distributed to the backend servers gradually increase.
            /// 
            /// > 
            /// 
            /// *   Basic ALB instances do not support slow starts. Standard and WAF-enabled ALB instances support slow starts.
            /// 
            /// *   Server groups of the instance and IP types support slow starts. Server groups of the Function Compute type do not support slow starts.
            /// 
            /// *   Slow start is supported only by the weighted round-robin scheduling algorithm.
            /// </summary>
            [NameInMap("SlowStartConfig")]
            [Validation(Required=false)]
            public ListServerGroupsResponseBodyServerGroupsSlowStartConfig SlowStartConfig { get; set; }
            public class ListServerGroupsResponseBodyServerGroupsSlowStartConfig : TeaModel {
                /// <summary>
                /// The duration of a slow start.
                /// </summary>
                [NameInMap("SlowStartDuration")]
                [Validation(Required=false)]
                public int? SlowStartDuration { get; set; }

                /// <summary>
                /// Indicates whether slow starts are enabled. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// </summary>
                [NameInMap("SlowStartEnabled")]
                [Validation(Required=false)]
                public bool? SlowStartEnabled { get; set; }

            }

            /// <summary>
            /// The configuration of session persistence.
            /// </summary>
            [NameInMap("StickySessionConfig")]
            [Validation(Required=false)]
            public ListServerGroupsResponseBodyServerGroupsStickySessionConfig StickySessionConfig { get; set; }
            public class ListServerGroupsResponseBodyServerGroupsStickySessionConfig : TeaModel {
                /// <summary>
                /// The cookie configured for the server.
                /// </summary>
                [NameInMap("Cookie")]
                [Validation(Required=false)]
                public string Cookie { get; set; }

                /// <summary>
                /// The timeout period of the cookie. Unit: seconds. Valid values: **1** to **86400**.
                /// 
                /// >  This parameter takes effect only when **StickySessionEnabled** is set to **true** and **StickySessionType** is set to **Insert**.
                /// </summary>
                [NameInMap("CookieTimeout")]
                [Validation(Required=false)]
                public int? CookieTimeout { get; set; }

                /// <summary>
                /// Indicates whether session persistence is enabled. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// </summary>
                [NameInMap("StickySessionEnabled")]
                [Validation(Required=false)]
                public bool? StickySessionEnabled { get; set; }

                /// <summary>
                /// The method that is used to handle the cookie. Valid values:
                /// 
                /// *   **insert**: inserts the cookie. The first time a client accesses ALB, ALB inserts the SERVERID cookie into the HTTP or HTTPS response packet. Subsequent requests from the client that carry this cookie are forwarded to the same backend server as the first request.
                /// *   **Server**: rewrites the cookie. ALB rewrites the custom cookies in requests from a client. Subsequent requests from the client that carry the new cookie are forwarded to the same backend server as the first request.
                /// </summary>
                [NameInMap("StickySessionType")]
                [Validation(Required=false)]
                public string StickySessionType { get; set; }

            }

            /// <summary>
            /// The tags that are added to the server group.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListServerGroupsResponseBodyServerGroupsTags> Tags { get; set; }
            public class ListServerGroupsResponseBodyServerGroupsTags : TeaModel {
                /// <summary>
                /// The tag key.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The tag value.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The configuration of consistent hashing based on URLs.
            /// </summary>
            [NameInMap("UchConfig")]
            [Validation(Required=false)]
            public ListServerGroupsResponseBodyServerGroupsUchConfig UchConfig { get; set; }
            public class ListServerGroupsResponseBodyServerGroupsUchConfig : TeaModel {
                /// <summary>
                /// The parameter type. Valid value: QueryString.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The hash value.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// Indicates whether persistent TCP connections are enabled. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("UpstreamKeepaliveEnabled")]
            [Validation(Required=false)]
            public bool? UpstreamKeepaliveEnabled { get; set; }

            /// <summary>
            /// The ID of the VPC to which the ALB instance belongs.
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
