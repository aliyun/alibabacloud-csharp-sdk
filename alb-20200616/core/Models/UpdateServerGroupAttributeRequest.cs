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
        /// <para>You can use the client to generate the value, but you must ensure that it is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the RequestId of the API request as the client token. The RequestId of each API request may be different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3******</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The graceful connection break configuration.</para>
        /// <para>After the graceful connection break is enabled, load balancing allows existing connections to be normally transmitted within a specified period after a backend server is removed or a health check is failed.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Basic Edition instances do not support connection draining. Only Standard Edition and WAF-enhanced Edition instances support this feature.</description></item>
        /// <item><description>Server group types that support connection draining include server type and IP type. Function Compute type is not supported.</description></item>
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
            /// <item><description><b>true</b>: enables connection draining.</description></item>
            /// <item><description><b>false</b>: disables connection draining.</description></item>
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
        /// <item><description><para><b>true</b>: enables cross-zone load balancing (default).</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: disables cross-zone load balancing.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Basic Edition instances do not support server groups with cross-zone load balancing disabled. Only Standard Edition and WAF-enhanced Edition instances support this feature.</description></item>
        /// <item><description>Server group types that support disabling cross-zone load balancing include server type and IP type. Function Compute type is not supported.</description></item>
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
        /// <para>Specifies whether to perform only a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs only a dry run and does not modify resources. The system checks the required parameters, request format, and service limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): performs a dry run and sends the actual request. If the request passes the dry run, an HTTP <c>2xx</c> status code is returned and the operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The health check configuration struct.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("HealthCheckConfig")]
        [Validation(Required=false)]
        public UpdateServerGroupAttributeRequestHealthCheckConfig HealthCheckConfig { get; set; }
        public class UpdateServerGroupAttributeRequestHealthCheckConfig : TeaModel {
            /// <summary>
            /// <para>The list of status codes that indicate a successful health check.</para>
            /// </summary>
            [NameInMap("HealthCheckCodes")]
            [Validation(Required=false)]
            public List<string> HealthCheckCodes { get; set; }

            /// <summary>
            /// <para>The port of the backend server that is used for health checks.</para>
            /// <para>Valid values: <b>0</b> to <b>65535</b>.</para>
            /// <para>A value of <b>0</b> indicates that the port of the backend server is used for health checks.</para>
            /// <remarks>
            /// <para>The parameter settings take effect only when <b>HealthCheckEnabled</b> is set to <b>true</b> for the server group.</para>
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
            /// <item><description><b>true</b>: enables health checks.</description></item>
            /// <item><description><b>false</b>: disables health checks.</description></item>
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
            /// <item><description><para><b>Internal IP address of the backend server</b> (default): The internal IP address of the backend server is used as the domain name for health checks.</para>
            /// </description></item>
            /// <item><description><para><b>Custom domain name</b>: Enter a domain name.</para>
            /// <list type="bullet">
            /// <item><description><para>The domain name must be 1 to 80 characters in length.</para>
            /// </description></item>
            /// <item><description><para>It can contain lowercase letters, digits, hyphens (-), and periods (.).</para>
            /// </description></item>
            /// <item><description><para>It must contain at least one period (.), and the period (.) cannot be at the beginning or end.</para>
            /// </description></item>
            /// <item><description><para>The rightmost domain label can contain only letters, and cannot contain digits or hyphens (-).</para>
            /// </description></item>
            /// <item><description><para>The domain name cannot start or end with a hyphen (-).</para>
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
            /// <para>The HTTP version that is used for health checks. Valid values:</para>
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
            /// <para>The parameter settings take effect only when <b>HealthCheckEnabled</b> is set to <b>true</b> for the server group.</para>
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
            /// <item><description><para><b>GET</b>: If the length of the response message exceeds 8 KB, the message is truncated. However, the health check result is not affected.</para>
            /// </description></item>
            /// <item><description><para><b>POST</b>: The POST method is used by default for gRPC listener health checks.</para>
            /// </description></item>
            /// <item><description><para><b>HEAD</b>: The HEAD method is used by default for HTTP and HTTPS listener health checks.</para>
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
            /// <para>The path that is used for health checks.</para>
            /// <para>The path must be 1 to 80 characters in length, and can contain only letters, digits, the characters <c>-/.%?#&amp;=</c>, and the extension characters <c>_;~!()*[]@$^:\&quot;,+</c>. The path must start with a forward slash.</para>
            /// <remarks>
            /// <para>This parameter takes effect only when <b>HealthCheckEnabled</b> is set to <b>true</b> and the <b>HealthCheckProtocol</b> settings are <b>HTTP</b> or <b>HTTPS</b> for the server group.</para>
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
            /// <item><description><para><b>HTTP</b>: sends HEAD or GET requests for browser impersonation to check whether the server application is healthy.</para>
            /// </description></item>
            /// <item><description><para><b>HTTPS</b>: sends HEAD or GET requests for browser impersonation to check whether the server application is healthy. (Data encryption makes it more secure than HTTP.)</para>
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
            /// <para>The timeout period to accept a response from a health check. If the backend ECS instance does not respond correctly within the specified time, the health check is failed. Unit: seconds.</para>
            /// <para>Valid values: <b>1</b> to <b>300</b>.</para>
            /// <remarks>
            /// <para>The parameter settings take effect only when <b>HealthCheckEnabled</b> is set to <b>true</b> for the server group.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("HealthCheckTimeout")]
            [Validation(Required=false)]
            public int? HealthCheckTimeout { get; set; }

            /// <summary>
            /// <para>The number of consecutive successful health checks that must occur before the health check status of a backend server changes from <b>fail</b> to <b>success</b>.</para>
            /// <para>Valid values: <b>2</b> to <b>10</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("HealthyThreshold")]
            [Validation(Required=false)]
            public int? HealthyThreshold { get; set; }

            /// <summary>
            /// <para>The number of consecutive failed health checks that must occur before the health check status of a backend server changes from <b>success</b> to <b>fail</b>.</para>
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
        /// <para>The IP version affinity mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NonAffinity (default): no affinity mode.</description></item>
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
        /// <para>The scheduling algorithm. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Wrr</b>: weighted round-robin. Backend servers with higher weights receive more requests.</description></item>
        /// <item><description><b>Wlc</b>: weighted least connections. Requests are distributed based on the weights and actual loads (number of connections) of backend servers. If backend servers have the same weight, the server with the fewest connections receives more requests.</description></item>
        /// <item><description><b>Sch</b>: consistent hashing. Requests with the same hash factor are scheduled to the same backend server. If the UchConfig parameter is not configured, the default hash factor is the source IP address, and requests from the same source IP address are distributed to the same backend server. If the UchConfig parameter is configured, the hash factor is the URL parameter, and requests with the same URL parameter are distributed to the same backend server.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Wrr</para>
        /// </summary>
        [NameInMap("Scheduler")]
        [Validation(Required=false)]
        public string Scheduler { get; set; }

        /// <summary>
        /// <para>The ID of the server group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sgp-atstuj3rtop****</para>
        /// </summary>
        [NameInMap("ServerGroupId")]
        [Validation(Required=false)]
        public string ServerGroupId { get; set; }

        /// <summary>
        /// <para>The name of the server group.</para>
        /// <para>The name must be 2 to 128 characters in length, and can contain letters, digits, periods (.), underscores (_), hyphens (-), and spaces. It must start with a letter or a digit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ServerGroupName")]
        [Validation(Required=false)]
        public string ServerGroupName { get; set; }

        /// <summary>
        /// <para>This parameter is applicable only to ALB Ingress scenarios and specifies the name of the <c>K8s Service</c> that corresponds to the server group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test2</para>
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// <para>The slow start configuration.</para>
        /// <para>After slow start is enabled, newly added backend servers in the backend server group are warmed up within the specified time period, and the number of requests forwarded to the servers increases linearly.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Basic Edition instances do not support slow start. Only Standard Edition and WAF-enhanced Edition instances support this feature.</description></item>
        /// <item><description>Server group types that support slow start include server type and IP type. Function Compute type is not supported.</description></item>
        /// <item><description>Slow start can be enabled only when the backend scheduling algorithm is weighted round-robin polling.</description></item>
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
            /// <para>Specifies whether to enable slow start. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: enables slow start.</description></item>
            /// <item><description><b>false</b>: disables slow start.</description></item>
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
        /// <para>The session persistence configuration struct.</para>
        /// </summary>
        [NameInMap("StickySessionConfig")]
        [Validation(Required=false)]
        public UpdateServerGroupAttributeRequestStickySessionConfig StickySessionConfig { get; set; }
        public class UpdateServerGroupAttributeRequestStickySessionConfig : TeaModel {
            /// <summary>
            /// <para>The cookie configured on the server.</para>
            /// <para>The cookie must be 1 to 200 characters in length, and can contain only ASCII letters and digits. It cannot contain commas (,), semicolons (;), or spaces, and cannot start with a dollar sign ($).</para>
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
            /// <para>The timeout period of the cookie. Unit: seconds.</para>
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
            /// <item><description><b>true</b>: enables session persistence.</description></item>
            /// <item><description><b>false</b>: disables session persistence.</description></item>
            /// </list>
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
            /// <item><description><b>Insert</b>: inserts a cookie.
            /// When a client accesses the server for the first time, load balancing inserts a cookie (SERVERID) into the HTTP or HTTPS response. The next time the client accesses the server with this cookie, the load balancing service forwards the request to the recorded backend server.</description></item>
            /// <item><description><b>Server</b>: rewrites a cookie.
            /// When ALB detects a user-defined cookie, it rewrites the original cookie. The next time the client accesses the server with the new cookie, ALB forwards the request to the recorded backend server.</description></item>
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
        /// <para>Specifies whether to enable backend keep-alive. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: enables backend keep-alive.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: disables backend keep-alive.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("UpstreamKeepaliveEnabled")]
        [Validation(Required=false)]
        public bool? UpstreamKeepaliveEnabled { get; set; }

    }

}
