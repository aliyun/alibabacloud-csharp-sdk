// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class QueryCollectionDataRequest : TeaModel {
        /// <summary>
        /// <para>Collection name.</para>
        /// <remarks>
        /// <para>You can use the <a href="https://help.aliyun.com/document_detail/2401503.html">ListCollections</a> API to view the list.</para>
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
        /// <para>Content for full-text search. When this value is empty, only vector search is used; when it is not empty, both vector and full-text search are used.</para>
        /// <remarks>
        /// <para>The Vector parameter cannot be empty at the same time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>hello_world</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>Instance ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> API to view details of all AnalyticDB PostgreSQL instances in the target region, including the instance ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>gp-xxxxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// <para>Dual-path recall algorithm, default is empty (i.e., directly compare and sort the scores of vectors and full-text).</para>
        /// <para>Available values:</para>
        /// <list type="bullet">
        /// <item><description>RRF: Reciprocal rank fusion, with a parameter k controlling the fusion effect. See HybridSearchArgs configuration for details;</description></item>
        /// <item><description>Weight: Weighted sorting, using a parameter alpha to control the score ratio of vectors and full-text, then sorting. See HybridSearchArgs configuration for details;</description></item>
        /// <item><description>Cascaded: Perform full-text search first, then vector search based on the full-text results;</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RRF</para>
        /// </summary>
        [NameInMap("HybridSearch")]
        [Validation(Required=false)]
        public string HybridSearch { get; set; }

        /// <summary>
        /// <para>The parameters of the two-way retrieval algorithm. The following parameters are supported:</para>
        /// <list type="bullet">
        /// <item><description>When HybridSearch is set to RRF, the scores are calculated by using the <c>1/(k+rank_i)</c> formula. The constant k is a positive integer that is greater than 1.</description></item>
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
        /// <item><description>When HybridSearch is set to Weight, the scores are calculated by using the <c>alpha * vector_score + (1-alpha) * text_score</c> formula. The alpha parameter specifies the proportion of the vector search score and the full-text search score and ranges from 0 to 1. A value of 0 specifies full-text search and a value of 1 specifies vector search.</description></item>
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
        public Dictionary<string, Dictionary<string, object>> HybridSearchArgs { get; set; }

        /// <summary>
        /// <para>Defaults to empty, indicating the metadata fields to return. Multiple fields should be separated by commas.</para>
        /// 
        /// <b>Example:</b>
        /// <para>title,content</para>
        /// </summary>
        [NameInMap("IncludeMetadataFields")]
        [Validation(Required=false)]
        public string IncludeMetadataFields { get; set; }

        /// <summary>
        /// <para>Whether to return vector data. Value descriptions:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Return vector data.</description></item>
        /// <item><description><b>false</b>: Do not return vector data, used for full-text search scenarios.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IncludeValues")]
        [Validation(Required=false)]
        public bool? IncludeValues { get; set; }

        /// <summary>
        /// <para>Similarity algorithm used during retrieval. Value descriptions:</para>
        /// <list type="bullet">
        /// <item><description><b>l2</b>: Euclidean distance.</description></item>
        /// <item><description><b>ip</b>: Inner product (dot product) distance.</description></item>
        /// <item><description><b>cosine</b>: Cosine similarity.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If this value is empty, the algorithm specified during index creation is used.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cosine</para>
        /// </summary>
        [NameInMap("Metrics")]
        [Validation(Required=false)]
        public string Metrics { get; set; }

        /// <summary>
        /// <para>Namespace.</para>
        /// <remarks>
        /// <para>You can use the <a href="https://help.aliyun.com/document_detail/2401502.html">ListNamespaces</a> API to view the list.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>mynamespace</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>Password for the namespace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testpassword</para>
        /// </summary>
        [NameInMap("NamespacePassword")]
        [Validation(Required=false)]
        public string NamespacePassword { get; set; }

        /// <summary>
        /// <para>Defaults to empty, indicating the starting point for pagination queries. Does not support hybrid search scenarios.</para>
        /// <para>The value must be &gt;= 0. When this value is not empty, it will return <c>Total</c>, which indicates the total number of hits. This parameter works with <c>TopK</c>. For example, to paginate 20 and retrieve chunks with <c>chunk_id</c> from 0 to 44, you need to make three requests:</para>
        /// <list type="bullet">
        /// <item><description><c>Offset=0, TopK=20</c> returns <c>chunk_id</c> 0~19</description></item>
        /// <item><description><c>Offset=20, TopK=20</c> returns <c>chunk_id</c> 20~39</description></item>
        /// <item><description><c>Offset=30, TopK=20</c> returns <c>chunk_id</c> 40~44</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Offset")]
        [Validation(Required=false)]
        public int? Offset { get; set; }

        /// <summary>
        /// <para>Defaults to empty, indicating the field for sorting. Does not support hybrid search scenarios.</para>
        /// <para>The field must belong to metadata or be a default field in the table, such as <c>id</c>. The supported formats are:</para>
        /// <list type="bullet">
        /// <item><description>A single field, e.g., <c>chunk_id</c>;</description></item>
        /// <item><description>Multiple fields, separated by commas, e.g., <c>block_id, chunk_id</c>;</description></item>
        /// <item><description>Supports reverse order, e.g., <c>block_id DESC, chunk_id DESC</c>;</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>chunk_id</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>Region ID where the instance is located.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Uses another relational table to filter vector data (similar to a Join function).</para>
        /// <remarks>
        /// <para>Data from the relational table can be returned by setting the <c>IncludeMetadataFields</c> parameter. For example, <c>rds_table_name.id</c> indicates returning the <c>id</c> field from the relational table.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("RelationalTableFilter")]
        [Validation(Required=false)]
        public QueryCollectionDataRequestRelationalTableFilter RelationalTableFilter { get; set; }
        public class QueryCollectionDataRequestRelationalTableFilter : TeaModel {
            /// <summary>
            /// <para>The Metadata field of the vector collection, used to associate with the fields in the vector table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>doc_id</para>
            /// </summary>
            [NameInMap("CollectionMetadataField")]
            [Validation(Required=false)]
            public string CollectionMetadataField { get; set; }

            /// <summary>
            /// <para>The filtering condition for the relational table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tags @&gt; ARRAY[\&quot;art\&quot;]</para>
            /// </summary>
            [NameInMap("Condition")]
            [Validation(Required=false)]
            public string Condition { get; set; }

            /// <summary>
            /// <para>The field in the relational table, used to associate with the Metadata field of the vector collection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>id</para>
            /// </summary>
            [NameInMap("TableField")]
            [Validation(Required=false)]
            public string TableField { get; set; }

            /// <summary>
            /// <para>The name of the relational table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my_rds_table</para>
            /// </summary>
            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

        }

        [NameInMap("SparseVector")]
        [Validation(Required=false)]
        public QueryCollectionDataRequestSparseVector SparseVector { get; set; }
        public class QueryCollectionDataRequestSparseVector : TeaModel {
            [NameInMap("Indices")]
            [Validation(Required=false)]
            public List<long?> Indices { get; set; }

            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<double?> Values { get; set; }

        }

        /// <summary>
        /// <para>Set the number of top results to return.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TopK")]
        [Validation(Required=false)]
        public long? TopK { get; set; }

        /// <summary>
        /// <para>Vector data, with the same dimension as specified in the <a href="https://help.aliyun.com/document_detail/2401497.html">CreateCollection</a> API.</para>
        /// <remarks>
        /// <para>When the vector is empty, only full-text search results are returned.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("Vector")]
        [Validation(Required=false)]
        public List<double?> Vector { get; set; }

        /// <summary>
        /// <para>The ID of the Workspace composed of multiple database instances. This parameter and <c>DBInstanceId</c> cannot both be empty. If both are specified, this parameter takes precedence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-ws-*****</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
