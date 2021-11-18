// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class ListAgentSummaryReportsResponseBody : TeaModel {
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
        public ListAgentSummaryReportsResponseBodyPagedAgentSummaryReport PagedAgentSummaryReport { get; set; }
        public class ListAgentSummaryReportsResponseBodyPagedAgentSummaryReport : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public ListAgentSummaryReportsResponseBodyPagedAgentSummaryReportList List { get; set; }
            public class ListAgentSummaryReportsResponseBodyPagedAgentSummaryReportList : TeaModel {
                [NameInMap("AgentSummaryReport")]
                [Validation(Required=false)]
                public List<ListAgentSummaryReportsResponseBodyPagedAgentSummaryReportListAgentSummaryReport> AgentSummaryReport { get; set; }
                public class ListAgentSummaryReportsResponseBodyPagedAgentSummaryReportListAgentSummaryReport : TeaModel {
                    [NameInMap("AgentId")]
                    [Validation(Required=false)]
                    public string AgentId { get; set; }

                    [NameInMap("AgentName")]
                    [Validation(Required=false)]
                    public string AgentName { get; set; }

                    [NameInMap("Inbound")]
                    [Validation(Required=false)]
                    public ListAgentSummaryReportsResponseBodyPagedAgentSummaryReportListAgentSummaryReportInbound Inbound { get; set; }
                    public class ListAgentSummaryReportsResponseBodyPagedAgentSummaryReportListAgentSummaryReportInbound : TeaModel {
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
                    };

                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    [NameInMap("LoginName")]
                    [Validation(Required=false)]
                    public string LoginName { get; set; }

                    [NameInMap("Outbound")]
                    [Validation(Required=false)]
                    public ListAgentSummaryReportsResponseBodyPagedAgentSummaryReportListAgentSummaryReportOutbound Outbound { get; set; }
                    public class ListAgentSummaryReportsResponseBodyPagedAgentSummaryReportListAgentSummaryReportOutbound : TeaModel {
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
                    };

                    [NameInMap("Overall")]
                    [Validation(Required=false)]
                    public ListAgentSummaryReportsResponseBodyPagedAgentSummaryReportListAgentSummaryReportOverall Overall { get; set; }
                    public class ListAgentSummaryReportsResponseBodyPagedAgentSummaryReportListAgentSummaryReportOverall : TeaModel {
                        [NameInMap("AverageReadyTime")]
                        [Validation(Required=false)]
                        public long? AverageReadyTime { get; set; }
                        [NameInMap("AverageTalkTime")]
                        [Validation(Required=false)]
                        public long? AverageTalkTime { get; set; }
                        [NameInMap("AverageWorkTime")]
                        [Validation(Required=false)]
                        public long? AverageWorkTime { get; set; }
                        [NameInMap("FirstLogInTime")]
                        [Validation(Required=false)]
                        public string FirstLogInTime { get; set; }
                        [NameInMap("LastLogOutTime")]
                        [Validation(Required=false)]
                        public string LastLogOutTime { get; set; }
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
                    };

                    [NameInMap("SkillGroupIds")]
                    [Validation(Required=false)]
                    public string SkillGroupIds { get; set; }

                    [NameInMap("SkillGroupNames")]
                    [Validation(Required=false)]
                    public string SkillGroupNames { get; set; }

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
