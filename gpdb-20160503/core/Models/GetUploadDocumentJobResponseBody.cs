// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class GetUploadDocumentJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The chunking result.</para>
        /// </summary>
        [NameInMap("ChunkResult")]
        [Validation(Required=false)]
        public GetUploadDocumentJobResponseBodyChunkResult ChunkResult { get; set; }
        public class GetUploadDocumentJobResponseBodyChunkResult : TeaModel {
            /// <summary>
            /// <para>The URL of the chunked file. The URL is valid for 2 hours. The file is in JSONL format, and each line is in the format <c>{&quot;page_content&quot;:&quot;*****&quot;, &quot;metadata&quot;: {&quot;**&quot;:&quot;***&quot;,&quot;**&quot;:&quot;***&quot;}</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://xxx/test.jsonl">http://xxx/test.jsonl</a></para>
            /// </summary>
            [NameInMap("ChunkFileUrl")]
            [Validation(Required=false)]
            public string ChunkFileUrl { get; set; }

            /// <summary>
            /// <para>The markdown result file parsed by ADBPGLoader. The URL is valid for 2 hours.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://oss.xxx/adbpg_loader_result.md">http://oss.xxx/adbpg_loader_result.md</a></para>
            /// </summary>
            [NameInMap("DocumentLoaderResultFileUrl")]
            [Validation(Required=false)]
            public string DocumentLoaderResultFileUrl { get; set; }

            /// <summary>
            /// <para>The URL of the chunked file without metadata. The URL is valid for 2 hours. The file is in plain text format, and each line represents a chunk. This file can be conveniently used for embedding.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://xxx/test.txt">http://xxx/test.txt</a></para>
            /// </summary>
            [NameInMap("PlainChunkFileUrl")]
            [Validation(Required=false)]
            public string PlainChunkFileUrl { get; set; }

        }

        /// <summary>
        /// <para>The details of the document upload task.</para>
        /// </summary>
        [NameInMap("Job")]
        [Validation(Required=false)]
        public GetUploadDocumentJobResponseBodyJob Job { get; set; }
        public class GetUploadDocumentJobResponseBodyJob : TeaModel {
            /// <summary>
            /// <para>Indicates whether the operation is complete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Completed")]
            [Validation(Required=false)]
            public bool? Completed { get; set; }

            /// <summary>
            /// <para>The time when the task was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-08 16:52:04.864664</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The error message returned when the operation encounters an exception or fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Failed to connect database.</para>
            /// </summary>
            [NameInMap("Error")]
            [Validation(Required=false)]
            public string Error { get; set; }

            /// <summary>
            /// <para>The error code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>InternalError</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>Job ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>231460f8-75dc-405e-a669-0c5204887e91</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The upload progress. This value is a percentage. A value of 100 indicates that the upload is complete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public int? Progress { get; set; }

            /// <summary>
            /// <para>The task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Success: The task is successful.</description></item>
            /// <item><description>Failed: The task failed. You can view the Error field for the failure reason.</description></item>
            /// <item><description>Cancelling: The task is being canceled.</description></item>
            /// <item><description>Cancelled: The task is canceled.</description></item>
            /// <item><description>Start: The task has started.</description></item>
            /// <item><description>Running: The task is running.</description></item>
            /// <item><description>Pending: The task is pending.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The time when the task was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-08 16:53:04.864664</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The detailed information returned by the operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABB39CC3-4488-4857-905D-2E4A051D0521</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of this operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>success</b>: The operation is successful.</description></item>
        /// <item><description><b>fail</b>: The operation failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The number of tokens or entries consumed by document understanding or embedding.</para>
        /// </summary>
        [NameInMap("Usage")]
        [Validation(Required=false)]
        public GetUploadDocumentJobResponseBodyUsage Usage { get; set; }
        public class GetUploadDocumentJobResponseBodyUsage : TeaModel {
            /// <summary>
            /// <para>The number of entries used during embedding.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("EmbeddingEntries")]
            [Validation(Required=false)]
            public int? EmbeddingEntries { get; set; }

            /// <summary>
            /// <para>The number of tokens used during embedding.</para>
            /// <remarks>
            /// <para>A token is the smallest unit into which the input text is split. A token can be a word, a phrase, a punctuation mark, or a character.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>475</para>
            /// </summary>
            [NameInMap("EmbeddingTokens")]
            [Validation(Required=false)]
            public int? EmbeddingTokens { get; set; }

        }

    }

}
