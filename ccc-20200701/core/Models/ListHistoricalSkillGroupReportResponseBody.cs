// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListHistoricalSkillGroupReportResponseBody : TeaModel {
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
        /// <para>Data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListHistoricalSkillGroupReportResponseBodyData Data { get; set; }
        public class ListHistoricalSkillGroupReportResponseBodyData : TeaModel {
            /// <summary>
            /// <para>List of historical data for skill groups.</para>
            /// </summary>
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListHistoricalSkillGroupReportResponseBodyDataList> List { get; set; }
            public class ListHistoricalSkillGroupReportResponseBodyDataList : TeaModel {
                /// <summary>
                /// <para>Back-to-back metric.</para>
                /// </summary>
                [NameInMap("Back2Back")]
                [Validation(Required=false)]
                public ListHistoricalSkillGroupReportResponseBodyDataListBack2Back Back2Back { get; set; }
                public class ListHistoricalSkillGroupReportResponseBodyDataListBack2Back : TeaModel {
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
                    /// <para>Answer rate. Calculation Formula: CallsAnswered / CallsDialed. (Because acknowledgement events and answer events may fall into different time ranges, the result may exceed 100% in certain cases.)</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.6</para>
                    /// </summary>
                    [NameInMap("AnswerRate")]
                    [Validation(Required=false)]
                    public float? AnswerRate { get; set; }

                    /// <summary>
                    /// <para>Average customer-side ring time, in seconds.</para>
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
                    public float? AverageTalkTime { get; set; }

                    /// <summary>
                    /// <para>Number of answered calls.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("CallsAnswered")]
                    [Validation(Required=false)]
                    public long? CallsAnswered { get; set; }

                    /// <summary>
                    /// <para>Number of calls answered by the customer.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>8</para>
                    /// </summary>
                    [NameInMap("CallsCustomerAnswered")]
                    [Validation(Required=false)]
                    public long? CallsCustomerAnswered { get; set; }

                    /// <summary>
                    /// <para>Number of dial-up calls.</para>
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
                    /// <para>0.8</para>
                    /// </summary>
                    [NameInMap("CustomerAnswerRate")]
                    [Validation(Required=false)]
                    public float? CustomerAnswerRate { get; set; }

                    /// <summary>
                    /// <para>Maximum Customer-side ring time, in seconds.</para>
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
                    public long? MaxTalkTime { get; set; }

                    /// <summary>
                    /// <para>Total Customer-side ring time, in seconds.</para>
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
                public ListHistoricalSkillGroupReportResponseBodyDataListInbound Inbound { get; set; }
                public class ListHistoricalSkillGroupReportResponseBodyDataListInbound : TeaModel {
                    /// <summary>
                    /// <para>Abandon rate. Calculation Formula: CallsAbandoned / CallsOffered (Because abandonment events and assignment events may fall into different time ranges, the result may exceed 100% in certain cases).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("AbandonRate")]
                    [Validation(Required=false)]
                    public float? AbandonRate { get; set; }

                    /// <summary>
                    /// <para>Statistics for each channel.</para>
                    /// </summary>
                    [NameInMap("AccessChannelTypeDetails")]
                    [Validation(Required=false)]
                    public List<ListHistoricalSkillGroupReportResponseBodyDataListInboundAccessChannelTypeDetails> AccessChannelTypeDetails { get; set; }
                    public class ListHistoricalSkillGroupReportResponseBodyDataListInboundAccessChannelTypeDetails : TeaModel {
                        /// <summary>
                        /// <para>Channel Type.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Web</para>
                        /// </summary>
                        [NameInMap("AccessChannelType")]
                        [Validation(Required=false)]
                        public string AccessChannelType { get; set; }

                        /// <summary>
                        /// <para>Quantity of assigned sessions.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2</para>
                        /// </summary>
                        [NameInMap("CallsOffered")]
                        [Validation(Required=false)]
                        public long? CallsOffered { get; set; }

                    }

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
                    /// <para>Average queue abandonment duration, in seconds. Calculation Formula: TotalAbandonedInQueueTime / CallsAbandonedInQueue.</para>
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
                    /// <para>Average call hold duration, in seconds. Calculation Formula: TotalHoldTime / CallsHold.</para>
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
                    /// <para>8</para>
                    /// </summary>
                    [NameInMap("AverageResponseTime")]
                    [Validation(Required=false)]
                    public float? AverageResponseTime { get; set; }

                    /// <summary>
                    /// <para>Average ring time, in seconds. Calculation Formula: TotalRingTime / CallsRinged.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("AverageRingTime")]
                    [Validation(Required=false)]
                    public float? AverageRingTime { get; set; }

                    /// <summary>
                    /// <para>Average talk time, in seconds. Calculation Formula: TotalTalkTime / CallsHandled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>64</para>
                    /// </summary>
                    [NameInMap("AverageTalkTime")]
                    [Validation(Required=false)]
                    public float? AverageTalkTime { get; set; }

                    /// <summary>
                    /// <para>Average wait time, which is the average duration a caller waits before an agent answers the call. Calculation Formula: TotalWaitTime / CallsHandled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("AverageWaitTime")]
                    [Validation(Required=false)]
                    public float? AverageWaitTime { get; set; }

                    /// <summary>
                    /// <para>Average post-processing duration, in seconds. Calculation Formula: TotalWorkTime / CallsHandled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>13</para>
                    /// </summary>
                    [NameInMap("AverageWorkTime")]
                    [Validation(Required=false)]
                    public float? AverageWorkTime { get; set; }

                    /// <summary>
                    /// <para>Quantity of abandoned calls. Calculation Formula: CallsAbandonedInQueue + CallsAbandonedInRing.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CallsAbandoned")]
                    [Validation(Required=false)]
                    public long? CallsAbandoned { get; set; }

                    /// <summary>
                    /// <para>Number of calls abandoned in queue, which refers to the number of calls where the customer hung up after entering the queue but before being answered.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CallsAbandonedInQueue")]
                    [Validation(Required=false)]
                    public long? CallsAbandonedInQueue { get; set; }

                    /// <summary>
                    /// <para>Ring abandonment count, which is the number of calls where the customer hung up while the agent\&quot;s phone was ringing.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CallsAbandonedInRing")]
                    [Validation(Required=false)]
                    public long? CallsAbandonedInRing { get; set; }

                    /// <summary>
                    /// <para>Transfer-in volume, which refers to the number of calls transferred to this skill group from other skill groups. Transfers between agents within the same skill group are not counted. If an agent is signed into multiple skill groups simultaneously, the call is attributed to the first skill group the agent signed into. If a single call is transferred multiple times from other skill groups to this skill group, each transfer is counted separately. The same rule applies below.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CallsAttendedTransferIn")]
                    [Validation(Required=false)]
                    public long? CallsAttendedTransferIn { get; set; }

                    /// <summary>
                    /// <para>Quantity of attended transfer-out calls, which refers to the number of calls transferred from this skill group to another skill group via consultation. Transfers between agents within the same skill group are not counted.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CallsAttendedTransferOut")]
                    [Validation(Required=false)]
                    public long? CallsAttendedTransferOut { get; set; }

                    /// <summary>
                    /// <para>Number of blind transfer-in calls, which refers to the number of calls directly transferred to this skill group from other skill groups. Transfers between agents within the same skill group are not counted. If an agent is signed into multiple skill groups simultaneously, the call is attributed to the first skill group the agent signed into. If a single call is transferred multiple times from other skill groups to this skill group, each transfer is counted separately. The same rule applies below.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CallsBlindTransferIn")]
                    [Validation(Required=false)]
                    public long? CallsBlindTransferIn { get; set; }

                    /// <summary>
                    /// <para>Number of blind transfer-out calls, which refers to the number of calls directly transferred from this skill group to another skill group. Transfers between agents within the same skill group are not counted.</para>
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
                    /// <para>7</para>
                    /// </summary>
                    [NameInMap("CallsHandled")]
                    [Validation(Required=false)]
                    public long? CallsHandled { get; set; }

                    /// <summary>
                    /// <para>Hold count, which is the number of times calls were placed on hold. Each time a call enters the queue and experiences multiple holds, it counts as one.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CallsHold")]
                    [Validation(Required=false)]
                    public long? CallsHold { get; set; }

                    /// <summary>
                    /// <para>Assigned call volume, which is the number of calls assigned to this skill group, including calls assigned through queues and calls assigned via transfers (consultation transfers and direct transfers). Calculation Formula: CallsQueued + CallsBlindTransferIn + CallsAttendedTransferIn.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>7</para>
                    /// </summary>
                    [NameInMap("CallsOffered")]
                    [Validation(Required=false)]
                    public long? CallsOffered { get; set; }

                    /// <summary>
                    /// <para>Overflow count, which is the number of calls that experienced queue (skill group) overflow. If a single call enters the same queue multiple times, each overflow is counted separately.</para>
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
                    /// <para>7</para>
                    /// </summary>
                    [NameInMap("CallsQueued")]
                    [Validation(Required=false)]
                    public long? CallsQueued { get; set; }

                    /// <summary>
                    /// <para>Queue Failure Quantity, which is the number of calls where the customer hung up after entering the queue but before being answered.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CallsQueuingFailed")]
                    [Validation(Required=false)]
                    public long? CallsQueuingFailed { get; set; }

                    /// <summary>
                    /// <para>Quantity of calls that overflowed from the queue. Queue overflow refers to calls that overflow while queuing in IVR.</para>
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
                    /// <para>Number of calls that rang to agents. Each time a call enters the queue and is assigned to multiple agents, resulting in ringing, it counts as one.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>7</para>
                    /// </summary>
                    [NameInMap("CallsRinged")]
                    [Validation(Required=false)]
                    public long? CallsRinged { get; set; }

                    /// <summary>
                    /// <para>Timeout count, which is the number of calls that experienced queue (skill group) timeout. If a single call enters the same queue multiple times, each timeout is counted separately.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CallsTimeout")]
                    [Validation(Required=false)]
                    public long? CallsTimeout { get; set; }

                    /// <summary>
                    /// <para>Acknowledgement rate. Calculation Formula: CallsHandled / CallsOffered (because acknowledgement events and assign events may fall into different time ranges, the result may exceed 100% in certain cases).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("HandleRate")]
                    [Validation(Required=false)]
                    public float? HandleRate { get; set; }

                    /// <summary>
                    /// <para>Maximum abandonment duration, in seconds.</para>
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
                    /// <para>Maximum call hold time, in seconds.</para>
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
                    /// <para>12</para>
                    /// </summary>
                    [NameInMap("MaxRingTime")]
                    [Validation(Required=false)]
                    public long? MaxRingTime { get; set; }

                    /// <summary>
                    /// <para>Maximum talk duration, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("MaxTalkTime")]
                    [Validation(Required=false)]
                    public long? MaxTalkTime { get; set; }

                    /// <summary>
                    /// <para>Maximum wait time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>13</para>
                    /// </summary>
                    [NameInMap("MaxWaitTime")]
                    [Validation(Required=false)]
                    public long? MaxWaitTime { get; set; }

                    /// <summary>
                    /// <para>Maximum post-processing duration, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12</para>
                    /// </summary>
                    [NameInMap("MaxWorkTime")]
                    [Validation(Required=false)]
                    public long? MaxWorkTime { get; set; }

                    /// <summary>
                    /// <para>Satisfaction index, which is the average of the satisfaction keypress digits (single-digit numbers).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("SatisfactionIndex")]
                    [Validation(Required=false)]
                    public float? SatisfactionIndex { get; set; }

                    /// <summary>
                    /// <para>Satisfaction rate. Calculation Formula: Count of evaluations marked as satisfied / Count of satisfaction survey responses.</para>
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
                    /// <para>Service level within 15 seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.7</para>
                    /// </summary>
                    [NameInMap("ServiceLevel15")]
                    [Validation(Required=false)]
                    public float? ServiceLevel15 { get; set; }

                    /// <summary>
                    /// <para>Service level within 20 seconds: number of calls with wait time less than or equal to 20 seconds divided by CallsQueued.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("ServiceLevel20")]
                    [Validation(Required=false)]
                    public float? ServiceLevel20 { get; set; }

                    /// <summary>
                    /// <para>Service level within 30 seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.9</para>
                    /// </summary>
                    [NameInMap("ServiceLevel30")]
                    [Validation(Required=false)]
                    public float? ServiceLevel30 { get; set; }

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
                    /// <para>Total ring abandonment duration, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("TotalAbandonedInRingTime")]
                    [Validation(Required=false)]
                    public long? TotalAbandonedInRingTime { get; set; }

                    /// <summary>
                    /// <para>Total call hold duration, in seconds.</para>
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
                    /// <para>9</para>
                    /// </summary>
                    [NameInMap("TotalMessagesSentByAgent")]
                    [Validation(Required=false)]
                    public long? TotalMessagesSentByAgent { get; set; }

                    /// <summary>
                    /// <para>Total number of messages sent by the customer in chat sessions.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("TotalMessagesSentByCustomer")]
                    [Validation(Required=false)]
                    public long? TotalMessagesSentByCustomer { get; set; }

                    /// <summary>
                    /// <para>Total ringing duration, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>32</para>
                    /// </summary>
                    [NameInMap("TotalRingTime")]
                    [Validation(Required=false)]
                    public long? TotalRingTime { get; set; }

                    /// <summary>
                    /// <para>Total talk time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>447</para>
                    /// </summary>
                    [NameInMap("TotalTalkTime")]
                    [Validation(Required=false)]
                    public long? TotalTalkTime { get; set; }

                    /// <summary>
                    /// <para>Total waiting duration, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>34</para>
                    /// </summary>
                    [NameInMap("TotalWaitTime")]
                    [Validation(Required=false)]
                    public long? TotalWaitTime { get; set; }

                    /// <summary>
                    /// <para>Total post-processing time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>85</para>
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
                public ListHistoricalSkillGroupReportResponseBodyDataListOutbound Outbound { get; set; }
                public class ListHistoricalSkillGroupReportResponseBodyDataListOutbound : TeaModel {
                    /// <summary>
                    /// <para>Answer rate. Calculation Formula: CallsAnswered / CallsDialed. (Because the call answering event and the acknowledgement event may fall into different time ranges, the result may exceed 100% in certain cases.)</para>
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
                    /// <para>37</para>
                    /// </summary>
                    [NameInMap("AverageDialingTime")]
                    [Validation(Required=false)]
                    public float? AverageDialingTime { get; set; }

                    /// <summary>
                    /// <para>Average call hold duration, in seconds. Calculation Formula: TotalHoldTime / CallsHold.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("AverageHoldTime")]
                    [Validation(Required=false)]
                    public float? AverageHoldTime { get; set; }

                    /// <summary>
                    /// <para>Average ring time, in seconds. Calculation Formula: TotalRingTime / CallsRinged.</para>
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
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("AverageTalkTime")]
                    [Validation(Required=false)]
                    public float? AverageTalkTime { get; set; }

                    /// <summary>
                    /// <para>Average post-processing duration per call, in seconds. Calculation Formula: TotalWorkTime / CallsDialed</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("AverageWorkTime")]
                    [Validation(Required=false)]
                    public float? AverageWorkTime { get; set; }

                    /// <summary>
                    /// <para>Number of answered calls.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("CallsAnswered")]
                    [Validation(Required=false)]
                    public long? CallsAnswered { get; set; }

                    /// <summary>
                    /// <para>Transfer-in volume for consultation, which refers to the number of calls transferred to this skill group from other skill groups for consultation. Transfers between agents within the same skill group are not counted. If an agent joins multiple skill groups simultaneously, the call is attributed to the first skill group the agent signed into. If a single call is transferred multiple times from other skill groups to this skill group, each transfer is counted separately. The same rule applies below.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CallsAttendedTransferIn")]
                    [Validation(Required=false)]
                    public long? CallsAttendedTransferIn { get; set; }

                    /// <summary>
                    /// <para>Quantity of attended transfer-out calls, which refers to the number of calls transferred from this skill group to another skill group for consultation. Transfers between agents within the same skill group are not counted.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CallsAttendedTransferOut")]
                    [Validation(Required=false)]
                    public long? CallsAttendedTransferOut { get; set; }

                    /// <summary>
                    /// <para>Quantity of direct transfer-in calls, which refers to the number of calls directly transferred to this skill group from other skill groups. Transfers between agents within the same skill group are not counted. If an agent is signed into multiple skill groups simultaneously, the call is attributed to the first skill group the agent signed into. If a single call is transferred multiple times from other skill groups to this skill group, each transfer is counted separately. The same rule applies below.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CallsBlindTransferIn")]
                    [Validation(Required=false)]
                    public long? CallsBlindTransferIn { get; set; }

                    /// <summary>
                    /// <para>Quantity of direct transfer-out calls, which refers to the number of calls directly transferred from this skill group to other skill groups. Transfers between agents within the same skill group are not counted.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CallsBlindTransferOut")]
                    [Validation(Required=false)]
                    public long? CallsBlindTransferOut { get; set; }

                    /// <summary>
                    /// <para>Number of dialed calls.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>6</para>
                    /// </summary>
                    [NameInMap("CallsDialed")]
                    [Validation(Required=false)]
                    public long? CallsDialed { get; set; }

                    /// <summary>
                    /// <para>Number of calls placed on hold. If a call is placed on hold multiple times before being transfer-out from the current skill group, it counts as one occurrence.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CallsHold")]
                    [Validation(Required=false)]
                    public long? CallsHold { get; set; }

                    /// <summary>
                    /// <para>Number of calls that rang to agents. Each time a call enters the queue and is assigned to multiple agents, resulting in ringing, it counts as one occurrence.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CallsRinged")]
                    [Validation(Required=false)]
                    public long? CallsRinged { get; set; }

                    /// <summary>
                    /// <para>Maximum dialing time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12</para>
                    /// </summary>
                    [NameInMap("MaxDialingTime")]
                    [Validation(Required=false)]
                    public long? MaxDialingTime { get; set; }

                    /// <summary>
                    /// <para>Maximum hold time during calls, in seconds.</para>
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
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("MaxRingTime")]
                    [Validation(Required=false)]
                    public long? MaxRingTime { get; set; }

                    /// <summary>
                    /// <para>Maximum talk time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("MaxTalkTime")]
                    [Validation(Required=false)]
                    public long? MaxTalkTime { get; set; }

                    /// <summary>
                    /// <para>Maximum post-processing duration per call, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("MaxWorkTime")]
                    [Validation(Required=false)]
                    public long? MaxWorkTime { get; set; }

                    /// <summary>
                    /// <para>Satisfaction index, which is the average value of the single-digit satisfaction key presses.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("SatisfactionIndex")]
                    [Validation(Required=false)]
                    public float? SatisfactionIndex { get; set; }

                    /// <summary>
                    /// <para>Satisfaction rate. Calculation Formula: Quantity of evaluations marked as satisfied divided by the Count of satisfaction survey responses.</para>
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
                    /// <para>Response Count of satisfaction surveys.</para>
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
                    /// <para>218</para>
                    /// </summary>
                    [NameInMap("TotalDialingTime")]
                    [Validation(Required=false)]
                    public long? TotalDialingTime { get; set; }

                    /// <summary>
                    /// <para>Total call hold duration, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("TotalHoldTime")]
                    [Validation(Required=false)]
                    public long? TotalHoldTime { get; set; }

                    /// <summary>
                    /// <para>Total ring duration, in seconds.</para>
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
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("TotalTalkTime")]
                    [Validation(Required=false)]
                    public long? TotalTalkTime { get; set; }

                    /// <summary>
                    /// <para>Total post-processing duration, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>9</para>
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
                public ListHistoricalSkillGroupReportResponseBodyDataListOverall Overall { get; set; }
                public class ListHistoricalSkillGroupReportResponseBodyDataListOverall : TeaModel {
                    /// <summary>
                    /// <para>Average break duration, in seconds. Calculation Formula: TotalBreakTime / Break Count. Break Count is a non-API statistical field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("AverageBreakTime")]
                    [Validation(Required=false)]
                    public float? AverageBreakTime { get; set; }

                    /// <summary>
                    /// <para>Average call hold duration, in seconds. Calculation Formula: TotalHoldTime / (Inbound CallsHold + Outbound CallsHold).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("AverageHoldTime")]
                    [Validation(Required=false)]
                    public float? AverageHoldTime { get; set; }

                    /// <summary>
                    /// <para>Average ready time, in seconds. Calculation Formula: TotalReadyTime / Count of ready events. The count of ready events is not an API statistics field.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("AverageReadyTime")]
                    [Validation(Required=false)]
                    public float? AverageReadyTime { get; set; }

                    /// <summary>
                    /// <para>Average talk time, in seconds. Calculation formula: TotalTalkTime / (CallsAnswered + CallsHandled).</para>
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
                    /// <para>8</para>
                    /// </summary>
                    [NameInMap("AverageWorkTime")]
                    [Validation(Required=false)]
                    public float? AverageWorkTime { get; set; }

                    /// <summary>
                    /// <para>List of break details.</para>
                    /// </summary>
                    [NameInMap("BreakCodeDetailList")]
                    [Validation(Required=false)]
                    public List<ListHistoricalSkillGroupReportResponseBodyDataListOverallBreakCodeDetailList> BreakCodeDetailList { get; set; }
                    public class ListHistoricalSkillGroupReportResponseBodyDataListOverallBreakCodeDetailList : TeaModel {
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
                        /// <para>2</para>
                        /// </summary>
                        [NameInMap("Count")]
                        [Validation(Required=false)]
                        public long? Count { get; set; }

                        /// <summary>
                        /// <para>Total duration of this break type, in seconds.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3600</para>
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
                    /// <para>19328</para>
                    /// </summary>
                    [NameInMap("MaxReadyTime")]
                    [Validation(Required=false)]
                    public long? MaxReadyTime { get; set; }

                    /// <summary>
                    /// <para>Maximum talk time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("MaxTalkTime")]
                    [Validation(Required=false)]
                    public long? MaxTalkTime { get; set; }

                    /// <summary>
                    /// <para>Maximum post-processing duration, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12</para>
                    /// </summary>
                    [NameInMap("MaxWorkTime")]
                    [Validation(Required=false)]
                    public long? MaxWorkTime { get; set; }

                    /// <summary>
                    /// <para>Agent occupancy rate. Calculation formula: (TotalWorkTime + TotalTalkTime) / TotalLoggedInTime.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.02332222293912065</para>
                    /// </summary>
                    [NameInMap("OccupancyRate")]
                    [Validation(Required=false)]
                    public float? OccupancyRate { get; set; }

                    /// <summary>
                    /// <para>Satisfaction index, which is the average value of the satisfaction keypress digits (single-digit numbers).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("SatisfactionIndex")]
                    [Validation(Required=false)]
                    public float? SatisfactionIndex { get; set; }

                    /// <summary>
                    /// <para>Satisfaction rate. Calculation Formula: Number of responses marked as satisfied / Count of satisfaction survey responses.</para>
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
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("TotalBreakTime")]
                    [Validation(Required=false)]
                    public long? TotalBreakTime { get; set; }

                    /// <summary>
                    /// <para>Total call volume. Calculation Formula: CallsOffered + CallsDialed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>13</para>
                    /// </summary>
                    [NameInMap("TotalCalls")]
                    [Validation(Required=false)]
                    public long? TotalCalls { get; set; }

                    /// <summary>
                    /// <para>Total hold duration, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("TotalHoldTime")]
                    [Validation(Required=false)]
                    public long? TotalHoldTime { get; set; }

                    /// <summary>
                    /// <para>Total logon time, in seconds.<br><em>Note: Excludes offline and short break durations.</em></para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>23218</para>
                    /// </summary>
                    [NameInMap("TotalLoggedInTime")]
                    [Validation(Required=false)]
                    public long? TotalLoggedInTime { get; set; }

                    /// <summary>
                    /// <para>Total ready time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>22428</para>
                    /// </summary>
                    [NameInMap("TotalReadyTime")]
                    [Validation(Required=false)]
                    public long? TotalReadyTime { get; set; }

                    /// <summary>
                    /// <para>Total talk time, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>449</para>
                    /// </summary>
                    [NameInMap("TotalTalkTime")]
                    [Validation(Required=false)]
                    public long? TotalTalkTime { get; set; }

                    /// <summary>
                    /// <para>Total post-processing duration, in seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>94</para>
                    /// </summary>
                    [NameInMap("TotalWorkTime")]
                    [Validation(Required=false)]
                    public long? TotalWorkTime { get; set; }

                }

                /// <summary>
                /// <para>Skill group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>skillgroup@ccc-test</para>
                /// </summary>
                [NameInMap("SkillGroupId")]
                [Validation(Required=false)]
                public string SkillGroupId { get; set; }

                /// <summary>
                /// <para>Skill group name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>skillgroup</para>
                /// </summary>
                [NameInMap("SkillGroupName")]
                [Validation(Required=false)]
                public string SkillGroupName { get; set; }

            }

            /// <summary>
            /// <para>Page number, ranging from 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>Page size, ranging from 1 to 100.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>Total count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
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
        /// <para>26A34338-5CD9-4C95-A7A6-5BDCE76C6B94</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
