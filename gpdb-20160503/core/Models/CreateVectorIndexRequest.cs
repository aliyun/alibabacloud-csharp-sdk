// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class CreateVectorIndexRequest : TeaModel {
        /// <summary>
        /// <para>Collection name.</para>
        /// <remarks>
        /// <para>You can use the <a href="https://help.aliyun.com/document_detail/2401503.html">ListCollections</a> API to view the list.</para>
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
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> API to view details of all AnalyticDB PostgreSQL instances in the target region, including the instance ID.</para>
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
        /// <para>Vector dimension.</para>
        /// <remarks>
        /// <para>This value must be consistent with the length of the vector data (Rows. Vector) uploaded via the <a href="https://help.aliyun.com/document_detail/2401493.html">UpsertCollectionData</a> API.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("Dimension")]
        [Validation(Required=false)]
        public int? Dimension { get; set; }

        /// <summary>
        /// <para>Whether to use mmap to build the HNSW index, default is 0. If the data does not need to be deleted and there are performance requirements for uploading data, it is recommended to set this to 1.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>When set to 0, the segment-page storage mode is used to build the index, which can use the shared_buffer in PostgreSQL for caching and supports deletion and update operations.</description></item>
        /// <item><description>When set to 1, the index is built using mmap, which does not support deletion and update operations.</description></item>
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
        /// <para>The maximum number of neighbors in the HNSW algorithm, ranging from 1 to 1000. The API will automatically set this value based on the vector dimension, and it generally does not need to be manually set.</para>
        /// <remarks>
        /// <para>It is suggested to set this based on the vector dimension as follows:</para>
        /// <list type="bullet">
        /// <item><description>Less than or equal to 384: 16</description></item>
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
        /// <para>Method used for building the vector index. Value description:</para>
        /// <list type="bullet">
        /// <item><description>l2: Euclidean distance.</description></item>
        /// <item><description>ip: Inner product (dot product) distance.</description></item>
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
        /// <para>Namespace, default is public.</para>
        /// <remarks>
        /// <para>You can use the <a href="https://help.aliyun.com/document_detail/2401502.html">ListNamespaces</a> API to view the list.</para>
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
        /// <para>Whether to enable PQ (Product Quantization) algorithm acceleration for the index. It is recommended to enable this when the data volume exceeds 500,000. Value description:</para>
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
        /// <para>Region ID where the instance is located.</para>
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
