// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeElasticPlanJobsRequest : TeaModel {
        /// <summary>
        /// The ID of the cluster.
        /// 
        /// >  You can call the [DescribeDBClusters](~~129857~~) operation to query the ID of an AnalyticDB for MySQL Data Lakehouse Edition (V3.0) cluster.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The name of the scaling plan.
        /// 
        /// > *   If you do not specify this parameter, all scaling plans of the cluster are queried.
        /// > *   You can call the [DescribeElasticPlans](~~601334~~) operation to query the name of a scaling plan.
        /// </summary>
        [NameInMap("ElasticPlanName")]
        [Validation(Required=false)]
        public string ElasticPlanName { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of scaling plan jobs to return per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The name of the resource group.
        /// 
        /// > *   If you do not specify this parameter, the scaling plans of all resource groups are queried, including interactive resource groups and elastic I/O units (EIUs).
        /// > *   You can call the [DescribeDBResourceGroup](~~459446~~) operation to query the name of a resource group within a specific cluster.
        /// </summary>
        [NameInMap("ResourceGroupName")]
        [Validation(Required=false)]
        public string ResourceGroupName { get; set; }

        /// <summary>
        /// The time to enable the scaling plan job.
        /// 
        /// Specify the time in the ISO 8601 standard in the yyyy-MM-ddThh:mm:ssZ format. The time must be in UTC.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The state of the scaling plan job.
        /// 
        /// Valid values:
        /// 
        /// *   RUNNING: The job is running.
        /// 
        /// *   SUCCESSFUL: The job is successfully run.
        /// 
        /// *   FAILED: The job fails.
        /// 
        /// > If you do not specify this parameter, scaling plan jobs in all states are queried.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
