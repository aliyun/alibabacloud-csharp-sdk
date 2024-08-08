// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Governance20210120.Models
{
    public class ListEvaluationResultsResponseBody : TeaModel {
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public long? AccountId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Results")]
        [Validation(Required=false)]
        public ListEvaluationResultsResponseBodyResults Results { get; set; }
        public class ListEvaluationResultsResponseBodyResults : TeaModel {
            [NameInMap("EvaluationTime")]
            [Validation(Required=false)]
            public string EvaluationTime { get; set; }

            [NameInMap("MetricResults")]
            [Validation(Required=false)]
            public List<ListEvaluationResultsResponseBodyResultsMetricResults> MetricResults { get; set; }
            public class ListEvaluationResultsResponseBodyResultsMetricResults : TeaModel {
                [NameInMap("EvaluationTime")]
                [Validation(Required=false)]
                public string EvaluationTime { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("ResourcesSummary")]
                [Validation(Required=false)]
                public ListEvaluationResultsResponseBodyResultsMetricResultsResourcesSummary ResourcesSummary { get; set; }
                public class ListEvaluationResultsResponseBodyResultsMetricResultsResourcesSummary : TeaModel {
                    [NameInMap("NonCompliant")]
                    [Validation(Required=false)]
                    public int? NonCompliant { get; set; }

                }

                [NameInMap("Result")]
                [Validation(Required=false)]
                public double? Result { get; set; }

                [NameInMap("Risk")]
                [Validation(Required=false)]
                public string Risk { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TotalScore")]
            [Validation(Required=false)]
            public double? TotalScore { get; set; }

        }

    }

}
