// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class DescribeMaintenanceActionRequest : TeaModel {
        /// <summary>
        /// Specifies whether to return the details of pending or historical O\&M events. Valid values:
        /// 
        /// *   **0**: returns the details of pending O\&M event.
        /// *   **1**: returns the details of historical O\&M event.
        /// 
        /// If you do not specify this parameter, the details of pending O\&M event are returned.
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
        /// The number of the page to return. The value must be an integer that is greater than 0. Default value: **1**.
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
        /// The ID of the region where the O\&M event occurs. Valid values:
        /// 
        /// *   The ID of the region where the O\&M event occurs. Example: `cn-hangzhou`. You can call the [DescribeRegions](~~143074~~) operation to query the regions and zones supported by AnalyticDB for MySQL, including the region IDs.
        /// *   You can also set Region to `all` to view all the O\&M events in all regions. If `Region` is set to `all`, `TaskType` must be set to `all`.
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// The ID of the region where the O\&M event occurs.
        /// 
        /// >  You can call the [DescribeRegions](~~143074~~) operation to query the regions and zones supported by AnalyticDB for MySQL, including the region IDs.
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
        /// *   **rds_apsaradb_upgrade**: indicates database software upgrades.
        /// *   **all**: indicates all the O\&M events in all regions within the current account. If `Region` is set to `all`, `TaskType` must be set to `all`.
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
