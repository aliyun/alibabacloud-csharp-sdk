// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlb20220430.Models
{
    public class UpdateServerGroupAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The IP version. Valid values: <b>ipv4</b> and <b>dualStack</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ipv4</para>
        /// </summary>
        [NameInMap("AddressIPVersion")]
        [Validation(Required=false)]
        public string AddressIPVersion { get; set; }

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
        /// <item><description><para><b>true</b>: Enables connection draining.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Disables connection draining.</para>
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
        /// <para>The timeout period for connection draining. Unit: seconds. Valid values: <b>0</b> to <b>900</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("ConnectionDrainTimeout")]
        [Validation(Required=false)]
        public int? ConnectionDrainTimeout { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs a dry run without updating the server group. The system checks whether required parameters are specified, the request format is valid, and the service limits are met. If the request fails the dry run, an error message is returned. If the request passes the dry run, the DryRunOperation error code is returned.</description></item>
        /// <item><description><b>false</b> (default): performs a dry run and sends the actual request. If the request passes the dry run, an HTTP 2xx status code is returned and the operation is performed.</description></item>
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
        /// </summary>
        [NameInMap("HealthCheckConfig")]
        [Validation(Required=false)]
        public UpdateServerGroupAttributeRequestHealthCheckConfig HealthCheckConfig { get; set; }
        public class UpdateServerGroupAttributeRequestHealthCheckConfig : TeaModel {
            /// <summary>
            /// <para>The port used for health checks on backend servers. Valid values: <b>0</b> to <b>65535</b>. A value of <b>0</b> indicates that the port of the backend server is used for health checks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("HealthCheckConnectPort")]
            [Validation(Required=false)]
            public int? HealthCheckConnectPort { get; set; }

            /// <summary>
            /// <para>The maximum timeout period for a health check response. Unit: seconds. Valid values: <b>1</b> to <b>300</b>. Default value: <b>5</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("HealthCheckConnectTimeout")]
            [Validation(Required=false)]
            public int? HealthCheckConnectTimeout { get; set; }

            /// <summary>
            /// <para>The domain name used for health checks. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>$SERVER_IP</b>: the internal IP address of the backend server.</description></item>
            /// <item><description><b>domain</b>: a custom domain name. The domain name must be 1 to 80 characters in length, and can contain only lowercase letters, digits, hyphens (-), and periods (.).</description></item>
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
            /// <item><description><para><b>true</b>: Enables health checks.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Disables health checks.</para>
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
            /// <para>The response string used for UDP health checks. The string can contain only letters and digits, and can be up to 512 characters in length.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ok</para>
            /// </summary>
            [NameInMap("HealthCheckExp")]
            [Validation(Required=false)]
            public string HealthCheckExp { get; set; }

            /// <summary>
            /// <para>The HTTP status codes that indicate a successful health check. Separate multiple HTTP status codes with commas (,). Valid values: <b>http_2xx</b> (default), <b>http_3xx</b>, <b>http_4xx</b>, and <b>http_5xx</b>.</para>
            /// <remarks>
            /// <para>This parameter takes effect only when <b>HealthCheckType</b> is set to <b>HTTP</b>.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("HealthCheckHttpCode")]
            [Validation(Required=false)]
            public List<string> HealthCheckHttpCode { get; set; }

            /// <summary>
            /// <para>The HTTP version used for health checks. Valid values: <b>HTTP1.0</b> and <b>HTTP1.1</b>.</para>
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
            /// <item><description><para>If <b>HealthCheckType</b> is set to <b>TCP</b> or <b>HTTP</b>, valid values are <b>1</b> to <b>50</b>.</para>
            /// </description></item>
            /// <item><description><para>If <b>HealthCheckType</b> is set to <b>UDP</b>, valid values are <b>1</b> to <b>300</b>. You must set the interval to a value greater than or equal to the response timeout period to ensure that UDP probe responses are not mistakenly identified as timeouts.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("HealthCheckInterval")]
            [Validation(Required=false)]
            public int? HealthCheckInterval { get; set; }

            /// <summary>
            /// <para>The request string used for UDP health checks. The string can contain only letters and digits, and can be up to 512 characters in length.</para>
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
            /// <para>The path must be 1 to 80 characters in length. It can contain only letters, digits, the characters <c>-/.%?#&amp;=</c>, and extension characters <c>_;~!()*[]@$^:\\&quot;,+</c>. It must start with a forward slash (/).</para>
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
            /// <para>The number of consecutive successful health checks required to change the health status of a backend server from <b>Failed</b> to <b>Success</b>. Valid values: <b>2</b> to <b>10</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("HealthyThreshold")]
            [Validation(Required=false)]
            public int? HealthyThreshold { get; set; }

            /// <summary>
            /// <para>The HTTP method used for health checks. Valid values: <b>GET</b> and <b>HEAD</b>.</para>
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
            /// <para>The number of consecutive failed health checks required to change the health status of a backend server from <b>Success</b> to <b>Failed</b>. Valid values: <b>2</b> to <b>10</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("UnhealthyThreshold")]
            [Validation(Required=false)]
            public int? UnhealthyThreshold { get; set; }

        }

        /// <summary>
        /// <para>The traffic scheduling policy in dual-stack mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>NonAffinity</b>: non-affinity mode. Requests are forwarded to healthy backend servers based on the scheduling algorithm regardless of the IP version of the source address. This is the default value.</description></item>
        /// <item><description><b>Affinity</b>: affinity mode. Requests are forwarded to backend servers based on the IP version of the source address. IPv4 requests are forwarded only to IPv4 backend servers, and IPv6 requests are forwarded only to IPv6 backend servers.<remarks>
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
        /// <para>Specifies whether to enable client IP preservation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Enables client IP preservation.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Disables client IP preservation.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If <b>PreserveClientIpEnabled</b> is set to <b>false</b> and the server group is associated with a <b>TCPSSL</b> listener, you cannot change the value of this parameter to <b>true</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("PreserveClientIpEnabled")]
        [Validation(Required=false)]
        public bool? PreserveClientIpEnabled { get; set; }

        /// <summary>
        /// <para>The region ID of the network load balancing instance.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/443657.html">DescribeRegions</a> operation to obtain the region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The scheduling algorithm. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Wrr</b>: weighted round-robin. Backend servers with higher weights receive more requests.</para>
        /// </description></item>
        /// <item><description><para><b>Wlc</b>: weighted least connections. Requests are distributed based on the weights and actual loads (number of connections) of backend servers. If weights are the same, backend servers with fewer connections receive more requests.</para>
        /// </description></item>
        /// <item><description><para><b>rr</b>: round-robin. Requests are distributed to backend servers in sequence.</para>
        /// </description></item>
        /// <item><description><para><b>sch</b>: source IP hash. Requests from the same source IP address are distributed to the same backend server.</para>
        /// </description></item>
        /// <item><description><para><b>tch</b>: 4-tuple hash. Consistent hashing based on the 4-tuple (source IP address, destination IP address, source port, and destination port). Requests from the same flow are distributed to the same backend server.</para>
        /// </description></item>
        /// <item><description><para><b>qch</b>: QUIC ID hash. Requests with the same QUIC ID are distributed to the same backend server.</para>
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
        /// <para>The ID of the server group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sgp-atstuj3rtoptyui****</para>
        /// </summary>
        [NameInMap("ServerGroupId")]
        [Validation(Required=false)]
        public string ServerGroupId { get; set; }

        /// <summary>
        /// <para>The new name of the server group.</para>
        /// <para>The name must be 2 to 128 characters in length, and must start with a letter or Chinese character. It can contain digits, periods (.), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>NLB_ServerGroup1</para>
        /// </summary>
        [NameInMap("ServerGroupName")]
        [Validation(Required=false)]
        public string ServerGroupName { get; set; }

    }

}
