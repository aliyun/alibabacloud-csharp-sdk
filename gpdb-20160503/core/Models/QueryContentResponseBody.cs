// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class QueryContentResponseBody : TeaModel {
        [NameInMap("EmbeddingTokens")]
        [Validation(Required=false)]
        public string EmbeddingTokens { get; set; }

        [NameInMap("Matches")]
        [Validation(Required=false)]
        public QueryContentResponseBodyMatches Matches { get; set; }
        public class QueryContentResponseBodyMatches : TeaModel {
            [NameInMap("MatchList")]
            [Validation(Required=false)]
            public List<QueryContentResponseBodyMatchesMatchList> MatchList { get; set; }
            public class QueryContentResponseBodyMatchesMatchList : TeaModel {
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("FileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                [NameInMap("FileURL")]
                [Validation(Required=false)]
                public string FileURL { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                [NameInMap("LoaderMetadata")]
                [Validation(Required=false)]
                public string LoaderMetadata { get; set; }

                [NameInMap("Metadata")]
                [Validation(Required=false)]
                public Dictionary<string, string> Metadata { get; set; }

                [NameInMap("RetrievalSource")]
                [Validation(Required=false)]
                public int? RetrievalSource { get; set; }

                [NameInMap("Score")]
                [Validation(Required=false)]
                public double? Score { get; set; }

                [NameInMap("Vector")]
                [Validation(Required=false)]
                public QueryContentResponseBodyMatchesMatchListVector Vector { get; set; }
                public class QueryContentResponseBodyMatchesMatchListVector : TeaModel {
                    [NameInMap("VectorList")]
                    [Validation(Required=false)]
                    public List<double?> VectorList { get; set; }

                }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("Usage")]
        [Validation(Required=false)]
        public QueryContentResponseBodyUsage Usage { get; set; }
        public class QueryContentResponseBodyUsage : TeaModel {
            [NameInMap("EmbeddingEntries")]
            [Validation(Required=false)]
            public string EmbeddingEntries { get; set; }

            [NameInMap("EmbeddingTokens")]
            [Validation(Required=false)]
            public string EmbeddingTokens { get; set; }

        }

    }

}
