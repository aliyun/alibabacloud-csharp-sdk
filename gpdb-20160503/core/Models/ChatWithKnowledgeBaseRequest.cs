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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/196830.html">DescribeDBInstances</a> operation to query the details of all instances in the target region, including the instance IDs.</para>
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
        /// <para>Specifies whether to return the recall results. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IncludeKnowledgeBaseResults")]
        [Validation(Required=false)]
        public bool? IncludeKnowledgeBaseResults { get; set; }

        /// <summary>
        /// <para>The knowledge retrieval parameters. If this parameter is not specified, only chat is performed.</para>
        /// </summary>
        [NameInMap("KnowledgeParams")]
        [Validation(Required=false)]
        public ChatWithKnowledgeBaseRequestKnowledgeParams KnowledgeParams { get; set; }
        public class ChatWithKnowledgeBaseRequestKnowledgeParams : TeaModel {
            /// <summary>
            /// <para>The method for merging multiple knowledge bases. Default value: RRF. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>RRF</description></item>
            /// <item><description>Weight</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;RRF&quot;</para>
            /// </summary>
            [NameInMap("MergeMethod")]
            [Validation(Required=false)]
            public string MergeMethod { get; set; }

            /// <summary>
            /// <para>The parameters for merging multiple knowledge bases.</para>
            /// </summary>
            [NameInMap("MergeMethodArgs")]
            [Validation(Required=false)]
            public ChatWithKnowledgeBaseRequestKnowledgeParamsMergeMethodArgs MergeMethodArgs { get; set; }
            public class ChatWithKnowledgeBaseRequestKnowledgeParamsMergeMethodArgs : TeaModel {
                /// <summary>
                /// <para>The configurable parameters when MergeMethod is set to RRF.</para>
                /// </summary>
                [NameInMap("Rrf")]
                [Validation(Required=false)]
                public ChatWithKnowledgeBaseRequestKnowledgeParamsMergeMethodArgsRrf Rrf { get; set; }
                public class ChatWithKnowledgeBaseRequestKnowledgeParamsMergeMethodArgsRrf : TeaModel {
                    /// <summary>
                    /// <para>The constant k in the score calculation formula 1/(k+rank_i). The value must be a positive integer greater than 1.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>60</para>
                    /// </summary>
                    [NameInMap("K")]
                    [Validation(Required=false)]
                    public long? K { get; set; }

                }

                /// <summary>
                /// <para>The configurable parameters when MergeMethod is set to Weight.</para>
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public ChatWithKnowledgeBaseRequestKnowledgeParamsMergeMethodArgsWeight Weight { get; set; }
                public class ChatWithKnowledgeBaseRequestKnowledgeParamsMergeMethodArgsWeight : TeaModel {
                    /// <summary>
                    /// <para>The weight array for each SourceCollection.</para>
                    /// </summary>
                    [NameInMap("Weights")]
                    [Validation(Required=false)]
                    public List<double?> Weights { get; set; }

                }

            }

            /// <summary>
            /// <para>The reranking factor. If this value is not empty, the vector search results are reranked. Valid values: 1 &lt; RerankFactor &lt;= 5.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>When document chunks are sparse, reranking is slow.</description></item>
            /// <item><description>We recommend that the number of reranked items (TopK × Factor, rounded up) does not exceed 50.</description></item>
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
            /// <para>The reranking model parameters.</para>
            /// </summary>
            [NameInMap("RerankModel")]
            [Validation(Required=false)]
            public ChatWithKnowledgeBaseRequestKnowledgeParamsRerankModel RerankModel { get; set; }
            public class ChatWithKnowledgeBaseRequestKnowledgeParamsRerankModel : TeaModel {
                /// <summary>
                /// <para>This parameter can be configured when RerankModel.Name is set to qwen3-rerank. You can add a custom sorting task type description to guide the model to adopt different sorting strategies.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Given a web search query, retrieve relevant passages that answer the query</para>
                /// </summary>
                [NameInMap("Instruct")]
                [Validation(Required=false)]
                public string Instruct { get; set; }

                /// <summary>
                /// <para>The name of the reranking model. Valid values: qwen3-rerank and gte-rerank-v2.</para>
                /// 
                /// <b>Example:</b>
                /// <para>qwen3-rerank</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The list of knowledge bases.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("SourceCollection")]
            [Validation(Required=false)]
            public List<ChatWithKnowledgeBaseRequestKnowledgeParamsSourceCollection> SourceCollection { get; set; }
            public class ChatWithKnowledgeBaseRequestKnowledgeParamsSourceCollection : TeaModel {
                /// <summary>
                /// <para>The name of the collection to be retrieved.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>adbpg_document_collection</para>
                /// </summary>
                [NameInMap("Collection")]
                [Validation(Required=false)]
                public string Collection { get; set; }

                /// <summary>
                /// <para>The namespace. Default value: public.</para>
                /// <remarks>
                /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2401495.html">CreateNamespace</a> operation to create a namespace and call the <a href="https://help.aliyun.com/document_detail/2401502.html">ListNamespaces</a> operation to view the namespace list.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>dukang</para>
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <para>The password for the namespace.</para>
                /// <remarks>
                /// <para>This value is specified when you call the CreateNamespace operation.</para>
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
                /// <para>The parameters related to the retrieval of this knowledge base.</para>
                /// </summary>
                [NameInMap("QueryParams")]
                [Validation(Required=false)]
                public ChatWithKnowledgeBaseRequestKnowledgeParamsSourceCollectionQueryParams QueryParams { get; set; }
                public class ChatWithKnowledgeBaseRequestKnowledgeParamsSourceCollectionQueryParams : TeaModel {
                    /// <summary>
                    /// <para>The filter condition for the data to be updated, in the SQL WHERE format.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>id = &quot;llm-t87l87fxuhn56woc_8anu8j2d3f_file_e74635e2cc314e838543e724f6b3b1f2_10658020&quot;</para>
                    /// </summary>
                    [NameInMap("Filter")]
                    [Validation(Required=false)]
                    public string Filter { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to enable knowledge graph enhancement. Default value: false.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("GraphEnhance")]
                    [Validation(Required=false)]
                    public bool? GraphEnhance { get; set; }

                    /// <summary>
                    /// <para>The top number of entities and relationship edges to return. Default value: 60.</para>
                    /// </summary>
                    [NameInMap("GraphSearchArgs")]
                    [Validation(Required=false)]
                    public ChatWithKnowledgeBaseRequestKnowledgeParamsSourceCollectionQueryParamsGraphSearchArgs GraphSearchArgs { get; set; }
                    public class ChatWithKnowledgeBaseRequestKnowledgeParamsSourceCollectionQueryParamsGraphSearchArgs : TeaModel {
                        /// <summary>
                        /// <para>The top number of entities and relationship edges to return. Default value: 60.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>60</para>
                        /// </summary>
                        [NameInMap("GraphTopK")]
                        [Validation(Required=false)]
                        public long? GraphTopK { get; set; }

                    }

                    /// <summary>
                    /// <para>The multi-channel recall algorithm. Default value: empty, which means directly comparing and sorting the scores of dense vectors and the full-text index.</para>
                    /// <para>Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>RRF: Reciprocal Rank Fusion. A parameter k is used to control the fusion effect. For more information, see the HybridSearchArgs configuration.</description></item>
                    /// <item><description>Weight: Weight-based sorting. Parameters are used to control the score weights of vectors and the full-text index before sorting. For more information, see the HybridSearchArgs configuration.</description></item>
                    /// <item><description>Cascaded: Performs full-text search first, and then performs vector search based on the results.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>RRF</para>
                    /// </summary>
                    [NameInMap("HybridSearch")]
                    [Validation(Required=false)]
                    public string HybridSearch { get; set; }

                    /// <summary>
                    /// <para>The algorithm parameters for multi-channel recall. Currently, RRF and Weight are supported. You can use HybridPathsSetting to specify the recall paths for dense vectors (dense), sparse vectors (sparse), and full-text search (fulltext). If this value is empty, dense vectors (dense) and full-text search (fulltext) are recalled by default.</para>
                    /// <list type="bullet">
                    /// <item><description>RRF: The constant k in the score calculation formula <c>1/(k+rank_i)</c>. The value must be a positive integer greater than 1. Format:</description></item>
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
                    /// <item><description>Weight: <list type="bullet">
                    /// <item><description>Dual-channel recall (HybridPathsSetting is not specified, only alpha is specified):<list type="bullet">
                    /// <item><description>Calculation formula: alpha * dense_score + (1-alpha) * fulltext_score. The parameter alpha represents the score weights of dense vectors and full-text search. The value ranges from 0 to 1, where 0 indicates that only full-text search is used, and 1 indicates that only dense vectors are used:</description></item>
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
                    /// <item><description>Triple-channel recall mode:<list type="bullet">
                    /// <item><description>Calculation formula: normalized_dense * dense_score + normalized_sparse * sparse_score + normalized_fulltext * fulltext_score. Here, dense, sparse, and fulltext represent the weights of dense vectors, sparse vectors, and full-text search, respectively. The values must be greater than or equal to 0. The system automatically normalizes the weights to scale them from 0 to 1 (that is, normalized_x = x / (dense + sparse + fulltext)).</description></item>
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
                    /// 
                    /// <b>Example:</b>
                    /// <para>{&quot;RRF&quot;:{&quot;k&quot;:60}}</para>
                    /// </summary>
                    [NameInMap("HybridSearchArgs")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> HybridSearchArgs { get; set; }

                    /// <summary>
                    /// <para>The method used to build the vector index. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>l2: Euclidean distance.</description></item>
                    /// <item><description>ip: Dot product (inner product) distance.</description></item>
                    /// <item><description>cosine: Cosine similarity.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cosine</para>
                    /// </summary>
                    [NameInMap("Metrics")]
                    [Validation(Required=false)]
                    public string Metrics { get; set; }

                    /// <summary>
                    /// <para>The recall window. If this value is not empty, the context of the retrieval results is added to the response. The format is an array of two elements: List&lt;A, B&gt;, where -10 &lt;= A &lt;= 0 and 0 &lt;= B &lt;= 10.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>We recommend that you use this parameter when document chunks are too small and retrieval may lose context information.</description></item>
                    /// <item><description>Reranking takes precedence over windowing. That is, reranking is performed before windowing.</description></item>
                    /// </list>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>[-1,1]</para>
                    /// </summary>
                    [NameInMap("RecallWindow")]
                    [Validation(Required=false)]
                    public List<long?> RecallWindow { get; set; }

                    /// <summary>
                    /// <para>The reranking factor. If this value is not empty, the vector search results are reranked. Valid values: 1 &lt; RerankFactor &lt;= 5.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>When document chunks are sparse, reranking is slow.</description></item>
                    /// <item><description>We recommend that the number of reranked items (TopK × Factor, rounded up) does not exceed 50.</description></item>
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
                    /// <para>The reranking model parameters.</para>
                    /// </summary>
                    [NameInMap("RerankModel")]
                    [Validation(Required=false)]
                    public ChatWithKnowledgeBaseRequestKnowledgeParamsSourceCollectionQueryParamsRerankModel RerankModel { get; set; }
                    public class ChatWithKnowledgeBaseRequestKnowledgeParamsSourceCollectionQueryParamsRerankModel : TeaModel {
                        /// <summary>
                        /// <para>This parameter can be configured when RerankModel.Name is set to qwen3-rerank. You can add a custom sorting task type description to guide the model to adopt different sorting strategies.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Given a web search query, retrieve relevant passages that answer the query</para>
                        /// </summary>
                        [NameInMap("Instruct")]
                        [Validation(Required=false)]
                        public string Instruct { get; set; }

                        /// <summary>
                        /// <para>The name of the reranking model. Valid values: qwen3-rerank and gte-rerank-v2.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>qwen3-rerank</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>The metadata fields that participate in reranking. Separate multiple fields with commas (,). By default, only the document content (content) is used for reranking. The field names must be defined in the Metadata of the Collection.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>title</para>
                        /// </summary>
                        [NameInMap("RerankMetadataFields")]
                        [Validation(Required=false)]
                        public string RerankMetadataFields { get; set; }

                    }

                    /// <summary>
                    /// <para>The number of top results to return.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("TopK")]
                    [Validation(Required=false)]
                    public long? TopK { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to use full-text search (dual-channel recall). Default value: false, which indicates that only vector search is used.</para>
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
            /// <para>The number of top results to return after the multi-vector collection recall results are merged.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TopK")]
            [Validation(Required=false)]
            public long? TopK { get; set; }

        }

        /// <summary>
        /// <para>The call parameter object for the large language model (LLM).</para>
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
            /// <para>The message list.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Messages")]
            [Validation(Required=false)]
            public List<ChatWithKnowledgeBaseRequestModelParamsMessages> Messages { get; set; }
            public class ChatWithKnowledgeBaseRequestModelParamsMessages : TeaModel {
                /// <summary>
                /// <para>The message content.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>You are a helpful assistant</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The message role. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>system</description></item>
                /// <item><description>user</description></item>
                /// <item><description>assistant</description></item>
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
            /// <para>The name of the large language model to use. For valid values, see <a href="https://www.alibabacloud.com/help/en/model-studio/compatibility-of-openai-with-dashscope#eadfc13038jd5">Model Studio documentation</a>.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen-plus</para>
            /// </summary>
            [NameInMap("Model")]
            [Validation(Required=false)]
            public string Model { get; set; }

            /// <summary>
            /// <para>The number of candidate replies to generate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("N")]
            [Validation(Required=false)]
            public long? N { get; set; }

            /// <summary>
            /// <para>The presence penalty coefficient. Valid values: -2.0 to 2.0.</para>
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
            /// <para>The list of stop words.</para>
            /// </summary>
            [NameInMap("Stop")]
            [Validation(Required=false)]
            public List<string> Stop { get; set; }

            /// <summary>
            /// <para>The sampling temperature. Valid values: 0 to 2.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.6</para>
            /// </summary>
            [NameInMap("Temperature")]
            [Validation(Required=false)]
            public double? Temperature { get; set; }

            /// <summary>
            /// <para>The tool list.</para>
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
                    /// <para>Get the weather</para>
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
                    /// <para>The JSON Schema of the function parameters.</para>
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
            /// <para>The probability threshold for nucleus sampling. Valid values: 0 to 1.</para>
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
        /// <para>The system prompt template. It must include {{ text_chunks }}, {{ user_system_prompt }}, {{ graph_entities }}, and {{ graph_relations }}. If this parameter is not specified, this part does not take effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;Answer the question based on the following knowledge: {{ text_chunks }}&quot;</para>
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
