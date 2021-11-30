// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alb20200616.Models
{
    public class GetListenerHealthStatusResponseBody : TeaModel {
        /// <summary>
        /// 监听健康检查结果
        /// </summary>
        [NameInMap("ListenerHealthStatus")]
        [Validation(Required=false)]
        public List<GetListenerHealthStatusResponseBodyListenerHealthStatus> ListenerHealthStatus { get; set; }
        public class GetListenerHealthStatusResponseBodyListenerHealthStatus : TeaModel {
            /// <summary>
            /// 监听Id
            /// </summary>
            [NameInMap("ListenerId")]
            [Validation(Required=false)]
            public string ListenerId { get; set; }

            /// <summary>
            /// 监听的端口号
            /// </summary>
            [NameInMap("ListenerPort")]
            [Validation(Required=false)]
            public int? ListenerPort { get; set; }

            /// <summary>
            /// 监听的协议
            /// </summary>
            [NameInMap("ListenerProtocol")]
            [Validation(Required=false)]
            public string ListenerProtocol { get; set; }

            /// <summary>
            /// 服务器组健康检查结果
            /// </summary>
            [NameInMap("ServerGroupInfos")]
            [Validation(Required=false)]
            public List<GetListenerHealthStatusResponseBodyListenerHealthStatusServerGroupInfos> ServerGroupInfos { get; set; }
            public class GetListenerHealthStatusResponseBodyListenerHealthStatusServerGroupInfos : TeaModel {
                /// <summary>
                /// 服务器组使用类型
                /// </summary>
                [NameInMap("ActionType")]
                [Validation(Required=false)]
                public string ActionType { get; set; }

                /// <summary>
                /// 健康检查开启/关闭
                /// </summary>
                [NameInMap("HealthCheckEnabled")]
                [Validation(Required=false)]
                public string HealthCheckEnabled { get; set; }

                /// <summary>
                /// 处于非正常状态的后端服务器
                /// </summary>
                [NameInMap("NonNormalServers")]
                [Validation(Required=false)]
                public List<GetListenerHealthStatusResponseBodyListenerHealthStatusServerGroupInfosNonNormalServers> NonNormalServers { get; set; }
                public class GetListenerHealthStatusResponseBodyListenerHealthStatusServerGroupInfosNonNormalServers : TeaModel {
                    /// <summary>
                    /// 后端服务器端口
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    /// <summary>
                    /// status为非正常状态时的详细异常原因
                    /// </summary>
                    [NameInMap("Reason")]
                    [Validation(Required=false)]
                    public GetListenerHealthStatusResponseBodyListenerHealthStatusServerGroupInfosNonNormalServersReason Reason { get; set; }
                    public class GetListenerHealthStatusResponseBodyListenerHealthStatusServerGroupInfosNonNormalServersReason : TeaModel {
                        [NameInMap("ActualResponse")]
                        [Validation(Required=false)]
                        public string ActualResponse { get; set; }
                        [NameInMap("ExpectedResponse")]
                        [Validation(Required=false)]
                        public string ExpectedResponse { get; set; }
                        [NameInMap("ReasonCode")]
                        [Validation(Required=false)]
                        public string ReasonCode { get; set; }
                    };

                    /// <summary>
                    /// 后端服务器id
                    /// </summary>
                    [NameInMap("ServerId")]
                    [Validation(Required=false)]
                    public string ServerId { get; set; }

                    /// <summary>
                    /// 后端服务器Ip
                    /// </summary>
                    [NameInMap("ServerIp")]
                    [Validation(Required=false)]
                    public string ServerIp { get; set; }

                    /// <summary>
                    /// 健康检查状态
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

                /// <summary>
                /// 服务器组ID
                /// </summary>
                [NameInMap("ServerGroupId")]
                [Validation(Required=false)]
                public string ServerGroupId { get; set; }

            }

        }

        /// <summary>
        /// 下一页标识
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 请求Id
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 转发规则健康检查结果
        /// </summary>
        [NameInMap("RuleHealthStatus")]
        [Validation(Required=false)]
        public List<GetListenerHealthStatusResponseBodyRuleHealthStatus> RuleHealthStatus { get; set; }
        public class GetListenerHealthStatusResponseBodyRuleHealthStatus : TeaModel {
            /// <summary>
            /// 转发规则ID
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// 服务器组健康检查结果
            /// </summary>
            [NameInMap("ServerGroupInfos")]
            [Validation(Required=false)]
            public List<GetListenerHealthStatusResponseBodyRuleHealthStatusServerGroupInfos> ServerGroupInfos { get; set; }
            public class GetListenerHealthStatusResponseBodyRuleHealthStatusServerGroupInfos : TeaModel {
                /// <summary>
                /// 服务器组使用类型
                /// </summary>
                [NameInMap("ActionType")]
                [Validation(Required=false)]
                public string ActionType { get; set; }

                /// <summary>
                /// 健康检查开启/关闭
                /// </summary>
                [NameInMap("HealthCheckEnabled")]
                [Validation(Required=false)]
                public string HealthCheckEnabled { get; set; }

                /// <summary>
                /// 处于非正常状态的后端服务器
                /// </summary>
                [NameInMap("NonNormalServers")]
                [Validation(Required=false)]
                public List<GetListenerHealthStatusResponseBodyRuleHealthStatusServerGroupInfosNonNormalServers> NonNormalServers { get; set; }
                public class GetListenerHealthStatusResponseBodyRuleHealthStatusServerGroupInfosNonNormalServers : TeaModel {
                    /// <summary>
                    /// 后端服务器端口
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public int? Port { get; set; }

                    /// <summary>
                    /// status为非正常状态时的详细异常原因
                    /// </summary>
                    [NameInMap("Reason")]
                    [Validation(Required=false)]
                    public GetListenerHealthStatusResponseBodyRuleHealthStatusServerGroupInfosNonNormalServersReason Reason { get; set; }
                    public class GetListenerHealthStatusResponseBodyRuleHealthStatusServerGroupInfosNonNormalServersReason : TeaModel {
                        [NameInMap("ActualResponse")]
                        [Validation(Required=false)]
                        public string ActualResponse { get; set; }
                        [NameInMap("ExpectedResponse")]
                        [Validation(Required=false)]
                        public string ExpectedResponse { get; set; }
                        [NameInMap("ReasonCode")]
                        [Validation(Required=false)]
                        public string ReasonCode { get; set; }
                    };

                    /// <summary>
                    /// 后端服务器Id
                    /// </summary>
                    [NameInMap("ServerId")]
                    [Validation(Required=false)]
                    public string ServerId { get; set; }

                    /// <summary>
                    /// 后端服务器ID
                    /// </summary>
                    [NameInMap("ServerIp")]
                    [Validation(Required=false)]
                    public string ServerIp { get; set; }

                    /// <summary>
                    /// 健康检查状态
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

                /// <summary>
                /// 服务器组ID
                /// </summary>
                [NameInMap("ServerGroupId")]
                [Validation(Required=false)]
                public string ServerGroupId { get; set; }

            }

        }

    }

}
