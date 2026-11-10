// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlb20220430.Models
{
    public class CreateServerGroupRequest : TeaModel {
        /// <summary>
        /// <para>The protocol version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ipv4</b> (default): IPv4.</para>
        /// </description></item>
        /// <item><description><para><b>DualStack</b>: dual-stack.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ipv4</para>
        /// </summary>
        [NameInMap("AddressIPVersion")]
        [Validation(Required=false)]
        public string AddressIPVersion { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable all-port forwarding. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: enables all-port forwarding.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): disables all-port forwarding.</para>
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
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the value, but you must ensure that it is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the API request as the <b>ClientToken</b>. The <b>RequestId</b> of each API request is unique.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable connection draining. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: enables connection draining.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): disables connection draining.</para>
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
        /// <para>The timeout period for connection draining. Unit: seconds.
        /// Valid values: <b>0</b> to <b>900</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("ConnectionDrainTimeout")]
        [Validation(Required=false)]
        public int? ConnectionDrainTimeout { get; set; }

        /// <summary>
        /// <para>Specifies whether to only precheck the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: prechecks the request without creating the server group. The system checks whether required parameters are specified, the request format, and service limits. If the request fails the precheck, the corresponding error is returned. If the request passes the precheck, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): sends the request. If the request passes the precheck, an HTTP 2xx status code is returned and the operation is performed.</description></item>
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
        /// </summary>
        [NameInMap("HealthCheckConfig")]
        [Validation(Required=false)]
        public CreateServerGroupRequestHealthCheckConfig HealthCheckConfig { get; set; }
        public class CreateServerGroupRequestHealthCheckConfig : TeaModel {
            /// <summary>
            /// <para>The port of the backend server used for health checks.</para>
            /// <para>Valid values: <b>0</b> to <b>65535</b>.</para>
            /// <para>Default value: <b>0</b>. This value indicates that the port of the backend server is used for health checks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("HealthCheckConnectPort")]
            [Validation(Required=false)]
            public int? HealthCheckConnectPort { get; set; }

            /// <summary>
            /// <para>The maximum timeout period for a health check response. Unit: seconds.
            /// Valid values: <b>1</b> to <b>300</b>.
            /// Default value: <b>5</b>.</para>
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
            /// <item><description><para><b>$SERVER_IP</b>: the internal IP address of the backend server.</para>
            /// </description></item>
            /// <item><description><para><b>domain</b>: a specified domain name. The domain name must be 1 to 80 characters in length, and can contain only letters, digits, hyphens (-), and periods (.).</para>
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
            /// <para>Specifies whether to enable health checks. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b> (default): enables health checks.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: disables health checks.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("HealthCheckEnabled")]
            [Validation(Required=false)]
            public bool? HealthCheckEnabled { get; set; }

            /// <summary>
            /// <para>The query string in the request for UDP listener health checks. The string can contain only letters and digits, and can be up to 512 characters in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ok</para>
            /// </summary>
            [NameInMap("HealthCheckExp")]
            [Validation(Required=false)]
            public string HealthCheckExp { get; set; }

            /// <summary>
            /// <para>The HTTP status codes for healthy responses. Separate multiple status codes with commas (,).
            /// Valid values: <b>http_2xx</b> (default), <b>http_3xx</b>, <b>http_4xx</b>, and <b>http_5xx</b>.</para>
            /// <remarks>
            /// <para>This parameter takes effect only when <b>HealthCheckType</b> is set to <b>HTTP</b>.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("HealthCheckHttpCode")]
            [Validation(Required=false)]
            public List<string> HealthCheckHttpCode { get; set; }

            /// <summary>
            /// <para>The HTTP protocol version for health checks. Valid values: <b>HTTP1.0</b> (default) and <b>HTTP1.1</b>.</para>
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
            /// <item><description>If <b>HealthCheckType</b> is set to <b>UDP</b>, valid values are <b>1</b> to <b>300</b>. You must set the interval to be greater than or equal to the response timeout period to ensure that UDP probe responses are not misjudged as unresponsive due to a timeout.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("HealthCheckInterval")]
            [Validation(Required=false)]
            public int? HealthCheckInterval { get; set; }

            /// <summary>
            /// <para>The query string in the request for UDP listener health checks. The string can contain only letters and digits, and can be up to 512 characters in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hello</para>
            /// </summary>
            [NameInMap("HealthCheckReq")]
            [Validation(Required=false)]
            public string HealthCheckReq { get; set; }

            /// <summary>
            /// <para>The protocol used for health checks. Valid values:</para>
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
            /// <para>The path must be 1 to 80 characters in length, and can contain only letters, digits, and the following special characters: <c>-/.%?#&amp;</c>. It must start with a forward slash (/).</para>
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
            /// <para>The number of consecutive successful health checks that must occur before the health check status of a backend server is changed from <b>fail</b> to <b>success</b>.</para>
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
            /// <para>The HTTP method used for health checks. Valid values: <b>GET</b> (default) and <b>HEAD</b>.</para>
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
            /// <para>The number of consecutive failed health checks that must occur before the health check status of a backend server is changed from <b>success</b> to <b>fail</b>.</para>
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
        /// <para>The traffic scheduling policy in dual-stack mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NonAffinity (default): non-affinity mode. Traffic is forwarded to healthy backend servers based on the scheduling algorithm regardless of the IP protocol version of the source.</description></item>
        /// <item><description>Affinity: affinity mode. Traffic is forwarded based on the IP protocol version of the request source. IPv4 requests are forwarded only to IPv4 backend servers, and IPv6 requests are forwarded only to IPv6 backend servers.<remarks>
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
        /// <para>Specifies whether to enable client IP address preservation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b> (default): enables client IP address preservation.</description></item>
        /// <item><description><b>false</b>: disables client IP address preservation.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If <b>Protocol</b> is set to <b>TCP</b> and this parameter is set to <b>true</b>, the server group cannot be associated with <b>TCPSSL</b> listeners.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>false</c>
        /// </summary>
        [NameInMap("PreserveClientIpEnabled")]
        [Validation(Required=false)]
        public bool? PreserveClientIpEnabled { get; set; }

        /// <summary>
        /// <para>The communication protocol used to forward traffic to backend servers. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>TCP</b> (default)</description></item>
        /// <item><description><b>UDP</b></description></item>
        /// <item><description><b>TCP_UDP</b><remarks>
        /// <list type="bullet">
        /// <item><description>If this parameter is set to <b>UDP</b>, the server group can be associated only with <b>UDP</b> listeners.</description></item>
        /// <item><description>If this parameter is set to <b>TCP</b> and <b>PreserveClientIpEnabled</b> is set to <b>true</b>, the server group can be associated only with <b>TCP</b> listeners.</description></item>
        /// <item><description>If this parameter is set to <b>TCP</b> and <b>PreserveClientIpEnabled</b> is set to <b>false</b>, the server group can be associated with <b>TCPSSL</b> and <b>TCP</b> listeners.</description></item>
        /// <item><description>If this parameter is set to <b>TCP_UDP</b>, the server group can be associated with <b>TCP</b> and <b>UDP</b> listeners.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>TCP</para>
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <para>The region ID of the Network Load Balancer (NLB) instance. </para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/443657.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

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
        /// <item><description><para><b>Wrr</b> (default): weighted round-robin. Backend servers with higher weights are more likely to be polled.</para>
        /// </description></item>
        /// <item><description><para><b>Wlc</b>: weighted least connections. In addition to the weight of each backend server, the actual load (number of connections) of the backend server is also considered. If the weights are the same, backend servers with fewer current connections are more likely to be polled.</para>
        /// </description></item>
        /// <item><description><para><b>rr</b>: round-robin. External requests are distributed to backend servers in sequence.</para>
        /// </description></item>
        /// <item><description><para><b>sch</b>: source IP hash. Requests from the same source IP address are scheduled to the same backend server.</para>
        /// </description></item>
        /// <item><description><para><b>tch</b>: 4-tuple hash. Consistent hashing based on the 4-tuple (source IP address, destination IP address, source port, and destination port). Requests from the same flow are scheduled to the same backend server.</para>
        /// </description></item>
        /// <item><description><para><b>qch</b>: QUIC ID hash. Requests with the same QUIC ID are scheduled to the same backend server.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>QUIC ID hash is supported only when the backend protocol is UDP.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Wrr</para>
        /// </summary>
        [NameInMap("Scheduler")]
        [Validation(Required=false)]
        public string Scheduler { get; set; }

        /// <summary>
        /// <para>The name of the server group.</para>
        /// <para>The name must be 2 to 128 characters in length, and must start with a letter or Chinese character. It can contain digits, periods (.), underscores (_), and hyphens (-).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NLB_ServerGroup</para>
        /// </summary>
        [NameInMap("ServerGroupName")]
        [Validation(Required=false)]
        public string ServerGroupName { get; set; }

        /// <summary>
        /// <para>The server group type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Instance</b> (default): server type. This type of server group supports adding <b>Ecs</b>, <b>Eni</b>, and <b>Eci</b> instances.</para>
        /// </description></item>
        /// <item><description><para><b>Ip</b>: IP address type. This type of server group supports directly adding backend servers by IP address.</para>
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
        /// <para>The list of tags.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateServerGroupRequestTag> Tag { get; set; }
        public class CreateServerGroupRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. The tag key can be up to 64 characters in length, and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>. It can contain letters, digits, underscores (_), periods (.), colons (:), forward slashes (/), equal signs (=), plus signs (+), hyphens (-), and at signs (@).</para>
            /// <para>You can add up to 20 tags in a single call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>env</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. The tag value can be up to 128 characters in length, and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>. It can contain letters, digits, underscores (_), periods (.), colons (:), forward slashes (/), equal signs (=), plus signs (+), hyphens (-), and at signs (@).</para>
            /// <para>You can add up to 20 tags in a single call.</para>
            /// 
            /// <b>Example:</b>
            /// <para>product</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the VPC where the server group is deployed.</para>
        /// <remarks>
        /// <para>If <b>ServerGroupType</b> is set to <b>Instance</b>, only servers in this VPC can be added to the server group.</para>
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
