// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class GetUploadDocumentJobResponseBody : TeaModel {
        [NameInMap("ChunkResult")]
        [Validation(Required=false)]
        public GetUploadDocumentJobResponseBodyChunkResult ChunkResult { get; set; }
        public class GetUploadDocumentJobResponseBodyChunkResult : TeaModel {
            [NameInMap("ChunkFileUrl")]
            [Validation(Required=false)]
            public string ChunkFileUrl { get; set; }

            [NameInMap("PlainChunkFileUrl")]
            [Validation(Required=false)]
            public string PlainChunkFileUrl { get; set; }

        }

        [NameInMap("Job")]
        [Validation(Required=false)]
        public GetUploadDocumentJobResponseBodyJob Job { get; set; }
        public class GetUploadDocumentJobResponseBodyJob : TeaModel {
            [NameInMap("Completed")]
            [Validation(Required=false)]
            public bool? Completed { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Error")]
            [Validation(Required=false)]
            public string Error { get; set; }

            /// <summary>
            /// Job ID。
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Progress")]
            [Validation(Required=false)]
            public int? Progress { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

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
        public GetUploadDocumentJobResponseBodyUsage Usage { get; set; }
        public class GetUploadDocumentJobResponseBodyUsage : TeaModel {
            [NameInMap("EmbeddingTokens")]
            [Validation(Required=false)]
            public int? EmbeddingTokens { get; set; }

        }

    }

}
