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
                [NameInMap("ArchitectureType")]
                [Validation(Required=false)]
                public string ArchitectureType { get; set; }

                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public long? Bandwidth { get; set; }

                [NameInMap("Capacity")]
                [Validation(Required=false)]
                public long? Capacity { get; set; }

                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                [NameInMap("CloudType")]
                [Validation(Required=false)]
                public string CloudType { get; set; }

                [NameInMap("ComputingType")]
                [Validation(Required=false)]
                public string ComputingType { get; set; }

                [NameInMap("Config")]
                [Validation(Required=false)]
                public string Config { get; set; }

                [NameInMap("ConnectionDomain")]
                [Validation(Required=false)]
                public string ConnectionDomain { get; set; }

                [NameInMap("ConnectionMode")]
                [Validation(Required=false)]
                public string ConnectionMode { get; set; }

                [NameInMap("Connections")]
                [Validation(Required=false)]
                public long? Connections { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("DestroyTime")]
                [Validation(Required=false)]
                public string DestroyTime { get; set; }

                [NameInMap("EditionType")]
                [Validation(Required=false)]
                public string EditionType { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                [NameInMap("EngineVersion")]
                [Validation(Required=false)]
                public string EngineVersion { get; set; }

                [NameInMap("GlobalInstanceId")]
                [Validation(Required=false)]
                public string GlobalInstanceId { get; set; }

                [NameInMap("HasRenewChangeOrder")]
                [Validation(Required=false)]
                public bool? HasRenewChangeOrder { get; set; }

                [NameInMap("InstanceClass")]
                [Validation(Required=false)]
                public string InstanceClass { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                [NameInMap("InstanceStatus")]
                [Validation(Required=false)]
                public string InstanceStatus { get; set; }

                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                [NameInMap("IsRds")]
                [Validation(Required=false)]
                public bool? IsRds { get; set; }

                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

                [NameInMap("PackageType")]
                [Validation(Required=false)]
                public string PackageType { get; set; }

                [NameInMap("Port")]
                [Validation(Required=false)]
                public long? Port { get; set; }

                [NameInMap("PrivateIp")]
                [Validation(Required=false)]
                public string PrivateIp { get; set; }

                [NameInMap("QPS")]
                [Validation(Required=false)]
                public long? QPS { get; set; }

                [NameInMap("ReadOnlyCount")]
                [Validation(Required=false)]
                public string ReadOnlyCount { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("ReplacateId")]
                [Validation(Required=false)]
                public string ReplacateId { get; set; }

                [NameInMap("ReplicaCount")]
                [Validation(Required=false)]
                public int? ReplicaCount { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                [NameInMap("SecondaryZoneId")]
                [Validation(Required=false)]
                public string SecondaryZoneId { get; set; }

                [NameInMap("ShardClass")]
                [Validation(Required=false)]
                public string ShardClass { get; set; }

                [NameInMap("ShardCount")]
                [Validation(Required=false)]
                public int? ShardCount { get; set; }

                [NameInMap("SlaveReadOnlyCount")]
                [Validation(Required=false)]
                public int? SlaveReadOnlyCount { get; set; }

                [NameInMap("SlaveReplicaCount")]
                [Validation(Required=false)]
                public int? SlaveReplicaCount { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
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

                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1E83311F-0EE4-4922-A3BF-730B312B****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
