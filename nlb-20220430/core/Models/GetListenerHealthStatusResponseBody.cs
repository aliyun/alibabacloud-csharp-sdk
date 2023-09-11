// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlb20220430.Models
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
            /// The ID of the listener of the NLB instance.
            /// </summary>
            [NameInMap("ListenerId")]
            [Validation(Required=false)]
            public string ListenerId { get; set; }

            /// <summary>
            /// The listening port.
            /// </summary>
            [NameInMap("ListenerPort")]
            [Validation(Required=false)]
            public int? ListenerPort { get; set; }

            /// <summary>
            /// The listening protocol. Valid values: **TCP**, **UDP**, and **TCPSSL**.
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
                /// Indicates whether the health check feature is enabled. Valid values:
                /// 
                /// *   **true**: enabled
                /// *   **false**: disabled
                /// </summary>
                [NameInMap("HeathCheckEnabled")]
                [Validation(Required=false)]
                public bool? HeathCheckEnabled { get; set; }

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
                    /// The cause of the health check failure.
                    /// </summary>
                    [NameInMap("Reason")]
                    [Validation(Required=false)]
                    public GetListenerHealthStatusResponseBodyListenerHealthStatusServerGroupInfosNonNormalServersReason Reason { get; set; }
                    public class GetListenerHealthStatusResponseBodyListenerHealthStatusServerGroupInfosNonNormalServersReason : TeaModel {
                        /// <summary>
                        /// The reason why the **status** is abnormal. Valid values:
                        /// 
                        /// *   **CONNECT_TIMEOUT**: The NLB instance failed to connect to the backend server within the specified period of time.
                        /// *   **CONNECT_FAILED**: The NLB instance failed to connect to the backend server.
                        /// *   **RECV_RESPONSE_TIMEOUT**: The NLB instance failed to receive a response from the backend server within the specified period of time.
                        /// *   **CONNECT_INTERRUPT**: The connection between the health check and the backend servers was interrupted.
                        /// *   **HTTP_CODE_NOT_MATCH**: The HTTP status code from the backend servers was not the expected one.
                        /// *   **HTTP_INVALID_HEADER**: The format of the response from the backend servers is invalid.
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
                    /// The health check status. Valid values:
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
                /// The ID of the server group.
                /// </summary>
                [NameInMap("ServerGroupId")]
                [Validation(Required=false)]
                public string ServerGroupId { get; set; }

            }

        }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token that is used for the next query. Valid values:
        /// 
        /// - If **NextToken** is empty, it indicates that no next query is to be sent.
        /// - If a value of **NextToken** is returned, the value is the token used for the next query.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
