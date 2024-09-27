// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Governance20210120.Models
{
    public class ListEvaluationScoreHistoryResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>AC9BD94C-D20C-4D27-88D4-89E8D75C051B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ScoreHistory")]
        [Validation(Required=false)]
        public ListEvaluationScoreHistoryResponseBodyScoreHistory ScoreHistory { get; set; }
        public class ListEvaluationScoreHistoryResponseBodyScoreHistory : TeaModel {
            [NameInMap("TotalScoreHistory")]
            [Validation(Required=false)]
            public List<ListEvaluationScoreHistoryResponseBodyScoreHistoryTotalScoreHistory> TotalScoreHistory { get; set; }
            public class ListEvaluationScoreHistoryResponseBodyScoreHistoryTotalScoreHistory : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-06-30T03:34:02Z</para>
                /// </summary>
                [NameInMap("EvaluationTime")]
                [Validation(Required=false)]
                public string EvaluationTime { get; set; }

                /// <summary>
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
