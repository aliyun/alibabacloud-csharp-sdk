// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListHistoricalAgentSkillGroupReportResponseBody : TeaModel {
        /// <summary>
        /// <para>Response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>List of historical agent skill group data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListHistoricalAgentSkillGroupReportResponseBodyData Data { get; set; }
        public class ListHistoricalAgentSkillGroupReportResponseBodyData : TeaModel {
            /// <summary>
            /// <para>List of historical agent skill group data.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListHistoricalAgentSkillGroupReportResponseBodyDataList> List { get; set; }
            public class ListHistoricalAgentSkillGroupReportResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>Agent ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>agent1@ccc-test</para>
                /// </summary>
                [NameInMap("AgentId")]
                [Validation(Required=false)]
                public string AgentId { get; set; }

                /// <summary>
                /// <para>Agent name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>云呼测试坐席</para>
                /// </summary>
                [NameInMap("AgentName")]
                [Validation(Required=false)]
                public string AgentName { get; set; }

                /// <summary>
                /// <para>Back-to-back call metrics.</para>
                /// </summary>
                [NameInMap("Back2Back")]
                [Validation(Required=false)]
                public ListHistoricalAgentSkillGroupReportResponseBodyDataListBack2Back Back2Back { get; set; }
                public class ListHistoricalAgentSkillGroupReportResponseBodyDataListBack2Back : TeaModel {
                    /// <summary>
                    /// <para>Agent-side answer rate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>已弃用，请使用AgentHandleRate代替此参数</para>
                    /// </summary>
                    [NameInMap("AgentAnswerRate")]
                    [Validation(Required=false)]
                    public float? AgentAnswerRate { get; set; }

                    /// <summary>
                    /// <para>Agent handle rate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.5</para>
                    /// </summary>
                    [NameInMap("AgentHandleRate")]
                    [Validation(Required=false)]
                    public float? AgentHandleRate { get; set; }

                    /// <summary>
                    /// <para>Answer rate. Formula: CallsAnswered/CallsDialed (Because answer events and offered events might fall into different time ranges, the result might sometimes exceed 100%).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.6</para>
                    /// </summary>
                    [NameInMap("AnswerRate")]
                    [Validation(Required=false)]
                    public float? AnswerRate { get; set; }

                    /// <summary>
                    /// <para>Average customer-side ring time in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("AverageCustomerRingTime")]
                    [Validation(Required=false)]
                    public float? AverageCustomerRingTime { get; set; }

                    /// <summary>
                    /// <para>Average ring time in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("AverageRingTime")]
                    [Validation(Required=false)]
                    public float? AverageRingTime { get; set; }

                    /// <summary>
                    /// <para>Average talk time in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("AverageTalkTime")]
                    [Validation(Required=false)]
                    public long? AverageTalkTime { get; set; }

                    /// <summary>
                    /// <para>Number of calls handled by agents.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("CallsAgentHandled")]
                    [Validation(Required=false)]
                    public long? CallsAgentHandled { get; set; }

                    /// <summary>
                    /// <para>Number of calls answered.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("CallsAnswered")]
                    [Validation(Required=false)]
                    public long? CallsAnswered { get; set; }

                    /// <summary>
                    /// <para>Number of calls answered by customers.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("CallsCustomerAnswered")]
                    [Validation(Required=false)]
                    public long? CallsCustomerAnswered { get; set; }

                    /// <summary>
                    /// <para>Number of customer-side pickups.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>已弃用，请使用CallsCustomerAnswered代替此参数</para>
                    /// </summary>
                    [NameInMap("CallsCustomerHandled")]
                    [Validation(Required=false)]
                    public long? CallsCustomerHandled { get; set; }

                    /// <summary>
                    /// <para>Number of calls dialed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("CallsDialed")]
                    [Validation(Required=false)]
                    public long? CallsDialed { get; set; }

                    /// <summary>
                    /// <para>Customer answer rate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.5</para>
                    /// </summary>
                    [NameInMap("CustomerAnswerRate")]
                    [Validation(Required=false)]
                    public float? CustomerAnswerRate { get; set; }

                    /// <summary>
                    /// <para>Customer-side handle rate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>已弃用，请使用CustomerAnswerRate代替此参数</para>
                    /// </summary>
                    [NameInMap("CustomerHandleRate")]
                    [Validation(Required=false)]
                    public float? CustomerHandleRate { get; set; }

                    /// <summary>
                    /// <para>Maximum customer-side ring time in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("MaxCustomerRingTime")]
                    [Validation(Required=false)]
                    public long? MaxCustomerRingTime { get; set; }

                    /// <summary>
                    /// <para>Maximum ring time in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("MaxRingTime")]
                    [Validation(Required=false)]
                    public long? MaxRingTime { get; set; }

                    /// <summary>
                    /// <para>Maximum talk time in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("MaxTalkTime")]
                    [Validation(Required=false)]
                    public long? MaxTalkTime { get; set; }

                    /// <summary>
                    /// <para>Total customer-side ring time in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("TotalCustomerRingTime")]
                    [Validation(Required=false)]
                    public long? TotalCustomerRingTime { get; set; }

                    /// <summary>
                    /// <para>Total ring time in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("TotalRingTime")]
                    [Validation(Required=false)]
                    public long? TotalRingTime { get; set; }

                    /// <summary>
                    /// <para>Total talk time in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("TotalTalkTime")]
                    [Validation(Required=false)]
                    public long? TotalTalkTime { get; set; }

                }

                /// <summary>
                /// <para>Agent\&quot;s employee ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1001</para>
                /// </summary>
                [NameInMap("DisplayId")]
                [Validation(Required=false)]
                public string DisplayId { get; set; }

                /// <summary>
                /// <para>Inbound metrics.</para>
                /// </summary>
                [NameInMap("Inbound")]
                [Validation(Required=false)]
                public ListHistoricalAgentSkillGroupReportResponseBodyDataListInbound Inbound { get; set; }
                public class ListHistoricalAgentSkillGroupReportResponseBodyDataListInbound : TeaModel {
                    /// <summary>
                    /// <para>Average first response time in chat sessions, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8</para>
                    /// </summary>
                    [NameInMap("AverageFirstResponseTime")]
                    [Validation(Required=false)]
                    public float? AverageFirstResponseTime { get; set; }

                    /// <summary>
                    /// <para>Average call hold time in seconds. Formula: TotalHoldTime/CallsHold.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("AverageHoldTime")]
                    [Validation(Required=false)]
                    public float? AverageHoldTime { get; set; }

                    /// <summary>
                    /// <para>Average response time in chat sessions.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>9</para>
                    /// </summary>
                    [NameInMap("AverageResponseTime")]
                    [Validation(Required=false)]
                    public float? AverageResponseTime { get; set; }

                    /// <summary>
                    /// <para>Average ring time in seconds. Formula: TotalRingTime/CallsRinged.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("AverageRingTime")]
                    [Validation(Required=false)]
                    public float? AverageRingTime { get; set; }

                    /// <summary>
                    /// <para>Average talk time in seconds. Formula: TotalTalkTime/CallsHandled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("AverageTalkTime")]
                    [Validation(Required=false)]
                    public float? AverageTalkTime { get; set; }

                    /// <summary>
                    /// <para>Average after-call work time in seconds. Formula: TotalWorkTime/CallsHandled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("AverageWorkTime")]
                    [Validation(Required=false)]
                    public float? AverageWorkTime { get; set; }

                    /// <summary>
                    /// <para>Number of attended transfers in. If a call is transferred multiple times to this agent, each transfer counts as one.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("CallsAttendedTransferIn")]
                    [Validation(Required=false)]
                    public long? CallsAttendedTransferIn { get; set; }

                    /// <summary>
                    /// <para>Number of attended transfers out. If a call is transferred multiple times to other agents, each transfer counts as one.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("CallsAttendedTransferOut")]
                    [Validation(Required=false)]
                    public long? CallsAttendedTransferOut { get; set; }

                    /// <summary>
                    /// <para>Number of blind transfers in. If a call is transferred multiple times to this agent, each transfer counts as one.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("CallsBlindTransferIn")]
                    [Validation(Required=false)]
                    public long? CallsBlindTransferIn { get; set; }

                    /// <summary>
                    /// <para>Number of blind transfers out. If a call is transferred multiple times to other agents, each transfer counts as one.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("CallsBlindTransferOut")]
                    [Validation(Required=false)]
                    public long? CallsBlindTransferOut { get; set; }

                    /// <summary>
                    /// <para>Number of calls handled, which is the number of times an agent answered a call.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("CallsHandled")]
                    [Validation(Required=false)]
                    public long? CallsHandled { get; set; }

                    /// <summary>
                    /// <para>Number of calls on hold, which is the number of times a call was put on hold.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("CallsHold")]
                    [Validation(Required=false)]
                    public long? CallsHold { get; set; }

                    /// <summary>
                    /// <para>Number of calls offered, which is the number of times calls were assigned to this agent, including blind transfers and attended transfers from other agents.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("CallsOffered")]
                    [Validation(Required=false)]
                    public long? CallsOffered { get; set; }

                    /// <summary>
                    /// <para>Number of calls that rang for the agent.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("CallsRinged")]
                    [Validation(Required=false)]
                    public long? CallsRinged { get; set; }

                    /// <summary>
                    /// <para>Handle rate. Formula: CallsHandled/CallsOffered (Because answer events and offered events might fall into different time ranges, the result might sometimes exceed 100%).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("HandleRate")]
                    [Validation(Required=false)]
                    public float? HandleRate { get; set; }

                    /// <summary>
                    /// <para>Maximum call hold time in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("MaxHoldTime")]
                    [Validation(Required=false)]
                    public long? MaxHoldTime { get; set; }

                    /// <summary>
                    /// <para>Maximum ring time in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("MaxRingTime")]
                    [Validation(Required=false)]
                    public long? MaxRingTime { get; set; }

                    /// <summary>
                    /// <para>Maximum talk time in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("MaxTalkTime")]
                    [Validation(Required=false)]
                    public long? MaxTalkTime { get; set; }

                    /// <summary>
                    /// <para>Maximum after-call work time in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("MaxWorkTime")]
                    [Validation(Required=false)]
                    public long? MaxWorkTime { get; set; }

                    /// <summary>
                    /// <para>Satisfaction index, which is the average value of the single-digit satisfaction key presses.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("SatisfactionIndex")]
                    [Validation(Required=false)]
                    public float? SatisfactionIndex { get; set; }

                    /// <summary>
                    /// <para>Satisfaction rate. Formula: Number of satisfied ratings/Number of satisfaction survey responses.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.5</para>
                    /// </summary>
                    [NameInMap("SatisfactionRate")]
                    [Validation(Required=false)]
                    public float? SatisfactionRate { get; set; }

                    /// <summary>
                    /// <para>Number of satisfaction surveys offered.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("SatisfactionSurveysOffered")]
                    [Validation(Required=false)]
                    public long? SatisfactionSurveysOffered { get; set; }

                    /// <summary>
                    /// <para>Number of satisfaction survey responses.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("SatisfactionSurveysResponded")]
                    [Validation(Required=false)]
                    public long? SatisfactionSurveysResponded { get; set; }

                    /// <summary>
                    /// <para>Total call hold time in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("TotalHoldTime")]
                    [Validation(Required=false)]
                    public long? TotalHoldTime { get; set; }

                    /// <summary>
                    /// <para>Total messages sent in chat sessions.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12</para>
                    /// </summary>
                    [NameInMap("TotalMessagesSent")]
                    [Validation(Required=false)]
                    public long? TotalMessagesSent { get; set; }

                    /// <summary>
                    /// <para>Total messages sent by agents in chat sessions.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>6</para>
                    /// </summary>
                    [NameInMap("TotalMessagesSentByAgent")]
                    [Validation(Required=false)]
                    public long? TotalMessagesSentByAgent { get; set; }

                    /// <summary>
                    /// <para>Total messages sent by customers in chat sessions.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>6</para>
                    /// </summary>
                    [NameInMap("TotalMessagesSentByCustomer")]
                    [Validation(Required=false)]
                    public long? TotalMessagesSentByCustomer { get; set; }

                    /// <summary>
                    /// <para>Total ring time in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("TotalRingTime")]
                    [Validation(Required=false)]
                    public long? TotalRingTime { get; set; }

                    /// <summary>
                    /// <para>Total talk time in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("TotalTalkTime")]
                    [Validation(Required=false)]
                    public long? TotalTalkTime { get; set; }

                    /// <summary>
                    /// <para>Total after-call work time in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("TotalWorkTime")]
                    [Validation(Required=false)]
                    public long? TotalWorkTime { get; set; }

                }

                /// <summary>
                /// <para>Internal call metrics.</para>
                /// </summary>
                [NameInMap("Internal")]
                [Validation(Required=false)]
                public ListHistoricalAgentSkillGroupReportResponseBodyDataListInternal Internal { get; set; }
                public class ListHistoricalAgentSkillGroupReportResponseBodyDataListInternal : TeaModel {
                    /// <summary>
                    /// <para>Average talk time in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("AverageTalkTime")]
                    [Validation(Required=false)]
                    public long? AverageTalkTime { get; set; }

                    /// <summary>
                    /// <para>Number of calls answered.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("CallsAnswered")]
                    [Validation(Required=false)]
                    public long? CallsAnswered { get; set; }

                    /// <summary>
                    /// <para>Number of calls dialed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("CallsDialed")]
                    [Validation(Required=false)]
                    public long? CallsDialed { get; set; }

                    /// <summary>
                    /// <para>Number of calls handled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("CallsHandled")]
                    [Validation(Required=false)]
                    public long? CallsHandled { get; set; }

                    /// <summary>
                    /// <para>Number of calls offered.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("CallsOffered")]
                    [Validation(Required=false)]
                    public long? CallsOffered { get; set; }

                    /// <summary>
                    /// <para>Number of calls the agent participated in.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("CallsTalk")]
                    [Validation(Required=false)]
                    public long? CallsTalk { get; set; }

                    /// <summary>
                    /// <para>Number of calls participated in.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("CallsTalked")]
                    [Validation(Required=false)]
                    public long? CallsTalked { get; set; }

                    /// <summary>
                    /// <para>Maximum talk time in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("MaxTalkTime")]
                    [Validation(Required=false)]
                    public long? MaxTalkTime { get; set; }

                    /// <summary>
                    /// <para>Total talk time in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("TotalTalkTime")]
                    [Validation(Required=false)]
                    public long? TotalTalkTime { get; set; }

                }

                /// <summary>
                /// <para>Outbound metrics.</para>
                /// </summary>
                [NameInMap("Outbound")]
                [Validation(Required=false)]
                public ListHistoricalAgentSkillGroupReportResponseBodyDataListOutbound Outbound { get; set; }
                public class ListHistoricalAgentSkillGroupReportResponseBodyDataListOutbound : TeaModel {
                    /// <summary>
                    /// <para>Answer rate. Formula: CallsAnswered/CallsDialed (Because answer events and offered events might fall into different time ranges, the result might sometimes exceed 100%).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.5</para>
                    /// </summary>
                    [NameInMap("AnswerRate")]
                    [Validation(Required=false)]
                    public float? AnswerRate { get; set; }

                    /// <summary>
                    /// <para>Average dialing time in seconds. Formula: TotalDialingTime/CallsDialed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("AverageDialingTime")]
                    [Validation(Required=false)]
                    public float? AverageDialingTime { get; set; }

                    /// <summary>
                    /// <para>Average call hold time in seconds. Formula: TotalHoldTime/CallsHold.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("AverageHoldTime")]
                    [Validation(Required=false)]
                    public float? AverageHoldTime { get; set; }

                    /// <summary>
                    /// <para>Average ring time in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("AverageRingTime")]
                    [Validation(Required=false)]
                    public float? AverageRingTime { get; set; }

                    /// <summary>
                    /// <para>Average talk time in seconds. Formula: TotalTalkTime/CallsAnswered.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("AverageTalkTime")]
                    [Validation(Required=false)]
                    public float? AverageTalkTime { get; set; }

                    /// <summary>
                    /// <para>Average after-call work time in seconds. Formula: TotalWorkTime/CallsDialed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("AverageWorkTime")]
                    [Validation(Required=false)]
                    public float? AverageWorkTime { get; set; }

                    /// <summary>
                    /// <para>Number of calls answered.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("CallsAnswered")]
                    [Validation(Required=false)]
                    public long? CallsAnswered { get; set; }

                    /// <summary>
                    /// <para>Number of attended transfers in. If a call is transferred multiple times to this agent, each transfer counts as one.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("CallsAttendedTransferIn")]
                    [Validation(Required=false)]
                    public long? CallsAttendedTransferIn { get; set; }

                    /// <summary>
                    /// <para>Number of attended transfers out. If a call is transferred multiple times to other agents, each transfer counts as one.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("CallsAttendedTransferOut")]
                    [Validation(Required=false)]
                    public long? CallsAttendedTransferOut { get; set; }

                    /// <summary>
                    /// <para>Number of blind transfers in. If a call is transferred multiple times to this agent, each transfer counts as one.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("CallsBlindTransferIn")]
                    [Validation(Required=false)]
                    public long? CallsBlindTransferIn { get; set; }

                    /// <summary>
                    /// <para>Number of blind transfers out. If a call is transferred multiple times to other agents, each transfer counts as one.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("CallsBlindTransferOut")]
                    [Validation(Required=false)]
                    public long? CallsBlindTransferOut { get; set; }

                    /// <summary>
                    /// <para>Number of calls dialed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("CallsDialed")]
                    [Validation(Required=false)]
                    public long? CallsDialed { get; set; }

                    /// <summary>
                    /// <para>Number of calls on hold, which is the number of times a call was put on hold.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("CallsHold")]
                    [Validation(Required=false)]
                    public long? CallsHold { get; set; }

                    /// <summary>
                    /// <para>Number of calls that rang for the agent.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("CallsRinged")]
                    [Validation(Required=false)]
                    public long? CallsRinged { get; set; }

                    /// <summary>
                    /// <para>Maximum dialing time in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("MaxDialingTime")]
                    [Validation(Required=false)]
                    public long? MaxDialingTime { get; set; }

                    /// <summary>
                    /// <para>Maximum call hold time in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("MaxHoldTime")]
                    [Validation(Required=false)]
                    public long? MaxHoldTime { get; set; }

                    /// <summary>
                    /// <para>Maximum ring time in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("MaxRingTime")]
                    [Validation(Required=false)]
                    public long? MaxRingTime { get; set; }

                    /// <summary>
                    /// <para>Maximum talk time in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("MaxTalkTime")]
                    [Validation(Required=false)]
                    public long? MaxTalkTime { get; set; }

                    /// <summary>
                    /// <para>Maximum after-call work time in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("MaxWorkTime")]
                    [Validation(Required=false)]
                    public long? MaxWorkTime { get; set; }

                    /// <summary>
                    /// <para>Satisfaction index, which is the average value of the single-digit satisfaction key presses.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1.4</para>
                    /// </summary>
                    [NameInMap("SatisfactionIndex")]
                    [Validation(Required=false)]
                    public float? SatisfactionIndex { get; set; }

                    /// <summary>
                    /// <para>Satisfaction rate. Formula: Number of satisfied ratings/Number of satisfaction survey responses.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.5</para>
                    /// </summary>
                    [NameInMap("SatisfactionRate")]
                    [Validation(Required=false)]
                    public float? SatisfactionRate { get; set; }

                    /// <summary>
                    /// <para>Number of satisfaction surveys offered.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("SatisfactionSurveysOffered")]
                    [Validation(Required=false)]
                    public long? SatisfactionSurveysOffered { get; set; }

                    /// <summary>
                    /// <para>Number of satisfaction survey responses.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("SatisfactionSurveysResponded")]
                    [Validation(Required=false)]
                    public long? SatisfactionSurveysResponded { get; set; }

                    /// <summary>
                    /// <para>Total dialing time in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("TotalDialingTime")]
                    [Validation(Required=false)]
                    public long? TotalDialingTime { get; set; }

                    /// <summary>
                    /// <para>Total call hold time in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("TotalHoldTime")]
                    [Validation(Required=false)]
                    public long? TotalHoldTime { get; set; }

                    /// <summary>
                    /// <para>Total ring time in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("TotalRingTime")]
                    [Validation(Required=false)]
                    public long? TotalRingTime { get; set; }

                    /// <summary>
                    /// <para>Total talk time in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("TotalTalkTime")]
                    [Validation(Required=false)]
                    public long? TotalTalkTime { get; set; }

                    /// <summary>
                    /// <para>Total after-call work time in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("TotalWorkTime")]
                    [Validation(Required=false)]
                    public long? TotalWorkTime { get; set; }

                }

                /// <summary>
                /// <para>Overall metrics.</para>
                /// </summary>
                [NameInMap("Overall")]
                [Validation(Required=false)]
                public ListHistoricalAgentSkillGroupReportResponseBodyDataListOverall Overall { get; set; }
                public class ListHistoricalAgentSkillGroupReportResponseBodyDataListOverall : TeaModel {
                    /// <summary>
                    /// <para>Average break time in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("AverageBreakTime")]
                    [Validation(Required=false)]
                    public float? AverageBreakTime { get; set; }

                    /// <summary>
                    /// <para>Average call hold time in seconds. Formula: TotalHoldTime/(Inbound CallsHold + Outbound CallsHold).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("AverageHoldTime")]
                    [Validation(Required=false)]
                    public float? AverageHoldTime { get; set; }

                    /// <summary>
                    /// <para>Average ready time in seconds. Formula: TotalReadyTime/Number of ready events. The number of ready events is not an API statistical field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("AverageReadyTime")]
                    [Validation(Required=false)]
                    public float? AverageReadyTime { get; set; }

                    /// <summary>
                    /// <para>Average talk time in seconds. Formula: TotalTalkTime/(CallsAnswered+CallsHandled).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("AverageTalkTime")]
                    [Validation(Required=false)]
                    public float? AverageTalkTime { get; set; }

                    /// <summary>
                    /// <para>Average after-call work time in seconds. Formula: TotalWorkTime/TotalCalls.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("AverageWorkTime")]
                    [Validation(Required=false)]
                    public float? AverageWorkTime { get; set; }

                    /// <summary>
                    /// <para>List of break code details.</para>
                    /// </summary>
                    [NameInMap("BreakCodeDetailList")]
                    [Validation(Required=false)]
                    public List<ListHistoricalAgentSkillGroupReportResponseBodyDataListOverallBreakCodeDetailList> BreakCodeDetailList { get; set; }
                    public class ListHistoricalAgentSkillGroupReportResponseBodyDataListOverallBreakCodeDetailList : TeaModel {
                        /// <summary>
                        /// <para>Break code.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>开会</para>
                        /// </summary>
                        [NameInMap("BreakCode")]
                        [Validation(Required=false)]
                        public string BreakCode { get; set; }

                        /// <summary>
                        /// <para>Count.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1</para>
                        /// </summary>
                        [NameInMap("Count")]
                        [Validation(Required=false)]
                        public long? Count { get; set; }

                        /// <summary>
                        /// <para>Duration in seconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>100</para>
                        /// </summary>
                        [NameInMap("Duration")]
                        [Validation(Required=false)]
                        public long? Duration { get; set; }

                    }

                    /// <summary>
                    /// <para>Earliest check-in time. Format is UNIX timestamp in milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1686030515000</para>
                    /// </summary>
                    [NameInMap("FirstCheckInTime")]
                    [Validation(Required=false)]
                    public long? FirstCheckInTime { get; set; }

                    /// <summary>
                    /// <para>Latest check-out time. Format is UNIX timestamp in milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1686030515000</para>
                    /// </summary>
                    [NameInMap("LastCheckOutTime")]
                    [Validation(Required=false)]
                    public long? LastCheckOutTime { get; set; }

                    /// <summary>
                    /// <para>Maximum break time in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("MaxBreakTime")]
                    [Validation(Required=false)]
                    public long? MaxBreakTime { get; set; }

                    /// <summary>
                    /// <para>Maximum call hold time in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("MaxHoldTime")]
                    [Validation(Required=false)]
                    public long? MaxHoldTime { get; set; }

                    /// <summary>
                    /// <para>Maximum ready time in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("MaxReadyTime")]
                    [Validation(Required=false)]
                    public long? MaxReadyTime { get; set; }

                    /// <summary>
                    /// <para>Maximum talk time in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("MaxTalkTime")]
                    [Validation(Required=false)]
                    public long? MaxTalkTime { get; set; }

                    /// <summary>
                    /// <para>Maximum after-call work time in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("MaxWorkTime")]
                    [Validation(Required=false)]
                    public long? MaxWorkTime { get; set; }

                    /// <summary>
                    /// <para>Agent occupancy rate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.5</para>
                    /// </summary>
                    [NameInMap("OccupancyRate")]
                    [Validation(Required=false)]
                    public float? OccupancyRate { get; set; }

                    /// <summary>
                    /// <para>Satisfaction index, which is the average value of the single-digit satisfaction key presses.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1.4</para>
                    /// </summary>
                    [NameInMap("SatisfactionIndex")]
                    [Validation(Required=false)]
                    public float? SatisfactionIndex { get; set; }

                    /// <summary>
                    /// <para>Satisfaction rate. Formula: Number of satisfied ratings/Number of satisfaction survey responses.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.5</para>
                    /// </summary>
                    [NameInMap("SatisfactionRate")]
                    [Validation(Required=false)]
                    public float? SatisfactionRate { get; set; }

                    /// <summary>
                    /// <para>Number of satisfaction surveys offered.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("SatisfactionSurveysOffered")]
                    [Validation(Required=false)]
                    public long? SatisfactionSurveysOffered { get; set; }

                    /// <summary>
                    /// <para>Number of satisfaction survey responses.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("SatisfactionSurveysResponded")]
                    [Validation(Required=false)]
                    public long? SatisfactionSurveysResponded { get; set; }

                    /// <summary>
                    /// <para>Total break time in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("TotalBreakTime")]
                    [Validation(Required=false)]
                    public long? TotalBreakTime { get; set; }

                    /// <summary>
                    /// <para>Total number of calls. Formula: CallsOffered + CallsDialed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("TotalCalls")]
                    [Validation(Required=false)]
                    public long? TotalCalls { get; set; }

                    /// <summary>
                    /// <para>Total hold time in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("TotalHoldTime")]
                    [Validation(Required=false)]
                    public long? TotalHoldTime { get; set; }

                    /// <summary>
                    /// <para>Total logged-in time in seconds.
                    /// <em>Note: This does not include offline or break time.</em></para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("TotalLoggedInTime")]
                    [Validation(Required=false)]
                    public long? TotalLoggedInTime { get; set; }

                    /// <summary>
                    /// <para>Total off-site logged-in time in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>120</para>
                    /// </summary>
                    [NameInMap("TotalOffSiteLggedInTime")]
                    [Validation(Required=false)]
                    public long? TotalOffSiteLggedInTime { get; set; }

                    /// <summary>
                    /// <para>Total office phone logged-in time in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>120</para>
                    /// </summary>
                    [NameInMap("TotalOfficePhoneLoggedInTime")]
                    [Validation(Required=false)]
                    public long? TotalOfficePhoneLoggedInTime { get; set; }

                    /// <summary>
                    /// <para>Total on-site logged-in time in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>120</para>
                    /// </summary>
                    [NameInMap("TotalOnSiteLoggedInTime")]
                    [Validation(Required=false)]
                    public string TotalOnSiteLoggedInTime { get; set; }

                    /// <summary>
                    /// <para>Total outbound-only logged-in time in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>120</para>
                    /// </summary>
                    [NameInMap("TotalOutboundScenarioLoggedInTime")]
                    [Validation(Required=false)]
                    public long? TotalOutboundScenarioLoggedInTime { get; set; }

                    /// <summary>
                    /// <para>Total outbound-only idle time in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("TotalOutboundScenarioReadyTime")]
                    [Validation(Required=false)]
                    public long? TotalOutboundScenarioReadyTime { get; set; }

                    /// <summary>
                    /// <para>Total outbound-only online time in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("TotalOutboundScenarioTime")]
                    [Validation(Required=false)]
                    public long? TotalOutboundScenarioTime { get; set; }

                    /// <summary>
                    /// <para>Total ready time in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("TotalReadyTime")]
                    [Validation(Required=false)]
                    public long? TotalReadyTime { get; set; }

                    /// <summary>
                    /// <para>Total talk time in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("TotalTalkTime")]
                    [Validation(Required=false)]
                    public long? TotalTalkTime { get; set; }

                    /// <summary>
                    /// <para>Total after-call work time in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("TotalWorkTime")]
                    [Validation(Required=false)]
                    public long? TotalWorkTime { get; set; }

                }

                /// <summary>
                /// <para>Skill group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>skillgroup1@ccc-test</para>
                /// </summary>
                [NameInMap("SkillGroupId")]
                [Validation(Required=false)]
                public string SkillGroupId { get; set; }

                /// <summary>
                /// <para>Skill group name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Default</para>
                /// </summary>
                [NameInMap("SkillGroupName")]
                [Validation(Required=false)]
                public string SkillGroupName { get; set; }

            }

            /// <summary>
            /// <para>Page number. Valid values are 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>Page size. Valid values are 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>Total count. Data is available only when PageNumber is 1. Otherwise, the value is 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>11</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BA03159C-E808-4FF1-B27E-A61B6E888D7F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
