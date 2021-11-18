// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class GetInstanceSummaryReportByIntervalResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("InstanceTimeIntervalReport")]
        [Validation(Required=false)]
        public GetInstanceSummaryReportByIntervalResponseBodyInstanceTimeIntervalReport InstanceTimeIntervalReport { get; set; }
        public class GetInstanceSummaryReportByIntervalResponseBodyInstanceTimeIntervalReport : TeaModel {
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
            [NameInMap("IntervalList")]
            [Validation(Required=false)]
            public GetInstanceSummaryReportByIntervalResponseBodyInstanceTimeIntervalReportIntervalList IntervalList { get; set; }
            public class GetInstanceSummaryReportByIntervalResponseBodyInstanceTimeIntervalReportIntervalList : TeaModel {
                [NameInMap("InstanceSummaryReport")]
                [Validation(Required=false)]
                public List<GetInstanceSummaryReportByIntervalResponseBodyInstanceTimeIntervalReportIntervalListInstanceSummaryReport> InstanceSummaryReport { get; set; }
                public class GetInstanceSummaryReportByIntervalResponseBodyInstanceTimeIntervalReportIntervalListInstanceSummaryReport : TeaModel {
                    [NameInMap("Inbound")]
                    [Validation(Required=false)]
                    public GetInstanceSummaryReportByIntervalResponseBodyInstanceTimeIntervalReportIntervalListInstanceSummaryReportInbound Inbound { get; set; }
                    public class GetInstanceSummaryReportByIntervalResponseBodyInstanceTimeIntervalReportIntervalListInstanceSummaryReportInbound : TeaModel {
                        [NameInMap("AverageRingTime")]
                        [Validation(Required=false)]
                        public long? AverageRingTime { get; set; }
                        [NameInMap("AverageTalkTime")]
                        [Validation(Required=false)]
                        public long? AverageTalkTime { get; set; }
                        [NameInMap("AverageWaitTime")]
                        [Validation(Required=false)]
                        public long? AverageWaitTime { get; set; }
                        [NameInMap("AverageWorkTime")]
                        [Validation(Required=false)]
                        public long? AverageWorkTime { get; set; }
                        [NameInMap("CallsAbandonedInIVR")]
                        [Validation(Required=false)]
                        public long? CallsAbandonedInIVR { get; set; }
                        [NameInMap("CallsAbandonedInQueue")]
                        [Validation(Required=false)]
                        public long? CallsAbandonedInQueue { get; set; }
                        [NameInMap("CallsHandled")]
                        [Validation(Required=false)]
                        public long? CallsHandled { get; set; }
                        [NameInMap("CallsIncomingIVR")]
                        [Validation(Required=false)]
                        public long? CallsIncomingIVR { get; set; }
                        [NameInMap("CallsIncomingLine")]
                        [Validation(Required=false)]
                        public long? CallsIncomingLine { get; set; }
                        [NameInMap("CallsIncomingQueue")]
                        [Validation(Required=false)]
                        public long? CallsIncomingQueue { get; set; }
                        [NameInMap("CallsOffered")]
                        [Validation(Required=false)]
                        public long? CallsOffered { get; set; }
                        [NameInMap("HandleRate")]
                        [Validation(Required=false)]
                        public float? HandleRate { get; set; }
                        [NameInMap("MaxRingTime")]
                        [Validation(Required=false)]
                        public long? MaxRingTime { get; set; }
                        [NameInMap("MaxTalkTime")]
                        [Validation(Required=false)]
                        public string MaxTalkTime { get; set; }
                        [NameInMap("MaxWaitTime")]
                        [Validation(Required=false)]
                        public long? MaxWaitTime { get; set; }
                        [NameInMap("MaxWorkTime")]
                        [Validation(Required=false)]
                        public long? MaxWorkTime { get; set; }
                        [NameInMap("SatisfactionIndex")]
                        [Validation(Required=false)]
                        public float? SatisfactionIndex { get; set; }
                        [NameInMap("SatisfactionSurveysOffered")]
                        [Validation(Required=false)]
                        public long? SatisfactionSurveysOffered { get; set; }
                        [NameInMap("SatisfactionSurveysResponded")]
                        [Validation(Required=false)]
                        public long? SatisfactionSurveysResponded { get; set; }
                        [NameInMap("ServiceLevel20")]
                        [Validation(Required=false)]
                        public float? ServiceLevel20 { get; set; }
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

                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    [NameInMap("Outbound")]
                    [Validation(Required=false)]
                    public GetInstanceSummaryReportByIntervalResponseBodyInstanceTimeIntervalReportIntervalListInstanceSummaryReportOutbound Outbound { get; set; }
                    public class GetInstanceSummaryReportByIntervalResponseBodyInstanceTimeIntervalReportIntervalListInstanceSummaryReportOutbound : TeaModel {
                        [NameInMap("AnswerRate")]
                        [Validation(Required=false)]
                        public float? AnswerRate { get; set; }
                        [NameInMap("AverageDialingTime")]
                        [Validation(Required=false)]
                        public long? AverageDialingTime { get; set; }
                        [NameInMap("AverageTalkTime")]
                        [Validation(Required=false)]
                        public long? AverageTalkTime { get; set; }
                        [NameInMap("AverageWorkTime")]
                        [Validation(Required=false)]
                        public long? AverageWorkTime { get; set; }
                        [NameInMap("CallsAnswered")]
                        [Validation(Required=false)]
                        public long? CallsAnswered { get; set; }
                        [NameInMap("CallsDialed")]
                        [Validation(Required=false)]
                        public long? CallsDialed { get; set; }
                        [NameInMap("MaxDialingTime")]
                        [Validation(Required=false)]
                        public long? MaxDialingTime { get; set; }
                        [NameInMap("MaxTalkTime")]
                        [Validation(Required=false)]
                        public long? MaxTalkTime { get; set; }
                        [NameInMap("MaxWorkTime")]
                        [Validation(Required=false)]
                        public long? MaxWorkTime { get; set; }
                        [NameInMap("SatisfactionIndex")]
                        [Validation(Required=false)]
                        public float? SatisfactionIndex { get; set; }
                        [NameInMap("SatisfactionSurveysOffered")]
                        [Validation(Required=false)]
                        public long? SatisfactionSurveysOffered { get; set; }
                        [NameInMap("SatisfactionSurveysResponded")]
                        [Validation(Required=false)]
                        public long? SatisfactionSurveysResponded { get; set; }
                        [NameInMap("TotalDialingTime")]
                        [Validation(Required=false)]
                        public long? TotalDialingTime { get; set; }
                        [NameInMap("TotalTalkTime")]
                        [Validation(Required=false)]
                        public long? TotalTalkTime { get; set; }
                        [NameInMap("TotalWorkTime")]
                        [Validation(Required=false)]
                        public long? TotalWorkTime { get; set; }
                    };

                    [NameInMap("Overall")]
                    [Validation(Required=false)]
                    public GetInstanceSummaryReportByIntervalResponseBodyInstanceTimeIntervalReportIntervalListInstanceSummaryReportOverall Overall { get; set; }
                    public class GetInstanceSummaryReportByIntervalResponseBodyInstanceTimeIntervalReportIntervalListInstanceSummaryReportOverall : TeaModel {
                        [NameInMap("AverageReadyTime")]
                        [Validation(Required=false)]
                        public long? AverageReadyTime { get; set; }
                        [NameInMap("AverageTalkTime")]
                        [Validation(Required=false)]
                        public long? AverageTalkTime { get; set; }
                        [NameInMap("AverageWorkTime")]
                        [Validation(Required=false)]
                        public long? AverageWorkTime { get; set; }
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

                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public string Timestamp { get; set; }

                }

            }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
