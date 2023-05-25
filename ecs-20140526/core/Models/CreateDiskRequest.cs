// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateDiskRequest : TeaModel {
        /// <summary>
        /// This parameter is not available for public use.
        /// </summary>
        [NameInMap("AdvancedFeatures")]
        [Validation(Required=false)]
        public string AdvancedFeatures { get; set; }

        /// <summary>
        /// This parameter is not available for public use.
        /// </summary>
        [NameInMap("Arn")]
        [Validation(Required=false)]
        public List<CreateDiskRequestArn> Arn { get; set; }
        public class CreateDiskRequestArn : TeaModel {
            /// <summary>
            /// This parameter is not available for public use.
            /// </summary>
            [NameInMap("AssumeRoleFor")]
            [Validation(Required=false)]
            public long? AssumeRoleFor { get; set; }

            /// <summary>
            /// This parameter is not available for public use.
            /// </summary>
            [NameInMap("RoleType")]
            [Validation(Required=false)]
            public string RoleType { get; set; }

            /// <summary>
            /// This parameter is not available for public use.
            /// </summary>
            [NameInMap("Rolearn")]
            [Validation(Required=false)]
            public string Rolearn { get; set; }

        }

        /// <summary>
        /// This parameter is not available for public use.
        /// </summary>
        [NameInMap("BurstingEnabled")]
        [Validation(Required=false)]
        public bool? BurstingEnabled { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The **token** can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see [How to ensure idempotence](~~25693~~).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The description of the disk. The description must be 2 to 256 characters in length and cannot start with `http://` or `https://`.
        /// 
        /// This parameter is empty by default.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The disk category. Valid values:
        /// 
        /// *   cloud: basic disk
        /// *   cloud_efficiency: ultra disk
        /// *   cloud_ssd: SSD
        /// *   cloud_essd: ESSD
        /// 
        /// Default value: cloud.
        /// </summary>
        [NameInMap("DiskCategory")]
        [Validation(Required=false)]
        public string DiskCategory { get; set; }

        /// <summary>
        /// The disk name. The name must be 2 to 128 characters in length. It must start with a letter and cannot start with `http://` or `https://`. It can contain letters, digits, colons (:), underscores (\_), and hyphens (-).
        /// 
        /// This parameter is empty by default.
        /// </summary>
        [NameInMap("DiskName")]
        [Validation(Required=false)]
        public string DiskName { get; set; }

        /// <summary>
        /// This parameter is not available for public use.
        /// </summary>
        [NameInMap("EncryptAlgorithm")]
        [Validation(Required=false)]
        public string EncryptAlgorithm { get; set; }

        /// <summary>
        /// Specifies whether to encrypt the disk. Valid values:
        /// 
        /// *   true: encrypts the disk.
        /// *   false: does not encrypt the disk.
        /// 
        /// Default value: false
        /// </summary>
        [NameInMap("Encrypted")]
        [Validation(Required=false)]
        public bool? Encrypted { get; set; }

        /// <summary>
        /// The ID of the subscription instance to which you want to automatically attach the created subscription disk.
        /// 
        /// *   After you specify the instance ID, the specified ResourceGroupId, Tag.N.Key, Tag.N.Value, ClientToken, and KMSKeyId parameters are ignored.
        /// *   You cannot specify the ZoneId and InstanceId parameters at the same time.
        /// 
        /// By default, this parameter is empty. This specifies that a pay-as-you-go disk is created. The RegionId and ZoneId parameters specify where the disk resides.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The ID of the Key Management Service (KMS) key that you want to use for the disk.
        /// </summary>
        [NameInMap("KMSKeyId")]
        [Validation(Required=false)]
        public string KMSKeyId { get; set; }

        /// <summary>
        /// Specifies whether to enable the multi-attach feature for the disk. Valid values:
        /// 
        /// *   Disabled
        /// *   Enabled Set the value to `Enabled` only for ESSDs.
        /// 
        /// Default value: Disabled.
        /// 
        /// **
        /// 
        /// **Disks for which the multi-attach feature is enabled only support the pay-as-you-go billing method.** If you set the `MultiAttach` parameter to Enabled, you cannot specify the `InstanceId` parameter. After you create disks, you can call the [AttachDisk](~~25515~~) operation to attach the disks to instances. You can attach disks for which the multi-attach feature is enabled only as data disks.
        /// </summary>
        [NameInMap("MultiAttach")]
        [Validation(Required=false)]
        public string MultiAttach { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The performance level of the ESSD. Default value: PL1. Valid values:
        /// 
        /// *   PL0: An ESSD can deliver up to 10,000 random read/write IOPS.
        /// *   PL1: An ESSD can deliver up to 50,000 random read/write IOPS.
        /// *   PL2: An ESSD can deliver up to 100,000 random read/write IOPS.
        /// *   PL3: An ESSD can deliver up to 1,000,000 random read/write IOPS.
        /// 
        /// Default value: PL1.
        /// 
        /// For more information about ESSD performance levels, see [ESSDs](~~122389~~).
        /// </summary>
        [NameInMap("PerformanceLevel")]
        [Validation(Required=false)]
        public string PerformanceLevel { get; set; }

        /// <summary>
        /// This parameter is not available for public use.
        /// </summary>
        [NameInMap("ProvisionedIops")]
        [Validation(Required=false)]
        public long? ProvisionedIops { get; set; }

        /// <summary>
        /// The ID of the region in which to create the disk. You can call the [DescribeRegions](~~25609~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group to which you want to assign the disk.
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
        /// The disk size. Unit: GiB. You must specify this parameter. Valid values:
        /// 
        /// *   Valid values when DiskCategory is set to cloud: 5 to 2,000
        /// 
        /// *   Valid values when DiskCategory is set to cloud_efficiency: 20 to 32,768
        /// 
        /// *   Valid values when DiskCategory is set to cloud_ssd: 20 to 32,768
        /// 
        /// *   Valid values when DiskCategory is set to cloud_essd: based on the value of the `PerformanceLevel` parameter
        /// 
        ///     *   Valid values when PerformanceLevel is set to PL0: 40 to 32,768
        ///     *   Valid values when PerformanceLevel is set to PL1: 20 to 32,768
        ///     *   Valid values when PerformanceLevel is set to PL2: 461 to 32,768
        ///     *   Valid values when PerformanceLevel is set to PL3: 1,261 to 32,768
        /// 
        /// If you specify the `SnapshotId` parameter, the following limits apply to the `SnapshotId` and `Size` parameters:
        /// 
        /// *   If the size of the snapshot that is specified by the `SnapshotId` parameter is greater than the value of the `Size` parameter, the disk is created based on the size of the specified snapshot.
        /// *   If the size of the snapshot that is specified by the `SnapshotId` parameter is less than the value of the `Size` parameter, the disk is created based on the value of the `Size` parameter.
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        /// <summary>
        /// The ID of the snapshot that you want to use to create the disk. You cannot use snapshots that are created on or before July 15, 2013 to create disks.
        /// 
        /// The following limits apply to the `SnapshotId` and `Size` parameters:
        /// 
        /// *   If the size of the snapshot that is specified by the `SnapshotId` parameter is greater than the value of the `Size` parameter, the disk is created based on the size of the specified snapshot.
        /// *   If the size of the snapshot that is specified by the `SnapshotId` parameter is less than the value of the `Size` parameter, the disk is created based on the value of the `Size` parameter.
        /// </summary>
        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

        /// <summary>
        /// The ID of the dedicated block storage cluster. If you want to create a disk in a specific dedicated block storage cluster, specify this parameter. For more information about dedicated block storage clusters, see [What is Dedicated Block Storage Cluster?](~~208883~~)
        /// 
        /// > Storage set-related parameters include `StorageSetId` as well as `StorageSetPartitionNumber`, and the dedicated block storage cluster-related parameter is `StorageClusterId`. You cannot specify a storage set-related parameter and a dedicated block storage cluster-related parameter at the same time.
        /// </summary>
        [NameInMap("StorageClusterId")]
        [Validation(Required=false)]
        public string StorageClusterId { get; set; }

        /// <summary>
        /// The storage set ID.
        /// 
        /// > Storage set-related parameters include `StorageSetId` as well as `StorageSetPartitionNumber`, and the dedicated block storage cluster-related parameter is `StorageClusterId`. You cannot specify a storage set-related parameter and a dedicated block storage cluster-related parameter at the same time.
        /// </summary>
        [NameInMap("StorageSetId")]
        [Validation(Required=false)]
        public string StorageSetId { get; set; }

        /// <summary>
        /// The number of partitions in the storage set. The value must be greater than or equal to 2 but cannot exceed the quota that you obtained by calling the [DescribeAccountAttributes](~~73772~~) operation.
        /// 
        /// Default value: 2.
        /// </summary>
        [NameInMap("StorageSetPartitionNumber")]
        [Validation(Required=false)]
        public int? StorageSetPartitionNumber { get; set; }

        /// <summary>
        /// The tags that you want to add to the disk.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateDiskRequestTag> Tag { get; set; }
        public class CreateDiskRequestTag : TeaModel {
            /// <summary>
            /// The key of tag N that you want to add to the disk. Valid values of N: 1 to 20. The tag key cannot be an empty string. It can be up to 128 characters in length and cannot contain `http://` or `https://`. The tag key cannot start with `acs:` or `aliyun`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N that you want to add to the disk. Valid values of N: 1 to 20. The tag value can be an empty string. It can be up to 128 characters in length and cannot start with `acs:`. The tag value cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The disk zone ID.
        /// 
        /// *   If you do not specify the InstanceId parameter, you must specify the ZoneId parameter.
        /// *   You cannot specify the ZoneId and InstanceId parameters at the same time.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
