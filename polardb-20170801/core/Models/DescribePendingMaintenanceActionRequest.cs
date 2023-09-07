// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribePendingMaintenanceActionRequest : TeaModel {
        /// <summary>
        /// Specifies whether to return the historical tasks. Valid values:
        /// 
        /// *   **0**: returns the current task.
        /// *   **1**: returns the historical tasks.
        /// 
        /// Default value: **0**.
        /// </summary>
        [NameInMap("IsHistory")]
        [Validation(Required=false)]
        public int? IsHistory { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The page number. The value of this parameter must be an integer that is greater than 0. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Valid values: **30**, **50**, or **100**.
        /// 
        /// Default value: **30**.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The region ID of the pending event. You can call the [DescribeRegions](~~98041~~) operation to query the regions and zones that are supported by PolarDB.
        /// >- You can set this parameter to **all** to view all pending events within your account.
        /// >- If you set `Region` to **all**, you must set `TaskType` to **all**.
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

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

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        /// <summary>
        /// The task type of pending events. Valid values:
        /// 
        /// *   **DatabaseSoftwareUpgrading**: database software upgrades
        /// *   **DatabaseHardwareMaintenance**: hardware maintenance and upgrades
        /// *   **DatabaseStorageUpgrading**: database storage upgrades
        /// *   **DatabaseProxyUpgrading**: minor version upgrades of the proxy
        /// *   **all**: queries the details of the pending events of all preceding types.
        /// 
        /// > If the `Region` parameter is set to **all**, the `TaskType` parameter must be set to **all**.
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
