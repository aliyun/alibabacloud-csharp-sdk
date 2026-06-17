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
        /// <item><description><para><c>hnswflat</c>: An HNSW index without quantization compression. This is the default value.</para>
        /// </description></item>
        /// <item><description><para><c>novam</c>: A graph index without quantization compression. This algorithm is suitable for high-performance scenarios such as real-time recommendation.</para>
        /// </description></item>
        /// <item><description><para><c>novad</c>: A partitioned index with rabitq quantization. This algorithm is suitable for large-scale, low-cost retrieval scenarios.</para>
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
        /// <para>The name of the document collection to create.</para>
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
        /// <para>The ID of the instance.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> operation to query the details of all AnalyticDB for PostgreSQL instances in the target region, including instance IDs.</para>
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
        /// <para>The vector dimension. If you omit this parameter, the system uses a default dimension for the selected <c>EmbeddingModel</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("Dimension")]
        [Validation(Required=false)]
        public int? Dimension { get; set; }

        /// <summary>
        /// <para>The embedding model. The default value is <c>text-embedding-v3</c>.</para>
        /// <remarks>
        /// <para>Supported models:</para>
        /// <list type="bullet">
        /// <item><description><para><c>text-embedding-v3</c> (Recommended, Default): 1,024, 768, or 512 dimensions</para>
        /// </description></item>
        /// <item><description><para><c>multimodal-embedding-v1</c> (Recommended): 1,024 dimensions, a multimodal embedding model</para>
        /// </description></item>
        /// <item><description><para><c>text-embedding-v1</c>: 1,536 dimensions</para>
        /// </description></item>
        /// <item><description><para><c>text-embedding-v2</c>: 1,536 dimensions</para>
        /// </description></item>
        /// <item><description><para><c>text2vec</c> (Not recommended): 1,024 dimensions</para>
        /// </description></item>
        /// <item><description><para><c>m3e-base</c> (Not recommended): 768 dimensions</para>
        /// </description></item>
        /// <item><description><para><c>m3e-small</c> (Not recommended): 512 dimensions</para>
        /// </description></item>
        /// <item><description><para><c>clip-vit-b-32</c> (Not recommended): CLIP ViT-B/32 model, 512 dimensions, an image embedding model</para>
        /// </description></item>
        /// <item><description><para><c>clip-vit-b-16</c> (Not recommended): CLIP ViT-B/16 model, 512 dimensions, an image embedding model</para>
        /// </description></item>
        /// <item><description><para><c>clip-vit-l-14</c> (Not recommended): CLIP ViT-L/14 model, 768 dimensions, an image embedding model</para>
        /// </description></item>
        /// <item><description><para><c>clip-vit-l-14-336px</c> (Not recommended): CLIP ViT-L/14\@336px model, 768 dimensions, an image embedding model</para>
        /// </description></item>
        /// <item><description><para><c>clip-rn50</c> (Not recommended): CLIP RN50 model, 1,024 dimensions, an image embedding model</para>
        /// </description></item>
        /// <item><description><para><c>clip-rn101</c> (Not recommended): CLIP RN101 model, 512 dimensions, an image embedding model</para>
        /// </description></item>
        /// <item><description><para><c>clip-rn50x4</c> (Not recommended): CLIP RN50x4 model, 640 dimensions, an image embedding model</para>
        /// </description></item>
        /// <item><description><para><c>clip-rn50x16</c> (Not recommended): CLIP RN50x16 model, 768 dimensions, an image embedding model</para>
        /// </description></item>
        /// <item><description><para><c>clip-rn50x64</c> (Not recommended): CLIP RN50x64 model, 1,024 dimensions, an image embedding model</para>
        /// </description></item>
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
        /// <para>Specifies whether to build a knowledge graph. The default value is <c>false</c>.</para>
        /// <remarks>
        /// <para>To use this parameter, you must first upgrade your instance to a version that supports the graph engine. During the public preview period, submit a ticket to request an upgrade.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableGraph")]
        [Validation(Required=false)]
        public bool? EnableGraph { get; set; }

        /// <summary>
        /// <para>A list of entity types.</para>
        /// <remarks>
        /// <para>This parameter is required when <c>EnableGraph</c> is set to <c>true</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Location</para>
        /// </summary>
        [NameInMap("EntityTypes")]
        [Validation(Required=false)]
        public List<string> EntityTypes { get; set; }

        /// <summary>
        /// <para>Specifies whether to use memory-mapped files (mmap) to build the HNSW index. The default value is 0. Setting this to <c>1</c> is recommended if you do not need to delete data and require high upload performance.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>0</c>: Builds the index by using segmented page storage. This mode supports delete and update operations and can use the <c>shared_buffer</c> in PostgreSQL for caching. This is the default value.</para>
        /// </description></item>
        /// <item><description><para><c>1</c>: Builds the index by using mmap. This mode does not support delete or update operations.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>The <c>ExternalStorage</c> parameter is supported only by AnalyticDB for PostgreSQL V6.0 instances. It is not supported by V7.0 instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ExternalStorage")]
        [Validation(Required=false)]
        public int? ExternalStorage { get; set; }

        /// <summary>
        /// <para>The metadata fields to use for full-text search. These fields must be keys defined in <c>Metadata</c>. Separate multiple fields with a comma (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>title,page</para>
        /// </summary>
        [NameInMap("FullTextRetrievalFields")]
        [Validation(Required=false)]
        public string FullTextRetrievalFields { get; set; }

        /// <summary>
        /// <para>The size of the candidate set (<c>ef_construction</c>) for HNSW index construction. The value must be greater than or equal to <c>2 * HnswM</c>.</para>
        /// <remarks>
        /// <para>Value range:</para>
        /// <list type="bullet">
        /// <item><description><para>For AnalyticDB for PostgreSQL V6.0 instances: 40 to 4,000.</para>
        /// </description></item>
        /// <item><description><para>For AnalyticDB for PostgreSQL V7.0 instances: 4 to 1,000. The default value is 64.</para>
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
        /// <para>The maximum number of neighbors (M) for the HNSW algorithm. You do not typically need to set this parameter, as the system automatically sets it based on the vector dimension.</para>
        /// <remarks>
        /// <para>Value range:</para>
        /// <list type="bullet">
        /// <item><description><para>For AnalyticDB for PostgreSQL V6.0 instances: 1 to 1,000.</para>
        /// </description></item>
        /// <item><description><para>For AnalyticDB for PostgreSQL V7.0 instances: 2 to 100. The default value is 16.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// <remarks>
        /// <para>We recommend that you set this parameter based on the vector dimension:</para>
        /// <list type="bullet">
        /// <item><description><para>If the dimension is 384 or less: 16</para>
        /// </description></item>
        /// <item><description><para>If the dimension is greater than 384 and less than or equal to 768: 32</para>
        /// </description></item>
        /// <item><description><para>If the dimension is greater than 768 and less than or equal to 1,024: 64</para>
        /// </description></item>
        /// <item><description><para>If the dimension is greater than 1,024: 128</para>
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
        /// <para>The name of the LLM model. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>knowledge-extract-standard</c>: The default value.</para>
        /// </description></item>
        /// <item><description><para><c>knowledge-extract-mini</c></para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter takes effect only when <c>EnableGraph</c> is set to <c>true</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>knowledge-extract-standard</para>
        /// </summary>
        [NameInMap("LLMModel")]
        [Validation(Required=false)]
        public string LLMModel { get; set; }

        /// <summary>
        /// <para>The language used to build the knowledge graph. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Simplified Chinese</c>: The default value.</para>
        /// </description></item>
        /// <item><description><para><c>English</c></para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter takes effect only when <c>EnableGraph</c> is set to <c>true</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Simplified Chinese</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The name of the manager account that has <c>rds_superuser</c> permissions.</para>
        /// <remarks>
        /// <para>You can create an account in the console on the \<em>\<em>Account Management\</em>\</em> page or by calling the <a href="https://help.aliyun.com/document_detail/2361789.html">CreateAccount</a> operation.</para>
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
        /// <para>The password for the manager account.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testpassword</para>
        /// </summary>
        [NameInMap("ManagerAccountPassword")]
        [Validation(Required=false)]
        public string ManagerAccountPassword { get; set; }

        /// <summary>
        /// <para>The metadata schema for the vector data, specified as a JSON map where keys are field names and values are data types.</para>
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
        /// <para>The following fields are reserved and cannot be used: <c>id</c>, <c>vector</c>, <c>doc_name</c>, <c>content</c>, <c>loader_metadata</c>, <c>source</c>, and <c>to_tsvector</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;title&quot;:&quot;text&quot;,&quot;page&quot;:&quot;int&quot;}</para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public string Metadata { get; set; }

        /// <summary>
        /// <para>The metadata fields on which to create scalar indexes. These fields must be keys defined in <c>Metadata</c>. Separate multiple fields with a comma (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>title</para>
        /// </summary>
        [NameInMap("MetadataIndices")]
        [Validation(Required=false)]
        public string MetadataIndices { get; set; }

        /// <summary>
        /// <para>The distance metric for the vector index.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b><c>l2</c></b>: Euclidean distance.</para>
        /// </description></item>
        /// <item><description><para><b><c>ip</c></b>: dot product (inner product) distance.</para>
        /// </description></item>
        /// <item><description><para><b><c>cosine</c></b> (Default): cosine similarity.</para>
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
        /// <para>The namespace. The default value is <c>public</c>.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2401495.html">CreateNamespace</a> operation to create a namespace and the <a href="https://help.aliyun.com/document_detail/2401502.html">ListNamespaces</a> operation to list namespaces.</para>
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
        /// <para>The tokenizer for full-text search. The default value is <c>zh_cn</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh_cn</para>
        /// </summary>
        [NameInMap("Parser")]
        [Validation(Required=false)]
        public string Parser { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the PQ (product quantization) algorithm to accelerate indexing. This is recommended for datasets with over 500,000 entries. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>0</c>: Disables the feature.</para>
        /// </description></item>
        /// <item><description><para><c>1</c>: Enables the feature. This is the default value.</para>
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
        /// <para>A list of relationship types.</para>
        /// <remarks>
        /// <para>This parameter is required when <c>EnableGraph</c> is set to <c>true</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Occurred</para>
        /// </summary>
        [NameInMap("RelationshipTypes")]
        [Validation(Required=false)]
        public List<string> RelationshipTypes { get; set; }

        /// <summary>
        /// <para>The metadata fields used to build the sparse vector. These fields must be keys defined in <c>Metadata</c>. Separate multiple fields with a comma (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>title,abstract</para>
        /// </summary>
        [NameInMap("SparseRetrievalFields")]
        [Validation(Required=false)]
        public string SparseRetrievalFields { get; set; }

        /// <summary>
        /// <para>Configuration for the sparse vector index. Specifying this parameter creates the index.</para>
        /// </summary>
        [NameInMap("SparseVectorIndexConfig")]
        [Validation(Required=false)]
        public CreateDocumentCollectionRequestSparseVectorIndexConfig SparseVectorIndexConfig { get; set; }
        public class CreateDocumentCollectionRequestSparseVectorIndexConfig : TeaModel {
            /// <summary>
            /// <para>The vector index algorithm.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><c>hnswflat</c>: An HNSW index without quantization compression. This is the default value.</para>
            /// </description></item>
            /// <item><description><para><c>novam</c>: A graph index without quantization compression. This algorithm is suitable for high-performance scenarios such as real-time recommendation.</para>
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
            /// <para>The size of the candidate set (<c>ef_construction</c>) for HNSW index construction. Valid values: 4 to 1,000. The default value is 64.</para>
            /// <remarks>
            /// <para>This parameter is applicable only to AnalyticDB for PostgreSQL V7.0 instances, and its value must be greater than or equal to <c>2 * HnswM</c>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>128</para>
            /// </summary>
            [NameInMap("HnswEfConstruction")]
            [Validation(Required=false)]
            public int? HnswEfConstruction { get; set; }

            /// <summary>
            /// <para>The maximum number of neighbors (M) for the HNSW algorithm. You do not typically need to set this parameter, as the system automatically sets it based on the vector dimension.</para>
            /// <remarks>
            /// <para>Value range:</para>
            /// <list type="bullet">
            /// <item><description><para>For AnalyticDB for PostgreSQL V6.0 instances: 1 to 1,000.</para>
            /// </description></item>
            /// <item><description><para>For AnalyticDB for PostgreSQL V7.0 instances: 2 to 100. The default value is 16.</para>
            /// </description></item>
            /// </list>
            /// </remarks>
            /// <remarks>
            /// <para>We recommend that you set this parameter based on the vector dimension:</para>
            /// <list type="bullet">
            /// <item><description><para>If the dimension is 384 or less: 16</para>
            /// </description></item>
            /// <item><description><para>If the dimension is greater than 384 and less than or equal to 768: 32</para>
            /// </description></item>
            /// <item><description><para>If the dimension is greater than 768 and less than or equal to 1,024: 64</para>
            /// </description></item>
            /// <item><description><para>If the dimension is greater than 1,024: 128</para>
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

        }

        /// <summary>
        /// <para>Specifies whether to support sparse vectors. The default value is <c>false</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SupportSparse")]
        [Validation(Required=false)]
        public bool? SupportSparse { get; set; }

        /// <summary>
        /// <para>Configuration for the dense vector index.</para>
        /// </summary>
        [NameInMap("VectorIndexConfig")]
        [Validation(Required=false)]
        public CreateDocumentCollectionRequestVectorIndexConfig VectorIndexConfig { get; set; }
        public class CreateDocumentCollectionRequestVectorIndexConfig : TeaModel {
            /// <summary>
            /// <para>The number of lists (partitions) for the novad algorithm. Valid values: [2, 1073741824]. The default value is 256.</para>
            /// 
            /// <b>Example:</b>
            /// <para>256</para>
            /// </summary>
            [NameInMap("Nlist")]
            [Validation(Required=false)]
            public int? Nlist { get; set; }

            /// <summary>
            /// <para>The number of bits used for rabitq compression. Valid values: [1, 8]. The default value is 3.</para>
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
