// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateDBInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The number of ApsaraDB RDS for MySQL instances to create. This parameter applies only to batch creation of ApsaraDB RDS for MySQL instances.</para>
        /// <para>Valid values: <b>1</b> to <b>20</b>. Default value: <b>1</b>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>When creating multiple ApsaraDB RDS for MySQL instances, consider using <b>Tag.Key</b> and <b>Tag.Value</b> to tag all instances in the same batch, so that you can manage them by tag after creation.</description></item>
        /// <item><description>After multiple ApsaraDB RDS for MySQL instances are created, the operation returns only <b>TaskId</b>, <b>RequestId</b>, and <b>Message</b>. Other details are not returned. To query the details of individual instances, call DescribeDBInstanceAttribute.</description></item>
        /// <item><description>If <b>engine</b> is not set to <b>MySQL</b> and this parameter is set to a value greater than <b>1</b>, the operation fails and returns the error code <c>InvalidParam.Engine</c>.</description></item>
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
        /// <item><description><para><b>true</b>: enables automatic automatic creation. The default proxy type is general-purpose.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: disables automatic automatic creation.</para>
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
        /// <para>Specifies whether to enable automatic payment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables automatic payment. Make sure that your account balance is sufficient.</description></item>
        /// <item><description><b>false</b>: generates an order without deducting fees.</description></item>
        /// </list>
        /// <remarks>
        /// <para>The default value is true. If your payment method has insufficient balance, set AutoPay to false. This generates an unpaid order, which you can pay for in the ApsaraDB RDS console.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal for the instance. This parameter is valid only for subscription instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you purchase the instance on a monthly basis, the auto-renewal cycle is one month.</description></item>
        /// <item><description>If you purchase the instance on a yearly basis, the auto-renewal cycle is one year.</description></item>
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
        /// <para>Specifies whether to use a coupon. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: uses a coupon.</description></item>
        /// <item><description><b>false</b> (default): does not use a coupon.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you use a coupon and then perform a downgrade, the amount offset by the coupon is not refunded.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public bool? AutoUseCoupon { get; set; }

        /// <summary>
        /// <para>The Babelfish configuration for ApsaraDB RDS for PostgreSQL instances.</para>
        /// <para>Configuration format: {&quot;babelfishEnabled&quot;:&quot;true&quot;,&quot;migrationMode&quot;:&quot;xxxxxxx&quot;,&quot;masterUsername&quot;:&quot;xxxxxxx&quot;,&quot;masterUserPassword&quot;:&quot;xxxxxxxx&quot;}</para>
        /// <para>The parameters are described as follows:</para>
        /// <list type="bullet">
        /// <item><description><b>babelfishEnabled</b>: specifies whether to enable Babelfish. Set to <b>true</b> to enable. Babelfish is disabled by default if this parameter is not configured.</description></item>
        /// <item><description><b>migrationMode</b>: the database mode. Set to <b>single-db</b> for single-database mode or <b>multi-db</b> for multi-database mode.</description></item>
        /// <item><description><b>masterUsername</b>: the initial administrator account name. The name can contain lowercase letters, digits, and underscores (_), must start with a letter, must end with a letter or digit, can be up to 63 characters in length, and cannot start with pg.</description></item>
        /// <item><description><b>masterUserPassword</b>: the password of the administrator account. The password must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. The password must be 8 to 32 characters in length. Special characters include <c>! @ # $ % ^ &amp; * () _ + - =</c>.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter applies only to ApsaraDB RDS for PostgreSQL instances. For more information about Babelfish for ApsaraDB RDS for PostgreSQL, see <a href="https://help.aliyun.com/document_detail/428613.html">Introduction to Babelfish</a>.</para>
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
        /// <para>Specifies whether to enable the I/O performance burst feature for premium performance disks (cloud disks). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enabled.</description></item>
        /// <item><description><b>false</b>: disabled.<remarks>
        /// <para>For more information about the I/O performance burst feature for premium performance disks, see <a href="https://help.aliyun.com/document_detail/2340501.html">What is a premium performance disk</a>.</para>
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
        /// <para>The business extension parameter.</para>
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
        /// <item><description><b>HighAvailability</b>: High-availability Edition.</description></item>
        /// <item><description><b>cluster</b>: MySQL or PostgreSQL Cluster Edition.</description></item>
        /// <item><description><b>AlwaysOn</b>: SQL Server Cluster Edition.</description></item>
        /// <item><description><b>Finance</b>: RDS Enterprise Edition.<remarks>
        /// <para>This parameter is required when you create a SQL Server Enterprise Cluster Edition&lt;props=&quot;china&quot;&gt;, Basic Edition Standard Edition, or Basic Edition Enterprise Edition instance. For example, to create a Basic Edition 2022 Enterprise Cluster Edition (2022_ent) instance, set this parameter to Basic.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Serverless instances</para>
        /// <list type="bullet">
        /// <item><description><b>serverless_basic</b>: Serverless Basic Edition. (Applicable to MySQL and PostgreSQL only.)</description></item>
        /// <item><description><b>serverless_standard</b>: Serverless High-availability Edition. (Applicable to MySQL and PostgreSQL only.)</description></item>
        /// <item><description><b>serverless_ha</b>: SQL Server Serverless High-availability Edition.</description></item>
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
        /// <para>The client token that is used to ensure the idempotency of the request. The token is generated by the client and must be unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCz****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the <a href="https://help.aliyun.com/document_detail/2701832.html">cold data archiving</a> feature for premium performance disks (cloud disks). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enabled.</description></item>
        /// <item><description><b>false</b>: disabled.</description></item>
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
        /// <para>SQL Server 2012, 2016, and 2017 support only standard access mode.</para>
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
        /// <para>The endpoint format is <c>xxx.mysql.rds.aliyuncs.com</c>, where <c>xxx</c> is the prefix of the instance ID, such as rm-uf6wjk5***.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5****.mysql.rds.aliyuncs.com</para>
        /// </summary>
        [NameInMap("ConnectionString")]
        [Validation(Required=false)]
        public string ConnectionString { get; set; }

        /// <summary>
        /// <para>The batch instance creation strategy. This parameter takes effect only when <b>Amount</b> is greater than 1. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Atomicity</b> (default): atomic. All instances in the same batch must be created successfully. If any instance fails to be created, all instances in the batch fail.</description></item>
        /// <item><description><b>Partial</b>: non-atomic. The creation of each instance is independent of other instances in the same batch.</description></item>
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
        /// <para>The instance type. You can specify a standard or YiTian instance type. For details, see <a href="https://help.aliyun.com/document_detail/26312.html">Primary instance types</a>.</para>
        /// <para>To create a serverless instance, use one of the following values:</para>
        /// <list type="bullet">
        /// <item><description>MySQL Basic Edition: <b>mysql.n2.serverless.1c</b></description></item>
        /// <item><description>MySQL High-availability Edition: <b>mysql.n2.serverless.2c</b></description></item>
        /// <item><description>SQL Server: <b>mssql.mem2.serverless.s2</b></description></item>
        /// <item><description>PostgreSQL Basic Edition: <b>pg.n2.serverless.1c</b></description></item>
        /// <item><description>PostgreSQL High-availability Edition: <b>pg.n2.serverless.2c</b></description></item>
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
        /// <para>The instance name. The name must be 2 to 255 characters in length. It must start with a Chinese character or an English letter, and can contain digits, Chinese characters, English letters, and hyphens (-).</para>
        /// <remarks>
        /// <para>The name cannot start with http:// or https://.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testInstance</para>
        /// </summary>
        [NameInMap("DBInstanceDescription")]
        [Validation(Required=false)]
        public string DBInstanceDescription { get; set; }

        /// <summary>
        /// <para>The network connectivity type of the instance. Set this parameter to <b>Intranet</b>, which indicates an internal network connection.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Intranet</para>
        /// </summary>
        [NameInMap("DBInstanceNetType")]
        [Validation(Required=false)]
        public string DBInstanceNetType { get; set; }

        /// <summary>
        /// <para>The instance storage capacity. Unit: GB. The value increments in steps of 5 GB. For the valid values, see <a href="https://help.aliyun.com/document_detail/26312.html">Instance types</a>.</para>
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
        /// <item><description><b>local_ssd</b>: instance with Premium Local SSDs (recommended).</description></item>
        /// <item><description><b>general_essd</b>: premium performance disk (recommended).</description></item>
        /// <item><description><b>cloud_essd</b>: PL1 ESSD.</description></item>
        /// <item><description><b>cloud_essd2</b>: PL2 ESSD.</description></item>
        /// <item><description><b>cloud_essd3</b>: PL3 ESSD.</description></item>
        /// <item><description><b>cloud_ssd</b>: standard SSD (not recommended. No longer available in some regions).</description></item>
        /// </list>
        /// <para>The default value of this parameter is automatically determined based on the instance type specified in <b>DBInstanceClass</b>:</para>
        /// <list type="bullet">
        /// <item><description>If the instance type is an instance with Premium Local SSDs, the default value is <b>local_ssd</b>.</description></item>
        /// <item><description>If the instance type is a cloud disk type, the default value is <b>cloud_essd</b>.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Serverless instances support only PL1 ESSDs and premium performance disks.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>general_essd</para>
        /// </summary>
        [NameInMap("DBInstanceStorageType")]
        [Validation(Required=false)]
        public string DBInstanceStorageType { get; set; }

        /// <summary>
        /// <para>Specifies whether table names are case-insensitive. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: case-insensitive (default).</description></item>
        /// <item><description><b>false</b>: case-sensitive.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DBIsIgnoreCase")]
        [Validation(Required=false)]
        public string DBIsIgnoreCase { get; set; }

        /// <summary>
        /// <para>The parameter template ID. You can call DescribeParameterGroups to query the ID.</para>
        /// <remarks>
        /// <para>This parameter is supported only for MySQL and PostgreSQL instances. If you do not specify this parameter, the system default parameter template is used. You can also create a custom parameter template and specify it here.</para>
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
        /// <item><description>When <b>Engine</b> is <b>MySQL</b>:<list type="bullet">
        /// <item><description>This parameter configures the UTC time zone. Valid values: <b>-12:59</b> to <b>+13:00</b>.</description></item>
        /// <item><description>Instances with Premium Local SSDs support named time zones, such as Asia/Hong_Kong. For more information about named time zones, see <a href="https://help.aliyun.com/document_detail/297356.html">Named time zone reference</a>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description>When <b>Engine</b> is <b>PostgreSQL</b>:<list type="bullet">
        /// <item><description>This parameter configures a named time zone. UTC time zones are not supported. For more information about named time zones, see <a href="https://help.aliyun.com/document_detail/297356.html">Named time zone reference</a>.</description></item>
        /// <item><description>This parameter can be configured only for PostgreSQL instances with cloud disks.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You can configure the time zone when creating a primary instance. Read-only instances do not support custom time zones and inherit the time zone of the primary instance.</description></item>
        /// <item><description>If you do not specify this parameter, the system selects a default time zone based on the region where you purchase the instance.</description></item>
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
        /// <para>The ID of the dedicated host group.</para>
        /// <para>This parameter is required when you create an ApsaraDB RDS instance in a dedicated cluster.</para>
        /// <list type="bullet">
        /// <item><description>You can call DescribeDedicatedHostGroups to query the host group information.</description></item>
        /// <item><description>If you have not created a host group, call CreateDedicatedHostGroup to create one.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>dhg-4n****</para>
        /// </summary>
        [NameInMap("DedicatedHostGroupId")]
        [Validation(Required=false)]
        public string DedicatedHostGroupId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the release protection feature for the RDS instance. This parameter is supported only for pay-as-you-go instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables release protection.</description></item>
        /// <item><description><b>false</b>: disables release protection (default).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DeletionProtection")]
        [Validation(Required=false)]
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run for this instance creation operation. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs a dry run without creating the instance. The dry run checks the request parameters, request format, business limits, and resource availability.</description></item>
        /// <item><description><b>false</b>: sends a normal request and creates the instance directly after the check passes (default).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The ID of the cloud disk encryption key in the same region. Specifying this parameter enables cloud disk encryption (which cannot be disabled after it is enabled) and requires you to also specify <b>RoleARN</b>.</para>
        /// <para>You can view the key ID in the Key Management Service console or create a new key. For more information, see <a href="https://help.aliyun.com/document_detail/181610.html">Create a key</a>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>For ApsaraDB RDS for MySQL, ApsaraDB RDS for PostgreSQL, and ApsaraDB RDS for SQL Server instances, you can omit this parameter and specify only <b>RoleARN</b> to create a cloud disk-encrypted instance using a service key.</description></item>
        /// <item><description>To allow RAM users to create instances only when cloud disk encryption is enabled, configure the following RAM authorization policy. If cloud disk encryption is not enabled, the RAM user cannot create instances:
        /// <c>{&quot;Version&quot;:&quot;1&quot;,&quot;Statement&quot;:[{&quot;Effect&quot;:&quot;Deny&quot;,&quot;Action&quot;:&quot;rds:CreateDBInstance&quot;,&quot;Resource&quot;:&quot;*&quot;,&quot;Condition&quot;:{&quot;StringEquals&quot;:{&quot;rds:DiskEncryptionRequired&quot;:&quot;false&quot;}}}]}</c>
        /// Warning: This configuration also affects the CreateOrder operation that is called when you create an instance in the console.</description></item>
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
        /// <para>The database engine type. Valid values:</para>
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
        /// <item><description>MySQL: <b>5.5</b>, <b>5.6</b>, <b>5.7</b>, <b>8.0</b></description></item>
        /// <item><description>SQL Server: <b>08r2_ent_ha</b> (cloud disk, discontinued), <b>2008r2</b> (Premium Local SSD, discontinued), <b>2012</b> (Enterprise Edition single-node), <b>2012_ent_ha</b>, <b>2012_std_ha</b>, <b>2012_web</b>, <b>2014_ent_ha</b>, <b>2014_std_ha</b>, <b>2016_ent_ha</b>, <b>2016_std_ha</b>, <b>2016_web</b>, <b>2017_ent</b>, <b>2017_std_ha</b>, <b>2017_web</b>, <b>2019_ent</b>, <b>2019_std_ha</b>, <b>2019_web</b>, <b>2022_ent</b>, <b>2022_std_ha</b>, <b>2022_web</b>, <b>2025_ent</b>, <b>2025_std</b></description></item>
        /// <item><description>PostgreSQL: <b>10.0</b>, <b>11.0</b>, <b>12.0</b>, <b>13.0</b>, <b>14.0</b>, <b>15.0</b>, <b>16.0</b>, <b>17.0</b>, <b>18.0</b></description></item>
        /// <item><description>MariaDB: <b>10.3</b>, <b>10.6</b></description></item>
        /// </list>
        /// </description></item>
        /// <item><description>Serverless instances<list type="bullet">
        /// <item><description>MySQL: <b>5.7</b>, <b>8.0</b></description></item>
        /// <item><description>SQL Server: <b>2016_std_sl</b>, <b>2017_std_sl</b>, <b>2019_std_sl</b></description></item>
        /// <item><description>PostgreSQL: <b>14.0</b>, <b>15.0</b>, <b>16.0</b>, <b>17.0</b>, <b>18.0</b></description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>MariaDB does not support serverless instances.</description></item>
        /// <item><description>In SQL Server instance versions, <c>_ent</c> indicates Enterprise Cluster Edition, <c>_ent_ha</c> indicates Enterprise Edition, <c>_std_ha</c> indicates Standard Edition, and <c>_web</c> indicates Web Edition.</description></item>
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
        /// <para>Specifies whether to enable <a href="https://help.aliyun.com/document_detail/2856526.html">ApsaraDB RDS for MySQL native replication</a>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ON</b>: enabled.</description></item>
        /// <item><description><b>OFF</b>: disabled.</description></item>
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
        /// <item><description><b>VPC</b>: virtual private cloud.</description></item>
        /// <item><description><b>Classic</b>: classic network.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>ApsaraDB RDS for MySQL cloud disk instances support only VPCs. Set this parameter to <b>VPC</b>.</description></item>
        /// <item><description>ApsaraDB RDS for PostgreSQL and MariaDB instances support only VPCs. Set this parameter to <b>VPC</b>.</description></item>
        /// <item><description>ApsaraDB RDS for SQL Server Basic Edition and Web Edition instances support both classic networks and VPCs. All other instances support only VPCs. Set this parameter to <b>VPC</b>.</description></item>
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
        /// <para>Specifies whether to enable the <a href="https://help.aliyun.com/document_detail/2527067.html">Buffer Pool Extension (BPE)</a> feature for premium performance disks (cloud disks). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: enabled.</description></item>
        /// <item><description><b>0</b>: disabled.</description></item>
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
        /// <item><description><b>optimized</b>: enabled.</description></item>
        /// <item><description><b>none</b> (default): disabled.</description></item>
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
        /// <item><description><b>Serverless</b>: serverless billing method. MariaDB instances do not support this billing method. For more information, see <a href="https://help.aliyun.com/document_detail/411291.html">Overview of MySQL Serverless instances</a>, <a href="https://help.aliyun.com/document_detail/604344.html">Overview of SQL Server Serverless instances</a>, and <a href="https://help.aliyun.com/document_detail/607742.html">Overview of PostgreSQL Serverless instances</a>.<remarks>
        /// <para>The system automatically generates and pays for the order. No manual payment confirmation is required.</para>
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
        /// <para>The subscription type of the prepaid instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Year</b>: subscription on a yearly basis.</description></item>
        /// <item><description><b>Month</b>: subscription on a monthly basis.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required if the billing method is <b>Prepaid</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Year</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The port to initialize when creating the ApsaraDB RDS instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>MySQL: 1000 to 65534</description></item>
        /// <item><description>PostgreSQL, SQL Server, MariaDB: 1000 to 5999</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3306</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public string Port { get; set; }

        /// <summary>
        /// <para>Settings for the internal network IP address of the instance. The IP address must be within the address range of the specified vSwitch. By default, the system automatically allocates an IP address based on <b>VPCId</b> and <b>vSwitchId</b>.</para>
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
        /// <para>The region ID. You can call <a href="https://help.aliyun.com/document_detail/610399.html">DescribeRegions</a> to query the region ID.</para>
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
        /// <para>The global resource descriptor (ARN) that grants the RDS service account authorization to access KMS on behalf of the primary account. You can call CheckCloudResourceAuthorized to query the ARN information.</para>
        /// <remarks>
        /// <para>Notice: You must specify <b>RoleARN</b> when you enable cloud disk encryption.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::1406****:role/aliyunrdsinstanceencryptiondefaultrole</para>
        /// </summary>
        [NameInMap("RoleARN")]
        [Validation(Required=false)]
        public string RoleARN { get; set; }

        /// <summary>
        /// <para>The <a href="https://help.aliyun.com/document_detail/43185.html">IP whitelist</a> of the instance. Separate multiple entries with commas (,). Duplicate entries are not allowed. You can add up to 1,000 IP addresses or CIDR blocks to a single instance. The following formats are supported:</para>
        /// <list type="bullet">
        /// <item><description>IP address format, for example: 10.10.XX.XX.</description></item>
        /// <item><description>CIDR block format, for example: 10.10.XX.XX/24 (classless inter-domain routing, where 24 indicates the length of the prefix in the address, ranging from 1 to 32).</description></item>
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
        /// <para>The settings for the serverless ApsaraDB RDS instance. This parameter is required when you create a serverless instance.</para>
        /// <remarks>
        /// <para>MariaDB does not support serverless instances.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ServerlessConfig")]
        [Validation(Required=false)]
        public CreateDBInstanceRequestServerlessConfig ServerlessConfig { get; set; }
        public class CreateDBInstanceRequestServerlessConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable intelligent pause and resume for the serverless instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: enabled.</description></item>
            /// <item><description><b>false</b>: disabled (default).</description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter applies only to MySQL and PostgreSQL serverless instances. If no connections are established within 10 minutes, the instance enters the paused state and automatically resumes when a connection is initiated.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AutoPause")]
            [Validation(Required=false)]
            public bool? AutoPause { get; set; }

            /// <summary>
            /// <para>The maximum RCU (RDS Capacity Unit) value for automatic scaling of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>MySQL: <b>1 to 32</b></description></item>
            /// <item><description>SQL Server: <b>2 to 16</b></description></item>
            /// <item><description>PostgreSQL: <b>1 to 14</b></description></item>
            /// </list>
            /// <remarks>
            /// <para>The value of this parameter must be greater than or equal to <b>MinCapacity</b> and must be an <b>integer</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("MaxCapacity")]
            [Validation(Required=false)]
            public double? MaxCapacity { get; set; }

            /// <summary>
            /// <para>The minimum RCU value for automatic scaling of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>MySQL: <b>0.5 to 32</b></description></item>
            /// <item><description>SQL Server: <b>2 to 16</b> (integers only)</description></item>
            /// <item><description>PostgreSQL: <b>0.5 to 14</b></description></item>
            /// </list>
            /// <remarks>
            /// <para>The value of this parameter must be less than or equal to <b>MaxCapacity</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("MinCapacity")]
            [Validation(Required=false)]
            public double? MinCapacity { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable forced elastic scaling for the serverless instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: enabled.</description></item>
            /// <item><description><b>false</b>: disabled (default).</description></item>
            /// </list>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>This parameter applies only to MySQL and PostgreSQL serverless instances. After you enable this parameter, forced scaling causes 30 to 120 seconds of service unavailability. Use this parameter with caution based on your actual situation.</description></item>
            /// <item><description>RCU elastic scaling usually takes effect immediately. However, in certain special situations (such as during a large transaction), scaling cannot complete immediately. In such cases, you can enable this parameter to force scaling.</description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SwitchForce")]
            [Validation(Required=false)]
            public bool? SwitchForce { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to enable automatic storage expansion. This parameter is supported only for MySQL and PostgreSQL instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enable</b>: enables automatic storage expansion.</description></item>
        /// <item><description><b>Disable</b>: disables automatic storage expansion (default).</description></item>
        /// </list>
        /// <remarks>
        /// <para>You can also call ModifyDasInstanceConfig after the instance is created to adjust this setting. For more information, see <a href="https://help.aliyun.com/document_detail/173826.html">Configure automatic storage expansion</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Disable</para>
        /// </summary>
        [NameInMap("StorageAutoScale")]
        [Validation(Required=false)]
        public string StorageAutoScale { get; set; }

        /// <summary>
        /// <para>The threshold (percentage) that triggers automatic storage expansion. Valid values:</para>
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
        /// <para>The maximum total storage capacity allowed for automatic storage expansion. Automatic storage expansion does not cause the total storage capacity of the instance to exceed this value. Unit: GB.</para>
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
        /// <para>This parameter is deprecated. You do not need to configure it.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gbk</para>
        /// </summary>
        [NameInMap("SystemDBCharset")]
        [Validation(Required=false)]
        public string SystemDBCharset { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateDBInstanceRequestTag> Tag { get; set; }
        public class CreateDBInstanceRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. Specifying this parameter binds a tag to the instance.</para>
            /// <list type="bullet">
            /// <item><description>If the specified tag key already exists, the tag is directly bound to the instance. You can call ListTagResources to query existing tags.</description></item>
            /// <item><description>If the specified tag key does not exist, the tag key is created and then bound to the instance.</description></item>
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
            /// <para>The tag value corresponding to the tag key. Specifying this parameter binds a tag to the instance.</para>
            /// <list type="bullet">
            /// <item><description>If the specified tag value already exists under the corresponding tag key, the tag value is directly bound to the instance. You can call ListTagResources to query existing tags.</description></item>
            /// <item><description>If the specified tag value does not exist under the corresponding tag key, the tag value is created and then bound to the instance.</description></item>
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
        /// <para>The host ID of the logger instance in the dedicated cluster.</para>
        /// <para>This parameter is required when you create an ApsaraDB RDS Enterprise Edition instance in a dedicated cluster. If you do not specify this parameter, the system automatically assigns a host.</para>
        /// <list type="bullet">
        /// <item><description>You can call DescribeDedicatedHosts to query the host information in the dedicated cluster.</description></item>
        /// <item><description>If you have not added a host, call CreateDedicatedHost to add one.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp****</para>
        /// </summary>
        [NameInMap("TargetDedicatedHostIdForLog")]
        [Validation(Required=false)]
        public string TargetDedicatedHostIdForLog { get; set; }

        /// <summary>
        /// <para>The host ID of the primary instance in the dedicated cluster.</para>
        /// <para>This parameter is required when you create an ApsaraDB RDS instance in a dedicated cluster. If you do not specify this parameter, the system automatically assigns a host.</para>
        /// <list type="bullet">
        /// <item><description>You can call DescribeDedicatedHosts to query the host information in the host group.</description></item>
        /// <item><description>If you have not added a host, call CreateDedicatedHost to add one.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp****</para>
        /// </summary>
        [NameInMap("TargetDedicatedHostIdForMaster")]
        [Validation(Required=false)]
        public string TargetDedicatedHostIdForMaster { get; set; }

        /// <summary>
        /// <para>The host ID of the secondary instance in the dedicated cluster.</para>
        /// <para>This parameter is required when you create an ApsaraDB RDS High-availability Edition or RDS Enterprise Edition instance in a dedicated cluster. If you do not specify this parameter, the system automatically allocates a host by default.</para>
        /// <list type="bullet">
        /// <item><description>You can call DescribeDedicatedHosts to query the host information in the dedicated cluster.</description></item>
        /// <item><description>If you have not added a host, call CreateDedicatedHost to add one.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp****</para>
        /// </summary>
        [NameInMap("TargetDedicatedHostIdForSlave")]
        [Validation(Required=false)]
        public string TargetDedicatedHostIdForSlave { get; set; }

        /// <summary>
        /// <para>The minor engine version of the RDS instance to create. This parameter is required only when you create a MySQL or PostgreSQL instance.
        /// Format:</para>
        /// <list type="bullet">
        /// <item><description><para>MySQL: <c>&lt;instance version&gt;_&lt;numeric version number&gt;</c>. For example, <c>rds_20200229</c>, <c>xcluster_20200229</c>, or <c>xcluster80_20200229</c>. The prefixes are described as follows:</para>
        /// <list type="bullet">
        /// <item><description>rds: high availability series or Basic Edition.</description></item>
        /// <item><description>xcluster: MySQL 5.7 RDS Enterprise Edition.</description></item>
        /// <item><description>xcluster80: MySQL 8.0 RDS Enterprise Edition.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You can call DescribeDBMiniEngineVersions to query the numeric version number. For differences between versions, see <a href="https://help.aliyun.com/document_detail/96060.html">AliSQL minor version release notes</a>.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description><para>PostgreSQL: <c>rds_postgres_&lt;major version&gt;00_&lt;minor version number&gt;</c>. For example, <c>rds_postgres_1400_20220830</c>. The fields are described as follows:</para>
        /// <list type="bullet">
        /// <item><description>1400: PostgreSQL major version 14.</description></item>
        /// <item><description>20220830: AliPG minor engine version. You can call DescribeDBMiniEngineVersions to query the minor version number. For differences between versions, see <a href="https://help.aliyun.com/document_detail/126002.html">PostgreSQL minor version release notes</a>.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If Babelfish is enabled in <b>BabelfishConfig</b>, the minor version format for ApsaraDB RDS for PostgreSQL instances is: <c>rds_postgres_&lt;major version&gt;00_&lt;AliPG minor version&gt;_babelfish</c>.</para>
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
        /// <item><description>If <b>Period</b> is set to <b>Year</b>, <b>UsedTime</b> can be set to <b>1 to 5</b>.</description></item>
        /// <item><description>If <b>Period</b> is set to <b>Month</b>, <b>UsedTime</b> can be set to <b>1 to 11</b>.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required if the billing method is <b>Prepaid</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public string UsedTime { get; set; }

        /// <summary>
        /// <para>The user backup ID. You can call ListUserBackupFiles to query the ID. Specifying this parameter creates an instance from a user backup.</para>
        /// <para>The following restrictions apply when you specify this parameter:</para>
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
        /// <para>This parameter takes effect only when <b>InstanceNetworkType</b> is set to <b>VPC</b>, which indicates the network type is VPC.</para>
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
        /// <item><description><b>Zone correspondence</b>: The zone of the vSwitch must correspond to the zone of the primary node (ZoneId) and the zone of the secondary node (ZoneIdSlave1). If you specify two vSwitch IDs, their order must match the order of ZoneId and ZoneSlaveId1.</description></item>
        /// <item><description><b>Network type requirement</b>: <b>InstanceNetworkType</b> must be set to <b>VPC</b>.</description></item>
        /// <item><description><b>Multiple vSwitch requirement</b>: If you specify <b>ZoneSlaveId1</b> (the zone ID of the secondary node) and it is not set to <b>Auto</b>, you must specify two vSwitch IDs separated by a comma (,).</description></item>
        /// <item><description><b>Character restriction</b>: VSwitchId cannot contain special characters such as spaces, <c>!</c>, <c>#</c>, <c>￥</c>, <c>&amp;</c>, or <c>%</c>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The whitelist. If you need to configure multiple IP addresses, separate them with commas (,) without spaces before or after the commas. Example: <c>192.168.0.1,172.16.213.9</c>.</para>
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
        /// <item><description>If you specify a VPC and a vSwitch, you must set this parameter to the zone ID of the vSwitch. Otherwise, the instance cannot be created.</description></item>
        /// <item><description>For high availability series instances, you must also specify <b>ZoneIdSlave1</b> to determine whether the instance uses single-zone or multi-zone deployment.</description></item>
        /// <item><description>For RDS Enterprise Edition instances, you must also specify <b>ZoneIdSlave1</b> and <b>ZoneIdSlave2</b> to determine whether the instance uses single-zone or multi-zone deployment.</description></item>
        /// <item><description>For RDS Cluster Edition instances, two-node clusters require <b>ZoneIdSlave1</b>, and three-node clusters require both <b>ZoneIdSlave1</b> and <b>ZoneIdSlave2</b>.</description></item>
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
        /// <item><description>If you set this parameter to <b>Auto</b>, the instance uses multi-zone deployment and the system automatically selects a zone for the secondary node.</description></item>
        /// <item><description>If this parameter is the same as <b>ZoneId</b>, the instance uses single-zone deployment.</description></item>
        /// <item><description>If this parameter is different from <b>ZoneId</b>, the instance uses multi-zone deployment.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-c</para>
        /// </summary>
        [NameInMap("ZoneIdSlave1")]
        [Validation(Required=false)]
        public string ZoneIdSlave1 { get; set; }

        /// <summary>
        /// <para>The zone ID of the second secondary node. ApsaraDB RDS for MySQL Cluster Edition instances support creating one or two secondary nodes when you create the instance. If you need this, use this parameter to specify the zone of the second secondary node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-d</para>
        /// </summary>
        [NameInMap("ZoneIdSlave2")]
        [Validation(Required=false)]
        public string ZoneIdSlave2 { get; set; }

    }

}
