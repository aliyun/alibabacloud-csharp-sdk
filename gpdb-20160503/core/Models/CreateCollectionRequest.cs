// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class CreateCollectionRequest : TeaModel {
        /// <summary>
        /// <para>The name of the collection that you want to create.</para>
        /// <remarks>
        /// <para> The name must comply with the naming conventions of PostgreSQL objects.</para>
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
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> operation to query the IDs of all AnalyticDB for PostgreSQL instances in a specific region.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>gp-xxxxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The number of vector dimensions.</para>
        /// <remarks>
        /// <para> If you specify this parameter, an index is created. When you call the <a href="https://help.aliyun.com/document_detail/2401493.html">UpsertCollectionData</a> operation, make sure that the length of the Rows.Vector parameter is the same as the value of this parameter. If you do not specify this parameter, you can call the <a href="https://help.aliyun.com/document_detail/2401499.html">CreateVectorIndex</a> operation to create an index.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("Dimension")]
        [Validation(Required=false)]
        public long? Dimension { get; set; }

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
        /// <para>title,content</para>
        /// </summary>
        [NameInMap("FullTextRetrievalFields")]
        [Validation(Required=false)]
        public string FullTextRetrievalFields { get; set; }

        /// <summary>
        /// <para>The maximum number of neighbors for the Hierarchical Navigable Small World (HNSW) algorithm. Valid values: 1 to 1000. In most cases, this parameter is automatically configured based on the value of the Dimension parameter. You do not need to configure this parameter.</para>
        /// <remarks>
        /// <para> We recommend that you configure this parameter based on the value of the Dimension parameter.</para>
        /// </remarks>
        /// <para>*If you set Dimension to a value less than or equal to 384, set the value of HnswM to 16.</para>
        /// <para>*If you set Dimension to a value greater than 384 and less than or equal to 768, set the value of HnswM to 32.</para>
        /// <para>*If you set Dimension to a value greater than 768 and less than or equal to 1024, set the value of HnswM to 64.</para>
        /// <para>*If you set Dimension to a value greater than 1024, set the value of HnswM to 128.</para>
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
        /// <para>The password of the manager account.</para>
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
        /// <para> Supported data types:</para>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>For information about the supported data types, see <a href="https://www.alibabacloud.com/help/zh/analyticdb/analyticdb-for-postgresql/developer-reference/data-types-1/">Data types</a>.</para>
        /// </description></item>
        /// <item><description><para>The money data type is not supported.</para>
        /// </description></item>
        /// </list>
        /// <para>**</para>
        /// <para><b>Warning</b> Reserved fields such as id, vector, to_tsvector, and source cannot be used.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;title&quot;:&quot;text&quot;,&quot;content&quot;:&quot;text&quot;,&quot;response&quot;:&quot;int&quot;}</para>
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public string Metadata { get; set; }

        /// <summary>
        /// <para>The scalar index fields. Separate multiple fields with commas (,). These fields must be keys defined in Metadata.</para>
        /// 
        /// <b>Example:</b>
        /// <para>title</para>
        /// </summary>
        [NameInMap("MetadataIndices")]
        [Validation(Required=false)]
        public string MetadataIndices { get; set; }

        /// <summary>
        /// <para>The method that is used to create vector indexes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>l2: Euclidean distance.</description></item>
        /// <item><description>ip: inner product distance.</description></item>
        /// <item><description>cosine: cosine similarity.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cosine</para>
        /// </summary>
        [NameInMap("Metrics")]
        [Validation(Required=false)]
        public string Metrics { get; set; }

        /// <summary>
        /// <para>The name of the namespace.</para>
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
        /// <para>The analyzer that is used for full-text search.</para>
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
        /// <para>0</para>
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
        /// <para>The ID of the workspace that consists of multiple AnalyticDB for PostgreSQL instances. You must specify one of the WorkspaceId and DBInstanceId parameters. If you specify both parameters, the WorkspaceId parameter takes effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-ws-*****</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
