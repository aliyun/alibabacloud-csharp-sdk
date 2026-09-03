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
        /// <para>The image retrieval input.</para>
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
        /// <para>The retrieval query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>What is the tax amount on the invoice?</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>The reranking model ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("rerankModelId")]
        [Validation(Required=false)]
        public long? RerankModelId { get; set; }

        /// <summary>
        /// <para>The name of a reranking model that the tenant has activated. If both rerankModelName and rerankModelId are specified, this parameter takes precedence.</para>
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
            /// <para>The number of candidate recall results.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("candidateCount")]
            [Validation(Required=false)]
            public int? CandidateCount { get; set; }

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
            /// <para>The weight of semantic relevance.</para>
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
            /// <para>The logical relation between conditions.</para>
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
