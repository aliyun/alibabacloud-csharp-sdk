// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.GEMP20210413.Models
{
    public class GetSimilarIncidentStatisticsResponseBody : TeaModel {
        /// <summary>
        /// data
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetSimilarIncidentStatisticsResponseBodyData Data { get; set; }
        public class GetSimilarIncidentStatisticsResponseBodyData : TeaModel {
            [NameInMap("countInSevenDays")]
            [Validation(Required=false)]
            public long? CountInSevenDays { get; set; }

            [NameInMap("countInSixMonths")]
            [Validation(Required=false)]
            public long? CountInSixMonths { get; set; }

            [NameInMap("dailySimilarIncidents")]
            [Validation(Required=false)]
            public List<GetSimilarIncidentStatisticsResponseBodyDataDailySimilarIncidents> DailySimilarIncidents { get; set; }
            public class GetSimilarIncidentStatisticsResponseBodyDataDailySimilarIncidents : TeaModel {
                [NameInMap("commitment")]
                [Validation(Required=false)]
                public long? Commitment { get; set; }

                [NameInMap("date")]
                [Validation(Required=false)]
                public string Date { get; set; }

                [NameInMap("day")]
                [Validation(Required=false)]
                public long? Day { get; set; }

                [NameInMap("month")]
                [Validation(Required=false)]
                public long? Month { get; set; }

                [NameInMap("similarIncidents")]
                [Validation(Required=false)]
                public List<GetSimilarIncidentStatisticsResponseBodyDataDailySimilarIncidentsSimilarIncidents> SimilarIncidents { get; set; }
                public class GetSimilarIncidentStatisticsResponseBodyDataDailySimilarIncidentsSimilarIncidents : TeaModel {
                    [NameInMap("assignUserId")]
                    [Validation(Required=false)]
                    public long? AssignUserId { get; set; }

                    [NameInMap("assignUserName")]
                    [Validation(Required=false)]
                    public string AssignUserName { get; set; }

                    [NameInMap("createTime")]
                    [Validation(Required=false)]
                    public string CreateTime { get; set; }

                    [NameInMap("durationTime")]
                    [Validation(Required=false)]
                    public long? DurationTime { get; set; }

                    [NameInMap("finishReason")]
                    [Validation(Required=false)]
                    public long? FinishReason { get; set; }

                    [NameInMap("finishReasonDescription")]
                    [Validation(Required=false)]
                    public string FinishReasonDescription { get; set; }

                    [NameInMap("finishSolutionDescription")]
                    [Validation(Required=false)]
                    public string FinishSolutionDescription { get; set; }

                    [NameInMap("incidentFinishSolution")]
                    [Validation(Required=false)]
                    public long? IncidentFinishSolution { get; set; }

                    [NameInMap("incidentId")]
                    [Validation(Required=false)]
                    public long? IncidentId { get; set; }

                    [NameInMap("incidentNumber")]
                    [Validation(Required=false)]
                    public string IncidentNumber { get; set; }

                    [NameInMap("incidentTitle")]
                    [Validation(Required=false)]
                    public string IncidentTitle { get; set; }

                    [NameInMap("relatedRouteRuleId")]
                    [Validation(Required=false)]
                    public long? RelatedRouteRuleId { get; set; }

                    [NameInMap("relatedRouteRuleName")]
                    [Validation(Required=false)]
                    public string RelatedRouteRuleName { get; set; }

                    [NameInMap("similarScore")]
                    [Validation(Required=false)]
                    public string SimilarScore { get; set; }

                }

                [NameInMap("week")]
                [Validation(Required=false)]
                public string Week { get; set; }

            }

            /// <summary>
            /// id of the request
            /// </summary>
            [NameInMap("requestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            /// <summary>
            /// topFiveIncidents
            /// </summary>
            [NameInMap("topFiveIncidents")]
            [Validation(Required=false)]
            public List<GetSimilarIncidentStatisticsResponseBodyDataTopFiveIncidents> TopFiveIncidents { get; set; }
            public class GetSimilarIncidentStatisticsResponseBodyDataTopFiveIncidents : TeaModel {
                [NameInMap("assignUserId")]
                [Validation(Required=false)]
                public string AssignUserId { get; set; }

                [NameInMap("assignUserName")]
                [Validation(Required=false)]
                public string AssignUserName { get; set; }

                [NameInMap("createTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("durationTime")]
                [Validation(Required=false)]
                public long? DurationTime { get; set; }

                [NameInMap("finishReason")]
                [Validation(Required=false)]
                public long? FinishReason { get; set; }

                [NameInMap("finishReasonDescription")]
                [Validation(Required=false)]
                public string FinishReasonDescription { get; set; }

                [NameInMap("finishSolutionDescription")]
                [Validation(Required=false)]
                public string FinishSolutionDescription { get; set; }

                [NameInMap("incidentFinishSolution")]
                [Validation(Required=false)]
                public long? IncidentFinishSolution { get; set; }

                [NameInMap("incidentId")]
                [Validation(Required=false)]
                public long? IncidentId { get; set; }

                [NameInMap("incidentNumber")]
                [Validation(Required=false)]
                public string IncidentNumber { get; set; }

                [NameInMap("incidentTitle")]
                [Validation(Required=false)]
                public string IncidentTitle { get; set; }

                [NameInMap("relatedRouteRuleId")]
                [Validation(Required=false)]
                public long? RelatedRouteRuleId { get; set; }

                [NameInMap("relatedRouteRuleName")]
                [Validation(Required=false)]
                public string RelatedRouteRuleName { get; set; }

                [NameInMap("similarScore")]
                [Validation(Required=false)]
                public string SimilarScore { get; set; }

            }

        }

        /// <summary>
        /// id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
