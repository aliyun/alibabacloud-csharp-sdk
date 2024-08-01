// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeDisksResponseBody : TeaModel {
        /// <summary>
        /// The details about the disks.
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
                /// The time when the disk was last attached. The time follows the ISO 8601 standard in the yyyy-MM-ddThh:mmZ format. The time is displayed in UTC.
                /// </summary>
                [NameInMap("AttachedTime")]
                [Validation(Required=false)]
                public string AttachedTime { get; set; }

                /// <summary>
                /// The attachment information of the disk. The value is an array that consists of the `Attachment` values. This value is not returned when you query Shared Block Storage devices.
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
                        /// The time when the disk was attached. The time is displayed in UTC.
                        /// </summary>
                        [NameInMap("AttachedTime")]
                        [Validation(Required=false)]
                        public string AttachedTime { get; set; }

                        /// <summary>
                        /// The device name of the disk.
                        /// </summary>
                        [NameInMap("Device")]
                        [Validation(Required=false)]
                        public string Device { get; set; }

                        /// <summary>
                        /// The ID of the instance to which the disk is attached.
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
                /// This parameter is in invitational preview and is not publicly available.
                /// </summary>
                [NameInMap("BdfId")]
                [Validation(Required=false)]
                public string BdfId { get; set; }

                /// <summary>
                /// Indicates whether the performance burst feature is enabled. Valid values:
                /// 
                /// *   true
                /// *   false
                /// 
                /// This parameter is available only if you set `Category` to `cloud_auto`. For more information, see [ESSD AutoPL disks](https://help.aliyun.com/document_detail/368372.html).
                /// </summary>
                [NameInMap("BurstingEnabled")]
                [Validation(Required=false)]
                public bool? BurstingEnabled { get; set; }

                /// <summary>
                /// The category of the disk. Valid values:
                /// 
                /// *   cloud: basic disk
                /// *   cloud_efficiency: ultra disk
                /// *   cloud_ssd: standard SSD
                /// *   cloud_essd: ESSD
                /// *   cloud_auto: ESSD AutoPL disk
                /// *   local_ssd_pro: I/O-intensive local disk
                /// *   local_hdd_pro: throughput-intensive local disk
                /// *   cloud_essd_entry: ESSD Entry disk
                /// *   elastic_ephemeral_disk_standard: standard elastic ephemeral disk
                /// *   elastic_ephemeral_disk_premium: premium static ephemeral disk
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
                /// Indicates whether the automatic snapshots of the cloud disk are deleted when the cloud disk is released. Valid values:
                /// 
                /// *   true: The automatic snapshots of the cloud disk are deleted when the disk is released.
                /// *   false: The automatic snapshots of the cloud disk are retained when the disk is released.
                /// 
                /// Snapshots that were created in the ECS console or by calling the [CreateSnapshot](https://help.aliyun.com/document_detail/25524.html) operation are retained and not affected by this parameter.
                /// </summary>
                [NameInMap("DeleteAutoSnapshot")]
                [Validation(Required=false)]
                public bool? DeleteAutoSnapshot { get; set; }

                /// <summary>
                /// Indicates whether the disk is released when the instance to which the disk is attached is released. Valid values:
                /// 
                /// *   true: The disk is released when the associated instance is released.
                /// *   false: The disk is retained when the associated instance is released.
                /// </summary>
                [NameInMap("DeleteWithInstance")]
                [Validation(Required=false)]
                public bool? DeleteWithInstance { get; set; }

                /// <summary>
                /// The description of the disk.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The time when the disk was last detached.
                /// </summary>
                [NameInMap("DetachedTime")]
                [Validation(Required=false)]
                public string DetachedTime { get; set; }

                /// <summary>
                /// The device name of the disk on the instance to which the disk is attached. Example: /dev/xvdb. Take note of the following items:
                /// 
                /// *   This parameter has a value only when the `Status` value is `In_use` or `Detaching`.
                /// *   This parameter is empty for cloud disks for which the multi-attach feature is enabled. You can query the attachment information of the cloud disk based on the returned list of `Attachment` objects.
                /// 
                /// >  This parameter will be removed in the future. We recommend that you use other parameters to ensure future compatibility.
                /// </summary>
                [NameInMap("Device")]
                [Validation(Required=false)]
                public string Device { get; set; }

                /// <summary>
                /// The billing method of the disk. Valid values:
                /// 
                /// *   PrePaid: subscription
                /// *   PostPaid: pay-as-you-go
                /// </summary>
                [NameInMap("DiskChargeType")]
                [Validation(Required=false)]
                public string DiskChargeType { get; set; }

                /// <summary>
                /// The ID of the disk.
                /// </summary>
                [NameInMap("DiskId")]
                [Validation(Required=false)]
                public string DiskId { get; set; }

                /// <summary>
                /// The name of the disk.
                /// </summary>
                [NameInMap("DiskName")]
                [Validation(Required=false)]
                public string DiskName { get; set; }

                /// <summary>
                /// Indicates whether the automatic snapshot policy feature is enabled for the disk.
                /// </summary>
                [NameInMap("EnableAutoSnapshot")]
                [Validation(Required=false)]
                public bool? EnableAutoSnapshot { get; set; }

                /// <summary>
                /// Indicates whether an automatic snapshot policy is applied to the cloud disk.
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
                /// The time when the subscription disk expires.
                /// </summary>
                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                /// <summary>
                /// The maximum number of read and write operations per second.
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
                /// The ID of the image that was used to create the instance. This parameter is empty unless the cloud disk was created from an image. The value of this parameter remains unchanged throughout the lifecycle of the cloud disk.
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// The ID of the instance to which the disk is attached. Take note of the following items:
                /// 
                /// *   This parameter has a value only when the `Status` value is `In_use` or `Detaching`.
                /// *   This parameter is empty for cloud disks for which the multi-attach feature is enabled. You can query the attachment information of the cloud disk based on the returned `Attachment` objects.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The ID of the KMS key that is used for the cloud disk.
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
                        /// The time when the disk was attached. The time follows the [ISO 8601](https://help.aliyun.com/document_detail/25696.html) standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.
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
                        /// The ID of the instance to which the disk is attached.
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
                /// The reasons why the disk was locked.
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
                        /// The reason why the disk was locked.
                        /// </summary>
                        [NameInMap("LockReason")]
                        [Validation(Required=false)]
                        public string LockReason { get; set; }

                    }

                }

                /// <summary>
                /// The performance level of the ESSD. Valid values:
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
                /// The locations in which data is stored.
                /// </summary>
                [NameInMap("Placement")]
                [Validation(Required=false)]
                public DescribeDisksResponseBodyDisksDiskPlacement Placement { get; set; }
                public class DescribeDisksResponseBodyDisksDiskPlacement : TeaModel {
                    /// <summary>
                    /// The IDs of the zones in which data is stored.
                    /// </summary>
                    [NameInMap("ZoneIds")]
                    [Validation(Required=false)]
                    public string ZoneIds { get; set; }

                }

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
                /// The provisioned read/write IOPS of the ESSD AutoPL disk. Valid values: 0 to min{50,000, 1,000 × *Capacity - Baseline IOPS}. Baseline IOPS = min{1,800 + 50 × *Capacity, 50,000}
                /// 
                /// This parameter is available only if you set `Category` to `cloud_auto`. For more information, see [ESSD AutoPL disks](https://help.aliyun.com/document_detail/368372.html).
                /// </summary>
                [NameInMap("ProvisionedIops")]
                [Validation(Required=false)]
                public long? ProvisionedIops { get; set; }

                /// <summary>
                /// The ID of the region to which the disk belongs.
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
                /// The serial number of the disk.
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
                /// The status of the disk. Valid values:
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
                        /// The tag key of the disk.
                        /// </summary>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// The tag value of the disk.
                        /// </summary>
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

                /// <summary>
                /// The amount of data that can be transferred per second. Unit: MB/s.
                /// </summary>
                [NameInMap("Throughput")]
                [Validation(Required=false)]
                public int? Throughput { get; set; }

                /// <summary>
                /// The amount of data that can be read per second. Unit: MB/s.
                /// </summary>
                [NameInMap("ThroughputRead")]
                [Validation(Required=false)]
                public int? ThroughputRead { get; set; }

                /// <summary>
                /// The amount of data that can be written per second. Unit: MB/s.
                /// </summary>
                [NameInMap("ThroughputWrite")]
                [Validation(Required=false)]
                public int? ThroughputWrite { get; set; }

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
                /// The ID of the zone to which the disk belongs.
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
        /// The page number.
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
