// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class QueryContentShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The name of the document collection.</para>
        /// <remarks>
        /// <para>A document collection is created by calling the <a href="https://help.aliyun.com/document_detail/2618448.html">CreateDocumentCollection</a> operation. Call the <a href="https://help.aliyun.com/document_detail/2618452.html">ListDocumentCollections</a> operation to list your document collections.</para>
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
        /// <para>The text to use for retrieval.</para>
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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> operation to find the IDs of all AnalyticDB for PostgreSQL instances in a region.</para>
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
        /// <para>The filename of the source image for a search-by-image query.</para>
        /// <remarks>
        /// <para>The image file must have a file extension. The supported extensions are bmp, jpg, jpeg, png, and tiff.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test.jpg</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>The publicly accessible URL of the image file for a search-by-image query.</para>
        /// <remarks>
        /// <para>The image file must have a file extension. The supported extensions are bmp, jpg, jpeg, png, and tiff.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://xx/myImage.jpg">https://xx/myImage.jpg</a></para>
        /// </summary>
        [NameInMap("FileUrl")]
        [Validation(Required=false)]
        public string FileUrl { get; set; }

        /// <summary>
        /// <para>A filter condition for the query, specified as a SQL <c>WHERE</c> clause that returns a boolean value. The clause can use comparison operators (such as <c>=</c>, <c>&lt;&gt;</c>, <c>!=</c>, <c>&gt;</c>, <c>&lt;</c>, <c>&gt;=</c>, and <c>&lt;=</c>), logical operators (<c>AND</c>, <c>OR</c>, and <c>NOT</c>), and keywords such as <c>IN</c>, <c>BETWEEN</c>, and <c>LIKE</c>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>For details about the syntax, see https\://www\.postgresqltutorial.com/postgresql-tutorial/postgresql-where/.</description></item>
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
        /// <para>Specifies whether to enable knowledge graph enhancement. The default value is <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("GraphEnhance")]
        [Validation(Required=false)]
        public bool? GraphEnhance { get; set; }

        /// <summary>
        /// <para>The parameters for knowledge graph retrieval.</para>
        /// </summary>
        [NameInMap("GraphSearchArgs")]
        [Validation(Required=false)]
        public string GraphSearchArgsShrink { get; set; }

        /// <summary>
        /// <para>Specifies the hybrid search algorithm. If this parameter is not specified, the system directly compares and sorts the scores from dense vector retrieval and full-text search.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>RRF: reciprocal rank fusion. This method uses a <c>k</c> parameter to control the fusion effect. For more information, see the <c>HybridSearchArgs</c> parameter.</para>
        /// </description></item>
        /// <item><description><para>Weight: A weighted sorting method. This method uses parameters to control the score weights of vector retrieval and full-text search before sorting. For more information, see the <c>HybridSearchArgs</c> parameter.</para>
        /// </description></item>
        /// <item><description><para>Cascaded: Performs full-text search first, and then performs vector retrieval on the results.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RRF</para>
        /// </summary>
        [NameInMap("HybridSearch")]
        [Validation(Required=false)]
        public string HybridSearch { get; set; }

        /// <summary>
        /// <para>Parameters for the multi-channel recall algorithm. Currently, <c>RRF</c> and <c>Weight</c> are supported. <c>HybridPathsSetting</c> can be used to specify the recall paths, including dense vector search (<c>dense</c>), sparse vector search (<c>sparse</c>), and full-text search (<c>fulltext</c>). If this parameter is not specified, the system recalls dense vectors and full-text search results by default.</para>
        /// <list type="bullet">
        /// <item><description>RRF: Specifies the constant <c>k</c> in the scoring formula <c>1/(k+rank_i)</c>. The value must be an integer greater than 1. Example:</description></item>
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
        /// <item><description><para>Weight:</para>
        /// <list type="bullet">
        /// <item><description><para>For dual-channel recall (if <c>HybridPathsSetting</c> is not specified, only <c>alpha</c> is configured):</para>
        /// <list type="bullet">
        /// <item><description>The score is calculated using the formula: <c>alpha * dense_score + (1-alpha) * fulltext_score</c>. The <c>alpha</c> parameter represents the score weight of dense vector retrieval relative to full-text search. The value must be in the range of 0 to 1. A value of 0 indicates that only full-text search is used, and a value of 1 indicates that only dense vector retrieval is used.</description></item>
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
        /// <item><description><para>For three-channel recall:</para>
        /// <list type="bullet">
        /// <item><description>The score is calculated using the formula: <c>normalized_dense * dense_score + normalized_sparse * sparse_score + normalized_fulltext * fulltext_score</c>. The <c>dense</c>, <c>sparse</c>, and <c>fulltext</c> parameters represent the weights for the dense vector, sparse vector, and full-text search results, respectively. Their values must be greater than or equal to 0. The system automatically normalizes the weights to a sum of 1 (for example, <c>normalized_x = x / (dense + sparse + fulltext)</c>).</description></item>
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
        public string HybridSearchArgsShrink { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the URL of the document. The default value is <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IncludeFileUrl")]
        [Validation(Required=false)]
        public bool? IncludeFileUrl { get; set; }

        /// <summary>
        /// <para>The metadata fields to include in the response. If left empty, no metadata is returned. To specify multiple fields, use a comma-separated list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>title,page</para>
        /// </summary>
        [NameInMap("IncludeMetadataFields")]
        [Validation(Required=false)]
        public string IncludeMetadataFields { get; set; }

        /// <summary>
        /// <para>Specifies whether to include the vector in the results. The default value is <c>false</c>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para><b>false</b>: The vector is not returned.</para>
        /// </description></item>
        /// <item><description><para><b>true</b>: The vector is returned.</para>
        /// </description></item>
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
        /// <para>The similarity algorithm used for retrieval. If this parameter is not specified, the algorithm that was specified when the document collection was created is used. We recommend that you do not set this parameter unless you have specific requirements.</para>
        /// <remarks>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>l2</b>: Euclidean distance.</para>
        /// </description></item>
        /// <item><description><para><b>ip</b>: dot product (inner product) distance.</para>
        /// </description></item>
        /// <item><description><para><b>cosine</b>: cosine similarity.</para>
        /// </description></item>
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
        /// <para>The namespace. The default value is <c>public</c>.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2401495.html">CreateNamespace</a> operation to create a namespace and the <a href="https://help.aliyun.com/document_detail/2401502.html">ListNamespaces</a> operation to list existing namespaces.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>mynamespace</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The password for the namespace.</para>
        /// <remarks>
        /// <para>This password is set when you call the <a href="https://help.aliyun.com/document_detail/2401495.html">CreateNamespace</a> operation.</para>
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
        /// <para>The offset for paginated queries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Offset")]
        [Validation(Required=false)]
        public int? Offset { get; set; }

        /// <summary>
        /// <para>The field to sort the results by. By default, this parameter is empty.</para>
        /// <para>The field must be a metadata field or a default field from the table, such as <c>id</c>. Supported formats include single fields (e.g., <c>chunk_id</c>), multiple comma-separated fields (e.g., <c>block_id, chunk_id</c>), and fields with a sort direction (e.g., <c>block_id DESC, chunk_id DESC</c>).</para>
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
        /// <para>The recall window. If this parameter is specified, additional context is returned with the retrieval results. The value must be a two-element array, <c>[A, B]</c>, where <c>-10 &lt;= A &lt;= 0</c> and <c>0 &lt;= B &lt;= 10</c>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>Use this parameter when documents are finely chunked and retrieval might otherwise lose contextual information.</para>
        /// </description></item>
        /// <item><description><para>Reranking is prioritized over windowing. The system first applies reranking and then processes the window.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// </summary>
        [NameInMap("RecallWindow")]
        [Validation(Required=false)]
        public string RecallWindowShrink { get; set; }

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
        /// <para>The factor for reranking vector retrieval results. The value must be greater than 1 and less than or equal to 5.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>Reranking may be slower if document chunks are sparse.</para>
        /// </description></item>
        /// <item><description><para>For best performance, the number of items to be reranked (<c>TopK</c> \* <c>RerankFactor</c>, rounded up) should not exceed 50.</para>
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
        /// <para>The parameters for the reranking model.</para>
        /// </summary>
        [NameInMap("RerankModel")]
        [Validation(Required=false)]
        public string RerankModelShrink { get; set; }

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
        /// <list type="bullet">
        /// <item><description><para>The value can be specified in seconds (s) or days (d). For example, <c>300s</c> indicates that the link is valid for 300 seconds, and <c>60d</c> indicates that the link is valid for 60 days.</para>
        /// </description></item>
        /// <item><description><para>The value must be in the range of <c>60s</c> to <c>365d</c>.</para>
        /// </description></item>
        /// <item><description><para>Default value: <c>7200s</c> (2 hours).</para>
        /// </description></item>
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
        /// <para>(Deprecated) Specifies whether to use full-text search (dual-channel recall). The default value is <c>false</c>, which means only vector retrieval is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("UseFullTextRetrieval")]
        [Validation(Required=false)]
        public bool? UseFullTextRetrieval { get; set; }

    }

}
