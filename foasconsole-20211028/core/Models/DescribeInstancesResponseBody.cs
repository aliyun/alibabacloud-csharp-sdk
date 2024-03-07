// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Foasconsole20211028.Models
{
    public class DescribeInstancesResponseBody : TeaModel {
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<DescribeInstancesResponseBodyInstances> Instances { get; set; }
        public class DescribeInstancesResponseBodyInstances : TeaModel {
            [NameInMap("ArchitectureType")]
            [Validation(Required=false)]
            public string ArchitectureType { get; set; }

            [NameInMap("AskClusterId")]
            [Validation(Required=false)]
            public string AskClusterId { get; set; }

            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            [NameInMap("ClusterStatus")]
            [Validation(Required=false)]
            public string ClusterStatus { get; set; }

            [NameInMap("Ha")]
            [Validation(Required=false)]
            public bool? Ha { get; set; }

            [NameInMap("HaResourceSpec")]
            [Validation(Required=false)]
            public DescribeInstancesResponseBodyInstancesHaResourceSpec HaResourceSpec { get; set; }
            public class DescribeInstancesResponseBodyInstancesHaResourceSpec : TeaModel {
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public int? Cpu { get; set; }

                [NameInMap("MemoryGB")]
                [Validation(Required=false)]
                public int? MemoryGB { get; set; }

            }

            [NameInMap("HaVSwitchIds")]
            [Validation(Required=false)]
            public List<string> HaVSwitchIds { get; set; }

            [NameInMap("HaZoneId")]
            [Validation(Required=false)]
            public string HaZoneId { get; set; }

            [NameInMap("HostAliases")]
            [Validation(Required=false)]
            public List<DescribeInstancesResponseBodyInstancesHostAliases> HostAliases { get; set; }
            public class DescribeInstancesResponseBodyInstancesHostAliases : TeaModel {
                [NameInMap("HostNames")]
                [Validation(Required=false)]
                public List<string> HostNames { get; set; }

                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

            }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            [NameInMap("MonitorType")]
            [Validation(Required=false)]
            public string MonitorType { get; set; }

            [NameInMap("OrderState")]
            [Validation(Required=false)]
            public string OrderState { get; set; }

            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            [NameInMap("ResourceCreateTime")]
            [Validation(Required=false)]
            public long? ResourceCreateTime { get; set; }

            [NameInMap("ResourceExpiredTime")]
            [Validation(Required=false)]
            public long? ResourceExpiredTime { get; set; }

            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            [NameInMap("ResourceSpec")]
            [Validation(Required=false)]
            public DescribeInstancesResponseBodyInstancesResourceSpec ResourceSpec { get; set; }
            public class DescribeInstancesResponseBodyInstancesResourceSpec : TeaModel {
                [NameInMap("Cpu")]
                [Validation(Required=false)]
                public int? Cpu { get; set; }

                [NameInMap("MemoryGB")]
                [Validation(Required=false)]
                public int? MemoryGB { get; set; }

            }

            [NameInMap("Storage")]
            [Validation(Required=false)]
            public DescribeInstancesResponseBodyInstancesStorage Storage { get; set; }
            public class DescribeInstancesResponseBodyInstancesStorage : TeaModel {
                [NameInMap("Oss")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesStorageOss Oss { get; set; }
                public class DescribeInstancesResponseBodyInstancesStorageOss : TeaModel {
                    [NameInMap("Bucket")]
                    [Validation(Required=false)]
                    public string Bucket { get; set; }

                }

            }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeInstancesResponseBodyInstancesTags> Tags { get; set; }
            public class DescribeInstancesResponseBodyInstancesTags : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("Uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

            [NameInMap("VSwitchIds")]
            [Validation(Required=false)]
            public List<string> VSwitchIds { get; set; }

            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("TotalPage")]
        [Validation(Required=false)]
        public int? TotalPage { get; set; }

    }

}
