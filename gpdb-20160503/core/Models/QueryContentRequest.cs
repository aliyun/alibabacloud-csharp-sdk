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
        /// <para>The document collection is created by calling the <a href="https://help.aliyun.com/document_detail/2618448.html">CreateDocumentCollection</a> operation. You can call the <a href="https://help.aliyun.com/document_detail/2618452.html">ListDocumentCollections</a> operation to view the created document collections.</para>
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
        /// <para>The source file name of the image to search in image-to-image search scenarios.</para>
        /// <remarks>
        /// <para>The image file must have a file name extension. Supported image file name extensions: bmp, jpg, jpeg, png, and tiff.</para>
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
        /// <para>The image file must have a file name extension. Supported image file name extensions: bmp, jpg, jpeg, png, and tiff.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://xx/myImage.jpg">https://xx/myImage.jpg</a></para>
        /// </summary>
        [NameInMap("FileUrl")]
        [Validation(Required=false)]
        public string FileUrl { get; set; }

        /// <summary>
        /// <para>The filter conditions for the data to query, formatted as an SQL WHERE clause. This is an expression that returns a Boolean value (true or false). The conditions can be simple comparison operators such as equal to (=), not equal to (&lt;&gt; or !=), greater than (&gt;), less than (&lt;), greater than or equal to (&gt;=), and less than or equal to (&lt;=). They can also be more complex expressions combined with logical operators (AND, OR, NOT), or conditions using keywords such as IN, BETWEEN, and LIKE.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>For detailed syntax, refer to <a href="https://www.postgresqltutorial.com/postgresql-tutorial/postgresql-where/">https://www.postgresqltutorial.com/postgresql-tutorial/postgresql-where/</a></description></item>
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
        /// <para>The multi-channel recall algorithm. Default value: empty. If this parameter is empty, the scores of dense vectors and full text are directly compared, and sorting is performed.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>RRF: Reciprocal Rank Fusion. A parameter k is used to control the fusion effect. For more information, see the HybridSearchArgs configuration.</description></item>
        /// <item><description>Weight: Weighted sorting. Parameters are used to control the score weights of vectors and full text before sorting. For more information, see the HybridSearchArgs configuration.</description></item>
        /// <item><description>Cascaded: Full-text retrieval is performed first, and then vector retrieval is performed based on the full-text retrieval results.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RRF</para>
        /// </summary>
        [NameInMap("HybridSearch")]
        [Validation(Required=false)]
        public string HybridSearch { get; set; }

        /// <summary>
        /// <para>The algorithm parameters for multi-channel recall. RRF and Weight are supported. You can use HybridPathsSetting to specify the recall of dense vectors (dense), sparse vectors (sparse), and full-text retrieval (fulltext). If this value is empty, dense vectors (dense) and full-text retrieval (fulltext) are recalled by default.</para>
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
        /// <item><description>Dual-channel recall (HybridPathsSetting is not specified, and only alpha is specified):<list type="bullet">
        /// <item><description>Formula: alpha * dense_score + (1-alpha) * fulltext_score. The alpha parameter indicates the score weights of dense vectors and full-text retrieval. Valid values: 0 to 1. A value of 0 indicates full-text retrieval only, and a value of 1 indicates dense vectors only:</description></item>
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
        /// <item><description>Three-channel recall pattern:<list type="bullet">
        /// <item><description>Formula: normalized_dense * dense_score + normalized_sparse * sparse_score + normalized_fulltext * fulltext_score. The dense, sparse, and fulltext parameters represent the weights of dense vectors, sparse vectors, and full-text retrieval, respectively. Valid values: greater than or equal to 0. The system automatically performs normalization on the weights to 0 to 1 (that is, normalized_x = x / (dense + sparse + fulltext)).</description></item>
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
        /// <para>The metadata fields to return. Default value: empty. Separate multiple fields with commas (,).</para>
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
        /// <item><description><b>false</b>: Vectors are not returned.</description></item>
        /// <item><description><b>true</b>: Vectors are returned.</description></item>
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
        /// <para>The similarity algorithm used during retrieval. If this value is empty, the algorithm specified when the knowledge base is created is used. You do not need to set this parameter unless you have special requirements.</para>
        /// <remarks>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>l2</b>: Euclidean distance.</description></item>
        /// <item><description><b>ip</b>: Dot product (inner product) distance.</description></item>
        /// <item><description><b>cosine</b>: Cosine similarity.</description></item>
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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2401495.html">CreateNamespace</a> operation to create a namespace and call the <a href="https://help.aliyun.com/document_detail/2401502.html">ListNamespaces</a> operation to view the namespace list.</para>
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
        /// <para>This value is specified when you call the <a href="https://help.aliyun.com/document_detail/2401495.html">CreateNamespace</a> operation.</para>
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
        /// <para>The offset used for a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Offset")]
        [Validation(Required=false)]
        public int? Offset { get; set; }

        /// <summary>
        /// <para>The field based on which sorting is performed. Default value: empty. The field must belong to the metadata or be a default field in the table, such as id. Supported formats: a single field, such as chunk_id; multiple fields separated by commas (,), such as block_id, chunk_id; and reverse order, such as block_id DESC, chunk_id DESC.</para>
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
        /// <para>The recall window. When this value is not empty, the context of the retrieval results is additionally returned. The format is an array of two elements: List&lt;A, B&gt;, where -10 &lt;= A &lt;= 0 and 0 &lt;= B &lt;= 10.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Use this parameter when documents are split into excessively small chunks and retrieval may lose context information.</description></item>
        /// <item><description>Reranking takes precedence over windowing. That is, reranking is performed before windowing.</description></item>
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
        /// <para>The reranking factor. When this value is not empty, the vector retrieval results are reranked. Valid values: 1 &lt; RerankFactor &lt;= 5.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>When document chunks are sparse, reranking is slow.</description></item>
        /// <item><description>The number of reranked results (TopK × Factor, rounded up) should not exceed 50.</description></item>
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
        /// <para>The reranking model parameters.</para>
        /// </summary>
        [NameInMap("RerankModel")]
        [Validation(Required=false)]
        public QueryContentRequestRerankModel RerankModel { get; set; }
        public class QueryContentRequestRerankModel : TeaModel {
            /// <summary>
            /// <para>This parameter can be set when RerankModel.Name is set to qwen3-rerank. You can add a custom sorting task description to guide the model to adopt different sorting strategies.</para>
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
            /// <para>The metadata fields that participate in reranking. Separate multiple fields with commas (,). By default, only the document content (content) is used for reranking. The field names must be metadata defined in the collection.</para>
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
        public int? TopK { get; set; }

        /// <summary>
        /// <para>The validity period of the returned image URL.</para>
        /// <remarks>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>The unit can be seconds (s) or days (d). For example, 300s indicates a validity period of 300 seconds, and 60d indicates a validity period of 60 days.</description></item>
        /// <item><description>Valid values: 60s to 365d.</description></item>
        /// <item><description>Default value: 7200s, which is 2 hours.</description></item>
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
        /// <para><b>[Deprecated]</b> Specifies whether to use full-text retrieval (dual-channel recall). Default value: false, which indicates that only vector retrieval is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("UseFullTextRetrieval")]
        [Validation(Required=false)]
        public bool? UseFullTextRetrieval { get; set; }

    }

}
