// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class CreateServerGroupRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the system automatically uses the <b>request ID</b> as the <b>client token</b>. The <b>request ID</b> may be different for each request.</para>
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
        /// <para>After connection draining is enabled, ALB maintains data transmission for a period of time after the backend server is removed or declared unhealthy.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Basic ALB instances do not support connection draining. Standard and WAF-enabled ALB instances support connection draining.</description></item>
        /// <item><description>Server groups of the instance and IP types support connection draining. Server groups of the Function Compute type do not support connection draining.</description></item>
        /// </list>
        /// </remarks>
        /// </summary>
        [NameInMap("ConnectionDrainConfig")]
        [Validation(Required=false)]
        public CreateServerGroupRequestConnectionDrainConfig ConnectionDrainConfig { get; set; }
        public class CreateServerGroupRequestConnectionDrainConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable connection draining. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b> (default)</description></item>
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
            /// <para>Default value: <b>300</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>300</para>
            /// </summary>
            [NameInMap("ConnectionDrainTimeout")]
            [Validation(Required=false)]
            public int? ConnectionDrainTimeout { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to enable cross-zone load balancing. Valid values:</para>
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
        /// <item><description><b>true</b>: performs only a dry run. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and service limits. If the request fails the dry run, an error code is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): performs a dry run and performs the actual request. If the request passes the dry run, a 2xx HTTP status code is returned and the operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The configuration of the health check feature.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("HealthCheckConfig")]
        [Validation(Required=false)]
        public CreateServerGroupRequestHealthCheckConfig HealthCheckConfig { get; set; }
        public class CreateServerGroupRequestHealthCheckConfig : TeaModel {
            /// <summary>
            /// <para>The HTTP status code that indicates healthy backend servers.</para>
            /// </summary>
            [NameInMap("HealthCheckCodes")]
            [Validation(Required=false)]
            public List<string> HealthCheckCodes { get; set; }

            /// <summary>
            /// <para>The backend port that is used for health checks.</para>
            /// <para>Valid values: <b>0</b> to <b>65535</b></para>
            /// <para>The default value is <b>0</b>, which specifies that the port of a backend server is used for health checks.</para>
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
            /// <remarks>
            /// <para> If the <b>ServerGroupType</b> parameter is set to <b>Instance</b> or <b>Ip</b>, the health check feature is enabled by default. If the <b>ServerGroupType</b> parameter is set to <b>Fc</b>, the health check feature is disabled by default.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
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
            /// <para><a href="http://www.example.com">www.example.com</a></para>
            /// </summary>
            [NameInMap("HealthCheckHost")]
            [Validation(Required=false)]
            public string HealthCheckHost { get; set; }

            /// <summary>
            /// <para>The version of the HTTP protocol. Valid values: <b>HTTP1.0</b> and <b>HTTP1.1</b>. Default value: HTTP1.1.</para>
            /// <remarks>
            /// <para> This parameter takes effect only if <b>HealthCheckProtocol</b> is set to <b>HTTP</b> or <b>HTTPS</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP1.1</para>
            /// </summary>
            [NameInMap("HealthCheckHttpVersion")]
            [Validation(Required=false)]
            public string HealthCheckHttpVersion { get; set; }

            /// <summary>
            /// <para>The interval at which health checks are performed. Unit: seconds</para>
            /// <para>Valid values: <b>1</b> to <b>50</b></para>
            /// <para>Default value: <b>2</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("HealthCheckInterval")]
            [Validation(Required=false)]
            public int? HealthCheckInterval { get; set; }

            /// <summary>
            /// <para>The HTTP method that is used for health checks. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>GET</b>: If the length of a response exceeds 8 KB, the response is truncated. However, the health check result is not affected.</description></item>
            /// <item><description><b>POST</b>: By default, gRPC health checks use the POST method.</description></item>
            /// <item><description><b>HEAD</b> (default): By default, HTTP and HTTPS use the HEAD method.</description></item>
            /// </list>
            /// <remarks>
            /// <para> This parameter takes effect only if <b>HealthCheckProtocol</b> is set to <b>HTTP</b>, <b>HTTPS</b>, or <b>gRPC</b>.</para>
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
            /// <para>The URL must be 1 to 80 characters in length, and can contain letters, digits, and the following special characters: <c>- / . % ? # &amp; =</c>. It can also contain the following extended characters: <c>_ ; ~ ! ( ) * [ ] @ $ ^ : \\&quot; , +</c>. The URL must start with a forward slash (/).</para>
            /// <remarks>
            /// <para> This parameter takes effect only if <b>HealthCheckProtocol</b> is set to <b>HTTP</b> or <b>HTTPS</b>.</para>
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
            /// <item><description><b>HTTP</b>: HTTP health checks simulate browser behaviors by sending HEAD or GET requests to probe the availability of backend servers.</description></item>
            /// <item><description><b>HTTPS</b>: HTTPS health checks simulate browser behaviors by sending HEAD or GET requests to probe the availability of backend servers. HTTPS provides higher security than HTTP because HTTPS supports data encryption.</description></item>
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
            /// <para>The timeout period of a health check response. If a backend server does not respond within the specified timeout period, the backend server is declared unhealthy. Unit: seconds</para>
            /// <para>Valid values: <b>1</b> to <b>300</b></para>
            /// <para>Default value: <b>5</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("HealthCheckTimeout")]
            [Validation(Required=false)]
            public int? HealthCheckTimeout { get; set; }

            /// <summary>
            /// <para>The number of times that an unhealthy backend server must consecutively pass health checks before it is declared healthy. In this case, the health check status of the backend server changes from <b>fail</b> to <b>success</b>.</para>
            /// <para>Valid values: <b>2</b> to <b>10</b></para>
            /// <para>Default value: <b>3</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("HealthyThreshold")]
            [Validation(Required=false)]
            public int? HealthyThreshold { get; set; }

            /// <summary>
            /// <para>The number of times that a healthy backend server must consecutively fail health checks before it is declared unhealthy. In this case, the health check status of the backend server changes from <b>success</b> to <b>fail</b>.</para>
            /// <para>Valid values: <b>2</b> to <b>10</b></para>
            /// <para>Default value: <b>3</b></para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("UnhealthyThreshold")]
            [Validation(Required=false)]
            public int? UnhealthyThreshold { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to enable Ipv6.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Ipv6Enabled")]
        [Validation(Required=false)]
        public bool? Ipv6Enabled { get; set; }

        /// <summary>
        /// <para>The backend protocol. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>HTTP</b>: allows you to associate an HTTPS, HTTP, or QUIC listener with the server group. This is the default value.</description></item>
        /// <item><description><b>HTTPS</b>: allows you to associate HTTPS listeners with backend servers.</description></item>
        /// <item><description><b>gRPC</b>: allows you to associate an HTTPS or QUIC listener with the server group.</description></item>
        /// </list>
        /// <remarks>
        /// <para> You do not need to specify a backend protocol if you set <b>ServerGroupType</b> to <b>Fc</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP</para>
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

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
        /// <para>The scheduling algorithm. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Wrr</b> (default): The weighted round-robin algorithm is used. Backend servers that have higher weights receive more requests than those that have lower weights.</description></item>
        /// <item><description><b>Wlc</b>: The weighted least connections algorithm is used. Requests are distributed based on the weights and the number of connections to backend servers. If two backend servers have the same weight, the backend server that has fewer connections is expected to receive more requests.</description></item>
        /// <item><description><b>Sch</b>: The consistent hashing algorithm is used. Requests from the same source IP address are distributed to the same backend server.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter takes effect when the <b>ServerGroupType</b> parameter is set to <b>Instance</b> or <b>Ip</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Wrr</para>
        /// </summary>
        [NameInMap("Scheduler")]
        [Validation(Required=false)]
        public string Scheduler { get; set; }

        /// <summary>
        /// <para>The name of the server group. The name must be 2 to 128 characters in length, and can contain letters, digits, periods (.), underscores (_), and hyphens (-). The name must start with a letter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-atstuj3rtoptyui****</para>
        /// </summary>
        [NameInMap("ServerGroupName")]
        [Validation(Required=false)]
        public string ServerGroupName { get; set; }

        /// <summary>
        /// <para>The type of server group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Instance</b> (default): allows you to add servers by specifying <b>Ecs</b>, <b>Eni</b>, or <b>Eci</b>.</description></item>
        /// <item><description><b>Ip</b>: allows you to add servers by specifying IP addresses.</description></item>
        /// <item><description><b>Fc</b>: allows you to add servers by specifying functions of Function Compute.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Instance</para>
        /// </summary>
        [NameInMap("ServerGroupType")]
        [Validation(Required=false)]
        public string ServerGroupType { get; set; }

        /// <summary>
        /// <para>This parameter is available only if the ALB Ingress controller is used. In this case, set this parameter to the name of the <c>Kubernetes Service</c> that is associated with the server group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// <para>The configurations of slow starts.
        /// After slow starts are enabled, SLB prefetches data to newly added backend servers. Requests distributed to the backend servers gradually increase.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Basic SLB instances do not support slow starts. Standard and WAF-enabled SLB instances support slow starts.</description></item>
        /// </list>
        /// <list type="bullet">
        /// <item><description>Server groups of the server and IP types support slow starts. Server groups of the Function Compute type do not support slow starts.</description></item>
        /// <item><description>Slow start is supported only by the weighted round-robin scheduling algorithm.</description></item>
        /// </list>
        /// </remarks>
        /// </summary>
        [NameInMap("SlowStartConfig")]
        [Validation(Required=false)]
        public CreateServerGroupRequestSlowStartConfig SlowStartConfig { get; set; }
        public class CreateServerGroupRequestSlowStartConfig : TeaModel {
            /// <summary>
            /// <para>The duration of a slow start.
            /// Valid values: 30 to 900.
            /// Default value: 30.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("SlowStartDuration")]
            [Validation(Required=false)]
            public int? SlowStartDuration { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable slow starts. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>true</para>
            /// </description></item>
            /// <item><description><para>false(default)</para>
            /// </description></item>
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
        /// <remarks>
        /// <para> This parameter takes effect when the <b>ServerGroupType</b> parameter is set to <b>Instance</b> or <b>Ip</b>.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("StickySessionConfig")]
        [Validation(Required=false)]
        public CreateServerGroupRequestStickySessionConfig StickySessionConfig { get; set; }
        public class CreateServerGroupRequestStickySessionConfig : TeaModel {
            /// <summary>
            /// <para>The cookie that you want to configure for the server.</para>
            /// <para>The cookie must be 1 to 200 characters in length, and can contain only ASCII letters and digits. It cannot contain commas (,), semicolons (;), or space characters. It cannot start with a dollar sign ($).</para>
            /// <remarks>
            /// <para> This parameter takes effect only when <b>StickySessionEnabled</b> is set to <b>true</b> and <b>StickySessionType</b> is set to <b>server</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>B490B5EBF6F3CD402E515D22BCDA****</para>
            /// </summary>
            [NameInMap("Cookie")]
            [Validation(Required=false)]
            public string Cookie { get; set; }

            /// <summary>
            /// <para>The maximum amount of time to wait before the session cookie expires. Unit: seconds</para>
            /// <para>Valid values: <b>1</b> to <b>86400</b></para>
            /// <para>Default value: <b>1000</b></para>
            /// <remarks>
            /// <para> This parameter takes effect only when <b>StickySessionEnabled</b> is set to <b>true</b> and <b>StickySessionType</b> is set to <b>Insert</b>.</para>
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
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// <remarks>
            /// <para> This parameter takes effect when the <b>ServerGroupType</b> parameter is set to <b>Instance</b> or <b>Ip</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("StickySessionEnabled")]
            [Validation(Required=false)]
            public bool? StickySessionEnabled { get; set; }

            /// <summary>
            /// <para>The method that is used to handle cookies. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Insert</b> (default value): inserts a cookie. The first time a client accesses ALB, ALB inserts the SERVERID cookie into the HTTP or HTTPS response packet. Subsequent requests from the client that carry this cookie are forwarded to the same backend server as the first request.</description></item>
            /// <item><description><b>Server</b>: rewrites a cookie. ALB rewrites the custom cookies in requests from a client. Subsequent requests from the client that carry the new cookie are forwarded to the same backend server as the first request.</description></item>
            /// </list>
            /// <remarks>
            /// <para> This parameter takes effect when the <b>StickySessionEnabled</b> parameter is set to <b>true</b>.</para>
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
        /// <para>The tag.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateServerGroupRequestTag> Tag { get; set; }
        public class CreateServerGroupRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. The tag key can be up to 128 characters in length, and cannot start with <c>acs:</c> or <c>aliyun</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>env</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. The tag value can be up to 128 characters in length, and cannot start with <c>acs:</c> or <c>aliyun</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>product</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The configuration of consistent hashing based on URLs.</para>
        /// </summary>
        [NameInMap("UchConfig")]
        [Validation(Required=false)]
        public CreateServerGroupRequestUchConfig UchConfig { get; set; }
        public class CreateServerGroupRequestUchConfig : TeaModel {
            /// <summary>
            /// <para>The type of the parameter.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>QueryString</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The parameter value for consistent hashing.</para>
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
        /// <para>false</para>
        /// </summary>
        [NameInMap("UpstreamKeepaliveEnabled")]
        [Validation(Required=false)]
        public bool? UpstreamKeepaliveEnabled { get; set; }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC). You can add only servers that are deployed in the specified VPC to the server group.</para>
        /// <remarks>
        /// <para> This parameter takes effect when the <b>ServerGroupType</b> parameter is set to <b>Instance</b> or <b>Ip</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp15zckdt37pq72zv****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
