// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateDBInstanceShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The number of ApsaraDB RDS for MySQL instances to create. This parameter is applicable only when you create multiple ApsaraDB RDS for MySQL instances at a time.</para>
        /// <para>Valid values: <b>1</b> to <b>20</b>. Default value: <b>1</b>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>When you create multiple ApsaraDB RDS for MySQL instances, you can use the <b>Tag.Key</b> and <b>Tag.Value</b> parameters to add tags to the instances in the same batch. This facilitates instance management by tag after creation.</description></item>
        /// <item><description>After multiple instances are created, the operation returns only the <b>TaskId</b>, <b>RequestId</b>, and <b>Message</b> parameters, and does not return other detail parameters. To query the details of a specific instance, you can call the DescribeDBInstanceAttribute operation.</description></item>
        /// <item><description>If <b>Engine</b> is not set to <b>MySQL</b> and the value of this parameter is greater than <b>1</b>, the operation fails and returns the error code <c>InvalidParam.Engine</c>.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Amount")]
        [Validation(Required=false)]
        public int? Amount { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically create a proxy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables automatic creation. By default, a general-purpose proxy is created.</description></item>
        /// <item><description><b>false</b>: disables automatic creation.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoCreateProxy")]
        [Validation(Required=false)]
        public bool? AutoCreateProxy { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic payment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables automatic payment. You must ensure that your account balance is sufficient.</description></item>
        /// <item><description><b>false</b>: generates an order without deducting fees.</description></item>
        /// </list>
        /// <remarks>
        /// <para>The default value is true. If your payment method has an insufficient balance, you can set AutoPay to false. In this case, an unpaid order is generated, and you can log on to the ApsaraDB RDS console to pay the order manually.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal for the instance. This parameter is valid only when you create a subscription instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you purchase the instance on a monthly basis, the auto-renewal epoch is one month.</description></item>
        /// <item><description>If you purchase the instance on a yearly basis, the auto-renewal epoch is one year.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public string AutoRenew { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable or disable automatic minor version upgrades. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Auto</b>: Enabled.</description></item>
        /// <item><description><b>Manual</b>: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Auto</para>
        /// </summary>
        [NameInMap("AutoUpgradeMinorVersion")]
        [Validation(Required=false)]
        public string AutoUpgradeMinorVersion { get; set; }

        /// <summary>
        /// <para>Specifies whether to use vouchers. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: uses vouchers.</description></item>
        /// <item><description><b>false</b>: does not use vouchers. This is the default value.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you use vouchers and later need to downgrade the instance configuration, the amount deducted by the vouchers will not be refunded.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public bool? AutoUseCoupon { get; set; }

        /// <summary>
        /// <para>The configuration information of Babelfish for ApsaraDB RDS for PostgreSQL.</para>
        /// <para>Configuration format: {&quot;babelfishEnabled&quot;:&quot;true&quot;,&quot;migrationMode&quot;:&quot;xxxxxxx&quot;,&quot;masterUsername&quot;:&quot;xxxxxxx&quot;,&quot;masterUserPassword&quot;:&quot;xxxxxxxx&quot;}</para>
        /// <para>Parameter description:</para>
        /// <list type="bullet">
        /// <item><description><b>babelfishEnabled</b>: specifies whether to enable Babelfish. Set the value to <b>true</b> to enable Babelfish. By default, Babelfish is disabled.</description></item>
        /// <item><description><b>migrationMode</b>: the database mode. Set the value to <b>single-db</b> for the single-database mode or <b>multi-db</b> for the multi-database mode.</description></item>
        /// <item><description><b>masterUsername</b>: the initial administrator account. The username must be 1 to 63 characters in length and can contain lowercase letters, digits, and underscores (_). It must start with a letter and end with a letter or digit. It cannot start with pg.</description></item>
        /// <item><description><b>masterUserPassword</b>: the password of the administrator account. The password must be 8 to 32 characters in length and must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. Special characters include <c>! @ # $ % ^ &amp; * () _ + - =</c>.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is applicable only to ApsaraDB RDS for PostgreSQL instances. For more information about Babelfish for ApsaraDB RDS for PostgreSQL, see <a href="https://help.aliyun.com/document_detail/428613.html">Babelfish overview</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;babelfishEnabled&quot;:&quot;true&quot;,&quot;migrationMode&quot;:&quot;single-db&quot;,&quot;masterUsername&quot;:&quot;babelfish_user&quot;,&quot;masterUserPassword&quot;:&quot;Babelfish123!&quot;}</para>
        /// </summary>
        [NameInMap("BabelfishConfig")]
        [Validation(Required=false)]
        public string BabelfishConfig { get; set; }

        [NameInMap("BpeEnabled")]
        [Validation(Required=false)]
        public string BpeEnabled { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the I/O performance burst feature for premium cloud disks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables the feature.</description></item>
        /// <item><description><b>false</b>: disables the feature.<remarks>
        /// <para>For more information about the I/O performance burst feature for premium cloud disks, see <a href="https://help.aliyun.com/document_detail/2340501.html">What is a premium cloud disk?</a>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("BurstingEnabled")]
        [Validation(Required=false)]
        public bool? BurstingEnabled { get; set; }

        /// <summary>
        /// <para>The extended business parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>121436975448952</para>
        /// </summary>
        [NameInMap("BusinessInfo")]
        [Validation(Required=false)]
        public string BusinessInfo { get; set; }

        /// <summary>
        /// <para>The instance edition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Regular instances</para>
        /// <list type="bullet">
        /// <item><description><b>Basic</b>: Basic Edition.</description></item>
        /// <item><description><b>HighAvailability</b>: high-availability series.</description></item>
        /// <item><description><b>cluster</b>: Cluster Edition for MySQL or PostgreSQL.</description></item>
        /// <item><description><b>AlwaysOn</b>: Cluster Edition for SQL Server.</description></item>
        /// <item><description><b>Finance</b>: RDS Enterprise Edition.<remarks>
        /// <para>This parameter is required when you create a SQL Server RDS Enterprise Edition&lt;props=&quot;china&quot;&gt;, Basic Edition Standard Edition, or Basic Edition Enterprise Edition instance. For example, when you create a Basic Edition 2022 RDS Enterprise Edition (2022_ent) instance, you must set this parameter to Basic.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Serverless instances</para>
        /// <list type="bullet">
        /// <item><description><b>serverless_basic</b>: Serverless Basic Edition. This value is applicable only to MySQL and PostgreSQL.</description></item>
        /// <item><description><b>serverless_standard</b>: Serverless high-availability series. This value is applicable only to MySQL and PostgreSQL.</description></item>
        /// <item><description><b>serverless_ha</b>: Serverless high-availability series for SQL Server.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required when PayType is set to Serverless.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>HighAvailability</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request and prevent duplicate submissions. You can use the client to generate the value, but you must ensure that the value is unique across different requests. The value can contain a maximum of 64 ASCII characters and cannot contain non-ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCz****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the <a href="https://help.aliyun.com/document_detail/2701832.html">data archiving</a> feature for premium cloud disks. Valid values:</para>
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
        /// <para>The default value is allocated by the RDS system.</para>
        /// <remarks>
        /// <para>SQL Server 2012, 2016, and 2017 instances support only the standard access mode.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("ConnectionMode")]
        [Validation(Required=false)]
        public string ConnectionMode { get; set; }

        /// <summary>
        /// <para>The internal endpoint of the database.</para>
        /// <para>Endpoint format: <c>xxx.mysql.rds.aliyuncs.com</c>, where <c>xxx</c> is the prefix of the instance ID, such as rm-uf6wjk5***.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5****.mysql.rds.aliyuncs.com</para>
        /// </summary>
        [NameInMap("ConnectionString")]
        [Validation(Required=false)]
        public string ConnectionString { get; set; }

        /// <summary>
        /// <para>The strategy for creating multiple instances at a time. This parameter takes effect only when <b>Amount</b> is greater than 1. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Atomicity</b>: atomicity. All instances in the same batch are created successfully, or if one instance fails to be created, all instances fail to be created. This is the default value.</description></item>
        /// <item><description><b>Partial</b>: non-atomicity. The creation of an instance is not affected by other instances in the same batch.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Atomicity</para>
        /// </summary>
        [NameInMap("CreateStrategy")]
        [Validation(Required=false)]
        public string CreateStrategy { get; set; }

        [NameInMap("CustomExtraInfo")]
        [Validation(Required=false)]
        public string CustomExtraInfo { get; set; }

        /// <summary>
        /// <para>The instance type. You can specify a standard or YiTian instance type. For details, see <a href="https://help.aliyun.com/document_detail/26312.html">Primary ApsaraDB RDS instance types</a>.</para>
        /// <para>To create a Serverless instance, specify one of the following values:</para>
        /// <list type="bullet">
        /// <item><description>MySQL Basic Edition: <b>mysql.n2.serverless.1c</b></description></item>
        /// <item><description>MySQL high-availability series: <b>mysql.n2.serverless.2c</b></description></item>
        /// <item><description>SQL Server: <b>mssql.mem2.serverless.s2</b></description></item>
        /// <item><description>PostgreSQL Basic Edition: <b>pg.n2.serverless.1c</b></description></item>
        /// <item><description>PostgreSQL high-availability series: <b>pg.n2.serverless.2c</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mysql.n2.medium.2c</para>
        /// </summary>
        [NameInMap("DBInstanceClass")]
        [Validation(Required=false)]
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// <para>The description of the instance. The description must be 2 to 255 characters in length. It must start with a letter and can contain letters, digits, Chinese characters, and hyphens (-).</para>
        /// <remarks>
        /// <para>The description cannot start with http:// or https://.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testInstance</para>
        /// </summary>
        [NameInMap("DBInstanceDescription")]
        [Validation(Required=false)]
        public string DBInstanceDescription { get; set; }

        /// <summary>
        /// <para>The network connectivity type of the instance. Set the value to <b>Intranet</b>, which indicates an internal network connection.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Intranet</para>
        /// </summary>
        [NameInMap("DBInstanceNetType")]
        [Validation(Required=false)]
        public string DBInstanceNetType { get; set; }

        /// <summary>
        /// <para>Instance storage capacity of the instance. Unit: GB. Instance storage capacity increases in increments of 5 GB. For more information about the valid values, see <a href="https://help.aliyun.com/document_detail/26312.html">Primary ApsaraDB RDS instance types</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("DBInstanceStorage")]
        [Validation(Required=false)]
        public int? DBInstanceStorage { get; set; }

        /// <summary>
        /// <para>The instance storage type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>local_ssd</b>: premium local SSD (recommended).</description></item>
        /// <item><description><b>general_essd</b>: premium cloud disk (recommended).</description></item>
        /// <item><description><b>cloud_essd</b>: PL1 ESSD.</description></item>
        /// <item><description><b>cloud_essd2</b>: PL2 ESSD.</description></item>
        /// <item><description><b>cloud_essd3</b>: PL3 ESSD.</description></item>
        /// <item><description><b>cloud_ssd</b>: standard SSD (not recommended, and no longer available in some regions).</description></item>
        /// </list>
        /// <para>The default value of this parameter is automatically determined based on the instance type specified by <b>DBInstanceClass</b>:</para>
        /// <list type="bullet">
        /// <item><description>If the instance type code indicates a premium local SSD, the default value is <b>local_ssd</b>.</description></item>
        /// <item><description>If the instance type code indicates a cloud disk, the default value is <b>cloud_essd</b>.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Serverless instances support only PL1 ESSDs and premium cloud disks.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>general_essd</para>
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
        /// <para>The ID of the parameter template. You can call the DescribeParameterGroups operation to query the parameter template ID.</para>
        /// <remarks>
        /// <para>This parameter is supported only by MySQL and PostgreSQL. If you do not specify this parameter, the default parameter template is used. You can also create a custom parameter template and specify it here.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rpg-sys-****</para>
        /// </summary>
        [NameInMap("DBParamGroupId")]
        [Validation(Required=false)]
        public string DBParamGroupId { get; set; }

        /// <summary>
        /// <para>The time zone of the instance. This parameter takes effect only when <b>Engine</b> is set to <b>MySQL</b> or <b>PostgreSQL</b>.</para>
        /// <list type="bullet">
        /// <item><description>If <b>Engine</b> is set to <b>MySQL</b>:<list type="bullet">
        /// <item><description>This parameter configures the UTC time zone. Valid values: <b>-12:59</b> to <b>+13:00</b>.</description></item>
        /// <item><description>For an instance with premium local SSDs, you can specify a named time zone, such as Asia/Hong_Kong. For more information about named time zones, see <a href="https://help.aliyun.com/document_detail/297356.html">Named time zones</a>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>If <b>Engine</b> is set to <b>PostgreSQL</b>:<list type="bullet">
        /// <item><description>This parameter configures a named time zone. UTC time zones are not supported. For more information about named time zones, see <a href="https://help.aliyun.com/document_detail/297356.html">Named time zones</a>.</description></item>
        /// <item><description>This parameter can be configured only for ApsaraDB RDS for PostgreSQL instances with cloud disks.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You can set the time zone when you purchase a primary instance. Read-only instances do not support time zone settings and inherit the time zone of the primary instance.</description></item>
        /// <item><description>If you do not specify this parameter, the system selects the default time zone based on the region where the instance is created.</description></item>
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
        /// <para>The ID of the dedicated cluster host group.</para>
        /// <para>This parameter is required when you create an instance in a dedicated cluster.</para>
        /// <list type="bullet">
        /// <item><description>You can call the DescribeDedicatedHostGroups operation to query the host group information.</description></item>
        /// <item><description>If you have not created a host group, you can call the CreateDedicatedHostGroup operation to create one.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>dhg-4n****</para>
        /// </summary>
        [NameInMap("DedicatedHostGroupId")]
        [Validation(Required=false)]
        public string DedicatedHostGroupId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the release protection feature for the ApsaraDB RDS instance. This feature is supported only for pay-as-you-go instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables the feature.</description></item>
        /// <item><description><b>false</b>: disables the feature. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DeletionProtection")]
        [Validation(Required=false)]
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a precheck for the instance creation operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs a precheck but does not create the instance. The check items include request parameters, request format, business limits, and inventory.</description></item>
        /// <item><description><b>false</b>: sends a normal request and creates the instance directly after the check passes. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The ID of the key used for cloud disk encryption in the same region. If you specify this parameter, cloud disk encryption is enabled and cannot be disabled. You must also specify <b>RoleARN</b>.</para>
        /// <para>You can view the key ID in the Key Management Service (KMS) console or create a new key. For more information, see <a href="https://help.aliyun.com/document_detail/181610.html">Create a CMK</a>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>For ApsaraDB RDS for MySQL, ApsaraDB RDS for PostgreSQL, and ApsaraDB RDS for SQL Server instances, you do not need to specify this parameter. You only need to specify <b>RoleARN</b> to use the service key to create an instance with cloud disk encryption enabled.</description></item>
        /// <item><description>If RAM authorization requires RAM users to enable cloud disk encryption when creating instances, the instances cannot be created if cloud disk encryption is not enabled. Configure the following RAM policy for the RAM user:
        /// <c>{&quot;Version&quot;:&quot;1&quot;,&quot;Statement&quot;:[{&quot;Effect&quot;:&quot;Deny&quot;,&quot;Action&quot;:&quot;rds:CreateDBInstance&quot;,&quot;Resource&quot;:&quot;*&quot;,&quot;Condition&quot;:{&quot;StringEquals&quot;:{&quot;rds:DiskEncryptionRequired&quot;:&quot;false&quot;}}}]}</c>
        /// Warning: This configuration also affects the CreateOrder operation for creating instances in the console.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0d24*****-da7b-4786-b981-9a164dxxxxxx</para>
        /// </summary>
        [NameInMap("EncryptionKey")]
        [Validation(Required=false)]
        public string EncryptionKey { get; set; }

        /// <summary>
        /// <para>The database engine. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>MySQL</b></description></item>
        /// <item><description><b>SQLServer</b></description></item>
        /// <item><description><b>PostgreSQL</b></description></item>
        /// <item><description><b>MariaDB</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("Engine")]
        [Validation(Required=false)]
        public string Engine { get; set; }

        /// <summary>
        /// <para>The database engine version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Regular instances<list type="bullet">
        /// <item><description>MySQL: <b>5.5</b>, <b>5.6</b>, <b>5.7</b>, and <b>8.0</b></description></item>
        /// <item><description>SQL Server: <b>08r2_ent_ha</b> (cloud disk edition, discontinued), <b>2008r2</b> (premium local SSD, discontinued), <b>2012</b> (Enterprise Edition standalone), <b>2012_ent_ha</b>, <b>2012_std_ha</b>, <b>2012_web</b>, <b>2014_ent_ha</b>, <b>2014_std_ha</b>, <b>2016_ent_ha</b>, <b>2016_std_ha</b>, <b>2016_web</b>, <b>2017_ent</b>, <b>2017_std_ha</b>, <b>2017_web</b>, <b>2019_ent</b>, <b>2019_std_ha</b>, <b>2019_web</b>, <b>2022_ent</b>, <b>2022_std_ha</b>, <b>2022_web</b>, <b>2025_ent</b>, and <b>2025_std</b></description></item>
        /// <item><description>PostgreSQL: <b>10.0</b>, <b>11.0</b>, <b>12.0</b>, <b>13.0</b>, <b>14.0</b>, <b>15.0</b>, <b>16.0</b>, <b>17.0</b>, and <b>18.0</b></description></item>
        /// <item><description>MariaDB: <b>10.3</b> and <b>10.6</b></description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Serverless instances<list type="bullet">
        /// <item><description>MySQL: <b>5.7</b> and <b>8.0</b></description></item>
        /// <item><description>SQL Server: <b>2016_std_sl</b>, <b>2017_std_sl</b>, and <b>2019_std_sl</b></description></item>
        /// <item><description>PostgreSQL: <b>14.0</b>, <b>15.0</b>, <b>16.0</b>, <b>17.0</b>, and <b>18.0</b></description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>MariaDB does not support Serverless instances.</description></item>
        /// <item><description>For SQL Server instances, <c>_ent</c> indicates Enterprise Cluster Edition, <c>_ent_ha</c> indicates Enterprise Edition, <c>_std_ha</c> indicates Standard Edition, and <c>_web</c> indicates Web Edition.</description></item>
        /// <item><description>SQL Server 2014 instances are not available on the international site.</description></item>
        /// <item><description>Babelfish for ApsaraDB RDS for PostgreSQL instances support only major version 15.0.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8.0</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable <a href="https://help.aliyun.com/document_detail/2856526.html">native replication for ApsaraDB RDS for MySQL</a>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ON</b>: enables the feature.</description></item>
        /// <item><description><b>OFF</b>: disables the feature.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ON</para>
        /// </summary>
        [NameInMap("ExternalReplication")]
        [Validation(Required=false)]
        public bool? ExternalReplication { get; set; }

        /// <summary>
        /// <para>The network type of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VPC</b>: VPC.</description></item>
        /// <item><description><b>Classic</b>: classic network.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL cloud disk instances support only VPCs. You must set this parameter to <b>VPC</b>.</description></item>
        /// <item><description>ApsaraDB RDS for PostgreSQL and ApsaraDB RDS for MariaDB instances support only VPCs. You must set this parameter to <b>VPC</b>.</description></item>
        /// <item><description>ApsaraDB RDS for SQL Server Basic Edition and Web Edition instances support both the classic network and VPCs. Other instances support only VPCs. You must set this parameter to <b>VPC</b>.</description></item>
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
        /// <para>Specifies whether to enable the <a href="https://help.aliyun.com/document_detail/2527067.html">Buffer Pool Extension (BPE)</a> feature for premium cloud disks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: enables the feature.</description></item>
        /// <item><description><b>0</b>: disables the feature.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IoAccelerationEnabled")]
        [Validation(Required=false)]
        public string IoAccelerationEnabled { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the <a href="https://help.aliyun.com/document_detail/2858761.html">16KB atomic write</a> feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>optimized</b>: enables the feature.</description></item>
        /// <item><description><b>none</b>: disables the feature. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>optimized</para>
        /// </summary>
        [NameInMap("OptimizedWrites")]
        [Validation(Required=false)]
        public string OptimizedWrites { get; set; }

        /// <summary>
        /// <para>The billing method of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Postpaid</b>: pay-as-you-go.</description></item>
        /// <item><description><b>Prepaid</b>: subscription.</description></item>
        /// <item><description><b>Serverless</b>: serverless billing method. MariaDB instances are not supported. For more information, see <a href="https://help.aliyun.com/document_detail/411291.html">Overview of ApsaraDB RDS for MySQL Serverless instances</a>, <a href="https://help.aliyun.com/document_detail/604344.html">Overview of ApsaraDB RDS for SQL Server Serverless instances</a>, and <a href="https://help.aliyun.com/document_detail/607742.html">Overview of ApsaraDB RDS for PostgreSQL Serverless instances</a>.<remarks>
        /// <para>The system automatically generates an order and completes the payment. You do not need to manually confirm the payment.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Postpaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The subscription period of the subscription instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Year</b>: yearly subscription.</description></item>
        /// <item><description><b>Month</b>: monthly subscription.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required when <b>PayType</b> is set to <b>Prepaid</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Year</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The port used to initialize the instance during creation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>MySQL: 1000 to 65534</description></item>
        /// <item><description>PostgreSQL, SQL Server, and MariaDB: 1000 to 5999</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3306</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public string Port { get; set; }

        /// <summary>
        /// <para>The internal IP address of the instance. The IP address must be within the address range of the specified vSwitch. By default, the system automatically allocates an IP address based on <b>VPCId</b> and <b>VSwitchId</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>172.16.XX.XX</para>
        /// </summary>
        [NameInMap("PrivateIpAddress")]
        [Validation(Required=false)]
        public string PrivateIpAddress { get; set; }

        /// <summary>
        /// <para>The coupon code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliwood-1688-mobile-promotion</para>
        /// </summary>
        [NameInMap("PromotionCode")]
        [Validation(Required=false)]
        public string PromotionCode { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the <a href="https://help.aliyun.com/document_detail/610399.html">DescribeRegions</a> operation to query the region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmy****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The global resource descriptor (ARN) used for the authorization of the ApsaraDB RDS service account to access KMS. You can invoke the CheckCloudResourceAuthorized operation to query the ARN.</para>
        /// <remarks>
        /// <para>Notice: When you enable cloud disk encryption, you must specify <b>RoleARN</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::1406****:role/aliyunrdsinstanceencryptiondefaultrole</para>
        /// </summary>
        [NameInMap("RoleARN")]
        [Validation(Required=false)]
        public string RoleARN { get; set; }

        /// <summary>
        /// <para>The <a href="https://help.aliyun.com/document_detail/43185.html">IP address whitelist</a> of the instance. Separate multiple IP addresses or CIDR blocks with commas (,). Duplicate IP addresses or CIDR blocks are not allowed. You can add up to 1,000 IP addresses or CIDR blocks to the whitelist of a single instance. The following formats are supported:</para>
        /// <list type="bullet">
        /// <item><description>IP addresses, such as 10.10.XX.XX.</description></item>
        /// <item><description>CIDR blocks, such as 10.10.XX.XX/24. In this example, 24 indicates the length of the prefix in the CIDR block, and the prefix length ranges from 1 to 32.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.10.XX.XX/24</para>
        /// </summary>
        [NameInMap("SecurityIPList")]
        [Validation(Required=false)]
        public string SecurityIPList { get; set; }

        /// <summary>
        /// <para>The settings for the ApsaraDB RDS Serverless instance. This parameter is required when you create a Serverless instance.</para>
        /// <remarks>
        /// <para>MariaDB does not support Serverless instances.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ServerlessConfig")]
        [Validation(Required=false)]
        public string ServerlessConfigShrink { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic storage expansion. This parameter is supported only by MySQL and PostgreSQL. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enable</b>: enables automatic storage expansion.</description></item>
        /// <item><description><b>Disable</b>: disables automatic storage expansion. This is the default value.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You can also call the ModifyDasInstanceConfig operation to adjust this setting after the instance is created. For more information, see <a href="https://help.aliyun.com/document_detail/173826.html">Enable automatic storage expansion</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Disable</para>
        /// </summary>
        [NameInMap("StorageAutoScale")]
        [Validation(Required=false)]
        public string StorageAutoScale { get; set; }

        /// <summary>
        /// <para>The threshold percentage that triggers automatic storage expansion. Valid values:</para>
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
        /// <para>50</para>
        /// </summary>
        [NameInMap("StorageThreshold")]
        [Validation(Required=false)]
        public int? StorageThreshold { get; set; }

        /// <summary>
        /// <para>The upper limit of the total storage capacity for automatic storage expansion. The automatic expansion does not cause the total storage capacity of the instance to exceed this value. Unit: GB.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The value must be greater than or equal to 0.</description></item>
        /// <item><description>This parameter is required when <b>StorageAutoScale</b> is set to <b>Enable</b>.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("StorageUpperBound")]
        [Validation(Required=false)]
        public int? StorageUpperBound { get; set; }

        /// <summary>
        /// <para>Deprecated. You do not need to configure this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gbk</para>
        /// </summary>
        [NameInMap("SystemDBCharset")]
        [Validation(Required=false)]
        public string SystemDBCharset { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateDBInstanceShrinkRequestTag> Tag { get; set; }
        public class CreateDBInstanceShrinkRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. You can specify this parameter to add a tag to the instance.</para>
            /// <list type="bullet">
            /// <item><description>If the specified tag key already exists, the tag key is directly added to the instance. You can call the ListTagResources operation to query existing tags.</description></item>
            /// <item><description>If the specified tag key does not exist, the tag key is created and then added to the instance.</description></item>
            /// <item><description>Empty strings are not allowed.</description></item>
            /// <item><description>This parameter must be used together with <b>Tag.Value</b>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>testkey1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value that corresponds to the tag key. You can specify this parameter to add a tag to the instance.</para>
            /// <list type="bullet">
            /// <item><description>If the specified tag value exists for the corresponding tag key, the tag value is directly added to the instance. You can call the ListTagResources operation to query existing tags.</description></item>
            /// <item><description>If the specified tag value does not exist for the corresponding tag key, the tag value is created and then added to the instance.</description></item>
            /// <item><description>This parameter must be used together with <b>Tag.Key</b>.</description></item>
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
        /// <item><description>If you do not have a host, you can invoke the CreateDedicatedHost operation to add one.</description></item>
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
        /// <list type="bullet">
        /// <item><description>You can call the DescribeDedicatedHosts operation to query the host information in the host group.</description></item>
        /// <item><description>If you do not have a host, you can call the CreateDedicatedHost operation to add one.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp****</para>
        /// </summary>
        [NameInMap("TargetDedicatedHostIdForMaster")]
        [Validation(Required=false)]
        public string TargetDedicatedHostIdForMaster { get; set; }

        /// <summary>
        /// <para>The ID of the host on which the secondary instance is created in the dedicated cluster.</para>
        /// <para>This parameter is required when you create a high-availability series or RDS Enterprise Edition instance in a dedicated cluster. If you do not specify this parameter, the system automatically allocates a host by default.</para>
        /// <list type="bullet">
        /// <item><description>You can invoke the DescribeDedicatedHosts operation to query the host information in the dedicated cluster.</description></item>
        /// <item><description>If you do not have a host, you can invoke the CreateDedicatedHost operation to add one.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp****</para>
        /// </summary>
        [NameInMap("TargetDedicatedHostIdForSlave")]
        [Validation(Required=false)]
        public string TargetDedicatedHostIdForSlave { get; set; }

        /// <summary>
        /// <para>The minor engine version of the ApsaraDB RDS instance. This parameter is required only when you create a MySQL or PostgreSQL instance.
        /// Format:</para>
        /// <list type="bullet">
        /// <item><description><para>MySQL: <c>&lt;Instance version&gt;_&lt;Numeric version number&gt;</c>. Examples: <c>rds_20200229</c>, <c>xcluster_20200229</c>, and <c>xcluster80_20200229</c>. Description:</para>
        /// <list type="bullet">
        /// <item><description>rds: high-availability series or Basic Edition.</description></item>
        /// <item><description>xcluster: MySQL 5.7 RDS Enterprise Edition.</description></item>
        /// <item><description>xcluster80: MySQL 8.0 RDS Enterprise Edition.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You can invoke the DescribeDBMiniEngineVersions operation to query the numeric version number. For more information about the differences between versions, see <a href="https://help.aliyun.com/document_detail/96060.html">AliSQL release notes</a>.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description><para>PostgreSQL: <c>rds_postgres_&lt;Major version&gt;00_&lt;Minor version number&gt;</c>. Example: <c>rds_postgres_1400_20220830</c>. Description:</para>
        /// <list type="bullet">
        /// <item><description>1400: PostgreSQL major version 14.</description></item>
        /// <item><description>20220830: AliPG minor engine version. You can invoke the DescribeDBMiniEngineVersions operation to query the minor engine version. For more information about the differences between versions, see <a href="https://help.aliyun.com/document_detail/126002.html">PostgreSQL release notes</a>.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If Babelfish is enabled in <b>BabelfishConfig</b>, the minor engine version format for the ApsaraDB RDS for PostgreSQL instance is <c>rds_postgres_&lt;Major version&gt;00_&lt;AliPG minor engine version&gt;_babelfish</c>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>rds_20200229</para>
        /// </summary>
        [NameInMap("TargetMinorVersion")]
        [Validation(Required=false)]
        public string TargetMinorVersion { get; set; }

        /// <summary>
        /// <para>The subscription duration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>Period</b> is set to <b>Year</b>, the valid values of <b>UsedTime</b> are <b>1</b> to <b>5</b>.</description></item>
        /// <item><description>If <b>Period</b> is set to <b>Month</b>, the valid values of <b>UsedTime</b> are <b>1</b> to <b>11</b>.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required when <b>PayType</b> is set to <b>Prepaid</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public string UsedTime { get; set; }

        /// <summary>
        /// <para>The ID of the user backup. You can call the ListUserBackupFiles operation to query the backup ID. If you specify this parameter, the instance is created based on the user backup.</para>
        /// <para>If you specify this parameter, the following limits apply:</para>
        /// <list type="bullet">
        /// <item><description><b>PayType</b> must be set to <b>Postpaid</b>.</description></item>
        /// <item><description><b>Engine</b> must be set to <b>MySQL</b>.</description></item>
        /// <item><description><b>EngineVersion</b> must be set to <b>5.7</b>.</description></item>
        /// <item><description><b>Category</b> must be set to <b>Basic</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>67798****</para>
        /// </summary>
        [NameInMap("UserBackupId")]
        [Validation(Required=false)]
        public string UserBackupId { get; set; }

        /// <summary>
        /// <para>The VPC ID.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when the network type <b>InstanceNetworkType</b> is set to <b>VPC</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-****</para>
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// <para>The vSwitch ID.</para>
        /// <list type="bullet">
        /// <item><description><b>Zone mapping</b>: The zone of the vSwitch specified by VSwitchId must correspond to the zone of the primary node (ZoneId) and the zone of the secondary node (ZoneIdSlave1). If you specify two vSwitch IDs, their sequence must match the sequence of ZoneId and ZoneIdSlave1.</description></item>
        /// <item><description><b>Network type limit</b>: <b>InstanceNetworkType</b> must be set to <b>VPC</b>.</description></item>
        /// <item><description><b>Multiple vSwitches</b>: If you specify <b>ZoneIdSlave1</b> and the value is not <b>Auto</b>, you must specify two vSwitch IDs and separate them with a comma (,).</description></item>
        /// <item><description><b>Character limit</b>: VSwitchId cannot contain special characters such as spaces, exclamation marks (!), number signs (#), yen signs (¥), ampersands (&amp;), or percent signs (%).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The whitelist templates.
        /// When you need to configure multiple IP addresses, separate multiple IP addresses or CIDR blocks with commas (,). Do not include spaces before or after the commas. Example: <c>192.168.0.1,172.16.213.9</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.0.1,172.16.213.9</para>
        /// </summary>
        [NameInMap("WhitelistTemplateList")]
        [Validation(Required=false)]
        public string WhitelistTemplateList { get; set; }

        /// <summary>
        /// <para>The zone ID of the primary node.</para>
        /// <list type="bullet">
        /// <item><description>If you specify a VPC and a vSwitch, you must specify the zone ID of the target vSwitch. Otherwise, the instance cannot be created.</description></item>
        /// <item><description>For a high-availability series instance, you must also specify <b>ZoneIdSlave1</b> to determine whether the instance uses a single-zone deployment or a multi-zone deployment.</description></item>
        /// <item><description>For an RDS Enterprise Edition instance, you must also specify <b>ZoneIdSlave1</b> and <b>ZoneIdSlave2</b> to determine whether the instance uses a single-zone deployment or a multi-zone deployment.</description></item>
        /// <item><description>For an ApsaraDB RDS for MySQL Cluster Edition instance, you must also specify <b>ZoneIdSlave1</b> for a two-node instance, and <b>ZoneIdSlave1</b> and <b>ZoneIdSlave2</b> for a three-node instance.</description></item>
        /// </list>
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
        /// <item><description>If you set this parameter to <b>Auto</b>, the instance uses a multi-zone deployment, and the system automatically selects a zone for the secondary node.</description></item>
        /// <item><description>If you set this parameter to the same value as <b>ZoneId</b>, the instance uses a single-zone deployment.</description></item>
        /// <item><description>If you set this parameter to a value different from <b>ZoneId</b>, the instance uses a multi-zone deployment.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-c</para>
        /// </summary>
        [NameInMap("ZoneIdSlave1")]
        [Validation(Required=false)]
        public string ZoneIdSlave1 { get; set; }

        /// <summary>
        /// <para>The zone ID of the second secondary node. ApsaraDB RDS for MySQL Cluster Edition instances support the creation of one or two secondary nodes when you create the instance. If you want to create a second secondary node, you can use this parameter to specify the zone of the second secondary node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-d</para>
        /// </summary>
        [NameInMap("ZoneIdSlave2")]
        [Validation(Required=false)]
        public string ZoneIdSlave2 { get; set; }

    }

}
