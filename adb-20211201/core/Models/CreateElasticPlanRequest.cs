// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class CreateElasticPlanRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable **Proportional Default Scaling for EIUs**.
        /// 
        /// Valid values:
        /// 
        /// *   true: enables Proportional Default Scaling for EIUs. If you enable Proportional Default Scaling, storage resources are scaled along with computing resources, and the TargetSize and CronExpression parameters are not supported.
        /// 
        /// *   false: does not enable Proportional Default Scaling for EIUs.
        /// 
        /// > *   This parameter is required if the Type parameter is set to WORKER. This parameter is not required if the Type parameter is set to EXECUTOR.
        /// > *   You can enable Proportional Default Scaling for EIUs for only a single scaling plan of a cluster.
        /// </summary>
        [NameInMap("AutoScale")]
        [Validation(Required=false)]
        public bool? AutoScale { get; set; }

        /// <summary>
        /// A CORN expression that specifies the scaling cycle and time for the scaling plan.
        /// </summary>
        [NameInMap("CronExpression")]
        [Validation(Required=false)]
        public string CronExpression { get; set; }

        /// <summary>
        /// The ID of the cluster.
        /// 
        /// >  You can call the [DescribeDBClusters](~~454250~~) operation to query the ID of an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The name of the scaling plan.
        /// 
        /// >  The name must be 2 to 30 characters in length, and can contain letters, digits, and underscores (\_). It must start with a letter.
        /// </summary>
        [NameInMap("ElasticPlanName")]
        [Validation(Required=false)]
        public string ElasticPlanName { get; set; }

        /// <summary>
        /// Specifies whether to immediately enable the scaling plan after the scaling plan is created.
        /// 
        /// Valid values:
        /// 
        /// *   true: immediately enables the scaling plan.
        /// *   false: does not immediately enable the scaling plan.
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The time to end the scaling plan.
        /// 
        /// >  Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The name of the resource group.
        /// 
        /// > *   This parameter is required if you want to create a scaling plan that uses interactive resource groups. This parameter is not required if you want to create a scaling plan that uses elastic I/O units (EIUs).
        /// > *   You can call the [DescribeDBResourceGroup](~~459446~~) operation to query the name of a resource group within a specific cluster.
        /// </summary>
        [NameInMap("ResourceGroupName")]
        [Validation(Required=false)]
        public string ResourceGroupName { get; set; }

        /// <summary>
        /// The time to start the scaling plan.
        /// 
        /// >  Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The amount of elastic resources after scaling.
        /// 
        /// > *   This parameter is not required only if the resource group uses **EIUs** and **Proportional Default Scaling for EIUs** is enabled.
        /// > *   You can call the [DescribeElasticPlanSpecifications](~~601278~~) operation to query the specifications that are supported for scaling plans.
        /// </summary>
        [NameInMap("TargetSize")]
        [Validation(Required=false)]
        public string TargetSize { get; set; }

        /// <summary>
        /// The type of the scaling plan.
        /// 
        /// Valid values:
        /// 
        /// *   EXECUTOR: interactive resource groups, which fall into the computing resource category.
        /// *   WORKER: EIUs.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
