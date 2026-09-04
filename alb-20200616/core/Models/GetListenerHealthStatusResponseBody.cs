// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class GetListenerHealthStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The health check status list of server groups associated with the listener.</para>
        /// </summary>
        [NameInMap("ListenerHealthStatus")]
        [Validation(Required=false)]
        public List<GetListenerHealthStatusResponseBodyListenerHealthStatus> ListenerHealthStatus { get; set; }
        public class GetListenerHealthStatusResponseBodyListenerHealthStatus : TeaModel {
            /// <summary>
            /// <para>The listener ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lsn-o4u54y73wq7b******</para>
            /// </summary>
            [NameInMap("ListenerId")]
            [Validation(Required=false)]
            public string ListenerId { get; set; }

            /// <summary>
            /// <para>The listener port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("ListenerPort")]
            [Validation(Required=false)]
            public int? ListenerPort { get; set; }

            /// <summary>
            /// <para>The listener protocol.</para>
            /// 
            /// <b>Example:</b>
            /// <para>http</para>
            /// </summary>
            [NameInMap("ListenerProtocol")]
            [Validation(Required=false)]
            public string ListenerProtocol { get; set; }

            /// <summary>
            /// <para>The server group information.</para>
            /// </summary>
            [NameInMap("ServerGroupInfos")]
            [Validation(Required=false)]
            public List<GetListenerHealthStatusResponseBodyListenerHealthStatusServerGroupInfos> ServerGroupInfos { get; set; }
            public class GetListenerHealthStatusResponseBodyListenerHealthStatusServerGroupInfos : TeaModel {
                /// <summary>
                /// <para>The server group usage type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>ForwardGroup</b>: Forward to the server group.</description></item>
                /// <item><description><b>TrafficMirror</b>: Mirror traffic to the server group.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>TrafficMirror</para>
                /// </summary>
                [NameInMap("ActionType")]
                [Validation(Required=false)]
                public string ActionType { get; set; }

                /// <summary>
                /// <para>The health check status. Valid values: <b>on</b>: Health check is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("HealthCheckEnabled")]
                [Validation(Required=false)]
                public string HealthCheckEnabled { get; set; }

                /// <summary>
                /// <para>The list of backend servers in abnormal state.</para>
                /// </summary>
                [NameInMap("NonNormalServers")]
                [Validation(Required=false)]
                public List<GetListenerHealthStatusResponseBodyListenerHealthStatusServerGroupInfosNonNormalServers> NonNormalServers { get; set; }
                public class GetListenerHealthStatusResponseBodyListenerHealthStatusServerGroupInfosNonNormalServers : TeaModel {
                    /// <summary>
                    /// <para>The backend server port.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>90</para>
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    /// <summary>
                    /// <para>The reason for the abnormal state.</para>
                    /// </summary>
                    [NameInMap("Reason")]
                    [Validation(Required=false)]
                    public GetListenerHealthStatusResponseBodyListenerHealthStatusServerGroupInfosNonNormalServersReason Reason { get; set; }
                    public class GetListenerHealthStatusResponseBodyListenerHealthStatusServerGroupInfosNonNormalServersReason : TeaModel {
                        /// <summary>
                        /// <para>The actual response code returned by the backend server, such as <b>302</b>.</para>
                        /// <remarks>
                        /// <para>This value is returned only when <b>ReasonCode</b> is <b>RESPONSE_MISMATCH</b>.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>302</para>
                        /// </summary>
                        [NameInMap("ActualResponse")]
                        [Validation(Required=false)]
                        public string ActualResponse { get; set; }

                        /// <summary>
                        /// <para>The expected response code from the backend server.</para>
                        /// <para>Valid values: <b>HTTP_2xx</b>, <b>HTTP_3xx</b>, <b>HTTP_4xx</b>, and <b>HTTP_5xx</b>. Multiple response codes are separated by commas (,).</para>
                        /// <remarks>
                        /// <para>This value is returned only when <b>ReasonCode</b> is <b>RESPONSE_MISMATCH</b>.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>HTTP_2xx</para>
                        /// </summary>
                        [NameInMap("ExpectedResponse")]
                        [Validation(Required=false)]
                        public string ExpectedResponse { get; set; }

                        /// <summary>
                        /// <para>The detailed reason when <b>Status</b> is abnormal.
                        /// Currently, only HTTP and HTTPS listeners and forwarding rules support viewing abnormal status reasons:</para>
                        /// <list type="bullet">
                        /// <item><description><para><b>CONNECT_TIMEOUT</b>: The Server Load Balancer (SLB) health check timed out when establishing a connection to the backend server.</para>
                        /// </description></item>
                        /// <item><description><para><b>CONNECT_FAILED</b>: The SLB health check failed to establish a connection to the backend server.</para>
                        /// </description></item>
                        /// <item><description><para><b>RECV_RESPONSE_FAILED</b>: The SLB health check failed to receive a response from the backend server.</para>
                        /// </description></item>
                        /// <item><description><para><b>RECV_RESPONSE_TIMEOUT</b>: The SLB health check timed out when receiving a response from the backend server.</para>
                        /// </description></item>
                        /// <item><description><para><b>SEND_REQUEST_FAILED</b>: The SLB health check failed to send a request to the backend server.</para>
                        /// </description></item>
                        /// <item><description><para><b>SEND_REQUEST_TIMEOUT</b>: The SLB health check timed out when sending a request to the backend server.</para>
                        /// </description></item>
                        /// <item><description><para><b>RESPONSE_FORMAT_ERROR</b>: The SLB health check received a response in an incorrect format from the backend server.</para>
                        /// </description></item>
                        /// <item><description><para><b>RESPONSE_MISMATCH</b>: The response code received from the backend server during the SLB health check did not match the expected response code.</para>
                        /// </description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>RESPONSE_MISMATCH</para>
                        /// </summary>
                        [NameInMap("ReasonCode")]
                        [Validation(Required=false)]
                        public string ReasonCode { get; set; }

                    }

                    /// <summary>
                    /// <para>The backend server ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>i-uf62h8v******</para>
                    /// </summary>
                    [NameInMap("ServerId")]
                    [Validation(Required=false)]
                    public string ServerId { get; set; }

                    /// <summary>
                    /// <para>The backend server IP address.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>192.168.8.10</para>
                    /// </summary>
                    [NameInMap("ServerIp")]
                    [Validation(Required=false)]
                    public string ServerIp { get; set; }

                    /// <summary>
                    /// <para>The health check status. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>Initial</b>: Initializing. The SLB instance has health check configured, but no data is available.</para>
                    /// </description></item>
                    /// <item><description><para><b>Unhealthy</b>: Unhealthy. The backend server has continuously reported an unhealthy state.</para>
                    /// </description></item>
                    /// <item><description><para><b>Unused</b>: Not in use. The weight of the backend server is 0, or cross-zone load balancing is disabled and the backend server is not in the same zone as the Application Load Balancer (ALB) instance.</para>
                    /// </description></item>
                    /// <item><description><para><b>Unavailable</b>: Not enabled. Health check is not enabled.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Initial</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

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
                /// <para>The associated server group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sgp-8ilqs4axp6******</para>
                /// </summary>
                [NameInMap("ServerGroupId")]
                [Validation(Required=false)]
                public string ServerGroupId { get; set; }

            }

        }

        /// <summary>
        /// <para>Indicates whether a next query token exists. Valid values:</para>
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
        /// <para>CEF72CEB-54B6-4AE8-B225-F876F******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The health status list of forwarding rules.</para>
        /// </summary>
        [NameInMap("RuleHealthStatus")]
        [Validation(Required=false)]
        public List<GetListenerHealthStatusResponseBodyRuleHealthStatus> RuleHealthStatus { get; set; }
        public class GetListenerHealthStatusResponseBodyRuleHealthStatus : TeaModel {
            /// <summary>
            /// <para>The forwarding rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rule-hp34s2h0xx1ht4nwo****</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// <para>The list of server groups.</para>
            /// </summary>
            [NameInMap("ServerGroupInfos")]
            [Validation(Required=false)]
            public List<GetListenerHealthStatusResponseBodyRuleHealthStatusServerGroupInfos> ServerGroupInfos { get; set; }
            public class GetListenerHealthStatusResponseBodyRuleHealthStatusServerGroupInfos : TeaModel {
                /// <summary>
                /// <para>The server group usage type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TrafficMirror</para>
                /// </summary>
                [NameInMap("ActionType")]
                [Validation(Required=false)]
                public string ActionType { get; set; }

                /// <summary>
                /// <para>The health check status. Valid values: <b>on</b>: Health check is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("HealthCheckEnabled")]
                [Validation(Required=false)]
                public string HealthCheckEnabled { get; set; }

                /// <summary>
                /// <para>The list of backend servers in abnormal state.</para>
                /// </summary>
                [NameInMap("NonNormalServers")]
                [Validation(Required=false)]
                public List<GetListenerHealthStatusResponseBodyRuleHealthStatusServerGroupInfosNonNormalServers> NonNormalServers { get; set; }
                public class GetListenerHealthStatusResponseBodyRuleHealthStatusServerGroupInfosNonNormalServers : TeaModel {
                    /// <summary>
                    /// <para>The backend server port.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>90</para>
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    /// <summary>
                    /// <para>The reason for the abnormal state.</para>
                    /// </summary>
                    [NameInMap("Reason")]
                    [Validation(Required=false)]
                    public GetListenerHealthStatusResponseBodyRuleHealthStatusServerGroupInfosNonNormalServersReason Reason { get; set; }
                    public class GetListenerHealthStatusResponseBodyRuleHealthStatusServerGroupInfosNonNormalServersReason : TeaModel {
                        /// <summary>
                        /// <para>The actual response code returned by the backend server, such as <b>302</b>.</para>
                        /// <remarks>
                        /// <para>This value is returned only when <b>ReasonCode</b> is <b>RESPONSE_MISMATCH</b>.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>302</para>
                        /// </summary>
                        [NameInMap("ActualResponse")]
                        [Validation(Required=false)]
                        public string ActualResponse { get; set; }

                        /// <summary>
                        /// <para>The expected response code from the backend server.</para>
                        /// <para>Valid values: <b>HTTP_2xx</b>, <b>HTTP_3xx</b>, <b>HTTP_4xx</b>, and <b>HTTP_5xx</b>. Multiple response codes are separated by commas (,).</para>
                        /// <remarks>
                        /// <para>This value is returned only when <b>ReasonCode</b> is <b>RESPONSE_MISMATCH</b>.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>HTTP_2xx</para>
                        /// </summary>
                        [NameInMap("ExpectedResponse")]
                        [Validation(Required=false)]
                        public string ExpectedResponse { get; set; }

                        /// <summary>
                        /// <para>The detailed reason when <b>Status</b> is abnormal.
                        /// Currently, only HTTP and HTTPS listeners and forwarding rules support viewing abnormal status reasons:</para>
                        /// <list type="bullet">
                        /// <item><description><para><b>CONNECT_TIMEOUT</b>: The Server Load Balancer (SLB) health check timed out when establishing a connection to the backend server.</para>
                        /// </description></item>
                        /// <item><description><para><b>CONNECT_FAILED</b>: The SLB health check failed to establish a connection to the backend server.</para>
                        /// </description></item>
                        /// <item><description><para><b>RECV_RESPONSE_FAILED</b>: The SLB health check failed to receive a response from the backend server.</para>
                        /// </description></item>
                        /// <item><description><para><b>RECV_RESPONSE_TIMEOUT</b>: The SLB health check timed out when receiving a response from the backend server.</para>
                        /// </description></item>
                        /// <item><description><para><b>SEND_REQUEST_FAILED</b>: The SLB health check failed to send a request to the backend server.</para>
                        /// </description></item>
                        /// <item><description><para><b>SEND_REQUEST_TIMEOUT</b>: The SLB health check timed out when sending a request to the backend server.</para>
                        /// </description></item>
                        /// <item><description><para><b>RESPONSE_FORMAT_ERROR</b>: The SLB health check received a response in an incorrect format from the backend server.</para>
                        /// </description></item>
                        /// <item><description><para><b>RESPONSE_MISMATCH</b>: The response code received from the backend server during the SLB health check did not match the expected response code.</para>
                        /// </description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>RESPONSE_MISMATCH</para>
                        /// </summary>
                        [NameInMap("ReasonCode")]
                        [Validation(Required=false)]
                        public string ReasonCode { get; set; }

                    }

                    /// <summary>
                    /// <para>The backend server ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>i-uf62h8v******</para>
                    /// </summary>
                    [NameInMap("ServerId")]
                    [Validation(Required=false)]
                    public string ServerId { get; set; }

                    /// <summary>
                    /// <para>The backend server group IP address.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>192.168.2.11</para>
                    /// </summary>
                    [NameInMap("ServerIp")]
                    [Validation(Required=false)]
                    public string ServerIp { get; set; }

                    /// <summary>
                    /// <para>The health check status. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><b>Initial</b>: Initializing. The SLB instance has health check configured, but no data is available.</para>
                    /// </description></item>
                    /// <item><description><para><b>Unhealthy</b>: Unhealthy. The backend server has continuously reported an unhealthy state.</para>
                    /// </description></item>
                    /// <item><description><para><b>Unused</b>: Not in use. The weight of the backend server is 0, or cross-zone load balancing is disabled and the backend server is not in the same zone as the ALB instance.</para>
                    /// </description></item>
                    /// <item><description><para><b>Unavailable</b>: Not enabled. Health check is not enabled.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Initial</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

                /// <summary>
                /// <para>The number of servers in the server group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ServerCount")]
                [Validation(Required=false)]
                public long? ServerCount { get; set; }

                /// <summary>
                /// <para>The associated server group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sgp-8ilqs4axp6******</para>
                /// </summary>
                [NameInMap("ServerGroupId")]
                [Validation(Required=false)]
                public string ServerGroupId { get; set; }

            }

        }

    }

}
