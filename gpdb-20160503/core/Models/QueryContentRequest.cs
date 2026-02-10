// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class QueryContentRequest : TeaModel {
        /// <summary>
        /// <para>Document collection name.</para>
        /// <remarks>
        /// <para>Created by the <a href="https://help.aliyun.com/document_detail/2618448.html">CreateDocumentCollection</a> API. You can use the <a href="https://help.aliyun.com/document_detail/2618452.html">ListDocumentCollections</a> API to view the list of created document collections.</para>
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
        /// <para>Text content for retrieval.</para>
        /// 
        /// <b>Example:</b>
        /// <para>What is ADBPG?</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>Instance ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> API to view details of all AnalyticDB for PostgreSQL instances in the target region, including the instance ID.</para>
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
        /// <para>In image search scenarios, the source file name of the image to be searched.</para>
        /// <remarks>
        /// <para>The image file must have a file extension. Currently supported image extensions: bmp, jpg, jpeg, png, tiff.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test.jpg</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>In image search scenarios, the publicly accessible URL of the image file.</para>
        /// <remarks>
        /// <para>The image file must have a file extension. Currently supported image extensions: bmp, jpg, jpeg, png, tiff.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://xx/myImage.jpg">https://xx/myImage.jpg</a></para>
        /// </summary>
        [NameInMap("FileUrl")]
        [Validation(Required=false)]
        public string FileUrl { get; set; }

        /// <summary>
        /// <para>Filter condition for the data to be queried, in SQL WHERE format. It is an expression that returns a boolean value (true or false). The conditions can be simple comparison operators such as equal (=), not equal (&lt;&gt; or !=), greater than (&gt;), less than (&lt;), greater than or equal to (&gt;=), less than or equal to (&lt;=), or more complex expressions combined with logical operators (AND, OR, NOT), and conditions using keywords like IN, BETWEEN, LIKE, etc.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>For detailed syntax, refer to: <a href="https://www.postgresqltutorial.com/postgresql-tutorial/postgresql-where/">https://www.postgresqltutorial.com/postgresql-tutorial/postgresql-where/</a></description></item>
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
        /// <para>Whether to enable knowledge graph enhancement. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("GraphEnhance")]
        [Validation(Required=false)]
        public bool? GraphEnhance { get; set; }

        /// <summary>
        /// <para>The search parameters of the knowledge graph.</para>
        /// </summary>
        [NameInMap("GraphSearchArgs")]
        [Validation(Required=false)]
        public QueryContentRequestGraphSearchArgs GraphSearchArgs { get; set; }
        public class QueryContentRequestGraphSearchArgs : TeaModel {
            /// <summary>
            /// <para>The number of top entities and relationship edges. Default value: 60.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("GraphTopK")]
            [Validation(Required=false)]
            public int? GraphTopK { get; set; }

        }

        /// <summary>
        /// <para>Dual recall algorithm, default is empty (i.e., directly compare and sort the scores of vectors and full text).</para>
        /// <para>Available values:</para>
        /// <list type="bullet">
        /// <item><description>RRF: Reciprocal rank fusion, with a parameter k controlling the fusion effect. See HybridSearchArgs configuration for details;</description></item>
        /// <item><description>Weight: Weighted ranking, using a parameter alpha to control the weight of vector and full-text scores, then sorting. See HybridSearchArgs configuration for details;</description></item>
        /// <item><description>Cascaded: Perform full-text retrieval first, then vector retrieval on top of it;</description></item>
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
        /// <para>Specifies whether to return the URL of the document. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IncludeFileUrl")]
        [Validation(Required=false)]
        public bool? IncludeFileUrl { get; set; }

        /// <summary>
        /// <para>The metadata fields to be returned. Separate multiple fields with commas (,). This parameter is empty by default.</para>
        /// 
        /// <b>Example:</b>
        /// <para>title,page</para>
        /// </summary>
        [NameInMap("IncludeMetadataFields")]
        [Validation(Required=false)]
        public string IncludeMetadataFields { get; set; }

        /// <summary>
        /// <para>Whether to return vectors. Default is false.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><b>false</b>: Do not return vectors.</description></item>
        /// <item><description><b>true</b>: Return vectors.</description></item>
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
        /// <para>Similarity algorithm used during retrieval. If this value is empty, the algorithm specified at the time of knowledge base creation is used. It is recommended not to set this unless there is a specific need.</para>
        /// <remarks>
        /// <para>Value description:</para>
        /// <list type="bullet">
        /// <item><description><b>l2</b>: Euclidean distance.</description></item>
        /// <item><description><b>ip</b>: Inner product (dot product) distance.</description></item>
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
        /// <para>Namespace, default is public.</para>
        /// <remarks>
        /// <para>You can create a namespace using the <a href="https://help.aliyun.com/document_detail/2401495.html">CreateNamespace</a> API and view the list of namespaces using the <a href="https://help.aliyun.com/document_detail/2401502.html">ListNamespaces</a> API.</para>
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
        /// <remarks>
        /// <para>This value is specified in the <a href="https://help.aliyun.com/document_detail/2401495.html">CreateNamespace</a> API.</para>
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
        /// <para>Offset, used for paginated queries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Offset")]
        [Validation(Required=false)]
        public int? Offset { get; set; }

        /// <summary>
        /// <para>The fields by which to sort the results. This parameter is empty by default.</para>
        /// <para>The field must be either a metadata field or a default field in the table (e.g., id). Supported formats include:</para>
        /// <para>Single field, such as chunk_id. Multiple fields that are separated by commas (,), such as block_id,chunk_id. Descending order is supported, e.g., block_id DESC, chunk_id DESC.</para>
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
        /// <para>Recall window. When this value is not empty, it adds context to the returned search results. The format is an array of 2 elements: List&lt;A, B&gt;, where -10 &lt;= A &lt;= 0 and 0 &lt;= B &lt;= 10.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Recommended when documents are fragmented and retrieval may lose contextual information.</description></item>
        /// <item><description>Re-ranking takes precedence over windowing, i.e., re-rank first, then apply windowing.</description></item>
        /// </list>
        /// </remarks>
        /// </summary>
        [NameInMap("RecallWindow")]
        [Validation(Required=false)]
        public List<int?> RecallWindow { get; set; }

        /// <summary>
        /// <para>The region ID where the instance is located.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Re-ranking factor. When this value is not empty, it will re-rank the vector search results. The value range is 1 &lt; RerankFactor &lt;= 5.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Re-ranking is slower when documents are sparsely split.</description></item>
        /// <item><description>It is recommended that the re-ranked count (TopK * Factor, rounded up) does not exceed 50.</description></item>
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
        /// <para>The number of the returned top results.</para>
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
        /// <para> Value Description</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>Supported units are seconds (s) and days (d). For example, 300s specifies that the URL is valid for 300 seconds, and 60d specifies that the URL is valid for 60 days.</para>
        /// </description></item>
        /// <item><description><para>Valid values: 60s to 365d.</para>
        /// </description></item>
        /// <item><description><para>Default value: 7200s, that is, 2 hours.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>7200s</para>
        /// </summary>
        [NameInMap("UrlExpiration")]
        [Validation(Required=false)]
        public string UrlExpiration { get; set; }

        /// <summary>
        /// <para>Whether to use full-text retrieval (dual recall). Default is false, which means only vector retrieval is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("UseFullTextRetrieval")]
        [Validation(Required=false)]
        public bool? UseFullTextRetrieval { get; set; }

    }

}
