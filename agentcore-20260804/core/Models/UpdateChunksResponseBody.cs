// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class UpdateChunksResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>同步返回 COMPLETED 表示本次写入结束，不改变资产原有处理状态；逐项返回 SUCCEEDED 或 FAILED，允许部分成功，不保证整批原子性或并发发布的新结果继承本次修改。无需轮询。</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public UpdateChunksResponseBodyData Data { get; set; }
        public class UpdateChunksResponseBodyData : TeaModel {
            /// <summary>
            /// <para>处理目标资产。</para>
            /// 
            /// <b>Example:</b>
            /// <para>asset-001</para>
            /// </summary>
            [NameInMap("assetId")]
            [Validation(Required=false)]
            public string AssetId { get; set; }

            /// <summary>
            /// <para>UpdateChunk 或 UpdateChunks 返回的逐项结果。同步启停直接返回最终结果；异步内容编辑返回受理结果，幂等重放返回已记录的请求结果。文档当前状态通过 GetAsset 查询，GetAsset 不返回此字段。逐项结果不由接口顶层 success 表示。</para>
            /// </summary>
            [NameInMap("chunkUpdate")]
            [Validation(Required=false)]
            public UpdateChunksResponseBodyDataChunkUpdate ChunkUpdate { get; set; }
            public class UpdateChunksResponseBodyDataChunkUpdate : TeaModel {
                /// <summary>
                /// <para>仅异步内容编辑返回原 UpdateChunk 的 clientToken，用于幂等重试；GetAsset 不接收或返回 clientToken。纯启停不创建异步回执。同一资产内不同参数复用同 token 返回 IdempotencyConflict。</para>
                /// 
                /// <b>Example:</b>
                /// <para>chunk-update-001</para>
                /// </summary>
                [NameInMap("clientToken")]
                [Validation(Required=false)]
                public string ClientToken { get; set; }

                /// <summary>
                /// <para>预留的幂等结果保留截止时间，当前未输出；不作为文档状态查询或自动重试的依据。</para>
                /// 
                /// <b>Example:</b>
                /// <para>2026-11-03T02:05:00Z</para>
                /// </summary>
                [NameInMap("expiresAt")]
                [Validation(Required=false)]
                public string ExpiresAt { get; set; }

                /// <summary>
                /// <para>本次 FAILED 项数量；异步内容编辑仍为 ACCEPTED 时，不能将 0 视为修改成功。</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("failedCount")]
                [Validation(Required=false)]
                public int? FailedCount { get; set; }

                /// <summary>
                /// <para>本次 UpdateChunk 或 UpdateChunks 的逐项结果。纯启停同步返回 SUCCEEDED/FAILED，批量允许部分成功；内容编辑先返回 ACCEPTED，幂等重放可返回已记录的处理结果。当前文档是否完成通过 GetAsset 的 status 判断。逐项结果与顶层 success 独立。</para>
                /// </summary>
                [NameInMap("results")]
                [Validation(Required=false)]
                public List<UpdateChunksResponseBodyDataChunkUpdateResults> Results { get; set; }
                public class UpdateChunksResponseBodyDataChunkUpdateResults : TeaModel {
                    /// <summary>
                    /// <para>本次修改的目标序号。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("chunkSeq")]
                    [Validation(Required=false)]
                    public int? ChunkSeq { get; set; }

                    /// <summary>
                    /// <para>失败时的脱敏原因；不包含内部任务、执行或物理存储标识。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>目标 Chunk 不存在。</para>
                    /// </summary>
                    [NameInMap("failureReason")]
                    [Validation(Required=false)]
                    public string FailureReason { get; set; }

                    /// <summary>
                    /// <para>ACCEPTED 表示内容编辑已受理但未完成；SUCCEEDED 表示纯启停已写入请求开始确定的目标或内容编辑已发布；不承诺并发发布的新结果继承启停。FAILED 表示该项未完成。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ACCEPTED</para>
                    /// </summary>
                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <para>仅终态返回：SUCCEEDED 为 true，FAILED 为 false；ACCEPTED 时不返回，不能将已受理当成写入成功。与表示请求受理或查询成功的接口顶层 success 独立。</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("success")]
                    [Validation(Required=false)]
                    public bool? Success { get; set; }

                }

                /// <summary>
                /// <para>本次提交的 Chunk 数量；UpdateChunk 为 1，UpdateChunks 为 1 至 100。</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("totalCount")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

            }

            /// <summary>
            /// <para>目标知识库。</para>
            /// 
            /// <b>Example:</b>
            /// <para>kb-001</para>
            /// </summary>
            [NameInMap("knowledgeBaseId")]
            [Validation(Required=false)]
            public string KnowledgeBaseId { get; set; }

            /// <summary>
            /// <para>当前处理的脱敏错误摘要。</para>
            /// </summary>
            [NameInMap("lastError")]
            [Validation(Required=false)]
            public UpdateChunksResponseBodyDataLastError LastError { get; set; }
            public class UpdateChunksResponseBodyDataLastError : TeaModel {
                /// <summary>
                /// <para>稳定的产品错误码；不返回内部任务标识、堆栈或存储地址。</para>
                /// 
                /// <b>Example:</b>
                /// <para>ProcessingFailed</para>
                /// </summary>
                [NameInMap("code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// <para>可向用户展示的脱敏错误摘要。</para>
                /// 
                /// <b>Example:</b>
                /// <para>文件解析失败。</para>
                /// </summary>
                [NameInMap("message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

            /// <summary>
            /// <para>考虑禁用和墓碑后的已发布结果可用性。</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("publishedResultAvailable")]
            [Validation(Required=false)]
            public bool? PublishedResultAvailable { get; set; }

            /// <summary>
            /// <para>UpdateChunk 或 UpdateChunks 的受理或执行结果；同步 Chunk 启停响应的 COMPLETED 仅表示本次写入结束，不改变资产原处理状态。异步内容编辑的受理和幂等重放结果不代表文档当前状态，文档状态通过 GetAsset 查询。</para>
            /// 
            /// <b>Example:</b>
            /// <para>PENDING</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>ISO 8601 UTC 时间。</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-27T02:05:00Z</para>
            /// </summary>
            [NameInMap("updatedAt")]
            [Validation(Required=false)]
            public string UpdatedAt { get; set; }

            /// <summary>
            /// <para>目标工作空间。</para>
            /// 
            /// <b>Example:</b>
            /// <para>ws-001</para>
            /// </summary>
            [NameInMap("workspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>true 表示请求已处理，不表示每一项都成功；检查 results 和 failedCount。令牌过期或资源状态等整次拒绝时为 false。</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
