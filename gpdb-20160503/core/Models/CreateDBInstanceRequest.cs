// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class CreateDBInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The AI node specifications information.</para>
        /// </summary>
        [NameInMap("AINodeSpecInfos")]
        [Validation(Required=false)]
        public List<CreateDBInstanceRequestAINodeSpecInfos> AINodeSpecInfos { get; set; }
        public class CreateDBInstanceRequestAINodeSpecInfos : TeaModel {
            /// <summary>
            /// <para>The number of AI nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AINodeNum")]
            [Validation(Required=false)]
            public string AINodeNum { get; set; }

            /// <summary>
            /// <para>The AI node specifications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ADB.AIMedium.2</para>
            /// </summary>
            [NameInMap("AINodeSpec")]
            [Validation(Required=false)]
            public string AINodeSpec { get; set; }

        }

        /// <summary>
        /// <para>The backup set ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/210093.html">DescribeDataBackups</a> operation to query the backup set IDs of all backup sets for the target instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1111111111</para>
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        /// <summary>
        /// <para>The Serverless cache storage size. Valid values: 800 to 102400. The step size is 32 GB. Unit: GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>800</para>
        /// </summary>
        [NameInMap("CacheStorageSize")]
        [Validation(Required=false)]
        public string CacheStorageSize { get; set; }

        /// <summary>
        /// <para>The client token used for idempotence checks. For more information, see <a href="https://help.aliyun.com/document_detail/327176.html">How to ensure idempotence</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0c593ea1-3bea-11e9-b96b-88**********</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to load a sample dataset after the instance is created. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Load a sample dataset.</description></item>
        /// <item><description><b>false</b>: Do not load a sample dataset.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not specify this parameter, the default value is false.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("CreateSampleData")]
        [Validation(Required=false)]
        public bool? CreateSampleData { get; set; }

        /// <summary>
        /// <para>The instance edition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>HighAvailability</b>: high-availability edition.</description></item>
        /// <item><description><b>Basic</b>: basic edition.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required when you create a storage elastic mode instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>HighAvailability</para>
        /// </summary>
        [NameInMap("DBInstanceCategory")]
        [Validation(Required=false)]
        public string DBInstanceCategory { get; set; }

        /// <summary>
        /// <para>The instance specifications. For more information, see the supplementary description of the DBInstanceClass parameter.</para>
        /// <remarks>
        /// <para>This parameter is required when you create a storage reservation mode instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>gpdb.group.segsdx1</para>
        /// </summary>
        [NameInMap("DBInstanceClass")]
        [Validation(Required=false)]
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// <para>The description of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("DBInstanceDescription")]
        [Validation(Required=false)]
        public string DBInstanceDescription { get; set; }

        /// <summary>
        /// <para>The number of compute groups. Valid values: 2, 4, 8, 12, 16, 24, 32, 64, 96, and 128.</para>
        /// <remarks>
        /// <para>This parameter is required when you create a storage reservation mode instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("DBInstanceGroupCount")]
        [Validation(Required=false)]
        public string DBInstanceGroupCount { get; set; }

        /// <summary>
        /// <para>The resource type of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>StorageElastic</b>: storage elastic mode.</description></item>
        /// <item><description><b>Serverless</b>: Serverless mode.</description></item>
        /// <item><description><b>ServerlessPro</b>: Serverless Pro mode.</description></item>
        /// <item><description><b>Classic</b>: storage reservation mode.</description></item>
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
        /// <para>The deployment mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>multiple: multi-zone deployment.</description></item>
        /// <item><description>single: single-zone deployment.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you do not specify this parameter, the default value is single-zone deployment.</description></item>
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
        /// <para>Indicates whether to enable Secure Sockets Layer (SSL) encryption. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Enable SSL encryption.</description></item>
        /// <item><description><b>false</b> (default): Do not enable SSL encryption.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableSSL")]
        [Validation(Required=false)]
        public bool? EnableSSL { get; set; }

        /// <summary>
        /// <para>The encryption key ID.</para>
        /// <remarks>
        /// <para>If the <b>EncryptionType</b> parameter is set to <b>CloudDisk</b>, specify the encryption key ID in the same region. Otherwise, leave this parameter empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0d2470df-da7b-4786-b981-88888888****</para>
        /// </summary>
        [NameInMap("EncryptionKey")]
        [Validation(Required=false)]
        public string EncryptionKey { get; set; }

        /// <summary>
        /// <para>The encryption type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>NULL</b>: Encryption is not enabled. This is the default value.</description></item>
        /// <item><description><b>CloudDisk</b>: Cloud disk encryption is enabled. Use the <b>EncryptionKey</b> parameter to specify the encryption key.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Cloud disk encryption cannot be disabled after it is enabled.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>CloudDisk</para>
        /// </summary>
        [NameInMap("EncryptionType")]
        [Validation(Required=false)]
        public string EncryptionType { get; set; }

        /// <summary>
        /// <para>The database engine. Set the value to <b>gpdb</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gpdb</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The database engine version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>6.0</b>: version 6.0.</description></item>
        /// <item><description><b>7.0</b>: version 7.0.</description></item>
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
        /// <para>The idle release wait time. The instance transitions to an idle state after no service traffic is detected for the specified duration. Unit: seconds. Minimum value: 60. Default value: 600.</para>
        /// <remarks>
        /// <para>This parameter is required only for Serverless instances in automatic scheduling mode.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>600</para>
        /// </summary>
        [NameInMap("IdleTime")]
        [Validation(Required=false)]
        public int? IdleTime { get; set; }

        /// <summary>
        /// <para>The network type of the instance. Set the value to <b>VPC</b>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Only VPC is supported on the public cloud.</description></item>
        /// <item><description>If you do not specify this parameter, the default value is VPC.</description></item>
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
        /// <para>The node specifications of compute nodes.</para>
        /// <para>Valid values for storage elastic mode (high-availability edition):</para>
        /// <list type="bullet">
        /// <item><description><b>2C16G</b></description></item>
        /// <item><description><b>4C32G</b></description></item>
        /// <item><description><b>16C128G</b></description></item>
        /// </list>
        /// <para>Valid values for storage elastic mode (basic edition):</para>
        /// <list type="bullet">
        /// <item><description><b>2C8G</b></description></item>
        /// <item><description><b>4C16G</b></description></item>
        /// <item><description><b>8C32G</b></description></item>
        /// <item><description><b>16C64G</b></description></item>
        /// </list>
        /// <para>Valid values for Serverless mode:</para>
        /// <list type="bullet">
        /// <item><description><b>4C16G</b></description></item>
        /// <item><description><b>8C32G</b></description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required when you create a storage elastic mode instance or a Serverless mode instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2C16G</para>
        /// </summary>
        [NameInMap("InstanceSpec")]
        [Validation(Required=false)]
        public string InstanceSpec { get; set; }

        /// <summary>
        /// <para>Specify this parameter if you want to change the master node to a MasterAI node.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter and MasterCU cannot be specified at the same time.</description></item>
        /// <item><description>Only specific regions and zones support changing the master node to a MasterAI node.</description></item>
        /// <item><description>Only basic edition instances of AnalyticDB for PostgreSQL 7.0 support MasterAI nodes.</description></item>
        /// <item><description>You can view all valid values of this parameter on the specification change page for the master node.</description></item>
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
        /// <para>The master resources. Valid values: </para>
        /// <list type="bullet">
        /// <item><description>2 CU </description></item>
        /// <item><description>4 CU </description></item>
        /// <item><description>8 CU </description></item>
        /// <item><description>16 CU </description></item>
        /// <item><description>32 CU <remarks>
        /// <para>Master resources above 8 CU incur additional fees.</para>
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
        /// <para><b>[Deprecated]</b> This parameter is deprecated. You do not need to specify this parameter.</para>
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
        /// <para>The billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Postpaid</b>: pay-as-you-go.</description></item>
        /// <item><description><b>Prepaid</b>: subscription.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you do not specify this parameter, the default value is pay-as-you-go.</description></item>
        /// <item><description>Discounts are available for subscription instances when you purchase them for one year or longer. Select a billing method based on your business requirements.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Prepaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The unit of the subscription duration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Month</b>: month.</description></item>
        /// <item><description><b>Year</b>: year.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required when you create a subscription instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para><b>[Deprecated]</b> This parameter is deprecated. You do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// <para>The product type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>standard</b>: Standard Edition.</description></item>
        /// <item><description><b>cost-effective</b>: Economy Edition.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not specify this parameter, the default value is Standard Edition.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>standard</para>
        /// </summary>
        [NameInMap("ProdType")]
        [Validation(Required=false)]
        public string ProdType { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86912.html">DescribeRegions</a> operation to query available region IDs.</para>
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
        /// <para>The ID of the enterprise resource group to which the instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The IP address whitelist.</para>
        /// <para>A value of 127.0.0.1 indicates that no external IP addresses are allowed to access the instance. After the instance is created, you can call the <a href="https://help.aliyun.com/document_detail/86928.html">ModifySecurityIps</a> operation to modify the IP address whitelist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.0.1</para>
        /// </summary>
        [NameInMap("SecurityIPList")]
        [Validation(Required=false)]
        public string SecurityIPList { get; set; }

        /// <summary>
        /// <para>The performance level (PL) of the ESSD cloud disk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>pl0</b>: PL0.</description></item>
        /// <item><description><b>pl1</b>: PL1.</description></item>
        /// <item><description><b>pl2</b>: PL2.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter takes effect only when the cloud disk storage type is ESSD cloud disk.</description></item>
        /// <item><description>If you do not specify this parameter, the default value is PL1.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pl1</para>
        /// </summary>
        [NameInMap("SegDiskPerformanceLevel")]
        [Validation(Required=false)]
        public string SegDiskPerformanceLevel { get; set; }

        /// <summary>
        /// <para>The number of compute nodes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Storage elastic mode (high-availability edition): 4 to 512. The value must be a multiple of 4.</description></item>
        /// <item><description>Storage elastic mode (basic edition): 2 to 512. The value must be a multiple of 2.</description></item>
        /// <item><description>Serverless mode: 2 to 512. The value must be a multiple of 2.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required when you create a storage elastic mode instance or a Serverless mode instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("SegNodeNum")]
        [Validation(Required=false)]
        public string SegNodeNum { get; set; }

        /// <summary>
        /// <para>The cloud disk storage type. Currently, only ESSD cloud disks are supported. Set the value to <b>cloud_essd</b>.</para>
        /// <remarks>
        /// <para>This parameter is required when you create a storage elastic mode instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_essd</para>
        /// </summary>
        [NameInMap("SegStorageType")]
        [Validation(Required=false)]
        public string SegStorageType { get; set; }

        /// <summary>
        /// <para>The mode of the Serverless instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Manual</b>: manual scheduling. This is the default value.</description></item>
        /// <item><description><b>Auto</b>: automatic scheduling.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is required only for Serverless mode instances.</description></item>
        /// <item><description>The automatic scheduling mode for AnalyticDB for PostgreSQL Serverless is in invitational preview. To use this feature, <a href="https://smartservice.console.aliyun.com/service/create-ticket?product=rds">submit a ticket</a> to apply for access.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Auto</para>
        /// </summary>
        [NameInMap("ServerlessMode")]
        [Validation(Required=false)]
        public string ServerlessMode { get; set; }

        /// <summary>
        /// <para>The compute resource threshold. Valid values: 16 to 1024. The step size is 8. Unit: ACU.</para>
        /// <remarks>
        /// <para>This parameter is required only for Serverless instances in automatic scheduling mode.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("ServerlessResource")]
        [Validation(Required=false)]
        public int? ServerlessResource { get; set; }

        /// <summary>
        /// <para>The ID of the source instance to clone.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> operation to query the details of all AnalyticDB for PostgreSQL instances in the target region, including instance IDs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>gp-bp***************</para>
        /// </summary>
        [NameInMap("SrcDbInstanceName")]
        [Validation(Required=false)]
        public string SrcDbInstanceName { get; set; }

        /// <summary>
        /// <para>The vSwitch ID in the secondary zone.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is required only for multi-zone deployment.</description></item>
        /// <item><description>The vSwitch must be in the same zone as the value specified by StandbyZoneId.</description></item>
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
        /// <para>The secondary zone ID.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is required only for multi-zone deployment.</description></item>
        /// <item><description>You can call the <a href="https://help.aliyun.com/document_detail/86912.html">DescribeRegions</a> operation to query available zone IDs.</description></item>
        /// <item><description>The secondary zone ID must be different from the primary zone ID.</description></item>
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
        /// <para>The storage capacity. Unit: GB. Valid values: &lt;props=&quot;china&quot;&gt;50 to 8000&lt;props=&quot;intl&quot;&gt;50 to 6000.</para>
        /// <remarks>
        /// <para>This parameter is required when you create a storage elastic mode instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("StorageSize")]
        [Validation(Required=false)]
        public long? StorageSize { get; set; }

        /// <summary>
        /// <para><b>[Deprecated]</b> This parameter is deprecated. You do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        /// <summary>
        /// <para>The Nth tag. Valid values of N: 1 to 20.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateDBInstanceRequestTag> Tag { get; set; }
        public class CreateDBInstanceRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. The following limits apply:</para>
            /// <list type="bullet">
            /// <item><description>The tag key cannot be an empty string.</description></item>
            /// <item><description>The tag key can be up to 128 characters in length.</description></item>
            /// <item><description>The tag key cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. The following limits apply:</para>
            /// <list type="bullet">
            /// <item><description>The tag value can be an empty string.</description></item>
            /// <item><description>The tag value can be up to 128 characters in length.</description></item>
            /// <item><description>The tag value cannot start with <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</description></item>
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
        /// <para>The subscription duration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>Period</b> is set to <b>Month</b>, valid values are 1 to 9.</description></item>
        /// <item><description>If <b>Period</b> is set to <b>Year</b>, valid values are 1 to 3.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required when you create a subscription instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public string UsedTime { get; set; }

        /// <summary>
        /// <para>The VPC ID.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><b>VPCId</b> is required.</description></item>
        /// <item><description>The VPC must be in the same region as the value specified by <b>RegionId</b>.</description></item>
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
        /// <para>The vSwitch ID.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><b>vSwitchId</b> is required.</description></item>
        /// <item><description>The vSwitch must be in the same zone as the value specified by <b>ZoneId</b>.</description></item>
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
        /// <para>Specifies whether to enable vector engine optimization. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>enabled</b>: Enable vector engine optimization.</description></item>
        /// <item><description><b>disabled</b> (default): Do not enable vector engine optimization.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>For mainstream analytics, data warehousing, and real-time data warehouse scenarios, <b>do not enable</b> vector engine optimization.</description></item>
        /// <item><description>For scenarios that use the vector analysis engine for AIGC and AISearch, <b>enable</b> vector engine optimization.</description></item>
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
        /// <para>The zone ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86912.html">DescribeRegions</a> operation to query available zone IDs.</para>
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
