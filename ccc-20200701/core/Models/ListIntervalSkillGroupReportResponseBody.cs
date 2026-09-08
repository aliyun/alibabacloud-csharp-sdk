// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListIntervalSkillGroupReportResponseBody : TeaModel {
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
        /// <para>List of segment-based statistics for the skill group.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListIntervalSkillGroupReportResponseBodyData> Data { get; set; }
        public class ListIntervalSkillGroupReportResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Back-to-back call metric.</para>
            /// </summary>
            [NameInMap("Back2Back")]
            [Validation(Required=false)]
            public ListIntervalSkillGroupReportResponseBodyDataBack2Back Back2Back { get; set; }
            public class ListIntervalSkillGroupReportResponseBodyDataBack2Back : TeaModel {
                /// <summary>
                /// <para>Agent acknowledgement rate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("AgentHandleRate")]
                [Validation(Required=false)]
                public float? AgentHandleRate { get; set; }

                /// <summary>
                /// <para>Answer rate. Calculation Formula: CallsAnswered / CallsDialed. (Because management events for answering and acknowledgement may fall into different Time Ranges, the Result may exceed 100% in certain cases.)</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("AnswerRate")]
                [Validation(Required=false)]
                public string AnswerRate { get; set; }

                /// <summary>
                /// <para>Average ring time on the Customer side, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("AverageCustomerRingTime")]
                [Validation(Required=false)]
                public float? AverageCustomerRingTime { get; set; }

                /// <summary>
                /// <para>Average ring time, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("AverageRingTime")]
                [Validation(Required=false)]
                public float? AverageRingTime { get; set; }

                /// <summary>
                /// <para>Average talk time, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("AverageTalkTime")]
                [Validation(Required=false)]
                public string AverageTalkTime { get; set; }

                /// <summary>
                /// <para>Quantity of calls handled by agents.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("CallsAgentHandled")]
                [Validation(Required=false)]
                public long? CallsAgentHandled { get; set; }

                /// <summary>
                /// <para>Call connection volume.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("CallsAnswered")]
                [Validation(Required=false)]
                public long? CallsAnswered { get; set; }

                /// <summary>
                /// <para>Quantity of calls answered by the Customer.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("CallsCustomerAnswered")]
                [Validation(Required=false)]
                public long? CallsCustomerAnswered { get; set; }

                /// <summary>
                /// <para>Dial-up volume.</para>
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
                /// <para>0.6</para>
                /// </summary>
                [NameInMap("CustomerAnswerRate")]
                [Validation(Required=false)]
                public float? CustomerAnswerRate { get; set; }

                /// <summary>
                /// <para>Maximum customer-side ring time, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("MaxCustomerRingTime")]
                [Validation(Required=false)]
                public long? MaxCustomerRingTime { get; set; }

                /// <summary>
                /// <para>Maximum ring time, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("MaxRingTime")]
                [Validation(Required=false)]
                public long? MaxRingTime { get; set; }

                /// <summary>
                /// <para>Maximum talk time, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("MaxTalkTime")]
                [Validation(Required=false)]
                public string MaxTalkTime { get; set; }

                /// <summary>
                /// <para>Total customer-side ring time, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("TotalCustomerRingTime")]
                [Validation(Required=false)]
                public long? TotalCustomerRingTime { get; set; }

                /// <summary>
                /// <para>Total ring time, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("TotalRingTime")]
                [Validation(Required=false)]
                public long? TotalRingTime { get; set; }

                /// <summary>
                /// <para>Total talk time, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("TotalTalkTime")]
                [Validation(Required=false)]
                public long? TotalTalkTime { get; set; }

            }

            /// <summary>
            /// <para>Inbound metrics.</para>
            /// </summary>
            [NameInMap("Inbound")]
            [Validation(Required=false)]
            public ListIntervalSkillGroupReportResponseBodyDataInbound Inbound { get; set; }
            public class ListIntervalSkillGroupReportResponseBodyDataInbound : TeaModel {
                /// <summary>
                /// <para>Abandon rate. Calculation Formula: CallsAbandoned / CallsOffered (because management events related to abandonment and assignment may fall into different time ranges, the result may exceed 100% in certain cases).</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AbandonRate")]
                [Validation(Required=false)]
                public float? AbandonRate { get; set; }

                /// <summary>
                /// <para>Average abandonment duration, in seconds. Calculation Formula: TotalAbandonTime / CallsAbandoned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AverageAbandonTime")]
                [Validation(Required=false)]
                public float? AverageAbandonTime { get; set; }

                /// <summary>
                /// <para>Average abandoned-in-queue duration, in seconds. Calculation Formula: TotalAbandonedInQueueTime / CallsAbandonedInQueue.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AverageAbandonedInQueueTime")]
                [Validation(Required=false)]
                public float? AverageAbandonedInQueueTime { get; set; }

                /// <summary>
                /// <para>Average ringing abandonment duration, in seconds. Calculation Formula: TotalAbandonedInRingTime / CallsAbandonedInRing.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AverageAbandonedInRingTime")]
                [Validation(Required=false)]
                public float? AverageAbandonedInRingTime { get; set; }

                /// <summary>
                /// <para>Average first response time for chat sessions, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6</para>
                /// </summary>
                [NameInMap("AverageFirstResponseTime")]
                [Validation(Required=false)]
                public float? AverageFirstResponseTime { get; set; }

                /// <summary>
                /// <para>Average hold time during calls, in seconds. Calculation Formula: TotalHoldTime / CallsHold.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AverageHoldTime")]
                [Validation(Required=false)]
                public float? AverageHoldTime { get; set; }

                /// <summary>
                /// <para>Average response time for chat sessions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>18</para>
                /// </summary>
                [NameInMap("AverageResponseTime")]
                [Validation(Required=false)]
                public float? AverageResponseTime { get; set; }

                /// <summary>
                /// <para>Average ring time, in seconds. Calculation Formula: TotalRingTime / CallsRinged.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11</para>
                /// </summary>
                [NameInMap("AverageRingTime")]
                [Validation(Required=false)]
                public float? AverageRingTime { get; set; }

                /// <summary>
                /// <para>Average talk duration, in seconds. Calculation Formula: TotalTalkTime / CallsHandled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("AverageTalkTime")]
                [Validation(Required=false)]
                public float? AverageTalkTime { get; set; }

                /// <summary>
                /// <para>Average wait time, which is the average duration a caller waits before an agent answers the call. Calculation Formula: TotalWaitTime / CallsHandled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>11</para>
                /// </summary>
                [NameInMap("AverageWaitTime")]
                [Validation(Required=false)]
                public float? AverageWaitTime { get; set; }

                /// <summary>
                /// <para>Average post-processing duration, in seconds. Calculation Formula: TotalWorkTime / CallsHandled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("AverageWorkTime")]
                [Validation(Required=false)]
                public float? AverageWorkTime { get; set; }

                /// <summary>
                /// <para>Abandoned call quantity. Calculation Formula: CallsAbandonedInQueue + CallsAbandonedInRing.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsAbandoned")]
                [Validation(Required=false)]
                public long? CallsAbandoned { get; set; }

                /// <summary>
                /// <para>Quantity of abandoned calls in queue, which refers to the number of calls where the customer hung up after entering the queue but before being answered.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsAbandonedInQueue")]
                [Validation(Required=false)]
                public long? CallsAbandonedInQueue { get; set; }

                /// <summary>
                /// <para>Ring abandonment count, which refers to the number of calls abandoned by customers while ringing to an agent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsAbandonedInRing")]
                [Validation(Required=false)]
                public long? CallsAbandonedInRing { get; set; }

                /// <summary>
                /// <para>Attended transfer-in count, which is the number of calls transferred to this skill group via attended transfers initiated from other skill groups. Transfers between agents within the same skill group are not counted. If an agent signs in to multiple skill groups simultaneously, the call is attributed to the first skill group the agent signed in to. If a single call is transferred from another skill group to this skill group multiple times, each transfer is counted separately. The same rule applies below.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsAttendedTransferIn")]
                [Validation(Required=false)]
                public long? CallsAttendedTransferIn { get; set; }

                /// <summary>
                /// <para>Attended transfer-out count, which refers to the number of calls transferred from this skill group to another skill group for consultation. Transfers between agents within the same skill group are not counted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsAttendedTransferOut")]
                [Validation(Required=false)]
                public long? CallsAttendedTransferOut { get; set; }

                /// <summary>
                /// <para>Quantity of blind transfer-in calls, which refers to the number of calls directly transferred into this skill group from other skill groups. Transfers between agents within the same skill group are not counted. If an agent is signed into multiple skill groups simultaneously, the call is attributed to the first skill group the agent signed into. If a single call is transferred multiple times from other skill groups into this skill group, each transfer is counted separately. The same rule applies below.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsBlindTransferIn")]
                [Validation(Required=false)]
                public long? CallsBlindTransferIn { get; set; }

                /// <summary>
                /// <para>Quantity of blind transfer-out calls, which refers to the number of calls directly transferred out from this skill group to other skill groups. Transfers between agents within the same skill group are not counted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsBlindTransferOut")]
                [Validation(Required=false)]
                public long? CallsBlindTransferOut { get; set; }

                /// <summary>
                /// <para>Acknowledgement count, which is the number of times agents answered calls. For a single call that enters a queue multiple times, if it is answered by multiple agents after one queue entry, it is counted as one.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("CallsHandled")]
                [Validation(Required=false)]
                public long? CallsHandled { get; set; }

                /// <summary>
                /// <para>Hold count, which is the number of times calls were placed on hold. If a single call enters the queue and is placed on hold multiple times, it is counted as one.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsHold")]
                [Validation(Required=false)]
                public long? CallsHold { get; set; }

                /// <summary>
                /// <para>Assigned call volume, which is the number of calls assigned to this skill group, including calls assigned through queues and calls assigned via transfers (consultation transfers and direct transfers). Calculation formula: CallsQueued + CallsBlindTransferIn + CallsAttendedTransferIn.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("CallsOffered")]
                [Validation(Required=false)]
                public long? CallsOffered { get; set; }

                /// <summary>
                /// <para>Overflow count, which is the number of calls that overflowed from a queue (skill group). If a single call enters the same queue multiple times, each overflow is counted separately.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsOverflow")]
                [Validation(Required=false)]
                public long? CallsOverflow { get; set; }

                /// <summary>
                /// <para>Number of inbound calls entering a queue (skill group). If a single call enters the same queue multiple times, each entry is counted separately.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("CallsQueued")]
                [Validation(Required=false)]
                public long? CallsQueued { get; set; }

                /// <summary>
                /// <para>Number of calls that overflowed from the queue, meaning calls that experienced queue overflow while waiting in the IVR queue.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsQueuingOverflow")]
                [Validation(Required=false)]
                public long? CallsQueuingOverflow { get; set; }

                /// <summary>
                /// <para>Number of calls that timed out during the queuing phase.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsQueuingTimeout")]
                [Validation(Required=false)]
                public long? CallsQueuingTimeout { get; set; }

                /// <summary>
                /// <para>Number of calls that rang to agents. Each time a call enters the queue and is assigned to multiple agents, resulting in ringing, it is counted as one occurrence.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("CallsRinged")]
                [Validation(Required=false)]
                public long? CallsRinged { get; set; }

                /// <summary>
                /// <para>Timeout count, which is the number of calls that timed out in a queue (skill group). If a single call enters the same queue multiple times, each timeout is counted separately.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsTimeout")]
                [Validation(Required=false)]
                public long? CallsTimeout { get; set; }

                /// <summary>
                /// <para>Acknowledgement rate. Calculation Formula: CallsHandled / CallsOffered (because acknowledgement events and assignment events may fall into different time ranges, the result may exceed 100% in certain cases).</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.6666666666666666</para>
                /// </summary>
                [NameInMap("HandleRate")]
                [Validation(Required=false)]
                public float? HandleRate { get; set; }

                /// <summary>
                /// <para>Maximum abandonment time, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MaxAbandonTime")]
                [Validation(Required=false)]
                public long? MaxAbandonTime { get; set; }

                /// <summary>
                /// <para>Maximum queue abandonment duration, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MaxAbandonedInQueueTime")]
                [Validation(Required=false)]
                public long? MaxAbandonedInQueueTime { get; set; }

                /// <summary>
                /// <para>Maximum ring abandonment duration, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MaxAbandonedInRingTime")]
                [Validation(Required=false)]
                public long? MaxAbandonedInRingTime { get; set; }

                /// <summary>
                /// <para>Maximum hold duration, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MaxHoldTime")]
                [Validation(Required=false)]
                public long? MaxHoldTime { get; set; }

                /// <summary>
                /// <para>Maximum ring duration, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>18</para>
                /// </summary>
                [NameInMap("MaxRingTime")]
                [Validation(Required=false)]
                public long? MaxRingTime { get; set; }

                /// <summary>
                /// <para>Maximum talk duration, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6</para>
                /// </summary>
                [NameInMap("MaxTalkTime")]
                [Validation(Required=false)]
                public long? MaxTalkTime { get; set; }

                /// <summary>
                /// <para>Maximum wait time, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>18</para>
                /// </summary>
                [NameInMap("MaxWaitTime")]
                [Validation(Required=false)]
                public long? MaxWaitTime { get; set; }

                /// <summary>
                /// <para>Maximum post-processing duration, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>19</para>
                /// </summary>
                [NameInMap("MaxWorkTime")]
                [Validation(Required=false)]
                public long? MaxWorkTime { get; set; }

                /// <summary>
                /// <para>Satisfaction index, which is the average value of the satisfaction rating digits (single-digit numbers) entered by callers.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SatisfactionIndex")]
                [Validation(Required=false)]
                public float? SatisfactionIndex { get; set; }

                /// <summary>
                /// <para>Satisfaction rate. Calculation Formula: Number of evaluations marked as satisfied divided by the count of satisfaction survey responses.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SatisfactionRate")]
                [Validation(Required=false)]
                public float? SatisfactionRate { get; set; }

                /// <summary>
                /// <para>Sending Count of satisfaction surveys.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SatisfactionSurveysOffered")]
                [Validation(Required=false)]
                public long? SatisfactionSurveysOffered { get; set; }

                /// <summary>
                /// <para>Count of satisfaction survey responses.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SatisfactionSurveysResponded")]
                [Validation(Required=false)]
                public long? SatisfactionSurveysResponded { get; set; }

                /// <summary>
                /// <para>Service level within 20 seconds: the number of calls with waiting time less than or equal to 20 seconds divided by CallsQueued.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ServiceLevel20")]
                [Validation(Required=false)]
                public float? ServiceLevel20 { get; set; }

                /// <summary>
                /// <para>Total abandonment duration, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalAbandonTime")]
                [Validation(Required=false)]
                public long? TotalAbandonTime { get; set; }

                /// <summary>
                /// <para>Total queue abandonment duration, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalAbandonedInQueueTime")]
                [Validation(Required=false)]
                public long? TotalAbandonedInQueueTime { get; set; }

                /// <summary>
                /// <para>Total ringing abandonment duration, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalAbandonedInRingTime")]
                [Validation(Required=false)]
                public long? TotalAbandonedInRingTime { get; set; }

                /// <summary>
                /// <para>Total call hold time, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalHoldTime")]
                [Validation(Required=false)]
                public long? TotalHoldTime { get; set; }

                /// <summary>
                /// <para>Total number of messages sent in chat sessions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("TotalMessagesSent")]
                [Validation(Required=false)]
                public long? TotalMessagesSent { get; set; }

                /// <summary>
                /// <para>Total number of messages sent by agents in chat sessions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7</para>
                /// </summary>
                [NameInMap("TotalMessagesSentByAgent")]
                [Validation(Required=false)]
                public long? TotalMessagesSentByAgent { get; set; }

                /// <summary>
                /// <para>Total number of messages sent by the Customer in chat sessions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("TotalMessagesSentByCustomer")]
                [Validation(Required=false)]
                public long? TotalMessagesSentByCustomer { get; set; }

                /// <summary>
                /// <para>Total ringing duration, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>33</para>
                /// </summary>
                [NameInMap("TotalRingTime")]
                [Validation(Required=false)]
                public long? TotalRingTime { get; set; }

                /// <summary>
                /// <para>Total talk duration, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9</para>
                /// </summary>
                [NameInMap("TotalTalkTime")]
                [Validation(Required=false)]
                public long? TotalTalkTime { get; set; }

                /// <summary>
                /// <para>Total wait time, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>33</para>
                /// </summary>
                [NameInMap("TotalWaitTime")]
                [Validation(Required=false)]
                public long? TotalWaitTime { get; set; }

                /// <summary>
                /// <para>Total post-processing time, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>23</para>
                /// </summary>
                [NameInMap("TotalWorkTime")]
                [Validation(Required=false)]
                public long? TotalWorkTime { get; set; }

            }

            /// <summary>
            /// <para>Outbound metrics.</para>
            /// </summary>
            [NameInMap("Outbound")]
            [Validation(Required=false)]
            public ListIntervalSkillGroupReportResponseBodyDataOutbound Outbound { get; set; }
            public class ListIntervalSkillGroupReportResponseBodyDataOutbound : TeaModel {
                /// <summary>
                /// <para>Answer rate. Calculation Formula: CallsAnswered / CallsDialed (because management events for answering and acknowledgement may fall into different Time Ranges, the Result may exceed 100% in certain cases).</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AnswerRate")]
                [Validation(Required=false)]
                public float? AnswerRate { get; set; }

                /// <summary>
                /// <para>Average dial-up duration, in seconds. Calculation Formula: TotalDialingTime / CallsDialed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30</para>
                /// </summary>
                [NameInMap("AverageDialingTime")]
                [Validation(Required=false)]
                public float? AverageDialingTime { get; set; }

                /// <summary>
                /// <para>Average hold time during calls, in seconds. Calculation formula: TotalHoldTime / CallsHold.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AverageHoldTime")]
                [Validation(Required=false)]
                public float? AverageHoldTime { get; set; }

                /// <summary>
                /// <para>Average ring time in seconds. Calculation Formula: TotalRingTime / CallsRinged.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AverageRingTime")]
                [Validation(Required=false)]
                public float? AverageRingTime { get; set; }

                /// <summary>
                /// <para>Average talk time, in seconds. Calculation Formula: TotalTalkTime / CallsAnswered.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("AverageTalkTime")]
                [Validation(Required=false)]
                public float? AverageTalkTime { get; set; }

                /// <summary>
                /// <para>Average post-processing time in seconds. Calculation Formula: TotalWorkTime / CallsDialed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("AverageWorkTime")]
                [Validation(Required=false)]
                public float? AverageWorkTime { get; set; }

                /// <summary>
                /// <para>Answered call count.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("CallsAnswered")]
                [Validation(Required=false)]
                public long? CallsAnswered { get; set; }

                /// <summary>
                /// <para>Transfer-in calls, which refer to the number of calls transferred to this skill group from other skill groups. Transfers between agents within the same skill group are not counted. If an agent is signed into multiple skill groups simultaneously, the call is attributed to the first skill group the agent signed into. If a single call is transferred multiple times from other skill groups to this skill group, each transfer is counted separately. The same rule applies below.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsAttendedTransferIn")]
                [Validation(Required=false)]
                public long? CallsAttendedTransferIn { get; set; }

                /// <summary>
                /// <para>Transfer-out call volume, which refers to the number of calls initiated by this skill group and transferred to other skill groups. Transfers between agents within the same skill group are not counted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsAttendedTransferOut")]
                [Validation(Required=false)]
                public long? CallsAttendedTransferOut { get; set; }

                /// <summary>
                /// <para>Direct transfer-in calls, which refer to the number of calls directly transferred to this skill group from other skill groups. Transfers between agents within the same skill group are not counted. If an agent is signed into multiple skill groups simultaneously, the call is attributed to the first skill group the agent signed into. If a single call is transferred multiple times from other skill groups to this skill group, each transfer is counted separately. The same rule applies below.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsBlindTransferIn")]
                [Validation(Required=false)]
                public long? CallsBlindTransferIn { get; set; }

                /// <summary>
                /// <para>Direct transfer-out calls, which refer to the number of calls directly transferred from this skill group to other skill groups. Transfers between agents within the same skill group are not counted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsBlindTransferOut")]
                [Validation(Required=false)]
                public long? CallsBlindTransferOut { get; set; }

                /// <summary>
                /// <para>Dialed call count.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("CallsDialed")]
                [Validation(Required=false)]
                public long? CallsDialed { get; set; }

                /// <summary>
                /// <para>Hold count, which is the number of calls that were placed on hold. If a single call was placed on hold multiple times before being transferred out of the current skill group, it is counted as one.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsHold")]
                [Validation(Required=false)]
                public long? CallsHold { get; set; }

                /// <summary>
                /// <para>Number of calls that rang to agents. Each call is counted once per queue entry, even if it was assigned to multiple agents and rang multiple times.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsRinged")]
                [Validation(Required=false)]
                public long? CallsRinged { get; set; }

                /// <summary>
                /// <para>Maximum dial-up duration, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>49</para>
                /// </summary>
                [NameInMap("MaxDialingTime")]
                [Validation(Required=false)]
                public long? MaxDialingTime { get; set; }

                /// <summary>
                /// <para>Maximum hold time during a call, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MaxHoldTime")]
                [Validation(Required=false)]
                public long? MaxHoldTime { get; set; }

                /// <summary>
                /// <para>Maximum ring time, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MaxRingTime")]
                [Validation(Required=false)]
                public long? MaxRingTime { get; set; }

                /// <summary>
                /// <para>Maximum talk time, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("MaxTalkTime")]
                [Validation(Required=false)]
                public long? MaxTalkTime { get; set; }

                /// <summary>
                /// <para>Maximum post-processing time in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("MaxWorkTime")]
                [Validation(Required=false)]
                public long? MaxWorkTime { get; set; }

                /// <summary>
                /// <para>Satisfaction index, which is the average value of the satisfaction key digits (single-digit numbers).</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SatisfactionIndex")]
                [Validation(Required=false)]
                public float? SatisfactionIndex { get; set; }

                /// <summary>
                /// <para>Satisfaction rate. Calculation Formula: number of evaluations marked as satisfied / Count of satisfaction survey responses.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SatisfactionRate")]
                [Validation(Required=false)]
                public float? SatisfactionRate { get; set; }

                /// <summary>
                /// <para>Sending Count of satisfaction surveys.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SatisfactionSurveysOffered")]
                [Validation(Required=false)]
                public long? SatisfactionSurveysOffered { get; set; }

                /// <summary>
                /// <para>Count of satisfaction survey responses.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SatisfactionSurveysResponded")]
                [Validation(Required=false)]
                public long? SatisfactionSurveysResponded { get; set; }

                /// <summary>
                /// <para>Total dial-up duration, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("TotalDialingTime")]
                [Validation(Required=false)]
                public long? TotalDialingTime { get; set; }

                /// <summary>
                /// <para>Total hold time during calls, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalHoldTime")]
                [Validation(Required=false)]
                public long? TotalHoldTime { get; set; }

                /// <summary>
                /// <para>Total ring time, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalRingTime")]
                [Validation(Required=false)]
                public long? TotalRingTime { get; set; }

                /// <summary>
                /// <para>Total talk time, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("TotalTalkTime")]
                [Validation(Required=false)]
                public long? TotalTalkTime { get; set; }

                /// <summary>
                /// <para>Total post-processing duration, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
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
            public ListIntervalSkillGroupReportResponseBodyDataOverall Overall { get; set; }
            public class ListIntervalSkillGroupReportResponseBodyDataOverall : TeaModel {
                /// <summary>
                /// <para>Average break time, in seconds. Calculation Formula: TotalBreakTime / Count of breaks. The Count of breaks is not a field provided by the API.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AverageBreakTime")]
                [Validation(Required=false)]
                public float? AverageBreakTime { get; set; }

                /// <summary>
                /// <para>Average call hold time, in seconds. Calculation Formula: TotalHoldTime / (Inbound CallsHold + Outbound CallsHold).</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AverageHoldTime")]
                [Validation(Required=false)]
                public float? AverageHoldTime { get; set; }

                /// <summary>
                /// <para>Average ready time, in seconds. Calculation Formula: TotalReadyTime / Count of ready events. The count of ready events is not an API statistical field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AverageReadyTime")]
                [Validation(Required=false)]
                public float? AverageReadyTime { get; set; }

                /// <summary>
                /// <para>Average talk time, in seconds. Calculation Formula: TotalTalkTime / (CallsAnswered + CallsHandled).</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AverageTalkTime")]
                [Validation(Required=false)]
                public float? AverageTalkTime { get; set; }

                /// <summary>
                /// <para>Average post-processing time, in seconds. Calculation Formula: TotalWorkTime / TotalCalls.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6</para>
                /// </summary>
                [NameInMap("AverageWorkTime")]
                [Validation(Required=false)]
                public float? AverageWorkTime { get; set; }

                /// <summary>
                /// <para>Statistics for each break type.</para>
                /// </summary>
                [NameInMap("BreakCodeDetailList")]
                [Validation(Required=false)]
                public List<ListIntervalSkillGroupReportResponseBodyDataOverallBreakCodeDetailList> BreakCodeDetailList { get; set; }
                public class ListIntervalSkillGroupReportResponseBodyDataOverallBreakCodeDetailList : TeaModel {
                    /// <summary>
                    /// <para>Break type code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>会议</para>
                    /// </summary>
                    [NameInMap("BreakCode")]
                    [Validation(Required=false)]
                    public string BreakCode { get; set; }

                    /// <summary>
                    /// <para>Number of occurrences of this break type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Count")]
                    [Validation(Required=false)]
                    public long? Count { get; set; }

                    /// <summary>
                    /// <para>Total duration of this break type, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>120</para>
                    /// </summary>
                    [NameInMap("Duration")]
                    [Validation(Required=false)]
                    public long? Duration { get; set; }

                }

                /// <summary>
                /// <para>Maximum break duration, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MaxBreakTime")]
                [Validation(Required=false)]
                public long? MaxBreakTime { get; set; }

                /// <summary>
                /// <para>Maximum call hold duration, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MaxHoldTime")]
                [Validation(Required=false)]
                public long? MaxHoldTime { get; set; }

                /// <summary>
                /// <para>Maximum ready time, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4927</para>
                /// </summary>
                [NameInMap("MaxReadyTime")]
                [Validation(Required=false)]
                public long? MaxReadyTime { get; set; }

                /// <summary>
                /// <para>Maximum talk time, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6</para>
                /// </summary>
                [NameInMap("MaxTalkTime")]
                [Validation(Required=false)]
                public long? MaxTalkTime { get; set; }

                /// <summary>
                /// <para>Maximum post-processing duration, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>19</para>
                /// </summary>
                [NameInMap("MaxWorkTime")]
                [Validation(Required=false)]
                public long? MaxWorkTime { get; set; }

                /// <summary>
                /// <para>Agent occupancy rate, calculated using the formula: (TotalWorkTime + TotalTalkTime) / TotalLoggedInTime.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.00422315148470254</para>
                /// </summary>
                [NameInMap("OccupancyRate")]
                [Validation(Required=false)]
                public float? OccupancyRate { get; set; }

                /// <summary>
                /// <para>Satisfaction index, which is the average value of the single-digit satisfaction rating entered by users.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SatisfactionIndex")]
                [Validation(Required=false)]
                public float? SatisfactionIndex { get; set; }

                /// <summary>
                /// <para>Satisfaction rate. Calculation Formula: Number of evaluations marked as satisfied / Count of satisfaction survey responses.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SatisfactionRate")]
                [Validation(Required=false)]
                public float? SatisfactionRate { get; set; }

                /// <summary>
                /// <para>Sending Count of satisfaction surveys.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SatisfactionSurveysOffered")]
                [Validation(Required=false)]
                public long? SatisfactionSurveysOffered { get; set; }

                /// <summary>
                /// <para>Count of satisfaction survey responses.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SatisfactionSurveysResponded")]
                [Validation(Required=false)]
                public long? SatisfactionSurveysResponded { get; set; }

                /// <summary>
                /// <para>Total break time, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("TotalBreakTime")]
                [Validation(Required=false)]
                public long? TotalBreakTime { get; set; }

                /// <summary>
                /// <para>Total call volume. Calculation Formula: CallsOffered + CallsDialed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("TotalCalls")]
                [Validation(Required=false)]
                public long? TotalCalls { get; set; }

                /// <summary>
                /// <para>Total hold time, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalHoldTime")]
                [Validation(Required=false)]
                public long? TotalHoldTime { get; set; }

                /// <summary>
                /// <para>Total logon duration, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9236</para>
                /// </summary>
                [NameInMap("TotalLoggedInTime")]
                [Validation(Required=false)]
                public long? TotalLoggedInTime { get; set; }

                /// <summary>
                /// <para>Total ready time in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9106</para>
                /// </summary>
                [NameInMap("TotalReadyTime")]
                [Validation(Required=false)]
                public long? TotalReadyTime { get; set; }

                /// <summary>
                /// <para>Total talk time, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>13</para>
                /// </summary>
                [NameInMap("TotalTalkTime")]
                [Validation(Required=false)]
                public long? TotalTalkTime { get; set; }

                /// <summary>
                /// <para>Total post-processing time, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>27</para>
                /// </summary>
                [NameInMap("TotalWorkTime")]
                [Validation(Required=false)]
                public long? TotalWorkTime { get; set; }

            }

            /// <summary>
            /// <para>Start Time of the time segment, formatted as a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1604639129000</para>
            /// </summary>
            [NameInMap("StatsTime")]
            [Validation(Required=false)]
            public long? StatsTime { get; set; }

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
        /// <para>943D8EF3-3321-471F-A104-51C96FCA94D6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
