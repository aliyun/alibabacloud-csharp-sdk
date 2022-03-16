// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class DescribeInstancesResponseBody : TeaModel {
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public DescribeInstancesResponseBodyInstances Instances { get; set; }
        public class DescribeInstancesResponseBodyInstances : TeaModel {
            [NameInMap("Instance")]
            [Validation(Required=false)]
            public List<DescribeInstancesResponseBodyInstancesInstance> Instance { get; set; }
            public class DescribeInstancesResponseBodyInstancesInstance : TeaModel {
                public bool? AutoRenewal { get; set; }
                public string BackupStatus { get; set; }
                public string ClusterId { get; set; }
                public string ClusterName { get; set; }
                public string ClusterType { get; set; }
                public string ColdStorageStatus { get; set; }
                public string CoreDiskCount { get; set; }
                public int? CoreDiskSize { get; set; }
                public string CoreDiskType { get; set; }
                public string CoreInstanceType { get; set; }
                public int? CoreNodeCount { get; set; }
                public string CreatedTime { get; set; }
                public string CreatedTimeUTC { get; set; }
                public int? Duration { get; set; }
                public string Engine { get; set; }
                public string ExpireTime { get; set; }
                public string ExpireTimeUTC { get; set; }
                public string InstanceId { get; set; }
                public string InstanceName { get; set; }
                public bool? IsDeletionProtection { get; set; }
                public bool? IsHa { get; set; }
                public string MajorVersion { get; set; }
                public int? MasterDiskSize { get; set; }
                public string MasterDiskType { get; set; }
                public string MasterInstanceType { get; set; }
                public int? MasterNodeCount { get; set; }
                public int? ModuleId { get; set; }
                public string ModuleStackVersion { get; set; }
                public string NetworkType { get; set; }
                public string ParentId { get; set; }
                public string PayType { get; set; }
                public string RegionId { get; set; }
                public string ResourceGroupId { get; set; }
                public string Status { get; set; }
                public DescribeInstancesResponseBodyInstancesInstanceTags Tags { get; set; }
                public class DescribeInstancesResponseBodyInstancesInstanceTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeInstancesResponseBodyInstancesInstanceTagsTag> Tag { get; set; }
                    public class DescribeInstancesResponseBodyInstancesInstanceTagsTag : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }
                public string VpcId { get; set; }
                public string VswitchId { get; set; }
                public string ZoneId { get; set; }
            }
        };

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
        public long? TotalCount { get; set; }

    }

}
