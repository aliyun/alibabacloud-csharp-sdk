// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class CreateHealthCheckTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>Generate a parameter value on your client to ensure that the value is unique across different requests. The ClientToken parameter supports only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the RequestId of the API request as the ClientToken. The RequestId of each API request is unique.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B******</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to only precheck the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: sends a precheck request without creating the resource. The system checks whether required parameters are specified, the request format is valid, and service limits are met. If the request fails the precheck, the corresponding error is returned. If the request passes the precheck, the <c>DryRunOperation</c> error code is returned.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): sends a normal request. After the request passes the precheck, the <b>http_2xx</b> status code is returned and the operation is performed.</para>
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
        /// <para>The list of normal status codes for health checks.</para>
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
        /// <para>Default value: <b>0</b>, which indicates that the port of the backend server is used for health checks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("HealthCheckConnectPort")]
        [Validation(Required=false)]
        public int? HealthCheckConnectPort { get; set; }

        /// <summary>
        /// <para>The domain name used for health checks. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><para><b>$SERVER_IP</b>: the private IP of the backend server. If an IP address is specified or this parameter is not specified, load balancing uses the private IP of the backend server as the domain name for health checks.</para>
        /// </description></item>
        /// <item><description><para><b>domain</b>: The domain name must be 1 to 80 characters in length, and can contain only letters, digits, periods (.), and hyphens (-).</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter takes effect only when <c>HealthCheckProtocol</c> is set to <b>HTTP</b> or <b>HTTPS</b>.</para>
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
        /// <para>Valid values: <b>HTTP 1.0</b> and <b>HTTP 1.1</b>.</para>
        /// <para>Default value: <b>HTTP 1.1</b>.</para>
        /// <remarks>
        /// <para>This parameter is available only when <c>HealthCheckProtocol</c> is set to <b>HTTP</b> or <b>HTTPS</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP 1.0</para>
        /// </summary>
        [NameInMap("HealthCheckHttpVersion")]
        [Validation(Required=false)]
        public string HealthCheckHttpVersion { get; set; }

        /// <summary>
        /// <para>The interval between health checks.</para>
        /// <para>Valid values: <b>1</b> to <b>50</b>. Unit: seconds.</para>
        /// <para>Default value: <b>2</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("HealthCheckInterval")]
        [Validation(Required=false)]
        public int? HealthCheckInterval { get; set; }

        /// <summary>
        /// <para>The health check method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>HEAD</b> (default): the default method for HTTP and HTTPS listener health checks.</para>
        /// </description></item>
        /// <item><description><para><b>POST</b>: the default method for gRPC listener health checks.</para>
        /// </description></item>
        /// <item><description><para><b>GET</b>: If the length of the response message exceeds 8 KB, the message is truncated. However, this does not affect the health check result.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is available only when <b>HealthCheckProtocol</b> is set to <b>HTTP</b>, <b>HTTPS</b>, or <b>gRPC</b>.</para>
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
        /// <para>The URL must be 1 to 80 characters in length, and can contain letters, digits, hyphens (-), forward slashes (/), periods (.), percent signs (%), question marks (?), number signs (#), ampersands (&amp;), and the following extended characters: <c>_;~!()*[]@$^:\&quot;,+</c>. The URL must start with a forward slash (/).</para>
        /// <remarks>
        /// <para>This parameter is available only when <c>HealthCheckProtocol</c> is set to <b>HTTP</b> or <b>HTTPS</b>.</para>
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
        /// <item><description><para><b>HTTP</b> (default): sends HEAD or GET requests for browser access impersonation to check whether the server application is healthy.</para>
        /// </description></item>
        /// <item><description><para><b>HTTPS</b>: sends HEAD or GET requests for browser access impersonation to check whether the server application is healthy. (Provides data encryption, making it more secure than HTTP.)</para>
        /// </description></item>
        /// <item><description><para><b>TCP</b>: sends SYN handshake messages to check whether the server port is alive.</para>
        /// </description></item>
        /// <item><description><para><b>gRPC</b>: sends POST or GET requests to check whether the server application is healthy.</para>
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
        /// <para>The name of the health check template. The name must be 2 to 128 characters in length. It must start with a letter, Chinese character, or digit, and can contain letters, Chinese characters, digits, periods (.), underscores (_), hyphens (-), and spaces.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HealthCheckTemplate1</para>
        /// </summary>
        [NameInMap("HealthCheckTemplateName")]
        [Validation(Required=false)]
        public string HealthCheckTemplateName { get; set; }

        /// <summary>
        /// <para>The timeout period for receiving a response from a health check. If the backend server does not respond within the specified timeout period, the health check fails.</para>
        /// <para>Valid values: <b>1</b> to <b>300</b>. Unit: seconds.</para>
        /// <para>Default value: <b>5</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("HealthCheckTimeout")]
        [Validation(Required=false)]
        public int? HealthCheckTimeout { get; set; }

        /// <summary>
        /// <para>The number of consecutive successful health checks that must occur before the health check status of a backend server changes from <b>Failed</b> to <b>Successful</b>.</para>
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
            /// <para>The tag key. The key can be up to 128 characters in length, and cannot start with aliyun or acs:. It cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>env</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. The value can be up to 128 characters in length, and cannot start with aliyun or acs:. It cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>product</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The number of consecutive failed health checks that must occur before the health check status of a backend server changes from <b>Successful</b> to <b>Failed</b>.</para>
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
