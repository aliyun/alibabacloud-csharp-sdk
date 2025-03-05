// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class UpdateServerGroupAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the request ID as the client token. The request ID may be different for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3FF3898</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The configurations of connection draining.</para>
        /// <para>After connection draining is enabled, SLB remains data transmission for a period of time after a backend server is removed or declared unhealthy.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Basic SLB instances do not support connection draining. Standard and WAF-enabled SLB instances support connection draining.</description></item>
        /// <item><description>Server groups of the server and IP types support connection draining. Server groups of the Function Compute type do not support connection draining.</description></item>
        /// </list>
        /// </remarks>
        /// </summary>
        [NameInMap("ConnectionDrainConfig")]
        [Validation(Required=false)]
        public UpdateServerGroupAttributeRequestConnectionDrainConfig ConnectionDrainConfig { get; set; }
        public class UpdateServerGroupAttributeRequestConnectionDrainConfig : TeaModel {
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
            /// <para>The timeout period of connection draining.</para>
            /// <para>Valid values: <b>0</b> to <b>900</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("ConnectionDrainTimeout")]
            [Validation(Required=false)]
            public int? ConnectionDrainTimeout { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether cross-zone load balancing is enabled for the server group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b> (default)</description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Basic ALB instances do not support server groups that have cross-zone load balancing disabled. Only Standard and WAF-enabled ALB instances support server groups that have cross-zone load balancing.</description></item>
        /// <item><description>Cross-zone load balancing can be disabled for server groups of the server and IP type, but not for server groups of the Function Compute type.</description></item>
        /// <item><description>When cross-zone load balancing is disabled, session persistence cannot be enabled.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("CrossZoneEnabled")]
        [Validation(Required=false)]
        public bool? CrossZoneEnabled { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run, without performing the actual request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: checks the request without performing the operation. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and service limits. If the request fails the dry run, an error code is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): performs a dry run and performs the actual request. If the request passes the dry run, a <c>2xx</c> HTTP status code is returned and the operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The configuration of health checks.</para>
        /// </summary>
        [NameInMap("HealthCheckConfig")]
        [Validation(Required=false)]
        public UpdateServerGroupAttributeRequestHealthCheckConfig HealthCheckConfig { get; set; }
        public class UpdateServerGroupAttributeRequestHealthCheckConfig : TeaModel {
            /// <summary>
            /// <para>The HTTP status codes that indicate healthy backend servers.</para>
            /// </summary>
            [NameInMap("HealthCheckCodes")]
            [Validation(Required=false)]
            public List<string> HealthCheckCodes { get; set; }

            /// <summary>
            /// <para>The backend port that is used for health checks.</para>
            /// <para>Valid values: <b>0</b> to <b>65535</b>.</para>
            /// <para>If you set the value to <b>0</b>, the backend port is used for health checks.</para>
            /// <remarks>
            /// <para> This parameter takes effect only if you set <b>HealthCheckEnabled</b> to <b>true</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("HealthCheckConnectPort")]
            [Validation(Required=false)]
            public int? HealthCheckConnectPort { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the health check feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HealthCheckEnabled")]
            [Validation(Required=false)]
            public bool? HealthCheckEnabled { get; set; }

            /// <summary>
            /// <para>The domain name that is used for health checks.</para>
            /// <list type="bullet">
            /// <item><description><para><b>Backend Server Internal IP</b> (default): Use the internal IP address of backend servers as the health check domain name.</para>
            /// </description></item>
            /// <item><description><para><b>Custom Domain Name</b>: Enter a domain name.</para>
            /// <list type="bullet">
            /// <item><description>The domain name must be 1 to 80 characters in length.</description></item>
            /// <item><description>The domain name can contain lowercase letters, digits, hyphens (-), and periods (.).</description></item>
            /// <item><description>The domain name must contain at least one period (.) but cannot start or end with a period (.).</description></item>
            /// <item><description>The rightmost domain label of the domain name can contain only letters, and cannot contain digits or hyphens (-).</description></item>
            /// <item><description>The domain name cannot start or end with a hyphen (-).</description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para> This parameter takes effect only if <b>HealthCheckProtocol</b> is set to <b>HTTP</b>, <b>HTTPS</b>, or <b>gRPC</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("HealthCheckHost")]
            [Validation(Required=false)]
            public string HealthCheckHost { get; set; }

            /// <summary>
            /// <para>The HTTP version that is used for health checks. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>HTTP1.0</b></description></item>
            /// <item><description><b>HTTP1.1</b></description></item>
            /// </list>
            /// <remarks>
            /// <para> This parameter takes effect only if you set <b>HealthCheckEnabled</b> to true and <b>HealthCheckProtocol</b> to <b>HTTP</b> or <b>HTTPS</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP1.1</para>
            /// </summary>
            [NameInMap("HealthCheckHttpVersion")]
            [Validation(Required=false)]
            public string HealthCheckHttpVersion { get; set; }

            /// <summary>
            /// <para>The interval at which health checks are performed. Unit: seconds.</para>
            /// <para>Valid values: <b>1</b> to <b>50</b>.</para>
            /// <remarks>
            /// <para> This parameter takes effect only if you set <b>HealthCheckEnabled</b> to <b>true</b>.</para>
            /// </remarks>
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
            /// <item><description><b>GET</b>: If the length of a response exceeds 8 KB, the response is truncated. However, the health check result is not affected.</description></item>
            /// <item><description><b>POST</b>: gRPC health checks use the POST method by default.</description></item>
            /// <item><description><b>HEAD</b>: HTTP and HTTPS health checks use the HEAD method by default.</description></item>
            /// </list>
            /// <remarks>
            /// <para> This parameter takes effect only if you set <b>HealthCheckEnabled</b> to true and <b>HealthCheckProtocol</b> to <b>HTTP</b>, <b>HTTPS</b>, or <b>gRPC</b>.</para>
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
            /// <para>The URL must be 1 to 80 characters in length, and can contain letters, digits, and the following special characters: <c>- / . % ? # &amp; =</c>. It can also contain the following extended characters: <c>_ ; ~ ! ( ) * [ ] @ $ ^ : \\&quot; , +</c>. The URL must start with a forward slash (<c>/</c>).</para>
            /// <remarks>
            /// <para> This parameter takes effect only if you set <b>HealthCheckEnabled</b> to <b>true</b> and <b>HealthCheckProtocol</b> to <b>HTTP</b> or <b>HTTPS</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>/test/index.html</para>
            /// </summary>
            [NameInMap("HealthCheckPath")]
            [Validation(Required=false)]
            public string HealthCheckPath { get; set; }

            /// <summary>
            /// <para>The protocol that you want to use for health checks. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>HTTP</b>: HTTP health checks simulate browser behaviors by sending HEAD or GET requests to probe the availability of backend servers.</description></item>
            /// <item><description><b>HTTPS</b>: HTTPS health checks simulate browser behaviors by sending HEAD or GET requests to probe the availability of backend servers. HTTPS supports encryption and provides higher security than HTTP.</description></item>
            /// <item><description><b>TCP</b>: TCP health checks send TCP SYN packets to a backend server to probe the availability of backend servers.</description></item>
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
            /// <para>The timeout period of a health check response. If a backend ECS instance does not respond within the specified timeout period, the ECS instance fails the health check. Unit: seconds.</para>
            /// <para>Valid values: <b>1</b> to <b>300</b>.</para>
            /// <remarks>
            /// <para> This parameter takes effect only if you set <b>HealthCheckEnabled</b> to <b>true</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("HealthCheckTimeout")]
            [Validation(Required=false)]
            public int? HealthCheckTimeout { get; set; }

            /// <summary>
            /// <para>The number of times that an unhealthy backend server must consecutively pass health checks before it can be declared healthy. In this case, the health check status of the backend server changes from <b>fail</b> to <b>success</b>.</para>
            /// <para>Valid values: <b>2</b> to <b>10</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("HealthyThreshold")]
            [Validation(Required=false)]
            public int? HealthyThreshold { get; set; }

            /// <summary>
            /// <para>The number of times that a healthy backend server must consecutively fail health checks before it can be declared unhealthy. In this case, the health check status of the backend server changes from <b>success</b> to <b>fail</b>.</para>
            /// <para>Valid values: <b>2</b> to <b>10</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("UnhealthyThreshold")]
            [Validation(Required=false)]
            public int? UnhealthyThreshold { get; set; }

        }

        /// <summary>
        /// <para>The scheduling algorithm. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Wrr</b>: the weighted round robin algorithm. Backend servers that have higher weights receive more requests than those that have lower weights.</description></item>
        /// <item><description><b>Wlc</b>: the weighted least connections algorithm. Requests are distributed based on the weights and the number of connections to backend servers. If two backend servers have the same weight, the backend server that has fewer connections is expected to receive more requests.</description></item>
        /// <item><description><b>Sch</b>: the consistent hashing algorithm. Requests from the same source IP address are distributed to the same backend server.</description></item>
        /// </list>
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
        /// <para>sgp-atstuj3rtop****</para>
        /// </summary>
        [NameInMap("ServerGroupId")]
        [Validation(Required=false)]
        public string ServerGroupId { get; set; }

        /// <summary>
        /// <para>The server group name.</para>
        /// <para>The name must be 2 to 128 characters in length and can contain letters, digits, periods (.), underscores (_), and hyphens (-). The name must start with a letter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ServerGroupName")]
        [Validation(Required=false)]
        public string ServerGroupName { get; set; }

        /// <summary>
        /// <para>This parameter is available only if the ALB Ingress controller is used. In this case, set this parameter to the name of the <c>Kubernetes Service</c> that is associated with the server group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test2</para>
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// <para>The configurations of slow starts.</para>
        /// <para>After slow starts are enabled, ALB prefetches data to newly added backend servers. Requests distributed to the backend servers gradually increase.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Basic ALB instances do not support slow starts. Standard and WAF-enabled ALB instances support slow starts.</description></item>
        /// <item><description>Server groups of the instance and IP types support slow starts. Server groups of the Function Compute type do not support slow starts.</description></item>
        /// <item><description>Slow start is supported only by the weighted round-robin scheduling algorithm.</description></item>
        /// </list>
        /// </remarks>
        /// </summary>
        [NameInMap("SlowStartConfig")]
        [Validation(Required=false)]
        public UpdateServerGroupAttributeRequestSlowStartConfig SlowStartConfig { get; set; }
        public class UpdateServerGroupAttributeRequestSlowStartConfig : TeaModel {
            /// <summary>
            /// <para>The duration of a slow start.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("SlowStartDuration")]
            [Validation(Required=false)]
            public int? SlowStartDuration { get; set; }

            /// <summary>
            /// <para>Indicates whether slow starts are enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SlowStartEnabled")]
            [Validation(Required=false)]
            public bool? SlowStartEnabled { get; set; }

        }

        /// <summary>
        /// <para>The configuration of session persistence.</para>
        /// </summary>
        [NameInMap("StickySessionConfig")]
        [Validation(Required=false)]
        public UpdateServerGroupAttributeRequestStickySessionConfig StickySessionConfig { get; set; }
        public class UpdateServerGroupAttributeRequestStickySessionConfig : TeaModel {
            /// <summary>
            /// <para>The cookie to be configured on the server.</para>
            /// <para>The cookie must be 1 to 200 characters in length and can contain only ASCII characters and digits. It cannot contain commas (,), semicolons (;), or space characters. It cannot start with a dollar sign ($).</para>
            /// <remarks>
            /// <para>This parameter takes effect when the <b>StickySessionEnabled</b> parameter is set to <b>true</b> and the <b>StickySessionType</b> parameter is set to <b>Server</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>B490B5EBF6F3CD402E515D22BCDA1598</para>
            /// </summary>
            [NameInMap("Cookie")]
            [Validation(Required=false)]
            public string Cookie { get; set; }

            /// <summary>
            /// <para>The timeout period of a cookie. Unit: seconds.</para>
            /// <para>Valid values: <b>1</b> to <b>86400</b>.</para>
            /// <remarks>
            /// <para>This parameter takes effect when the <b>StickySessionEnabled</b> parameter is set to <b>true</b> and the <b>StickySessionType</b> parameter is set to <b>Insert</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("CookieTimeout")]
            [Validation(Required=false)]
            public int? CookieTimeout { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable session persistence. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b> (default)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("StickySessionEnabled")]
            [Validation(Required=false)]
            public bool? StickySessionEnabled { get; set; }

            /// <summary>
            /// <para>The method that is used to handle a cookie. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Insert</b>: inserts a cookie.</description></item>
            /// </list>
            /// <para>ALB inserts a cookie (SERVERID) into the first HTTP or HTTPS response packet that is sent to a client. The next request from the client contains this cookie and the listener forwards this request to the recorded backend server.</para>
            /// <list type="bullet">
            /// <item><description><b>Server</b>: rewrites a cookie.</description></item>
            /// </list>
            /// <para>When ALB detects a user-defined cookie, it overwrites the original cookie with the user-defined cookie. Subsequent requests to ALB carry this user-defined cookie, and ALB determines the destination servers of the requests based on the cookies.</para>
            /// <remarks>
            /// <para>This parameter takes effect when the <b>StickySessionEnabled</b> parameter is set to <b>true</b> for the server group.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Insert</para>
            /// </summary>
            [NameInMap("StickySessionType")]
            [Validation(Required=false)]
            public string StickySessionType { get; set; }

        }

        /// <summary>
        /// <para>The configurations of consistent hashing based on URLs.</para>
        /// </summary>
        [NameInMap("UchConfig")]
        [Validation(Required=false)]
        public UpdateServerGroupAttributeRequestUchConfig UchConfig { get; set; }
        public class UpdateServerGroupAttributeRequestUchConfig : TeaModel {
            /// <summary>
            /// <para>The type of the parameter. Only query strings are supported.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>QueryString</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The value of the parameter used for consistent hashing.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>abc</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to enable persistent TCP connections.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("UpstreamKeepaliveEnabled")]
        [Validation(Required=false)]
        public bool? UpstreamKeepaliveEnabled { get; set; }

    }

}
