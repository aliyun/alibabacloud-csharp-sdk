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
        /// <para>You can use the client to generate the value, but you must ensure that it is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> of each API request may be different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CAF0E-5718-45B5-9D4D-70B******</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The graceful connection break configuration.</para>
        /// <para>After graceful connection break is enabled, load balancing allows existing connections to be transmitted normally within a specified period of time after a backend server is removed or a health check failed.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Basic Edition instances do not support graceful connection break. Only Standard Edition and WAF-enhanced Edition instances support this feature.</description></item>
        /// <item><description>Server type and IP type server groups support graceful connection break. Function Compute type server groups do not support this feature.</description></item>
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
            /// <item><description><b>true</b>: enables connection draining.</description></item>
            /// <item><description><b>false</b>: disables connection draining (default).</description></item>
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
        /// <item><description><para><b>true</b>: enables cross-zone load balancing (default).</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: disables cross-zone load balancing.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Basic Edition instances do not support associating with server groups that have cross-zone load balancing disabled. Only Standard Edition and WAF-enhanced Edition instances support this feature.</description></item>
        /// <item><description>Server type and IP type server groups support disabling cross-zone load balancing. Function Compute type server groups do not support this feature.</description></item>
        /// <item><description>Session persistence cannot be enabled when cross-zone load balancing is disabled.</description></item>
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
        /// <para>Specifies whether to only precheck the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: prechecks the request without creating the server group. The system checks whether the required parameters are specified, the request format, and the service limits. If the request fails the precheck, the corresponding error is returned. If the request passes the precheck, the DryRunOperation error code is returned.</description></item>
        /// <item><description><b>false</b> (default): sends the normal request. After the request passes the precheck, an HTTP 2xx status code is returned and the operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The health check configuration.</para>
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
            /// <para>The list of status codes that indicate a successful health check.</para>
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
            /// <item><description><para><b>true</b>: enables health checks.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: disables health checks.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>By default, health checks are enabled when <b>ServerGroupType</b> is set to <b>Instance</b> or <b>Ip</b>, and disabled when <b>ServerGroupType</b> is set to <b>Fc</b>.</para>
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
            /// <para>The domain name used for health checks. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Internal IP address of the backend server</b> (default): uses the internal IP address of the backend server as the domain name for health checks.</para>
            /// </description></item>
            /// <item><description><para><b>Custom domain name</b>: specifies a domain name.</para>
            /// <list type="bullet">
            /// <item><description><para>The domain name must be 1 to 80 characters in length.</para>
            /// </description></item>
            /// <item><description><para>It can contain lowercase letters, digits, hyphens (-), and periods (.).</para>
            /// </description></item>
            /// <item><description><para>It must contain at least one period (.), and the period (.) cannot be at the beginning or end.</para>
            /// </description></item>
            /// <item><description><para>The rightmost domain label can contain only letters, and cannot contain digits or hyphens (-).</para>
            /// </description></item>
            /// <item><description><para>The hyphen (-) cannot be at the beginning or end.</para>
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
            /// <para>The HTTP version used for health checks. Valid values: <b>HTTP1.0</b> and <b>HTTP1.1</b> (default).</para>
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
            /// <para>The HTTP method used for health checks. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>GET</b>: if the length of the response message exceeds 8 KB, it is truncated, but this does not affect the health check result.</para>
            /// </description></item>
            /// <item><description><para><b>POST</b>: the default method for gRPC listener health checks.</para>
            /// </description></item>
            /// <item><description><para><b>HEAD</b> (default): the default method for HTTP and HTTPS listener health checks.</para>
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
            /// <para>The path used for health checks.</para>
            /// <para>The path must be 1 to 80 characters in length, and can contain only letters, digits, and the following special characters: <c>-/.%?#&amp;=</c> and extended characters <c>_;~!()*[]@$^:\&quot;,+</c>. The URL must start with a forward slash (/).</para>
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
            /// <para>The protocol used for health checks. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>HTTP</b>: sends HEAD or GET requests to perform impersonation of browser access and check whether the server application is healthy.</para>
            /// </description></item>
            /// <item><description><para><b>HTTPS</b>: sends HEAD or GET requests to perform impersonation of browser access and check whether the server application is healthy (data encryption, which makes it more secure than HTTP).</para>
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
            /// <para>The timeout period for a health check response. If the backend server does not respond within the specified timeout period, the health check fails. Unit: seconds.</para>
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
            /// <para>The number of consecutive successful health checks required to change the health check status of a backend server from <b>Failed</b> to <b>Successful</b>.</para>
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
            /// <para>The number of consecutive failed health checks required to change the health check status of a backend server from <b>Successful</b> to <b>Failed</b>.</para>
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
        /// <para>The IP version affinity mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NonAffinity: non-affinity mode. This is the default value.</description></item>
        /// <item><description>Affinity: affinity mode.</description></item>
        /// </list>
        /// <para>This parameter takes effect only when Ipv6Enabled is set to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Affinity</para>
        /// </summary>
        [NameInMap("IpVersionAffinityMode")]
        [Validation(Required=false)]
        public string IpVersionAffinityMode { get; set; }

        /// <summary>
        /// <para>Specifies whether the IP protocol version used by load balancing to forward traffic to the backend server group supports IPv6. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b> (default): IPv6 is not supported. The IPv4 type supports adding only IPv4 backend servers.</description></item>
        /// <item><description><b>true</b>: the dual-stack type is used. Both IPv4 and IPv6 backend servers can be added.</description></item>
        /// </list>
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
        /// <item><description><para><b>HTTP</b> (default): supports associating with HTTPS, HTTP, and QUIC listeners.</para>
        /// </description></item>
        /// <item><description><para><b>HTTPS</b>: supports associating with HTTP and HTTPS listeners.</para>
        /// </description></item>
        /// <item><description><para><b>gRPC</b>: associates with HTTPS listeners.</para>
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
        /// <para>The ID of the resource group.</para>
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
        /// <item><description><para><b>Wrr</b> (default): weighted round-robin. Backend servers with higher weights are more likely to be polled.</para>
        /// </description></item>
        /// <item><description><para><b>Wlc</b>: weighted least connections. In addition to polling based on the weight of each backend server, this algorithm also considers the actual load (number of connections) of the backend servers. When the weights are the same, backend servers with fewer current connections are more likely to be polled.</para>
        /// </description></item>
        /// <item><description><para><b>Sch</b>: consistent hashing. Requests with the same hash factor calculation result are scheduled to the same backend server. If the <b>UchConfig</b> parameter is not configured, the default hash factor is the source IP address, and requests from the same source IP address are distributed to the same backend server. If the <b>UchConfig</b> parameter is configured, the hash factor is the URL parameter, and requests with the same URL parameter are distributed to the same backend server.</para>
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
        /// <para>The name of the server group. The name must be 2 to 128 characters in length, and must start with a letter, Chinese character, or digit. It can contain digits, periods (.), underscores (_), hyphens (-), and spaces.</para>
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
        /// <item><description><para><b>Fc</b>: Function Compute type. This type of server group supports adding Function Compute backend servers.</para>
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
        /// <para>The name of the <c>K8s Service</c> that corresponds to the server group. This parameter is applicable only to ALB Ingress scenarios.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// <para>The slow start configuration.</para>
        /// <para>After slow start is enabled, newly added backend servers in the server group are warmed up within the specified time period, and the number of requests forwarded to the servers increases linearly.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Basic Edition instances do not support slow start. Only Standard Edition and WAF-enhanced Edition instances support this feature.</description></item>
        /// <item><description>Server type and IP backend server groups support slow start. Function Compute backend server groups do not support this feature.</description></item>
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
            /// <para>Specifies whether to enable slow start. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: enables slow start.</description></item>
            /// <item><description><b>false</b>: disables slow start (default).</description></item>
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
            /// <para>The cookie must be 1 to 200 characters in length, and can contain only ASCII letters and digits. It cannot contain commas (,), semicolons (;), or spaces, and cannot start with a dollar sign ($).</para>
            /// <remarks>
            /// <para>This parameter takes effect only when <b>StickySessionEnabled</b> is set to <b>true</b> and <b>StickySessionType</b> is set to <b>server</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>B490B6EBF6F3CD402E515D22BCDA****</para>
            /// </summary>
            [NameInMap("Cookie")]
            [Validation(Required=false)]
            public string Cookie { get; set; }

            /// <summary>
            /// <para>The timeout period of the cookie. Unit: seconds.</para>
            /// <para>Valid values: <b>1</b> to <b>86400</b>.</para>
            /// <para>Default value: <b>1000</b>.</para>
            /// <remarks>
            /// <para>This parameter takes effect only when <b>StickySessionEnabled</b> is set to <b>true</b> and <b>StickySessionType</b> is set to <b>Insert</b>.</para>
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
            /// <item><description><b>true</b>: enables session persistence.</description></item>
            /// <item><description><b>false</b>: disables session persistence.</description></item>
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
            /// <item><description><para><b>Insert</b> (default): inserts a cookie.
            /// When a client accesses the server for the first time, load balancing inserts a cookie (that is, inserts SERVERID into the HTTP or HTTPS response message). The next time the client accesses the server with this cookie, load balancing forwards the request to the previously recorded backend server.</para>
            /// </description></item>
            /// <item><description><para><b>Server</b>: rewrites a cookie.
            /// When load balancing detects a user-defined cookie, it rewrites the original cookie. The next time the client accesses the server with the new cookie, load balancing forwards the request to the previously recorded backend server.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter takes effect only when <b>StickySessionEnabled</b> is set to <b>true</b>.</para>
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
            /// <para>The tag key. The key can be up to 128 characters in length, and cannot start with <c>aliyun</c> or <c>acs:</c>, or contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>env</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. The value can be up to 128 characters in length, and cannot start with <c>aliyun</c> or <c>acs:</c>, or contain <c>http://</c> or <c>https://</c>.</para>
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
        /// <para>Specifies whether to enable backend keep-alive. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables backend keep-alive.</description></item>
        /// <item><description><b>false</b> (default): disables backend keep-alive.</description></item>
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
