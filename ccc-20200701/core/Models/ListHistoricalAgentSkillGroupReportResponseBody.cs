// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListHistoricalAgentSkillGroupReportResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListHistoricalAgentSkillGroupReportResponseBodyData Data { get; set; }
        public class ListHistoricalAgentSkillGroupReportResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListHistoricalAgentSkillGroupReportResponseBodyDataList> List { get; set; }
            public class ListHistoricalAgentSkillGroupReportResponseBodyDataList : TeaModel {
                [NameInMap("AgentId")]
                [Validation(Required=false)]
                public string AgentId { get; set; }

                [NameInMap("AgentName")]
                [Validation(Required=false)]
                public string AgentName { get; set; }

                [NameInMap("Back2Back")]
                [Validation(Required=false)]
                public ListHistoricalAgentSkillGroupReportResponseBodyDataListBack2Back Back2Back { get; set; }
                public class ListHistoricalAgentSkillGroupReportResponseBodyDataListBack2Back : TeaModel {
                    [NameInMap("AgentAnswerRate")]
                    [Validation(Required=false)]
                    public float? AgentAnswerRate { get; set; }

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
                    public long? AverageTalkTime { get; set; }

                    [NameInMap("CallsAnswered")]
                    [Validation(Required=false)]
                    public long? CallsAnswered { get; set; }

                    [NameInMap("CallsCustomerHandled")]
                    [Validation(Required=false)]
                    public long? CallsCustomerHandled { get; set; }

                    [NameInMap("CallsDialed")]
                    [Validation(Required=false)]
                    public long? CallsDialed { get; set; }

                    [NameInMap("CustomerHandleRate")]
                    [Validation(Required=false)]
                    public float? CustomerHandleRate { get; set; }

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

                [NameInMap("DisplayId")]
                [Validation(Required=false)]
                public string DisplayId { get; set; }

                [NameInMap("Inbound")]
                [Validation(Required=false)]
                public ListHistoricalAgentSkillGroupReportResponseBodyDataListInbound Inbound { get; set; }
                public class ListHistoricalAgentSkillGroupReportResponseBodyDataListInbound : TeaModel {
                    [NameInMap("AverageHoldTime")]
                    [Validation(Required=false)]
                    public float? AverageHoldTime { get; set; }

                    [NameInMap("AverageRingTime")]
                    [Validation(Required=false)]
                    public float? AverageRingTime { get; set; }

                    [NameInMap("AverageTalkTime")]
                    [Validation(Required=false)]
                    public float? AverageTalkTime { get; set; }

                    [NameInMap("AverageWorkTime")]
                    [Validation(Required=false)]
                    public float? AverageWorkTime { get; set; }

                    [NameInMap("CallsAttendedTransferIn")]
                    [Validation(Required=false)]
                    public long? CallsAttendedTransferIn { get; set; }

                    [NameInMap("CallsAttendedTransferOut")]
                    [Validation(Required=false)]
                    public long? CallsAttendedTransferOut { get; set; }

                    [NameInMap("CallsBlindTransferIn")]
                    [Validation(Required=false)]
                    public long? CallsBlindTransferIn { get; set; }

                    [NameInMap("CallsBlindTransferOut")]
                    [Validation(Required=false)]
                    public long? CallsBlindTransferOut { get; set; }

                    [NameInMap("CallsHandled")]
                    [Validation(Required=false)]
                    public long? CallsHandled { get; set; }

                    [NameInMap("CallsHold")]
                    [Validation(Required=false)]
                    public long? CallsHold { get; set; }

                    [NameInMap("CallsOffered")]
                    [Validation(Required=false)]
                    public long? CallsOffered { get; set; }

                    [NameInMap("CallsRinged")]
                    [Validation(Required=false)]
                    public long? CallsRinged { get; set; }

                    [NameInMap("HandleRate")]
                    [Validation(Required=false)]
                    public float? HandleRate { get; set; }

                    [NameInMap("MaxHoldTime")]
                    [Validation(Required=false)]
                    public long? MaxHoldTime { get; set; }

                    [NameInMap("MaxRingTime")]
                    [Validation(Required=false)]
                    public long? MaxRingTime { get; set; }

                    [NameInMap("MaxTalkTime")]
                    [Validation(Required=false)]
                    public long? MaxTalkTime { get; set; }

                    [NameInMap("MaxWorkTime")]
                    [Validation(Required=false)]
                    public long? MaxWorkTime { get; set; }

                    [NameInMap("SatisfactionIndex")]
                    [Validation(Required=false)]
                    public float? SatisfactionIndex { get; set; }

                    [NameInMap("SatisfactionRate")]
                    [Validation(Required=false)]
                    public float? SatisfactionRate { get; set; }

                    [NameInMap("SatisfactionSurveysOffered")]
                    [Validation(Required=false)]
                    public long? SatisfactionSurveysOffered { get; set; }

                    [NameInMap("SatisfactionSurveysResponded")]
                    [Validation(Required=false)]
                    public long? SatisfactionSurveysResponded { get; set; }

                    [NameInMap("TotalHoldTime")]
                    [Validation(Required=false)]
                    public long? TotalHoldTime { get; set; }

                    [NameInMap("TotalRingTime")]
                    [Validation(Required=false)]
                    public long? TotalRingTime { get; set; }

                    [NameInMap("TotalTalkTime")]
                    [Validation(Required=false)]
                    public long? TotalTalkTime { get; set; }

                    [NameInMap("TotalWorkTime")]
                    [Validation(Required=false)]
                    public long? TotalWorkTime { get; set; }

                }

                [NameInMap("Internal")]
                [Validation(Required=false)]
                public ListHistoricalAgentSkillGroupReportResponseBodyDataListInternal Internal { get; set; }
                public class ListHistoricalAgentSkillGroupReportResponseBodyDataListInternal : TeaModel {
                    [NameInMap("AverageTalkTime")]
                    [Validation(Required=false)]
                    public long? AverageTalkTime { get; set; }

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

                    [NameInMap("CallsTalk")]
                    [Validation(Required=false)]
                    public long? CallsTalk { get; set; }

                    [NameInMap("MaxTalkTime")]
                    [Validation(Required=false)]
                    public long? MaxTalkTime { get; set; }

                    [NameInMap("TotalTalkTime")]
                    [Validation(Required=false)]
                    public long? TotalTalkTime { get; set; }

                }

                [NameInMap("Outbound")]
                [Validation(Required=false)]
                public ListHistoricalAgentSkillGroupReportResponseBodyDataListOutbound Outbound { get; set; }
                public class ListHistoricalAgentSkillGroupReportResponseBodyDataListOutbound : TeaModel {
                    [NameInMap("AnswerRate")]
                    [Validation(Required=false)]
                    public float? AnswerRate { get; set; }

                    [NameInMap("AverageDialingTime")]
                    [Validation(Required=false)]
                    public float? AverageDialingTime { get; set; }

                    [NameInMap("AverageHoldTime")]
                    [Validation(Required=false)]
                    public float? AverageHoldTime { get; set; }

                    [NameInMap("AverageRingTime")]
                    [Validation(Required=false)]
                    public float? AverageRingTime { get; set; }

                    [NameInMap("AverageTalkTime")]
                    [Validation(Required=false)]
                    public float? AverageTalkTime { get; set; }

                    [NameInMap("AverageWorkTime")]
                    [Validation(Required=false)]
                    public float? AverageWorkTime { get; set; }

                    [NameInMap("CallsAnswered")]
                    [Validation(Required=false)]
                    public long? CallsAnswered { get; set; }

                    [NameInMap("CallsAttendedTransferIn")]
                    [Validation(Required=false)]
                    public long? CallsAttendedTransferIn { get; set; }

                    [NameInMap("CallsAttendedTransferOut")]
                    [Validation(Required=false)]
                    public long? CallsAttendedTransferOut { get; set; }

                    [NameInMap("CallsBlindTransferIn")]
                    [Validation(Required=false)]
                    public long? CallsBlindTransferIn { get; set; }

                    [NameInMap("CallsBlindTransferOut")]
                    [Validation(Required=false)]
                    public long? CallsBlindTransferOut { get; set; }

                    [NameInMap("CallsDialed")]
                    [Validation(Required=false)]
                    public long? CallsDialed { get; set; }

                    [NameInMap("CallsHold")]
                    [Validation(Required=false)]
                    public long? CallsHold { get; set; }

                    [NameInMap("CallsRinged")]
                    [Validation(Required=false)]
                    public long? CallsRinged { get; set; }

                    [NameInMap("MaxDialingTime")]
                    [Validation(Required=false)]
                    public long? MaxDialingTime { get; set; }

                    [NameInMap("MaxHoldTime")]
                    [Validation(Required=false)]
                    public long? MaxHoldTime { get; set; }

                    [NameInMap("MaxRingTime")]
                    [Validation(Required=false)]
                    public long? MaxRingTime { get; set; }

                    [NameInMap("MaxTalkTime")]
                    [Validation(Required=false)]
                    public long? MaxTalkTime { get; set; }

                    [NameInMap("MaxWorkTime")]
                    [Validation(Required=false)]
                    public long? MaxWorkTime { get; set; }

                    [NameInMap("SatisfactionIndex")]
                    [Validation(Required=false)]
                    public float? SatisfactionIndex { get; set; }

                    [NameInMap("SatisfactionRate")]
                    [Validation(Required=false)]
                    public float? SatisfactionRate { get; set; }

                    [NameInMap("SatisfactionSurveysOffered")]
                    [Validation(Required=false)]
                    public long? SatisfactionSurveysOffered { get; set; }

                    [NameInMap("SatisfactionSurveysResponded")]
                    [Validation(Required=false)]
                    public long? SatisfactionSurveysResponded { get; set; }

                    [NameInMap("TotalDialingTime")]
                    [Validation(Required=false)]
                    public long? TotalDialingTime { get; set; }

                    [NameInMap("TotalHoldTime")]
                    [Validation(Required=false)]
                    public long? TotalHoldTime { get; set; }

                    [NameInMap("TotalRingTime")]
                    [Validation(Required=false)]
                    public long? TotalRingTime { get; set; }

                    [NameInMap("TotalTalkTime")]
                    [Validation(Required=false)]
                    public long? TotalTalkTime { get; set; }

                    [NameInMap("TotalWorkTime")]
                    [Validation(Required=false)]
                    public long? TotalWorkTime { get; set; }

                }

                [NameInMap("Overall")]
                [Validation(Required=false)]
                public ListHistoricalAgentSkillGroupReportResponseBodyDataListOverall Overall { get; set; }
                public class ListHistoricalAgentSkillGroupReportResponseBodyDataListOverall : TeaModel {
                    [NameInMap("AverageBreakTime")]
                    [Validation(Required=false)]
                    public float? AverageBreakTime { get; set; }

                    [NameInMap("AverageHoldTime")]
                    [Validation(Required=false)]
                    public float? AverageHoldTime { get; set; }

                    [NameInMap("AverageReadyTime")]
                    [Validation(Required=false)]
                    public float? AverageReadyTime { get; set; }

                    [NameInMap("AverageTalkTime")]
                    [Validation(Required=false)]
                    public float? AverageTalkTime { get; set; }

                    [NameInMap("AverageWorkTime")]
                    [Validation(Required=false)]
                    public float? AverageWorkTime { get; set; }

                    [NameInMap("BreakCodeDetailList")]
                    [Validation(Required=false)]
                    public List<ListHistoricalAgentSkillGroupReportResponseBodyDataListOverallBreakCodeDetailList> BreakCodeDetailList { get; set; }
                    public class ListHistoricalAgentSkillGroupReportResponseBodyDataListOverallBreakCodeDetailList : TeaModel {
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

                    [NameInMap("MaxBreakTime")]
                    [Validation(Required=false)]
                    public long? MaxBreakTime { get; set; }

                    [NameInMap("MaxHoldTime")]
                    [Validation(Required=false)]
                    public long? MaxHoldTime { get; set; }

                    [NameInMap("MaxReadyTime")]
                    [Validation(Required=false)]
                    public long? MaxReadyTime { get; set; }

                    [NameInMap("MaxTalkTime")]
                    [Validation(Required=false)]
                    public long? MaxTalkTime { get; set; }

                    [NameInMap("MaxWorkTime")]
                    [Validation(Required=false)]
                    public long? MaxWorkTime { get; set; }

                    [NameInMap("OccupancyRate")]
                    [Validation(Required=false)]
                    public float? OccupancyRate { get; set; }

                    [NameInMap("SatisfactionIndex")]
                    [Validation(Required=false)]
                    public float? SatisfactionIndex { get; set; }

                    [NameInMap("SatisfactionRate")]
                    [Validation(Required=false)]
                    public float? SatisfactionRate { get; set; }

                    [NameInMap("SatisfactionSurveysOffered")]
                    [Validation(Required=false)]
                    public long? SatisfactionSurveysOffered { get; set; }

                    [NameInMap("SatisfactionSurveysResponded")]
                    [Validation(Required=false)]
                    public long? SatisfactionSurveysResponded { get; set; }

                    [NameInMap("TotalBreakTime")]
                    [Validation(Required=false)]
                    public long? TotalBreakTime { get; set; }

                    [NameInMap("TotalCalls")]
                    [Validation(Required=false)]
                    public long? TotalCalls { get; set; }

                    [NameInMap("TotalHoldTime")]
                    [Validation(Required=false)]
                    public long? TotalHoldTime { get; set; }

                    [NameInMap("TotalLoggedInTime")]
                    [Validation(Required=false)]
                    public long? TotalLoggedInTime { get; set; }

                    [NameInMap("TotalOutboundScenarioReadyTime")]
                    [Validation(Required=false)]
                    public long? TotalOutboundScenarioReadyTime { get; set; }

                    [NameInMap("TotalOutboundScenarioTime")]
                    [Validation(Required=false)]
                    public long? TotalOutboundScenarioTime { get; set; }

                    [NameInMap("TotalReadyTime")]
                    [Validation(Required=false)]
                    public long? TotalReadyTime { get; set; }

                    [NameInMap("TotalTalkTime")]
                    [Validation(Required=false)]
                    public long? TotalTalkTime { get; set; }

                    [NameInMap("TotalWorkTime")]
                    [Validation(Required=false)]
                    public long? TotalWorkTime { get; set; }

                }

                [NameInMap("SkillGroupId")]
                [Validation(Required=false)]
                public string SkillGroupId { get; set; }

                [NameInMap("SkillGroupName")]
                [Validation(Required=false)]
                public string SkillGroupName { get; set; }

            }

            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
