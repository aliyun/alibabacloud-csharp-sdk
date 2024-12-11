// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class ListServerGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, no next page exists.</description></item>
        /// <item><description>If <b>NextToken</b> is not empty, the value of NextToken can be used in the next request to retrieve a new page of results.</description></item>
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
        /// <para>CEF72CEB-54B6-4AE8-B225-F876FF7BA984</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The server groups.</para>
        /// </summary>
        [NameInMap("ServerGroups")]
        [Validation(Required=false)]
        public List<ListServerGroupsResponseBodyServerGroups> ServerGroups { get; set; }
        public class ListServerGroupsResponseBodyServerGroups : TeaModel {
            /// <summary>
            /// <para>Indicates whether configuration management is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("ConfigManagedEnabled")]
            [Validation(Required=false)]
            public bool? ConfigManagedEnabled { get; set; }

            /// <summary>
            /// <para>The configurations of connection draining.</para>
            /// <para>After connection draining is enabled, ALB maintains data transmission for a period of time after the backend server is removed or declared unhealthy.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>Basic ALB instances do not support connection draining. Standard and WAF-enabled ALB instances support connection draining. </description></item>
            /// <item><description>Server groups of the instance and IP types support connection draining. Server groups of the Function Compute type do not support connection draining.</description></item>
            /// </list>
            /// </remarks>
            /// </summary>
            [NameInMap("ConnectionDrainConfig")]
            [Validation(Required=false)]
            public ListServerGroupsResponseBodyServerGroupsConnectionDrainConfig ConnectionDrainConfig { get; set; }
            public class ListServerGroupsResponseBodyServerGroupsConnectionDrainConfig : TeaModel {
                /// <summary>
                /// <para>Indicates whether connection draining is enabled. Valid values:</para>
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
                /// 
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("ConnectionDrainTimeout")]
                [Validation(Required=false)]
                public int? ConnectionDrainTimeout { get; set; }

            }

            /// <summary>
            /// <para>The time when the resource was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-07-02T02:49:05Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>是否开启跨可用区转发。（默认开启）</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CrossZoneEnabled")]
            [Validation(Required=false)]
            public bool? CrossZoneEnabled { get; set; }

            /// <summary>
            /// <para>The health check configurations.</para>
            /// </summary>
            [NameInMap("HealthCheckConfig")]
            [Validation(Required=false)]
            public ListServerGroupsResponseBodyServerGroupsHealthCheckConfig HealthCheckConfig { get; set; }
            public class ListServerGroupsResponseBodyServerGroupsHealthCheckConfig : TeaModel {
                /// <summary>
                /// <para>The HTTP status codes that indicate healthy backend servers.</para>
                /// </summary>
                [NameInMap("HealthCheckCodes")]
                [Validation(Required=false)]
                public List<string> HealthCheckCodes { get; set; }

                /// <summary>
                /// <para>The backend port that is used for health checks. Valid values: <b>0</b> to <b>65535</b>.</para>
                /// <para>A value of <b>0</b> indicates that the port of a backend server is used for health checks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("HealthCheckConnectPort")]
                [Validation(Required=false)]
                public int? HealthCheckConnectPort { get; set; }

                /// <summary>
                /// <para>Indicates whether the health check feature is enabled. Valid values:</para>
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
                /// <item><description>The domain name is 1 to 80 characters in length.</description></item>
                /// <item><description>The domain name contains lowercase letters, digits, hyphens (-), and periods (.).</description></item>
                /// <item><description>The domain name contains at least one period (.) but does not start or end with a period (.).</description></item>
                /// <item><description>The rightmost domain label of the domain name contains only letters, and does not contain digits or hyphens (-).</description></item>
                /// <item><description>The domain name does not start or end with a hyphen (-).</description></item>
                /// </list>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <para> This parameter takes effect only if HealthCheckProtocol is set to HTTP, HTTPS, or gRPC.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://www.example.com">www.example.com</a></para>
                /// </summary>
                [NameInMap("HealthCheckHost")]
                [Validation(Required=false)]
                public string HealthCheckHost { get; set; }

                /// <summary>
                /// <para>The HTTP version that is used for health checks.</para>
                /// <para>Valid values: <b>HTTP1.0</b> and <b>HTTP1.1</b>.</para>
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
                /// <para>The interval at which health checks are performed. Unit: seconds. Valid values: <b>1</b> to <b>50</b>.</para>
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
                /// <item><description><b>HTTPS</b>: HTTPS health checks simulate browser behaviors by sending HEAD or GET requests to probe the availability of backend servers. HTTPS supports encryption and provides higher security than HTTP.</description></item>
                /// <item><description><b>TCP</b>: TCP health checks send TCP SYN packets to a backend server to check whether the port of the backend server is reachable.</description></item>
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
                /// <para>The timeout period of a health check response. If a backend server does not respond within the specified timeout period, the backend server is declared unhealthy. Unit: seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("HealthCheckTimeout")]
                [Validation(Required=false)]
                public int? HealthCheckTimeout { get; set; }

                /// <summary>
                /// <para>The number of times that an unhealthy backend server must consecutively pass health checks before it is declared healthy. In this case, the health status is changed from <b>fail</b> to <b>success</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("HealthyThreshold")]
                [Validation(Required=false)]
                public int? HealthyThreshold { get; set; }

                /// <summary>
                /// <para>The number of times that a healthy backend server must consecutively fail health checks before it is declared unhealthy. In this case, the health status is changed from <b>success</b> to <b>fail</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("UnhealthyThreshold")]
                [Validation(Required=false)]
                public int? UnhealthyThreshold { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether IPv6 is supported. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
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
            /// <item><description><b>HTTP</b>: allows you to associate HTTPS, HTTP, or QUIC listeners with backend servers.</description></item>
            /// <item><description><b>HTTPS</b>: allows you to associate HTTPS listeners with backend servers.</description></item>
            /// <item><description><b>GRPC</b>: allows you to associate HTTPS and QUIC listeners with backend servers.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The ID of the ALB instance associated with the server group.</para>
            /// </summary>
            [NameInMap("RelatedLoadBalancerIds")]
            [Validation(Required=false)]
            public List<string> RelatedLoadBalancerIds { get; set; }

            /// <summary>
            /// <para>The ID of the resource group to which the instance belongs.</para>
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
            /// <item><description><b>Wrr</b>: weighted round-robin. Backend servers with higher weights receive more requests than backend servers with lower weights.</description></item>
            /// <item><description><b>Wlc</b>: weighted least connections. Requests are distributed based on the weight and load of each backend server. The load refers to the number of connections on a backend server. If multiple backend servers have the same weight, requests are forwarded to the backend server with the least number of connections.</description></item>
            /// <item><description><b>Sch</b>: consistent hashing. Requests that have the same hash factors are distributed to the same backend server. If you do not specify the UchConfig parameter, the source IP address is used as the hash factor by default. Requests that are from the same IP address are distributed to the same backend server. If you specify the UchConfig parameter, the URL string is used as the hash factor. Requests that have the same URL string are distributed to the same backend server.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Wrr</para>
            /// </summary>
            [NameInMap("Scheduler")]
            [Validation(Required=false)]
            public string Scheduler { get; set; }

            /// <summary>
            /// <para>The number of backend servers in the server group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ServerCount")]
            [Validation(Required=false)]
            public int? ServerCount { get; set; }

            /// <summary>
            /// <para>The server group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sgp-cige6j****</para>
            /// </summary>
            [NameInMap("ServerGroupId")]
            [Validation(Required=false)]
            public string ServerGroupId { get; set; }

            /// <summary>
            /// <para>The server group name.</para>
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
            /// <item><description><b>Creating</b>.</description></item>
            /// <item><description><b>Available</b></description></item>
            /// <item><description><b>Configuring</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("ServerGroupStatus")]
            [Validation(Required=false)]
            public string ServerGroupStatus { get; set; }

            /// <summary>
            /// <para>The server group type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Instance</b>: instances, including ECS instances, ENIs, and elastic container instances.</description></item>
            /// <item><description><b>Ip</b>: IP addresses.</description></item>
            /// <item><description><b>Fc</b>: Function Compute</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Instance</para>
            /// </summary>
            [NameInMap("ServerGroupType")]
            [Validation(Required=false)]
            public string ServerGroupType { get; set; }

            /// <summary>
            /// <para>The name of the server group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
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
            public ListServerGroupsResponseBodyServerGroupsSlowStartConfig SlowStartConfig { get; set; }
            public class ListServerGroupsResponseBodyServerGroupsSlowStartConfig : TeaModel {
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
            public ListServerGroupsResponseBodyServerGroupsStickySessionConfig StickySessionConfig { get; set; }
            public class ListServerGroupsResponseBodyServerGroupsStickySessionConfig : TeaModel {
                /// <summary>
                /// <para>The cookie configured for the server.</para>
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
                /// <para>Indicates whether session persistence is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("StickySessionEnabled")]
                [Validation(Required=false)]
                public bool? StickySessionEnabled { get; set; }

                /// <summary>
                /// <para>The method that is used to handle the cookie. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>insert</b>: inserts the cookie. The first time a client accesses ALB, ALB inserts the SERVERID cookie into the HTTP or HTTPS response packet. Subsequent requests from the client that carry this cookie are forwarded to the same backend server as the first request.</description></item>
                /// <item><description><b>Server</b>: rewrites the cookie. ALB rewrites the custom cookies in requests from a client. Subsequent requests from the client that carry the new cookie are forwarded to the same backend server as the first request.</description></item>
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
            /// <para>The tags that are added to the server group.</para>
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
            /// <para>The configuration of consistent hashing based on URLs.</para>
            /// </summary>
            [NameInMap("UchConfig")]
            [Validation(Required=false)]
            public ListServerGroupsResponseBodyServerGroupsUchConfig UchConfig { get; set; }
            public class ListServerGroupsResponseBodyServerGroupsUchConfig : TeaModel {
                /// <summary>
                /// <para>The parameter type. Valid value: QueryString.</para>
                /// 
                /// <b>Example:</b>
                /// <para>QueryString</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The hash value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abc</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether persistent TCP connections are enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("UpstreamKeepaliveEnabled")]
            [Validation(Required=false)]
            public bool? UpstreamKeepaliveEnabled { get; set; }

            /// <summary>
            /// <para>The ID of the VPC to which the ALB instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp15zckdt37pq72zv****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
