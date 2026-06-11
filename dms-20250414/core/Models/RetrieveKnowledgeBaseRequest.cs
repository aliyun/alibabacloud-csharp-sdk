// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms20250414.Models
{
    public class RetrieveKnowledgeBaseRequest : TeaModel {
        /// <summary>
        /// <para>A filter for the data, specified as a SQL <c>WHERE</c> clause.</para>
        /// 
        /// <b>Example:</b>
        /// <para>title = \&quot;test\&quot; AND name like \&quot;test%\&quot;</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// <para>The hybrid search algorithm. If this parameter is not set, the system directly compares and ranks the scores from the dense vector and full-text searches.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>RRF</c>: Reciprocal Rank Fusion. This method uses a parameter <c>k</c> to control the fusion effect. For more information, see the <c>HybridSearchArgs</c> configuration.</para>
        /// </description></item>
        /// <item><description><para><c>Weight</c>: Weighted ranking. This method applies weights to the vector and full-text search scores before ranking. For more information, see the <c>HybridSearchArgs</c> configuration.</para>
        /// </description></item>
        /// <item><description><para><c>Cascaded</c>: Performs a full-text search first, followed by a vector search on the results of the full-text search.</para>
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
        /// <para>Parameters for the specified <c>HybridSearch</c> algorithm. Both <c>RRF</c> and <c>Weight</c> are supported. You can use the <c>HybridPathsSetting</c> object to specify the retrieval paths: dense vector (<c>dense</c>), sparse vector (<c>sparse</c>), and full-text search (<c>fulltext</c>). If this object is not provided, the default retrieval paths are <c>dense</c> and <c>fulltext</c>.</para>
        /// <list type="bullet">
        /// <item><description><c>RRF</c>: Specifies the constant <c>k</c> in the scoring formula <c>1/(k+rank_i)</c>. The value of <c>k</c> must be an integer greater than 1. The format is as follows:</description></item>
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
        /// <item><description><para>Two-path recall (do not specify <c>HybridPathsSetting</c>; specify only <c>alpha</c>):</para>
        /// <list type="bullet">
        /// <item><description>The score is calculated using the formula: <c>alpha * dense_score + (1-alpha) * fulltext_score</c>. The <c>alpha</c> parameter balances the scores from the dense vector and full-text searches. Its value must be in the range [0, 1], where 0 relies solely on full-text search, and 1 relies solely on dense vector search.</description></item>
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
        /// <item><description><para>Three-path recall:</para>
        /// <list type="bullet">
        /// <item><description>The score is calculated using the formula: <c>normalized_dense * dense_score + normalized_sparse * sparse_score + normalized_fulltext * fulltext_score</c>. The <c>dense</c>, <c>sparse</c>, and <c>fulltext</c> parameters are the weights for the dense vector, sparse vector, and full-text searches, respectively. Their values must be 0 or greater. The system automatically normalizes the weights to sum to 1 (for example, <c>normalized_x = x / (dense + sparse + fulltext)</c>).</description></item>
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
        /// 
        /// <b>Example:</b>
        /// <para>{ \&quot;Weight\&quot;: { \&quot;alpha\&quot;: 0.5 } }</para>
        /// </summary>
        [NameInMap("HybridSearchArgs")]
        [Validation(Required=false)]
        public string HybridSearchArgs { get; set; }

        /// <summary>
        /// <para>The metadata fields to return, separated by commas. By default, no metadata fields are returned.</para>
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
        /// <para>false</para>
        /// </summary>
        [NameInMap("IncludeVector")]
        [Validation(Required=false)]
        public bool? IncludeVector { get; set; }

        /// <summary>
        /// <para>The ID of the knowledge base.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kb-***</para>
        /// </summary>
        [NameInMap("KbUuid")]
        [Validation(Required=false)]
        public string KbUuid { get; set; }

        /// <summary>
        /// <para>The distance metric for retrieval. If unspecified, this defaults to the metric configured for the knowledge base. Only set this parameter if you have specific requirements.</para>
        /// <para>Valid values:</para>
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
        /// <para>The offset for pagination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Offset")]
        [Validation(Required=false)]
        public int? Offset { get; set; }

        /// <summary>
        /// <para>The field to use for sorting the results. By default, this parameter is empty.</para>
        /// <para>The field must be a metadata field or a default table field, such as <c>id</c>. Supported formats include:</para>
        /// <para>You can specify a single field (for example, <c>chunk_id</c>), multiple comma-separated fields (for example, <c>block_id, chunk_id</c>), or fields with descending order (for example, <c>block_id DESC, chunk_id DESC</c>).</para>
        /// 
        /// <b>Example:</b>
        /// <para>created_at</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The query text.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>What is GraphRAG?</para>
        /// </summary>
        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>The recall window. If specified, this parameter expands the context of the retrieved results. The format is a two-element array <c>[A, B]</c>, where <c>-10 &lt;= A &lt;= 0</c> and <c>0 &lt;= B &lt;= 10</c>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>Recommended when document chunks are highly fragmented, which might cause context loss during retrieval.</para>
        /// </description></item>
        /// <item><description><para>Reranking occurs before windowing is applied.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[-5,5]</para>
        /// </summary>
        [NameInMap("RecallWindow")]
        [Validation(Required=false)]
        public string RecallWindow { get; set; }

        /// <summary>
        /// <para>The factor used to rerank vector search results. The value must be in the range (1, 5].</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>Reranking may be slow if document chunks are sparse.</para>
        /// </description></item>
        /// <item><description><para>The number of items to rerank, calculated as <c>ceil(TopK * RerankFactor)</c>, should not exceed 50.</para>
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
        /// <para>The number of top-ranked results to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TopK")]
        [Validation(Required=false)]
        public int? TopK { get; set; }

    }

}
