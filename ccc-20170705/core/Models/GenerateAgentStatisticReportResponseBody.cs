// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class GenerateAgentStatisticReportResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("DataList")]
        [Validation(Required=false)]
        public GenerateAgentStatisticReportResponseBodyDataList DataList { get; set; }
        public class GenerateAgentStatisticReportResponseBodyDataList : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public GenerateAgentStatisticReportResponseBodyDataListList List { get; set; }
            public class GenerateAgentStatisticReportResponseBodyDataListList : TeaModel {
                [NameInMap("GenerateAgentStatistic")]
                [Validation(Required=false)]
                public List<GenerateAgentStatisticReportResponseBodyDataListListGenerateAgentStatistic> GenerateAgentStatistic { get; set; }
                public class GenerateAgentStatisticReportResponseBodyDataListListGenerateAgentStatistic : TeaModel {
                    [NameInMap("AgentId")]
                    [Validation(Required=false)]
                    public string AgentId { get; set; }

                    [NameInMap("AgentName")]
                    [Validation(Required=false)]
                    public string AgentName { get; set; }

                    [NameInMap("AverageReadyTime")]
                    [Validation(Required=false)]
                    public long? AverageReadyTime { get; set; }

                    [NameInMap("Inbound")]
                    [Validation(Required=false)]
                    public GenerateAgentStatisticReportResponseBodyDataListListGenerateAgentStatisticInbound Inbound { get; set; }
                    public class GenerateAgentStatisticReportResponseBodyDataListListGenerateAgentStatisticInbound : TeaModel {
                        [NameInMap("AverageHoldTime")]
                        [Validation(Required=false)]
                        public long? AverageHoldTime { get; set; }
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
                    };

                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

                    [NameInMap("LoginName")]
                    [Validation(Required=false)]
                    public string LoginName { get; set; }

                    [NameInMap("MaxReadyTime")]
                    [Validation(Required=false)]
                    public long? MaxReadyTime { get; set; }

                    [NameInMap("OccupancyRate")]
                    [Validation(Required=false)]
                    public float? OccupancyRate { get; set; }

                    [NameInMap("Outbound")]
                    [Validation(Required=false)]
                    public GenerateAgentStatisticReportResponseBodyDataListListGenerateAgentStatisticOutbound Outbound { get; set; }
                    public class GenerateAgentStatisticReportResponseBodyDataListListGenerateAgentStatisticOutbound : TeaModel {
                        [NameInMap("AnswerRate")]
                        [Validation(Required=false)]
                        public float? AnswerRate { get; set; }
                        [NameInMap("AverageDialingTime")]
                        [Validation(Required=false)]
                        public long? AverageDialingTime { get; set; }
                        [NameInMap("AverageHoldTime")]
                        [Validation(Required=false)]
                        public long? AverageHoldTime { get; set; }
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
                        [NameInMap("MaxHoldTime")]
                        [Validation(Required=false)]
                        public long? MaxHoldTime { get; set; }
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
                        [NameInMap("TotalHoldTime")]
                        [Validation(Required=false)]
                        public long? TotalHoldTime { get; set; }
                        [NameInMap("TotalTalkTime")]
                        [Validation(Required=false)]
                        public long? TotalTalkTime { get; set; }
                        [NameInMap("TotalWorkTime")]
                        [Validation(Required=false)]
                        public long? TotalWorkTime { get; set; }
                    };

                    [NameInMap("Overall")]
                    [Validation(Required=false)]
                    public GenerateAgentStatisticReportResponseBodyDataListListGenerateAgentStatisticOverall Overall { get; set; }
                    public class GenerateAgentStatisticReportResponseBodyDataListListGenerateAgentStatisticOverall : TeaModel {
                        [NameInMap("AverageHoldTime")]
                        [Validation(Required=false)]
                        public long? AverageHoldTime { get; set; }
                        [NameInMap("AverageTalkTime")]
                        [Validation(Required=false)]
                        public long? AverageTalkTime { get; set; }
                        [NameInMap("AverageWorkTime")]
                        [Validation(Required=false)]
                        public long? AverageWorkTime { get; set; }
                        [NameInMap("MaxHoldTime")]
                        [Validation(Required=false)]
                        public long? MaxHoldTime { get; set; }
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
                        [NameInMap("TotalCalls")]
                        [Validation(Required=false)]
                        public long? TotalCalls { get; set; }
                        [NameInMap("TotalHoldTime")]
                        [Validation(Required=false)]
                        public long? TotalHoldTime { get; set; }
                        [NameInMap("TotalTalkTime")]
                        [Validation(Required=false)]
                        public long? TotalTalkTime { get; set; }
                        [NameInMap("TotalWorkTime")]
                        [Validation(Required=false)]
                        public long? TotalWorkTime { get; set; }
                    };

                    [NameInMap("RecordDate")]
                    [Validation(Required=false)]
                    public string RecordDate { get; set; }

                    [NameInMap("SkillGroupIds")]
                    [Validation(Required=false)]
                    public string SkillGroupIds { get; set; }

                    [NameInMap("SkillGroupNames")]
                    [Validation(Required=false)]
                    public string SkillGroupNames { get; set; }

                    [NameInMap("TotalBreakTime")]
                    [Validation(Required=false)]
                    public long? TotalBreakTime { get; set; }

                    [NameInMap("TotalLoggedInTime")]
                    [Validation(Required=false)]
                    public long? TotalLoggedInTime { get; set; }

                    [NameInMap("TotalReadyTime")]
                    [Validation(Required=false)]
                    public long? TotalReadyTime { get; set; }

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
