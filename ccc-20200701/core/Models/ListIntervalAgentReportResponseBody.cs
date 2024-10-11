// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListIntervalAgentReportResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListIntervalAgentReportResponseBodyData> Data { get; set; }
        public class ListIntervalAgentReportResponseBodyData : TeaModel {
            [NameInMap("Back2Back")]
            [Validation(Required=false)]
            public ListIntervalAgentReportResponseBodyDataBack2Back Back2Back { get; set; }
            public class ListIntervalAgentReportResponseBodyDataBack2Back : TeaModel {
                [NameInMap("AgentHandleRate")]
                [Validation(Required=false)]
                public float? AgentHandleRate { get; set; }

                [NameInMap("AnswerRate")]
                [Validation(Required=false)]
                public float? AnswerRate { get; set; }

                [NameInMap("AverageCustomerRingTime")]
                [Validation(Required=false)]
                public float? AverageCustomerRingTime { get; set; }

                [NameInMap("AverageRingTime")]
                [Validation(Required=false)]
                public float? AverageRingTime { get; set; }

                [NameInMap("AverageTalkTime")]
                [Validation(Required=false)]
                public float? AverageTalkTime { get; set; }

                [NameInMap("CallsAgentHandled")]
                [Validation(Required=false)]
                public long? CallsAgentHandled { get; set; }

                [NameInMap("CallsAnswered")]
                [Validation(Required=false)]
                public long? CallsAnswered { get; set; }

                [NameInMap("CallsCustomerAnswered")]
                [Validation(Required=false)]
                public long? CallsCustomerAnswered { get; set; }

                [NameInMap("CallsDialed")]
                [Validation(Required=false)]
                public long? CallsDialed { get; set; }

                [NameInMap("CustomerAnswerRate")]
                [Validation(Required=false)]
                public float? CustomerAnswerRate { get; set; }

                [NameInMap("MaxCustomerRingTime")]
                [Validation(Required=false)]
                public long? MaxCustomerRingTime { get; set; }

                [NameInMap("MaxRingTime")]
                [Validation(Required=false)]
                public long? MaxRingTime { get; set; }

                [NameInMap("MaxTalkTime")]
                [Validation(Required=false)]
                public long? MaxTalkTime { get; set; }

                [NameInMap("TotalCustomerRingTime")]
                [Validation(Required=false)]
                public long? TotalCustomerRingTime { get; set; }

                [NameInMap("TotalRingTime")]
                [Validation(Required=false)]
                public long? TotalRingTime { get; set; }

                [NameInMap("TotalTalkTime")]
                [Validation(Required=false)]
                public long? TotalTalkTime { get; set; }

            }

            [NameInMap("Inbound")]
            [Validation(Required=false)]
            public ListIntervalAgentReportResponseBodyDataInbound Inbound { get; set; }
            public class ListIntervalAgentReportResponseBodyDataInbound : TeaModel {
                [NameInMap("AccessChannelTypeDetails")]
                [Validation(Required=false)]
                public List<ListIntervalAgentReportResponseBodyDataInboundAccessChannelTypeDetails> AccessChannelTypeDetails { get; set; }
                public class ListIntervalAgentReportResponseBodyDataInboundAccessChannelTypeDetails : TeaModel {
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
                [NameInMap("TotalWorkTime")]
                [Validation(Required=false)]
                public long? TotalWorkTime { get; set; }

            }

            [NameInMap("Internal")]
            [Validation(Required=false)]
            public ListIntervalAgentReportResponseBodyDataInternal Internal { get; set; }
            public class ListIntervalAgentReportResponseBodyDataInternal : TeaModel {
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

            }

            [NameInMap("Outbound")]
            [Validation(Required=false)]
            public ListIntervalAgentReportResponseBodyDataOutbound Outbound { get; set; }
            public class ListIntervalAgentReportResponseBodyDataOutbound : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AnswerRate")]
                [Validation(Required=false)]
                public float? AnswerRate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>30</para>
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
                /// <para>1</para>
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
                /// <para>5</para>
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
                /// <para>60</para>
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
                /// <para>2</para>
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
                /// <para>148</para>
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
                /// <para>4</para>
                /// </summary>
                [NameInMap("TotalWorkTime")]
                [Validation(Required=false)]
                public long? TotalWorkTime { get; set; }

            }

            [NameInMap("Overall")]
            [Validation(Required=false)]
            public ListIntervalAgentReportResponseBodyDataOverall Overall { get; set; }
            public class ListIntervalAgentReportResponseBodyDataOverall : TeaModel {
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
                /// <para>1</para>
                /// </summary>
                [NameInMap("AverageWorkTime")]
                [Validation(Required=false)]
                public float? AverageWorkTime { get; set; }

                [NameInMap("BreakCodeDetailList")]
                [Validation(Required=false)]
                public List<ListIntervalAgentReportResponseBodyDataOverallBreakCodeDetailList> BreakCodeDetailList { get; set; }
                public class ListIntervalAgentReportResponseBodyDataOverallBreakCodeDetailList : TeaModel {
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
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
                [NameInMap("LastCheckoutTime")]
                [Validation(Required=false)]
                public long? LastCheckoutTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
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
                /// <para>435</para>
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
                /// <para>2</para>
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
                /// <para>1</para>
                /// </summary>
                [NameInMap("TotalBreakTime")]
                [Validation(Required=false)]
                public long? TotalBreakTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5</para>
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
                /// <para>914</para>
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
                /// <para>763</para>
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
                /// <para>4</para>
                /// </summary>
                [NameInMap("TotalWorkTime")]
                [Validation(Required=false)]
                public long? TotalWorkTime { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1620291600000</para>
            /// </summary>
            [NameInMap("StatsTime")]
            [Validation(Required=false)]
            public long? StatsTime { get; set; }

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
