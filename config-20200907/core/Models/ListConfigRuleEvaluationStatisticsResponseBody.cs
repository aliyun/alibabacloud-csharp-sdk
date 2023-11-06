// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListConfigRuleEvaluationStatisticsResponseBody : TeaModel {
        /// <summary>
        /// The statistics of compliance evaluation results.
        /// </summary>
        [NameInMap("EvaluationResults")]
        [Validation(Required=false)]
        public List<ListConfigRuleEvaluationStatisticsResponseBodyEvaluationResults> EvaluationResults { get; set; }
        public class ListConfigRuleEvaluationStatisticsResponseBodyEvaluationResults : TeaModel {
            /// <summary>
            /// The number of resources that are evaluated as non-compliant.
            /// </summary>
            [NameInMap("NonCompliantResourceCnt")]
            [Validation(Required=false)]
            public int? NonCompliantResourceCnt { get; set; }

            /// <summary>
            /// The number of rules based on which resources are evaluated as non-compliant.
            /// </summary>
            [NameInMap("NonCompliantRuleCnt")]
            [Validation(Required=false)]
            public int? NonCompliantRuleCnt { get; set; }

            /// <summary>
            /// The date on which the statistics are obtained.
            /// </summary>
            [NameInMap("StatisticDate")]
            [Validation(Required=false)]
            public string StatisticDate { get; set; }

            /// <summary>
            /// The total number of resources.
            /// </summary>
            [NameInMap("TotalResourceCnt")]
            [Validation(Required=false)]
            public int? TotalResourceCnt { get; set; }

            /// <summary>
            /// The total number of rules.
            /// </summary>
            [NameInMap("TotalRuleCnt")]
            [Validation(Required=false)]
            public int? TotalRuleCnt { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
