// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDBInstanceAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The queried instance.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeDBInstanceAttributeResponseBodyItems Items { get; set; }
        public class DescribeDBInstanceAttributeResponseBodyItems : TeaModel {
            [NameInMap("DBInstanceAttribute")]
            [Validation(Required=false)]
            public List<DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttribute> DBInstanceAttribute { get; set; }
            public class DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttribute : TeaModel {
                /// <summary>
                /// <para>Queries the current instance availability status, in percentage (%).</para>
                /// <remarks>
                /// <para>This parameter is only applicable to instances in the storage reserved mode.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>100.0%</para>
                /// </summary>
                [NameInMap("AvailabilityValue")]
                [Validation(Required=false)]
                public string AvailabilityValue { get; set; }

                /// <summary>
                /// <para>Access mode, with the following values:</para>
                /// <list type="bullet">
                /// <item><description><b>Performance</b>: Standard access mode.</description></item>
                /// <item><description><b>Safty</b>: High-security access mode.</description></item>
                /// <item><description><b>LVS</b>: LVS link mode.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>LVS</para>
                /// </summary>
                [NameInMap("ConnectionMode")]
                [Validation(Required=false)]
                public string ConnectionMode { get; set; }

                /// <summary>
                /// <para>Instance connection address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gp-bp13ue79qk8y1****-master.gpdb.rds.aliyuncs.com</para>
                /// </summary>
                [NameInMap("ConnectionString")]
                [Validation(Required=false)]
                public string ConnectionString { get; set; }

                /// <summary>
                /// <para>Minor version number of the kernel.</para>
                /// 
                /// <b>Example:</b>
                /// <para>mm.v6.3.10.1-202207141918</para>
                /// </summary>
                [NameInMap("CoreVersion")]
                [Validation(Required=false)]
                public string CoreVersion { get; set; }

                /// <summary>
                /// <para>Number of CPU cores for the compute node, unit: Core.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("CpuCores")]
                [Validation(Required=false)]
                public int? CpuCores { get; set; }

                /// <summary>
                /// <para>Number of CPU cores per node.</para>
                /// <remarks>
                /// <para>This parameter is only applicable to instances in the storage reserved mode.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("CpuCoresPerNode")]
                [Validation(Required=false)]
                public int? CpuCoresPerNode { get; set; }

                /// <summary>
                /// <para>Instance creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-08-11T09:16:26Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>Instance series, with the following values:</para>
                /// <list type="bullet">
                /// <item><description><b>Basic</b>: Basic Edition.</description></item>
                /// <item><description><b>HighAvailability</b>: High Availability Edition.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>HighAvailability</para>
                /// </summary>
                [NameInMap("DBInstanceCategory")]
                [Validation(Required=false)]
                public string DBInstanceCategory { get; set; }

                /// <summary>
                /// <para>Instance specification.</para>
                /// <remarks>
                /// <para>This parameter is only applicable to reserved storage mode instances.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>gpdb.group.segsdx1</para>
                /// </summary>
                [NameInMap("DBInstanceClass")]
                [Validation(Required=false)]
                public string DBInstanceClass { get; set; }

                /// <summary>
                /// <para>Instance family, with the following values:</para>
                /// <list type="bullet">
                /// <item><description><b>s</b>: Shared type.</description></item>
                /// <item><description><b>x</b>: General type.</description></item>
                /// <item><description><b>d</b>: Dedicated package.</description></item>
                /// <item><description><b>h</b>: Dedicated physical machine.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>x</para>
                /// </summary>
                [NameInMap("DBInstanceClassType")]
                [Validation(Required=false)]
                public string DBInstanceClassType { get; set; }

                /// <summary>
                /// <para>Number of CPU cores.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("DBInstanceCpuCores")]
                [Validation(Required=false)]
                public int? DBInstanceCpuCores { get; set; }

                /// <summary>
                /// <para>Instance description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gp-bp13ue79qk8y1****</para>
                /// </summary>
                [NameInMap("DBInstanceDescription")]
                [Validation(Required=false)]
                public string DBInstanceDescription { get; set; }

                /// <summary>
                /// <para>Maximum BPS (disk throughput) of the compute group, in Mbps.</para>
                /// <remarks>
                /// <para>This parameter is only applicable to reserved storage mode instances.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DBInstanceDiskMBPS")]
                [Validation(Required=false)]
                public long? DBInstanceDiskMBPS { get; set; }

                /// <summary>
                /// <para>Number of compute groups.</para>
                /// <remarks>
                /// <para>This parameter is only applicable to reserved storage mode instances.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("DBInstanceGroupCount")]
                [Validation(Required=false)]
                public string DBInstanceGroupCount { get; set; }

                /// <summary>
                /// <para>Instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gp-bp13ue79qk8y1****</para>
                /// </summary>
                [NameInMap("DBInstanceId")]
                [Validation(Required=false)]
                public string DBInstanceId { get; set; }

                /// <summary>
                /// <para>Memory of the compute node.</para>
                /// <remarks>
                /// <para>The unit for storage-reserved mode is MB; for Serverless and storage-elastic modes, it is GB.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>16</para>
                /// </summary>
                [NameInMap("DBInstanceMemory")]
                [Validation(Required=false)]
                public long? DBInstanceMemory { get; set; }

                /// <summary>
                /// <para>Instance resource type, with the following values:</para>
                /// <list type="bullet">
                /// <item><description><b>Serverless</b>: Serverless mode.</description></item>
                /// <item><description><b>StorageElastic</b>: Storage elastic mode.</description></item>
                /// <item><description><b>Classic</b>: Storage reserved mode.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>StorageElastic</para>
                /// </summary>
                [NameInMap("DBInstanceMode")]
                [Validation(Required=false)]
                public string DBInstanceMode { get; set; }

                /// <summary>
                /// <para>This parameter is deprecated and will not return any value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("DBInstanceNetType")]
                [Validation(Required=false)]
                public string DBInstanceNetType { get; set; }

                /// <summary>
                /// <para>Instance status. For more details, see the supplementary explanation of the DBInstanceStatus parameter.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("DBInstanceStatus")]
                [Validation(Required=false)]
                public string DBInstanceStatus { get; set; }

                /// <summary>
                /// <para>Maximum storage space of a single replica, in GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("DBInstanceStorage")]
                [Validation(Required=false)]
                public long? DBInstanceStorage { get; set; }

                /// <summary>
                /// <para>The deployment mode.</para>
                /// 
                /// <b>Example:</b>
                /// <para>single</para>
                /// </summary>
                [NameInMap("DeployMode")]
                [Validation(Required=false)]
                public string DeployMode { get; set; }

                /// <summary>
                /// <para>Encryption key.</para>
                /// <remarks>
                /// <para>This parameter is returned only for instances with disk encryption enabled.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0d2470df-da7b-4786-b981-************</para>
                /// </summary>
                [NameInMap("EncryptionKey")]
                [Validation(Required=false)]
                public string EncryptionKey { get; set; }

                /// <summary>
                /// <para>Encryption type, with the following value:</para>
                /// <list type="bullet">
                /// <item><description><b>CloudDisk</b>: Cloud disk encryption.</description></item>
                /// </list>
                /// <remarks>
                /// <para>This parameter is returned only for instances with cloud disk encryption.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>CloudDisk</para>
                /// </summary>
                [NameInMap("EncryptionType")]
                [Validation(Required=false)]
                public string EncryptionType { get; set; }

                /// <summary>
                /// <para>Database engine.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gpdb</para>
                /// </summary>
                [NameInMap("Engine")]
                [Validation(Required=false)]
                public string Engine { get; set; }

                /// <summary>
                /// <para>Database version.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6.0</para>
                /// </summary>
                [NameInMap("EngineVersion")]
                [Validation(Required=false)]
                public string EngineVersion { get; set; }

                /// <summary>
                /// <para>Instance expiration time (in UTC).</para>
                /// <remarks>
                /// <para>The expiration time for pay-as-you-go instances is <c>2999-09-08T16:00:00Z</c>.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>2999-09-08T16:00:00Z</para>
                /// </summary>
                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                /// <summary>
                /// <para>Compute group machine type, with the following values:</para>
                /// <list type="bullet">
                /// <item><description><b>0</b>: SSD</description></item>
                /// <item><description><b>1</b>: HDD</description></item>
                /// </list>
                /// <remarks>
                /// <para>This parameter applies only to storage-reserved mode instances.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("HostType")]
                [Validation(Required=false)]
                public string HostType { get; set; }

                /// <summary>
                /// <para>Idle release waiting time. Unit: seconds.</para>
                /// <remarks>
                /// <para>This parameter is returned only for instances in the Serverless automatic scheduling mode.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>600</para>
                /// </summary>
                [NameInMap("IdleTime")]
                [Validation(Required=false)]
                public int? IdleTime { get; set; }

                /// <summary>
                /// <para>Instance network type, with the following values:</para>
                /// <list type="bullet">
                /// <item><description><b>Classic</b>: Classic network.</description></item>
                /// <item><description><b>VPC</b>: VPC network.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>VPC</para>
                /// </summary>
                [NameInMap("InstanceNetworkType")]
                [Validation(Required=false)]
                public string InstanceNetworkType { get; set; }

                /// <summary>
                /// <para>Lock mode, with the following values:</para>
                /// <list type="bullet">
                /// <item><description><b>Unlock</b>: Normal.</description></item>
                /// <item><description><b>ManualLock</b>: Manually triggered lock.</description></item>
                /// <item><description><b>LockByExpiration</b>: Automatically locked when the instance expires.</description></item>
                /// <item><description><b>LockByRestoration</b>: Automatically locked before the instance rolls back.</description></item>
                /// <item><description><b>LockByDiskQuota</b>: Automatically locked when the instance space is full.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Unlock</para>
                /// </summary>
                [NameInMap("LockMode")]
                [Validation(Required=false)]
                public string LockMode { get; set; }

                /// <summary>
                /// <para>This parameter is deprecated and will not return any value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("LockReason")]
                [Validation(Required=false)]
                public string LockReason { get; set; }

                /// <summary>
                /// <para>Maintenance end time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>22:00Z</para>
                /// </summary>
                [NameInMap("MaintainEndTime")]
                [Validation(Required=false)]
                public string MaintainEndTime { get; set; }

                /// <summary>
                /// <para>Maintenance start time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>18:00Z</para>
                /// </summary>
                [NameInMap("MaintainStartTime")]
                [Validation(Required=false)]
                public string MaintainStartTime { get; set; }

                /// <summary>
                /// <para>The specifications of AI coordinator node resources of the instance. If the coordinator nodes of the instance are not AI nodes, null is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ADB.AIMedium.2</para>
                /// </summary>
                [NameInMap("MasterAISpec")]
                [Validation(Required=false)]
                public string MasterAISpec { get; set; }

                /// <summary>
                /// <para>Master resources.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("MasterCU")]
                [Validation(Required=false)]
                public int? MasterCU { get; set; }

                /// <summary>
                /// <para>Number of Master nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MasterNodeNum")]
                [Validation(Required=false)]
                public int? MasterNodeNum { get; set; }

                /// <summary>
                /// <para>Maximum number of concurrent connections for the instance.</para>
                /// <remarks>
                /// <para>This parameter is only applicable to reserved storage mode instances.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("MaxConnections")]
                [Validation(Required=false)]
                public int? MaxConnections { get; set; }

                /// <summary>
                /// <para>Memory size per replica, see the <b>MemoryUnit</b> parameter for the unit.</para>
                /// <remarks>
                /// <para>This parameter is only applicable to instances in the storage reserved mode.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MemoryPerNode")]
                [Validation(Required=false)]
                public int? MemoryPerNode { get; set; }

                /// <summary>
                /// <para>Memory size of the compute node.</para>
                /// <remarks>
                /// <para>The unit is MB for the storage reserved mode; GB for Serverless and storage elastic modes.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>16</para>
                /// </summary>
                [NameInMap("MemorySize")]
                [Validation(Required=false)]
                public long? MemorySize { get; set; }

                /// <summary>
                /// <para>Memory unit.</para>
                /// <remarks>
                /// <para>This parameter is only applicable to reserved storage mode instances.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>GB</para>
                /// </summary>
                [NameInMap("MemoryUnit")]
                [Validation(Required=false)]
                public string MemoryUnit { get; set; }

                /// <summary>
                /// <para>Minor version of the kernel.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6.3.10.1-202207141918</para>
                /// </summary>
                [NameInMap("MinorVersion")]
                [Validation(Required=false)]
                public string MinorVersion { get; set; }

                /// <summary>
                /// <para>Billing type, with the following values:</para>
                /// <list type="bullet">
                /// <item><description><b>Postpaid</b>: Pay-as-you-go.</description></item>
                /// <item><description><b>Prepaid</b>: Subscription.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Postpaid</para>
                /// </summary>
                [NameInMap("PayType")]
                [Validation(Required=false)]
                public string PayType { get; set; }

                /// <summary>
                /// <para>Instance port number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5432</para>
                /// </summary>
                [NameInMap("Port")]
                [Validation(Required=false)]
                public string Port { get; set; }

                /// <summary>
                /// <para>The service type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>standard</para>
                /// </summary>
                [NameInMap("ProdType")]
                [Validation(Required=false)]
                public string ProdType { get; set; }

                /// <summary>
                /// <para>This parameter has been deprecated and will not return a value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("ReadDelayTime")]
                [Validation(Required=false)]
                public string ReadDelayTime { get; set; }

                /// <summary>
                /// <para>Region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>ID of the resource group where the instance is located.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-bp67acfmxazb4p****</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// <para>Instance running time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4 days 22:58:55</para>
                /// </summary>
                [NameInMap("RunningTime")]
                [Validation(Required=false)]
                public string RunningTime { get; set; }

                /// <summary>
                /// <para>This parameter is deprecated and will not return any value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("SecurityIPList")]
                [Validation(Required=false)]
                public string SecurityIPList { get; set; }

                /// <summary>
                /// <para>Performance Level (PL), currently only <b>PL1</b> is supported.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PL1</para>
                /// </summary>
                [NameInMap("SegDiskPerformanceLevel")]
                [Validation(Required=false)]
                public string SegDiskPerformanceLevel { get; set; }

                /// <summary>
                /// <para>Number of Segment nodes.</para>
                /// <remarks>
                /// <para>This parameter applies only to instances in the storage elastic mode and Serverless manual scheduling mode.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("SegNodeNum")]
                [Validation(Required=false)]
                public int? SegNodeNum { get; set; }

                /// <summary>
                /// <para>The specifications of AI compute node resources of the instance. If the compute nodes of the instance are not AI nodes, null is returned.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ADB.AIMedium.2</para>
                /// </summary>
                [NameInMap("SegmentAISpec")]
                [Validation(Required=false)]
                public string SegmentAISpec { get; set; }

                /// <summary>
                /// <para>Number of compute groups.</para>
                /// <remarks>
                /// <para>This parameter applies only to storage-reserved mode instances.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SegmentCounts")]
                [Validation(Required=false)]
                public int? SegmentCounts { get; set; }

                /// <summary>
                /// <para>The mode of the Serverless instance, with the following values:</para>
                /// <list type="bullet">
                /// <item><description><b>Manual</b>: Manual scheduling.</description></item>
                /// <item><description><b>Auto</b>: Automatic scheduling.</description></item>
                /// </list>
                /// <remarks>
                /// <para>This parameter is returned only for Serverless mode instances.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Auto</para>
                /// </summary>
                [NameInMap("ServerlessMode")]
                [Validation(Required=false)]
                public string ServerlessMode { get; set; }

                /// <summary>
                /// <para>Compute resource threshold. Unit: ACU.</para>
                /// <remarks>
                /// <para>This parameter is returned only for instances in the Serverless automatic scheduling mode.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>32</para>
                /// </summary>
                [NameInMap("ServerlessResource")]
                [Validation(Required=false)]
                public int? ServerlessResource { get; set; }

                /// <summary>
                /// <para>The secondary zone ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-i</para>
                /// </summary>
                [NameInMap("StandbyZoneId")]
                [Validation(Required=false)]
                public string StandbyZoneId { get; set; }

                /// <summary>
                /// <para>The time when the instance started running.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-08-11T09:26:43Z</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>Storage size per replica, see the <b>StorageUnit</b> parameter for units.</para>
                /// <remarks>
                /// <para>This parameter applies only to storage-reserved mode instances.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("StoragePerNode")]
                [Validation(Required=false)]
                public int? StoragePerNode { get; set; }

                /// <summary>
                /// <para>Storage space size, unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("StorageSize")]
                [Validation(Required=false)]
                public long? StorageSize { get; set; }

                /// <summary>
                /// <para>Storage type, with the following values:</para>
                /// <list type="bullet">
                /// <item><description><b>cloud_essd</b>: ESSD cloud disk.</description></item>
                /// <item><description><b>cloud_efficiency</b>: Efficient cloud disk.</description></item>
                /// </list>
                /// <remarks>
                /// <para>This parameter is only applicable to instances in the storage elastic mode.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>cloud_essd</para>
                /// </summary>
                [NameInMap("StorageType")]
                [Validation(Required=false)]
                public string StorageType { get; set; }

                /// <summary>
                /// <para>Storage unit, with the following values:</para>
                /// <list type="bullet">
                /// <item><description><b>GB SSD</b></description></item>
                /// <item><description><b>TB SSD</b></description></item>
                /// <item><description><b>GB HDD</b></description></item>
                /// </list>
                /// <remarks>
                /// <para>This parameter is only applicable to instances in the storage reserved mode.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>GB SSD</para>
                /// </summary>
                [NameInMap("StorageUnit")]
                [Validation(Required=false)]
                public string StorageUnit { get; set; }

                /// <summary>
                /// <para>Indicates whether backup recovery is supported, with the following values:</para>
                /// <list type="bullet">
                /// <item><description><b>true</b>: Backup recovery is supported.</description></item>
                /// <item><description><b>false</b>: Backup recovery is not supported.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("SupportRestore")]
                [Validation(Required=false)]
                public bool? SupportRestore { get; set; }

                /// <summary>
                /// <para>Tag key-value pairs.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeTags Tags { get; set; }
                public class DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeTagsTag> Tag { get; set; }
                    public class DescribeDBInstanceAttributeResponseBodyItemsDBInstanceAttributeTagsTag : TeaModel {
                        /// <summary>
                        /// <para>Tag key.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test-key</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>Tag value.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>test-value</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

                /// <summary>
                /// <para>vSwitch ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-bp1cpq8mr64paltkb****</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>Indicates whether vector engine optimization is enabled. The values are as follows:</para>
                /// <list type="bullet">
                /// <item><description><b>enabled</b>: Indicates that vector engine optimization is enabled.</description></item>
                /// <item><description><b>disabled</b>: Indicates that vector engine optimization is disabled.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>enabled</para>
                /// </summary>
                [NameInMap("VectorConfigurationStatus")]
                [Validation(Required=false)]
                public string VectorConfigurationStatus { get; set; }

                /// <summary>
                /// <para>VPC ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-bp19ame5m1r3oejns****</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <para>Zone ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-j</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5E6EDEB8-D73E-5F2D-B948-86C8AEB05A68</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
