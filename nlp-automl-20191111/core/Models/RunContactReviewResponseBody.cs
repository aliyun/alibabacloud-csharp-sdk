// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlp_automl20191111.Models
{
    public class RunContactReviewResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RawContractContent")]
        [Validation(Required=false)]
        public string RawContractContent { get; set; }

        [NameInMap("ContactContent")]
        [Validation(Required=false)]
        public RunContactReviewResponseBodyContactContent ContactContent { get; set; }
        public class RunContactReviewResponseBodyContactContent : TeaModel {
            [NameInMap("ReviewResults")]
            [Validation(Required=false)]
            public List<RunContactReviewResponseBodyContactContentReviewResults> ReviewResults { get; set; }
            public class RunContactReviewResponseBodyContactContentReviewResults : TeaModel {
                public string RiskLevel { get; set; }
                public string Type { get; set; }
                public List<string> Value { get; set; }
                public List<string> StartPosition { get; set; }
                public string ModificationSuggestion { get; set; }
                public string Reason { get; set; }
                public List<string> EndPosition { get; set; }
            }
            [NameInMap("StructureResults")]
            [Validation(Required=false)]
            public List<RunContactReviewResponseBodyContactContentStructureResults> StructureResults { get; set; }
            public class RunContactReviewResponseBodyContactContentStructureResults : TeaModel {
                public string Type { get; set; }
                public List<string> Value { get; set; }
                public List<string> StartPosition { get; set; }
                public string Name { get; set; }
                public List<string> EndPosition { get; set; }
            }
        };

    }

}
