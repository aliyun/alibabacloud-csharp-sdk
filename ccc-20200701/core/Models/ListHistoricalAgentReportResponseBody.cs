// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListHistoricalAgentReportResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListHistoricalAgentReportResponseBodyData Data { get; set; }
        public class ListHistoricalAgentReportResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListHistoricalAgentReportResponseBodyDataList> List { get; set; }
            public class ListHistoricalAgentReportResponseBodyDataList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>agent1@ccc-test</para>
                /// </summary>
                [NameInMap("AgentId")]
                [Validation(Required=false)]
                public string AgentId { get; set; }

                [NameInMap("AgentName")]
                [Validation(Required=false)]
                public string AgentName { get; set; }

                [NameInMap("Back2Back")]
                [Validation(Required=false)]
                public ListHistoricalAgentReportResponseBodyDataListBack2Back Back2Back { get; set; }
                public class ListHistoricalAgentReportResponseBodyDataListBack2Back : TeaModel {
                    [NameInMap("AgentHandleRate")]
                    [Validation(Required=false)]
                    public string AgentHandleRate { get; set; }

                    [NameInMap("AnswerRate")]
                    [Validation(Required=false)]
                    public string AnswerRate { get; set; }

                    [NameInMap("AverageCustomerRingTime")]
                    [Validation(Required=false)]
                    public string AverageCustomerRingTime { get; set; }

                    [NameInMap("AverageRingTime")]
                    [Validation(Required=false)]
                    public string AverageRingTime { get; set; }

                    [NameInMap("AverageTalkTime")]
                    [Validation(Required=false)]
                    public string AverageTalkTime { get; set; }

                    [NameInMap("CallsAgentHandled")]
                    [Validation(Required=false)]
                    public string CallsAgentHandled { get; set; }

                    [NameInMap("CallsAnswered")]
                    [Validation(Required=false)]
                    public string CallsAnswered { get; set; }

                    [NameInMap("CallsCustomerAnswered")]
                    [Validation(Required=false)]
                    public string CallsCustomerAnswered { get; set; }

                    [NameInMap("CallsDialed")]
                    [Validation(Required=false)]
                    public string CallsDialed { get; set; }

                    [NameInMap("CustomerAnswerRate")]
                    [Validation(Required=false)]
                    public string CustomerAnswerRate { get; set; }

                    [NameInMap("MaxCustomerRingTime")]
                    [Validation(Required=false)]
                    public string MaxCustomerRingTime { get; set; }

                    [NameInMap("MaxRingTime")]
                    [Validation(Required=false)]
                    public string MaxRingTime { get; set; }

                    [NameInMap("MaxTalkTime")]
                    [Validation(Required=false)]
                    public string MaxTalkTime { get; set; }

                    [NameInMap("TotalCustomerRingTime")]
                    [Validation(Required=false)]
                    public string TotalCustomerRingTime { get; set; }

                    [NameInMap("TotalRingTime")]
                    [Validation(Required=false)]
                    public string TotalRingTime { get; set; }

                    [NameInMap("TotalTalkTime")]
                    [Validation(Required=false)]
                    public string TotalTalkTime { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>001</para>
                /// </summary>
                [NameInMap("DisplayId")]
                [Validation(Required=false)]
                public string DisplayId { get; set; }

                [NameInMap("Inbound")]
                [Validation(Required=false)]
                public ListHistoricalAgentReportResponseBodyDataListInbound Inbound { get; set; }
                public class ListHistoricalAgentReportResponseBodyDataListInbound : TeaModel {
                    [NameInMap("AccessChannelTypeDetails")]
                    [Validation(Required=false)]
                    public List<ListHistoricalAgentReportResponseBodyDataListInboundAccessChannelTypeDetails> AccessChannelTypeDetails { get; set; }
                    public class ListHistoricalAgentReportResponseBodyDataListInboundAccessChannelTypeDetails : TeaModel {
                        [NameInMap("AccessChannelType")]
                        [Validation(Required=false)]
                        public string AccessChannelType { get; set; }

                        [NameInMap("CallsOffered")]
                        [Validation(Required=false)]
                        public long? CallsOffered { get; set; }

                    }

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
                    [NameInMap("AverageWorkTime")]
                    [Validation(Required=false)]
                    public float? AverageWorkTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CallsAttendedTransferIn")]
                    [Validation(Required=false)]
                    public long? CallsAttendedTransferIn { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CallsAttendedTransferOut")]
                    [Validation(Required=false)]
                    public long? CallsAttendedTransferOut { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CallsBlindTransferIn")]
                    [Validation(Required=false)]
                    public long? CallsBlindTransferIn { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CallsBlindTransferOut")]
                    [Validation(Required=false)]
                    public long? CallsBlindTransferOut { get; set; }

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
                    [NameInMap("CallsOffered")]
                    [Validation(Required=false)]
                    public long? CallsOffered { get; set; }

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
                    [NameInMap("HandleRate")]
                    [Validation(Required=false)]
                    public float? HandleRate { get; set; }

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

                    [NameInMap("ServiceLevel15")]
                    [Validation(Required=false)]
                    public float? ServiceLevel15 { get; set; }

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
                    public string TotalMessagesSentByCustomer { get; set; }

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

                [NameInMap("Internal")]
                [Validation(Required=false)]
                public ListHistoricalAgentReportResponseBodyDataListInternal Internal { get; set; }
                public class ListHistoricalAgentReportResponseBodyDataListInternal : TeaModel {
                    [NameInMap("AverageTalkTime")]
                    [Validation(Required=false)]
                    public float? AverageTalkTime { get; set; }

                    [NameInMap("CallsAnswered")]
                    [Validation(Required=false)]
                    public long? CallsAnswered { get; set; }

                    [NameInMap("CallsDialed")]
                    [Validation(Required=false)]
                    public long? CallsDialed { get; set; }

                    [NameInMap("CallsHandled")]
                    [Validation(Required=false)]
                    public long? CallsHandled { get; set; }

                    [NameInMap("CallsOffered")]
                    [Validation(Required=false)]
                    public long? CallsOffered { get; set; }

                    [NameInMap("CallsTalked")]
                    [Validation(Required=false)]
                    public long? CallsTalked { get; set; }

                    [NameInMap("MaxTalkTime")]
                    [Validation(Required=false)]
                    public long? MaxTalkTime { get; set; }

                    [NameInMap("TotalTalkTime")]
                    [Validation(Required=false)]
                    public long? TotalTalkTime { get; set; }

                }

                [NameInMap("Outbound")]
                [Validation(Required=false)]
                public ListHistoricalAgentReportResponseBodyDataListOutbound Outbound { get; set; }
                public class ListHistoricalAgentReportResponseBodyDataListOutbound : TeaModel {
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
                    [NameInMap("CallsAttendedTransferIn")]
                    [Validation(Required=false)]
                    public long? CallsAttendedTransferIn { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CallsAttendedTransferOut")]
                    [Validation(Required=false)]
                    public long? CallsAttendedTransferOut { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CallsBlindTransferIn")]
                    [Validation(Required=false)]
                    public long? CallsBlindTransferIn { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("CallsBlindTransferOut")]
                    [Validation(Required=false)]
                    public long? CallsBlindTransferOut { get; set; }

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
                    public long? CallsHold { get; set; }

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
                public ListHistoricalAgentReportResponseBodyDataListOverall Overall { get; set; }
                public class ListHistoricalAgentReportResponseBodyDataListOverall : TeaModel {
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

                    [NameInMap("BreakCodeDetailList")]
                    [Validation(Required=false)]
                    public List<ListHistoricalAgentReportResponseBodyDataListOverallBreakCodeDetailList> BreakCodeDetailList { get; set; }
                    public class ListHistoricalAgentReportResponseBodyDataListOverallBreakCodeDetailList : TeaModel {
                        [NameInMap("BreakCode")]
                        [Validation(Required=false)]
                        public string BreakCode { get; set; }

                        [NameInMap("Count")]
                        [Validation(Required=false)]
                        public long? Count { get; set; }

                        [NameInMap("Duration")]
                        [Validation(Required=false)]
                        public long? Duration { get; set; }

                    }

                    [NameInMap("FirstCheckInTime")]
                    [Validation(Required=false)]
                    public long? FirstCheckInTime { get; set; }

                    [NameInMap("LastCheckOutTime")]
                    [Validation(Required=false)]
                    public long? LastCheckOutTime { get; set; }

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

                    [NameInMap("TotalOffSiteLoggedInTime")]
                    [Validation(Required=false)]
                    public long? TotalOffSiteLoggedInTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>已弃用，请使用TotalOffSiteLoggedInTime代替此参数</para>
                    /// </summary>
                    [NameInMap("TotalOffSiteOnlineTime")]
                    [Validation(Required=false)]
                    public long? TotalOffSiteOnlineTime { get; set; }

                    [NameInMap("TotalOfficePhoneLoggedInTime")]
                    [Validation(Required=false)]
                    public long? TotalOfficePhoneLoggedInTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>已弃用，请使用TotalOfficePhoneLoggedInTime代替此参数</para>
                    /// </summary>
                    [NameInMap("TotalOfficePhoneOnlineTime")]
                    [Validation(Required=false)]
                    public long? TotalOfficePhoneOnlineTime { get; set; }

                    [NameInMap("TotalOnSiteLoggedInTime")]
                    [Validation(Required=false)]
                    public long? TotalOnSiteLoggedInTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>已弃用，请使用TotalOnSiteLoggedInTime代替此参数</para>
                    /// </summary>
                    [NameInMap("TotalOnSiteOnlineTime")]
                    [Validation(Required=false)]
                    public long? TotalOnSiteOnlineTime { get; set; }

                    [NameInMap("TotalOutboundScenarioLoggedInTime")]
                    [Validation(Required=false)]
                    public long? TotalOutboundScenarioLoggedInTime { get; set; }

                    [NameInMap("TotalOutboundScenarioReadyTime")]
                    [Validation(Required=false)]
                    public long? TotalOutboundScenarioReadyTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>已弃用，请使用TotalOutboundScenarioLoggedInTime代替此参数</para>
                    /// </summary>
                    [NameInMap("TotalOutboundScenarioTime")]
                    [Validation(Required=false)]
                    public long? TotalOutboundScenarioTime { get; set; }

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

                /// <summary>
                /// <b>Example:</b>
                /// <para>[&quot;skillgroup1@ccc-test&quot;,&quot;skillgroup2@ccc-test&quot;]</para>
                /// </summary>
                [NameInMap("SkillGroupIds")]
                [Validation(Required=false)]
                public string SkillGroupIds { get; set; }

                [NameInMap("SkillGroupNames")]
                [Validation(Required=false)]
                public string SkillGroupNames { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

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
        /// <para>EEEE671A-3E24-4A04-81E6-6C4F5B39DF75</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
