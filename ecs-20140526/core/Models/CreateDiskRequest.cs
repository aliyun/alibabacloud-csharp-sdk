// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateDiskRequest : TeaModel {
        /// <summary>
        /// This parameter is unavailable.
        /// </summary>
        [NameInMap("AdvancedFeatures")]
        [Validation(Required=false)]
        public string AdvancedFeatures { get; set; }

        /// <summary>
        /// 该参数暂未开放使用。
        /// </summary>
        [NameInMap("Arn")]
        [Validation(Required=false)]
        public List<CreateDiskRequestArn> Arn { get; set; }
        public class CreateDiskRequestArn : TeaModel {
            /// <summary>
            /// This parameter is unavailable.
            /// </summary>
            [NameInMap("AssumeRoleFor")]
            [Validation(Required=false)]
            public long? AssumeRoleFor { get; set; }

            /// <summary>
            /// This parameter is unavailable.
            /// </summary>
            [NameInMap("RoleType")]
            [Validation(Required=false)]
            public string RoleType { get; set; }

            /// <summary>
            /// This parameter is unavailable.
            /// </summary>
            [NameInMap("Rolearn")]
            [Validation(Required=false)]
            public string Rolearn { get; set; }

        }

        /// <summary>
        /// This parameter is unavailable.
        /// </summary>
        [NameInMap("BurstingEnabled")]
        [Validation(Required=false)]
        public bool? BurstingEnabled { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must make sure that the value is unique among different requests. The **ClientToken** value can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see [How to ensure idempotence](~~25693~~).
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
        /// The category of the data disk. Valid values:
        /// 
        /// *   cloud: basic disk
        /// *   cloud_efficiency: ultra disk
        /// *   cloud_ssd: standard SSD
        /// *   cloud_essd: ESSD
        /// 
        /// Default value: cloud.
        /// </summary>
        [NameInMap("DiskCategory")]
        [Validation(Required=false)]
        public string DiskCategory { get; set; }

        /// <summary>
        /// The name of the disk. The name must be 2 to 128 characters in length. The name must start with a letter but cannot start with `http://` or `https://`. It can contain letters, digits, colons (:), underscores (\_), and hyphens (-).
        /// 
        /// This parameter is empty by default.
        /// </summary>
        [NameInMap("DiskName")]
        [Validation(Required=false)]
        public string DiskName { get; set; }

        /// <summary>
        /// This parameter is unavailable.
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
        /// Default value: false.
        /// </summary>
        [NameInMap("Encrypted")]
        [Validation(Required=false)]
        public bool? Encrypted { get; set; }

        /// <summary>
        /// The ID of the instance to which the created subscription disk is automatically attached.
        /// 
        /// *   After you specify the instance ID, the specified ResourceGroupId, Tag.N.Key, Tag.N.Value, ClientToken, and KMSKeyId parameters are ignored.
        /// *   You cannot specify ZoneId and InstanceId at the same time.
        /// 
        /// This parameter is empty by default. This indicates that a pay-as-you-go disk is created. The RegionId and ZoneId parameters specify where the disk resides.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The ID of the Key Management Service (KMS) key used by the disk.
        /// </summary>
        [NameInMap("KMSKeyId")]
        [Validation(Required=false)]
        public string KMSKeyId { get; set; }

        /// <summary>
        /// Specifies whether to enable the multi-attach feature for the disk. Valid values:
        /// 
        /// *   Disabled: disables the multi-attach feature.
        /// *   Enabled: enables the multi-attach feature. Set the value to `Enabled` only for ESSDs.
        /// 
        /// Default value: Disabled.
        /// 
        /// >  Disks for which the multi-attach feature is enabled support only the pay-as-you-go billing method. When the `MultiAttach` parameter is set to Enabled, you cannot specify the `InstanceId` parameter. You can call the [AttachDisk](~~25515~~) operation to attach disks to instances after the disks are created. Disks for which the multi-attach feature is enabled can be attached only as data disks.
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
        /// The performance level of the ESSD. Valid values:
        /// 
        /// *   PL0: A single ESSD can deliver up to 10,000 random read/write IOPS.
        /// *   PL1: An ESSD can deliver up to 50,000 random read/write IOPS.
        /// *   PL2: A single ESSD can deliver up to 100,000 random read/write IOPS.
        /// *   PL3: A single ESSD can deliver up to 1,000,000 random read/write IOPS.
        /// 
        /// Default value: PL1.
        /// 
        /// For more information about ESSD performance levels, see [ESSDs](~~122389~~).
        /// </summary>
        [NameInMap("PerformanceLevel")]
        [Validation(Required=false)]
        public string PerformanceLevel { get; set; }

        /// <summary>
        /// This parameter is unavailable.
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
        /// The ID of the resource group to which to assign the disk.
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
        /// The size of the disk. Unit: GiB. This parameter is required. Valid values:
        /// 
        /// *   Valid values when DiskCategory is set to cloud: 5 to 2,000
        /// 
        /// *   Valid values when DiskCategory is set to cloud_efficiency: 20 to 32,768
        /// 
        /// *   Valid values when DiskCategory is set to cloud_ssd: 20 to 32,768
        /// 
        /// *   Valid values when DiskCategory is set to cloud_essd: depends on the `PerformanceLevel` value.
        /// 
        ///     *   Valid values when PerformanceLevel is set to PL0: 40 to 32,768
        ///     *   Valid values when PerformanceLevel is set to PL1: 20 to 32,768
        ///     *   Valid values when PerformanceLevel is set to PL2: 461 to 32,768
        ///     *   Valid values when PerformanceLevel is set to PL3: 1,261 to 32,768
        /// 
        /// If the `SnapshotId` parameter is specified, the following limits apply to the `SnapshotId` and `Size` parameters:
        /// 
        /// *   If the size of the snapshot specified by the `SnapshotId` parameter is greater than the specified `Size` value, the size of the created disk is equal to the specified snapshot size.
        /// *   If the size of the snapshot specified by the `SnapshotId` parameter is smaller than the specified `Size` value, the size of the created disk is equal to the specified `Size` value.
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        /// <summary>
        /// The ID of the snapshot used to create the disk. Snapshots that were created on or before July 15, 2013 cannot be used to create disks.
        /// 
        /// The following limits apply to the `SnapshotId` and `Size` parameters:
        /// 
        /// *   If the size of the snapshot specified by the `SnapshotId` parameter is greater than the specified `Size` value, the size of the created disk is equal to the specified snapshot size.
        /// *   If the size of the snapshot specified by the `SnapshotId` parameter is smaller than the specified `Size` value, the size of the created disk is equal to the specified `Size` value.
        /// </summary>
        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

        /// <summary>
        /// The ID of the dedicated block storage cluster. To create a disk in a specific dedicated block storage cluster, specify this parameter. For more information about dedicated block storage clusters, see [What is Dedicated Block Storage Cluster?](~~208883~~)
        /// 
        /// >  You can specify only one of the storage set-related parameters (`StorageSetId` and `StorageSetPartitionNumber`) and dedicated block storage cluster-related parameter (`StorageClusterId`). If you specify more than one of the preceding parameters, the call fails.
        /// </summary>
        [NameInMap("StorageClusterId")]
        [Validation(Required=false)]
        public string StorageClusterId { get; set; }

        /// <summary>
        /// The ID of the storage set.
        /// 
        /// >  You can specify only one of the storage set-related parameters (`StorageSetId` and `StorageSetPartitionNumber`) and dedicated block storage cluster-related parameter (`StorageClusterId`). If you specify more than one of the preceding parameters, the call fails.
        /// </summary>
        [NameInMap("StorageSetId")]
        [Validation(Required=false)]
        public string StorageSetId { get; set; }

        /// <summary>
        /// The number of partitions in the storage set. The value must be greater than or equal to 2, but cannot exceed the quota obtained by calling the [DescribeAccountAttributes](~~73772~~) operation.
        /// 
        /// Default value: 2.
        /// </summary>
        [NameInMap("StorageSetPartitionNumber")]
        [Validation(Required=false)]
        public int? StorageSetPartitionNumber { get; set; }

        /// <summary>
        /// 云盘的标签信息列表。
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateDiskRequestTag> Tag { get; set; }
        public class CreateDiskRequestTag : TeaModel {
            /// <summary>
            /// The key of tag N of the disk. Valid values of N: 1 to 20. The key cannot be an empty string. It can be up to 128 characters in length and cannot start with `acs:` or `aliyun`. It cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N of the disk. Valid values of N: 1 to 20. The value can be an empty string. It can be up to 128 characters in length. It cannot start with `acs:` or contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The ID of the zone in which to create the pay-as-you-go disk.
        /// 
        /// *   If the InstanceId parameter is not specified, the ZoneId parameter is required.
        /// *   You cannot specify ZoneId and InstanceId at the same time.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
