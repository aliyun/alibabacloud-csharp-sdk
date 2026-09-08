// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListHistoricalAgentReportResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListHistoricalAgentReportResponseBodyData Data { get; set; }
        public class ListHistoricalAgentReportResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of agent historical data.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListHistoricalAgentReportResponseBodyDataList> List { get; set; }
            public class ListHistoricalAgentReportResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>The agent ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>agent1@ccc-test</para>
                /// </summary>
                [NameInMap("AgentId")]
                [Validation(Required=false)]
                public string AgentId { get; set; }

                /// <summary>
                /// <para>The agent name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Agent Wang.</para>
                /// </summary>
                [NameInMap("AgentName")]
                [Validation(Required=false)]
                public string AgentName { get; set; }

                /// <summary>
                /// <para>The back-to-back call metrics.</para>
                /// </summary>
                [NameInMap("Back2Back")]
                [Validation(Required=false)]
                public ListHistoricalAgentReportResponseBodyDataListBack2Back Back2Back { get; set; }
                public class ListHistoricalAgentReportResponseBodyDataListBack2Back : TeaModel {
                    /// <summary>
                    /// <para>The agent answer rate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("AgentHandleRate")]
                    [Validation(Required=false)]
                    public string AgentHandleRate { get; set; }

                    /// <summary>
                    /// <para>The answer rate. Formula: CallsAnswered/CallsDialed. Because the answer event and the dial event may fall within different time ranges, the result may exceed 100% in some cases.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.6</para>
                    /// </summary>
                    [NameInMap("AnswerRate")]
                    [Validation(Required=false)]
                    public string AnswerRate { get; set; }

                    /// <summary>
                    /// <para>The average customer-side ring duration. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("AverageCustomerRingTime")]
                    [Validation(Required=false)]
                    public string AverageCustomerRingTime { get; set; }

                    /// <summary>
                    /// <para>The average ring duration. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("AverageRingTime")]
                    [Validation(Required=false)]
                    public string AverageRingTime { get; set; }

                    /// <summary>
                    /// <para>The average talk duration. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("AverageTalkTime")]
                    [Validation(Required=false)]
                    public string AverageTalkTime { get; set; }

                    /// <summary>
                    /// <para>The number of calls answered by the agent.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("CallsAgentHandled")]
                    [Validation(Required=false)]
                    public string CallsAgentHandled { get; set; }

                    /// <summary>
                    /// <para>The number of calls answered.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("CallsAnswered")]
                    [Validation(Required=false)]
                    public string CallsAnswered { get; set; }

                    /// <summary>
                    /// <para>The number of calls answered by the customer.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>7</para>
                    /// </summary>
                    [NameInMap("CallsCustomerAnswered")]
                    [Validation(Required=false)]
                    public string CallsCustomerAnswered { get; set; }

                    /// <summary>
                    /// <para>The number of calls dialed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("CallsDialed")]
                    [Validation(Required=false)]
                    public string CallsDialed { get; set; }

                    /// <summary>
                    /// <para>The customer answer rate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.7</para>
                    /// </summary>
                    [NameInMap("CustomerAnswerRate")]
                    [Validation(Required=false)]
                    public string CustomerAnswerRate { get; set; }

                    /// <summary>
                    /// <para>The maximum customer-side ring duration. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("MaxCustomerRingTime")]
                    [Validation(Required=false)]
                    public string MaxCustomerRingTime { get; set; }

                    /// <summary>
                    /// <para>The maximum ring time. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("MaxRingTime")]
                    [Validation(Required=false)]
                    public string MaxRingTime { get; set; }

                    /// <summary>
                    /// <para>The maximum talk time. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("MaxTalkTime")]
                    [Validation(Required=false)]
                    public string MaxTalkTime { get; set; }

                    /// <summary>
                    /// <para>The total customer-side ring duration. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("TotalCustomerRingTime")]
                    [Validation(Required=false)]
                    public string TotalCustomerRingTime { get; set; }

                    /// <summary>
                    /// <para>The total ring time. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("TotalRingTime")]
                    [Validation(Required=false)]
                    public string TotalRingTime { get; set; }

                    /// <summary>
                    /// <para>The total talk time. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("TotalTalkTime")]
                    [Validation(Required=false)]
                    public string TotalTalkTime { get; set; }

                }

                /// <summary>
                /// <para>The agent display ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>001</para>
                /// </summary>
                [NameInMap("DisplayId")]
                [Validation(Required=false)]
                public string DisplayId { get; set; }

                /// <summary>
                /// <para>The inbound data.</para>
                /// </summary>
                [NameInMap("Inbound")]
                [Validation(Required=false)]
                public ListHistoricalAgentReportResponseBodyDataListInbound Inbound { get; set; }
                public class ListHistoricalAgentReportResponseBodyDataListInbound : TeaModel {
                    /// <summary>
                    /// <para>The statistics by channel.</para>
                    /// </summary>
                    [NameInMap("AccessChannelTypeDetails")]
                    [Validation(Required=false)]
                    public List<ListHistoricalAgentReportResponseBodyDataListInboundAccessChannelTypeDetails> AccessChannelTypeDetails { get; set; }
                    public class ListHistoricalAgentReportResponseBodyDataListInboundAccessChannelTypeDetails : TeaModel {
                        /// <summary>
                        /// <para>The channel type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Web</para>
                        /// </summary>
                        [NameInMap("AccessChannelType")]
                        [Validation(Required=false)]
                        public string AccessChannelType { get; set; }

                        /// <summary>
                        /// <para>The number of sessions offered.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("CallsOffered")]
                        [Validation(Required=false)]
                        public long? CallsOffered { get; set; }

                    }

                    /// <summary>
                    /// <para>The average first response time for chat sessions. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("AverageFirstResponseTime")]
                    [Validation(Required=false)]
                    public float? AverageFirstResponseTime { get; set; }

                    /// <summary>
                    /// <para>The average hold time. Formula: TotalHoldTime/CallsHold. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("AverageHoldTime")]
                    [Validation(Required=false)]
                    public float? AverageHoldTime { get; set; }

                    /// <summary>
                    /// <para>The average response time for chat sessions.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12</para>
                    /// </summary>
                    [NameInMap("AverageResponseTime")]
                    [Validation(Required=false)]
                    public float? AverageResponseTime { get; set; }

                    /// <summary>
                    /// <para>The average ring time. Formula: TotalRingTime/CallsRinged. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("AverageRingTime")]
                    [Validation(Required=false)]
                    public float? AverageRingTime { get; set; }

                    /// <summary>
                    /// <para>The average talk time. Formula: TotalTalkTime/CallsHandled. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("AverageTalkTime")]
                    [Validation(Required=false)]
                    public float? AverageTalkTime { get; set; }

                    /// <summary>
                    /// <para>The average after-call work (ACW) time. Formula: TotalWorkTime/CallsHandled. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("AverageWorkTime")]
                    [Validation(Required=false)]
                    public float? AverageWorkTime { get; set; }

                    /// <summary>
                    /// <para>The number of attended transfers in. If a call is transferred in to this agent multiple times, each transfer is counted separately.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CallsAttendedTransferIn")]
                    [Validation(Required=false)]
                    public long? CallsAttendedTransferIn { get; set; }

                    /// <summary>
                    /// <para>The number of attended transfers out. If a call is transferred out to other agents multiple times, each transfer is counted separately.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CallsAttendedTransferOut")]
                    [Validation(Required=false)]
                    public long? CallsAttendedTransferOut { get; set; }

                    /// <summary>
                    /// <para>The number of blind transfers in. If a call is transferred in to this agent multiple times, each transfer is counted separately.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CallsBlindTransferIn")]
                    [Validation(Required=false)]
                    public long? CallsBlindTransferIn { get; set; }

                    /// <summary>
                    /// <para>The number of blind transfers out. If a call is transferred out to other agents multiple times, each transfer is counted separately.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CallsBlindTransferOut")]
                    [Validation(Required=false)]
                    public long? CallsBlindTransferOut { get; set; }

                    /// <summary>
                    /// <para>The number of calls answered by the agent.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CallsHandled")]
                    [Validation(Required=false)]
                    public long? CallsHandled { get; set; }

                    /// <summary>
                    /// <para>The number of holds, which is the number of times calls were placed on hold.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CallsHold")]
                    [Validation(Required=false)]
                    public long? CallsHold { get; set; }

                    /// <summary>
                    /// <para>The number of calls offered, which is the number of calls assigned to this agent, including calls blind-transferred and attended-transferred from other agents.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CallsOffered")]
                    [Validation(Required=false)]
                    public long? CallsOffered { get; set; }

                    /// <summary>
                    /// <para>The number of calls that rang the agent.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CallsRinged")]
                    [Validation(Required=false)]
                    public long? CallsRinged { get; set; }

                    /// <summary>
                    /// <para>The handle rate. Formula: CallsHandled/CallsOffered. Because the answer event and the offered event may fall within different time ranges, the result may exceed 100% in some cases.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("HandleRate")]
                    [Validation(Required=false)]
                    public float? HandleRate { get; set; }

                    /// <summary>
                    /// <para>The maximum hold time. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("MaxHoldTime")]
                    [Validation(Required=false)]
                    public long? MaxHoldTime { get; set; }

                    /// <summary>
                    /// <para>The maximum ring time. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("MaxRingTime")]
                    [Validation(Required=false)]
                    public long? MaxRingTime { get; set; }

                    /// <summary>
                    /// <para>The maximum talk time. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("MaxTalkTime")]
                    [Validation(Required=false)]
                    public long? MaxTalkTime { get; set; }

                    /// <summary>
                    /// <para>The maximum after-call work (ACW) time. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("MaxWorkTime")]
                    [Validation(Required=false)]
                    public long? MaxWorkTime { get; set; }

                    /// <summary>
                    /// <para>The satisfaction index, which is the average value of satisfaction survey key presses (single-digit numbers).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("SatisfactionIndex")]
                    [Validation(Required=false)]
                    public float? SatisfactionIndex { get; set; }

                    /// <summary>
                    /// <para>The satisfaction rate. Formula: number of satisfied ratings/number of satisfaction survey responses.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("SatisfactionRate")]
                    [Validation(Required=false)]
                    public float? SatisfactionRate { get; set; }

                    /// <summary>
                    /// <para>The number of satisfaction surveys sent.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("SatisfactionSurveysOffered")]
                    [Validation(Required=false)]
                    public long? SatisfactionSurveysOffered { get; set; }

                    /// <summary>
                    /// <para>The number of satisfaction survey responses.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("SatisfactionSurveysResponded")]
                    [Validation(Required=false)]
                    public long? SatisfactionSurveysResponded { get; set; }

                    /// <summary>
                    /// <para>The 15-second service level.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.85</para>
                    /// </summary>
                    [NameInMap("ServiceLevel15")]
                    [Validation(Required=false)]
                    public float? ServiceLevel15 { get; set; }

                    /// <summary>
                    /// <para>The total hold time. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("TotalHoldTime")]
                    [Validation(Required=false)]
                    public long? TotalHoldTime { get; set; }

                    /// <summary>
                    /// <para>The total number of messages sent in chat sessions.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>16</para>
                    /// </summary>
                    [NameInMap("TotalMessagesSent")]
                    [Validation(Required=false)]
                    public long? TotalMessagesSent { get; set; }

                    /// <summary>
                    /// <para>The total number of messages sent by the agent in chat sessions.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>7</para>
                    /// </summary>
                    [NameInMap("TotalMessagesSentByAgent")]
                    [Validation(Required=false)]
                    public long? TotalMessagesSentByAgent { get; set; }

                    /// <summary>
                    /// <para>The total number of messages sent by the customer in chat sessions.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>9</para>
                    /// </summary>
                    [NameInMap("TotalMessagesSentByCustomer")]
                    [Validation(Required=false)]
                    public string TotalMessagesSentByCustomer { get; set; }

                    /// <summary>
                    /// <para>The total ring time. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("TotalRingTime")]
                    [Validation(Required=false)]
                    public long? TotalRingTime { get; set; }

                    /// <summary>
                    /// <para>The total talk time. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("TotalTalkTime")]
                    [Validation(Required=false)]
                    public long? TotalTalkTime { get; set; }

                    /// <summary>
                    /// <para>The total after-call work (ACW) time. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("TotalWorkTime")]
                    [Validation(Required=false)]
                    public long? TotalWorkTime { get; set; }

                }

                /// <summary>
                /// <para>The internal call metrics.</para>
                /// </summary>
                [NameInMap("Internal")]
                [Validation(Required=false)]
                public ListHistoricalAgentReportResponseBodyDataListInternal Internal { get; set; }
                public class ListHistoricalAgentReportResponseBodyDataListInternal : TeaModel {
                    /// <summary>
                    /// <para>The average talk duration. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("AverageTalkTime")]
                    [Validation(Required=false)]
                    public float? AverageTalkTime { get; set; }

                    /// <summary>
                    /// <para>The number of calls answered.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("CallsAnswered")]
                    [Validation(Required=false)]
                    public long? CallsAnswered { get; set; }

                    /// <summary>
                    /// <para>The number of calls dialed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("CallsDialed")]
                    [Validation(Required=false)]
                    public long? CallsDialed { get; set; }

                    /// <summary>
                    /// <para>The number of calls answered.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("CallsHandled")]
                    [Validation(Required=false)]
                    public long? CallsHandled { get; set; }

                    /// <summary>
                    /// <para>The number of inbound calls.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("CallsOffered")]
                    [Validation(Required=false)]
                    public long? CallsOffered { get; set; }

                    /// <summary>
                    /// <para>The number of calls participated in.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("CallsTalked")]
                    [Validation(Required=false)]
                    public long? CallsTalked { get; set; }

                    /// <summary>
                    /// <para>The maximum talk time. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("MaxTalkTime")]
                    [Validation(Required=false)]
                    public long? MaxTalkTime { get; set; }

                    /// <summary>
                    /// <para>The total talk time. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("TotalTalkTime")]
                    [Validation(Required=false)]
                    public long? TotalTalkTime { get; set; }

                }

                /// <summary>
                /// <para>The outbound data.</para>
                /// </summary>
                [NameInMap("Outbound")]
                [Validation(Required=false)]
                public ListHistoricalAgentReportResponseBodyDataListOutbound Outbound { get; set; }
                public class ListHistoricalAgentReportResponseBodyDataListOutbound : TeaModel {
                    /// <summary>
                    /// <para>The answer rate. Formula: CallsAnswered/CallsDialed. Because the answer event and the dial event may fall within different time ranges, the result may exceed 100% in some cases.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("AnswerRate")]
                    [Validation(Required=false)]
                    public float? AnswerRate { get; set; }

                    /// <summary>
                    /// <para>The average dialing time. Formula: TotalDialingTime/CallsDialed. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("AverageDialingTime")]
                    [Validation(Required=false)]
                    public float? AverageDialingTime { get; set; }

                    /// <summary>
                    /// <para>The average hold time. Formula: TotalHoldTime/CallsHold. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("AverageHoldTime")]
                    [Validation(Required=false)]
                    public float? AverageHoldTime { get; set; }

                    /// <summary>
                    /// <para>The average ring time. Formula: TotalRingTime/CallsRinged. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("AverageRingTime")]
                    [Validation(Required=false)]
                    public float? AverageRingTime { get; set; }

                    /// <summary>
                    /// <para>The average talk time. Formula: TotalTalkTime/CallsAnswered. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("AverageTalkTime")]
                    [Validation(Required=false)]
                    public float? AverageTalkTime { get; set; }

                    /// <summary>
                    /// <para>The average after-call work (ACW) time. Formula: TotalWorkTime/CallsDialed. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("AverageWorkTime")]
                    [Validation(Required=false)]
                    public float? AverageWorkTime { get; set; }

                    /// <summary>
                    /// <para>The number of calls answered.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CallsAnswered")]
                    [Validation(Required=false)]
                    public long? CallsAnswered { get; set; }

                    /// <summary>
                    /// <para>The number of attended transfers in. If a call is transferred in to this agent multiple times, each transfer is counted separately.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CallsAttendedTransferIn")]
                    [Validation(Required=false)]
                    public long? CallsAttendedTransferIn { get; set; }

                    /// <summary>
                    /// <para>The number of attended transfers out. If a call is transferred out to other agents multiple times, each transfer is counted separately.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CallsAttendedTransferOut")]
                    [Validation(Required=false)]
                    public long? CallsAttendedTransferOut { get; set; }

                    /// <summary>
                    /// <para>The number of blind transfers in. If a call is transferred in to this agent multiple times, each transfer is counted separately.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CallsBlindTransferIn")]
                    [Validation(Required=false)]
                    public long? CallsBlindTransferIn { get; set; }

                    /// <summary>
                    /// <para>The number of blind transfers out. If a call is transferred out to other agents multiple times, each transfer is counted separately.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CallsBlindTransferOut")]
                    [Validation(Required=false)]
                    public long? CallsBlindTransferOut { get; set; }

                    /// <summary>
                    /// <para>The number of calls dialed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CallsDialed")]
                    [Validation(Required=false)]
                    public long? CallsDialed { get; set; }

                    /// <summary>
                    /// <para>The number of holds, which is the number of times calls were placed on hold.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CallsHold")]
                    [Validation(Required=false)]
                    public long? CallsHold { get; set; }

                    /// <summary>
                    /// <para>The number of calls that rang the agent.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CallsRinged")]
                    [Validation(Required=false)]
                    public long? CallsRinged { get; set; }

                    /// <summary>
                    /// <para>The maximum dialing time. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("MaxDialingTime")]
                    [Validation(Required=false)]
                    public long? MaxDialingTime { get; set; }

                    /// <summary>
                    /// <para>The maximum hold time. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("MaxHoldTime")]
                    [Validation(Required=false)]
                    public long? MaxHoldTime { get; set; }

                    /// <summary>
                    /// <para>The maximum ring time. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("MaxRingTime")]
                    [Validation(Required=false)]
                    public long? MaxRingTime { get; set; }

                    /// <summary>
                    /// <para>The maximum talk time. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("MaxTalkTime")]
                    [Validation(Required=false)]
                    public long? MaxTalkTime { get; set; }

                    /// <summary>
                    /// <para>The maximum after-call work (ACW) time. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("MaxWorkTime")]
                    [Validation(Required=false)]
                    public long? MaxWorkTime { get; set; }

                    /// <summary>
                    /// <para>The satisfaction index, which is the average value of satisfaction survey key presses (single-digit numbers).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("SatisfactionIndex")]
                    [Validation(Required=false)]
                    public float? SatisfactionIndex { get; set; }

                    /// <summary>
                    /// <para>The satisfaction rate. Formula: number of satisfied ratings/number of satisfaction survey responses.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("SatisfactionRate")]
                    [Validation(Required=false)]
                    public float? SatisfactionRate { get; set; }

                    /// <summary>
                    /// <para>The number of satisfaction surveys sent.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("SatisfactionSurveysOffered")]
                    [Validation(Required=false)]
                    public long? SatisfactionSurveysOffered { get; set; }

                    /// <summary>
                    /// <para>The number of satisfaction survey responses.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("SatisfactionSurveysResponded")]
                    [Validation(Required=false)]
                    public long? SatisfactionSurveysResponded { get; set; }

                    /// <summary>
                    /// <para>The total dialing time. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("TotalDialingTime")]
                    [Validation(Required=false)]
                    public long? TotalDialingTime { get; set; }

                    /// <summary>
                    /// <para>The total hold time. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("TotalHoldTime")]
                    [Validation(Required=false)]
                    public long? TotalHoldTime { get; set; }

                    /// <summary>
                    /// <para>The total ring time. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("TotalRingTime")]
                    [Validation(Required=false)]
                    public long? TotalRingTime { get; set; }

                    /// <summary>
                    /// <para>The total talk time. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("TotalTalkTime")]
                    [Validation(Required=false)]
                    public long? TotalTalkTime { get; set; }

                    /// <summary>
                    /// <para>The total after-call work (ACW) time. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("TotalWorkTime")]
                    [Validation(Required=false)]
                    public long? TotalWorkTime { get; set; }

                }

                /// <summary>
                /// <para>The overall data.</para>
                /// </summary>
                [NameInMap("Overall")]
                [Validation(Required=false)]
                public ListHistoricalAgentReportResponseBodyDataListOverall Overall { get; set; }
                public class ListHistoricalAgentReportResponseBodyDataListOverall : TeaModel {
                    /// <summary>
                    /// <para>The average break duration. Formula: TotalBreakTime / number of breaks. The number of breaks is a non-API statistical field. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("AverageBreakTime")]
                    [Validation(Required=false)]
                    public float? AverageBreakTime { get; set; }

                    /// <summary>
                    /// <para>The average hold duration. Unit: seconds. Formula: TotalHoldTime / (inbound CallsHold + outbound CallsHold).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("AverageHoldTime")]
                    [Validation(Required=false)]
                    public float? AverageHoldTime { get; set; }

                    /// <summary>
                    /// <para>The average ready duration. Formula: TotalReadyTime / number of ready states. The number of ready states is a non-API statistical field. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("AverageReadyTime")]
                    [Validation(Required=false)]
                    public float? AverageReadyTime { get; set; }

                    /// <summary>
                    /// <para>The average talk duration. Formula: TotalTalkTime / (CallsAnswered + CallsHandled). Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("AverageTalkTime")]
                    [Validation(Required=false)]
                    public float? AverageTalkTime { get; set; }

                    /// <summary>
                    /// <para>The average after-call work duration. Formula: TotalWorkTime / TotalCalls. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("AverageWorkTime")]
                    [Validation(Required=false)]
                    public float? AverageWorkTime { get; set; }

                    /// <summary>
                    /// <para>The statistics for each break type.</para>
                    /// </summary>
                    [NameInMap("BreakCodeDetailList")]
                    [Validation(Required=false)]
                    public List<ListHistoricalAgentReportResponseBodyDataListOverallBreakCodeDetailList> BreakCodeDetailList { get; set; }
                    public class ListHistoricalAgentReportResponseBodyDataListOverallBreakCodeDetailList : TeaModel {
                        /// <summary>
                        /// <para>The break type code.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Meeting.</para>
                        /// </summary>
                        [NameInMap("BreakCode")]
                        [Validation(Required=false)]
                        public string BreakCode { get; set; }

                        /// <summary>
                        /// <para>The number of occurrences of this break type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3</para>
                        /// </summary>
                        [NameInMap("Count")]
                        [Validation(Required=false)]
                        public long? Count { get; set; }

                        /// <summary>
                        /// <para>The total duration of this break type. Unit: seconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>120</para>
                        /// </summary>
                        [NameInMap("Duration")]
                        [Validation(Required=false)]
                        public long? Duration { get; set; }

                    }

                    /// <summary>
                    /// <para>The earliest check-in time. The value is a UNIX timestamp. Unit: milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1686030515000</para>
                    /// </summary>
                    [NameInMap("FirstCheckInTime")]
                    [Validation(Required=false)]
                    public long? FirstCheckInTime { get; set; }

                    /// <summary>
                    /// <para>The last check-out time. The value is a UNIX timestamp. Unit: milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1686030515000</para>
                    /// </summary>
                    [NameInMap("LastCheckOutTime")]
                    [Validation(Required=false)]
                    public long? LastCheckOutTime { get; set; }

                    /// <summary>
                    /// <para>The maximum break duration. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("MaxBreakTime")]
                    [Validation(Required=false)]
                    public long? MaxBreakTime { get; set; }

                    /// <summary>
                    /// <para>The maximum hold time. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("MaxHoldTime")]
                    [Validation(Required=false)]
                    public long? MaxHoldTime { get; set; }

                    /// <summary>
                    /// <para>The maximum ready duration. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("MaxReadyTime")]
                    [Validation(Required=false)]
                    public long? MaxReadyTime { get; set; }

                    /// <summary>
                    /// <para>The maximum talk time. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("MaxTalkTime")]
                    [Validation(Required=false)]
                    public long? MaxTalkTime { get; set; }

                    /// <summary>
                    /// <para>The maximum after-call work (ACW) time. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("MaxWorkTime")]
                    [Validation(Required=false)]
                    public long? MaxWorkTime { get; set; }

                    /// <summary>
                    /// <para>The agent occupancy rate. Formula: (TotalWorkTime + TotalTalkTime) / TotalLoggedInTime.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("OccupancyRate")]
                    [Validation(Required=false)]
                    public float? OccupancyRate { get; set; }

                    /// <summary>
                    /// <para>The satisfaction index, which is the average value of satisfaction survey key presses (single-digit numbers).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("SatisfactionIndex")]
                    [Validation(Required=false)]
                    public float? SatisfactionIndex { get; set; }

                    /// <summary>
                    /// <para>The satisfaction rate. Formula: number of satisfied ratings/number of satisfaction survey responses.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("SatisfactionRate")]
                    [Validation(Required=false)]
                    public float? SatisfactionRate { get; set; }

                    /// <summary>
                    /// <para>The number of satisfaction surveys sent.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("SatisfactionSurveysOffered")]
                    [Validation(Required=false)]
                    public long? SatisfactionSurveysOffered { get; set; }

                    /// <summary>
                    /// <para>The number of satisfaction survey responses.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("SatisfactionSurveysResponded")]
                    [Validation(Required=false)]
                    public long? SatisfactionSurveysResponded { get; set; }

                    /// <summary>
                    /// <para>The total break duration. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("TotalBreakTime")]
                    [Validation(Required=false)]
                    public long? TotalBreakTime { get; set; }

                    /// <summary>
                    /// <para>The total number of calls. Formula: CallsOffered + CallsDialed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("TotalCalls")]
                    [Validation(Required=false)]
                    public long? TotalCalls { get; set; }

                    /// <summary>
                    /// <para>The total hold duration. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("TotalHoldTime")]
                    [Validation(Required=false)]
                    public long? TotalHoldTime { get; set; }

                    /// <summary>
                    /// <para>The total logged-in duration, excluding break time. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("TotalLoggedInTime")]
                    [Validation(Required=false)]
                    public long? TotalLoggedInTime { get; set; }

                    /// <summary>
                    /// <para>The total off-site online duration. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("TotalOffSiteLoggedInTime")]
                    [Validation(Required=false)]
                    public long? TotalOffSiteLoggedInTime { get; set; }

                    /// <summary>
                    /// <para>The total off-site online duration. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Deprecated. Use TotalOffSiteLoggedInTime instead.</para>
                    /// </summary>
                    [NameInMap("TotalOffSiteOnlineTime")]
                    [Validation(Required=false)]
                    public long? TotalOffSiteOnlineTime { get; set; }

                    /// <summary>
                    /// <para>The total online duration in office phone mode. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3600</para>
                    /// </summary>
                    [NameInMap("TotalOfficePhoneLoggedInTime")]
                    [Validation(Required=false)]
                    public long? TotalOfficePhoneLoggedInTime { get; set; }

                    /// <summary>
                    /// <para>The total online duration in office phone mode. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Deprecated. Use TotalOfficePhoneLoggedInTime instead.</para>
                    /// </summary>
                    [NameInMap("TotalOfficePhoneOnlineTime")]
                    [Validation(Required=false)]
                    public long? TotalOfficePhoneOnlineTime { get; set; }

                    /// <summary>
                    /// <para>The total on-site online duration. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("TotalOnSiteLoggedInTime")]
                    [Validation(Required=false)]
                    public long? TotalOnSiteLoggedInTime { get; set; }

                    /// <summary>
                    /// <para>The total on-site online duration. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Deprecated. Use TotalOnSiteLoggedInTime instead.</para>
                    /// </summary>
                    [NameInMap("TotalOnSiteOnlineTime")]
                    [Validation(Required=false)]
                    public long? TotalOnSiteOnlineTime { get; set; }

                    /// <summary>
                    /// <para>The total outbound-only online duration. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("TotalOutboundScenarioLoggedInTime")]
                    [Validation(Required=false)]
                    public long? TotalOutboundScenarioLoggedInTime { get; set; }

                    /// <summary>
                    /// <para>The total outbound-only idle duration. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("TotalOutboundScenarioReadyTime")]
                    [Validation(Required=false)]
                    public long? TotalOutboundScenarioReadyTime { get; set; }

                    /// <summary>
                    /// <para>The total outbound-only online duration. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Deprecated. Use TotalOutboundScenarioLoggedInTime instead.</para>
                    /// </summary>
                    [NameInMap("TotalOutboundScenarioTime")]
                    [Validation(Required=false)]
                    public long? TotalOutboundScenarioTime { get; set; }

                    /// <summary>
                    /// <para>The total ready duration. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("TotalReadyTime")]
                    [Validation(Required=false)]
                    public long? TotalReadyTime { get; set; }

                    /// <summary>
                    /// <para>The total talk time. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("TotalTalkTime")]
                    [Validation(Required=false)]
                    public long? TotalTalkTime { get; set; }

                    /// <summary>
                    /// <para>The total after-call work (ACW) time. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("TotalWorkTime")]
                    [Validation(Required=false)]
                    public long? TotalWorkTime { get; set; }

                }

                /// <summary>
                /// <para>The list of skill group IDs to which the agent belongs. The format is a JSON array character string. Each array element is a skill group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;skillgroup1@ccc-test&quot;,&quot;skillgroup2@ccc-test&quot;]</para>
                /// </summary>
                [NameInMap("SkillGroupIds")]
                [Validation(Required=false)]
                public string SkillGroupIds { get; set; }

                /// <summary>
                /// <para>The list of skill group names to which the agent belongs. The format is a JSON array character string. Each array element is a skill group name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[&quot;TestSkillGroup1&quot;,&quot;TestSkillGroup2&quot;]</para>
                /// </summary>
                [NameInMap("SkillGroupNames")]
                [Validation(Required=false)]
                public string SkillGroupNames { get; set; }

            }

            /// <summary>
            /// <para>The page number. Valid values: 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The page size. Valid values: 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EEEE671A-3E24-4A04-81E6-6C4F5B39DF75</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
