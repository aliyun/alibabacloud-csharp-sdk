// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class QueryContentRequest : TeaModel {
        /// <summary>
        /// <para>The name of the document collection.</para>
        /// <remarks>
        /// <para>The document collection is created by calling the <a href="https://help.aliyun.com/document_detail/2618448.html">CreateDocumentCollection</a> operation. You can call the <a href="https://help.aliyun.com/document_detail/2618452.html">ListDocumentCollections</a> operation to query existing document collections.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>document</para>
        /// </summary>
        [NameInMap("Collection")]
        [Validation(Required=false)]
        public string Collection { get; set; }

        /// <summary>
        /// <para>The text content used for retrieval.</para>
        /// 
        /// <b>Example:</b>
        /// <para>What is AnalyticDB for PostgreSQL?</para>
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
        /// <para>The name of the source image file to search in image-to-image search scenarios.</para>
        /// <remarks>
        /// <para>The image file must have a file extension. Supported image extensions: bmp, jpg, jpeg, png, and tiff.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test.jpg</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>The publicly accessible URL of the image file in image-to-image search scenarios.</para>
        /// <remarks>
        /// <para>The image file must have a file extension. Supported image extensions: bmp, jpg, jpeg, png, and tiff.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://xx/myImage.jpg">https://xx/myImage.jpg</a></para>
        /// </summary>
        [NameInMap("FileUrl")]
        [Validation(Required=false)]
        public string FileUrl { get; set; }

        /// <summary>
        /// <para>The filter condition for the data to query, in SQL WHERE clause format. The filter is an expression that returns a Boolean value (true or false). Conditions can be simple comparison operators such as equal to (=), not equal to (&lt;&gt; or !=), greater than (&gt;), less than (&lt;), greater than or equal to (&gt;=), and less than or equal to (&lt;=). Conditions can also be more complex expressions combined with logical operators (AND, OR, NOT), as well as conditions using the IN, BETWEEN, and LIKE keywords.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>For detailed syntax, refer to: <a href="https://www.postgresqltutorial.com/postgresql-tutorial/postgresql-where/">https://www.postgresqltutorial.com/postgresql-tutorial/postgresql-where/</a>.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>title = \&quot;test\&quot; AND name like \&quot;test%\&quot;</para>
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
        /// <para>The knowledge graph retrieval parameters.</para>
        /// </summary>
        [NameInMap("GraphSearchArgs")]
        [Validation(Required=false)]
        public QueryContentRequestGraphSearchArgs GraphSearchArgs { get; set; }
        public class QueryContentRequestGraphSearchArgs : TeaModel {
            /// <summary>
            /// <para>The number of top entities and relationship edges to return. Default value: 60.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("GraphTopK")]
            [Validation(Required=false)]
            public int? GraphTopK { get; set; }

        }

        /// <summary>
        /// <para>The multi-channel recall algorithm. Default value: empty, which indicates that the dense vector and full-text index scores are directly compared and sorted.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>RRF: Reciprocal Rank Fusion. A parameter k controls the fusion effect. For more information, see the HybridSearchArgs configuration.</description></item>
        /// <item><description>Weight: Weighted sorting. Parameters control the score weights of AISearch retrieve and full-text index results before sorting. For more information, see the HybridSearchArgs configuration.</description></item>
        /// <item><description>Cascaded: Full-text index retrieve is performed first, followed by AISearch retrieve based on the full-text index results.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RRF</para>
        /// </summary>
        [NameInMap("HybridSearch")]
        [Validation(Required=false)]
        public string HybridSearch { get; set; }

        /// <summary>
        /// <para>The algorithm parameters for multi-channel recall. RRF and Weight are supported. HybridPathsSetting specifies the recall paths: dense vectors (dense), sparse vectors (sparse), and full-text index (fulltext). If this value is empty, dense vectors (dense) and full-text index (fulltext) are used by default.</para>
        /// <list type="bullet">
        /// <item><description>RRF: Specifies the constant k in the score calculation formula <c>1/(k+rank_i)</c>. The value must be a positive integer greater than 1. Format:</description></item>
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
        /// <item><description>Formula: alpha * dense_score + (1-alpha) * fulltext_score. The alpha parameter specifies the score weight between dense vectors and full-text index retrieve. Valid values: 0 to 1, where 0 indicates full-text index only and 1 indicates dense vector only:</description></item>
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
        /// <item><description>Formula: normalized_dense * dense_score + normalized_sparse * sparse_score + normalized_fulltext * fulltext_score. The dense, sparse, and fulltext values represent the weights for dense vectors, sparse vectors, and full-text index retrieve respectively. Valid values: greater than or equal to 0. The system automatically performs normalization of the weights to 0 to 1 (normalized_x = x / (dense + sparse + fulltext)).</description></item>
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
        public Dictionary<string, Dictionary<string, object>> HybridSearchArgs { get; set; }

        /// <summary>
        /// <para>Specifies whether to synchronously return the URL of the document. By default, the URL is not returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IncludeFileUrl")]
        [Validation(Required=false)]
        public bool? IncludeFileUrl { get; set; }

        /// <summary>
        /// <para>The metadata fields to return. Default value: empty. Separate multiple fields with commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>title,page</para>
        /// </summary>
        [NameInMap("IncludeMetadataFields")]
        [Validation(Required=false)]
        public string IncludeMetadataFields { get; set; }

        /// <summary>
        /// <para>Specifies whether to return vectors. Default value: false.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><b>false</b>: Does not return vectors.</description></item>
        /// <item><description><b>true</b>: Returns vectors.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IncludeVector")]
        [Validation(Required=false)]
        public bool? IncludeVector { get; set; }

        /// <summary>
        /// <para>The similarity algorithm used for retrieval. If this value is empty, the algorithm specified when the knowledge base was created is used. Leave this parameter empty unless you have specific requirements.</para>
        /// <remarks>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>l2</b>: Euclidean distance.</description></item>
        /// <item><description><b>ip</b>: inner product distance.</description></item>
        /// <item><description><b>cosine</b>: cosine similarity.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cosine</para>
        /// </summary>
        [NameInMap("Metrics")]
        [Validation(Required=false)]
        public string Metrics { get; set; }

        /// <summary>
        /// <para>The namespace. Default value: public.</para>
        /// <remarks>
        /// <para>You can create a namespace by calling the <a href="https://help.aliyun.com/document_detail/2401495.html">CreateNamespace</a> operation and query namespaces by calling the <a href="https://help.aliyun.com/document_detail/2401502.html">ListNamespaces</a> operation.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>mynamespace</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The password of the namespace.</para>
        /// <remarks>
        /// <para>This value is specified by the <a href="https://help.aliyun.com/document_detail/2401495.html">CreateNamespace</a> operation.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testpassword</para>
        /// </summary>
        [NameInMap("NamespacePassword")]
        [Validation(Required=false)]
        public string NamespacePassword { get; set; }

        /// <summary>
        /// <para>The offset for paged query. Used for paging through results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
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
        /// <para>created_at</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The recall window. When this value is not empty, additional context around the retrieval results is returned. The format is a two-element array: List&lt;A, B&gt;, where -10&lt;=A&lt;=0 and 0&lt;=B&lt;=10.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Use this parameter when documents are split into overly small chunks and retrieval may lose contextual information.</description></item>
        /// <item><description>Reranking takes priority over windowing. Reranking is performed first, followed by windowing.</description></item>
        /// </list>
        /// </remarks>
        /// </summary>
        [NameInMap("RecallWindow")]
        [Validation(Required=false)]
        public List<int?> RecallWindow { get; set; }

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

        /// <summary>
        /// <para>The reranking factor. When this value is not empty, the AISearch retrieve results are reranked. Valid values: 1 &lt; RerankFactor &lt;= 5.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Reranking is slow when documents are sparsely chunked.</description></item>
        /// <item><description>The total number of reranked results (TopK × Factor, rounded up) should not exceed 50.</description></item>
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
        /// <para>The rerank model parameters.</para>
        /// </summary>
        [NameInMap("RerankModel")]
        [Validation(Required=false)]
        public QueryContentRequestRerankModel RerankModel { get; set; }
        public class QueryContentRequestRerankModel : TeaModel {
            /// <summary>
            /// <para>This parameter can be set when RerankModel.Name is qwen3-rerank.
            /// Adds a custom sorting task type description. This parameter guides the model to adopt different sorting strategies.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Given a web search query, retrieve relevant passages that answer the query</para>
            /// </summary>
            [NameInMap("Instruct")]
            [Validation(Required=false)]
            public string Instruct { get; set; }

            /// <summary>
            /// <para>The name of the rerank model. Valid values: qwen3-rerank, gte-rerank-v2.</para>
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
        /// <para>10</para>
        /// </summary>
        [NameInMap("TopK")]
        [Validation(Required=false)]
        public int? TopK { get; set; }

        /// <summary>
        /// <para>The validity period of the returned image URL.</para>
        /// <remarks>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Supports seconds (s) and days (d) as units. For example, 300s indicates a validity period of 300 seconds, and 60d indicates a validity period of 60 days.</description></item>
        /// <item><description>Valid values: 60s to 365d.</description></item>
        /// <item><description>Default value: 7200s (2 hours).</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>7200s</para>
        /// </summary>
        [NameInMap("UrlExpiration")]
        [Validation(Required=false)]
        public string UrlExpiration { get; set; }

        /// <summary>
        /// <para>(Deprecated) Specifies whether to use full-text retrieval (dual-path recall). Default value: false, which indicates that only vector retrieval is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("UseFullTextRetrieval")]
        [Validation(Required=false)]
        public bool? UseFullTextRetrieval { get; set; }

    }

}
