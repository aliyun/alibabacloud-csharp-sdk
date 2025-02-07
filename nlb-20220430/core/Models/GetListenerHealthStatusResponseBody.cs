// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlb20220430.Models
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
            /// <para>The ID of the listener of the NLB instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>lsn-bp1bpn0kn908w4nbw****@80</para>
            /// </summary>
            [NameInMap("ListenerId")]
            [Validation(Required=false)]
            public string ListenerId { get; set; }

            /// <summary>
            /// <para>The listening port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("ListenerPort")]
            [Validation(Required=false)]
            public int? ListenerPort { get; set; }

            /// <summary>
            /// <para>The listening protocol. Valid values: <b>TCP</b>, <b>UDP</b>, and <b>TCPSSL</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TCPSSL</para>
            /// </summary>
            [NameInMap("ListenerProtocol")]
            [Validation(Required=false)]
            public string ListenerProtocol { get; set; }

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
                /// <item><description><b>true</b>: enabled</description></item>
                /// <item><description><b>false</b>: disabled</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("HeathCheckEnabled")]
                [Validation(Required=false)]
                public bool? HeathCheckEnabled { get; set; }

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
                    /// <para>80</para>
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    /// <summary>
                    /// <para>The cause of the health check failure.</para>
                    /// </summary>
                    [NameInMap("Reason")]
                    [Validation(Required=false)]
                    public GetListenerHealthStatusResponseBodyListenerHealthStatusServerGroupInfosNonNormalServersReason Reason { get; set; }
                    public class GetListenerHealthStatusResponseBodyListenerHealthStatusServerGroupInfosNonNormalServersReason : TeaModel {
                        /// <summary>
                        /// <para>The reason why the <b>status</b> is abnormal. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>CONNECT_TIMEOUT</b>: The NLB instance failed to connect to the backend server within the specified period of time.</description></item>
                        /// <item><description><b>CONNECT_FAILED</b>: The NLB instance failed to connect to the backend server.</description></item>
                        /// <item><description><b>RECV_RESPONSE_TIMEOUT</b>: The NLB instance failed to receive a response from the backend server within the specified period of time.</description></item>
                        /// <item><description><b>CONNECT_INTERRUPT</b>: The connection between the health check and the backend servers was interrupted.</description></item>
                        /// <item><description><b>HTTP_CODE_NOT_MATCH</b>: The HTTP status code from the backend servers was not the expected one.</description></item>
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
                    /// <para>The ID of the backend server.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>i-bp1bt75jaujl7tjl****</para>
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
                    /// <para>The health check status. Valid values:</para>
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
                /// <para>The ID of the server group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sgp-ppdpc14gdm3x4o****</para>
                /// </summary>
                [NameInMap("ServerGroupId")]
                [Validation(Required=false)]
                public string ServerGroupId { get; set; }

            }

        }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token that is used for the next query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>NextToken</b> is empty, it indicates that no next query is to be sent.</description></item>
        /// <item><description>If a value of <b>NextToken</b> is returned, the value is the token used for the next query.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>FFmyTO70tTpLG6I3FmYAXGKPd****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>54B48E3D-DF70-471B-AA93-08E683A1B45</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
