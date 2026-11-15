// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MilvusKnowledgeBase20260604.Models
{
    public class SearchKnowledgeBaseResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;PolicyType&quot;:&quot;AccountLevelIdentityBasedPolicy&quot;,&quot;NoPermissionType&quot;:&quot;ImplicitDeny&quot;,&quot;AuthAction&quot;:&quot;milvusknowledgebase:SearchKnowledgeBase&quot;}</para>
        /// </summary>
        [NameInMap("accessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The returned status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>Optional or conditionally returned. Required when includeWiki is set to true. The cursor for the next page of evidence, which is null for the last page. Not used for legacy results pagination. Null is allowed and can be omitted. Constraints: {&quot;minLength&quot;:1,&quot;maxLength&quot;:4096}.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-opaque-next-token</para>
        /// </summary>
        [NameInMap("evidenceNextToken")]
        [Validation(Required=false)]
        public string EvidenceNextToken { get; set; }

        /// <summary>
        /// <para>Optional or conditionally returned. Returned only when includeWiki is set to true. The current page of unified and merged results. Constraints: {&quot;minItems&quot;:0,&quot;maxItems&quot;:100}.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;evidenceId&quot;:&quot;wiki_section_page_1_sec_1_rev_7&quot;,&quot;kind&quot;:&quot;wiki_section&quot;,&quot;knowledgeBaseId&quot;:&quot;example_kb&quot;,&quot;documentId&quot;:null,&quot;chunkId&quot;:null,&quot;pageId&quot;:&quot;page_1&quot;,&quot;sectionId&quot;:&quot;sec_1&quot;,&quot;entityId&quot;:null,&quot;relationId&quot;:null,&quot;revisionId&quot;:&quot;rev_7&quot;,&quot;batchId&quot;:&quot;batch_7&quot;,&quot;title&quot;:&quot;Warranty instructions&quot;,&quot;content&quot;:&quot;The warranty period for Product A is 18 months.&quot;,&quot;score&quot;:0.62,&quot;sourceRefs&quot;:[{&quot;documentId&quot;:&quot;doc_manual&quot;,&quot;chunkId&quot;:&quot;chunk_1&quot;,&quot;sourceRevisionId&quot;:&quot;source_rev_7&quot;,&quot;version&quot;:&quot;DRAFT&quot;}],&quot;sourceRefCount&quot;:1,&quot;sourceRefsTruncated&quot;:false,&quot;sourceTaskId&quot;:&quot;11111111111111111111111111111111&quot;}]</para>
        /// </summary>
        [NameInMap("evidenceResults")]
        [Validation(Required=false)]
        public List<SearchKnowledgeBaseResponseBodyEvidenceResults> EvidenceResults { get; set; }
        public class SearchKnowledgeBaseResponseBodyEvidenceResults : TeaModel {
            /// <summary>
            /// <para>Required and always returned. Null is allowed. The semantics of null values follow the field description. Null is allowed and can be omitted. Constraints: {&quot;minLength&quot;:1,&quot;maxLength&quot;:128,&quot;pattern&quot;:&quot;^[A-Za-z0-9][A-Za-z0-9_-]{0,127}$&quot;}.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("batchId")]
            [Validation(Required=false)]
            public string BatchId { get; set; }

            /// <summary>
            /// <para>Required and always returned. Null is allowed. The semantics of null values follow the field description. Null is allowed and can be omitted. Constraints: {&quot;minLength&quot;:1,&quot;maxLength&quot;:128,&quot;pattern&quot;:&quot;^[A-Za-z0-9][A-Za-z0-9_-]{0,127}$&quot;}.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("chunkId")]
            [Validation(Required=false)]
            public string ChunkId { get; set; }

            /// <summary>
            /// <para>Required and always returned. The readable evidence text. Constraints: {&quot;maxLength&quot;:65535}.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The warranty period for Product A is 18 months</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>Required and always returned. Null is allowed. The semantics of null values follow the field description. Null is allowed and can be omitted. Constraints: {&quot;minLength&quot;:1,&quot;maxLength&quot;:128,&quot;pattern&quot;:&quot;^[A-Za-z0-9][A-Za-z0-9_-]{0,127}$&quot;}.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("documentId")]
            [Validation(Required=false)]
            public string DocumentId { get; set; }

            /// <summary>
            /// <para>Required and always returned. Null is allowed. The semantics of null values follow the field description. Null is allowed and can be omitted. Constraints: {&quot;minLength&quot;:1,&quot;maxLength&quot;:128,&quot;pattern&quot;:&quot;^[A-Za-z0-9][A-Za-z0-9_-]{0,127}$&quot;}.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("entityId")]
            [Validation(Required=false)]
            public string EntityId { get; set; }

            /// <summary>
            /// <para>Required and always returned. An opaque business ID generated by the server. Ownership is validated, and arbitrary paths are not accepted. Constraints: {&quot;minLength&quot;:1,&quot;maxLength&quot;:128,&quot;pattern&quot;:&quot;^[A-Za-z0-9][A-Za-z0-9_-]{0,127}$&quot;}.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>wiki_section_page_1_sec_1_rev_7</para>
            /// </summary>
            [NameInMap("evidenceId")]
            [Validation(Required=false)]
            public string EvidenceId { get; set; }

            /// <summary>
            /// <para>Required and always returned. The actual evidence object type. Constraints: {&quot;enum&quot;:[&quot;raw&quot;,&quot;wiki_page&quot;,&quot;wiki_section&quot;,&quot;graph_fact&quot;],&quot;maxLength&quot;:64}.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>wiki_section</para>
            /// </summary>
            [NameInMap("kind")]
            [Validation(Required=false)]
            public string Kind { get; set; }

            /// <summary>
            /// <para>Required and always returned. An opaque business ID generated by the server. Ownership is validated, and arbitrary paths are not accepted. Constraints: {&quot;minLength&quot;:1,&quot;maxLength&quot;:128,&quot;pattern&quot;:&quot;^[A-Za-z0-9][A-Za-z0-9_-]{0,127}$&quot;}.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example_kb</para>
            /// </summary>
            [NameInMap("knowledgeBaseId")]
            [Validation(Required=false)]
            public string KnowledgeBaseId { get; set; }

            /// <summary>
            /// <para>Required and always returned. Null is allowed. The semantics of null values follow the field description. Null is allowed and can be omitted. Constraints: {&quot;minLength&quot;:1,&quot;maxLength&quot;:128,&quot;pattern&quot;:&quot;^[A-Za-z0-9][A-Za-z0-9_-]{0,127}$&quot;}.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>page_1</para>
            /// </summary>
            [NameInMap("pageId")]
            [Validation(Required=false)]
            public string PageId { get; set; }

            /// <summary>
            /// <para>Required and always returned. Null is allowed. The semantics of null values follow the field description. Null is allowed and can be omitted. Constraints: {&quot;minLength&quot;:1,&quot;maxLength&quot;:128,&quot;pattern&quot;:&quot;^[A-Za-z0-9][A-Za-z0-9_-]{0,127}$&quot;}.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("relationId")]
            [Validation(Required=false)]
            public string RelationId { get; set; }

            /// <summary>
            /// <para>Required and always returned. An opaque business ID generated by the server. Ownership is validated, and arbitrary paths are not accepted. Constraints: {&quot;minLength&quot;:1,&quot;maxLength&quot;:128,&quot;pattern&quot;:&quot;^[A-Za-z0-9][A-Za-z0-9_-]{0,127}$&quot;}.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example_value</para>
            /// </summary>
            [NameInMap("revisionId")]
            [Validation(Required=false)]
            public string RevisionId { get; set; }

            /// <summary>
            /// <para>Required and always returned. A finite numerical value used for unified ranking. For hybrid, it is the relevance of the existing Dealer.rerank. For rerank, it is the text and model hybrid relevance of the existing Dealer.rerank_by_model, along semanticWeight and rank features, and is not a relevance probability. minScore is applied according to the existing unified scoring rules. Can be null for non-ranked factual evidence. Null is allowed and can be omitted.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.62</para>
            /// </summary>
            [NameInMap("score")]
            [Validation(Required=false)]
            public double? Score { get; set; }

            /// <summary>
            /// <para>Required and always returned. Null is allowed. The semantics of null values follow the field description. Null is allowed and can be omitted. Constraints: {&quot;minLength&quot;:1,&quot;maxLength&quot;:128,&quot;pattern&quot;:&quot;^[A-Za-z0-9][A-Za-z0-9_-]{0,127}$&quot;}.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sec_1</para>
            /// </summary>
            [NameInMap("sectionId")]
            [Validation(Required=false)]
            public string SectionId { get; set; }

            /// <summary>
            /// <para>Required and always returned. The total number of source chunk references. Authentication is performed on the full set. Constraints: {&quot;minimum&quot;:1,&quot;maximum&quot;:9223372036854775807}.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("sourceRefCount")]
            [Validation(Required=false)]
            public long? SourceRefCount { get; set; }

            /// <summary>
            /// <para>Required and always returned. The actually supported sources. Constraints: {&quot;minItems&quot;:1,&quot;maxItems&quot;:1000}.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;documentId&quot;:&quot;doc_manual&quot;,&quot;chunkId&quot;:&quot;chunk_1&quot;,&quot;sourceRevisionId&quot;:&quot;source_rev_7&quot;,&quot;version&quot;:&quot;DRAFT&quot;,&quot;contentHash&quot;:&quot;aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa&quot;}]</para>
            /// </summary>
            [NameInMap("sourceRefs")]
            [Validation(Required=false)]
            public List<SearchKnowledgeBaseResponseBodyEvidenceResultsSourceRefs> SourceRefs { get; set; }
            public class SearchKnowledgeBaseResponseBodyEvidenceResultsSourceRefs : TeaModel {
                /// <summary>
                /// <para>Required and always returned. An opaque business ID generated by the server. Ownership is validated, and arbitrary paths are not accepted. Constraints: {&quot;minLength&quot;:1,&quot;maxLength&quot;:128,&quot;pattern&quot;:&quot;^[A-Za-z0-9][A-Za-z0-9_-]{0,127}$&quot;}.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example_value</para>
                /// </summary>
                [NameInMap("chunkId")]
                [Validation(Required=false)]
                public string ChunkId { get; set; }

                /// <summary>
                /// <para>Required and always returned. An opaque business ID generated by the server. Ownership is validated, and arbitrary paths are not accepted. Constraints: {&quot;minLength&quot;:1,&quot;maxLength&quot;:128,&quot;pattern&quot;:&quot;^[A-Za-z0-9][A-Za-z0-9_-]{0,127}$&quot;}.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example_value</para>
                /// </summary>
                [NameInMap("documentId")]
                [Validation(Required=false)]
                public string DocumentId { get; set; }

                /// <summary>
                /// <para>Optional or conditionally returned. The document name that can be returned only after authorization. Constraints: {&quot;maxLength&quot;:1024}.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example_value</para>
                /// </summary>
                [NameInMap("documentName")]
                [Validation(Required=false)]
                public string DocumentName { get; set; }

                /// <summary>
                /// <para>Optional or conditionally returned. Null is allowed. The semantics of null values follow the field description. Null is allowed and can be omitted. Constraints: {&quot;minimum&quot;:0,&quot;maximum&quot;:9223372036854775807}.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("mediaEndMs")]
                [Validation(Required=false)]
                public long? MediaEndMs { get; set; }

                /// <summary>
                /// <para>Optional or conditionally returned. Null is allowed. The semantics of null values follow the field description. Null is allowed and can be omitted. Constraints: {&quot;minimum&quot;:0,&quot;maximum&quot;:9223372036854775807}.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("mediaStartMs")]
                [Validation(Required=false)]
                public long? MediaStartMs { get; set; }

                /// <summary>
                /// <para>Optional or conditionally returned. Null is allowed. The semantics of null values follow the field description. Null is allowed and can be omitted. Constraints: {&quot;minimum&quot;:1,&quot;maximum&quot;:9223372036854775807}.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("pageNumber")]
                [Validation(Required=false)]
                public long? PageNumber { get; set; }

                /// <summary>
                /// <para>Required and always returned. An opaque business ID generated by the server. Ownership is validated, and arbitrary paths are not accepted. Constraints: {&quot;minLength&quot;:1,&quot;maxLength&quot;:128,&quot;pattern&quot;:&quot;^[A-Za-z0-9][A-Za-z0-9_-]{0,127}$&quot;}.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example_value</para>
                /// </summary>
                [NameInMap("sourceRevisionId")]
                [Validation(Required=false)]
                public string SourceRevisionId { get; set; }

                /// <summary>
                /// <para>Required and always returned. The display name of the version. Does not fall back to draft if invalid or unavailable. Constraints: {&quot;maxLength&quot;:64,&quot;pattern&quot;:&quot;^(DRAFT|LATEST_PUBLISHED|v[1-9][0-9]*)$&quot;,&quot;default&quot;:&quot;DRAFT&quot;}.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DRAFT</para>
                /// </summary>
                [NameInMap("version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <para>Required and always returned. True when a single sourceRefs contains only the first 1,000 items. You can paginate and verify by using sourceTaskId.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("sourceRefsTruncated")]
            [Validation(Required=false)]
            public bool? SourceRefsTruncated { get; set; }

            /// <summary>
            /// <para>Required and always returned. The entry for complete sources. Must be a non-null locator when sourceRefsTruncated is true. Source operation references held by artifacts or revisions remain readable, and archiving task details does not delete the source manifest. Null is allowed and can be omitted. Constraints: {&quot;minLength&quot;:32,&quot;maxLength&quot;:32,&quot;pattern&quot;:&quot;^[0-9a-f]{32}$&quot;}.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>null</para>
            /// </summary>
            [NameInMap("sourceTaskId")]
            [Validation(Required=false)]
            public string SourceTaskId { get; set; }

            /// <summary>
            /// <para>Required and always returned. The display title after authorization. Constraints: {&quot;maxLength&quot;:1024}.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Warranty instructions</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

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
        /// <para>The returned message.</para>
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
        /// <para>The number of items per page.</para>
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
        /// <para>The list of search results.</para>
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
            /// <para>The time ranges of sentence-by-sentence or paragraph-by-paragraph content within the chunk in the original media. This field is not returned for non-audio chunks.</para>
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
            /// <para>The scalar fields of the structured knowledge base. These fields are returned by their original column names and are not used for retrieval.</para>
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
            /// <para>The relevance details.</para>
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
            /// <para>The list of tags.</para>
            /// </summary>
            [NameInMap("tags")]
            [Validation(Required=false)]
            public List<string> Tags { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total count.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
