// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class CreateCollectionRequest : TeaModel {
        /// <summary>
        /// <para>The vector index algorithm.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>hnswflat: HNSW index without quantization compression (default).</description></item>
        /// <item><description>novam: Graph index without quantization compression, suitable for high-performance scenarios such as real-time recommendation.</description></item>
        /// <item><description>novad: Partitioned index with rabitq quantization, suitable for large-scale, low-cost retrieval scenarios.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>hnswflat</para>
        /// </summary>
        [NameInMap("Algorithm")]
        [Validation(Required=false)]
        public string Algorithm { get; set; }

        /// <summary>
        /// <para>The name of the collection to be created.</para>
        /// <remarks>
        /// <para>The name must comply with the PostgreSQL object naming conventions.</para>
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
        /// <para>Instance ID of the instance.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> operation to query instance IDs of all AnalyticDB for PostgreSQL instances in the target region.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>gp-bp152460513z****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The vector dimensions.</para>
        /// <remarks>
        /// <para>If you specify this value, an index is built, and the length of Rows.Vector in the subsequent <a href="https://help.aliyun.com/document_detail/2401493.html">UpsertCollectionData</a> operation for uploading vector data must be consistent with this value. If you do not specify this value, you can call the <a href="https://help.aliyun.com/document_detail/2401499.html">CreateVectorIndex</a> operation later to build an index.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("Dimension")]
        [Validation(Required=false)]
        public long? Dimension { get; set; }

        /// <summary>
        /// <para>Specifies whether to use mmap to build the HNSW index. Default value: 0. If the data does not need to be deleted and you have high requirements for the data upload speed, set this parameter to 1.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Build the index by using segment-page storage. This is the default value. In this mode, shared_buffers in PostgreSQL can be used for caching, and operations such as deletion and update are supported.</description></item>
        /// <item><description>1: Build the index by using mmap. This mode does not support operations such as deletion and update.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Notice: The ExternalStorage parameter is supported only in V6.0. It is not supported in V7.0.</notice></para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ExternalStorage")]
        [Validation(Required=false)]
        public int? ExternalStorage { get; set; }

        /// <summary>
        /// <para>The fields used to retrieve data via full-text index. Separate multiple fields with commas (,). The fields must be keys defined in Metadata.</para>
        /// 
        /// <b>Example:</b>
        /// <para>title,content</para>
        /// </summary>
        [NameInMap("FullTextRetrievalFields")]
        [Validation(Required=false)]
        public string FullTextRetrievalFields { get; set; }

        /// <summary>
        /// <para>The size of the candidate set when building the index by using the HNSW algorithm. The value must be greater than or equal to 2 × HNSW_M.</para>
        /// <remarks>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>AnalyticDB for PostgreSQL V6.0 instances: 40 to 4000.</description></item>
        /// <item><description>AnalyticDB for PostgreSQL V7.0 instances: 4 to 1000. Default value: 64.</description></item>
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
        /// <para>The maximum number of neighbors in the HNSW algorithm. The operation automatically sets this value based on the vector dimensions. Typically, you do not need to manually set this value.</para>
        /// <remarks>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>AnalyticDB for PostgreSQL V6.0 instances: 1 to 1000.</description></item>
        /// <item><description>AnalyticDB for PostgreSQL V7.0 instances: 2 to 100. Default value: 16.</description></item>
        /// </list>
        /// </remarks>
        /// <remarks>
        /// <para>Recommended settings based on vector dimensions:</para>
        /// <list type="bullet">
        /// <item><description>Less than or equal to 384: 16.</description></item>
        /// <item><description>Greater than 384 and less than or equal to 768: 32.</description></item>
        /// <item><description>Greater than 768 and less than or equal to 1024: 64.</description></item>
        /// <item><description>Greater than 1024: 128.</description></item>
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
        /// <para>The name of the administrator account that has the rds_superuser permission.</para>
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
        /// <para>The password of the administrator account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testpassword</para>
        /// </summary>
        [NameInMap("ManagerAccountPassword")]
        [Validation(Required=false)]
        public string ManagerAccountPassword { get; set; }

        /// <summary>
        /// <para>The metadata of the vector data, which is a JSON string in MAP format. The key represents the field name, and the value represents the data type.</para>
        /// <remarks>
        /// <para>Supported data types:</para>
        /// <list type="bullet">
        /// <item><description>For the list of data types, see <a href="https://help.aliyun.com/document_detail/424383.html">Data types</a>.</description></item>
        /// <item><description>The money data type is not supported.</description></item>
        /// </list>
        /// </remarks>
        /// <remarks>
        /// <para>Warning: The id, vector, to_tsvector, and source fields are reserved fields and cannot be used.</warning></para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;title&quot;:&quot;text&quot;,&quot;content&quot;:&quot;text&quot;,&quot;response&quot;:&quot;int&quot;}</para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public string Metadata { get; set; }

        /// <summary>
        /// <para>The scalar index fields. Separate multiple fields with commas (,). The fields must be keys defined in Metadata.</para>
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
        /// <item><description>l2: Euclidean distance.</description></item>
        /// <item><description>ip: Inner product.</description></item>
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
        /// <para>The namespace.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2401495.html">CreateNamespace</a> operation to create a namespace, and call the <a href="https://help.aliyun.com/document_detail/2401502.html">ListNamespaces</a> operation to view the namespace list.</para>
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
        /// <para>The tokenizer used to retrieve data via full-text index. Default value: zh_cn.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh_cn</para>
        /// </summary>
        [NameInMap("Parser")]
        [Validation(Required=false)]
        public string Parser { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the Product Quantization (PQ) algorithm to accelerate the index. Enable this feature when the data volume exceeds 500,000. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: Disable.</description></item>
        /// <item><description>1: Enable (default).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PqEnable")]
        [Validation(Required=false)]
        public int? PqEnable { get; set; }

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
        /// <para>The sparse vector index configuration. If this parameter is passed, a sparse vector index is created.</para>
        /// </summary>
        [NameInMap("SparseVectorIndexConfig")]
        [Validation(Required=false)]
        public CreateCollectionRequestSparseVectorIndexConfig SparseVectorIndexConfig { get; set; }
        public class CreateCollectionRequestSparseVectorIndexConfig : TeaModel {
            /// <summary>
            /// <para>The vector index algorithm.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>hnswflat: HNSW index without quantization compression (default).</description></item>
            /// <item><description>novam: Graph index without quantization compression, suitable for high-performance scenarios such as real-time recommendation.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>hnswflat</para>
            /// </summary>
            [NameInMap("Algorithm")]
            [Validation(Required=false)]
            public string Algorithm { get; set; }

            /// <summary>
            /// <para>The size of the candidate set when building the index by using the HNSW algorithm. Valid values: 4 to 1000. Default value: 64.</para>
            /// <remarks>
            /// <para>This value is required only for AnalyticDB for PostgreSQL V7.0 instances, and the value must be greater than or equal to 2 × HNSW_M.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>128</para>
            /// </summary>
            [NameInMap("HnswEfConstruction")]
            [Validation(Required=false)]
            public int? HnswEfConstruction { get; set; }

            /// <summary>
            /// <para>The maximum number of neighbors in the HNSW algorithm. The operation automatically sets this value based on the vector dimensions. Typically, you do not need to manually set this value.</para>
            /// <remarks>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>AnalyticDB for PostgreSQL V6.0 instances: 1 to 1000.</description></item>
            /// <item><description>AnalyticDB for PostgreSQL V7.0 instances: 2 to 100. Default value: 16.</description></item>
            /// </list>
            /// </remarks>
            /// <remarks>
            /// <para>Recommended settings based on vector dimensions:</para>
            /// <list type="bullet">
            /// <item><description>Less than or equal to 384: 16.</description></item>
            /// <item><description>Greater than 384 and less than or equal to 768: 32.</description></item>
            /// <item><description>Greater than 768 and less than or equal to 1024: 64.</description></item>
            /// <item><description>Greater than 1024: 128.</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>64</para>
            /// </summary>
            [NameInMap("HnswM")]
            [Validation(Required=false)]
            public int? HnswM { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to support sparse vectors. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SupportSparse")]
        [Validation(Required=false)]
        public bool? SupportSparse { get; set; }

        /// <summary>
        /// <para>The dense vector index configuration.</para>
        /// </summary>
        [NameInMap("VectorIndexConfig")]
        [Validation(Required=false)]
        public CreateCollectionRequestVectorIndexConfig VectorIndexConfig { get; set; }
        public class CreateCollectionRequestVectorIndexConfig : TeaModel {
            /// <summary>
            /// <para>The number of Novad lists (partitions). Valid values: [2, 1073741824]. Default value: 256.</para>
            /// 
            /// <b>Example:</b>
            /// <para>256</para>
            /// </summary>
            [NameInMap("Nlist")]
            [Validation(Required=false)]
            public int? Nlist { get; set; }

            /// <summary>
            /// <para>The number of rabitq compression bits. Valid values: [1, 8]. Default value: 3.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("RabitqBits")]
            [Validation(Required=false)]
            public int? RabitqBits { get; set; }

        }

        /// <summary>
        /// <para>The ID of the workspace that consists of multiple database instances. This parameter and the DBInstanceId parameter cannot be empty at the same time. If both parameters are specified, this parameter takes precedence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-ws-*****</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
