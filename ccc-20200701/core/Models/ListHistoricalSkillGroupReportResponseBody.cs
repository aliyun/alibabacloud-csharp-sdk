// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListHistoricalSkillGroupReportResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListHistoricalSkillGroupReportResponseBodyData Data { get; set; }
        public class ListHistoricalSkillGroupReportResponseBodyData : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListHistoricalSkillGroupReportResponseBodyDataList> List { get; set; }
            public class ListHistoricalSkillGroupReportResponseBodyDataList : TeaModel {
                public string SkillGroupName { get; set; }
                public string SkillGroupId { get; set; }
                public ListHistoricalSkillGroupReportResponseBodyDataListInbound Inbound { get; set; }
                public class ListHistoricalSkillGroupReportResponseBodyDataListInbound : TeaModel {
                    [NameInMap("AverageRingTime")]
                    [Validation(Required=false)]
                    public float? AverageRingTime { get; set; }

                    [NameInMap("CallsOverflow")]
                    [Validation(Required=false)]
                    public long? CallsOverflow { get; set; }

                    [NameInMap("CallsAbandonedInRing")]
                    [Validation(Required=false)]
                    public long? CallsAbandonedInRing { get; set; }

                    [NameInMap("CallsHandled")]
                    [Validation(Required=false)]
                    public long? CallsHandled { get; set; }

                    [NameInMap("TotalWorkTime")]
                    [Validation(Required=false)]
                    public long? TotalWorkTime { get; set; }

                    [NameInMap("TotalAbandonedInRingTime")]
                    [Validation(Required=false)]
                    public long? TotalAbandonedInRingTime { get; set; }

                    [NameInMap("MaxWorkTime")]
                    [Validation(Required=false)]
                    public long? MaxWorkTime { get; set; }

                    [NameInMap("CallsAttendedTransferOut")]
                    [Validation(Required=false)]
                    public long? CallsAttendedTransferOut { get; set; }

                    [NameInMap("AverageWaitTime")]
                    [Validation(Required=false)]
                    public float? AverageWaitTime { get; set; }

                    [NameInMap("TotalHoldTime")]
                    [Validation(Required=false)]
                    public long? TotalHoldTime { get; set; }

                    [NameInMap("MaxAbandonTime")]
                    [Validation(Required=false)]
                    public long? MaxAbandonTime { get; set; }

                    [NameInMap("AverageWorkTime")]
                    [Validation(Required=false)]
                    public float? AverageWorkTime { get; set; }

                    [NameInMap("CallsQueued")]
                    [Validation(Required=false)]
                    public long? CallsQueued { get; set; }

                    [NameInMap("CallsBlindTransferIn")]
                    [Validation(Required=false)]
                    public long? CallsBlindTransferIn { get; set; }

                    [NameInMap("SatisfactionIndex")]
                    [Validation(Required=false)]
                    public float? SatisfactionIndex { get; set; }

                    [NameInMap("AverageAbandonedInRingTime")]
                    [Validation(Required=false)]
                    public float? AverageAbandonedInRingTime { get; set; }

                    [NameInMap("AverageAbandonTime")]
                    [Validation(Required=false)]
                    public float? AverageAbandonTime { get; set; }

                    [NameInMap("CallsRinged")]
                    [Validation(Required=false)]
                    public long? CallsRinged { get; set; }

                    [NameInMap("CallsBlindTransferOut")]
                    [Validation(Required=false)]
                    public long? CallsBlindTransferOut { get; set; }

                    [NameInMap("CallsAttendedTransferIn")]
                    [Validation(Required=false)]
                    public long? CallsAttendedTransferIn { get; set; }

                    [NameInMap("CallsAbandoned")]
                    [Validation(Required=false)]
                    public long? CallsAbandoned { get; set; }

                    [NameInMap("MaxAbandonedInQueueTime")]
                    [Validation(Required=false)]
                    public long? MaxAbandonedInQueueTime { get; set; }

                    [NameInMap("TotalWaitTime")]
                    [Validation(Required=false)]
                    public long? TotalWaitTime { get; set; }

                    [NameInMap("TotalRingTime")]
                    [Validation(Required=false)]
                    public long? TotalRingTime { get; set; }

                    [NameInMap("MaxTalkTime")]
                    [Validation(Required=false)]
                    public long? MaxTalkTime { get; set; }

                    [NameInMap("MaxRingTime")]
                    [Validation(Required=false)]
                    public long? MaxRingTime { get; set; }

                    [NameInMap("AbandonRate")]
                    [Validation(Required=false)]
                    public float? AbandonRate { get; set; }

                    [NameInMap("TotalTalkTime")]
                    [Validation(Required=false)]
                    public long? TotalTalkTime { get; set; }

                    [NameInMap("TotalAbandonTime")]
                    [Validation(Required=false)]
                    public long? TotalAbandonTime { get; set; }

                    [NameInMap("CallsOffered")]
                    [Validation(Required=false)]
                    public long? CallsOffered { get; set; }

                    [NameInMap("MaxAbandonedInRingTime")]
                    [Validation(Required=false)]
                    public long? MaxAbandonedInRingTime { get; set; }

                    [NameInMap("MaxWaitTime")]
                    [Validation(Required=false)]
                    public long? MaxWaitTime { get; set; }

                    [NameInMap("AverageAbandonedInQueueTime")]
                    [Validation(Required=false)]
                    public float? AverageAbandonedInQueueTime { get; set; }

                    [NameInMap("ServiceLevel20")]
                    [Validation(Required=false)]
                    public float? ServiceLevel20 { get; set; }

                    [NameInMap("MaxHoldTime")]
                    [Validation(Required=false)]
                    public long? MaxHoldTime { get; set; }

                    [NameInMap("SatisfactionRate")]
                    [Validation(Required=false)]
                    public float? SatisfactionRate { get; set; }

                    [NameInMap("AverageTalkTime")]
                    [Validation(Required=false)]
                    public float? AverageTalkTime { get; set; }

                    [NameInMap("CallsHold")]
                    [Validation(Required=false)]
                    public long? CallsHold { get; set; }

                    [NameInMap("SatisfactionSurveysOffered")]
                    [Validation(Required=false)]
                    public long? SatisfactionSurveysOffered { get; set; }

                    [NameInMap("HandleRate")]
                    [Validation(Required=false)]
                    public float? HandleRate { get; set; }

                    [NameInMap("CallsTimeout")]
                    [Validation(Required=false)]
                    public long? CallsTimeout { get; set; }

                    [NameInMap("SatisfactionSurveysResponded")]
                    [Validation(Required=false)]
                    public long? SatisfactionSurveysResponded { get; set; }

                    [NameInMap("AverageHoldTime")]
                    [Validation(Required=false)]
                    public float? AverageHoldTime { get; set; }

                    [NameInMap("TotalAbandonedInQueueTime")]
                    [Validation(Required=false)]
                    public long? TotalAbandonedInQueueTime { get; set; }

                    [NameInMap("CallsAbandonedInQueue")]
                    [Validation(Required=false)]
                    public long? CallsAbandonedInQueue { get; set; }

                }
                public ListHistoricalSkillGroupReportResponseBodyDataListOutbound Outbound { get; set; }
                public class ListHistoricalSkillGroupReportResponseBodyDataListOutbound : TeaModel {
                    [NameInMap("AverageRingTime")]
                    [Validation(Required=false)]
                    public float? AverageRingTime { get; set; }

                    [NameInMap("CallsDialed")]
                    [Validation(Required=false)]
                    public long? CallsDialed { get; set; }

                    [NameInMap("CallsAnswered")]
                    [Validation(Required=false)]
                    public long? CallsAnswered { get; set; }

                    [NameInMap("TotalWorkTime")]
                    [Validation(Required=false)]
                    public long? TotalWorkTime { get; set; }

                    [NameInMap("CallsAttendedTransferOut")]
                    [Validation(Required=false)]
                    public long? CallsAttendedTransferOut { get; set; }

                    [NameInMap("MaxWorkTime")]
                    [Validation(Required=false)]
                    public long? MaxWorkTime { get; set; }

                    [NameInMap("TotalDialingTime")]
                    [Validation(Required=false)]
                    public long? TotalDialingTime { get; set; }

                    [NameInMap("TotalHoldTime")]
                    [Validation(Required=false)]
                    public long? TotalHoldTime { get; set; }

                    [NameInMap("AverageWorkTime")]
                    [Validation(Required=false)]
                    public float? AverageWorkTime { get; set; }

                    [NameInMap("CallsBlindTransferIn")]
                    [Validation(Required=false)]
                    public long? CallsBlindTransferIn { get; set; }

                    [NameInMap("SatisfactionIndex")]
                    [Validation(Required=false)]
                    public float? SatisfactionIndex { get; set; }

                    [NameInMap("CallsRinged")]
                    [Validation(Required=false)]
                    public long? CallsRinged { get; set; }

                    [NameInMap("CallsAttendedTransferIn")]
                    [Validation(Required=false)]
                    public long? CallsAttendedTransferIn { get; set; }

                    [NameInMap("CallsBlindTransferOut")]
                    [Validation(Required=false)]
                    public long? CallsBlindTransferOut { get; set; }

                    [NameInMap("TotalRingTime")]
                    [Validation(Required=false)]
                    public long? TotalRingTime { get; set; }

                    [NameInMap("MaxTalkTime")]
                    [Validation(Required=false)]
                    public long? MaxTalkTime { get; set; }

                    [NameInMap("MaxRingTime")]
                    [Validation(Required=false)]
                    public long? MaxRingTime { get; set; }

                    [NameInMap("TotalTalkTime")]
                    [Validation(Required=false)]
                    public long? TotalTalkTime { get; set; }

                    [NameInMap("MaxDialingTime")]
                    [Validation(Required=false)]
                    public long? MaxDialingTime { get; set; }

                    [NameInMap("AnswerRate")]
                    [Validation(Required=false)]
                    public float? AnswerRate { get; set; }

                    [NameInMap("MaxHoldTime")]
                    [Validation(Required=false)]
                    public long? MaxHoldTime { get; set; }

                    [NameInMap("AverageTalkTime")]
                    [Validation(Required=false)]
                    public float? AverageTalkTime { get; set; }

                    [NameInMap("SatisfactionRate")]
                    [Validation(Required=false)]
                    public float? SatisfactionRate { get; set; }

                    [NameInMap("CallsHold")]
                    [Validation(Required=false)]
                    public long? CallsHold { get; set; }

                    [NameInMap("SatisfactionSurveysOffered")]
                    [Validation(Required=false)]
                    public long? SatisfactionSurveysOffered { get; set; }

                    [NameInMap("SatisfactionSurveysResponded")]
                    [Validation(Required=false)]
                    public long? SatisfactionSurveysResponded { get; set; }

                    [NameInMap("AverageHoldTime")]
                    [Validation(Required=false)]
                    public float? AverageHoldTime { get; set; }

                    [NameInMap("AverageDialingTime")]
                    [Validation(Required=false)]
                    public float? AverageDialingTime { get; set; }

                }
                public ListHistoricalSkillGroupReportResponseBodyDataListOverall Overall { get; set; }
                public class ListHistoricalSkillGroupReportResponseBodyDataListOverall : TeaModel {
                    [NameInMap("TotalTalkTime")]
                    [Validation(Required=false)]
                    public long? TotalTalkTime { get; set; }

                    [NameInMap("TotalLoggedInTime")]
                    [Validation(Required=false)]
                    public long? TotalLoggedInTime { get; set; }

                    [NameInMap("OccupancyRate")]
                    [Validation(Required=false)]
                    public float? OccupancyRate { get; set; }

                    [NameInMap("TotalWorkTime")]
                    [Validation(Required=false)]
                    public long? TotalWorkTime { get; set; }

                    [NameInMap("MaxHoldTime")]
                    [Validation(Required=false)]
                    public long? MaxHoldTime { get; set; }

                    [NameInMap("MaxWorkTime")]
                    [Validation(Required=false)]
                    public long? MaxWorkTime { get; set; }

                    [NameInMap("AverageBreakTime")]
                    [Validation(Required=false)]
                    public float? AverageBreakTime { get; set; }

                    [NameInMap("TotalHoldTime")]
                    [Validation(Required=false)]
                    public long? TotalHoldTime { get; set; }

                    [NameInMap("SatisfactionRate")]
                    [Validation(Required=false)]
                    public float? SatisfactionRate { get; set; }

                    [NameInMap("MaxBreakTime")]
                    [Validation(Required=false)]
                    public long? MaxBreakTime { get; set; }

                    [NameInMap("AverageWorkTime")]
                    [Validation(Required=false)]
                    public float? AverageWorkTime { get; set; }

                    [NameInMap("AverageTalkTime")]
                    [Validation(Required=false)]
                    public float? AverageTalkTime { get; set; }

                    [NameInMap("SatisfactionIndex")]
                    [Validation(Required=false)]
                    public float? SatisfactionIndex { get; set; }

                    [NameInMap("SatisfactionSurveysOffered")]
                    [Validation(Required=false)]
                    public long? SatisfactionSurveysOffered { get; set; }

                    [NameInMap("SatisfactionSurveysResponded")]
                    [Validation(Required=false)]
                    public long? SatisfactionSurveysResponded { get; set; }

                    [NameInMap("MaxReadyTime")]
                    [Validation(Required=false)]
                    public long? MaxReadyTime { get; set; }

                    [NameInMap("AverageReadyTime")]
                    [Validation(Required=false)]
                    public float? AverageReadyTime { get; set; }

                    [NameInMap("AverageHoldTime")]
                    [Validation(Required=false)]
                    public float? AverageHoldTime { get; set; }

                    [NameInMap("TotalReadyTime")]
                    [Validation(Required=false)]
                    public long? TotalReadyTime { get; set; }

                    [NameInMap("TotalBreakTime")]
                    [Validation(Required=false)]
                    public long? TotalBreakTime { get; set; }

                    [NameInMap("MaxTalkTime")]
                    [Validation(Required=false)]
                    public long? MaxTalkTime { get; set; }

                    [NameInMap("TotalCalls")]
                    [Validation(Required=false)]
                    public long? TotalCalls { get; set; }

                }
            }
        };

    }

}
