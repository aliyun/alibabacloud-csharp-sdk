// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class QueryKnowledgeBasesContentRequest : TeaModel {
        /// <summary>
        /// <para>The text content used for retrieval.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>What is ADBPG?</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> operation to query the details of all AnalyticDB for PostgreSQL instances in a region, including instance IDs.</para>
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
        /// <para>The method used to merge results from multiple knowledge bases. Default value: RRF. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>RRF</description></item>
        /// <item><description>Weight</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RRF</para>
        /// </summary>
        [NameInMap("MergeMethod")]
        [Validation(Required=false)]
        public string MergeMethod { get; set; }

        /// <summary>
        /// <para>The parameters for the merge method of each SourceCollection.</para>
        /// </summary>
        [NameInMap("MergeMethodArgs")]
        [Validation(Required=false)]
        public QueryKnowledgeBasesContentRequestMergeMethodArgs MergeMethodArgs { get; set; }
        public class QueryKnowledgeBasesContentRequestMergeMethodArgs : TeaModel {
            /// <summary>
            /// <para>The configurable parameters when MergeMethod is set to RRF.</para>
            /// </summary>
            [NameInMap("Rrf")]
            [Validation(Required=false)]
            public QueryKnowledgeBasesContentRequestMergeMethodArgsRrf Rrf { get; set; }
            public class QueryKnowledgeBasesContentRequestMergeMethodArgsRrf : TeaModel {
                /// <summary>
                /// <para>The k constant in the scoring algorithm <c>1/(k+rank_i)</c>. The value must be a positive integer greater than 1.</para>
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
            public QueryKnowledgeBasesContentRequestMergeMethodArgsWeight Weight { get; set; }
            public class QueryKnowledgeBasesContentRequestMergeMethodArgsWeight : TeaModel {
                /// <summary>
                /// <para>The weight array for each SourceCollection.</para>
                /// </summary>
                [NameInMap("Weights")]
                [Validation(Required=false)]
                public List<double?> Weights { get; set; }

            }

        }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The reranking factor. If this parameter is not empty, the vector retrieval results are reranked. Valid values: 1 &lt; RerankFactor &lt;= 5.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Reranking is slow when document chunks are sparse.</description></item>
        /// <item><description>The recommended reranking count (TopK × Factor, rounded up) should not exceed 50.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("RerankFactor")]
        [Validation(Required=false)]
        public double? RerankFactor { get; set; }

        /// <summary>
        /// <para>The reranking model parameters for performing an additional reranking on the overall results after multi-channel merging.</para>
        /// </summary>
        [NameInMap("RerankModel")]
        [Validation(Required=false)]
        public QueryKnowledgeBasesContentRequestRerankModel RerankModel { get; set; }
        public class QueryKnowledgeBasesContentRequestRerankModel : TeaModel {
            /// <summary>
            /// <para>This parameter can be set when RerankModel.Name is set to qwen3-rerank. Specifies a custom ranking task type description that guides the model to adopt different ranking strategies.</para>
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
        /// <para>The information about the multiple collections to retrieve.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SourceCollection")]
        [Validation(Required=false)]
        public List<QueryKnowledgeBasesContentRequestSourceCollection> SourceCollection { get; set; }
        public class QueryKnowledgeBasesContentRequestSourceCollection : TeaModel {
            /// <summary>
            /// <para>The document collection name.</para>
            /// <remarks>
            /// <para>Created by the <a href="https://help.aliyun.com/document_detail/2618448.html">CreateDocumentCollection</a> operation. You can call the <a href="https://help.aliyun.com/document_detail/2618452.html">ListDocumentCollections</a> operation to view existing document collections.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>knowledge22</para>
            /// </summary>
            [NameInMap("Collection")]
            [Validation(Required=false)]
            public string Collection { get; set; }

            /// <summary>
            /// <para>The namespace.</para>
            /// <remarks>
            /// <para>You can create a namespace by calling the <a href="https://help.aliyun.com/document_detail/2401495.html">CreateNamespace</a> operation and view the list by calling the <a href="https://help.aliyun.com/document_detail/2401502.html">ListNamespaces</a> operation.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>ns_cloud_index</para>
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>The password for the namespace.</para>
            /// <remarks>
            /// <para>This value is specified by the <a href="https://help.aliyun.com/document_detail/2401495.html">CreateNamespace</a> operation.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ns_password</para>
            /// </summary>
            [NameInMap("NamespacePassword")]
            [Validation(Required=false)]
            public string NamespacePassword { get; set; }

            /// <summary>
            /// <para>The filter conditions for the data to query, in SQL WHERE clause format.</para>
            /// </summary>
            [NameInMap("QueryParams")]
            [Validation(Required=false)]
            public QueryKnowledgeBasesContentRequestSourceCollectionQueryParams QueryParams { get; set; }
            public class QueryKnowledgeBasesContentRequestSourceCollectionQueryParams : TeaModel {
                /// <summary>
                /// <para>The filter conditions for the data to query, in SQL WHERE clause format. This is an expression that returns a Boolean value (true or false). Conditions can be simple comparison operators such as equal to (=), not equal to (&lt;&gt; or !=), greater than (&gt;), less than (&lt;), greater than or equal to (&gt;=), or less than or equal to (&lt;=). Conditions can also be more complex expressions combined with logical operators (AND, OR, NOT), as well as conditions using the IN, BETWEEN, and LIKE keywords.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>For detailed syntax, refer to: <a href="https://www.postgresqltutorial.com/postgresql-tutorial/postgresql-where/">https://www.postgresqltutorial.com/postgresql-tutorial/postgresql-where/</a></description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>id = \&quot;llm-52tvykqt6u67iw73_j6ovptwjk7_file_6ce3da1f7e69495d9f491f2180c86973_11967297\&quot;</para>
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
                /// <para>The number of top entities and relationship edges to return. Default value: 60.</para>
                /// </summary>
                [NameInMap("GraphSearchArgs")]
                [Validation(Required=false)]
                public QueryKnowledgeBasesContentRequestSourceCollectionQueryParamsGraphSearchArgs GraphSearchArgs { get; set; }
                public class QueryKnowledgeBasesContentRequestSourceCollectionQueryParamsGraphSearchArgs : TeaModel {
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
                /// <para>The multi-channel recall algorithm. Default value: empty (scores from dense vectors and full-text retrieval are directly compared and sorted).</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>RRF: Reciprocal rank fusion. A parameter k controls the fusion effect. For more information, see the HybridSearchArgs configuration.</description></item>
                /// <item><description>Weight: Weighted ranking. Parameters control the score weights of vector retrieval and full-text retrieval results before sorting. For more information, see the HybridSearchArgs configuration.</description></item>
                /// <item><description>Cascaded: Full-text retrieval is performed first, followed by vector retrieval on the full-text retrieval results.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Cascaded</para>
                /// </summary>
                [NameInMap("HybridSearch")]
                [Validation(Required=false)]
                public string HybridSearch { get; set; }

                /// <summary>
                /// <para>The algorithm parameters for multi-channel recall. RRF and Weight are supported. HybridPathsSetting specifies the recall paths: dense vectors (dense), sparse vectors (sparse), and full-text retrieval (fulltext). If this value is empty, dense vectors (dense) and full-text retrieval (fulltext) are used by default.</para>
                /// <list type="bullet">
                /// <item><description>RRF: The k constant in the scoring algorithm <c>1/(k+rank_i)</c>. The value must be a positive integer greater than 1. Format:</description></item>
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
                /// <item><description>Formula: alpha * dense_score + (1-alpha) * fulltext_score. The alpha parameter specifies the score weight between dense vectors and full-text retrieval. Valid values: 0 to 1, where 0 indicates full-text retrieval only and 1 indicates dense vectors only:</description></item>
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
                /// <item><description>Three-path recall pattern:<list type="bullet">
                /// <item><description>Formula: normalized_dense * dense_score + normalized_sparse * sparse_score + normalized_fulltext * fulltext_score. The dense, sparse, and fulltext parameters represent the weights for dense vectors, sparse vectors, and full-text retrieval respectively. Valid values: greater than or equal to 0. The system automatically applies normalization to the weights to 0 to 1 (normalized_x = x / (dense + sparse + fulltext)).</description></item>
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
                /// <para>The offset for paged query. Used for paging through results.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Offset")]
                [Validation(Required=false)]
                public int? Offset { get; set; }

                /// <summary>
                /// <para>The field used for sorting. Default value: empty.</para>
                /// <para>The field must belong to metadata or a default field in the table, such as id. Supported formats:</para>
                /// <para>A single field, such as chunk_id.
                /// Multiple fields separated by commas, such as block_id, chunk_id.
                /// Descending order, such as block_id DESC, chunk_id DESC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>file_id,sort_num</para>
                /// </summary>
                [NameInMap("OrderBy")]
                [Validation(Required=false)]
                public string OrderBy { get; set; }

                /// <summary>
                /// <para>The recall window. If this value is not empty, additional context is returned for the retrieval results. The format is a two-element array: List&lt;A, B&gt;, where -10 &lt;= A &lt;= 0 and 0 &lt;= B &lt;= 10.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>Use this parameter when document chunks are too granular and retrieval may lose context information.</description></item>
                /// <item><description>Reranking takes priority over windowing. Reranking is performed first, followed by windowing.</description></item>
                /// </list>
                /// </remarks>
                /// </summary>
                [NameInMap("RecallWindow")]
                [Validation(Required=false)]
                public List<long?> RecallWindow { get; set; }

                /// <summary>
                /// <para>The reranking factor. If this parameter is not empty, the vector retrieval results are reranked. Valid values: 1 &lt; RerankFactor &lt;= 5.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>Reranking is slow when document chunks are sparse.</description></item>
                /// <item><description>The recommended reranking count (TopK × Factor, rounded up) should not exceed 50.</description></item>
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
                public QueryKnowledgeBasesContentRequestSourceCollectionQueryParamsRerankModel RerankModel { get; set; }
                public class QueryKnowledgeBasesContentRequestSourceCollectionQueryParamsRerankModel : TeaModel {
                    /// <summary>
                    /// <para>This parameter can be set when RerankModel.Name is set to qwen3-rerank. Specifies a custom ranking task type description that guides the model to adopt different ranking strategies.</para>
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
                /// <para>776</para>
                /// </summary>
                [NameInMap("TopK")]
                [Validation(Required=false)]
                public long? TopK { get; set; }

                /// <summary>
                /// <para>Specifies whether to use full-text retrieval (dual-path recall). Default value: false, which indicates that only vector retrieval is used.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("UseFullTextRetrieval")]
                [Validation(Required=false)]
                public bool? UseFullTextRetrieval { get; set; }

            }

        }

        /// <summary>
        /// <para>The number of top results to return after multi-channel recall merging.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TopK")]
        [Validation(Required=false)]
        public long? TopK { get; set; }

    }

}
