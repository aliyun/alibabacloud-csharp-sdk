// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class CreateElasticPlanRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable **Default Proportional Scaling for EIUs**. Valid values:
        /// 
        /// *   true. In this case, storage resources are scaled along with computing resources, and the TargetSize and CronExpression parameters are not supported.
        /// *   false
        /// 
        /// > 
        /// 
        /// *   This parameter must be specified when Type is set to WORKER. This parameter is not required when Type is set to EXECUTOR.
        /// 
        /// *   You can enable Default Proportional Scaling for EIUs for only a single scaling plan of a cluster.
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
        /// The cluster ID.
        /// 
        /// >  You can call the [DescribeDBClusters](https://help.aliyun.com/document_detail/454250.html) operation to query the IDs of all AnalyticDB for MySQL Data Lakehouse Edition (V3.0) clusters within a region.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The name of the scaling plan.
        /// 
        /// >  The name must be 2 to 30 characters in length and can contain letters, digits, and underscores (_). The name must start with a letter.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ElasticPlanName")]
        [Validation(Required=false)]
        public string ElasticPlanName { get; set; }

        /// <summary>
        /// Specifies whether to immediately enable the scaling plan after the plan is created. Valid values:
        /// 
        /// *   true
        /// *   false
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The end time of the scaling plan.
        /// 
        /// >  Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The name of the resource group.
        /// 
        /// > 
        /// 
        /// *   If you want to create a scaling plan that uses interactive resource groups, you must specify this parameter. If you want to create a scaling plan that uses elastic I/O units (EIUs), you do not need to specify this parameter.
        /// 
        /// *   You can call the [DescribeDBResourceGroup](https://help.aliyun.com/document_detail/459446.html) operation to query the resource group name for a cluster.
        /// </summary>
        [NameInMap("ResourceGroupName")]
        [Validation(Required=false)]
        public string ResourceGroupName { get; set; }

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
        /// *   You can call the [DescribeElasticPlanSpecifications](https://help.aliyun.com/document_detail/601278.html) operation to query the specifications that are supported for scaling plans.
        /// </summary>
        [NameInMap("TargetSize")]
        [Validation(Required=false)]
        public string TargetSize { get; set; }

        /// <summary>
        /// The type of the scaling plan. Valid values:
        /// 
        /// *   EXECUTOR: the interactive resource group type, which indicates the computing resource type.
        /// *   WORKER: the EIU type.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
