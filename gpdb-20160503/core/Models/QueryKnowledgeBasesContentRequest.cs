// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class QueryKnowledgeBasesContentRequest : TeaModel {
        /// <summary>
        /// <para>The text content for retrieval.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> operation to query the information about all AnalyticDB for PostgreSQL instances within a region, including instance IDs.</para>
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
        /// <para>The method used to merge multiple knowledge bases. Default value: RRF. Valid values:</para>
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
        /// <para>The parameters of the merge method for each SourceCollection.</para>
        /// </summary>
        [NameInMap("MergeMethodArgs")]
        [Validation(Required=false)]
        public QueryKnowledgeBasesContentRequestMergeMethodArgs MergeMethodArgs { get; set; }
        public class QueryKnowledgeBasesContentRequestMergeMethodArgs : TeaModel {
            /// <summary>
            /// <para>The parameter that can be configured when the MergeMethod parameter is set to RRF.</para>
            /// </summary>
            [NameInMap("Rrf")]
            [Validation(Required=false)]
            public QueryKnowledgeBasesContentRequestMergeMethodArgsRrf Rrf { get; set; }
            public class QueryKnowledgeBasesContentRequestMergeMethodArgsRrf : TeaModel {
                /// <summary>
                /// <para>The smoothing constant k in the formula to calculate the score: 1/(k + rank_i). The k constant must be a positive integer greater than 1.</para>
                /// 
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("K")]
                [Validation(Required=false)]
                public long? K { get; set; }

            }

            /// <summary>
            /// <para>The parameter that you can configure when you set the MergeMethod parameter to Weight.</para>
            /// </summary>
            [NameInMap("Weight")]
            [Validation(Required=false)]
            public QueryKnowledgeBasesContentRequestMergeMethodArgsWeight Weight { get; set; }
            public class QueryKnowledgeBasesContentRequestMergeMethodArgsWeight : TeaModel {
                /// <summary>
                /// <para>An array of weights for each SourceCollection.</para>
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
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The rerank factor. If you specify this parameter, the vector retrieval results are reranked once more. Valid values: 1\&lt;RerankFactor&lt;=5.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If the document is segmented into sparse parts, reranking is inefficient.</para>
        /// </description></item>
        /// <item><description><para>We recommend that the number of reranked results (the ceiling of TopK × RerankFactor) not exceed 50.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("RerankFactor")]
        [Validation(Required=false)]
        public double? RerankFactor { get; set; }

        /// <summary>
        /// <para>The information about collections to retrieve from.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SourceCollection")]
        [Validation(Required=false)]
        public List<QueryKnowledgeBasesContentRequestSourceCollection> SourceCollection { get; set; }
        public class QueryKnowledgeBasesContentRequestSourceCollection : TeaModel {
            /// <summary>
            /// <para>The name of the document collection.</para>
            /// <remarks>
            /// <para> You can call the <a href="https://help.aliyun.com/document_detail/2618448.html">CreateDocumentCollection</a> operation to create a document collection and call the <a href="https://help.aliyun.com/document_detail/2618452.html">ListDocumentCollections</a> operation to query a list of document collections.</para>
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
            /// <para> You can call the <a href="https://help.aliyun.com/document_detail/2401495.html">CreateNamespace</a> operation to create a namespace and call the <a href="https://help.aliyun.com/document_detail/2401502.html">ListNamespaces</a> operation to query a list of namespaces.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>ns_cloud_index</para>
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>The password of the namespace.</para>
            /// <remarks>
            /// <para> The value of this parameter is specified when you call the <a href="https://help.aliyun.com/document_detail/2401495.html">CreateNamespace</a> operation.</para>
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
            /// <para>The condition that is used to filter the data to be updated. Specify this parameter in a format that is the same as the WHERE clause.</para>
            /// </summary>
            [NameInMap("QueryParams")]
            [Validation(Required=false)]
            public QueryKnowledgeBasesContentRequestSourceCollectionQueryParams QueryParams { get; set; }
            public class QueryKnowledgeBasesContentRequestSourceCollectionQueryParams : TeaModel {
                /// <summary>
                /// <para>The filter condition that is used to query data. Specify this parameter in a format that is the same as the WHERE clause. The parameter is an expression that returns a Boolean value of TRUE or FALSE. The condition can be a simple comparison using operators such as equal (=), not equal (&lt;&gt; or !=), greater than (&gt;), less than (&lt;), greater than or equal (&gt;=), or less than or equal (&lt;=). It can also be a more complex expression combining multiple conditions with logical operators (AND, OR, NOT), or use keywords such as IN, BETWEEN, and LIKE.</para>
                /// <remarks>
                /// </remarks>
                /// <list type="bullet">
                /// <item><description>For the syntax, see <a href="https://www.postgresqltutorial.com/postgresql-tutorial/postgresql-where/">https://www.postgresqltutorial.com/postgresql-tutorial/postgresql-where/</a>.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>id = \&quot;llm-52tvykqt6u67iw73_j6ovptwjk7_file_6ce3da1f7e69495d9f491f2180c86973_11967297\&quot;</para>
                /// </summary>
                [NameInMap("Filter")]
                [Validation(Required=false)]
                public string Filter { get; set; }

                /// <summary>
                /// <para>Whether to enable knowledge graph enhancement. Default value: false.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("GraphEnhance")]
                [Validation(Required=false)]
                public bool? GraphEnhance { get; set; }

                /// <summary>
                /// <para>Returns the top number of entities and relationship edges. Default value: 60.</para>
                /// </summary>
                [NameInMap("GraphSearchArgs")]
                [Validation(Required=false)]
                public QueryKnowledgeBasesContentRequestSourceCollectionQueryParamsGraphSearchArgs GraphSearchArgs { get; set; }
                public class QueryKnowledgeBasesContentRequestSourceCollectionQueryParamsGraphSearchArgs : TeaModel {
                    /// <summary>
                    /// <para>Returns the top number of entities and relationship edges. Default value: 60.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>60</para>
                    /// </summary>
                    [NameInMap("GraphTopK")]
                    [Validation(Required=false)]
                    public long? GraphTopK { get; set; }

                }

                /// <summary>
                /// <para>The dual-path retrieval algorithm. This parameter is empty by default, which specifies that scores of vector retrieval and full-text retrieval are directly compared and sorted together.</para>
                /// <para>Valid values:</para>
                /// <list type="bullet">
                /// <item><description>RRF: The reciprocal rank fusion (RRF) algorithm uses a constant k to control the fusion effect. For more information, see the description of the HybridSearchArgs parameter.</description></item>
                /// <item><description>Weight: This algorithm uses the alpha parameter to specify the proportion of the vector search score and the full-text search score and then sorts by weight. For more information, see the description of the HybridSearchArgs parameter.</description></item>
                /// <item><description>Cascaded: This algorithm performs first full-text retrieval and then vector retrieval.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Cascaded</para>
                /// </summary>
                [NameInMap("HybridSearch")]
                [Validation(Required=false)]
                public string HybridSearch { get; set; }

                /// <summary>
                /// <para>The parameters of the dual-path retrieval algorithm. RRF and Weight are supported at this time:</para>
                /// <list type="bullet">
                /// <item><description>RRF: Specifies the smoothing constant k in the formula to calculate the score: <c>1/(k + rank_i)</c>. The k constant must be a positive integer greater than 1. The format:</description></item>
                /// </list>
                /// <!---->
                /// 
                /// <pre><c>{ 
                ///    &quot;RRF&quot;: {
                ///     &quot;k&quot;: 60
                ///    }
                /// }
                /// </c></pre>
                /// <list type="bullet">
                /// <item><description>Weight: The score is computed as <c>alpha * vector_score + (1 - alpha) * text_score</c>. The parameter alpha controls the weighting between vector search and full-text search scores, with a valid range of [0, 1]. 0 specifies only full-text search score. 1 specifies only vector search score.</description></item>
                /// </list>
                /// <!---->
                /// 
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
                /// <para>The method that is used to create vector indexes. Valid values:</para>
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
                /// <para>Offset for pagination.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("Offset")]
                [Validation(Required=false)]
                public int? Offset { get; set; }

                /// <summary>
                /// <para>The fields by which to sort the results. This parameter is empty by default.</para>
                /// <para>The field must be either a metadata field or a default field in the table (e.g., id). Supported formats include:</para>
                /// <para>Single field, such as chunk_id. Multiple fields that are separated by commas (,), such as block_id,chunk_id. Descending order is supported, such as block_id DESC,chunk_id DESC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>file_id,sort_num</para>
                /// </summary>
                [NameInMap("OrderBy")]
                [Validation(Required=false)]
                public string OrderBy { get; set; }

                /// <summary>
                /// <para>The retrieval window. If you specify this parameter, the context of the retrieved result is added in the output. Format: List\&lt;A, B&gt;. Valid values: -10&lt;=A&lt;=0 and 0&lt;=B&lt;=10.</para>
                /// <remarks>
                /// </remarks>
                /// <list type="bullet">
                /// <item><description><para>We recommend that you specify this parameter if the source document is segmented into large numbers of pieces, which may result in loss of contextual information during retrieval.</para>
                /// </description></item>
                /// <item><description><para>Perform re-ranking before windowing.</para>
                /// </description></item>
                /// </list>
                /// </summary>
                [NameInMap("RecallWindow")]
                [Validation(Required=false)]
                public List<long?> RecallWindow { get; set; }

                /// <summary>
                /// <para>The rerank factor. If you specify this parameter, the vector retrieval results are reranked once more. Valid values: 1\&lt;RerankFactor&lt;=5.</para>
                /// <remarks>
                /// </remarks>
                /// <list type="bullet">
                /// <item><description><para>If the document is segmented into sparse parts, reranking is inefficient.</para>
                /// </description></item>
                /// <item><description><para>We recommend that the number of reranked results (the ceiling of TopK × RerankFactor) not exceed 50.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2.0</para>
                /// </summary>
                [NameInMap("RerankFactor")]
                [Validation(Required=false)]
                public double? RerankFactor { get; set; }

                /// <summary>
                /// <para>The number of top results.</para>
                /// 
                /// <b>Example:</b>
                /// <para>776</para>
                /// </summary>
                [NameInMap("TopK")]
                [Validation(Required=false)]
                public long? TopK { get; set; }

                /// <summary>
                /// <para>Specifies whether to use full-text retrieval (dual-path retrieval). The default value is false, which means only vector retrieval is used.</para>
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
        /// <para>Set the number of top results to be returned after merging results from multiple path retrieval.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TopK")]
        [Validation(Required=false)]
        public long? TopK { get; set; }

    }

}
