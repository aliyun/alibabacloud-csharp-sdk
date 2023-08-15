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
                [NameInMap("AutoRenewal")]
                [Validation(Required=false)]
                public bool? AutoRenewal { get; set; }

                [NameInMap("BackupStatus")]
                [Validation(Required=false)]
                public string BackupStatus { get; set; }

                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                [NameInMap("ClusterName")]
                [Validation(Required=false)]
                public string ClusterName { get; set; }

                [NameInMap("ClusterType")]
                [Validation(Required=false)]
                public string ClusterType { get; set; }

                [NameInMap("ColdStorageStatus")]
                [Validation(Required=false)]
                public string ColdStorageStatus { get; set; }

                [NameInMap("CoreDiskCount")]
                [Validation(Required=false)]
                public string CoreDiskCount { get; set; }

                [NameInMap("CoreDiskSize")]
                [Validation(Required=false)]
                public int? CoreDiskSize { get; set; }

                [NameInMap("CoreDiskType")]
                [Validation(Required=false)]
                public string CoreDiskType { get; set; }

                [NameInMap("CoreInstanceType")]
                [Validation(Required=false)]
                public string CoreInstanceType { get; set; }

                [NameInMap("CoreNodeCount")]
                [Validation(Required=false)]
                public int? CoreNodeCount { get; set; }

                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                [NameInMap("CreatedTimeUTC")]
                [Validation(Required=false)]
                public string CreatedTimeUTC { get; set; }

                [NameInMap("Duration")]
                [Validation(Required=false)]
                public int? Duration { get; set; }

                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                [NameInMap("ExpireTimeUTC")]
                [Validation(Required=false)]
                public string ExpireTimeUTC { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                [NameInMap("IsDeletionProtection")]
                [Validation(Required=false)]
                public bool? IsDeletionProtection { get; set; }

                [NameInMap("IsHa")]
                [Validation(Required=false)]
                public bool? IsHa { get; set; }

                [NameInMap("MajorVersion")]
                [Validation(Required=false)]
                public string MajorVersion { get; set; }

                [NameInMap("MasterDiskSize")]
                [Validation(Required=false)]
                public int? MasterDiskSize { get; set; }

                [NameInMap("MasterDiskType")]
                [Validation(Required=false)]
                public string MasterDiskType { get; set; }

                [NameInMap("MasterInstanceType")]
                [Validation(Required=false)]
                public string MasterInstanceType { get; set; }

                [NameInMap("MasterNodeCount")]
                [Validation(Required=false)]
                public int? MasterNodeCount { get; set; }

                [NameInMap("ModuleId")]
                [Validation(Required=false)]
                public int? ModuleId { get; set; }

                [NameInMap("ModuleStackVersion")]
                [Validation(Required=false)]
                public string ModuleStackVersion { get; set; }

                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                [NameInMap("ParentId")]
                [Validation(Required=false)]
                public string ParentId { get; set; }

                [NameInMap("PayType")]
                [Validation(Required=false)]
                public string PayType { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
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

                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                [NameInMap("VswitchId")]
                [Validation(Required=false)]
                public string VswitchId { get; set; }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

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
