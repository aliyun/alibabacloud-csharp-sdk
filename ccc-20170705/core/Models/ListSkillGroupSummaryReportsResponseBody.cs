// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class ListSkillGroupSummaryReportsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PagedSkillGroupSummaryReport")]
        [Validation(Required=false)]
        public ListSkillGroupSummaryReportsResponseBodyPagedSkillGroupSummaryReport PagedSkillGroupSummaryReport { get; set; }
        public class ListSkillGroupSummaryReportsResponseBodyPagedSkillGroupSummaryReport : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public ListSkillGroupSummaryReportsResponseBodyPagedSkillGroupSummaryReportList List { get; set; }
            public class ListSkillGroupSummaryReportsResponseBodyPagedSkillGroupSummaryReportList : TeaModel {
                [NameInMap("SkillGroupSummaryReport")]
                [Validation(Required=false)]
                public List<ListSkillGroupSummaryReportsResponseBodyPagedSkillGroupSummaryReportListSkillGroupSummaryReport> SkillGroupSummaryReport { get; set; }
                public class ListSkillGroupSummaryReportsResponseBodyPagedSkillGroupSummaryReportListSkillGroupSummaryReport : TeaModel {
                    [NameInMap("Inbound")]
                    [Validation(Required=false)]
                    public ListSkillGroupSummaryReportsResponseBodyPagedSkillGroupSummaryReportListSkillGroupSummaryReportInbound Inbound { get; set; }
                    public class ListSkillGroupSummaryReportsResponseBodyPagedSkillGroupSummaryReportListSkillGroupSummaryReportInbound : TeaModel {
                        [NameInMap("AbandonedInQueueOfQueueCount")]
                        [Validation(Required=false)]
                        public long? AbandonedInQueueOfQueueCount { get; set; }
                        [NameInMap("AnsweredByAgentOfQueueCount")]
                        [Validation(Required=false)]
                        public long? AnsweredByAgentOfQueueCount { get; set; }
                        [NameInMap("AnsweredByAgentOfQueueMaxWaitTimeDuration")]
                        [Validation(Required=false)]
                        public long? AnsweredByAgentOfQueueMaxWaitTimeDuration { get; set; }
                        [NameInMap("AnsweredByAgentOfQueueWaitTimeDuration")]
                        [Validation(Required=false)]
                        public long? AnsweredByAgentOfQueueWaitTimeDuration { get; set; }
                        [NameInMap("AverageRingTime")]
                        [Validation(Required=false)]
                        public long? AverageRingTime { get; set; }
                        [NameInMap("AverageTalkTime")]
                        [Validation(Required=false)]
                        public long? AverageTalkTime { get; set; }
                        [NameInMap("AverageWorkTime")]
                        [Validation(Required=false)]
                        public long? AverageWorkTime { get; set; }
                        [NameInMap("CallsHandled")]
                        [Validation(Required=false)]
                        public long? CallsHandled { get; set; }
                        [NameInMap("CallsOffered")]
                        [Validation(Required=false)]
                        public long? CallsOffered { get; set; }
                        [NameInMap("GiveUpByAgentOfQueueCount")]
                        [Validation(Required=false)]
                        public long? GiveUpByAgentOfQueueCount { get; set; }
                        [NameInMap("HandleRate")]
                        [Validation(Required=false)]
                        public float? HandleRate { get; set; }
                        [NameInMap("InComingQueueOfQueueCount")]
                        [Validation(Required=false)]
                        public long? InComingQueueOfQueueCount { get; set; }
                        [NameInMap("MaxRingTime")]
                        [Validation(Required=false)]
                        public long? MaxRingTime { get; set; }
                        [NameInMap("MaxTalkTime")]
                        [Validation(Required=false)]
                        public string MaxTalkTime { get; set; }
                        [NameInMap("MaxWorkTime")]
                        [Validation(Required=false)]
                        public long? MaxWorkTime { get; set; }
                        [NameInMap("OverFlowInQueueOfQueueCount")]
                        [Validation(Required=false)]
                        public long? OverFlowInQueueOfQueueCount { get; set; }
                        [NameInMap("QueueMaxWaitTimeDuration")]
                        [Validation(Required=false)]
                        public long? QueueMaxWaitTimeDuration { get; set; }
                        [NameInMap("QueueWaitTimeDuration")]
                        [Validation(Required=false)]
                        public long? QueueWaitTimeDuration { get; set; }
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
                        [NameInMap("TotalWorkTime")]
                        [Validation(Required=false)]
                        public long? TotalWorkTime { get; set; }
                    };

                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    [NameInMap("Outbound")]
                    [Validation(Required=false)]
                    public ListSkillGroupSummaryReportsResponseBodyPagedSkillGroupSummaryReportListSkillGroupSummaryReportOutbound Outbound { get; set; }
                    public class ListSkillGroupSummaryReportsResponseBodyPagedSkillGroupSummaryReportListSkillGroupSummaryReportOutbound : TeaModel {
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
                    public ListSkillGroupSummaryReportsResponseBodyPagedSkillGroupSummaryReportListSkillGroupSummaryReportOverall Overall { get; set; }
                    public class ListSkillGroupSummaryReportsResponseBodyPagedSkillGroupSummaryReportListSkillGroupSummaryReportOverall : TeaModel {
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

                    [NameInMap("SkillGroupId")]
                    [Validation(Required=false)]
                    public string SkillGroupId { get; set; }

                    [NameInMap("SkillGroupName")]
                    [Validation(Required=false)]
                    public string SkillGroupName { get; set; }

                }

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
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
