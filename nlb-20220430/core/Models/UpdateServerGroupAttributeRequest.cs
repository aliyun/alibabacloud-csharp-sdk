// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlb20220430.Models
{
    public class UpdateServerGroupAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The client token used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token. Ensure that the token is unique among different requests. Only ASCII characters are allowed.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the value of <b>RequestId</b> is used.**** The value of <b>RequestId</b> is different for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable connection draining. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ConnectionDrainEnabled")]
        [Validation(Required=false)]
        public bool? ConnectionDrainEnabled { get; set; }

        /// <summary>
        /// <para>Specify a timeout period for connection draining. Unit: seconds. Valid values: <b>0</b> to <b>900</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("ConnectionDrainTimeout")]
        [Validation(Required=false)]
        public int? ConnectionDrainTimeout { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: validates the request without performing the operation. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and service limits. If the request fails the validation, the corresponding error message is returned. If the request passes the validation, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): validates the request and performs the operation. If the request passes the validation, a 2xx HTTP status code is returned and the operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>Health check configurations.</para>
        /// </summary>
        [NameInMap("HealthCheckConfig")]
        [Validation(Required=false)]
        public UpdateServerGroupAttributeRequestHealthCheckConfig HealthCheckConfig { get; set; }
        public class UpdateServerGroupAttributeRequestHealthCheckConfig : TeaModel {
            /// <summary>
            /// <para>The backend port that is used for health checks. Valid values: <b>0</b> to <b>65535</b>. If you set this parameter to <b>0</b>, the port that the backend server uses to provide services is also used for health checks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("HealthCheckConnectPort")]
            [Validation(Required=false)]
            public int? HealthCheckConnectPort { get; set; }

            /// <summary>
            /// <para>The timeout period for a health check response. Unit: seconds. Valid values: <b>1 to 300</b>. Default value: <b>5</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("HealthCheckConnectTimeout")]
            [Validation(Required=false)]
            public int? HealthCheckConnectTimeout { get; set; }

            /// <summary>
            /// <para>The domain name used for health checks. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>$SERVER_IP</b>: the internal IP address of a backend server.</description></item>
            /// <item><description><b>domain</b>: the specified domain name. The domain name must be 1 to 80 characters in length, and can contain lowercase letters, digits, hyphens (-), and periods (.).</description></item>
            /// </list>
            /// <remarks>
            /// <para> This parameter takes effect only if you set <b>HealthCheckType</b> to <b>HTTP</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>$SERVER_IP</para>
            /// </summary>
            [NameInMap("HealthCheckDomain")]
            [Validation(Required=false)]
            public string HealthCheckDomain { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable health checks. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("HealthCheckEnabled")]
            [Validation(Required=false)]
            public bool? HealthCheckEnabled { get; set; }

            /// <summary>
            /// <para>The response string of UDP health checks. The string must be 1 to 512 characters in length, and can contain letters and digits.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ok</para>
            /// </summary>
            [NameInMap("HealthCheckExp")]
            [Validation(Required=false)]
            public string HealthCheckExp { get; set; }

            /// <summary>
            /// <para>The HTTP status codes to return for health checks. Separate multiple HTTP status codes with commas (,). Valid values: <b>http_2xx</b> (default), <b>http_3xx</b>, <b>http_4xx</b>, and <b>http_5xx</b>.</para>
            /// <remarks>
            /// <para> This parameter takes effect only if you set <b>HealthCheckType</b> to <b>HTTP</b>.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("HealthCheckHttpCode")]
            [Validation(Required=false)]
            public List<string> HealthCheckHttpCode { get; set; }

            /// <summary>
            /// <para>The version of the HTTP protocol. Valid values: <b>HTTP1.0</b> and <b>HTTP1.1</b>.</para>
            /// <remarks>
            /// <para> This parameter takes effect only if you set <b>HealthCheckType</b> to <b>HTTP</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP1.0</para>
            /// </summary>
            [NameInMap("HealthCheckHttpVersion")]
            [Validation(Required=false)]
            public string HealthCheckHttpVersion { get; set; }

            /// <summary>
            /// <para>The interval at which health checks are performed. Unit: seconds. Default value: <b>5</b>.</para>
            /// <list type="bullet">
            /// <item><description>If you set <b>HealthCheckType</b> to <b>TCP</b> or <b>HTTP</b>, valid values are <b>1 to 50</b>.</description></item>
            /// <item><description>If you set <b>HealthCheckType</b> to <b>UDP</b>, valid values are <b>1 to 300</b>. Set the health check interval equal to or larger than the response timeout period to ensure that UDP response timeouts are not determined as no responses.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("HealthCheckInterval")]
            [Validation(Required=false)]
            public int? HealthCheckInterval { get; set; }

            /// <summary>
            /// <para>The request string of UDP health checks. The string must be 1 to 512 characters in length, and can contain letters and digits.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hello</para>
            /// </summary>
            [NameInMap("HealthCheckReq")]
            [Validation(Required=false)]
            public string HealthCheckReq { get; set; }

            /// <summary>
            /// <para>The protocol that is used for health checks. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>TCP</b></description></item>
            /// <item><description><b>HTTP</b></description></item>
            /// <item><description><b>UDP</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TCP</para>
            /// </summary>
            [NameInMap("HealthCheckType")]
            [Validation(Required=false)]
            public string HealthCheckType { get; set; }

            /// <summary>
            /// <para>The path to which health check probes are sent.</para>
            /// <para>The path must be 1 to 80 characters in length and can contain only letters, digits, and the following special characters: <c>- / . % ? # &amp; =</c>. It can also contain the following extended characters: <c>_ ; ~ ! ( ) * [ ] @ $ ^ : \\&quot; , +</c>. It must start with a forward slash (/).</para>
            /// <remarks>
            /// <para> This parameter takes effect only if you set <b>HealthCheckType</b> to <b>HTTP</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>/test/index.html</para>
            /// </summary>
            [NameInMap("HealthCheckUrl")]
            [Validation(Required=false)]
            public string HealthCheckUrl { get; set; }

            /// <summary>
            /// <para>The number of times that an unhealthy backend server must consecutively pass health checks before it is declared healthy. In this case, the health status changes from <b>fail</b> to <b>success</b>. Valid values: <b>2</b> to <b>10</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("HealthyThreshold")]
            [Validation(Required=false)]
            public int? HealthyThreshold { get; set; }

            /// <summary>
            /// <para>The HTTP method used for health checks. Valid values: <b>GET</b> and <b>HEAD</b>.</para>
            /// <remarks>
            /// <para> This parameter takes effect only if you set <b>HealthCheckType</b> to <b>HTTP</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>GET</para>
            /// </summary>
            [NameInMap("HttpCheckMethod")]
            [Validation(Required=false)]
            public string HttpCheckMethod { get; set; }

            /// <summary>
            /// <para>The number of times that a healthy backend server must consecutively fail health checks before it is declared unhealthy. In this case, the health status changes from <b>success</b> to <b>fail</b>. Valid values: <b>2</b> to <b>10</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("UnhealthyThreshold")]
            [Validation(Required=false)]
            public int? UnhealthyThreshold { get; set; }

        }

        [NameInMap("IpVersionAffinityMode")]
        [Validation(Required=false)]
        public string IpVersionAffinityMode { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable client IP preservation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> You cannot set this parameter to <b>true</b> if <b>PreserveClientIpEnabled</b> is set to <b>false</b> and the server group is associated with a listener that uses <b>SSL over TCP</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("PreserveClientIpEnabled")]
        [Validation(Required=false)]
        public bool? PreserveClientIpEnabled { get; set; }

        /// <summary>
        /// <para>The ID of the region where the NLB instance is deployed.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/443657.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The scheduling algorithm. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Wrr</b>: weighted round-robin. Backend servers with higher weights receive more requests.</description></item>
        /// <item><description><b>Wlc</b>: weighted least connections. Requests are distributed based on the weight and load of each backend server. The load refers to the number of connections on a backend server. If multiple backend servers have the same weight, requests are forwarded to the backend server with the least connections.</description></item>
        /// <item><description><b>rr</b>: Requests are forwarded to backend servers in sequence.</description></item>
        /// <item><description><b>sch</b>: source IP hash. Requests from the same source IP address are forwarded to the same backend server.</description></item>
        /// <item><description><b>tch</b>: consistent hashing based on four factors: source IP address, destination IP address, source port, and destination port. Requests that contain the same four factors are forwarded to the same backend server.</description></item>
        /// <item><description><b>qch</b>: QUIC ID hash. Requests that contain the same QUIC ID are forwarded to the same backend server.</description></item>
        /// </list>
        /// <remarks>
        /// <para> QUIC ID hash is supported only when the backend protocol is set to UDP.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Wrr</para>
        /// </summary>
        [NameInMap("Scheduler")]
        [Validation(Required=false)]
        public string Scheduler { get; set; }

        /// <summary>
        /// <para>The server group ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sgp-atstuj3rtoptyui****</para>
        /// </summary>
        [NameInMap("ServerGroupId")]
        [Validation(Required=false)]
        public string ServerGroupId { get; set; }

        /// <summary>
        /// <para>The new name of the server group.</para>
        /// <para>The name must be 2 to 128 characters in length, can contain digits, periods (.), underscores (_), and hyphens (-), and must start with a letter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NLB_ServerGroup1</para>
        /// </summary>
        [NameInMap("ServerGroupName")]
        [Validation(Required=false)]
        public string ServerGroupName { get; set; }

    }

}
