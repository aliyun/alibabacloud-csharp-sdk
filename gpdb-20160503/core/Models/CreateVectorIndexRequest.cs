// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class CreateVectorIndexRequest : TeaModel {
        /// <summary>
        /// <para>The vector indexing algorithm.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>hnswflat</c>: (Default) An HNSW index that does not use quantization compression.</para>
        /// </description></item>
        /// <item><description><para><c>novam</c>: A graph-based index that does not use quantization compression. This algorithm is suitable for high-performance scenarios, such as real-time recommendations.</para>
        /// </description></item>
        /// <item><description><para><c>novad</c>: A partitioned index that uses rabitq quantization. This algorithm is suitable for large-scale, cost-effective retrieval scenarios.</para>
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
        /// <para>The collection name.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2401503.html">ListCollections</a> operation to list all collections.</para>
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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> operation to view the details of all AnalyticDB for PostgreSQL instances in a specific region, including the instance ID.</para>
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
        /// <para>The vector dimension.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is required for dense vectors.</para>
        /// </description></item>
        /// <item><description><para>This value must match the length of the <c>Rows.Vector</c> data provided when calling the <a href="https://help.aliyun.com/document_detail/2401493.html">UpsertCollectionData</a> operation.</para>
        /// </description></item>
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
        /// <para>Specifies whether to use <c>mmap</c> to build the HNSW index. The default value is 0. Set this to 1 for high-performance data uploads in scenarios where data deletion is not required.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>0</c>: (Default) Builds the index by using segmented page storage. This mode uses the <c>shared_buffer</c> in PostgreSQL for caching and supports delete and update operations.</para>
        /// </description></item>
        /// <item><description><para><c>1</c>: Builds the index by using <c>mmap</c>. This mode does not support delete and update operations.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Notice: </para>
        /// </remarks>
        /// <para>The <c>ExternalStorage</c> parameter is supported only by AnalyticDB for PostgreSQL V6.0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ExternalStorage")]
        [Validation(Required=false)]
        public int? ExternalStorage { get; set; }

        /// <summary>
        /// <para>The size of the candidate set for the HNSW algorithm during index construction. The value must be in the range of 4 to 1,000. The default value is 64.</para>
        /// <remarks>
        /// <para>This parameter applies only to AnalyticDB for PostgreSQL V7.0 instances, and its value must be greater than or equal to <c>2 * HnswM</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>128</para>
        /// </summary>
        [NameInMap("HnswEfConstruction")]
        [Validation(Required=false)]
        public int? HnswEfConstruction { get; set; }

        /// <summary>
        /// <para>The maximum number of neighbors for the Hierarchical Navigable Small World (HNSW) algorithm. The system automatically sets this value based on the vector dimension. You do not typically need to configure this parameter manually.</para>
        /// <remarks>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>For AnalyticDB for PostgreSQL V6.0 instances: 1 to 1,000.</para>
        /// </description></item>
        /// <item><description><para>For AnalyticDB for PostgreSQL V7.0 instances: 2 to 100. The default value is 16.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// <remarks>
        /// <para>We recommend the following values based on the vector dimension:</para>
        /// <list type="bullet">
        /// <item><description><para>For dimensions of 384 or less: 16</para>
        /// </description></item>
        /// <item><description><para>For dimensions from 385 to 768: 32</para>
        /// </description></item>
        /// <item><description><para>For dimensions from 769 to 1,024: 64</para>
        /// </description></item>
        /// <item><description><para>For dimensions greater than 1,024: 128</para>
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
        /// <para>The name of the management account that has <c>rds_superuser</c> permissions.</para>
        /// <remarks>
        /// <para>You can create an account on the \<em>\<em>account management\</em>\</em> page in the console or by calling the <a href="https://help.aliyun.com/document_detail/2361789.html">CreateAccount</a> operation.</para>
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
        /// <item><description><para><c>l2</c>: euclidean distance</para>
        /// </description></item>
        /// <item><description><para><c>ip</c>: dot product (inner product)</para>
        /// </description></item>
        /// <item><description><para><c>cosine</c>: cosine similarity</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Sparse vectors support only <c>ip</c>.</para>
        /// </remarks>
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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/2401502.html">ListNamespaces</a> operation to list all namespaces.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>mynamespace</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The number of lists (partitions) for the Novad algorithm. The value must be in the range of 2 to 1,073,741,824. The default value is 256.</para>
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
        /// <para>Specifies whether to enable Product Quantization (PQ) to accelerate indexing. Recommended for collections with over 500,000 vectors. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>0</c>: Disabled.</para>
        /// </description></item>
        /// <item><description><para><c>1</c>: Enabled. (Default)</para>
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
        /// <para>The number of bits for rabitq compression. The valid range is 1 to 8. The default value is 3.</para>
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
        /// <item><description><para><c>Dense</c>: (Default) a dense vector</para>
        /// </description></item>
        /// <item><description><para><c>Sparse</c>: a sparse vector</para>
        /// </description></item>
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
