// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class CreateCollectionRequest : TeaModel {
        /// <summary>
        /// The name of the collection that you want to create.
        /// 
        /// >  The name must comply with the naming conventions of PostgreSQL objects.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Collection")]
        [Validation(Required=false)]
        public string Collection { get; set; }

        /// <summary>
        /// The instance ID.
        /// 
        /// >  You can call the [DescribeDBInstances](https://help.aliyun.com/document_detail/86911.html) operation to query the IDs of all AnalyticDB for PostgreSQL instances in a specific region.
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// The number of vector dimensions.
        /// 
        /// >  If you specify this parameter, an index is created. When you call the [UpsertCollectionData](https://help.aliyun.com/document_detail/2401493.html) operation, make sure that the length of the Rows.Vector parameter is the same as the value of this parameter. If you do not specify this parameter, you can call the [CreateVectorIndex](https://help.aliyun.com/document_detail/2401499.html) operation to create an index.
        /// </summary>
        [NameInMap("Dimension")]
        [Validation(Required=false)]
        public long? Dimension { get; set; }

        /// <summary>
        /// Specifies whether to use the memory mapping technology to create HNSW indexes. Valid values: 0 and 1. Default value: 0. We recommend that you set the value to 1 in scenarios that require upload speed but not data deletion.
        /// 
        /// > 
        /// 
        /// *   0: uses segmented paging storage to create indexes. This method uses the shared buffer of PostgreSQL for caching and supports the delete and update operations.
        /// 
        /// *   1: uses the memory mapping technology to create indexes. This method does not support the delete or update operation.
        /// </summary>
        [NameInMap("ExternalStorage")]
        [Validation(Required=false)]
        public int? ExternalStorage { get; set; }

        [NameInMap("FullTextRetrievalFields")]
        [Validation(Required=false)]
        public string FullTextRetrievalFields { get; set; }

        /// <summary>
        /// The maximum number of neighbors for the Hierarchical Navigable Small World (HNSW) algorithm. Valid values: 1 to 1000. In most cases, this parameter is automatically configured based on the value of the Dimension parameter. You do not need to configure this parameter.
        /// 
        /// >  We recommend that you configure this parameter based on the value of the Dimension parameter.
        /// 
        /// *If you set Dimension to a value less than or equal to 384, set the value of HnswM to 16.
        /// 
        /// *If you set Dimension to a value greater than 384 and less than or equal to 768, set the value of HnswM to 32.
        /// 
        /// *If you set Dimension to a value greater than 768 and less than or equal to 1024, set the value of HnswM to 64.
        /// 
        /// *If you set Dimension to a value greater than 1024, set the value of HnswM to 128.
        /// </summary>
        [NameInMap("HnswM")]
        [Validation(Required=false)]
        public int? HnswM { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ManagerAccount")]
        [Validation(Required=false)]
        public string ManagerAccount { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("ManagerAccountPassword")]
        [Validation(Required=false)]
        public string ManagerAccountPassword { get; set; }

        /// <summary>
        /// The metadata of the vector data, which is a JSON string in the MAP format. The key specifies the field name, and the value specifies the data type.
        /// 
        /// > 
        /// 
        /// *   For information about the supported data types, see [Data types](https://help.aliyun.com/zh/analyticdb-for-postgresql/developer-reference/data-types-1/?spm=a2c4g.11186623.0.0.43e567a1C35QRD).
        /// 
        /// *   The money data type is not supported.
        /// 
        /// **
        /// 
        /// **Warning**
        /// Reserved fields such as id, vector, to_tsvector, and source cannot be used.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Metadata")]
        [Validation(Required=false)]
        public string Metadata { get; set; }

        [NameInMap("Metrics")]
        [Validation(Required=false)]
        public string Metrics { get; set; }

        /// <summary>
        /// The name of the namespace.
        /// 
        /// >  You can call the [CreateNamespace](https://help.aliyun.com/document_detail/2401495.html) operation to create a namespace and call the [ListNamespaces](https://help.aliyun.com/document_detail/2401502.html) operation to query a list of namespaces.
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("Parser")]
        [Validation(Required=false)]
        public string Parser { get; set; }

        /// <summary>
        /// Specifies whether to enable the product quantization (PQ) feature for index acceleration. We recommend that you enable this feature for more than 500,000 rows of data. Valid values:
        /// 
        /// *   0: no.
        /// *   1 (default): yes.
        /// </summary>
        [NameInMap("PqEnable")]
        [Validation(Required=false)]
        public int? PqEnable { get; set; }

        /// <summary>
        /// The region ID of the instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
