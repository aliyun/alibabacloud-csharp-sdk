// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20190306.Models
{
    public class CreateAndStartBackupPlanRequest : TeaModel {
        /// <summary>
        /// <para>The backup gateway ID.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>If <b>SourceEndpointInstanceType</b> is set to <b>Agent</b>, this parameter is required.****</para>
        /// </description></item>
        /// <item><description><para>For more information about how to install a backup gateway, see <a href="https://help.aliyun.com/document_detail/93250.html">Install a backup gateway</a>.</para>
        /// </description></item>
        /// <item><description><para>You can query a list of existing backup gateways by calling the <a href="https://help.aliyun.com/document_detail/2869840.html">DescribeBackupGatewayList</a> operation.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>23313123312</para>
        /// </summary>
        [NameInMap("BackupGatewayId")]
        [Validation(Required=false)]
        public long? BackupGatewayId { get; set; }

        /// <summary>
        /// <para>The interval at which you want to perform incremental log backups. Unit: seconds.</para>
        /// <remarks>
        /// <para> This parameter is required only if you set BackupMethod to <b>physical</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("BackupLogIntervalSeconds")]
        [Validation(Required=false)]
        public int? BackupLogIntervalSeconds { get; set; }

        /// <summary>
        /// <para>The method that is used to generate the backup file. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>logical</b>: logical backup</description></item>
        /// <item><description><b>physical</b>: physical backup</description></item>
        /// <item><description><b>duplication</b>: dump backup</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>logical</para>
        /// </summary>
        [NameInMap("BackupMethod")]
        [Validation(Required=false)]
        public string BackupMethod { get; set; }

        /// <summary>
        /// <para>The object to be backed up.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[ { &quot;DBName&quot;:&quot;Name of the database to be backed up&quot;, &quot;SchemaName&quot;:&quot;Name of the schema to be backed up&quot;, &quot;TableIncludes&quot;:[{ &quot;TableName&quot;:&quot;Name of the table to be backed up&quot; }], &quot;TableExcludes&quot;:[{ &quot;TableName&quot;:&quot;Name of the table that you do not want to back up&quot; }] } ]</para>
        /// </summary>
        [NameInMap("BackupObjects")]
        [Validation(Required=false)]
        public string BackupObjects { get; set; }

        /// <summary>
        /// <para>The day of the week on which you want to perform full backup. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Monday</b></description></item>
        /// <item><description><b>Tuesday</b></description></item>
        /// <item><description><b>Wednesday</b></description></item>
        /// <item><description><b>Thursday</b></description></item>
        /// <item><description><b>Friday</b></description></item>
        /// <item><description><b>Saturday</b></description></item>
        /// <item><description><b>Sunday</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> You can specify multiple values. Separate multiple values with commas (,).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Monday</para>
        /// </summary>
        [NameInMap("BackupPeriod")]
        [Validation(Required=false)]
        public string BackupPeriod { get; set; }

        /// <summary>
        /// <para>The ID of the backup schedule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dbstooi0*******</para>
        /// </summary>
        [NameInMap("BackupPlanId")]
        [Validation(Required=false)]
        public string BackupPlanId { get; set; }

        /// <summary>
        /// <para>The name of the backup schedule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dbstooi0*******</para>
        /// </summary>
        [NameInMap("BackupPlanName")]
        [Validation(Required=false)]
        public string BackupPlanName { get; set; }

        /// <summary>
        /// <para>The network bandwidth throttling. Unit: KB/s. DBS allows a maximum bandwidth of 10 GB/s.</para>
        /// <remarks>
        /// <para> This parameter takes effect only when physical backups for MySQL databases are performed.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>262144</para>
        /// </summary>
        [NameInMap("BackupRateLimit")]
        [Validation(Required=false)]
        public long? BackupRateLimit { get; set; }

        /// <summary>
        /// <para>The number of days for which the backup data is retained. Valid values: 0 to 1825. Default value: 730.</para>
        /// 
        /// <b>Example:</b>
        /// <para>730</para>
        /// </summary>
        [NameInMap("BackupRetentionPeriod")]
        [Validation(Required=false)]
        public int? BackupRetentionPeriod { get; set; }

        /// <summary>
        /// <para>The I/O limit for the disk. Unit: KB/s.</para>
        /// <remarks>
        /// <para> This parameter takes effect only when physical backups for MySQL databases are performed.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>262144</para>
        /// </summary>
        [NameInMap("BackupSpeedLimit")]
        [Validation(Required=false)]
        public long? BackupSpeedLimit { get; set; }

        /// <summary>
        /// <para>The start time of full backup tasks. Specify the value in the <em>HH:mm</em> format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>14:22</para>
        /// </summary>
        [NameInMap("BackupStartTime")]
        [Validation(Required=false)]
        public string BackupStartTime { get; set; }

        /// <summary>
        /// <para>The storage type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Empty: If you do not specify this parameter, the system stores backup data in your OSS bucket.</description></item>
        /// <item><description>system : The system stores backup data in the built-in OSS bucket of DBS.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>N/A</para>
        /// </summary>
        [NameInMap("BackupStorageType")]
        [Validation(Required=false)]
        public string BackupStorageType { get; set; }

        /// <summary>
        /// <para>The backup method that you want to use for full backups. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>simple</b>: scheduled backup. If you specify this value for the BackupStrategyType parameter, you must also specify the BackupPeriod and BackupStartTime parameters.</description></item>
        /// <item><description><b>Manual</b>: manual backup.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Default value: <b>simple</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>simple</para>
        /// </summary>
        [NameInMap("BackupStrategyType")]
        [Validation(Required=false)]
        public string BackupStrategyType { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DBS</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The unique ID (UID) of the Alibaba Cloud account to which the source database belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2xxx7778xxxxxxxxxx</para>
        /// </summary>
        [NameInMap("CrossAliyunId")]
        [Validation(Required=false)]
        public string CrossAliyunId { get; set; }

        /// <summary>
        /// <para>The name of the RAM role that is used to perform backups across Alibaba Cloud accounts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test123</para>
        /// </summary>
        [NameInMap("CrossRoleName")]
        [Validation(Required=false)]
        public string CrossRoleName { get; set; }

        /// <summary>
        /// <para>The region in which the database that you want to back up resides.</para>
        /// <remarks>
        /// <para>This parameter is required if the <b>PayType</b> parameter is set to <b>postpay</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("DatabaseRegion")]
        [Validation(Required=false)]
        public string DatabaseRegion { get; set; }

        /// <summary>
        /// <para>The type of the source database. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>MySQL</b></description></item>
        /// <item><description><b>MSSQL</b></description></item>
        /// <item><description><b>Oracle</b></description></item>
        /// <item><description><b>MariaDB</b></description></item>
        /// <item><description><b>PostgreSQL</b></description></item>
        /// <item><description><b>DRDS</b></description></item>
        /// <item><description><b>MongoDB</b></description></item>
        /// <item><description><b>Redis</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL</para>
        /// </summary>
        [NameInMap("DatabaseType")]
        [Validation(Required=false)]
        public string DatabaseType { get; set; }

        /// <summary>
        /// <para>The number of days after which the storage class of the backup data is changed to Archive. Default value: 365.</para>
        /// 
        /// <b>Example:</b>
        /// <para>365</para>
        /// </summary>
        [NameInMap("DuplicationArchivePeriod")]
        [Validation(Required=false)]
        public int? DuplicationArchivePeriod { get; set; }

        /// <summary>
        /// <para>The number of days after which the storage class of the backup data is changed to Infrequent Access (IA). Default value: 180.</para>
        /// 
        /// <b>Example:</b>
        /// <para>180</para>
        /// </summary>
        [NameInMap("DuplicationInfrequentAccessPeriod")]
        [Validation(Required=false)]
        public int? DuplicationInfrequentAccessPeriod { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the incremental log backup feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables the incremental log backup feature.</description></item>
        /// <item><description><b>false</b>: disables the incremental log backup feature.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableBackupLog")]
        [Validation(Required=false)]
        public bool? EnableBackupLog { get; set; }

        /// <summary>
        /// <para>The request source. Default value: OpenApi. You do not need to set this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OpenApi</para>
        /// </summary>
        [NameInMap("FromApp")]
        [Validation(Required=false)]
        public string FromApp { get; set; }

        /// <summary>
        /// <para>The type of the backup schedule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>micro</b></description></item>
        /// <item><description><b>small</b></description></item>
        /// <item><description><b>medium</b></description></item>
        /// <item><description><b>large</b></description></item>
        /// <item><description><b>xlarge</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> A backup schedule type with higher specifications offers higher backup and restoration performance. For more information, see <a href="https://help.aliyun.com/document_detail/84372.html">Select a backup schedule type</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>micro</para>
        /// </summary>
        [NameInMap("InstanceClass")]
        [Validation(Required=false)]
        public string InstanceClass { get; set; }

        /// <summary>
        /// <para>The type of the source database instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>RDS</b>: ApsaraDB RDS.</description></item>
        /// <item><description><b>PolarDB</b>: PolarDB.</description></item>
        /// <item><description><b>DDS</b>: ApsaraDB for MongoDB.</description></item>
        /// <item><description><b>Kvstore</b>: ApsaraDB for Redis.</description></item>
        /// <item><description><b>Other</b>: Database connected by using an IP address and a port number.</description></item>
        /// <item><description><b>dg</b>: Self-managed database that has no public IP address or port number and is connected over Database Gateway.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If <b>PayType</b> is set to <b>postpay</b>, this parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>RDS</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The name of the Object Storage Service (OSS) bucket used to store backup files. By default, the system automatically generates a name for the OSS bucket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestOssBucket</para>
        /// </summary>
        [NameInMap("OSSBucketName")]
        [Validation(Required=false)]
        public string OSSBucketName { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>The billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>postpay</b>: pay-as-you-go.</description></item>
        /// <item><description><b>prepay</b>: subscription.</description></item>
        /// </list>
        /// <remarks>
        /// <para> The default value is <b>prepay</b>. You can set this parameter to <b>postpay</b> only if you set <b>BackupMethod</b> to <b>duplication</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Postpaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>Specifies whether to use yearly subscription or monthly subscription for the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Year</b>: yearly subscription</description></item>
        /// <item><description><b>Month</b>: monthly subscription</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Year</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The ID of the region in which you want to store the backup data. You can query the supported regions of DBS by calling the <a href="https://help.aliyun.com/document_detail/2869853.html">DescribeRegions</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekzecovzti****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The name of the database.</para>
        /// <remarks>
        /// <para>This parameter is required if the DatabaseType parameter is set to <b>PostgreSQL</b> or <b>MongoDB</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testRDS</para>
        /// </summary>
        [NameInMap("SourceEndpointDatabaseName")]
        [Validation(Required=false)]
        public string SourceEndpointDatabaseName { get; set; }

        /// <summary>
        /// <para>The endpoint of the database.</para>
        /// <remarks>
        /// <para>This parameter is required if the <b>SourceEndpointInstanceType</b> parameter is set to <b>Express</b>, <b>Agent</b>, or <b>Other</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5xxxxxxx.mysql.rds.aliyuncs.com</para>
        /// </summary>
        [NameInMap("SourceEndpointIP")]
        [Validation(Required=false)]
        public string SourceEndpointIP { get; set; }

        /// <summary>
        /// <para>The ID of the database instance.</para>
        /// <remarks>
        /// <para>This parameter is required if the <b>SourceEndpointInstanceType</b> parameter is set to <b>RDS</b>, <b>ECS</b>, <b>DDS</b>, or <b>Express</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5xxxxxxxxxx</para>
        /// </summary>
        [NameInMap("SourceEndpointInstanceID")]
        [Validation(Required=false)]
        public string SourceEndpointInstanceID { get; set; }

        /// <summary>
        /// <para>The location of the source database. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>RDS</b>: The database is on an ApsaraDB RDS instance.</description></item>
        /// <item><description><b>ECS</b>: The database is on an Elastic Compute Service (ECS) instance.</description></item>
        /// <item><description><b>Express</b>: The database is connected to DBS by using Express Connect, VPN Gateway, or Smart Access Gateway.</description></item>
        /// <item><description><b>Agent</b>: The database is connected to DBS over a DBS backup gateway.</description></item>
        /// <item><description><b>DDS</b>: The database is on an ApsaraDB for MongoDB instance.</description></item>
        /// <item><description><b>Other</b>: The database is connected to DBS by using an IP address and a port number.</description></item>
        /// <item><description><b>dg</b>: The database is a self-managed database that has no public IP address or port number and is connected to DBS over Database Gateway.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RDS</para>
        /// </summary>
        [NameInMap("SourceEndpointInstanceType")]
        [Validation(Required=false)]
        public string SourceEndpointInstanceType { get; set; }

        /// <summary>
        /// <para>The system ID (SID) of the Oracle database. This parameter is required if the source database is an Oracle database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("SourceEndpointOracleSID")]
        [Validation(Required=false)]
        public string SourceEndpointOracleSID { get; set; }

        /// <summary>
        /// <para>The password of the account that is used to connect to the database.</para>
        /// <remarks>
        /// <para>This parameter is required except that the database is an SQL Server database that is connected to DBS over a DBS backup gateway or a Redis database.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testPassword</para>
        /// </summary>
        [NameInMap("SourceEndpointPassword")]
        [Validation(Required=false)]
        public string SourceEndpointPassword { get; set; }

        /// <summary>
        /// <para>The port of the database.</para>
        /// <remarks>
        /// <para>This parameter is required if the <b>SourceEndpointInstanceType</b> parameter is set to <b>Express</b>, <b>Agent</b>, <b>Other</b>, or <b>ECS</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3306</para>
        /// </summary>
        [NameInMap("SourceEndpointPort")]
        [Validation(Required=false)]
        public int? SourceEndpointPort { get; set; }

        /// <summary>
        /// <para>The region in which the database that you want to back up resides.</para>
        /// <remarks>
        /// <para>This parameter is required if the <b>SourceEndpointInstanceType</b> parameter is set to <b>RDS</b>, <b>ECS</b>, <b>DDS</b>, <b>Express</b>, or <b>Agent</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("SourceEndpointRegion")]
        [Validation(Required=false)]
        public string SourceEndpointRegion { get; set; }

        /// <summary>
        /// <para>The username of the account that is used to connect to the database.</para>
        /// <remarks>
        /// <para>This parameter is required except that the database is an SQL Server database that is connected to DBS over a DBS backup gateway or a Redis database.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testRDS</para>
        /// </summary>
        [NameInMap("SourceEndpointUserName")]
        [Validation(Required=false)]
        public string SourceEndpointUserName { get; set; }

        /// <summary>
        /// <para>The region in which you want to store the backup data.</para>
        /// <remarks>
        /// <para>This parameter is required if the <b>PayType</b> parameter is set to <b>postpay</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("StorageRegion")]
        [Validation(Required=false)]
        public string StorageRegion { get; set; }

        /// <summary>
        /// <para>This parameter is unavailable.</para>
        /// 
        /// <b>Example:</b>
        /// <para>N/A</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        /// <summary>
        /// <para>The subscription duration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>Period</b> is set to <b>Year</b>, the valid values of <b>UsedTime</b> range from 1 to 5.</description></item>
        /// <item><description>If <b>Period</b> is set to <b>Month</b>, the valid values of <b>UsedTime</b> range from 1 to 11.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public int? UsedTime { get; set; }

    }

}
