// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeMaintenanceActionRequest : TeaModel {
        /// <summary>
        /// Specifies whether to return the information about pending or historical O\&M events. Valid values:
        /// 
        /// *   **0**: returns the information about pending O\&M event.
        /// *   **1**: returns the information about historical O\&M event.
        /// 
        /// If you do not specify this parameter, the information about pending O\&M event are returned.
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
        /// The page number. Pages start from page 1. Default value: **1**.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page. Valid values: **30**, **50**, and **100**. Default value: 30.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The region ID. Valid values:
        /// 
        /// *   The ID of the region where the O\&M event occurs. Example: `cn-hangzhou`. You can call the [DescribeRegions](~~143074~~) operation to query the most recent region list.
        /// *   You can also set Region to `all` to query the O\&M events in all regions. If you set `Region` to `all`, you must set `TaskType` to `all`.
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// The ID of the region where the O\&M event occurs.
        /// 
        /// > You can call the [DescribeRegions](~~143074~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The type of the O\&M event. Valid values:
        /// 
        /// *   **rds_apsaradb_upgrade**: database software upgrades.
        /// *   **all**: all the O\&M events in all regions within the current account. If you set `Region` to `all`, you must set `TaskType` to `all`.
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
