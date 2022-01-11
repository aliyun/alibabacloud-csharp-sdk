// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeInstancesResponseBody : TeaModel {
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public DescribeInstancesResponseBodyInstances Instances { get; set; }
        public class DescribeInstancesResponseBodyInstances : TeaModel {
            [NameInMap("KVStoreInstance")]
            [Validation(Required=false)]
            public List<DescribeInstancesResponseBodyInstancesKVStoreInstance> KVStoreInstance { get; set; }
            public class DescribeInstancesResponseBodyInstancesKVStoreInstance : TeaModel {
                public string ArchitectureType { get; set; }
                public long? Bandwidth { get; set; }
                public long? Capacity { get; set; }
                public string ChargeType { get; set; }
                public string Config { get; set; }
                public string ConnectionDomain { get; set; }
                public string ConnectionMode { get; set; }
                public long? Connections { get; set; }
                public string CreateTime { get; set; }
                public string DestroyTime { get; set; }
                public string EndTime { get; set; }
                public string EngineVersion { get; set; }
                public string GlobalInstanceId { get; set; }
                public bool? HasRenewChangeOrder { get; set; }
                public string InstanceClass { get; set; }
                public string InstanceId { get; set; }
                public string InstanceName { get; set; }
                public string InstanceStatus { get; set; }
                public string InstanceType { get; set; }
                public bool? IsRds { get; set; }
                public string NetworkType { get; set; }
                public string NodeType { get; set; }
                public string PackageType { get; set; }
                public long? Port { get; set; }
                public string PrivateIp { get; set; }
                public long? QPS { get; set; }
                public string RegionId { get; set; }
                public string ReplacateId { get; set; }
                public string ResourceGroupId { get; set; }
                public string SearchKey { get; set; }
                public string SecondaryZoneId { get; set; }
                public int? ShardCount { get; set; }
                public DescribeInstancesResponseBodyInstancesKVStoreInstanceTags Tags { get; set; }
                public class DescribeInstancesResponseBodyInstancesKVStoreInstanceTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeInstancesResponseBodyInstancesKVStoreInstanceTagsTag> Tag { get; set; }
                    public class DescribeInstancesResponseBodyInstancesKVStoreInstanceTagsTag : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }
                public string UserName { get; set; }
                public string VSwitchId { get; set; }
                public string VpcId { get; set; }
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
        public int? TotalCount { get; set; }

    }

}
