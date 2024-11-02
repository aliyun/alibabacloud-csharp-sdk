// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class GetHealthCheckTemplateAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status codes that indicate a healthy backend server.</para>
        /// </summary>
        [NameInMap("HealthCheckCodes")]
        [Validation(Required=false)]
        public List<string> HealthCheckCodes { get; set; }

        /// <summary>
        /// <para>The port that is used for health checks.</para>
        /// <para>Valid values: <b>0</b> to <b>65535</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("HealthCheckConnectPort")]
        [Validation(Required=false)]
        public int? HealthCheckConnectPort { get; set; }

        /// <summary>
        /// <para>The domain name that is used for health checks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>$SERVER_IP</b>: the private IP addresses of backend servers. If an IP address is specified, or this parameter is not specified, the ALB instance uses the private IP addresses of backend servers as domain names for health checks.</description></item>
        /// <item><description><b>domain</b>: The domain name must be 1 to 80 characters in length, and can contain letters, digits, periods (.), and hyphens (-).</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter takes effect only if <c>HealthCheckProtocol</c> is set to <b>HTTP</b> or <b>HTTPS</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>$SERVER_IP</para>
        /// </summary>
        [NameInMap("HealthCheckHost")]
        [Validation(Required=false)]
        public string HealthCheckHost { get; set; }

        /// <summary>
        /// <para>The HTTP version for health checks.</para>
        /// <para>Valid values: <b>HTTP1.0</b> and <b>HTTP1.1</b>.</para>
        /// <remarks>
        /// <para> This parameter takes effect only if you set <c>HealthCheckProtocol</c> to <b>HTTP</b> or <b>HTTPS</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP1.0</para>
        /// </summary>
        [NameInMap("HealthCheckHttpVersion")]
        [Validation(Required=false)]
        public string HealthCheckHttpVersion { get; set; }

        /// <summary>
        /// <para>The interval at which health checks are performed. Unit: seconds. Valid values: <b>1 to 50</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("HealthCheckInterval")]
        [Validation(Required=false)]
        public int? HealthCheckInterval { get; set; }

        /// <summary>
        /// <para>The HTTP method that is used for health checks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>HEAD</b> (default): By default, HTTP and HTTPS health checks use the HEAD method.</description></item>
        /// <item><description><b>GET</b>: If the length of a response exceeds 8 KB, the response is truncated. However, the health check result is not affected.</description></item>
        /// <item><description><b>POST</b>: gRPC health checks use the POST method by default.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter takes effect only if you set <b>HealthCheckProtocol</b> to <b>HTTP</b>, <b>HTTPS</b>, or <b>gRPC</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>GET</para>
        /// </summary>
        [NameInMap("HealthCheckMethod")]
        [Validation(Required=false)]
        public string HealthCheckMethod { get; set; }

        /// <summary>
        /// <para>The URL that is used for health checks.</para>
        /// <para>The URL must be 1 to 80 characters in length, and can contain letters, digits, the following special characters: - / . % ? # &amp;, and the following extended characters: <c>_ ; ~ ! ( ) * [ ] @ $ ^ : \\&quot; , +</c>. The URL must start with a forward slash (/).</para>
        /// <remarks>
        /// <para> This parameter takes effect only if you set <b>HealthCheckProtocol</b> to <b>HTTP</b>, <b>HTTPS</b>, or <b>gRPC</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>/test/index.html</para>
        /// </summary>
        [NameInMap("HealthCheckPath")]
        [Validation(Required=false)]
        public string HealthCheckPath { get; set; }

        /// <summary>
        /// <para>The protocol that is used for health checks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>HTTP</b> (default): HTTP health checks simulate browser behaviors by sending HEAD or GET requests to probe the availability of backend servers.</description></item>
        /// <item><description><b>HTTPS</b>: The ALB instance sends HEAD or GET requests, which simulate browser requests, to check whether the backend server is healthy. HTTPS supports encryption and provides higher security than HTTP.</description></item>
        /// <item><description><b>TCP</b>: TCP health checks send TCP SYN packets to a backend server to probe the availability of backend servers.</description></item>
        /// <item><description><b>gRPC</b>: gRPC health checks send POST or GET requests to a backend server to probe the availability of backend servers.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP</para>
        /// </summary>
        [NameInMap("HealthCheckProtocol")]
        [Validation(Required=false)]
        public string HealthCheckProtocol { get; set; }

        /// <summary>
        /// <para>The ID of the health check template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hct-x4jazoyi6tvsq9****</para>
        /// </summary>
        [NameInMap("HealthCheckTemplateId")]
        [Validation(Required=false)]
        public string HealthCheckTemplateId { get; set; }

        /// <summary>
        /// <para>The name of the health check template.</para>
        /// <para>The name must be 2 to 128 characters in length, and can contain letters, digits, periods (.), underscores (_), and hyphens (-). The name must start with a letter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HealthCheckTemplate1</para>
        /// </summary>
        [NameInMap("HealthCheckTemplateName")]
        [Validation(Required=false)]
        public string HealthCheckTemplateName { get; set; }

        /// <summary>
        /// <para>The timeout period of a health check response. If a backend server does not respond within the specified timeout period, the backend server is declared unhealthy. Unit: seconds.</para>
        /// <para>Valid values: <b>1</b> to <b>300</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HealthCheckTimeout")]
        [Validation(Required=false)]
        public int? HealthCheckTimeout { get; set; }

        /// <summary>
        /// <para>The number of times that an unhealthy backend server must consecutively pass health checks before it is declared healthy. In this case, the health status is changed from <b>fail</b> to <b>success</b>.</para>
        /// <para>Valid values: <b>2</b> to <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("HealthyThreshold")]
        [Validation(Required=false)]
        public int? HealthyThreshold { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DB1AFC33-DAE8-528E-AA4D-4A6AABE71945</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<GetHealthCheckTemplateAttributeResponseBodyTags> Tags { get; set; }
        public class GetHealthCheckTemplateAttributeResponseBodyTags : TeaModel {
            /// <summary>
            /// <para>The tag key. The tag key can be up to 128 characters in length, and cannot contain <c>http://</c> or <c>https://</c>. The tag key cannot start with <c>acs:</c> or <c>aliyun</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>env</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. The tag value can be up to 128 characters in length, and cannot start with <c>acs:</c>. The tag value cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>product</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The number of times that a healthy backend server must consecutively fail health checks before it is declared unhealthy. In this case, the health status is changed from <b>success</b> to <b>fail</b>.</para>
        /// <para>Valid values: <b>2</b> to <b>10</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("UnhealthyThreshold")]
        [Validation(Required=false)]
        public int? UnhealthyThreshold { get; set; }

    }

}
