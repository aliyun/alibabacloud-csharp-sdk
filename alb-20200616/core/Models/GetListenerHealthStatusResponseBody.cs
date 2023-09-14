// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class GetListenerHealthStatusResponseBody : TeaModel {
        /// <summary>
        /// The health check status of the server groups that are associated with the listener.
        /// </summary>
        [NameInMap("ListenerHealthStatus")]
        [Validation(Required=false)]
        public List<GetListenerHealthStatusResponseBodyListenerHealthStatus> ListenerHealthStatus { get; set; }
        public class GetListenerHealthStatusResponseBodyListenerHealthStatus : TeaModel {
            /// <summary>
            /// The listener ID.
            /// </summary>
            [NameInMap("ListenerId")]
            [Validation(Required=false)]
            public string ListenerId { get; set; }

            /// <summary>
            /// The listener port.
            /// </summary>
            [NameInMap("ListenerPort")]
            [Validation(Required=false)]
            public int? ListenerPort { get; set; }

            /// <summary>
            /// The listener protocol.
            /// </summary>
            [NameInMap("ListenerProtocol")]
            [Validation(Required=false)]
            public string ListenerProtocol { get; set; }

            /// <summary>
            /// The information about the server groups.
            /// </summary>
            [NameInMap("ServerGroupInfos")]
            [Validation(Required=false)]
            public List<GetListenerHealthStatusResponseBodyListenerHealthStatusServerGroupInfos> ServerGroupInfos { get; set; }
            public class GetListenerHealthStatusResponseBodyListenerHealthStatusServerGroupInfos : TeaModel {
                /// <summary>
                /// The action specified for the server group.
                /// </summary>
                [NameInMap("ActionType")]
                [Validation(Required=false)]
                public string ActionType { get; set; }

                /// <summary>
                /// Indicates whether health checks are enabled. If **on** is returned, it indicates that health checks are enabled.
                /// </summary>
                [NameInMap("HealthCheckEnabled")]
                [Validation(Required=false)]
                public string HealthCheckEnabled { get; set; }

                /// <summary>
                /// A list of unhealthy backend servers.
                /// </summary>
                [NameInMap("NonNormalServers")]
                [Validation(Required=false)]
                public List<GetListenerHealthStatusResponseBodyListenerHealthStatusServerGroupInfosNonNormalServers> NonNormalServers { get; set; }
                public class GetListenerHealthStatusResponseBodyListenerHealthStatusServerGroupInfosNonNormalServers : TeaModel {
                    /// <summary>
                    /// The backend port.
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    /// <summary>
                    /// The cause of the abnormal state.
                    /// </summary>
                    [NameInMap("Reason")]
                    [Validation(Required=false)]
                    public GetListenerHealthStatusResponseBodyListenerHealthStatusServerGroupInfosNonNormalServersReason Reason { get; set; }
                    public class GetListenerHealthStatusResponseBodyListenerHealthStatusServerGroupInfosNonNormalServersReason : TeaModel {
                        /// <summary>
                        /// The HTTP status code returned from the server, for example, **302**.
                        /// 
                        /// > A value is returned only if `ReasonCode` is set to **RESPONSE_MISMATCH**.
                        /// </summary>
                        [NameInMap("ActualResponse")]
                        [Validation(Required=false)]
                        public string ActualResponse { get; set; }

                        /// <summary>
                        /// The HTTP status code returned after backend servers pass health checks.
                        /// 
                        /// Valid values: **HTTP\_2xx**, **HTTP\_3xx**, **HTTP\_4xx**, and **HTTP\_5xx**. Multiple status codes are separated by commas (,).
                        /// 
                        /// > This value is returned only if **ReasonCode** is set to **RESPONSE_MISMATCH**.
                        /// </summary>
                        [NameInMap("ExpectedResponse")]
                        [Validation(Required=false)]
                        public string ExpectedResponse { get; set; }

                        /// <summary>
                        /// The reason why the value of **Status** is Unhealthy. Only HTTP and HTTPS listeners support this parameter.
                        /// 
                        /// *   **CONNECT_TIMEOUT**: ALB failed to connect to the backend server within the specified period of time.
                        /// *   **CONNECT_FAILED**: ALB failed to connect to the backend server.
                        /// *   **RECV_RESPONSE_FAILED**: ALB failed to receive a response from the backend server.
                        /// *   **RECV_RESPONSE_TIMEOUT**: ALB failed to receive a response from the backend server within the specified period of time.
                        /// *   **SEND_REQUEST_FAILED**: ALB failed to send a request to the backend server.
                        /// *   **SEND_REQUEST_TIMEOUT**: ALB failed to send a request to the backend server within the specified period of time.
                        /// *   **RESPONSE_FORMAT_ERROR**: The format of the response from the backend server is invalid.
                        /// *   **RESPONSE_FORMAT_ERROR**: The HTTP status code returned from the backend server is not the expected one.
                        /// </summary>
                        [NameInMap("ReasonCode")]
                        [Validation(Required=false)]
                        public string ReasonCode { get; set; }

                    }

                    /// <summary>
                    /// The ID of the backend server.
                    /// </summary>
                    [NameInMap("ServerId")]
                    [Validation(Required=false)]
                    public string ServerId { get; set; }

                    /// <summary>
                    /// The IP address of the backend server.
                    /// </summary>
                    [NameInMap("ServerIp")]
                    [Validation(Required=false)]
                    public string ServerIp { get; set; }

                    /// <summary>
                    /// The status of the health check. Valid values: Valid values:
                    /// 
                    /// *   **Initial**: indicates that health checks are configured for the NLB instance, but no data was found.
                    /// *   **Unhealthy**: indicates that the backend server consecutively fails health checks.
                    /// *   **Unused**: indicates that the weight of the backend server is 0.
                    /// *   **Unavailable**: indicates that health checks are disabled.
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

                /// <summary>
                /// The ID of the server group that is associated with the listener.
                /// </summary>
                [NameInMap("ServerGroupId")]
                [Validation(Required=false)]
                public string ServerGroupId { get; set; }

            }

        }

        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results. Valid values:
        /// 
        /// *   If **NextToken** is empty, no next page exists.
        /// *   If **NextToken** was returned in the previous query, specify the value to obtain the next set of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The health check status of the forwarding rules.
        /// </summary>
        [NameInMap("RuleHealthStatus")]
        [Validation(Required=false)]
        public List<GetListenerHealthStatusResponseBodyRuleHealthStatus> RuleHealthStatus { get; set; }
        public class GetListenerHealthStatusResponseBodyRuleHealthStatus : TeaModel {
            /// <summary>
            /// The ID of the forwarding rule.
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// The server groups.
            /// </summary>
            [NameInMap("ServerGroupInfos")]
            [Validation(Required=false)]
            public List<GetListenerHealthStatusResponseBodyRuleHealthStatusServerGroupInfos> ServerGroupInfos { get; set; }
            public class GetListenerHealthStatusResponseBodyRuleHealthStatusServerGroupInfos : TeaModel {
                /// <summary>
                /// The action specified for the server group.
                /// </summary>
                [NameInMap("ActionType")]
                [Validation(Required=false)]
                public string ActionType { get; set; }

                /// <summary>
                /// Indicates whether health checks are enabled. If **on** is returned, it indicates that health checks are enabled.
                /// </summary>
                [NameInMap("HealthCheckEnabled")]
                [Validation(Required=false)]
                public string HealthCheckEnabled { get; set; }

                /// <summary>
                /// A list of unhealthy backend servers.
                /// </summary>
                [NameInMap("NonNormalServers")]
                [Validation(Required=false)]
                public List<GetListenerHealthStatusResponseBodyRuleHealthStatusServerGroupInfosNonNormalServers> NonNormalServers { get; set; }
                public class GetListenerHealthStatusResponseBodyRuleHealthStatusServerGroupInfosNonNormalServers : TeaModel {
                    /// <summary>
                    /// The backend port.
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    /// <summary>
                    /// The cause of the abnormal state.
                    /// </summary>
                    [NameInMap("Reason")]
                    [Validation(Required=false)]
                    public GetListenerHealthStatusResponseBodyRuleHealthStatusServerGroupInfosNonNormalServersReason Reason { get; set; }
                    public class GetListenerHealthStatusResponseBodyRuleHealthStatusServerGroupInfosNonNormalServersReason : TeaModel {
                        /// <summary>
                        /// The HTTP status code returned from the server, for example, **302**.
                        /// 
                        /// > A value is returned only if **ReasonCode** is set to **RESPONSE_MISMATCH**.
                        /// </summary>
                        [NameInMap("ActualResponse")]
                        [Validation(Required=false)]
                        public string ActualResponse { get; set; }

                        /// <summary>
                        /// The HTTP status code returned after backend servers pass health checks.
                        /// 
                        /// Valid values: **HTTP\_2xx**, **HTTP\_3xx**, **HTTP\_4xx**, and **HTTP\_5xx**. Multiple status codes are separated by commas (,).
                        /// 
                        /// > A value is returned only if **ReasonCode** is set to **RESPONSE_MISMATCH**.
                        /// </summary>
                        [NameInMap("ExpectedResponse")]
                        [Validation(Required=false)]
                        public string ExpectedResponse { get; set; }

                        /// <summary>
                        /// The reason why the value of **Status** is Unhealthy. Only HTTP and HTTPS listeners support this parameter.
                        /// 
                        /// *   **CONNECT_TIMEOUT**: ALB failed to connect to the backend server within the specified period of time.
                        /// *   **CONNECT_FAILED**: ALB failed to connect to the backend server.
                        /// *   **RECV_RESPONSE_FAILED**: ALB failed to receive a response from the backend server.
                        /// *   **RECV_RESPONSE_TIMEOUT**: ALB failed to receive a response from the backend server within the specified period of time.
                        /// *   **SEND_REQUEST_FAILED**: ALB failed to send a request to the backend server.
                        /// *   **SEND_REQUEST_TIMEOUT**: ALB failed to send a request to the backend server within the specified period of time.
                        /// *   **RESPONSE_FORMAT_ERROR**: The format of the response from the backend server is invalid.
                        /// *   **RESPONSE_FORMAT_ERROR**: The HTTP status code returned from the backend server is not the expected one.
                        /// </summary>
                        [NameInMap("ReasonCode")]
                        [Validation(Required=false)]
                        public string ReasonCode { get; set; }

                    }

                    /// <summary>
                    /// The ID of the backend server.
                    /// </summary>
                    [NameInMap("ServerId")]
                    [Validation(Required=false)]
                    public string ServerId { get; set; }

                    /// <summary>
                    /// The IP address of the server group.
                    /// </summary>
                    [NameInMap("ServerIp")]
                    [Validation(Required=false)]
                    public string ServerIp { get; set; }

                    /// <summary>
                    /// The status of the health check. Valid values: Valid values:
                    /// 
                    /// *   **Initial**: indicates that health checks are configured for the NLB instance, but no data was found.
                    /// *   **Unhealthy**: indicates that the backend server consecutively fails health checks.
                    /// *   **Unused**: indicates that the weight of the backend server is 0.
                    /// *   **Unavailable**: indicates that health checks are disabled.
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

                /// <summary>
                /// The ID of the server group that is associated with the listener.
                /// </summary>
                [NameInMap("ServerGroupId")]
                [Validation(Required=false)]
                public string ServerGroupId { get; set; }

            }

        }

    }

}
