// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dyvmsapi20170525.Models
{
    public class CloudAgentWorkloadReportResponseBody : TeaModel {
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
        public CloudAgentWorkloadReportResponseBodyData Data { get; set; }
        public class CloudAgentWorkloadReportResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<CloudAgentWorkloadReportResponseBodyDataList> List { get; set; }
            public class CloudAgentWorkloadReportResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>座席来电接听率</para>
                /// 
                /// <b>Example:</b>
                /// <para>80%</para>
                /// </summary>
                [NameInMap("AgentAnswerRate")]
                [Validation(Required=false)]
                public string AgentAnswerRate { get; set; }

                /// <summary>
                /// <para>座席创建时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-04-20</para>
                /// </summary>
                [NameInMap("AgentCreateTime")]
                [Validation(Required=false)]
                public string AgentCreateTime { get; set; }

                /// <summary>
                /// <para>座席名称</para>
                /// 
                /// <b>Example:</b>
                /// <para>test-3</para>
                /// </summary>
                [NameInMap("AgentName")]
                [Validation(Required=false)]
                public string AgentName { get; set; }

                /// <summary>
                /// <para>座席呼叫接听率</para>
                /// 
                /// <b>Example:</b>
                /// <para>0%</para>
                /// </summary>
                [NameInMap("AgentRate")]
                [Validation(Required=false)]
                public string AgentRate { get; set; }

                /// <summary>
                /// <para>座席停用时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:01</para>
                /// </summary>
                [NameInMap("AgentStopTime")]
                [Validation(Required=false)]
                public string AgentStopTime { get; set; }

                /// <summary>
                /// <para>平均空闲时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:01</para>
                /// </summary>
                [NameInMap("AvgIdleTime")]
                [Validation(Required=false)]
                public string AvgIdleTime { get; set; }

                /// <summary>
                /// <para>平均置忙时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:00</para>
                /// </summary>
                [NameInMap("AvgPauseTime")]
                [Validation(Required=false)]
                public string AvgPauseTime { get; set; }

                /// <summary>
                /// <para>平均等待时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:00</para>
                /// </summary>
                [NameInMap("AvgPreviewObWaitTime")]
                [Validation(Required=false)]
                public string AvgPreviewObWaitTime { get; set; }

                /// <summary>
                /// <para>平均休息时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:03</para>
                /// </summary>
                [NameInMap("AvgRestTime")]
                [Validation(Required=false)]
                public string AvgRestTime { get; set; }

                /// <summary>
                /// <para>通话利用率</para>
                /// 
                /// <b>Example:</b>
                /// <para>66%</para>
                /// </summary>
                [NameInMap("CallUtilization")]
                [Validation(Required=false)]
                public string CallUtilization { get; set; }

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
                /// <para>创建时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-04-20 10:00:00</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>时间范围</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值</para>
                /// </summary>
                [NameInMap("DateTimeRange")]
                [Validation(Required=false)]
                public string DateTimeRange { get; set; }

                /// <summary>
                /// <para>统计日期</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-04-20</para>
                /// </summary>
                [NameInMap("Day")]
                [Validation(Required=false)]
                public string Day { get; set; }

                /// <summary>
                /// <para>主叫外呼客户接听数</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("DirectObAnsweredCount")]
                [Validation(Required=false)]
                public string DirectObAnsweredCount { get; set; }

                /// <summary>
                /// <para>主叫外呼接听量分布</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DirectObAnsweredDurationArray")]
                [Validation(Required=false)]
                public string DirectObAnsweredDurationArray { get; set; }

                /// <summary>
                /// <para>主叫外呼接听量分布描述</para>
                /// </summary>
                [NameInMap("DirectObAnsweredDurationDscArray")]
                [Validation(Required=false)]
                public List<string> DirectObAnsweredDurationDscArray { get; set; }

                /// <summary>
                /// <para>主叫外呼总时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:00</para>
                /// </summary>
                [NameInMap("DirectObBridgeDuration")]
                [Validation(Required=false)]
                public string DirectObBridgeDuration { get; set; }

                /// <summary>
                /// <para>主叫外呼双方接听分钟数</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:00</para>
                /// </summary>
                [NameInMap("DirectObBridgeTime")]
                [Validation(Required=false)]
                public string DirectObBridgeTime { get; set; }

                /// <summary>
                /// <para>主叫外呼咨询总次数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DirectObConsultCount")]
                [Validation(Required=false)]
                public string DirectObConsultCount { get; set; }

                /// <summary>
                /// <para>主叫外呼强插总次数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DirectObMonitorBargeCount")]
                [Validation(Required=false)]
                public string DirectObMonitorBargeCount { get; set; }

                /// <summary>
                /// <para>主叫外呼总监控强拆次数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DirectObMonitorDisconnectCount")]
                [Validation(Required=false)]
                public string DirectObMonitorDisconnectCount { get; set; }

                /// <summary>
                /// <para>主叫外呼监听总次数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DirectObMonitorSpyCount")]
                [Validation(Required=false)]
                public string DirectObMonitorSpyCount { get; set; }

                /// <summary>
                /// <para>主叫外呼监控三方总次数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DirectObMonitorThreewayCount")]
                [Validation(Required=false)]
                public string DirectObMonitorThreewayCount { get; set; }

                /// <summary>
                /// <para>主叫外呼耳语总次数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DirectObMonitorWhisperCount")]
                [Validation(Required=false)]
                public string DirectObMonitorWhisperCount { get; set; }

                /// <summary>
                /// <para>主叫外呼总次数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DirectObTotalCount")]
                [Validation(Required=false)]
                public string DirectObTotalCount { get; set; }

                /// <summary>
                /// <para>主叫外呼总分钟数</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:22</para>
                /// </summary>
                [NameInMap("DirectObTotalTime")]
                [Validation(Required=false)]
                public string DirectObTotalTime { get; set; }

                /// <summary>
                /// <para>主叫外呼转移总次数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DirectObTransferCount")]
                [Validation(Required=false)]
                public string DirectObTransferCount { get; set; }

                /// <summary>
                /// <para>主叫外呼有效接听数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DirectObValidCalls")]
                [Validation(Required=false)]
                public string DirectObValidCalls { get; set; }

                /// <summary>
                /// <para>主叫外呼有效接听时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:00</para>
                /// </summary>
                [NameInMap("DirectObValidTotalBridgeTime")]
                [Validation(Required=false)]
                public string DirectObValidTotalBridgeTime { get; set; }

                /// <summary>
                /// <para>企业id</para>
                /// 
                /// <b>Example:</b>
                /// <para>7000002</para>
                /// </summary>
                [NameInMap("EnterpriseId")]
                [Validation(Required=false)]
                public string EnterpriseId { get; set; }

                /// <summary>
                /// <para>工时利用率</para>
                /// 
                /// <b>Example:</b>
                /// <para>80%</para>
                /// </summary>
                [NameInMap("HoursUtilization")]
                [Validation(Required=false)]
                public string HoursUtilization { get; set; }

                /// <summary>
                /// <para>座席挂机数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("IbAgentHangupCount")]
                [Validation(Required=false)]
                public string IbAgentHangupCount { get; set; }

                /// <summary>
                /// <para>来电座席拒接数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("IbAgentRefuseCount")]
                [Validation(Required=false)]
                public string IbAgentRefuseCount { get; set; }

                /// <summary>
                /// <para>呼入座席接听数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("IbAnsweredCount")]
                [Validation(Required=false)]
                public string IbAnsweredCount { get; set; }

                /// <summary>
                /// <para>接听量分布</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;&quot;</para>
                /// </summary>
                [NameInMap("IbAnsweredDurationArray")]
                [Validation(Required=false)]
                public List<string> IbAnsweredDurationArray { get; set; }

                /// <summary>
                /// <para>呼入接听量分布描述</para>
                /// </summary>
                [NameInMap("IbAnsweredDurationDscArray")]
                [Validation(Required=false)]
                public List<string> IbAnsweredDurationDscArray { get; set; }

                /// <summary>
                /// <para>呼入接听平均延迟时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:00</para>
                /// </summary>
                [NameInMap("IbAvgAnswerDelayTime")]
                [Validation(Required=false)]
                public string IbAvgAnswerDelayTime { get; set; }

                /// <summary>
                /// <para>呼入平均通话时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:00</para>
                /// </summary>
                [NameInMap("IbAvgBridgeTime")]
                [Validation(Required=false)]
                public string IbAvgBridgeTime { get; set; }

                /// <summary>
                /// <para>呼入平均呼叫时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:00</para>
                /// </summary>
                [NameInMap("IbAvgCallingTime")]
                [Validation(Required=false)]
                public string IbAvgCallingTime { get; set; }

                /// <summary>
                /// <para>呼入平均保持时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:00</para>
                /// </summary>
                [NameInMap("IbAvgHoldTime")]
                [Validation(Required=false)]
                public string IbAvgHoldTime { get; set; }

                /// <summary>
                /// <para>呼入平均整理时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:10</para>
                /// </summary>
                [NameInMap("IbAvgWrapupTime")]
                [Validation(Required=false)]
                public string IbAvgWrapupTime { get; set; }

                /// <summary>
                /// <para>呼入通话次数</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("IbBridgeCount")]
                [Validation(Required=false)]
                public string IbBridgeCount { get; set; }

                /// <summary>
                /// <para>呼入通话分钟数</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:00</para>
                /// </summary>
                [NameInMap("IbBridgeMinute")]
                [Validation(Required=false)]
                public string IbBridgeMinute { get; set; }

                /// <summary>
                /// <para>呼入双方接听时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:00</para>
                /// </summary>
                [NameInMap("IbBridgeTime")]
                [Validation(Required=false)]
                public string IbBridgeTime { get; set; }

                /// <summary>
                /// <para>呼入呼叫次数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("IbCallingCount")]
                [Validation(Required=false)]
                public string IbCallingCount { get; set; }

                /// <summary>
                /// <para>呼入总呼叫时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:00</para>
                /// </summary>
                [NameInMap("IbCallingTime")]
                [Validation(Required=false)]
                public string IbCallingTime { get; set; }

                /// <summary>
                /// <para>呼入咨询数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("IbConsultCount")]
                [Validation(Required=false)]
                public string IbConsultCount { get; set; }

                /// <summary>
                /// <para>客户挂机数</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("IbCustomerHangupCount")]
                [Validation(Required=false)]
                public string IbCustomerHangupCount { get; set; }

                /// <summary>
                /// <para>呼叫保持次数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("IbHoldCount")]
                [Validation(Required=false)]
                public string IbHoldCount { get; set; }

                /// <summary>
                /// <para>呼入总保持时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:00</para>
                /// </summary>
                [NameInMap("IbHoldTime")]
                [Validation(Required=false)]
                public string IbHoldTime { get; set; }

                /// <summary>
                /// <para>呼入接听最大延迟时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:00</para>
                /// </summary>
                [NameInMap("IbMaxAnswerDelayTime")]
                [Validation(Required=false)]
                public string IbMaxAnswerDelayTime { get; set; }

                /// <summary>
                /// <para>呼入最大通话时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:00</para>
                /// </summary>
                [NameInMap("IbMaxBridgeTime")]
                [Validation(Required=false)]
                public string IbMaxBridgeTime { get; set; }

                /// <summary>
                /// <para>呼入最大呼叫时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:10</para>
                /// </summary>
                [NameInMap("IbMaxCallingTime")]
                [Validation(Required=false)]
                public string IbMaxCallingTime { get; set; }

                /// <summary>
                /// <para>呼入最大保持时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:00</para>
                /// </summary>
                [NameInMap("IbMaxHoldTime")]
                [Validation(Required=false)]
                public string IbMaxHoldTime { get; set; }

                /// <summary>
                /// <para>呼入最大整理时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:00</para>
                /// </summary>
                [NameInMap("IbMaxWrapupTime")]
                [Validation(Required=false)]
                public string IbMaxWrapupTime { get; set; }

                /// <summary>
                /// <para>呼入接听最小延迟时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:00</para>
                /// </summary>
                [NameInMap("IbMinAnswerDelayTime")]
                [Validation(Required=false)]
                public string IbMinAnswerDelayTime { get; set; }

                /// <summary>
                /// <para>呼入最小通话时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:10</para>
                /// </summary>
                [NameInMap("IbMinBridgeTime")]
                [Validation(Required=false)]
                public string IbMinBridgeTime { get; set; }

                /// <summary>
                /// <para>呼入最小呼叫时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:00</para>
                /// </summary>
                [NameInMap("IbMinCallingTime")]
                [Validation(Required=false)]
                public string IbMinCallingTime { get; set; }

                /// <summary>
                /// <para>呼入最小保持时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:00</para>
                /// </summary>
                [NameInMap("IbMinHoldTime")]
                [Validation(Required=false)]
                public string IbMinHoldTime { get; set; }

                /// <summary>
                /// <para>呼入最小整理时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:00</para>
                /// </summary>
                [NameInMap("IbMinWrapupTime")]
                [Validation(Required=false)]
                public string IbMinWrapupTime { get; set; }

                /// <summary>
                /// <para>呼入监控强插数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("IbMonitorBargeCount")]
                [Validation(Required=false)]
                public string IbMonitorBargeCount { get; set; }

                /// <summary>
                /// <para>呼入强插时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:00</para>
                /// </summary>
                [NameInMap("IbMonitorBargeDuration")]
                [Validation(Required=false)]
                public string IbMonitorBargeDuration { get; set; }

                /// <summary>
                /// <para>呼入监控强拆数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("IbMonitorDisconnectCount")]
                [Validation(Required=false)]
                public string IbMonitorDisconnectCount { get; set; }

                /// <summary>
                /// <para>呼入监控抢线数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("IbMonitorPickupCount")]
                [Validation(Required=false)]
                public string IbMonitorPickupCount { get; set; }

                /// <summary>
                /// <para>呼入抢线时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("IbMonitorPickupDuration")]
                [Validation(Required=false)]
                public string IbMonitorPickupDuration { get; set; }

                /// <summary>
                /// <para>呼入监控监听数</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("IbMonitorSpyCount")]
                [Validation(Required=false)]
                public string IbMonitorSpyCount { get; set; }

                /// <summary>
                /// <para>呼入监听时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:00</para>
                /// </summary>
                [NameInMap("IbMonitorSpyDuration")]
                [Validation(Required=false)]
                public string IbMonitorSpyDuration { get; set; }

                /// <summary>
                /// <para>呼入监控三方数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("IbMonitorThreewayCount")]
                [Validation(Required=false)]
                public string IbMonitorThreewayCount { get; set; }

                /// <summary>
                /// <para>呼入监控耳语数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("IbMonitorWhisperCount")]
                [Validation(Required=false)]
                public string IbMonitorWhisperCount { get; set; }

                /// <summary>
                /// <para>呼入耳语时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:00</para>
                /// </summary>
                [NameInMap("IbMonitorWhisperDuration")]
                [Validation(Required=false)]
                public string IbMonitorWhisperDuration { get; set; }

                /// <summary>
                /// <para>呼入接听总延迟时间</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:00</para>
                /// </summary>
                [NameInMap("IbTotalAnswerDelayTime")]
                [Validation(Required=false)]
                public string IbTotalAnswerDelayTime { get; set; }

                /// <summary>
                /// <para>总呼入座席数</para>
                /// 
                /// <b>Example:</b>
                /// <para>6</para>
                /// </summary>
                [NameInMap("IbTotalCount")]
                [Validation(Required=false)]
                public string IbTotalCount { get; set; }

                /// <summary>
                /// <para>呼入总分钟数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("IbTotalMinute")]
                [Validation(Required=false)]
                public string IbTotalMinute { get; set; }

                /// <summary>
                /// <para>呼入总通话时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("IbTotalTime")]
                [Validation(Required=false)]
                public string IbTotalTime { get; set; }

                /// <summary>
                /// <para>呼入转移数</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("IbTransferCount")]
                [Validation(Required=false)]
                public string IbTransferCount { get; set; }

                /// <summary>
                /// <para>呼入座席未接听数</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("IbUnansweredCount")]
                [Validation(Required=false)]
                public string IbUnansweredCount { get; set; }

                /// <summary>
                /// <para>座席来电接听数</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("IbUniqueAnsweredCount")]
                [Validation(Required=false)]
                public string IbUniqueAnsweredCount { get; set; }

                /// <summary>
                /// <para>座席来电数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("IbUniqueTotalCount")]
                [Validation(Required=false)]
                public string IbUniqueTotalCount { get; set; }

                /// <summary>
                /// <para>座席来电未接听数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("IbUniqueUnansweredCount")]
                [Validation(Required=false)]
                public string IbUniqueUnansweredCount { get; set; }

                /// <summary>
                /// <para>呼入有效通话次数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("IbValidCalls")]
                [Validation(Required=false)]
                public string IbValidCalls { get; set; }

                /// <summary>
                /// <para>呼入有效通话时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:10</para>
                /// </summary>
                [NameInMap("IbValidTotalBridgeTime")]
                [Validation(Required=false)]
                public string IbValidTotalBridgeTime { get; set; }

                /// <summary>
                /// <para>呼入整理次数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("IbWrapupCount")]
                [Validation(Required=false)]
                public string IbWrapupCount { get; set; }

                /// <summary>
                /// <para>呼入总整理时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:00</para>
                /// </summary>
                [NameInMap("IbWrapupTime")]
                [Validation(Required=false)]
                public string IbWrapupTime { get; set; }

                /// <summary>
                /// <para>id</para>
                /// 
                /// <b>Example:</b>
                /// <para>123124</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>空闲次数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("IdleCount")]
                [Validation(Required=false)]
                public string IdleCount { get; set; }

                /// <summary>
                /// <para>总空闲时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:00</para>
                /// </summary>
                [NameInMap("IdleTime")]
                [Validation(Required=false)]
                public string IdleTime { get; set; }

                /// <summary>
                /// <para>预览外呼IVR转移座席接听数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("IvrTransferBridgeCount")]
                [Validation(Required=false)]
                public string IvrTransferBridgeCount { get; set; }

                /// <summary>
                /// <para>预览外呼IVR转移双方接听时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:01</para>
                /// </summary>
                [NameInMap("IvrTransferBridgeDuration")]
                [Validation(Required=false)]
                public string IvrTransferBridgeDuration { get; set; }

                /// <summary>
                /// <para>预览外呼IVR转移座席数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("IvrTransferCount")]
                [Validation(Required=false)]
                public string IvrTransferCount { get; set; }

                /// <summary>
                /// <para>总登录时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:01</para>
                /// </summary>
                [NameInMap("LoginTime")]
                [Validation(Required=false)]
                public string LoginTime { get; set; }

                /// <summary>
                /// <para>最大空闲时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:00</para>
                /// </summary>
                [NameInMap("MaxIdleTime")]
                [Validation(Required=false)]
                public string MaxIdleTime { get; set; }

                /// <summary>
                /// <para>最大置忙时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:00</para>
                /// </summary>
                [NameInMap("MaxPauseTime")]
                [Validation(Required=false)]
                public string MaxPauseTime { get; set; }

                /// <summary>
                /// <para>最大休息时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:00</para>
                /// </summary>
                [NameInMap("MaxRestTime")]
                [Validation(Required=false)]
                public string MaxRestTime { get; set; }

                /// <summary>
                /// <para>最小空闲时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:01</para>
                /// </summary>
                [NameInMap("MinIdleTime")]
                [Validation(Required=false)]
                public string MinIdleTime { get; set; }

                /// <summary>
                /// <para>最小置忙时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:00</para>
                /// </summary>
                [NameInMap("MinPauseTime")]
                [Validation(Required=false)]
                public string MinPauseTime { get; set; }

                /// <summary>
                /// <para>最小休息时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:00</para>
                /// </summary>
                [NameInMap("MinRestTime")]
                [Validation(Required=false)]
                public string MinRestTime { get; set; }

                /// <summary>
                /// <para>外呼平均通话时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:00</para>
                /// </summary>
                [NameInMap("ObAvgBridgeTime")]
                [Validation(Required=false)]
                public string ObAvgBridgeTime { get; set; }

                /// <summary>
                /// <para>外呼平均呼叫时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:11</para>
                /// </summary>
                [NameInMap("ObAvgCallingTime")]
                [Validation(Required=false)]
                public string ObAvgCallingTime { get; set; }

                /// <summary>
                /// <para>外呼平均保持时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:50</para>
                /// </summary>
                [NameInMap("ObAvgHoldTime")]
                [Validation(Required=false)]
                public string ObAvgHoldTime { get; set; }

                /// <summary>
                /// <para>外呼平均整理时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:05</para>
                /// </summary>
                [NameInMap("ObAvgWrapupTime")]
                [Validation(Required=false)]
                public string ObAvgWrapupTime { get; set; }

                /// <summary>
                /// <para>外呼通话次数</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("ObBridgeCount")]
                [Validation(Required=false)]
                public string ObBridgeCount { get; set; }

                /// <summary>
                /// <para>外呼总通话时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>ObBridgeTime</para>
                /// </summary>
                [NameInMap("ObBridgeTime")]
                [Validation(Required=false)]
                public string ObBridgeTime { get; set; }

                /// <summary>
                /// <para>外呼呼叫次数</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ObCallingCount")]
                [Validation(Required=false)]
                public string ObCallingCount { get; set; }

                /// <summary>
                /// <para>外呼总呼叫时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:00</para>
                /// </summary>
                [NameInMap("ObCallingTime")]
                [Validation(Required=false)]
                public string ObCallingTime { get; set; }

                /// <summary>
                /// <para>外呼保持次数</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ObHoldCount")]
                [Validation(Required=false)]
                public string ObHoldCount { get; set; }

                /// <summary>
                /// <para>外呼总保持时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:10</para>
                /// </summary>
                [NameInMap("ObHoldTime")]
                [Validation(Required=false)]
                public string ObHoldTime { get; set; }

                /// <summary>
                /// <para>外呼最大通话时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:00</para>
                /// </summary>
                [NameInMap("ObMaxBridgeTime")]
                [Validation(Required=false)]
                public string ObMaxBridgeTime { get; set; }

                /// <summary>
                /// <para>外呼最大呼叫时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:03</para>
                /// </summary>
                [NameInMap("ObMaxCallingTime")]
                [Validation(Required=false)]
                public string ObMaxCallingTime { get; set; }

                /// <summary>
                /// <para>外呼最大保持时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:01</para>
                /// </summary>
                [NameInMap("ObMaxHoldTime")]
                [Validation(Required=false)]
                public string ObMaxHoldTime { get; set; }

                /// <summary>
                /// <para>外呼最大整理时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:22</para>
                /// </summary>
                [NameInMap("ObMaxWrapupTime")]
                [Validation(Required=false)]
                public string ObMaxWrapupTime { get; set; }

                /// <summary>
                /// <para>外呼最小通话时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:02</para>
                /// </summary>
                [NameInMap("ObMinBridgeTime")]
                [Validation(Required=false)]
                public string ObMinBridgeTime { get; set; }

                /// <summary>
                /// <para>外呼最小呼叫时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ObMinCallingTime")]
                [Validation(Required=false)]
                public string ObMinCallingTime { get; set; }

                /// <summary>
                /// <para>外呼最小保持时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:00</para>
                /// </summary>
                [NameInMap("ObMinHoldTime")]
                [Validation(Required=false)]
                public string ObMinHoldTime { get; set; }

                /// <summary>
                /// <para>外呼最小整理时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:00</para>
                /// </summary>
                [NameInMap("ObMinWrapupTime")]
                [Validation(Required=false)]
                public string ObMinWrapupTime { get; set; }

                /// <summary>
                /// <para>外呼双方接听时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:10</para>
                /// </summary>
                [NameInMap("ObRealBridgeTime")]
                [Validation(Required=false)]
                public string ObRealBridgeTime { get; set; }

                /// <summary>
                /// <para>外呼整理次数</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("ObWrapupCount")]
                [Validation(Required=false)]
                public string ObWrapupCount { get; set; }

                /// <summary>
                /// <para>外呼总整理时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:00</para>
                /// </summary>
                [NameInMap("ObWrapupTime")]
                [Validation(Required=false)]
                public string ObWrapupTime { get; set; }

                /// <summary>
                /// <para>置忙次数</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PauseCount")]
                [Validation(Required=false)]
                public string PauseCount { get; set; }

                /// <summary>
                /// <para>总置忙时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:10</para>
                /// </summary>
                [NameInMap("PauseTime")]
                [Validation(Required=false)]
                public string PauseTime { get; set; }

                /// <summary>
                /// <para>预测外呼座席接听通话总小时</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PredictObAgentAnsweredHour")]
                [Validation(Required=false)]
                public string PredictObAgentAnsweredHour { get; set; }

                /// <summary>
                /// <para>预测外呼座席接听通话总时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>72</para>
                /// </summary>
                [NameInMap("PredictObAgentAnsweredTime")]
                [Validation(Required=false)]
                public long? PredictObAgentAnsweredTime { get; set; }

                /// <summary>
                /// <para>预测外呼座席接听数</para>
                /// 
                /// <b>Example:</b>
                /// <para>27</para>
                /// </summary>
                [NameInMap("PredictObAnsweredCount")]
                [Validation(Required=false)]
                public long? PredictObAnsweredCount { get; set; }

                /// <summary>
                /// <para>预测外呼接听量分布</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;&quot;</para>
                /// </summary>
                [NameInMap("PredictObAnsweredDurationArray")]
                [Validation(Required=false)]
                public string PredictObAnsweredDurationArray { get; set; }

                /// <summary>
                /// <para>预测外呼咨询数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PredictObConsultCount")]
                [Validation(Required=false)]
                public string PredictObConsultCount { get; set; }

                /// <summary>
                /// <para>预测外呼监控强插数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PredictObMonitorBargeCount")]
                [Validation(Required=false)]
                public string PredictObMonitorBargeCount { get; set; }

                /// <summary>
                /// <para>预测外呼强插时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:00</para>
                /// </summary>
                [NameInMap("PredictObMonitorBargeDuration")]
                [Validation(Required=false)]
                public string PredictObMonitorBargeDuration { get; set; }

                /// <summary>
                /// <para>预测外呼监控强拆数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PredictObMonitorDisconnectCount")]
                [Validation(Required=false)]
                public string PredictObMonitorDisconnectCount { get; set; }

                /// <summary>
                /// <para>预测外呼监控监听数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PredictObMonitorSpyCount")]
                [Validation(Required=false)]
                public string PredictObMonitorSpyCount { get; set; }

                /// <summary>
                /// <para>预测外呼监听时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:00</para>
                /// </summary>
                [NameInMap("PredictObMonitorSpyDuration")]
                [Validation(Required=false)]
                public string PredictObMonitorSpyDuration { get; set; }

                /// <summary>
                /// <para>预测外呼监控三方数</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PredictObMonitorThreewayCount")]
                [Validation(Required=false)]
                public string PredictObMonitorThreewayCount { get; set; }

                /// <summary>
                /// <para>预测外呼监控耳语数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PredictObMonitorWhisperCount")]
                [Validation(Required=false)]
                public string PredictObMonitorWhisperCount { get; set; }

                /// <summary>
                /// <para>预测外呼耳语时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:00</para>
                /// </summary>
                [NameInMap("PredictObMonitorWhisperDuration")]
                [Validation(Required=false)]
                public string PredictObMonitorWhisperDuration { get; set; }

                /// <summary>
                /// <para>预测外呼总数</para>
                /// 
                /// <b>Example:</b>
                /// <para>39</para>
                /// </summary>
                [NameInMap("PredictObTotalCount")]
                [Validation(Required=false)]
                public long? PredictObTotalCount { get; set; }

                /// <summary>
                /// <para>预测外呼转移数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PredictObTransferCount")]
                [Validation(Required=false)]
                public string PredictObTransferCount { get; set; }

                /// <summary>
                /// <para>预测外呼有效通话数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PredictObValidCalls")]
                [Validation(Required=false)]
                public long? PredictObValidCalls { get; set; }

                /// <summary>
                /// <para>预测外呼有效通话总小时</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PredictObValidTotalBridgeHour")]
                [Validation(Required=false)]
                public string PredictObValidTotalBridgeHour { get; set; }

                /// <summary>
                /// <para>预测外呼有效通话时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>33</para>
                /// </summary>
                [NameInMap("PredictObValidTotalBridgeTime")]
                [Validation(Required=false)]
                public long? PredictObValidTotalBridgeTime { get; set; }

                /// <summary>
                /// <para>预览外呼座席接听率</para>
                /// 
                /// <b>Example:</b>
                /// <para>33%</para>
                /// </summary>
                [NameInMap("PreviewAgentAnswerdRate")]
                [Validation(Required=false)]
                public string PreviewAgentAnswerdRate { get; set; }

                /// <summary>
                /// <para>预览外呼客户接听率</para>
                /// 
                /// <b>Example:</b>
                /// <para>0%</para>
                /// </summary>
                [NameInMap("PreviewCustomerAnswerdRate")]
                [Validation(Required=false)]
                public string PreviewCustomerAnswerdRate { get; set; }

                /// <summary>
                /// <para>预览外呼座席接听数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PreviewObAgentAnsweredCount")]
                [Validation(Required=false)]
                public string PreviewObAgentAnsweredCount { get; set; }

                /// <summary>
                /// <para>预览外呼座席接听时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:01</para>
                /// </summary>
                [NameInMap("PreviewObAgentAnsweredTime")]
                [Validation(Required=false)]
                public string PreviewObAgentAnsweredTime { get; set; }

                /// <summary>
                /// <para>预览外呼双方接听数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PreviewObAnsweredCount")]
                [Validation(Required=false)]
                public string PreviewObAnsweredCount { get; set; }

                /// <summary>
                /// <para>预览外呼接听量分布</para>
                /// </summary>
                [NameInMap("PreviewObAnsweredDurationArray")]
                [Validation(Required=false)]
                public List<string> PreviewObAnsweredDurationArray { get; set; }

                /// <summary>
                /// <para>预览外呼接听量分布描述</para>
                /// </summary>
                [NameInMap("PreviewObAnsweredDurationDscArray")]
                [Validation(Required=false)]
                public List<string> PreviewObAnsweredDurationDscArray { get; set; }

                /// <summary>
                /// <para>预览外呼咨询数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PreviewObConsultCount")]
                [Validation(Required=false)]
                public string PreviewObConsultCount { get; set; }

                /// <summary>
                /// <para>预览外呼客户接听时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:00</para>
                /// </summary>
                [NameInMap("PreviewObCustomerAnsweredTime")]
                [Validation(Required=false)]
                public string PreviewObCustomerAnsweredTime { get; set; }

                /// <summary>
                /// <para>响铃数</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PreviewObCustomerRingingCount")]
                [Validation(Required=false)]
                public string PreviewObCustomerRingingCount { get; set; }

                /// <summary>
                /// <para>响铃率</para>
                /// 
                /// <b>Example:</b>
                /// <para>100%</para>
                /// </summary>
                [NameInMap("PreviewObCustomerRingingRate")]
                [Validation(Required=false)]
                public string PreviewObCustomerRingingRate { get; set; }

                /// <summary>
                /// <para>预览外呼监控强插数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PreviewObMonitorBargeCount")]
                [Validation(Required=false)]
                public string PreviewObMonitorBargeCount { get; set; }

                /// <summary>
                /// <para>预览外呼强插时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:00</para>
                /// </summary>
                [NameInMap("PreviewObMonitorBargeDuration")]
                [Validation(Required=false)]
                public string PreviewObMonitorBargeDuration { get; set; }

                /// <summary>
                /// <para>预览外呼监控强拆数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PreviewObMonitorDisconnectCount")]
                [Validation(Required=false)]
                public string PreviewObMonitorDisconnectCount { get; set; }

                /// <summary>
                /// <para>预览外呼监控监听数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PreviewObMonitorSpyCount")]
                [Validation(Required=false)]
                public string PreviewObMonitorSpyCount { get; set; }

                /// <summary>
                /// <para>预览外呼监听时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PreviewObMonitorSpyDuration")]
                [Validation(Required=false)]
                public string PreviewObMonitorSpyDuration { get; set; }

                /// <summary>
                /// <para>预览外呼监控三方数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PreviewObMonitorThreewayCount")]
                [Validation(Required=false)]
                public string PreviewObMonitorThreewayCount { get; set; }

                /// <summary>
                /// <para>预览外呼监控耳语数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PreviewObMonitorWhisperCount")]
                [Validation(Required=false)]
                public string PreviewObMonitorWhisperCount { get; set; }

                /// <summary>
                /// <para>预览外呼耳语时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:00</para>
                /// </summary>
                [NameInMap("PreviewObMonitorWhisperDuration")]
                [Validation(Required=false)]
                public string PreviewObMonitorWhisperDuration { get; set; }

                /// <summary>
                /// <para>预览外呼双方接听通话小时</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PreviewObTotalBridgeHour")]
                [Validation(Required=false)]
                public string PreviewObTotalBridgeHour { get; set; }

                /// <summary>
                /// <para>预览外呼双方接听通话时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:00</para>
                /// </summary>
                [NameInMap("PreviewObTotalBridgeTime")]
                [Validation(Required=false)]
                public string PreviewObTotalBridgeTime { get; set; }

                /// <summary>
                /// <para>总预览外呼数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PreviewObTotalCount")]
                [Validation(Required=false)]
                public string PreviewObTotalCount { get; set; }

                /// <summary>
                /// <para>预览外呼被转接听数</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PreviewObTransferBridgeCount")]
                [Validation(Required=false)]
                public string PreviewObTransferBridgeCount { get; set; }

                /// <summary>
                /// <para>预览外呼被转接听时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:00</para>
                /// </summary>
                [NameInMap("PreviewObTransferBridgeDuration")]
                [Validation(Required=false)]
                public string PreviewObTransferBridgeDuration { get; set; }

                /// <summary>
                /// <para>预览外呼被转数</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PreviewObTransferCount")]
                [Validation(Required=false)]
                public string PreviewObTransferCount { get; set; }

                /// <summary>
                /// <para>预览外呼有效通话次数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("PreviewObValidCalls")]
                [Validation(Required=false)]
                public string PreviewObValidCalls { get; set; }

                /// <summary>
                /// <para>预览外呼有效通话总小时</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PreviewObValidTotalBridgeHour")]
                [Validation(Required=false)]
                public string PreviewObValidTotalBridgeHour { get; set; }

                /// <summary>
                /// <para>预览外呼有效总通话时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:22</para>
                /// </summary>
                [NameInMap("PreviewObValidTotalBridgeTime")]
                [Validation(Required=false)]
                public string PreviewObValidTotalBridgeTime { get; set; }

                /// <summary>
                /// <para>队列名</para>
                /// 
                /// <b>Example:</b>
                /// <para>name3</para>
                /// </summary>
                [NameInMap("QueueName")]
                [Validation(Required=false)]
                public string QueueName { get; set; }

                /// <summary>
                /// <para>休息次数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RestCount")]
                [Validation(Required=false)]
                public string RestCount { get; set; }

                /// <summary>
                /// <para>总休息时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:00</para>
                /// </summary>
                [NameInMap("RestTime")]
                [Validation(Required=false)]
                public string RestTime { get; set; }

                /// <summary>
                /// <para>行名称</para>
                /// 
                /// <b>Example:</b>
                /// <para>示例值</para>
                /// </summary>
                [NameInMap("RowName")]
                [Validation(Required=false)]
                public string RowName { get; set; }

                /// <summary>
                /// <para>总双方接听时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:00</para>
                /// </summary>
                [NameInMap("TotalBridgeTime")]
                [Validation(Required=false)]
                public string TotalBridgeTime { get; set; }

                /// <summary>
                /// <para>webcall座席接听分钟数</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:00</para>
                /// </summary>
                [NameInMap("WebcallObAgentAnsweredTime")]
                [Validation(Required=false)]
                public string WebcallObAgentAnsweredTime { get; set; }

                /// <summary>
                /// <para>webcall双方接听数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("WebcallObAnsweredCount")]
                [Validation(Required=false)]
                public string WebcallObAnsweredCount { get; set; }

                /// <summary>
                /// <para>webcall接听量分布</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;&quot;</para>
                /// </summary>
                [NameInMap("WebcallObAnsweredDurationArray")]
                [Validation(Required=false)]
                public string WebcallObAnsweredDurationArray { get; set; }

                /// <summary>
                /// <para>webcall咨询数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("WebcallObConsultCount")]
                [Validation(Required=false)]
                public string WebcallObConsultCount { get; set; }

                /// <summary>
                /// <para>webcall监控强插数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("WebcallObMonitorBargeCount")]
                [Validation(Required=false)]
                public string WebcallObMonitorBargeCount { get; set; }

                /// <summary>
                /// <para>webcall强插时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:00</para>
                /// </summary>
                [NameInMap("WebcallObMonitorBargeDuration")]
                [Validation(Required=false)]
                public string WebcallObMonitorBargeDuration { get; set; }

                /// <summary>
                /// <para>webcall监控强拆数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("WebcallObMonitorDisconnectCount")]
                [Validation(Required=false)]
                public string WebcallObMonitorDisconnectCount { get; set; }

                /// <summary>
                /// <para>webcall监控监听数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("WebcallObMonitorSpyCount")]
                [Validation(Required=false)]
                public string WebcallObMonitorSpyCount { get; set; }

                /// <summary>
                /// <para>webcall监听时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:00</para>
                /// </summary>
                [NameInMap("WebcallObMonitorSpyDuration")]
                [Validation(Required=false)]
                public string WebcallObMonitorSpyDuration { get; set; }

                /// <summary>
                /// <para>webcall监控三方数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("WebcallObMonitorThreewayCount")]
                [Validation(Required=false)]
                public string WebcallObMonitorThreewayCount { get; set; }

                /// <summary>
                /// <para>webcall监控耳语数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("WebcallObMonitorWhisperCount")]
                [Validation(Required=false)]
                public string WebcallObMonitorWhisperCount { get; set; }

                /// <summary>
                /// <para>webcall耳语时长</para>
                /// 
                /// <b>Example:</b>
                /// <para>00:00:00</para>
                /// </summary>
                [NameInMap("WebcallObMonitorWhisperDuration")]
                [Validation(Required=false)]
                public string WebcallObMonitorWhisperDuration { get; set; }

                /// <summary>
                /// <para>总webcall数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("WebcallObTotalCount")]
                [Validation(Required=false)]
                public string WebcallObTotalCount { get; set; }

                /// <summary>
                /// <para>webcall转移数</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("WebcallObTransferCount")]
                [Validation(Required=false)]
                public string WebcallObTransferCount { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public string PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public string TotalCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalPageCount")]
            [Validation(Required=false)]
            public string TotalPageCount { get; set; }

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
        /// <para>756BCB70-492E-5877-ABEB-03BB5CA28540</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
