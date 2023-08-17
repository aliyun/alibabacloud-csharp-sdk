// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20190315.Models
{
    public class ModifyMaintenanceActionRequest : TeaModel {
        /// <summary>
        /// The ID of the pending O\&M event. You can specify multiple IDs to batch change the switchover time. Separate multiple IDs with commas (,).
        /// 
        /// > 
        /// 
        /// *   You can call the [DescribeMaintenanceAction](~~271738~~) operation to query the information about pending O\&M events, including the event ID.
        /// 
        /// *   You can change the switchover time only for pending O\&M events. The switchover time of historical O\&M events cannot be changed. For more information about the status of pending and historical O\&M events, see [DescribeMaintenanceAction](~~271738~~).
        /// </summary>
        [NameInMap("Ids")]
        [Validation(Required=false)]
        public string Ids { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The ID of the region where the pending O\&M event occurs.
        /// 
        /// > 
        /// 
        /// *   You can call the [DescribeRegions](~~143074~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

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
        /// The point in time when you want the system to perform operations on the pending O\&M event. Specify the time in the ISO 8601 standard in the `yyyy-MM-ddTHH:mm:ssZ` format. The time must be in UTC.
        /// </summary>
        [NameInMap("SwitchTime")]
        [Validation(Required=false)]
        public string SwitchTime { get; set; }

    }

}
