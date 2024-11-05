// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeDBInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the instance.</para>
        /// </summary>
        [NameInMap("DBInstances")]
        [Validation(Required=false)]
        public DescribeDBInstancesResponseBodyDBInstances DBInstances { get; set; }
        public class DescribeDBInstancesResponseBodyDBInstances : TeaModel {
            [NameInMap("DBInstance")]
            [Validation(Required=false)]
            public List<DescribeDBInstancesResponseBodyDBInstancesDBInstance> DBInstance { get; set; }
            public class DescribeDBInstancesResponseBodyDBInstancesDBInstance : TeaModel {
                /// <summary>
                /// <para>The backup retention policy configured for the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: All backup sets of the instance are immediately deleted when the instance is released.</description></item>
                /// <item><description><b>1</b>: A backup set of the instance is automatically backed up and retained for a long period of time when the instance is released.</description></item>
                /// <item><description><b>2</b>: All backup sets of the instance are automatically backed up and retained for a long period of time when the instance is released.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("BackupRetentionPolicy")]
                [Validation(Required=false)]
                public int? BackupRetentionPolicy { get; set; }

                /// <summary>
                /// <para>The I/O throughput consumed by the instance.</para>
                /// <remarks>
                /// <para> This parameter is required only when the instance is a serverless instance.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("CapacityUnit")]
                [Validation(Required=false)]
                public string CapacityUnit { get; set; }

                /// <summary>
                /// <para>The billing method of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>PrePaid</b>: subscription</description></item>
                /// <item><description><b>PostPaid:</b> pay-as-you-go</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>PrePaid</para>
                /// </summary>
                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                /// <summary>
                /// <para>The time when the instance was created. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-03-25T02:18:00Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The instance type of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dds.mongo.mid</para>
                /// </summary>
                [NameInMap("DBInstanceClass")]
                [Validation(Required=false)]
                public string DBInstanceClass { get; set; }

                /// <summary>
                /// <para>The description of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Test database</para>
                /// </summary>
                [NameInMap("DBInstanceDescription")]
                [Validation(Required=false)]
                public string DBInstanceDescription { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dds-bp18b0934e70****</para>
                /// </summary>
                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                /// <summary>
                /// <para>The status of the instance. For more information, see <a href="https://help.aliyun.com/document_detail/63870.html">Instance states</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("DBInstanceStatus")]
                [Validation(Required=false)]
                public string DBInstanceStatus { get; set; }

                /// <summary>
                /// <para>The storage capacity of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("DBInstanceStorage")]
                [Validation(Required=false)]
                public int? DBInstanceStorage { get; set; }

                /// <summary>
                /// <para>The architecture of the instance.</para>
                /// <list type="bullet">
                /// <item><description><b>sharding</b>: sharded cluster instance</description></item>
                /// <item><description><b>replicate</b>: replica set or standalone instance</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>sharding</para>
                /// </summary>
                [NameInMap("DBInstanceType")]
                [Validation(Required=false)]
                public string DBInstanceType { get; set; }

                /// <summary>
                /// <para>The time when the instance data is destroyed. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>For a subscription instance, the computing resources of the instance are released on the 16th day after expiration, and the data of the instance is retained for seven days. The data is deleted on the 23th day after expiration and cannot be restored.</description></item>
                /// <item><description>For a pay-as-you-go instance, the computing resources of the instance are released on the 16th day after the payment becomes overdue, and the data of the instance is retained for seven days. The data is deleted on the 23th day after the payment becomes overdue and cannot be restored.</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2021-12-10T16:00:00Z</para>
                /// </summary>
                [NameInMap("DestroyTime")]
                [Validation(Required=false)]
                public string DestroyTime { get; set; }

                /// <summary>
                /// <para>The engine of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MongoDB</para>
                /// </summary>
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                /// <summary>
                /// <para>The database engine version of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>7.0</b></description></item>
                /// <item><description><b>6.0</b></description></item>
                /// <item><description><b>5.0</b></description></item>
                /// <item><description><b>4.4</b></description></item>
                /// <item><description><b>4.2</b></description></item>
                /// <item><description><b>4.0</b></description></item>
                /// <item><description><b>3.4</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>4.2</para>
                /// </summary>
                [NameInMap("EngineVersion")]
                [Validation(Required=false)]
                public string EngineVersion { get; set; }

                /// <summary>
                /// <para>The time when the instance expires. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-11-25T16:00Z</para>
                /// </summary>
                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                /// <summary>
                /// <para>The secondary zone 2 of the instance in the multi-zone deployment. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>cn-hangzhou-g</b>: Hangzhou Zone G</description></item>
                /// <item><description><b>cn-hangzhou-h</b>: Hangzhou Zone H</description></item>
                /// <item><description><b>cn-hangzhou-i</b>: Hangzhou Zone I</description></item>
                /// <item><description><b>cn-hongkong-b</b>: Hong Kong Zone B</description></item>
                /// <item><description><b>cn-hongkong-c</b>: Hong Kong Zone C</description></item>
                /// <item><description><b>cn-hongkong-d</b>: Hong Kong Zone D</description></item>
                /// <item><description><b>cn-wulanchabu-a</b>: Ulanqab Zone A</description></item>
                /// <item><description><b>cn-wulanchabu-b</b>: Ulanqab Zone B</description></item>
                /// <item><description><b>cn-wulanchabu-c</b>: Ulanqab Zone C</description></item>
                /// <item><description><b>ap-southeast-1a</b>: Singapore Zone A</description></item>
                /// <item><description><b>ap-southeast-1b</b>: Singapore Zone B</description></item>
                /// <item><description><b>ap-southeast-1c</b>: Singapore Zone C</description></item>
                /// <item><description><b>ap-southeast-5a</b>: Jakarta Zone A</description></item>
                /// <item><description><b>ap-southeast-5b</b>: Jakarta Zone B</description></item>
                /// <item><description><b>ap-southeast-5c</b>: Jakarta Zone C</description></item>
                /// <item><description><b>eu-central-1a</b>: Frankfurt Zone A</description></item>
                /// <item><description><b>eu-central-1b</b>: Frankfurt Zone B</description></item>
                /// <item><description><b>eu-central-1c</b>: Frankfurt Zone C</description></item>
                /// </list>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>This parameter is returned only when the instance is a replica set or sharded cluster instance that runs MongoDB 4.4 or 5.0 and uses the multi-zone deployment.</description></item>
                /// <item><description>This parameter is returned only if you use the China site (aliyun.com).</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-h</para>
                /// </summary>
                [NameInMap("HiddenZoneId")]
                [Validation(Required=false)]
                public string HiddenZoneId { get; set; }

                /// <summary>
                /// <para>The kind code of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: physical machine</description></item>
                /// <item><description><b>1</b>: Elastic Compute Service (ECS) instance</description></item>
                /// <item><description><b>2</b>: Docker cluster</description></item>
                /// <item><description><b>18</b>: Kubernetes cluster</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("KindCode")]
                [Validation(Required=false)]
                public string KindCode { get; set; }

                /// <summary>
                /// <para>The date when the last downgrade operation was performed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-05-08</para>
                /// </summary>
                [NameInMap("LastDowngradeTime")]
                [Validation(Required=false)]
                public string LastDowngradeTime { get; set; }

                /// <summary>
                /// <para>The lock status of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Unlock</b>: The cluster is unlocked.</description></item>
                /// <item><description><b>ManualLock</b>: The instance is manually locked.</description></item>
                /// <item><description><b>LockByExpiration</b>: The instance is automatically locked due to instance expiration.</description></item>
                /// <item><description><b>LockByRestoration</b>: The instance is automatically locked before it is rolled back.</description></item>
                /// <item><description><b>LockByDiskQuota</b>: The instance is automatically locked after the storage space is exhausted.</description></item>
                /// <item><description><b>Released</b>: The instance is released. After an instance is released, the instance cannot be unlocked. You can only restore the backup data of the instance to a new instance. This process requires a long period of time.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Unlock</para>
                /// </summary>
                [NameInMap("LockMode")]
                [Validation(Required=false)]
                public string LockMode { get; set; }

                /// <summary>
                /// <para>The details of the mongos node.</para>
                /// <remarks>
                /// <para> This parameter is returned if the instance is a sharded cluster instance.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("MongosList")]
                [Validation(Required=false)]
                public DescribeDBInstancesResponseBodyDBInstancesDBInstanceMongosList MongosList { get; set; }
                public class DescribeDBInstancesResponseBodyDBInstancesDBInstanceMongosList : TeaModel {
                    [NameInMap("MongosAttribute")]
                    [Validation(Required=false)]
                    public List<DescribeDBInstancesResponseBodyDBInstancesDBInstanceMongosListMongosAttribute> MongosAttribute { get; set; }
                    public class DescribeDBInstancesResponseBodyDBInstancesDBInstanceMongosListMongosAttribute : TeaModel {
                        /// <summary>
                        /// <para>The instance type of the mongos node.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>dds.mongos.standard</para>
                        /// </summary>
                        [NameInMap("NodeClass")]
                        [Validation(Required=false)]
                        public string NodeClass { get; set; }

                        /// <summary>
                        /// <para>The description of the mongos node.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>testmongosnode</para>
                        /// </summary>
                        [NameInMap("NodeDescription")]
                        [Validation(Required=false)]
                        public string NodeDescription { get; set; }

                        /// <summary>
                        /// <para>The ID of the mongos node.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>s-bp10e3b0d02f****</para>
                        /// </summary>
                        [NameInMap("NodeId")]
                        [Validation(Required=false)]
                        public string NodeId { get; set; }

                    }

                }

                /// <summary>
                /// <para>The network type of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Classic</b>: classic network</description></item>
                /// <item><description><b>VPC</b>: VPC</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Classic</para>
                /// </summary>
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                /// <summary>
                /// <para>The region ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The time when the instance was released.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-06-17T07:01Z</para>
                /// </summary>
                [NameInMap("ReleaseTime")]
                [Validation(Required=false)]
                public string ReleaseTime { get; set; }

                /// <summary>
                /// <para>The number of nodes in the instance.</para>
                /// <remarks>
                /// <para> This parameter is returned if the instance is a replica set instance.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("ReplicationFactor")]
                [Validation(Required=false)]
                public string ReplicationFactor { get; set; }

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
                /// <para>The secondary zone 1 of the instance in the multi-zone deployment. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>cn-hangzhou-g</b>: Hangzhou Zone G</description></item>
                /// <item><description><b>cn-hangzhou-h</b>: Hangzhou Zone H</description></item>
                /// <item><description><b>cn-hangzhou-i</b>: Hangzhou Zone I</description></item>
                /// <item><description><b>cn-hongkong-b</b>: Hong Kong Zone B</description></item>
                /// <item><description><b>cn-hongkong-c</b>: Hong Kong Zone C</description></item>
                /// <item><description><b>cn-hongkong-d</b>: Hong Kong Zone D</description></item>
                /// <item><description><b>cn-wulanchabu-a</b>: Ulanqab Zone A</description></item>
                /// <item><description><b>cn-wulanchabu-b</b>: Ulanqab Zone B</description></item>
                /// <item><description><b>cn-wulanchabu-c</b>: Ulanqab Zone C</description></item>
                /// <item><description><b>ap-southeast-1a</b>: Singapore Zone A</description></item>
                /// <item><description><b>ap-southeast-1b</b>: Singapore Zone B</description></item>
                /// <item><description><b>ap-southeast-1c</b>: Singapore Zone C</description></item>
                /// <item><description><b>ap-southeast-5a</b>: Jakarta Zone A</description></item>
                /// <item><description><b>ap-southeast-5b</b>: Jakarta Zone B</description></item>
                /// <item><description><b>ap-southeast-5c</b>: Jakarta Zone C</description></item>
                /// <item><description><b>eu-central-1a</b>: Frankfurt Zone A</description></item>
                /// <item><description><b>eu-central-1b</b>: Frankfurt Zone B</description></item>
                /// <item><description><b>eu-central-1c</b>: Frankfurt Zone C</description></item>
                /// </list>
                /// <remarks>
                /// <list type="bullet">
                /// <item><description>This parameter is returned only when the instance is a replica set or sharded cluster instance that runs MongoDB 4.4 or 5.0 and uses the multi-zone deployment.</description></item>
                /// <item><description>This parameter is returned only if you use the China site (aliyun.com).</description></item>
                /// </list>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-i</para>
                /// </summary>
                [NameInMap("SecondaryZoneId")]
                [Validation(Required=false)]
                public string SecondaryZoneId { get; set; }

                /// <summary>
                /// <para>The details of the shard node.</para>
                /// <remarks>
                /// <para> This parameter is returned if the instance is a sharded cluster instance.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("ShardList")]
                [Validation(Required=false)]
                public DescribeDBInstancesResponseBodyDBInstancesDBInstanceShardList ShardList { get; set; }
                public class DescribeDBInstancesResponseBodyDBInstancesDBInstanceShardList : TeaModel {
                    [NameInMap("ShardAttribute")]
                    [Validation(Required=false)]
                    public List<DescribeDBInstancesResponseBodyDBInstancesDBInstanceShardListShardAttribute> ShardAttribute { get; set; }
                    public class DescribeDBInstancesResponseBodyDBInstancesDBInstanceShardListShardAttribute : TeaModel {
                        /// <summary>
                        /// <para>The instance type of the shard node.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>dds.shard.mid</para>
                        /// </summary>
                        [NameInMap("NodeClass")]
                        [Validation(Required=false)]
                        public string NodeClass { get; set; }

                        /// <summary>
                        /// <para>The description of the shard node.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>testshardnode</para>
                        /// </summary>
                        [NameInMap("NodeDescription")]
                        [Validation(Required=false)]
                        public string NodeDescription { get; set; }

                        /// <summary>
                        /// <para>The ID of the shard node.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>d-bp1cac6f2083****</para>
                        /// </summary>
                        [NameInMap("NodeId")]
                        [Validation(Required=false)]
                        public string NodeId { get; set; }

                        /// <summary>
                        /// <para>The storage capacity of the shard node. Unit: GB.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>10</para>
                        /// </summary>
                        [NameInMap("NodeStorage")]
                        [Validation(Required=false)]
                        public int? NodeStorage { get; set; }

                        /// <summary>
                        /// <para>The number of read-only nodes in the shard node. Valid values: <b>0</b> to <b>5</b>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>2</para>
                        /// </summary>
                        [NameInMap("ReadonlyReplicas")]
                        [Validation(Required=false)]
                        public int? ReadonlyReplicas { get; set; }

                    }

                }

                /// <summary>
                /// <para>The storage type of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>cloud_essd</b>: Enterprise SSD (ESSD)</description></item>
                /// <item><description><b>local_ssd</b>: local SSD</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>local_ssd</para>
                /// </summary>
                [NameInMap("StorageType")]
                [Validation(Required=false)]
                public string StorageType { get; set; }

                /// <summary>
                /// <para>The details of the tag.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeDBInstancesResponseBodyDBInstancesDBInstanceTags Tags { get; set; }
                public class DescribeDBInstancesResponseBodyDBInstancesDBInstanceTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeDBInstancesResponseBodyDBInstancesDBInstanceTagsTag> Tag { get; set; }
                    public class DescribeDBInstancesResponseBodyDBInstancesDBInstanceTagsTag : TeaModel {
                        /// <summary>
                        /// <para>The tag key.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The tag value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>api</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>Indicates whether password-free access over virtual private cloud (VPC) is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Open</b>: Password-free access over VPC is enabled.</description></item>
                /// <item><description><b>Close</b>: Password-free access over VPC is disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Close</para>
                /// </summary>
                [NameInMap("VpcAuthMode")]
                [Validation(Required=false)]
                public string VpcAuthMode { get; set; }

                /// <summary>
                /// <para>The zone ID of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-g</para>
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
        /// <para>The number of entries returned on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0E4FE33F-5510-5758-8FA7-A6672CDE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of instances in the query results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
