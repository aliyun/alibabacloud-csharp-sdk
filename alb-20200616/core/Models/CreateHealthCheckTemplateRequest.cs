// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class CreateHealthCheckTemplateRequest : TeaModel {
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
        /// Specifies whether to perform only a dry run, without performing the actual request. Valid values:
        /// 
        /// *   **true**: performs only a dry run. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and service limits. If the request fails the dry run, an error code is returned. If the request passes the dry run, the `DryRunOperation` error code is returned.
        /// *   **false** (default): performs a dry run and performs the actual request. If the request passes the dry run, a **2xx** HTTP status code is returned and the operation is performed.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// The interval at which health checks are performed.
        /// 
        /// Valid values: **1 to 50**.
        /// 
        /// Default value: **2**.
        /// </summary>
        [NameInMap("HealthCheckCodes")]
        [Validation(Required=false)]
        public List<string> HealthCheckCodes { get; set; }

        /// <summary>
        /// The port that is used for health checks.
        /// 
        /// Valid values: **0 to 65535**.
        /// 
        /// Default value: **0**. If you set the value to 0, the port of a backend server is used for health checks.
        /// </summary>
        [NameInMap("HealthCheckConnectPort")]
        [Validation(Required=false)]
        public int? HealthCheckConnectPort { get; set; }

        /// <summary>
        /// The domain name that you want to use for the health check.
        /// 
        /// Default value: **$SERVER_IP**. The domain name must be 1 to 80 characters in length. The domain name must meet the following requirements:
        /// 
        /// *   The domain name can contain lowercase letters, digits, hyphens (-), and periods (.).
        /// *   The domain name must contain at least one period (.) but cannot start or end with a period (.).
        /// *   The rightmost domain label can contain only letters but cannot contain digits or hyphens (-).
        /// *   Other fields cannot start or end with a hyphen (-).
        /// 
        /// This parameter is required only if the **HealthCheckProtocol** parameter is set to **HTTP**.
        /// </summary>
        [NameInMap("HealthCheckHost")]
        [Validation(Required=false)]
        public string HealthCheckHost { get; set; }

        /// <summary>
        /// The HTTP version that is used for health checks.
        /// 
        /// Valid values: **HTTP 1.0** and **HTTP 1.1**.
        /// 
        /// Default value: **HTTP 1.1**.
        /// 
        /// > This parameter is valid only if the `HealthCheckProtocol` parameter is set to **HTTP**.
        /// </summary>
        [NameInMap("HealthCheckHttpVersion")]
        [Validation(Required=false)]
        public string HealthCheckHttpVersion { get; set; }

        /// <summary>
        /// The interval at which health checks are performed.
        /// 
        /// Valid values: **1 to 50**.
        /// 
        /// Default value: **2**.
        /// </summary>
        [NameInMap("HealthCheckInterval")]
        [Validation(Required=false)]
        public int? HealthCheckInterval { get; set; }

        /// <summary>
        /// The method that you want to use for the health check. Valid values:
        /// 
        /// *   **HEAD**: By default, the ALB instance sends HEAD requests to a backend server to perform HTTP health checks.
        /// *   **POST**: gRPC health checks automatically use the POST method.
        /// *   **GET**: If the length of a response exceeds 8 KB, the response is truncated. However, the health check result is not affected.
        /// 
        /// > This parameter takes effect only when the **HealthCheckProtocol** parameter is set to **HTTP** or **gRPC**.
        /// </summary>
        [NameInMap("HealthCheckMethod")]
        [Validation(Required=false)]
        public string HealthCheckMethod { get; set; }

        /// <summary>
        /// The URL that is used for health checks.
        /// 
        /// It must be 1 to 80 characters in length, and can contain letters, digits, hyphens (-), forward slashes (/), periods (.), percent signs (%), question marks (?), number signs (#), and ampersands (&). It can also contain the following extended characters: `_ ; ~ ! ( ) * [ ] @ $ ^ : \" , +`. The URL must start with a forward slash (/).
        /// 
        /// > This parameter is valid only if the `HealthCheckProtocol` parameter is set to **HTTP**.
        /// </summary>
        [NameInMap("HealthCheckPath")]
        [Validation(Required=false)]
        public string HealthCheckPath { get; set; }

        /// <summary>
        /// The protocol that you want to use for health checks. Valid values:
        /// 
        /// *   **HTTP** (default): To perform HTTP health checks, ALB sends HEAD or GET requests to a backend server to check whether the backend server is healthy.
        /// *   **TCP**: To perform TCP health checks, ALB sends SYN packets to a backend server to check whether the port of the backend server is available to receive requests.
        /// *   **gRPC**: To perform gRPC health checks, ALB sends POST or GET requests to a backend server to check whether the backend server is healthy.
        /// </summary>
        [NameInMap("HealthCheckProtocol")]
        [Validation(Required=false)]
        public string HealthCheckProtocol { get; set; }

        /// <summary>
        /// The name of the health check template.
        /// 
        /// The name must be 2 to 128 characters in length, and can contain letters, digits, periods (.), underscores (\_), and hyphens (-). The name must start with a letter.
        /// </summary>
        [NameInMap("HealthCheckTemplateName")]
        [Validation(Required=false)]
        public string HealthCheckTemplateName { get; set; }

        /// <summary>
        /// The timeout period of a health check. If a backend server does not respond within the specified timeout period, the backend server fails the health check.
        /// 
        /// Valid values: **1 to 300**.
        /// 
        /// Default value: **5**.
        /// 
        /// > If the value of the `HealthCheckTimeout` parameter is smaller than that of the `HealthCheckInterval` parameter, the timeout period specified by the `HealthCheckTimeout` parameter is ignored and the value of the `HealthCheckInterval` parameter is used as the timeout period.
        /// </summary>
        [NameInMap("HealthCheckTimeout")]
        [Validation(Required=false)]
        public int? HealthCheckTimeout { get; set; }

        /// <summary>
        /// The number of times that an unhealthy backend server must consecutively pass health checks before it is declared healthy. In this case, the health status is changed from **fail** to **success**.
        /// 
        /// Valid values: **2 to 10**.
        /// 
        /// Default value: **3**.
        /// </summary>
        [NameInMap("HealthyThreshold")]
        [Validation(Required=false)]
        public int? HealthyThreshold { get; set; }

        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateHealthCheckTemplateRequestTag> Tag { get; set; }
        public class CreateHealthCheckTemplateRequestTag : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The number of times that a healthy backend server must consecutively fail health checks before it is declared unhealthy. In this case, the health status is changed from **success** to **fail**.
        /// 
        /// Valid values: **2 to 10**.
        /// 
        /// Default value: **3**.
        /// </summary>
        [NameInMap("UnhealthyThreshold")]
        [Validation(Required=false)]
        public int? UnhealthyThreshold { get; set; }

    }

}
