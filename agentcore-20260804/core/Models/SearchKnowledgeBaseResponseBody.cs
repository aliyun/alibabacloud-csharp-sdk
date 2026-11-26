// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class SearchKnowledgeBaseResponseBody : TeaModel {
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
        /// <para>The published results that the caller has permission to access.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public SearchKnowledgeBaseResponseBodyData Data { get; set; }
        public class SearchKnowledgeBaseResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The final authorized and published candidates. The number of candidates may be less than topK. If a backend failure occurs, an error is returned instead of a fake success with empty results.</para>
            /// </summary>
            [NameInMap("chunks")]
            [Validation(Required=false)]
            public List<SearchKnowledgeBaseResponseBodyDataChunks> Chunks { get; set; }
            public class SearchKnowledgeBaseResponseBodyDataChunks : TeaModel {
                /// <summary>
                /// <para>The asset to which the matched chunk belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>asset-001</para>
                /// </summary>
                [NameInMap("assetId")]
                [Validation(Required=false)]
                public string AssetId { get; set; }

                /// <summary>
                /// <para>The display name of the matched asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>guide.pdf</para>
                /// </summary>
                [NameInMap("assetName")]
                [Validation(Required=false)]
                public string AssetName { get; set; }

                /// <summary>
                /// <para>The 1-based logical sequence number within the published asset.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("chunkSeq")]
                [Validation(Required=false)]
                public int? ChunkSeq { get; set; }

                /// <summary>
                /// <para>The opaque token passed back as-is during updates. It is verified against the current published results at the start of the request, and an error is returned if it has expired. It does not follow newly published concurrent results after a simple start-stop operation, and must not be parsed or generated manually.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ct-0123456789abcdef0123456789abcdef0123456789abcdef0123456789abcdef</para>
                /// </summary>
                [NameInMap("chunkToken")]
                [Validation(Required=false)]
                public string ChunkToken { get; set; }

                /// <summary>
                /// <para>The chunk content that has passed the permission, enablement status, and published version verifications.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Welcome to the product</para>
                /// </summary>
                [NameInMap("content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The file name that matches the published original file. It is not affected by changes to the asset display name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>guide.pdf</para>
                /// </summary>
                [NameInMap("fileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                /// <summary>
                /// <para>The ranking score interpreted by scoreType. Normalization is not guaranteed, and scores cannot be directly compared across different modes or queries.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0325</para>
                /// </summary>
                [NameInMap("score")]
                [Validation(Required=false)]
                public double? Score { get; set; }

                /// <summary>
                /// <para>The detailed normalized scores for the vector, keyword, fusion, and reranking stages. Stages that are not involved are not returned.</para>
                /// </summary>
                [NameInMap("scores")]
                [Validation(Required=false)]
                public SearchKnowledgeBaseResponseBodyDataChunksScores Scores { get; set; }
                public class SearchKnowledgeBaseResponseBodyDataChunksScores : TeaModel {
                    /// <summary>
                    /// <para>The normalized score for the fusion stage. This field is not returned if the stage is not involved.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.85</para>
                    /// </summary>
                    [NameInMap("fusion")]
                    [Validation(Required=false)]
                    public double? Fusion { get; set; }

                    /// <summary>
                    /// <para>The normalized score for the keyword channel. This field is not returned if the stage is not involved.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.8</para>
                    /// </summary>
                    [NameInMap("keyword")]
                    [Validation(Required=false)]
                    public double? Keyword { get; set; }

                    /// <summary>
                    /// <para>The normalized score for the reranking stage. This field is not returned if the stage is not involved.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.92</para>
                    /// </summary>
                    [NameInMap("rerank")]
                    [Validation(Required=false)]
                    public double? Rerank { get; set; }

                    /// <summary>
                    /// <para>The normalized score for the vector channel. This field is not returned if the stage is not involved.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.9</para>
                    /// </summary>
                    [NameInMap("vector")]
                    [Validation(Required=false)]
                    public double? Vector { get; set; }

                }

                /// <summary>
                /// <para>The source location, such as p.3 for a PDF page, s.2 for a PPT slide, or a worksheet name. This field is not returned if the location cannot be mapped.</para>
                /// 
                /// <b>Example:</b>
                /// <para>p.3</para>
                /// </summary>
                [NameInMap("sourceLocation")]
                [Validation(Required=false)]
                public string SourceLocation { get; set; }

                /// <summary>
                /// <para>The title hierarchy to which the matched chunk belongs. This field is not returned if the hierarchy cannot be located.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Product Guide &gt; Configuration</para>
                /// </summary>
                [NameInMap("titlePath")]
                [Validation(Required=false)]
                public string TitlePath { get; set; }

            }

            /// <summary>
            /// <para>The actual final ranking stage, such as keyword, vector, rrf, weighted, or rerank. This does not replace the detailed scores.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rrf</para>
            /// </summary>
            [NameInMap("scoreType")]
            [Validation(Required=false)]
            public string ScoreType { get; set; }

            /// <summary>
            /// <para>The server-side processing duration for the current knowledge base retrieval, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>120</para>
            /// </summary>
            [NameInMap("timeSpent")]
            [Validation(Required=false)]
            public long? TimeSpent { get; set; }

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
        /// <para>The description of the data masking result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request trace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01A00000-0000-0000-0000-000000000001</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
