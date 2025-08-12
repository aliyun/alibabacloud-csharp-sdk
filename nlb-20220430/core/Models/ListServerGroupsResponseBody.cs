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
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, no next page exists.</description></item>
        /// <item><description>If a value is returned for <b>NextToken</b>, the value is the token that determines the start point of the next query.</description></item>
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
        /// <para>A list of server groups.</para>
        /// </summary>
        [NameInMap("ServerGroups")]
        [Validation(Required=false)]
        public List<ListServerGroupsResponseBodyServerGroups> ServerGroups { get; set; }
        public class ListServerGroupsResponseBodyServerGroups : TeaModel {
            /// <summary>
            /// <para>The IP version. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ipv4</b></description></item>
            /// <item><description><b>DualStack</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ipv4</para>
            /// </summary>
            [NameInMap("AddressIPVersion")]
            [Validation(Required=false)]
            public string AddressIPVersion { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>165820696622****</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <para>Indicates whether the feature of forwarding requests to all ports is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
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
            /// <para>The timeout period of connection draining. Unit: seconds. Valid values: <b>10</b> to <b>900</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("ConnectionDrainTimeout")]
            [Validation(Required=false)]
            public int? ConnectionDrainTimeout { get; set; }

            /// <summary>
            /// <para>The configurations of health checks.</para>
            /// </summary>
            [NameInMap("HealthCheck")]
            [Validation(Required=false)]
            public ListServerGroupsResponseBodyServerGroupsHealthCheck HealthCheck { get; set; }
            public class ListServerGroupsResponseBodyServerGroupsHealthCheck : TeaModel {
                /// <summary>
                /// <para>The backend port that is used for health checks.</para>
                /// <para>Valid values: <b>0</b> to <b>65535</b>.</para>
                /// <para>A value of <b>0</b> indicates that the port on a backend server is used for health checks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("HealthCheckConnectPort")]
                [Validation(Required=false)]
                public int? HealthCheckConnectPort { get; set; }

                /// <summary>
                /// <para>The maximum timeout period of a health check response. Unit: seconds. Default value: <b>5</b>.</para>
                /// <para>Valid values: <b>1</b> to <b>300</b></para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("HealthCheckConnectTimeout")]
                [Validation(Required=false)]
                public int? HealthCheckConnectTimeout { get; set; }

                /// <summary>
                /// <para>The domain name that you want to use for health checks. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>$SERVER_IP</b>: the private IP address of a backend server.</description></item>
                /// <item><description><b>domain</b>: a specified domain name. The domain name must be 1 to 80 characters in length, and can contain lowercase letters, digits, hyphens (-), and periods (.).</description></item>
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
                /// <para>Indicates whether the health check feature is enabled. Valid values:</para>
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
                /// <para>The HTTP status codes returned for health checks. Multiple HTTP status codes are separated by commas (,). Valid values: <b>http_2xx</b>, <b>http_3xx</b>, <b>http_4xx</b>, and <b>http_5xx</b>.</para>
                /// <remarks>
                /// <para>This parameter takes effect only when <b>HealthCheckType</b> is set to <b>HTTP</b>.</para>
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
                /// <para>200</para>
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
                /// <para>The number of times that an unhealthy backend server must consecutively pass health checks before it is declared healthy. In this case, the health status changes from <b>fail</b> to <b>success</b>.</para>
                /// <para>Valid values: <b>2</b> to <b>10</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("HealthyThreshold")]
                [Validation(Required=false)]
                public int? HealthyThreshold { get; set; }

                /// <summary>
                /// <para>The HTTP method that is used for health checks. Valid values: <b>GET</b> and <b>HEAD</b>.</para>
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
                /// <para>The number of times that a healthy backend server must consecutively fail health checks before it is declared unhealthy. In this case, the health status changes from <b>success</b> to <b>fail</b>.</para>
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
            /// <para>Indicates whether client IP preservation is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is set to <b>true</b> by default when <b>AddressIPVersion</b> is set to <b>ipv4</b>. This parameter is set to <b>false</b> when <b>AddressIPVersion</b> is set to <b>ipv6</b>. <b>true</b> will be supported by later versions.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("PreserveClientIpEnabled")]
            [Validation(Required=false)]
            public bool? PreserveClientIpEnabled { get; set; }

            /// <summary>
            /// <para>The backend protocol. Valid values: <b>TCP</b> and <b>UDP</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TCP</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The region ID of the NLB instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The NLB instances.</para>
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
            /// <para>The routing algorithm. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Wrr</b>: Backend servers with higher weights receive more requests than backend servers with lower weights.</description></item>
            /// <item><description><b>rr</b>: Requests are forwarded to the backend servers in sequence. sch: Requests are forwarded to the backend servers based on source IP address hashing.</description></item>
            /// <item><description><b>sch</b>: Requests from the same source IP address are forwarded to the same backend server.</description></item>
            /// <item><description><b>tch</b>: Four-element hashing, which specifies consistent hashing that is based on four factors: source IP address, destination IP address, source port, and destination port. Requests that contain the same information based on the four factors are forwarded to the same backend server.</description></item>
            /// <item><description><b>qch</b>: QUIC ID hashing. Requests that contain the same QUIC ID are forwarded to the same backend server.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Wrr</para>
            /// </summary>
            [NameInMap("Scheduler")]
            [Validation(Required=false)]
            public string Scheduler { get; set; }

            /// <summary>
            /// <para>The number of server groups associated with the NLB instances.</para>
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
            /// <para>The status of the server group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Creating</b></description></item>
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
            /// <para>The type of server group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Instance</b> : contains servers of the <b>Ecs</b>, <b>Ens</b>, and <b>Eci</b> types.</description></item>
            /// <item><description><b>Ip</b>: contains servers specified by IP addresses.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Instance</para>
            /// </summary>
            [NameInMap("ServerGroupType")]
            [Validation(Required=false)]
            public string ServerGroupType { get; set; }

            /// <summary>
            /// <para>The tag.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListServerGroupsResponseBodyServerGroupsTags> Tags { get; set; }
            public class ListServerGroupsResponseBodyServerGroupsTags : TeaModel {
                /// <summary>
                /// <para>The tag key. At most 10 tag keys are returned.</para>
                /// <para>The tag key can be up to 64 characters in length, and cannot contain <c>http://</c> or <c>https://</c>. It cannot start with <c>aliyun</c> or <c>acs:</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value. At most 10 tag values are returned.</para>
                /// <para>The tag value can be up to 128 characters in length, and cannot contain <c>http://</c> or <c>https://</c>. It cannot start with <c>aliyun</c> or <c>acs:</c>.</para>
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
