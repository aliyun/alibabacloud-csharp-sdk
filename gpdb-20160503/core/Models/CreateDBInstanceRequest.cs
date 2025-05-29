// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class CreateDBInstanceRequest : TeaModel {
        [NameInMap("AINodeSpecInfos")]
        [Validation(Required=false)]
        public List<CreateDBInstanceRequestAINodeSpecInfos> AINodeSpecInfos { get; set; }
        public class CreateDBInstanceRequestAINodeSpecInfos : TeaModel {
            [NameInMap("AINodeNum")]
            [Validation(Required=false)]
            public string AINodeNum { get; set; }

            [NameInMap("AINodeSpec")]
            [Validation(Required=false)]
            public string AINodeSpec { get; set; }

        }

        /// <summary>
        /// <para>Backup set ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/210093.html">DescribeDataBackups</a> interface to view the backup set IDs of all backup sets under the target instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1111111111</para>
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        [NameInMap("CacheStorageSize")]
        [Validation(Required=false)]
        public string CacheStorageSize { get; set; }

        /// <summary>
        /// <para>Idempotence check. For more information, see <a href="https://help.aliyun.com/document_detail/327176.html">How to Ensure Idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0c593ea1-3bea-11e9-b96b-88**********</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Whether to load sample datasets after the instance is created. The values are as follows:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Load sample datasets.</description></item>
        /// <item><description><b>false</b>: Do not load sample datasets.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If this parameter is not specified, it defaults to not loading sample datasets.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CreateSampleData")]
        [Validation(Required=false)]
        public bool? CreateSampleData { get; set; }

        /// <summary>
        /// <para>Instance series. The value description is as follows:</para>
        /// <list type="bullet">
        /// <item><description><b>HighAvailability</b>: High availability version.</description></item>
        /// <item><description><b>Basic</b>: Basic version.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required when creating an instance in the storage elastic mode.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>HighAvailability</para>
        /// </summary>
        [NameInMap("DBInstanceCategory")]
        [Validation(Required=false)]
        public string DBInstanceCategory { get; set; }

        /// <summary>
        /// <para>Instance type. For more details, see the supplementary description of the DBInstanceClass parameter.</para>
        /// <remarks>
        /// <para>This parameter is required when creating a reserved storage mode instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>gpdb.group.segsdx1</para>
        /// </summary>
        [NameInMap("DBInstanceClass")]
        [Validation(Required=false)]
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// <para>Instance description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("DBInstanceDescription")]
        [Validation(Required=false)]
        public string DBInstanceDescription { get; set; }

        /// <summary>
        /// <para>Number of compute groups. The values are: 2, 4, 8, 12, 16, 24, 32, 64, 96, 128.</para>
        /// <remarks>
        /// <para>This parameter is required when creating a reserved storage mode instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("DBInstanceGroupCount")]
        [Validation(Required=false)]
        public string DBInstanceGroupCount { get; set; }

        /// <summary>
        /// <para>Instance resource type. The value description is as follows:</para>
        /// <list type="bullet">
        /// <item><description><b>StorageElastic</b>: Storage elastic mode.</description></item>
        /// <item><description><b>Serverless</b>: Serverless mode.</description></item>
        /// <item><description><b>Classic</b>: Storage reserved mode.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>StorageElastic</para>
        /// </summary>
        [NameInMap("DBInstanceMode")]
        [Validation(Required=false)]
        public string DBInstanceMode { get; set; }

        /// <summary>
        /// <para>Deployment mode. The values are as follows:</para>
        /// <list type="bullet">
        /// <item><description>multiple: Multi-zone deployment.</description></item>
        /// <item><description>single: Single-zone deployment.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If this parameter is not specified, the default value is single-zone deployment.</description></item>
        /// <item><description>Currently, only single-zone deployment is supported.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>single</para>
        /// </summary>
        [NameInMap("DeployMode")]
        [Validation(Required=false)]
        public string DeployMode { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable SSL encryption. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b> (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableSSL")]
        [Validation(Required=false)]
        public bool? EnableSSL { get; set; }

        /// <summary>
        /// <para>Key ID.</para>
        /// <remarks>
        /// <para>If the value of the <b>EncryptionType</b> parameter is <b>CloudDisk</b>, you need to specify the encryption key ID within the same region through this parameter; otherwise, it should be empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0d2470df-da7b-4786-b981-88888888****</para>
        /// </summary>
        [NameInMap("EncryptionKey")]
        [Validation(Required=false)]
        public string EncryptionKey { get; set; }

        /// <summary>
        /// <para>Encryption type. The value description is as follows:</para>
        /// <list type="bullet">
        /// <item><description><b>NULL</b>: No encryption (default).</description></item>
        /// <item><description><b>CloudDisk</b>: Enable cloud disk encryption and specify the key through the <b>EncryptionKey</b> parameter.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Once cloud disk encryption is enabled, it cannot be disabled.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>CloudDisk</para>
        /// </summary>
        [NameInMap("EncryptionType")]
        [Validation(Required=false)]
        public string EncryptionType { get; set; }

        /// <summary>
        /// <para>Database engine, with the value <b>gpdb</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gpdb</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>Engine version. The values are as follows:</para>
        /// <list type="bullet">
        /// <item><description><b>6.0</b>: Version 6.0.</description></item>
        /// <item><description><b>7.0</b>: Version 7.0.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6.0</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>The idle release wait time. When the duration without business traffic reaches the specified time, the instance will enter the idle state. The unit is seconds, with a minimum value of 60, and the default value is 600.</para>
        /// <remarks>
        /// <para>This parameter is required only for Serverless auto-scheduling mode instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>600</para>
        /// </summary>
        [NameInMap("IdleTime")]
        [Validation(Required=false)]
        public int? IdleTime { get; set; }

        /// <summary>
        /// <para>Instance network type, with the value <b>VPC</b>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Only VPC networks are supported in public cloud.</description></item>
        /// <item><description>If not specified, it defaults to VPC type.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("InstanceNetworkType")]
        [Validation(Required=false)]
        public string InstanceNetworkType { get; set; }

        /// <summary>
        /// <para>Compute node specifications.</para>
        /// <para>For high-availability versions of the elastic storage mode, the values are as follows:</para>
        /// <list type="bullet">
        /// <item><description><b>2C16G</b></description></item>
        /// <item><description><b>4C32G</b></description></item>
        /// <item><description><b>16C128G</b></description></item>
        /// </list>
        /// <para>For basic versions of the elastic storage mode, the values are as follows:</para>
        /// <list type="bullet">
        /// <item><description><b>2C8G</b></description></item>
        /// <item><description><b>4C16G</b></description></item>
        /// <item><description><b>8C32G</b></description></item>
        /// <item><description><b>16C64G</b></description></item>
        /// </list>
        /// <para>For Serverless mode, the values are as follows:</para>
        /// <list type="bullet">
        /// <item><description><b>4C16G</b></description></item>
        /// <item><description><b>8C32G</b></description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required when creating an elastic storage mode instance or a Serverless mode instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2C16G</para>
        /// </summary>
        [NameInMap("InstanceSpec")]
        [Validation(Required=false)]
        public string InstanceSpec { get; set; }

        /// <summary>
        /// <para>This parameter must be specified if you want to change coordinator nodes to AI coordinator nodes.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You cannot specify the MasterAISpec and MasterCU parameters at the same time.</description></item>
        /// <item><description>You can change coordinator nodes to AI coordinator nodes only in specific regions and zones.</description></item>
        /// <item><description>Only AnalyticDB for PostgreSQL V7.0 instances of Basic Edition support AI coordinator nodes.</description></item>
        /// <item><description>You can view the valid values of this parameter on the configuration change page of coordinator nodes.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ADB.AIMedium.2</para>
        /// </summary>
        [NameInMap("MasterAISpec")]
        [Validation(Required=false)]
        public string MasterAISpec { get; set; }

        /// <summary>
        /// <para>Master resources, with the following values: </para>
        /// <list type="bullet">
        /// <item><description>2 CU </description></item>
        /// <item><description>4 CU </description></item>
        /// <item><description>8 CU </description></item>
        /// <item><description>16 CU </description></item>
        /// <item><description>32 CU <remarks>
        /// <para>Master resources above 8 CU will incur charges.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>8 CU</para>
        /// </summary>
        [NameInMap("MasterCU")]
        [Validation(Required=false)]
        public int? MasterCU { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated and should not be passed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("MasterNodeNum")]
        [Validation(Required=false)]
        public string MasterNodeNum { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The billing method of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Postpaid</b>: pay-as-you-go.</description></item>
        /// <item><description><b>Prepaid</b>: subscription.</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If you do not specify this parameter, Postpaid is used.</para>
        /// </description></item>
        /// <item><description><para>You can obtain more cost savings if you create a subscription instance for one year or longer. We recommend that you select the billing method that best suits your needs.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Prepaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>Unit of the duration for which resources are purchased. The values are as follows:</para>
        /// <list type="bullet">
        /// <item><description><b>Month</b>: Month</description></item>
        /// <item><description><b>Year</b>: Year</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required when creating a subscription-billed instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated and should not be passed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// <para>Product type. The values are as follows:</para>
        /// <list type="bullet">
        /// <item><description><b>standard</b>: Standard Edition.</description></item>
        /// <item><description><b>cost-effective</b>: Cost-Effective Edition.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If this parameter is not specified, the default value is Standard Edition.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>standard</para>
        /// </summary>
        [NameInMap("ProdType")]
        [Validation(Required=false)]
        public string ProdType { get; set; }

        /// <summary>
        /// <para>Region ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86912.html">DescribeRegions</a> interface to view available region IDs.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the enterprise resource group where the instance is located.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The IP address whitelist of the instance.</para>
        /// <para>A value of 127.0.0.1 denies access from any external IP address. You can call the <a href="https://help.aliyun.com/document_detail/86928.html">ModifySecurityIps</a> operation to modify the IP address whitelist after you create an instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.0.1</para>
        /// </summary>
        [NameInMap("SecurityIPList")]
        [Validation(Required=false)]
        public string SecurityIPList { get; set; }

        /// <summary>
        /// <para>The performance level of ESSDs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>pl0</b></description></item>
        /// <item><description><b>pl1</b></description></item>
        /// <item><description><b>pl2</b></description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter takes effect only when SegStorageType is set to cloud_essd.</para>
        /// </description></item>
        /// <item><description><para>If you do not specify this parameter, pl1 is used.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>pl1</para>
        /// </summary>
        [NameInMap("SegDiskPerformanceLevel")]
        [Validation(Required=false)]
        public string SegDiskPerformanceLevel { get; set; }

        /// <summary>
        /// <para>The number of compute nodes. The value description is as follows:</para>
        /// <list type="bullet">
        /// <item><description>For the high-availability version of the storage elastic mode, the value range is 4 to 512, and the value must be a multiple of 4.</description></item>
        /// <item><description>For the basic version of the storage elastic mode, the value range is 2 to 512, and the value must be a multiple of 2.</description></item>
        /// <item><description>For the Serverless mode, the value range is 2 to 512, and the value must be a multiple of 2.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required when creating instances in the storage elastic mode or Serverless mode.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("SegNodeNum")]
        [Validation(Required=false)]
        public string SegNodeNum { get; set; }

        /// <summary>
        /// <para>Disk storage type, currently only ESSD cloud disks are supported, with the value <b>cloud_essd</b>.</para>
        /// <remarks>
        /// <para>This parameter is required when creating an elastic storage mode instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_essd</para>
        /// </summary>
        [NameInMap("SegStorageType")]
        [Validation(Required=false)]
        public string SegStorageType { get; set; }

        /// <summary>
        /// <para>The mode of the Serverless instance. The values are as follows:</para>
        /// <list type="bullet">
        /// <item><description><b>Manual</b>: Manual scheduling (default).</description></item>
        /// <item><description><b>Auto</b>: Auto scheduling.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required only for Serverless mode instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Auto</para>
        /// </summary>
        [NameInMap("ServerlessMode")]
        [Validation(Required=false)]
        public string ServerlessMode { get; set; }

        /// <summary>
        /// <para>The threshold for computing resources. The value range is 8 to 32, with a step of 8, and the unit is ACU. The default value is 32.</para>
        /// <remarks>
        /// <para>This parameter is required only for Serverless auto-scheduling mode instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>32</para>
        /// </summary>
        [NameInMap("ServerlessResource")]
        [Validation(Required=false)]
        public int? ServerlessResource { get; set; }

        /// <summary>
        /// <para>ID of the source instance to be cloned.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> interface to view details of all AnalyticDB for PostgreSQL instances in the target region, including the instance ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>gp-bp***************</para>
        /// </summary>
        [NameInMap("SrcDbInstanceName")]
        [Validation(Required=false)]
        public string SrcDbInstanceName { get; set; }

        /// <summary>
        /// <para>VSwitch ID of the standby zone.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is required for multi-zone deployment.</description></item>
        /// <item><description>The VSwitch ID of the standby zone must be in the same zone as the StandbyZoneId.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1cpq8mr64paltkb****</para>
        /// </summary>
        [NameInMap("StandbyVSwitchId")]
        [Validation(Required=false)]
        public string StandbyVSwitchId { get; set; }

        /// <summary>
        /// <para>ID of the standby zone.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is required for multi-zone deployment.</description></item>
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/86912.html">DescribeRegions</a> interface to view available zone IDs.</description></item>
        /// <item><description>The ID of the standby zone must be different from the ID of the primary zone.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-j</para>
        /// </summary>
        [NameInMap("StandbyZoneId")]
        [Validation(Required=false)]
        public string StandbyZoneId { get; set; }

        /// <summary>
        /// <para>The size of the storage space, in GB, with a value range of &lt;props=&quot;china&quot;&gt;50<del>8000&lt;props=&quot;intl&quot;&gt;50</del>6000.</para>
        /// <remarks>
        /// <para>This parameter is required when creating an instance in the storage elastic mode.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("StorageSize")]
        [Validation(Required=false)]
        public long? StorageSize { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated and should not be passed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        /// <summary>
        /// <para>The Nth tag. The value of N ranges from 1 to 20.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateDBInstanceRequestTag> Tag { get; set; }
        public class CreateDBInstanceRequestTag : TeaModel {
            /// <summary>
            /// <para>Tag key. The restrictions are as follows:</para>
            /// <list type="bullet">
            /// <item><description>It cannot be an empty string.</description></item>
            /// <item><description>It supports up to 128 characters.</description></item>
            /// <item><description>It cannot start with <c>aliyun</c> or <c>acs:</c>, and it cannot contain <c>http://</c> or <c>https://</c>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>Tag value. The restrictions are as follows:</para>
            /// <list type="bullet">
            /// <item><description>It can be an empty string.</description></item>
            /// <item><description>It supports up to 128 characters.</description></item>
            /// <item><description>It cannot start with <c>acs:</c>, and it cannot contain <c>http://</c> or <c>https://</c>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>Duration for which resources are purchased. The values are as follows:</para>
        /// <list type="bullet">
        /// <item><description>When <b>Period</b> is <b>Month</b>, the value ranges from 1 to 9.</description></item>
        /// <item><description>When <b>Period</b> is <b>Year</b>, the value ranges from 1 to 3.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required when creating a subscription-billed instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public string UsedTime { get; set; }

        /// <summary>
        /// <para>VPC ID.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><b>VPCId</b> is required.</description></item>
        /// <item><description>The region of the <b>VPC</b> must be consistent with <b>RegionId</b>.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp19ame5m1r3oejns****</para>
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// <para>vSwitch ID.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><b>vSwitchId</b> is required.</description></item>
        /// <item><description>The availability zone of the <b>vSwitch</b> must be consistent with <b>ZoneId</b>.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1cpq8mr64paltkb****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>Whether to enable vector engine optimization. The value description is as follows:</para>
        /// <list type="bullet">
        /// <item><description><b>enabled</b>: Enable vector engine optimization.</description></item>
        /// <item><description><b>disabled</b> (default): Do not enable vector engine optimization.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>For mainstream analysis scenarios, data warehouse scenarios, and real-time data warehouse scenarios, it is recommended to <b>not enable</b> vector engine optimization.</description></item>
        /// <item><description>For users using the vector analysis engine for AIGC, vector retrieval, and other scenarios, it is recommended to <b>enable</b> vector engine optimization.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("VectorConfigurationStatus")]
        [Validation(Required=false)]
        public string VectorConfigurationStatus { get; set; }

        /// <summary>
        /// <para>Zone ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86912.html">DescribeRegions</a> interface to view available zone IDs.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-i</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
