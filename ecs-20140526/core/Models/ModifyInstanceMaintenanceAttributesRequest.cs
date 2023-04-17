// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyInstanceMaintenanceAttributesRequest : TeaModel {
        /// <summary>
        /// The maintenance action. Valid values:
        /// 
        /// *   Stop: stops the instance.
        /// *   AutoRecover: automatically recovers the instance.
        /// *   AutoRedeploy: redeploys the instance, which may damage the data of the local disks (if any).
        /// </summary>
        [NameInMap("ActionOnMaintenance")]
        [Validation(Required=false)]
        public string ActionOnMaintenance { get; set; }

        /// <summary>
        /// The ID of instance N. Valid values of N: 1 to 100.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public List<string> InstanceId { get; set; }

        /// <summary>
        /// The maintenance windows.
        /// </summary>
        [NameInMap("MaintenanceWindow")]
        [Validation(Required=false)]
        public List<ModifyInstanceMaintenanceAttributesRequestMaintenanceWindow> MaintenanceWindow { get; set; }
        public class ModifyInstanceMaintenanceAttributesRequestMaintenanceWindow : TeaModel {
            /// <summary>
            /// The end time of the maintenance window. The time must be on the hour at exactly 0 minute and 0 second. The StartTime and EndTime parameters must be specified at the same time. The EndTime value must be 1 to 23 hours later than the StartTime value. Specify the time in the `HH:mm:ss` format. The time must be in UTC+8. Set the value of N to 1.
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// The start time of the maintenance window. The time must be on the hour at exactly 0 minute and 0 second. The StartTime and EndTime parameters must be specified at the same time. The EndTime value must be 1 to 23 hours later than the StartTime value. Specify the time in the `HH:mm:ss` format. The time must be in UTC+8. Set the value of N to 1.
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

        }

        /// <summary>
        /// Specifies whether to send an event notification before maintenance. Valid values:
        /// 
        /// *   True: sends an event notification.
        /// *   False: does not send an event notification.
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("NotifyOnMaintenance")]
        [Validation(Required=false)]
        public bool? NotifyOnMaintenance { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the instance. You can call the [DescribeRegions](~~25609~~) operation to query the most recent list of regions.
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

    }

}
