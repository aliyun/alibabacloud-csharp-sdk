// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class UpdateServerGroupAttributeRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request.
        /// 
        /// You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.
        /// 
        /// > If you do not specify this parameter, the system automatically uses the request ID as the client token. The request ID may be different for each request.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The configurations of connection draining.
        /// 
        /// After connection draining is enabled, ALB maintains data transmission for a period of time after the backend server is removed or declared unhealthy.
        /// 
        /// > *   By default, connection draining is disabled. To enable connection draining, contact your account manager.
        /// >*   Basic ALB instances do not support connection draining. Standard and WAF-enabled ALB instances support connection draining.
        /// >*   Server groups of the instance and IP types support connection draining. Server groups of the Function Compute type do not support connection draining.
        /// </summary>
        [NameInMap("ConnectionDrainConfig")]
        [Validation(Required=false)]
        public UpdateServerGroupAttributeRequestConnectionDrainConfig ConnectionDrainConfig { get; set; }
        public class UpdateServerGroupAttributeRequestConnectionDrainConfig : TeaModel {
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
        /// Specifies whether to perform only a dry run, without performing the actual request. Valid values:
        /// 
        /// *   **true**: checks the request without performing the operation. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and service limits. If the request fails the dry run, an error code is returned. If the request passes the dry run, the `DryRunOperation` error code is returned.
        /// *   **false** (default): performs a dry run and performs the actual request. If the request passes the dry run, a `2xx` HTTP status code is returned and the operation is performed.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The configuration of health checks.
        /// </summary>
        [NameInMap("HealthCheckConfig")]
        [Validation(Required=false)]
        public UpdateServerGroupAttributeRequestHealthCheckConfig HealthCheckConfig { get; set; }
        public class UpdateServerGroupAttributeRequestHealthCheckConfig : TeaModel {
            /// <summary>
            /// The HTTP status codes that indicate healthy backend servers.
            /// </summary>
            [NameInMap("HealthCheckCodes")]
            [Validation(Required=false)]
            public List<string> HealthCheckCodes { get; set; }

            /// <summary>
            /// The backend port that is used for health checks.
            /// 
            /// Valid values: **0** to **65535**.
            /// 
            /// If you set the value to **0**, the backend port is used for health checks.
            /// 
            /// >  This parameter takes effect only if you set **HealthCheckEnabled** to **true**.
            /// </summary>
            [NameInMap("HealthCheckConnectPort")]
            [Validation(Required=false)]
            public int? HealthCheckConnectPort { get; set; }

            /// <summary>
            /// Specifies whether to enable the health check feature. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("HealthCheckEnabled")]
            [Validation(Required=false)]
            public bool? HealthCheckEnabled { get; set; }

            /// <summary>
            /// The domain name that is used for health checks. The domain name must meet the following requirements:
            /// 
            /// *   The domain name must be 1 to 80 characters in length.
            /// *   The domain name can contain lowercase letters, digits, hyphens (-), and periods (.).
            /// *   The domain name must contain at least one period (.) but cannot start or end with a period (.).
            /// *   The rightmost field of the domain name can contain only letters and cannot contain digits or hyphens (-).
            /// *   Other fields cannot start or end with a hyphen (-).
            /// 
            /// >  This parameter takes effect only if you set **HealthCheckEnabled** to true and **HealthCheckProtocol** to **HTTP** or **HTTPS**.
            /// </summary>
            [NameInMap("HealthCheckHost")]
            [Validation(Required=false)]
            public string HealthCheckHost { get; set; }

            /// <summary>
            /// The HTTP version for health checks. Valid values:
            /// 
            /// *   **HTTP1.0**
            /// *   **HTTP1.1**
            /// 
            /// >  This parameter takes effect only if you set **HealthCheckEnabled** to true and **HealthCheckProtocol** to **HTTP** or **HTTPS**.
            /// </summary>
            [NameInMap("HealthCheckHttpVersion")]
            [Validation(Required=false)]
            public string HealthCheckHttpVersion { get; set; }

            /// <summary>
            /// The interval at which health checks are performed. Unit: seconds.
            /// 
            /// Valid values: **1** to **50**.
            /// 
            /// >  This parameter takes effect only if you set **HealthCheckEnabled** to **true**.
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
            /// >  This parameter takes effect only if you set **HealthCheckEnabled** to true and **HealthCheckProtocol** to **HTTP**, **HTTPS**, or **gRPC**.
            /// </summary>
            [NameInMap("HealthCheckMethod")]
            [Validation(Required=false)]
            public string HealthCheckMethod { get; set; }

            /// <summary>
            /// The URL that is used for health checks.
            /// 
            /// The URL must be 1 to 80 characters in length, and can contain letters, digits, and the following special characters: `- / . % ? # & =`. It can also contain the following extended characters: `_ ; ~ ! ( ) * [ ] @ $ ^ : \\" , +`. The URL must start with a forward slash (`/`).
            /// 
            /// >  This parameter takes effect only if you set **HealthCheckEnabled** to **true** and **HealthCheckProtocol** to **HTTP** or **HTTPS**.
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
            /// </summary>
            [NameInMap("HealthCheckProtocol")]
            [Validation(Required=false)]
            public string HealthCheckProtocol { get; set; }

            /// <summary>
            /// The timeout period of a health check response. If a backend ECS instance does not respond within the specified timeout period, the ECS instance fails the health check. Unit: seconds.
            /// 
            /// Valid values: **1** to **300**.
            /// 
            /// > 
            /// 
            /// *   If the value of **HealthCHeckTimeout** is smaller than the value of **HealthCheckInterval**, **HealthCHeckTimeout** becomes invalid. The timeout period is specified by the value of **HealthCheckInterval**.
            /// 
            /// *   This parameter takes effect only if you set **HealthCheckEnabled** to **true**.
            /// </summary>
            [NameInMap("HealthCheckTimeout")]
            [Validation(Required=false)]
            public int? HealthCheckTimeout { get; set; }

            /// <summary>
            /// The number of times that an unhealthy backend server must consecutively pass health checks before it can be declared healthy. In this case, the health check status of the backend server changes from **fail** to **success**.
            /// 
            /// Valid values: **2** to **10**.
            /// </summary>
            [NameInMap("HealthyThreshold")]
            [Validation(Required=false)]
            public int? HealthyThreshold { get; set; }

            /// <summary>
            /// The number of times that a healthy backend server must consecutively fail health checks before it can be declared unhealthy. In this case, the health check status of the backend server changes from **success** to **fail**.
            /// 
            /// Valid values: **2** to **10**.
            /// </summary>
            [NameInMap("UnhealthyThreshold")]
            [Validation(Required=false)]
            public int? UnhealthyThreshold { get; set; }

        }

        /// <summary>
        /// The scheduling algorithm. Valid values:
        /// 
        /// *   **Wrr**: the weighted round robin algorithm. Backend servers that have higher weights receive more requests than those that have lower weights.
        /// *   **Wlc**: the weighted least connections algorithm. Requests are distributed based on the weights and the number of connections to backend servers. If two backend servers have the same weight, the backend server that has fewer connections is expected to receive more requests.
        /// *   **Sch**: the consistent hashing algorithm. Requests from the same source IP address are distributed to the same backend server.
        /// </summary>
        [NameInMap("Scheduler")]
        [Validation(Required=false)]
        public string Scheduler { get; set; }

        /// <summary>
        /// The server group ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ServerGroupId")]
        [Validation(Required=false)]
        public string ServerGroupId { get; set; }

        /// <summary>
        /// The server group name.
        /// 
        /// The name must be 2 to 128 characters in length and can contain letters, digits, periods (.), underscores (_), and hyphens (-). The name must start with a letter.
        /// </summary>
        [NameInMap("ServerGroupName")]
        [Validation(Required=false)]
        public string ServerGroupName { get; set; }

        /// <summary>
        /// This parameter is available only if the ALB Ingress controller is used. In this case, set this parameter to the name of the `Kubernetes Service` that is associated with the server group.
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// The configurations of slow starts.
        /// 
        /// After slow starts are enabled, ALB prefetches data to newly added backend servers. Requests distributed to the backend servers gradually increase.
        /// 
        /// > *   Basic ALB instances do not support slow starts. Standard and WAF-enabled ALB instances support slow starts.
        /// >*   Server groups of the instance and IP types support slow starts. Server groups of the Function Compute type do not support slow starts.
        /// >*   Slow start is supported only by the weighted round-robin scheduling algorithm.
        /// </summary>
        [NameInMap("SlowStartConfig")]
        [Validation(Required=false)]
        public UpdateServerGroupAttributeRequestSlowStartConfig SlowStartConfig { get; set; }
        public class UpdateServerGroupAttributeRequestSlowStartConfig : TeaModel {
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
        public UpdateServerGroupAttributeRequestStickySessionConfig StickySessionConfig { get; set; }
        public class UpdateServerGroupAttributeRequestStickySessionConfig : TeaModel {
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
            /// > This parameter takes effect when the **StickySessionEnabled** parameter is set to **true** and the **StickySessionType** parameter is set to **Insert**.
            /// </summary>
            [NameInMap("CookieTimeout")]
            [Validation(Required=false)]
            public int? CookieTimeout { get; set; }

            /// <summary>
            /// Specifies whether to enable session persistence. Valid values:
            /// 
            /// *   **true**
            /// *   **false** (default)
            /// </summary>
            [NameInMap("StickySessionEnabled")]
            [Validation(Required=false)]
            public bool? StickySessionEnabled { get; set; }

            /// <summary>
            /// The method that is used to handle a cookie. Valid values:
            /// 
            /// *   **Insert**: inserts a cookie.
            /// 
            /// ALB inserts a cookie (SERVERID) into the first HTTP or HTTPS response packet that is sent to a client. The next request from the client contains this cookie and the listener forwards this request to the recorded backend server.
            /// 
            /// *   **Server**: rewrites a cookie.
            /// 
            /// When ALB detects a user-defined cookie, it overwrites the original cookie with the user-defined cookie. Subsequent requests to ALB carry this user-defined cookie, and ALB determines the destination servers of the requests based on the cookies.
            /// 
            /// > This parameter takes effect when the **StickySessionEnabled** parameter is set to **true** for the server group.
            /// </summary>
            [NameInMap("StickySessionType")]
            [Validation(Required=false)]
            public string StickySessionType { get; set; }

        }

        /// <summary>
        /// The configurations of consistent hashing based on URLs.
        /// </summary>
        [NameInMap("UchConfig")]
        [Validation(Required=false)]
        public UpdateServerGroupAttributeRequestUchConfig UchConfig { get; set; }
        public class UpdateServerGroupAttributeRequestUchConfig : TeaModel {
            /// <summary>
            /// The type of the parameter. Only query strings are supported.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The value of the parameter used for consistent hashing.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// Specifies whether to enable persistent TCP connections.
        /// </summary>
        [NameInMap("UpstreamKeepaliveEnabled")]
        [Validation(Required=false)]
        public bool? UpstreamKeepaliveEnabled { get; set; }

    }

}
