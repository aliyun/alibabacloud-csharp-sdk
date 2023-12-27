// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class CreateElasticPlanRequest : TeaModel {
        /// <summary>
        /// The ID of the AnalyticDB for MySQL Data Warehouse Edition (V3.0) cluster.
        /// 
        /// > You can call the [DescribeDBClusters](~~129857~~) operation to query the IDs of all AnalyticDB for MySQL Data Warehouse Edition (V3.0) clusters within a region.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// Specifies whether the scaling plan takes effect. Valid values:
        /// 
        /// *   **true** (default)
        /// *   **false**
        /// </summary>
        [NameInMap("ElasticPlanEnable")]
        [Validation(Required=false)]
        public bool? ElasticPlanEnable { get; set; }

        /// <summary>
        /// The end date of the scaling plan. Specify the date in the yyyy-MM-dd format.
        /// </summary>
        [NameInMap("ElasticPlanEndDay")]
        [Validation(Required=false)]
        public string ElasticPlanEndDay { get; set; }

        [NameInMap("ElasticPlanMonthlyRepeat")]
        [Validation(Required=false)]
        public string ElasticPlanMonthlyRepeat { get; set; }

        /// <summary>
        /// The name of the scaling plan.
        /// 
        /// *   The name must be 2 to 30 characters in length.
        /// *   The name can contain letters, digits, and underscores (\_).
        /// </summary>
        [NameInMap("ElasticPlanName")]
        [Validation(Required=false)]
        public string ElasticPlanName { get; set; }

        /// <summary>
        /// The number of nodes that are involved in the scaling plan.
        /// 
        /// *   If ElasticPlanType is set to **worker**, you can set this parameter to 0 or leave this parameter empty.
        /// *   If ElasticPlanType is set to **executorcombineworker** or **executor**, you must set this parameter to a value that is greater than 0.
        /// </summary>
        [NameInMap("ElasticPlanNodeNum")]
        [Validation(Required=false)]
        public int? ElasticPlanNodeNum { get; set; }

        /// <summary>
        /// The start date of the scaling plan. Specify the date in the yyyy-MM-dd format.
        /// </summary>
        [NameInMap("ElasticPlanStartDay")]
        [Validation(Required=false)]
        public string ElasticPlanStartDay { get; set; }

        /// <summary>
        /// The restoration time of the scaling plan. Specify the time on the hour in the HH:mm:ss format. The interval between the scale-up time and the restoration time cannot be more than 24 hours.
        /// </summary>
        [NameInMap("ElasticPlanTimeEnd")]
        [Validation(Required=false)]
        public string ElasticPlanTimeEnd { get; set; }

        /// <summary>
        /// The scale-up time of the scaling plan. Specify the time on the hour in the HH:mm:ss format.
        /// </summary>
        [NameInMap("ElasticPlanTimeStart")]
        [Validation(Required=false)]
        public string ElasticPlanTimeStart { get; set; }

        /// <summary>
        /// The type of the scaling plan. Valid values:
        /// 
        /// *   **worker**: scales only elastic I/O resources.
        /// *   **executor**: scales only computing resources.
        /// *   **executorcombineworker** (default): scales both elastic I/O resources and computing resources by proportion.
        /// > - If you want to set this parameter to **executorcombineworker**, make sure that the cluster runs a minor version of 3.1.3.2 or later.
        /// > - If you want to set this parameter to **worker** or **executor**, make sure that the cluster runs a minor version of 3.1.6.1 or later and a ticket is submitted. After your request is approved, you can set this parameter to **worker** or **executor**.
        /// </summary>
        [NameInMap("ElasticPlanType")]
        [Validation(Required=false)]
        public string ElasticPlanType { get; set; }

        /// <summary>
        /// The days of the week when you want to execute the scaling plan. Valid values: 0 to 6, which indicates Sunday to Saturday. Separate multiple values with commas (,).
        /// </summary>
        [NameInMap("ElasticPlanWeeklyRepeat")]
        [Validation(Required=false)]
        public string ElasticPlanWeeklyRepeat { get; set; }

        /// <summary>
        /// The resource specifications that can be scaled up by the scaling plan. Valid values:
        /// 
        /// *   8 Core 64 GB (default)
        /// *   16 Core 64 GB
        /// *   32 Core 64 GB
        /// *   64 Core 128 GB
        /// *   12 Core 96 GB
        /// *   24 Core 96 GB
        /// *   52 Core 86 GB
        /// </summary>
        [NameInMap("ElasticPlanWorkerSpec")]
        [Validation(Required=false)]
        public string ElasticPlanWorkerSpec { get; set; }

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
        /// > You can call the [DescribeDBResourceGroup](~~466685~~) operation to query the resource group name.
        /// </summary>
        [NameInMap("ResourcePoolName")]
        [Validation(Required=false)]
        public string ResourcePoolName { get; set; }

    }

}
