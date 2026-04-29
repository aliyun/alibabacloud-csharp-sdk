// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class CloudMonitorTaskResponseBody : TeaModel {
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
        public CloudMonitorTaskResponseBodyData Data { get; set; }
        public class CloudMonitorTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <para>座席状态统计</para>
            /// </summary>
            [NameInMap("AgentInfo")]
            [Validation(Required=false)]
            public CloudMonitorTaskResponseBodyDataAgentInfo AgentInfo { get; set; }
            public class CloudMonitorTaskResponseBodyDataAgentInfo : TeaModel {
                /// <summary>
                /// <para>可用座席数</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("AvailableCount")]
                [Validation(Required=false)]
                public long? AvailableCount { get; set; }

                /// <summary>
                /// <para>通话中的座席数</para>
                /// 
                /// <b>Example:</b>
                /// <para>6</para>
                /// </summary>
                [NameInMap("BridgeCount")]
                [Validation(Required=false)]
                public long? BridgeCount { get; set; }

                /// <summary>
                /// <para>当前在线座席数</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("OnlineCount")]
                [Validation(Required=false)]
                public long? OnlineCount { get; set; }

                /// <summary>
                /// <para>响铃中的座席数</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("RingingCount")]
                [Validation(Required=false)]
                public long? RingingCount { get; set; }

                /// <summary>
                /// <para>座席总数</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

                /// <summary>
                /// <para>整理中的座席数</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("WrapupCount")]
                [Validation(Required=false)]
                public long? WrapupCount { get; set; }

            }

            /// <summary>
            /// <para>座席统计详情</para>
            /// </summary>
            [NameInMap("AgentStatisticList")]
            [Validation(Required=false)]
            public List<CloudMonitorTaskResponseBodyDataAgentStatisticList> AgentStatisticList { get; set; }
            public class CloudMonitorTaskResponseBodyDataAgentStatisticList : TeaModel {
                /// <summary>
                /// <para>座席平均进线时长,空闲时长/呼叫数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AgentAvgIdleTime")]
                [Validation(Required=false)]
                public long? AgentAvgIdleTime { get; set; }

                /// <summary>
                /// <para>座席当前状态:  stateIdle(空闲)  statePause(置忙)  stateInuse(通话） stateCalling(呼叫中)  stateWrapup(整理)   为空代表该当前时间座席在该任务中没有相关状态，如：座席未被使用等</para>
                /// 
                /// <b>Example:</b>
                /// <para>stateIdle</para>
                /// </summary>
                [NameInMap("AgentStatus")]
                [Validation(Required=false)]
                public string AgentStatus { get; set; }

                /// <summary>
                /// <para>座席平均通话时长，单位秒数</para>
                /// 
                /// <b>Example:</b>
                /// <para>116</para>
                /// </summary>
                [NameInMap("AvgBridgeTime")]
                [Validation(Required=false)]
                public string AvgBridgeTime { get; set; }

                /// <summary>
                /// <para>接听数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("BridgeCount")]
                [Validation(Required=false)]
                public long? BridgeCount { get; set; }

                /// <summary>
                /// <para>座席自动应答率=(座席接通时间-开始呼叫座席时间)&lt;=2s的通话数/座席接通数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0</para>
                /// </summary>
                [NameInMap("BridgeIn2sRate")]
                [Validation(Required=false)]
                public double? BridgeIn2sRate { get; set; }

                /// <summary>
                /// <para>任务级别，座席单日接听上限，-1代表未配置接听上限</para>
                /// 
                /// <b>Example:</b>
                /// <para>-1</para>
                /// </summary>
                [NameInMap("CallLimit")]
                [Validation(Required=false)]
                public long? CallLimit { get; set; }

                /// <summary>
                /// <para>呼叫数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CalledCount")]
                [Validation(Required=false)]
                public long? CalledCount { get; set; }

                /// <summary>
                /// <para>座席工号</para>
                /// 
                /// <b>Example:</b>
                /// <para>1111</para>
                /// </summary>
                [NameInMap("Cno")]
                [Validation(Required=false)]
                public string Cno { get; set; }

                /// <summary>
                /// <para>企业级别 座席单日接听上限，-1代表未配置接听上限</para>
                /// 
                /// <b>Example:</b>
                /// <para>-1</para>
                /// </summary>
                [NameInMap("EnterpriseCallLimit")]
                [Validation(Required=false)]
                public long? EnterpriseCallLimit { get; set; }

                /// <summary>
                /// <para>企业级别 座席今日已接听数</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("EnterpriseTodayAnsweredCount")]
                [Validation(Required=false)]
                public long? EnterpriseTodayAnsweredCount { get; set; }

                /// <summary>
                /// <para>座席名称</para>
                /// 
                /// <b>Example:</b>
                /// <para>name2</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>座席未接听数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("NoBridgeCount")]
                [Validation(Required=false)]
                public long? NoBridgeCount { get; set; }

                /// <summary>
                /// <para>任务级别 座席今日已接听数</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("TodayAnsweredCount")]
                [Validation(Required=false)]
                public long? TodayAnsweredCount { get; set; }

            }

            /// <summary>
            /// <para>通道监控信息</para>
            /// </summary>
            [NameInMap("ChannelInfo")]
            [Validation(Required=false)]
            public CloudMonitorTaskResponseBodyDataChannelInfo ChannelInfo { get; set; }
            public class CloudMonitorTaskResponseBodyDataChannelInfo : TeaModel {
                /// <summary>
                /// <para>客户接通个数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AnswerCount")]
                [Validation(Required=false)]
                public long? AnswerCount { get; set; }

                /// <summary>
                /// <para>桥接个数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("BridgedCount")]
                [Validation(Required=false)]
                public long? BridgedCount { get; set; }

                /// <summary>
                /// <para>任务当前通道数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ChannelCount")]
                [Validation(Required=false)]
                public long? ChannelCount { get; set; }

                /// <summary>
                /// <para>企业预测外呼通道数</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("EnterpriseChannelCount")]
                [Validation(Required=false)]
                public long? EnterpriseChannelCount { get; set; }

                /// <summary>
                /// <para>溢出到ivr数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("IvrCount")]
                [Validation(Required=false)]
                public long? IvrCount { get; set; }

                /// <summary>
                /// <para>等待转座席的个数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("WaitAgentCount")]
                [Validation(Required=false)]
                public long? WaitAgentCount { get; set; }

                /// <summary>
                /// <para>等待客户接听的个数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("WaitAnswerCount")]
                [Validation(Required=false)]
                public long? WaitAnswerCount { get; set; }

            }

            /// <summary>
            /// <para>已移除座席统计详情，仅当 <c>includeRemovedAgents=1</c> 时返回</para>
            /// </summary>
            [NameInMap("RemovedAgentStatisticList")]
            [Validation(Required=false)]
            public List<CloudMonitorTaskResponseBodyDataRemovedAgentStatisticList> RemovedAgentStatisticList { get; set; }
            public class CloudMonitorTaskResponseBodyDataRemovedAgentStatisticList : TeaModel {
                /// <summary>
                /// <para>座席平均进线时长,空闲时长/呼叫数</para>
                /// 
                /// <b>Example:</b>
                /// <para>13</para>
                /// </summary>
                [NameInMap("AgentAvgIdleTime")]
                [Validation(Required=false)]
                public long? AgentAvgIdleTime { get; set; }

                /// <summary>
                /// <para>座席当前状态:  stateIdle(空闲)  statePause(置忙)  stateInuse(通话） stateCalling(呼叫中)  stateWrapup(整理)   为空代表该当前时间座席在该任务中没有相关状态，如：座席未被使用等</para>
                /// 
                /// <b>Example:</b>
                /// <para>stateIdle</para>
                /// </summary>
                [NameInMap("AgentStatus")]
                [Validation(Required=false)]
                public string AgentStatus { get; set; }

                /// <summary>
                /// <para>座席平均通话时长，单位秒数</para>
                /// 
                /// <b>Example:</b>
                /// <para>39</para>
                /// </summary>
                [NameInMap("AvgBridgeTime")]
                [Validation(Required=false)]
                public string AvgBridgeTime { get; set; }

                /// <summary>
                /// <para>接听数</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("BridgeCount")]
                [Validation(Required=false)]
                public long? BridgeCount { get; set; }

                /// <summary>
                /// <para>座席自动应答率=(座席接通时间-开始呼叫座席时间)&lt;=2s的通话数/座席接通数</para>
                /// 
                /// <b>Example:</b>
                /// <para>3.55</para>
                /// </summary>
                [NameInMap("BridgeIn2sRate")]
                [Validation(Required=false)]
                public double? BridgeIn2sRate { get; set; }

                /// <summary>
                /// <para>任务级别，座席单日接听上限，-1代表未配置接听上限</para>
                /// 
                /// <b>Example:</b>
                /// <para>-1</para>
                /// </summary>
                [NameInMap("CallLimit")]
                [Validation(Required=false)]
                public long? CallLimit { get; set; }

                /// <summary>
                /// <para>呼叫数</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("CalledCount")]
                [Validation(Required=false)]
                public long? CalledCount { get; set; }

                /// <summary>
                /// <para>座席工号</para>
                /// 
                /// <b>Example:</b>
                /// <para>1111</para>
                /// </summary>
                [NameInMap("Cno")]
                [Validation(Required=false)]
                public string Cno { get; set; }

                /// <summary>
                /// <para>企业级别 座席单日接听上限，-1代表未配置接听上限</para>
                /// 
                /// <b>Example:</b>
                /// <para>-1</para>
                /// </summary>
                [NameInMap("EnterpriseCallLimit")]
                [Validation(Required=false)]
                public long? EnterpriseCallLimit { get; set; }

                /// <summary>
                /// <para>企业级别 座席今日已接听数</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("EnterpriseTodayAnsweredCount")]
                [Validation(Required=false)]
                public long? EnterpriseTodayAnsweredCount { get; set; }

                /// <summary>
                /// <para>座席名称</para>
                /// 
                /// <b>Example:</b>
                /// <para>name</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>座席未接听数</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("NoBridgeCount")]
                [Validation(Required=false)]
                public long? NoBridgeCount { get; set; }

                /// <summary>
                /// <para>任务级别 座席今日已接听数</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("TodayAnsweredCount")]
                [Validation(Required=false)]
                public long? TodayAnsweredCount { get; set; }

            }

            /// <summary>
            /// <para>任务监控信息</para>
            /// </summary>
            [NameInMap("Statistic")]
            [Validation(Required=false)]
            public CloudMonitorTaskResponseBodyDataStatistic Statistic { get; set; }
            public class CloudMonitorTaskResponseBodyDataStatistic : TeaModel {
                /// <summary>
                /// <para>座席数量</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("AgentCount")]
                [Validation(Required=false)]
                public long? AgentCount { get; set; }

                /// <summary>
                /// <para>应答数量</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("AnswerCount")]
                [Validation(Required=false)]
                public long? AnswerCount { get; set; }

                /// <summary>
                /// <para>呼叫坐席数</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("CallAgentCount")]
                [Validation(Required=false)]
                public long? CallAgentCount { get; set; }

                /// <summary>
                /// <para>已呼叫数量</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("CalledCount")]
                [Validation(Required=false)]
                public long? CalledCount { get; set; }

                /// <summary>
                /// <para>任务属性</para>
                /// </summary>
                [NameInMap("CtiLinkTaskProperty")]
                [Validation(Required=false)]
                public CloudMonitorTaskResponseBodyDataStatisticCtiLinkTaskProperty CtiLinkTaskProperty { get; set; }
                public class CloudMonitorTaskResponseBodyDataStatisticCtiLinkTaskProperty : TeaModel {
                    /// <summary>
                    /// <para>外呼任务Id</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12314</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>任务名称</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>testTask</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>任务结束时间</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2026-04-20 11:00:00</para>
                    /// </summary>
                    [NameInMap("OverTime")]
                    [Validation(Required=false)]
                    public string OverTime { get; set; }

                    /// <summary>
                    /// <para>任务开始时间</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2026-04-20 10:00:00</para>
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                    /// <summary>
                    /// <para>任务状态，0.初始 1.运行中 2.暂停 3.结束</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public long? Status { get; set; }

                    /// <summary>
                    /// <para>任务状态描述</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>示例值</para>
                    /// </summary>
                    [NameInMap("StatusDescription")]
                    [Validation(Required=false)]
                    public string StatusDescription { get; set; }

                }

                /// <summary>
                /// <para>未呼叫数量</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("UncalledCount")]
                [Validation(Required=false)]
                public long? UncalledCount { get; set; }

            }

            /// <summary>
            /// <para>当日任务监控信息</para>
            /// </summary>
            [NameInMap("TodayStatistic")]
            [Validation(Required=false)]
            public CloudMonitorTaskResponseBodyDataTodayStatistic TodayStatistic { get; set; }
            public class CloudMonitorTaskResponseBodyDataTodayStatistic : TeaModel {
                /// <summary>
                /// <para>座席数量</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("AgentCount")]
                [Validation(Required=false)]
                public long? AgentCount { get; set; }

                /// <summary>
                /// <para>应答数量</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("AnswerCount")]
                [Validation(Required=false)]
                public long? AnswerCount { get; set; }

                /// <summary>
                /// <para>呼叫坐席数</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("CallAgentCount")]
                [Validation(Required=false)]
                public long? CallAgentCount { get; set; }

                /// <summary>
                /// <para>已呼叫数量</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("CalledCount")]
                [Validation(Required=false)]
                public long? CalledCount { get; set; }

                [NameInMap("CtiLinkTaskProperty")]
                [Validation(Required=false)]
                public CloudMonitorTaskResponseBodyDataTodayStatisticCtiLinkTaskProperty CtiLinkTaskProperty { get; set; }
                public class CloudMonitorTaskResponseBodyDataTodayStatisticCtiLinkTaskProperty : TeaModel {
                    /// <summary>
                    /// <para>外呼任务Id</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12314</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>任务名称</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>testTask</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>任务结束时间</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2026-04-20 11:00:00</para>
                    /// </summary>
                    [NameInMap("OverTime")]
                    [Validation(Required=false)]
                    public string OverTime { get; set; }

                    /// <summary>
                    /// <para>任务开始时间</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2026-04-20 10:00:00</para>
                    /// </summary>
                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                    /// <summary>
                    /// <para>任务状态，0.初始 1.运行中 2.暂停 3.结束</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <para>任务状态描述</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>示例值示例值</para>
                    /// </summary>
                    [NameInMap("StatusDescription")]
                    [Validation(Required=false)]
                    public string StatusDescription { get; set; }

                }

                /// <summary>
                /// <para>未呼叫数量</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("UncalledCount")]
                [Validation(Required=false)]
                public long? UncalledCount { get; set; }

            }

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
        /// <para>7BF47617-7851-48F7-A3A1-2021342A78E2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
