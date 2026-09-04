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
        /// <para>Generate a parameter value from your client to ensure that the value is unique among different requests. ClientToken supports only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> may vary for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CAF0E-5718-45B5-9D4D-70B******</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The connection draining configuration.</para>
        /// <para>After connection draining is enabled, when a backend server is removed or a health check failure occurs, the load balancing service allows existing connections to continue Normal data transmission for a specified period of time.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Basic Edition instances do not support connection draining. Only Standard Edition and WAF Enhanced Edition instances support this feature.</description></item>
        /// <item><description>Server type and IP type server groups support connection draining. Function Compute type server groups do not.</description></item>
        /// </list>
        /// </remarks>
        /// </summary>
        [NameInMap("ConnectionDrainConfig")]
        [Validation(Required=false)]
        public CreateServerGroupRequestConnectionDrainConfig ConnectionDrainConfig { get; set; }
        public class CreateServerGroupRequestConnectionDrainConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable connection draining.</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: enabled.</description></item>
            /// <item><description><b>false</b>: disabled (default).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("ConnectionDrainEnabled")]
            [Validation(Required=false)]
            public bool? ConnectionDrainEnabled { get; set; }

            /// <summary>
            /// <para>The connection draining timeout period.</para>
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
        /// <para>Specifies whether to enable cross-zone load balancing for the server group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: enabled (default).</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: disabled.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Basic Edition instances do not support binding server groups with cross-zone load balancing disabled. Only Standard Edition and WAF Enhanced Edition instances support this feature.</description></item>
        /// <item><description>Server type and IP type server groups support disabling cross-zone load balancing. Function Compute type server groups do not.</description></item>
        /// <item><description>Session persistence is not supported when cross-zone load balancing is disabled.</description></item>
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
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs a dry run without creating the server group. The system checks required parameters, request syntax, and business restrictions. If the check fails, the corresponding error is returned. If the check succeeds, the error code <c>DryRunOperation</c> is returned.</description></item>
        /// <item><description><b>false</b> (default): sends a normal request. After the check succeeds, an HTTP 2xx status code is returned and the operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The health check configurations.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-123</para>
        /// </summary>
        [NameInMap("HealthCheckConfig")]
        [Validation(Required=false)]
        public CreateServerGroupRequestHealthCheckConfig HealthCheckConfig { get; set; }
        public class CreateServerGroupRequestHealthCheckConfig : TeaModel {
            /// <summary>
            /// <para>The list of status codes that indicate a Normal health check status.</para>
            /// </summary>
            [NameInMap("HealthCheckCodes")]
            [Validation(Required=false)]
            public List<string> HealthCheckCodes { get; set; }

            /// <summary>
            /// <para>The port of the backend server used for health checks.</para>
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
            /// <para>Specifies whether to enable health checks. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: disabled.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>Health checks are enabled by default when <b>ServerGroupType</b> is set to <b>Instance</b> or <b>Ip</b>. Health checks are disabled by default when <b>ServerGroupType</b> is set to <b>Fc</b>.</para>
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
            /// <para>The domain name used for health checks.</para>
            /// <list type="bullet">
            /// <item><description><para><b>Use the internal IP address of the backend server</b> (default): uses the internal IP address of the backend server as the health check domain name.</para>
            /// </description></item>
            /// <item><description><para><b>Specify a specific domain name</b>: enter a domain name.</para>
            /// <list type="bullet">
            /// <item><description><para>The domain name must be 1 to 80 characters in length.</para>
            /// </description></item>
            /// <item><description><para>The domain name can contain lowercase letters, digits, hyphens (-), and periods (.).</para>
            /// </description></item>
            /// <item><description><para>The domain name must contain at least one period (.). Periods (.) cannot appear at the beginning or end.</para>
            /// </description></item>
            /// <item><description><para>The rightmost domain label can contain only letters, not digits or hyphens (-).</para>
            /// </description></item>
            /// <item><description><para>Hyphens (-) cannot appear at the beginning or end.</para>
            /// </description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter takes effect only when <b>HealthCheckProtocol</b> is set to <b>HTTP</b>, <b>HTTPS</b>, or <b>gRPC</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.example.com">www.example.com</a></para>
            /// </summary>
            [NameInMap("HealthCheckHost")]
            [Validation(Required=false)]
            public string HealthCheckHost { get; set; }

            /// <summary>
            /// <para>The HTTP version for health checks. Valid values: <b>HTTP1.0</b> and <b>HTTP1.1</b> (default).</para>
            /// <remarks>
            /// <para>This parameter takes effect only when <b>HealthCheckProtocol</b> is set to <b>HTTP</b> or <b>HTTPS</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP1.1</para>
            /// </summary>
            [NameInMap("HealthCheckHttpVersion")]
            [Validation(Required=false)]
            public string HealthCheckHttpVersion { get; set; }

            /// <summary>
            /// <para>The interval between two consecutive health checks. Unit: seconds.</para>
            /// <para>Valid values: <b>1</b> to <b>50</b>.</para>
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
            /// <item><description><para><b>GET</b>: If the response body exceeds 8 KB, it is truncated. However, this does not affect the health check result.</para>
            /// </description></item>
            /// <item><description><para><b>POST</b>: gRPC listener health checks use the POST method by default.</para>
            /// </description></item>
            /// <item><description><para><b>HEAD</b> (default): HTTP and HTTPS listener health checks use the HEAD method by default.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter takes effect only when <b>HealthCheckProtocol</b> is set to <b>HTTP</b>, <b>HTTPS</b>, or <b>gRPC</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>HEAD</para>
            /// </summary>
            [NameInMap("HealthCheckMethod")]
            [Validation(Required=false)]
            public string HealthCheckMethod { get; set; }

            /// <summary>
            /// <para>The forwarding rule path for health checks.</para>
            /// <para>The path must be 1 to 80 characters in length and can contain only letters, digits, and the characters <c>-/.%?#&amp;=</c> and the extended characters <c>_;~!（)*[]@$^:\\&quot;,+</c>. The URL must start with a forward slash (/).</para>
            /// <remarks>
            /// <para>This parameter takes effect only when <b>HealthCheckProtocol</b> is set to <b>HTTP</b> or <b>HTTPS</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>/test/index.html</para>
            /// </summary>
            [NameInMap("HealthCheckPath")]
            [Validation(Required=false)]
            public string HealthCheckPath { get; set; }

            /// <summary>
            /// <para>The health check protocol. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>HTTP</b>: uses impersonation of browser access behavior by sending HEAD or GET requests to check whether the server application is healthy.</para>
            /// </description></item>
            /// <item><description><para><b>HTTPS</b>: uses impersonation of browser access behavior by sending HEAD or GET requests to check whether the server application is healthy. Data encryption is used, which is more secure than HTTP.</para>
            /// </description></item>
            /// <item><description><para><b>TCP</b>: sends SYN handshake packets to check whether the server port is alive.</para>
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
            /// <para>The maximum period of time to wait for a response from a health check. If the backend server does not respond correctly within the specified period of time, the health check fails. Unit: seconds.</para>
            /// <para>Valid values: <b>1</b> to <b>300</b>.</para>
            /// <para>Default value: <b>5</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("HealthCheckTimeout")]
            [Validation(Required=false)]
            public int? HealthCheckTimeout { get; set; }

            /// <summary>
            /// <para>The number of consecutive successful health checks required before the health check status of a backend server changes from <b>fail</b> to <b>success</b>.</para>
            /// <para>Valid values: <b>2</b> to <b>10</b>.</para>
            /// <para>Default value: <b>3</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("HealthyThreshold")]
            [Validation(Required=false)]
            public int? HealthyThreshold { get; set; }

            /// <summary>
            /// <para>The number of consecutive failed health checks required before the health check status of a backend server changes from <b>success</b> to <b>fail</b>.</para>
            /// <para>Valid values: <b>2</b> to <b>10</b>.</para>
            /// <para>Default value: <b>3</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("UnhealthyThreshold")]
            [Validation(Required=false)]
            public int? UnhealthyThreshold { get; set; }

        }

        /// <summary>
        /// <para>The IP version affinity mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Affinity</para>
        /// </summary>
        [NameInMap("IpVersionAffinityMode")]
        [Validation(Required=false)]
        public string IpVersionAffinityMode { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable IPv6.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Ipv6Enabled")]
        [Validation(Required=false)]
        public bool? Ipv6Enabled { get; set; }

        /// <summary>
        /// <para>The backend protocol. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>HTTP</b> (default): can be associated with HTTPS, HTTP, and QUIC listeners.</para>
        /// </description></item>
        /// <item><description><para><b>HTTPS</b>: can be associated with HTTPS listeners.</para>
        /// </description></item>
        /// <item><description><para><b>gRPC</b>: can be associated with HTTPS and QUIC listeners.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>You do not need to configure the backend protocol when <b>ServerGroupType</b> is set to <b>Fc</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>HTTP</para>
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-atstuj3rsop****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The scheduling algorithm. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Wrr</b> (default): weighted round-robin. Backend servers with higher weights receive more requests.</para>
        /// </description></item>
        /// <item><description><para><b>Wlc</b>: weighted least connections. In addition to the weight assigned to each backend server, the actual load (number of connections) is also considered. When the weights are the same, backend servers with fewer current connections receive more requests.</para>
        /// </description></item>
        /// <item><description><para><b>Sch</b>: consistent hashing. Requests with the same hash factor are routed to the same backend server. If the <b>UchConfig</b> parameter is not configured, the default hash factor is the source IP address, and requests from the same source IP address are distributed to the same backend server. If the <b>UchConfig</b> parameter is configured, the hash factor is the URL parameter, and requests with the same URL parameter are distributed to the same backend server.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter takes effect only when <b>ServerGroupType</b> is set to <b>Instance</b> or <b>Ip</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Wrr</para>
        /// </summary>
        [NameInMap("Scheduler")]
        [Validation(Required=false)]
        public string Scheduler { get; set; }

        /// <summary>
        /// <para>The server group name. The name must be 2 to 128 characters in length, and must start with an uppercase letter, lowercase letter, Chinese character, or digit. The name can contain digits, periods (.), underscores (_), hyphens (-), and spaces.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ServerGroupName")]
        [Validation(Required=false)]
        public string ServerGroupName { get; set; }

        /// <summary>
        /// <para>The type of the server group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Instance</b> (default): server type. This type of server group supports adding <b>Ecs</b>, <b>Eni</b>, and <b>Eci</b> instances.</para>
        /// </description></item>
        /// <item><description><para><b>Ip</b>: IP address type. This type of server group supports adding backend servers by IP address.</para>
        /// </description></item>
        /// <item><description><para><b>Fc</b>: Function Compute type. This type supports adding Function Compute-based backend servers.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Instance</para>
        /// </summary>
        [NameInMap("ServerGroupType")]
        [Validation(Required=false)]
        public string ServerGroupType { get; set; }

        /// <summary>
        /// <para>This parameter is applicable only to ALB Ingress scenarios and specifies the <c>K8s Service</c> name that corresponds to the server group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// <para>The slow start configuration.</para>
        /// <para>After slow start is enabled, newly added backend servers are warmed up during a specified period of time. The number of requests forwarded to the server increases linearly.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Basic Edition instances do not support slow start. Only Standard Edition and WAF Enhanced Edition instances support this feature.</description></item>
        /// <item><description>Server type and IP backend server groups support slow start configuration. Function Compute backend server groups do not.</description></item>
        /// <item><description>Slow start can be enabled only when the backend scheduling algorithm is weighted round-robin.</description></item>
        /// </list>
        /// </remarks>
        /// </summary>
        [NameInMap("SlowStartConfig")]
        [Validation(Required=false)]
        public CreateServerGroupRequestSlowStartConfig SlowStartConfig { get; set; }
        public class CreateServerGroupRequestSlowStartConfig : TeaModel {
            /// <summary>
            /// <para>The slow start duration.</para>
            /// <para>Valid values: <b>30</b> to <b>900</b>.</para>
            /// <para>Default value: <b>30</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("SlowStartDuration")]
            [Validation(Required=false)]
            public int? SlowStartDuration { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable slow start.</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: enabled.</description></item>
            /// <item><description><b>false</b>: disabled (default).</description></item>
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
        /// <para>The session persistence configuration.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when <b>ServerGroupType</b> is set to <b>Instance</b> or <b>Ip</b>.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("StickySessionConfig")]
        [Validation(Required=false)]
        public CreateServerGroupRequestStickySessionConfig StickySessionConfig { get; set; }
        public class CreateServerGroupRequestStickySessionConfig : TeaModel {
            /// <summary>
            /// <para>The cookie configured on the server.</para>
            /// <para>The cookie must be 1 to 200 characters in length and can contain only ASCII letters and digits. It cannot contain commas (,), semicolons (;), or spaces, and cannot start with a dollar sign ($).</para>
            /// <remarks>
            /// <para>This parameter takes effect when <b>StickySessionEnabled</b> is set to <b>true</b> and <b>StickySessionType</b> is set to <b>server</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>B490B6EBF6F3CD402E515D22BCDA****</para>
            /// </summary>
            [NameInMap("Cookie")]
            [Validation(Required=false)]
            public string Cookie { get; set; }

            /// <summary>
            /// <para>The cookie timeout period. Unit: seconds.</para>
            /// <para>Valid values: <b>1</b> to <b>86400</b>.</para>
            /// <para>Default value: <b>1000</b>.</para>
            /// <remarks>
            /// <para>This parameter takes effect when <b>StickySessionEnabled</b> is set to <b>true</b> and <b>StickySessionType</b> is set to <b>Insert</b>.</para>
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
            /// <item><description><b>true</b>: enabled.</description></item>
            /// <item><description><b>false</b>: disabled.</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter takes effect only when <b>ServerGroupType</b> is set to <b>Instance</b> or <b>Ip</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("StickySessionEnabled")]
            [Validation(Required=false)]
            public bool? StickySessionEnabled { get; set; }

            /// <summary>
            /// <para>The method used to handle cookies. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Insert</b> (default): inserts a cookie. When a client first accesses the load balancer, the load balancer inserts a cookie (SERVERID) into the HTTP or HTTPS response. Subsequent requests that carry this cookie are forwarded to the previously recorded backend server.</para>
            /// </description></item>
            /// <item><description><para><b>Server</b>: rewrites a cookie. When the load balancing service detects a user-defined cookie, it rewrites the original cookie. Subsequent requests that carry the new cookie are forwarded to the previously recorded backend server.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter takes effect when <b>StickySessionEnabled</b> is set to <b>true</b>.</para>
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
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateServerGroupRequestTag> Tag { get; set; }
        public class CreateServerGroupRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. The tag key can be up to 128 characters in length, and cannot start with <c>aliyun</c> or <c>acs:</c>, or contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>env</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. The tag value can be up to 128 characters in length, and cannot start with <c>aliyun</c> or <c>acs:</c>, or contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>product</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The URL consistent hashing parameter settings.</para>
        /// </summary>
        [NameInMap("UchConfig")]
        [Validation(Required=false)]
        public CreateServerGroupRequestUchConfig UchConfig { get; set; }
        public class CreateServerGroupRequestUchConfig : TeaModel {
            /// <summary>
            /// <para>The parameter type. Set the value to <b>QueryString</b>.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>QueryString</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The consistent hashing parameter value.</para>
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
        /// <para>Specifies whether to enable upstream keepalive connections.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enabled.</description></item>
        /// <item><description><b>false</b> (default): disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("UpstreamKeepaliveEnabled")]
        [Validation(Required=false)]
        public bool? UpstreamKeepaliveEnabled { get; set; }

        /// <summary>
        /// <para>The VPC-connected instance ID. Only servers in this VPC can be added to the server group.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when <b>ServerGroupType</b> is set to <b>Instance</b> or <b>Ip</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp15zdkdt37pq72zv****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
