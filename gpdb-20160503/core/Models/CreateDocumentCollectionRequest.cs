// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class CreateDocumentCollectionRequest : TeaModel {
        /// <summary>
        /// <para>The vector index algorithm.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>hnswflat: HNSW index without quantization compression (default).</description></item>
        /// <item><description>novam: graph index without quantization compression, suitable for high-performance scenarios such as real-time recommendations.</description></item>
        /// <item><description>novad: partitioned index with RaBitQ quantization, suitable for large-scale low-cost retrieval scenarios.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>hnswflat</para>
        /// </summary>
        [NameInMap("Algorithm")]
        [Validation(Required=false)]
        public string Algorithm { get; set; }

        /// <summary>
        /// <para>The name of the knowledge base to create.</para>
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
        /// <para>The vector dimensions. The default value is the dimension supported by the embedding model.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("Dimension")]
        [Validation(Required=false)]
        public int? Dimension { get; set; }

        /// <summary>
        /// <para>The embedding model. Default value: text-embedding-v3.</para>
        /// <remarks>
        /// <para>Supported models:</para>
        /// <list type="bullet">
        /// <item><description>text-embedding-v3 (recommended, default): 1024, 768, or 512 dimensions</description></item>
        /// <item><description>multimodal-embedding-v1 (recommended): 1024 dimensions, multimodal embedding model</description></item>
        /// <item><description>text-embedding-v1: 1536 dimensions</description></item>
        /// <item><description>text-embedding-v2: 1536 dimensions</description></item>
        /// <item><description>text2vec (not recommended): 1024 dimensions</description></item>
        /// <item><description>m3e-base (not recommended): 768 dimensions</description></item>
        /// <item><description>m3e-small (not recommended): 512 dimensions</description></item>
        /// <item><description>clip-vit-b-32 (not recommended): CLIP ViT-B/32 model, 512 dimensions, image embedding model</description></item>
        /// <item><description>clip-vit-b-16 (not recommended): CLIP ViT-B/16 model, 512 dimensions, image embedding model</description></item>
        /// <item><description>clip-vit-l-14 (not recommended): CLIP ViT-L/14 model, 768 dimensions, image embedding model</description></item>
        /// <item><description>clip-vit-l-14-336px (not recommended): CLIP ViT-L/14@336px model, 768 dimensions, image embedding model</description></item>
        /// <item><description>clip-rn50 (not recommended): CLIP RN50 model, 1024 dimensions, image embedding model</description></item>
        /// <item><description>clip-rn101 (not recommended): CLIP RN101 model, 512 dimensions, image embedding model</description></item>
        /// <item><description>clip-rn50x4 (not recommended): CLIP RN50x4 model, 640 dimensions, image embedding model</description></item>
        /// <item><description>clip-rn50x16 (not recommended): CLIP RN50x16 model, 768 dimensions, image embedding model</description></item>
        /// <item><description>clip-rn50x64 (not recommended): CLIP RN50x64 model, 1024 dimensions, image embedding model</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>text-embedding-v1</para>
        /// </summary>
        [NameInMap("EmbeddingModel")]
        [Validation(Required=false)]
        public string EmbeddingModel { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable knowledge graph construction. Default value: false.</para>
        /// <remarks>
        /// <para>Before using this parameter, upgrade the instance to a version that supports the graph engine. (During the public preview, submit a ticket to upgrade the version.)</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableGraph")]
        [Validation(Required=false)]
        public bool? EnableGraph { get; set; }

        /// <summary>
        /// <para>The list of entity types.</para>
        /// <remarks>
        /// <para>This parameter is required when knowledge graph construction is enabled.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Location</para>
        /// </summary>
        [NameInMap("EntityTypes")]
        [Validation(Required=false)]
        public List<string> EntityTypes { get; set; }

        /// <summary>
        /// <para>Specifies whether to use mmap to build the HNSW index. Default value: 0. If data does not need to be deleted and you require high upload performance, set this parameter to 1.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: uses segment-page storage to build the index. This mode uses shared_buffer in PostgreSQL as cache and supports delete and update operations.</description></item>
        /// <item><description>1: uses mmap to build the index. This mode does not support delete or update operations.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Notice: Only version 6.0 supports the ExternalStorage parameter. Version 7.0 does not support this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ExternalStorage")]
        [Validation(Required=false)]
        public int? ExternalStorage { get; set; }

        /// <summary>
        /// <para>The fields used for full-text retrieval. Separate multiple fields with commas (,). The fields must be keys defined in Metadata.</para>
        /// 
        /// <b>Example:</b>
        /// <para>title,page</para>
        /// </summary>
        [NameInMap("FullTextRetrievalFields")]
        [Validation(Required=false)]
        public string FullTextRetrievalFields { get; set; }

        /// <summary>
        /// <para>The candidate set size when building an index with the HNSW algorithm. The value must be &gt;= 2*HNSW_M.</para>
        /// <remarks>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>AnalyticDB for PostgreSQL 6.0 instances: 40 to 4000.</description></item>
        /// <item><description>AnalyticDB for PostgreSQL 7.0 instances: 4 to 1000. Default value: 64.</description></item>
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
        /// <para>The maximum number of neighbors in the HNSW algorithm. This value is automatically set based on the vector dimensions. Manual configuration is generally not required.</para>
        /// <remarks>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>AnalyticDB for PostgreSQL 6.0 instances: 1 to 1000.</description></item>
        /// <item><description>AnalyticDB for PostgreSQL 7.0 instances: 2 to 100. Default value: 16.</description></item>
        /// </list>
        /// </remarks>
        /// <remarks>
        /// <para>Recommended values based on vector dimensions:</para>
        /// <list type="bullet">
        /// <item><description>384 or fewer: 16</description></item>
        /// <item><description>Greater than 384 and up to 768: 32</description></item>
        /// <item><description>Greater than 768 and up to 1024: 64</description></item>
        /// <item><description>Greater than 1024: 128</description></item>
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
        /// <para>The LLM model name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>knowledge-extract-standard: default value.</description></item>
        /// <item><description>knowledge-extract-mini<remarks>
        /// <para>This parameter takes effect only when knowledge graph construction is enabled.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>knowledge-extract-standard</para>
        /// </summary>
        [NameInMap("LLMModel")]
        [Validation(Required=false)]
        public string LLMModel { get; set; }

        /// <summary>
        /// <para>The language used for knowledge graph construction. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Simplified Chinese: Simplified Chinese. Default value.</description></item>
        /// <item><description>English: English.<remarks>
        /// <para>This parameter takes effect only when knowledge graph construction is enabled.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Simplified Chinese</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The name of the management account that has the rds_superuser permission.</para>
        /// <remarks>
        /// <para>You can create an account in the console by navigating to Account Management, or by calling the <a href="https://help.aliyun.com/document_detail/2361789.html">CreateAccount</a> operation.</para>
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
        /// <para>The metadata of vector data, in the format of a JSON string representing a MAP. The key represents the field name, and the value represents the data type.</para>
        /// <remarks>
        /// <para>Supported data types:</para>
        /// <list type="bullet">
        /// <item><description>For the list of data types, see <a href="https://help.aliyun.com/document_detail/424383.html">Data types</a>.</description></item>
        /// <item><description>The money type is not supported.</description></item>
        /// </list>
        /// </remarks>
        /// <remarks>
        /// <para>Warning: The following fields are reserved and cannot be used: id, vector, doc_name, content, loader_metadata, source, and to_tsvector.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;title&quot;:&quot;text&quot;,&quot;page&quot;:&quot;int&quot;}</para>
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
        /// <para>The distance metric used for building vector indexes.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>l2</b>: Euclidean distance.</description></item>
        /// <item><description><b>ip</b>: inner product distance.</description></item>
        /// <item><description><b>cosine</b> (default): cosine similarity.</description></item>
        /// </list>
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
        /// <para>You can create a namespace by calling the <a href="https://help.aliyun.com/document_detail/2401495.html">CreateNamespace</a> operation and query the list of namespaces by calling the <a href="https://help.aliyun.com/document_detail/2401502.html">ListNamespaces</a> operation.</para>
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
        /// <para>The tokenizer used for full-text retrieval. Default value: zh_cn.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh_cn</para>
        /// </summary>
        [NameInMap("Parser")]
        [Validation(Required=false)]
        public string Parser { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Product Quantization (PQ) algorithm acceleration for the index. We recommend enabling this feature when the data volume exceeds 500,000. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: disabled.</description></item>
        /// <item><description>1: enabled (default).</description></item>
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
        /// <para>The list of relationship edge types.</para>
        /// <remarks>
        /// <para>This parameter is required when knowledge graph construction is enabled.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Occurred</para>
        /// </summary>
        [NameInMap("RelationshipTypes")]
        [Validation(Required=false)]
        public List<string> RelationshipTypes { get; set; }

        /// <summary>
        /// <para>The metadata fields used for building sparse vectors. Separate multiple fields with commas (,). The fields must be keys defined in Metadata.</para>
        /// 
        /// <b>Example:</b>
        /// <para>title,abstract</para>
        /// </summary>
        [NameInMap("SparseRetrievalFields")]
        [Validation(Required=false)]
        public string SparseRetrievalFields { get; set; }

        /// <summary>
        /// <para>The sparse vector index configuration. If specified, a sparse vector index is created.</para>
        /// </summary>
        [NameInMap("SparseVectorIndexConfig")]
        [Validation(Required=false)]
        public CreateDocumentCollectionRequestSparseVectorIndexConfig SparseVectorIndexConfig { get; set; }
        public class CreateDocumentCollectionRequestSparseVectorIndexConfig : TeaModel {
            /// <summary>
            /// <para>The vector index algorithm.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>hnswflat: HNSW index without quantization compression (default).</description></item>
            /// <item><description>novam: graph index without quantization compression, suitable for high-performance scenarios such as real-time recommendations.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>hnswflat</para>
            /// </summary>
            [NameInMap("Algorithm")]
            [Validation(Required=false)]
            public string Algorithm { get; set; }

            /// <summary>
            /// <para>The candidate set size when building an index with the HNSW algorithm. Valid values: 4 to 1000. Default value: 64.</para>
            /// <remarks>
            /// <para>This parameter is required only for AnalyticDB for PostgreSQL 7.0 instances, and the value must be &gt;= 2*HNSW_M.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>128</para>
            /// </summary>
            [NameInMap("HnswEfConstruction")]
            [Validation(Required=false)]
            public int? HnswEfConstruction { get; set; }

            /// <summary>
            /// <para>The maximum number of neighbors in the HNSW algorithm. This value is automatically set based on the vector dimensions. Manual configuration is generally not required.</para>
            /// <remarks>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>AnalyticDB for PostgreSQL 6.0 instances: 1 to 1000.</description></item>
            /// <item><description>AnalyticDB for PostgreSQL 7.0 instances: 2 to 100. Default value: 16.</description></item>
            /// </list>
            /// </remarks>
            /// <remarks>
            /// <para>Recommended values based on vector dimensions:</para>
            /// <list type="bullet">
            /// <item><description>384 or fewer: 16</description></item>
            /// <item><description>Greater than 384 and up to 768: 32</description></item>
            /// <item><description>Greater than 768 and up to 1024: 64</description></item>
            /// <item><description>Greater than 1024: 128</description></item>
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
        public CreateDocumentCollectionRequestVectorIndexConfig VectorIndexConfig { get; set; }
        public class CreateDocumentCollectionRequestVectorIndexConfig : TeaModel {
            /// <summary>
            /// <para>The Novad list count (number of partitions). Valid values: 2 to 1073741824. Default value: 256.</para>
            /// 
            /// <b>Example:</b>
            /// <para>256</para>
            /// </summary>
            [NameInMap("Nlist")]
            [Validation(Required=false)]
            public int? Nlist { get; set; }

            /// <summary>
            /// <para>The number of RaBitQ compression bits. Valid values: 1 to 8. Default value: 3.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("RabitqBits")]
            [Validation(Required=false)]
            public int? RabitqBits { get; set; }

        }

    }

}
