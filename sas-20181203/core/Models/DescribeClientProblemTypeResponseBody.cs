// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeClientProblemTypeResponseBody : TeaModel {
        [NameInMap("Count")]
        [Validation(Required=false)]
        public int? Count { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ProblemTypes")]
        [Validation(Required=false)]
        public List<DescribeClientProblemTypeResponseBodyProblemTypes> ProblemTypes { get; set; }
        public class DescribeClientProblemTypeResponseBodyProblemTypes : TeaModel {
            [NameInMap("problemDetail")]
            [Validation(Required=false)]
            public string ProblemDetail { get; set; }

            [NameInMap("problemId")]
            [Validation(Required=false)]
            public string ProblemId { get; set; }

            [NameInMap("problemType")]
            [Validation(Required=false)]
            public string ProblemType { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
