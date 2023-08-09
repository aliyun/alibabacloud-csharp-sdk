// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateSnapshotRequest : TeaModel {
        /// <summary>
        /// The description of the snapshot. The description must be 2 to 256 characters in length and cannot start with `http://` or `https://`.
        /// 
        /// By default, this parameter is left empty.
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// The retention period of the snapshot. Valid values: 1 to 65536. Unit: days. The snapshot is automatically released when its retention period expires.
        /// 
        /// This parameter is empty by default, which indicates that the snapshot is not automatically released.
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The cloud disk ID.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// Creates a snapshot for a disk.
        /// </summary>
        [NameInMap("DiskId")]
        [Validation(Required=false)]
        public string DiskId { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but make sure that the token is unique across requests. **The token can contain only ASCII characters and cannot exceed 64 characters in length.** For more information, see [How to ensure idempotence](~~25693~~).
        /// </summary>
        [NameInMap("InstantAccess")]
        [Validation(Required=false)]
        public bool? InstantAccess { get; set; }

        /// <summary>
        /// The ID of the resource group to which to assign the snapshot.
        /// </summary>
        [NameInMap("InstantAccessRetentionDays")]
        [Validation(Required=false)]
        public int? InstantAccessRetentionDays { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The snapshot type. Valid values:
        /// 
        /// *   Standard: normal snapshot
        /// *   Flash: local snapshot
        /// 
        /// > This parameter will be removed in the future. We recommend that you use the `InstantAccess` parameter to ensure future compatibility. This parameter and the `InstantAccess` parameter cannot be specified at the same time. For more information, see the "Description" section of this topic.
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
        /// The snapshot name. The name must be 2 to 128 characters in length. It must start with a letter and cannot start with `http://` or `https://`. It can contain letters, digits, colons (:), underscores (\_), and hyphens (-).
        /// 
        /// The name cannot start with `auto` because snapshots whose names start with auto are recognized as automatic snapshots.
        /// </summary>
        [NameInMap("RetentionDays")]
        [Validation(Required=false)]
        public int? RetentionDays { get; set; }

        /// <summary>
        /// The local snapshot feature is replaced by the instant access feature. Parameter description:
        /// 
        /// *   If you used the local snapshot feature before December 14, 2020, you can use the `Category` or `InstantAccess` parameter as expected and must take note of the following items:
        /// 
        ///     *   The `Category` and `InstantAccess` parameters cannot be specified at the same time.
        ///     *   If neither the `Category` nor `InstantAccess` parameters is specified, normal snapshots are created.
        /// 
        /// *   If you did not use the local snapshot feature before December 14, 2020, you can use the `InstantAccess` parameter but cannot use the `Category` parameter.
        /// 
        /// You cannot create snapshots for a disk in the following scenarios:
        /// 
        /// *   The number of manual snapshots of the disk has reached 256.
        /// *   A snapshot is being created for the disk.
        /// *   The instance to which the disk is attached has never been started.
        /// *   The ECS instance to which the disk is attached is not in the **Stopped** or **Running** state.````
        /// *   If the response contains `{"OperationLocks": {"LockReason" : "security"}}`, the instance is locked for security reasons. No operations are allowed on the instance.
        /// 
        /// When you create a snapshot, take note of the following items:
        /// 
        /// *   If a snapshot is being created, you cannot use this snapshot to create a custom image by calling the [CreateImage](~~25535~~) operation.
        /// *   When a snapshot is being created for a disk that is attached to an instance, do not change the instance state.
        /// *   You can create snapshots for a disk that is in the **Expired** state.`` If the release time scheduled for a disk arrives while a snapshot is being created for the disk, the snapshot is in the **Creating** state and is deleted when the disk is released.``
        /// </summary>
        [NameInMap("SnapshotName")]
        [Validation(Required=false)]
        public string SnapshotName { get; set; }

        /// <summary>
        /// The value of tag N that you want to add to the snapshot. Valid values of N: 1 to 20. The tag value can be an empty string. It can be up to 128 characters in length and cannot start with acs: or contain [http:// or https://.](http://https://。)
        /// </summary>
        [NameInMap("StorageLocationArn")]
        [Validation(Required=false)]
        public string StorageLocationArn { get; set; }

        /// <summary>
        /// Specifies whether to enable the instant access feature. Valid values:
        /// 
        /// *   true: enables the instant access feature. This feature can be enabled only for enhanced SSDs (ESSDs).
        /// 
        ///     **
        /// 
        ///     **Note**After the instant access feature is enabled, an instant access (IA) snapshot is created and can be used to roll back disks or create disks across zones even when the snapshot is being created. This feature ensures that a new ESSD snapshot is available for use as soon as possible regardless of its size.
        /// 
        /// *   false: does not enable the instant access feature. If InstantAccess is set to false, a normal snapshot is created.
        /// 
        /// Default value: false.
        /// 
        /// > This parameter and the `Category` parameter cannot be specified at the same time. For more information, see the "Description" section of this topic.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateSnapshotRequestTag> Tag { get; set; }
        public class CreateSnapshotRequestTag : TeaModel {
            /// <summary>
            /// The tags to add to the snapshot.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag key to add to the snapshot.
            /// 
            /// > This parameter will be deprecated in the future. We recommend that you use the Tag.N.key parameter to ensure future compatibility.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
