// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class GetHealthCheckTemplateAttributeResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status codes that indicate a healthy backend server.
        /// </summary>
        [NameInMap("HealthCheckCodes")]
        [Validation(Required=false)]
        public List<string> HealthCheckCodes { get; set; }

        /// <summary>
        /// The port that is used for health checks.
        /// 
        /// Valid values: **0** to **65535**.
        /// </summary>
        [NameInMap("HealthCheckConnectPort")]
        [Validation(Required=false)]
        public int? HealthCheckConnectPort { get; set; }

        /// <summary>
        /// The domain name that is used for health checks. Valid values:
        /// 
        /// *   **$SERVER_IP**: the private IP addresses of backend servers. If an IP address is specified, or this parameter is not specified, the ALB instance uses the private IP addresses of backend servers as domain names for health checks.
        /// *   **domain**: The domain name must be 1 to 80 characters in length, and can contain letters, digits, periods (.), and hyphens (-).
        /// 
        /// >  This parameter takes effect only if `HealthCheckProtocol` is set to **HTTP** or **HTTPS**.
        /// </summary>
        [NameInMap("HealthCheckHost")]
        [Validation(Required=false)]
        public string HealthCheckHost { get; set; }

        /// <summary>
        /// The HTTP version for health checks.
        /// 
        /// Valid values: **HTTP1.0** and **HTTP1.1**.
        /// 
        /// >  This parameter takes effect only if you set `HealthCheckProtocol` to **HTTP** or **HTTPS**.
        /// </summary>
        [NameInMap("HealthCheckHttpVersion")]
        [Validation(Required=false)]
        public string HealthCheckHttpVersion { get; set; }

        /// <summary>
        /// The interval at which health checks are performed. Unit: seconds. Valid values: **1 to 50**.
        /// </summary>
        [NameInMap("HealthCheckInterval")]
        [Validation(Required=false)]
        public int? HealthCheckInterval { get; set; }

        /// <summary>
        /// The HTTP method that is used for health checks. Valid values:
        /// 
        /// *   **HEAD** (default): By default, HTTP and HTTPS health checks use the HEAD method.
        /// *   **GET**: If the length of a response exceeds 8 KB, the response is truncated. However, the health check result is not affected.
        /// *   **POST**: gRPC health checks use the POST method by default.
        /// 
        /// >  This parameter takes effect only if you set **HealthCheckProtocol** to **HTTP**, **HTTPS**, or **gRPC**.
        /// </summary>
        [NameInMap("HealthCheckMethod")]
        [Validation(Required=false)]
        public string HealthCheckMethod { get; set; }

        /// <summary>
        /// The URL that is used for health checks.
        /// 
        /// The URL must be 1 to 80 characters in length, and can contain letters, digits, the following special characters: - / . % ? # &, and the following extended characters: `_ ; ~ ! ( ) * [ ] @ $ ^ : \\" , +`. The URL must start with a forward slash (/).
        /// 
        /// >  This parameter takes effect only if you set **HealthCheckProtocol** to **HTTP**, **HTTPS**, or **gRPC**.
        /// </summary>
        [NameInMap("HealthCheckPath")]
        [Validation(Required=false)]
        public string HealthCheckPath { get; set; }

        /// <summary>
        /// The protocol that is used for health checks. Valid values:
        /// 
        /// *   **HTTP** (default): HTTP health checks simulate browser behaviors by sending HEAD or GET requests to probe the availability of backend servers.
        /// *   **HTTPS**: The ALB instance sends HEAD or GET requests, which simulate browser requests, to check whether the backend server is healthy. HTTPS supports encryption and provides higher security than HTTP.
        /// *   **TCP**: TCP health checks send TCP SYN packets to a backend server to probe the availability of backend servers.
        /// *   **gRPC**: gRPC health checks send POST or GET requests to a backend server to probe the availability of backend servers.
        /// </summary>
        [NameInMap("HealthCheckProtocol")]
        [Validation(Required=false)]
        public string HealthCheckProtocol { get; set; }

        /// <summary>
        /// The ID of the health check template.
        /// </summary>
        [NameInMap("HealthCheckTemplateId")]
        [Validation(Required=false)]
        public string HealthCheckTemplateId { get; set; }

        /// <summary>
        /// The name of the health check template.
        /// 
        /// The name must be 2 to 128 characters in length, and can contain letters, digits, periods (.), underscores (_), and hyphens (-). The name must start with a letter.
        /// </summary>
        [NameInMap("HealthCheckTemplateName")]
        [Validation(Required=false)]
        public string HealthCheckTemplateName { get; set; }

        /// <summary>
        /// The timeout period of a health check. If a backend server does not respond within the specified timeout period, the backend server fails the health check. Unit: seconds.
        /// 
        /// Valid values: **1** to **300**.
        /// 
        /// > If the value of the `HealthCheckTimeout` parameter is smaller than that of the `HealthCheckInterval` parameter, the timeout period specified by the `HealthCheckTimeout` parameter is ignored and the value of the `HealthCheckInterval` parameter is used as the timeout period.
        /// </summary>
        [NameInMap("HealthCheckTimeout")]
        [Validation(Required=false)]
        public int? HealthCheckTimeout { get; set; }

        /// <summary>
        /// The number of times that an unhealthy backend server must consecutively pass health checks before it is declared healthy. In this case, the health status is changed from **fail** to **success**.
        /// 
        /// Valid values: **2** to **10**.
        /// </summary>
        [NameInMap("HealthyThreshold")]
        [Validation(Required=false)]
        public int? HealthyThreshold { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The tags.
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<GetHealthCheckTemplateAttributeResponseBodyTags> Tags { get; set; }
        public class GetHealthCheckTemplateAttributeResponseBodyTags : TeaModel {
            /// <summary>
            /// The tag key. The tag key can be up to 128 characters in length, and cannot contain `http://` or `https://`. The tag key cannot start with `acs:` or `aliyun`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value. The tag value can be up to 128 characters in length, and cannot start with `acs:`. The tag value cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The number of times that a healthy backend server must consecutively fail health checks before it is declared unhealthy. In this case, the health status is changed from **success** to **fail**.
        /// 
        /// Valid values: **2** to **10**.
        /// </summary>
        [NameInMap("UnhealthyThreshold")]
        [Validation(Required=false)]
        public int? UnhealthyThreshold { get; set; }

    }

}
