// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Governance20210120.Models
{
    public class ListEvaluationScoreHistoryResponseBody : TeaModel {
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
                [NameInMap("EvaluationTime")]
                [Validation(Required=false)]
                public string EvaluationTime { get; set; }

                [NameInMap("Score")]
                [Validation(Required=false)]
                public double? Score { get; set; }

            }

        }

    }

}
