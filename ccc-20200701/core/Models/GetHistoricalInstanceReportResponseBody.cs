// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class GetHistoricalInstanceReportResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetHistoricalInstanceReportResponseBodyData Data { get; set; }
        public class GetHistoricalInstanceReportResponseBodyData : TeaModel {
            [NameInMap("Inbound")]
            [Validation(Required=false)]
            public GetHistoricalInstanceReportResponseBodyDataInbound Inbound { get; set; }
            public class GetHistoricalInstanceReportResponseBodyDataInbound : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AbandonRate")]
                [Validation(Required=false)]
                public float? AbandonRate { get; set; }

                [NameInMap("AccessChannelTypeDetailList")]
                [Validation(Required=false)]
                public List<GetHistoricalInstanceReportResponseBodyDataInboundAccessChannelTypeDetailList> AccessChannelTypeDetailList { get; set; }
                public class GetHistoricalInstanceReportResponseBodyDataInboundAccessChannelTypeDetailList : TeaModel {
                    [NameInMap("AccessChannelType")]
                    [Validation(Required=false)]
                    public string AccessChannelType { get; set; }

                    [NameInMap("CallsOffered")]
                    [Validation(Required=false)]
                    public long? CallsOffered { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AverageAbandonTime")]
                [Validation(Required=false)]
                public float? AverageAbandonTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AverageAbandonedInIVRTime")]
                [Validation(Required=false)]
                public float? AverageAbandonedInIVRTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AverageAbandonedInQueueTime")]
                [Validation(Required=false)]
                public float? AverageAbandonedInQueueTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AverageAbandonedInRingTime")]
                [Validation(Required=false)]
                public float? AverageAbandonedInRingTime { get; set; }

                [NameInMap("AverageFirstResponseTime")]
                [Validation(Required=false)]
                public float? AverageFirstResponseTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AverageHoldTime")]
                [Validation(Required=false)]
                public float? AverageHoldTime { get; set; }

                [NameInMap("AverageResponseTime")]
                [Validation(Required=false)]
                public float? AverageResponseTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AverageRingTime")]
                [Validation(Required=false)]
                public float? AverageRingTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AverageTalkTime")]
                [Validation(Required=false)]
                public float? AverageTalkTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AverageWaitTime")]
                [Validation(Required=false)]
                public float? AverageWaitTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AverageWorkTime")]
                [Validation(Required=false)]
                public float? AverageWorkTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsAbandoned")]
                [Validation(Required=false)]
                public long? CallsAbandoned { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsAbandonedInIVR")]
                [Validation(Required=false)]
                public long? CallsAbandonedInIVR { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsAbandonedInQueue")]
                [Validation(Required=false)]
                public long? CallsAbandonedInQueue { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsAbandonedInRing")]
                [Validation(Required=false)]
                public long? CallsAbandonedInRing { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsAbandonedInVoiceNavigator")]
                [Validation(Required=false)]
                public long? CallsAbandonedInVoiceNavigator { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsAttendedTransferred")]
                [Validation(Required=false)]
                public long? CallsAttendedTransferred { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsBlindTransferred")]
                [Validation(Required=false)]
                public long? CallsBlindTransferred { get; set; }

                [NameInMap("CallsCausedIVRException")]
                [Validation(Required=false)]
                public long? CallsCausedIVRException { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsForwardToOutsideNumber")]
                [Validation(Required=false)]
                public long? CallsForwardToOutsideNumber { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsHandled")]
                [Validation(Required=false)]
                public long? CallsHandled { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsHold")]
                [Validation(Required=false)]
                public long? CallsHold { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsIVRException")]
                [Validation(Required=false)]
                public long? CallsIVRException { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsOffered")]
                [Validation(Required=false)]
                public long? CallsOffered { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsQueued")]
                [Validation(Required=false)]
                public long? CallsQueued { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsQueuingFailed")]
                [Validation(Required=false)]
                public long? CallsQueuingFailed { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsQueuingOverflow")]
                [Validation(Required=false)]
                public long? CallsQueuingOverflow { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsQueuingTimeout")]
                [Validation(Required=false)]
                public long? CallsQueuingTimeout { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsRinged")]
                [Validation(Required=false)]
                public long? CallsRinged { get; set; }

                [NameInMap("CallsToVoicemail")]
                [Validation(Required=false)]
                public long? CallsToVoicemail { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsVoicemail")]
                [Validation(Required=false)]
                public long? CallsVoicemail { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("HandleRate")]
                [Validation(Required=false)]
                public float? HandleRate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MaxAbandonTime")]
                [Validation(Required=false)]
                public long? MaxAbandonTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("MaxAbandonedInIVRTime")]
                [Validation(Required=false)]
                public long? MaxAbandonedInIVRTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MaxAbandonedInQueueTime")]
                [Validation(Required=false)]
                public long? MaxAbandonedInQueueTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MaxAbandonedInRingTime")]
                [Validation(Required=false)]
                public long? MaxAbandonedInRingTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MaxHoldTime")]
                [Validation(Required=false)]
                public long? MaxHoldTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MaxRingTime")]
                [Validation(Required=false)]
                public long? MaxRingTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MaxTalkTime")]
                [Validation(Required=false)]
                public long? MaxTalkTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MaxWaitTime")]
                [Validation(Required=false)]
                public long? MaxWaitTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MaxWorkTime")]
                [Validation(Required=false)]
                public long? MaxWorkTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SatisfactionIndex")]
                [Validation(Required=false)]
                public float? SatisfactionIndex { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SatisfactionRate")]
                [Validation(Required=false)]
                public float? SatisfactionRate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SatisfactionSurveysOffered")]
                [Validation(Required=false)]
                public long? SatisfactionSurveysOffered { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SatisfactionSurveysResponded")]
                [Validation(Required=false)]
                public long? SatisfactionSurveysResponded { get; set; }

                [NameInMap("ServiceLevel15")]
                [Validation(Required=false)]
                public float? ServiceLevel15 { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ServiceLevel20")]
                [Validation(Required=false)]
                public float? ServiceLevel20 { get; set; }

                [NameInMap("ServiceLevel30")]
                [Validation(Required=false)]
                public float? ServiceLevel30 { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalAbandonTime")]
                [Validation(Required=false)]
                public long? TotalAbandonTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalAbandonedInIVRTime")]
                [Validation(Required=false)]
                public long? TotalAbandonedInIVRTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalAbandonedInQueueTime")]
                [Validation(Required=false)]
                public long? TotalAbandonedInQueueTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalAbandonedInRingTime")]
                [Validation(Required=false)]
                public long? TotalAbandonedInRingTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalHoldTime")]
                [Validation(Required=false)]
                public long? TotalHoldTime { get; set; }

                [NameInMap("TotalMessagesSent")]
                [Validation(Required=false)]
                public long? TotalMessagesSent { get; set; }

                [NameInMap("TotalMessagesSentByAgent")]
                [Validation(Required=false)]
                public long? TotalMessagesSentByAgent { get; set; }

                [NameInMap("TotalMessagesSentByCustomer")]
                [Validation(Required=false)]
                public long? TotalMessagesSentByCustomer { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalRingTime")]
                [Validation(Required=false)]
                public long? TotalRingTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalTalkTime")]
                [Validation(Required=false)]
                public long? TotalTalkTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalWaitTime")]
                [Validation(Required=false)]
                public long? TotalWaitTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalWorkTime")]
                [Validation(Required=false)]
                public long? TotalWorkTime { get; set; }

            }

            [NameInMap("Internal")]
            [Validation(Required=false)]
            public GetHistoricalInstanceReportResponseBodyDataInternal Internal { get; set; }
            public class GetHistoricalInstanceReportResponseBodyDataInternal : TeaModel {
                [NameInMap("CallsAnswered")]
                [Validation(Required=false)]
                public long? CallsAnswered { get; set; }

                [NameInMap("CallsDialed")]
                [Validation(Required=false)]
                public long? CallsDialed { get; set; }

            }

            [NameInMap("Outbound")]
            [Validation(Required=false)]
            public GetHistoricalInstanceReportResponseBodyDataOutbound Outbound { get; set; }
            public class GetHistoricalInstanceReportResponseBodyDataOutbound : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AnswerRate")]
                [Validation(Required=false)]
                public float? AnswerRate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AverageDialingTime")]
                [Validation(Required=false)]
                public float? AverageDialingTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AverageHoldTime")]
                [Validation(Required=false)]
                public float? AverageHoldTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AverageRingTime")]
                [Validation(Required=false)]
                public float? AverageRingTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AverageTalkTime")]
                [Validation(Required=false)]
                public float? AverageTalkTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AverageWorkTime")]
                [Validation(Required=false)]
                public float? AverageWorkTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsAnswered")]
                [Validation(Required=false)]
                public long? CallsAnswered { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsAttendedTransferred")]
                [Validation(Required=false)]
                public long? CallsAttendedTransferred { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsBlindTransferred")]
                [Validation(Required=false)]
                public long? CallsBlindTransferred { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsDialed")]
                [Validation(Required=false)]
                public long? CallsDialed { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsHold")]
                [Validation(Required=false)]
                public int? CallsHold { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CallsRinged")]
                [Validation(Required=false)]
                public long? CallsRinged { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MaxDialingTime")]
                [Validation(Required=false)]
                public long? MaxDialingTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MaxHoldTime")]
                [Validation(Required=false)]
                public long? MaxHoldTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MaxRingTime")]
                [Validation(Required=false)]
                public long? MaxRingTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MaxTalkTime")]
                [Validation(Required=false)]
                public long? MaxTalkTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MaxWorkTime")]
                [Validation(Required=false)]
                public long? MaxWorkTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SatisfactionIndex")]
                [Validation(Required=false)]
                public float? SatisfactionIndex { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SatisfactionRate")]
                [Validation(Required=false)]
                public float? SatisfactionRate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SatisfactionSurveysOffered")]
                [Validation(Required=false)]
                public long? SatisfactionSurveysOffered { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SatisfactionSurveysResponded")]
                [Validation(Required=false)]
                public long? SatisfactionSurveysResponded { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalDialingTime")]
                [Validation(Required=false)]
                public long? TotalDialingTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalHoldTime")]
                [Validation(Required=false)]
                public long? TotalHoldTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalRingTime")]
                [Validation(Required=false)]
                public long? TotalRingTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalTalkTime")]
                [Validation(Required=false)]
                public long? TotalTalkTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalWorkTime")]
                [Validation(Required=false)]
                public long? TotalWorkTime { get; set; }

            }

            [NameInMap("Overall")]
            [Validation(Required=false)]
            public GetHistoricalInstanceReportResponseBodyDataOverall Overall { get; set; }
            public class GetHistoricalInstanceReportResponseBodyDataOverall : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AverageBreakTime")]
                [Validation(Required=false)]
                public float? AverageBreakTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AverageHoldTime")]
                [Validation(Required=false)]
                public float? AverageHoldTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AverageReadyTime")]
                [Validation(Required=false)]
                public float? AverageReadyTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AverageTalkTime")]
                [Validation(Required=false)]
                public float? AverageTalkTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AverageWorkTime")]
                [Validation(Required=false)]
                public float? AverageWorkTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MaxBreakTime")]
                [Validation(Required=false)]
                public long? MaxBreakTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MaxHoldTime")]
                [Validation(Required=false)]
                public long? MaxHoldTime { get; set; }

                [NameInMap("MaxLoggedInAgents")]
                [Validation(Required=false)]
                public long? MaxLoggedInAgents { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MaxReadyTime")]
                [Validation(Required=false)]
                public long? MaxReadyTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MaxTalkTime")]
                [Validation(Required=false)]
                public long? MaxTalkTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MaxWorkTime")]
                [Validation(Required=false)]
                public long? MaxWorkTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("OccupancyRate")]
                [Validation(Required=false)]
                public float? OccupancyRate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SatisfactionIndex")]
                [Validation(Required=false)]
                public float? SatisfactionIndex { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SatisfactionRate")]
                [Validation(Required=false)]
                public float? SatisfactionRate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SatisfactionSurveysOffered")]
                [Validation(Required=false)]
                public long? SatisfactionSurveysOffered { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SatisfactionSurveysResponded")]
                [Validation(Required=false)]
                public long? SatisfactionSurveysResponded { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalBreakTime")]
                [Validation(Required=false)]
                public long? TotalBreakTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalCalls")]
                [Validation(Required=false)]
                public long? TotalCalls { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalHoldTime")]
                [Validation(Required=false)]
                public long? TotalHoldTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalLoggedInTime")]
                [Validation(Required=false)]
                public long? TotalLoggedInTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalReadyTime")]
                [Validation(Required=false)]
                public long? TotalReadyTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalTalkTime")]
                [Validation(Required=false)]
                public long? TotalTalkTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TotalWorkTime")]
                [Validation(Required=false)]
                public long? TotalWorkTime { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>943D8EF3-3321-471F-A104-51C96FCA94D6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
