// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class ListSkillGroupSummaryReportsByIntervalResponseBody : TeaModel {
        [NameInMap("PagedSkillGroupSummaryReport")]
        [Validation(Required=false)]
        public ListSkillGroupSummaryReportsByIntervalResponseBodyPagedSkillGroupSummaryReport PagedSkillGroupSummaryReport { get; set; }
        public class ListSkillGroupSummaryReportsByIntervalResponseBodyPagedSkillGroupSummaryReport : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public ListSkillGroupSummaryReportsByIntervalResponseBodyPagedSkillGroupSummaryReportList List { get; set; }
            public class ListSkillGroupSummaryReportsByIntervalResponseBodyPagedSkillGroupSummaryReportList : TeaModel {
                [NameInMap("SkillGroupTimeIntervalReport")]
                [Validation(Required=false)]
                public List<ListSkillGroupSummaryReportsByIntervalResponseBodyPagedSkillGroupSummaryReportListSkillGroupTimeIntervalReport> SkillGroupTimeIntervalReport { get; set; }
                public class ListSkillGroupSummaryReportsByIntervalResponseBodyPagedSkillGroupSummaryReportListSkillGroupTimeIntervalReport : TeaModel {
                    [NameInMap("SkillGroupId")]
                    [Validation(Required=false)]
                    public string SkillGroupId { get; set; }

                    [NameInMap("IntervalList")]
                    [Validation(Required=false)]
                    public ListSkillGroupSummaryReportsByIntervalResponseBodyPagedSkillGroupSummaryReportListSkillGroupTimeIntervalReportIntervalList IntervalList { get; set; }
                    public class ListSkillGroupSummaryReportsByIntervalResponseBodyPagedSkillGroupSummaryReportListSkillGroupTimeIntervalReportIntervalList : TeaModel {
                        [NameInMap("SkillGroupSummaryReport")]
                        [Validation(Required=false)]
                        public List<ListSkillGroupSummaryReportsByIntervalResponseBodyPagedSkillGroupSummaryReportListSkillGroupTimeIntervalReportIntervalListSkillGroupSummaryReport> SkillGroupSummaryReport { get; set; }
                        public class ListSkillGroupSummaryReportsByIntervalResponseBodyPagedSkillGroupSummaryReportListSkillGroupTimeIntervalReportIntervalListSkillGroupSummaryReport : TeaModel {
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

                            [NameInMap("TotalBreakTime")]
                            [Validation(Required=false)]
                            public long? TotalBreakTime { get; set; }

                            [NameInMap("TotalReadyTime")]
                            [Validation(Required=false)]
                            public long? TotalReadyTime { get; set; }

                            [NameInMap("MaxTalkTime")]
                            [Validation(Required=false)]
                            public long? MaxTalkTime { get; set; }

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

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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
