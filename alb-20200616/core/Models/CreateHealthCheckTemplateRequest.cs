// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class CreateHealthCheckTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The client token used to ensure the idempotence of the request.</para>
        /// <para>You can generate this token, but you must ensure that it is unique across requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system uses the <c>RequestId</c> of the request as the client token. Each API request has a unique <c>RequestId</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B******</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Performs a dry run. The system checks the request for potential issues, including missing required parameters, incorrect request syntax, and service limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned. The resource is not created.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): Sends a normal request. If the request is valid, a 2xx HTTP status code is returned and the health check template is created.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The HTTP status codes that indicate a successful health check.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("HealthCheckCodes")]
        [Validation(Required=false)]
        public List<string> HealthCheckCodes { get; set; }

        /// <summary>
        /// <para>The port used for health checks.</para>
        /// <para>Valid values: <b>0</b> to <b>65535</b>.</para>
        /// <para>Default value: <b>0</b>. This value indicates that the port of a backend server is used for health checks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("HealthCheckConnectPort")]
        [Validation(Required=false)]
        public int? HealthCheckConnectPort { get; set; }

        /// <summary>
        /// <para>The domain name used for the health check. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>$SERVER_IP</b>: The private IP address of a backend server. If you set this parameter to <c>$SERVER_IP</c> or leave it empty, the load balancer uses the private IP address of the backend server as the domain name for the health check.</para>
        /// </description></item>
        /// <item><description><para><b>domain</b>: The domain name must be 1 to 80 characters in length and can contain letters, digits, periods (.), and hyphens (-).</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter takes effect only when the <c>HealthCheckProtocol</c> parameter is set to <b>HTTP</b> or <b>HTTPS</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>$SERVER_IP</para>
        /// </summary>
        [NameInMap("HealthCheckHost")]
        [Validation(Required=false)]
        public string HealthCheckHost { get; set; }

        /// <summary>
        /// <para>The version of the HTTP protocol that is used for the health check.</para>
        /// <para>Valid values: <b>HTTP1.0</b> and <b>HTTP1.1</b>.</para>
        /// <para>Default value: <b>HTTP1.1</b>.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when the <c>HealthCheckProtocol</c> parameter is set to <b>HTTP</b> or <b>HTTPS</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP 1.0</para>
        /// </summary>
        [NameInMap("HealthCheckHttpVersion")]
        [Validation(Required=false)]
        public string HealthCheckHttpVersion { get; set; }

        /// <summary>
        /// <para>The interval at which health checks are performed.</para>
        /// <para>Valid values: <b>1</b> to <b>50</b>. Unit: seconds.</para>
        /// <para>Default value: <b>2</b>. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("HealthCheckInterval")]
        [Validation(Required=false)]
        public int? HealthCheckInterval { get; set; }

        /// <summary>
        /// <para>The method used for the health check. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>HEAD</b> (default): For HTTP and HTTPS listeners, the default health check method is HEAD.</para>
        /// </description></item>
        /// <item><description><para><b>POST</b>: For gRPC listeners, the default health check method is POST.</para>
        /// </description></item>
        /// <item><description><para><b>GET</b>: If the response body exceeds 8 KB, it is truncated. This does not affect the health check result.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter takes effect only when the <c>HealthCheckProtocol</c> parameter is set to <b>HTTP</b>, <b>HTTPS</b>, or <b>gRPC</b>.</para>
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
        /// <para>The URL must be 1 to 80 characters in length. It must start with a forward slash (/) and can contain letters, digits, and the following special characters: <c>- / . % ? # &amp; _;~!()*[]@$^:\\&quot;,+</c>.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when the <c>HealthCheckProtocol</c> parameter is set to <b>HTTP</b> or <b>HTTPS</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>/test/index.html</para>
        /// </summary>
        [NameInMap("HealthCheckPath")]
        [Validation(Required=false)]
        public string HealthCheckPath { get; set; }

        /// <summary>
        /// <para>The protocol used for the health check. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>HTTP</b> (default): simulates browser access by sending HEAD or GET requests to check whether the server application is healthy.</para>
        /// </description></item>
        /// <item><description><para><b>HTTPS</b>: simulates browser access by sending HEAD or GET requests to check whether the server application is healthy. HTTPS provides encrypted data transmission and is more secure than HTTP.</para>
        /// </description></item>
        /// <item><description><para><b>TCP</b>: checks whether the server port is responsive by sending SYN packets.</para>
        /// </description></item>
        /// <item><description><para><b>gRPC</b>: checks whether the server application is healthy by sending POST or GET requests.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP</para>
        /// </summary>
        [NameInMap("HealthCheckProtocol")]
        [Validation(Required=false)]
        public string HealthCheckProtocol { get; set; }

        /// <summary>
        /// <para>The name of the health check template.</para>
        /// <para>The name must be 2 to 128 characters in length, must start with a letter, a digit, or a Chinese character, and can contain digits, periods (.), underscores (_), hyphens (-), and spaces.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HealthCheckTemplate1</para>
        /// </summary>
        [NameInMap("HealthCheckTemplateName")]
        [Validation(Required=false)]
        public string HealthCheckTemplateName { get; set; }

        /// <summary>
        /// <para>The timeout period for a health check response. If a backend server does not respond within this period, the health check fails.</para>
        /// <para>Valid values: <b>1</b> to <b>300</b>. Unit: seconds.</para>
        /// <para>Default value: <b>5</b>. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("HealthCheckTimeout")]
        [Validation(Required=false)]
        public int? HealthCheckTimeout { get; set; }

        /// <summary>
        /// <para>The number of consecutive successful health checks required to change the health status of a backend server from <b>unhealthy</b> to <b>healthy</b>.</para>
        /// <para>Valid values: <b>2</b> to <b>10</b>.</para>
        /// <para>Default value: <b>3</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("HealthyThreshold")]
        [Validation(Required=false)]
        public int? HealthyThreshold { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-atstuj3rtop****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateHealthCheckTemplateRequestTag> Tag { get; set; }
        public class CreateHealthCheckTemplateRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. The tag key can be up to 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c> and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>env</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. The tag value can be up to 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c> and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>product</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The number of consecutive failed health checks required to change the health status of a backend server from <b>healthy</b> to <b>unhealthy</b>.</para>
        /// <para>Valid values: <b>2</b> to <b>10</b>.</para>
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
