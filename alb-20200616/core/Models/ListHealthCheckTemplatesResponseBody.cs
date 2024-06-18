// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ListHealthCheckTemplatesResponseBody : TeaModel {
        /// <summary>
        /// The health check templates.
        /// </summary>
        [NameInMap("HealthCheckTemplates")]
        [Validation(Required=false)]
        public List<ListHealthCheckTemplatesResponseBodyHealthCheckTemplates> HealthCheckTemplates { get; set; }
        public class ListHealthCheckTemplatesResponseBodyHealthCheckTemplates : TeaModel {
            /// <summary>
            /// The HTTP status codes that indicate healthy backend servers.
            /// </summary>
            [NameInMap("HealthCheckCodes")]
            [Validation(Required=false)]
            public List<string> HealthCheckCodes { get; set; }

            /// <summary>
            /// The port that is used for health checks.
            /// 
            /// Valid values: \\*\\* 0 to 65535\\*\\*.
            /// 
            /// The default value is **0**, which specifies that the port of a backend server is used for health checks.
            /// </summary>
            [NameInMap("HealthCheckConnectPort")]
            [Validation(Required=false)]
            public int? HealthCheckConnectPort { get; set; }

            /// <summary>
            /// The domain name that is used for health checks. Valid values:
            /// 
            /// *   **$SERVER_IP** (default): the private IP address of a backend server. If an IP address is specified, or this parameter is not specified, the ALB instance uses the private IP address of each backend server as the domain name for health checks.
            /// *   **domain**: The domain name must be 1 to 80 characters in length, and can contain letters, digits, periods (.), and hyphens (-).
            /// 
            /// >  This parameter takes effect only when `HealthCheckProtocol` is set to **HTTP** or **HTTPS**. HTTPS is unavailable by default. If you want to use HTTPS, log on to the SLB console, go to the Quota Center page, click the **ALB** tab, and then apply for the privilege to use HTTPs.
            /// </summary>
            [NameInMap("HealthCheckHost")]
            [Validation(Required=false)]
            public string HealthCheckHost { get; set; }

            /// <summary>
            /// The HTTP version for health checks.
            /// 
            /// Valid values: **HTTP 1.0** and **HTTP 1.1**.
            /// 
            /// Default value: **HTTP 1.1**.
            /// 
            /// >  This parameter takes effect only when `HealthCheckProtocol` is set to **HTTP** or **HTTPS**. HTTPS is unavailable by default. If you want to use HTTPS, log on to the SLB console, go to the Quota Center page, click the **ALB** tab, and then apply for the privilege to use HTTPs.
            /// </summary>
            [NameInMap("HealthCheckHttpVersion")]
            [Validation(Required=false)]
            public string HealthCheckHttpVersion { get; set; }

            /// <summary>
            /// The interval at which health checks are performed. Unit: seconds. Valid values: **1 to 50**. Default value: **2**.
            /// </summary>
            [NameInMap("HealthCheckInterval")]
            [Validation(Required=false)]
            public int? HealthCheckInterval { get; set; }

            /// <summary>
            /// The HTTP method that is used for health checks. Valid value:
            /// 
            /// *   **HEAD** (default): By default, HTTP and HTTPS health checks use the HEAD method.
            /// *   **GET**: If the length of a response exceeds 8 KB, the response is truncated. However, the health check result is not affected.
            /// *   **POST**: gRPC health checks use the POST method by default.
            /// 
            /// >  This parameter takes effect only when **HealthCheckProtocol** is set to **HTTP**, **HTTPS**, or **gRPC**. HTTPS is unavailable by default. If you want to use HTTPS, log on to the SLB console, go to the Quota Center page, click the **ALB** tab, and then apply for the privilege to use HTTPs.
            /// </summary>
            [NameInMap("HealthCheckMethod")]
            [Validation(Required=false)]
            public string HealthCheckMethod { get; set; }

            /// <summary>
            /// The URL path that you want to use for health checks.
            /// 
            /// The URL must be 1 to 80 characters in length, and can contain letters, digits, the following special characters: - / . % ? # &, and the following extended characters: `_ ; ~ ! ( ) * [ ] @ $ ^ : \\" , +`. The URL must start with a forward slash (/).
            /// </summary>
            [NameInMap("HealthCheckPath")]
            [Validation(Required=false)]
            public string HealthCheckPath { get; set; }

            /// <summary>
            /// The protocol that is used for health checks. Valid value:
            /// 
            /// *   **HTTP** (default): The ALB instance sends HEAD or GET requests, which simulate browser requests, to check whether the backend server is healthy.
            /// *   **HTTPS**: The ALB instance sends HEAD or GET requests, which simulate browser requests, to check whether the backend server is healthy. HTTPS provides higher security because HTTPS supports data encryption.
            /// *   **TCP**: TCP health checks send TCP SYN packets to a backend server to check whether the port of the backend server is reachable.
            /// *   **gRPC**: The ALB instance sends POST or GET requests to a backend server to check whether the backend server is healthy.
            /// 
            /// >  HTTPS is unavailable by default. If you want to use HTTPS, log on to the SLB console, go to the Quota Center page, click the **ALB** tab, and then apply for the privilege to use HTTPs.
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
            /// The name must be 2 to 128 character characters in length, and can contain letters, digits, periods (.), underscores (_), and hyphens (-). It must start with a letter.
            /// </summary>
            [NameInMap("HealthCheckTemplateName")]
            [Validation(Required=false)]
            public string HealthCheckTemplateName { get; set; }

            /// <summary>
            /// The timeout period of a health check response. If a backend Elastic Compute Service (ECS) instance does not respond within the specified timeout period, the ECS instance fails to pass the health check.
            /// 
            /// Valid values: **1 to 300**. Unit: seconds.
            /// 
            /// Default value: **5**.
            /// 
            /// >  If the value of **HealthCHeckTimeout** is smaller than the value of **HealthCheckInterval**, **HealthCHeckTimeout** does not take effect. The value of **HealthCheckInterval** specifies the timeout period.
            /// </summary>
            [NameInMap("HealthCheckTimeout")]
            [Validation(Required=false)]
            public int? HealthCheckTimeout { get; set; }

            /// <summary>
            /// The number of times that an unhealthy backend server must consecutively pass health checks before it is declared healthy. In this case, the health status changes from **fail** to **success**.
            /// 
            /// Valid values: **2 to 10**.
            /// 
            /// Default value: **3**.
            /// </summary>
            [NameInMap("HealthyThreshold")]
            [Validation(Required=false)]
            public int? HealthyThreshold { get; set; }

            /// <summary>
            /// The tags.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListHealthCheckTemplatesResponseBodyHealthCheckTemplatesTags> Tags { get; set; }
            public class ListHealthCheckTemplatesResponseBodyHealthCheckTemplatesTags : TeaModel {
                /// <summary>
                /// The tag key. The tag key can be up to 128 characters in length, and cannot contain `http://` or `https://`. The tag key cannot start with `acs:` or `aliyun`.
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The tag value. The tag value can be up to 128 characters in length, and cannot contain `http://` or `https://`. The tag value cannot start with `acs:` or `aliyun`.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The number of times that a healthy backend server must consecutively fail health checks before it is declared unhealthy. In this case, the health status changes from **success** to **fail**.
            /// 
            /// Valid values: **2 to 10**.
            /// 
            /// Default value: **3**.
            /// </summary>
            [NameInMap("UnhealthyThreshold")]
            [Validation(Required=false)]
            public int? UnhealthyThreshold { get; set; }

        }

        /// <summary>
        /// The number of entries returned per page. Valid values: **1** to **100**. Default value: **20**.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The returned value of NextToken is a pagination token, which can be used in the next request to retrieve a new page of results. Valid values:
        /// 
        /// *   If **NextToken** is empty, no next page exists.
        /// *   If a value of **NextToken** was returned in the previous query, specify the value to obtain the next set of results.
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
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
