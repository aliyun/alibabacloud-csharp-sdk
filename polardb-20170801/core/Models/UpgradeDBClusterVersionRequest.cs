// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class UpgradeDBClusterVersionRequest : TeaModel {
        /// <summary>
        /// The ID of cluster.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// Specifies whether to immediately run the task to modify parameters and restart the cluster. Valid values: 
        /// 
        /// - false: runs the task on schedule. 
        /// - true: runs the task immediately. Default value: false.
        /// 
        /// > No need to use this parameter when calling this interface
        /// </summary>
        [NameInMap("FromTimeService")]
        [Validation(Required=false)]
        public bool? FromTimeService { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The latest start time to run the task that updates the kernel version of the cluster. Specify the time in the `YYYY-MM-DDThh:mm:ssZ` format. The time must be in UTC.
        /// 
        /// > *   The value of this parameter must be at least 30 minutes later than the value of PlannedStartTime.
        /// >*   If you specify `PlannedStartTime` but do not specify PlannedEndTime, the latest start time of the task is `PlannedEndTime + 30 minutes`. For example, if you set `PlannedStartTime` to `2021-01-14T09:00:00Z` and do not specify PlannedEndTime, the latest start time of the task is set to `2021-01-14T09:30:00Z`.
        /// </summary>
        [NameInMap("PlannedEndTime")]
        [Validation(Required=false)]
        public string PlannedEndTime { get; set; }

        /// <summary>
        /// The earliest start time to run the task that updates the kernel version of the cluster. Specify the time in the `YYYY-MM-DDThh:mm:ssZ` format. The time must be in UTC.
        /// 
        /// > *   The earliest start time of the task can be a point in time within the next 24 hours. For example, if the current time is `2021-01-14T09:00:00Z`, you can specify a point in time between `2021-01-14T09:00:00Z` and `2021-01-15T09:00:00Z`.
        /// >*   If you do not specify this parameter, the kernel update task runs immediately after you submit the request.
        /// </summary>
        [NameInMap("PlannedStartTime")]
        [Validation(Required=false)]
        public string PlannedStartTime { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The code of the version to which you want to upgrade the cluster. You can call the [DescribeDBClusterVersion](~~2319145~~) operation to query the version code.
        /// </summary>
        [NameInMap("TargetDBRevisionVersionCode")]
        [Validation(Required=false)]
        public string TargetDBRevisionVersionCode { get; set; }

        /// <summary>
        /// Kernel version upgrade label. The value is fixed as INNOVATE.
        /// > this parameter is passed in, UpgradePolicy must pass COLD.
        /// </summary>
        [NameInMap("UpgradeLabel")]
        [Validation(Required=false)]
        public string UpgradeLabel { get; set; }

        /// <summary>
        /// Kernel version upgrade strategy. Value:
        /// 
        /// - HOT: Hot Upgrade
        /// - COLD: Cold upgrade. Currently, only PolarDB MySQL version 8.0 cluster version supports this upgrade method.
        /// </summary>
        [NameInMap("UpgradePolicy")]
        [Validation(Required=false)]
        public string UpgradePolicy { get; set; }

        /// <summary>
        /// There is no need to use this parameter to upgrade the type when calling this interface. Value:
        /// 
        /// - PROXY: Upgrade database proxy only (Proxy)
        /// - DB: Upgrade kernel engine only
        /// - ALL (default): Upgrade both database proxy and kernel engine simultaneously
        /// </summary>
        [NameInMap("UpgradeType")]
        [Validation(Required=false)]
        public string UpgradeType { get; set; }

    }

}
