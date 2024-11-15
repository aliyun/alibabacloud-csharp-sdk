// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Governance20210120.Models
{
    public class ListEvaluationScoreHistoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AC9BD94C-D20C-4D27-88D4-89E8D75C051B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The historical scores.</para>
        /// </summary>
        [NameInMap("ScoreHistory")]
        [Validation(Required=false)]
        public ListEvaluationScoreHistoryResponseBodyScoreHistory ScoreHistory { get; set; }
        public class ListEvaluationScoreHistoryResponseBodyScoreHistory : TeaModel {
            /// <summary>
            /// <para>The historical scores.</para>
            /// </summary>
            [NameInMap("TotalScoreHistory")]
            [Validation(Required=false)]
            public List<ListEvaluationScoreHistoryResponseBodyScoreHistoryTotalScoreHistory> TotalScoreHistory { get; set; }
            public class ListEvaluationScoreHistoryResponseBodyScoreHistoryTotalScoreHistory : TeaModel {
                /// <summary>
                /// <para>The time when the score was generated. The time is in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-06-30T03:34:02Z</para>
                /// </summary>
                [NameInMap("EvaluationTime")]
                [Validation(Required=false)]
                public string EvaluationTime { get; set; }

                /// <summary>
                /// <para>The score.</para>
                /// <para>Valid values: 0 to 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.6753</para>
                /// </summary>
                [NameInMap("Score")]
                [Validation(Required=false)]
                public double? Score { get; set; }

            }

        }

    }

}
