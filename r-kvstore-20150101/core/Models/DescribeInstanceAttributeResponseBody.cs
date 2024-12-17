// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeInstanceAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the instances.</para>
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public DescribeInstanceAttributeResponseBodyInstances Instances { get; set; }
        public class DescribeInstanceAttributeResponseBodyInstances : TeaModel {
            [NameInMap("DBInstanceAttribute")]
            [Validation(Required=false)]
            public List<DescribeInstanceAttributeResponseBodyInstancesDBInstanceAttribute> DBInstanceAttribute { get; set; }
            public class DescribeInstanceAttributeResponseBodyInstancesDBInstanceAttribute : TeaModel {
                /// <summary>
                /// <para>The architecture of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>cluster</b>: cluster architecture</description></item>
                /// <item><description><b>standard</b>: standard architecture</description></item>
                /// <item><description><b>rwsplit</b>: read/write splitting architecture</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>standard</para>
                /// </summary>
                [NameInMap("ArchitectureType")]
                [Validation(Required=false)]
                public string ArchitectureType { get; set; }

                /// <summary>
                /// <para>The retention period of audit logs. Unit: day. A value of 0 indicates that the audit log feature is disabled. For information about how to enable the feature, see <a href="https://help.aliyun.com/document_detail/102015.html">Enable the audit log feature</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>15</para>
                /// </summary>
                [NameInMap("AuditLogRetention")]
                [Validation(Required=false)]
                public string AuditLogRetention { get; set; }

                /// <summary>
                /// <para>The availability metric of the current month.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100%</para>
                /// </summary>
                [NameInMap("AvailabilityValue")]
                [Validation(Required=false)]
                public string AvailabilityValue { get; set; }

                /// <summary>
                /// <para>The earliest point in time to which data can be restored. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// <remarks>
                /// </remarks>
                /// <list type="bullet">
                /// <item><description><para>This parameter is returned only when the data flashback feature is enabled for the instance. For more information, see <a href="https://help.aliyun.com/document_detail/148479.html">Restore data to a point in time by using the data flashback feature</a>.</para>
                /// </description></item>
                /// <item><description><para>When you call the <a href="https://help.aliyun.com/document_detail/61083.html">RestoreInstance</a> operation to implement data flashback, you can obtain the earliest point in time for data flashback from the return value of this parameter and set the <b>RestoreTime</b> parameter to this point in time.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>2021-07-06T05:49:55Z</para>
                /// </summary>
                [NameInMap("BackupLogStartTime")]
                [Validation(Required=false)]
                public string BackupLogStartTime { get; set; }

                /// <summary>
                /// <para>The bandwidth of the instance. Unit: Mbit/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("Bandwidth")]
                [Validation(Required=false)]
                public long? Bandwidth { get; set; }

                /// <summary>
                /// <para>The storage capacity of the instance. Unit: MB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1024</para>
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
                /// <para>The parameter configurations of the instance in the JSON format. For more information, see <a href="https://help.aliyun.com/document_detail/43885.html">Parameter descriptions</a>. You can use the <a href="https://help.aliyun.com/document_detail/473830.html">DescribeAuditLogConfig</a> operation to query audit log configurations.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{\&quot;EvictionPolicy\&quot;:\&quot;volatile-lru\&quot;,\&quot;hash-max-ziplist-entries\&quot;:512,\&quot;zset-max-ziplist-entries\&quot;:128,\&quot;zset-max-ziplist-value\&quot;:64,\&quot;set-max-intset-entries\&quot;:512,\&quot;hash-max-ziplist-value\&quot;:64}</para>
                /// </summary>
                [NameInMap("Config")]
                [Validation(Required=false)]
                public string Config { get; set; }

                /// <summary>
                /// <para>The internal endpoint of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>r-bp1d72gwl41z7f****.redis.rds.aliyuncs.com</para>
                /// </summary>
                [NameInMap("ConnectionDomain")]
                [Validation(Required=false)]
                public string ConnectionDomain { get; set; }

                /// <summary>
                /// <para>The maximum number of connections supported by the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10000</para>
                /// </summary>
                [NameInMap("Connections")]
                [Validation(Required=false)]
                public long? Connections { get; set; }

                /// <summary>
                /// <para>The time when the instance was created. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-03-06T10:42:03Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The time when the subscription expires. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2019-04-06T10:42:03Z</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The database engine of the instance. The return value is <b>Redis</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Redis</para>
                /// </summary>
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                /// <summary>
                /// <para>The database engine version of the instance. Valid values: <b>2.8</b>, <b>4.0</b>, and <b>5.0</b>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4.0</para>
                /// </summary>
                [NameInMap("EngineVersion")]
                [Validation(Required=false)]
                public string EngineVersion { get; set; }

                /// <summary>
                /// <para>The ID of the distributed instance to which the instance belongs.</para>
                /// <remarks>
                /// <para> This parameter is returned only when the ApsaraDB for Redis instance is a child instance of a distributed instance.</para>
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
                public string HasRenewChangeOrder { get; set; }

                /// <summary>
                /// <para>The instance type. For more information, see <a href="https://help.aliyun.com/document_detail/107984.html">Instance types</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>redis.master.small.default</para>
                /// </summary>
                [NameInMap("InstanceClass")]
                [Validation(Required=false)]
                public string InstanceClass { get; set; }

                /// <summary>
                /// <para>The ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>r-bp1d72gwl41z7f****</para>
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
                /// <para>Indicates whether the release protection feature is enabled for the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("InstanceReleaseProtection")]
                [Validation(Required=false)]
                public bool? InstanceReleaseProtection { get; set; }

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
                /// <remarks>
                /// <para> For more information about instance states, see <a href="https://help.aliyun.com/document_detail/200740.html">Instance states and impacts</a>.</para>
                /// </remarks>
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
                /// <para>Indicates whether the order for instance configuration change has reached the final state. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: The configuration change has been completed or has not been performed.</description></item>
                /// <item><description><b>false</b>: The configurations of the instance are being changed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsOrderCompleted")]
                [Validation(Required=false)]
                public bool? IsOrderCompleted { get; set; }

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
                /// <para>Indicates whether the transparent data encryption (TDE) feature is supported for the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: This feature is supported. This feature is available only for <a href="https://help.aliyun.com/document_detail/443827.html">DRAM-based</a> instances that use local disks.</description></item>
                /// <item><description><b>false</b>: This feature is not supported.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsSupportTDE")]
                [Validation(Required=false)]
                public bool? IsSupportTDE { get; set; }

                /// <summary>
                /// <para>The end time of the maintenance window. The time is in the <em>HH:mmZ</em> format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>22:00Z</para>
                /// </summary>
                [NameInMap("MaintainEndTime")]
                [Validation(Required=false)]
                public string MaintainEndTime { get; set; }

                /// <summary>
                /// <para>The start time of the maintenance window. The time is in the <em>HH:mmZ</em> format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>18:00Z</para>
                /// </summary>
                [NameInMap("MaintainStartTime")]
                [Validation(Required=false)]
                public string MaintainStartTime { get; set; }

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
                /// <item><description><b>single</b>: The instance is a standalone instance.</description></item>
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
                /// <item><description><b>standard</b>: standard plan.</description></item>
                /// <item><description><b>customized</b>: custom plan. This plan type is phased out.</description></item>
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
                /// <para>The private IP address of the instance.</para>
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
                /// <para>The expected maximum queries per second (QPS).</para>
                /// 
                /// <b>Example:</b>
                /// <para>100000</para>
                /// </summary>
                [NameInMap("QPS")]
                [Validation(Required=false)]
                public long? QPS { get; set; }

                /// <summary>
                /// <para>The number of read replicas. This parameter is available only for read/write splitting instances that use cloud disks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("ReadOnlyCount")]
                [Validation(Required=false)]
                public int? ReadOnlyCount { get; set; }

                /// <summary>
                /// <para>If the instance is a cluster instance that uses cloud disks, this parameter indicates the actual instance type of individual shards in the instance. The InstanceClass parameter indicates the virtual instance type.</para>
                /// <remarks>
                /// <para> To query fees for instances of the instance type, you can specify the instance type that is returned by this parameter in the <a href="https://help.aliyun.com/document_detail/95612.html">DescribePrice</a> operation.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>tair.rdb.with.proxy.1g</para>
                /// </summary>
                [NameInMap("RealInstanceClass")]
                [Validation(Required=false)]
                public string RealInstanceClass { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("ReplicaCount")]
                [Validation(Required=false)]
                public int? ReplicaCount { get; set; }

                /// <summary>
                /// <para>The ID of the replica node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>bls-awxxxxxxxxxxxxx</para>
                /// </summary>
                [NameInMap("ReplicaId")]
                [Validation(Required=false)]
                public string ReplicaId { get; set; }

                /// <summary>
                /// <para>The architecture of the replica node. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>master-slave</b>: the standard master-replica architecture.</description></item>
                /// <item><description><b>cluster</b>: the cluster architecture, which includes the read/write splitting instances and cluster instances.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>master-slave</para>
                /// </summary>
                [NameInMap("ReplicationMode")]
                [Validation(Required=false)]
                public string ReplicationMode { get; set; }

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
                /// <para> This parameter is returned only if the instance has a secondary zone ID.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hongkong-h</para>
                /// </summary>
                [NameInMap("SecondaryZoneId")]
                [Validation(Required=false)]
                public string SecondaryZoneId { get; set; }

                /// <summary>
                /// <para>The IP addresses in the whitelist.</para>
                /// 
                /// <b>Example:</b>
                /// <para>127.0.0.1</para>
                /// </summary>
                [NameInMap("SecurityIPList")]
                [Validation(Required=false)]
                public string SecurityIPList { get; set; }

                /// <summary>
                /// <para>The number of shards. This parameter is available only for ApsaraDB for Redis instances that are purchased on the China site (aliyun.com).</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("ShardCount")]
                [Validation(Required=false)]
                public int? ShardCount { get; set; }

                /// <summary>
                /// <para>The number of read replicas in the secondary zone. This parameter is returned only after read/write splitting is enabled for the instance across multiple zones.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("SlaveReadOnlyCount")]
                [Validation(Required=false)]
                public long? SlaveReadOnlyCount { get; set; }

                [NameInMap("SlaveReplicaCount")]
                [Validation(Required=false)]
                public int? SlaveReplicaCount { get; set; }

                /// <summary>
                /// <para>The storage capacity of the cloud disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("Storage")]
                [Validation(Required=false)]
                public string Storage { get; set; }

                /// <summary>
                /// <para>The storage type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>essd_pl1</para>
                /// </summary>
                [NameInMap("StorageType")]
                [Validation(Required=false)]
                public string StorageType { get; set; }

                /// <summary>
                /// <para>Details about the tags.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeInstanceAttributeResponseBodyInstancesDBInstanceAttributeTags Tags { get; set; }
                public class DescribeInstanceAttributeResponseBodyInstancesDBInstanceAttributeTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeInstanceAttributeResponseBodyInstancesDBInstanceAttributeTagsTag> Tag { get; set; }
                    public class DescribeInstanceAttributeResponseBodyInstancesDBInstanceAttributeTagsTag : TeaModel {
                        /// <summary>
                        /// <para>The tag key.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>tagkey</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The tag value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>tagvalue</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

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
                /// <para>Indicates whether password authentication is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Open</b>: Password authentication is enabled.</description></item>
                /// <item><description><b>Close</b>: Password authentication is disabled and <a href="https://help.aliyun.com/document_detail/85168.html">password-free access</a> is enabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Open</para>
                /// </summary>
                [NameInMap("VpcAuthMode")]
                [Validation(Required=false)]
                public string VpcAuthMode { get; set; }

                /// <summary>
                /// <para>The ID of the instance in the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>r-bp1d72gwl41z7f****</para>
                /// </summary>
                [NameInMap("VpcCloudInstanceId")]
                [Validation(Required=false)]
                public string VpcCloudInstanceId { get; set; }

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
                /// <para>cn-hongkong-b</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

                /// <summary>
                /// <para>The deployment type of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>singlezone</b>: The instance is deployed in a single zone.</description></item>
                /// <item><description><b>doublezone</b>: The instance is deployed in two zones of the same region.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>singlezone</para>
                /// </summary>
                [NameInMap("ZoneType")]
                [Validation(Required=false)]
                public string ZoneType { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CA40C261-EB72-4EDA-AC57-958722162595</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
