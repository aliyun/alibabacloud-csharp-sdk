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
        /// <para>If you do not specify this parameter, the system automatically uses the RequestId of the API request as the ClientToken. The RequestId may be different for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3******</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The connection draining configuration.</para>
        /// <para>After connection draining is enabled, when a backend server is removed or fails a health check, the load balancing service allows existing connections to continue transmitting data for a specified period of time without break.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Basic Edition instances do not support connection draining. Only Standard Edition and WAF Enhanced Edition instances support this feature.</description></item>
        /// <item><description>Server type and IP type server groups support connection draining. Function Compute type server groups do not support this feature.</description></item>
        /// </list>
        /// </remarks>
        /// </summary>
        [NameInMap("ConnectionDrainConfig")]
        [Validation(Required=false)]
        public UpdateServerGroupAttributeRequestConnectionDrainConfig ConnectionDrainConfig { get; set; }
        public class UpdateServerGroupAttributeRequestConnectionDrainConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable connection draining.</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: enabled.</description></item>
            /// <item><description><b>false</b>: disabled.</description></item>
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
        /// <item><description>Server type and IP type server groups support disabling cross-zone load balancing. Function Compute type server groups do not support this feature.</description></item>
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
        /// <item><description><b>true</b>: performs a dry run without modifying the resource. The system checks the required parameters, request syntax, and business restrictions. If the check fails, the corresponding error is returned. If the check succeeds, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): performs a dry run and sends the request. If the check succeeds, an HTTP <c>2xx</c> status code is returned and the operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The health check configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("HealthCheckConfig")]
        [Validation(Required=false)]
        public UpdateServerGroupAttributeRequestHealthCheckConfig HealthCheckConfig { get; set; }
        public class UpdateServerGroupAttributeRequestHealthCheckConfig : TeaModel {
            /// <summary>
            /// <para>The list of status codes that indicate healthy health checks.</para>
            /// </summary>
            [NameInMap("HealthCheckCodes")]
            [Validation(Required=false)]
            public List<string> HealthCheckCodes { get; set; }

            /// <summary>
            /// <para>The port of the backend server that is used for health checks.</para>
            /// <para>Valid values: <b>0</b> to <b>65535</b>.</para>
            /// <para>Settings this parameter to <b>0</b> indicates that the port of the backend server is used for health checks.</para>
            /// <remarks>
            /// <para>This parameter settings take effect only when <b>HealthCheckEnabled</b> is set to <b>true</b> for the server group.</para>
            /// </remarks>
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
            /// <item><description><b>true</b>: enabled.</description></item>
            /// <item><description><b>false</b>: disabled.</description></item>
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
            /// <item><description><para><b>Use the internal IP address of the backend server</b> (default): The internal IP address of the backend server is used as the health check domain name.</para>
            /// </description></item>
            /// <item><description><para><b>Specify a domain name</b>: Enter a domain name.</para>
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
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("HealthCheckHost")]
            [Validation(Required=false)]
            public string HealthCheckHost { get; set; }

            /// <summary>
            /// <para>The HTTP version for health checks. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>HTTP1.0</b></description></item>
            /// <item><description><b>HTTP1.1</b></description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter takes effect only when <b>HealthCheckEnabled</b> is set to true and <b>HealthCheckProtocol</b> is set to <b>HTTP</b> or <b>HTTPS</b> for the server group.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP1.1</para>
            /// </summary>
            [NameInMap("HealthCheckHttpVersion")]
            [Validation(Required=false)]
            public string HealthCheckHttpVersion { get; set; }

            /// <summary>
            /// <para>The interval between two consecutive health checks. Unit: seconds. </para>
            /// <para>Valid values: <b>1</b> to <b>50</b>.</para>
            /// <remarks>
            /// <para>This parameter settings take effect only when <b>HealthCheckEnabled</b> is set to <b>true</b> for the server group.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("HealthCheckInterval")]
            [Validation(Required=false)]
            public int? HealthCheckInterval { get; set; }

            /// <summary>
            /// <para>The health check method. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>GET</b>: If the response body is longer than 8 KB, it is truncated. However, this does not affect the health check result.</para>
            /// </description></item>
            /// <item><description><para><b>POST</b>: gRPC listener health checks use the POST method by default.</para>
            /// </description></item>
            /// <item><description><para><b>HEAD</b>: HTTP and HTTPS listener health checks use the HEAD method by default.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter takes effect only when <b>HealthCheckEnabled</b> is set to true and <b>HealthCheckProtocol</b> is set to <b>HTTP</b>, <b>HTTPS</b>, or <b>gRPC</b> for the server group.</para>
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
            /// <para>The path must be 1 to 80 characters in length and can contain only letters, digits, and the following characters: <c>-/.%?#&amp;=</c> and the following extended characters: <c>_;~!（)*[]@$^:\\&quot;,+</c>. The URL must start with <c>/</c>.</para>
            /// <remarks>
            /// <para>This parameter takes effect only when <b>HealthCheckEnabled</b> is set to <b>true</b> and <b>HealthCheckProtocol</b> is set to <b>HTTP</b> or <b>HTTPS</b> for the server group.</para>
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
            /// <item><description><para><b>HTTP</b>: The system sends HEAD or GET requests to simulate browser access behavior and checks whether the server application is healthy.</para>
            /// </description></item>
            /// <item><description><para><b>HTTPS</b>: The system sends HEAD or GET requests to simulate browser access behavior and checks whether the server application is healthy. HTTPS provides data encryption and is more secure than HTTP.</para>
            /// </description></item>
            /// <item><description><para><b>TCP</b>: The system sends SYN handshake packets to check whether the server port is alive.</para>
            /// </description></item>
            /// <item><description><para><b>gRPC</b>: The system sends POST or GET requests to check whether the server application is healthy.</para>
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
            /// <para>The time to accept a response from a health check. If the backend ECS instance does not respond correctly within the specified time, the health check is considered failed. Unit: seconds.</para>
            /// <para>Valid values: <b>1</b> to <b>300</b>.</para>
            /// <remarks>
            /// <para>This parameter settings take effect only when <b>HealthCheckEnabled</b> is set to <b>true</b> for the server group.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("HealthCheckTimeout")]
            [Validation(Required=false)]
            public int? HealthCheckTimeout { get; set; }

            /// <summary>
            /// <para>The number of consecutive successful health checks required before the health check status of a backend server changes from <b>fail</b> to <b>success</b>.</para>
            /// <para>Valid values: <b>2</b> to <b>10</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("HealthyThreshold")]
            [Validation(Required=false)]
            public int? HealthyThreshold { get; set; }

            /// <summary>
            /// <para>The number of consecutive failed health checks required before the health check status of a backend server changes from <b>success</b> to <b>fail</b>.</para>
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
        /// <para>The IP version affinity mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Affinity</para>
        /// </summary>
        [NameInMap("IpVersionAffinityMode")]
        [Validation(Required=false)]
        public string IpVersionAffinityMode { get; set; }

        /// <summary>
        /// <para>The scheduling algorithm. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Wrr</b>: weighted round-robin. Backend servers with higher weights receive more requests (higher probability) than those with lower weights.</description></item>
        /// <item><description><b>Wlc</b>: weighted least connections. In addition to the weight assigned to each backend server, the actual server load (number of connections) is also considered. When the weights are the same, backend servers with fewer current connections receive more requests (higher probability).</description></item>
        /// <item><description><b>Sch</b>: consistent hashing. Requests with the same hash factor are dispatched to the same backend server. If the UchConfig parameter is not configured, the default hash factor is the source IP address, and requests from the same source IP address are distributed to the same backend server. If the UchConfig parameter is configured, the hash factor is a URL parameter, and requests with the same URL parameter are distributed to the same backend server.</description></item>
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
        /// <para>The name must be 2 to 128 characters in length, and can contain letters, digits, periods (.), underscores (_), hyphens (-), and spaces. The name must start with a letter, a digit, or a Chinese character.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ServerGroupName")]
        [Validation(Required=false)]
        public string ServerGroupName { get; set; }

        /// <summary>
        /// <para>This parameter is applicable only to ALB Ingress scenarios and specifies the <c>K8s Service</c> name that corresponds to the server group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test2</para>
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// <para>The slow start configuration.</para>
        /// <para>After slow start is enabled, newly added backend servers in the server group are warmed up during a specified period of time, and the number of requests forwarded to these servers increases linearly.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Basic Edition instances do not support slow start. Only Standard Edition and WAF Enhanced Edition instances support this feature.</description></item>
        /// <item><description>Server type and IP backend server groups support slow start configuration. Function Compute backend server groups do not support this feature.</description></item>
        /// <item><description>Slow start can be enabled only when the backend scheduling algorithm is weighted round-robin.</description></item>
        /// </list>
        /// </remarks>
        /// </summary>
        [NameInMap("SlowStartConfig")]
        [Validation(Required=false)]
        public UpdateServerGroupAttributeRequestSlowStartConfig SlowStartConfig { get; set; }
        public class UpdateServerGroupAttributeRequestSlowStartConfig : TeaModel {
            /// <summary>
            /// <para>The slow start duration.</para>
            /// <para>Valid values: <b>30</b> to <b>900</b>.</para>
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
            /// <item><description><b>false</b>: disabled.</description></item>
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
        /// </summary>
        [NameInMap("StickySessionConfig")]
        [Validation(Required=false)]
        public UpdateServerGroupAttributeRequestStickySessionConfig StickySessionConfig { get; set; }
        public class UpdateServerGroupAttributeRequestStickySessionConfig : TeaModel {
            /// <summary>
            /// <para>The cookie configured on the server.</para>
            /// <para>The cookie must be 1 to 200 characters in length and can contain only ASCII letters and digits. It cannot contain commas (,), semicolons (;), or spaces, and cannot start with a dollar sign ($).</para>
            /// <remarks>
            /// <para>This parameter takes effect only when <b>StickySessionEnabled</b> is set to <b>true</b> and <b>StickySessionType</b> is set to <b>Server</b> for the server group.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>B490B5EBF6F3CD402E515D22B******</para>
            /// </summary>
            [NameInMap("Cookie")]
            [Validation(Required=false)]
            public string Cookie { get; set; }

            /// <summary>
            /// <para>The cookie timeout period. Unit: seconds.</para>
            /// <para>Valid values: <b>1</b> to <b>86400</b>.</para>
            /// <remarks>
            /// <para>This parameter takes effect only when <b>StickySessionEnabled</b> is set to <b>true</b> and <b>StickySessionType</b> is set to <b>Insert</b> for the server group.</para>
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
            /// <item><description><b>Insert</b>: inserts a cookie.
            /// When a client accesses the server for the first time, the load balancing service inserts a cookie into the response (inserts SERVERID into the HTTP or HTTPS response). The next time the client sends a request with this cookie, the load balancing service forwards the request to the previously recorded backend server.</description></item>
            /// <item><description><b>Server</b>: rewrites a cookie.
            /// When the load balancing service detects a user-defined cookie, it rewrites the original cookie. The next time the client sends a request with the new cookie, the load balancing service forwards the request to the previously recorded backend server.</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter takes effect only when <b>StickySessionEnabled</b> is set to <b>true</b> for the server group.</para>
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
        /// <para>The URL consistent hashing parameter settings.</para>
        /// </summary>
        [NameInMap("UchConfig")]
        [Validation(Required=false)]
        public UpdateServerGroupAttributeRequestUchConfig UchConfig { get; set; }
        public class UpdateServerGroupAttributeRequestUchConfig : TeaModel {
            /// <summary>
            /// <para>The parameter type. Only QueryString is supported.</para>
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
        /// <item><description><para><b>true</b>: enabled.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>sgp-123</para>
        /// </summary>
        [NameInMap("UpstreamKeepaliveEnabled")]
        [Validation(Required=false)]
        public bool? UpstreamKeepaliveEnabled { get; set; }

    }

}
