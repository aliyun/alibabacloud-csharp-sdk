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
        /// The cluster ID.
        /// 
        /// >  You can call the [DescribeDBClusters](~~129857~~) operation to query the IDs of all AnalyticDB for MySQL Data Lakehouse Edition (V3.0) clusters within a region.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The name of the scaling plan.
        /// 
        /// >  You can call the [DescribeElasticPlans](~~601334~~) operation to query the names of scaling plans.
        /// </summary>
        [NameInMap("ElasticPlanName")]
        [Validation(Required=false)]
        public string ElasticPlanName { get; set; }

        /// <summary>
        /// The end time of the scaling plan.
        /// 
        /// >  Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The start time of the scaling plan.
        /// 
        /// >  Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The desired specifications of elastic resources after scaling.
        /// 
        /// > 
        /// 
        /// *   If the scaling plan uses **EIUs** and **Default Proportional Scaling for EIUs** is enabled, you do not need to specify this parameter. In other cases, you must specify this parameter.
        /// 
        /// *   You can call the [DescribeElasticPlanSpecifications](~~601278~~) operation to query the specifications that are supported for scaling plans.
        /// </summary>
        [NameInMap("TargetSize")]
        [Validation(Required=false)]
        public string TargetSize { get; set; }

    }

}
