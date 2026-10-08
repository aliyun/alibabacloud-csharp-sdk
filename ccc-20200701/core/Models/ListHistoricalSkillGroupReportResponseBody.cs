// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListHistoricalSkillGroupReportResponseBody : TeaModel {
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
        public ListHistoricalSkillGroupReportResponseBodyData Data { get; set; }
        public class ListHistoricalSkillGroupReportResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of historical data for the skill group.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListHistoricalSkillGroupReportResponseBodyDataList> List { get; set; }
            public class ListHistoricalSkillGroupReportResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>The back-to-back call metrics.</para>
                /// </summary>
                [NameInMap("Back2Back")]
                [Validation(Required=false)]
                public ListHistoricalSkillGroupReportResponseBodyDataListBack2Back Back2Back { get; set; }
                public class ListHistoricalSkillGroupReportResponseBodyDataListBack2Back : TeaModel {
                    /// <summary>
                    /// <para>The agent answer rate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("AgentHandleRate")]
                    [Validation(Required=false)]
                    public float? AgentHandleRate { get; set; }

                    /// <summary>
                    /// <para>The answer rate. Calculation formula: CallsAnswered/CallsDialed. The result may exceed 100% in some cases because answer events and response events may fall into different time ranges.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.6</para>
                    /// </summary>
                    [NameInMap("AnswerRate")]
                    [Validation(Required=false)]
                    public float? AnswerRate { get; set; }

                    /// <summary>
                    /// <para>The average ring time on the customer side, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("AverageCustomerRingTime")]
                    [Validation(Required=false)]
                    public float? AverageCustomerRingTime { get; set; }

                    /// <summary>
                    /// <para>The average ring time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("AverageRingTime")]
                    [Validation(Required=false)]
                    public float? AverageRingTime { get; set; }

                    /// <summary>
                    /// <para>The average talk time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("AverageTalkTime")]
                    [Validation(Required=false)]
                    public float? AverageTalkTime { get; set; }

                    /// <summary>
                    /// <para>The number of answered calls.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("CallsAnswered")]
                    [Validation(Required=false)]
                    public long? CallsAnswered { get; set; }

                    /// <summary>
                    /// <para>The number of calls answered by customers.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8</para>
                    /// </summary>
                    [NameInMap("CallsCustomerAnswered")]
                    [Validation(Required=false)]
                    public long? CallsCustomerAnswered { get; set; }

                    /// <summary>
                    /// <para>The number of dialed calls.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("CallsDialed")]
                    [Validation(Required=false)]
                    public long? CallsDialed { get; set; }

                    /// <summary>
                    /// <para>The customer answer rate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.8</para>
                    /// </summary>
                    [NameInMap("CustomerAnswerRate")]
                    [Validation(Required=false)]
                    public float? CustomerAnswerRate { get; set; }

                    /// <summary>
                    /// <para>The maximum ring time on the customer side, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("MaxCustomerRingTime")]
                    [Validation(Required=false)]
                    public long? MaxCustomerRingTime { get; set; }

                    /// <summary>
                    /// <para>The maximum ring time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("MaxRingTime")]
                    [Validation(Required=false)]
                    public long? MaxRingTime { get; set; }

                    /// <summary>
                    /// <para>The maximum talk time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("MaxTalkTime")]
                    [Validation(Required=false)]
                    public long? MaxTalkTime { get; set; }

                    /// <summary>
                    /// <para>The total ring time on the customer side, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("TotalCustomerRingTime")]
                    [Validation(Required=false)]
                    public long? TotalCustomerRingTime { get; set; }

                    /// <summary>
                    /// <para>The total ring time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("TotalRingTime")]
                    [Validation(Required=false)]
                    public long? TotalRingTime { get; set; }

                    /// <summary>
                    /// <para>The total talk time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("TotalTalkTime")]
                    [Validation(Required=false)]
                    public long? TotalTalkTime { get; set; }

                }

                /// <summary>
                /// <para>The inbound call metrics.</para>
                /// </summary>
                [NameInMap("Inbound")]
                [Validation(Required=false)]
                public ListHistoricalSkillGroupReportResponseBodyDataListInbound Inbound { get; set; }
                public class ListHistoricalSkillGroupReportResponseBodyDataListInbound : TeaModel {
                    /// <summary>
                    /// <para>The abandon rate. Calculation formula: CallsAbandoned/CallsOffered. The result may exceed 100% in some cases because abandon events and allocation events may fall into different time ranges.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("AbandonRate")]
                    [Validation(Required=false)]
                    public float? AbandonRate { get; set; }

                    /// <summary>
                    /// <para>The statistical data for each channel.</para>
                    /// </summary>
                    [NameInMap("AccessChannelTypeDetails")]
                    [Validation(Required=false)]
                    public List<ListHistoricalSkillGroupReportResponseBodyDataListInboundAccessChannelTypeDetails> AccessChannelTypeDetails { get; set; }
                    public class ListHistoricalSkillGroupReportResponseBodyDataListInboundAccessChannelTypeDetails : TeaModel {
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
                        /// <para>The number of offered sessions.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2</para>
                        /// </summary>
                        [NameInMap("CallsOffered")]
                        [Validation(Required=false)]
                        public long? CallsOffered { get; set; }

                    }

                    /// <summary>
                    /// <para>The average abandon time, in seconds. Calculation formula: TotalAbandonTime/CallsAbandoned.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("AverageAbandonTime")]
                    [Validation(Required=false)]
                    public float? AverageAbandonTime { get; set; }

                    /// <summary>
                    /// <para>The average abandon time in queue, in seconds. Calculation formula: TotalAbandonedInQueueTime/CallsAbandonedInQueue.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("AverageAbandonedInQueueTime")]
                    [Validation(Required=false)]
                    public float? AverageAbandonedInQueueTime { get; set; }

                    /// <summary>
                    /// <para>The average abandon time during ringing, in seconds. Calculation formula: TotalAbandonedInRingTime/CallsAbandonedInRing.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("AverageAbandonedInRingTime")]
                    [Validation(Required=false)]
                    public float? AverageAbandonedInRingTime { get; set; }

                    /// <summary>
                    /// <para>The average first response time for chat sessions, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>6</para>
                    /// </summary>
                    [NameInMap("AverageFirstResponseTime")]
                    [Validation(Required=false)]
                    public float? AverageFirstResponseTime { get; set; }

                    /// <summary>
                    /// <para>The average hold time, in seconds. Calculation formula: TotalHoldTime/CallsHold.</para>
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
                    /// <para>8</para>
                    /// </summary>
                    [NameInMap("AverageResponseTime")]
                    [Validation(Required=false)]
                    public float? AverageResponseTime { get; set; }

                    /// <summary>
                    /// <para>The average ring time, in seconds. Calculation formula: TotalRingTime/CallsRinged.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("AverageRingTime")]
                    [Validation(Required=false)]
                    public float? AverageRingTime { get; set; }

                    /// <summary>
                    /// <para>The average talk time, in seconds. Calculation formula: TotalTalkTime/CallsHandled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>64</para>
                    /// </summary>
                    [NameInMap("AverageTalkTime")]
                    [Validation(Required=false)]
                    public float? AverageTalkTime { get; set; }

                    /// <summary>
                    /// <para>The average wait time, which is the average time a caller waits before an agent answers the call. Calculation formula: TotalWaitTime/CallsHandled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("AverageWaitTime")]
                    [Validation(Required=false)]
                    public float? AverageWaitTime { get; set; }

                    /// <summary>
                    /// <para>The average after-call work time, in seconds. Calculation formula: TotalWorkTime/CallsHandled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>13</para>
                    /// </summary>
                    [NameInMap("AverageWorkTime")]
                    [Validation(Required=false)]
                    public float? AverageWorkTime { get; set; }

                    /// <summary>
                    /// <para>The number of abandoned calls. Calculation formula: CallsAbandonedInQueue + CallsAbandonedInRing.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CallsAbandoned")]
                    [Validation(Required=false)]
                    public long? CallsAbandoned { get; set; }

                    /// <summary>
                    /// <para>The number of calls abandoned in queue, which refers to the number of calls hung up by customers while waiting in the queue after entering it.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CallsAbandonedInQueue")]
                    [Validation(Required=false)]
                    public long? CallsAbandonedInQueue { get; set; }

                    /// <summary>
                    /// <para>The number of calls abandoned during ringing, which refers to the number of calls hung up by customers while the agent is ringing.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CallsAbandonedInRing")]
                    [Validation(Required=false)]
                    public long? CallsAbandonedInRing { get; set; }

                    /// <summary>
                    /// <para>The number of attended transfers in, which refers to the number of calls transferred to this skill group from other skill groups through attended transfers. Transfers between agents within the same skill group are not counted. If an agent is signed in to multiple skill groups at the same time, the call is attributed to the first skill group the agent signed in to. If a call is transferred to this skill group multiple times from other skill groups, each transfer is counted as one. The same rule applies to similar metrics below.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CallsAttendedTransferIn")]
                    [Validation(Required=false)]
                    public long? CallsAttendedTransferIn { get; set; }

                    /// <summary>
                    /// <para>The number of attended transfers out, which refers to the number of calls transferred from this skill group to other skill groups through attended transfers. Transfers between agents within the same skill group are not counted.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CallsAttendedTransferOut")]
                    [Validation(Required=false)]
                    public long? CallsAttendedTransferOut { get; set; }

                    /// <summary>
                    /// <para>The number of blind transfers in, which refers to the number of calls transferred to this skill group from other skill groups through blind transfers. Transfers between agents within the same skill group are not counted. If an agent is signed in to multiple skill groups at the same time, the call is attributed to the first skill group the agent signed in to. If a call is transferred to this skill group multiple times from other skill groups, each transfer is counted as one. The same rule applies to similar metrics below.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CallsBlindTransferIn")]
                    [Validation(Required=false)]
                    public long? CallsBlindTransferIn { get; set; }

                    /// <summary>
                    /// <para>The number of blind transfers out, which refers to the number of calls transferred from this skill group to other skill groups through blind transfers. Transfers between agents within the same skill group are not counted.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CallsBlindTransferOut")]
                    [Validation(Required=false)]
                    public long? CallsBlindTransferOut { get; set; }

                    /// <summary>
                    /// <para>The number of handled calls, which refers to the number of times agents answer calls. If a call is answered by multiple agents after entering the queue each time, it is counted as one.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>7</para>
                    /// </summary>
                    [NameInMap("CallsHandled")]
                    [Validation(Required=false)]
                    public long? CallsHandled { get; set; }

                    /// <summary>
                    /// <para>The number of held calls, which refers to the number of times calls are put on hold. If a call is put on hold multiple times after entering the queue each time, it is counted as one.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CallsHold")]
                    [Validation(Required=false)]
                    public long? CallsHold { get; set; }

                    /// <summary>
                    /// <para>The number of offered calls, which refers to the number of calls assigned to this skill group, including calls assigned through queues and calls assigned through transfers (attended transfers and blind transfers). Calculation formula: CallsQueued + CallsBlindTransferIn + CallsAttendedTransferIn.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>7</para>
                    /// </summary>
                    [NameInMap("CallsOffered")]
                    [Validation(Required=false)]
                    public long? CallsOffered { get; set; }

                    /// <summary>
                    /// <para>The number of overflowed calls, which refers to the number of calls that overflow from the queue or skill group. If a call enters the same queue multiple times and overflows each time, each overflow is counted as one.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CallsOverflow")]
                    [Validation(Required=false)]
                    public long? CallsOverflow { get; set; }

                    /// <summary>
                    /// <para>The number of queued calls in inbound scenarios, which refers to the number of calls that enter the queue or skill group. If a call enters the same queue multiple times, each entry is counted as one.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>7</para>
                    /// </summary>
                    [NameInMap("CallsQueued")]
                    [Validation(Required=false)]
                    public long? CallsQueued { get; set; }

                    /// <summary>
                    /// <para>The number of failed queue calls, which refers to the number of calls hung up by customers while waiting in the queue after entering it.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CallsQueuingFailed")]
                    [Validation(Required=false)]
                    public long? CallsQueuingFailed { get; set; }

                    /// <summary>
                    /// <para>The number of calls that overflow from the queue, which refers to calls that overflow while waiting in the IVR queue.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CallsQueuingOverflow")]
                    [Validation(Required=false)]
                    public long? CallsQueuingOverflow { get; set; }

                    /// <summary>
                    /// <para>The number of calls that time out during the queuing phase.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CallsQueuingTimeout")]
                    [Validation(Required=false)]
                    public long? CallsQueuingTimeout { get; set; }

                    /// <summary>
                    /// <para>The number of ringing calls, which refers to the number of calls that trigger agent ringing. If a call is assigned to multiple agents and triggers ringing after entering the queue each time, it is counted as one.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>7</para>
                    /// </summary>
                    [NameInMap("CallsRinged")]
                    [Validation(Required=false)]
                    public long? CallsRinged { get; set; }

                    /// <summary>
                    /// <para>The number of timed-out calls, which refers to the number of calls that time out in the queue or skill group. If a call enters the same queue multiple times and times out each time, each timeout is counted as one.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CallsTimeout")]
                    [Validation(Required=false)]
                    public long? CallsTimeout { get; set; }

                    /// <summary>
                    /// <para>The handle rate. Calculation formula: CallsHandled/CallsOffered. The result may exceed 100% in some cases because handle events and offer events may fall into different time ranges.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("HandleRate")]
                    [Validation(Required=false)]
                    public float? HandleRate { get; set; }

                    /// <summary>
                    /// <para>The maximum abandon time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("MaxAbandonTime")]
                    [Validation(Required=false)]
                    public long? MaxAbandonTime { get; set; }

                    /// <summary>
                    /// <para>The maximum abandon time in queue, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("MaxAbandonedInQueueTime")]
                    [Validation(Required=false)]
                    public long? MaxAbandonedInQueueTime { get; set; }

                    /// <summary>
                    /// <para>The maximum abandon time during ringing, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("MaxAbandonedInRingTime")]
                    [Validation(Required=false)]
                    public long? MaxAbandonedInRingTime { get; set; }

                    /// <summary>
                    /// <para>The maximum hold time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("MaxHoldTime")]
                    [Validation(Required=false)]
                    public long? MaxHoldTime { get; set; }

                    /// <summary>
                    /// <para>The maximum ring time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12</para>
                    /// </summary>
                    [NameInMap("MaxRingTime")]
                    [Validation(Required=false)]
                    public long? MaxRingTime { get; set; }

                    /// <summary>
                    /// <para>The maximum talk time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("MaxTalkTime")]
                    [Validation(Required=false)]
                    public long? MaxTalkTime { get; set; }

                    /// <summary>
                    /// <para>The maximum wait time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>13</para>
                    /// </summary>
                    [NameInMap("MaxWaitTime")]
                    [Validation(Required=false)]
                    public long? MaxWaitTime { get; set; }

                    /// <summary>
                    /// <para>The maximum after-call work time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12</para>
                    /// </summary>
                    [NameInMap("MaxWorkTime")]
                    [Validation(Required=false)]
                    public long? MaxWorkTime { get; set; }

                    /// <summary>
                    /// <para>The satisfaction index, which is the average value of the satisfaction rating digits.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("SatisfactionIndex")]
                    [Validation(Required=false)]
                    public float? SatisfactionIndex { get; set; }

                    /// <summary>
                    /// <para>The satisfaction rate. Calculation formula: Number of satisfied ratings / Number of satisfaction survey responses.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("SatisfactionRate")]
                    [Validation(Required=false)]
                    public float? SatisfactionRate { get; set; }

                    /// <summary>
                    /// <para>The number of satisfaction surveys offered.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("SatisfactionSurveysOffered")]
                    [Validation(Required=false)]
                    public long? SatisfactionSurveysOffered { get; set; }

                    /// <summary>
                    /// <para>The number of satisfaction surveys responded to.</para>
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
                    /// <para>0.7</para>
                    /// </summary>
                    [NameInMap("ServiceLevel15")]
                    [Validation(Required=false)]
                    public float? ServiceLevel15 { get; set; }

                    /// <summary>
                    /// <para>The 20-second service level. Calculation formula: Number of calls with a wait time of less than or equal to 20 seconds / CallsQueued.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("ServiceLevel20")]
                    [Validation(Required=false)]
                    public float? ServiceLevel20 { get; set; }

                    /// <summary>
                    /// <para>The 30-second service level.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.9</para>
                    /// </summary>
                    [NameInMap("ServiceLevel30")]
                    [Validation(Required=false)]
                    public float? ServiceLevel30 { get; set; }

                    /// <summary>
                    /// <para>The total abandon time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("TotalAbandonTime")]
                    [Validation(Required=false)]
                    public long? TotalAbandonTime { get; set; }

                    /// <summary>
                    /// <para>The total abandon time in queue, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("TotalAbandonedInQueueTime")]
                    [Validation(Required=false)]
                    public long? TotalAbandonedInQueueTime { get; set; }

                    /// <summary>
                    /// <para>The total abandon time during ringing, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("TotalAbandonedInRingTime")]
                    [Validation(Required=false)]
                    public long? TotalAbandonedInRingTime { get; set; }

                    /// <summary>
                    /// <para>The total hold time, in seconds.</para>
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
                    /// <para>12</para>
                    /// </summary>
                    [NameInMap("TotalMessagesSent")]
                    [Validation(Required=false)]
                    public long? TotalMessagesSent { get; set; }

                    /// <summary>
                    /// <para>The total number of messages sent by agents in chat sessions.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>9</para>
                    /// </summary>
                    [NameInMap("TotalMessagesSentByAgent")]
                    [Validation(Required=false)]
                    public long? TotalMessagesSentByAgent { get; set; }

                    /// <summary>
                    /// <para>The total number of messages sent by customers in chat sessions.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("TotalMessagesSentByCustomer")]
                    [Validation(Required=false)]
                    public long? TotalMessagesSentByCustomer { get; set; }

                    /// <summary>
                    /// <para>The total ring time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>32</para>
                    /// </summary>
                    [NameInMap("TotalRingTime")]
                    [Validation(Required=false)]
                    public long? TotalRingTime { get; set; }

                    /// <summary>
                    /// <para>The total talk time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>447</para>
                    /// </summary>
                    [NameInMap("TotalTalkTime")]
                    [Validation(Required=false)]
                    public long? TotalTalkTime { get; set; }

                    /// <summary>
                    /// <para>The total wait time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>34</para>
                    /// </summary>
                    [NameInMap("TotalWaitTime")]
                    [Validation(Required=false)]
                    public long? TotalWaitTime { get; set; }

                    /// <summary>
                    /// <para>The total after-call work time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>85</para>
                    /// </summary>
                    [NameInMap("TotalWorkTime")]
                    [Validation(Required=false)]
                    public long? TotalWorkTime { get; set; }

                }

                /// <summary>
                /// <para>The outbound metrics.</para>
                /// </summary>
                [NameInMap("Outbound")]
                [Validation(Required=false)]
                public ListHistoricalSkillGroupReportResponseBodyDataListOutbound Outbound { get; set; }
                public class ListHistoricalSkillGroupReportResponseBodyDataListOutbound : TeaModel {
                    /// <summary>
                    /// <para>The answer rate. Calculation formula: CallsAnswered/CallsDialed. The result may exceed 100% in some cases because answer events and response events may fall into different time ranges.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("AnswerRate")]
                    [Validation(Required=false)]
                    public float? AnswerRate { get; set; }

                    /// <summary>
                    /// <para>The average dialing time in seconds. Formula: TotalDialingTime/CallsDialed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>37</para>
                    /// </summary>
                    [NameInMap("AverageDialingTime")]
                    [Validation(Required=false)]
                    public float? AverageDialingTime { get; set; }

                    /// <summary>
                    /// <para>The average hold time, in seconds. Calculation formula: TotalHoldTime/CallsHold.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("AverageHoldTime")]
                    [Validation(Required=false)]
                    public float? AverageHoldTime { get; set; }

                    /// <summary>
                    /// <para>The average ring time, in seconds. Calculation formula: TotalRingTime/CallsRinged.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("AverageRingTime")]
                    [Validation(Required=false)]
                    public float? AverageRingTime { get; set; }

                    /// <summary>
                    /// <para>The average talk time in seconds. Formula: TotalTalkTime/CallsAnswered.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("AverageTalkTime")]
                    [Validation(Required=false)]
                    public float? AverageTalkTime { get; set; }

                    /// <summary>
                    /// <para>The average after-call work time in seconds. Formula: TotalWorkTime/CallsDialed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("AverageWorkTime")]
                    [Validation(Required=false)]
                    public float? AverageWorkTime { get; set; }

                    /// <summary>
                    /// <para>The number of answered calls.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("CallsAnswered")]
                    [Validation(Required=false)]
                    public long? CallsAnswered { get; set; }

                    /// <summary>
                    /// <para>The number of attended transfers in, which refers to the number of calls transferred to this skill group from other skill groups through attended transfers. Transfers between agents within the same skill group are not counted. If an agent is signed in to multiple skill groups at the same time, the call is attributed to the first skill group the agent signed in to. If a call is transferred to this skill group multiple times from other skill groups, each transfer is counted as one. The same rule applies to similar metrics below.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CallsAttendedTransferIn")]
                    [Validation(Required=false)]
                    public long? CallsAttendedTransferIn { get; set; }

                    /// <summary>
                    /// <para>The number of attended transfers out, which refers to the number of calls transferred from this skill group to other skill groups through attended transfers. Transfers between agents within the same skill group are not counted.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CallsAttendedTransferOut")]
                    [Validation(Required=false)]
                    public long? CallsAttendedTransferOut { get; set; }

                    /// <summary>
                    /// <para>The number of blind transfers in, which refers to the number of calls transferred to this skill group from other skill groups through blind transfers. Transfers between agents within the same skill group are not counted. If an agent is signed in to multiple skill groups at the same time, the call is attributed to the first skill group the agent signed in to. If a call is transferred to this skill group multiple times from other skill groups, each transfer is counted as one. The same rule applies to similar metrics below.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CallsBlindTransferIn")]
                    [Validation(Required=false)]
                    public long? CallsBlindTransferIn { get; set; }

                    /// <summary>
                    /// <para>The number of blind transfers out, which refers to the number of calls transferred from this skill group to other skill groups through blind transfers. Transfers between agents within the same skill group are not counted.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CallsBlindTransferOut")]
                    [Validation(Required=false)]
                    public long? CallsBlindTransferOut { get; set; }

                    /// <summary>
                    /// <para>The number of dialed calls.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>6</para>
                    /// </summary>
                    [NameInMap("CallsDialed")]
                    [Validation(Required=false)]
                    public long? CallsDialed { get; set; }

                    /// <summary>
                    /// <para>The number of calls placed on hold. If a call is placed on hold multiple times before being transferred out of the current skill group, it is counted as one.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CallsHold")]
                    [Validation(Required=false)]
                    public long? CallsHold { get; set; }

                    /// <summary>
                    /// <para>The number of ringing calls, which refers to the number of calls that trigger agent ringing. If a call is assigned to multiple agents and triggers ringing after entering the queue each time, it is counted as one.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CallsRinged")]
                    [Validation(Required=false)]
                    public long? CallsRinged { get; set; }

                    /// <summary>
                    /// <para>The maximum dialing time in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12</para>
                    /// </summary>
                    [NameInMap("MaxDialingTime")]
                    [Validation(Required=false)]
                    public long? MaxDialingTime { get; set; }

                    /// <summary>
                    /// <para>The maximum hold time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("MaxHoldTime")]
                    [Validation(Required=false)]
                    public long? MaxHoldTime { get; set; }

                    /// <summary>
                    /// <para>The maximum ring time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("MaxRingTime")]
                    [Validation(Required=false)]
                    public long? MaxRingTime { get; set; }

                    /// <summary>
                    /// <para>The maximum talk time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("MaxTalkTime")]
                    [Validation(Required=false)]
                    public long? MaxTalkTime { get; set; }

                    /// <summary>
                    /// <para>The maximum after-call work time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("MaxWorkTime")]
                    [Validation(Required=false)]
                    public long? MaxWorkTime { get; set; }

                    /// <summary>
                    /// <para>The satisfaction index, which is the average value of the satisfaction rating digits.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("SatisfactionIndex")]
                    [Validation(Required=false)]
                    public float? SatisfactionIndex { get; set; }

                    /// <summary>
                    /// <para>The satisfaction rate. Calculation formula: Number of satisfied ratings / Number of satisfaction survey responses.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("SatisfactionRate")]
                    [Validation(Required=false)]
                    public float? SatisfactionRate { get; set; }

                    /// <summary>
                    /// <para>The number of satisfaction surveys offered.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("SatisfactionSurveysOffered")]
                    [Validation(Required=false)]
                    public long? SatisfactionSurveysOffered { get; set; }

                    /// <summary>
                    /// <para>The number of satisfaction surveys responded to.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("SatisfactionSurveysResponded")]
                    [Validation(Required=false)]
                    public long? SatisfactionSurveysResponded { get; set; }

                    /// <summary>
                    /// <para>The total dialing time in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>218</para>
                    /// </summary>
                    [NameInMap("TotalDialingTime")]
                    [Validation(Required=false)]
                    public long? TotalDialingTime { get; set; }

                    /// <summary>
                    /// <para>The total hold time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("TotalHoldTime")]
                    [Validation(Required=false)]
                    public long? TotalHoldTime { get; set; }

                    /// <summary>
                    /// <para>The total ring time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("TotalRingTime")]
                    [Validation(Required=false)]
                    public long? TotalRingTime { get; set; }

                    /// <summary>
                    /// <para>The total talk time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("TotalTalkTime")]
                    [Validation(Required=false)]
                    public long? TotalTalkTime { get; set; }

                    /// <summary>
                    /// <para>The total after-call work time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>9</para>
                    /// </summary>
                    [NameInMap("TotalWorkTime")]
                    [Validation(Required=false)]
                    public long? TotalWorkTime { get; set; }

                }

                /// <summary>
                /// <para>The overall metrics.</para>
                /// </summary>
                [NameInMap("Overall")]
                [Validation(Required=false)]
                public ListHistoricalSkillGroupReportResponseBodyDataListOverall Overall { get; set; }
                public class ListHistoricalSkillGroupReportResponseBodyDataListOverall : TeaModel {
                    /// <summary>
                    /// <para>The average break time in seconds. Formula: TotalBreakTime/Number of breaks. The number of breaks is not a statistical field returned by the API.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("AverageBreakTime")]
                    [Validation(Required=false)]
                    public float? AverageBreakTime { get; set; }

                    /// <summary>
                    /// <para>The average hold time in seconds. Formula: TotalHoldTime/(Inbound CallsHold + Outbound CallsHold).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("AverageHoldTime")]
                    [Validation(Required=false)]
                    public float? AverageHoldTime { get; set; }

                    /// <summary>
                    /// <para>The average ready time in seconds. Formula: TotalReadyTime/Number of ready states. The number of ready states is not a statistical field returned by the API.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("AverageReadyTime")]
                    [Validation(Required=false)]
                    public float? AverageReadyTime { get; set; }

                    /// <summary>
                    /// <para>The average talk time in seconds. Formula: TotalTalkTime/(CallsAnswered + CallsHandled).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("AverageTalkTime")]
                    [Validation(Required=false)]
                    public float? AverageTalkTime { get; set; }

                    /// <summary>
                    /// <para>The average after-call work time in seconds. Formula: TotalWorkTime/TotalCalls.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8</para>
                    /// </summary>
                    [NameInMap("AverageWorkTime")]
                    [Validation(Required=false)]
                    public float? AverageWorkTime { get; set; }

                    /// <summary>
                    /// <para>The list of break details.</para>
                    /// </summary>
                    [NameInMap("BreakCodeDetailList")]
                    [Validation(Required=false)]
                    public List<ListHistoricalSkillGroupReportResponseBodyDataListOverallBreakCodeDetailList> BreakCodeDetailList { get; set; }
                    public class ListHistoricalSkillGroupReportResponseBodyDataListOverallBreakCodeDetailList : TeaModel {
                        /// <summary>
                        /// <para>The break type code.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Meeting</para>
                        /// </summary>
                        [NameInMap("BreakCode")]
                        [Validation(Required=false)]
                        public string BreakCode { get; set; }

                        /// <summary>
                        /// <para>The number of occurrences of this break type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2</para>
                        /// </summary>
                        [NameInMap("Count")]
                        [Validation(Required=false)]
                        public long? Count { get; set; }

                        /// <summary>
                        /// <para>The total duration of this break type in seconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3600</para>
                        /// </summary>
                        [NameInMap("Duration")]
                        [Validation(Required=false)]
                        public long? Duration { get; set; }

                    }

                    /// <summary>
                    /// <para>The maximum break time in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("MaxBreakTime")]
                    [Validation(Required=false)]
                    public long? MaxBreakTime { get; set; }

                    /// <summary>
                    /// <para>The maximum hold time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("MaxHoldTime")]
                    [Validation(Required=false)]
                    public long? MaxHoldTime { get; set; }

                    /// <summary>
                    /// <para>The maximum ready time in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>19328</para>
                    /// </summary>
                    [NameInMap("MaxReadyTime")]
                    [Validation(Required=false)]
                    public long? MaxReadyTime { get; set; }

                    /// <summary>
                    /// <para>The maximum talk time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("MaxTalkTime")]
                    [Validation(Required=false)]
                    public long? MaxTalkTime { get; set; }

                    /// <summary>
                    /// <para>The maximum after-call work time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12</para>
                    /// </summary>
                    [NameInMap("MaxWorkTime")]
                    [Validation(Required=false)]
                    public long? MaxWorkTime { get; set; }

                    /// <summary>
                    /// <para>The agent occupancy rate. Formula: (TotalWorkTime + TotalTalkTime) / TotalLoggedInTime.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.02332222293912065</para>
                    /// </summary>
                    [NameInMap("OccupancyRate")]
                    [Validation(Required=false)]
                    public float? OccupancyRate { get; set; }

                    /// <summary>
                    /// <para>The satisfaction index, which is the average value of the satisfaction rating digits.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("SatisfactionIndex")]
                    [Validation(Required=false)]
                    public float? SatisfactionIndex { get; set; }

                    /// <summary>
                    /// <para>The satisfaction rate. Calculation formula: Number of satisfied ratings / Number of satisfaction survey responses.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("SatisfactionRate")]
                    [Validation(Required=false)]
                    public float? SatisfactionRate { get; set; }

                    /// <summary>
                    /// <para>The number of satisfaction surveys offered.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("SatisfactionSurveysOffered")]
                    [Validation(Required=false)]
                    public long? SatisfactionSurveysOffered { get; set; }

                    /// <summary>
                    /// <para>The number of satisfaction surveys responded to.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("SatisfactionSurveysResponded")]
                    [Validation(Required=false)]
                    public long? SatisfactionSurveysResponded { get; set; }

                    /// <summary>
                    /// <para>The total break time in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("TotalBreakTime")]
                    [Validation(Required=false)]
                    public long? TotalBreakTime { get; set; }

                    /// <summary>
                    /// <para>The total number of calls. Formula: CallsOffered + CallsDialed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>13</para>
                    /// </summary>
                    [NameInMap("TotalCalls")]
                    [Validation(Required=false)]
                    public long? TotalCalls { get; set; }

                    /// <summary>
                    /// <para>The total hold time in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("TotalHoldTime")]
                    [Validation(Required=false)]
                    public long? TotalHoldTime { get; set; }

                    /// <summary>
                    /// <para>The total logged-in time in seconds.
                    /// <em>Note: Excludes offline and break time.</em></para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>23218</para>
                    /// </summary>
                    [NameInMap("TotalLoggedInTime")]
                    [Validation(Required=false)]
                    public long? TotalLoggedInTime { get; set; }

                    /// <summary>
                    /// <para>The total ready time in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>22428</para>
                    /// </summary>
                    [NameInMap("TotalReadyTime")]
                    [Validation(Required=false)]
                    public long? TotalReadyTime { get; set; }

                    /// <summary>
                    /// <para>The total talk time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>449</para>
                    /// </summary>
                    [NameInMap("TotalTalkTime")]
                    [Validation(Required=false)]
                    public long? TotalTalkTime { get; set; }

                    /// <summary>
                    /// <para>The total after-call work time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>94</para>
                    /// </summary>
                    [NameInMap("TotalWorkTime")]
                    [Validation(Required=false)]
                    public long? TotalWorkTime { get; set; }

                }

                /// <summary>
                /// <para>The skill group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>skillgroup@ccc-test</para>
                /// </summary>
                [NameInMap("SkillGroupId")]
                [Validation(Required=false)]
                public string SkillGroupId { get; set; }

                /// <summary>
                /// <para>The skill group name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>skillgroup</para>
                /// </summary>
                [NameInMap("SkillGroupName")]
                [Validation(Required=false)]
                public string SkillGroupName { get; set; }

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
            /// <para>The number of entries per page. Valid values: 1 to 100.</para>
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
            /// <para>4</para>
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
        /// <para>None</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>26A34338-5CD9-4C95-A7A6-5BDCE76C6B94</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
