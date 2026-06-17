// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ChatWithKnowledgeBaseRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/196830.html">DescribeDBInstances</a> operation to view the details of all instances in a target region, including their instance IDs.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-xxxxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>Whether to include the raw retrieval results from the knowledge base in the response. Default: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IncludeKnowledgeBaseResults")]
        [Validation(Required=false)]
        public bool? IncludeKnowledgeBaseResults { get; set; }

        /// <summary>
        /// <para>Parameters for knowledge retrieval. If omitted, the operation performs a standard chat without retrieving from a knowledge base.</para>
        /// </summary>
        [NameInMap("KnowledgeParams")]
        [Validation(Required=false)]
        public ChatWithKnowledgeBaseRequestKnowledgeParams KnowledgeParams { get; set; }
        public class ChatWithKnowledgeBaseRequestKnowledgeParams : TeaModel {
            /// <summary>
            /// <para>The method for merging results from multiple knowledge bases. Default: <c>RRF</c>. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>RRF</c></para>
            /// </description></item>
            /// <item><description><para><c>Weight</c></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;RRF&quot;</para>
            /// </summary>
            [NameInMap("MergeMethod")]
            [Validation(Required=false)]
            public string MergeMethod { get; set; }

            /// <summary>
            /// <para>The parameters for the merge method.</para>
            /// </summary>
            [NameInMap("MergeMethodArgs")]
            [Validation(Required=false)]
            public ChatWithKnowledgeBaseRequestKnowledgeParamsMergeMethodArgs MergeMethodArgs { get; set; }
            public class ChatWithKnowledgeBaseRequestKnowledgeParamsMergeMethodArgs : TeaModel {
                /// <summary>
                /// <para>Parameters to use when <c>MergeMethod</c> is set to <c>RRF</c>.</para>
                /// </summary>
                [NameInMap("Rrf")]
                [Validation(Required=false)]
                public ChatWithKnowledgeBaseRequestKnowledgeParamsMergeMethodArgsRrf Rrf { get; set; }
                public class ChatWithKnowledgeBaseRequestKnowledgeParamsMergeMethodArgsRrf : TeaModel {
                    /// <summary>
                    /// <para>The constant <c>k</c> in the reciprocal rank fusion formula <c>1/(k + rank_i)</c>. The value must be a positive integer greater than 1.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>60</para>
                    /// </summary>
                    [NameInMap("K")]
                    [Validation(Required=false)]
                    public long? K { get; set; }

                }

                /// <summary>
                /// <para>Parameters to use when <c>MergeMethod</c> is set to <c>Weight</c>.</para>
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public ChatWithKnowledgeBaseRequestKnowledgeParamsMergeMethodArgsWeight Weight { get; set; }
                public class ChatWithKnowledgeBaseRequestKnowledgeParamsMergeMethodArgsWeight : TeaModel {
                    /// <summary>
                    /// <para>An array of weights corresponding to each collection specified in <c>SourceCollection</c>.</para>
                    /// </summary>
                    [NameInMap("Weights")]
                    [Validation(Required=false)]
                    public List<double?> Weights { get; set; }

                }

            }

            /// <summary>
            /// <para>The reranking factor. Specify this to rerank the initial vector retrieval results for improved relevance. Valid range: (1, 5].</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><para>Reranking may be less efficient if document chunks are sparse.</para>
            /// </description></item>
            /// <item><description><para>We recommend that the number of items to rerank, calculated as <c>Ceiling(TopK * RerankFactor)</c>, does not exceed 50.</para>
            /// </description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1.0001</para>
            /// </summary>
            [NameInMap("RerankFactor")]
            [Validation(Required=false)]
            public double? RerankFactor { get; set; }

            /// <summary>
            /// <para>The model to use for reranking.</para>
            /// </summary>
            [NameInMap("RerankModel")]
            [Validation(Required=false)]
            public ChatWithKnowledgeBaseRequestKnowledgeParamsRerankModel RerankModel { get; set; }
            public class ChatWithKnowledgeBaseRequestKnowledgeParamsRerankModel : TeaModel {
                /// <summary>
                /// <para>The instruction or prompt for the reranking model.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Given a web search query, retrieve relevant passages that answer the query</para>
                /// </summary>
                [NameInMap("Instruct")]
                [Validation(Required=false)]
                public string Instruct { get; set; }

                /// <summary>
                /// <para>The name of the reranking model.</para>
                /// 
                /// <b>Example:</b>
                /// <para>qwen3-rerank</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>An array of knowledge base collections to query.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("SourceCollection")]
            [Validation(Required=false)]
            public List<ChatWithKnowledgeBaseRequestKnowledgeParamsSourceCollection> SourceCollection { get; set; }
            public class ChatWithKnowledgeBaseRequestKnowledgeParamsSourceCollection : TeaModel {
                /// <summary>
                /// <para>The name of the collection to query.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>adbpg_document_collection</para>
                /// </summary>
                [NameInMap("Collection")]
                [Validation(Required=false)]
                public string Collection { get; set; }

                /// <summary>
                /// <para>The namespace where the collection resides. Default: <c>public</c>.</para>
                /// <remarks>
                /// <para>You can create a namespace by calling the <a href="https://help.aliyun.com/document_detail/2401495.html">CreateNamespace</a> operation and view existing namespaces by calling the <a href="https://help.aliyun.com/document_detail/2401502.html">ListNamespaces</a> operation.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>dukang</para>
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <para>The password for the specified namespace.</para>
                /// <remarks>
                /// <para>This password is set when you call the <c>CreateNamespace</c> operation.</para>
                /// </remarks>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>namespacePasswd</para>
                /// </summary>
                [NameInMap("NamespacePassword")]
                [Validation(Required=false)]
                public string NamespacePassword { get; set; }

                /// <summary>
                /// <para>Retrieval parameters for this knowledge base collection.</para>
                /// </summary>
                [NameInMap("QueryParams")]
                [Validation(Required=false)]
                public ChatWithKnowledgeBaseRequestKnowledgeParamsSourceCollectionQueryParams QueryParams { get; set; }
                public class ChatWithKnowledgeBaseRequestKnowledgeParamsSourceCollectionQueryParams : TeaModel {
                    /// <summary>
                    /// <para>A filter to apply to the search, specified as a SQL <c>WHERE</c> clause.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>id = \&quot;llm-t87l87fxuhn56woc_8anu8j2d3f_file_e74635e2cc314e838543e724f6b3b1f2_10658020\&quot;</para>
                    /// </summary>
                    [NameInMap("Filter")]
                    [Validation(Required=false)]
                    public string Filter { get; set; }

                    /// <summary>
                    /// <para>Whether to enhance the search with a knowledge graph. Default: <c>false</c>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("GraphEnhance")]
                    [Validation(Required=false)]
                    public bool? GraphEnhance { get; set; }

                    /// <summary>
                    /// <para>Parameters for the knowledge graph search, used when <c>GraphEnhance</c> is <c>true</c>.</para>
                    /// </summary>
                    [NameInMap("GraphSearchArgs")]
                    [Validation(Required=false)]
                    public ChatWithKnowledgeBaseRequestKnowledgeParamsSourceCollectionQueryParamsGraphSearchArgs GraphSearchArgs { get; set; }
                    public class ChatWithKnowledgeBaseRequestKnowledgeParamsSourceCollectionQueryParamsGraphSearchArgs : TeaModel {
                        /// <summary>
                        /// <para>The maximum number of entities and relationship edges to return from the knowledge graph search. Default: 60.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>60</para>
                        /// </summary>
                        [NameInMap("GraphTopK")]
                        [Validation(Required=false)]
                        public long? GraphTopK { get; set; }

                    }

                    /// <summary>
                    /// <para>The multi-channel recall algorithm. If omitted, the system directly compares and sorts scores from dense vector retrieval and full-text search.</para>
                    /// <para>Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><c>RRF</c>: Uses reciprocal rank fusion. The fusion effect is controlled by the <c>k</c> parameter in <c>HybridSearchArgs</c>.</para>
                    /// </description></item>
                    /// <item><description><para><c>Weight</c>: Uses weighted sorting. The weights for vector retrieval and full-text search scores are controlled by parameters in <c>HybridSearchArgs</c>.</para>
                    /// </description></item>
                    /// <item><description><para><c>Cascaded</c>: Performs a full-text search first, followed by a vector retrieval on the results.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>RRF</para>
                    /// </summary>
                    [NameInMap("HybridSearch")]
                    [Validation(Required=false)]
                    public string HybridSearch { get; set; }

                    /// <summary>
                    /// <para>Parameters for the multi-channel recall algorithm. <c>RRF</c> and <c>Weight</c> are supported. The <c>HybridPathsSetting</c> parameter can specify the recall channels: <c>dense</c> (dense vector), <c>sparse</c> (sparse vector), and <c>fulltext</c> (full-text search). If this parameter is empty, <c>dense</c> and <c>fulltext</c> are used by default.</para>
                    /// <list type="bullet">
                    /// <item><description><c>RRF</c>: Specifies the constant <c>k</c> in the formula <c>1/(k+rank_i)</c>. The value must be a positive integer greater than 1. Format:</description></item>
                    /// </list>
                    /// <pre><c>{
                    ///   &quot;HybridPathsSetting&quot;: {
                    ///     &quot;paths&quot;: &quot;dense,fulltext&quot;
                    ///   },
                    ///   &quot;RRF&quot;: {
                    ///     &quot;k&quot;: 60
                    ///   }
                    /// }
                    /// </c></pre>
                    /// <list type="bullet">
                    /// <item><description><para><c>Weight</c>:</para>
                    /// <list type="bullet">
                    /// <item><description><para>Two-channel recall (if <c>HybridPathsSetting</c> is not specified, only <c>alpha</c> is required):</para>
                    /// <list type="bullet">
                    /// <item><description>Formula: <c>alpha * dense_score + (1-alpha) * fulltext_score</c>. The <c>alpha</c> parameter represents the weight of the dense vector score relative to the full-text search score. The value must be in the range [0, 1]. A value of 0 uses only full-text search. A value of 1 uses only dense vector retrieval.</description></item>
                    /// </list>
                    /// </description></item>
                    /// </list>
                    /// </description></item>
                    /// </list>
                    /// <pre><c>{ 
                    ///    &quot;Weight&quot;: {
                    ///     &quot;alpha&quot;: 0.5
                    ///    }
                    /// }
                    /// </c></pre>
                    /// <list type="bullet">
                    /// <item><description><para>Three-channel recall:</para>
                    /// <list type="bullet">
                    /// <item><description>Formula: <c>normalized_dense * dense_score + normalized_sparse * sparse_score + normalized_fulltext * fulltext_score</c>. The <c>dense</c>, <c>sparse</c>, and <c>fulltext</c> parameters represent the weights for each channel and must be greater than or equal to 0. The system automatically normalizes these weights (for example, <c>normalized_x = x / (dense + sparse + fulltext)</c>).</description></item>
                    /// </list>
                    /// </description></item>
                    /// </list>
                    /// <pre><c>{
                    ///   &quot;HybridPathsSetting&quot;: {
                    ///      &quot;paths&quot;: &quot;dense,sparse,fulltext&quot;
                    ///    },
                    ///   &quot;Weight&quot;: {
                    ///     &quot;dense&quot;: 0.5,
                    ///     &quot;sparse&quot;: 0.3,
                    ///     &quot;fulltext&quot;: 0.2
                    ///   }
                    /// }
                    /// </c></pre>
                    /// </summary>
                    [NameInMap("HybridSearchArgs")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> HybridSearchArgs { get; set; }

                    /// <summary>
                    /// <para>The distance metric used for vector indexing. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><c>l2</c>: euclidean distance.</para>
                    /// </description></item>
                    /// <item><description><para><c>ip</c>: Inner product (dot product) distance.</para>
                    /// </description></item>
                    /// <item><description><para><c>cosine</c>: cosine similarity.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cosine</para>
                    /// </summary>
                    [NameInMap("Metrics")]
                    [Validation(Required=false)]
                    public string Metrics { get; set; }

                    /// <summary>
                    /// <para>The recall window. If specified, expands the context around retrieved text chunks. Must be an array of two integers, <c>[A, B]</c>, where <c>A</c> is the number of preceding chunks to include (from -10 to 0) and <c>B</c> is the number of following chunks (from 0 to 10).</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description><para>We recommend that you use this parameter when document chunks are highly fragmented and retrieval might result in a loss of context.</para>
                    /// </description></item>
                    /// <item><description><para>Reranking is performed before windowing is applied.</para>
                    /// </description></item>
                    /// </list>
                    /// </remarks>
                    /// </summary>
                    [NameInMap("RecallWindow")]
                    [Validation(Required=false)]
                    public List<long?> RecallWindow { get; set; }

                    /// <summary>
                    /// <para>The reranking factor for this collection, which overrides the top-level <c>RerankFactor</c>. If specified, it reranks the initial retrieval results to improve relevance. Valid range: (1, 5].</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description><para>Reranking may be less efficient if document chunks are sparse.</para>
                    /// </description></item>
                    /// <item><description><para>We recommend that the number of items to rerank, calculated as <c>Ceiling(TopK * RerankFactor)</c>, does not exceed 50.</para>
                    /// </description></item>
                    /// </list>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1.5</para>
                    /// </summary>
                    [NameInMap("RerankFactor")]
                    [Validation(Required=false)]
                    public double? RerankFactor { get; set; }

                    /// <summary>
                    /// <para>The model to use for reranking.</para>
                    /// </summary>
                    [NameInMap("RerankModel")]
                    [Validation(Required=false)]
                    public ChatWithKnowledgeBaseRequestKnowledgeParamsSourceCollectionQueryParamsRerankModel RerankModel { get; set; }
                    public class ChatWithKnowledgeBaseRequestKnowledgeParamsSourceCollectionQueryParamsRerankModel : TeaModel {
                        /// <summary>
                        /// <para>The instruction or prompt for the reranking model.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Given a web search query, retrieve relevant passages that answer the query</para>
                        /// </summary>
                        [NameInMap("Instruct")]
                        [Validation(Required=false)]
                        public string Instruct { get; set; }

                        /// <summary>
                        /// <para>The name of the reranking model.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>qwen3-rerank</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                    /// <summary>
                    /// <para>The number of top results to return from this collection before merging.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("TopK")]
                    [Validation(Required=false)]
                    public long? TopK { get; set; }

                    /// <summary>
                    /// <para>Whether to enable full-text search in addition to vector retrieval. Default: <c>false</c> (uses only vector retrieval).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("UseFullTextRetrieval")]
                    [Validation(Required=false)]
                    public bool? UseFullTextRetrieval { get; set; }

                }

            }

            /// <summary>
            /// <para>The number of top results to return after the results from multiple vector collection recalls are merged.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TopK")]
            [Validation(Required=false)]
            public long? TopK { get; set; }

        }

        /// <summary>
        /// <para>The parameters for calling the large language model (LLM).</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ModelParams")]
        [Validation(Required=false)]
        public ChatWithKnowledgeBaseRequestModelParams ModelParams { get; set; }
        public class ChatWithKnowledgeBaseRequestModelParams : TeaModel {
            /// <summary>
            /// <para>The maximum number of tokens to generate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8192</para>
            /// </summary>
            [NameInMap("MaxTokens")]
            [Validation(Required=false)]
            public long? MaxTokens { get; set; }

            /// <summary>
            /// <para>The list of messages that form the conversation history.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Messages")]
            [Validation(Required=false)]
            public List<ChatWithKnowledgeBaseRequestModelParamsMessages> Messages { get; set; }
            public class ChatWithKnowledgeBaseRequestModelParamsMessages : TeaModel {
                /// <summary>
                /// <para>The content of the message.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>You are a helpful assistant.</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The role of the message author. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>system</c></para>
                /// </description></item>
                /// <item><description><para><c>user</c></para>
                /// </description></item>
                /// <item><description><para><c>assistant</c></para>
                /// </description></item>
                /// </list>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>user</para>
                /// </summary>
                [NameInMap("Role")]
                [Validation(Required=false)]
                public string Role { get; set; }

            }

            /// <summary>
            /// <para>The name of the large language model to use. For a list of available models, see the <a href="https://help.aliyun.com/zh/model-studio/compatibility-of-openai-with-dashscope?spm=a2c4g.11186623.help-menu-2400256.d_2_10_0.45b5516eZIciC8%5C&scm=20140722.H_2833609._.OR_help-T_cn~zh-V_1#eadfc13038jd5">Model Studio documentation</a>.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen-plus</para>
            /// </summary>
            [NameInMap("Model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            /// <summary>
            /// <para>The number of candidate responses to generate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("N")]
            [Validation(Required=false)]
            public long? N { get; set; }

            /// <summary>
            /// <para>The presence penalty. Valid range: [-2.0, 2.0].</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("PresencePenalty")]
            [Validation(Required=false)]
            public double? PresencePenalty { get; set; }

            /// <summary>
            /// <para>The random seed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>42</para>
            /// </summary>
            [NameInMap("Seed")]
            [Validation(Required=false)]
            public long? Seed { get; set; }

            /// <summary>
            /// <para>A list of stop words.</para>
            /// </summary>
            [NameInMap("Stop")]
            [Validation(Required=false)]
            public List<string> Stop { get; set; }

            /// <summary>
            /// <para>The sampling temperature. Valid range: (0, 2.0].</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.6</para>
            /// </summary>
            [NameInMap("Temperature")]
            [Validation(Required=false)]
            public double? Temperature { get; set; }

            /// <summary>
            /// <para>The list of tools.</para>
            /// </summary>
            [NameInMap("Tools")]
            [Validation(Required=false)]
            public List<ChatWithKnowledgeBaseRequestModelParamsTools> Tools { get; set; }
            public class ChatWithKnowledgeBaseRequestModelParamsTools : TeaModel {
                /// <summary>
                /// <para>The function information.</para>
                /// </summary>
                [NameInMap("Function")]
                [Validation(Required=false)]
                public ChatWithKnowledgeBaseRequestModelParamsToolsFunction Function { get; set; }
                public class ChatWithKnowledgeBaseRequestModelParamsToolsFunction : TeaModel {
                    /// <summary>
                    /// <para>The description of the function tool.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>获取天气。</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The name of the function tool.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>get_weather</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The JSON schema of the function parameters.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>{&quot;type&quot;: &quot;object&quot;, ...}</para>
                    /// </summary>
                    [NameInMap("Parameters")]
                    [Validation(Required=false)]
                    public object Parameters { get; set; }

                }

            }

            /// <summary>
            /// <para>The probability threshold for nucleus sampling. Valid range: (0, 1.0).</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.9</para>
            /// </summary>
            [NameInMap("TopP")]
            [Validation(Required=false)]
            public double? TopP { get; set; }

        }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>A custom system prompt template. If specified, it overrides the default prompt. The template must include the {{ text_chunks }}, {{ user_system_prompt }}, {{ graph_entities }}, and {{ graph_relations }} placeholders.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;参考以下知识回答问题:{{ text_chunks }}&quot;</para>
        /// </summary>
        [NameInMap("PromptParams")]
        [Validation(Required=false)]
        public string PromptParams { get; set; }

        /// <summary>
        /// <para>The region ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
