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
            /// <para>The URL of the file after chunking. The validity period of the URL is 2 hours. The file is in the JSONL format. Each line is in the <c>{&quot;page_content&quot;:&quot;*****&quot;, &quot;metadata&quot;: {&quot;**&quot;:&quot;***&quot;,&quot;**&quot;:&quot;***&quot;}</c> format.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://xxx/test.jsonl">http://xxx/test.jsonl</a></para>
            /// </summary>
            [NameInMap("ChunkFileUrl")]
            [Validation(Required=false)]
            public string ChunkFileUrl { get; set; }

            [NameInMap("DocumentLoaderResultFileUrl")]
            [Validation(Required=false)]
            public string DocumentLoaderResultFileUrl { get; set; }

            /// <summary>
            /// <para>The URL of the file that does not contain metadata after chunking. The validity period of the URL is 2 hours. The file is in the TXT format. Each line is a chunk. The file can be easily used for embedding.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://xxx/test.txt">http://xxx/test.txt</a></para>
            /// </summary>
            [NameInMap("PlainChunkFileUrl")]
            [Validation(Required=false)]
            public string PlainChunkFileUrl { get; set; }

        }

        /// <summary>
        /// <para>The information about the document upload job.</para>
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
            /// <para>The time when the job was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-08 16:52:04.864664</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The error message.</para>
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
            /// <para>The job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>231460f8-75dc-405e-a669-0c5204887e91</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The progress of the document upload job. Unit: %. A value of 100 indicates that the job is complete.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public int? Progress { get; set; }

            /// <summary>
            /// <para>The status of the job. Valid values: Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Success</description></item>
            /// <item><description>Failed (See the Error parameter for failure reasons.)</description></item>
            /// <item><description>Cancelling</description></item>
            /// <item><description>Cancelled</description></item>
            /// <item><description>Start</description></item>
            /// <item><description>Running</description></item>
            /// <item><description>Pending</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The time when the job was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-08 16:53:04.864664</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
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
        /// <para>The status of the operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>success</b></description></item>
        /// <item><description><b>fail</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The number of tokens that are used for document understanding or embedding.</para>
        /// </summary>
        [NameInMap("Usage")]
        [Validation(Required=false)]
        public GetUploadDocumentJobResponseBodyUsage Usage { get; set; }
        public class GetUploadDocumentJobResponseBodyUsage : TeaModel {
            /// <summary>
            /// <para>The count of embedding entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("EmbeddingEntries")]
            [Validation(Required=false)]
            public int? EmbeddingEntries { get; set; }

            /// <summary>
            /// <para>The number of tokens that are used for vectorization.</para>
            /// <remarks>
            /// <para> A token is the minimum unit for splitting text. A token can be a word, phrase, punctuation, or character.</para>
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
