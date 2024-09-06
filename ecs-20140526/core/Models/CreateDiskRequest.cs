// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateDiskRequest : TeaModel {
        /// <summary>
        /// This parameter is not publicly available.
        /// </summary>
        [NameInMap("AdvancedFeatures")]
        [Validation(Required=false)]
        public string AdvancedFeatures { get; set; }

        /// <summary>
        /// This parameter is not publicly available.
        /// </summary>
        [NameInMap("Arn")]
        [Validation(Required=false)]
        public List<CreateDiskRequestArn> Arn { get; set; }
        public class CreateDiskRequestArn : TeaModel {
            /// <summary>
            /// This parameter is not publicly available.
            /// </summary>
            [NameInMap("AssumeRoleFor")]
            [Validation(Required=false)]
            public long? AssumeRoleFor { get; set; }

            /// <summary>
            /// This parameter is not publicly available.
            /// </summary>
            [NameInMap("RoleType")]
            [Validation(Required=false)]
            public string RoleType { get; set; }

            /// <summary>
            /// This parameter is not publicly available.
            /// </summary>
            [NameInMap("Rolearn")]
            [Validation(Required=false)]
            public string Rolearn { get; set; }

        }

        /// <summary>
        /// Specifies whether to enable the performance burst feature. Valid values:
        /// 
        /// *   true
        /// *   false
        /// 
        /// >  This parameter is available only when DiskCategory is set to cloud_auto. For more information, see [ESSD AutoPL disks](https://help.aliyun.com/document_detail/368372.html).
        /// </summary>
        [NameInMap("BurstingEnabled")]
        [Validation(Required=false)]
        public bool? BurstingEnabled { get; set; }

        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The **token** can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see [How to ensure idempotence](https://help.aliyun.com/document_detail/25693.html).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// The description of the disk. The description must be 2 to 256 characters in length and cannot start with `http://` or `https://`.
        /// 
        /// This parameter is left empty by default.
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
        /// *   cloud_auto: ESSD AutoPL disk
        /// *   cloud_essd_entry: ESSD Entry disk
        /// *   elastic_ephemeral_disk_standard: standard elastic ephemeral disk
        /// *   elastic_ephemeral_disk_premium: premium elastic ephemeral disk
        /// 
        /// Default value: cloud.
        /// </summary>
        [NameInMap("DiskCategory")]
        [Validation(Required=false)]
        public string DiskCategory { get; set; }

        /// <summary>
        /// The name of the disk. The name must be 2 to 128 characters in length and can contain letters and digits. The name can contain colons (:), underscores (_), periods (.), and hyphens (-).
        /// 
        /// This parameter is left empty by default.
        /// </summary>
        [NameInMap("DiskName")]
        [Validation(Required=false)]
        public string DiskName { get; set; }

        /// <summary>
        /// This parameter is not publicly available.
        /// </summary>
        [NameInMap("EncryptAlgorithm")]
        [Validation(Required=false)]
        public string EncryptAlgorithm { get; set; }

        /// <summary>
        /// Specifies whether to encrypt the disk. Valid values:
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
        /// The ID of the subscription instance to which to attach the subscription disk.
        /// 
        /// *   If you specify an instance ID, the following parameters are ignored: ResourceGroupId, Tag.N.Key, Tag.N.Value, ClientToken, and KMSKeyId.
        /// *   You cannot specify both ZoneId and InstanceId in a request.
        /// 
        /// This parameter is empty by default, which indicates that a pay-as-you-go disk is created in the region and zone specified by RegionId and ZoneId.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The ID of the Key Management Service (KMS) key that is used for the disk.
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
        /// >  Disks for which the multi-attach feature is enabled support only the pay-as-you-go billing method. When `MultiAttach` is set to Enabled, you cannot specify `InstanceId`. You can call the [AttachDisk](https://help.aliyun.com/document_detail/25515.html) operation to attach disks to instances after the disks are created. Disks for which the multi-attach feature is enabled can be attached only as data disks.
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
        /// The performance level of the disk if the disk is an ESSD. Valid values:
        /// 
        /// *   PL0: A single ESSD can deliver up to 10,000 random read/write IOPS.
        /// *   PL1: A single ESSD can deliver up to 50,000 random read/write IOPS.
        /// *   PL2: A single ESSD can deliver up to 100,000 random read/write IOPS.
        /// *   PL3: A single ESSD can deliver up to 1,000,000 random read/write IOPS.
        /// 
        /// Default value: PL1.
        /// 
        /// For information about ESSD performance levels, see [ESSDs](https://help.aliyun.com/document_detail/122389.html).
        /// </summary>
        [NameInMap("PerformanceLevel")]
        [Validation(Required=false)]
        public string PerformanceLevel { get; set; }

        /// <summary>
        /// The provisioned read/write IOPS of the ESSD AutoPL disk. Valid values: 0 to min{50,000, 1,000 × Capacity - Baseline IOPS}.
        /// 
        /// Baseline IOPS = min{1,800 + 50 × Capacity, 50,000}.
        /// 
        /// >  This parameter is available only when DiskCategory is set to cloud_auto. For more information, see [ESSD AutoPL disks](https://help.aliyun.com/document_detail/368372.html).
        /// </summary>
        [NameInMap("ProvisionedIops")]
        [Validation(Required=false)]
        public long? ProvisionedIops { get; set; }

        /// <summary>
        /// The ID of the region in which to create the disk. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/25609.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group to which to add the disk.
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
        /// *   Valid values when DiskCategory is set to cloud: 5 to 2000.
        /// 
        /// *   Valid values when DiskCategory is set to cloud_efficiency: 20 to 32768.
        /// 
        /// *   Valid values when DiskCategory is set to cloud_ssd: 20 to 32768.
        /// 
        /// *   Valid values when DiskCategory is set to cloud_essd: vary based on the `PerformanceLevel` value.
        /// 
        ///     *   Valid values when PerformanceLevel is set to PL0: 1 to 65536.
        ///     *   Valid values when PerformanceLevel is set to PL1: 20 to 65536.
        ///     *   Valid values when PerformanceLevel is set to PL2: 461 to 65536.
        ///     *   Valid values when PerformanceLevel is set to PL3: 1261 to 65536.
        /// 
        /// *   Valid values when DiskCategory is set to cloud_auto: 1 to 65536.
        /// 
        /// *   Valid values when DiskCategory is set to cloud_essd_entry: 10 to 32768.
        /// 
        /// *   Valid values when DiskCategory is set to elastic_ephemeral_disk_standard: 64 to 8192.
        /// 
        /// *   Valid values when DiskCategory is set to elastic_ephemeral_disk_premium: 64 to 8192.
        /// 
        /// If `SnapshotId` is specified, the following limits apply to `SnapshotId` and `Size`:
        /// 
        /// *   If the size of the snapshot specified by `SnapshotId` is larger than the value of `Size`, the size of the created disk is equal to the size of the snapshot.
        /// *   If the size of the snapshot specified by `SnapshotId` is smaller than the value of `Size`, the size of the created disk is equal to the value of `Size`.
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

        /// <summary>
        /// The ID of the snapshot to use to create the disk. Snapshots that were created on or before July 15, 2013 cannot be used to create disks.
        /// 
        /// The following limits apply to `SnapshotId` and `Size`:
        /// 
        /// *   If the size of the snapshot specified by `SnapshotId` is larger than the value of `Size`, the size of the created disk is equal to the specified snapshot size.
        /// *   If the size of the snapshot specified by `SnapshotId` is smaller than the value of `Size`, the size of the created disk is equal to the value of `Size`.
        /// *   You cannot create elastic ephemeral disks from snapshots.
        /// </summary>
        [NameInMap("SnapshotId")]
        [Validation(Required=false)]
        public string SnapshotId { get; set; }

        /// <summary>
        /// The ID of the dedicated block storage cluster in which to create the disk. To create a disk in a specific dedicated block storage cluster, you must specify this parameter.
        /// 
        /// >  You can specify the storage set-related parameters (`StorageSetId` and `StorageSetPartitionNumber`) or the dedicated block storage cluster-related parameter (`StorageClusterId`), but not both. If you specify a storage set-related parameter and a dedicated block storage cluster-related parameter in a request, the request fails.
        /// </summary>
        [NameInMap("StorageClusterId")]
        [Validation(Required=false)]
        public string StorageClusterId { get; set; }

        /// <summary>
        /// The ID of the storage set.
        /// 
        /// > You cannot specify storage set-related parameters (`StorageSetId` and `StorageSetPartitionNumber`) and the dedicated block storage cluster-related parameter (`StorageClusterId`) at the same time. Otherwise, the operation cannot be called.
        /// </summary>
        [NameInMap("StorageSetId")]
        [Validation(Required=false)]
        public string StorageSetId { get; set; }

        /// <summary>
        /// The number of partitions in the storage set. The value must be greater than or equal to 2 but cannot exceed the quota obtained by calling the [DescribeAccountAttributes](https://help.aliyun.com/document_detail/73772.html)operation.
        /// 
        /// Default value: 2.
        /// </summary>
        [NameInMap("StorageSetPartitionNumber")]
        [Validation(Required=false)]
        public int? StorageSetPartitionNumber { get; set; }

        /// <summary>
        /// The tags to add to the disk.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateDiskRequestTag> Tag { get; set; }
        public class CreateDiskRequestTag : TeaModel {
            /// <summary>
            /// The key of tag N to add to the disk. Valid values of N: 1 to 20. The tag key cannot be an empty string. The tag key can be up to 128 characters in length and cannot contain `http://` or `https://`. The tag key cannot start with `acs:` or `aliyun`.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value of tag N to add to the disk. Valid values of N: 1 to 20. The tag value can be an empty string. The tag value can be up to 128 characters in length and cannot contain `http://` or `https://`.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The ID of the zone in which to create the pay-as-you-go disk.
        /// 
        /// *   If you do not specify InstanceId, you must specify ZoneId.
        /// *   You cannot specify both ZoneId and InstanceId in a request.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
