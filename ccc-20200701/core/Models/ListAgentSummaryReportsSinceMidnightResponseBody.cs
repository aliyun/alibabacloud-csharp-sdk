// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListAgentSummaryReportsSinceMidnightResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PagedAgentSummaryReport")]
        [Validation(Required=false)]
        public ListAgentSummaryReportsSinceMidnightResponseBodyPagedAgentSummaryReport PagedAgentSummaryReport { get; set; }
        public class ListAgentSummaryReportsSinceMidnightResponseBodyPagedAgentSummaryReport : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListAgentSummaryReportsSinceMidnightResponseBodyPagedAgentSummaryReportList> List { get; set; }
            public class ListAgentSummaryReportsSinceMidnightResponseBodyPagedAgentSummaryReportList : TeaModel {
                public string AgentId { get; set; }
                public string AgentName { get; set; }
                public ListAgentSummaryReportsSinceMidnightResponseBodyPagedAgentSummaryReportListInbound Inbound { get; set; }
                public class ListAgentSummaryReportsSinceMidnightResponseBodyPagedAgentSummaryReportListInbound : TeaModel {
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

                    [NameInMap("HandleRate")]
                    [Validation(Required=false)]
                    public float? HandleRate { get; set; }

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

                }
                public string InstanceId { get; set; }
                public string LoginName { get; set; }
                public ListAgentSummaryReportsSinceMidnightResponseBodyPagedAgentSummaryReportListOutbound Outbound { get; set; }
                public class ListAgentSummaryReportsSinceMidnightResponseBodyPagedAgentSummaryReportListOutbound : TeaModel {
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
                    public string MaxWorkTime { get; set; }

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

                }
                public ListAgentSummaryReportsSinceMidnightResponseBodyPagedAgentSummaryReportListOverall Overall { get; set; }
                public class ListAgentSummaryReportsSinceMidnightResponseBodyPagedAgentSummaryReportListOverall : TeaModel {
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

                    [NameInMap("OneTransferCalls")]
                    [Validation(Required=false)]
                    public long? OneTransferCalls { get; set; }

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

                }
                public string SkillGroupIds { get; set; }
                public string SkillGroupNames { get; set; }
                public string Timestamp { get; set; }
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
