// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class CreateVectorIndexRequest : TeaModel {
        /// <summary>
        /// <para>The vector index algorithm. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>hnswflat: HNSW index without quantization compression (default).</description></item>
        /// <item><description>novam: graph index without quantization compression, suitable for high-performance scenarios such as real-time recommendation.</description></item>
        /// <item><description>novad: partitioned index with RaBitQ quantization, suitable for large-scale, low-cost retrieval scenarios.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>hnswflat</para>
        /// </summary>
        [NameInMap("Algorithm")]
        [Validation(Required=false)]
        public string Algorithm { get; set; }

        /// <summary>
        /// <para>The collection name.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2401503.html">ListCollections</a> operation to query the list.</para>
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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> operation to query the details of all AnalyticDB for PostgreSQL instances in a specific region, including the instance IDs.</para>
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
        /// <para>The vector dimensions.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is required for dense vectors.</description></item>
        /// <item><description>The value must be the same as the length of the vector data Rows.Vector in the <a href="https://help.aliyun.com/document_detail/2401493.html">UpsertCollectionData</a> operation.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("Dimension")]
        [Validation(Required=false)]
        public int? Dimension { get; set; }

        /// <summary>
        /// <para>Specifies whether to use mmap to build the HNSW index. Default value: 0. If data does not need to be deleted and you have high requirements for data upload speed, we recommend that you set this parameter to 1.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: uses the default segment-page storage to build the index. In this mode, shared_buffer in PostgreSQL can be used for caching, and operations such as deletion and update are supported.</description></item>
        /// <item><description>1: uses mmap to build the index. This mode does not support operations such as deletion and update.</description></item>
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
        /// <para>The size of the candidate set when the HNSW algorithm builds the index. Valid values: 4 to 1000. Default value: 64.</para>
        /// <remarks>
        /// <para>This parameter is required only for AnalyticDB for PostgreSQL V7.0 instances, and the value must be greater than or equal to 2 × HNSW_M.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>128</para>
        /// </summary>
        [NameInMap("HnswEfConstruction")]
        [Validation(Required=false)]
        public int? HnswEfConstruction { get; set; }

        /// <summary>
        /// <para>The maximum number of neighbors in the HNSW algorithm. The operation automatically sets this value based on the vector dimensions. You do not need to manually set this value in most cases.</para>
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
        /// <item><description>384 or less: 16</description></item>
        /// <item><description>Greater than 384 and less than or equal to 768: 32</description></item>
        /// <item><description>Greater than 768 and less than or equal to 1024: 64</description></item>
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
        /// <para>The name of the management account that has the rds_superuser permission.</para>
        /// <remarks>
        /// <para>You can create an account in the console by navigating to Account Management, or call the <a href="https://help.aliyun.com/document_detail/2361789.html">CreateAccount</a> operation.</para>
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
        /// <para>The distance metric used to build the vector index. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>l2: Euclidean distance.</description></item>
        /// <item><description>ip: inner product.</description></item>
        /// <item><description>cosine: cosine similarity.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Only ip is supported for sparse vectors.</para>
        /// </remarks>
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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2401502.html">ListNamespaces</a> operation to query the list.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>mynamespace</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The number of lists (partitions) for Novad. Valid values: 2 to 1073741824. Default value: 256.</para>
        /// 
        /// <b>Example:</b>
        /// <para>256</para>
        /// </summary>
        [NameInMap("Nlist")]
        [Validation(Required=false)]
        public int? Nlist { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable product quantization (PQ) algorithm acceleration for the index. We recommend that you enable this feature when the data volume exceeds 500,000. Valid values:</para>
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
        /// <para>The number of bits for RaBitQ compression. Valid values: 1 to 8. Default value: 3.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("RabitqBits")]
        [Validation(Required=false)]
        public int? RabitqBits { get; set; }

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
        /// <para>The vector type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Dense: dense vector (default).</description></item>
        /// <item><description>Sparse: sparse vector.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Dense</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
