// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class CreateDocumentCollectionShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The name of the document collection that you want to create.</para>
        /// <remarks>
        /// <para>The name must comply with PostgreSQL object naming restrictions.</para>
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

        [NameInMap("Dimension")]
        [Validation(Required=false)]
        public int? Dimension { get; set; }

        /// <summary>
        /// <para>The vectorization algorithm.</para>
        /// <remarks>
        /// <para> Supported algorithms:</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>text-embedding-v1: the algorithm that produces 1536-dimensional vectors.</para>
        /// </description></item>
        /// <item><description><para>text-embedding-v2: the algorithm that produces 1536-dimensional vectors.</para>
        /// </description></item>
        /// <item><description><para>text2vec: the algorithm that produces 1024-dimensional vectors.</para>
        /// </description></item>
        /// <item><description><para>m3e-base: the algorithm that produces 768-dimensional vectors.</para>
        /// </description></item>
        /// <item><description><para>m3e-small: the algorithm that produces 512-dimensional vectors.</para>
        /// </description></item>
        /// <item><description><para>clip-vit-b-32: the image vectorization algorithm that uses the Contrastive Language-Image Pre-Training (CLIP) ViT-B/32 model and produces 512-dimensional vectors.</para>
        /// </description></item>
        /// <item><description><para>clip-vit-b-16: the image vectorization algorithm that uses the CLIP ViT-B/16 model and produces 512-dimensional vectors.</para>
        /// </description></item>
        /// <item><description><para>clip-vit-l-14: the image vectorization algorithm that uses the CLIP ViT-L/14 model and produces 768-dimensional vectors.</para>
        /// </description></item>
        /// <item><description><para>clip-vit-l-14-336px: the image vectorization algorithm that uses the CLIP ViT-L/14@336px model and produces 768-dimensional vectors.</para>
        /// </description></item>
        /// <item><description><para>clip-rn50: the image vectorization algorithm that uses the CLIP RN50 model and produces 1024-dimensional vectors.</para>
        /// </description></item>
        /// <item><description><para>clip-rn101: the image vectorization algorithm that uses the CLIP RN101 model and produces 512-dimensional vectors.</para>
        /// </description></item>
        /// <item><description><para>clip-rn50x4: the image vectorization algorithm that uses the CLIP RN50x4 model and produces 640-dimensional vectors.</para>
        /// </description></item>
        /// <item><description><para>clip-rn50x16: the image vectorization algorithm that uses the CLIP RN50x16 model and produces 768-dimensional vectors.</para>
        /// </description></item>
        /// <item><description><para>clip-rn50x64: the image vectorization algorithm that uses the CLIP RN50x64 model and produces 1024-dimensional vectors.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>text-embedding-v1</para>
        /// </summary>
        [NameInMap("EmbeddingModel")]
        [Validation(Required=false)]
        public string EmbeddingModel { get; set; }

        [NameInMap("EnableGraph")]
        [Validation(Required=false)]
        public bool? EnableGraph { get; set; }

        [NameInMap("EntityTypes")]
        [Validation(Required=false)]
        public string EntityTypesShrink { get; set; }

        /// <summary>
        /// <para>Specifies whether to use the memory mapping technology to create HNSW indexes. Valid values: 0 and 1. Default value: 0. We recommend that you set the value to 1 in scenarios that require upload speed but not data deletion.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>0: uses segmented paging storage to create indexes. This method uses the shared buffer of PostgreSQL for caching and supports the delete and update operations.</para>
        /// </description></item>
        /// <item><description><para>1: uses the memory mapping technology to create indexes. This method does not support the delete or update operation.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ExternalStorage")]
        [Validation(Required=false)]
        public int? ExternalStorage { get; set; }

        /// <summary>
        /// <para>The fields used for full-text search. Separate multiple fields with commas (,). These fields must be keys defined in Metadata.</para>
        /// 
        /// <b>Example:</b>
        /// <para>title,page</para>
        /// </summary>
        [NameInMap("FullTextRetrievalFields")]
        [Validation(Required=false)]
        public string FullTextRetrievalFields { get; set; }

        [NameInMap("HnswEfConstruction")]
        [Validation(Required=false)]
        public string HnswEfConstruction { get; set; }

        /// <summary>
        /// <para>The maximum number of neighbors for the Hierarchical Navigable Small World (HNSW) algorithm. Valid values: 1 to 1000. In most cases, this parameter is automatically configured based on the value of the Dimension parameter. You do not need to configure this parameter.</para>
        /// <remarks>
        /// <para> We recommend that you configure this parameter based on the value of the Dimension parameter.</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If you set Dimension to a value less than or equal to 384, set the value of HnswM to 16.</para>
        /// </description></item>
        /// <item><description><para>If you set Dimension to a value greater than 384 and less than or equal to 768, set the value of HnswM to 32.</para>
        /// </description></item>
        /// <item><description><para>If you set Dimension to a value greater than 768 and less than or equal to 1024, set the value of HnswM to 64.</para>
        /// </description></item>
        /// <item><description><para>If you set Dimension to a value greater than 1024, set the value of HnswM to 128.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>64</para>
        /// </summary>
        [NameInMap("HnswM")]
        [Validation(Required=false)]
        public int? HnswM { get; set; }

        [NameInMap("LLMModel")]
        [Validation(Required=false)]
        public string LLMModel { get; set; }

        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The name of the manager account that has the rds_superuser permission.</para>
        /// <remarks>
        /// <para>You can create an account through the console -&gt; Account Management, or by using the <a href="https://help.aliyun.com/document_detail/2361789.html">CreateAccount</a> API.</para>
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
        /// <para>The metadata of the vector data, which is a JSON string in the MAP format. The key specifies the field name, and the value specifies the data type.</para>
        /// <remarks>
        /// <para>Supported data types:</para>
        /// <list type="bullet">
        /// <item><description>For information about data types, see: <a href="https://www.alibabacloud.com/help/en/analyticdb/analyticdb-for-postgresql/developer-reference/data-types-1/">Data Types</a>.</description></item>
        /// <item><description>The money type is not supported.</description></item>
        /// </list>
        /// </remarks>
        /// <remarks>
        /// <para>Warning: The fields id, vector, doc_name, content, loader_metadata, source, and to_tsvector are reserved and should not be used.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;title&quot;:&quot;text&quot;,&quot;page&quot;:&quot;int&quot;}</para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public string Metadata { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>title</para>
        /// </summary>
        [NameInMap("MetadataIndices")]
        [Validation(Required=false)]
        public string MetadataIndices { get; set; }

        /// <summary>
        /// <para>The method that is used to create vector indexes.</para>
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
        /// <para>The name of the namespace. Default value: public.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/2401495.html">CreateNamespace</a> operation to create a namespace and call the <a href="https://help.aliyun.com/document_detail/2401502.html">ListNamespaces</a> operation to query a list of namespaces.</para>
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
        /// <para>The analyzer that is used for full-text search. Default value: zh_cn.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh_cn</para>
        /// </summary>
        [NameInMap("Parser")]
        [Validation(Required=false)]
        public string Parser { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the product quantization (PQ) feature for index acceleration. We recommend that you enable this feature for more than 500,000 rows of data. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: no.</description></item>
        /// <item><description>1 (default): yes.</description></item>
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

        [NameInMap("RelationshipTypes")]
        [Validation(Required=false)]
        public string RelationshipTypesShrink { get; set; }

        [NameInMap("SparseRetrievalFields")]
        [Validation(Required=false)]
        public string SparseRetrievalFields { get; set; }

        [NameInMap("SparseVectorIndexConfig")]
        [Validation(Required=false)]
        public string SparseVectorIndexConfigShrink { get; set; }

        [NameInMap("SupportSparse")]
        [Validation(Required=false)]
        public bool? SupportSparse { get; set; }

    }

}
