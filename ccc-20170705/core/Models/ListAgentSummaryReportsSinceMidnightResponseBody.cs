// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class ListAgentSummaryReportsSinceMidnightResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PagedAgentSummaryReport")]
        [Validation(Required=false)]
        public ListAgentSummaryReportsSinceMidnightResponseBodyPagedAgentSummaryReport PagedAgentSummaryReport { get; set; }
        public class ListAgentSummaryReportsSinceMidnightResponseBodyPagedAgentSummaryReport : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public ListAgentSummaryReportsSinceMidnightResponseBodyPagedAgentSummaryReportList List { get; set; }
            public class ListAgentSummaryReportsSinceMidnightResponseBodyPagedAgentSummaryReportList : TeaModel {
                [NameInMap("AgentSummaryReport")]
                [Validation(Required=false)]
                public List<ListAgentSummaryReportsSinceMidnightResponseBodyPagedAgentSummaryReportListAgentSummaryReport> AgentSummaryReport { get; set; }
                public class ListAgentSummaryReportsSinceMidnightResponseBodyPagedAgentSummaryReportListAgentSummaryReport : TeaModel {
                    [NameInMap("Overall")]
                    [Validation(Required=false)]
                    public ListAgentSummaryReportsSinceMidnightResponseBodyPagedAgentSummaryReportListAgentSummaryReportOverall Overall { get; set; }
                    public class ListAgentSummaryReportsSinceMidnightResponseBodyPagedAgentSummaryReportListAgentSummaryReportOverall : TeaModel {
                        [NameInMap("TotalLoggedInTime")]
                        [Validation(Required=false)]
                        public long? TotalLoggedInTime { get; set; }
                        [NameInMap("TotalTalkTime")]
                        [Validation(Required=false)]
                        public long? TotalTalkTime { get; set; }
                        [NameInMap("OccupancyRate")]
                        [Validation(Required=false)]
                        public float? OccupancyRate { get; set; }
                        [NameInMap("TotalWorkTime")]
                        [Validation(Required=false)]
                        public long? TotalWorkTime { get; set; }
                        [NameInMap("MaxWorkTime")]
                        [Validation(Required=false)]
                        public long? MaxWorkTime { get; set; }
                        [NameInMap("AverageTalkTime")]
                        [Validation(Required=false)]
                        public long? AverageTalkTime { get; set; }
                        [NameInMap("AverageWorkTime")]
                        [Validation(Required=false)]
                        public long? AverageWorkTime { get; set; }
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
                        public long? AverageReadyTime { get; set; }
                        [NameInMap("OneTransferCalls")]
                        [Validation(Required=false)]
                        public long? OneTransferCalls { get; set; }
                        [NameInMap("MaxTalkTime")]
                        [Validation(Required=false)]
                        public long? MaxTalkTime { get; set; }
                        [NameInMap("TotalReadyTime")]
                        [Validation(Required=false)]
                        public long? TotalReadyTime { get; set; }
                        [NameInMap("TotalBreakTime")]
                        [Validation(Required=false)]
                        public long? TotalBreakTime { get; set; }
                        [NameInMap("TotalCalls")]
                        [Validation(Required=false)]
                        public long? TotalCalls { get; set; }
                    };

                    [NameInMap("LoginName")]
                    [Validation(Required=false)]
                    public string LoginName { get; set; }

                    [NameInMap("AgentId")]
                    [Validation(Required=false)]
                    public string AgentId { get; set; }

                    [NameInMap("Inbound")]
                    [Validation(Required=false)]
                    public ListAgentSummaryReportsSinceMidnightResponseBodyPagedAgentSummaryReportListAgentSummaryReportInbound Inbound { get; set; }
                    public class ListAgentSummaryReportsSinceMidnightResponseBodyPagedAgentSummaryReportListAgentSummaryReportInbound : TeaModel {
                        [NameInMap("TotalTalkTime")]
                        [Validation(Required=false)]
                        public long? TotalTalkTime { get; set; }
                        [NameInMap("AverageRingTime")]
                        [Validation(Required=false)]
                        public long? AverageRingTime { get; set; }
                        [NameInMap("CallsOffered")]
                        [Validation(Required=false)]
                        public long? CallsOffered { get; set; }
                        [NameInMap("CallsHandled")]
                        [Validation(Required=false)]
                        public long? CallsHandled { get; set; }
                        [NameInMap("ServiceLevel20")]
                        [Validation(Required=false)]
                        public float? ServiceLevel20 { get; set; }
                        [NameInMap("TotalWorkTime")]
                        [Validation(Required=false)]
                        public long? TotalWorkTime { get; set; }
                        [NameInMap("MaxWorkTime")]
                        [Validation(Required=false)]
                        public long? MaxWorkTime { get; set; }
                        [NameInMap("AverageTalkTime")]
                        [Validation(Required=false)]
                        public long? AverageTalkTime { get; set; }
                        [NameInMap("AverageWorkTime")]
                        [Validation(Required=false)]
                        public long? AverageWorkTime { get; set; }
                        [NameInMap("SatisfactionIndex")]
                        [Validation(Required=false)]
                        public float? SatisfactionIndex { get; set; }
                        [NameInMap("SatisfactionSurveysOffered")]
                        [Validation(Required=false)]
                        public long? SatisfactionSurveysOffered { get; set; }
                        [NameInMap("HandleRate")]
                        [Validation(Required=false)]
                        public float? HandleRate { get; set; }
                        [NameInMap("SatisfactionSurveysResponded")]
                        [Validation(Required=false)]
                        public long? SatisfactionSurveysResponded { get; set; }
                        [NameInMap("TotalRingTime")]
                        [Validation(Required=false)]
                        public long? TotalRingTime { get; set; }
                        [NameInMap("MaxTalkTime")]
                        [Validation(Required=false)]
                        public long? MaxTalkTime { get; set; }
                        [NameInMap("MaxRingTime")]
                        [Validation(Required=false)]
                        public long? MaxRingTime { get; set; }
                    };

                    [NameInMap("Outbound")]
                    [Validation(Required=false)]
                    public ListAgentSummaryReportsSinceMidnightResponseBodyPagedAgentSummaryReportListAgentSummaryReportOutbound Outbound { get; set; }
                    public class ListAgentSummaryReportsSinceMidnightResponseBodyPagedAgentSummaryReportListAgentSummaryReportOutbound : TeaModel {
                        [NameInMap("TotalTalkTime")]
                        [Validation(Required=false)]
                        public long? TotalTalkTime { get; set; }
                        [NameInMap("MaxDialingTime")]
                        [Validation(Required=false)]
                        public long? MaxDialingTime { get; set; }
                        [NameInMap("CallsDialed")]
                        [Validation(Required=false)]
                        public long? CallsDialed { get; set; }
                        [NameInMap("CallsAnswered")]
                        [Validation(Required=false)]
                        public long? CallsAnswered { get; set; }
                        [NameInMap("TotalWorkTime")]
                        [Validation(Required=false)]
                        public long? TotalWorkTime { get; set; }
                        [NameInMap("AnswerRate")]
                        [Validation(Required=false)]
                        public float? AnswerRate { get; set; }
                        [NameInMap("MaxWorkTime")]
                        [Validation(Required=false)]
                        public string MaxWorkTime { get; set; }
                        [NameInMap("TotalDialingTime")]
                        [Validation(Required=false)]
                        public long? TotalDialingTime { get; set; }
                        [NameInMap("AverageWorkTime")]
                        [Validation(Required=false)]
                        public long? AverageWorkTime { get; set; }
                        [NameInMap("AverageTalkTime")]
                        [Validation(Required=false)]
                        public long? AverageTalkTime { get; set; }
                        [NameInMap("SatisfactionIndex")]
                        [Validation(Required=false)]
                        public float? SatisfactionIndex { get; set; }
                        [NameInMap("SatisfactionSurveysOffered")]
                        [Validation(Required=false)]
                        public long? SatisfactionSurveysOffered { get; set; }
                        [NameInMap("SatisfactionSurveysResponded")]
                        [Validation(Required=false)]
                        public long? SatisfactionSurveysResponded { get; set; }
                        [NameInMap("MaxTalkTime")]
                        [Validation(Required=false)]
                        public long? MaxTalkTime { get; set; }
                        [NameInMap("AverageDialingTime")]
                        [Validation(Required=false)]
                        public long? AverageDialingTime { get; set; }
                    };

                    [NameInMap("AgentName")]
                    [Validation(Required=false)]
                    public string AgentName { get; set; }

                    [NameInMap("SkillGroupNames")]
                    [Validation(Required=false)]
                    public string SkillGroupNames { get; set; }

                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public string Timestamp { get; set; }

                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    [NameInMap("SkillGroupIds")]
                    [Validation(Required=false)]
                    public string SkillGroupIds { get; set; }

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

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
