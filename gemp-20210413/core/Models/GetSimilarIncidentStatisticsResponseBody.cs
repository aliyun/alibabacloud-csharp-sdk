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
                public long? Commitment { get; set; }
                public string Date { get; set; }
                public long? Day { get; set; }
                public long? Month { get; set; }
                public List<GetSimilarIncidentStatisticsResponseBodyDataDailySimilarIncidentsSimilarIncidents> SimilarIncidents { get; set; }
                public class GetSimilarIncidentStatisticsResponseBodyDataDailySimilarIncidentsSimilarIncidents : TeaModel {
                    public long? AssignUserId { get; set; }
                    public string AssignUserName { get; set; }
                    public string CreateTime { get; set; }
                    public long? DurationTime { get; set; }
                    public long? FinishReason { get; set; }
                    public string FinishReasonDescription { get; set; }
                    public string FinishSolutionDescription { get; set; }
                    public long? IncidentFinishSolution { get; set; }
                    public long? IncidentId { get; set; }
                    public string IncidentNumber { get; set; }
                    public string IncidentTitle { get; set; }
                    public long? RelatedRouteRuleId { get; set; }
                    public string RelatedRouteRuleName { get; set; }
                    public string SimilarScore { get; set; }
                }
                public string Week { get; set; }
            }
            [NameInMap("requestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }
            [NameInMap("topFiveIncidents")]
            [Validation(Required=false)]
            public List<GetSimilarIncidentStatisticsResponseBodyDataTopFiveIncidents> TopFiveIncidents { get; set; }
            public class GetSimilarIncidentStatisticsResponseBodyDataTopFiveIncidents : TeaModel {
                public string AssignUserId { get; set; }
                public string AssignUserName { get; set; }
                public string CreateTime { get; set; }
                public long? DurationTime { get; set; }
                public long? FinishReason { get; set; }
                public string FinishReasonDescription { get; set; }
                public string FinishSolutionDescription { get; set; }
                public long? IncidentFinishSolution { get; set; }
                public long? IncidentId { get; set; }
                public string IncidentNumber { get; set; }
                public string IncidentTitle { get; set; }
                public long? RelatedRouteRuleId { get; set; }
                public string RelatedRouteRuleName { get; set; }
                public string SimilarScore { get; set; }
            }
        };

        /// <summary>
        /// id of the request
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
