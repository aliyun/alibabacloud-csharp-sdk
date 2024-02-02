// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeDisksResponseBody : TeaModel {
        /// <summary>
        /// The details of the cloud disks or local disks.
        /// </summary>
        [NameInMap("Disks")]
        [Validation(Required=false)]
        public DescribeDisksResponseBodyDisks Disks { get; set; }
        public class DescribeDisksResponseBodyDisks : TeaModel {
            [NameInMap("Disk")]
            [Validation(Required=false)]
            public List<DescribeDisksResponseBodyDisksDisk> Disk { get; set; }
            public class DescribeDisksResponseBodyDisksDisk : TeaModel {
                /// <summary>
                /// The time when the cloud disk was last attached. The time follows the ISO 8601 standard in the yyyy-MM-ddThh:mmZ format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("AttachedTime")]
                [Validation(Required=false)]
                public string AttachedTime { get; set; }

                /// <summary>
                /// The attachment information of the cloud disk. The value is an array that consists of the `Attachment` values. However, this value is not returned when you query Shared Block Storage devices.
                /// </summary>
                [NameInMap("Attachments")]
                [Validation(Required=false)]
                public DescribeDisksResponseBodyDisksDiskAttachments Attachments { get; set; }
                public class DescribeDisksResponseBodyDisksDiskAttachments : TeaModel {
                    [NameInMap("Attachment")]
                    [Validation(Required=false)]
                    public List<DescribeDisksResponseBodyDisksDiskAttachmentsAttachment> Attachment { get; set; }
                    public class DescribeDisksResponseBodyDisksDiskAttachmentsAttachment : TeaModel {
                        /// <summary>
                        /// The time when the disk was attached, which is displayed in UTC.
                        /// </summary>
                        [NameInMap("AttachedTime")]
                        [Validation(Required=false)]
                        public string AttachedTime { get; set; }

                        /// <summary>
                        /// The device name.
                        /// </summary>
                        [NameInMap("Device")]
                        [Validation(Required=false)]
                        public string Device { get; set; }

                        /// <summary>
                        /// The ID of the instance to which the disk was attached.
                        /// </summary>
                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                    }

                }

                /// <summary>
                /// The ID of the automatic snapshot policy that is applied to the cloud disk.
                /// </summary>
                [NameInMap("AutoSnapshotPolicyId")]
                [Validation(Required=false)]
                public string AutoSnapshotPolicyId { get; set; }

                /// <summary>
                /// This parameter is currently only available to select users and unavailable for general users.
                /// </summary>
                [NameInMap("BdfId")]
                [Validation(Required=false)]
                public string BdfId { get; set; }

                /// <summary>
                /// This parameter is unavailable for public use.
                /// </summary>
                [NameInMap("BurstingEnabled")]
                [Validation(Required=false)]
                public bool? BurstingEnabled { get; set; }

                /// <summary>
                /// The disk category. Valid values:
                /// 
                /// *   cloud: basic disk
                /// *   cloud_efficiency: ultra disk
                /// *   cloud_ssd: standard SSD
                /// *   cloud_essd: ESSD
                /// *   local_ssd_pro: I/O-intensive local disk
                /// *   local_hdd_pro: throughput-intensive local disk
                /// *   ephemeral: retired local disk
                /// *   ephemeral_ssd: retired local SSD
                /// </summary>
                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                /// <summary>
                /// The time when the disk was created.
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// Indicates whether the automatic snapshots of the cloud disk are deleted after the disk is released. Valid values:
                /// 
                /// *   true
                /// *   false
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
                /// The disk description.
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
                /// The device name of the disk on its associated instance. Example: /dev/xvdb. Take note of the following items:
                /// 
                /// *   This parameter has a value only when the `Status` value is `In_use`.
                /// *   This parameter is empty for cloud disks that have the multi-attach feature enabled. You can query the attachment information of the cloud disk based on the `Attachment` values.
                /// 
                /// > This parameter will be removed in the future. To ensure future compatibility, we recommend that you do not use this parameter.
                /// </summary>
                [NameInMap("Device")]
                [Validation(Required=false)]
                public string Device { get; set; }

                /// <summary>
                /// The disk billing method. Valid values:
                /// 
                /// *   PrePaid: subscription
                /// *   PostPaid: pay-as-you-go
                /// </summary>
                [NameInMap("DiskChargeType")]
                [Validation(Required=false)]
                public string DiskChargeType { get; set; }

                /// <summary>
                /// The disk ID.
                /// </summary>
                [NameInMap("DiskId")]
                [Validation(Required=false)]
                public string DiskId { get; set; }

                /// <summary>
                /// The disk name.
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
                /// Indicates whether an automatic snapshot policy is configured for the cloud disk.
                /// </summary>
                [NameInMap("EnableAutomatedSnapshotPolicy")]
                [Validation(Required=false)]
                public bool? EnableAutomatedSnapshotPolicy { get; set; }

                /// <summary>
                /// Indicates whether the cloud disk is encrypted.
                /// </summary>
                [NameInMap("Encrypted")]
                [Validation(Required=false)]
                public bool? Encrypted { get; set; }

                /// <summary>
                /// The time when the subscription cloud disk expires.
                /// </summary>
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                /// <summary>
                /// The maximum number of IOPS.
                /// </summary>
                [NameInMap("IOPS")]
                [Validation(Required=false)]
                public int? IOPS { get; set; }

                /// <summary>
                /// The maximum number of read operations per second.
                /// </summary>
                [NameInMap("IOPSRead")]
                [Validation(Required=false)]
                public int? IOPSRead { get; set; }

                /// <summary>
                /// The maximum number of write operations per second.
                /// </summary>
                [NameInMap("IOPSWrite")]
                [Validation(Required=false)]
                public int? IOPSWrite { get; set; }

                /// <summary>
                /// The ID of the image that was used to create the instance. This parameter is empty unless the cloud disk is created from an image. The value of this parameter remains unchanged throughout the lifecycle of the cloud disk.
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// The ID of the instance to which the disk was attached. Take note of the following items:
                /// 
                /// *   This parameter has a value only when the `Status` value is `In_use`.
                /// *   This parameter is empty for cloud disks that have the multi-attach feature enabled. You can query the attachment information of the cloud disk based on the `Attachment` values.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The ID of the KMS key that is used by the cloud disk.
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
                /// The attachment information of the Shared Block Storage device.
                /// </summary>
                [NameInMap("MountInstances")]
                [Validation(Required=false)]
                public DescribeDisksResponseBodyDisksDiskMountInstances MountInstances { get; set; }
                public class DescribeDisksResponseBodyDisksDiskMountInstances : TeaModel {
                    [NameInMap("MountInstance")]
                    [Validation(Required=false)]
                    public List<DescribeDisksResponseBodyDisksDiskMountInstancesMountInstance> MountInstance { get; set; }
                    public class DescribeDisksResponseBodyDisksDiskMountInstancesMountInstance : TeaModel {
                        /// <summary>
                        /// The time when the cloud disk was attached. The time follows the [ISO 8601](~~25696~~) standard in the yyyy-MM-ddTHH:mm:ssZ format and is displayed in UTC.
                        /// </summary>
                        [NameInMap("AttachedTime")]
                        [Validation(Required=false)]
                        public string AttachedTime { get; set; }

                        /// <summary>
                        /// The mount point of the disk.
                        /// </summary>
                        [NameInMap("Device")]
                        [Validation(Required=false)]
                        public string Device { get; set; }

                        /// <summary>
                        /// The ID of the instance to which the disk was attached.
                        /// </summary>
                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                    }

                }

                /// <summary>
                /// Indicates whether the multi-attach feature is enabled for the cloud disk.
                /// </summary>
                [NameInMap("MultiAttach")]
                [Validation(Required=false)]
                public string MultiAttach { get; set; }

                /// <summary>
                /// The reasons why the disk is locked.
                /// </summary>
                [NameInMap("OperationLocks")]
                [Validation(Required=false)]
                public DescribeDisksResponseBodyDisksDiskOperationLocks OperationLocks { get; set; }
                public class DescribeDisksResponseBodyDisksDiskOperationLocks : TeaModel {
                    [NameInMap("OperationLock")]
                    [Validation(Required=false)]
                    public List<DescribeDisksResponseBodyDisksDiskOperationLocksOperationLock> OperationLock { get; set; }
                    public class DescribeDisksResponseBodyDisksDiskOperationLocksOperationLock : TeaModel {
                        /// <summary>
                        /// The security reason why the disk is locked.
                        /// </summary>
                        [NameInMap("LockReason")]
                        [Validation(Required=false)]
                        public string LockReason { get; set; }

                    }

                }

                /// <summary>
                /// The performance level of the enhanced SSD (ESSD). Valid values:
                /// 
                /// *   PL0: An ESSD can deliver up to 10,000 random read/write IOPS.
                /// *   PL1: An ESSD can deliver up to 50,000 random read/write IOPS.
                /// *   PL2: An ESSD can deliver up to 100,000 random read/write IOPS.
                /// *   PL3: An ESSD delivers up to 1,000,000 random read/write IOPS.
                /// </summary>
                [NameInMap("PerformanceLevel")]
                [Validation(Required=false)]
                public string PerformanceLevel { get; set; }

                /// <summary>
                /// Indicates whether the disk is removable.
                /// </summary>
                [NameInMap("Portable")]
                [Validation(Required=false)]
                public bool? Portable { get; set; }

                /// <summary>
                /// The product code of the disk in Alibaba Cloud Marketplace.
                /// </summary>
                [NameInMap("ProductCode")]
                [Validation(Required=false)]
                public string ProductCode { get; set; }

                /// <summary>
                /// This parameter is unavailable for public use.
                /// </summary>
                [NameInMap("ProvisionedIops")]
                [Validation(Required=false)]
                public long? ProvisionedIops { get; set; }

                /// <summary>
                /// The region ID of the disk.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The ID of the resource group to which the disk belongs.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The disk serial number.
                /// </summary>
                [NameInMap("SerialNumber")]
                [Validation(Required=false)]
                public string SerialNumber { get; set; }

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
                /// The state of the cloud disk. Valid values:
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
                /// The storage set ID.
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
                /// The tags of the disk.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeDisksResponseBodyDisksDiskTags Tags { get; set; }
                public class DescribeDisksResponseBodyDisksDiskTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeDisksResponseBodyDisksDiskTagsTag> Tag { get; set; }
                    public class DescribeDisksResponseBodyDisksDiskTagsTag : TeaModel {
                        /// <summary>
                        /// The tag key.
                        /// </summary>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// The tag value.
                        /// </summary>
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

                /// <summary>
                /// The amount of data transferred per second. Unit: MB/s.
                /// </summary>
                [NameInMap("Throughput")]
                [Validation(Required=false)]
                public int? Throughput { get; set; }

                [NameInMap("ThroughputRead")]
                [Validation(Required=false)]
                public int? ThroughputRead { get; set; }

                [NameInMap("ThroughputWrite")]
                [Validation(Required=false)]
                public int? ThroughputWrite { get; set; }

                /// <summary>
                /// The disk type. Valid values:
                /// 
                /// *   system: system disk
                /// *   data: data disk
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The ID of the zone to which the cloud disk or local disk belongs.
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// The returned pagination token which can be used in the next request to retrieve a new page of results.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The returned page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
