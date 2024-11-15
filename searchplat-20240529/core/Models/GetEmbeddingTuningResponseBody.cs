// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240529.Models
{
    public class GetEmbeddingTuningResponseBody : TeaModel {
        [NameInMap("latency")]
        [Validation(Required=false)]
        public int? Latency { get; set; }

        [NameInMap("request_id")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public GetEmbeddingTuningResponseBodyResult Result { get; set; }
        public class GetEmbeddingTuningResponseBodyResult : TeaModel {
            [NameInMap("output")]
            [Validation(Required=false)]
            public List<List<float?>> Output { get; set; }

        }

        [NameInMap("usage")]
        [Validation(Required=false)]
        public GetEmbeddingTuningResponseBodyUsage Usage { get; set; }
        public class GetEmbeddingTuningResponseBodyUsage : TeaModel {
            [NameInMap("doc_count")]
            [Validation(Required=false)]
            public int? DocCount { get; set; }

        }

    }

}
