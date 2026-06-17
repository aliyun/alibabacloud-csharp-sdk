// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class CreateDBInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The AI node specifications.</para>
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
            /// <para>The specifications of the AI nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ADB.AIMedium.2</para>
            /// </summary>
            [NameInMap("AINodeSpec")]
            [Validation(Required=false)]
            public string AINodeSpec { get; set; }

        }

        /// <summary>
        /// <para>The ID of the backup set.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/210093.html">DescribeDataBackups</a> operation to query the backup set IDs for the source instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1111111111</para>
        /// </summary>
        [NameInMap("BackupId")]
        [Validation(Required=false)]
        public string BackupId { get; set; }

        /// <summary>
        /// <para>The cache size for a serverless instance, in GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>800</para>
        /// </summary>
        [NameInMap("CacheStorageSize")]
        [Validation(Required=false)]
        public string CacheStorageSize { get; set; }

        /// <summary>
        /// <para>A client token used to ensure the idempotence of the request. For more information, see <a href="https://help.aliyun.com/document_detail/327176.html">How to ensure idempotence</a>.</para>
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
        /// <item><description><para><b>true</b>: A sample dataset is loaded.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: A sample dataset is not loaded.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If this parameter is not specified, a sample dataset is not loaded.</para>
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
        /// <item><description><para><b>HighAvailability</b>: High-availability Edition</para>
        /// </description></item>
        /// <item><description><para><b>Basic</b>: Basic Edition</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required for instances in elastic storage mode.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>HighAvailability</para>
        /// </summary>
        [NameInMap("DBInstanceCategory")]
        [Validation(Required=false)]
        public string DBInstanceCategory { get; set; }

        /// <summary>
        /// <para>The instance type. For more information, see the description of the <c>DBInstanceClass</c> parameter.</para>
        /// <remarks>
        /// <para>This parameter is required for instances in reserved storage mode.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>gpdb.group.segsdx1</para>
        /// </summary>
        [NameInMap("DBInstanceClass")]
        [Validation(Required=false)]
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// <para>The instance description.</para>
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
        /// <para>This parameter is required for instances in reserved storage mode.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("DBInstanceGroupCount")]
        [Validation(Required=false)]
        public string DBInstanceGroupCount { get; set; }

        /// <summary>
        /// <para>The instance resource mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>StorageElastic</b>: elastic storage mode</para>
        /// </description></item>
        /// <item><description><para><b>Serverless</b>: serverless mode</para>
        /// </description></item>
        /// <item><description><para><b>Classic</b>: reserved storage mode</para>
        /// </description></item>
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
        /// <item><description><para>multiple: multi-AZ deployment.</para>
        /// </description></item>
        /// <item><description><para>single: single-AZ deployment.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>If this parameter is not specified, the default value is single.</para>
        /// </description></item>
        /// <item><description><para>Defaults to <c>single</c> (single-AZ deployment), which is the only mode currently supported.</para>
        /// </description></item>
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
        /// <item><description><para><b>true</b>: SSL encryption is enabled.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): SSL encryption is disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableSSL")]
        [Validation(Required=false)]
        public bool? EnableSSL { get; set; }

        /// <summary>
        /// <para>The ID of the encryption key.</para>
        /// <remarks>
        /// <para>If <c>EncryptionType</c> is set to <c>CloudDisk</c>, you must specify the ID of an encryption key in the same region. Otherwise, leave this parameter empty.</para>
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
        /// <item><description><para><b>NULL</b>: disables encryption. This is the default value.</para>
        /// </description></item>
        /// <item><description><para><b>CloudDisk</b>: Enables cloud disk encryption. If you select this option, you must also specify a value for <c>EncryptionKey</c>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>After cloud disk encryption is enabled, it cannot be disabled.</para>
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
        /// <item><description><para><b>6.0</b></para>
        /// </description></item>
        /// <item><description><para><b>7.0</b></para>
        /// </description></item>
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
        /// <para>The period of inactivity, in seconds, after which the instance is considered idle. Minimum value: 60. Default value: 600.</para>
        /// <remarks>
        /// <para>This parameter is required only for serverless instances that use auto-scheduling.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>600</para>
        /// </summary>
        [NameInMap("IdleTime")]
        [Validation(Required=false)]
        public int? IdleTime { get; set; }

        /// <summary>
        /// <para>The instance network type. Set the value to <b>VPC</b>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>Only VPCs are supported.</para>
        /// </description></item>
        /// <item><description><para>If this parameter is not specified, VPC is used by default.</para>
        /// </description></item>
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
        /// <para>The instance type for the compute nodes.</para>
        /// <para>Valid values for a High-availability Edition instance in elastic storage mode:</para>
        /// <list type="bullet">
        /// <item><description><para><b>2C16G</b></para>
        /// </description></item>
        /// <item><description><para><b>4C32G</b></para>
        /// </description></item>
        /// <item><description><para><b>16C128G</b></para>
        /// </description></item>
        /// </list>
        /// <para>Valid values for a Basic Edition instance in elastic storage mode:</para>
        /// <list type="bullet">
        /// <item><description><para><b>2C8G</b></para>
        /// </description></item>
        /// <item><description><para><b>4C16G</b></para>
        /// </description></item>
        /// <item><description><para><b>8C32G</b></para>
        /// </description></item>
        /// <item><description><para><b>16C64G</b></para>
        /// </description></item>
        /// </list>
        /// <para>Valid values for a serverless instance:</para>
        /// <list type="bullet">
        /// <item><description><para><b>4C16G</b></para>
        /// </description></item>
        /// <item><description><para><b>8C32G</b></para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required for instances in elastic storage mode or serverless mode.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2C16G</para>
        /// </summary>
        [NameInMap("InstanceSpec")]
        [Validation(Required=false)]
        public string InstanceSpec { get; set; }

        /// <summary>
        /// <para>Use this parameter to configure the coordinator node as a MasterAI node.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter and <c>MasterCU</c> are mutually exclusive.</para>
        /// </description></item>
        /// <item><description><para>This feature is available only in some regions and zones.</para>
        /// </description></item>
        /// <item><description><para>MasterAI nodes are supported only for AnalyticDB for PostgreSQL V7.0 Basic Edition instances.</para>
        /// </description></item>
        /// <item><description><para>For a list of all possible values, see the coordinator node specification change page in the console.</para>
        /// </description></item>
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
        /// <para>The resources for the coordinator node. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>2 CU</para>
        /// </description></item>
        /// <item><description><para>4 CU</para>
        /// </description></item>
        /// <item><description><para>8 CU</para>
        /// </description></item>
        /// <item><description><para>16 CU</para>
        /// </description></item>
        /// <item><description><para>32 CU</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>You are charged for coordinator node resources of 8 CUs or more.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>8 CU</para>
        /// </summary>
        [NameInMap("MasterCU")]
        [Validation(Required=false)]
        public int? MasterCU { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated.</para>
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
        /// <para>The billing method for the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Postpaid</b>: pay-as-you-go.</para>
        /// </description></item>
        /// <item><description><para><b>Prepaid</b>: subscription.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>If this parameter is not specified, the default billing method is pay-as-you-go.</para>
        /// </description></item>
        /// <item><description><para>Discounts are available for subscriptions of one year or longer. Select a billing method based on your business needs.</para>
        /// </description></item>
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
        /// <item><description><para><b>Month</b></para>
        /// </description></item>
        /// <item><description><para><b>Year</b></para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required for subscription instances.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated.</para>
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
        /// <item><description><para><b>standard</b>: Standard Edition.</para>
        /// </description></item>
        /// <item><description><para><b>cost-effective</b>: Cost-effective Edition.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If this parameter is not specified, the default value is standard.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>standard</para>
        /// </summary>
        [NameInMap("ProdType")]
        [Validation(Required=false)]
        public string ProdType { get; set; }

        /// <summary>
        /// <para>The ID of the region for the instance.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86912.html">DescribeRegions</a> operation to query the IDs of available regions.</para>
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
        /// <para>The ID of the resource group for the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The IP address whitelist for the instance.</para>
        /// <para>A value of 127.0.0.1 blocks all external access. After you create the instance, you can call the <a href="https://help.aliyun.com/document_detail/86928.html">ModifySecurityIps</a> operation to modify the IP address whitelist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.0.1</para>
        /// </summary>
        [NameInMap("SecurityIPList")]
        [Validation(Required=false)]
        public string SecurityIPList { get; set; }

        /// <summary>
        /// <para>The performance level of the ESSDs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>pl0</b>: PL0</para>
        /// </description></item>
        /// <item><description><para><b>pl1</b>: PL1</para>
        /// </description></item>
        /// <item><description><para><b>pl2</b>: PL2</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter applies only if the segment node storage type is ESSD.</para>
        /// </description></item>
        /// <item><description><para>If this parameter is not specified, pl1 is used by default.</para>
        /// </description></item>
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
        /// <item><description><para>For a High-availability Edition instance in elastic storage mode, the value must be a multiple of 4, from 4 to 512.</para>
        /// </description></item>
        /// <item><description><para>For a Basic Edition instance in elastic storage mode, the value must be a multiple of 2, from 2 to 512.</para>
        /// </description></item>
        /// <item><description><para>For a serverless instance, the value must be a multiple of 2, from 2 to 512.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required for instances in elastic storage mode or serverless mode.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("SegNodeNum")]
        [Validation(Required=false)]
        public string SegNodeNum { get; set; }

        /// <summary>
        /// <para>The storage type for the segment nodes. Only ESSDs are supported. Set the value to <b>cloud_essd</b>.</para>
        /// <remarks>
        /// <para>This parameter is required for instances in elastic storage mode.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_essd</para>
        /// </summary>
        [NameInMap("SegStorageType")]
        [Validation(Required=false)]
        public string SegStorageType { get; set; }

        /// <summary>
        /// <para>The mode of the serverless instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Manual</b>: manual scheduling. This is the default value.</para>
        /// </description></item>
        /// <item><description><para><b>Auto</b>: auto-scheduling.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is required only for instances in serverless mode.</para>
        /// </description></item>
        /// <item><description><para>Auto-scheduling for AnalyticDB for PostgreSQL instances in serverless mode is in preview. To use this feature, <a href="https://smartservice.console.aliyun.com/service/create-ticket?product=rds">submit a ticket</a> to be added to the whitelist.</para>
        /// </description></item>
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
        /// <para>The threshold for computing resources, in AnalyticDB Compute Units (ACUs). The value must be a multiple of 8, ranging from 8 to 32. The default value is 32.</para>
        /// <remarks>
        /// <para>This parameter is required only for serverless instances that use auto-scheduling.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>32</para>
        /// </summary>
        [NameInMap("ServerlessResource")]
        [Validation(Required=false)]
        public int? ServerlessResource { get; set; }

        /// <summary>
        /// <para>The ID of the source instance to be cloned.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> operation to query the details of all AnalyticDB for PostgreSQL instances in the destination region, including instance IDs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>gp-bp***************</para>
        /// </summary>
        [NameInMap("SrcDbInstanceName")]
        [Validation(Required=false)]
        public string SrcDbInstanceName { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch in the standby zone.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is required only for a multi-AZ deployment.</para>
        /// </description></item>
        /// <item><description><para>The vSwitch must be in the standby zone specified in <c>StandbyZoneId</c>.</para>
        /// </description></item>
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
        /// <para>The ID of the standby zone.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is required only for a multi-AZ deployment.</para>
        /// </description></item>
        /// <item><description><para>You can call the <a href="https://help.aliyun.com/document_detail/86912.html">DescribeRegions</a> operation to query the IDs of available zones.</para>
        /// </description></item>
        /// <item><description><para>The standby zone must be different from the primary zone.</para>
        /// </description></item>
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
        /// <para>The storage capacity for the instance, in GB. Valid values: &lt;props=&quot;china&quot;&gt;50 to 8000&lt;props=&quot;intl&quot;&gt;50 to 6000.</para>
        /// <remarks>
        /// <para>This parameter is required for instances in elastic storage mode.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("StorageSize")]
        [Validation(Required=false)]
        public long? StorageSize { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        /// <summary>
        /// <para>The tags to add to the instance. You can add up to 20 tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateDBInstanceRequestTag> Tag { get; set; }
        public class CreateDBInstanceRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. The following limits apply:</para>
            /// <list type="bullet">
            /// <item><description><para>The tag key cannot be empty.</para>
            /// </description></item>
            /// <item><description><para>The tag key can be up to 128 characters in length.</para>
            /// </description></item>
            /// <item><description><para>The tag key cannot start with <c>aliyun</c> or <c>acs:</c> and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// </description></item>
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
            /// <item><description><para>The tag value can be empty.</para>
            /// </description></item>
            /// <item><description><para>The tag value can be up to 128 characters in length.</para>
            /// </description></item>
            /// <item><description><para>The tag value cannot start with <c>acs:</c> and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// </description></item>
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
        /// <item><description><para>If <b>Period</b> is <b>Month</b>, the value can be an integer from 1 to 9.</para>
        /// </description></item>
        /// <item><description><para>If <b>Period</b> is <b>Year</b>, the value can be an integer from 1 to 3.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required for subscription instances.</para>
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
        /// <item><description><para>This parameter is required.</para>
        /// </description></item>
        /// <item><description><para>The VPC must be in the region specified by <c>RegionId</c>.</para>
        /// </description></item>
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
        /// <item><description><para>This parameter is required.</para>
        /// </description></item>
        /// <item><description><para>The vSwitch must be in the zone specified by <c>ZoneId</c>.</para>
        /// </description></item>
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
        /// <item><description><para><b>enabled</b>: enables vector engine optimization.</para>
        /// </description></item>
        /// <item><description><para><b>disabled</b> (default): disables vector engine optimization.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>For mainstream analytics, data warehousing, and real-time data warehousing scenarios, we recommend that you <b>disable</b> vector engine optimization.</para>
        /// </description></item>
        /// <item><description><para>For AIGC and vector search scenarios, we recommend that you <b>enable</b> vector engine optimization.</para>
        /// </description></item>
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
        /// <para>The ID of the zone for the instance.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86912.html">DescribeRegions</a> operation to query the IDs of available zones.</para>
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
