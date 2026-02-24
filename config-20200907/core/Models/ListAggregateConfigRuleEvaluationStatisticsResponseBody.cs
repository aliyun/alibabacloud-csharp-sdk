// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListAggregateConfigRuleEvaluationStatisticsResponseBody : TeaModel {
        [NameInMap("EvaluationResults")]
        [Validation(Required=false)]
        public List<ListAggregateConfigRuleEvaluationStatisticsResponseBodyEvaluationResults> EvaluationResults { get; set; }
        public class ListAggregateConfigRuleEvaluationStatisticsResponseBodyEvaluationResults : TeaModel {
            [NameInMap("AggregatorId")]
            [Validation(Required=false)]
            public string AggregatorId { get; set; }

            [NameInMap("NonCompliantResourceCnt")]
            [Validation(Required=false)]
            public int? NonCompliantResourceCnt { get; set; }

            [NameInMap("NonCompliantRuleCnt")]
            [Validation(Required=false)]
            public int? NonCompliantRuleCnt { get; set; }

            [NameInMap("StatisticDate")]
            [Validation(Required=false)]
            public string StatisticDate { get; set; }

            [NameInMap("TotalResourceCnt")]
            [Validation(Required=false)]
            public int? TotalResourceCnt { get; set; }

            [NameInMap("TotalRuleCnt")]
            [Validation(Required=false)]
            public int? TotalRuleCnt { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
