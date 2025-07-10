// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gwlb20240415.Models
{
    public class CreateServerGroupRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>request ID</b> as the <b>client token</b>. The <b>request ID</b> may be different for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The configurations of connection draining.</para>
        /// </summary>
        [NameInMap("ConnectionDrainConfig")]
        [Validation(Required=false)]
        public CreateServerGroupRequestConnectionDrainConfig ConnectionDrainConfig { get; set; }
        public class CreateServerGroupRequestConnectionDrainConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable connection draining. Valid values:</para>
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
            /// <para>Valid values: <b>1</b> to <b>3600</b>.</para>
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
        /// <para>Specifies whether to perform only a dry run without performing the actual request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs only a dry run. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and service limits. If the request fails the dry run, an error code is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): performs a dry run and performs the actual request. If the request passes the dry run, a 2xx HTTP status code is returned and the operation is performed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The health check configurations.</para>
        /// </summary>
        [NameInMap("HealthCheckConfig")]
        [Validation(Required=false)]
        public CreateServerGroupRequestHealthCheckConfig HealthCheckConfig { get; set; }
        public class CreateServerGroupRequestHealthCheckConfig : TeaModel {
            /// <summary>
            /// <para>The backend server port used for health checks.</para>
            /// <para>Valid values: <b>1</b> to <b>65535</b>.</para>
            /// <para>Default value: <b>80</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("HealthCheckConnectPort")]
            [Validation(Required=false)]
            public int? HealthCheckConnectPort { get; set; }

            /// <summary>
            /// <para>The maximum timeout period for a health check response.</para>
            /// <para>Unit: seconds.</para>
            /// <para>Valid values: <b>1</b> to <b>300</b>.</para>
            /// <para>Default value: <b>5</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("HealthCheckConnectTimeout")]
            [Validation(Required=false)]
            public int? HealthCheckConnectTimeout { get; set; }

            /// <summary>
            /// <para>The domain name used for health checks. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>$SERVER_IP</b> (default): the private IP address of a backend server.</description></item>
            /// <item><description><b>domain</b>: a domain name. The domain name must be 1 to 80 characters in length, and can contain letters, digits, hyphens (-), and periods (.).</description></item>
            /// </list>
            /// <remarks>
            /// <para> This parameter takes effect only if you set <b>HealthCheckProtocol</b> to <b>HTTP</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>$SERVER_IP</para>
            /// </summary>
            [NameInMap("HealthCheckDomain")]
            [Validation(Required=false)]
            public string HealthCheckDomain { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable health checks. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b> (default)</description></item>
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
            /// <para>Unit: seconds.</para>
            /// <para>Valid values: <b>1</b> to <b>50</b>.</para>
            /// <para>Default value: <b>10</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("HealthCheckInterval")]
            [Validation(Required=false)]
            public int? HealthCheckInterval { get; set; }

            /// <summary>
            /// <para>The path used for health checks.</para>
            /// <para>It must be 1 to 80 characters in length, and can contain letters, digits, hyphens (-), forward slashes (/), periods (.), percent signs (%), question marks (?), number signs (#), and ampersands (&amp;). The URL can also contain the following extended characters: _ ; ~ ! ( ) \* [ ] @ $ ^ : \&quot; , + =</para>
            /// <para>It must start with a forward slash (/).</para>
            /// <remarks>
            /// <para> This parameter takes effect only if you set <b>HealthCheckProtocol</b> to <b>HTTP</b>.</para>
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
            /// <item><description><b>TCP</b> (default): GWLB performs TCP health checks by sending SYN packets to a backend server to check whether the port of the backend server is available to receive requests.</description></item>
            /// <item><description><b>HTTP</b>: GWLB performs HTTP health checks to check whether backend servers are healthy by sending GET requests which simulate access from browsers.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TCP</para>
            /// </summary>
            [NameInMap("HealthCheckProtocol")]
            [Validation(Required=false)]
            public string HealthCheckProtocol { get; set; }

            /// <summary>
            /// <para>The number of times that an unhealthy backend server must consecutively pass health checks before it is declared healthy. In this case, the health check status of the backend server changes from <b>fail</b> to <b>success</b>.</para>
            /// <para>Valid values: <b>2</b> to <b>10</b>.</para>
            /// <para>Default value: <b>2</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("HealthyThreshold")]
            [Validation(Required=false)]
            public int? HealthyThreshold { get; set; }

            /// <summary>
            /// <para>The number of times that a healthy backend server must consecutively fail health checks before it is declared unhealthy. In this case, the health check status of the backend server changes from <b>success</b> to <b>fail</b>.</para>
            /// <para>Valid values: <b>2</b> to <b>10</b>.</para>
            /// <para>Default value: <b>2</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("UnhealthyThreshold")]
            [Validation(Required=false)]
            public int? UnhealthyThreshold { get; set; }

        }

        /// <summary>
        /// <para>The backend protocol. Valid value:</para>
        /// <list type="bullet">
        /// <item><description><b>GENEVE</b> (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>GENEVE</para>
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

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
        /// <item><description><b>5TCH</b> (default): specifies consistent hashing that is based on the following factors: source IP address, destination IP address, source port, protocol, and destination port. Requests that contain the same information based on the preceding factors are forwarded to the same backend server.</description></item>
        /// <item><description><b>3TCH</b>: specifies consistent hashing that is based on the following factors: source IP address, destination IP address, and protocol. Requests that contain the same information based on the preceding factors are forwarded to the same backend server.</description></item>
        /// <item><description><b>2TCH</b>: specifies consistent hashing that is based on the following factors: source IP address and destination IP address. Requests that contain the same information based on the preceding factors are forwarded to the same backend server.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>5TCH</para>
        /// </summary>
        [NameInMap("Scheduler")]
        [Validation(Required=false)]
        public string Scheduler { get; set; }

        /// <summary>
        /// <para>Specifies how GWLB processes requests over existing connections when a backend server is not running as expected. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>NoRebalance</b> (default): GWLB continues to forward requests over existing connections to the unavailable backend server.</description></item>
        /// <item><description><b>Rebalance</b>: GWLB forwards requests over existing connections to the remaining healthy backend servers.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NoRebalance</para>
        /// </summary>
        [NameInMap("ServerFailoverMode")]
        [Validation(Required=false)]
        public string ServerFailoverMode { get; set; }

        /// <summary>
        /// <para>The server group name.</para>
        /// <para>The name must be 2 to 128 characters in length, and can contain digits, periods (.), underscores (_), and hyphens (-). It must start with a letter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testServerGroupName</para>
        /// </summary>
        [NameInMap("ServerGroupName")]
        [Validation(Required=false)]
        public string ServerGroupName { get; set; }

        /// <summary>
        /// <para>The type of the server group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Instance</b> (default): allows you to specify resources of the <b>Ecs</b>, <b>Eni</b>, or <b>Eci</b> type.</description></item>
        /// <item><description><b>Ip</b>: allows you to add servers by specifying their IP addresses.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Instance</para>
        /// </summary>
        [NameInMap("ServerGroupType")]
        [Validation(Required=false)]
        public string ServerGroupType { get; set; }

        /// <summary>
        /// <para>The tag keys.</para>
        /// <para>You can specify at most 20 tags in each call.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateServerGroupRequestTag> Tag { get; set; }
        public class CreateServerGroupRequestTag : TeaModel {
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
        /// <remarks>
        /// <para>If <b>ServerGroupType</b> is set to <b>Instance</b>, only servers in the specified VPC can be added to the server group.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp15zckdt37pq72zv****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
