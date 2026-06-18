// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class RetrieveRequest : TeaModel {
        /// <summary>
        /// <para>The number of top-K similar text chunks to retrieve using vector retrieval. This is achieved by generating a vector representation of the query and searching the knowledge base for the K text chunks with the most similar vectors. The value must be an integer from 0 to 100. The sum of <c>DenseSimilarityTopK</c> and <c>SparseSimilarityTopK</c> must not exceed 200.</para>
        /// <para>Default value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("DenseSimilarityTopK")]
        [Validation(Required=false)]
        public int? DenseSimilarityTopK { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable reranking. For more information, see <a href="https://help.aliyun.com/document_detail/2807740.html">Knowledge base</a>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Enables reranking.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: Disables reranking.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <c>true</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableReranking")]
        [Validation(Required=false)]
        public bool? EnableReranking { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/model-studio/use-cases/rag-optimization#b7031e2ad6cji">conversational query rewriting</a>&lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/model-studio/use-cases/rag-optimization#b7031e2ad6cji">conversational query rewriting</a>.
        /// Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Enables conversational query rewriting.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: Disables conversational query rewriting.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableRewrite")]
        [Validation(Required=false)]
        public bool? EnableRewrite { get; set; }

        [NameInMap("Extra")]
        [Validation(Required=false)]
        public RetrieveRequestExtra Extra { get; set; }
        public class RetrieveRequestExtra : TeaModel {
            [NameInMap("uniqueId")]
            [Validation(Required=false)]
            public string UniqueId { get; set; }

        }

        /// <summary>
        /// <para>The URLs of images to include in the query.</para>
        /// </summary>
        [NameInMap("Images")]
        [Validation(Required=false)]
        public List<string> Images { get; set; }

        /// <summary>
        /// <para>The ID of the knowledge base. This is the <c>Data.Id</c> value returned by the <c>CreateIndex</c> operation.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Ensure the specified knowledge base exists and has not been deleted.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5pwe0mxxxx</para>
        /// </summary>
        [NameInMap("IndexId")]
        [Validation(Required=false)]
        public string IndexId { get; set; }

        /// <summary>
        /// <para>The query, which is the original user prompt. There are no limits on the length of the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>阿里云百炼平台介绍</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>The conversation history, used for &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/model-studio/use-cases/rag-optimization#b7031e2ad6cji">conversational query rewriting</a>&lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/model-studio/use-cases/rag-optimization#b7031e2ad6cji">conversational query rewriting</a>. This parameter is effective only when <c>EnableRewrite</c> is set to <c>true</c>.</para>
        /// </summary>
        [NameInMap("QueryHistory")]
        [Validation(Required=false)]
        public List<RetrieveRequestQueryHistory> QueryHistory { get; set; }
        public class RetrieveRequestQueryHistory : TeaModel {
            /// <summary>
            /// <para>The content of the message for the specified <c>role</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>代表一段文本。</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The role of the entity that sent the message.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>user</c>: Indicates that the <c>content</c> is from the end user.</para>
            /// </description></item>
            /// <item><description><para><c>assistant</c>: Indicates that the <c>content</c> is a response from the Model Studio application.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

        }

        /// <summary>
        /// <para>The reranking configurations.</para>
        /// </summary>
        [NameInMap("Rerank")]
        [Validation(Required=false)]
        public List<RetrieveRequestRerank> Rerank { get; set; }
        public class RetrieveRequestRerank : TeaModel {
            /// <summary>
            /// <para>The reranking model to use. Specifying a model here overrides the default model selected when the knowledge base was created. Valid values:</para>
            /// <para>&lt;props=&quot;china&quot;&gt;</para>
            /// <list type="bullet">
            /// <item><description><para><c>qwen3-rerank-hybrid</c>: Performs reranking by using the qwen3-rerank (hybrid) model.</para>
            /// </description></item>
            /// <item><description><para><c>qwen3-rerank</c>: Performs reranking by using the qwen3-rerank model.</para>
            /// </description></item>
            /// <item><description><para><c>gte-rerank-hybrid</c>: Performs reranking by using the gte-rerank (hybrid) model.</para>
            /// </description></item>
            /// <item><description><para><c>gte-rerank</c>: Performs reranking by using the gte-rerank model.</para>
            /// </description></item>
            /// </list>
            /// <para>&lt;props=&quot;intl&quot;&gt;</para>
            /// <list type="bullet">
            /// <item><description><para><c>gte-rerank-hybrid</c>: Performs reranking by using the gte-rerank (hybrid) model.</para>
            /// </description></item>
            /// <item><description><para><c>gte-rerank</c>: Performs reranking by using the gte-rerank model.</para>
            /// </description></item>
            /// </list>
            /// <para>If you do not specify this parameter, the model configured for the knowledge base is used.</para>
            /// <para>&lt;props=&quot;china&quot;&gt;</para>
            /// <remarks>
            /// <para>Use <c>qwen3-rerank</c> for semantic ranking only. We recommend <c>qwen3-rerank-hybrid</c> if you require both semantic ranking and text matching features for higher relevance.</para>
            /// </remarks>
            /// <para>&lt;props=&quot;intl&quot;&gt;</para>
            /// <remarks>
            /// <para>Use <c>gte-rerank</c> for semantic ranking only. We recommend <c>gte-rerank-hybrid</c> if you require both semantic ranking and text matching features for higher relevance.</para>
            /// </remarks>
            /// <para>&lt;props=&quot;china&quot;&gt;</para>
            /// <remarks>
            /// <para>The <c>gte-rerank-hybrid</c> and <c>gte-rerank</c> models are no longer updated and are not recommended for use.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>gte-rerank-hybrid</para>
            /// </summary>
            [NameInMap("ModelName")]
            [Validation(Required=false)]
            public string ModelName { get; set; }

            /// <summary>
            /// <para>&lt;props=&quot;intl&quot;&gt;</para>
            /// <para>This parameter is not yet available. Do not specify a value for it.</para>
            /// <para>&lt;props=&quot;china&quot;&gt;</para>
            /// <para>A natural language instruction to fine-tune the behavior of the reranking model.</para>
            /// <remarks>
            /// <para>Notice: </para>
            /// </remarks>
            /// <para>This parameter takes effect only when <c>RerankMode</c> is set to <c>custom</c>.</para>
            /// </summary>
            [NameInMap("RerankInstruct")]
            [Validation(Required=false)]
            public string RerankInstruct { get; set; }

            /// <summary>
            /// <para>&lt;props=&quot;china&quot;&gt;</para>
            /// <para>Specifies the instruction intervention mode for the reranking model. This mode determines the model\&quot;s scoring preference.</para>
            /// <para><b>Valid values:</b></para>
            /// <list type="bullet">
            /// <item><description><para><c>qa</c>: (Default) Q\&amp;A mode. The model assigns higher scores to candidates that directly answer the query. Recommended for Q\&amp;A scenarios.</para>
            /// </description></item>
            /// <item><description><para><c>similar</c>: Similarity mode. The model assigns higher scores to candidates with high content similarity to the query. Recommended for match-based retrieval scenarios.</para>
            /// </description></item>
            /// <item><description><para><c>custom</c>: Custom mode. The model\&quot;s ranking behavior is determined by the instructions in the <c>RerankInstruct</c> parameter.</para>
            /// </description></item>
            /// </list>
            /// <para>&lt;props=&quot;intl&quot;&gt;</para>
            /// <para>This parameter is not yet available. Do not specify a value for it.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qa</para>
            /// </summary>
            [NameInMap("RerankMode")]
            [Validation(Required=false)]
            public string RerankMode { get; set; }

        }

        /// <summary>
        /// <para>The similarity threshold for reranking. Only text chunks with a similarity score greater than this value are returned. The value must be between 0.01 and 1.00, inclusive. This parameter overrides the similarity threshold setting of the knowledge base.</para>
        /// <para>If not specified, the threshold configured for the knowledge base is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.20</para>
        /// </summary>
        [NameInMap("RerankMinScore")]
        [Validation(Required=false)]
        public float? RerankMinScore { get; set; }

        /// <summary>
        /// <para>The number of top-ranked text chunks to return after reranking. The value must be an integer from 1 to 20. Default value: 5.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("RerankTopN")]
        [Validation(Required=false)]
        public int? RerankTopN { get; set; }

        /// <summary>
        /// <para>Configuration for conversational query rewriting.</para>
        /// </summary>
        [NameInMap("Rewrite")]
        [Validation(Required=false)]
        public List<RetrieveRequestRewrite> Rewrite { get; set; }
        public class RetrieveRequestRewrite : TeaModel {
            /// <summary>
            /// <para>Specifies the model for conversational query rewriting, which automatically rewrites the original query based on the conversation context to improve retrieval results. Valid value:</para>
            /// <list type="bullet">
            /// <item><description><c>conv-rewrite-qwen-1.8b</c>: The only model currently supported for this feature.</description></item>
            /// </list>
            /// <para>If this parameter is not specified, <c>conv-rewrite-qwen-1.8b</c> is used by default.</para>
            /// 
            /// <b>Example:</b>
            /// <para>conv-rewrite-qwen-1.8b</para>
            /// </summary>
            [NameInMap("ModelName")]
            [Validation(Required=false)]
            public string ModelName { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to save the retrieval history for testing purposes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Saves the retrieval history.</para>
        /// </description></item>
        /// <item><description><para><c>false</c>: Does not save the retrieval history.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SaveRetrieverHistory")]
        [Validation(Required=false)]
        public bool? SaveRetrieverHistory { get; set; }

        /// <summary>
        /// <para>Specifies custom retrieval conditions, such as tags, to filter semantic retrieval results and exclude irrelevant information.
        /// The filtering logic is applied only when the <c>is_displayed_chunk_content</c> parameter is set to <c>true</c>. For more information, see <a href="https://help.aliyun.com/document_detail/2869641.html">SearchFilters for a knowledge base</a>.</para>
        /// </summary>
        [NameInMap("SearchFilters")]
        [Validation(Required=false)]
        public List<Dictionary<string, string>> SearchFilters { get; set; }

        /// <summary>
        /// <para>The number of top-K text chunks to retrieve using keyword retrieval. This feature finds text chunks in the knowledge base that exactly match the keywords in the query. It helps filter out irrelevant text chunks and provide more accurate results.
        /// The value must be an integer from 0 to 100.
        /// The sum of <c>DenseSimilarityTopK</c> and <c>SparseSimilarityTopK</c> must not exceed 200.</para>
        /// <para>Default value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("SparseSimilarityTopK")]
        [Validation(Required=false)]
        public int? SparseSimilarityTopK { get; set; }

    }

}
