// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeDisksResponseBody : TeaModel {
        [NameInMap("Disks")]
        [Validation(Required=false)]
        public DescribeDisksResponseBodyDisks Disks { get; set; }
        public class DescribeDisksResponseBodyDisks : TeaModel {
            [NameInMap("Disk")]
            [Validation(Required=false)]
            public List<DescribeDisksResponseBodyDisksDisk> Disk { get; set; }
            public class DescribeDisksResponseBodyDisksDisk : TeaModel {
                [NameInMap("AttachedTime")]
                [Validation(Required=false)]
                public string AttachedTime { get; set; }

                [NameInMap("Attachments")]
                [Validation(Required=false)]
                public DescribeDisksResponseBodyDisksDiskAttachments Attachments { get; set; }
                public class DescribeDisksResponseBodyDisksDiskAttachments : TeaModel {
                    [NameInMap("Attachment")]
                    [Validation(Required=false)]
                    public List<DescribeDisksResponseBodyDisksDiskAttachmentsAttachment> Attachment { get; set; }
                    public class DescribeDisksResponseBodyDisksDiskAttachmentsAttachment : TeaModel {
                        [NameInMap("AttachedTime")]
                        [Validation(Required=false)]
                        public string AttachedTime { get; set; }

                        [NameInMap("Device")]
                        [Validation(Required=false)]
                        public string Device { get; set; }

                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                    }

                }

                [NameInMap("AutoSnapshotPolicyId")]
                [Validation(Required=false)]
                public string AutoSnapshotPolicyId { get; set; }

                [NameInMap("BdfId")]
                [Validation(Required=false)]
                public string BdfId { get; set; }

                [NameInMap("BurstingEnabled")]
                [Validation(Required=false)]
                public bool? BurstingEnabled { get; set; }

                [NameInMap("Category")]
                [Validation(Required=false)]
                public string Category { get; set; }

                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                [NameInMap("DeleteAutoSnapshot")]
                [Validation(Required=false)]
                public bool? DeleteAutoSnapshot { get; set; }

                [NameInMap("DeleteWithInstance")]
                [Validation(Required=false)]
                public bool? DeleteWithInstance { get; set; }

                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("DetachedTime")]
                [Validation(Required=false)]
                public string DetachedTime { get; set; }

                [NameInMap("Device")]
                [Validation(Required=false)]
                public string Device { get; set; }

                [NameInMap("DiskChargeType")]
                [Validation(Required=false)]
                public string DiskChargeType { get; set; }

                [NameInMap("DiskId")]
                [Validation(Required=false)]
                public string DiskId { get; set; }

                [NameInMap("DiskName")]
                [Validation(Required=false)]
                public string DiskName { get; set; }

                [NameInMap("EnableAutoSnapshot")]
                [Validation(Required=false)]
                public bool? EnableAutoSnapshot { get; set; }

                [NameInMap("EnableAutomatedSnapshotPolicy")]
                [Validation(Required=false)]
                public bool? EnableAutomatedSnapshotPolicy { get; set; }

                [NameInMap("Encrypted")]
                [Validation(Required=false)]
                public bool? Encrypted { get; set; }

                [NameInMap("ExpiredTime")]
                [Validation(Required=false)]
                public string ExpiredTime { get; set; }

                [NameInMap("IOPS")]
                [Validation(Required=false)]
                public int? IOPS { get; set; }

                [NameInMap("IOPSRead")]
                [Validation(Required=false)]
                public int? IOPSRead { get; set; }

                [NameInMap("IOPSWrite")]
                [Validation(Required=false)]
                public int? IOPSWrite { get; set; }

                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("KMSKeyId")]
                [Validation(Required=false)]
                public string KMSKeyId { get; set; }

                [NameInMap("MountInstanceNum")]
                [Validation(Required=false)]
                public int? MountInstanceNum { get; set; }

                [NameInMap("MountInstances")]
                [Validation(Required=false)]
                public DescribeDisksResponseBodyDisksDiskMountInstances MountInstances { get; set; }
                public class DescribeDisksResponseBodyDisksDiskMountInstances : TeaModel {
                    [NameInMap("MountInstance")]
                    [Validation(Required=false)]
                    public List<DescribeDisksResponseBodyDisksDiskMountInstancesMountInstance> MountInstance { get; set; }
                    public class DescribeDisksResponseBodyDisksDiskMountInstancesMountInstance : TeaModel {
                        [NameInMap("AttachedTime")]
                        [Validation(Required=false)]
                        public string AttachedTime { get; set; }

                        [NameInMap("Device")]
                        [Validation(Required=false)]
                        public string Device { get; set; }

                        [NameInMap("InstanceId")]
                        [Validation(Required=false)]
                        public string InstanceId { get; set; }

                    }

                }

                [NameInMap("MultiAttach")]
                [Validation(Required=false)]
                public string MultiAttach { get; set; }

                [NameInMap("OperationLocks")]
                [Validation(Required=false)]
                public DescribeDisksResponseBodyDisksDiskOperationLocks OperationLocks { get; set; }
                public class DescribeDisksResponseBodyDisksDiskOperationLocks : TeaModel {
                    [NameInMap("OperationLock")]
                    [Validation(Required=false)]
                    public List<DescribeDisksResponseBodyDisksDiskOperationLocksOperationLock> OperationLock { get; set; }
                    public class DescribeDisksResponseBodyDisksDiskOperationLocksOperationLock : TeaModel {
                        [NameInMap("LockReason")]
                        [Validation(Required=false)]
                        public string LockReason { get; set; }

                    }

                }

                [NameInMap("PerformanceLevel")]
                [Validation(Required=false)]
                public string PerformanceLevel { get; set; }

                [NameInMap("Portable")]
                [Validation(Required=false)]
                public bool? Portable { get; set; }

                [NameInMap("ProductCode")]
                [Validation(Required=false)]
                public string ProductCode { get; set; }

                [NameInMap("ProvisionedIops")]
                [Validation(Required=false)]
                public long? ProvisionedIops { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("SerialNumber")]
                [Validation(Required=false)]
                public string SerialNumber { get; set; }

                [NameInMap("Size")]
                [Validation(Required=false)]
                public int? Size { get; set; }

                [NameInMap("SourceSnapshotId")]
                [Validation(Required=false)]
                public string SourceSnapshotId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("StorageClusterId")]
                [Validation(Required=false)]
                public string StorageClusterId { get; set; }

                [NameInMap("StorageSetId")]
                [Validation(Required=false)]
                public string StorageSetId { get; set; }

                [NameInMap("StorageSetPartitionNumber")]
                [Validation(Required=false)]
                public int? StorageSetPartitionNumber { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeDisksResponseBodyDisksDiskTags Tags { get; set; }
                public class DescribeDisksResponseBodyDisksDiskTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeDisksResponseBodyDisksDiskTagsTag> Tag { get; set; }
                    public class DescribeDisksResponseBodyDisksDiskTagsTag : TeaModel {
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

                [NameInMap("Throughput")]
                [Validation(Required=false)]
                public int? Throughput { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
