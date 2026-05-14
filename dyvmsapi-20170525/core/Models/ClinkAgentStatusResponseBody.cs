// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class ClinkAgentStatusResponseBody : TeaModel {
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ClinkAgentStatusResponseBodyData Data { get; set; }
        public class ClinkAgentStatusResponseBodyData : TeaModel {
            /// <summary>
            /// <para>[座席状态详情] #座席状态详情</para>
            /// </summary>
            [NameInMap("AgentStatus")]
            [Validation(Required=false)]
            public List<ClinkAgentStatusResponseBodyDataAgentStatus> AgentStatus { get; set; }
            public class ClinkAgentStatusResponseBodyDataAgentStatus : TeaModel {
                /// <summary>
                /// <para>座席状态</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值</para>
                /// </summary>
                [NameInMap("AgentStatus")]
                [Validation(Required=false)]
                public string AgentStatus { get; set; }

                /// <summary>
                /// <para>座席状态详情</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值</para>
                /// </summary>
                [NameInMap("AgentStatusDetail")]
                [Validation(Required=false)]
                public string AgentStatusDetail { get; set; }

                /// <summary>
                /// <para>绑定号码</para>
                /// 
                /// <b>Example:</b>
                /// <para>1327770</para>
                /// </summary>
                [NameInMap("BindTel")]
                [Validation(Required=false)]
                public string BindTel { get; set; }

                /// <summary>
                /// <para>电话类型，1:电话；2:IP话机；3:软电话</para>
                /// 
                /// <b>Example:</b>
                /// <para>19</para>
                /// </summary>
                [NameInMap("BindType")]
                [Validation(Required=false)]
                public long? BindType { get; set; }

                /// <summary>
                /// <para>座席来电接听次数</para>
                /// 
                /// <b>Example:</b>
                /// <para>59</para>
                /// </summary>
                [NameInMap("BridgeCallCount")]
                [Validation(Required=false)]
                public long? BridgeCallCount { get; set; }

                /// <summary>
                /// <para>座席名称</para>
                /// 
                /// <b>Example:</b>
                /// <para>name1</para>
                /// </summary>
                [NameInMap("ClientName")]
                [Validation(Required=false)]
                public string ClientName { get; set; }

                /// <summary>
                /// <para>座席号</para>
                /// 
                /// <b>Example:</b>
                /// <para>1111</para>
                /// </summary>
                [NameInMap("Cno")]
                [Validation(Required=false)]
                public string Cno { get; set; }

                /// <summary>
                /// <para>座席code</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>客户号码</para>
                /// 
                /// <b>Example:</b>
                /// <para>177xxxx7750</para>
                /// </summary>
                [NameInMap("CustomerNumber")]
                [Validation(Required=false)]
                public string CustomerNumber { get; set; }

                /// <summary>
                /// <para>客户来电号码加密串</para>
                /// 
                /// <b>Example:</b>
                /// <hr>
                /// </summary>
                [NameInMap("CustomerNumberEncrypt")]
                [Validation(Required=false)]
                public string CustomerNumberEncrypt { get; set; }

                /// <summary>
                /// <para>客户状态，空闲，呼叫中，响铃，通话</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值</para>
                /// </summary>
                [NameInMap("CustomerStatus")]
                [Validation(Required=false)]
                public string CustomerStatus { get; set; }

                /// <summary>
                /// <para>呼入接听总响铃时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>15</para>
                /// </summary>
                [NameInMap("IbAnsweredRingingDuration")]
                [Validation(Required=false)]
                public long? IbAnsweredRingingDuration { get; set; }

                /// <summary>
                /// <para>客户呼入接听数</para>
                /// 
                /// <b>Example:</b>
                /// <para>66</para>
                /// </summary>
                [NameInMap("IbClientAnsweredCount")]
                [Validation(Required=false)]
                public long? IbClientAnsweredCount { get; set; }

                /// <summary>
                /// <para>客户呼入接听率</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0</para>
                /// </summary>
                [NameInMap("IbClientAnsweredRate")]
                [Validation(Required=false)]
                public double? IbClientAnsweredRate { get; set; }

                /// <summary>
                /// <para>客户呼入数</para>
                /// 
                /// <b>Example:</b>
                /// <para>15</para>
                /// </summary>
                [NameInMap("IbClientTotalCount")]
                [Validation(Required=false)]
                public long? IbClientTotalCount { get; set; }

                /// <summary>
                /// <para>客户呼入未接听数</para>
                /// 
                /// <b>Example:</b>
                /// <para>71</para>
                /// </summary>
                [NameInMap("IbClientUnansweredCount")]
                [Validation(Required=false)]
                public long? IbClientUnansweredCount { get; set; }

                /// <summary>
                /// <para>空闲超时时间（单位分钟）</para>
                /// 
                /// <b>Example:</b>
                /// <para>83</para>
                /// </summary>
                [NameInMap("IdleTimeOut")]
                [Validation(Required=false)]
                public long? IdleTimeOut { get; set; }

                /// <summary>
                /// <para>座席来电次数</para>
                /// 
                /// <b>Example:</b>
                /// <para>29</para>
                /// </summary>
                [NameInMap("IncomingCallCount")]
                [Validation(Required=false)]
                public long? IncomingCallCount { get; set; }

                /// <summary>
                /// <para>登录时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>97</para>
                /// </summary>
                [NameInMap("LoginDuration")]
                [Validation(Required=false)]
                public long? LoginDuration { get; set; }

                /// <summary>
                /// <para>外呼平均通话时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>25</para>
                /// </summary>
                [NameInMap("ObAvgBridgeDuration")]
                [Validation(Required=false)]
                public long? ObAvgBridgeDuration { get; set; }

                /// <summary>
                /// <para>外呼通话时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>59</para>
                /// </summary>
                [NameInMap("ObBridgeDuration")]
                [Validation(Required=false)]
                public long? ObBridgeDuration { get; set; }

                /// <summary>
                /// <para>外呼接听率</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0</para>
                /// </summary>
                [NameInMap("ObBridgeRate")]
                [Validation(Required=false)]
                public double? ObBridgeRate { get; set; }

                /// <summary>
                /// <para>座席外呼数</para>
                /// 
                /// <b>Example:</b>
                /// <para>96</para>
                /// </summary>
                [NameInMap("ObCallCount")]
                [Validation(Required=false)]
                public long? ObCallCount { get; set; }

                /// <summary>
                /// <para>外呼座席未接听数</para>
                /// 
                /// <b>Example:</b>
                /// <para>75</para>
                /// </summary>
                [NameInMap("ObClientUnbridgeCount")]
                [Validation(Required=false)]
                public long? ObClientUnbridgeCount { get; set; }

                /// <summary>
                /// <para>外呼客户接听数</para>
                /// 
                /// <b>Example:</b>
                /// <para>55</para>
                /// </summary>
                [NameInMap("ObCustomerBridgeCount")]
                [Validation(Required=false)]
                public long? ObCustomerBridgeCount { get; set; }

                /// <summary>
                /// <para>外呼客户未接听数</para>
                /// 
                /// <b>Example:</b>
                /// <para>15</para>
                /// </summary>
                [NameInMap("ObCustomerUnbridgeCount")]
                [Validation(Required=false)]
                public long? ObCustomerUnbridgeCount { get; set; }

                /// <summary>
                /// <para>置忙状态描述</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值示例值示例值</para>
                /// </summary>
                [NameInMap("PauseDescription")]
                [Validation(Required=false)]
                public string PauseDescription { get; set; }

                /// <summary>
                /// <para>置忙类型</para>
                /// 
                /// <b>Example:</b>
                /// <para>87</para>
                /// </summary>
                [NameInMap("PauseType")]
                [Validation(Required=false)]
                public long? PauseType { get; set; }

                /// <summary>
                /// <para>座席是否处于预测外呼状态 1：是 0：否</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PredictToCall")]
                [Validation(Required=false)]
                public long? PredictToCall { get; set; }

                /// <summary>
                /// <para>队列来电接听数</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("QueueIncomingCallCount")]
                [Validation(Required=false)]
                public long? QueueIncomingCallCount { get; set; }

                /// <summary>
                /// <para>队列信息</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("QueueInfo")]
                [Validation(Required=false)]
                public string QueueInfo { get; set; }

                /// <summary>
                /// <para>队列编号</para>
                /// 
                /// <b>Example:</b>
                /// <para>0035</para>
                /// </summary>
                [NameInMap("Queues")]
                [Validation(Required=false)]
                public string Queues { get; set; }

                /// <summary>
                /// <para>客户速挂数</para>
                /// 
                /// <b>Example:</b>
                /// <para>63</para>
                /// </summary>
                [NameInMap("QuickUnlinkCount")]
                [Validation(Required=false)]
                public long? QuickUnlinkCount { get; set; }

                /// <summary>
                /// <para>状态时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>89</para>
                /// </summary>
                [NameInMap("StateDuration")]
                [Validation(Required=false)]
                public long? StateDuration { get; set; }

                /// <summary>
                /// <para>座席标签</para>
                /// </summary>
                [NameInMap("TagNames")]
                [Validation(Required=false)]
                public List<string> TagNames { get; set; }

            }

            /// <summary>
            /// <para>请求 id</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("ClinkRequestId")]
            [Validation(Required=false)]
            public string ClinkRequestId { get; set; }

            /// <summary>
            /// <para>当前页码</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public long? PageNumber { get; set; }

            /// <summary>
            /// <para>一页展示条数</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }

            /// <summary>
            /// <para>总条数</para>
            /// 
            /// <b>Example:</b>
            /// <para>63</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A90E4451-FED7-49D2-87C8-00700A8C4D0D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
