// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class CreateCollectionShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The vector index algorithm.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>hnswflat</c>: (Default) An HNSW index without quantization compression.</para>
        /// </description></item>
        /// <item><description><para><c>novam</c>: A graph index without quantization compression. This algorithm is suitable for high-performance scenarios, such as real-time recommendations.</para>
        /// </description></item>
        /// <item><description><para><c>novad</c>: A partitioned index with <c>rabitq</c> quantization. This algorithm is suitable for large-scale, low-cost retrieval scenarios.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>hnswflat</para>
        /// </summary>
        [NameInMap("Algorithm")]
        [Validation(Required=false)]
        public string Algorithm { get; set; }

        /// <summary>
        /// <para>The name of the collection to create.</para>
        /// <remarks>
        /// <para>The name must comply with PostgreSQL object naming conventions.</para>
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
        /// <para>The instance ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> operation to query the IDs of all AnalyticDB for PostgreSQL instances in a specific region.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>gp-bp152460513z****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The vector dimension.</para>
        /// <remarks>
        /// <para>If you specify this parameter, a vector index is created. In subsequent calls to the <a href="https://help.aliyun.com/document_detail/2401493.html">UpsertCollectionData</a> operation, the length of <c>Rows.Vector</c> must match this dimension. If you do not specify this parameter, you must call the <a href="https://help.aliyun.com/document_detail/2401499.html">CreateVectorIndex</a> operation to create an index later.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("Dimension")]
        [Validation(Required=false)]
        public long? Dimension { get; set; }

        /// <summary>
        /// <para>Specifies whether to use <c>mmap</c> to build the HNSW index. The default value is 0. We recommend setting this to 1 if your data does not require deletion and you need high-performance data ingestion.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>0</c>: (Default) Builds the index by using segmented page storage. This mode can use the <c>shared_buffer</c> in PostgreSQL for caching and supports <c>DELETE</c> and <c>UPDATE</c> operations.</para>
        /// </description></item>
        /// <item><description><para><c>1</c>: Builds the index by using <c>mmap</c>. This mode does not support <c>DELETE</c> or <c>UPDATE</c> operations.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>The <c>ExternalStorage</c> parameter is available only for AnalyticDB for PostgreSQL v6.0 instances and is not supported in v7.0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ExternalStorage")]
        [Validation(Required=false)]
        public int? ExternalStorage { get; set; }

        /// <summary>
        /// <para>The fields to use for full-text search. Use commas (<c>,</c>) to separate multiple field names. These fields must be keys defined in the <c>Metadata</c> parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>title,content</para>
        /// </summary>
        [NameInMap("FullTextRetrievalFields")]
        [Validation(Required=false)]
        public string FullTextRetrievalFields { get; set; }

        /// <summary>
        /// <para>The size of the candidate set for HNSW index construction. The value must be greater than or equal to <c>2 * HnswM</c>.</para>
        /// <remarks>
        /// <para>Value range:</para>
        /// <list type="bullet">
        /// <item><description><para>For AnalyticDB for PostgreSQL V6.0 instances: 40 to 4000.</para>
        /// </description></item>
        /// <item><description><para>For AnalyticDB for PostgreSQL V7.0 instances: 4 to 1000. The default value is 64.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>128</para>
        /// </summary>
        [NameInMap("HnswEfConstruction")]
        [Validation(Required=false)]
        public string HnswEfConstruction { get; set; }

        /// <summary>
        /// <para>The maximum number of neighbors for the HNSW algorithm. You do not typically need to set this parameter, as the system automatically determines a value based on the vector dimension.</para>
        /// <remarks>
        /// <para>Value range:</para>
        /// <list type="bullet">
        /// <item><description><para>For AnalyticDB for PostgreSQL V6.0 instances: 1 to 1000.</para>
        /// </description></item>
        /// <item><description><para>For AnalyticDB for PostgreSQL V7.0 instances: 2 to 100. The default value is 16.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// <remarks>
        /// <para>We recommend that you set this parameter based on the vector dimension:</para>
        /// <list type="bullet">
        /// <item><description><para>16 for dimensions less than or equal to 384.</para>
        /// </description></item>
        /// <item><description><para>32 for dimensions greater than 384 and less than or equal to 768.</para>
        /// </description></item>
        /// <item><description><para>64 for dimensions greater than 768 and less than or equal to 1024.</para>
        /// </description></item>
        /// <item><description><para>128 for dimensions greater than 1024.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>64</para>
        /// </summary>
        [NameInMap("HnswM")]
        [Validation(Required=false)]
        public int? HnswM { get; set; }

        /// <summary>
        /// <para>The name of the management account that has the <c>rds_superuser</c> privilege.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2361789.html">CreateAccount</a> operation to create an account.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testaccount</para>
        /// </summary>
        [NameInMap("ManagerAccount")]
        [Validation(Required=false)]
        public string ManagerAccount { get; set; }

        /// <summary>
        /// <para>The password of the management account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testpassword</para>
        /// </summary>
        [NameInMap("ManagerAccountPassword")]
        [Validation(Required=false)]
        public string ManagerAccountPassword { get; set; }

        /// <summary>
        /// <para>A JSON string that defines the metadata schema as a map. The keys are field names, and the values are their corresponding data types.</para>
        /// <remarks>
        /// <para>Supported data types</para>
        /// <list type="bullet">
        /// <item><description><para>For a list of supported data types, see <a href="https://help.aliyun.com/document_detail/424383.html">Data types</a>.</para>
        /// </description></item>
        /// <item><description><para>The <c>money</c> data type is not supported.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// <remarks>
        /// <para>Warning: </para>
        /// </remarks>
        /// <para>The field names <c>id</c>, <c>vector</c>, <c>to_tsvector</c>, and <c>source</c> are reserved and cannot be used.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;title&quot;:&quot;text&quot;,&quot;content&quot;:&quot;text&quot;,&quot;response&quot;:&quot;int&quot;}</para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public string Metadata { get; set; }

        /// <summary>
        /// <para>The scalar index fields. Separate multiple fields with commas (<c>,</c>). The fields must be keys that are defined in <c>Metadata</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>title</para>
        /// </summary>
        [NameInMap("MetadataIndices")]
        [Validation(Required=false)]
        public string MetadataIndices { get; set; }

        /// <summary>
        /// <para>The distance metric used to build the vector index. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>l2</c>: Euclidean distance.</para>
        /// </description></item>
        /// <item><description><para><c>ip</c>: dot product.</para>
        /// </description></item>
        /// <item><description><para><c>cosine</c>: cosine similarity.</para>
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
        /// <para>The namespace.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2401495.html">CreateNamespace</a> operation to create a namespace or the <a href="https://help.aliyun.com/document_detail/2401502.html">ListNamespaces</a> operation to list existing namespaces.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>mynamespace</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The parser for full-text search. The default is <c>zh_cn</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh_cn</para>
        /// </summary>
        [NameInMap("Parser")]
        [Validation(Required=false)]
        public string Parser { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Product Quantization (PQ) for index acceleration. This is recommended for datasets with more than 500,000 entries. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>0</c>: Disabled.</para>
        /// </description></item>
        /// <item><description><para><c>1</c>: (Default) Enabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PqEnable")]
        [Validation(Required=false)]
        public int? PqEnable { get; set; }

        /// <summary>
        /// <para>The ID of the region where the instance is located.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The configuration for the sparse vector index. If specified, a sparse vector index is created.</para>
        /// </summary>
        [NameInMap("SparseVectorIndexConfig")]
        [Validation(Required=false)]
        public string SparseVectorIndexConfigShrink { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable support for sparse vectors. The default value is <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SupportSparse")]
        [Validation(Required=false)]
        public bool? SupportSparse { get; set; }

        /// <summary>
        /// <para>The configuration for the dense vector index.</para>
        /// </summary>
        [NameInMap("VectorIndexConfig")]
        [Validation(Required=false)]
        public string VectorIndexConfigShrink { get; set; }

        /// <summary>
        /// <para>The ID of the workspace, which contains multiple database instances. You must specify either <c>WorkspaceId</c> or <c>DBInstanceId</c>. If both are specified, <c>WorkspaceId</c> takes precedence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-ws-*****</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
