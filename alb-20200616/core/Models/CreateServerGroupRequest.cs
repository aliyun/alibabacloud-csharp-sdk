// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class CreateServerGroupRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.
        /// 
        /// > If you do not specify this parameter, the system automatically uses the **request ID** as the **client token**. The **request ID** may be different for each request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Specifies whether to perform only a dry run, without performing the actual request. Valid values:
        /// 
        /// *   **true**: performs only a dry run. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and service limits. If the request fails the dry run, an error code is returned. If the request passes the dry run, the `DryRunOperation` error code is returned.
        /// *   **false** (default): performs a dry run and performs the actual request. If the request passes the dry run, a 2xx HTTP status code is returned and the operation is performed.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The configuration of health checks.
        /// </summary>
        [NameInMap("HealthCheckConfig")]
        [Validation(Required=false)]
        public CreateServerGroupRequestHealthCheckConfig HealthCheckConfig { get; set; }
        public class CreateServerGroupRequestHealthCheckConfig : TeaModel {
            /// <summary>
            /// The HTTP status codes that are used to determine whether the backend server passes the health check.
            /// </summary>
            [NameInMap("HealthCheckCodes")]
            [Validation(Required=false)]
            public List<string> HealthCheckCodes { get; set; }

            /// <summary>
            /// The port that you want to use for health checks on backend servers.
            /// 
            /// Valid values: **0** to **65535**.
            /// 
            /// Default value: **0**. If you set the value to 0, the port of a backend server is used for health checks.
            /// </summary>
            [NameInMap("HealthCheckConnectPort")]
            [Validation(Required=false)]
            public int? HealthCheckConnectPort { get; set; }

            /// <summary>
            /// Indicates whether the health check feature is enabled. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// 
            /// > If the **ServerGroupType** parameter is set to **Instance** or **Ip**, the health check feature is enabled by default. If the **ServerGroupType** parameter is set to **Fc**, the health check feature is disabled by default.
            /// </summary>
            [NameInMap("HealthCheckEnabled")]
            [Validation(Required=false)]
            public bool? HealthCheckEnabled { get; set; }

            /// <summary>
            /// The domain name that is used for health checks. The domain name must meet the following requirements:
            /// 
            /// *   The domain name must be 1 to 80 characters in length.
            /// *   The domain name can contain lowercase letters, digits, hyphens (-), and periods (.).
            /// *   It must contain at least one period (.) but cannot start or end with a period (.).
            /// *   The rightmost domain label of the domain name can contain only letters, and cannot contain digits or hyphens (-).
            /// *   The domain name cannot start or end with a hyphen (-).
            /// 
            /// > This parameter takes effect only when the **HealthCheckProtocol** parameter is set to **HTTP**.
            /// </summary>
            [NameInMap("HealthCheckHost")]
            [Validation(Required=false)]
            public string HealthCheckHost { get; set; }

            /// <summary>
            /// The HTTP version. Valid values: **HTTP1.0** and **HTTP1.1**. Default value: HTTP1.1.
            /// 
            /// > This parameter takes effect only when the **HealthCheckProtocol** parameter is set to **HTTP**.
            /// </summary>
            [NameInMap("HealthCheckHttpVersion")]
            [Validation(Required=false)]
            public string HealthCheckHttpVersion { get; set; }

            /// <summary>
            /// The interval at which health checks are performed. Unit: seconds.
            /// 
            /// Valid values: **1** to **50**.
            /// 
            /// Default value: **2**.
            /// </summary>
            [NameInMap("HealthCheckInterval")]
            [Validation(Required=false)]
            public int? HealthCheckInterval { get; set; }

            /// <summary>
            /// The HTTP method that is used for health checks. Valid values:
            /// 
            /// *   **GET**: If the length of a response exceeds 8 KB, the response is truncated. However, the health check result is not affected.
            /// *   **POST**: gRPC health checks automatically use the POST method.
            /// *   **HEAD**: By default, HTTP health checks use the HEAD method.
            /// 
            /// > This parameter takes effect only when the **HealthCheckProtocol** parameter is set to **HTTP** or **gRPC**.
            /// </summary>
            [NameInMap("HealthCheckMethod")]
            [Validation(Required=false)]
            public string HealthCheckMethod { get; set; }

            /// <summary>
            /// The path that is used for health checks.
            /// 
            /// The path must be 1 to 80 characters in length and can contain only letters, digits, and the following special characters: `- / . % ? # & =`. It can also contain the following extended characters: `_ ; ~ ! ( ) * [ ] @ $ ^ : \" , +`. The URL must start with a forward slash (/).
            /// 
            /// > This parameter takes effect only when the **HealthCheckProtocol** parameter is set to **HTTP**.
            /// </summary>
            [NameInMap("HealthCheckPath")]
            [Validation(Required=false)]
            public string HealthCheckPath { get; set; }

            /// <summary>
            /// The protocol that is used for health checks. Valid values:
            /// 
            /// *   **HTTP**: To perform HTTP health checks, Application Load Balancer (ALB) sends HEAD or GET requests to a backend server to check whether the backend server is healthy.
            /// *   **HTTPS**: To perform HTTPS health checks, ALB sends SYN packets to a backend server to check whether the port of the backend server is available to receive requests.
            /// *   **gRPC**: To perform gRPC health checks, ALB sends POST or GET requests to a backend server to check whether the backend server is healthy.
            /// </summary>
            [NameInMap("HealthCheckProtocol")]
            [Validation(Required=false)]
            public string HealthCheckProtocol { get; set; }

            /// <summary>
            /// Specify the timeout period of a health check response. If a backend server, such as an Elastic Compute Service (ECS) instance, does not return a health check response within the specified timeout period, the server fails the health check. Unit: seconds.
            /// 
            /// Valid values: **1** to **300**.
            /// 
            /// Default value: **5**.
            /// 
            /// > If the value of the **HealthCheckTimeout** parameter is smaller than that of the **HealthCheckInterval** parameter, the timeout period specified by the **HealthCheckTimeout** parameter is ignored and the value of the **HealthCheckInterval** parameter is used as the timeout period.
            /// </summary>
            [NameInMap("HealthCheckTimeout")]
            [Validation(Required=false)]
            public int? HealthCheckTimeout { get; set; }

            /// <summary>
            /// The number of times that an unhealthy backend server must consecutively pass health checks before it is declared healthy. In this case, the health status is changed from **fail** to **success**.
            /// 
            /// Valid values: **2** to **10**.
            /// 
            /// Default value: **3**.
            /// </summary>
            [NameInMap("HealthyThreshold")]
            [Validation(Required=false)]
            public int? HealthyThreshold { get; set; }

            /// <summary>
            /// The number of times that a healthy backend server must consecutively fail health checks before it is declared unhealthy. In this case, the health status is changed from **success** to **fail**.
            /// 
            /// Valid values: **2** to **10**.
            /// 
            /// Default value: **3**.
            /// </summary>
            [NameInMap("UnhealthyThreshold")]
            [Validation(Required=false)]
            public int? UnhealthyThreshold { get; set; }

        }

        /// <summary>
        /// The backend protocol. Valid values:
        /// 
        /// *   **HTTP** (default): The server group can be associated with HTTPS, HTTP, and QUIC listeners.
        /// *   **HTTPS**: The server group can be associated with HTTPS listeners.
        /// *   **gRPC**: The server group can be associated with HTTPS and QUIC listeners.
        /// 
        /// > If the **ServerGroupType** parameter is set to **Fc**, you can set Protocol only to **HTTP**.
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// The scheduling algorithm. Valid values:
        /// 
        /// *   **Wrr** (default): The weighted round-robin algorithm is used. Backend servers that have higher weights receive more requests than those that have lower weights.
        /// *   **Wlc**: The weighted least connections algorithm is used. Requests are distributed based on the weights and the number of connections to backend servers. If two backend servers have the same weight, the backend server that has fewer connections is expected to receive more requests.
        /// *   **Sch**: The consistent hashing algorithm is used. Requests from the same source IP address are distributed to the same backend server.
        /// 
        /// > This parameter takes effect when the **ServerGroupType** parameter is set to **Instance** or **Ip**.
        /// </summary>
        [NameInMap("Scheduler")]
        [Validation(Required=false)]
        public string Scheduler { get; set; }

        /// <summary>
        /// The name of the server group. The name must be 2 to 128 characters in length, and can contain letters, digits, periods (.), underscores (\_), and hyphens (-). The name must start with a letter.
        /// </summary>
        [NameInMap("ServerGroupName")]
        [Validation(Required=false)]
        public string ServerGroupName { get; set; }

        /// <summary>
        /// The type of server group. Valid values:
        /// 
        /// *   **Instance** (default): allows you to add servers by specifying **Ecs**, **Ens**, or **Eci**.
        /// *   **Ip**: allows you to add servers by specifying IP addresses.
        /// *   **Fc**: allows you to add servers by specifying functions of Function Compute.
        /// </summary>
        [NameInMap("ServerGroupType")]
        [Validation(Required=false)]
        public string ServerGroupType { get; set; }

        /// <summary>
        /// This parameter is available only if the ALB Ingress controller is used. In this case, set this parameter to the name of the `Kubernetes Service` that is associated with the server group.
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// The configuration of session persistence.
        /// 
        /// > This parameter takes effect when the **ServerGroupType** parameter is set to **Instance** or **Ip**.
        /// </summary>
        [NameInMap("StickySessionConfig")]
        [Validation(Required=false)]
        public CreateServerGroupRequestStickySessionConfig StickySessionConfig { get; set; }
        public class CreateServerGroupRequestStickySessionConfig : TeaModel {
            /// <summary>
            /// The cookie to be configured on the server.
            /// 
            /// The cookie must be 1 to 200 characters in length and can contain only ASCII characters and digits. It cannot contain commas (,), semicolons (;), or space characters. It cannot start with a dollar sign ($).
            /// 
            /// > This parameter takes effect when the **StickySessionEnabled** parameter is set to **true** and the **StickySessionType** parameter is set to **Server**.
            /// </summary>
            [NameInMap("Cookie")]
            [Validation(Required=false)]
            public string Cookie { get; set; }

            /// <summary>
            /// The timeout period of a cookie. Unit: seconds.
            /// 
            /// Valid values: **1** to **86400**.
            /// 
            /// Default value: **1000**.
            /// 
            /// > This parameter takes effect only when the **StickySessionEnabled** parameter is set to **true** and the **StickySessionType** parameter is set to **Insert**.
            /// </summary>
            [NameInMap("CookieTimeout")]
            [Validation(Required=false)]
            public int? CookieTimeout { get; set; }

            /// <summary>
            /// Specifies whether to enable session persistence. Valid values:
            /// 
            /// *   **true**
            /// *   **false** (default)
            /// 
            /// > This parameter takes effect when the **ServerGroupType** parameter is set to **Instance** or **Ip**.
            /// </summary>
            [NameInMap("StickySessionEnabled")]
            [Validation(Required=false)]
            public bool? StickySessionEnabled { get; set; }

            /// <summary>
            /// The method that is used to handle a cookie. Valid values:
            /// 
            /// *   **Insert** (default): inserts a cookie.
            /// 
            /// ALB inserts a session cookie (SERVERID) into the first HTTP or HTTPS response that is sent to a client. Subsequent requests to ALB carry this cookie, and ALB determines the destination servers of the requests based on the cookies.
            /// 
            /// *   **Server**: rewrites a cookie.
            /// 
            /// When ALB detects a user-defined cookie, it overwrites the original cookie with the user-defined cookie. Subsequent requests to ALB carry this user-defined cookie, and ALB determines the destination servers of the requests based on the cookies.
            /// 
            /// > This parameter takes effect when the **StickySessionEnabled** parameter is set to **true**.
            /// </summary>
            [NameInMap("StickySessionType")]
            [Validation(Required=false)]
            public string StickySessionType { get; set; }

        }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateServerGroupRequestTag> Tag { get; set; }
        public class CreateServerGroupRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The setting of consistent hashing based on URLs.
        /// </summary>
        [NameInMap("UchConfig")]
        [Validation(Required=false)]
        public CreateServerGroupRequestUchConfig UchConfig { get; set; }
        public class CreateServerGroupRequestUchConfig : TeaModel {
            /// <summary>
            /// Type
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The setting of consistent hashing.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("UpstreamKeepaliveEnabled")]
        [Validation(Required=false)]
        public bool? UpstreamKeepaliveEnabled { get; set; }

        /// <summary>
        /// The ID of the virtual private cloud (VPC). You can add only backend servers that are deployed in the specified VPC to the server group.
        /// 
        /// > This parameter takes effect when the **ServerGroupType** parameter is set to **Instance** or **Ip**.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
