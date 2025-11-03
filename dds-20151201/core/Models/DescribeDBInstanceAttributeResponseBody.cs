// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class DescribeDBInstanceAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The instance details.</para>
        /// </summary>
        [NameInMap("DBInstances")]
        [Validation(Required=false)]
        public DescribeDBInstanceAttributeResponseBodyDBInstances DBInstances { get; set; }
        public class DescribeDBInstanceAttributeResponseBodyDBInstances : TeaModel {
            [NameInMap("DBInstance")]
            [Validation(Required=false)]
            public List<DescribeDBInstanceAttributeResponseBodyDBInstancesDBInstance> DBInstance { get; set; }
            public class DescribeDBInstanceAttributeResponseBodyDBInstancesDBInstance : TeaModel {
                /// <summary>
                /// <para>Indicates whether performance burst is enabled for the ESSD AutoPL disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("BurstingEnabled")]
                [Validation(Required=false)]
                public bool? BurstingEnabled { get; set; }

                /// <summary>
                /// <para>The read and write throughput consumed by the instance.</para>
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
                /// <para>PostPaid</para>
                /// </summary>
                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                /// <summary>
                /// <para>The details of the ConfigServer node.</para>
                /// <remarks>
                /// <para> This parameter is returned if the instance is a sharded cluster instance.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("ConfigserverList")]
                [Validation(Required=false)]
                public DescribeDBInstanceAttributeResponseBodyDBInstancesDBInstanceConfigserverList ConfigserverList { get; set; }
                public class DescribeDBInstanceAttributeResponseBodyDBInstancesDBInstanceConfigserverList : TeaModel {
                    [NameInMap("ConfigserverAttribute")]
                    [Validation(Required=false)]
                    public List<DescribeDBInstanceAttributeResponseBodyDBInstancesDBInstanceConfigserverListConfigserverAttribute> ConfigserverAttribute { get; set; }
                    public class DescribeDBInstanceAttributeResponseBodyDBInstancesDBInstanceConfigserverListConfigserverAttribute : TeaModel {
                        /// <summary>
                        /// <para>The endpoint of the Configserver node.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>dds-bp18b0934e7053e4-cs****.mongodb.rds.aliyuncs.com</para>
                        /// </summary>
                        [NameInMap("ConnectString")]
                        [Validation(Required=false)]
                        public string ConnectString { get; set; }

                        /// <summary>
                        /// <para>The minor version of the current MongoDB kernel.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>mongodb_20230613_4.0.25</para>
                        /// </summary>
                        [NameInMap("CurrentKernelVersion")]
                        [Validation(Required=false)]
                        public string CurrentKernelVersion { get; set; }

                        /// <summary>
                        /// <para>The lock status of the Configserver node. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>Unlock</b>: The instance is not locked.</description></item>
                        /// <item><description><b>ManualLock</b>: The instance is manually locked.</description></item>
                        /// <item><description><b>LockByExpiration</b>: The instance is automatically locked due to instance expiration.</description></item>
                        /// <item><description><b>LockByRestoration</b>: The instance is automatically locked before a rollback.</description></item>
                        /// <item><description><b>LockByDiskQuota</b>: The instance is automatically locked because its storage capacity is exhausted and the instance is inaccessible.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Unlock</para>
                        /// </summary>
                        [NameInMap("LockMode")]
                        [Validation(Required=false)]
                        public string LockMode { get; set; }

                        /// <summary>
                        /// <para>The maximum number of connections to the Configserver node.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1000</para>
                        /// </summary>
                        [NameInMap("MaxConnections")]
                        [Validation(Required=false)]
                        public int? MaxConnections { get; set; }

                        /// <summary>
                        /// <para>The maximum IOPS of the Configserver node.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1000</para>
                        /// </summary>
                        [NameInMap("MaxIOPS")]
                        [Validation(Required=false)]
                        public int? MaxIOPS { get; set; }

                        /// <summary>
                        /// <para>The instance type of the Configserver node.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>dds.cs.mid</para>
                        /// </summary>
                        [NameInMap("NodeClass")]
                        [Validation(Required=false)]
                        public string NodeClass { get; set; }

                        /// <summary>
                        /// <para>The name of the Configserver node.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>testConfigserver</para>
                        /// </summary>
                        [NameInMap("NodeDescription")]
                        [Validation(Required=false)]
                        public string NodeDescription { get; set; }

                        /// <summary>
                        /// <para>The ID of the Configserver node.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>dds-bp11483712c1****-cs</para>
                        /// </summary>
                        [NameInMap("NodeId")]
                        [Validation(Required=false)]
                        public string NodeId { get; set; }

                        /// <summary>
                        /// <para>The storage capacity of the Configserver node. Unit: GB.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>20</para>
                        /// </summary>
                        [NameInMap("NodeStorage")]
                        [Validation(Required=false)]
                        public int? NodeStorage { get; set; }

                        /// <summary>
                        /// <para>The port number that is used to connect to the Configserver node.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3717</para>
                        /// </summary>
                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public int? Port { get; set; }

                        /// <summary>
                        /// <para>The status of the Configserver node. For more information, see <a href="https://help.aliyun.com/document_detail/63870.html">Instance states</a>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Running</para>
                        /// </summary>
                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                    }

                }

                /// <summary>
                /// <para>The time when the instance was created. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-01-02T07:43:59Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The minor version of the current database in the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5.0.5-20220721143518_0</para>
                /// </summary>
                [NameInMap("CurrentKernelVersion")]
                [Validation(Required=false)]
                public string CurrentKernelVersion { get; set; }

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
                /// <para>The name of the instance.</para>
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
                /// <para>dds-bp11483712c1****</para>
                /// </summary>
                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                /// <summary>
                /// <para>The status of the orders generated for the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>all_completed</b>: All orders are being produced or complete.</description></item>
                /// <item><description><b>order_unpaid</b>: The instance has unpaid orders.</description></item>
                /// <item><description><b>order_wait_for_produce</b>: Orders are being delivered for production.</description></item>
                /// </list>
                /// <remarks>
                /// <para> The order production process includes the following steps: place an order, pay for an order, deliver an order for production, produce an order, and complete the production.</para>
                /// </remarks>
                /// <list type="bullet">
                /// <item><description>If an order is in the <b>order_wait_for_produce</b> state for a long time, an error occurs when the order is being delivered for production. The system will automatically retry.</description></item>
                /// <item><description>The instance status changes only when the order is in the producing and complete state, such as changing configurations and running.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>all_completed</para>
                /// </summary>
                [NameInMap("DBInstanceOrderStatus")]
                [Validation(Required=false)]
                public string DBInstanceOrderStatus { get; set; }

                /// <summary>
                /// <para>Indicates whether release protection is enabled for the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("DBInstanceReleaseProtection")]
                [Validation(Required=false)]
                public bool? DBInstanceReleaseProtection { get; set; }

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
                /// <para>10</para>
                /// </summary>
                [NameInMap("DBInstanceStorage")]
                [Validation(Required=false)]
                public int? DBInstanceStorage { get; set; }

                /// <summary>
                /// <para>The architecture of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>replicate</b>: replica set instance</description></item>
                /// <item><description><b>sharding</b>: sharded cluster instance</description></item>
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

                [NameInMap("DisasterRecoveryInfo")]
                [Validation(Required=false)]
                public string DisasterRecoveryInfo { get; set; }

                /// <summary>
                /// <para>Indicates whether disk encryption is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("Encrypted")]
                [Validation(Required=false)]
                public bool? Encrypted { get; set; }

                /// <summary>
                /// <para>The Key Management Service (KMS) key used for disk encryption.</para>
                /// 
                /// <b>Example:</b>
                /// <para>07609cc3-3109-408f-a35e-c548e776da0b</para>
                /// </summary>
                [NameInMap("EncryptionKey")]
                [Validation(Required=false)]
                public string EncryptionKey { get; set; }

                /// <summary>
                /// <para>The database engine of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MongoDB</para>
                /// </summary>
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                /// <summary>
                /// <para>The database engine version of the instance.</para>
                /// <list type="bullet">
                /// <item><description><b>6.0</b></description></item>
                /// <item><description><b>5.0</b></description></item>
                /// <item><description><b>4.4</b></description></item>
                /// <item><description><b>4.2</b></description></item>
                /// <item><description><b>4.0</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>4.4</para>
                /// </summary>
                [NameInMap("EngineVersion")]
                [Validation(Required=false)]
                public string EngineVersion { get; set; }

                /// <summary>
                /// <para>The time when the subscription instance expires. The time follows the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm</em>Z format. The time is displayed in UTC.</para>
                /// <remarks>
                /// <para> This parameter is returned if the instance is a subscription instance.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2022-02-05T16:00Z</para>
                /// </summary>
                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                /// <summary>
                /// <para>The ID of the secondary zone 2 of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>cn-hangzhou-g</b>: Hangzhou Zone G</description></item>
                /// <item><description><b>cn-hangzhou-h</b>: Hangzhou Zone H</description></item>
                /// <item><description><b>cn-hangzhou-i</b>: Hangzhou Zone I</description></item>
                /// <item><description><b>cn-hongkong-b</b>: Hongkong Zone B</description></item>
                /// <item><description><b>cn-hongkong-c</b>: Hongkong Zone C</description></item>
                /// <item><description><b>cn-hongkong-d</b>: Hongkong Zone D</description></item>
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
                /// </remarks>
                /// <list type="bullet">
                /// <item><description><para>This parameter is returned if the instance is a replica set or sharded cluster instance that runs MongoDB 4.4 or 5.0 and uses multi-zone deployment.</para>
                /// </description></item>
                /// <item><description><para>This parameter is returned only if you use the China site (aliyun.com).</para>
                /// </description></item>
                /// </list>
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
                /// <para>The date when the last downgrade operation was performed on the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-01-08</para>
                /// </summary>
                [NameInMap("LastDowngradeTime")]
                [Validation(Required=false)]
                public string LastDowngradeTime { get; set; }

                /// <summary>
                /// <para>The lock status of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Unlock</b>: The instance is not locked.</description></item>
                /// <item><description><b>ManualLock</b>: The instance is manually locked.</description></item>
                /// <item><description><b>LockByExpiration</b>: The instance is automatically locked due to instance expiration.</description></item>
                /// <item><description><b>LockByRestoration</b>: The instance is automatically locked before the instance is rolled back.</description></item>
                /// <item><description><b>LockByDiskQuota</b>: The instance is automatically locked after the storage space is exhausted.</description></item>
                /// <item><description><b>Released</b>: The instance is released.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Unlock</para>
                /// </summary>
                [NameInMap("LockMode")]
                [Validation(Required=false)]
                public string LockMode { get; set; }

                /// <summary>
                /// <para>The end time of the maintenance window. The time follows the ISO 8601 standard in the <em>HH:mm</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>03:00Z</para>
                /// </summary>
                [NameInMap("MaintainEndTime")]
                [Validation(Required=false)]
                public string MaintainEndTime { get; set; }

                /// <summary>
                /// <para>The start time of the maintenance window. The time follows the ISO 8601 standard in the <em>HH:mm</em>Z format. The time is displayed in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>18:00Z</para>
                /// </summary>
                [NameInMap("MaintainStartTime")]
                [Validation(Required=false)]
                public string MaintainStartTime { get; set; }

                /// <summary>
                /// <para>The maximum number of connections to the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("MaxConnections")]
                [Validation(Required=false)]
                public int? MaxConnections { get; set; }

                /// <summary>
                /// <para>The maximum IOPS of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("MaxIOPS")]
                [Validation(Required=false)]
                public int? MaxIOPS { get; set; }

                /// <summary>
                /// <para>The maximum MBPS of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>350</para>
                /// </summary>
                [NameInMap("MaxMBPS")]
                [Validation(Required=false)]
                public int? MaxMBPS { get; set; }

                /// <summary>
                /// <para>The details of the mongos node.</para>
                /// <remarks>
                /// <para> This parameter is returned if the instance is a sharded cluster instance.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("MongosList")]
                [Validation(Required=false)]
                public DescribeDBInstanceAttributeResponseBodyDBInstancesDBInstanceMongosList MongosList { get; set; }
                public class DescribeDBInstanceAttributeResponseBodyDBInstancesDBInstanceMongosList : TeaModel {
                    [NameInMap("MongosAttribute")]
                    [Validation(Required=false)]
                    public List<DescribeDBInstanceAttributeResponseBodyDBInstancesDBInstanceMongosListMongosAttribute> MongosAttribute { get; set; }
                    public class DescribeDBInstanceAttributeResponseBodyDBInstancesDBInstanceMongosListMongosAttribute : TeaModel {
                        /// <summary>
                        /// <para>The endpoint of the mongos node.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>s-bp1d8c262a15****.mongodb.rds.aliyuncs.com</para>
                        /// </summary>
                        [NameInMap("ConnectSting")]
                        [Validation(Required=false)]
                        public string ConnectSting { get; set; }

                        /// <summary>
                        /// <para>The endpoint of the mongos node.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>s-bp1d8c262a15****.mongodb.rds.aliyuncs.com</para>
                        /// </summary>
                        [NameInMap("ConnectString")]
                        [Validation(Required=false)]
                        public string ConnectString { get; set; }

                        /// <summary>
                        /// <para>The minor version of the current MongoDB kernel.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>mongodb_20220518_4.0.21</para>
                        /// </summary>
                        [NameInMap("CurrentKernelVersion")]
                        [Validation(Required=false)]
                        public string CurrentKernelVersion { get; set; }

                        /// <summary>
                        /// <para>The lock status of the instance. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>Unlock</b>: The instance is not locked.</description></item>
                        /// <item><description><b>ManualLock</b>: The instance is manually locked.</description></item>
                        /// <item><description><b>LockByExpiration</b>: The instance is automatically locked due to instance expiration.</description></item>
                        /// <item><description><b>LockByRestoration</b>: The instance is automatically locked before a rollback.</description></item>
                        /// <item><description><b>LockByDiskQuota</b>: The instance is automatically locked because its storage capacity is exhausted and the instance is inaccessible.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Unlock</para>
                        /// </summary>
                        [NameInMap("LockMode")]
                        [Validation(Required=false)]
                        public string LockMode { get; set; }

                        /// <summary>
                        /// <para>The maximum number of connections to the mongos node.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>1000</para>
                        /// </summary>
                        [NameInMap("MaxConnections")]
                        [Validation(Required=false)]
                        public int? MaxConnections { get; set; }

                        /// <summary>
                        /// <para>The maximum IOPS of the mongos node.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>800</para>
                        /// </summary>
                        [NameInMap("MaxIOPS")]
                        [Validation(Required=false)]
                        public int? MaxIOPS { get; set; }

                        /// <summary>
                        /// <para>The instance type of the mongos node.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>dds.mongos.mid</para>
                        /// </summary>
                        [NameInMap("NodeClass")]
                        [Validation(Required=false)]
                        public string NodeClass { get; set; }

                        /// <summary>
                        /// <para>The name of the mongos node.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>mongos1</para>
                        /// </summary>
                        [NameInMap("NodeDescription")]
                        [Validation(Required=false)]
                        public string NodeDescription { get; set; }

                        /// <summary>
                        /// <para>The ID of the mongos node.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>s-bp1d8c262a15****</para>
                        /// </summary>
                        [NameInMap("NodeId")]
                        [Validation(Required=false)]
                        public string NodeId { get; set; }

                        /// <summary>
                        /// <para>The port number that is used to connect to the mongos node.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3717</para>
                        /// </summary>
                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public int? Port { get; set; }

                        /// <summary>
                        /// <para>The status of the mongos node. For more information, see <a href="https://help.aliyun.com/document_detail/63870.html">Instance states</a>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Running</para>
                        /// </summary>
                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                        /// <summary>
                        /// <para>The VPC ID of the instance.</para>
                        /// <remarks>
                        /// <para> This parameter is returned if the network type of the instance is VPC.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>vpc-bp1n3i15v90el48nx****</para>
                        /// </summary>
                        [NameInMap("VPCId")]
                        [Validation(Required=false)]
                        public string VPCId { get; set; }

                        /// <summary>
                        /// <para>The vSwitch ID of the instance.</para>
                        /// <remarks>
                        /// <para> This parameter is returned if the network type of the instance is VPC.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>vsw-bp1vj604nj5a9zz74****</para>
                        /// </summary>
                        [NameInMap("VSwitchId")]
                        [Validation(Required=false)]
                        public string VSwitchId { get; set; }

                        /// <summary>
                        /// <para>The ID of the mongos node.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>s-bp1d8c262a158****</para>
                        /// </summary>
                        [NameInMap("VpcCloudInstanceId")]
                        [Validation(Required=false)]
                        public string VpcCloudInstanceId { get; set; }

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
                /// <para>VPC</para>
                /// </summary>
                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                /// <summary>
                /// <para>The access protocol type of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>mongodb</b></description></item>
                /// <item><description><b>dynamodb</b></description></item>
                /// </list>
                /// <remarks>
                /// <para> This parameter is returned if the instance is a sharded cluster instance.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>mongodb</para>
                /// </summary>
                [NameInMap("ProtocolType")]
                [Validation(Required=false)]
                public string ProtocolType { get; set; }

                /// <summary>
                /// <para>The provisioned performance of the ESSD AutoPL disk.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1960</para>
                /// </summary>
                [NameInMap("ProvisionedIops")]
                [Validation(Required=false)]
                public long? ProvisionedIops { get; set; }

                /// <summary>
                /// <para>The number of read-only nodes in the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ReadonlyReplicas")]
                [Validation(Required=false)]
                public string ReadonlyReplicas { get; set; }

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
                /// <para>The logical ID of the replica set instance.</para>
                /// <remarks>
                /// <para> ApsaraDB for MongoDB does not support new instances of this type. This parameter applies only to previous-version replica set instances.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>bls-m****</para>
                /// </summary>
                [NameInMap("ReplacateId")]
                [Validation(Required=false)]
                public string ReplacateId { get; set; }

                /// <summary>
                /// <para>The name of the replica set instance.</para>
                /// <remarks>
                /// <para> This parameter is returned if the instance is a replica set instance.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>mgset-10ace****</para>
                /// </summary>
                [NameInMap("ReplicaSetName")]
                [Validation(Required=false)]
                public string ReplicaSetName { get; set; }

                /// <summary>
                /// <para>The information of the replica set instance.</para>
                /// <remarks>
                /// <para> This parameter is returned if the instance is a replica set instance.</para>
                /// </remarks>
                /// </summary>
                [NameInMap("ReplicaSets")]
                [Validation(Required=false)]
                public DescribeDBInstanceAttributeResponseBodyDBInstancesDBInstanceReplicaSets ReplicaSets { get; set; }
                public class DescribeDBInstanceAttributeResponseBodyDBInstancesDBInstanceReplicaSets : TeaModel {
                    [NameInMap("ReplicaSet")]
                    [Validation(Required=false)]
                    public List<DescribeDBInstanceAttributeResponseBodyDBInstancesDBInstanceReplicaSetsReplicaSet> ReplicaSet { get; set; }
                    public class DescribeDBInstanceAttributeResponseBodyDBInstancesDBInstanceReplicaSetsReplicaSet : TeaModel {
                        /// <summary>
                        /// <para>The endpoint of the node.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>dds-bp11483712c1****.mongodb.rds.aliyuncs.com</para>
                        /// </summary>
                        [NameInMap("ConnectionDomain")]
                        [Validation(Required=false)]
                        public string ConnectionDomain { get; set; }

                        /// <summary>
                        /// <para>The port number that is used to connect to the node.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3717</para>
                        /// </summary>
                        [NameInMap("ConnectionPort")]
                        [Validation(Required=false)]
                        public string ConnectionPort { get; set; }

                        /// <summary>
                        /// <para>The network type of the instance. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>Classic</b>: classic network</description></item>
                        /// <item><description><b>VPC</b>: VPC</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>VPC</para>
                        /// </summary>
                        [NameInMap("NetworkType")]
                        [Validation(Required=false)]
                        public string NetworkType { get; set; }

                        /// <summary>
                        /// <para>The role of the node. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>Primary</b></description></item>
                        /// <item><description><b>Secondary</b></description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Primary</para>
                        /// </summary>
                        [NameInMap("ReplicaSetRole")]
                        [Validation(Required=false)]
                        public string ReplicaSetRole { get; set; }

                        /// <summary>
                        /// <para>The instance ID.</para>
                        /// <remarks>
                        /// <para> This parameter is returned if the network type of the instance is VPC.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>dds-bp11483712c1****</para>
                        /// </summary>
                        [NameInMap("VPCCloudInstanceId")]
                        [Validation(Required=false)]
                        public string VPCCloudInstanceId { get; set; }

                        /// <summary>
                        /// <para>The VPC ID of the instance.</para>
                        /// <remarks>
                        /// <para> This parameter is returned if the network type of the instance is VPC.</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>vpc-bp1jk5vwkcri27qme****</para>
                        /// </summary>
                        [NameInMap("VPCId")]
                        [Validation(Required=false)]
                        public string VPCId { get; set; }

                        /// <summary>
                        /// <para>The vSwitch ID of the instance.</para>
                        /// <remarks>
                        /// <para> This parameter is returned if the network type of the instance is virtual private cloud (VPC).</para>
                        /// </remarks>
                        /// 
                        /// <b>Example:</b>
                        /// <para>vpc-bp1jk5vwkcri27qme****</para>
                        /// </summary>
                        [NameInMap("VSwitchId")]
                        [Validation(Required=false)]
                        public string VSwitchId { get; set; }

                    }

                }

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
                /// <remarks>
                /// <para> This parameter is returned only if you use the China site (aliyun.com).</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>rg-acfmyiu4ekp****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>mdb.shard.2x.xlarge.d</para>
                /// </summary>
                [NameInMap("SearchNodeClass")]
                [Validation(Required=false)]
                public string SearchNodeClass { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("SearchNodeCount")]
                [Validation(Required=false)]
                public int? SearchNodeCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("SearchNodeStorage")]
                [Validation(Required=false)]
                public int? SearchNodeStorage { get; set; }

                /// <summary>
                /// <para>The ID of the secondary zone 1 of the instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>cn-hangzhou-g</b>: Hangzhou Zone G</description></item>
                /// <item><description><b>cn-hangzhou-h</b>: Hangzhou Zone H</description></item>
                /// <item><description><b>cn-hangzhou-i</b>: Hangzhou Zone I</description></item>
                /// <item><description><b>cn-hongkong-b</b>: Hongkong Zone B</description></item>
                /// <item><description><b>cn-hongkong-c</b>: Hongkong Zone C</description></item>
                /// <item><description><b>cn-hongkong-d</b>: Hongkong Zone D</description></item>
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
                /// </remarks>
                /// <list type="bullet">
                /// <item><description><para>This parameter is returned if the instance is a replica set or sharded cluster instance that runs MongoDB 4.4 or 5.0 and uses multi-zone deployment.</para>
                /// </description></item>
                /// <item><description><para>This parameter is returned only if you use the China site (aliyun.com).</para>
                /// </description></item>
                /// </list>
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
                public DescribeDBInstanceAttributeResponseBodyDBInstancesDBInstanceShardList ShardList { get; set; }
                public class DescribeDBInstanceAttributeResponseBodyDBInstancesDBInstanceShardList : TeaModel {
                    [NameInMap("ShardAttribute")]
                    [Validation(Required=false)]
                    public List<DescribeDBInstanceAttributeResponseBodyDBInstancesDBInstanceShardListShardAttribute> ShardAttribute { get; set; }
                    public class DescribeDBInstanceAttributeResponseBodyDBInstancesDBInstanceShardListShardAttribute : TeaModel {
                        /// <summary>
                        /// <para>The endpoint of the shard node.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>d-bp1af0680a9c6d3****.mongodb.rds.aliyuncs.com:****</para>
                        /// </summary>
                        [NameInMap("ConnectString")]
                        [Validation(Required=false)]
                        public string ConnectString { get; set; }

                        /// <summary>
                        /// <para>The minor version of the current MongoDB kernel.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>mongodb_20230613_4.0.25</para>
                        /// </summary>
                        [NameInMap("CurrentKernelVersion")]
                        [Validation(Required=false)]
                        public string CurrentKernelVersion { get; set; }

                        /// <summary>
                        /// <para>The lock status of the shard node. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>Unlock</b>: The instance is not locked.</description></item>
                        /// <item><description><b>ManualLock</b>: The instance is manually locked.</description></item>
                        /// <item><description><b>LockByExpiration</b>: The instance is automatically locked due to instance expiration.</description></item>
                        /// <item><description><b>LockByRestoration</b>: The instance is automatically locked before a rollback.</description></item>
                        /// <item><description><b>LockByDiskQuota</b>: The instance is automatically locked because its storage capacity is exhausted and the instance is inaccessible.</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Unlock</para>
                        /// </summary>
                        [NameInMap("LockMode")]
                        [Validation(Required=false)]
                        public string LockMode { get; set; }

                        /// <summary>
                        /// <para>The maximum number of connections to the shard node.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>8000</para>
                        /// </summary>
                        [NameInMap("MaxConnections")]
                        [Validation(Required=false)]
                        public int? MaxConnections { get; set; }

                        /// <summary>
                        /// <para>The maximum MBPS of the shard node.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>350</para>
                        /// </summary>
                        [NameInMap("MaxDiskMbps")]
                        [Validation(Required=false)]
                        public string MaxDiskMbps { get; set; }

                        /// <summary>
                        /// <para>The maximum IOPS of the shard node.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>8000</para>
                        /// </summary>
                        [NameInMap("MaxIOPS")]
                        [Validation(Required=false)]
                        public int? MaxIOPS { get; set; }

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
                        /// <para>The name of the shard node.</para>
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
                        /// <para>d-bp16e09d9c5d****</para>
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
                        /// <para>The port number that is used to connect to the shard node.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>3717</para>
                        /// </summary>
                        [NameInMap("Port")]
                        [Validation(Required=false)]
                        public int? Port { get; set; }

                        /// <summary>
                        /// <para>The number of read-only nodes in the shard node. Valid values: <b>0</b> to <b>5</b>. The value must be an integer.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>0</para>
                        /// </summary>
                        [NameInMap("ReadonlyReplicas")]
                        [Validation(Required=false)]
                        public int? ReadonlyReplicas { get; set; }

                        [NameInMap("ReplicaSetName")]
                        [Validation(Required=false)]
                        public string ReplicaSetName { get; set; }

                        /// <summary>
                        /// <para>The status of the shard node. For more information, see <a href="https://help.aliyun.com/document_detail/63870.html">Instance states</a>.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Running</para>
                        /// </summary>
                        [NameInMap("Status")]
                        [Validation(Required=false)]
                        public string Status { get; set; }

                    }

                }

                /// <summary>
                /// <para>The storage engine of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>WiredTiger</para>
                /// </summary>
                [NameInMap("StorageEngine")]
                [Validation(Required=false)]
                public string StorageEngine { get; set; }

                /// <summary>
                /// <para>The storage type of the instance. Valid values:</para>
                /// <para><b>cloud_essd1</b>: ESSD PL1 <b>cloud_essd2</b>: ESSD PL2 <b>cloud_essd3</b>: ESSD PL3 <b>local_ssd</b>: local SSD <b>cloud_essd_dbfs_s</b>: DBFS disk</para>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_essd1</para>
                /// </summary>
                [NameInMap("StorageType")]
                [Validation(Required=false)]
                public string StorageType { get; set; }

                /// <summary>
                /// <para>The progress of data synchronization in percentage. When you are changing the configurations of the instance, you must synchronize the data of the instance. You can obtain the data synchronization progress based on the value returned for this parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.8</para>
                /// </summary>
                [NameInMap("SyncPercent")]
                [Validation(Required=false)]
                public string SyncPercent { get; set; }

                /// <summary>
                /// <para>The details of the instance tags.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeDBInstanceAttributeResponseBodyDBInstancesDBInstanceTags Tags { get; set; }
                public class DescribeDBInstanceAttributeResponseBodyDBInstancesDBInstanceTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeDBInstanceAttributeResponseBodyDBInstancesDBInstanceTagsTag> Tag { get; set; }
                    public class DescribeDBInstanceAttributeResponseBodyDBInstancesDBInstanceTagsTag : TeaModel {
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
                /// <para>Indicates whether the cluster backup mode is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: The cluster backup mode is enabled.</description></item>
                /// <item><description><b>false</b>: The cluster backup mode is disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("UseClusterBackup")]
                [Validation(Required=false)]
                public bool? UseClusterBackup { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// <remarks>
                /// <para> This parameter is returned if the network type of the instance is VPC.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>dds-bp11483712c1****</para>
                /// </summary>
                [NameInMap("VPCCloudInstanceIds")]
                [Validation(Required=false)]
                public string VPCCloudInstanceIds { get; set; }

                /// <summary>
                /// <para>The VPC ID of the instance.</para>
                /// <remarks>
                /// <para> This parameter is returned if the network type of the instance is VPC.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-bp1n3i15v90el48nx****</para>
                /// </summary>
                [NameInMap("VPCId")]
                [Validation(Required=false)]
                public string VPCId { get; set; }

                /// <summary>
                /// <para>The vSwitch ID of the instance.</para>
                /// <remarks>
                /// <para> This parameter is returned if the network type of the instance is VPC.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bp1oo2a7isyrb8igf****</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>Indicates whether password-free access within the VPC is enabled. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Open</b>: Password-free access within the VPC is enabled.</description></item>
                /// <item><description><b>Close</b>: Password-free access within the VPC is disabled, and you must use a password for access.</description></item>
                /// <item><description><b>NotSupport</b>: Password-free access within the VPC is not supported.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Open</para>
                /// </summary>
                [NameInMap("VpcAuthMode")]
                [Validation(Required=false)]
                public string VpcAuthMode { get; set; }

                /// <summary>
                /// <para>The ID of the zone in which the instance resides.</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A935A8EE-A6CC-53DE-98BA-20ABAA7E632B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
