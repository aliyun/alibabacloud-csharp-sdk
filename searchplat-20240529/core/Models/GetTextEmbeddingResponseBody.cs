// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240529.Models
{
    public class GetTextEmbeddingResponseBody : TeaModel {
        [NameInMap("latency")]
        [Validation(Required=false)]
        public int? Latency { get; set; }

        [NameInMap("request_id")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public GetTextEmbeddingResponseBodyResult Result { get; set; }
        public class GetTextEmbeddingResponseBodyResult : TeaModel {
            [NameInMap("embeddings")]
            [Validation(Required=false)]
            public List<GetTextEmbeddingResponseBodyResultEmbeddings> Embeddings { get; set; }
            public class GetTextEmbeddingResponseBodyResultEmbeddings : TeaModel {
                [NameInMap("embedding")]
                [Validation(Required=false)]
                public List<double?> Embedding { get; set; }

                [NameInMap("index")]
                [Validation(Required=false)]
                public int? Index { get; set; }

            }

        }

        [NameInMap("usage")]
        [Validation(Required=false)]
        public GetTextEmbeddingResponseBodyUsage Usage { get; set; }
        public class GetTextEmbeddingResponseBodyUsage : TeaModel {
            [NameInMap("token_count")]
            [Validation(Required=false)]
            public long? TokenCount { get; set; }

        }

    }

}
