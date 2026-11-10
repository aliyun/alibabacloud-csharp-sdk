// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20190306.Models
{
    public class ConfigureBackupPlanRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable automatic backup. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables automatic backup</description></item>
        /// <item><description><b>false</b>: disables automatic backup</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoStartBackup")]
        [Validation(Required=false)]
        public bool? AutoStartBackup { get; set; }

        /// <summary>
        /// <para>The ID of the backup gateway. You can call the <a href="https://help.aliyun.com/document_detail/2869825.html">DescribeBackupPlanList</a> operation to query the value of this parameter.</para>
        /// <remarks>
        /// <para>This parameter is required when <b>SourceEndpointInstanceType</b> is set to <b>agent</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>23313123312</para>
        /// </summary>
        [NameInMap("BackupGatewayId")]
        [Validation(Required=false)]
        public long? BackupGatewayId { get; set; }

        /// <summary>
        /// <para>The interval for incremental backup, in seconds.</para>
        /// <remarks>
        /// <para>This parameter is supported only for physical backup.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("BackupLogIntervalSeconds")]
        [Validation(Required=false)]
        public int? BackupLogIntervalSeconds { get; set; }

        /// <summary>
        /// <para>The objects to be backed up. You can call the <a href="https://help.aliyun.com/document_detail/2869825.html">DescribeBackupPlanList</a> operation to query the value of this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[     {         &quot;DBName&quot;:&quot;DatabaseToBackUp&quot;,         &quot;SchemaName&quot;:&quot;SchemaToBackUp&quot;,         &quot;TableIncludes&quot;:[{             &quot;TableName&quot;:&quot;TableToBackUp&quot;         }],         &quot;TableExcludes&quot;:[{             &quot;TableName&quot;:&quot;TableToExclude&quot;         }]     } ]</para>
        /// </summary>
        [NameInMap("BackupObjects")]
        [Validation(Required=false)]
        public string BackupObjects { get; set; }

        /// <summary>
        /// <para>The full backup cycle. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Monday</b>: Monday</description></item>
        /// <item><description><b>Tuesday</b>: Tuesday</description></item>
        /// <item><description><b>Wednesday</b>: Wednesday</description></item>
        /// <item><description><b>Thursday</b>: Thursday</description></item>
        /// <item><description><b>Friday</b>: Friday</description></item>
        /// <item><description><b>Saturday</b>: Saturday</description></item>
        /// <item><description><b>Sunday</b>: Sunday</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Monday</para>
        /// </summary>
        [NameInMap("BackupPeriod")]
        [Validation(Required=false)]
        public string BackupPeriod { get; set; }

        /// <summary>
        /// <para>The ID of the backup plan. You can call the <a href="https://help.aliyun.com/document_detail/2869825.html">DescribeBackupPlanList</a> operation to query the value of this parameter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dbstooi0*******</para>
        /// </summary>
        [NameInMap("BackupPlanId")]
        [Validation(Required=false)]
        public string BackupPlanId { get; set; }

        /// <summary>
        /// <para>The custom name of the backup plan. You can call the <a href="https://help.aliyun.com/document_detail/2869825.html">DescribeBackupPlanList</a> operation to query the value of this parameter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dbstooi0*******</para>
        /// </summary>
        [NameInMap("BackupPlanName")]
        [Validation(Required=false)]
        public string BackupPlanName { get; set; }

        /// <summary>
        /// <para>The network bandwidth throttling. Unit: KB/s. Maximum value: 10 GB.</para>
        /// <remarks>
        /// <para>This parameter takes effect only for MySQL physical backup.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>262144</para>
        /// </summary>
        [NameInMap("BackupRateLimit")]
        [Validation(Required=false)]
        public long? BackupRateLimit { get; set; }

        /// <summary>
        /// <para>The retention period of backup data. Valid values: 0 to 1825. Default value: 730. Unit: days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>730</para>
        /// </summary>
        [NameInMap("BackupRetentionPeriod")]
        [Validation(Required=false)]
        public int? BackupRetentionPeriod { get; set; }

        /// <summary>
        /// <para>The disk I/O limit. Unit: KB/s.</para>
        /// <remarks>
        /// <para>This parameter takes effect only for MySQL physical backup.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>262144</para>
        /// </summary>
        [NameInMap("BackupSpeedLimit")]
        [Validation(Required=false)]
        public long? BackupSpeedLimit { get; set; }

        /// <summary>
        /// <para>The start time of the full backup. The time is in the <i>HH:mm</i>Z format and displayed in UTC. You can call the <a href="https://help.aliyun.com/document_detail/2869825.html">DescribeBackupPlanList</a> operation to query the value of this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>14:22</para>
        /// </summary>
        [NameInMap("BackupStartTime")]
        [Validation(Required=false)]
        public string BackupStartTime { get; set; }

        /// <summary>
        /// <para>The encryption method for backup storage.</para>
        /// 
        /// <b>Example:</b>
        /// <para>encrypted</para>
        /// </summary>
        [NameInMap("BackupStorageEncryptMethod")]
        [Validation(Required=false)]
        public string BackupStorageEncryptMethod { get; set; }

        /// <summary>
        /// <para>The built-in storage type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Empty string (default): Backup data is stored in your OSS bucket.</description></item>
        /// <item><description>system: Backup data is stored in the built-in OSS bucket of DBS.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("BackupStorageType")]
        [Validation(Required=false)]
        public string BackupStorageType { get; set; }

        /// <summary>
        /// <para>The full backup epoch. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>simple</b>: periodic backup, which is used together with BackupPeriod and BackupStartTime</description></item>
        /// <item><description><b>manual</b>: manual backup</description></item>
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
        /// <para>The client token that is used to ensure the idempotence of the request and prevent duplicate submissions. You can use the client to generate the value, and you must ensure that the value is unique among different requests. The value can be up to 64 ASCII characters in length and cannot contain non-ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCzxxxxxxx</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The UID of the Alibaba Cloud account for cross-account backup. You can call the <a href="https://help.aliyun.com/document_detail/2869838.html">DescribeRestoreTaskList</a> operation to query the value of this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2xxx7778xxxxxxxxxx</para>
        /// </summary>
        [NameInMap("CrossAliyunId")]
        [Validation(Required=false)]
        public string CrossAliyunId { get; set; }

        /// <summary>
        /// <para>The name of the RAM role for cross-account backup. You can call the <a href="https://help.aliyun.com/document_detail/2869838.html">DescribeRestoreTaskList</a> operation to query the value of this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test123</para>
        /// </summary>
        [NameInMap("CrossRoleName")]
        [Validation(Required=false)]
        public string CrossRoleName { get; set; }

        /// <summary>
        /// <para>The period after which backup data is transitioned to Archive storage. Default value: 365. Unit: days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>365</para>
        /// </summary>
        [NameInMap("DuplicationArchivePeriod")]
        [Validation(Required=false)]
        public int? DuplicationArchivePeriod { get; set; }

        /// <summary>
        /// <para>The period after which backup data is transitioned to Infrequent Access (IA) storage. Default value: 180. Unit: days.</para>
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
        /// <item><description><b>true</b>: enables incremental log backup</description></item>
        /// <item><description><b>false</b>: disables incremental log backup</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableBackupLog")]
        [Validation(Required=false)]
        public bool? EnableBackupLog { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable log backup for MySQL physical backup.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableMysqlPhysicalBackupBinlog")]
        [Validation(Required=false)]
        public string EnableMysqlPhysicalBackupBinlog { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable an SSL-encrypted connection to the source database instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableSourceEndpointSsl")]
        [Validation(Required=false)]
        public string EnableSourceEndpointSsl { get; set; }

        /// <summary>
        /// <para>The name of the OSS bucket.</para>
        /// <remarks>
        /// <para>By default, the system automatically generates a new name.</para>
        /// </remarks>
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
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekzecovzti****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The name of the database. You can call the <a href="https://help.aliyun.com/document_detail/2869825.html">DescribeBackupPlanList</a> operation to query the value of this parameter.</para>
        /// <remarks>
        /// <para>This parameter is required when the database engine is <b>PostgreSQL</b> or <b>MongoDB</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testRDS</para>
        /// </summary>
        [NameInMap("SourceEndpointDatabaseName")]
        [Validation(Required=false)]
        public string SourceEndpointDatabaseName { get; set; }

        /// <summary>
        /// <para>The database connection address. You can call the <a href="https://help.aliyun.com/document_detail/2869825.html">DescribeBackupPlanList</a> operation to query the value of this parameter.</para>
        /// <remarks>
        /// <para>This parameter is required when <b>SourceEndpointInstanceType</b> is set to <b>express</b>, <b>agent</b>, or <b>other</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5*******.mysql.rds.aliyuncs.com</para>
        /// </summary>
        [NameInMap("SourceEndpointIP")]
        [Validation(Required=false)]
        public string SourceEndpointIP { get; set; }

        /// <summary>
        /// <para>The database instance ID. You can call the <a href="https://help.aliyun.com/document_detail/2869825.html">DescribeBackupPlanList</a> operation to query the value of this parameter.</para>
        /// <remarks>
        /// <para>This parameter is required when <b>SourceEndpoint</b>.<b>InstanceType</b> is set to <b>RDS</b>, <b>ECS</b>, <b>DDS</b>, or <b>Express</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5*********</para>
        /// </summary>
        [NameInMap("SourceEndpointInstanceID")]
        [Validation(Required=false)]
        public string SourceEndpointInstanceID { get; set; }

        /// <summary>
        /// <para>The location of the database. You can call the <a href="https://help.aliyun.com/document_detail/2869825.html">DescribeBackupPlanList</a> operation to query the value of this parameter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>RDS</b></description></item>
        /// <item><description><b>ECS</b></description></item>
        /// <item><description><b>Express</b>: databases connected over Express Connect circuits, VPN gateways, or Smart Access Gateway (SAG)</description></item>
        /// <item><description><b>Agent</b>: databases connected over backup gateways</description></item>
        /// <item><description><b>DDS</b>: ApsaraDB for MongoDB</description></item>
        /// <item><description><b>Other</b>: databases connected by using IP addresses and port numbers</description></item>
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
        /// <para>Oracle Home</para>
        /// 
        /// <b>Example:</b>
        /// <para>/home/test</para>
        /// </summary>
        [NameInMap("SourceEndpointOracleHome")]
        [Validation(Required=false)]
        public string SourceEndpointOracleHome { get; set; }

        /// <summary>
        /// <para>The Oracle system identifier (SID).</para>
        /// <remarks>
        /// <para>This parameter is required when the database engine is Oracle.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("SourceEndpointOracleSID")]
        [Validation(Required=false)]
        public string SourceEndpointOracleSID { get; set; }

        /// <summary>
        /// <para>The password of the database account.</para>
        /// <remarks>
        /// <para>This parameter is not required when the database engine is <b>Redis</b>, or when the database is connected over a backup gateway (<b>agent</b>) and the database engine is <b>SQL Server</b>. This parameter is required in other scenarios.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testPassword</para>
        /// </summary>
        [NameInMap("SourceEndpointPassword")]
        [Validation(Required=false)]
        public string SourceEndpointPassword { get; set; }

        /// <summary>
        /// <para>The port number of the database. You can call the <a href="https://help.aliyun.com/document_detail/2869825.html">DescribeBackupPlanList</a> operation to query the value of this parameter.</para>
        /// <remarks>
        /// <para>This parameter is required when <b>SourceEndpoint</b>.<b>InstanceType</b> is set to <b>express</b>, <b>agent</b>, <b>other</b>, or <b>ECS</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3306</para>
        /// </summary>
        [NameInMap("SourceEndpointPort")]
        [Validation(Required=false)]
        public int? SourceEndpointPort { get; set; }

        /// <summary>
        /// <para>The region of the database. You can call the <a href="https://help.aliyun.com/document_detail/2869825.html">DescribeBackupPlanList</a> operation to query the value of this parameter.</para>
        /// <remarks>
        /// <para>This parameter is required when <b>SourceEndpointInstanceType</b> is set to RDS, ECS, DDS, Express, or Agent.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("SourceEndpointRegion")]
        [Validation(Required=false)]
        public string SourceEndpointRegion { get; set; }

        /// <summary>
        /// <para>The username of the database account.</para>
        /// <remarks>
        /// <para>This parameter is not required when the database engine is <b>Redis</b>, or when the database is connected over a backup gateway (<b>agent</b>) and the database engine is <b>SQL Server</b>. This parameter is required in other scenarios.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testRDS</para>
        /// </summary>
        [NameInMap("SourceEndpointUserName")]
        [Validation(Required=false)]
        public string SourceEndpointUserName { get; set; }

        /// <summary>
        /// <para>The PEM certificate for the SSL-encrypted connection to the source database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE----- ... -----END CERTIFICATE-----</para>
        /// </summary>
        [NameInMap("SslCaPem")]
        [Validation(Required=false)]
        public string SslCaPem { get; set; }

    }

}
