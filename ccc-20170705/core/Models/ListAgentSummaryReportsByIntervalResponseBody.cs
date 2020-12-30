// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class ListAgentSummaryReportsByIntervalResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PagedAgentSummaryReport")]
        [Validation(Required=false)]
        public ListAgentSummaryReportsByIntervalResponseBodyPagedAgentSummaryReport PagedAgentSummaryReport { get; set; }
        public class ListAgentSummaryReportsByIntervalResponseBodyPagedAgentSummaryReport : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public ListAgentSummaryReportsByIntervalResponseBodyPagedAgentSummaryReportList List { get; set; }
            public class ListAgentSummaryReportsByIntervalResponseBodyPagedAgentSummaryReportList : TeaModel {
                [NameInMap("AgentTimeIntervalReport")]
                [Validation(Required=false)]
                public List<ListAgentSummaryReportsByIntervalResponseBodyPagedAgentSummaryReportListAgentTimeIntervalReport> AgentTimeIntervalReport { get; set; }
                public class ListAgentSummaryReportsByIntervalResponseBodyPagedAgentSummaryReportListAgentTimeIntervalReport : TeaModel {
                    [NameInMap("AgentId")]
                    [Validation(Required=false)]
                    public string AgentId { get; set; }

                    [NameInMap("IntervalList")]
                    [Validation(Required=false)]
                    public ListAgentSummaryReportsByIntervalResponseBodyPagedAgentSummaryReportListAgentTimeIntervalReportIntervalList IntervalList { get; set; }
                    public class ListAgentSummaryReportsByIntervalResponseBodyPagedAgentSummaryReportListAgentTimeIntervalReportIntervalList : TeaModel {
                        [NameInMap("AgentSummaryReport")]
                        [Validation(Required=false)]
                        public List<ListAgentSummaryReportsByIntervalResponseBodyPagedAgentSummaryReportListAgentTimeIntervalReportIntervalListAgentSummaryReport> AgentSummaryReport { get; set; }
                        public class ListAgentSummaryReportsByIntervalResponseBodyPagedAgentSummaryReportListAgentTimeIntervalReportIntervalListAgentSummaryReport : TeaModel {
                            [NameInMap("TotalLoggedInTime")]
                            [Validation(Required=false)]
                            public long? TotalLoggedInTime { get; set; }

                            [NameInMap("TotalTalkTime")]
                            [Validation(Required=false)]
                            public long? TotalTalkTime { get; set; }

                            [NameInMap("OccupancyRate")]
                            [Validation(Required=false)]
                            public float? OccupancyRate { get; set; }

                            [NameInMap("LastLogOutTime")]
                            [Validation(Required=false)]
                            public string LastLogOutTime { get; set; }

                            [NameInMap("TotalWorkTime")]
                            [Validation(Required=false)]
                            public long? TotalWorkTime { get; set; }

                            [NameInMap("FirstLogInTime")]
                            [Validation(Required=false)]
                            public string FirstLogInTime { get; set; }

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

                            [NameInMap("AverageReadyTime")]
                            [Validation(Required=false)]
                            public long? AverageReadyTime { get; set; }

                            [NameInMap("MaxReadyTime")]
                            [Validation(Required=false)]
                            public long? MaxReadyTime { get; set; }

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

                        }
                    };

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
