// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeDBInstancesOverviewResponseBody : TeaModel {
        /// <summary>
        /// <para>The information of instances.</para>
        /// </summary>
        [NameInMap("DBInstances")]
        [Validation(Required=false)]
        public List<DescribeDBInstancesOverviewResponseBodyDBInstances> DBInstances { get; set; }
        public class DescribeDBInstancesOverviewResponseBodyDBInstances : TeaModel {
            /// <summary>
            /// <para>The read and write throughput consumed by the instance.</para>
            /// <remarks>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description><para>This parameter is returned when the instance is a serverless instance.</para>
            /// </description></item>
            /// <item><description><para>Serverless instances are available only in the China site (aliyun.com).</para>
            /// </description></item>
            /// </list>
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
            /// <item><description><b>PostPaid</b>: pay-as-you-go</description></item>
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
            /// <para>2022-01-05T03:18:53Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The instance type. The instance type varies based on the instance architecture. For more information about instance types supported by different instance architectures, see the following references:</para>
            /// <list type="bullet">
            /// <item><description><a href="https://help.aliyun.com/document_detail/311407.html">Standalone instance types</a></description></item>
            /// <item><description><a href="https://help.aliyun.com/document_detail/311410.html">Replica set instance types</a></description></item>
            /// <item><description><a href="https://help.aliyun.com/document_detail/311414.html">Sharded cluster instance types</a></description></item>
            /// </list>
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
            /// <para>test db</para>
            /// </summary>
            [NameInMap("DBInstanceDescription")]
            [Validation(Required=false)]
            public string DBInstanceDescription { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dds-bp12c5b040dc****</para>
            /// </summary>
            [NameInMap("DBInstanceId")]
            [Validation(Required=false)]
            public string DBInstanceId { get; set; }

            /// <summary>
            /// <para>The state of the instance. For more information about valid values, see <a href="https://help.aliyun.com/document_detail/63870.html">Instance states</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("DBInstanceStatus")]
            [Validation(Required=false)]
            public string DBInstanceStatus { get; set; }

            /// <summary>
            /// <para>The storage space of the instance. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("DBInstanceStorage")]
            [Validation(Required=false)]
            public int? DBInstanceStorage { get; set; }

            /// <summary>
            /// <para>The architecture of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>sharding</b>: sharded cluster instance</description></item>
            /// <item><description><b>replicate</b>: replica set or standalone instance</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>replicate</para>
            /// </summary>
            [NameInMap("DBInstanceType")]
            [Validation(Required=false)]
            public string DBInstanceType { get; set; }

            /// <summary>
            /// <para>The time when the instance data was destroyed. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-10T16:00:00Z</para>
            /// </summary>
            [NameInMap("DestroyTime")]
            [Validation(Required=false)]
            public string DestroyTime { get; set; }

            /// <summary>
            /// <para>The database engine of the instance. Set the value to <b>MongoDB</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MongoDB</para>
            /// </summary>
            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            /// <summary>
            /// <para>The database engine version of the instance.</para>
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
            /// <para>2022-02-05T16:00Z</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

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
            /// <para>0</para>
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
            /// <para>Indicates whether the instance is locked. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Unlock</b>: The instance is not locked.</description></item>
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
            /// <para>The details of the mongos nodes.</para>
            /// <remarks>
            /// <para> This parameter is returned when the instance is a sharded cluster instance.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("MongosList")]
            [Validation(Required=false)]
            public List<DescribeDBInstancesOverviewResponseBodyDBInstancesMongosList> MongosList { get; set; }
            public class DescribeDBInstancesOverviewResponseBodyDBInstancesMongosList : TeaModel {
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
                /// <para>mongos node describe.</para>
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

            /// <summary>
            /// <para>The network type of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Classic</b></description></item>
            /// <item><description><b>VPC</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>VPC</para>
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
            /// <para>The number of nodes in the instance.</para>
            /// <remarks>
            /// <para> This parameter is returned when the instance is a replica set instance.</para>
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
            /// <para>rg-acfm22cdcgc****</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The details of the shard nodes.</para>
            /// <remarks>
            /// <para> This parameter is returned when the instance is a sharded cluster instance.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("ShardList")]
            [Validation(Required=false)]
            public List<DescribeDBInstancesOverviewResponseBodyDBInstancesShardList> ShardList { get; set; }
            public class DescribeDBInstancesOverviewResponseBodyDBInstancesShardList : TeaModel {
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
                /// <para>testshard</para>
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
                /// <para>The storage space of the shard node. Unit: GB.</para>
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

            /// <summary>
            /// <para>The tags to add to the instance.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeDBInstancesOverviewResponseBodyDBInstancesTags> Tags { get; set; }
            public class DescribeDBInstancesOverviewResponseBodyDBInstancesTags : TeaModel {
                /// <summary>
                /// <para>The tag key. Valid values of N: <b>1</b> to <b>20</b>.</para>
                /// <list type="bullet">
                /// <item><description>The key cannot start with <c>aliyun</c>, <c>acs:</c>, <c>http://</c>, or <c>https://</c>.</description></item>
                /// <item><description>It can be up to 64 characters in length.</description></item>
                /// <item><description>It cannot be an empty string.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>testdatabase</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value. Valid values of N: <b>1</b> to <b>20</b>.</para>
                /// <list type="bullet">
                /// <item><description>The value cannot start with <c>aliyun</c>, <c>acs:</c>, <c>http://</c>, or <c>https://</c>.</description></item>
                /// <item><description>The value can be up to 128 characters in length.</description></item>
                /// <item><description>The value can be an empty string.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>apitest</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether password-free access over VPC is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Open</b>: Password-free access over VPC is enabled.</description></item>
            /// <item><description><b>Close</b>: Password-free access over VPC is disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Open</para>
            /// </summary>
            [NameInMap("VpcAuthMode")]
            [Validation(Required=false)]
            public string VpcAuthMode { get; set; }

            /// <summary>
            /// <para>The zone ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-i</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>52820D2B-B2DD-59F0-BDF2-83EC19C6F1CA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of instances in the query results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
