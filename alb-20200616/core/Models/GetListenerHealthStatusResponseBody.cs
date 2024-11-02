// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class GetListenerHealthStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The health check status of the server groups that are associated with the listener.</para>
        /// </summary>
        [NameInMap("ListenerHealthStatus")]
        [Validation(Required=false)]
        public List<GetListenerHealthStatusResponseBodyListenerHealthStatus> ListenerHealthStatus { get; set; }
        public class GetListenerHealthStatusResponseBodyListenerHealthStatus : TeaModel {
            /// <summary>
            /// <para>The listener ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lsr-bp1bpn0kn908w4nbw****</para>
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
            /// <para>The information about the server group.</para>
            /// </summary>
            [NameInMap("ServerGroupInfos")]
            [Validation(Required=false)]
            public List<GetListenerHealthStatusResponseBodyListenerHealthStatusServerGroupInfos> ServerGroupInfos { get; set; }
            public class GetListenerHealthStatusResponseBodyListenerHealthStatusServerGroupInfos : TeaModel {
                /// <summary>
                /// <para>The action specified for the server group. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>ForwardGroup</b>: distributes requests to server groups.</description></item>
                /// <item><description><b>TrafficMirror</b>: mirrors requests to server groups.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>TrafficMirror</para>
                /// </summary>
                [NameInMap("ActionType")]
                [Validation(Required=false)]
                public string ActionType { get; set; }

                /// <summary>
                /// <para>Indicates whether health checks are enabled. If <b>on</b> is returned, it indicates that health checks are enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("HealthCheckEnabled")]
                [Validation(Required=false)]
                public string HealthCheckEnabled { get; set; }

                /// <summary>
                /// <para>A list of unhealthy backend servers.</para>
                /// </summary>
                [NameInMap("NonNormalServers")]
                [Validation(Required=false)]
                public List<GetListenerHealthStatusResponseBodyListenerHealthStatusServerGroupInfosNonNormalServers> NonNormalServers { get; set; }
                public class GetListenerHealthStatusResponseBodyListenerHealthStatusServerGroupInfosNonNormalServers : TeaModel {
                    /// <summary>
                    /// <para>The backend port.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>90</para>
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    /// <summary>
                    /// <para>The cause of the abnormal state.</para>
                    /// </summary>
                    [NameInMap("Reason")]
                    [Validation(Required=false)]
                    public GetListenerHealthStatusResponseBodyListenerHealthStatusServerGroupInfosNonNormalServersReason Reason { get; set; }
                    public class GetListenerHealthStatusResponseBodyListenerHealthStatusServerGroupInfosNonNormalServersReason : TeaModel {
                        /// <summary>
                        /// <para>The HTTP status code returned from the server, for example, <b>302</b>.</para>
                        /// <remarks>
                        /// <para>A value is returned only if <c>ReasonCode</c> is set to <b>RESPONSE_MISMATCH</b>.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>302</para>
                        /// </summary>
                        [NameInMap("ActualResponse")]
                        [Validation(Required=false)]
                        public string ActualResponse { get; set; }

                        /// <summary>
                        /// <para>The HTTP status code returned after backend servers pass health checks.</para>
                        /// <para>Valid values: <b>HTTP_2xx</b>, <b>HTTP_3xx</b>, <b>HTTP_4xx</b>, and <b>HTTP_5xx</b>. Multiple status codes are separated by commas (,).</para>
                        /// <remarks>
                        /// <para>This value is returned only if <b>ReasonCode</b> is set to <b>RESPONSE_MISMATCH</b>.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>HTTP_2xx</para>
                        /// </summary>
                        [NameInMap("ExpectedResponse")]
                        [Validation(Required=false)]
                        public string ExpectedResponse { get; set; }

                        /// <summary>
                        /// <para>The reason why the value of <b>Status</b> is Unhealthy. Only HTTP and HTTPS listeners support this parameter.</para>
                        /// <list type="bullet">
                        /// <item><description><b>CONNECT_TIMEOUT</b>: ALB failed to connect to the backend server within the specified period of time.</description></item>
                        /// <item><description><b>CONNECT_FAILED</b>: ALB failed to connect to the backend server.</description></item>
                        /// <item><description><b>RECV_RESPONSE_FAILED</b>: ALB failed to receive a response from the backend server.</description></item>
                        /// <item><description><b>RECV_RESPONSE_TIMEOUT</b>: ALB failed to receive a response from the backend server within the specified period of time.</description></item>
                        /// <item><description><b>SEND_REQUEST_FAILED</b>: ALB failed to send a request to the backend server.</description></item>
                        /// <item><description><b>SEND_REQUEST_TIMEOUT</b>: ALB failed to send a request to the backend server within the specified period of time.</description></item>
                        /// <item><description><b>RESPONSE_FORMAT_ERROR</b>: The format of the response from the backend server is invalid.</description></item>
                        /// <item><description><b>RESPONSE_FORMAT_ERROR</b>: The HTTP status code returned from the backend server is not the expected one.</description></item>
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
                    /// <para>The ID of the backend server.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rg-bp1bfa08ex*****</para>
                    /// </summary>
                    [NameInMap("ServerId")]
                    [Validation(Required=false)]
                    public string ServerId { get; set; }

                    /// <summary>
                    /// <para>The IP address of the backend server.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>192.168.8.10</para>
                    /// </summary>
                    [NameInMap("ServerIp")]
                    [Validation(Required=false)]
                    public string ServerIp { get; set; }

                    /// <summary>
                    /// <para>The status of the health check. Valid values: Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>Initial</b>: indicates that health checks are configured for the NLB instance, but no data was found.</description></item>
                    /// <item><description><b>Unhealthy</b>: indicates that the backend server consecutively fails health checks.</description></item>
                    /// <item><description><b>Unused</b>: indicates that the weight of the backend server is 0.</description></item>
                    /// <item><description><b>Unavailable</b>: indicates that health checks are disabled.</description></item>
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
                /// <para>The ID of the server group that is associated with the listener.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsp-bp1qjwo61pqz3ahltv****</para>
                /// </summary>
                [NameInMap("ServerGroupId")]
                [Validation(Required=false)]
                public string ServerGroupId { get; set; }

            }

        }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, no next page exists.</description></item>
        /// <item><description>If <b>NextToken</b> was returned in the previous query, specify the value to obtain the next set of results.</description></item>
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
        /// <para>CEF72CEB-54B6-4AE8-B225-F876FF7BA984</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The health check status of the forwarding rules.</para>
        /// </summary>
        [NameInMap("RuleHealthStatus")]
        [Validation(Required=false)]
        public List<GetListenerHealthStatusResponseBodyRuleHealthStatus> RuleHealthStatus { get; set; }
        public class GetListenerHealthStatusResponseBodyRuleHealthStatus : TeaModel {
            /// <summary>
            /// <para>The ID of the forwarding rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rule-hp34s2h0xx1ht4nwo****</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// <para>The server groups.</para>
            /// </summary>
            [NameInMap("ServerGroupInfos")]
            [Validation(Required=false)]
            public List<GetListenerHealthStatusResponseBodyRuleHealthStatusServerGroupInfos> ServerGroupInfos { get; set; }
            public class GetListenerHealthStatusResponseBodyRuleHealthStatusServerGroupInfos : TeaModel {
                /// <summary>
                /// <para>The action specified for the server group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TrafficMirror</para>
                /// </summary>
                [NameInMap("ActionType")]
                [Validation(Required=false)]
                public string ActionType { get; set; }

                /// <summary>
                /// <para>Indicates whether health checks are enabled. If <b>on</b> is returned, it indicates that health checks are enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>on</para>
                /// </summary>
                [NameInMap("HealthCheckEnabled")]
                [Validation(Required=false)]
                public string HealthCheckEnabled { get; set; }

                /// <summary>
                /// <para>A list of unhealthy backend servers.</para>
                /// </summary>
                [NameInMap("NonNormalServers")]
                [Validation(Required=false)]
                public List<GetListenerHealthStatusResponseBodyRuleHealthStatusServerGroupInfosNonNormalServers> NonNormalServers { get; set; }
                public class GetListenerHealthStatusResponseBodyRuleHealthStatusServerGroupInfosNonNormalServers : TeaModel {
                    /// <summary>
                    /// <para>The backend port.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>90</para>
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    /// <summary>
                    /// <para>The cause of the abnormal state.</para>
                    /// </summary>
                    [NameInMap("Reason")]
                    [Validation(Required=false)]
                    public GetListenerHealthStatusResponseBodyRuleHealthStatusServerGroupInfosNonNormalServersReason Reason { get; set; }
                    public class GetListenerHealthStatusResponseBodyRuleHealthStatusServerGroupInfosNonNormalServersReason : TeaModel {
                        /// <summary>
                        /// <para>The HTTP status code returned from the server, for example, <b>302</b>.</para>
                        /// <remarks>
                        /// <para>A value is returned only if <b>ReasonCode</b> is set to <b>RESPONSE_MISMATCH</b>.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>302</para>
                        /// </summary>
                        [NameInMap("ActualResponse")]
                        [Validation(Required=false)]
                        public string ActualResponse { get; set; }

                        /// <summary>
                        /// <para>The HTTP status code returned after backend servers pass health checks.</para>
                        /// <para>Valid values: <b>HTTP_2xx</b>, <b>HTTP_3xx</b>, <b>HTTP_4xx</b>, and <b>HTTP_5xx</b>. Multiple status codes are separated by commas (,).</para>
                        /// <remarks>
                        /// <para>A value is returned only if <b>ReasonCode</b> is set to <b>RESPONSE_MISMATCH</b>.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>HTTP_2xx</para>
                        /// </summary>
                        [NameInMap("ExpectedResponse")]
                        [Validation(Required=false)]
                        public string ExpectedResponse { get; set; }

                        /// <summary>
                        /// <para>The reason why the value of <b>Status</b> is Unhealthy. Only HTTP and HTTPS listeners support this parameter.</para>
                        /// <list type="bullet">
                        /// <item><description><b>CONNECT_TIMEOUT</b>: ALB failed to connect to the backend server within the specified period of time.</description></item>
                        /// <item><description><b>CONNECT_FAILED</b>: ALB failed to connect to the backend server.</description></item>
                        /// <item><description><b>RECV_RESPONSE_FAILED</b>: ALB failed to receive a response from the backend server.</description></item>
                        /// <item><description><b>RECV_RESPONSE_TIMEOUT</b>: ALB failed to receive a response from the backend server within the specified period of time.</description></item>
                        /// <item><description><b>SEND_REQUEST_FAILED</b>: ALB failed to send a request to the backend server.</description></item>
                        /// <item><description><b>SEND_REQUEST_TIMEOUT</b>: ALB failed to send a request to the backend server within the specified period of time.</description></item>
                        /// <item><description><b>RESPONSE_FORMAT_ERROR</b>: The format of the response from the backend server is invalid.</description></item>
                        /// <item><description><b>RESPONSE_FORMAT_ERROR</b>: The HTTP status code returned from the backend server is not the expected one.</description></item>
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
                    /// <para>The ID of the backend server.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rg-bp1bfa08ex****</para>
                    /// </summary>
                    [NameInMap("ServerId")]
                    [Validation(Required=false)]
                    public string ServerId { get; set; }

                    /// <summary>
                    /// <para>The IP address of the server group.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>192.168.2.11</para>
                    /// </summary>
                    [NameInMap("ServerIp")]
                    [Validation(Required=false)]
                    public string ServerIp { get; set; }

                    /// <summary>
                    /// <para>The status of the health check. Valid values: Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>Initial</b>: indicates that health checks are configured for the NLB instance, but no data was found.</description></item>
                    /// <item><description><b>Unhealthy</b>: indicates that the backend server consecutively fails health checks.</description></item>
                    /// <item><description><b>Unused</b>: indicates that the weight of the backend server is 0.</description></item>
                    /// <item><description><b>Unavailable</b>: indicates that health checks are disabled.</description></item>
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
                /// <para>The ID of the server group that is associated with the listener.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsp-bp1qjwo61pqz3ahlt****</para>
                /// </summary>
                [NameInMap("ServerGroupId")]
                [Validation(Required=false)]
                public string ServerGroupId { get; set; }

            }

        }

    }

}
