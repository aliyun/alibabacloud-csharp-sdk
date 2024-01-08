// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeDedicatedBlockStorageClusterDisksResponseBody : TeaModel {
        /// <summary>
        /// Details about the cloud disks.
        /// </summary>
        [NameInMap("Disks")]
        [Validation(Required=false)]
        public DescribeDedicatedBlockStorageClusterDisksResponseBodyDisks Disks { get; set; }
        public class DescribeDedicatedBlockStorageClusterDisksResponseBodyDisks : TeaModel {
            /// <summary>
            /// Details about the cloud disks.
            /// </summary>
            [NameInMap("Disk")]
            [Validation(Required=false)]
            public List<DescribeDedicatedBlockStorageClusterDisksResponseBodyDisksDisk> Disk { get; set; }
            public class DescribeDedicatedBlockStorageClusterDisksResponseBodyDisksDisk : TeaModel {
                /// <summary>
                /// The time when the cloud disk was last attached. The time follows the ISO 8601 standard in the yyyy-MM-ddThh:mmZ format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("AttachedTime")]
                [Validation(Required=false)]
                public string AttachedTime { get; set; }

                /// <summary>
                /// This parameter is currently in invitational preview and unavailable for general users.
                /// </summary>
                [NameInMap("BdfId")]
                [Validation(Required=false)]
                public string BdfId { get; set; }

                /// <summary>
                /// Whether the ESSD AutoPL disk is enabled burst IOPS / BPS. This parameter is available only if the DiskCategory parameter is set to cloud_auto. For more information, see [ESSD AutoPL disks](~~368372~~).
                /// </summary>
                [NameInMap("BurstingEnabled")]
                [Validation(Required=false)]
                public bool? BurstingEnabled { get; set; }

                /// <summary>
                /// The category of the disk. A value of cloud_essd indicates that the disk is an ESSD.
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// Indicates whether the automatic snapshots of the cloud disk are deleted when the disk is released. Valid values:
                /// 
                /// *   true: The automatic snapshots of the cloud disk are deleted when the disk is released.
                /// *   false: The automatic snapshots of the cloud disk are retained when the disk is released.
                /// 
                /// Snapshots that are created by calling the [CreateSnapshot](~~25524~~) operation or by using the Elastic Compute Service (ECS) console are retained and not affected by this parameter.
                /// </summary>
                [NameInMap("DeleteAutoSnapshot")]
                [Validation(Required=false)]
                public bool? DeleteAutoSnapshot { get; set; }

                /// <summary>
                /// Indicates whether the cloud disk is released when its associated instance is released. Valid values:
                /// 
                /// *   true: The cloud disk is released when its associated instance is released.
                /// *   false: The cloud disk is retained when its associated instance is released.
                /// </summary>
                [NameInMap("DeleteWithInstance")]
                [Validation(Required=false)]
                public bool? DeleteWithInstance { get; set; }

                /// <summary>
                /// The description of the cloud disk.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The time when the cloud disk was last detached.
                /// </summary>
                [NameInMap("DetachedTime")]
                [Validation(Required=false)]
                public string DetachedTime { get; set; }

                /// <summary>
                /// The device name of the cloud disk on its associated instance. Example: /dev/xvdb. Take note of the following items:
                /// 
                /// *   This parameter has a value only when the `Status` value is `In_use`.
                /// *   This parameter is empty for cloud disks that have the multi-attach feature enabled. You can query the attachment information of the cloud disk based on the `Attachment` values.
                /// 
                /// >  This parameter will be removed in the future. We recommend that you use other parameters to ensure future compatibility.
                /// </summary>
                [NameInMap("Device")]
                [Validation(Required=false)]
                public string Device { get; set; }

                /// <summary>
                /// The billing method of the cloud disk. Valid values:
                /// 
                /// *   PrePaid: subscription
                /// *   PostPaid: pay-as-you-go
                /// </summary>
                [NameInMap("DiskChargeType")]
                [Validation(Required=false)]
                public string DiskChargeType { get; set; }

                /// <summary>
                /// The ID of the cloud disk.
                /// </summary>
                [NameInMap("DiskId")]
                [Validation(Required=false)]
                public string DiskId { get; set; }

                /// <summary>
                /// The name of the cloud disk.
                /// </summary>
                [NameInMap("DiskName")]
                [Validation(Required=false)]
                public string DiskName { get; set; }

                /// <summary>
                /// Indicates whether the automatic snapshot policy feature is enabled for the cloud disk.
                /// </summary>
                [NameInMap("EnableAutoSnapshot")]
                [Validation(Required=false)]
                public bool? EnableAutoSnapshot { get; set; }

                /// <summary>
                /// Indicates whether the cloud disk is encrypted.
                /// </summary>
                [NameInMap("Encrypted")]
                [Validation(Required=false)]
                public bool? Encrypted { get; set; }

                /// <summary>
                /// The maximum number of IOPS.
                /// </summary>
                [NameInMap("IOPS")]
                [Validation(Required=false)]
                public long? IOPS { get; set; }

                /// <summary>
                /// The ID of the image that was used to create the instance. This parameter is empty unless the cloud disk was created from an image. The value of this parameter remains unchanged throughout the lifecycle of the cloud disk.
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// The ID of the instance to which the cloud disk is attached. Take note of the following items:
                /// 
                /// *   This parameter has a value only when the `Status` value is `In_use`.
                /// *   This parameter is empty for cloud disks that have the multi-attach feature enabled. You can query the attachment information of the cloud disk based on the `Attachment` values.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The ID of the Key Management Service (KMS) key used by the cloud disk.
                /// </summary>
                [NameInMap("KMSKeyId")]
                [Validation(Required=false)]
                public string KMSKeyId { get; set; }

                /// <summary>
                /// The number of instances to which the Shared Block Storage device is attached.
                /// </summary>
                [NameInMap("MountInstanceNum")]
                [Validation(Required=false)]
                public int? MountInstanceNum { get; set; }

                /// <summary>
                /// Indicates whether the multi-attach feature was enabled for the cloud disk.
                /// </summary>
                [NameInMap("MultiAttach")]
                [Validation(Required=false)]
                public string MultiAttach { get; set; }

                /// <summary>
                /// The performance level of the enhanced SSD (ESSD). Valid values:
                /// 
                /// *   PL0: A single ESSD can deliver up to 10,000 random read/write IOPS.
                /// *   PL1: A single ESSD can deliver up to 50,000 random read/write IOPS.
                /// *   PL2: A single ESSD can deliver up to 100,000 random read/write IOPS.
                /// *   PL3: A single ESSD can deliver up to 1,000,000 random read/write IOPS.
                /// </summary>
                [NameInMap("PerformanceLevel")]
                [Validation(Required=false)]
                public string PerformanceLevel { get; set; }

                /// <summary>
                /// Indicates whether the cloud disk is removable.
                /// </summary>
                [NameInMap("Portable")]
                [Validation(Required=false)]
                public bool? Portable { get; set; }

                /// <summary>
                /// The provisioned read/write IOPS of the ESSD AutoPL disk. 
                /// >  This parameter is available only if the DiskCategory parameter is set to cloud_auto. For more information, see [ESSD AutoPL disks](~~368372~~) and [Modify the performance configurations of an ESSD AutoPL disk](~~413275~~).
                /// </summary>
                [NameInMap("ProvisionedIops")]
                [Validation(Required=false)]
                public long? ProvisionedIops { get; set; }

                /// <summary>
                /// The region ID of cloud disk.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The size of the disk. Unit: GiB.
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public int? Size { get; set; }

                /// <summary>
                /// The ID of the snapshot that was used to create the cloud disk.
                /// 
                /// This parameter is empty unless the cloud disk was created from a snapshot. The value of this parameter remains unchanged throughout the lifecycle of the cloud disk.
                /// </summary>
                [NameInMap("SourceSnapshotId")]
                [Validation(Required=false)]
                public string SourceSnapshotId { get; set; }

                /// <summary>
                /// The state of the cloud disk. For more information, see [Disk states](~~25689~~). Valid values:
                /// 
                /// *   In_use
                /// *   Available
                /// *   Attaching
                /// *   Detaching
                /// *   Creating
                /// *   ReIniting
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The ID of the dedicated block storage cluster to which the cloud disk belongs. If your cloud disk belongs to the public block storage cluster, an empty value is returned.
                /// </summary>
                [NameInMap("StorageClusterId")]
                [Validation(Required=false)]
                public string StorageClusterId { get; set; }

                /// <summary>
                /// The ID of the storage set.
                /// </summary>
                [NameInMap("StorageSetId")]
                [Validation(Required=false)]
                public string StorageSetId { get; set; }

                /// <summary>
                /// The maximum number of partitions in the storage set.
                /// </summary>
                [NameInMap("StorageSetPartitionNumber")]
                [Validation(Required=false)]
                public int? StorageSetPartitionNumber { get; set; }

                /// <summary>
                /// The tags of the cloud disk.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<DescribeDedicatedBlockStorageClusterDisksResponseBodyDisksDiskTags> Tags { get; set; }
                public class DescribeDedicatedBlockStorageClusterDisksResponseBodyDisksDiskTags : TeaModel {
                    /// <summary>
                    /// The tag key of the cloud disk.
                    /// </summary>
                    [NameInMap("TagKey")]
                    [Validation(Required=false)]
                    public string TagKey { get; set; }

                    /// <summary>
                    /// The tag value of the cloud disk.
                    /// </summary>
                    [NameInMap("TagValue")]
                    [Validation(Required=false)]
                    public string TagValue { get; set; }

                }

                /// <summary>
                /// The maximum number of BPS.
                /// </summary>
                [NameInMap("Throughput")]
                [Validation(Required=false)]
                public long? Throughput { get; set; }

                /// <summary>
                /// The type of the disk. Valid values:
                /// 
                /// *   system: system disk
                /// *   data: data disk
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The zone ID of cloud disk.
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// The query token returned in this call.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
