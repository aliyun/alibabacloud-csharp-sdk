// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MilvusKnowledgeBase20260604.Models
{
    public class SearchKnowledgeBaseResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the access denial due to a permission verification failure.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;PolicyType&quot;:&quot;AccountLevelIdentityBasedPolicy&quot;,&quot;NoPermissionType&quot;:&quot;ImplicitDeny&quot;,&quot;AuthAction&quot;:&quot;milvusknowledgebase:SearchKnowledgeBase&quot;}</para>
        /// </summary>
        [NameInMap("accessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The return code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The return message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("pageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The query labels.</para>
        /// </summary>
        [NameInMap("queryLabels")]
        [Validation(Required=false)]
        public List<string> QueryLabels { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FCC42-90DE-56D3-A10D-3C06995DED17</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of retrieval results.</para>
        /// </summary>
        [NameInMap("results")]
        [Validation(Required=false)]
        public List<SearchKnowledgeBaseResponseBodyResults> Results { get; set; }
        public class SearchKnowledgeBaseResponseBodyResults : TeaModel {
            /// <summary>
            /// <para>The chunk ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7f0de3e041322a1d</para>
            /// </summary>
            [NameInMap("chunkId")]
            [Validation(Required=false)]
            public string ChunkId { get; set; }

            /// <summary>
            /// <para>The chunk content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Tax amount 1.59</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The content type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>table</para>
            /// </summary>
            [NameInMap("contentType")]
            [Validation(Required=false)]
            public string ContentType { get; set; }

            /// <summary>
            /// <para>The document ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>539ddb688fe811f182f637422a0713b5</para>
            /// </summary>
            [NameInMap("documentId")]
            [Validation(Required=false)]
            public string DocumentId { get; set; }

            /// <summary>
            /// <para>The document name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>invoice.pdf</para>
            /// </summary>
            [NameInMap("documentName")]
            [Validation(Required=false)]
            public string DocumentName { get; set; }

            /// <summary>
            /// <para>The list of associated images.</para>
            /// </summary>
            [NameInMap("images")]
            [Validation(Required=false)]
            public List<SearchKnowledgeBaseResponseBodyResultsImages> Images { get; set; }
            public class SearchKnowledgeBaseResponseBodyResultsImages : TeaModel {
                /// <summary>
                /// <para>The image ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>kd-620ad908ec651-41253795bafd7a1c</para>
                /// </summary>
                [NameInMap("imageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// <para>The temporary access URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://example.com/signed-image">https://example.com/signed-image</a></para>
                /// </summary>
                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            /// <summary>
            /// <para>The knowledge base ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kd-xxxxxxxxxx</para>
            /// </summary>
            [NameInMap("knowledgeBaseId")]
            [Validation(Required=false)]
            public string KnowledgeBaseId { get; set; }

            /// <summary>
            /// <para>The list of document locations.</para>
            /// </summary>
            [NameInMap("locations")]
            [Validation(Required=false)]
            public List<SearchKnowledgeBaseResponseBodyResultsLocations> Locations { get; set; }
            public class SearchKnowledgeBaseResponseBodyResultsLocations : TeaModel {
                /// <summary>
                /// <para>The bottom boundary.</para>
                /// 
                /// <b>Example:</b>
                /// <para>364</para>
                /// </summary>
                [NameInMap("bottom")]
                [Validation(Required=false)]
                public int? Bottom { get; set; }

                /// <summary>
                /// <para>The left boundary.</para>
                /// 
                /// <b>Example:</b>
                /// <para>13</para>
                /// </summary>
                [NameInMap("left")]
                [Validation(Required=false)]
                public int? Left { get; set; }

                /// <summary>
                /// <para>The page number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("pageNumber")]
                [Validation(Required=false)]
                public int? PageNumber { get; set; }

                /// <summary>
                /// <para>The right boundary.</para>
                /// 
                /// <b>Example:</b>
                /// <para>566</para>
                /// </summary>
                [NameInMap("right")]
                [Validation(Required=false)]
                public int? Right { get; set; }

                /// <summary>
                /// <para>The top boundary.</para>
                /// 
                /// <b>Example:</b>
                /// <para>12</para>
                /// </summary>
                [NameInMap("top")]
                [Validation(Required=false)]
                public int? Top { get; set; }

            }

            /// <summary>
            /// <para>The end time of the audio or video chunk in the original media, in milliseconds. This field is not returned for non-media chunks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8400</para>
            /// </summary>
            [NameInMap("mediaEndMs")]
            [Validation(Required=false)]
            public long? MediaEndMs { get; set; }

            /// <summary>
            /// <para>The start time of the audio or video chunk in the original media, in milliseconds. This field is not returned for non-media chunks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1250</para>
            /// </summary>
            [NameInMap("mediaStartMs")]
            [Validation(Required=false)]
            public long? MediaStartMs { get; set; }

            /// <summary>
            /// <para>The time ranges of sentence-level or paragraph-level content within the chunk in the original media. This field is not returned for non-audio chunks.</para>
            /// </summary>
            [NameInMap("mediaTimeline")]
            [Validation(Required=false)]
            public List<SearchKnowledgeBaseResponseBodyResultsMediaTimeline> MediaTimeline { get; set; }
            public class SearchKnowledgeBaseResponseBodyResultsMediaTimeline : TeaModel {
                /// <summary>
                /// <para>The end time of the segment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4200</para>
                /// </summary>
                [NameInMap("endMs")]
                [Validation(Required=false)]
                public long? EndMs { get; set; }

                /// <summary>
                /// <para>The start time of the segment.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1250</para>
                /// </summary>
                [NameInMap("startMs")]
                [Validation(Required=false)]
                public long? StartMs { get; set; }

                /// <summary>
                /// <para>The segment text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The first sentence</para>
                /// </summary>
                [NameInMap("text")]
                [Validation(Required=false)]
                public string Text { get; set; }

            }

            /// <summary>
            /// <para>The parent chunk ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>parent-chunk-id</para>
            /// </summary>
            [NameInMap("parentChunkId")]
            [Validation(Required=false)]
            public string ParentChunkId { get; set; }

            /// <summary>
            /// <para>The scalar columns of the structured knowledge base. The columns are returned by their original column names and are not used in retrieval.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;question&quot;:&quot;How do I reset it?&quot;,&quot;category&quot;:&quot;account&quot;}</para>
            /// </summary>
            [NameInMap("scalarFields")]
            [Validation(Required=false)]
            public object ScalarFields { get; set; }

            /// <summary>
            /// <para>The overall relevance score.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.26136884</para>
            /// </summary>
            [NameInMap("score")]
            [Validation(Required=false)]
            public float? Score { get; set; }

            /// <summary>
            /// <para>The relevance score details.</para>
            /// </summary>
            [NameInMap("scoreDetails")]
            [Validation(Required=false)]
            public SearchKnowledgeBaseResponseBodyResultsScoreDetails ScoreDetails { get; set; }
            public class SearchKnowledgeBaseResponseBodyResultsScoreDetails : TeaModel {
                /// <summary>
                /// <para>The keyword relevance score.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.0000000014285714</para>
                /// </summary>
                [NameInMap("keywordScore")]
                [Validation(Required=false)]
                public float? KeywordScore { get; set; }

                /// <summary>
                /// <para>The semantic relevance score.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.5227377</para>
                /// </summary>
                [NameInMap("semanticScore")]
                [Validation(Required=false)]
                public float? SemanticScore { get; set; }

            }

            /// <summary>
            /// <para>The list of labels.</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<string> Tags { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
