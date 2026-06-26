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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/196830.html">DescribeDBInstances</a> operation to query the details of all instances in the target region, including the instance ID.</para>
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
        /// <para>The knowledge retrieval parameter object. If not specified, only chat is performed.</para>
        /// </summary>
        [NameInMap("KnowledgeParams")]
        [Validation(Required=false)]
        public ChatWithKnowledgeBaseRequestKnowledgeParams KnowledgeParams { get; set; }
        public class ChatWithKnowledgeBaseRequestKnowledgeParams : TeaModel {
            /// <summary>
            /// <para>The method for merging multiple knowledge bases. Default is RRF. Valid values:</para>
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
            /// <para>The parameters for multi-knowledge base fusion.</para>
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
                    /// <para>The k constant in the scoring algorithm 1/(k+rank_i). The value must be a positive integer greater than 1.</para>
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
            /// <para>The reranking factor. When this value is not empty, the vector retrieval results are reranked. Value range: 1 &lt; RerankFactor &lt;= 5.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>Reranking is slow when document segmentation is sparse.</description></item>
            /// <item><description>It is recommended that the number of items to rerank (TopK * Factor, rounded up) does not exceed 50.</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1.0001</para>
            /// </summary>
            [NameInMap("RerankFactor")]
            [Validation(Required=false)]
            public double? RerankFactor { get; set; }

            [NameInMap("RerankModel")]
            [Validation(Required=false)]
            public ChatWithKnowledgeBaseRequestKnowledgeParamsRerankModel RerankModel { get; set; }
            public class ChatWithKnowledgeBaseRequestKnowledgeParamsRerankModel : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>Given a web search query, retrieve relevant passages that answer the query</para>
                /// </summary>
                [NameInMap("Instruct")]
                [Validation(Required=false)]
                public string Instruct { get; set; }

                /// <summary>
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
                /// <para>The name of the collection to recall.</para>
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
                /// <para>You can create a namespace by calling the <a href="https://help.aliyun.com/document_detail/2401495.html">CreateNamespace</a> operation, and view the list by calling the <a href="https://help.aliyun.com/document_detail/2401502.html">ListNamespaces</a> operation.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>dukang</para>
                /// </summary>
                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                /// <summary>
                /// <para>The password corresponding to the namespace.</para>
                /// <remarks>
                /// <para>This value is specified in the CreateNamespace operation.</para>
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
                /// <para>The parameters related to knowledge base retrieval.</para>
                /// </summary>
                [NameInMap("QueryParams")]
                [Validation(Required=false)]
                public ChatWithKnowledgeBaseRequestKnowledgeParamsSourceCollectionQueryParams QueryParams { get; set; }
                public class ChatWithKnowledgeBaseRequestKnowledgeParamsSourceCollectionQueryParams : TeaModel {
                    /// <summary>
                    /// <para>The filter condition for the data to be updated, in SQL WHERE clause format.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>id = \&quot;llm-t87l87fxuhn56woc_8anu8j2d3f_file_e74635e2cc314e838543e724f6b3b1f2_10658020\&quot;</para>
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
                    /// <para>The number of top entities and relationship edges to return. Default value: 60.</para>
                    /// </summary>
                    [NameInMap("GraphSearchArgs")]
                    [Validation(Required=false)]
                    public ChatWithKnowledgeBaseRequestKnowledgeParamsSourceCollectionQueryParamsGraphSearchArgs GraphSearchArgs { get; set; }
                    public class ChatWithKnowledgeBaseRequestKnowledgeParamsSourceCollectionQueryParamsGraphSearchArgs : TeaModel {
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
                    /// <para>The multi-path recall algorithm. Default is empty (i.e., directly compares and sorts the dense vector and full-text scores).</para>
                    /// <para>Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>RRF: Reciprocal Rank Fusion. Has a parameter k to control the fusion effect. See HybridSearchArgs configuration for details.</description></item>
                    /// <item><description>Weight: Weight-based sorting. Uses parameters to control the score weights of vector and full-text retrieval, then sorts. See HybridSearchArgs configuration for details.</description></item>
                    /// <item><description>Cascaded: First performs full-text retrieval, then performs vector retrieval on top of it.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>RRF</para>
                    /// </summary>
                    [NameInMap("HybridSearch")]
                    [Validation(Required=false)]
                    public string HybridSearch { get; set; }

                    /// <summary>
                    /// <para>The algorithm parameters for multi-path recall. Currently supports RRF and Weight. HybridPathsSetting can specify recall of dense vectors (dense), sparse vectors (sparse), and full-text retrieval (fulltext). If the value is empty, dense vectors (dense) and full-text retrieval (fulltext) are recalled by default.</para>
                    /// <list type="bullet">
                    /// <item><description>RRF: Specifies the k constant in the scoring algorithm <c>1/(k+rank_i)</c>. The value must be a positive integer greater than 1. Format:</description></item>
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
                    /// <item><description>Dual-path recall (without specifying HybridPathsSetting, only specifying alpha):<list type="bullet">
                    /// <item><description>Formula: alpha * dense_score + (1-alpha) * fulltext_score. The parameter alpha represents the score weight between dense vector and full-text retrieval, ranging from 0 to 1, where 0 means full-text only and 1 means dense vector only:</description></item>
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
                    /// <item><description>Three-path recall mode:<list type="bullet">
                    /// <item><description>Formula: normalized_dense * dense_score + normalized_sparse * sparse_score + normalized_fulltext * fulltext_score. Where dense, sparse, and fulltext represent the weights for dense vector, sparse vector, and full-text retrieval respectively, with values greater than or equal to 0. The system automatically normalizes the weights to the range 0-1 (i.e., normalized_x = x / (dense + sparse + fulltext)).</description></item>
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
                    /// <para>The method used when building the vector index. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>l2: Euclidean distance.</description></item>
                    /// <item><description>ip: Inner product distance.</description></item>
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
                    /// <para>The recall window. When this value is not empty, additional context of the retrieval results is returned. The format is a 2-element array: List&lt;A, B&gt;, where -10 &lt;= A &lt;= 0 and 0 &lt;= B &lt;= 10.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>It is recommended to use this parameter when document segmentation is too granular and retrieval may lose contextual information.</description></item>
                    /// <item><description>Reranking takes priority over windowing, meaning reranking is performed first, then windowing is applied.</description></item>
                    /// </list>
                    /// </remarks>
                    /// </summary>
                    [NameInMap("RecallWindow")]
                    [Validation(Required=false)]
                    public List<long?> RecallWindow { get; set; }

                    /// <summary>
                    /// <para>The reranking factor. When this value is not empty, the vector retrieval results are reranked. Value range: 1 &lt; RerankFactor &lt;= 5.</para>
                    /// <remarks>
                    /// <list type="bullet">
                    /// <item><description>Reranking is slow when document segmentation is sparse.</description></item>
                    /// <item><description>It is recommended that the number of items to rerank (TopK * Factor, rounded up) does not exceed 50.</description></item>
                    /// </list>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1.5</para>
                    /// </summary>
                    [NameInMap("RerankFactor")]
                    [Validation(Required=false)]
                    public double? RerankFactor { get; set; }

                    [NameInMap("RerankModel")]
                    [Validation(Required=false)]
                    public ChatWithKnowledgeBaseRequestKnowledgeParamsSourceCollectionQueryParamsRerankModel RerankModel { get; set; }
                    public class ChatWithKnowledgeBaseRequestKnowledgeParamsSourceCollectionQueryParamsRerankModel : TeaModel {
                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>Given a web search query, retrieve relevant passages that answer the query</para>
                        /// </summary>
                        [NameInMap("Instruct")]
                        [Validation(Required=false)]
                        public string Instruct { get; set; }

                        /// <summary>
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
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("TopK")]
                    [Validation(Required=false)]
                    public long? TopK { get; set; }

                    /// <summary>
                    /// <para>Specifies whether to use full-text retrieval (dual-path recall). Default value: false, which means only vector retrieval is used.</para>
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
            /// <para>The number of top results to return after merging the recall results from multiple vector collections.</para>
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
            /// <para>The name of the large model to use. For valid values, see: <a href="https://help.aliyun.com/zh/model-studio/compatibility-of-openai-with-dashscope?spm=a2c4g.11186623.help-menu-2400256.d_2_10_0.45b5516eZIciC8&scm=20140722.H_2833609._.OR_help-T_cn~zh-V_1#eadfc13038jd5">Bailian Help Documentation</a></para>
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
            /// <para>The presence penalty coefficient (-2.0 to 2.0).</para>
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
            /// <para>The stop word list.</para>
            /// </summary>
            [NameInMap("Stop")]
            [Validation(Required=false)]
            public List<string> Stop { get; set; }

            /// <summary>
            /// <para>The sampling temperature (0 to 2).</para>
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
                    /// <para>The function tool description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>获取天气。</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The function tool name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>get_weather</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The function parameters in JSON Schema format.</para>
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
            /// <para>The nucleus sampling probability threshold (0 to 1).</para>
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
        /// <para>The system prompt template, which must include {{ text_chunks }}, {{ user_system_prompt }}, {{ graph_entities }}, and {{ graph_relations }}. If not specified, this part does not take effect.</para>
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
