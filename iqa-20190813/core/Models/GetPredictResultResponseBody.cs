// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iqa20190813.Models
{
    public class GetPredictResultResponseBody : TeaModel {
        [NameInMap("Trace")]
        [Validation(Required=false)]
        public string Trace { get; set; }

        [NameInMap("CostTime")]
        [Validation(Required=false)]
        public long? CostTime { get; set; }

        [NameInMap("TopK")]
        [Validation(Required=false)]
        public int? TopK { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TraceTag")]
        [Validation(Required=false)]
        public string TraceTag { get; set; }

        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("Question")]
        [Validation(Required=false)]
        public string Question { get; set; }

        [NameInMap("PredictResults")]
        [Validation(Required=false)]
        public List<GetPredictResultResponseBodyPredictResults> PredictResults { get; set; }
        public class GetPredictResultResponseBodyPredictResults : TeaModel {
            [NameInMap("Answer")]
            [Validation(Required=false)]
            public string Answer { get; set; }

            [NameInMap("QuestionId")]
            [Validation(Required=false)]
            public string QuestionId { get; set; }

            [NameInMap("Rank")]
            [Validation(Required=false)]
            public int? Rank { get; set; }

            [NameInMap("Score")]
            [Validation(Required=false)]
            public float? Score { get; set; }

            [NameInMap("Question")]
            [Validation(Required=false)]
            public string Question { get; set; }

        }

    }

}
