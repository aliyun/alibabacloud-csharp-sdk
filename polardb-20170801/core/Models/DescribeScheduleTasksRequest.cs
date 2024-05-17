// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeScheduleTasksRequest : TeaModel {
        /// <summary>
        /// The description of the cluster.
        /// </summary>
        [NameInMap("DBClusterDescription")]
        [Validation(Required=false)]
        public string DBClusterDescription { get; set; }

        /// <summary>
        /// The cluster ID.
        /// 
        /// > 
        /// 
        /// *   You can call the [DescribeDBClusters](https://help.aliyun.com/document_detail/98094.html) operation to query the information of all PolarDB clusters that are deployed in a specific region, such as the cluster IDs.
        /// 
        /// *   If you do not specify this parameter, all scheduled tasks on your clusters are queried.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// The ID of the order.
        /// 
        /// >  The order ID can contain only digits.
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The page number of the page to return. Set this parameter to an integer that is greater than 0. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Valid values: **30**, **50**, and **100**. Default value: 30.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The latest start time of the task that you specified when you created the scheduled task. The time is displayed in UTC.
        /// </summary>
        [NameInMap("PlannedEndTime")]
        [Validation(Required=false)]
        public string PlannedEndTime { get; set; }

        /// <summary>
        /// The earliest start time of the task that you specified when you created the scheduled task. The time is displayed in UTC.
        /// </summary>
        [NameInMap("PlannedStartTime")]
        [Validation(Required=false)]
        public string PlannedStartTime { get; set; }

        /// <summary>
        /// The ID of the region.
        /// 
        /// > 
        /// 
        /// *   You can call the [DescribeRegions](https://help.aliyun.com/document_detail/98041.html) operation to query the region information of all clusters in a specific account.
        /// 
        /// *   If you do not specify this parameter, scheduled tasks on your clusters that are deployed in all regions are queried.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The state of the tasks that you want to query. Valid values:
        /// 
        /// *   **pending**: The tasks are pending execution.
        /// *   **executing**: The tasks are being executed.
        /// *   **failure**: The tasks failed and need to be run again.
        /// *   **finish**: The tasks are complete.
        /// *   **cancel**: The tasks are canceled.
        /// *   **expired**: The tasks are expired. The tasks are not started within the time periods that are specified to start the tasks.
        /// *   **rollback**: The tasks are being rolled back.
        /// 
        /// >  If you do not specify this parameter, all scheduled tasks in all states are queried.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The type of scheduled tasks that you want to query. Valid values:
        /// 
        /// *   **CreateDBNodes**
        /// *   **ModifyDBNodeClass**
        /// *   **UpgradeDBClusterVersion**
        /// *   **ModifyDBClusterPrimaryZone**
        /// 
        /// > 
        /// 
        /// *   If you specify the `PlannedStartTime` parameter when you call the four preceding operations, the details of each task are returned. Otherwise, an empty string is returned for the `TimerInfos` parameter.
        /// 
        /// *   If you do not specify this parameter, all types of scheduled tasks on you clusters are queried.
        /// </summary>
        [NameInMap("TaskAction")]
        [Validation(Required=false)]
        public string TaskAction { get; set; }

    }

}
