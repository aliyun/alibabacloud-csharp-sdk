// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class UpdateChunkResponseBody : TeaModel {
        /// <summary>
        /// <para>The stable result code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>For pure enable or disable operations, COMPLETED and the final state of each item are synchronously returned, indicating that the current write operation is complete. This does not change the original processing status of the asset or guarantee that concurrently published new results inherit the modifications. Polling is not required. When content is included, poll the current status of GetAsset until it reaches COMPLETED or FAILED. For failure reasons, see lastError. GetAsset does not accept clientToken or return chunkUpdate. ACCEPTED does not indicate completion.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public UpdateChunkResponseBodyData Data { get; set; }
        public class UpdateChunkResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The target asset for processing.</para>
            /// 
            /// <b>Example:</b>
            /// <para>asset-001</para>
            /// </summary>
            [NameInMap("assetId")]
            [Validation(Required=false)]
            public string AssetId { get; set; }

            /// <summary>
            /// <para>The itemized results returned by UpdateChunk or UpdateChunks. Synchronous enable or disable operations directly return the final results. Asynchronous content edits return the acceptance results, and idempotent replays return the recorded request results. You can query the current status of the document by calling GetAsset. GetAsset does not return this field. The itemized results are not represented by the top-level success parameter of the API operation.</para>
            /// </summary>
            [NameInMap("chunkUpdate")]
            [Validation(Required=false)]
            public UpdateChunkResponseBodyDataChunkUpdate ChunkUpdate { get; set; }
            public class UpdateChunkResponseBodyDataChunkUpdate : TeaModel {
                /// <summary>
                /// <para>Only asynchronous content edits return the clientToken of the original UpdateChunk for idempotent retries. GetAsset does not accept or return the clientToken. Pure enable or disable operations do not create asynchronous receipts. If the same token is reused with different parameters within the same asset, IdempotencyConflict is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>chunk-update-001</para>
                /// </summary>
                [NameInMap("clientToken")]
                [Validation(Required=false)]
                public string ClientToken { get; set; }

                /// <summary>
                /// <para>The reserved expiration time for idempotent result retention. This field is not currently outputted and is not used as a basis for document status queries or automatic retries.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-11-03T02:05:00Z</para>
                /// </summary>
                [NameInMap("expiresAt")]
                [Validation(Required=false)]
                public string ExpiresAt { get; set; }

                /// <summary>
                /// <para>The number of FAILED items in this request. When asynchronous content edits are still in the ACCEPTED state, a value of 0 does not indicate a successful modification.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("failedCount")]
                [Validation(Required=false)]
                public int? FailedCount { get; set; }

                /// <summary>
                /// <para>The itemized results of the current UpdateChunk or UpdateChunks request. Synchronous enable or disable operations return SUCCEEDED or FAILED, and batch operations allow partial success. Content edits first return ACCEPTED, and idempotent replays may return recorded processing results. You can determine whether the current document is completed by checking the status returned by GetAsset. The itemized results are independent of the top-level success parameter.</para>
                /// </summary>
                [NameInMap("results")]
                [Validation(Required=false)]
                public List<UpdateChunkResponseBodyDataChunkUpdateResults> Results { get; set; }
                public class UpdateChunkResponseBodyDataChunkUpdateResults : TeaModel {
                    /// <summary>
                    /// <para>The target sequence number for this modification.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("chunkSeq")]
                    [Validation(Required=false)]
                    public int? ChunkSeq { get; set; }

                    /// <summary>
                    /// <para>The desensitized reason for the failure. It does not contain internal task, execution, or physical storage identifiers.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The target chunk does not exist</para>
                    /// </summary>
                    [NameInMap("failureReason")]
                    [Validation(Required=false)]
                    public string FailureReason { get; set; }

                    /// <summary>
                    /// <para>ACCEPTED indicates that the content edit is accepted but not completed. SUCCEEDED indicates that the pure enable or disable operation has been written to the target determined at the beginning of the request, or the content edit has been published. It is not guaranteed that concurrently published new results will inherit the enable or disable operations. FAILED indicates that the item is not completed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ACCEPTED</para>
                    /// </summary>
                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <para>Returned only in the final state. The value is true for SUCCEEDED and false for FAILED. This parameter is not returned for ACCEPTED. An accepted state cannot be treated as a successful write. This parameter is independent of the top-level success parameter, which indicates request acceptance or query success.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("success")]
                    [Validation(Required=false)]
                    public bool? Success { get; set; }

                }

                /// <summary>
                /// <para>The number of chunks submitted in this request. The value is 1 for UpdateChunk, and 1 to 100 for UpdateChunks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("totalCount")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

            }

            /// <summary>
            /// <para>The target knowledge base.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kb-001</para>
            /// </summary>
            [NameInMap("knowledgeBaseId")]
            [Validation(Required=false)]
            public string KnowledgeBaseId { get; set; }

            /// <summary>
            /// <para>The desensitized error summary of the current processing.</para>
            /// </summary>
            [NameInMap("lastError")]
            [Validation(Required=false)]
            public UpdateChunkResponseBodyDataLastError LastError { get; set; }
            public class UpdateChunkResponseBodyDataLastError : TeaModel {
                /// <summary>
                /// <para>The stable product error code. It does not return internal task identifiers, stack traces, or storage addresses.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ProcessingFailed</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>The desensitized error summary that can be displayed to users.</para>
                /// 
                /// <b>Example:</b>
                /// <para>File parsing failed</para>
                /// </summary>
                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

            /// <summary>
            /// <para>The availability of the published result, considering disabled states and tombstones.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("publishedResultAvailable")]
            [Validation(Required=false)]
            public bool? PublishedResultAvailable { get; set; }

            /// <summary>
            /// <para>The acceptance or execution result of UpdateChunk or UpdateChunks. The COMPLETED status in the synchronous chunk enable or disable response only indicates that the current write operation is complete, and does not change the original processing status of the asset. The acceptance and idempotent replay results of asynchronous content edits do not represent the current status of the document. You can query the document status by calling GetAsset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>PENDING</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The update time in ISO 8601 UTC format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-27T02:05:00Z</para>
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            /// <summary>
            /// <para>The target workspace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ws-001</para>
            /// </summary>
            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        /// <summary>
        /// <para>The actual HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The desensitized result description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request tracking ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01A00000-0000-0000-0000-000000000001</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Specifies whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request is successfully processed or accepted. For pure enable or disable operations, the final result of each item is checked. For content edits, you must wait for the asynchronous final state.</description></item>
        /// <item><description>false: The entire request is rejected due to token expiration, authentication failure, or resource status issues.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
