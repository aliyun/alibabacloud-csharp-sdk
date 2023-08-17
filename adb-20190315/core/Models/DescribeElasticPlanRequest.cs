// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeElasticPlanRequest : TeaModel {
        /// <summary>
        /// The ID of the AnalyticDB for MySQL Data Warehouse Edition (V3.0) cluster.
        /// 
        /// >  You can call the [DescribeDBClusters](~~129857~~) operation to query the cluster IDs of all AnalyticDB for MySQL Data Warehouse Edition (V3.0) clusters within a specific region.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// Specifies whether the scaling plan takes effect. Default value: true. Valid values:
        /// 
        /// *   **true**: The scaling plan takes effect.
        /// *   **false**: The scaling plan does not take effect.
        /// </summary>
        [NameInMap("ElasticPlanEnable")]
        [Validation(Required=false)]
        public bool? ElasticPlanEnable { get; set; }

        /// <summary>
        /// The name of the scaling plan.
        /// 
        /// *   The name must be 2 to 30 characters in length.
        /// 
        /// *   The name can contain letters, digits, and underscores (\_).
        /// 
        /// >  If you do not specify this parameter, the details of all scaling plans for the specified cluster are returned.
        /// </summary>
        [NameInMap("ElasticPlanName")]
        [Validation(Required=false)]
        public string ElasticPlanName { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The name of the resource group.
        /// 
        /// > *   You can call the [DescribeDBResourceGroup](~~466685~~) operation to query the resource group name.
        /// </summary>
        [NameInMap("ResourcePoolName")]
        [Validation(Required=false)]
        public string ResourcePoolName { get; set; }

    }

}
