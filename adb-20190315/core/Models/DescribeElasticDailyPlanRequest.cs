// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeElasticDailyPlanRequest : TeaModel {
        /// <summary>
        /// The ID of the AnalyticDB for MySQL Data Warehouse Edition (V3.0) cluster.
        /// 
        /// >  You can call the [DescribeDBClusters](~~129857~~) operation to query the cluster IDs of all AnalyticDB for MySQL Data Warehouse Edition (V3.0) clusters within a specific region.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The start date of the current-day scaling plan. Specify the date in the yyyy-MM-dd format.
        /// </summary>
        [NameInMap("ElasticDailyPlanDay")]
        [Validation(Required=false)]
        public string ElasticDailyPlanDay { get; set; }

        /// <summary>
        /// The execution state of the current-day scaling plan. Separate multiple values with commas (,). Valid values:
        /// 
        /// *   **1**: The scaling plan is not executed.
        /// *   **2**: The scaling plan is being executed.
        /// *   **3**: The scaling plan is executed.
        /// *   **4**: The scaling plan fails to be executed.
        /// </summary>
        [NameInMap("ElasticDailyPlanStatusList")]
        [Validation(Required=false)]
        public string ElasticDailyPlanStatusList { get; set; }

        /// <summary>
        /// The name of the scaling plan. Valid values:
        /// 
        /// *   The name must be 2 to 30 characters in length.
        /// *   The name can contain letters, digits, and underscores (\_).
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
        /// >  You can call the [DescribeDBResourceGroup](~~466685~~) operation to query the resource group name.
        /// </summary>
        [NameInMap("ResourcePoolName")]
        [Validation(Required=false)]
        public string ResourcePoolName { get; set; }

    }

}
