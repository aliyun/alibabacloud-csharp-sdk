// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeDBInstancesOverviewResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of instances.</para>
        /// </summary>
        [NameInMap("DBInstances")]
        [Validation(Required=false)]
        public List<DescribeDBInstancesOverviewResponseBodyDBInstances> DBInstances { get; set; }
        public class DescribeDBInstancesOverviewResponseBodyDBInstances : TeaModel {
            /// <summary>
            /// <para>The read and write throughput consumed by the instance.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>This parameter is returned only if the instance is a serverless instance.</description></item>
            /// <item><description>Serverless instances are supported only on the Alibaba Cloud China site.</description></item>
            /// </list>
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
            /// <item><description><b>PrePaid</b>: subscription.</description></item>
            /// <item><description><b>PostPaid</b>: pay-as-you-go.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PrePaid</para>
            /// </summary>
            [NameInMap("ChargeType")]
            [Validation(Required=false)]
            public string ChargeType { get; set; }

            /// <summary>
            /// <para>The time when the instance was created. The time is displayed in UTC in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-01-05T03:18:53Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The instance type. For more information about the instance types of different architectures, see the following topics:</para>
            /// <list type="bullet">
            /// <item><description><a href="https://help.aliyun.com/document_detail/311407.html">Standalone instance types</a></description></item>
            /// <item><description><a href="https://help.aliyun.com/document_detail/311410.html">Replica set instance types</a></description></item>
            /// <item><description><a href="https://help.aliyun.com/document_detail/311414.html">Sharded cluster instance types</a></description></item>
            /// </list>
            /// <para>&lt;props=&quot;china&quot;&gt;</para>
            /// <remarks>
            /// <para>You do not need to specify this parameter for serverless instances.</para>
            /// </remarks>
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
            /// <para>dds-bp12c5b040dc****</para>
            /// </summary>
            [NameInMap("DBInstanceId")]
            [Validation(Required=false)]
            public string DBInstanceId { get; set; }

            /// <summary>
            /// <para>The status of the instance. For more information, see <a href="https://help.aliyun.com/document_detail/63870.html">Instance statuses</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("DBInstanceStatus")]
            [Validation(Required=false)]
            public string DBInstanceStatus { get; set; }

            /// <summary>
            /// <para>The storage capacity of the instance. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("DBInstanceStorage")]
            [Validation(Required=false)]
            public int? DBInstanceStorage { get; set; }

            /// <summary>
            /// <para>The architecture of the instance. Valid values: </para>
            /// <list type="bullet">
            /// <item><description><b>sharding</b>: sharded cluster instance.</description></item>
            /// <item><description><b>replicate</b>: replica set or standalone instance.
            /// &lt;props=&quot;china&quot;&gt;</description></item>
            /// <item><description><b>serverless</b>: serverless instance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>replicate</para>
            /// </summary>
            [NameInMap("DBInstanceType")]
            [Validation(Required=false)]
            public string DBInstanceType { get; set; }

            /// <summary>
            /// <para>The data destruction time of the instance. The time is displayed in UTC in the yyyy-MM-ddTHH:mm:ssZ format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-10T16:00:00Z</para>
            /// </summary>
            [NameInMap("DestroyTime")]
            [Validation(Required=false)]
            public string DestroyTime { get; set; }

            /// <summary>
            /// <para>The database engine. The value is <b>MongoDB</b>.</para>
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
            /// <para>The time when the instance expires. The time is displayed in UTC in the <i>yyyy-MM-dd</i>T<i>HH:mm</i>Z format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-02-05T16:00Z</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <para>The type of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: physical machine</description></item>
            /// <item><description><b>1</b>: ECS</description></item>
            /// <item><description><b>2</b>: Docker</description></item>
            /// <item><description><b>18</b>: new Kubernetes architecture instance</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("KindCode")]
            [Validation(Required=false)]
            public string KindCode { get; set; }

            /// <summary>
            /// <para>The time when the instance was last downgraded. The date is in the YYYY-MM-DD format, such as 2021-05-08.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-05-08</para>
            /// </summary>
            [NameInMap("LastDowngradeTime")]
            [Validation(Required=false)]
            public string LastDowngradeTime { get; set; }

            /// <summary>
            /// <para>The lock status of the instance.</para>
            /// <list type="bullet">
            /// <item><description><b>Unlock</b>: The instance is not locked.</description></item>
            /// <item><description><b>ManualLock</b>: The instance is manually locked.</description></item>
            /// <item><description><b>LockByExpiration</b>: The instance is automatically locked after it expires.</description></item>
            /// <item><description><b>LockByRestoration</b>: The instance is automatically locked before a rollback.</description></item>
            /// <item><description><b>LockByDiskQuota</b>: The instance is automatically locked because its storage capacity is exhausted.</description></item>
            /// <item><description><b>Released</b>: The instance is released. In this case, you cannot unlock the instance. You can only use backup data to create a new instance. The recreation process may take a long time.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Unlock</para>
            /// </summary>
            [NameInMap("LockMode")]
            [Validation(Required=false)]
            public string LockMode { get; set; }

            /// <summary>
            /// <para>The list of mongos nodes.</para>
            /// <remarks>
            /// <para>This parameter is returned only if the instance is a sharded cluster instance.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("MongosList")]
            [Validation(Required=false)]
            public List<DescribeDBInstancesOverviewResponseBodyDBInstancesMongosList> MongosList { get; set; }
            public class DescribeDBInstancesOverviewResponseBodyDBInstancesMongosList : TeaModel {
                /// <summary>
                /// <para>The node specifications of the mongos node.</para>
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
                /// <para>Test mongos node</para>
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
            /// <item><description><b>Classic</b>: classic network.</description></item>
            /// <item><description><b>VPC</b>: VPC.</description></item>
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
            /// <para>This parameter is returned only if the instance is a replica set instance.</para>
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
            /// <para>The list of shard nodes.</para>
            /// <remarks>
            /// <para>This parameter is returned only if the instance is a sharded cluster instance.</para>
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
                /// <para>Test shard node</para>
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

            /// <summary>
            /// <para>The tags of the instance.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeDBInstancesOverviewResponseBodyDBInstancesTags> Tags { get; set; }
            public class DescribeDBInstancesOverviewResponseBodyDBInstancesTags : TeaModel {
                /// <summary>
                /// <para>The tag key of the instance. Valid values of N: <b>1</b> to <b>20</b>.</para>
                /// <list type="bullet">
                /// <item><description>The tag key cannot start with <c>aliyun</c>, <c>acs:</c>, <c>http://</c>, or <c>https://</c>.</description></item>
                /// <item><description>The tag key can be up to 64 characters in length.</description></item>
                /// <item><description>The tag key cannot be an empty string.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>testdatabase</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value of the instance. Valid values of N: <b>1</b> to <b>20</b>.</para>
                /// <list type="bullet">
                /// <item><description>The tag value cannot start with <c>aliyun</c>, <c>acs:</c>, <c>http://</c>, or <c>https://</c>.</description></item>
                /// <item><description>The tag value can be up to 128 characters in length.</description></item>
                /// <item><description>The tag value can be an empty string.</description></item>
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
            /// <para>Indicates whether password-free access within a VPC is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Open</b>: enabled.</description></item>
            /// <item><description><b>Close</b>: disabled.</description></item>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>52820D2B-B2DD-59F0-BDF2-83EC19C6F1CA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of instances returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
