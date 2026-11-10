// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlb20220430.Models
{
    public class ListServerGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries per page. Valid values: <b>1</b> to <b>100</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, no next query exists.</description></item>
        /// <item><description>If <b>NextToken</b> is returned, the value indicates the token for the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>54B28E3D-DF70-471B-AA93-08E683A1B45</para>
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
            /// <para>The protocol version. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Ipv4</b>: IPv4 type.</description></item>
            /// <item><description><b>DualStack</b>: dual-stack type.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ipv4</para>
            /// </summary>
            [NameInMap("AddressIPVersion")]
            [Validation(Required=false)]
            public string AddressIPVersion { get; set; }

            /// <summary>
            /// <para>The user UID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>165820696622****</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <para>Indicates whether all-port forwarding is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("AnyPortEnabled")]
            [Validation(Required=false)]
            public bool? AnyPortEnabled { get; set; }

            /// <summary>
            /// <para>Indicates whether connection draining is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("ConnectionDrainEnabled")]
            [Validation(Required=false)]
            public bool? ConnectionDrainEnabled { get; set; }

            /// <summary>
            /// <para>The connection draining timeout period. Unit: seconds.
            /// Valid values: <b>10</b> to <b>900</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("ConnectionDrainTimeout")]
            [Validation(Required=false)]
            public int? ConnectionDrainTimeout { get; set; }

            /// <summary>
            /// <para>The health check configuration.</para>
            /// </summary>
            [NameInMap("HealthCheck")]
            [Validation(Required=false)]
            public ListServerGroupsResponseBodyServerGroupsHealthCheck HealthCheck { get; set; }
            public class ListServerGroupsResponseBodyServerGroupsHealthCheck : TeaModel {
                /// <summary>
                /// <para>The port of the backend server used for health checks.</para>
                /// <para>Valid values: <b>0</b> to <b>65535</b>.</para>
                /// <para>A value of <b>0</b> indicates that the port of the backend server is used for health checks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("HealthCheckConnectPort")]
                [Validation(Required=false)]
                public int? HealthCheckConnectPort { get; set; }

                /// <summary>
                /// <para>The maximum timeout period for a health check response. Unit: seconds. Default value: <b>5</b>.</para>
                /// <para>Valid values: <b>1</b> to <b>300</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("HealthCheckConnectTimeout")]
                [Validation(Required=false)]
                public int? HealthCheckConnectTimeout { get; set; }

                /// <summary>
                /// <para>The domain name used for health checks. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>$SERVER_IP</b>: the private IP address of the backend server.</para>
                /// </description></item>
                /// <item><description><para><b>domain</b>: a specific domain name. The domain name can be 1 to 80 characters in length and can contain only lowercase letters, digits, hyphens (-), and periods (.).</para>
                /// </description></item>
                /// </list>
                /// <remarks>
                /// <para>This parameter takes effect only when <b>HealthCheckType</b> is set to <b>HTTP</b>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>$SERVER_IP</para>
                /// </summary>
                [NameInMap("HealthCheckDomain")]
                [Validation(Required=false)]
                public string HealthCheckDomain { get; set; }

                /// <summary>
                /// <para>Indicates whether health check is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><b>true</b>: Enabled.</para>
                /// </description></item>
                /// <item><description><para><b>false</b>: Disabled.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("HealthCheckEnabled")]
                [Validation(Required=false)]
                public bool? HealthCheckEnabled { get; set; }

                /// <summary>
                /// <para>The response string for UDP listener health checks. The string can contain only letters and digits and can be up to 512 characters in length.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ok</para>
                /// </summary>
                [NameInMap("HealthCheckExp")]
                [Validation(Required=false)]
                public string HealthCheckExp { get; set; }

                /// <summary>
                /// <para>The HTTP status codes for a healthy response. Multiple status codes are separated by commas (,).
                /// Valid values: <b>http_2xx</b>, <b>http_3xx</b>, <b>http_4xx</b>, and <b>http_5xx</b>.</para>
                /// <remarks>
                /// <para>This parameter takes effect only when <b>HealthCheckType</b> is set to <b>HTTP</b>.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("HealthCheckHttpCode")]
                [Validation(Required=false)]
                public List<string> HealthCheckHttpCode { get; set; }

                /// <summary>
                /// <para>The HTTP version for health checks. Valid values: <b>HTTP1.0</b> and <b>HTTP1.1</b>.</para>
                /// <remarks>
                /// <para>This parameter takes effect only when <b>HealthCheckType</b> is set to <b>HTTP</b>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>HTTP1.0</para>
                /// </summary>
                [NameInMap("HealthCheckHttpVersion")]
                [Validation(Required=false)]
                public string HealthCheckHttpVersion { get; set; }

                /// <summary>
                /// <para>The interval between two consecutive health checks. Unit: seconds. Default value: <b>5</b>.</para>
                /// <list type="bullet">
                /// <item><description>If <b>HealthCheckType</b> is set to <b>TCP</b> or <b>HTTP</b>, valid values are <b>1</b> to <b>50</b>.</description></item>
                /// <item><description>If <b>HealthCheckType</b> is set to <b>UDP</b>, valid values are <b>1</b> to <b>300</b>. Set the interval to a value greater than or equal to the response timeout period to prevent UDP probe responses from being incorrectly identified as non-responses due to timeout.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("HealthCheckInterval")]
                [Validation(Required=false)]
                public int? HealthCheckInterval { get; set; }

                /// <summary>
                /// <para>The request string for UDP listener health checks. The string can contain only letters and digits and can be up to 512 characters in length.</para>
                /// 
                /// <b>Example:</b>
                /// <para>hello</para>
                /// </summary>
                [NameInMap("HealthCheckReq")]
                [Validation(Required=false)]
                public string HealthCheckReq { get; set; }

                /// <summary>
                /// <para>The health check protocol. Valid values:</para>
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
                /// <para>The health check path.</para>
                /// <remarks>
                /// <para>This parameter takes effect only when <b>HealthCheckType</b> is set to <b>HTTP</b>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>/test/index.html</para>
                /// </summary>
                [NameInMap("HealthCheckUrl")]
                [Validation(Required=false)]
                public string HealthCheckUrl { get; set; }

                /// <summary>
                /// <para>The number of consecutive successful health checks required before a backend server is declared healthy (status changes from <b>fail</b> to <b>success</b>).</para>
                /// <para>Valid values: <b>2</b> to <b>10</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("HealthyThreshold")]
                [Validation(Required=false)]
                public int? HealthyThreshold { get; set; }

                /// <summary>
                /// <para>The health check method. Valid values: <b>GET</b> and <b>HEAD</b>.</para>
                /// <remarks>
                /// <para>This parameter takes effect only when <b>HealthCheckType</b> is set to <b>HTTP</b>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>GET</para>
                /// </summary>
                [NameInMap("HttpCheckMethod")]
                [Validation(Required=false)]
                public string HttpCheckMethod { get; set; }

                /// <summary>
                /// <para>The number of consecutive failed health checks required before a backend server is declared unhealthy (status changes from <b>success</b> to <b>fail</b>).</para>
                /// <para>Valid values: <b>2</b> to <b>10</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("UnhealthyThreshold")]
                [Validation(Required=false)]
                public int? UnhealthyThreshold { get; set; }

            }

            /// <summary>
            /// <para>The traffic scheduling policy in dual-stack mode:</para>
            /// <list type="bullet">
            /// <item><description>NonAffinity (default): non-affinity mode. Traffic is forwarded to healthy backends based on the scheduling algorithm regardless of the IP protocol version of the source.</description></item>
            /// <item><description>Affinity: affinity mode. Traffic is forwarded based on the IP protocol version of the request source. IPv4 requests are forwarded only to IPv4 backends, and IPv6 requests are forwarded only to IPv6 backends.<remarks>
            /// <para>This parameter takes effect only when <b>AddressIPVersion</b> is set to <b>DualStack</b>.</para>
            /// </remarks>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Affinity</para>
            /// </summary>
            [NameInMap("IpVersionAffinityMode")]
            [Validation(Required=false)]
            public string IpVersionAffinityMode { get; set; }

            /// <summary>
            /// <para>Indicates whether client IP preservation is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Enabled.</description></item>
            /// <item><description><b>false</b>: Disabled.</description></item>
            /// </list>
            /// <remarks>
            /// <para>When <b>AddressIPVersion</b> is set to <b>ipv4</b>, the default value is <b>true</b>. When <b>AddressIPVersion</b> is set to <b>ipv6</b>, the value can only be <b>false</b>. This will be changed to <b>true</b> after the underlying infrastructure supports it.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("PreserveClientIpEnabled")]
            [Validation(Required=false)]
            public bool? PreserveClientIpEnabled { get; set; }

            /// <summary>
            /// <para>The backend forwarding protocol. Valid values: <b>TCP</b> and <b>UDP</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TCP</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The region ID of the Network Load Balancer (NLB) load balancing instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The list of Network Load Balancer (NLB) load balancing instances.</para>
            /// </summary>
            [NameInMap("RelatedLoadBalancerIds")]
            [Validation(Required=false)]
            public List<string> RelatedLoadBalancerIds { get; set; }

            /// <summary>
            /// <para>The ID of the resource group to which the server group belongs.</para>
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
            /// <item><description><b>Wrr</b>: weighted round-robin. Backend servers with higher weights are polled more frequently.</description></item>
            /// <item><description><b>Wlc</b>: weighted least connections. In addition to polling based on the weight configured for each backend server, the actual load (number of connections) of the backend server is also considered. When the weights are the same, backend servers with fewer current connections are polled more frequently.</description></item>
            /// <item><description><b>rr</b>: round-robin. Requests are distributed to backend servers in access sequence.</description></item>
            /// <item><description><b>sch</b>: source IP hashing. Requests from the same source address are scheduled to the same backend server.</description></item>
            /// <item><description><b>tch</b>: four-element hashing. Consistent hashing based on four elements (source IP, destination IP address, source port, and destination port). Requests from the same flow are scheduled to the same backend server.</description></item>
            /// <item><description><b>qch</b>: QUIC ID hashing. Requests with the same QUIC ID are hashed to the same backend server.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Wrr</para>
            /// </summary>
            [NameInMap("Scheduler")]
            [Validation(Required=false)]
            public string Scheduler { get; set; }

            /// <summary>
            /// <para>The number of backend servers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ServerCount")]
            [Validation(Required=false)]
            public int? ServerCount { get; set; }

            /// <summary>
            /// <para>The server group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sgp-atstuj3rtoptyui****</para>
            /// </summary>
            [NameInMap("ServerGroupId")]
            [Validation(Required=false)]
            public string ServerGroupId { get; set; }

            /// <summary>
            /// <para>The server group name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NLB_ServerGroup</para>
            /// </summary>
            [NameInMap("ServerGroupName")]
            [Validation(Required=false)]
            public string ServerGroupName { get; set; }

            /// <summary>
            /// <para>The server group status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Creating</b>: The server group is being created.</description></item>
            /// <item><description><b>Available</b>: The server group is available.</description></item>
            /// <item><description><b>Configuring</b>: The server group is being modified.</description></item>
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
            /// <item><description><b>Instance</b>: server type. This type of server group supports adding <b>Ecs</b>, <b>Ens</b>, and <b>Eci</b> instances.</description></item>
            /// <item><description><b>Ip</b>: IP address type. This type of server group supports adding IP addresses directly.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Instance</para>
            /// </summary>
            [NameInMap("ServerGroupType")]
            [Validation(Required=false)]
            public string ServerGroupType { get; set; }

            /// <summary>
            /// <para>The tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListServerGroupsResponseBodyServerGroupsTags> Tags { get; set; }
            public class ListServerGroupsResponseBodyServerGroupsTags : TeaModel {
                /// <summary>
                /// <para>The tag key. You can specify up to 10 tag keys.</para>
                /// <para>The tag key can be up to 64 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value. You can specify up to 10 tag values.</para>
                /// <para>The tag value can be up to 128 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The ID of the VPC to which the server group belongs.</para>
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
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
