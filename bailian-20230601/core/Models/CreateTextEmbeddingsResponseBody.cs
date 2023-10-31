// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20230601.Models
{
    public class CreateTextEmbeddingsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateTextEmbeddingsResponseBodyData Data { get; set; }
        public class CreateTextEmbeddingsResponseBodyData : TeaModel {
            [NameInMap("Embeddings")]
            [Validation(Required=false)]
            public List<CreateTextEmbeddingsResponseBodyDataEmbeddings> Embeddings { get; set; }
            public class CreateTextEmbeddingsResponseBodyDataEmbeddings : TeaModel {
                [NameInMap("Embedding")]
                [Validation(Required=false)]
                public List<double?> Embedding { get; set; }

                [NameInMap("TextIndex")]
                [Validation(Required=false)]
                public int? TextIndex { get; set; }

            }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public string HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
