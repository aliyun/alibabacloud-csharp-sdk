// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class CreateGadOrderShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The number of ApsaraDB RDS for MySQL instances to be created. This parameter is applicable only when you create multiple ApsaraDB RDS for MySQL instances at a time.</para>
        /// <para>Valid values: 1 to 20. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Amount")]
        [Validation(Required=false)]
        public int? Amount { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically create a proxy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: enables automatic creation. By default, a general-purpose proxy is created.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: disables automatic creation.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoCreateProxy")]
        [Validation(Required=false)]
        public bool? AutoCreateProxy { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal upon expiration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false</b>: no. This is the default value.</description></item>
        /// <item><description><b>true</b>: yes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enables auto-renewal.</description></item>
        /// <item><description>false: disables auto-renewal.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public string AutoRenew { get; set; }

        /// <summary>
        /// <para>The configuration information of Babelfish for ApsaraDB RDS for PostgreSQL.</para>
        /// <para>Configuration format: {&quot;babelfishEnabled&quot;:&quot;true&quot;,&quot;migrationMode&quot;:&quot;xxxxxxx&quot;,&quot;masterUsername&quot;:&quot;xxxxxxx&quot;,&quot;masterUserPassword&quot;:&quot;xxxxxxxx&quot;}</para>
        /// <para>Parameter descriptions:</para>
        /// <list type="bullet">
        /// <item><description><b>babelfishEnabled</b>: specifies whether to enable Babelfish. Set the value to <b>true</b> to enable Babelfish. By default, Babelfish is disabled if this parameter is not configured.</description></item>
        /// <item><description><b>migrationMode</b>: the database mode. Set the value to <b>single-db</b> for the single-database mode or <b>multi-db</b> for the multi-database mode.</description></item>
        /// <item><description><b>masterUsername</b>: the initial administrator account. The username must be 1 to 63 characters in length and can contain lowercase letters, digits, and underscores (_). It must start with a letter and end with a letter or digit. It cannot start with pg.</description></item>
        /// <item><description><b>masterUserPassword</b>: the password of the administrator account. The password must be 8 to 32 characters in length and must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. Special characters include <c>! @ # $ % ^ &amp; * () _ + - =</c>.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is applicable only to ApsaraDB RDS for PostgreSQL instances. For more information about Babelfish for ApsaraDB RDS for PostgreSQL, see <a href="https://help.aliyun.com/document_detail/428613.html">Babelfish overview</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;isAnalyticReadOnlyIns\&quot;:\&quot;true\&quot;}</para>
        /// </summary>
        [NameInMap("BabelfishConfig")]
        [Validation(Required=false)]
        public string BabelfishConfig { get; set; }

        [NameInMap("BpeEnabled")]
        [Validation(Required=false)]
        public string BpeEnabled { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the I/O performance burst feature for ESSD AutoPL cloud disks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables the feature.</description></item>
        /// <item><description><b>false</b>: disables the feature. This is the default value.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is supported only when StorageType is set to ESSDAUTOPL.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("BurstingEnabled")]
        [Validation(Required=false)]
        public bool? BurstingEnabled { get; set; }

        /// <summary>
        /// <para>The additional parameter that specifies business information.</para>
        /// 
        /// <b>Example:</b>
        /// <hr>
        /// </summary>
        [NameInMap("BusinessInfo")]
        [Validation(Required=false)]
        public string BusinessInfo { get; set; }

        /// <summary>
        /// <para>The instance edition. Valid values:</para>
        /// <para>General instances:
        /// Basic: Basic Edition.
        /// HighAvailability: high-availability series.
        /// cluster: Cluster Edition for MySQL or PostgreSQL.
        /// AlwaysOn: Cluster Edition for SQL Server.
        /// Finance: RDS Enterprise Edition.
        /// Note: This parameter is required when you create an ApsaraDB RDS for SQL Server instance of the RDS Enterprise Edition, Basic Edition Standard, or Basic Edition Enterprise. For example, when you create a Basic Edition instance of the 2022 RDS Enterprise Edition (2022_ent), you must set this parameter to Basic.
        /// Serverless instances:
        /// serverless_basic: Serverless Basic Edition. This edition is active only for MySQL and PostgreSQL.</para>
        /// <para>serverless_standard: Serverless high availability series. This edition is active only for MySQL and PostgreSQL.</para>
        /// <para>serverless_ha: SQL Server Serverless high availability series.</para>
        /// <para>Note: This parameter is required when PayType is set to Serverless.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AlwaysOn</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. The portal rewrites this parameter as a random UUID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0c593ea1-3bea-11e9-b96b-88e9fe63****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gad-x32115vv105f427</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the <a href="https://help.aliyun.com/document_detail/2701832.html">data archiving</a> feature for premium performance disks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables the feature.</description></item>
        /// <item><description><b>false</b>: disables the feature.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ColdDataEnabled")]
        [Validation(Required=false)]
        public bool? ColdDataEnabled { get; set; }

        /// <summary>
        /// <para>The access mode of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Standard</b>: standard access mode.</description></item>
        /// <item><description><b>Safe</b>: database proxy mode.</description></item>
        /// </list>
        /// <para>Default value: allocated by the RDS system.</para>
        /// <remarks>
        /// <para>SQL Server 2012, 2016, and 2017 support only the standard access mode.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("ConnectionMode")]
        [Validation(Required=false)]
        public string ConnectionMode { get; set; }

        /// <summary>
        /// <para>The database connection address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Mid-end service</para>
        /// </summary>
        [NameInMap("ConnectionString")]
        [Validation(Required=false)]
        public string ConnectionString { get; set; }

        /// <summary>
        /// <para>The policy for creating multiple instances at a time. This parameter takes effect only when the <b>Amount</b> parameter is set to a value greater than 1. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Atomicity</b> (default): atomicity. All instances in the same batch are created successfully, or if one instance fails to be created, all instances fail to be created.</description></item>
        /// <item><description><b>Partial</b>: non-atomicity. The creation of an instance is not affected by other instances in the same batch.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Atomicity</para>
        /// </summary>
        [NameInMap("CreateStrategy")]
        [Validation(Required=false)]
        public string CreateStrategy { get; set; }

        /// <summary>
        /// <para>The instance type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>selectdb.xlarge</b>: 4 cores, 32 GB.</description></item>
        /// <item><description><b>selectdb.2xlarge</b>: 8 cores, 64 GB.</description></item>
        /// <item><description><b>selectdb.4xlarge</b>: 16 cores, 128 GB.</description></item>
        /// <item><description><b>selectdb.8xlarge</b>: 32 cores, 256 GB.</description></item>
        /// <item><description><b>selectdb.16xlarge</b>: 64 cores, 512 GB.</description></item>
        /// <item><description><b>selectdb.24xlarge</b>: 96 cores, 768 GB.</description></item>
        /// <item><description><b>selectdb.32xlarge</b>: 128 cores, 1024 GB.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>mssql.x4.medium.e2</para>
        /// </summary>
        [NameInMap("DBInstanceClass")]
        [Validation(Required=false)]
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// <para>The name of the instance. The name must be 2 to 255 characters in length. It must start with a letter or Chinese character and can contain letters, Chinese characters, digits, and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>testInstance</para>
        /// </summary>
        [NameInMap("DBInstanceDescription")]
        [Validation(Required=false)]
        public string DBInstanceDescription { get; set; }

        /// <summary>
        /// <para>The network connection type of the instance. Set the value to Intranet, which indicates an internal network connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Intranet</para>
        /// </summary>
        [NameInMap("DBInstanceNetType")]
        [Validation(Required=false)]
        public string DBInstanceNetType { get; set; }

        /// <summary>
        /// <para>Instance storage capacity of the instance. Instance storage capacity of a read-only instance must be greater than or equal to that of the primary instance. Valid values: See the <b>Storage Capacity</b> column in <a href="https://help.aliyun.com/document_detail/145759.html">Read-only instance types</a>. The value must be a multiple of 5. Unit: GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("DBInstanceStorage")]
        [Validation(Required=false)]
        public int? DBInstanceStorage { get; set; }

        /// <summary>
        /// <para>The storage type of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>local_ssd</b>: premium local SSD.</description></item>
        /// <item><description><b>cloud_ssd</b>: standard SSD.</description></item>
        /// <item><description><b>cloud_essd</b>: PL1 ESSD.</description></item>
        /// <item><description><b>cloud_essd2</b>: PL2 ESSD.</description></item>
        /// <item><description><b>cloud_essd3</b>: PL3 ESSD.</description></item>
        /// <item><description><b>general_essd</b>: premium performance disk.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If the primary ApsaraDB RDS for MySQL instance uses premium local SSDs, you can set this parameter only to <b>local_ssd</b>. If the primary instance uses cloud disks, you can set this parameter only to a cloud disk storage type.</description></item>
        /// <item><description>ApsaraDB RDS for SQL Server supports only cloud disk storage types.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_auto</para>
        /// </summary>
        [NameInMap("DBInstanceStorageType")]
        [Validation(Required=false)]
        public string DBInstanceStorageType { get; set; }

        /// <summary>
        /// <para>Specifies whether table names are case-sensitive. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Table names are not case-sensitive. This is the default value.</description></item>
        /// <item><description><b>false</b>: Table names are case-sensitive.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DBIsIgnoreCase")]
        [Validation(Required=false)]
        public string DBIsIgnoreCase { get; set; }

        /// <summary>
        /// <para>The ID of the parameter template. You can call the DescribeParameterGroups operation to query the ID.</para>
        /// <remarks>
        /// <para>This parameter is supported only for MySQL and PostgreSQL. If you do not specify this parameter, the default parameter template is used. You can also create a custom parameter template and use it here.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rpg-sys-01040402010***</para>
        /// </summary>
        [NameInMap("DBParamGroupId")]
        [Validation(Required=false)]
        public string DBParamGroupId { get; set; }

        /// <summary>
        /// <para>The time zone of the instance. This parameter takes effect only when <b>Engine</b> is set to <b>MySQL</b> or <b>PostgreSQL</b>.</para>
        /// <list type="bullet">
        /// <item><description>When <b>Engine</b> is set to <b>MySQL</b>:<list type="bullet">
        /// <item><description>The parameter settings configure the UTC time zone. Valid values: <b>-12:59</b> to <b>+13:00</b>.</description></item>
        /// <item><description>An instance with Premium Local SSDs can use a named time zone, such as Asia/Hong_Kong. For more information about named time zones, see <a href="https://help.aliyun.com/document_detail/297356.html">Named time zones</a>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>When <b>Engine</b> is set to <b>PostgreSQL</b>:<list type="bullet">
        /// <item><description>The parameter settings configure a named time zone. UTC time zones are not supported. For more information about named time zones, see <a href="https://help.aliyun.com/document_detail/297356.html">Named time zones</a>.</description></item>
        /// <item><description>This parameter can be configured only for PostgreSQL instances that use cloud disks.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You can make parameter settings for the time zone when you purchase a primary instance. Read-only instances do not support time zone Settings and inherit the time zone of the primary instance.</description></item>
        /// <item><description>If you do not make parameter settings for this parameter, the system selects the default time zone based on the region where the instance is created.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>+08:00</para>
        /// </summary>
        [NameInMap("DBTimeZone")]
        [Validation(Required=false)]
        public string DBTimeZone { get; set; }

        /// <summary>
        /// <para>The objects to be migrated or synchronized, in JSON format. For more information, see <a href="https://help.aliyun.com/document_detail/209545.html">Description of migration, synchronization, or change tracking objects</a>.</para>
        /// <list type="bullet">
        /// <item><description>The DbList parameter supports up to 1 MB of data.</description></item>
        /// <item><description>If DbList contains filter conditions, the total length of DbList, including the filter conditions, cannot exceed 1 MB.</description></item>
        /// <item><description>For distributed tasks (such as migration or synchronization tasks with PolarDB-X 1.0 as the source), DbList is split based on physical table shards to generate multiple subtasks. The DbList of each subtask supports up to 1 MB of data.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;dtstest\&quot;:{\&quot;name\&quot;:\&quot;dtstest\&quot;,\&quot;all\&quot;:true,\&quot;conflict\&quot;:\&quot;overwrite\&quot;}}</para>
        /// </summary>
        [NameInMap("DbList")]
        [Validation(Required=false)]
        public string DbList { get; set; }

        /// <summary>
        /// <para>The DbList mode for SQL Server disaster recovery. Set this parameter to 0. Valid values are 0, 1, and 2, and the value must be consistent within the same group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("DbListMode")]
        [Validation(Required=false)]
        public int? DbListMode { get; set; }

        /// <summary>
        /// <para>The ID of the existing dedicated cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dhg-4kv98863455z***</para>
        /// </summary>
        [NameInMap("DedicatedHostGroupId")]
        [Validation(Required=false)]
        public string DedicatedHostGroupId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable deletion protection for the resource stack. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Enabled: enables deletion protection for the resource stack.</description></item>
        /// <item><description>Disabled (default): disables deletion protection for the resource stack. In this case, you can release the resource stack by using the console or calling the DeleteStack operation.</description></item>
        /// </list>
        /// <remarks>
        /// <para>The deletion protection settings for a nested resource stack are the same as those for the root resource stack.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DeletionProtection")]
        [Validation(Required=false)]
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a precheck. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: yes. After the precheck succeeds, no changes are made to the instance.</description></item>
        /// <item><description><b>false</b> (default): no. After the precheck succeeds, the database instance of the DTS task is modified and the task is run.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The ID of the encryption key. If encryption is disabled, this parameter is empty.</para>
        /// <remarks>
        /// <para>After disk encryption is enabled for a cloud disk instance, it cannot be disabled.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>07609cc3-3109-408f-a35e-c548e776***</para>
        /// </summary>
        [NameInMap("EncryptionKey")]
        [Validation(Required=false)]
        public string EncryptionKey { get; set; }

        /// <summary>
        /// <para>The database engine type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SQLServer</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The database engine version of the instance. The valid values vary based on the database engine type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8.0</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>The network type of the instance. Set the value to <b>VPC</b>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Only VPCs are supported in Alibaba Cloud.</description></item>
        /// <item><description>If you do not specify this parameter, the default value VPC is used.</description></item>
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
        /// <para>Specifies whether to enable the Buffer Pool Extension (BPE) feature for premium performance disks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: enables the feature.</description></item>
        /// <item><description><b>0</b>: disables the feature.</description></item>
        /// </list>
        /// <remarks>
        /// <para>For more information about the Buffer Pool Extension (BPE) feature, see <a href="https://help.aliyun.com/document_detail/2527067.html">Buffer Pool Extension (BPE)</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IoAccelerationEnabled")]
        [Validation(Required=false)]
        public string IoAccelerationEnabled { get; set; }

        /// <summary>
        /// <para>Specifies whether the primary instance account exists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("MasterAccountExist")]
        [Validation(Required=false)]
        public bool? MasterAccountExist { get; set; }

        /// <summary>
        /// <para>The privileged account of the primary instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gadtest</para>
        /// </summary>
        [NameInMap("MasterAccountName")]
        [Validation(Required=false)]
        public string MasterAccountName { get; set; }

        /// <summary>
        /// <para>The password of the primary instance account.</para>
        /// 
        /// <b>Example:</b>
        /// <password>
        /// </summary>
        [NameInMap("MasterAccountPassword")]
        [Validation(Required=false)]
        public string MasterAccountPassword { get; set; }

        /// <summary>
        /// <para>This parameter is specific to MongoDB. The architecture type of the primary database. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: replica set.</description></item>
        /// <item><description>2: sharded cluster.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MasterDatabaseName")]
        [Validation(Required=false)]
        public string MasterDatabaseName { get; set; }

        /// <summary>
        /// <para>This parameter is specific to MongoDB. The architecture type of the primary database. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: replica set.</description></item>
        /// <item><description>2: sharded cluster.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MasterEngineArchType")]
        [Validation(Required=false)]
        public string MasterEngineArchType { get; set; }

        /// <summary>
        /// <para>The primary instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-j6c685vh0j0y1k***</para>
        /// </summary>
        [NameInMap("MasterInstanceId")]
        [Validation(Required=false)]
        public string MasterInstanceId { get; set; }

        /// <summary>
        /// <para>The region where the primary instance resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hongkong</para>
        /// </summary>
        [NameInMap("MasterRegion")]
        [Validation(Required=false)]
        public string MasterRegion { get; set; }

        /// <summary>
        /// <para>The shard account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>db_test</para>
        /// </summary>
        [NameInMap("MasterShardAccountName")]
        [Validation(Required=false)]
        public string MasterShardAccountName { get; set; }

        /// <summary>
        /// <para>The password of the shard account.</para>
        /// 
        /// <b>Example:</b>
        /// <password>
        /// </summary>
        [NameInMap("MasterShardAccountPassword")]
        [Validation(Required=false)]
        public string MasterShardAccountPassword { get; set; }

        /// <summary>
        /// <para>Specifies whether to purchase a new secondary instance. If this parameter is set to false, an existing instance is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("NeedCreateSlave")]
        [Validation(Required=false)]
        public bool? NeedCreateSlave { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>The billing method of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PrePaid</b>: subscription.</description></item>
        /// <item><description><b>PostPaid</b>: pay-as-you-go.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Prepaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The billing method for subscription instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Year</b>: yearly.</description></item>
        /// <item><description><b>Month</b>: monthly.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is valid and required only when the billing method is <b>PrePaid</b> (subscription).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The database service port of the destination instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5432</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public string Port { get; set; }

        /// <summary>
        /// <para>Settings for the internal network IP address of the instance. The IP address must be within the IP address range of the specified vSwitch. By default, the system automatically allocates an IP address based on the VpcId and VSwitchId parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.60.22.91</para>
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// <para>The region ID of the primary instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hongkong</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmx4gs2dcym***</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The global resource descriptor (ARN) for the authorization of the RDS cloud service account by the primary account to access KMS. You can call the CheckCloudResourceAuthorized operation to query the ARN.</para>
        /// <remarks>
        /// <para>Notice: When you enable cloud disk encryption, you must specify <b>RoleARN</b>.</notice></para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::1929332604914597:role/aliyunr***tanceencryptiondefaultrole</para>
        /// </summary>
        [NameInMap("RoleARN")]
        [Validation(Required=false)]
        public string RoleARN { get; set; }

        /// <summary>
        /// <para>The IP addresses that are added to the whitelist of the instance. Separate multiple IP addresses with commas (,). Note: If you set this parameter to 127.0.0.1, access from all IP addresses is denied. If you set this parameter to 192.168.0.0/24, access from all IP addresses in the 192.168.0.XX format is allowed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.16.0.0/12</para>
        /// </summary>
        [NameInMap("SecurityIPList")]
        [Validation(Required=false)]
        public string SecurityIPList { get; set; }

        /// <summary>
        /// <para>The settings of the Serverless instance. This parameter is required when you create a Serverless instance.</para>
        /// </summary>
        [NameInMap("ServerlessConfig")]
        [Validation(Required=false)]
        public string ServerlessConfigShrink { get; set; }

        /// <summary>
        /// <para>Specifies whether the secondary instance account exists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SlaveAccountExist")]
        [Validation(Required=false)]
        public bool? SlaveAccountExist { get; set; }

        /// <summary>
        /// <para>The account with the same name on the secondary instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gadtest</para>
        /// </summary>
        [NameInMap("SlaveAccountName")]
        [Validation(Required=false)]
        public string SlaveAccountName { get; set; }

        /// <summary>
        /// <para>The password of the secondary instance account.</para>
        /// 
        /// <b>Example:</b>
        /// <password>
        /// </summary>
        [NameInMap("SlaveAccountPassword")]
        [Validation(Required=false)]
        public string SlaveAccountPassword { get; set; }

        /// <summary>
        /// <para>The name of the secondary database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>slave_database</para>
        /// </summary>
        [NameInMap("SlaveDatabaseName")]
        [Validation(Required=false)]
        public string SlaveDatabaseName { get; set; }

        /// <summary>
        /// <para>This parameter is specific to MongoDB. The architecture type of the secondary database. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: replica set.</description></item>
        /// <item><description>2: sharded cluster.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SlaveEngineArchType")]
        [Validation(Required=false)]
        public string SlaveEngineArchType { get; set; }

        /// <summary>
        /// <para>The secondary instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-t4nb481a8qn0b3***</para>
        /// </summary>
        [NameInMap("SlaveInstanceId")]
        [Validation(Required=false)]
        public string SlaveInstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether the secondary instance is read-only.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SlaveReadOnly")]
        [Validation(Required=false)]
        public bool? SlaveReadOnly { get; set; }

        /// <summary>
        /// <para>The region where the secondary instance resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ap-southeast-1</para>
        /// </summary>
        [NameInMap("SlaveRegion")]
        [Validation(Required=false)]
        public string SlaveRegion { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Automatic storage scaling for the Standard Edition cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Enable: enables Automatic storage scaling.</description></item>
        /// <item><description>Disable: shutdown Automatic storage scaling.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Disable</para>
        /// </summary>
        [NameInMap("StorageAutoScale")]
        [Validation(Required=false)]
        public string StorageAutoScale { get; set; }

        /// <summary>
        /// <para>The threshold (in percentage) that triggers automatic storage expansion. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>10</b></description></item>
        /// <item><description><b>20</b></description></item>
        /// <item><description><b>30</b></description></item>
        /// <item><description><b>40</b></description></item>
        /// <item><description><b>50</b></description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required when <b>StorageAutoScale</b> is set to <b>Enable</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("StorageThreshold")]
        [Validation(Required=false)]
        public int? StorageThreshold { get; set; }

        /// <summary>
        /// <para>The Settings for the upper limit of Automatic storage scaling for the Standard Edition cluster. Unit: GB.</para>
        /// <remarks>
        /// <para>The maximum value is 32000.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>64000</para>
        /// </summary>
        [NameInMap("StorageUpperBound")]
        [Validation(Required=false)]
        public int? StorageUpperBound { get; set; }

        /// <summary>
        /// <para>The synchronization account type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user</para>
        /// </summary>
        [NameInMap("SyncAccountType")]
        [Validation(Required=false)]
        public string SyncAccountType { get; set; }

        /// <summary>
        /// <para>The synchronization topology. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>oneway</b>: one-way synchronization. This is the default value.</description></item>
        /// <item><description><b>bidirectional</b>: two-way synchronization.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>oneway</para>
        /// </summary>
        [NameInMap("SyncArchitecture")]
        [Validation(Required=false)]
        public string SyncArchitecture { get; set; }

        /// <summary>
        /// <para>The conflict resolution policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ignore</para>
        /// </summary>
        [NameInMap("SyncConflict")]
        [Validation(Required=false)]
        public string SyncConflict { get; set; }

        /// <summary>
        /// <para><b>[Deprecated]</b> This parameter is deprecated and does not need to be configured.</para>
        /// 
        /// <b>Example:</b>
        /// <para>utf8</para>
        /// </summary>
        [NameInMap("SystemDBCharset")]
        [Validation(Required=false)]
        public string SystemDBCharset { get; set; }

        /// <summary>
        /// <para>The tags of the data migration instance. This parameter is used as a filter. If this parameter is not empty, only the instance tasks that have the specified tags are returned.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateGadOrderShrinkRequestTag> Tag { get; set; }
        public class CreateGadOrderShrinkRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. You can call the <a href="https://help.aliyun.com/document_detail/191187.html">ListTagResources</a> operation to query the tag key.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>N indicates the sequence number of the tag key. For example, Tag.1.Key indicates the key of the first tag, and Tag.2.Key indicates the key of the second tag. You can specify 1 to 20 tag keys at a time.</description></item>
            /// </list>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>This parameter cannot be set to an empty string.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>testkey1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. You can call the <a href="https://help.aliyun.com/document_detail/191187.html">ListTagResources</a> operation to query the tag value.</para>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>N indicates the sequence number of the tag value. For example, Tag.1.Value indicates the value of the first tag, and Tag.2.Value indicates the value of the second tag. You can specify 1 to 20 tag values at a time.</description></item>
            /// </list>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>This parameter can be set to an empty string.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>testvalue1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the host on which the logger instance is created in the dedicated cluster.</para>
        /// <para>This parameter is required when you create an RDS Enterprise Edition instance in a dedicated cluster. If you do not specify this parameter, the system automatically allocates a host by default.</para>
        /// <list type="bullet">
        /// <item><description>You can invoke the DescribeDedicatedHosts operation to query the host information in the dedicated cluster.</description></item>
        /// <item><description>If no hosts are active, you can invoke the CreateDedicatedHost operation to create a host.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp****</para>
        /// </summary>
        [NameInMap("TargetDedicatedHostIdForLog")]
        [Validation(Required=false)]
        public string TargetDedicatedHostIdForLog { get; set; }

        /// <summary>
        /// <para>The ID of the host on which the primary instance is created in the dedicated cluster.</para>
        /// <para>This parameter is required when you create an instance in a dedicated cluster. If you do not specify this parameter, the system automatically assigns a host.</para>
        /// <para>You can call the DescribeDedicatedHosts operation to query the host information in the dedicated cluster.
        /// If no hosts are available, you can call the CreateDedicatedHost operation to create a host.</para>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp****</para>
        /// </summary>
        [NameInMap("TargetDedicatedHostIdForMaster")]
        [Validation(Required=false)]
        public string TargetDedicatedHostIdForMaster { get; set; }

        /// <summary>
        /// <para>The ID of the host on which the secondary instance is created in the dedicated cluster.</para>
        /// <para>This parameter is required when you create a high availability series or RDS Enterprise Edition instance in a dedicated cluster. If you do not specify this parameter, the system automatically allocates a host by default.</para>
        /// <list type="bullet">
        /// <item><description>You can invoke the DescribeDedicatedHosts operation to query the host information in the dedicated cluster.</description></item>
        /// <item><description>If no hosts are active, you can invoke the CreateDedicatedHost operation to create a host.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp****</para>
        /// </summary>
        [NameInMap("TargetDedicatedHostIdForSlave")]
        [Validation(Required=false)]
        public string TargetDedicatedHostIdForSlave { get; set; }

        /// <summary>
        /// <para>The minor engine version of the ApsaraDB RDS instance. This parameter is required only when you create a MySQL or PostgreSQL instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds_postgres_1700_20260***</para>
        /// </summary>
        [NameInMap("TargetMinorVersion")]
        [Validation(Required=false)]
        public string TargetMinorVersion { get; set; }

        /// <summary>
        /// <para>The purchase duration for subscription instances.</para>
        /// <list type="bullet">
        /// <item><description>When <b>Period</b> is set to <b>Month</b>, valid values are 1, 2, 3, 4, 5, 6, 7, 8, and 9.</description></item>
        /// <item><description>When <b>Period</b> is set to <b>Year</b>, valid values are 1, 2, 3, and 5.<remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is valid and required only when <b>PayType</b> is set to <b>PrePaid</b>.</description></item>
        /// </list>
        /// </remarks>
        /// </description></item>
        /// <item><description>For the billing method of subscription instances, you can specify it in the <b>Period</b> parameter.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public string UsedTime { get; set; }

        /// <summary>
        /// <para>The ID of the user backup. You can call the ListUserBackupFiles operation to query the ID. If you specify this parameter, the instance is created based on the user backup.</para>
        /// <para>If you specify this parameter, the following limits apply:</para>
        /// <list type="bullet">
        /// <item><description>The PayType parameter must be set to Postpaid.</description></item>
        /// <item><description>The Engine parameter must be set to MySQL.</description></item>
        /// <item><description>The EngineVersion parameter must be set to 5.7.</description></item>
        /// <item><description>The Category parameter must be set to Basic.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>67798****</para>
        /// </summary>
        [NameInMap("UserBackupId")]
        [Validation(Required=false)]
        public string UserBackupId { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch in the VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-wz9gttyapd3i9dmzn***</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-m5ehjekt8mzvyyx5a1***</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The whitelist. To configure multiple IP addresses, separate the IP addresses or CIDR blocks with commas (,) without spaces before or after the commas. Example: <c>192.168.0.1,172.16.213.9</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.0.1,172.16.213.9</para>
        /// </summary>
        [NameInMap("WhitelistTemplateList")]
        [Validation(Required=false)]
        public string WhitelistTemplateList { get; set; }

        /// <summary>
        /// <para>The zone ID of the primary node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-b</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

        /// <summary>
        /// <para>The zone ID of the secondary node.</para>
        /// <list type="bullet">
        /// <item><description>If you set this parameter to <b>Auto</b>, it indicates a multi-zone deployment and the system automatically selects an active zone for the secondary node.</description></item>
        /// <item><description>If you set this parameter to the same value as <b>ZoneId</b>, it is a single-zone deployment.</description></item>
        /// <item><description>If you set this parameter to a value different from <b>ZoneId</b>, it is a multi-zone deployment.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing-i</para>
        /// </summary>
        [NameInMap("ZoneIdSlave1")]
        [Validation(Required=false)]
        public string ZoneIdSlave1 { get; set; }

        /// <summary>
        /// <para>The secondary zone 2.</para>
        /// <remarks>
        /// <para>This parameter is active only for instances of the RDS Enterprise Edition.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-chengdu-b</para>
        /// </summary>
        [NameInMap("ZoneIdSlave2")]
        [Validation(Required=false)]
        public string ZoneIdSlave2 { get; set; }

    }

}
