// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class DescribeElasticPlansRequest : TeaModel {
        /// <summary>
        /// The cluster ID.
        /// 
        /// > You can call the [DescribeDBClusters](~~129857~~) operation to query the IDs of all AnalyticDB for MySQL Data Lakehouse Edition (V3.0) clusters within a region.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The name of the scaling plan.
        /// 
        /// > If you do not specify this parameter, all scaling plans are queried.
        /// </summary>
        [NameInMap("ElasticPlanName")]
        [Validation(Required=false)]
        public string ElasticPlanName { get; set; }

        /// <summary>
        /// Indicates whether the scaling plan was immediately enabled after the plan is created. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The name of the resource group.
        /// 
        /// > *   If you do not specify this parameter, the scaling plans of all resource groups are queried, covering the interactive resource group type and the elastic I/O unit (EIU) type.
        /// >*   You can call the [DescribeDBResourceGroup](~~459446~~) operation to query the name of a resource group within a cluster.
        /// </summary>
        [NameInMap("ResourceGroupName")]
        [Validation(Required=false)]
        public string ResourceGroupName { get; set; }

        /// <summary>
        /// The type of the scaling plan. Valid values:
        /// 
        /// *   EXECUTOR: interactive resource groups, which fall into the computing resource category.
        /// *   WORKER: EIUs.
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
