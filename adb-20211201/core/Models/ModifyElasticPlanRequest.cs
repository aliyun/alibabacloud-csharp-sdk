// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class ModifyElasticPlanRequest : TeaModel {
        /// <summary>
        /// A CORN expression that specifies the scaling cycle and time for the scaling plan.
        /// </summary>
        [NameInMap("CronExpression")]
        [Validation(Required=false)]
        public string CronExpression { get; set; }

        /// <summary>
        /// The ID of the cluster.
        /// 
        /// >  You can call the [DescribeDBClusters](~~129857~~) operation to query the ID of an AnalyticDB for MySQL Data Warehouse Edition (V3.0) cluster.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The name of the scaling plan.
        /// 
        /// >  You can call the [DescribeElasticPlans](~~601334~~) operation to query the name of a scaling plan of a specific cluster.
        /// </summary>
        [NameInMap("ElasticPlanName")]
        [Validation(Required=false)]
        public string ElasticPlanName { get; set; }

        /// <summary>
        /// The time to end the scaling plan.
        /// 
        /// >  Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

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

    }

}
