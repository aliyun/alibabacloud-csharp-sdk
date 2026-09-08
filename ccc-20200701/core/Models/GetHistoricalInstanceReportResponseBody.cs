// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class GetHistoricalInstanceReportResponseBody : TeaModel {
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
        public GetHistoricalInstanceReportResponseBodyData Data { get; set; }
        public class GetHistoricalInstanceReportResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Inbound data.</para>
            /// </summary>
            [NameInMap("Inbound")]
            [Validation(Required=false)]
            public GetHistoricalInstanceReportResponseBodyDataInbound Inbound { get; set; }
            public class GetHistoricalInstanceReportResponseBodyDataInbound : TeaModel {
                /// <summary>
                /// <para>Abandon rate. Calculation Formula: CallsAbandoned / CallsOffered (because abandonment events and assignment events may fall into different time ranges, the result may exceed 100% in certain cases).</para>
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
                [NameInMap("AccessChannelTypeDetailList")]
                [Validation(Required=false)]
                public List<GetHistoricalInstanceReportResponseBodyDataInboundAccessChannelTypeDetailList> AccessChannelTypeDetailList { get; set; }
                public class GetHistoricalInstanceReportResponseBodyDataInboundAccessChannelTypeDetailList : TeaModel {
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
                    /// <para>Number of assigned sessions.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5</para>
                    /// </summary>
                    [NameInMap("CallsOffered")]
                    [Validation(Required=false)]
                    public long? CallsOffered { get; set; }

                }

                /// <summary>
                /// <para>Average abandon time, in seconds. Calculation formula: TotalAbandonTime / CallsAbandoned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AverageAbandonTime")]
                [Validation(Required=false)]
                public float? AverageAbandonTime { get; set; }

                /// <summary>
                /// <para>Average IVR abandonment duration, in seconds. Calculation Formula: TotalAbandonedInIVRTime / CallsAbandonedInIVR.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AverageAbandonedInIVRTime")]
                [Validation(Required=false)]
                public float? AverageAbandonedInIVRTime { get; set; }

                /// <summary>
                /// <para>[responses_200_schema_properties_Data_properties_Inbound_properties_MaxAbandonedInQueueTime_type]integer</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AverageAbandonedInQueueTime")]
                [Validation(Required=false)]
                public float? AverageAbandonedInQueueTime { get; set; }

                /// <summary>
                /// <para>Average ring-time abandon duration, in seconds. Calculation formula: TotalAbandonedInRingTime / CallsAbandonedInRing.</para>
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
                /// <para>12</para>
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
                /// <para>Average response time (RT) for chat sessions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>15</para>
                /// </summary>
                [NameInMap("AverageResponseTime")]
                [Validation(Required=false)]
                public float? AverageResponseTime { get; set; }

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
                /// <para>Average talk time, in seconds. Calculation Formula: TotalTalkTime / CallsHandled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AverageTalkTime")]
                [Validation(Required=false)]
                public float? AverageTalkTime { get; set; }

                /// <summary>
                /// <para>[responses_200_schema_properties_Data_properties_Inbound_properties_AverageFirstResponseTime_type]number</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AverageWaitTime")]
                [Validation(Required=false)]
                public float? AverageWaitTime { get; set; }

                /// <summary>
                /// <para>Average post-processing time, in seconds. Calculation formula: TotalWorkTime / CallsHandled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AverageWorkTime")]
                [Validation(Required=false)]
                public float? AverageWorkTime { get; set; }

                /// <summary>
                /// <para>Total number of abandoned calls. Calculation Formula: CallsAbandonedInIVR + CallsAbandonedInQueue + CallsAbandonedInRing.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsAbandoned")]
                [Validation(Required=false)]
                public long? CallsAbandoned { get; set; }

                /// <summary>
                /// <para>Number of calls abandoned in IVR, which refers to the count of calls where the customer hung up during the IVR flow after entering it. This is determined by the hang-up reason in call details being marked as &quot;IVR abandoned.&quot;</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsAbandonedInIVR")]
                [Validation(Required=false)]
                public long? CallsAbandonedInIVR { get; set; }

                /// <summary>
                /// <para>Number of calls abandoned in queue, which refers to the number of calls where the customer hung up while waiting in the queue after the call entered the queue.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsAbandonedInQueue")]
                [Validation(Required=false)]
                public long? CallsAbandonedInQueue { get; set; }

                /// <summary>
                /// <para>Number of calls abandoned during ringing, which refers to the quantity of calls where the customer hung up while the agent\&quot;s phone was ringing.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsAbandonedInRing")]
                [Validation(Required=false)]
                public long? CallsAbandonedInRing { get; set; }

                /// <summary>
                /// <para>Number of calls abandoned in the Intelligent Voice Navigator module.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsAbandonedInVoiceNavigator")]
                [Validation(Required=false)]
                public long? CallsAbandonedInVoiceNavigator { get; set; }

                /// <summary>
                /// <para>Number of consultative transfers, which refers to the number of calls that were transferred via consultative transfer. If a single call is transferred multiple times, it is counted as one.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsAttendedTransferred")]
                [Validation(Required=false)]
                public long? CallsAttendedTransferred { get; set; }

                /// <summary>
                /// <para>The number of blind transfers, which refers to the count of calls directly transferred without consultation. If a single call is transferred multiple times, it is counted as one.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsBlindTransferred")]
                [Validation(Required=false)]
                public long? CallsBlindTransferred { get; set; }

                /// <summary>
                /// <para>Number of calls that caused IVR exceptions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsCausedIVRException")]
                [Validation(Required=false)]
                public long? CallsCausedIVRException { get; set; }

                /// <summary>
                /// <para>Number of calls forwarded to an external number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsForwardToOutsideNumber")]
                [Validation(Required=false)]
                public long? CallsForwardToOutsideNumber { get; set; }

                /// <summary>
                /// <para>Acknowledgement count, which refers to the number of calls answered by agents. If a single call is answered by multiple agents, it is counted only once.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsHandled")]
                [Validation(Required=false)]
                public long? CallsHandled { get; set; }

                /// <summary>
                /// <para>[responses_200_schema_properties_Data_properties_Inbound_properties_TotalAbandonTime_type]integer</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsHold")]
                [Validation(Required=false)]
                public long? CallsHold { get; set; }

                /// <summary>
                /// <para>Number of calls with IVR exceptions. A call is counted when the IVR enters a hang-up reason node and the hang-up reason configured in that node is &quot;transfer to agent failed.&quot;</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsIVRException")]
                [Validation(Required=false)]
                public long? CallsIVRException { get; set; }

                /// <summary>
                /// <para>[responses_200_schema_properties_Data_properties_Inbound_properties_TotalAbandonedInRingTime_type]integer</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsOffered")]
                [Validation(Required=false)]
                public long? CallsOffered { get; set; }

                /// <summary>
                /// <para>Number of calls entering the queue. If a single call enters the queue multiple times, it is counted once.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsQueued")]
                [Validation(Required=false)]
                public long? CallsQueued { get; set; }

                /// <summary>
                /// <para>The number of queue failures, which refers to the count of calls where the customer hung up while waiting in the queue after entering it.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsQueuingFailed")]
                [Validation(Required=false)]
                public long? CallsQueuingFailed { get; set; }

                /// <summary>
                /// <para>The number of calls that overflowed from the queue, where queue overflow refers to calls exceeding the queue capacity while waiting in the IVR queue.</para>
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
                /// <para>Number of calls that rang agents. If a single call is assigned to multiple agents and rings, it is counted once.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsRinged")]
                [Validation(Required=false)]
                public long? CallsRinged { get; set; }

                /// <summary>
                /// <para>The number of calls routed to voicemail.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("CallsToVoicemail")]
                [Validation(Required=false)]
                public long? CallsToVoicemail { get; set; }

                /// <summary>
                /// <para>Number of calls transferred to voicemail. The count increases by 1 when a call enters the voicemail module configured in IVR.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsVoicemail")]
                [Validation(Required=false)]
                public long? CallsVoicemail { get; set; }

                /// <summary>
                /// <para>[responses_200_schema_properties_Data_properties_Inbound_properties_CallsBlindTransferred_type]integer</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("HandleRate")]
                [Validation(Required=false)]
                public float? HandleRate { get; set; }

                /// <summary>
                /// <para>Maximum abandon time, in seconds. A call is considered abandoned if the customer hangs up after entering the IVR but before an agent answers.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MaxAbandonTime")]
                [Validation(Required=false)]
                public long? MaxAbandonTime { get; set; }

                /// <summary>
                /// <para>Maximum IVR abandonment duration, in seconds. IVR abandonment is defined as a customer hanging up during IVR interaction. This does not include hang-ups while waiting in queue or during agent ringing after call assignment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("MaxAbandonedInIVRTime")]
                [Validation(Required=false)]
                public long? MaxAbandonedInIVRTime { get; set; }

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
                /// <para>Maximum ringing abandonment duration, in seconds. Ringing abandonment is defined as the customer hanging up while the call is ringing on the agent\&quot;s side after being assigned to the agent.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MaxAbandonedInRingTime")]
                [Validation(Required=false)]
                public long? MaxAbandonedInRingTime { get; set; }

                /// <summary>
                /// <para>Maximum hold time, in seconds.</para>
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
                /// <para>Maximum wait time, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MaxWaitTime")]
                [Validation(Required=false)]
                public long? MaxWaitTime { get; set; }

                /// <summary>
                /// <para>Maximum post-processing time, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MaxWorkTime")]
                [Validation(Required=false)]
                public long? MaxWorkTime { get; set; }

                /// <summary>
                /// <para>[responses_200_schema_properties_Data_properties_Inbound_properties_CallsQueuingOverflow_type]integer</para>
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
                /// <para>Service level within 15 seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.78</para>
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
                /// <para>Total IVR abandonment duration, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalAbandonedInIVRTime")]
                [Validation(Required=false)]
                public long? TotalAbandonedInIVRTime { get; set; }

                /// <summary>
                /// <para>Total queue abandon time, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalAbandonedInQueueTime")]
                [Validation(Required=false)]
                public long? TotalAbandonedInQueueTime { get; set; }

                /// <summary>
                /// <para>[responses_200_schema_properties_Data_properties_Inbound_properties_SatisfactionSurveysOffered_type]integer</para>
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
                /// <para>8</para>
                /// </summary>
                [NameInMap("TotalMessagesSentByAgent")]
                [Validation(Required=false)]
                public long? TotalMessagesSentByAgent { get; set; }

                /// <summary>
                /// <para>Total number of messages sent by the customer in chat sessions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("TotalMessagesSentByCustomer")]
                [Validation(Required=false)]
                public long? TotalMessagesSentByCustomer { get; set; }

                /// <summary>
                /// <para>[responses_200_schema_properties_Data_properties_Inbound_properties_CallsQueuingFailed_type]integer</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalRingTime")]
                [Validation(Required=false)]
                public long? TotalRingTime { get; set; }

                /// <summary>
                /// <para>[responses_200_schema_properties_Data_properties_Inbound_properties_CallsToVoicemail_type]integer</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalTalkTime")]
                [Validation(Required=false)]
                public long? TotalTalkTime { get; set; }

                /// <summary>
                /// <para>Total wait time, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalWaitTime")]
                [Validation(Required=false)]
                public long? TotalWaitTime { get; set; }

                /// <summary>
                /// <para>Total post-processing duration, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
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
            public GetHistoricalInstanceReportResponseBodyDataInternal Internal { get; set; }
            public class GetHistoricalInstanceReportResponseBodyDataInternal : TeaModel {
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
                /// <para>Dial-up volume.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("CallsDialed")]
                [Validation(Required=false)]
                public long? CallsDialed { get; set; }

            }

            /// <summary>
            /// <para>Outbound metrics.</para>
            /// </summary>
            [NameInMap("Outbound")]
            [Validation(Required=false)]
            public GetHistoricalInstanceReportResponseBodyDataOutbound Outbound { get; set; }
            public class GetHistoricalInstanceReportResponseBodyDataOutbound : TeaModel {
                /// <summary>
                /// <para>Answer rate. Calculation Formula: CallsAnswered / CallsDialed. (Because the answering event and the acknowledgement event may fall into different time ranges, the result may exceed 100% in certain cases.)</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AnswerRate")]
                [Validation(Required=false)]
                public float? AnswerRate { get; set; }

                /// <summary>
                /// <para>Average Dial-up Time, in seconds. Calculation Formula: TotalDialingTime / CallsDialed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AverageDialingTime")]
                [Validation(Required=false)]
                public float? AverageDialingTime { get; set; }

                /// <summary>
                /// <para>Average hold duration, in seconds. Calculation formula: TotalHoldTime / CallsHold.</para>
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
                /// <para>0</para>
                /// </summary>
                [NameInMap("AverageTalkTime")]
                [Validation(Required=false)]
                public float? AverageTalkTime { get; set; }

                /// <summary>
                /// <para>Average post-processing time per call, in seconds. Calculation Formula: TotalWorkTime / CallsDialed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AverageWorkTime")]
                [Validation(Required=false)]
                public float? AverageWorkTime { get; set; }

                /// <summary>
                /// <para>Answered Call Count.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsAnswered")]
                [Validation(Required=false)]
                public long? CallsAnswered { get; set; }

                /// <summary>
                /// <para>Number of attended transfers, which refers to the quantity of calls that underwent attended transfer. If a single call is transferred multiple times, it is counted as one.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsAttendedTransferred")]
                [Validation(Required=false)]
                public long? CallsAttendedTransferred { get; set; }

                /// <summary>
                /// <para>Number of blind transfers, which refers to the quantity of calls that underwent blind transfer. If a single call is transferred multiple times, it is counted as one.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsBlindTransferred")]
                [Validation(Required=false)]
                public long? CallsBlindTransferred { get; set; }

                /// <summary>
                /// <para>Dial-up Call Count.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsDialed")]
                [Validation(Required=false)]
                public long? CallsDialed { get; set; }

                /// <summary>
                /// <para>Hold Count, which is the number of calls that were placed on hold. If a single call was put on hold multiple times, it is counted as one.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsHold")]
                [Validation(Required=false)]
                public int? CallsHold { get; set; }

                /// <summary>
                /// <para>Number of calls that rang for agents. If a single call is assigned to multiple agents and rings for each, it is counted as one.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsRinged")]
                [Validation(Required=false)]
                public long? CallsRinged { get; set; }

                /// <summary>
                /// <para>Maximum Dial-up Time, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MaxDialingTime")]
                [Validation(Required=false)]
                public long? MaxDialingTime { get; set; }

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
                /// <para>Maximum ring duration, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MaxRingTime")]
                [Validation(Required=false)]
                public long? MaxRingTime { get; set; }

                /// <summary>
                /// <para>Maximum Talk Time, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MaxTalkTime")]
                [Validation(Required=false)]
                public long? MaxTalkTime { get; set; }

                /// <summary>
                /// <para>Maximum post-processing time per call, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MaxWorkTime")]
                [Validation(Required=false)]
                public long? MaxWorkTime { get; set; }

                /// <summary>
                /// <para>Satisfaction Index, which is the average of the satisfaction keypress digits (single-digit numbers).</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SatisfactionIndex")]
                [Validation(Required=false)]
                public float? SatisfactionIndex { get; set; }

                /// <summary>
                /// <para>Satisfaction Rate. Calculation Formula: Number of responses marked as satisfied / Count of satisfaction survey responses.</para>
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
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalDialingTime")]
                [Validation(Required=false)]
                public long? TotalDialingTime { get; set; }

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
                /// <para>Total Ring Time, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalRingTime")]
                [Validation(Required=false)]
                public long? TotalRingTime { get; set; }

                /// <summary>
                /// <para>Total Talk Time, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalTalkTime")]
                [Validation(Required=false)]
                public long? TotalTalkTime { get; set; }

                /// <summary>
                /// <para>Total post-processing duration, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
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
            public GetHistoricalInstanceReportResponseBodyDataOverall Overall { get; set; }
            public class GetHistoricalInstanceReportResponseBodyDataOverall : TeaModel {
                /// <summary>
                /// <para>Average break duration, in seconds. Calculation Formula: TotalBreakTime / Count of breaks. The count of breaks is not an exposed API field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AverageBreakTime")]
                [Validation(Required=false)]
                public float? AverageBreakTime { get; set; }

                /// <summary>
                /// <para>Average call hold duration, in seconds. Calculation Formula: TotalHoldTime / (InboundCallsHold + OutboundCallsHold).</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AverageHoldTime")]
                [Validation(Required=false)]
                public float? AverageHoldTime { get; set; }

                /// <summary>
                /// <para>Average ready duration, in seconds. Calculation Formula: TotalReadyTime / Count of ready events. The count of ready events is not currently exposed externally.</para>
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
                /// <para>Average post-processing time per call, in seconds. Calculation Formula: TotalWorkTime / TotalCalls.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AverageWorkTime")]
                [Validation(Required=false)]
                public float? AverageWorkTime { get; set; }

                /// <summary>
                /// <para>Maximum short break duration, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
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
                /// <para>Maximum number of agents simultaneously logged on during the Time Range.</para>
                /// 
                /// <b>Example:</b>
                /// <para>102</para>
                /// </summary>
                [NameInMap("MaxLoggedInAgents")]
                [Validation(Required=false)]
                public long? MaxLoggedInAgents { get; set; }

                /// <summary>
                /// <para>Maximum ready time, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
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
                /// <para>Maximum post-processing time per call, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MaxWorkTime")]
                [Validation(Required=false)]
                public long? MaxWorkTime { get; set; }

                /// <summary>
                /// <para>Agent occupancy rate. Calculation Formula: (TotalWorkTime + TotalTalkTime) / TotalLoggedInTime.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
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
                /// <para>Total break time, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalBreakTime")]
                [Validation(Required=false)]
                public long? TotalBreakTime { get; set; }

                /// <summary>
                /// <para>Total call volume. Calculation Formula: CallsOffered + CallsDialed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
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
                /// <para>Total logon duration, in seconds. Exclude break time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalLoggedInTime")]
                [Validation(Required=false)]
                public long? TotalLoggedInTime { get; set; }

                /// <summary>
                /// <para>Total ready time, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalReadyTime")]
                [Validation(Required=false)]
                public long? TotalReadyTime { get; set; }

                /// <summary>
                /// <para>Total talk time, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalTalkTime")]
                [Validation(Required=false)]
                public long? TotalTalkTime { get; set; }

                /// <summary>
                /// <para>Total post-processing time, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalWorkTime")]
                [Validation(Required=false)]
                public long? TotalWorkTime { get; set; }

            }

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
