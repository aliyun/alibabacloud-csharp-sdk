// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class QueryCollectionDataRequest : TeaModel {
        /// <summary>
        /// <para>The name of the collection.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2401503.html">ListCollections</a> operation to list available collections.</para>
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
        /// <para>The content for full-text search. If this parameter is omitted, only vector search is performed. If this parameter is specified, the system performs a hybrid search of vector search and full-text search.</para>
        /// <remarks>
        /// <para>You must specify one of the Content and Vector parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>hello_world</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> operation to query details for all AnalyticDB for PostgreSQL instances in a region, including their instance IDs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>gp-xxxxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The filter conditions for data retrieval. It is in the format of a WHERE clause in SQL. This expression returns a boolean value, which can be a simple comparison operator, such as <c>=</c>, <c>&lt;&gt;</c>, <c>!=</c>, <c>&gt;</c>, <c>&lt;</c>, <c>&gt;=</c>, and <c>&lt;=</c>, or a more complex expression combined with logical operators, such as <c>AND</c>, <c>OR</c>, and <c>NOT</c>, and keywords such as <c>IN</c>, <c>BETWEEN</c>, and <c>LIKE</c>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>For more information about the syntax, see <a href="https://www.postgresqltutorial.com/postgresql-tutorial/postgresql-where/">PostgreSQL WHERE</a>.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pipeline_id=\&quot;1yhpmo0rbn\&quot; AND (spu=\&quot;10025667796135\&quot; AND dept_id=\&quot;226\&quot;)</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// <para>The hybrid search algorithm. If this parameter is empty, the system ranks results by directly comparing the scores from the vector search and the full-text search.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>RRF</c>: Reciprocal Rank Fusion. This algorithm has a parameter k to control the fusion effect. For more information, see the description of the <c>HybridSearchArgs</c> parameter.</para>
        /// </description></item>
        /// <item><description><para><c>Weight</c>: weighted sort. This algorithm uses a parameter alpha to control the score ratio of vector search and full-text search, and then sorts the results. For more information about the parameter, see the <c>HybridSearchArgs</c> parameter.</para>
        /// </description></item>
        /// <item><description><para><c>Cascaded</c>: performs a full-text search, and then performs a vector search on the search results.</para>
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
        /// <para>The parameters for the hybrid search algorithm. The following algorithms are supported: RRF and Weight.</para>
        /// <list type="bullet">
        /// <item><description>For RRF, specify the constant k in the scoring algorithm <c>1/(k+rank_i)</c>. The value must be a positive integer greater than 1. The format is as follows:</description></item>
        /// </list>
        /// <pre><c>{ 
        ///    &quot;RRF&quot;: {
        ///     &quot;k&quot;: 60
        ///    }
        /// }
        /// </c></pre>
        /// <list type="bullet">
        /// <item><description>For Weight, in the formula <c>alpha * vector_score + (1-alpha) * text_score</c>, the alpha parameter indicates the score ratio of the vector search to the full-text search. The value ranges from 0 to 1. 0 indicates that only the full-text search is used, and 1 indicates that only the vector search is used.</description></item>
        /// </list>
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
        /// <para>This parameter is left empty by default. It specifies the metadata fields to be returned. You can specify multiple fields and separate them with commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>title,content</para>
        /// </summary>
        [NameInMap("IncludeMetadataFields")]
        [Validation(Required=false)]
        public string IncludeMetadataFields { get; set; }

        /// <summary>
        /// <para>Specifies whether to return sparse vector data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: returns sparse vector data.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: does not return sparse vector data.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IncludeSparseValues")]
        [Validation(Required=false)]
        public bool? IncludeSparseValues { get; set; }

        /// <summary>
        /// <para>Specifies whether to return dense vector data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: returns dense vector data.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: does not return dense vector data.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IncludeValues")]
        [Validation(Required=false)]
        public bool? IncludeValues { get; set; }

        /// <summary>
        /// <para>The similarity algorithm for search. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>l2</b>: the Euclidean distance.</para>
        /// </description></item>
        /// <item><description><para><b>ip</b>: the dot product distance.</para>
        /// </description></item>
        /// <item><description><para><b>cosine</b>: the cosine similarity.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If this parameter is not specified, the algorithm specified when the index is created is used.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cosine</para>
        /// </summary>
        [NameInMap("Metrics")]
        [Validation(Required=false)]
        public string Metrics { get; set; }

        /// <summary>
        /// <para>The name of the namespace.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2401502.html">ListNamespaces</a> operation to list available namespaces.</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testpassword</para>
        /// </summary>
        [NameInMap("NamespacePassword")]
        [Validation(Required=false)]
        public string NamespacePassword { get; set; }

        /// <summary>
        /// <para>This parameter is left empty by default. It specifies the start position of a paged query. This parameter is not supported in hybrid search.</para>
        /// <para>The value must be greater than or equal to 0. When this parameter is not empty, Total in the response indicates the total number of hits. This parameter is used with TopK. For example, if you want to retrieve chunks 0 to 44 with a page size of 20, you must send three requests:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Offset=0, TopK=20</c> returns chunks 0 to 19.</para>
        /// </description></item>
        /// <item><description><para><c>Offset=20, TopK=20</c> returns chunks 20 to 39.</para>
        /// </description></item>
        /// <item><description><para><c>Offset=40, TopK=20</c> returns chunks 40 to 44.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Offset")]
        [Validation(Required=false)]
        public int? Offset { get; set; }

        /// <summary>
        /// <para>This parameter is left empty by default. It specifies the field based on which to sort the results. This parameter is not supported in hybrid search.</para>
        /// <para>The field must be a metadata field or a default field in the table, such as <c>id</c>. The following formats are supported:</para>
        /// <list type="bullet">
        /// <item><description><para>A single field, such as <c>chunk_id</c>.</para>
        /// </description></item>
        /// <item><description><para>Multiple fields separated by commas (,), such as <c>block_id, chunk_id</c>.</para>
        /// </description></item>
        /// <item><description><para>Descending order, such as <c>block_id DESC, chunk_id DESC</c>.</para>
        /// </description></item>
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
        /// <para>Uses another relational table to filter vector data, which is similar to the JOIN operation.</para>
        /// <remarks>
        /// <para>The data of the relational table can be returned by setting the IncludeMetadataFields parameter. For example, <c>rds_table_name.id</c> indicates that the id field of the relational table is returned.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("RelationalTableFilter")]
        [Validation(Required=false)]
        public QueryCollectionDataRequestRelationalTableFilter RelationalTableFilter { get; set; }
        public class QueryCollectionDataRequestRelationalTableFilter : TeaModel {
            /// <summary>
            /// <para>The metadata field of the vector collection, which is used to associate with the fields of the vector table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>doc_id</para>
            /// </summary>
            [NameInMap("CollectionMetadataField")]
            [Validation(Required=false)]
            public string CollectionMetadataField { get; set; }

            /// <summary>
            /// <para>The filter conditions for the relational table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tags @&gt; ARRAY[\&quot;art\&quot;]</para>
            /// </summary>
            [NameInMap("Condition")]
            [Validation(Required=false)]
            public string Condition { get; set; }

            /// <summary>
            /// <para>The field of the relational table, which is used to associate with the metadata field of the vector collection.</para>
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

        /// <summary>
        /// <para>The sparse vector data.</para>
        /// </summary>
        [NameInMap("SparseVector")]
        [Validation(Required=false)]
        public QueryCollectionDataRequestSparseVector SparseVector { get; set; }
        public class QueryCollectionDataRequestSparseVector : TeaModel {
            /// <summary>
            /// <para>The array of indexes.</para>
            /// <remarks>
            /// <para>The number of elements in the array cannot exceed 4,000.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("Indices")]
            [Validation(Required=false)]
            public List<long?> Indices { get; set; }

            /// <summary>
            /// <para>The array of sparse vectors.</para>
            /// </summary>
            [NameInMap("Values")]
            [Validation(Required=false)]
            public List<double?> Values { get; set; }

        }

        /// <summary>
        /// <para>Specifies the number of top results to return.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TopK")]
        [Validation(Required=false)]
        public long? TopK { get; set; }

        /// <summary>
        /// <para>The vector data. The length of the vector data must be the same as that specified in the <a href="https://help.aliyun.com/document_detail/2401497.html">CreateCollection</a> operation.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>If <c>SparseVector</c> is empty, only the dense vector search results are returned.</para>
        /// </description></item>
        /// <item><description><para>If both <c>Vector</c> and <c>SparseVector</c> are empty, only the full-text search results are returned.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// </summary>
        [NameInMap("Vector")]
        [Validation(Required=false)]
        public List<double?> Vector { get; set; }

        /// <summary>
        /// <para>The ID of the workspace that consists of multiple database instances. You must specify this parameter or the DBInstanceId parameter. If both this parameter and DBInstanceId are specified, this parameter is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-ws-*****</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
