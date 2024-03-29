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

            [NameInMap("ConnectionDrainConfig")]
            [Validation(Required=false)]
            public ListServerGroupsResponseBodyServerGroupsConnectionDrainConfig ConnectionDrainConfig { get; set; }
            public class ListServerGroupsResponseBodyServerGroupsConnectionDrainConfig : TeaModel {
                [NameInMap("ConnectionDrainEnabled")]
                [Validation(Required=false)]
                public bool? ConnectionDrainEnabled { get; set; }

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
            /// The health check configuration.
            /// </summary>
            [NameInMap("HealthCheckConfig")]
            [Validation(Required=false)]
            public ListServerGroupsResponseBodyServerGroupsHealthCheckConfig HealthCheckConfig { get; set; }
            public class ListServerGroupsResponseBodyServerGroupsHealthCheckConfig : TeaModel {
                /// <summary>
                /// The HTTP status codes that indicate whether the backend server passes the health check.
                /// </summary>
                [NameInMap("HealthCheckCodes")]
                [Validation(Required=false)]
                public List<string> HealthCheckCodes { get; set; }

                /// <summary>
                /// The port that you want to use for health checks on backend servers. Valid values: **0** to **65535**.
                /// 
                /// A value of **0** indicates that the port on a backend server is used for health checks.
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
                /// *   The domain name is 1 to 80 characters in length.
                /// *   The domain name contains lowercase letters, digits, hyphens (-), and periods (.).
                /// *   The domain name contains at least one period (.) but does not start or end with a period (.).
                /// *   The rightmost domain label of the domain name contains only letters, and does not contain digits or hyphens (-).
                /// *   The domain name does not start or end with a hyphen (-).
                /// 
                /// >  This parameter takes effect only when **HealthCheckProtocol** is set to **HTTP** or **HTTPS**. HTTPS is unavailable by default. If you want to use HTTPS, log on to the SLB console, go to the Quota Center page, and then apply for the privilege to use HTPS on the **ALB** tab.
                /// </summary>
                [NameInMap("HealthCheckHost")]
                [Validation(Required=false)]
                public string HealthCheckHost { get; set; }

                /// <summary>
                /// The HTTP version that is used for health checks.
                /// 
                /// Valid values: **HTTP1.0** and **HTTP1.1**.
                /// 
                /// >  This parameter takes effect when **HealthCheckProtocol** is set to **HTTP** or **HTTPS**. HTTPS is unavailable by default. If you want to use HTTPS, log on to the SLB console, go to the Quota Center page, and then apply for the privilege to use HTPS on the **ALB** tab.
                /// </summary>
                [NameInMap("HealthCheckHttpVersion")]
                [Validation(Required=false)]
                public string HealthCheckHttpVersion { get; set; }

                /// <summary>
                /// The interval between two consecutive health checks. Unit: seconds. Valid values: **1** to **50**.
                /// </summary>
                [NameInMap("HealthCheckInterval")]
                [Validation(Required=false)]
                public int? HealthCheckInterval { get; set; }

                /// <summary>
                /// The HTTP method that is used for health checks. Valid values:
                /// 
                /// *   **GET**: If the length of a response exceeds 8 KB, the response is truncated. However, the health check result is not affected.
                /// *   **POST**: gRPC health checks on listeners use the POST method by default.
                /// *   **HEAD**: HTTP and HTTPS health checks on listeners use the HEAD method by default.
                /// 
                /// >  This parameter takes effect when **HealthCheckProtocol** is set to **HTTP**, **HTTPS**, or **gRPC**. HTTPS is unavailable by default. If you want to use HTTPS, log on to the SLB console, go to the Quota Center page, and then apply for the privilege to use HTTPS on the **ALB** tab.
                /// </summary>
                [NameInMap("HealthCheckMethod")]
                [Validation(Required=false)]
                public string HealthCheckMethod { get; set; }

                /// <summary>
                /// The path that is used for health checks.
                /// 
                /// >  This parameter takes effect only when **HealthCheckProtocol** is set to **HTTP** or **HTTPS**. HTTPS is unavailable by default. If you want to use HTTPS, log on to the SLB console, go to the Quota Center page, and then apply for the privilege to use HTPS on the **ALB** tab.
                /// </summary>
                [NameInMap("HealthCheckPath")]
                [Validation(Required=false)]
                public string HealthCheckPath { get; set; }

                /// <summary>
                /// The protocol that you want to use for health checks. Valid values:
                /// 
                /// *   **HTTP**: ALB performs HTTP health checks by sending HEAD or GET requests to a backend server to check whether the backend server is healthy.
                /// *   **HTTPS**: ALB performs HTTPS health checks by sending HEAD or GET requests to a backend server to check whether the backend server is healthy. HTTPS supports data encryption and provides higher data security than HTTP.
                /// *   **TCP**: To perform TCP health checks, ALB sends SYN packets to the backend server to check whether the port of the backend server is available to receive requests.
                /// *   **gRPC**: ALB performs gRPC health checks by sending POST or GET requests to a backend server to check whether the backend server is healthy.
                /// 
                /// >  HTTPS is unavailable by default. If you want to use HTTPS, log on to the SLB console, go to the Quota Center page, and then apply for the privilege to use HTTPS on the **ALB** tab.
                /// </summary>
                [NameInMap("HealthCheckProtocol")]
                [Validation(Required=false)]
                public string HealthCheckProtocol { get; set; }

                /// <summary>
                /// The timeout period for a health check response. If a backend server does not respond within the specified timeout period, the backend server fails the health check. Unit: seconds.
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
            /// *   **HTTPS**: allows you to associate an HTTPS listener with the server group.
            /// *   **GRPC**: allows you to associate an HTTPS or QUIC listener with the server group.
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            [NameInMap("RelatedLoadBalancerIds")]
            [Validation(Required=false)]
            public List<string> RelatedLoadBalancerIds { get; set; }

            /// <summary>
            /// The resource group ID to which the GA instance belongs.
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// The scheduling algorithm. Valid values:
            /// 
            /// *   **Wrr**: Backend servers with higher weights receive more requests than backend servers with lower weights.
            /// *   **Wlc**: Requests are distributed based on the weight and load of each backend server. The load refers to the number of connections on a backend server. If multiple backend servers have the same weight, requests are forwarded to the backend server with the least number of connections.
            /// *   **Sch**: The consistent hashing algorithm is used. Requests from the same source IP address are distributed to the same backend server.
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
            /// The ID of the server group.
            /// </summary>
            [NameInMap("ServerGroupId")]
            [Validation(Required=false)]
            public string ServerGroupId { get; set; }

            /// <summary>
            /// The name of the server group.
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
            /// *   **Instance**
            /// *   **Ip**
            /// *   **Fc**
            /// </summary>
            [NameInMap("ServerGroupType")]
            [Validation(Required=false)]
            public string ServerGroupType { get; set; }

            /// <summary>
            /// The service name.
            /// </summary>
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            [NameInMap("SlowStartConfig")]
            [Validation(Required=false)]
            public ListServerGroupsResponseBodyServerGroupsSlowStartConfig SlowStartConfig { get; set; }
            public class ListServerGroupsResponseBodyServerGroupsSlowStartConfig : TeaModel {
                [NameInMap("SlowStartDuration")]
                [Validation(Required=false)]
                public int? SlowStartDuration { get; set; }

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
                /// The cookie that is configured on the server.
                /// </summary>
                [NameInMap("Cookie")]
                [Validation(Required=false)]
                public string Cookie { get; set; }

                /// <summary>
                /// The timeout period of a cookie. Unit: seconds. Valid values: **1** to **86400**.
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
                /// The method that is used to handle a cookie. Valid values:
                /// 
                /// *   **Insert**: inserts a cookie. ALB inserts a cookie (SERVERID) into the first HTTP or HTTPS response packet that is sent to a client. The next request from the client contains this cookie and the listener distributes this request to the recorded backend server.
                /// *   **Server**: rewrites a cookie. When ALB detects a user-defined cookie, it overwrites the original cookie with the user-defined cookie. Subsequent requests to ALB carry this user-defined cookie, and ALB determines the destination servers of the requests based on the cookies.
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
                /// The data type of the common parameter.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The parameter value for consistent hashing.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// Indicates whether long-lived TCP connections are enabled. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("UpstreamKeepaliveEnabled")]
            [Validation(Required=false)]
            public bool? UpstreamKeepaliveEnabled { get; set; }

            /// <summary>
            /// The VPC ID.
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
