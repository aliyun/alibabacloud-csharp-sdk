// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListIntervalInstanceReportResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListIntervalInstanceReportResponseBodyData> Data { get; set; }
        public class ListIntervalInstanceReportResponseBodyData : TeaModel {
            [NameInMap("Inbound")]
            [Validation(Required=false)]
            public ListIntervalInstanceReportResponseBodyDataInbound Inbound { get; set; }
            public class ListIntervalInstanceReportResponseBodyDataInbound : TeaModel {
                [NameInMap("AbandonedRate")]
                [Validation(Required=false)]
                public float? AbandonedRate { get; set; }
                [NameInMap("AverageAbandonTime")]
                [Validation(Required=false)]
                public float? AverageAbandonTime { get; set; }
                [NameInMap("AverageAbandonedInIVRTime")]
                [Validation(Required=false)]
                public float? AverageAbandonedInIVRTime { get; set; }
                [NameInMap("AverageAbandonedInQueueTime")]
                [Validation(Required=false)]
                public float? AverageAbandonedInQueueTime { get; set; }
                [NameInMap("AverageAbandonedInRingTime")]
                [Validation(Required=false)]
                public float? AverageAbandonedInRingTime { get; set; }
                [NameInMap("AverageHoldTime")]
                [Validation(Required=false)]
                public float? AverageHoldTime { get; set; }
                [NameInMap("AverageRingTime")]
                [Validation(Required=false)]
                public float? AverageRingTime { get; set; }
                [NameInMap("AverageTalkTime")]
                [Validation(Required=false)]
                public float? AverageTalkTime { get; set; }
                [NameInMap("AverageWaitTime")]
                [Validation(Required=false)]
                public float? AverageWaitTime { get; set; }
                [NameInMap("AverageWorkTime")]
                [Validation(Required=false)]
                public float? AverageWorkTime { get; set; }
                [NameInMap("CallsAbandoned")]
                [Validation(Required=false)]
                public long? CallsAbandoned { get; set; }
                [NameInMap("CallsAbandonedInIVR")]
                [Validation(Required=false)]
                public long? CallsAbandonedInIVR { get; set; }
                [NameInMap("CallsAbandonedInQueue")]
                [Validation(Required=false)]
                public long? CallsAbandonedInQueue { get; set; }
                [NameInMap("CallsAbandonedInRing")]
                [Validation(Required=false)]
                public long? CallsAbandonedInRing { get; set; }
                [NameInMap("CallsAbandonedInVoiceNavigator")]
                [Validation(Required=false)]
                public long? CallsAbandonedInVoiceNavigator { get; set; }
                [NameInMap("CallsAttendedTransferred")]
                [Validation(Required=false)]
                public long? CallsAttendedTransferred { get; set; }
                [NameInMap("CallsBlindTransferred")]
                [Validation(Required=false)]
                public long? CallsBlindTransferred { get; set; }
                [NameInMap("CallsForwardToOutsideNumber")]
                [Validation(Required=false)]
                public long? CallsForwardToOutsideNumber { get; set; }
                [NameInMap("CallsHandled")]
                [Validation(Required=false)]
                public long? CallsHandled { get; set; }
                [NameInMap("CallsHold")]
                [Validation(Required=false)]
                public long? CallsHold { get; set; }
                [NameInMap("CallsIVRException")]
                [Validation(Required=false)]
                public long? CallsIVRException { get; set; }
                [NameInMap("CallsOffered")]
                [Validation(Required=false)]
                public long? CallsOffered { get; set; }
                [NameInMap("CallsQueued")]
                [Validation(Required=false)]
                public long? CallsQueued { get; set; }
                [NameInMap("CallsQueuingFailed")]
                [Validation(Required=false)]
                public long? CallsQueuingFailed { get; set; }
                [NameInMap("CallsQueuingOverflow")]
                [Validation(Required=false)]
                public long? CallsQueuingOverflow { get; set; }
                [NameInMap("CallsQueuingTimeout")]
                [Validation(Required=false)]
                public long? CallsQueuingTimeout { get; set; }
                [NameInMap("CallsRinged")]
                [Validation(Required=false)]
                public long? CallsRinged { get; set; }
                [NameInMap("CallsVoicemail")]
                [Validation(Required=false)]
                public long? CallsVoicemail { get; set; }
                [NameInMap("HandleRate")]
                [Validation(Required=false)]
                public float? HandleRate { get; set; }
                [NameInMap("MaxAbandonTime")]
                [Validation(Required=false)]
                public long? MaxAbandonTime { get; set; }
                [NameInMap("MaxAbandonedInIVRTime")]
                [Validation(Required=false)]
                public long? MaxAbandonedInIVRTime { get; set; }
                [NameInMap("MaxAbandonedInQueueTime")]
                [Validation(Required=false)]
                public long? MaxAbandonedInQueueTime { get; set; }
                [NameInMap("MaxAbandonedInRingTime")]
                [Validation(Required=false)]
                public long? MaxAbandonedInRingTime { get; set; }
                [NameInMap("MaxHoldTime")]
                [Validation(Required=false)]
                public long? MaxHoldTime { get; set; }
                [NameInMap("MaxRingTime")]
                [Validation(Required=false)]
                public long? MaxRingTime { get; set; }
                [NameInMap("MaxTalkTime")]
                [Validation(Required=false)]
                public long? MaxTalkTime { get; set; }
                [NameInMap("MaxWaitTime")]
                [Validation(Required=false)]
                public long? MaxWaitTime { get; set; }
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
                [NameInMap("ServiceLevel20")]
                [Validation(Required=false)]
                public float? ServiceLevel20 { get; set; }
                [NameInMap("TotalAbandonTime")]
                [Validation(Required=false)]
                public long? TotalAbandonTime { get; set; }
                [NameInMap("TotalAbandonedInIVRTime")]
                [Validation(Required=false)]
                public long? TotalAbandonedInIVRTime { get; set; }
                [NameInMap("TotalAbandonedInQueueTime")]
                [Validation(Required=false)]
                public long? TotalAbandonedInQueueTime { get; set; }
                [NameInMap("TotalAbandonedInRingTime")]
                [Validation(Required=false)]
                public long? TotalAbandonedInRingTime { get; set; }
                [NameInMap("TotalHoldTime")]
                [Validation(Required=false)]
                public long? TotalHoldTime { get; set; }
                [NameInMap("TotalRingTime")]
                [Validation(Required=false)]
                public long? TotalRingTime { get; set; }
                [NameInMap("TotalTalkTime")]
                [Validation(Required=false)]
                public long? TotalTalkTime { get; set; }
                [NameInMap("TotalWaitTime")]
                [Validation(Required=false)]
                public long? TotalWaitTime { get; set; }
                [NameInMap("TotalWorkTime")]
                [Validation(Required=false)]
                public long? TotalWorkTime { get; set; }
            };

            [NameInMap("Outbound")]
            [Validation(Required=false)]
            public ListIntervalInstanceReportResponseBodyDataOutbound Outbound { get; set; }
            public class ListIntervalInstanceReportResponseBodyDataOutbound : TeaModel {
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
                [NameInMap("CallsAttendedTransferred")]
                [Validation(Required=false)]
                public long? CallsAttendedTransferred { get; set; }
                [NameInMap("CallsBlindTransferred")]
                [Validation(Required=false)]
                public long? CallsBlindTransferred { get; set; }
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
            };

            [NameInMap("Overall")]
            [Validation(Required=false)]
            public ListIntervalInstanceReportResponseBodyDataOverall Overall { get; set; }
            public class ListIntervalInstanceReportResponseBodyDataOverall : TeaModel {
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
                [NameInMap("TotalReadyTime")]
                [Validation(Required=false)]
                public long? TotalReadyTime { get; set; }
                [NameInMap("TotalTalkTime")]
                [Validation(Required=false)]
                public long? TotalTalkTime { get; set; }
                [NameInMap("TotalWorkTime")]
                [Validation(Required=false)]
                public long? TotalWorkTime { get; set; }
            };

            [NameInMap("StatsTime")]
            [Validation(Required=false)]
            public long? StatsTime { get; set; }

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
