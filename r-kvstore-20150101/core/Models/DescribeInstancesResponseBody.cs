// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the instances.</para>
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public DescribeInstancesResponseBodyInstances Instances { get; set; }
        public class DescribeInstancesResponseBodyInstances : TeaModel {
            [NameInMap("KVStoreInstance")]
            [Validation(Required=false)]
            public List<DescribeInstancesResponseBodyInstancesKVStoreInstance> KVStoreInstance { get; set; }
            public class DescribeInstancesResponseBodyInstancesKVStoreInstance : TeaModel {
                /// <summary>
                /// <para>The architecture of the instance. Default value: NULL. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>cluster</b>: cluster architecture</description></item>
                /// <item><description><b>standard</b>: standard architecture</description></item>
                /// <item><description><b>rwsplit</b>: read/write splitting architecture</description></item>
                /// <item><description><b>NULL</b>: all of the preceding architectures</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>cluster</para>
                /// </summary>
                [NameInMap("ArchitectureType")]
                [Validation(Required=false)]
                public string ArchitectureType { get; set; }

                /// <summary>
                /// <para>The bandwidth of the instance. Unit: Mbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>96</para>
                /// </summary>
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public long? Bandwidth { get; set; }

                /// <summary>
                /// <para>The storage capacity of the instance. Unit: MB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4096</para>
                /// </summary>
                [NameInMap("Capacity")]
                [Validation(Required=false)]
                public long? Capacity { get; set; }

                /// <summary>
                /// <para>The billing method of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>PrePaid</b>: subscription</description></item>
                /// <item><description><b>PostPaid</b>: pay-as-you-go</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PostPaid</para>
                /// </summary>
                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                /// <summary>
                /// <para>This parameter is returned only when the instance is in a cloud box.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloudbox</para>
                /// </summary>
                [NameInMap("CloudType")]
                [Validation(Required=false)]
                public string CloudType { get; set; }

                /// <summary>
                /// <para>The type of the computing resource. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Ecs</b>: cloud-native computing service</description></item>
                /// <item><description><b>Machine</b>: physical machine</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Ecs</para>
                /// </summary>
                [NameInMap("ComputingType")]
                [Validation(Required=false)]
                public string ComputingType { get; set; }

                /// <summary>
                /// <para>The parameter configurations of the instance. For more information, see <a href="https://help.aliyun.com/document_detail/43885.html">Modify parameters of an instance</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;maxmemory-policy\&quot;:\&quot;volatile-lfu\&quot;,\&quot;EvictionPolicy\&quot;:\&quot;volatile-lru\&quot;,\&quot;hash-max-ziplist-entries\&quot;:512,\&quot;zset-max-ziplist-entries\&quot;:128,\&quot;zset-max-ziplist-value\&quot;:64,\&quot;set-max-intset-entries\&quot;:512,\&quot;hash-max-ziplist-value\&quot;:64,\&quot;#no_loose_disabled-commands\&quot;:\&quot;flushall,flushdb\&quot;,\&quot;lazyfree-lazy-eviction\&quot;:\&quot;yes\&quot;}</para>
                /// </summary>
                [NameInMap("Config")]
                [Validation(Required=false)]
                public string Config { get; set; }

                /// <summary>
                /// <para>The internal endpoint of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>r-bp1zxszhcgatnx****.redis.rds.aliyuncs.com</para>
                /// </summary>
                [NameInMap("ConnectionDomain")]
                [Validation(Required=false)]
                public string ConnectionDomain { get; set; }

                /// <summary>
                /// <para>The connection mode of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Standard</b>: standard mode</description></item>
                /// <item><description><b>Safe</b>: database proxy mode</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Standard</para>
                /// </summary>
                [NameInMap("ConnectionMode")]
                [Validation(Required=false)]
                public string ConnectionMode { get; set; }

                /// <summary>
                /// <para>The maximum number of connections supported by the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20000</para>
                /// </summary>
                [NameInMap("Connections")]
                [Validation(Required=false)]
                public long? Connections { get; set; }

                /// <summary>
                /// <para>The time when the instance was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2018-11-07T08:49:00Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The time when the instance was deleted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-04-28T10:03:01Z</para>
                /// </summary>
                [NameInMap("DestroyTime")]
                [Validation(Required=false)]
                public string DestroyTime { get; set; }

                /// <summary>
                /// <para>The edition of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Community</b>: Redis Open-Source Edition</description></item>
                /// <item><description><b>Enterprise</b>: Tair (Enterprise Edition)</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Enterprise</para>
                /// </summary>
                [NameInMap("EditionType")]
                [Validation(Required=false)]
                public string EditionType { get; set; }

                /// <summary>
                /// <para>The time when the subscription instance expires.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-06-13T16:00:00Z</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The database engine version of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4.0</para>
                /// </summary>
                [NameInMap("EngineVersion")]
                [Validation(Required=false)]
                public string EngineVersion { get; set; }

                /// <summary>
                /// <para>The ID of the distributed instance.</para>
                /// <remarks>
                /// <para> This parameter is returned only if the instance is a child instance of a distributed instance.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>gr-bp14rkqrhac****</para>
                /// </summary>
                [NameInMap("GlobalInstanceId")]
                [Validation(Required=false)]
                public string GlobalInstanceId { get; set; }

                /// <summary>
                /// <para>Indicates whether your Alibaba Cloud account has pending orders for renewal and configuration change. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("HasRenewChangeOrder")]
                [Validation(Required=false)]
                public bool? HasRenewChangeOrder { get; set; }

                /// <summary>
                /// <para>The instance class.</para>
                /// 
                /// <b>Example:</b>
                /// <para>redis.logic.sharding.2g.2db.0rodb.4proxy.default</para>
                /// </summary>
                [NameInMap("InstanceClass")]
                [Validation(Required=false)]
                public string InstanceClass { get; set; }

                /// <summary>
                /// <para>The ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>r-bp1zxszhcgatnx****</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The name of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>apitest</para>
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// <para>The state of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Normal</b>: The instance is normal.</description></item>
                /// <item><description><b>Creating</b>: The instance is being created.</description></item>
                /// <item><description><b>Changing</b>: The configurations of the instance are being changed.</description></item>
                /// <item><description><b>Inactive</b>: The instance is disabled.</description></item>
                /// <item><description><b>Flushing</b>: The instance is being released.</description></item>
                /// <item><description><b>Released</b>: The instance is released.</description></item>
                /// <item><description><b>Transforming</b>: The billing method of the instance is being changed.</description></item>
                /// <item><description><b>Unavailable</b>: The instance is unavailable.</description></item>
                /// <item><description><b>Error</b>: The instance failed to be created.</description></item>
                /// <item><description><b>Migrating</b>: The instance is being migrated.</description></item>
                /// <item><description><b>BackupRecovering</b>: The instance is being restored from a backup.</description></item>
                /// <item><description><b>MinorVersionUpgrading</b>: The minor version of the instance is being updated.</description></item>
                /// <item><description><b>NetworkModifying</b>: The network type of the instance is being changed.</description></item>
                /// <item><description><b>SSLModifying</b>: The SSL configurations of the instance are being changed.</description></item>
                /// <item><description><b>MajorVersionUpgrading</b>: The major version of the instance is being upgraded. The instance remains accessible during the upgrade.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("InstanceStatus")]
                [Validation(Required=false)]
                public string InstanceStatus { get; set; }

                /// <summary>
                /// <para>The database engine of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Tair</b></description></item>
                /// <item><description><b>Redis</b></description></item>
                /// <item><description><b>Memcache</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Redis</para>
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// <para>Indicates whether the instance is managed by ApsaraDB RDS. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsRds")]
                [Validation(Required=false)]
                public bool? IsRds { get; set; }

                /// <summary>
                /// <para>The network type of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>CLASSIC</b></description></item>
                /// <item><description><b>VPC</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>CLASSIC</para>
                /// </summary>
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                /// <summary>
                /// <para>The node type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>double</b>: The instance contains a master node and a replica node.</description></item>
                /// <item><description><b>single</b>: The instance contains only a master node. This node type is phased out.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>double</para>
                /// </summary>
                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

                /// <summary>
                /// <para>The plan type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>standard</b>: standard plan</description></item>
                /// <item><description><b>customized</b>: custom plan</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>standard</para>
                /// </summary>
                [NameInMap("PackageType")]
                [Validation(Required=false)]
                public string PackageType { get; set; }

                /// <summary>
                /// <para>The service port of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6379</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public long? Port { get; set; }

                /// <summary>
                /// <para>The private IP address.</para>
                /// <remarks>
                /// <para> This parameter is not returned when the instance is deployed in the classic network.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>172.16.49.***</para>
                /// </summary>
                [NameInMap("PrivateIp")]
                [Validation(Required=false)]
                public string PrivateIp { get; set; }

                /// <summary>
                /// <para>The number of queries per second (QPS).</para>
                /// 
                /// <b>Example:</b>
                /// <para>100000</para>
                /// </summary>
                [NameInMap("QPS")]
                [Validation(Required=false)]
                public long? QPS { get; set; }

                /// <summary>
                /// <para>The number of read replicas in the primary zone.</para>
                /// <remarks>
                /// <para> The <b>ReadOnlyCount</b> and <b>SlaveReadOnlyCount</b> parameters are applicable only to cloud-native instances for which read/write splitting is enabled. If the instance is a cluster instance, the preceding parameters indicate the number of read replicas <b>per node</b> in the primary and secondary zones of the instance.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ReadOnlyCount")]
                [Validation(Required=false)]
                public string ReadOnlyCount { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The logical ID of the distributed instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>grr-bp11381ebc16****</para>
                /// </summary>
                [NameInMap("ReplacateId")]
                [Validation(Required=false)]
                public string ReplacateId { get; set; }

                /// <summary>
                /// <para>The number of replica nodes in the primary zone.</para>
                /// <remarks>
                /// <para> The <b>ReplicaCount</b> and <b>SlaveReplicaCount</b> parameters are applicable only to cloud-native instances. If the instance is a cluster instance, the preceding parameters indicate the number of replica nodes <b>per node</b> in the primary and secondary zones of the instance.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ReplicaCount")]
                [Validation(Required=false)]
                public int? ReplicaCount { get; set; }

                /// <summary>
                /// <para>The ID of the resource group to which the instance belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-acfmyiu4ekp****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>The ID of the secondary zone.</para>
                /// <remarks>
                /// <para> If multiple zones are returned for <b>ZoneId</b>, such as cn-hangzhou-MAZ10(h,i), this parameter is ignored.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-h</para>
                /// </summary>
                [NameInMap("SecondaryZoneId")]
                [Validation(Required=false)]
                public string SecondaryZoneId { get; set; }

                /// <summary>
                /// <para>The shard class. For more information about shard classes, see <a href="https://help.aliyun.com/document_detail/26350.html">Overview</a>.</para>
                /// <remarks>
                /// <para> The overall performance of a cluster instance is calculated by multiplying the class of a single shard (ShardClass) by the number of shards (ShardCount).</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>redis.shard.small.ce</para>
                /// </summary>
                [NameInMap("ShardClass")]
                [Validation(Required=false)]
                public string ShardClass { get; set; }

                /// <summary>
                /// <para>The number of data shards in the cluster instance.</para>
                /// <remarks>
                /// <para> This parameter is returned only for cloud-native cluster instances or read/write splitting instances.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("ShardCount")]
                [Validation(Required=false)]
                public int? ShardCount { get; set; }

                /// <summary>
                /// <para>The number of read replicas in the secondary zone.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SlaveReadOnlyCount")]
                [Validation(Required=false)]
                public int? SlaveReadOnlyCount { get; set; }

                /// <summary>
                /// <para>The number of replica nodes in the secondary zone.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SlaveReplicaCount")]
                [Validation(Required=false)]
                public int? SlaveReplicaCount { get; set; }

                /// <summary>
                /// <para>Details about the tags.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeInstancesResponseBodyInstancesKVStoreInstanceTags Tags { get; set; }
                public class DescribeInstancesResponseBodyInstancesKVStoreInstanceTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeInstancesResponseBodyInstancesKVStoreInstanceTagsTag> Tag { get; set; }
                    public class DescribeInstancesResponseBodyInstancesKVStoreInstanceTagsTag : TeaModel {
                        /// <summary>
                        /// <para>The key of the tag.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>key1</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The value of the tag.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>value1</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>The username used to connect to the instance. By default, a username named after the instance ID is included.</para>
                /// 
                /// <b>Example:</b>
                /// <para>r-bp1zxszhcgatnx****</para>
                /// </summary>
                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

                /// <summary>
                /// <para>The ID of the vSwitch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bp1e7clcw529l773d****</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The ID of the virtual private cloud (VPC).</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-bp1nme44gek34slfc****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>The zone ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-b</para>
                /// </summary>
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
