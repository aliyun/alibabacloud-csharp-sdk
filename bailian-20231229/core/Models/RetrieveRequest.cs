// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class RetrieveRequest : TeaModel {
        /// <summary>
        /// <para>The top K value for AISearch. The system generates a vector for the input text and retrieves the top K text chunks in the knowledge base that are most similar to the vector representation. Valid values: 0 to 100.
        /// The sum of DenseSimilarityTopK and SparseSimilarityTopK must be less than or equal to 200.</para>
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
        /// <item><description>true: Enabled.</description></item>
        /// <item><description>false: Disabled.</description></item>
        /// </list>
        /// <para>Default value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableReranking")]
        [Validation(Required=false)]
        public bool? EnableReranking { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable &lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/model-studio/use-cases/rag-optimization#b7031e2ad6cji">multi-turn conversation rewriting</a>&lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/model-studio/use-cases/rag-optimization#b7031e2ad6cji">multi-turn conversation rewriting</a>.
        /// Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Enabled.</description></item>
        /// <item><description>false: Disabled.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
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
        /// <para>The URLs of the images passed in the query.</para>
        /// </summary>
        [NameInMap("Images")]
        [Validation(Required=false)]
        public List<string> Images { get; set; }

        /// <summary>
        /// <para>The ID of the knowledge base, which is the Data.Id returned by the CreateIndex operation.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Make sure that the corresponding knowledge base is created and not deleted.</description></item>
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
        /// <para>The input text, which is the original input prompt. The length and characters of Query are not limited.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Introduction to Alibaba Cloud Model Studio</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;<a href="https://help.aliyun.com/model-studio/use-cases/rag-optimization#b7031e2ad6cji">Multi-turn conversation rewriting</a>&lt;props=&quot;intl&quot;&gt;<a href="https://www.alibabacloud.com/help/model-studio/use-cases/rag-optimization#b7031e2ad6cji">Multi-turn conversation rewriting</a> allows you to pass in your own managed conversation history. This parameter takes effect only when EnableRewrite is set to <b>true</b>. Otherwise, it does not take effect even if you specify it.</para>
        /// </summary>
        [NameInMap("QueryHistory")]
        [Validation(Required=false)]
        public List<RetrieveRequestQueryHistory> QueryHistory { get; set; }
        public class RetrieveRequestQueryHistory : TeaModel {
            /// <summary>
            /// <para>The question or answer content of the corresponding role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>A piece of text</para>
            /// </summary>
            [NameInMap("content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The role.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>user: If this role is passed, content indicates the text that you input to the Alibaba Cloud Model Studio application.</description></item>
            /// <item><description>assistant: If this role is passed, content indicates the reply from the Alibaba Cloud Model Studio application.</description></item>
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
        /// <para>The reranking configuration.</para>
        /// </summary>
        [NameInMap("Rerank")]
        [Validation(Required=false)]
        public List<RetrieveRequestRerank> Rerank { get; set; }
        public class RetrieveRequestRerank : TeaModel {
            /// <summary>
            /// <para>The specified reranking model. The value specified here overrides the reranking model selected when the knowledge base was created. Valid values:</para>
            /// <para>&lt;props=&quot;china&quot;&gt;</para>
            /// <list type="bullet">
            /// <item><description>qwen3-rerank-hybrid: qwen3-rerank (hybrid) reranking.</description></item>
            /// <item><description>qwen3-rerank: qwen3-rerank reranking.</description></item>
            /// <item><description>gte-rerank-hybrid: gte-rerank (hybrid) reranking.</description></item>
            /// <item><description>gte-rerank: gte-rerank reranking.</description></item>
            /// </list>
            /// <para>&lt;props=&quot;intl&quot;&gt;</para>
            /// <list type="bullet">
            /// <item><description>gte-rerank-hybrid: Official reranking.</description></item>
            /// <item><description>gte-rerank: gte-rerank reranking.</description></item>
            /// </list>
            /// <para>Default value: null. The reranking model selected when the knowledge base was created is used.</para>
            /// <para>&lt;props=&quot;china&quot;&gt;</para>
            /// <remarks>
            /// <para>If you only need semantic reranking, use qwen3-rerank. If you need both semantic reranking and text matching features to ensure relevance, use qwen3-rerank-hybrid.</para>
            /// </remarks>
            /// <para>&lt;props=&quot;intl&quot;&gt;</para>
            /// <remarks>
            /// <para>If you only need semantic reranking, use gte-rerank. If you need both semantic reranking and text matching features to ensure relevance, use gte-rerank-hybrid.</para>
            /// </remarks>
            /// <para>&lt;props=&quot;china&quot;&gt;</para>
            /// <remarks>
            /// <para>gte-rerank-hybrid and gte-rerank will no longer be updated and are not recommended.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>gte-rerank-hybrid</para>
            /// </summary>
            [NameInMap("ModelName")]
            [Validation(Required=false)]
            public string ModelName { get; set; }

            /// <summary>
            /// <para>&lt;props=&quot;intl&quot;&gt;This parameter is not available. Do not specify this parameter.</para>
            /// <para>&lt;props=&quot;china&quot;&gt;A natural language instruction used to fine-tune the behavior of the reranking model.
            /// <notice>This parameter takes effect only when rerank_mode is set to custom.</notice></para>
            /// 
            /// <b>Example:</b>
            /// <para>Given a web search query, retrieve relevant passages that answer the query.</para>
            /// </summary>
            [NameInMap("RerankInstruct")]
            [Validation(Required=false)]
            public string RerankInstruct { get; set; }

            /// <summary>
            /// <para>&lt;props=&quot;china&quot;&gt;
            /// The instruction intervention mode of the reranking model, which determines its scoring preference.</para>
            /// <para><b>Valid values:</b></para>
            /// <list type="bullet">
            /// <item><description><para><b>qa</b>: (Default) Q&amp;A mode. The model tends to assign higher scores to candidates that can directly answer the query. Recommended for Q&amp;A scenarios.</para>
            /// </description></item>
            /// <item><description><para><b>similar</b>: Similarity mode. The model tends to assign higher scores to candidates that are highly consistent with the query content. Recommended for matching and retrieval scenarios.</para>
            /// </description></item>
            /// <item><description><para><b>custom</b>: Custom mode. The reranking behavior of the model is determined by the instruction in the rerank_instruct parameter.</para>
            /// </description></item>
            /// </list>
            /// <para>&lt;props=&quot;intl&quot;&gt;This parameter is not available. Do not specify this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qa</para>
            /// </summary>
            [NameInMap("RerankMode")]
            [Validation(Required=false)]
            public string RerankMode { get; set; }

        }

        /// <summary>
        /// <para>The similarity threshold. This threshold specifies the minimum similarity score allowed for recalled text chunks and is used to filter the text chunks returned by the ranking model. Only text chunks with a score greater than this value are recalled. Valid values: 0.01 to 1.00. This parameter has a higher priority than the similarity threshold configured for the knowledge base.</para>
        /// <para>If no specific value is specified, the similarity threshold configured for the knowledge base is used by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.20</para>
        /// </summary>
        [NameInMap("RerankMinScore")]
        [Validation(Required=false)]
        public float? RerankMinScore { get; set; }

        /// <summary>
        /// <para>The top N text chunks to return after reranking. Valid values: 1 to 20. Default value: 5.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("RerankTopN")]
        [Validation(Required=false)]
        public int? RerankTopN { get; set; }

        /// <summary>
        /// <para>The multi-turn conversation rewriting configuration.</para>
        /// </summary>
        [NameInMap("Rewrite")]
        [Validation(Required=false)]
        public List<RetrieveRequestRewrite> Rewrite { get; set; }
        public class RetrieveRequestRewrite : TeaModel {
            /// <summary>
            /// <para>The name of the multi-turn conversation rewriting model. The model automatically adjusts the original input prompt (user question) based on the conversation context to improve retrieval performance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>conv-rewrite-qwen-1.8b: The conv-rewrite-qwen-1.8b model. Currently, only this model is supported.</description></item>
            /// </list>
            /// <para>Default value: null. The conv-rewrite-qwen-1.8b model is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>conv-rewrite-qwen-1.8b</para>
            /// </summary>
            [NameInMap("ModelName")]
            [Validation(Required=false)]
            public string ModelName { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to save the historical text chunk recall test data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Save.</description></item>
        /// <item><description>false: Do not save.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SaveRetrieverHistory")]
        [Validation(Required=false)]
        public bool? SaveRetrieverHistory { get; set; }

        /// <summary>
        /// <para>The personalized retrieval conditions, such as tags, configured by using SearchFilter to filter semantic retrieval results and exclude information irrelevant to the query.
        /// The filtering logic takes effect when the is_displayed_chunk_content parameter is set to true. For more information, see <a href="https://help.aliyun.com/document_detail/2869641.html">Knowledge base SearchFilters</a>.</para>
        /// </summary>
        [NameInMap("SearchFilters")]
        [Validation(Required=false)]
        public List<Dictionary<string, string>> SearchFilters { get; set; }

        /// <summary>
        /// <para>The top K value for keyword retrieval. The system retrieves chunks from the knowledge base that are an exact match for the keywords in the input text. This helps you filter out irrelevant text chunks and provides more accurate results.
        /// Valid values: 0 to 100.
        /// The sum of DenseSimilarityTopK and SparseSimilarityTopK must be less than or equal to 200.</para>
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
