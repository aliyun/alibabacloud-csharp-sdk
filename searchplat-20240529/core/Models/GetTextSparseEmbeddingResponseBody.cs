// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Searchplat20240529.Models
{
    public class GetTextSparseEmbeddingResponseBody : TeaModel {
        [NameInMap("latency")]
        [Validation(Required=false)]
        public int? Latency { get; set; }

        [NameInMap("request_id")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public GetTextSparseEmbeddingResponseBodyResult Result { get; set; }
        public class GetTextSparseEmbeddingResponseBodyResult : TeaModel {
            [NameInMap("sparse_embeddings")]
            [Validation(Required=false)]
            public List<GetTextSparseEmbeddingResponseBodyResultSparseEmbeddings> SparseEmbeddings { get; set; }
            public class GetTextSparseEmbeddingResponseBodyResultSparseEmbeddings : TeaModel {
                [NameInMap("embedding")]
                [Validation(Required=false)]
                public List<GetTextSparseEmbeddingResponseBodyResultSparseEmbeddingsEmbedding> Embedding { get; set; }
                public class GetTextSparseEmbeddingResponseBodyResultSparseEmbeddingsEmbedding : TeaModel {
                    [NameInMap("token")]
                    [Validation(Required=false)]
                    public string Token { get; set; }

                    [NameInMap("token_id")]
                    [Validation(Required=false)]
                    public int? TokenId { get; set; }

                    [NameInMap("weight")]
                    [Validation(Required=false)]
                    public float? Weight { get; set; }

                }

                [NameInMap("index")]
                [Validation(Required=false)]
                public int? Index { get; set; }

            }

        }

        [NameInMap("usage")]
        [Validation(Required=false)]
        public GetTextSparseEmbeddingResponseBodyUsage Usage { get; set; }
        public class GetTextSparseEmbeddingResponseBodyUsage : TeaModel {
            [NameInMap("token_count")]
            [Validation(Required=false)]
            public long? TokenCount { get; set; }

        }

    }

}
