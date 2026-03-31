// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class ListConfigRuleEvaluationStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>The statistics of compliance evaluation results.</para>
        /// </summary>
        [NameInMap("EvaluationResults")]
        [Validation(Required=false)]
        public List<ListConfigRuleEvaluationStatisticsResponseBodyEvaluationResults> EvaluationResults { get; set; }
        public class ListConfigRuleEvaluationStatisticsResponseBodyEvaluationResults : TeaModel {
            /// <summary>
            /// <para>The number of resources that are evaluated as non-compliant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("NonCompliantResourceCnt")]
            [Validation(Required=false)]
            public int? NonCompliantResourceCnt { get; set; }

            /// <summary>
            /// <para>The number of rules based on which resources are evaluated as non-compliant.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("NonCompliantRuleCnt")]
            [Validation(Required=false)]
            public int? NonCompliantRuleCnt { get; set; }

            /// <summary>
            /// <para>The date on which the statistics are obtained.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-06-27</para>
            /// </summary>
            [NameInMap("StatisticDate")]
            [Validation(Required=false)]
            public string StatisticDate { get; set; }

            /// <summary>
            /// <para>The total number of resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>91</para>
            /// </summary>
            [NameInMap("TotalResourceCnt")]
            [Validation(Required=false)]
            public int? TotalResourceCnt { get; set; }

            /// <summary>
            /// <para>The total number of rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13</para>
            /// </summary>
            [NameInMap("TotalRuleCnt")]
            [Validation(Required=false)]
            public int? TotalRuleCnt { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4FF2B787-347E-5299-A196-2C0448DEA341</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
