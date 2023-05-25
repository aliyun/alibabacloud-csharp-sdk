// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateSnapshotGroupRequest : TeaModel {
        /// <summary>
        /// The description of the snapshot-consistent group. The description must be 2 to 256 characters in length and cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The ID of cloud disk N for which you want to create snapshots. You can specify multiple cloud disk IDs across instances within the same zone. Valid values of N: 1 to 16. A single snapshot-consistent group can contain snapshots of up to 16 cloud disks whose total disk size does not exceed 32 TiB.
        /// 
        /// Take note of the following items:
        /// 
        /// *   You cannot specify both DiskId.N and `ExcludeDiskId.N` in the same request.
        /// *   If `InstanceId` is set, you can use DiskId.N to specify only cloud disks attached to the instance specified by InstanceId, and you cannot use DiskId.N to specify cloud disks attached to multiple instances.
        /// </summary>
        [NameInMap("DiskId")]
        [Validation(Required=false)]
        public List<string> DiskId { get; set; }

        /// <summary>
        /// The ID of cloud disk N for which you do not want to create snapshots. If this parameter is specified, the created snapshot-consistent group does not contain snapshots of the cloud disk. Valid values of N: 1 to 16.
        /// 
        /// This parameter is empty by default, which indicates that snapshots are created for all the disks of the instance.
        /// 
        /// > You cannot specify ExcludeDiskId.N and `DiskId.N` in the same request.
        /// </summary>
        [NameInMap("ExcludeDiskId")]
        [Validation(Required=false)]
        public List<string> ExcludeDiskId { get; set; }

        /// <summary>
        /// The instance ID.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Specifies whether to enable the instant access feature. Valid values:
        /// 
        /// *   true
        /// *   false
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("InstantAccess")]
        [Validation(Required=false)]
        public bool? InstantAccess { get; set; }

        /// <summary>
        /// The number of days for which the instant access feature is available. Unit: days. Valid values: 1 to 65535.
        /// 
        /// This parameter takes effect only when `InstantAccess` is set to true. The instant access feature is automatically disabled when the specified duration ends.
        /// 
        /// This parameter is empty by default, which indicates that the expiration time of the instant access feature is determined by the time when snapshots are released.
        /// </summary>
        [NameInMap("InstantAccessRetentionDays")]
        [Validation(Required=false)]
        public int? InstantAccessRetentionDays { get; set; }

        /// <summary>
        /// The name of the snapshot-consistent group. The name must be 2 to 128 characters in length, and can contain letters, digits, periods (.), underscores (\_), hyphens (-), and colons (:). It must start with a letter and cannot start with `http://` or `https://`.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

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

        /// <summary>
        /// The ID of the resource group to which the snapshot-consistent group belongs.
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
        /// > This parameter is unavailable for public use.
        /// </summary>
        [NameInMap("StorageLocationArn")]
        [Validation(Required=false)]
        public string StorageLocationArn { get; set; }

        /// <summary>
        /// The list of tags.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateSnapshotGroupRequestTag> Tag { get; set; }
        public class CreateSnapshotGroupRequestTag : TeaModel {
            /// <summary>
            /// The key of tag N of the snapshot-consistent group. Valid values of N: 1 to 20. The tag key cannot be an empty string. The tag key can be up to 128 characters in length and cannot start with `acs:` or `aliyun`. It cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N of the snapshot-consistent group. Valid values of N: 1 to 20. The tag value can be an empty string. It can be up to 128 characters in length and cannot start with `acs:`. It cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
