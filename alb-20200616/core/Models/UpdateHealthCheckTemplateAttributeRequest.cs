// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class UpdateHealthCheckTemplateAttributeRequest : TeaModel {
        /// <summary>
        /// <para>A client token used to ensure the idempotence of the request.</para>
        /// <para>You must generate a unique value on your client for each request. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <c>RequestId</c> of the request as the <c>ClientToken</c>. The <c>RequestId</c> of each request is unique.</para>
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
        /// <item><description><para><b>true</b>: Performs a dry run to check the request. The system checks for required parameters, request syntax, and business constraints without performing the operation. If the request is invalid, an error is returned. If the request is valid, the <c>DryRunOperation</c> error code is returned.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): Sends a normal request. If the request is valid, a <b>2xx HTTP</b> status code is returned and the operation is performed.</para>
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
        /// <para>The list of status codes that indicate a healthy state.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("HealthCheckCodes")]
        [Validation(Required=false)]
        public List<string> HealthCheckCodes { get; set; }

        /// <summary>
        /// <para>The port used for health checks. Valid values: <b>0</b> to <b>65535</b>.
        /// The default value is <b>0</b>, which means the health check uses the backend server\&quot;s port.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("HealthCheckConnectPort")]
        [Validation(Required=false)]
        public int? HealthCheckConnectPort { get; set; }

        /// <summary>
        /// <para>The domain name used for health checks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>$SERVER_IP</b> (default): The private IP of a backend server. If you specify this value or leave the parameter empty, the load balancing service uses the private IP of the backend server for health checks.</para>
        /// </description></item>
        /// <item><description><para><b>domain</b>: A domain name that is 1 to 80 characters long and can contain letters, digits, periods (.), and hyphens (-).</para>
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
        /// <para>The HTTP version used for health checks.</para>
        /// <para>Valid values: <b>HTTP1.0</b> and <b>HTTP1.1</b>.</para>
        /// <para>Default value: <b>HTTP1.1</b>.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when the <c>HealthCheckProtocol</c> parameter is set to <b>HTTP</b> or <b>HTTPS</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP1.0</para>
        /// </summary>
        [NameInMap("HealthCheckHttpVersion")]
        [Validation(Required=false)]
        public string HealthCheckHttpVersion { get; set; }

        /// <summary>
        /// <para>The interval between health checks, in seconds. Valid values: <b>1</b> to <b>50</b>. Default value: <b>2</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("HealthCheckInterval")]
        [Validation(Required=false)]
        public int? HealthCheckInterval { get; set; }

        /// <summary>
        /// <para>The method used for health checks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>HEAD</b> (default): The default method for health checks on HTTP and HTTPS listeners.</para>
        /// </description></item>
        /// <item><description><para><b>GET</b>: If the response body is larger than 8 KB, it is truncated. This does not affect the health check result.</para>
        /// </description></item>
        /// <item><description><para><b>POST</b>: The default method for health checks on gRPC listeners.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter takes effect only when the <b>HealthCheckProtocol</b> parameter is set to <b>HTTP</b>, <b>HTTPS</b>, or <b>gRPC</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>HEAD</para>
        /// </summary>
        [NameInMap("HealthCheckMethod")]
        [Validation(Required=false)]
        public string HealthCheckMethod { get; set; }

        /// <summary>
        /// <para>The URL used for health checks.</para>
        /// <para>The URL must be 1 to 80 characters long. It can contain letters, digits, hyphens (-), forward slashes (/), periods (.), percent signs (%), question marks (?), number signs (#), ampersands (&amp;), and the following extended characters: <c>_;~!()*[]@$^:\\&quot;,+</c>.</para>
        /// <para>The URL must start with a forward slash (/).</para>
        /// <remarks>
        /// <para>This parameter takes effect only when the <b>HealthCheckProtocol</b> parameter is set to <b>HTTP</b>, <b>HTTPS</b>, or <b>gRPC</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>/test/index.html</para>
        /// </summary>
        [NameInMap("HealthCheckPath")]
        [Validation(Required=false)]
        public string HealthCheckPath { get; set; }

        /// <summary>
        /// <para>The protocol used for health checks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>HTTP</b> (default): Checks the health of a backend server by sending an HTTP HEAD or GET request.</para>
        /// </description></item>
        /// <item><description><para><b>HTTPS</b>: Checks the health of a backend server by sending an HTTPS HEAD or GET request. HTTPS is more secure than HTTP because it encrypts data.</para>
        /// </description></item>
        /// <item><description><para><b>TCP</b>: Checks if a backend server port is reachable by sending a TCP SYN packet.</para>
        /// </description></item>
        /// <item><description><para><b>gRPC</b>: Checks the health of a backend server by sending a POST or GET request.</para>
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
        /// <para>The health check template ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hct-bp1qjwo61******</para>
        /// </summary>
        [NameInMap("HealthCheckTemplateId")]
        [Validation(Required=false)]
        public string HealthCheckTemplateId { get; set; }

        /// <summary>
        /// <para>The name of the health check template.</para>
        /// <para>The name must be 2 to 128 characters long, start with a letter, a Chinese character, or a digit, and can contain letters, Chinese characters, digits, periods (.), underscores (_), hyphens (-), and spaces.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HealthCheckTemplate1</para>
        /// </summary>
        [NameInMap("HealthCheckTemplateName")]
        [Validation(Required=false)]
        public string HealthCheckTemplateName { get; set; }

        /// <summary>
        /// <para>The timeout period, in seconds, for a health check response. A health check fails if a backend server does not respond within this period.</para>
        /// <para>Valid values: <b>1</b> to <b>300</b>. Default value: <b>5</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("HealthCheckTimeout")]
        [Validation(Required=false)]
        public int? HealthCheckTimeout { get; set; }

        /// <summary>
        /// <para>The number of consecutive successful health checks required to change a backend server\&quot;s status from <b>unhealthy</b> to <b>healthy</b>.</para>
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
        /// <para>The number of consecutive failed health checks required to change a backend server\&quot;s status from <b>healthy</b> to <b>unhealthy</b>.</para>
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
