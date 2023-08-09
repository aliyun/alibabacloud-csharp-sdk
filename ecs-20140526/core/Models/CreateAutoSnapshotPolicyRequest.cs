// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateAutoSnapshotPolicyRequest : TeaModel {
        /// <summary>
        /// The retention period of the snapshot copy in the destination region. Unit: days. Valid values:
        /// 
        /// *   \-1: The snapshot copy is permanently retained.
        /// *   A value in the range of 1 to 65535: The snapshot copy is retained for the specified number of days.
        /// 
        /// Default value: -1.
        /// </summary>
        [NameInMap("CopiedSnapshotsRetentionDays")]
        [Validation(Required=false)]
        public int? CopiedSnapshotsRetentionDays { get; set; }

        /// <summary>
        /// Specifies whether to enable cross-region replication for snapshots.
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("EnableCrossRegionCopy")]
        [Validation(Required=false)]
        public bool? EnableCrossRegionCopy { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The resource group ID.
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
        /// > This parameter is not publicly available.
        /// </summary>
        [NameInMap("StorageLocationArn")]
        [Validation(Required=false)]
        public string StorageLocationArn { get; set; }

        /// <summary>
        /// The tags to add to the snapshot.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateAutoSnapshotPolicyRequestTag> Tag { get; set; }
        public class CreateAutoSnapshotPolicyRequestTag : TeaModel {
            /// <summary>
            /// The key of tag N to add to the snapshot. Valid values of N: 1 to 20. The tag key cannot be an empty string. The tag key can be up to 128 characters in length. The tag key cannot start with acs: or aliyun or contain [http:// or https://.](http://https://。)
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N to add to the snapshot. Valid values of N: 1 to 20. The tag value can be an empty string. The tag value can be up to 128 characters in length. The tag value cannot start with acs: or aliyun or contain [http:// or https://.](http://https://。)
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The destination region to which to copy the snapshot. You can specify only a single destination region.
        /// </summary>
        [NameInMap("TargetCopyRegions")]
        [Validation(Required=false)]
        public string TargetCopyRegions { get; set; }

        /// <summary>
        /// The name of the automatic snapshot policy. The name must be 2 to 128 characters in length. It must start with a letter and cannot start with [http:// or https://. It can contain letters, digits, colons (.), underscores (\_), and hyphens (-).](http://https://。、（:）、（\_）（-）。)
        /// 
        /// This parameter is empty by default.
        /// </summary>
        [NameInMap("autoSnapshotPolicyName")]
        [Validation(Required=false)]
        public string AutoSnapshotPolicyName { get; set; }

        /// <summary>
        /// The ID of the region in which to create the automatic snapshot policy. You can call the [DescribeRegions](~~25609~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The days of the week on which to create automatic snapshots. Valid values: 1 to 7, which correspond to Monday to Sunday. 1 indicates Monday. Format description:
        /// 
        /// *   Set this parameter to a JSON-formatted array. For example, a value of \["1"] specifies automatic snapshots to be created every Monday.
        /// *   To schedule multiple automatic snapshots to be created in a week, you can specify multiple values. Separate the values with commas (,). You can specify a maximum of seven days. For example, a value of \["1","3","5"] specifies automatic snapshots to be created every Monday, Wednesday, and Friday.
        /// </summary>
        [NameInMap("repeatWeekdays")]
        [Validation(Required=false)]
        public string RepeatWeekdays { get; set; }

        /// <summary>
        /// The retention period of the automatic snapshot. Unit: days. Valid values:
        /// 
        /// *   \-1: The snapshot is permanently retained.
        /// *   A value in the range of 1 to 65535: The snapshot is retained for the specified number of days.
        /// 
        /// Default value: -1.
        /// </summary>
        [NameInMap("retentionDays")]
        [Validation(Required=false)]
        public int? RetentionDays { get; set; }

        /// <summary>
        /// The points in time of the day at which to create automatic snapshots. The time must be in UTC+8. Unit: hours. Valid values: 0 to 23, which correspond to the 24 on-the-hour points in time from 00:00:00 to 23:00:00. 1 indicates 01:00:00. Format description:
        /// 
        /// *   Set this parameter to a JSON-formatted array. For example, a value of \["1"] specifies automatic snapshots to be created at 01:00:00.
        /// *   To schedule multiple automatic snapshots to be created in a day, you can specify multiple values. Separate the values with commas (,). You can specify a maximum of 24 points in time. For example, a value of \["1","3","5"] specifies automatic snapshots to be created at 01:00:00, 03:00:00, and 05:00:00.
        /// </summary>
        [NameInMap("timePoints")]
        [Validation(Required=false)]
        public string TimePoints { get; set; }

    }

}
