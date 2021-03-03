// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20170705.Models
{
    public class GetAgentDataResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("DataList")]
        [Validation(Required=false)]
        public GetAgentDataResponseBodyDataList DataList { get; set; }
        public class GetAgentDataResponseBodyDataList : TeaModel {
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<GetAgentDataResponseBodyDataListList> List { get; set; }
            public class GetAgentDataResponseBodyDataListList : TeaModel {
                public string AgentId { get; set; }
                public string LoginName { get; set; }
                public string AgentName { get; set; }
                public string SkillGroupIds { get; set; }
                public string SkillGroupNames { get; set; }
                public string InstanceId { get; set; }
                public string RecordDate { get; set; }
                public long? TotalLoggedInTime { get; set; }
                public long? TotalBreakTime { get; set; }
                public float? OccupancyRate { get; set; }
                public long? TotalReadyTime { get; set; }
                public long? MaxReadyTime { get; set; }
                public long? AverageReadyTime { get; set; }
                public GetAgentDataResponseBodyDataListListInbound Inbound { get; set; }
                public class GetAgentDataResponseBodyDataListListInbound : TeaModel {
                    [NameInMap("TotalTalkTime")]
                    [Validation(Required=false)]
                    public long? TotalTalkTime { get; set; }

                    [NameInMap("MaxTalkTime")]
                    [Validation(Required=false)]
                    public long? MaxTalkTime { get; set; }

                    [NameInMap("AverageTalkTime")]
                    [Validation(Required=false)]
                    public long? AverageTalkTime { get; set; }

                    [NameInMap("TotalHoldTime")]
                    [Validation(Required=false)]
                    public long? TotalHoldTime { get; set; }

                    [NameInMap("MaxHoldTime")]
                    [Validation(Required=false)]
                    public long? MaxHoldTime { get; set; }

                    [NameInMap("AverageHoldTime")]
                    [Validation(Required=false)]
                    public long? AverageHoldTime { get; set; }

                    [NameInMap("TotalWorkTime")]
                    [Validation(Required=false)]
                    public long? TotalWorkTime { get; set; }

                    [NameInMap("MaxWorkTime")]
                    [Validation(Required=false)]
                    public long? MaxWorkTime { get; set; }

                    [NameInMap("AverageWorkTime")]
                    [Validation(Required=false)]
                    public long? AverageWorkTime { get; set; }

                    [NameInMap("SatisfactionSurveysOffered")]
                    [Validation(Required=false)]
                    public long? SatisfactionSurveysOffered { get; set; }

                    [NameInMap("SatisfactionSurveysResponded")]
                    [Validation(Required=false)]
                    public long? SatisfactionSurveysResponded { get; set; }

                    [NameInMap("SatisfactionIndex")]
                    [Validation(Required=false)]
                    public float? SatisfactionIndex { get; set; }

                    [NameInMap("CallsOffered")]
                    [Validation(Required=false)]
                    public long? CallsOffered { get; set; }

                    [NameInMap("CallsHandled")]
                    [Validation(Required=false)]
                    public long? CallsHandled { get; set; }

                    [NameInMap("HandleRate")]
                    [Validation(Required=false)]
                    public float? HandleRate { get; set; }

                    [NameInMap("TotalRingTime")]
                    [Validation(Required=false)]
                    public long? TotalRingTime { get; set; }

                    [NameInMap("MaxRingTime")]
                    [Validation(Required=false)]
                    public long? MaxRingTime { get; set; }

                    [NameInMap("AverageRingTime")]
                    [Validation(Required=false)]
                    public long? AverageRingTime { get; set; }

                }
                public GetAgentDataResponseBodyDataListListOutbound Outbound { get; set; }
                public class GetAgentDataResponseBodyDataListListOutbound : TeaModel {
                    [NameInMap("TotalTalkTime")]
                    [Validation(Required=false)]
                    public long? TotalTalkTime { get; set; }

                    [NameInMap("MaxTalkTime")]
                    [Validation(Required=false)]
                    public long? MaxTalkTime { get; set; }

                    [NameInMap("AverageTalkTime")]
                    [Validation(Required=false)]
                    public long? AverageTalkTime { get; set; }

                    [NameInMap("TotalHoldTime")]
                    [Validation(Required=false)]
                    public long? TotalHoldTime { get; set; }

                    [NameInMap("MaxHoldTime")]
                    [Validation(Required=false)]
                    public long? MaxHoldTime { get; set; }

                    [NameInMap("AverageHoldTime")]
                    [Validation(Required=false)]
                    public long? AverageHoldTime { get; set; }

                    [NameInMap("TotalWorkTime")]
                    [Validation(Required=false)]
                    public long? TotalWorkTime { get; set; }

                    [NameInMap("MaxWorkTime")]
                    [Validation(Required=false)]
                    public long? MaxWorkTime { get; set; }

                    [NameInMap("AverageWorkTime")]
                    [Validation(Required=false)]
                    public long? AverageWorkTime { get; set; }

                    [NameInMap("SatisfactionSurveysOffered")]
                    [Validation(Required=false)]
                    public long? SatisfactionSurveysOffered { get; set; }

                    [NameInMap("SatisfactionSurveysResponded")]
                    [Validation(Required=false)]
                    public long? SatisfactionSurveysResponded { get; set; }

                    [NameInMap("SatisfactionIndex")]
                    [Validation(Required=false)]
                    public float? SatisfactionIndex { get; set; }

                    [NameInMap("CallsDialed")]
                    [Validation(Required=false)]
                    public long? CallsDialed { get; set; }

                    [NameInMap("CallsAnswered")]
                    [Validation(Required=false)]
                    public long? CallsAnswered { get; set; }

                    [NameInMap("AnswerRate")]
                    [Validation(Required=false)]
                    public float? AnswerRate { get; set; }

                    [NameInMap("TotalDialingTime")]
                    [Validation(Required=false)]
                    public long? TotalDialingTime { get; set; }

                    [NameInMap("MaxDialingTime")]
                    [Validation(Required=false)]
                    public long? MaxDialingTime { get; set; }

                    [NameInMap("AverageDialingTime")]
                    [Validation(Required=false)]
                    public long? AverageDialingTime { get; set; }

                }
                public GetAgentDataResponseBodyDataListListOverall Overall { get; set; }
                public class GetAgentDataResponseBodyDataListListOverall : TeaModel {
                    [NameInMap("TotalTalkTime")]
                    [Validation(Required=false)]
                    public long? TotalTalkTime { get; set; }

                    [NameInMap("MaxTalkTime")]
                    [Validation(Required=false)]
                    public long? MaxTalkTime { get; set; }

                    [NameInMap("AverageTalkTime")]
                    [Validation(Required=false)]
                    public long? AverageTalkTime { get; set; }

                    [NameInMap("TotalHoldTime")]
                    [Validation(Required=false)]
                    public long? TotalHoldTime { get; set; }

                    [NameInMap("MaxHoldTime")]
                    [Validation(Required=false)]
                    public long? MaxHoldTime { get; set; }

                    [NameInMap("AverageHoldTime")]
                    [Validation(Required=false)]
                    public long? AverageHoldTime { get; set; }

                    [NameInMap("TotalWorkTime")]
                    [Validation(Required=false)]
                    public long? TotalWorkTime { get; set; }

                    [NameInMap("MaxWorkTime")]
                    [Validation(Required=false)]
                    public long? MaxWorkTime { get; set; }

                    [NameInMap("AverageWorkTime")]
                    [Validation(Required=false)]
                    public long? AverageWorkTime { get; set; }

                    [NameInMap("SatisfactionSurveysOffered")]
                    [Validation(Required=false)]
                    public long? SatisfactionSurveysOffered { get; set; }

                    [NameInMap("SatisfactionSurveysResponded")]
                    [Validation(Required=false)]
                    public long? SatisfactionSurveysResponded { get; set; }

                    [NameInMap("SatisfactionIndex")]
                    [Validation(Required=false)]
                    public float? SatisfactionIndex { get; set; }

                    [NameInMap("TotalCalls")]
                    [Validation(Required=false)]
                    public long? TotalCalls { get; set; }

                }
            }
        };

    }

}
