// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gwlb20240415.Models
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
            /// <para>lsn-sg8aha6pzjavvo****</para>
            /// </summary>
            [NameInMap("ListenerId")]
            [Validation(Required=false)]
            public string ListenerId { get; set; }

            /// <summary>
            /// <para>The information about the server groups.</para>
            /// </summary>
            [NameInMap("ServerGroupInfos")]
            [Validation(Required=false)]
            public List<GetListenerHealthStatusResponseBodyListenerHealthStatusServerGroupInfos> ServerGroupInfos { get; set; }
            public class GetListenerHealthStatusResponseBodyListenerHealthStatusServerGroupInfos : TeaModel {
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
                /// <para>The server group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sgp-0vdsbyszro3nr6****</para>
                /// </summary>
                [NameInMap("ServerGroupId")]
                [Validation(Required=false)]
                public string ServerGroupId { get; set; }

                /// <summary>
                /// <para>The backend servers.</para>
                /// </summary>
                [NameInMap("Servers")]
                [Validation(Required=false)]
                public List<GetListenerHealthStatusResponseBodyListenerHealthStatusServerGroupInfosServers> Servers { get; set; }
                public class GetListenerHealthStatusResponseBodyListenerHealthStatusServerGroupInfosServers : TeaModel {
                    /// <summary>
                    /// <para>The backend port.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>6081</para>
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    /// <summary>
                    /// <para>The reason why <b>Status</b> indicates an unhealthy status.</para>
                    /// </summary>
                    [NameInMap("Reason")]
                    [Validation(Required=false)]
                    public GetListenerHealthStatusResponseBodyListenerHealthStatusServerGroupInfosServersReason Reason { get; set; }
                    public class GetListenerHealthStatusResponseBodyListenerHealthStatusServerGroupInfosServersReason : TeaModel {
                        /// <summary>
                        /// <para>The reason why <b>Status</b> indicates an unhealthy status. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>CONNECT_TIMEOUT</b>: The GWLB instance failed to connect to the backend server within the specified period of time.</description></item>
                        /// <item><description><b>CONNECT_FAILED</b>: The GWLB instance failed to connect to the backend server.</description></item>
                        /// <item><description><b>RECV_RESPONSE_TIMEOUT</b>: The GWLB instance failed to receive a response from the backend server within the specified period of time.</description></item>
                        /// <item><description><b>CONNECT_INTERRUPT</b>: The connection between the health check and the backend server was interrupted.</description></item>
                        /// <item><description><b>HTTP_CODE_NOT_MATCH</b>: The HTTP status code from the backend server is not the expected one.</description></item>
                        /// <item><description><b>HTTP_INVALID_HEADER</b>: The format of the response from the backend servers is invalid.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>CONNECT_TIMEOUT</para>
                        /// </summary>
                        [NameInMap("ReasonCode")]
                        [Validation(Required=false)]
                        public string ReasonCode { get; set; }

                    }

                    /// <summary>
                    /// <para>The backend server ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>i-2ze4rnh8yj9kif3z****</para>
                    /// </summary>
                    [NameInMap("ServerId")]
                    [Validation(Required=false)]
                    public string ServerId { get; set; }

                    /// <summary>
                    /// <para>The IP address of the server.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>192.168.0.XXX</para>
                    /// </summary>
                    [NameInMap("ServerIp")]
                    [Validation(Required=false)]
                    public string ServerIp { get; set; }

                    /// <summary>
                    /// <para>The health status of the backend server. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>Initial</b>: Health checks are configured for the GWLB instance, but no data is found.</description></item>
                    /// <item><description><b>Unhealthy</b>: The backend server consecutively fails health checks.</description></item>
                    /// <item><description><b>Unused</b>: The backend server is not in use.</description></item>
                    /// <item><description><b>Unavailable</b>: Health checks are disabled.</description></item>
                    /// <item><description><b>Healthy</b>: The backend server is healthy.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Healthy</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 1000. Default value: 20.</para>
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
        /// <para>U12WEI6Ro2ol3wA54rBNSwdC5+lYy6q5SjIQEvc1wz5mjZxV+YjsHRdXV8XauY1BpOQIvwX63E0en54H3D****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0ED4F222-36A0-5470-8A9A-AAB4E96BAC1A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>31</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
