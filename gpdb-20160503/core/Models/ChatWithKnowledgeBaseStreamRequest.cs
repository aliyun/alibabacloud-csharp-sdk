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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> operation to query the IDs of all AnalyticDB for PostgreSQL instances in a specified region.</para>
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
        /// <para>Specifies whether to include the retrieved knowledge base results in the response. Default value: <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IncludeKnowledgeBaseResults")]
        [Validation(Required=false)]
        public bool? IncludeKnowledgeBaseResults { get; set; }

        /// <summary>
        /// <para>Parameters for knowledge retrieval. If omitted, the API performs a chat-only operation.</para>
        /// </summary>
        [NameInMap("KnowledgeParams")]
        [Validation(Required=false)]
        public ChatWithKnowledgeBaseStreamRequestKnowledgeParams KnowledgeParams { get; set; }
        public class ChatWithKnowledgeBaseStreamRequestKnowledgeParams : TeaModel {
            /// <summary>
            /// <para>Specifies the method for merging results from multiple knowledge bases. Default: <c>RRF</c>. Valid values:</para>
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
            /// <para>The arguments for the result merging method.</para>
            /// </summary>
            [NameInMap("MergeMethodArgs")]
            [Validation(Required=false)]
            public ChatWithKnowledgeBaseStreamRequestKnowledgeParamsMergeMethodArgs MergeMethodArgs { get; set; }
            public class ChatWithKnowledgeBaseStreamRequestKnowledgeParamsMergeMethodArgs : TeaModel {
                /// <summary>
                /// <para>Parameters for the <c>RRF</c> merge method.</para>
                /// </summary>
                [NameInMap("Rrf")]
                [Validation(Required=false)]
                public ChatWithKnowledgeBaseStreamRequestKnowledgeParamsMergeMethodArgsRrf Rrf { get; set; }
                public class ChatWithKnowledgeBaseStreamRequestKnowledgeParamsMergeMethodArgsRrf : TeaModel {
                    /// <summary>
                    /// <para>The constant <c>k</c> used in the reciprocal rank fusion (RRF) formula <c>1/(k + rank_i)</c>. The value must be an integer greater than 1.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>60</para>
                    /// </summary>
                    [NameInMap("K")]
                    [Validation(Required=false)]
                    public long? K { get; set; }

                }

                /// <summary>
                /// <para>Parameters for the <c>Weight</c> merge method.</para>
                /// </summary>
                [NameInMap("Weight")]
                [Validation(Required=false)]
                public ChatWithKnowledgeBaseStreamRequestKnowledgeParamsMergeMethodArgsWeight Weight { get; set; }
                public class ChatWithKnowledgeBaseStreamRequestKnowledgeParamsMergeMethodArgsWeight : TeaModel {
                    /// <summary>
                    /// <para>An array of weights for each <c>SourceCollection</c>.</para>
                    /// </summary>
                    [NameInMap("Weights")]
                    [Validation(Required=false)]
                    public List<double?> Weights { get; set; }

                }

            }

            /// <summary>
            /// <para>Specifies the factor for reranking vector search results. The value must be greater than 1 and less than or equal to 5.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><para>Reranking may be inefficient if document chunks are sparse.</para>
            /// </description></item>
            /// <item><description><para>The number of items to rerank, calculated as <c>ceil(TopK * RerankFactor)</c>, should not exceed 50.</para>
            /// </description></item>
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
            /// <para>The rerank model to use.</para>
            /// </summary>
            [NameInMap("RerankModel")]
            [Validation(Required=false)]
            public ChatWithKnowledgeBaseStreamRequestKnowledgeParamsRerankModel RerankModel { get; set; }
            public class ChatWithKnowledgeBaseStreamRequestKnowledgeParamsRerankModel : TeaModel {
                /// <summary>
                /// <para>An instruction for the rerank model.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Given a web search query, retrieve relevant passages that answer the query</para>
                /// </summary>
                [NameInMap("Instruct")]
                [Validation(Required=false)]
                public string Instruct { get; set; }

                /// <summary>
                /// <para>The name of the rerank model.</para>
                /// 
                /// <b>Example:</b>
                /// <para>qwen3-rerank</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            /// <summary>
            /// <para>An array of knowledge bases to search.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("SourceCollection")]
            [Validation(Required=false)]
            public List<ChatWithKnowledgeBaseStreamRequestKnowledgeParamsSourceCollection> SourceCollection { get; set; }
            public class ChatWithKnowledgeBaseStreamRequestKnowledgeParamsSourceCollection : TeaModel {
                /// <summary>
                /// <para>The name of the collection to search.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_index_adb_50943_prod</para>
                /// </summary>
                [NameInMap("Collection")]
                [Validation(Required=false)]
                public string Collection { get; set; }

                /// <summary>
                /// <para>The namespace that contains the collection.</para>
                /// <remarks>
                /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2401502.html">ListNamespaces</a> operation to view available namespaces.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>ddstar_vector</para>
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <para>The password for the specified namespace.</para>
                /// <remarks>
                /// <para>This value is specified in the <c>CreateNamespace</c> operation.</para>
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
                /// <para>Parameters for the knowledge base query.</para>
                /// </summary>
                [NameInMap("QueryParams")]
                [Validation(Required=false)]
                public ChatWithKnowledgeBaseStreamRequestKnowledgeParamsSourceCollectionQueryParams QueryParams { get; set; }
                public class ChatWithKnowledgeBaseStreamRequestKnowledgeParamsSourceCollectionQueryParams : TeaModel {
                    /// <summary>
                    /// <para>A filter expression to apply to the search, similar to a SQL <c>WHERE</c> clause.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>method_id=\&quot;e41695f0-2851-40ac-b21d-dd337b60d71c\&quot;</para>
                    /// </summary>
                    [NameInMap("Filter")]
                    [Validation(Required=false)]
                    public string Filter { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to enable knowledge graph enhancement. Default value: <c>false</c>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("GraphEnhance")]
                    [Validation(Required=false)]
                    public bool? GraphEnhance { get; set; }

                    /// <summary>
                    /// <para>The parameters for knowledge graph search.</para>
                    /// </summary>
                    [NameInMap("GraphSearchArgs")]
                    [Validation(Required=false)]
                    public ChatWithKnowledgeBaseStreamRequestKnowledgeParamsSourceCollectionQueryParamsGraphSearchArgs GraphSearchArgs { get; set; }
                    public class ChatWithKnowledgeBaseStreamRequestKnowledgeParamsSourceCollectionQueryParamsGraphSearchArgs : TeaModel {
                        /// <summary>
                        /// <para>The number of top entities and relationship edges to return. Default value: <c>60</c>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>60</para>
                        /// </summary>
                        [NameInMap("GraphTopK")]
                        [Validation(Required=false)]
                        public long? GraphTopK { get; set; }

                    }

                    /// <summary>
                    /// <para>Specifies the hybrid search algorithm. If omitted, the system performs a basic score comparison of vector search and full-text retrieval results.</para>
                    /// <para>Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><c>RRF</c>: Reciprocal rank fusion. Configure the <c>k</c> parameter in <c>HybridSearchArgs</c>.</para>
                    /// </description></item>
                    /// <item><description><para><c>Weight</c>: Weighted score fusion. Use the <c>alpha</c> parameter in <c>HybridSearchArgs</c> to control the balance between vector and full-text search scores.</para>
                    /// </description></item>
                    /// <item><description><para><c>Cascaded</c>: First performs full-text retrieval, then runs a vector search on the results.</para>
                    /// </description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Cascaded</para>
                    /// </summary>
                    [NameInMap("HybridSearch")]
                    [Validation(Required=false)]
                    public string HybridSearch { get; set; }

                    /// <summary>
                    /// <para>The arguments for the specified hybrid search algorithm. Supports <c>RRF</c> and <c>Weight</c>.</para>
                    /// <list type="bullet">
                    /// <item><description><c>RRF</c>: Specifies the constant <c>k</c> in the score calculation formula <c>1/(k+rank_i)</c>. <c>k</c> must be an integer greater than 1. Format:</description></item>
                    /// </list>
                    /// <pre><c>{ 
                    ///    &quot;RRF&quot;: {
                    ///     &quot;k&quot;: 60
                    ///    }
                    /// }
                    /// </c></pre>
                    /// <list type="bullet">
                    /// <item><description><c>Weight</c>: Calculates the final score using the formula <c>alpha * vector_score + (1 - alpha) * text_score</c>. The <c>alpha</c> parameter balances the scores, ranging from 0 (full-text only) to 1 (vector only). Format:</description></item>
                    /// </list>
                    /// <pre><c>{ 
                    ///    &quot;Weight&quot;: {
                    ///     &quot;alpha&quot;: 0.5
                    ///    }
                    /// }
                    /// </c></pre>
                    /// </summary>
                    [NameInMap("HybridSearchArgs")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> HybridSearchArgs { get; set; }

                    /// <summary>
                    /// <para>The distance metric for vector search. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><para><c>l2</c>: Euclidean distance.</para>
                    /// </description></item>
                    /// <item><description><para><c>ip</c>: Inner product.</para>
                    /// </description></item>
                    /// <item><description><para><c>cosine</c>: Cosine similarity.</para>
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
                    /// <para>The recall window. Specifies a window of context to include around retrieved chunks. The value must be a two-element array <c>[A, B]</c>, where -10 &lt;= A &lt;= 0 and 0 &lt;= B &lt;= 10.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description><para>This parameter is useful when document chunks are small and a search might miss important surrounding context.</para>
                    /// </description></item>
                    /// <item><description><para>The window is applied after reranking.</para>
                    /// </description></item>
                    /// </list>
                    /// </remarks>
                    /// </summary>
                    [NameInMap("RecallWindow")]
                    [Validation(Required=false)]
                    public List<long?> RecallWindow { get; set; }

                    /// <summary>
                    /// <para>The rerank factor. If specified, the system reranks the results from the vector search. The value must be greater than 1 and less than or equal to 5.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description><para>Reranking may be inefficient if document chunks are sparse.</para>
                    /// </description></item>
                    /// <item><description><para>The number of items to rerank, calculated as <c>ceil(TopK * RerankFactor)</c>, should not exceed 50.</para>
                    /// </description></item>
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
                    /// <para>The rerank model to use.</para>
                    /// </summary>
                    [NameInMap("RerankModel")]
                    [Validation(Required=false)]
                    public ChatWithKnowledgeBaseStreamRequestKnowledgeParamsSourceCollectionQueryParamsRerankModel RerankModel { get; set; }
                    public class ChatWithKnowledgeBaseStreamRequestKnowledgeParamsSourceCollectionQueryParamsRerankModel : TeaModel {
                        /// <summary>
                        /// <para>An instruction for the rerank model.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Given a web search query, retrieve relevant passages that answer the query</para>
                        /// </summary>
                        [NameInMap("Instruct")]
                        [Validation(Required=false)]
                        public string Instruct { get; set; }

                        /// <summary>
                        /// <para>The name of the rerank model.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>qwen3-rerank</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                    }

                    /// <summary>
                    /// <para>The number of top results to return from this collection.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>101</para>
                    /// </summary>
                    [NameInMap("TopK")]
                    [Validation(Required=false)]
                    public long? TopK { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to use full-text retrieval for hybrid search. If <c>false</c> (the default), only vector search is performed.</para>
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
            /// <para>The total number of top results to return after merging results from all collections.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("TopK")]
            [Validation(Required=false)]
            public long? TopK { get; set; }

        }

        /// <summary>
        /// <para>An object that contains parameters for the Large Language Model (LLM) call.</para>
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
            /// <para>A list of messages in the conversation.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Messages")]
            [Validation(Required=false)]
            public List<ChatWithKnowledgeBaseStreamRequestModelParamsMessages> Messages { get; set; }
            public class ChatWithKnowledgeBaseStreamRequestModelParamsMessages : TeaModel {
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
            /// <para>The name of the Large Language Model to use. For a list of available models, refer to the <a href="https://help.aliyun.com/zh/model-studio/compatibility-of-openai-with-dashscope?spm=openapi-amp.newDocPublishment.0.0.257c281fH8TtM8%5C&scm=20140722.H_2833609._.OR_help-T_cn~zh-V_1#eadfc13038jd5">Model Studio documentation</a>.</para>
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
            /// <para>The presence penalty. A value between -2.0 and 2.0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("PresencePenalty")]
            [Validation(Required=false)]
            public double? PresencePenalty { get; set; }

            /// <summary>
            /// <para>The random seed for sampling.</para>
            /// 
            /// <b>Example:</b>
            /// <para>42</para>
            /// </summary>
            [NameInMap("Seed")]
            [Validation(Required=false)]
            public long? Seed { get; set; }

            /// <summary>
            /// <para>A list of stop sequences.</para>
            /// </summary>
            [NameInMap("Stop")]
            [Validation(Required=false)]
            public List<string> Stop { get; set; }

            /// <summary>
            /// <para>The sampling temperature. A value between 0 and 2.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.6</para>
            /// </summary>
            [NameInMap("Temperature")]
            [Validation(Required=false)]
            public double? Temperature { get; set; }

            /// <summary>
            /// <para>A list of tools the model can call.</para>
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
                    /// <para>A description of the function tool.</para>
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
                    /// <para>The parameters of the function, described as a JSON Schema object.</para>
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
            /// <para>The nucleus sampling probability threshold. A value between 0 and 1.</para>
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
        /// <para>A template for the system prompt. It must include placeholders such as <c>{{text_chunks}}</c>, <c>{{user_system_prompt}}</c>, <c>{{graph_entities}}</c>, and <c>{{graph_relations}}</c>. If omitted, no custom prompt template is applied.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;参考以下知识回答问题:{{ text_chunks }}&quot;</para>
        /// </summary>
        [NameInMap("PromptParams")]
        [Validation(Required=false)]
        public string PromptParams { get; set; }

        /// <summary>
        /// <para>The instance\&quot;s region ID.</para>
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
