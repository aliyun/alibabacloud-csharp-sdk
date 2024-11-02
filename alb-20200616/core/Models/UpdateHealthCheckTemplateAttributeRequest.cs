// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class UpdateHealthCheckTemplateAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the system automatically uses the request ID as the client token. The request ID may be different for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3FF3898</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run, without performing the actual request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs only a dry run. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and service limits. If the request fails the dry run, an error code is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): performs a dry run and performs the actual request. If the request passes the dry run, a <b>2xx</b> HTTP status code is returned and the operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The HTTP status codes that indicate a healthy backend server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("HealthCheckCodes")]
        [Validation(Required=false)]
        public List<string> HealthCheckCodes { get; set; }

        /// <summary>
        /// <para>The port that is used for health checks. Valid values: <b>0 to 65535</b>. Default value: <b>0</b>. This value indicates that the port of a backend server is used for health checks.</para>
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
        /// <item><description><b>$SERVER_IP</b> (default): the private IP address of a backend server. If an IP address is specified, or this parameter is not specified, the ALB instance uses the private IP addresses of backend servers as domain names for health checks.</description></item>
        /// <item><description><b>domain</b>: The domain name must be 1 to 80 characters in length, and can contain letters, digits, periods (.), and hyphens (-).</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is available only if <c>HealthCheckProtocol</c> is set to <b>HTTP</b> or <b>HTTPS</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>$_ip</para>
        /// </summary>
        [NameInMap("HealthCheckHost")]
        [Validation(Required=false)]
        public string HealthCheckHost { get; set; }

        /// <summary>
        /// <para>The HTTP version that is used for health checks.</para>
        /// <para>Valid values: <b>HTTP1.0</b> and <b>HTTP1.1</b>.</para>
        /// <para>Default value: <b>HTTP1.1</b>.</para>
        /// <remarks>
        /// <para> This parameter is available only if you set <c>HealthCheckProtocol</c> to <b>HTTP</b> or <b>HTTPS</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP1.0</para>
        /// </summary>
        [NameInMap("HealthCheckHttpVersion")]
        [Validation(Required=false)]
        public string HealthCheckHttpVersion { get; set; }

        /// <summary>
        /// <para>The interval at which health checks are performed. Unit: seconds. Valid values: <b>1 to 50</b>. Default value: <b>2</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
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
        /// <para> This parameter is available only if you set <b>HealthCheckProtocol</b> to <b>HTTP</b>, <b>HTTPS</b>, or <b>gRPC</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>HEAD</para>
        /// </summary>
        [NameInMap("HealthCheckMethod")]
        [Validation(Required=false)]
        public string HealthCheckMethod { get; set; }

        /// <summary>
        /// <para>The URL that is used for health checks.</para>
        /// <para>The URL must be 1 to 80 characters in length and can contain letters, digits, hyphens (-), forward slashes (/), periods (.), percent signs (%), question marks (?), number signs (#), ampersands (&amp;), and the following extended character sets: <c>_ ; ~ ! ( ) * [ ] @ $ ^ : \\&quot; , +</c>.</para>
        /// <para>The URL must start with a forward slash (/).</para>
        /// <remarks>
        /// <para> This parameter is available only if you set <b>HealthCheckProtocol</b> to <b>HTTP</b>, <b>HTTPS</b>, or <b>gRPC</b>.</para>
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
        /// <item><description><b>TCP</b>: TCP health checks send TCP SYN packets to a backend server to check whether the port of the backend server is reachable.</description></item>
        /// <item><description><b>gRPC</b>: gRPC health checks send POST or GET requests to a backend server to check whether the backend server is healthy.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP</para>
        /// </summary>
        [NameInMap("HealthCheckProtocol")]
        [Validation(Required=false)]
        public string HealthCheckProtocol { get; set; }

        /// <summary>
        /// <para>The template ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hct-bp1qjwo61pqz3ahltv0mw</para>
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
        /// <para>The timeout period of a health check response. If a backend server does not respond within the specified timeout period, the backend server is declared unhealthy.</para>
        /// <para>Unit: seconds. Valid values: <b>1 to 300</b>. Default value: <b>5</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("HealthCheckTimeout")]
        [Validation(Required=false)]
        public int? HealthCheckTimeout { get; set; }

        /// <summary>
        /// <para>The number of times that an unhealthy backend server must consecutively pass health checks before it is declared healthy. In this case, the health status is changed from <b>fail</b> to <b>success</b>.</para>
        /// <para>Valid values: <b>2 to 10</b>.</para>
        /// <para>Default value: <b>3</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("HealthyThreshold")]
        [Validation(Required=false)]
        public int? HealthyThreshold { get; set; }

        /// <summary>
        /// <para>The number of times that a healthy backend server must consecutively fail health checks before it is declared unhealthy. In this case, the health status is changed from <b>success</b> to <b>fail</b>.</para>
        /// <para>Valid values: <b>2 to 10</b>.</para>
        /// <para>Default value: <b>3</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("UnhealthyThreshold")]
        [Validation(Required=false)]
        public int? UnhealthyThreshold { get; set; }

    }

}
