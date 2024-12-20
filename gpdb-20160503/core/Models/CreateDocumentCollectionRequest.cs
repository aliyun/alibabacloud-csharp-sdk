// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class CreateDocumentCollectionRequest : TeaModel {
        /// <summary>
        /// <para>Name of the document library to be created.</para>
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
        /// <para>Vectorization algorithm.</para>
        /// <remarks>
        /// <para>Supported algorithms:</para>
        /// <list type="bullet">
        /// <item><description>text-embedding-v1: 1536 dimensions</description></item>
        /// <item><description>text-embedding-v2: 1536 dimensions</description></item>
        /// <item><description>text2vec: 1024 dimensions</description></item>
        /// <item><description>m3e-base: 768 dimensions</description></item>
        /// <item><description>m3e-small: 512 dimensions</description></item>
        /// <item><description>clip-vit-b-32: CLIP ViT-B/32 model, 512 dimensions, image vectorization algorithm</description></item>
        /// <item><description>clip-vit-b-16: CLIP ViT-B/16 model, 512 dimensions, image vectorization algorithm</description></item>
        /// <item><description>clip-vit-l-14: CLIP ViT-L/14 model, 768 dimensions, image vectorization algorithm</description></item>
        /// <item><description>clip-vit-l-14-336px: CLIP ViT-L/14@336px model, 768 dimensions, image vectorization algorithm</description></item>
        /// <item><description>clip-rn50: CLIP RN50 model, 1024 dimensions, image vectorization algorithm</description></item>
        /// <item><description>clip-rn101: CLIP RN101 model, 512 dimensions, image vectorization algorithm</description></item>
        /// <item><description>clip-rn50x4: CLIP RN50x4 model, 640 dimensions, image vectorization algorithm</description></item>
        /// <item><description>clip-rn50x16: CLIP RN50x16 model, 768 dimensions, image vectorization algorithm</description></item>
        /// <item><description>clip-rn50x64: CLIP RN50x64 model, 1024 dimensions, image vectorization algorithm</description></item>
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
        /// <para>Whether to use mmap to build HNSW index, default is 0. If the data does not need to be deleted and there are requirements for the speed of uploading data, it is recommended to set this to 1.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>When set to 0, segment-page storage will be used by default to build the index. This mode can use PostgreSQL\&quot;s shared_buffer as a cache and supports operations such as deletion and updates.</description></item>
        /// <item><description>When set to 1, the index will be built using mmap. This mode does not support deletion or update operations.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ExternalStorage")]
        [Validation(Required=false)]
        public int? ExternalStorage { get; set; }

        /// <summary>
        /// <para>Fields used for full-text search, separated by commas (,). These fields must be keys defined in Metadata.</para>
        /// 
        /// <b>Example:</b>
        /// <para>title,page</para>
        /// </summary>
        [NameInMap("FullTextRetrievalFields")]
        [Validation(Required=false)]
        public string FullTextRetrievalFields { get; set; }

        /// <summary>
        /// <para>The maximum number of neighbors in the HNSW algorithm, ranging from 1 to 1000. The interface will automatically set this value based on the vector dimension, and it generally does not need to be manually configured.</para>
        /// <remarks>
        /// <para>It is recommended to set according to the vector dimension: &gt;- For dimensions less than or equal to 384: 16 &gt;- For dimensions greater than 384 but less than or equal to 768: 32 &gt;- For dimensions greater than 768 but less than or equal to 1024: 64 &gt;- For dimensions greater than 1024: 128</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>64</para>
        /// </summary>
        [NameInMap("HnswM")]
        [Validation(Required=false)]
        public int? HnswM { get; set; }

        /// <summary>
        /// <para>Name of the management account with rds_superuser permissions.</para>
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
        /// <para>Management account password.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testpassword</para>
        /// </summary>
        [NameInMap("ManagerAccountPassword")]
        [Validation(Required=false)]
        public string ManagerAccountPassword { get; set; }

        /// <summary>
        /// <para>Metadata of vector data, in the form of a MAP JSON string. The key represents the field name, and the value represents the data type.</para>
        /// <remarks>
        /// <para>Supported data types</para>
        /// <list type="bullet">
        /// <item><description>For a list of data types, see: <a href="https://www.alibabacloud.com/help/en/analyticdb/analyticdb-for-postgresql/developer-reference/data-types-1/">Data Types</a>.</description></item>
        /// <item><description>The money type is not supported at this time.</description></item>
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

        [NameInMap("MetadataIndices")]
        [Validation(Required=false)]
        public string MetadataIndices { get; set; }

        /// <summary>
        /// <para>Method used when building the vector index.</para>
        /// <para>Value description:</para>
        /// <list type="bullet">
        /// <item><description><b>l2</b>: Euclidean distance.</description></item>
        /// <item><description><b>ip</b>: Inner product (dot product) distance.</description></item>
        /// <item><description><b>cosine</b> (default): Cosine similarity.</description></item>
        /// </list>
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
        /// <para>You can create a namespace using the <a href="https://help.aliyun.com/document_detail/2401495.html">CreateNamespace</a> API and view the list using the <a href="https://help.aliyun.com/document_detail/2401502.html">ListNamespaces</a> API.</para>
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
        /// <para>Tokenizer used for full-text search, default is zh_cn.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh_cn</para>
        /// </summary>
        [NameInMap("Parser")]
        [Validation(Required=false)]
        public string Parser { get; set; }

        /// <summary>
        /// <para>Whether to enable PQ (Product Quantization) algorithm for index acceleration. It is recommended to enable this when the data volume exceeds 500,000. Value description:</para>
        /// <list type="bullet">
        /// <item><description>0: Disabled.</description></item>
        /// <item><description>1: Enabled (default).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PqEnable")]
        [Validation(Required=false)]
        public int? PqEnable { get; set; }

        /// <summary>
        /// <para>ID of the region where the instance is located.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
