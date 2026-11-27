// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ListServerGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries returned per request in a paginated query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token used to retrieve the next page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, no more results are available.</description></item>
        /// <item><description>If <b>NextToken</b> is returned, the value is the token for the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>caeba0bbb2be03f8****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CEF72CEB-54B6-4AE8-B225-F876******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of backend server groups.</para>
        /// </summary>
        [NameInMap("ServerGroups")]
        [Validation(Required=false)]
        public List<ListServerGroupsResponseBodyServerGroups> ServerGroups { get; set; }
        public class ListServerGroupsResponseBodyServerGroups : TeaModel {
            /// <summary>
            /// <para>Indicates whether configuration management is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Enabled.</description></item>
            /// <item><description><b>false</b>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("ConfigManagedEnabled")]
            [Validation(Required=false)]
            public bool? ConfigManagedEnabled { get; set; }

            /// <summary>
            /// <para>The graceful connection break configuration.</para>
            /// <para>When graceful connection break is enabled, load balancing allows existing connections to be transmitted normally within a specified period after a backend server is removed or a health check failed.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>Graceful connection break is not supported by Basic Edition instances. Only Standard Edition and WAF Enhanced Edition instances support this feature.</description></item>
            /// <item><description>Graceful connection break is supported by server groups of the server type and IP type, but not by server groups of the Function Compute type.</description></item>
            /// </list>
            /// </remarks>
            /// </summary>
            [NameInMap("ConnectionDrainConfig")]
            [Validation(Required=false)]
            public ListServerGroupsResponseBodyServerGroupsConnectionDrainConfig ConnectionDrainConfig { get; set; }
            public class ListServerGroupsResponseBodyServerGroupsConnectionDrainConfig : TeaModel {
                /// <summary>
                /// <para>Specifies whether to enable connection draining.</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: Enabled.</description></item>
                /// <item><description><b>false</b>: Disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("ConnectionDrainEnabled")]
                [Validation(Required=false)]
                public bool? ConnectionDrainEnabled { get; set; }

                /// <summary>
                /// <para>The timeout period for connection draining.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("ConnectionDrainTimeout")]
                [Validation(Required=false)]
                public int? ConnectionDrainTimeout { get; set; }

            }

            /// <summary>
            /// <para>The time when the resource was created. The time is displayed in UTC and follows the ISO 8601 standard in the YYYY-MM-DDTHH:mm:ssZ format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-07-02T02:49:05Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable cross-zone load balancing for the server group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Enabled. This is the default value.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CrossZoneEnabled")]
            [Validation(Required=false)]
            public bool? CrossZoneEnabled { get; set; }

            /// <summary>
            /// <para>The health check configuration.</para>
            /// </summary>
            [NameInMap("HealthCheckConfig")]
            [Validation(Required=false)]
            public ListServerGroupsResponseBodyServerGroupsHealthCheckConfig HealthCheckConfig { get; set; }
            public class ListServerGroupsResponseBodyServerGroupsHealthCheckConfig : TeaModel {
                /// <summary>
                /// <para>The list of status codes that indicate a successful health check.</para>
                /// </summary>
                [NameInMap("HealthCheckCodes")]
                [Validation(Required=false)]
                public List<string> HealthCheckCodes { get; set; }

                /// <summary>
                /// <para>The port of the backend server used for health checks. Valid values: <b>0</b> to <b>65535</b>. A value of <b>0</b> indicates that the port of the backend server is used for health checks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("HealthCheckConnectPort")]
                [Validation(Required=false)]
                public int? HealthCheckConnectPort { get; set; }

                /// <summary>
                /// <para>Indicates whether health checks are enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: Enabled.</description></item>
                /// <item><description><b>false</b>: Disabled.</description></item>
                /// </list>
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
                /// <item><description><para><b>Use the internal IP address of the backend server</b> (default): The internal IP address of the backend server is used as the domain name for health checks.</para>
                /// </description></item>
                /// <item><description><para><b>Specify a domain name</b>: Enter a domain name.</para>
                /// <list type="bullet">
                /// <item><description><para>The domain name must be 1 to 80 characters in length.</para>
                /// </description></item>
                /// <item><description><para>It can contain lowercase letters, digits, hyphens (-), and periods (.).</para>
                /// </description></item>
                /// <item><description><para>It must contain at least one period (.), and the period (.) cannot be at the beginning or end.</para>
                /// </description></item>
                /// <item><description><para>The rightmost domain label can contain only letters, and cannot contain digits or hyphens (-).</para>
                /// </description></item>
                /// <item><description><para>A hyphen (-) cannot be at the beginning or end.</para>
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
                /// <para>The HTTP version for health checks. Valid values: <b>HTTP1.0</b> and <b>HTTP1.1</b>.</para>
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
                /// <para>The interval between two consecutive health checks. Unit: seconds. Valid values: <b>1</b> to <b>50</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("HealthCheckInterval")]
                [Validation(Required=false)]
                public int? HealthCheckInterval { get; set; }

                /// <summary>
                /// <para>The HTTP method used for health checks. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>GET</b>: If the response message exceeds 8 KB, it is truncated. However, this does not affect the health check result.</para>
                /// </description></item>
                /// <item><description><para><b>POST</b>: The POST method is used by default for gRPC listener health checks.</para>
                /// </description></item>
                /// <item><description><para><b>HEAD</b>: The HEAD method is used by default for HTTP and HTTPS listener health checks.</para>
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
                /// <item><description><para><b>HTTP</b>: Sends HEAD or GET requests for browser impersonation to check whether the server application is healthy.</para>
                /// </description></item>
                /// <item><description><para><b>HTTPS</b>: Sends HEAD or GET requests for browser impersonation to check whether the server application is healthy. (Data encryption, more secure than HTTP.)</para>
                /// </description></item>
                /// <item><description><para><b>TCP</b>: Sends SYN handshake messages to check whether the server port is alive.</para>
                /// </description></item>
                /// <item><description><para><b>gRPC</b>: Sends POST or GET requests to check whether the server application is healthy.</para>
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
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("HealthCheckTimeout")]
                [Validation(Required=false)]
                public int? HealthCheckTimeout { get; set; }

                /// <summary>
                /// <para>The number of consecutive successful health checks required to change the health check status of a backend server from <b>Failed</b> to <b>Successful</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("HealthyThreshold")]
                [Validation(Required=false)]
                public int? HealthyThreshold { get; set; }

                /// <summary>
                /// <para>The number of consecutive failed health checks required to change the health check status of a backend server from <b>Successful</b> to <b>Failed</b>.</para>
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
            /// <item><description>NonAffinity: No affinity mode. This is the default value.</description></item>
            /// <item><description>Affinity: Affinity mode.</description></item>
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
            /// <para>Indicates whether the IP protocol version used by the load balancing to forward traffic to the backend server group supports IPv6. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>false</b> (default): IPv6 is not supported. For the IPv4 type, only IPv4 backend servers can be added.</description></item>
            /// <item><description><b>true</b>: Dual-stack type. Both IPv4 and IPv6 backend servers can be added.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Ipv6Enabled")]
            [Validation(Required=false)]
            public bool? Ipv6Enabled { get; set; }

            /// <summary>
            /// <para>The backend protocol type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>HTTP</b>: Supports association with HTTPS, HTTP, and QUIC listeners.</para>
            /// </description></item>
            /// <item><description><para><b>HTTPS</b>: Supports association with HTTPS listeners.</para>
            /// </description></item>
            /// <item><description><para><b>GRPC</b>: Supports association with HTTPS and QUIC listeners.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The IDs of the associated instances.</para>
            /// </summary>
            [NameInMap("RelatedLoadBalancerIds")]
            [Validation(Required=false)]
            public List<string> RelatedLoadBalancerIds { get; set; }

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
            /// <item><description><b>Wrr</b>: Weighted round-robin. Backend servers with higher weights are more likely to be polled.</description></item>
            /// <item><description><b>Wlc</b>: Weighted least connections. In addition to the weight of each backend server, the actual load (number of connections) is also considered. When weights are the same, backend servers with fewer current connections are more likely to be polled.</description></item>
            /// <item><description><b>Sch</b>: Consistent hashing. Requests with the same hash factor calculation result are scheduled to the same backend server. If the UchConfig parameter is not configured, the default hash factor is the source IP address, and requests from the same source IP address are distributed to the same backend server. If the UchConfig parameter is configured, the hash factor is the URL parameter, and requests with the same URL parameter are distributed to the same backend server.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Wrr</para>
            /// </summary>
            [NameInMap("Scheduler")]
            [Validation(Required=false)]
            public string Scheduler { get; set; }

            /// <summary>
            /// <para>The number of servers in the server group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ServerCount")]
            [Validation(Required=false)]
            public int? ServerCount { get; set; }

            /// <summary>
            /// <para>The ID of the server group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sgp-cige6j****</para>
            /// </summary>
            [NameInMap("ServerGroupId")]
            [Validation(Required=false)]
            public string ServerGroupId { get; set; }

            /// <summary>
            /// <para>The name of the server group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Group3</para>
            /// </summary>
            [NameInMap("ServerGroupName")]
            [Validation(Required=false)]
            public string ServerGroupName { get; set; }

            /// <summary>
            /// <para>The status of the server group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Creating</b>: The server group is being created.</para>
            /// </description></item>
            /// <item><description><para><b>Available</b>: The server group is available.</para>
            /// </description></item>
            /// <item><description><para><b>Configuring</b>: The server group is being reconfigured.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("ServerGroupStatus")]
            [Validation(Required=false)]
            public string ServerGroupStatus { get; set; }

            /// <summary>
            /// <para>The type of the server group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Instance</b>: Server type, including ECS, ENI, and ECI instances.</para>
            /// </description></item>
            /// <item><description><para><b>Ip</b>: IP address type.</para>
            /// </description></item>
            /// <item><description><para><b>Fc</b>: Function Compute type.</para>
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
            /// <para>The service name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            /// <summary>
            /// <para>The slow start configuration.</para>
            /// <para>After slow start is enabled, newly added backend servers in the backend server group are warmed up within a specified period, and the number of requests forwarded to the servers increases linearly.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>Slow start is not supported by Basic Edition instances. Only Standard Edition and WAF Enhanced Edition instances support this feature.</description></item>
            /// <item><description>Slow start can be configured for server groups of the server type and IP type, but not for server groups of the Function Compute type.</description></item>
            /// <item><description>Slow start can be enabled only when the backend scheduling algorithm is set to the weighted polling algorithm.</description></item>
            /// </list>
            /// </remarks>
            /// </summary>
            [NameInMap("SlowStartConfig")]
            [Validation(Required=false)]
            public ListServerGroupsResponseBodyServerGroupsSlowStartConfig SlowStartConfig { get; set; }
            public class ListServerGroupsResponseBodyServerGroupsSlowStartConfig : TeaModel {
                /// <summary>
                /// <para>The duration of slow start.</para>
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
                /// <item><description><b>true</b>: Enabled.</description></item>
                /// <item><description><b>false</b>: Disabled.</description></item>
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
            public ListServerGroupsResponseBodyServerGroupsStickySessionConfig StickySessionConfig { get; set; }
            public class ListServerGroupsResponseBodyServerGroupsStickySessionConfig : TeaModel {
                /// <summary>
                /// <para>The cookie configured on the server.</para>
                /// 
                /// <b>Example:</b>
                /// <para>B490B5EBF6F3CD402E515D22BCDA****</para>
                /// </summary>
                [NameInMap("Cookie")]
                [Validation(Required=false)]
                public string Cookie { get; set; }

                /// <summary>
                /// <para>The timeout period of the cookie. Unit: seconds. Valid values: <b>1</b> to <b>86400</b>.</para>
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
                /// <para>Indicates whether session persistence is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: Enabled.</description></item>
                /// <item><description><b>false</b>: Disabled.</description></item>
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
                /// <item><description><b>Insert</b>: Insert a cookie. When a client accesses the service for the first time, the load balancing inserts a cookie (that is, inserts SERVERID into the HTTP or HTTPS response message). The next time the client accesses the service with this cookie, the load balancing service forwards the request to the previously recorded backend server.</description></item>
                /// <item><description><b>Server</b>: Rewrite a cookie. When the load balancing detects a user-defined cookie, it rewrites the original cookie. The next time the client accesses the service with the new cookie, the load balancing service forwards the request to the previously recorded backend server.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Insert</para>
                /// </summary>
                [NameInMap("StickySessionType")]
                [Validation(Required=false)]
                public string StickySessionType { get; set; }

            }

            /// <summary>
            /// <para>The list of tags bound to the server group.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListServerGroupsResponseBodyServerGroupsTags> Tags { get; set; }
            public class ListServerGroupsResponseBodyServerGroupsTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The URL consistent hash parameter settings.</para>
            /// </summary>
            [NameInMap("UchConfig")]
            [Validation(Required=false)]
            public ListServerGroupsResponseBodyServerGroupsUchConfig UchConfig { get; set; }
            public class ListServerGroupsResponseBodyServerGroupsUchConfig : TeaModel {
                /// <summary>
                /// <para>The parameter type. Only QueryString is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>QueryString</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The consistent hash parameter value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abc</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether upstream keep-alive is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Enabled.</description></item>
            /// <item><description><b>false</b>: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("UpstreamKeepaliveEnabled")]
            [Validation(Required=false)]
            public bool? UpstreamKeepaliveEnabled { get; set; }

            /// <summary>
            /// <para>The VPC-connected instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp15zckdt37pq72zv****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
