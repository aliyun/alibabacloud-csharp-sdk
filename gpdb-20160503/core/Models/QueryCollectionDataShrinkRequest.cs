// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class QueryCollectionDataShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The collection name.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2401503.html">ListCollections</a> operation to view the list.</para>
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
        /// <para>The content used for full-text retrieval. If this parameter is left empty, only vector retrieval is used. If this parameter is specified, both vector and full-text retrieval are used.</para>
        /// <remarks>
        /// <para>This parameter and the Vector parameter cannot be left empty at the same time.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>hello_world</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> operation to query the details of all AnalyticDB for PostgreSQL instances in a specific region, including the instance IDs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>gp-xxxxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The filter condition for the data to query, in the SQL WHERE clause format. It is an expression that returns a Boolean value (true or false). The condition can be a simple comparison operator, such as equal to (=), not equal to (&lt;&gt; or !=), greater than (&gt;), less than (&lt;), greater than or equal to (&gt;=), or less than or equal to (&lt;=). It can also be a more complex expression combined with logical operators (AND, OR, NOT), or a condition that uses keywords such as IN, BETWEEN, and LIKE.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>For detailed syntax, refer to <a href="https://www.postgresqltutorial.com/postgresql-tutorial/postgresql-where/">https://www.postgresqltutorial.com/postgresql-tutorial/postgresql-where/</a></description></item>
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
        /// <para>The dual-channel recall algorithm. Default value: empty (which means the vector and full-text scores are directly compared and sorting is applied). Valid values:</para>
        /// <list type="bullet">
        /// <item><description>RRF: reciprocal rank fusion. A parameter k is used to control the fusion effect. For more information, see the HybridSearchArgs configuration.</description></item>
        /// <item><description>Weight: weighted sorting. A parameter alpha is used to control the weight of the vector and full-text scores before sorting. For more information, see the HybridSearchArgs configuration.</description></item>
        /// <item><description>Cascaded: full-text retrieval is performed first, and then vector retrieval is performed based on the results.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RRF</para>
        /// </summary>
        [NameInMap("HybridSearch")]
        [Validation(Required=false)]
        public string HybridSearch { get; set; }

        /// <summary>
        /// <para>The algorithm parameters for hybrid search. RRF and Weight are supported:</para>
        /// <list type="bullet">
        /// <item><description>RRF: specifies the constant k in the score calculation formula <c>1/(k+rank_i)</c>. The value must be a positive integer greater than 1. Format:</description></item>
        /// </list>
        /// <pre><c>{ 
        ///    &quot;RRF&quot;: {
        ///     &quot;k&quot;: 60
        ///    }
        /// }
        /// </c></pre>
        /// <list type="bullet">
        /// <item><description>Weight: The calculation formula is <c>alpha * vector_score + (1-alpha) * text_score</c>. The parameter alpha represents the weight of the vector and full-text search scores. The value ranges from 0 to 1, where 0 indicates full-text search only and 1 indicates vector search only. Format:</description></item>
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
        public string HybridSearchArgsShrink { get; set; }

        /// <summary>
        /// <para>The metadata fields to return. Default value: empty. Separate multiple fields with commas.</para>
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
        /// <item><description><b>true</b>: returns sparse vector data.</description></item>
        /// <item><description><b>false</b>: does not return sparse vector data.</description></item>
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
        /// <item><description><b>true</b>: returns dense vector data.</description></item>
        /// <item><description><b>false</b>: does not return dense vector data.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IncludeValues")]
        [Validation(Required=false)]
        public bool? IncludeValues { get; set; }

        /// <summary>
        /// <para>The similarity algorithm used during search. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>l2</b>: Euclidean distance.</description></item>
        /// <item><description><b>ip</b>: Dot product (inner product) distance.</description></item>
        /// <item><description><b>cosine</b>: Cosine similarity.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If this parameter is left empty, the algorithm specified when the index is built is used.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cosine</para>
        /// </summary>
        [NameInMap("Metrics")]
        [Validation(Required=false)]
        public string Metrics { get; set; }

        /// <summary>
        /// <para>The namespace.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2401502.html">ListNamespaces</a> operation to view the list.</para>
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
        /// <para>The retrieval starting point during paged queries. Default value: empty. This parameter is not supported in dual-channel recall scenarios.</para>
        /// <para>The value must be greater than or equal to 0. If this parameter is specified, the Total parameter is returned to indicate the total number of hits. This parameter is used together with TopK. For example, to retrieve chunks with chunk_id ranging from 0 to 44 with a paging size of 20, you must make three requests:</para>
        /// <list type="bullet">
        /// <item><description>Offset=0, TopK=20 returns chunks with chunk_id ranging from 0 to 19.</description></item>
        /// <item><description>Offset=20, TopK=20 returns chunks with chunk_id ranging from 20 to 39.</description></item>
        /// <item><description>Offset=30, TopK=20 returns chunks with chunk_id ranging from 40 to 44.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Offset")]
        [Validation(Required=false)]
        public int? Offset { get; set; }

        /// <summary>
        /// <para>The field based on which the results are sorted. Default value: empty. This parameter is not supported in hybrid search scenarios.</para>
        /// <para>The field must belong to the metadata or be a default field in the table, such as id. Supported formats:</para>
        /// <list type="bullet">
        /// <item><description>A single field, such as chunk_id.</description></item>
        /// <item><description>Multiple fields separated by commas, such as block_id, chunk_id.</description></item>
        /// <item><description>Descending order, such as block_id DESC, chunk_id DESC.</description></item>
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
        /// <para>Uses another relational table to filter vector data, similar to the JOIN operation.</para>
        /// <remarks>
        /// <para>You can set the IncludeMetadataFields parameter to return data from the relational table. For example, rds_table_name.id indicates that the id field of the relational table is returned.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("RelationalTableFilter")]
        [Validation(Required=false)]
        public string RelationalTableFilterShrink { get; set; }

        /// <summary>
        /// <para>The list of sparse vector data.</para>
        /// </summary>
        [NameInMap("SparseVector")]
        [Validation(Required=false)]
        public string SparseVectorShrink { get; set; }

        /// <summary>
        /// <para>The number of top results to return.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TopK")]
        [Validation(Required=false)]
        public long? TopK { get; set; }

        /// <summary>
        /// <para>The vector data. The length must be consistent with the dimension specified in the <a href="https://help.aliyun.com/document_detail/2401497.html">CreateCollection</a> operation.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If SparseVector is left empty, the system uses it to retrieve only dense vector results.</description></item>
        /// <item><description>If both Vector and SparseVector are left empty, the system uses it to retrieve only full-text results.</description></item>
        /// </list>
        /// </remarks>
        /// </summary>
        [NameInMap("Vector")]
        [Validation(Required=false)]
        public string VectorShrink { get; set; }

        /// <summary>
        /// <para>The ID of the workspace that consists of multiple database instances. This parameter and the DBInstanceId parameter cannot be left empty at the same time. If both parameters are specified, this parameter takes precedence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-ws-*****</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
