// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeInstancesResponseBody : TeaModel {
        /// <summary>
        /// Details of the instances.
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
                /// The architecture of the instance. Default value: NULL. Valid values:
                /// 
                /// *   **cluster**: The instance is a cluster instance.
                /// *   **standard**: The instance is a standard instance.
                /// *   **rwsplit**: The instance is a read/write splitting instance.
                /// *   **NULL**: The instance can be a cluster, standard, or read/write splitting instance.
                /// </summary>
                [NameInMap("ArchitectureType")]
                [Validation(Required=false)]
                public string ArchitectureType { get; set; }

                /// <summary>
                /// The bandwidth of the instance. Unit: Mbit/s.
                /// </summary>
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public long? Bandwidth { get; set; }

                /// <summary>
                /// The storage capacity of the instance. Unit: MB.
                /// </summary>
                [NameInMap("Capacity")]
                [Validation(Required=false)]
                public long? Capacity { get; set; }

                /// <summary>
                /// The billing method of the instance. Valid values:
                /// 
                /// *   **PrePaid**: subscription
                /// *   **PostPaid**: pay-as-you-go
                /// </summary>
                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                /// <summary>
                /// This parameter is returned only when the instance is in a cloud box.
                /// </summary>
                [NameInMap("CloudType")]
                [Validation(Required=false)]
                public string CloudType { get; set; }

                /// <summary>
                /// The parameter configurations of the instance. For more information, see [Modify parameters of an instance](~~43885~~).
                /// </summary>
                [NameInMap("Config")]
                [Validation(Required=false)]
                public string Config { get; set; }

                /// <summary>
                /// The internal endpoint of the instance.
                /// </summary>
                [NameInMap("ConnectionDomain")]
                [Validation(Required=false)]
                public string ConnectionDomain { get; set; }

                /// <summary>
                /// The connection mode of the instance. Valid values:
                /// 
                /// *   **Standard**: standard mode
                /// *   **Safe**: proxy mode
                /// </summary>
                [NameInMap("ConnectionMode")]
                [Validation(Required=false)]
                public string ConnectionMode { get; set; }

                /// <summary>
                /// The maximum number of connections supported by the instance.
                /// </summary>
                [NameInMap("Connections")]
                [Validation(Required=false)]
                public long? Connections { get; set; }

                /// <summary>
                /// The time when the instance was created.
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// The time when the instance was deleted.
                /// </summary>
                [NameInMap("DestroyTime")]
                [Validation(Required=false)]
                public string DestroyTime { get; set; }

                /// <summary>
                /// The edition of the instance. Valid values:
                /// 
                /// *   **Community**: Community Edition
                /// *   **Enterprise**: Enhance Edition (Tair)
                /// </summary>
                [NameInMap("EditionType")]
                [Validation(Required=false)]
                public string EditionType { get; set; }

                /// <summary>
                /// The time when the subscription instance expires.
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// The database engine version of the instance. Valid values: **2.8**, **4.0**, **5.0**, and **6.0**.
                /// </summary>
                [NameInMap("EngineVersion")]
                [Validation(Required=false)]
                public string EngineVersion { get; set; }

                /// <summary>
                /// The ID of the distributed instance.
                /// 
                /// > This parameter is returned only when the instance is a child instance of a distributed instance.
                /// </summary>
                [NameInMap("GlobalInstanceId")]
                [Validation(Required=false)]
                public string GlobalInstanceId { get; set; }

                /// <summary>
                /// Indicates whether your Alibaba Cloud account has pending orders for renewal and configuration change. Valid values:
                /// 
                /// *   **true**: Your Alibaba Cloud account has pending orders for renewal and configuration change.
                /// *   **false**: Your Alibaba Cloud account does not have pending orders for renewal and configuration change.
                /// </summary>
                [NameInMap("HasRenewChangeOrder")]
                [Validation(Required=false)]
                public bool? HasRenewChangeOrder { get; set; }

                /// <summary>
                /// The instance class of the instance.
                /// </summary>
                [NameInMap("InstanceClass")]
                [Validation(Required=false)]
                public string InstanceClass { get; set; }

                /// <summary>
                /// The ID of the instance.
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// The name of the instance.
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// The state of the instance. Valid values:
                /// 
                /// *   **Normal**: The instance is normal.
                /// *   **Creating**: The instance is being created.
                /// *   **Changing**: The configurations of the instance are being changed.
                /// *   **Inactive**: The instance is disabled.
                /// *   **Flushing**: The instance is being released.
                /// *   **Released**: The instance is released.
                /// *   **Transforming**: The billing method of the instance is being changed.
                /// *   **Unavailable**: The instance is suspended.
                /// *   **Error**: The instance failed to be created.
                /// *   **Migrating**: The instance is being migrated.
                /// *   **BackupRecovering**: The instance is being restored from a backup.
                /// *   **MinorVersionUpgrading**: The minor version of the instance is being updated.
                /// *   **NetworkModifying**: The network type of the instance is being changed.
                /// *   **SSLModifying**: The SSL certificate of the instance is being changed.
                /// *   **MajorVersionUpgrading**: The major version of the instance is being upgraded. The instance remains accessible during the upgrade.
                /// </summary>
                [NameInMap("InstanceStatus")]
                [Validation(Required=false)]
                public string InstanceStatus { get; set; }

                /// <summary>
                /// The database engine of the instance. Valid values:
                /// 
                /// *   **Tair**
                /// *   **Redis**
                /// *   **Memcache**
                /// </summary>
                [NameInMap("InstanceType")]
                [Validation(Required=false)]
                public string InstanceType { get; set; }

                /// <summary>
                /// Indicates whether the instance is managed by ApsaraDB RDS. Valid values:
                /// 
                /// *   **true**: The instance is managed by ApsaraDB RDS.
                /// *   **false**: The instance is not managed by ApsaraDB RDS.
                /// </summary>
                [NameInMap("IsRds")]
                [Validation(Required=false)]
                public bool? IsRds { get; set; }

                /// <summary>
                /// The network type of the instance. Valid values:
                /// 
                /// *   **CLASSIC**: classic network
                /// *   **VPC**: VPC
                /// </summary>
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                /// <summary>
                /// The node type. Valid values:
                /// 
                /// *   **double**: The instance contains a master node and a replica node.
                /// *   **single**: The instance contains only a master node. This node type is phrased out.
                /// </summary>
                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

                /// <summary>
                /// The plan type of the instance. Valid values:
                /// 
                /// *   **standard**: standard plan
                /// *   **customized**: custom plan
                /// </summary>
                [NameInMap("PackageType")]
                [Validation(Required=false)]
                public string PackageType { get; set; }

                /// <summary>
                /// The port number of the instance.
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public long? Port { get; set; }

                /// <summary>
                /// The private IP address of the instance.
                /// 
                /// > This parameter is not returned when the instance is deployed in the classic network.
                /// </summary>
                [NameInMap("PrivateIp")]
                [Validation(Required=false)]
                public string PrivateIp { get; set; }

                /// <summary>
                /// The expected maximum queries per second (QPS).
                /// </summary>
                [NameInMap("QPS")]
                [Validation(Required=false)]
                public long? QPS { get; set; }

                /// <summary>
                /// The region ID of the instance.
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// The logical ID of the replica instance.
                /// </summary>
                [NameInMap("ReplacateId")]
                [Validation(Required=false)]
                public string ReplacateId { get; set; }

                /// <summary>
                /// The ID of the resource group to which the instance belongs.
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// The ID of the secondary zone.
                /// 
                /// > If multiple zones are returned for **ZoneId** such as cn-hangzhou-MAZ10(h,i), this parameter is ignored.
                /// </summary>
                [NameInMap("SecondaryZoneId")]
                [Validation(Required=false)]
                public string SecondaryZoneId { get; set; }

                /// <summary>
                /// The shard class for the instance.
                /// </summary>
                [NameInMap("ShardClass")]
                [Validation(Required=false)]
                public string ShardClass { get; set; }

                /// <summary>
                /// The number of data shards in the instance.
                /// 
                /// > This parameter is returned only when the instance is a cluster instance that uses cloud disks.
                /// </summary>
                [NameInMap("ShardCount")]
                [Validation(Required=false)]
                public int? ShardCount { get; set; }

                /// <summary>
                /// Details of the tags.
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
                        /// The key of the tag.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The value of the tag.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// The username that is used to connect to the instance. By default, the username that is named after the instance ID is returned.
                /// </summary>
                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

                /// <summary>
                /// The ID of the vSwitch.
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// The ID of the VPC.
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// The zone ID of the instance.
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of instances.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
