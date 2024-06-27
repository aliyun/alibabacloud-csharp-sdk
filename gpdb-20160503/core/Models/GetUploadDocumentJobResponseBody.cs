// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class GetUploadDocumentJobResponseBody : TeaModel {
        /// <summary>
        /// The chunking result.
        /// </summary>
        [NameInMap("ChunkResult")]
        [Validation(Required=false)]
        public GetUploadDocumentJobResponseBodyChunkResult ChunkResult { get; set; }
        public class GetUploadDocumentJobResponseBodyChunkResult : TeaModel {
            /// <summary>
            /// The URL of the file after chunking. The validity period of the URL is 2 hours. The file is in the JSONL format. Each line is in the `{"page_content":"*****", "metadata": {"**":"***","**":"***"}` format.
            /// </summary>
            [NameInMap("ChunkFileUrl")]
            [Validation(Required=false)]
            public string ChunkFileUrl { get; set; }

            /// <summary>
            /// The URL of the file that does not contain metadata after chunking. The validity period of the URL is 2 hours. The file is in the TXT format. Each line is a chunk. The file can be easily used for embedding.
            /// </summary>
            [NameInMap("PlainChunkFileUrl")]
            [Validation(Required=false)]
            public string PlainChunkFileUrl { get; set; }

        }

        /// <summary>
        /// The information about the document upload job.
        /// </summary>
        [NameInMap("Job")]
        [Validation(Required=false)]
        public GetUploadDocumentJobResponseBodyJob Job { get; set; }
        public class GetUploadDocumentJobResponseBodyJob : TeaModel {
            /// <summary>
            /// Indicates whether the operation is complete.
            /// </summary>
            [NameInMap("Completed")]
            [Validation(Required=false)]
            public bool? Completed { get; set; }

            /// <summary>
            /// The time when the job was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The error message.
            /// </summary>
            [NameInMap("Error")]
            [Validation(Required=false)]
            public string Error { get; set; }

            /// <summary>
            /// The job ID.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// The progress of the document upload job. Unit: %. A value of 100 indicates that the job is complete.
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public int? Progress { get; set; }

            /// <summary>
            /// The status of the job. Valid values: Valid values:
            /// 
            /// *   Success
            /// *   Failed (See the Error parameter for failure reasons.)
            /// *   Cancelling
            /// *   Cancelled
            /// *   Start
            /// *   Running
            /// *   Pending
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The time when the job was updated.
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The status of the operation. Valid values:
        /// 
        /// *   **success**
        /// *   **fail**
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The number of tokens that are used for document understanding or embedding.
        /// </summary>
        [NameInMap("Usage")]
        [Validation(Required=false)]
        public GetUploadDocumentJobResponseBodyUsage Usage { get; set; }
        public class GetUploadDocumentJobResponseBodyUsage : TeaModel {
            [NameInMap("EmbeddingEntries")]
            [Validation(Required=false)]
            public int? EmbeddingEntries { get; set; }

            /// <summary>
            /// The number of tokens that are used for vectorization.
            /// 
            /// >  A token is the minimum unit for splitting text. A token can be a word, phrase, punctuation, or character.
            /// </summary>
            [NameInMap("EmbeddingTokens")]
            [Validation(Required=false)]
            public int? EmbeddingTokens { get; set; }

        }

    }

}
