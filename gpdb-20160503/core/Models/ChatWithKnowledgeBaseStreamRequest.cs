// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ChatWithKnowledgeBaseStreamRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> operation to query the IDs of all AnalyticDB for PostgreSQL instances in a region.</para>
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
        /// <para>Specifies whether to return recall results. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IncludeKnowledgeBaseResults")]
        [Validation(Required=false)]
        public bool? IncludeKnowledgeBaseResults { get; set; }

        /// <summary>
        /// <para>The knowledge retrieval parameter object. If this parameter is not specified, only chat is performed.</para>
        /// </summary>
        [NameInMap("KnowledgeParams")]
        [Validation(Required=false)]
        public ChatWithKnowledgeBaseStreamRequestKnowledgeParams KnowledgeParams { get; set; }
        public class ChatWithKnowledgeBaseStreamRequestKnowledgeParams : TeaModel {
            /// <summary>
            /// <para>The method for merging results from multiple knowledge bases. Default value: RRF. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>RRF</description></item>
            /// <item><description>Weight.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;RRF&quot;</para>
            /// </summary>
            [NameInMap("MergeMethod")]
            [Validation(Required=false)]
            public string MergeMethod { get; set; }

            /// <summary>
            /// <para>The parameters for merging results from multiple knowledge bases.</para>
            /// </summary>
            [NameInMap("MergeMethodArgs")]
            [Validation(Required=false)]
            public ChatWithKnowledgeBaseStreamRequestKnowledgeParamsMergeMethodArgs MergeMethodArgs { get; set; }
            public class ChatWithKnowledgeBaseStreamRequestKnowledgeParamsMergeMethodArgs : TeaModel {
                /// <summary>
                /// <para>The configurable parameters when MergeMethod is set to RRF.</para>
                /// </summary>
                [NameInMap("Rrf")]
                [Validation(Required=false)]
                public ChatWithKnowledgeBaseStreamRequestKnowledgeParamsMergeMethodArgsRrf Rrf { get; set; }
                public class ChatWithKnowledgeBaseStreamRequestKnowledgeParamsMergeMethodArgsRrf : TeaModel {
                    /// <summary>
                    /// <para>The k constant in the score calculation formula <c>1/(k+rank_i)</c>. The value must be a positive integer greater than 1.</para>
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
                public ChatWithKnowledgeBaseStreamRequestKnowledgeParamsMergeMethodArgsWeight Weight { get; set; }
                public class ChatWithKnowledgeBaseStreamRequestKnowledgeParamsMergeMethodArgsWeight : TeaModel {
                    /// <summary>
                    /// <para>The weight array for each SourceCollection.</para>
                    /// </summary>
                    [NameInMap("Weights")]
                    [Validation(Required=false)]
                    public List<double?> Weights { get; set; }

                }

            }

            /// <summary>
            /// <para>The reranking factor. If this value is not empty, the AISearch retrieve results are reranked. Valid values: 1 &lt; RerankFactor &lt;= 5.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>Reranking is slow when document chunks are sparse.</description></item>
            /// <item><description>The recommended number of reranked items (TopK × Factor, rounded up) should not exceed 50.</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>5.0</para>
            /// </summary>
            [NameInMap("RerankFactor")]
            [Validation(Required=false)]
            public double? RerankFactor { get; set; }

            /// <summary>
            /// <para>The reranking model parameters for performing an additional reranking on the merged results from multiple retrieval paths.</para>
            /// </summary>
            [NameInMap("RerankModel")]
            [Validation(Required=false)]
            public ChatWithKnowledgeBaseStreamRequestKnowledgeParamsRerankModel RerankModel { get; set; }
            public class ChatWithKnowledgeBaseStreamRequestKnowledgeParamsRerankModel : TeaModel {
                /// <summary>
                /// <para>This parameter can be set when RerankModel.Name is set to qwen3-rerank. Specifies a custom ranking task type description to guide the model to adopt different ranking strategies.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Given a web search query, retrieve relevant passages that answer the query</para>
                /// </summary>
                [NameInMap("Instruct")]
                [Validation(Required=false)]
                public string Instruct { get; set; }

                /// <summary>
                /// <para>The reranking model name. Valid values: qwen3-rerank, gte-rerank-v2.</para>
                /// 
                /// <b>Example:</b>
                /// <para>qwen3-rerank</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>The knowledge base.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("SourceCollection")]
            [Validation(Required=false)]
            public List<ChatWithKnowledgeBaseStreamRequestKnowledgeParamsSourceCollection> SourceCollection { get; set; }
            public class ChatWithKnowledgeBaseStreamRequestKnowledgeParamsSourceCollection : TeaModel {
                /// <summary>
                /// <para>The name of the collection to recall.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_index_adb_50943_prod</para>
                /// </summary>
                [NameInMap("Collection")]
                [Validation(Required=false)]
                public string Collection { get; set; }

                /// <summary>
                /// <para>The namespace.</para>
                /// <remarks>
                /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2401502.html">ListNamespaces</a> operation to query the list.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>ddstar_vector</para>
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <para>The password of the namespace.</para>
                /// <remarks>
                /// <para>This value is specified in the CreateNamespace operation.</para>
                /// </remarks>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>namespacePassword</para>
                /// </summary>
                [NameInMap("NamespacePassword")]
                [Validation(Required=false)]
                public string NamespacePassword { get; set; }

                /// <summary>
                /// <para>The parameters related to retrieval from this knowledge base.</para>
                /// </summary>
                [NameInMap("QueryParams")]
                [Validation(Required=false)]
                public ChatWithKnowledgeBaseStreamRequestKnowledgeParamsSourceCollectionQueryParams QueryParams { get; set; }
                public class ChatWithKnowledgeBaseStreamRequestKnowledgeParamsSourceCollectionQueryParams : TeaModel {
                    /// <summary>
                    /// <para>The filter condition for the data to update, in SQL WHERE clause format.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>method_id=\&quot;e41695f0-2851-40ac-b21d-dd337b60d71c\&quot;</para>
                    /// </summary>
                    [NameInMap("Filter")]
                    [Validation(Required=false)]
                    public string Filter { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to enable knowledge graph enhancement. Default value: false.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("GraphEnhance")]
                    [Validation(Required=false)]
                    public bool? GraphEnhance { get; set; }

                    /// <summary>
                    /// <para>The knowledge graph retrieval parameters.</para>
                    /// </summary>
                    [NameInMap("GraphSearchArgs")]
                    [Validation(Required=false)]
                    public ChatWithKnowledgeBaseStreamRequestKnowledgeParamsSourceCollectionQueryParamsGraphSearchArgs GraphSearchArgs { get; set; }
                    public class ChatWithKnowledgeBaseStreamRequestKnowledgeParamsSourceCollectionQueryParamsGraphSearchArgs : TeaModel {
                        /// <summary>
                        /// <para>The number of top entities and relationship edges to return. Default value: 60.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>60</para>
                        /// </summary>
                        [NameInMap("GraphTopK")]
                        [Validation(Required=false)]
                        public long? GraphTopK { get; set; }

                    }

                    /// <summary>
                    /// <para>The multi-channel recall algorithm. Default value: empty (AISearch and full-text index scores are directly compared and sorted).</para>
                    /// <para>Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>RRF: Reciprocal rank fusion. A parameter k controls the fusion effect. For more information, see HybridSearchArgs.</description></item>
                    /// <item><description>Weight: Weighted reranking. A parameter alpha controls the score weight between AISearch and full-text index results, then performs reranking. For more information, see HybridSearchArgs.</description></item>
                    /// <item><description>Cascaded: Full-text index retrieve is performed first, followed by AISearch retrieve on the full-text index results.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Cascaded</para>
                    /// </summary>
                    [NameInMap("HybridSearch")]
                    [Validation(Required=false)]
                    public string HybridSearch { get; set; }

                    /// <summary>
                    /// <para>The algorithm parameters for multi-channel recall. RRF and Weight are supported:</para>
                    /// <list type="bullet">
                    /// <item><description>RRF: The k constant in the score calculation formula <c>1/(k+rank_i)</c>. The value must be a positive integer greater than 1. Format:</description></item>
                    /// </list>
                    /// <pre><c>{ 
                    ///    &quot;RRF&quot;: {
                    ///     &quot;k&quot;: 60
                    ///    }
                    /// }
                    /// </c></pre>
                    /// <list type="bullet">
                    /// <item><description>Weight: The calculation formula is <c>alpha * vector_score + (1-alpha) * text_score</c>. The parameter alpha specifies the score weight between vector and full-text retrieval. Valid values: 0 to 1, where 0 indicates full-text only and 1 indicates vector only:</description></item>
                    /// </list>
                    /// <pre><c>{ 
                    ///    &quot;Weight&quot;: {
                    ///     &quot;alpha&quot;: 0.5
                    ///    }
                    /// }
                    /// ```.
                    /// </c></pre>
                    /// </summary>
                    [NameInMap("HybridSearchArgs")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> HybridSearchArgs { get; set; }

                    /// <summary>
                    /// <para>The method used to build the vector index. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>l2: Euclidean distance.</description></item>
                    /// <item><description>ip: inner product distance.</description></item>
                    /// <item><description>cosine: cosine similarity.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cosine</para>
                    /// </summary>
                    [NameInMap("Metrics")]
                    [Validation(Required=false)]
                    public string Metrics { get; set; }

                    /// <summary>
                    /// <para>The recall window. If this value is not empty, additional context is returned for retrieval results. The format is a two-element array: List&lt;A, B&gt;, where -10 &lt;= A &lt;= 0 and 0 &lt;= B &lt;= 10.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>Use this parameter when documents are segmented too finely and retrieval may lose contextual information.</description></item>
                    /// <item><description>Reranking takes priority over windowing. Reranking is performed first, followed by windowing.</description></item>
                    /// </list>
                    /// </remarks>
                    /// </summary>
                    [NameInMap("RecallWindow")]
                    [Validation(Required=false)]
                    public List<long?> RecallWindow { get; set; }

                    /// <summary>
                    /// <para>The reranking factor. If this value is not empty, the AISearch retrieve results are reranked. Valid values: 1 &lt; RerankFactor &lt;= 5.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>Reranking is slow when document chunks are sparse.</description></item>
                    /// <item><description>The recommended number of reranked items (TopK × Factor, rounded up) should not exceed 50.</description></item>
                    /// </list>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2.0</para>
                    /// </summary>
                    [NameInMap("RerankFactor")]
                    [Validation(Required=false)]
                    public double? RerankFactor { get; set; }

                    /// <summary>
                    /// <para>The reranking model parameters.</para>
                    /// </summary>
                    [NameInMap("RerankModel")]
                    [Validation(Required=false)]
                    public ChatWithKnowledgeBaseStreamRequestKnowledgeParamsSourceCollectionQueryParamsRerankModel RerankModel { get; set; }
                    public class ChatWithKnowledgeBaseStreamRequestKnowledgeParamsSourceCollectionQueryParamsRerankModel : TeaModel {
                        /// <summary>
                        /// <para>This parameter can be set when RerankModel.Name is set to qwen3-rerank. Specifies a custom ranking task type description to guide the model to adopt different ranking strategies.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Given a web search query, retrieve relevant passages that answer the query</para>
                        /// </summary>
                        [NameInMap("Instruct")]
                        [Validation(Required=false)]
                        public string Instruct { get; set; }

                        /// <summary>
                        /// <para>The reranking model name. Valid values: qwen3-rerank, gte-rerank-v2.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>qwen3-rerank</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("RerankMetadataFields")]
                        [Validation(Required=false)]
                        public string RerankMetadataFields { get; set; }

                    }

                    /// <summary>
                    /// <para>The number of top results to return.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>101</para>
                    /// </summary>
                    [NameInMap("TopK")]
                    [Validation(Required=false)]
                    public long? TopK { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to use full-text index (multi-channel recall). Default value: false. Only AISearch retrieve is used.</para>
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
            /// <para>The number of top results to return after merging recall results from multiple vector collections.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TopK")]
            [Validation(Required=false)]
            public long? TopK { get; set; }

        }

        /// <summary>
        /// <para>The large language model (LLM) invocation parameter object.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ModelParams")]
        [Validation(Required=false)]
        public ChatWithKnowledgeBaseStreamRequestModelParams ModelParams { get; set; }
        public class ChatWithKnowledgeBaseStreamRequestModelParams : TeaModel {
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
            public List<ChatWithKnowledgeBaseStreamRequestModelParamsMessages> Messages { get; set; }
            public class ChatWithKnowledgeBaseStreamRequestModelParamsMessages : TeaModel {
                /// <summary>
                /// <para>The message content.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>You are a helpful assistant.</para>
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// <para>The message role. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>system</description></item>
                /// <item><description>user</description></item>
                /// <item><description>assistant.</description></item>
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
            /// <para>The number of candidate responses to generate.</para>
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
            public List<ChatWithKnowledgeBaseStreamRequestModelParamsTools> Tools { get; set; }
            public class ChatWithKnowledgeBaseStreamRequestModelParamsTools : TeaModel {
                /// <summary>
                /// <para>The function information.</para>
                /// </summary>
                [NameInMap("Function")]
                [Validation(Required=false)]
                public ChatWithKnowledgeBaseStreamRequestModelParamsToolsFunction Function { get; set; }
                public class ChatWithKnowledgeBaseStreamRequestModelParamsToolsFunction : TeaModel {
                    /// <summary>
                    /// <para>The description of the function tool.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Get weather.</para>
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
            /// <para>The nucleus sampling probability threshold. Valid values: 0 to 1.</para>
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
        /// <para>The system prompt template. The template must include {{ text_chunks }}, {{ user_system_prompt }}, {{ graph_entities }}, and {{ graph_relations }}. If not specified, this part does not take effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;参考以下知识回答问题:{{ text_chunks }}&quot;</para>
        /// </summary>
        [NameInMap("PromptParams")]
        [Validation(Required=false)]
        public string PromptParams { get; set; }

        /// <summary>
        /// <para>The ID of the region where the instance resides.</para>
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
