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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> operation to query the details of all AnalyticDB for PostgreSQL instances in a specific region, including the instance IDs.</para>
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
            public QueryKnowledgeBasesContentRequestMergeMethodArgsWeight Weight { get; set; }
            public class QueryKnowledgeBasesContentRequestMergeMethodArgsWeight : TeaModel {
                /// <summary>
                /// <para>The array of weights for each SourceCollection.</para>
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
        /// <para>The reranking factor. If this value is not empty, the vector retrieve results are reranked. Valid values: 1 &lt; RerankFactor &lt;= 5.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Reranking is slow when document chunks are sparse.</description></item>
        /// <item><description>We recommend that the number of reranked items (TopK × Factor, rounded up) does not exceed 50.</description></item>
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
        /// <para>The parameters of the reranking model used to rerank the merged multi-channel results.</para>
        /// </summary>
        [NameInMap("RerankModel")]
        [Validation(Required=false)]
        public QueryKnowledgeBasesContentRequestRerankModel RerankModel { get; set; }
        public class QueryKnowledgeBasesContentRequestRerankModel : TeaModel {
            /// <summary>
            /// <para>This parameter can be set when RerankModel.Name is set to qwen3-rerank. Adds a custom description for the sorting task type. You can use this parameter to guide the model to adopt different sorting strategies.</para>
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
        /// <para>The information about multiple collections to be retrieved.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SourceCollection")]
        [Validation(Required=false)]
        public List<QueryKnowledgeBasesContentRequestSourceCollection> SourceCollection { get; set; }
        public class QueryKnowledgeBasesContentRequestSourceCollection : TeaModel {
            /// <summary>
            /// <para>The name of the document collection.</para>
            /// <remarks>
            /// <para>Created by the <a href="https://help.aliyun.com/document_detail/2618448.html">CreateDocumentCollection</a> operation. You can call the <a href="https://help.aliyun.com/document_detail/2618452.html">ListDocumentCollections</a> operation to view the created document collections.</para>
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
            /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2401495.html">CreateNamespace</a> operation to create a namespace and the <a href="https://help.aliyun.com/document_detail/2401502.html">ListNamespaces</a> operation to view the namespace list.</para>
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
            /// <para>This value is specified when you call the <a href="https://help.aliyun.com/document_detail/2401495.html">CreateNamespace</a> operation.</para>
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
            /// <para>The filter condition for the data to be updated, in the SQL WHERE clause format.</para>
            /// </summary>
            [NameInMap("QueryParams")]
            [Validation(Required=false)]
            public QueryKnowledgeBasesContentRequestSourceCollectionQueryParams QueryParams { get; set; }
            public class QueryKnowledgeBasesContentRequestSourceCollectionQueryParams : TeaModel {
                /// <summary>
                /// <para>The filter condition for the data to be queried, in the SQL WHERE clause format. It is an expression that returns a Boolean value (true or false). The condition can be a simple comparison operator such as equal to (=), not equal to (&lt;&gt; or !=), greater than (&gt;), less than (&lt;), greater than or equal to (&gt;=), or less than or equal to (&lt;=). It can also be a more complex expression combined with logical operators (AND, OR, NOT), or a condition using keywords such as IN, BETWEEN, and LIKE.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>For detailed syntax, refer to <a href="https://www.postgresqltutorial.com/postgresql-tutorial/postgresql-where/">https://www.postgresqltutorial.com/postgresql-tutorial/postgresql-where/</a>.</description></item>
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
                /// <para>The multi-channel recall algorithm. Default value: empty, which means directly comparing and sorting the scores of dense vectors and full text. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>RRF: Reciprocal Rank Fusion. A parameter k is used to control the fusion effect. For more information, see the HybridSearchArgs configuration.</description></item>
                /// <item><description>Weight: Weighted sorting. Parameters are used to control the score weights of vectors and full text before sorting. For more information, see the HybridSearchArgs configuration.</description></item>
                /// <item><description>Cascaded: Full-text retrieve is performed first, followed by vector retrieve based on the full-text retrieve results.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Cascaded</para>
                /// </summary>
                [NameInMap("HybridSearch")]
                [Validation(Required=false)]
                public string HybridSearch { get; set; }

                /// <summary>
                /// <para>The algorithm parameters for multi-channel recall. Currently, RRF and Weight are supported. You can use HybridPathsSetting to specify the recall of dense vectors (dense), sparse vectors (sparse), and full-text index (fulltext). If this value is empty, dense vectors (dense) and full-text index (fulltext) are recalled by default.</para>
                /// <list type="bullet">
                /// <item><description>RRF: Specifies the constant k in the score calculation formula 1/(k+rank_i). The value must be a positive integer greater than 1. Format:</description></item>
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
                /// <item><description>Calculation formula: alpha * dense_score + (1-alpha) * fulltext_score. The alpha parameter represents the score weight of dense vectors and full-text index retrieve score. The value ranges from 0 to 1, where 0 indicates full-text index only and 1 indicates dense vectors only:</description></item>
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
                /// <item><description>Triple-channel recall pattern:<list type="bullet">
                /// <item><description>Calculation formula: normalized_dense * dense_score + normalized_sparse * sparse_score + normalized_fulltext * fulltext_score. Here, dense, sparse, and fulltext represent the weights of dense vectors, sparse vectors, and full-text index, respectively. The value must be greater than or equal to 0. The system automatically performs normalization on the weights to 0 to 1 (that is, normalized_x = x / (dense + sparse + fulltext)).</description></item>
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
                /// <para>The offset used for paging in a paged query.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Offset")]
                [Validation(Required=false)]
                public int? Offset { get; set; }

                /// <summary>
                /// <para>The field based on which the results are sorted. Default value: empty.</para>
                /// <para>The field must belong to metadata or be a default field in the table, such as id. Supported formats:</para>
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
                /// <para>The recall window. If this value is not empty, the context of the retrieval results is additionally returned. The format is an array of two elements: List&lt;A, B&gt;, where -10 &lt;= A &lt;= 0 and 0 &lt;= B &lt;= 10.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>We recommend that you use this parameter when document chunks are too small and retrieval may lose context information.</description></item>
                /// <item><description>Reranking takes precedence over windowing. That is, reranking is performed before windowing.</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>[0,0]</para>
                /// </summary>
                [NameInMap("RecallWindow")]
                [Validation(Required=false)]
                public List<long?> RecallWindow { get; set; }

                /// <summary>
                /// <para>The reranking factor. If this value is not empty, the vector retrieve results are reranked. Valid values: 1 &lt; RerankFactor &lt;= 5.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>Reranking is slow when document chunks are sparse.</description></item>
                /// <item><description>We recommend that the number of reranked items (TopK × Factor, rounded up) does not exceed 50.</description></item>
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
                /// <para>The parameters of the reranking model.</para>
                /// </summary>
                [NameInMap("RerankModel")]
                [Validation(Required=false)]
                public QueryKnowledgeBasesContentRequestSourceCollectionQueryParamsRerankModel RerankModel { get; set; }
                public class QueryKnowledgeBasesContentRequestSourceCollectionQueryParamsRerankModel : TeaModel {
                    /// <summary>
                    /// <para>This parameter can be set when RerankModel.Name is set to qwen3-rerank. Adds a custom description for the sorting task type. You can use this parameter to guide the model to adopt different sorting strategies.</para>
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
                    /// <para>The metadata fields that participate in reranking. Separate multiple fields with commas (,). By default, only the document content (content) is used for reranking. The field names must be defined in the metadata of the collection.</para>
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
                /// <para>776</para>
                /// </summary>
                [NameInMap("TopK")]
                [Validation(Required=false)]
                public long? TopK { get; set; }

                /// <summary>
                /// <para>Specifies whether to use full-text retrieve (dual-channel recall). Default value: false, which indicates that only vector retrieve is used.</para>
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
        /// <para>The number of top results to return after multi-channel recall results are merged.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TopK")]
        [Validation(Required=false)]
        public long? TopK { get; set; }

    }

}
