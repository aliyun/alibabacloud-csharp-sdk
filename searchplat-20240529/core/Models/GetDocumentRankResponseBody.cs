// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240529.Models
{
    public class GetDocumentRankResponseBody : TeaModel {
        [NameInMap("latency")]
        [Validation(Required=false)]
        public int? Latency { get; set; }

        [NameInMap("request_id")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public GetDocumentRankResponseBodyResult Result { get; set; }
        public class GetDocumentRankResponseBodyResult : TeaModel {
            [NameInMap("scores")]
            [Validation(Required=false)]
            public List<GetDocumentRankResponseBodyResultScores> Scores { get; set; }
            public class GetDocumentRankResponseBodyResultScores : TeaModel {
                [NameInMap("index")]
                [Validation(Required=false)]
                public int? Index { get; set; }

                [NameInMap("score")]
                [Validation(Required=false)]
                public double? Score { get; set; }

            }

        }

        [NameInMap("usage")]
        [Validation(Required=false)]
        public GetDocumentRankResponseBodyUsage Usage { get; set; }
        public class GetDocumentRankResponseBodyUsage : TeaModel {
            [NameInMap("doc_count")]
            [Validation(Required=false)]
            public long? DocCount { get; set; }

        }

    }

}
