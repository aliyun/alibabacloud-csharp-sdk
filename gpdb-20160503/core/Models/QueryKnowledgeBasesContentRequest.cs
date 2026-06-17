// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class QueryKnowledgeBasesContentRequest : TeaModel {
        /// <summary>
        /// <para>The text content to search for.</para>
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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> operation to view the details of all AnalyticDB for PostgreSQL instances in a specific region, including their instance IDs.</para>
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
        /// <para>The method for merging results from multiple knowledge bases. The default value is <c>RRF</c>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>RRF</para>
        /// </description></item>
        /// <item><description><para>Weight</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RRF</para>
        /// </summary>
        [NameInMap("MergeMethod")]
        [Validation(Required=false)]
        public string MergeMethod { get; set; }

        /// <summary>
        /// <para>The arguments for the specified <c>MergeMethod</c>.</para>
        /// </summary>
        [NameInMap("MergeMethodArgs")]
        [Validation(Required=false)]
        public QueryKnowledgeBasesContentRequestMergeMethodArgs MergeMethodArgs { get; set; }
        public class QueryKnowledgeBasesContentRequestMergeMethodArgs : TeaModel {
            /// <summary>
            /// <para>The parameters that you can configure when <c>MergeMethod</c> is set to <c>RRF</c>.</para>
            /// </summary>
            [NameInMap("Rrf")]
            [Validation(Required=false)]
            public QueryKnowledgeBasesContentRequestMergeMethodArgsRrf Rrf { get; set; }
            public class QueryKnowledgeBasesContentRequestMergeMethodArgsRrf : TeaModel {
                /// <summary>
                /// <para>The constant <c>k</c> in the scoring formula <c>1/(k+rank_i)</c>. It must be a positive integer greater than 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("K")]
                [Validation(Required=false)]
                public long? K { get; set; }

            }

            /// <summary>
            /// <para>The parameters that you can configure when <c>MergeMethod</c> is set to <c>Weight</c>.</para>
            /// </summary>
            [NameInMap("Weight")]
            [Validation(Required=false)]
            public QueryKnowledgeBasesContentRequestMergeMethodArgsWeight Weight { get; set; }
            public class QueryKnowledgeBasesContentRequestMergeMethodArgsWeight : TeaModel {
                /// <summary>
                /// <para>An array of weights for each source collection.</para>
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
        /// <para>The reranking factor. If specified, the system reranks the final merged results. Valid values: 1 &lt; RerankFactor &lt;= 5.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>Sparse document chunking reduces reranking efficiency.</para>
        /// </description></item>
        /// <item><description><para>We recommend that the number of items to rerank (TopK × Factor, rounded up) does not exceed 50.</para>
        /// </description></item>
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
        /// <para>Parameters for the rerank model applied to the final merged results.</para>
        /// </summary>
        [NameInMap("RerankModel")]
        [Validation(Required=false)]
        public QueryKnowledgeBasesContentRequestRerankModel RerankModel { get; set; }
        public class QueryKnowledgeBasesContentRequestRerankModel : TeaModel {
            /// <summary>
            /// <para>This parameter can be set only when <c>RerankModel.Name</c> is <c>qwen3-rerank</c>. Use this parameter to provide a custom instruction that guides the model\&quot;s ranking strategy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Given a web search query, retrieve relevant passages that answer the query</para>
            /// </summary>
            [NameInMap("Instruct")]
            [Validation(Required=false)]
            public string Instruct { get; set; }

            /// <summary>
            /// <para>The name of the rerank model. Valid values: <c>qwen3-rerank</c> and <c>gte-rerank-v2</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>qwen3-rerank</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        /// <summary>
        /// <para>The source collections to search.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SourceCollection")]
        [Validation(Required=false)]
        public List<QueryKnowledgeBasesContentRequestSourceCollection> SourceCollection { get; set; }
        public class QueryKnowledgeBasesContentRequestSourceCollection : TeaModel {
            /// <summary>
            /// <para>The document collection name.</para>
            /// <remarks>
            /// <para>To create a document collection, call the <a href="https://help.aliyun.com/document_detail/2618448.html">CreateDocumentCollection</a> operation. To view existing document collections, call the <a href="https://help.aliyun.com/document_detail/2618452.html">ListDocumentCollections</a> operation.</para>
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
            /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2401495.html">CreateNamespace</a> operation to create a namespace and call the <a href="https://help.aliyun.com/document_detail/2401502.html">ListNamespaces</a> operation to view existing namespaces.</para>
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
            /// <para>You specify this value when you call the <a href="https://help.aliyun.com/document_detail/2401495.html">CreateNamespace</a> operation.</para>
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
            /// <para>The query parameters for the source collection.</para>
            /// </summary>
            [NameInMap("QueryParams")]
            [Validation(Required=false)]
            public QueryKnowledgeBasesContentRequestSourceCollectionQueryParams QueryParams { get; set; }
            public class QueryKnowledgeBasesContentRequestSourceCollectionQueryParams : TeaModel {
                /// <summary>
                /// <para>A filter expression for the data to retrieve, formatted as a SQL <c>WHERE</c> clause. This is a Boolean expression that evaluates to <c>true</c> or <c>false</c>. The expression can include simple comparison operators (such as <c>=</c>, <c>&lt;&gt;</c>, <c>!=</c>, <c>&gt;</c>, <c>&lt;</c>, <c>&gt;=</c>, and <c>&lt;=</c>), logical operators (<c>AND</c>, <c>OR</c>, <c>NOT</c>), and keywords such as <c>IN</c>, <c>BETWEEN</c>, and <c>LIKE</c>.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>For syntax details, see <a href="https://www.postgresqltutorial.com/postgresql-tutorial/postgresql-where/">PostgreSQL WHERE</a>.</description></item>
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
                /// <para>Specifies whether to enable knowledge graph enhancement. The default value is <c>false</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("GraphEnhance")]
                [Validation(Required=false)]
                public bool? GraphEnhance { get; set; }

                /// <summary>
                /// <para>Parameters for the graph search.</para>
                /// </summary>
                [NameInMap("GraphSearchArgs")]
                [Validation(Required=false)]
                public QueryKnowledgeBasesContentRequestSourceCollectionQueryParamsGraphSearchArgs GraphSearchArgs { get; set; }
                public class QueryKnowledgeBasesContentRequestSourceCollectionQueryParamsGraphSearchArgs : TeaModel {
                    /// <summary>
                    /// <para>The number of top entities and relationship edges to return. The default value is 60.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>60</para>
                    /// </summary>
                    [NameInMap("GraphTopK")]
                    [Validation(Required=false)]
                    public long? GraphTopK { get; set; }

                }

                /// <summary>
                /// <para>The hybrid search algorithm. If this parameter is not specified, the system directly compares and sorts the scores from dense vector and full-text searches.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>RRF</c>: Reciprocal rank fusion. Uses a parameter <c>k</c> to control the fusion effect. For more information, see the <c>HybridSearchArgs</c> parameter.</para>
                /// </description></item>
                /// <item><description><para><c>Weight</c>: Weighted ranking. Uses parameters to control the score weights from different retrieval paths, such as dense vector and full-text searches, before sorting. For more information, see the <c>HybridSearchArgs</c> parameter.</para>
                /// </description></item>
                /// <item><description><para><c>Cascaded</c>: Performs a full-text search first, and then performs a vector search on the results.</para>
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
                /// <para>The parameters for the hybrid search algorithm. <c>RRF</c> and <c>Weight</c> are supported. <c>HybridPathsSetting</c> specifies the retrieval paths: dense vectors (<c>dense</c>), sparse vectors (<c>sparse</c>), and full-text search (<c>fulltext</c>). If this parameter is not specified, the default paths are <c>dense</c> and <c>fulltext</c>.</para>
                /// <list type="bullet">
                /// <item><description><c>RRF</c>: Specifies the constant <c>k</c> in the scoring formula <c>1/(k+rank_i)</c>. <c>k</c> must be a positive integer greater than 1. Format:</description></item>
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
                /// <item><description><para>Two-path retrieval (the default if you do not specify <c>HybridPathsSetting</c>):</para>
                /// <list type="bullet">
                /// <item><description>Scoring formula: <c>alpha * dense_score + (1-alpha) * fulltext_score</c>. The <c>alpha</c> parameter represents the score weight of dense vectors relative to full-text search. The value must be in the range of [0, 1]. A value of 0 indicates full-text search only, and a value of 1 indicates dense vector search only.</description></item>
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
                /// <item><description><para>Three-path retrieval:</para>
                /// <list type="bullet">
                /// <item><description>Scoring formula: <c>normalized_dense * dense_score + normalized_sparse * sparse_score + normalized_fulltext * fulltext_score</c>. The <c>dense</c>, <c>sparse</c>, and <c>fulltext</c> parameters represent the weights for dense vectors, sparse vectors, and full-text search, respectively. The value of each weight must be greater than or equal to 0. The system automatically normalizes the weights to a range of [0, 1] (for example, <c>normalized_x = x / (dense + sparse + fulltext)</c>).</description></item>
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
                /// <para>The distance metric used for building the vector index. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para><c>l2</c>: Euclidean distance.</para>
                /// </description></item>
                /// <item><description><para><c>ip</c>: Inner product distance.</para>
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
                /// <para>The offset for paged queries.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Offset")]
                [Validation(Required=false)]
                public int? Offset { get; set; }

                /// <summary>
                /// <para>Specifies the field by which to sort the results. By default, this parameter is empty.</para>
                /// <para>The field must be a metadata field or a default field in the table, such as <c>id</c>. The following formats are supported:</para>
                /// <para>A single field, such as <c>chunk_id</c>. Multiple fields separated by commas, such as <c>block_id, chunk_id</c>. Descending order, such as <c>block_id DESC, chunk_id DESC</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>file_id,sort_num</para>
                /// </summary>
                [NameInMap("OrderBy")]
                [Validation(Required=false)]
                public string OrderBy { get; set; }

                /// <summary>
                /// <para>The recall window. If specified, adds context from surrounding document chunks to the search results. The format is a two-element array <c>[A, B]</c>, where <c>-10 &lt;= A &lt;= 0</c> and <c>0 &lt;= B &lt;= 10</c>.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description><para>This parameter is recommended for finely chunked documents where retrieval might otherwise lose context.</para>
                /// </description></item>
                /// <item><description><para>The system applies reranking before applying the recall window.</para>
                /// </description></item>
                /// </list>
                /// </remarks>
                /// </summary>
                [NameInMap("RecallWindow")]
                [Validation(Required=false)]
                public List<long?> RecallWindow { get; set; }

                /// <summary>
                /// <para>The reranking factor. If specified, the system reranks the results from this source collection before they are merged. Valid values: 1 &lt; RerankFactor &lt;= 5.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description><para>Sparse document chunking reduces reranking efficiency.</para>
                /// </description></item>
                /// <item><description><para>We recommend that the number of items to rerank (TopK × Factor, rounded up) does not exceed 50.</para>
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
                /// <para>Parameters for the rerank model applied to the results from this specific source collection before the final merge.</para>
                /// </summary>
                [NameInMap("RerankModel")]
                [Validation(Required=false)]
                public QueryKnowledgeBasesContentRequestSourceCollectionQueryParamsRerankModel RerankModel { get; set; }
                public class QueryKnowledgeBasesContentRequestSourceCollectionQueryParamsRerankModel : TeaModel {
                    /// <summary>
                    /// <para>This parameter can be set only when <c>RerankModel.Name</c> is <c>qwen3-rerank</c>. Use this parameter to provide a custom instruction that guides the model\&quot;s ranking strategy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Given a web search query, retrieve relevant passages that answer the query</para>
                    /// </summary>
                    [NameInMap("Instruct")]
                    [Validation(Required=false)]
                    public string Instruct { get; set; }

                    /// <summary>
                    /// <para>The name of the rerank model. Valid values: <c>qwen3-rerank</c> and <c>gte-rerank-v2</c>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>qwen3-rerank</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                /// <summary>
                /// <para>The number of top results to return from this source collection.</para>
                /// 
                /// <b>Example:</b>
                /// <para>776</para>
                /// </summary>
                [NameInMap("TopK")]
                [Validation(Required=false)]
                public long? TopK { get; set; }

                /// <summary>
                /// <para>Specifies whether to use full-text search, which enables two-path retrieval. The default value is <c>false</c>, which indicates that only vector retrieval is performed.</para>
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
        /// <para>The number of top results to return after the results from all recall paths are merged.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TopK")]
        [Validation(Required=false)]
        public long? TopK { get; set; }

    }

}
