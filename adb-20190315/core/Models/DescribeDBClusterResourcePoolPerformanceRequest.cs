// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeDBClusterResourcePoolPerformanceRequest : TeaModel {
        /// <summary>
        /// The cluster ID.
        /// 
        /// > You can call the [DescribeDBClusters](~~129857~~) operation to query the information about all AnalyticDB for MySQL clusters within a region, including cluster IDs.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The end of the time range to monitor the resource group. The end time must be later than the start time. Specify the time in the ISO 8601 standard in the *yyyy-MM-ddTHH:mmZ* format. The time must be in UTC.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The metrics of the resource group. You can enter multiple metrics at the same time to query the monitoring information. Separate multiple metrics with commas (,). Valid values:
        /// 
        /// *   **AnalyticDB_RP_CPU**: the average CPU utilization. Unit: %.
        /// *   **AnalyticDB_RP_RT**: the query response time (RT). Unit: milliseconds.
        /// *   **AnalyticDB_RP_QPS**: the queries per second (QPS). The value of this parameter must be a numeric value.
        /// *   **AnalyticDB_RP_WaitTime**: the query waiting time. Unit: milliseconds.
        /// *   **AnalyticDB_RP_OriginalNode**: the number of basic nodes in the resource group.
        /// *   **AnalyticDB_RP_ActualNode**: the number of scheduled nodes that are scaled out in the resource group.
        /// *   **AnalyticDB_RP_PlanNode**: the number of scheduled nodes to be scaled out in the resource group.
        /// *   **AnalyticDB_RP_TotalNode**: the total number of nodes in the resource group. Total number of nodes = Number of basic nodes + Number of scheduled nodes that are scaled out.
        /// 
        /// > 
        /// 
        /// *   If you leave this parameter empty, the monitoring information about all metrics is returned.
        /// 
        /// *   For more information about scaling plans, see [Create a resource scaling plan](~~189507~~).
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

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
        /// The names of the resource groups that you want to query. You can enter multiple names of resource groups. Separate multiple names with commas (,).
        /// 
        /// > 
        /// 
        /// *   The value of this parameter is case-insensitive. For example, `USER_DEFAULT` and `user_default` specify the same resource group.
        /// 
        /// *   If you leave this parameter empty, the monitoring information about the `USER_DEFAULT` resource group is returned.
        /// </summary>
        [NameInMap("ResourcePools")]
        [Validation(Required=false)]
        public string ResourcePools { get; set; }

        /// <summary>
        /// The beginning of the time range to monitor the resource group. Specify the time in the ISO 8601 standard in the *yyyy-MM-ddTHH:mmZ* format. The time must be in UTC.
        /// 
        /// > You can view only the monitoring information about the resource groups within the last two days.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
