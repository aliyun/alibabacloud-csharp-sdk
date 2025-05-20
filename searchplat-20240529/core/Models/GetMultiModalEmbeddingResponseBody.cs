// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240529.Models
{
    public class GetMultiModalEmbeddingResponseBody : TeaModel {
        [NameInMap("latency")]
        [Validation(Required=false)]
        public int? Latency { get; set; }

        [NameInMap("request_id")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public GetMultiModalEmbeddingResponseBodyResult Result { get; set; }
        public class GetMultiModalEmbeddingResponseBodyResult : TeaModel {
            [NameInMap("embeddings")]
            [Validation(Required=false)]
            public List<GetMultiModalEmbeddingResponseBodyResultEmbeddings> Embeddings { get; set; }
            public class GetMultiModalEmbeddingResponseBodyResultEmbeddings : TeaModel {
                [NameInMap("embedding")]
                [Validation(Required=false)]
                public List<double?> Embedding { get; set; }

                [NameInMap("index")]
                [Validation(Required=false)]
                public long? Index { get; set; }

            }

        }

        [NameInMap("usage")]
        [Validation(Required=false)]
        public GetMultiModalEmbeddingResponseBodyUsage Usage { get; set; }
        public class GetMultiModalEmbeddingResponseBodyUsage : TeaModel {
            [NameInMap("image")]
            [Validation(Required=false)]
            public long? Image { get; set; }

            [NameInMap("token_count")]
            [Validation(Required=false)]
            public long? TokenCount { get; set; }

        }

    }

}
