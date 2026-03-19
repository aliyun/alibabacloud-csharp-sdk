// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20190306.Models
{
    public class CreateAndStartBackupPlanRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the backup gateway.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is required if <b>SourceEndpoint</b>.<b>InstanceType</b> is set to <b>agent</b>.</para>
        /// </description></item>
        /// <item><description><para>For more information about how to create a backup gateway, see <a href="https://help.aliyun.com/document_detail/93250.html">Add a backup gateway</a>.</para>
        /// </description></item>
        /// <item><description><para>You can call the <a href="https://help.aliyun.com/document_detail/2869840.html">DescribeBackupGatewayList</a> operation to view the list of existing backup gateways.</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>23313123312</para>
        /// </summary>
        [NameInMap("BackupGatewayId")]
        [Validation(Required=false)]
        public long? BackupGatewayId { get; set; }

        /// <summary>
        /// <para>The interval for incremental backups, in seconds.</para>
        /// <remarks>
        /// <para>This parameter is required only for <b>physical backups</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("BackupLogIntervalSeconds")]
        [Validation(Required=false)]
        public int? BackupLogIntervalSeconds { get; set; }

        /// <summary>
        /// <para>The backup method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>logical</b>: logical backup</para>
        /// </description></item>
        /// <item><description><para><b>physical</b>: physical backup</para>
        /// </description></item>
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
        /// <para>The backup objects.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[     {         &quot;DBName&quot;:&quot;待备份库名&quot;,         &quot;SchemaName&quot;:&quot;待备份 Schema 名&quot;,         &quot;TableIncludes&quot;:[{             &quot;TableName&quot;:&quot;待备份表表名&quot;         }],         &quot;TableExcludes&quot;:[{             &quot;TableName&quot;:&quot;待备份库名不需要备份表的表名&quot;         }]     } ]</para>
        /// </summary>
        [NameInMap("BackupObjects")]
        [Validation(Required=false)]
        public string BackupObjects { get; set; }

        /// <summary>
        /// <para>The full backup cycle. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Monday</b></para>
        /// </description></item>
        /// <item><description><para><b>Tuesday</b></para>
        /// </description></item>
        /// <item><description><para><b>Wednesday</b></para>
        /// </description></item>
        /// <item><description><para><b>Thursday</b></para>
        /// </description></item>
        /// <item><description><para><b>Friday</b></para>
        /// </description></item>
        /// <item><description><para><b>Saturday</b></para>
        /// </description></item>
        /// <item><description><para><b>Sunday</b></para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>You can select multiple values. Separate them with commas (,).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Monday</para>
        /// </summary>
        [NameInMap("BackupPeriod")]
        [Validation(Required=false)]
        public string BackupPeriod { get; set; }

        /// <summary>
        /// <para>The ID of the backup plan.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dbstooi0*******</para>
        /// </summary>
        [NameInMap("BackupPlanId")]
        [Validation(Required=false)]
        public string BackupPlanId { get; set; }

        /// <summary>
        /// <para>The custom name of the backup plan.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dbstooi0*******</para>
        /// </summary>
        [NameInMap("BackupPlanName")]
        [Validation(Required=false)]
        public string BackupPlanName { get; set; }

        /// <summary>
        /// <para>The network bandwidth throttling limit, in KB/s. The maximum allowed value is 10 GB.</para>
        /// <remarks>
        /// <para>This parameter is valid only for MySQL physical backups.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>262144</para>
        /// </summary>
        [NameInMap("BackupRateLimit")]
        [Validation(Required=false)]
        public long? BackupRateLimit { get; set; }

        /// <summary>
        /// <para>The retention period for backup data, in days. Valid values: 0 to 1825. Default value: 730.</para>
        /// 
        /// <b>Example:</b>
        /// <para>730</para>
        /// </summary>
        [NameInMap("BackupRetentionPeriod")]
        [Validation(Required=false)]
        public int? BackupRetentionPeriod { get; set; }

        /// <summary>
        /// <para>The disk I/O limit, in KB/s.</para>
        /// <remarks>
        /// <para>This parameter is valid only for MySQL physical backups.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>262144</para>
        /// </summary>
        [NameInMap("BackupSpeedLimit")]
        [Validation(Required=false)]
        public long? BackupSpeedLimit { get; set; }

        /// <summary>
        /// <para>The start time for the full backup. The time is in the <em>HH:mm</em> format and is in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>14:22</para>
        /// </summary>
        [NameInMap("BackupStartTime")]
        [Validation(Required=false)]
        public string BackupStartTime { get; set; }

        /// <summary>
        /// <para>The built-in storage type:</para>
        /// <list type="bullet">
        /// <item><description><para>Empty (default): Backup data is stored in your OSS bucket.</para>
        /// </description></item>
        /// <item><description><para>system: Backup data is stored in the built-in OSS bucket of DBS.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("BackupStorageType")]
        [Validation(Required=false)]
        public string BackupStorageType { get; set; }

        /// <summary>
        /// <para>The full backup strategy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>simple</b>: periodic backup. Use this value with BackupPeriod and BackupStartTime.</para>
        /// </description></item>
        /// <item><description><para><b>manual</b>: manual backup.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The default value is <b>simple</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>simple</para>
        /// </summary>
        [NameInMap("BackupStrategyType")]
        [Validation(Required=false)]
        public string BackupStrategyType { get; set; }

        /// <summary>
        /// <para>A client token used to ensure the idempotence of the request. This prevents duplicate requests.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ASDASDASDSADASFCZXVZ</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The UID of the Alibaba Cloud account for cross-account backup.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1648821913******</para>
        /// </summary>
        [NameInMap("CrossAliyunId")]
        [Validation(Required=false)]
        public string CrossAliyunId { get; set; }

        /// <summary>
        /// <para>The name of the RAM role for cross-account backup.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test123</para>
        /// </summary>
        [NameInMap("CrossRoleName")]
        [Validation(Required=false)]
        public string CrossRoleName { get; set; }

        /// <summary>
        /// <para>The region where the database is located.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("DatabaseRegion")]
        [Validation(Required=false)]
        public string DatabaseRegion { get; set; }

        /// <summary>
        /// <para>The database type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>MySQL</b></para>
        /// </description></item>
        /// <item><description><para><b>MSSQL</b></para>
        /// </description></item>
        /// <item><description><para><b>Oracle</b></para>
        /// </description></item>
        /// <item><description><para><b>MariaDB</b></para>
        /// </description></item>
        /// <item><description><para><b>PostgreSQL</b></para>
        /// </description></item>
        /// <item><description><para><b>DRDS</b></para>
        /// </description></item>
        /// <item><description><para><b>MongoDB</b></para>
        /// </description></item>
        /// <item><description><para><b>Redis</b></para>
        /// </description></item>
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
        /// <para>The time after which backup data is converted to archive storage, in days. Default value: 365.</para>
        /// 
        /// <b>Example:</b>
        /// <para>365</para>
        /// </summary>
        [NameInMap("DuplicationArchivePeriod")]
        [Validation(Required=false)]
        public int? DuplicationArchivePeriod { get; set; }

        /// <summary>
        /// <para>The time after which backup data is converted to Infrequent Access (IA) storage, in days. Default value: 180.</para>
        /// 
        /// <b>Example:</b>
        /// <para>180</para>
        /// </summary>
        [NameInMap("DuplicationInfrequentAccessPeriod")]
        [Validation(Required=false)]
        public int? DuplicationInfrequentAccessPeriod { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable incremental log backup. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b></para>
        /// </description></item>
        /// <item><description><para><b>false</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableBackupLog")]
        [Validation(Required=false)]
        public bool? EnableBackupLog { get; set; }

        /// <summary>
        /// <para>The source of the request. The default value is OpenApi. You do not need to set this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OpenApi</para>
        /// </summary>
        [NameInMap("FromApp")]
        [Validation(Required=false)]
        public string FromApp { get; set; }

        /// <summary>
        /// <para>The specification of the backup plan. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>micro</b></para>
        /// </description></item>
        /// <item><description><para><b>small</b></para>
        /// </description></item>
        /// <item><description><para><b>medium</b></para>
        /// </description></item>
        /// <item><description><para><b>large</b></para>
        /// </description></item>
        /// <item><description><para><b>xlarge</b></para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>Higher specifications provide better backup and recovery performance. For more information, see <a href="https://help.aliyun.com/document_detail/84372.html">Specifications</a>.</para>
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
        /// <para>The database instance type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>RDS</b></para>
        /// </description></item>
        /// <item><description><para><b>PolarDB</b></para>
        /// </description></item>
        /// <item><description><para><b>DDS</b>: Alibaba Cloud MongoDB</para>
        /// </description></item>
        /// <item><description><para><b>Kvstore</b>: Alibaba Cloud Redis</para>
        /// </description></item>
        /// <item><description><para><b>Other</b>: A database connected over an IP address and port.</para>
        /// </description></item>
        /// <item><description><para><b>dg</b>: A self-managed database without a public IP address or port, connected through Database Gateway (DG).</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RDS</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// <para>The name of the Object Storage Service (OSS) bucket.
        /// Default: The system automatically generates a new name.</para>
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
        /// <para>The payment method. Valid value:</para>
        /// <para><b>prepay</b>: subscription</para>
        /// 
        /// <b>Example:</b>
        /// <para>prepay</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The billing cycle of the subscription instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Year</b></para>
        /// </description></item>
        /// <item><description><para><b>Month</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Year</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The region where DBS is available. To view the available regions, call the <a href="https://help.aliyun.com/document_detail/2869853.html">DescribeRegions</a> operation.</para>
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
        /// <para>The database name.</para>
        /// <remarks>
        /// <para>This parameter is required if the database type is <b>PostgreSQL</b> or <b>MongoDB</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testRDS</para>
        /// </summary>
        [NameInMap("SourceEndpointDatabaseName")]
        [Validation(Required=false)]
        public string SourceEndpointDatabaseName { get; set; }

        /// <summary>
        /// <para>The database endpoint.</para>
        /// <remarks>
        /// <para>This parameter is required if <b>SourceEndpoint</b>.<b>InstanceType</b> is set to <b>express</b>, <b>agent</b>, or <b>other</b>.</para>
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
        /// <para>This parameter is required if <b>SourceEndpoint</b>.<b>InstanceType</b> is set to <b>RDS</b>, <b>ECS</b>, <b>DDS</b>, or <b>Express</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5xxxxxxxxxx</para>
        /// </summary>
        [NameInMap("SourceEndpointInstanceID")]
        [Validation(Required=false)]
        public string SourceEndpointInstanceID { get; set; }

        /// <summary>
        /// <para>The location of the database. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>RDS</b></para>
        /// </description></item>
        /// <item><description><para><b>ECS</b></para>
        /// </description></item>
        /// <item><description><para><b>Express</b>: A database connected through a leased line, VPN Gateway, or Smart Access Gateway.</para>
        /// </description></item>
        /// <item><description><para><b>Agent</b>: A database connected through a backup gateway.</para>
        /// </description></item>
        /// <item><description><para><b>DDS</b>: Alibaba Cloud MongoDB</para>
        /// </description></item>
        /// <item><description><para><b>Other</b>: A database connected directly over an IP address and port.</para>
        /// </description></item>
        /// <item><description><para><b>dg</b>: A self-managed database without a public IP address or port, connected through Database Gateway (DG).</para>
        /// </description></item>
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
        /// <para>The Oracle system ID (SID). This parameter is required if the database type is Oracle.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("SourceEndpointOracleSID")]
        [Validation(Required=false)]
        public string SourceEndpointOracleSID { get; set; }

        /// <summary>
        /// <para>The password for the database account.</para>
        /// <remarks>
        /// <para>This parameter is optional if the database type is <b>Redis</b>, or if the database location is <b>agent</b> and the database type is <b>MSSQL</b>. In all other cases, this parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testPassword</para>
        /// </summary>
        [NameInMap("SourceEndpointPassword")]
        [Validation(Required=false)]
        public string SourceEndpointPassword { get; set; }

        /// <summary>
        /// <para>The database port.</para>
        /// <remarks>
        /// <para>This parameter is required if <b>SourceEndpoint</b>.<b>InstanceType</b> is set to <b>express</b>, <b>agent</b>, <b>other</b>, or <b>ECS</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3306</para>
        /// </summary>
        [NameInMap("SourceEndpointPort")]
        [Validation(Required=false)]
        public int? SourceEndpointPort { get; set; }

        /// <summary>
        /// <para>The region where the database is located.</para>
        /// <remarks>
        /// <para>This parameter is required if <b>SourceEndpoint</b>.<b>InstanceType</b> is set to <b>RDS</b>, <b>ECS</b>, <b>DDS</b>, <b>Express</b>, or <b>Agent</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("SourceEndpointRegion")]
        [Validation(Required=false)]
        public string SourceEndpointRegion { get; set; }

        /// <summary>
        /// <para>The database account.</para>
        /// <remarks>
        /// <para>This parameter is optional if the database type is <b>Redis</b>, or if the database location is <b>agent</b> and the database type is <b>MSSQL</b>. In all other cases, this parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testRDS</para>
        /// </summary>
        [NameInMap("SourceEndpointUserName")]
        [Validation(Required=false)]
        public string SourceEndpointUserName { get; set; }

        /// <summary>
        /// <para>The storage region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("StorageRegion")]
        [Validation(Required=false)]
        public string StorageRegion { get; set; }

        /// <summary>
        /// <para>This parameter is not yet available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("StorageType")]
        [Validation(Required=false)]
        public string StorageType { get; set; }

        /// <summary>
        /// <para>The subscription duration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>If <b>Period</b> is set to <b>Year</b>, the value of <b>UsedTime</b> can be 1 to 5.</para>
        /// </description></item>
        /// <item><description><para>If <b>Period</b> is set to <b>Month</b>, the value of <b>UsedTime</b> can be 1 to 11.</para>
        /// </description></item>
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
