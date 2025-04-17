// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gwlb20240415.Models
{
    public class ListServerGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of entries per page.</para>
        /// <para>Valid values: 1 to 1000.</para>
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
        /// <item><description>If a value of <b>NextToken</b> is returned, the value indicates the token that is used for the next query.</description></item>
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
        /// <para>54B48E3D-DF70-471B-AA93-08E683A1B45</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The configurations of the server group.</para>
        /// </summary>
        [NameInMap("ServerGroups")]
        [Validation(Required=false)]
        public List<ListServerGroupsResponseBodyServerGroups> ServerGroups { get; set; }
        public class ListServerGroupsResponseBodyServerGroups : TeaModel {
            /// <summary>
            /// <para>The configurations of connection draining.</para>
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
                /// <para>Unit: seconds</para>
                /// <para>Valid values: 1 to 3600.</para>
                /// 
                /// <b>Example:</b>
                /// <para>300</para>
                /// </summary>
                [NameInMap("ConnectionDrainTimeout")]
                [Validation(Required=false)]
                public int? ConnectionDrainTimeout { get; set; }

            }

            /// <summary>
            /// <para>The time when the resource was created. The time follows the ISO 8601 standard in the <b>yyyy-MM-ddTHH:mm:ssZ</b> format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-08-05T18:24:07Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The configuration of health checks.</para>
            /// </summary>
            [NameInMap("HealthCheckConfig")]
            [Validation(Required=false)]
            public ListServerGroupsResponseBodyServerGroupsHealthCheckConfig HealthCheckConfig { get; set; }
            public class ListServerGroupsResponseBodyServerGroupsHealthCheckConfig : TeaModel {
                /// <summary>
                /// <para>The backend server port that is used for health checks.</para>
                /// <para>Valid values: <b>1</b> to <b>65535</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>80</para>
                /// </summary>
                [NameInMap("HealthCheckConnectPort")]
                [Validation(Required=false)]
                public int? HealthCheckConnectPort { get; set; }

                /// <summary>
                /// <para>The maximum timeout period of a health check.</para>
                /// <para>Unit: seconds</para>
                /// <para>Valid values: <b>1</b> to <b>300</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("HealthCheckConnectTimeout")]
                [Validation(Required=false)]
                public int? HealthCheckConnectTimeout { get; set; }

                /// <summary>
                /// <para>The domain name that is used for health checks. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>$SERVER_IP</b>: the internal IP address of a backend server.</description></item>
                /// <item><description><b>domain</b>: a domain name. The domain name must be 1 to 80 characters in length, and can contain letters, digits, hyphens (-), and periods (.).</description></item>
                /// </list>
                /// <remarks>
                /// <para>This parameter takes effect only if you set <b>HealthCheckProtocol</b> to <b>HTTP</b>.</para>
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
                /// <para>true</para>
                /// </summary>
                [NameInMap("HealthCheckEnabled")]
                [Validation(Required=false)]
                public bool? HealthCheckEnabled { get; set; }

                /// <summary>
                /// <para>The HTTP status codes that the system returns for health checks.</para>
                /// </summary>
                [NameInMap("HealthCheckHttpCode")]
                [Validation(Required=false)]
                public List<string> HealthCheckHttpCode { get; set; }

                /// <summary>
                /// <para>The interval at which health checks are performed.</para>
                /// <para>Unit: seconds</para>
                /// <para>Valid values: <b>1</b> to <b>50</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("HealthCheckInterval")]
                [Validation(Required=false)]
                public int? HealthCheckInterval { get; set; }

                /// <summary>
                /// <para>The URL that is used for health checks.</para>
                /// <para>The URL must be 1 to 80 characters in length, and can contain letters, digits, and the following special characters: <c>- / . % ? # &amp; </c>The URL must start with a forward slash (/).</para>
                /// <remarks>
                /// <para>This parameter takes effect only if you set <b>HealthCheckProtocol</b> to <b>HTTP</b>.</para>
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
                /// <item><description><b>TCP</b>: TCP health checks send TCP SYN packets to a backend server to check whether the port of the backend server is reachable.</description></item>
                /// <item><description><b>HTTP</b>: HTTP health checks simulate a process that uses a web browser to access resources by sending HEAD or GET requests to an instance. These requests are used to check whether the instance is healthy.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>TCP</para>
                /// </summary>
                [NameInMap("HealthCheckProtocol")]
                [Validation(Required=false)]
                public string HealthCheckProtocol { get; set; }

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
                /// <para>The number of times that a healthy backend server must consecutively fail health checks before it is declared unhealthy. In this case, the health status changes from <b>success</b> to <b>fail</b>.</para>
                /// <para>Valid values: <b>2</b> to <b>10</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("UnhealthyThreshold")]
                [Validation(Required=false)]
                public int? UnhealthyThreshold { get; set; }

            }

            /// <summary>
            /// <para>The backend protocol. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>GENEVE</b>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>GENEVE</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            /// <summary>
            /// <para>The IDs of the GWLB instances that are associated with the server group.</para>
            /// </summary>
            [NameInMap("RelatedLoadBalancerIds")]
            [Validation(Required=false)]
            public List<string> RelatedLoadBalancerIds { get; set; }

            /// <summary>
            /// <para>The resource group ID.</para>
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
            /// <item><description><b>5TCH</b>: indicates consistent hashing that is based on the following factors: source IP address, destination IP address, source port, protocol, and destination port. Requests that contain the same information based on the preceding factors are forwarded to the same backend server.</description></item>
            /// <item><description><b>3TCH</b>: indicates consistent hashing that is based on the following factors: source IP address, destination IP address, and protocol. Requests that contain the same information based on the preceding factors are forwarded to the same backend server.</description></item>
            /// <item><description><b>2TCH</b>: indicates consistent hashing that is based on the following factors: source IP address and destination IP address. Requests that contain the same information based on the preceding factors are forwarded to the same backend server.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>5TCH</para>
            /// </summary>
            [NameInMap("Scheduler")]
            [Validation(Required=false)]
            public string Scheduler { get; set; }

            /// <summary>
            /// <para>The number of server groups.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ServerCount")]
            [Validation(Required=false)]
            public int? ServerCount { get; set; }

            [NameInMap("ServerFailoverMode")]
            [Validation(Required=false)]
            public string ServerFailoverMode { get; set; }

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
            /// <para>testServerGroupName</para>
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
            /// <para>The server group type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Instance</b>: allows you to specify servers of the <b>Ecs</b>, <b>Eni</b>, or <b>Eci</b> type.</description></item>
            /// <item><description><b>Ip</b>: allows you to add servers of by specifying IP addresses.</description></item>
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
                /// <para>The tag key. The tag key cannot be an empty string. The tag key can be up to 128 characters in length, and cannot start with <c>acs:</c> or <c>aliyun</c>. The tag key cannot contain <c>http://</c> or <c>https://</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testTagKey</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value. The tag value can be up to 256 characters in length and cannot contain <c>http://</c> or <c>https://</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testTagValue</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The VPC ID.</para>
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
