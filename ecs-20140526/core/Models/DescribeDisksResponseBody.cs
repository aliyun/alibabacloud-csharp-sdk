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
                public string AttachedTime { get; set; }
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
                public string AutoSnapshotPolicyId { get; set; }
                public string BdfId { get; set; }
                public bool? BurstingEnabled { get; set; }
                public string Category { get; set; }
                public string CreationTime { get; set; }
                public bool? DeleteAutoSnapshot { get; set; }
                public bool? DeleteWithInstance { get; set; }
                public string Description { get; set; }
                public string DetachedTime { get; set; }
                public string Device { get; set; }
                public string DiskChargeType { get; set; }
                public string DiskId { get; set; }
                public string DiskName { get; set; }
                public bool? EnableAutoSnapshot { get; set; }
                public bool? EnableAutomatedSnapshotPolicy { get; set; }
                public bool? Encrypted { get; set; }
                public string ExpiredTime { get; set; }
                public int? IOPS { get; set; }
                public int? IOPSRead { get; set; }
                public int? IOPSWrite { get; set; }
                public string ImageId { get; set; }
                public string InstanceId { get; set; }
                public string KMSKeyId { get; set; }
                public int? MountInstanceNum { get; set; }
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
                public string MultiAttach { get; set; }
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
                public string PerformanceLevel { get; set; }
                public bool? Portable { get; set; }
                public string ProductCode { get; set; }
                public long? ProvisionedIops { get; set; }
                public string RegionId { get; set; }
                public string ResourceGroupId { get; set; }
                public string SerialNumber { get; set; }
                public int? Size { get; set; }
                public string SourceSnapshotId { get; set; }
                public string Status { get; set; }
                public string StorageClusterId { get; set; }
                public string StorageSetId { get; set; }
                public int? StorageSetPartitionNumber { get; set; }
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
                public int? Throughput { get; set; }
                public string Type { get; set; }
                public string ZoneId { get; set; }
            }
        };

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
