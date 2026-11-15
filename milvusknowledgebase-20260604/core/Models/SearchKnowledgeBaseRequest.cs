// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MilvusKnowledgeBase20260604.Models
{
    public class SearchKnowledgeBaseRequest : TeaModel {
        /// <summary>
        /// <para>The list of document IDs.</para>
        /// </summary>
        [NameInMap("documentIds")]
        [Validation(Required=false)]
        public List<string> DocumentIds { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the knowledge graph.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("enableKnowledgeGraph")]
        [Validation(Required=false)]
        public bool? EnableKnowledgeGraph { get; set; }

        /// <summary>
        /// <para>The evidence page token. This parameter is optional and conditionally returned. It can only be passed when includeWiki is set to true. Omit this parameter for the first evidence page, and pass the evidenceNextToken from the previous page as is for subsequent pages. The candidate pool, subject, parameters, and page size are fixed, and the token expires in 5 minutes without renewal. An expired token returns a 409 error and does not trigger an automatic re-search. The pageNumber parameter only controls the legacy results. Constraint: {&quot;minLength&quot;:1,&quot;maxLength&quot;:4096}.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example-opaque-next-token</para>
        /// </summary>
        [NameInMap("evidencePageToken")]
        [Validation(Required=false)]
        public string EvidencePageToken { get; set; }

        /// <summary>
        /// <para>The image search input.</para>
        /// </summary>
        [NameInMap("image")]
        [Validation(Required=false)]
        public SearchKnowledgeBaseRequestImage Image { get; set; }
        public class SearchKnowledgeBaseRequestImage : TeaModel {
            /// <summary>
            /// <para>The Base64-encoded image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>data:image/png;base64,iVBORw0KGgoAAA...</para>
            /// </summary>
            [NameInMap("base64")]
            [Validation(Required=false)]
            public string Base64 { get; set; }

            /// <summary>
            /// <para>The object key of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>uploaded/invoice.png</para>
            /// </summary>
            [NameInMap("objectKey")]
            [Validation(Required=false)]
            public string ObjectKey { get; set; }

            /// <summary>
            /// <para>The image URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/invoice.png">https://example.com/invoice.png</a></para>
            /// </summary>
            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to use Wiki evidence. This parameter is optional and conditionally returned, and is added for backward compatibility. Default value: false. If set to true, a unified evidenceResults field is additionally returned without disguising Wiki content as original text. Constraint: {&quot;default&quot;:false}.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("includeWiki")]
        [Validation(Required=false)]
        public bool? IncludeWiki { get; set; }

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
        /// <para>The search query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>What is the tax amount on the invoice?</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>The rerank model ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("rerankModelId")]
        [Validation(Required=false)]
        public long? RerankModelId { get; set; }

        /// <summary>
        /// <para>The name of the rerank model activated for the tenant. If both rerankModelId and this parameter are specified, this parameter takes precedence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen3-rerank</para>
        /// </summary>
        [NameInMap("rerankModelName")]
        [Validation(Required=false)]
        public string RerankModelName { get; set; }

        /// <summary>
        /// <para>The retrieval configuration.</para>
        /// </summary>
        [NameInMap("retrievalConfig")]
        [Validation(Required=false)]
        public SearchKnowledgeBaseRequestRetrievalConfig RetrievalConfig { get; set; }
        public class SearchKnowledgeBaseRequestRetrievalConfig : TeaModel {
            /// <summary>
            /// <para>The number of candidates to recall.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("candidateCount")]
            [Validation(Required=false)]
            public int? CandidateCount { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable multi-hop evidence completion. Default value: false. For pilot knowledge bases, this feature can be used on the first page of DRAFT text retrieval. The pageSize can be 5, 10, or 20, which requires a minimum candidateCount of 40, 48, or 64, respectively. When enabled, results are returned by document.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enableEvidenceCompletion")]
            [Validation(Required=false)]
            public bool? EnableEvidenceCompletion { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable query expansion.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enableQueryExpansion")]
            [Validation(Required=false)]
            public bool? EnableQueryExpansion { get; set; }

            /// <summary>
            /// <para>The minimum relevance score.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.2</para>
            /// </summary>
            [NameInMap("minScore")]
            [Validation(Required=false)]
            public float? MinScore { get; set; }

            /// <summary>
            /// <para>The weight for semantic relevance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("semanticWeight")]
            [Validation(Required=false)]
            public float? SemanticWeight { get; set; }

            /// <summary>
            /// <para>The list of translation languages.</para>
            /// </summary>
            [NameInMap("translationLanguages")]
            [Validation(Required=false)]
            public List<string> TranslationLanguages { get; set; }

        }

        /// <summary>
        /// <para>The tag filter.</para>
        /// </summary>
        [NameInMap("tagFilter")]
        [Validation(Required=false)]
        public SearchKnowledgeBaseRequestTagFilter TagFilter { get; set; }
        public class SearchKnowledgeBaseRequestTagFilter : TeaModel {
            /// <summary>
            /// <para>The list of tag conditions.</para>
            /// </summary>
            [NameInMap("conditions")]
            [Validation(Required=false)]
            public List<SearchKnowledgeBaseRequestTagFilterConditions> Conditions { get; set; }
            public class SearchKnowledgeBaseRequestTagFilterConditions : TeaModel {
                /// <summary>
                /// <para>The tag field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>category</para>
                /// </summary>
                [NameInMap("field")]
                [Validation(Required=false)]
                public string Field { get; set; }

                /// <summary>
                /// <para>The operator.</para>
                /// 
                /// <b>Example:</b>
                /// <para>in</para>
                /// </summary>
                [NameInMap("op")]
                [Validation(Required=false)]
                public string Op { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>invoice</para>
                /// </summary>
                [NameInMap("value")]
                [Validation(Required=false)]
                public object Value { get; set; }

            }

            /// <summary>
            /// <para>The condition relation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>or</para>
            /// </summary>
            [NameInMap("relation")]
            [Validation(Required=false)]
            public string Relation { get; set; }

        }

        /// <summary>
        /// <para>The knowledge base version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

    }

}
