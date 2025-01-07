// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateDBInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The number of ApsaraDB RDS for MySQL instances that you want to create. The parameter takes effect only when you create multiple ApsaraDB RDS for MySQL instances at a time by using a single request.</para>
        /// <para>Valid values: <b>1</b> to <b>20</b>. Default value: <b>1</b>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If you want to create multiple ApsaraDB RDS for MySQL instances at a time by using a single request, you can add tags to all the instances by using the <b>Tag.Key</b> parameter and the <b>Tag.Value</b> parameter. After the instances are created, you can manage the instances based on the tags.</description></item>
        /// <item><description>After you submit a request to create multiple ApsaraDB RDS for MySQL instances, this operation returns <b>TaskId</b>, <b>RequestId</b>, and <b>Message</b>. You can call the DescribeDBInstanceAttribute operation to query the information about an instance.</description></item>
        /// <item><description>If the value of the <b>Engine</b> parameter is not <b>MySQL</b> and the value of the Amount parameter is greater than <b>1</b>, this operation fails and returns an error code <c>InvalidParam.Engine</c>.</description></item>
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
        /// <para>Specifies whether to automatically create a database proxy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: automatically creates a database proxy. By default, a general-purpose database proxy is created.</description></item>
        /// <item><description><b>false</b>: does not automatically create a database proxy.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoCreateProxy")]
        [Validation(Required=false)]
        public bool? AutoCreateProxy { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the automatic payment feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables the feature. Make sure that your account balance is sufficient.</description></item>
        /// <item><description><b>false</b>: disables the feature. An unpaid order is generated.</description></item>
        /// </list>
        /// <remarks>
        /// <para> Default value: true. If your account balance is insufficient, you can set the AutoPay parameter to false to generate an unpaid order. Then, you can log on to the ApsaraDB RDS console to complete the payment.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal for the instance. You must specify this parameter only if the instance uses the subscription billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The auto-renewal cycle is one month for a monthly subscription.</description></item>
        /// <item><description>The auto-renewal cycle is one year for a yearly subscription.</description></item>
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
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public bool? AutoUseCoupon { get; set; }

        /// <summary>
        /// <para>The configuration of the Babelfish feature for the instance that runs PostgreSQL.</para>
        /// <para>Format:{&quot;babelfishEnabled&quot;:&quot;true&quot;,&quot;migrationMode&quot;:&quot;xxxxxxx&quot;,&quot;masterUsername&quot;:&quot;xxxxxxx&quot;,&quot;masterUserPassword&quot;:&quot;xxxxxxxx&quot;}</para>
        /// <para>The following list describes the fields in the format:</para>
        /// <list type="bullet">
        /// <item><description><b>babelfishEnabled</b>: specifies whether to enable Babelfish for the instance. If you set this field to <b>true</b>, you enable Babelfish for the instance. If you leave this parameter empty, Babelfish is disabled for the instance.</description></item>
        /// <item><description><b>migrationMode</b>: The migration mode of the instance. Valid values: <b>single-db</b> and <b>multi-db</b>.</description></item>
        /// <item><description><b>masterUsername</b>: The username of the administrator account. The username can contain lowercase letters, digits, and underscores (_). It must start with a letter and end with a letter or digit. It can be up to 63 characters in length and cannot start with pg.</description></item>
        /// <item><description><b>masterUserPassword</b>: The password of the administrator account. The password must contain at least three of the following character types: uppercase letters, lowercase letters, digits, and special characters. It must be 8 to 32 characters in length. The password can contain any of the following characters: <c>! @ # $ % ^ &amp; * ( ) _ + - =</c>.</description></item>
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

        /// <summary>
        /// <para>A deprecated parameter. You do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("BpeEnabled")]
        [Validation(Required=false)]
        public string BpeEnabled { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the I/O burst feature of general ESSDs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> For more information about the I/O burst feature of general ESSDs, see <a href="https://help.aliyun.com/document_detail/2340501.html">What are general ESSDs?</a></para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("BurstingEnabled")]
        [Validation(Required=false)]
        public bool? BurstingEnabled { get; set; }

        /// <summary>
        /// <para>The additional business information about the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>121436975448952</para>
        /// </summary>
        [NameInMap("BusinessInfo")]
        [Validation(Required=false)]
        public string BusinessInfo { get; set; }

        /// <summary>
        /// <para>The RDS edition of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Regular RDS instance</para>
        /// <list type="bullet">
        /// <item><description><b>Basic</b>: RDS Basic Edition</description></item>
        /// <item><description><b>HighAvailability</b>: RDS High-availability Edition</description></item>
        /// <item><description><b>cluster</b>: RDS Cluster Edition for ApsaraDB RDS for MySQL or PostgreSQL</description></item>
        /// <item><description><b>AlwaysOn</b>: RDS Cluster Edition for ApsaraDB RDS for SQL Server</description></item>
        /// <item><description><b>Finance</b>: RDS Basic Edition for serverless instances</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Serverless instance</para>
        /// <list type="bullet">
        /// <item><description><b>serverless_basic</b>: RDS Basic Edition for serverless instances. This edition is available only for instances that run MySQL and PostgreSQL.</description></item>
        /// <item><description><b>serverless_standard</b>: RDS High-availability Edition for serverless instances. This edition is available only for instances that run MySQL and PostgreSQL.</description></item>
        /// <item><description><b>serverless_ha</b>: RDS High-availability Edition for serverless instances. This edition is available only for instances that run SQL Server.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required when you create a serverless instance.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>HighAvailability</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCz*****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the data archiving feature of general ESSDs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> For more information about the data archiving feature of general ESSDs, see <a href="https://help.aliyun.com/document_detail/2701832.html">Use the data archiving feature of general ESSDs</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ColdDataEnabled")]
        [Validation(Required=false)]
        public bool? ColdDataEnabled { get; set; }

        /// <summary>
        /// <para>The connection mode of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Standard</b>: standard mode</description></item>
        /// <item><description><b>Safe</b>: database proxy mode</description></item>
        /// </list>
        /// <para>ApsaraDB RDS automatically assigns a connection mode to the instance.</para>
        /// <remarks>
        /// <para>SQL Server 2012, SQL Server 2016, and SQL Server 2017 support only the standard mode.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Standard</para>
        /// </summary>
        [NameInMap("ConnectionMode")]
        [Validation(Required=false)]
        public string ConnectionMode { get; set; }

        /// <summary>
        /// <para>The internal endpoint that is used to connect to the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5*****.mysql.rds.aliyuncs.com</para>
        /// </summary>
        [NameInMap("ConnectionString")]
        [Validation(Required=false)]
        public string ConnectionString { get; set; }

        /// <summary>
        /// <para>The policy based on which multiple instances are created. The parameter takes effect only when the value of the <b>Amount</b> parameter is greater than 1. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Atomicity</b> (default): atomicity. The instances are all created together. If one instance cannot be created, none of the instances are created.</description></item>
        /// <item><description><b>Partial</b>: non-atomicity. Each instance is independently created. The failure in creating an instance does not affect the creation of the other instances.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Atomicity</para>
        /// </summary>
        [NameInMap("CreateStrategy")]
        [Validation(Required=false)]
        public string CreateStrategy { get; set; }

        /// <summary>
        /// <para>The instance type of the instance. You can specify an instance type of the standard or YiTian product type. For more information, see <a href="https://help.aliyun.com/document_detail/26312.html">Primary ApsaraDB RDS instance types</a>.</para>
        /// <para>To create a serverless instance, set this parameter to one of the following values:</para>
        /// <list type="bullet">
        /// <item><description>If you want to create a serverless instance that runs MySQL on RDS Basic Edition, set this parameter to <b>mysql.n2.serverless.1c</b>.</description></item>
        /// <item><description>If you want to create a serverless instance that runs MySQL on RDS High-availability Edition, set this parameter to <b>mysql.n2.serverless.2c</b>.</description></item>
        /// <item><description>If you want to create a serverless instance that runs SQL Server, set this parameter to <b>mssql.mem2.serverless.s2</b>.</description></item>
        /// <item><description>If you want to create a serverless instance that runs PostgreSQL on RDS Basic Edition, set this parameter to <b>pg.n2.serverless.1c</b>.</description></item>
        /// <item><description>If you want to create a serverless instance that runs PostgreSQL on RDS High-availability Edition, set this parameter to <b>pg.n2.serverless.2c</b>.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds.mysql.s1.small</para>
        /// </summary>
        [NameInMap("DBInstanceClass")]
        [Validation(Required=false)]
        public string DBInstanceClass { get; set; }

        /// <summary>
        /// <para>The instance name. The name must be 2 to 255 characters in length and can contain letters, digits, underscores (_), and hyphens (-). The name must start with a letter.</para>
        /// <remarks>
        /// <para>The name cannot start with http:// or https://.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Test database</para>
        /// </summary>
        [NameInMap("DBInstanceDescription")]
        [Validation(Required=false)]
        public string DBInstanceDescription { get; set; }

        /// <summary>
        /// <para>The network connection type of the instance. The value of this parameter is fixed as <b>Intranet</b>, indicating an internal network connection.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Internet</para>
        /// </summary>
        [NameInMap("DBInstanceNetType")]
        [Validation(Required=false)]
        public string DBInstanceNetType { get; set; }

        /// <summary>
        /// <para>The storage capacity of the instance. Unit: GB. The storage capacity increases in increments of 5 GB. For more information, see <a href="https://help.aliyun.com/document_detail/26312.html">Primary ApsaraDB RDS instance types</a>.</para>
        /// <para>This parameter is required.</para>
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
        /// <item><description><b>local_ssd</b>: local SSD. This is the recommended storage type.</description></item>
        /// <item><description><b>general_essd</b>: general Enterprise SSD (ESSD). This is the recommended storage type.</description></item>
        /// <item><description><b>cloud_essd</b>: PL1 ESSD</description></item>
        /// <item><description><b>cloud_essd2</b>: PL2 ESSD</description></item>
        /// <item><description><b>cloud_essd3</b>: PL3 ESSD</description></item>
        /// <item><description><b>cloud_ssd</b>: standard SSD. This storage type is not recommended. Standard SSDs are no longer available for purchase in some Alibaba Cloud regions.</description></item>
        /// </list>
        /// <para>The default value of this parameter is determined by the instance type specified by the <b>DBInstanceClass</b> parameter.</para>
        /// <list type="bullet">
        /// <item><description>If the instance type specifies the local SSD storage type, the default value of this parameter is <b>local_ssd</b>.</description></item>
        /// <item><description>If the instance type specifies the standard SSD or ESSD storage type, the default value of this parameter is <b>cloud_essd</b>.</description></item>
        /// </list>
        /// <remarks>
        /// <para> Serverless instances support only PL1 ESSDs and general ESSDs.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cloud_essd</para>
        /// </summary>
        [NameInMap("DBInstanceStorageType")]
        [Validation(Required=false)]
        public string DBInstanceStorageType { get; set; }

        /// <summary>
        /// <para>Specifies whether the table name is case-sensitive. Valid values:</para>
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
        /// <para>The parameter template ID. You can call the DescribeParameterGroups operation to query the parameter template ID.</para>
        /// <remarks>
        /// <para> This parameter is available if you want to create an instance that runs MySQL or PostgreSQL. If you do not configure this parameter, the default parameter template is used. If you want to use a custom parameter template, you can customize a parameter template and set this parameter to the ID of the custom template.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rpg-sys-*****</para>
        /// </summary>
        [NameInMap("DBParamGroupId")]
        [Validation(Required=false)]
        public string DBParamGroupId { get; set; }

        /// <summary>
        /// <para>The time zone of the instance. This parameter takes effect only when you set the <b>Engine</b> parameter to <b>MySQL</b> or <b>PostgreSQL</b>.</para>
        /// <list type="bullet">
        /// <item><description><para>If you set <b>Engine</b> to <b>MySQL</b>:</para>
        /// <list type="bullet">
        /// <item><description>The time zone of the instance is in UTC. Valid values: <b>-12:59</b> to <b>+13:00</b>.</description></item>
        /// <item><description>If the instance uses local SSDs, you can specify the name of the time zone. Example: Asia/Hong_Kong. For more information, see <a href="https://help.aliyun.com/document_detail/297356.html">Time zones</a>.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>If you set <b>Engine</b> to <b>PostgreSQL</b>:</para>
        /// <list type="bullet">
        /// <item><description>The time zone of the instance is not in UTC. For more information, see <a href="https://help.aliyun.com/document_detail/297356.html">Time zones</a>.</description></item>
        /// <item><description>You can specify this parameter only when the instance runs PostgreSQL with standard SSDs or ESSDs.</description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You can specify the time zone when you create a primary instance. You cannot specify the time zone when you create a read-only instance. Read-only instances inherit the time zone of their primary instance.</description></item>
        /// <item><description>If you do not specify this parameter, the system automatically assigns the default time zone of the region in which the instance resides.</description></item>
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
        /// <para>The ID of the dedicated cluster to which the instance belongs.</para>
        /// <para>If you create the instance in a dedicated cluster, you must specify this parameter.</para>
        /// <list type="bullet">
        /// <item><description>You can call the DescribeDedicatedHostGroups operation to query the information about the dedicated cluster.</description></item>
        /// <item><description>If no dedicated clusters are created, you can call the CreateDedicatedHostGroup operation to create a dedicated cluster.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>dhg-4n*****</para>
        /// </summary>
        [NameInMap("DedicatedHostGroupId")]
        [Validation(Required=false)]
        public string DedicatedHostGroupId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the release protection feature for the instance. This feature is available only for pay-as-you-go instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b> (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DeletionProtection")]
        [Validation(Required=false)]
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: performs a dry run but does not create the instance. The system checks items such as the request parameters, request format, service limits, and available resources.</description></item>
        /// <item><description><b>false</b> (default): performs a dry run and sends the request. If the request passes the dry run, the instance is created.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The ID of the key that is used for cloud disk encryption in the region in which the instance is deployed. If this parameter is specified, cloud disk encryption is enabled and you must also specify the <b>RoleARN</b> parameter. Cloud disk encryption cannot be disabled after it is enabled.</para>
        /// <para>You can obtain the ID of the key in the Key Management Service (KMS) console or create a key. For more information, see <a href="https://help.aliyun.com/document_detail/181610.html">Create a key</a>.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This parameter is not required when you create an instance that runs MySQL, PostgreSQL, or SQL Server. You need to only specify the <b>RoleARN</b> parameter to create an instance that has cloud disk encryption enabled by using the obtained key ID.</description></item>
        /// <item><description>You can configure RAM authorization to require a RAM user to enable cloud disk encryption when the RAM user is used to create an instance. If cloud disk encryption is disabled during the instance creation, the creation operation fails. To complete the configuration, you can attach the following policy to the RAM user: <c>{&quot;Version&quot;:&quot;1&quot;,&quot;Statement&quot;:[{&quot;Effect&quot;:&quot;Deny&quot;,&quot;Action&quot;:&quot;rds:CreateDBInstance&quot;,&quot;Resource&quot;:&quot;*&quot;,&quot;Condition&quot;:{&quot;StringEquals&quot;:{&quot;rds:DiskEncryptionRequired&quot;:&quot;false&quot;}}}]}</c></description></item>
        /// </list>
        /// </remarks>
        /// <remarks>
        /// <para>Warning: The configuration also affects the CreateOrder operation that is called to create instances in the console.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0d24*****-da7b-4786-b981-9a164dxxxxxx</para>
        /// </summary>
        [NameInMap("EncryptionKey")]
        [Validation(Required=false)]
        public string EncryptionKey { get; set; }

        /// <summary>
        /// <para>The database engine of the instance. Valid values:</para>
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
        /// <para>The database engine version of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Regular instance</para>
        /// <list type="bullet">
        /// <item><description>Valid values when you set Engine to MySQL: <b>5.5</b>, <b>5.6</b>, <b>5.7</b>, and <b>8.0</b></description></item>
        /// <item><description>Valid values when you set Engine to SQLServer: <b>08r2_ent_ha</b> (cloud disks, discontinued), <b>2008r2</b> (local disks, discontinued), <b>2012</b> (SQL Server EE Basic), <b>2012_ent_ha</b>, <b>2012_std_ha</b>, <b>2012_web</b>, <b>2014_ent_ha</b>, <b>2014_std_ha</b>, <b>2016_ent_ha</b>, <b>2016_std_ha</b>, <b>2016_web</b>, <b>2017_ent</b>, <b>2017_std_ha</b>, <b>2017_web</b>, <b>2019_ent</b>, <b>2019_std_ha</b>, <b>2019_web</b>, <b>2022_ent</b>, <b>2022_std_ha</b>, and <b>2022_web</b></description></item>
        /// <item><description>Valid values when you set Engine to PostgreSQL: <b>10.0</b>, <b>11.0</b>, <b>12.0</b>, <b>13.0</b>, <b>14.0</b>, <b>15.0</b>, and <b>16.0</b></description></item>
        /// <item><description>Valid value if you set Engine to MariaDB: <b>10.3</b></description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Serverless instance</para>
        /// <list type="bullet">
        /// <item><description>Valid values when you set Engine to MySQL: <b>5.7</b> and <b>8.0</b></description></item>
        /// <item><description>Valid values when you set Engine to SQLServer: <b>2016_std_sl</b>, <b>2017_std_sl</b>, and <b>2019_std_sl</b></description></item>
        /// <item><description>Valid values when you set Engine to PostgreSQL: <b>14.0</b>, <b>15.0</b>, and <b>16.0</b></description></item>
        /// </list>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>ApsaraDB RDS for MariaDB does not support serverless instances.</description></item>
        /// <item><description>RDS instances that run SQL Server: <c>_ent</c> specifies SQL Server EE (Always On), <c>_ent_ha</c> specifies SQL Server EE, <c>_std_ha</c> specifies SQL Server SE, and <c>_web</c> specifies SQL Server Web.</description></item>
        /// <item><description>RDS instances that run SQL Server 2014 are not available for purchase on the international site (alibabacloud.com).</description></item>
        /// <item><description>Babelfish is supported only for RDS instances that run PostgreSQL 15.</description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5.6</para>
        /// </summary>
        [NameInMap("EngineVersion")]
        [Validation(Required=false)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// <para>The network type of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VPC</b>: a virtual private cloud (VPC)</description></item>
        /// <item><description><b>Classic</b>: the classic network</description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If the instance runs MySQL and uses cloud disks, you must set this parameter to <b>VPC</b>.</para>
        /// </description></item>
        /// <item><description><para>If the instance runs PostgreSQL or MariaDB, you must set this parameter to <b>VPC</b>.</para>
        /// </description></item>
        /// <item><description><para>If the instance runs SQL Server Basic or SQL Server Web, you can set this parameter to VPC or Classic. If the instance runs other database engine, you must set this parameter to <b>VPC</b>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Classic</para>
        /// </summary>
        [NameInMap("InstanceNetworkType")]
        [Validation(Required=false)]
        public string InstanceNetworkType { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the I/O acceleration feature of general ESSDs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: enabled</description></item>
        /// <item><description><b>0</b>: disabled</description></item>
        /// </list>
        /// <remarks>
        /// <para> For more information about the I/O acceleration feature of general ESSDs, see <a href="https://help.aliyun.com/document_detail/2527067.html">Introduction</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("IoAccelerationEnabled")]
        [Validation(Required=false)]
        public string IoAccelerationEnabled { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the write optimization feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>optimized</b>: enables the feature.</description></item>
        /// <item><description><b>none</b>: disables the feature.</description></item>
        /// </list>
        /// <remarks>
        /// <para> For more information about the write optimization feature, see <a href="https://help.aliyun.com/document_detail/2858761.html">Write optimization</a>.</para>
        /// </remarks>
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
        /// <item><description><b>Serverless</b>: serverless. This value is not supported for instances that run MariaDB. For more information, see <a href="https://help.aliyun.com/document_detail/411291.html">Overview of serverless ApsaraDB RDS for MySQL instances</a>, <a href="https://help.aliyun.com/document_detail/604344.html">Overview of serverless ApsaraDB RDS for SQL Server instances</a>, and <a href="https://help.aliyun.com/document_detail/607742.html">Overview of serverless ApsaraDB RDS for PostgreSQL instances</a>.</description></item>
        /// </list>
        /// <remarks>
        /// <para>The system automatically generates a purchase order and completes the payment.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Postpaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The unit of the subscription duration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Year</b></description></item>
        /// <item><description><b>Month</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> If you set the PayType parameter to <b>Prepaid</b>, you must also specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Year</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The port. You can initialize the port when you create the instance.</para>
        /// <list type="bullet">
        /// <item><description>Valid values if the instance runs MySQL: 1000 to 65534</description></item>
        /// <item><description>Valid values if the instance runs PostgreSQL, SQL Server, or MariaDB: 1000 to 5999</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3306</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public string Port { get; set; }

        /// <summary>
        /// <para>The private IP address of the instance. The private IP address must be within the CIDR block that is supported by the specified vSwitch. ApsaraDB RDS automatically assigns a private IP address to the instance based on the values of the <b>VPCId</b> and <b>vSwitchId</b> parameters.</para>
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
        /// <para>The region ID. You can call the DescribeRegions operation to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmy*****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud Resource Name (ARN) that is provided by your Alibaba Cloud account for RAM users. RAM users can use the ARN to connect ApsaraDB RDS to KMS. You can call the CheckCloudResourceAuthorized operation to query the ARN.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::1406xxxxxx:role/aliyunrdsinstanceencryptiondefaultrole</para>
        /// </summary>
        [NameInMap("RoleARN")]
        [Validation(Required=false)]
        public string RoleARN { get; set; }

        /// <summary>
        /// <para>The IP address whitelist of the instance. For more information, see <a href="https://help.aliyun.com/document_detail/43185.html">Use a database client or the CLI to connect to an ApsaraDB RDS for MySQL instance</a>. If the IP address whitelist contains more than one entry, separate the entries with commas (,). Each entry must be unique. The IP address whitelist can contain up to 1,000 entries. The entries in the IP address whitelist must be in one of the following formats:</para>
        /// <list type="bullet">
        /// <item><description>IP addresses, such as 10.10.XX.XX.</description></item>
        /// <item><description>CIDR blocks, such as 10.10.XX.XX/24. In this example, 24 indicates that the prefix of each IP address in the IP address whitelist is 24 bits in length. You can replace 24 with a value within the range of 1 to 32.</description></item>
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
        /// <para>The settings of the serverless instance. This parameter is required when you create a serverless instance.</para>
        /// <remarks>
        /// <para> ApsaraDB RDS for MariaDB does not support serverless instances.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ServerlessConfig")]
        [Validation(Required=false)]
        public CreateDBInstanceRequestServerlessConfig ServerlessConfig { get; set; }
        public class CreateDBInstanceRequestServerlessConfig : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable the automatic startup and stop feature for the serverless instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b> (default)</description></item>
            /// </list>
            /// <remarks>
            /// <para> This parameter is required only for serverless instances that run MySQL and PostgreSQL. After the automatic start and stop feature is enabled, if no connections to the instance are established within 10 minutes, the instance is suspended. After a connection to the instance is established, the instance is resumed.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("AutoPause")]
            [Validation(Required=false)]
            public bool? AutoPause { get; set; }

            /// <summary>
            /// <para>The maximum number of RDS Capacity Units (RCUs). Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Serverless ApsaraDB RDS for MySQL instances: <b>1 to 32</b></description></item>
            /// <item><description>Serverless ApsaraDB RDS for SQL Server instances: <b>2 to 8</b></description></item>
            /// <item><description>Serverless ApsaraDB RDS for PostgreSQL instances: <b>1 to 14</b></description></item>
            /// </list>
            /// <remarks>
            /// <para> The value of this parameter must be greater than or equal to the value of the <b>MinCapacity</b> parameter and can be set only to an <b>integer</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>8</para>
            /// </summary>
            [NameInMap("MaxCapacity")]
            [Validation(Required=false)]
            public double? MaxCapacity { get; set; }

            /// <summary>
            /// <para>The minimum number of RCUs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Serverless ApsaraDB RDS for MySQL instances: <b>0.5 to 32</b>.</description></item>
            /// <item><description>Serverless ApsaraDB RDS for SQL Server instances: <b>2 to 8</b>. Only integers are supported.</description></item>
            /// <item><description>Serverless ApsaraDB RDS for PostgreSQL instances: <b>0.5 to 14</b></description></item>
            /// </list>
            /// <remarks>
            /// <para> The value of this parameter must be less than or equal to the value of the <b>MaxCapacity</b> parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>0.5</para>
            /// </summary>
            [NameInMap("MinCapacity")]
            [Validation(Required=false)]
            public double? MinCapacity { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable the forced scaling feature for the serverless instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b> (default)</description></item>
            /// </list>
            /// <remarks>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description><para>This parameter is required only for serverless instances that run MySQL and PostgreSQL. If you set this parameter to true, a service interruption that lasts approximately 30 to 120 seconds occurs during forced scaling. Process with caution.</para>
            /// </description></item>
            /// <item><description><para>The RCU scaling for a serverless instance immediately takes effect. In some cases, such as the execution of large transactions, the scaling does not immediately take effect. In this case, you can enable this feature to forcefully scale the RCUs of the instance.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("SwitchForce")]
            [Validation(Required=false)]
            public bool? SwitchForce { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to enable the automatic storage expansion feature for the instance. If the instance runs MySQL or PostgreSQL, this feature is supported. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enable</b></description></item>
        /// <item><description><b>Disable</b> (default)</description></item>
        /// </list>
        /// <remarks>
        /// <para> After the instance is created, you can call the ModifyDasInstanceConfig operation to adjust the settings. For more information, see <a href="https://help.aliyun.com/document_detail/173826.html">Configure automatic storage expansion</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Disable</para>
        /// </summary>
        [NameInMap("StorageAutoScale")]
        [Validation(Required=false)]
        public string StorageAutoScale { get; set; }

        /// <summary>
        /// <para>The threshold in percentage based on which automatic storage expansion is triggered. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>10</b></description></item>
        /// <item><description><b>20</b></description></item>
        /// <item><description><b>30</b></description></item>
        /// <item><description><b>40</b></description></item>
        /// <item><description><b>50</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> If you set the <b>StorageAutoScale</b> parameter to <b>Enable</b>, you must also specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("StorageThreshold")]
        [Validation(Required=false)]
        public int? StorageThreshold { get; set; }

        /// <summary>
        /// <para>The maximum storage capacity that is allowed for automatic storage expansion. The storage capacity of the instance cannot exceed the maximum storage capacity. Unit: GB.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Valid values: an integer greater than or equal to 0.</description></item>
        /// <item><description>If you set <b>StorageAutoScale</b> to <b>Enable</b>, you must specify this parameter.</description></item>
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
        /// <para>A deprecated parameter. You do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gbk</para>
        /// </summary>
        [NameInMap("SystemDBCharset")]
        [Validation(Required=false)]
        public string SystemDBCharset { get; set; }

        /// <summary>
        /// <para>The tags that are added to instances.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateDBInstanceRequestTag> Tag { get; set; }
        public class CreateDBInstanceRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. You can use this parameter to add tags to the instance.</para>
            /// <list type="bullet">
            /// <item><description>If the specified tag key is an existing key, the system directly adds the tag key to the instance. You can call the ListTagResources to query the existing tag.</description></item>
            /// <item><description>If the specified tag key does not exist, the system creates the tag key and adds the tag key to the instance.</description></item>
            /// <item><description>The value cannot be an empty string.</description></item>
            /// <item><description>This parameter must be used together with the <b>Tag.Value</b> parameter.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>testkey1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. You can use this parameter to add tags to the instance.</para>
            /// <list type="bullet">
            /// <item><description>If the specified tag value is found in the specified tag key, the system directly adds the tag value to the instance. You can call the ListTagResources to query the existing tag.</description></item>
            /// <item><description>If the specified tag value is not found in the specified tag key, the system creates the tag value and adds the tag value to the instance.</description></item>
            /// <item><description>This parameter must be used together with the <b>Tag.Key</b> parameter.</description></item>
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
        /// <para>The ID of the host to which the logger instance belongs in the specified dedicated cluster.</para>
        /// <para>If you want to create an instance that runs RDS Enterprise Edition in a dedicated cluster, you must specify this parameter. If you do not specify this parameter, the system automatically assigns a host.</para>
        /// <list type="bullet">
        /// <item><description>You can call the DescribeDedicatedHosts operation to query the host in the dedicated cluster.</description></item>
        /// <item><description>If no hosts are created, you can call the CreateDedicatedHost operation to create a host.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp*****3</para>
        /// </summary>
        [NameInMap("TargetDedicatedHostIdForLog")]
        [Validation(Required=false)]
        public string TargetDedicatedHostIdForLog { get; set; }

        /// <summary>
        /// <para>The ID of the host to which the instance belongs in the specified dedicated cluster.</para>
        /// <para>If you create the instance in a dedicated cluster, you must specify this parameter. If you do not specify this parameter, the system automatically assigns a host.</para>
        /// <list type="bullet">
        /// <item><description>You can call the DescribeDedicatedHosts operation to query the host in the dedicated cluster.</description></item>
        /// <item><description>If no hosts are created, you can call the CreateDedicatedHost operation to create a host.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp*****1</para>
        /// </summary>
        [NameInMap("TargetDedicatedHostIdForMaster")]
        [Validation(Required=false)]
        public string TargetDedicatedHostIdForMaster { get; set; }

        /// <summary>
        /// <para>The ID of the host to which the secondary instance belongs in the specified dedicated cluster.</para>
        /// <para>If you want to create an instance that runs RDS High-availability Edition or RDS Enterprise Edition in a dedicated cluster, you must specify this parameter. If you do not specify this parameter, the system automatically assigns a host.</para>
        /// <list type="bullet">
        /// <item><description>You can call the DescribeDedicatedHosts operation to query the host in the dedicated cluster.</description></item>
        /// <item><description>If no hosts are created, you can call the CreateDedicatedHost operation to create a host.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>i-bp*****2</para>
        /// </summary>
        [NameInMap("TargetDedicatedHostIdForSlave")]
        [Validation(Required=false)]
        public string TargetDedicatedHostIdForSlave { get; set; }

        /// <summary>
        /// <para>The minor engine version of the instance. This parameter is required only when you create an instance that runs MySQL or PostgreSQL. The value format varies based on the database engine of the instance.</para>
        /// <list type="bullet">
        /// <item><description><para>If you create an instance that runs MySQL, the value is in the following format: <c>&lt;RDS edition&gt;_&lt;Minor engine version&gt;</c>. Examples: <c>rds_20200229</c>, <c>xcluster_20200229</c>, and <c>xcluster80_20200229</c>.</para>
        /// <list type="bullet">
        /// <item><description>rds: The instance runs RDS Basic Edition or RDS High-availability Edition.</description></item>
        /// <item><description>xcluster: The instance runs MySQL 5.7 on RDS Enterprise Edition.</description></item>
        /// <item><description>xcluster80: The instance runs MySQL 8.0 on RDS Enterprise Edition.</description></item>
        /// </list>
        /// <remarks>
        /// <para>You can call the DescribeDBMiniEngineVersions operation to query the minor engine version. For more information about the differences between minor engine versions of AliSQL, see <a href="https://help.aliyun.com/document_detail/96060.html">Release notes</a>.</para>
        /// </remarks>
        /// </description></item>
        /// <item><description><para>If you create an instance that runs PostgreSQL, the value is in the following format: <c>rds_postgres_&lt;Major engine version&gt;00_&lt;Minor engine version&gt;</c>. Example: <c>rds_postgres_1400_20220830</c>.</para>
        /// <list type="bullet">
        /// <item><description>1400: The major engine version is PostgreSQL 14.</description></item>
        /// <item><description>20220830: the AliPG version. You can call the DescribeDBMiniEngineVersions operation to query the AliPG version. For more information about minor engine versions, see <a href="https://help.aliyun.com/document_detail/126002.html">Release notes for AliPG</a>.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you configure the <b>BabelfishConfig</b> parameter for your instance that runs PostgreSQL and set the babelfishEnabled field to true, the value of this parameter is in the following format: <c>rds_postgres_Major engine version00_AliPG version_babelfish</c>.</para>
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
        /// <para>The subscription duration of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If you set the <b>Period</b> parameter to <b>Year</b>, the value of the <b>UsedTime</b> parameter ranges from <b>1 to 5</b>.</description></item>
        /// <item><description>If you set the <b>Period</b> parameter to <b>Month</b>, the value of the <b>UsedTime</b> parameter ranges from <b>1 to 11</b>.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you set the PayType parameter to <b>Prepaid</b>, you must also specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public string UsedTime { get; set; }

        /// <summary>
        /// <para>The ID of the full backup file. You can call the ListUserBackupFiles operation to query the ID of the full backup file. If you want to create an instance by using the data of a backup file, you must specify this parameter.</para>
        /// <para>This parameter is supported only when the following requirements are met:</para>
        /// <list type="bullet">
        /// <item><description>The <b>PayType</b> parameter is set to <b>Postpaid</b>.</description></item>
        /// <item><description>The <b>Engine</b> parameter is set to <b>MySQL</b>.</description></item>
        /// <item><description>The <b>EngineVersion</b> parameter is set to <b>5.7</b>.</description></item>
        /// <item><description>The <b>Category</b> parameter is set to <b>Basic</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>67798*****</para>
        /// </summary>
        [NameInMap("UserBackupId")]
        [Validation(Required=false)]
        public string UserBackupId { get; set; }

        /// <summary>
        /// <para>The ID of the VPC to which the instance belongs.</para>
        /// <remarks>
        /// <para>This parameter is available when you set the <b>InstanceNetworkType</b> parameter to <b>VPC</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-*****</para>
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// <para>The vSwitch ID. The vSwitch must belong to the zone that is specified by <b>ZoneId</b>.</para>
        /// <list type="bullet">
        /// <item><description>If you set <b>InstanceNetworkType</b> to <b>VPC</b>, you must also specify this parameter.</description></item>
        /// <item><description>If you set the <b>ZoneSlaveId1</b> parameter to a value that is not <b>Auto</b>, you must specify the IDs of two vSwitches for this parameter and separate the IDs with a comma (,). The ZoneSlaveId1 parameter specifies the zone ID of the secondary node.</description></item>
        /// <item><description>The value cannot contain <c>spaces</c>, exclamation points <c>(!)</c>, or special characters such as number signs <c>(#)</c>, dollar signs <c>($)</c>, ampersands <c>(&amp;)</c>, and percent signs <c>(%)</c>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-*****</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The entries in the whitelist. If you enter multiple IP addresses or CIDR blocks, you must separate the IP addresses or CIDR blocks with commas (,). Do not add spaces preceding or following the commas. Example: <c>192.168.0.1,172.16.213.9</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.XXX.XX.1,172.XXX.XX.9</para>
        /// </summary>
        [NameInMap("WhitelistTemplateList")]
        [Validation(Required=false)]
        public string WhitelistTemplateList { get; set; }

        /// <summary>
        /// <para>The zone ID of the primary instance.</para>
        /// <list type="bullet">
        /// <item><description>If you specify a virtual private cloud (VPC) and a vSwitch, you must specify the ID of the zone to which the specified vSwitch belongs. Otherwise, the instance cannot be created.</description></item>
        /// <item><description>If the instance runs RDS High-availability Edition, you must specify the <b>ZoneIdSlave1</b> parameter. The ZoneIdSlave1 parameter specifies whether to use the single-zone deployment method or the multi-zone deployment method.</description></item>
        /// <item><description>If the instance runs RDS Enterprise Edition, you must specify the <b>ZoneIdSlave1</b> and <b>ZoneIdSlave2</b> parameters. The ZoneIdSlave1 and ZoneIdSlave2 parameters specify whether to use the single-zone deployment method or the multi-zone deployment method.</description></item>
        /// <item><description>If the instance runs MySQL on RDS Cluster Edition, you must specify the <b>ZoneIdSlave1</b> parameter for the RDS cluster that has two nodes and the <b>ZoneIdSlave1</b> and <b>ZoneIdSlave2</b> parameters for the RDS cluster that has three nodes.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-b</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

        /// <summary>
        /// <para>The zone ID of the secondary instance.</para>
        /// <list type="bullet">
        /// <item><description>If you set this parameter to <b>Auto</b>, the multi-zone deployment method is used and the zone of the secondary instance is automatically configured.</description></item>
        /// <item><description>If you set this parameter to the same value as the <b>ZoneId</b> parameter, the single-zone deployment method is used.</description></item>
        /// <item><description>If you set this parameter to a value that is different from the value of the <b>ZoneId</b> parameter, the multiple-zone deployment method is used.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-c</para>
        /// </summary>
        [NameInMap("ZoneIdSlave1")]
        [Validation(Required=false)]
        public string ZoneIdSlave1 { get; set; }

        /// <summary>
        /// <para>The zone ID of the other secondary node. When you create an ApsaraDB RDS for MySQL cluster, you can create one to two secondary nodes for the cluster. This parameter applies if you create a cluster that contains two secondary nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-d</para>
        /// </summary>
        [NameInMap("ZoneIdSlave2")]
        [Validation(Required=false)]
        public string ZoneIdSlave2 { get; set; }

    }

}
