// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CopySnapshotRequest : TeaModel {
        /// <summary>
        /// >This parameter is currently in invitational preview and unavailable for public use.
        /// </summary>
        [NameInMap("Arn")]
        [Validation(Required=false)]
        public List<CopySnapshotRequestArn> Arn { get; set; }
        public class CopySnapshotRequestArn : TeaModel {
            /// <summary>
            /// > This parameter is not publicly available.
            /// </summary>
            [NameInMap("AssumeRoleFor")]
            [Validation(Required=false)]
            public long? AssumeRoleFor { get; set; }

            /// <summary>
            /// > This parameter is not publicly available.
            /// </summary>
            [NameInMap("RoleType")]
            [Validation(Required=false)]
            public string RoleType { get; set; }

            /// <summary>
            /// > This parameter is not publicly available.
            /// </summary>
            [NameInMap("Rolearn")]
            [Validation(Required=false)]
            public string Rolearn { get; set; }

        }

        /// <summary>
        /// The ID of the destination region to which to copy the source snapshot.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DestinationRegionId")]
        [Validation(Required=false)]
        public string DestinationRegionId { get; set; }

        /// <summary>
        /// The description of the new snapshot. The description must be 2 to 256 characters in length and cannot start with http:// or https://.
        /// 
        /// This parameter is empty by default.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DestinationSnapshotDescription")]
        [Validation(Required=false)]
        public string DestinationSnapshotDescription { get; set; }

        /// <summary>
        /// The name of the new snapshot. The name must be 2 to 128 characters in length. It must start with a letter and cannot start http:// or https://. The name can contain digits, letters, colons (:), underscores (_), and hyphens (-).
        /// 
        /// This parameter is empty by default.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DestinationSnapshotName")]
        [Validation(Required=false)]
        public string DestinationSnapshotName { get; set; }

        /// <summary>
        /// >  This parameter is not publicly available.
        /// </summary>
        [NameInMap("DestinationStorageLocationArn")]
        [Validation(Required=false)]
        public string DestinationStorageLocationArn { get; set; }

        /// <summary>
        /// Specifies whether to encrypt the new snapshot. Valid values:
        /// 
        /// *   true
        /// *   false
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("Encrypted")]
        [Validation(Required=false)]
        public bool? Encrypted { get; set; }

        /// <summary>
        /// The ID of the customer master key (CMK) in Key Management Service (KMS) in the destination region.
        /// </summary>
        [NameInMap("KMSKeyId")]
        [Validation(Required=false)]
        public string KMSKeyId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the source snapshot. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/25609.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// This parameter is not publicly available.
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
        /// The retention period of the new snapshot. Unit: days. The new snapshot is automatically released when its retention period ends. Valid values: 1 to 65536.
        /// 
        /// This parameter is empty by default, which indicates that the snapshot is not automatically released.
        /// </summary>
        [NameInMap("RetentionDays")]
        [Validation(Required=false)]
        public int? RetentionDays { get; set; }

        /// <summary>
        /// The ID of the source snapshot.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

        /// <summary>
        /// The tag key and value of the new snapshot.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CopySnapshotRequestTag> Tag { get; set; }
        public class CopySnapshotRequestTag : TeaModel {
            /// <summary>
            /// The key of tag N to add to the new snapshot. The tag key cannot be an empty string. It can be up to 128 characters in length and cannot start with acs: or aliyun. It cannot contain http:// or https://.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N to add to the new snapshot. The tag value can be an empty string. It can be up to 128 characters in length and cannot start with acs: or aliyun. It cannot contain http:// or https://.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
