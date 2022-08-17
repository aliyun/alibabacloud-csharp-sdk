// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ebs20210730.Models
{
    public class DescribeDedicatedBlockStorageClusterDisksResponseBody : TeaModel {
        [NameInMap("Disks")]
        [Validation(Required=false)]
        public DescribeDedicatedBlockStorageClusterDisksResponseBodyDisks Disks { get; set; }
        public class DescribeDedicatedBlockStorageClusterDisksResponseBodyDisks : TeaModel {
            [NameInMap("Disk")]
            [Validation(Required=false)]
            public List<DescribeDedicatedBlockStorageClusterDisksResponseBodyDisksDisk> Disk { get; set; }
            public class DescribeDedicatedBlockStorageClusterDisksResponseBodyDisksDisk : TeaModel {
                public string AttachedTime { get; set; }
                public string BdfId { get; set; }
                public string Category { get; set; }
                public bool? DeleteAutoSnapshot { get; set; }
                public bool? DeleteWithInstance { get; set; }
                public string Description { get; set; }
                public string DetachedTime { get; set; }
                public string Device { get; set; }
                public string DiskChargeType { get; set; }
                public string DiskId { get; set; }
                public string DiskName { get; set; }
                public bool? EnableAutoSnapshot { get; set; }
                public bool? Encrypted { get; set; }
                public long? IOPS { get; set; }
                public string ImageId { get; set; }
                public string InstanceId { get; set; }
                public string KMSKeyId { get; set; }
                public int? MountInstanceNum { get; set; }
                public string MultiAttach { get; set; }
                public string PerformanceLevel { get; set; }
                public bool? Portable { get; set; }
                public string RegionId { get; set; }
                public int? Size { get; set; }
                public string SourceSnapshotId { get; set; }
                public string Status { get; set; }
                public string StorageClusterId { get; set; }
                public string StorageSetId { get; set; }
                public int? StorageSetPartitionNumber { get; set; }
                public List<DescribeDedicatedBlockStorageClusterDisksResponseBodyDisksDiskTags> Tags { get; set; }
                public class DescribeDedicatedBlockStorageClusterDisksResponseBodyDisksDiskTags : TeaModel {
                    public string TagKey { get; set; }
                    public string TagValue { get; set; }
                }
                public string Type { get; set; }
                public string ZoneId { get; set; }
            }
        };

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
