// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class ModifyDBResourcePoolRequest : TeaModel {
        /// <summary>
        /// The ID of the AnalyticDB for MySQL Data Warehouse Edition (V3.0) cluster.
        /// 
        /// > You can call the [DescribeDBClusters](~~129857~~) operation to query the IDs of all AnalyticDB for MySQL Data Warehouse Edition (V3.0) clusters within a region.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The number of nodes.
        /// 
        /// *   Each node provides 16 cores and 64 GB memory.
        /// *   The amount of resources that you want to add to or remove from the cluster cannot exceed the total amount of resources in the cluster.
        /// 
        /// > - If you do not specify this parameter, the original value is retained.
        /// > - You must specify at least one of the QueryType and NodeNum parameters.
        /// </summary>
        [NameInMap("NodeNum")]
        [Validation(Required=false)]
        public int? NodeNum { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [NameInMap("PoolName")]
        [Validation(Required=false)]
        public string PoolName { get; set; }

        /// <summary>
        /// The mode in which SQL statements are executed. Valid values:
        /// 
        /// *   **batch**
        /// *   **interactive**
        /// 
        /// > If you do not specify this parameter, the original value is retained.
        /// </summary>
        [NameInMap("QueryType")]
        [Validation(Required=false)]
        public string QueryType { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
