// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20190306.Models
{
    public class ConfigureBackupPlanRequest : TeaModel {
        /// <summary>
        /// <para>Enable automatic backup. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Enable</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Disable</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoStartBackup")]
        [Validation(Required=false)]
        public bool? AutoStartBackup { get; set; }

        /// <summary>
        /// <para>The backup gateway ID. Call the <a href="https://help.aliyun.com/document_detail/2869825.html">DescribeBackupPlanList</a> API to get this parameter\&quot;s value.</para>
        /// <remarks>
        /// <para>This parameter is required when <b>SourceEndpointInstanceType</b> is <b>agent</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>23313123312</para>
        /// </summary>
        [NameInMap("BackupGatewayId")]
        [Validation(Required=false)]
        public long? BackupGatewayId { get; set; }

        /// <summary>
        /// <para>The incremental interval in seconds (s).</para>
        /// <remarks>
        /// <para>Only physical backup is supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("BackupLogIntervalSeconds")]
        [Validation(Required=false)]
        public int? BackupLogIntervalSeconds { get; set; }

        /// <summary>
        /// <para>The backup objects. Call the <a href="https://help.aliyun.com/document_detail/2869825.html">DescribeBackupPlanList</a> API to get this parameter\&quot;s value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[     {         &quot;DBName&quot;:&quot;待备份库名&quot;,         &quot;SchemaName&quot;:&quot;待备份 Schema 名&quot;,         &quot;TableIncludes&quot;:[{             &quot;TableName&quot;:&quot;待备份表表名&quot;         }],         &quot;TableExcludes&quot;:[{             &quot;TableName&quot;:&quot;待备份库名不需要备份表的表名&quot;         }]     } ]</para>
        /// </summary>
        [NameInMap("BackupObjects")]
        [Validation(Required=false)]
        public string BackupObjects { get; set; }

        /// <summary>
        /// <para>The full backup period. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Monday</b>: Monday</para>
        /// </description></item>
        /// <item><description><para><b>Tuesday</b>: Tuesday</para>
        /// </description></item>
        /// <item><description><para><b>Wednesday</b>: Wednesday</para>
        /// </description></item>
        /// <item><description><para><b>Thursday</b>: Thursday</para>
        /// </description></item>
        /// <item><description><para><b>Friday</b>: Friday</para>
        /// </description></item>
        /// <item><description><para><b>Saturday</b>: Saturday</para>
        /// </description></item>
        /// <item><description><para><b>Sunday</b>: Sunday</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Monday</para>
        /// </summary>
        [NameInMap("BackupPeriod")]
        [Validation(Required=false)]
        public string BackupPeriod { get; set; }

        /// <summary>
        /// <para>The backup plan ID. Call the <a href="https://help.aliyun.com/document_detail/2869825.html">DescribeBackupPlanList</a> API to get this parameter\&quot;s value.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dbstooi0*******</para>
        /// </summary>
        [NameInMap("BackupPlanId")]
        [Validation(Required=false)]
        public string BackupPlanId { get; set; }

        /// <summary>
        /// <para>The custom backup plan name. Call the <a href="https://help.aliyun.com/document_detail/2869825.html">DescribeBackupPlanList</a> API to get this parameter\&quot;s value.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dbstooi0*******</para>
        /// </summary>
        [NameInMap("BackupPlanName")]
        [Validation(Required=false)]
        public string BackupPlanName { get; set; }

        /// <summary>
        /// <para>The network bandwidth throttling in KB/s. The maximum value is 10 GB.</para>
        /// <remarks>
        /// <para>This parameter is valid only for MySQL physical backup.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>262144</para>
        /// </summary>
        [NameInMap("BackupRateLimit")]
        [Validation(Required=false)]
        public long? BackupRateLimit { get; set; }

        /// <summary>
        /// <para>The retention period for backup data. Valid values: 0 to 1825. Default value: 730 days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>730</para>
        /// </summary>
        [NameInMap("BackupRetentionPeriod")]
        [Validation(Required=false)]
        public int? BackupRetentionPeriod { get; set; }

        /// <summary>
        /// <para>The disk I/O limit in KB/s.</para>
        /// <remarks>
        /// <para>This parameter is valid only for MySQL physical backup.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>262144</para>
        /// </summary>
        [NameInMap("BackupSpeedLimit")]
        [Validation(Required=false)]
        public long? BackupSpeedLimit { get; set; }

        /// <summary>
        /// <para>The full backup start time in <em>HH:mm</em>Z (UTC) format. Call the <a href="https://help.aliyun.com/document_detail/2869825.html">DescribeBackupPlanList</a> API to get this parameter\&quot;s value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>14:22</para>
        /// </summary>
        [NameInMap("BackupStartTime")]
        [Validation(Required=false)]
        public string BackupStartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>encrypted</para>
        /// </summary>
        [NameInMap("BackupStorageEncryptMethod")]
        [Validation(Required=false)]
        public string BackupStorageEncryptMethod { get; set; }

        /// <summary>
        /// <para>The built-in storage type:</para>
        /// <list type="bullet">
        /// <item><description><para>Empty (default): Backup data is stored on your OSS.</para>
        /// </description></item>
        /// <item><description><para>system: Backup data is stored on the built-in OSS of DBS.</para>
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
        /// <para>The full backup period. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>simple</b>: Periodic backup. Use this value with BackupPeriod and BackupStartTime.</para>
        /// </description></item>
        /// <item><description><para><b>manual</b>: Manual backup.</para>
        /// </description></item>
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
        /// <para>Ensure the idempotence of the request to prevent duplicate submissions. The client generates this parameter value. Ensure its uniqueness across different requests. The maximum length is 64 ASCII characters, and the value cannot contain non-ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCzxxxxxxx</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The UID for cross-Alibaba Cloud account backup. Call the <a href="https://help.aliyun.com/document_detail/2869838.html">DescribeRestoreTaskList</a> API to get this parameter\&quot;s value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2xxx7778xxxxxxxxxx</para>
        /// </summary>
        [NameInMap("CrossAliyunId")]
        [Validation(Required=false)]
        public string CrossAliyunId { get; set; }

        /// <summary>
        /// <para>The RAM role name for cross-Alibaba Cloud account backup. Call the <a href="https://help.aliyun.com/document_detail/2869838.html">DescribeRestoreTaskList</a> API to get this parameter\&quot;s value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test123</para>
        /// </summary>
        [NameInMap("CrossRoleName")]
        [Validation(Required=false)]
        public string CrossRoleName { get; set; }

        /// <summary>
        /// <para>The period after which data is converted to archive cold storage. Default value: 365 days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>365</para>
        /// </summary>
        [NameInMap("DuplicationArchivePeriod")]
        [Validation(Required=false)]
        public int? DuplicationArchivePeriod { get; set; }

        /// <summary>
        /// <para>The period after which data is converted to Infrequent Access storage. Default value: 180 days.</para>
        /// 
        /// <b>Example:</b>
        /// <para>180</para>
        /// </summary>
        [NameInMap("DuplicationInfrequentAccessPeriod")]
        [Validation(Required=false)]
        public int? DuplicationInfrequentAccessPeriod { get; set; }

        /// <summary>
        /// <para>Enable incremental log backup. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Enable</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Disable</para>
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
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableMysqlPhysicalBackupBinlog")]
        [Validation(Required=false)]
        public string EnableMysqlPhysicalBackupBinlog { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableSourceEndpointSsl")]
        [Validation(Required=false)]
        public string EnableSourceEndpointSsl { get; set; }

        /// <summary>
        /// <para>The OSS bucket name.</para>
        /// <remarks>
        /// <para>The system automatically generates a new name by default.</para>
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
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekzecovzti****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The database name. Call the <a href="https://help.aliyun.com/document_detail/2869825.html">DescribeBackupPlanList</a> API to get this parameter\&quot;s value.</para>
        /// <remarks>
        /// <para>This parameter is required when the database type is <b>PostgreSQL</b> or <b>MongoDB</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testRDS</para>
        /// </summary>
        [NameInMap("SourceEndpointDatabaseName")]
        [Validation(Required=false)]
        public string SourceEndpointDatabaseName { get; set; }

        /// <summary>
        /// <para>The database endpoint. Call the <a href="https://help.aliyun.com/document_detail/2869825.html">DescribeBackupPlanList</a> API to get this parameter\&quot;s value.</para>
        /// <remarks>
        /// <para>This parameter is required when <b>SourceEndpointInstanceType</b> is <b>express</b>, <b>agent</b>, or <b>other</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5*******.mysql.rds.aliyuncs.com</para>
        /// </summary>
        [NameInMap("SourceEndpointIP")]
        [Validation(Required=false)]
        public string SourceEndpointIP { get; set; }

        /// <summary>
        /// <para>The database instance ID. Call the <a href="https://help.aliyun.com/document_detail/2869825.html">DescribeBackupPlanList</a> API to get this parameter\&quot;s value.</para>
        /// <remarks>
        /// <para>This parameter is required when <b>SourceEndpoint</b>.<b>InstanceType</b> is <b>RDS</b>, <b>ECS</b>, <b>DDS</b>, or <b>Express</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5*********</para>
        /// </summary>
        [NameInMap("SourceEndpointInstanceID")]
        [Validation(Required=false)]
        public string SourceEndpointInstanceID { get; set; }

        /// <summary>
        /// <para>The location of the database. Call the <a href="https://help.aliyun.com/document_detail/2869825.html">DescribeBackupPlanList</a> API to get this parameter\&quot;s value. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>RDS</b></para>
        /// </description></item>
        /// <item><description><para><b>ECS</b></para>
        /// </description></item>
        /// <item><description><para><b>Express</b>: A database connected through a leased line, VPN Gateway, or Smart Gateway.</para>
        /// </description></item>
        /// <item><description><para><b>Agent</b>: A database connected through a backup gateway.</para>
        /// </description></item>
        /// <item><description><para><b>DDS</b>: Cloud MongoDB.</para>
        /// </description></item>
        /// <item><description><para><b>Other</b>: A database directly connected through IP:Port.</para>
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
        /// <b>Example:</b>
        /// <para>/home/test</para>
        /// </summary>
        [NameInMap("SourceEndpointOracleHome")]
        [Validation(Required=false)]
        public string SourceEndpointOracleHome { get; set; }

        /// <summary>
        /// <para>The Oracle SID name.</para>
        /// <remarks>
        /// <para>This parameter is required when the database type is Oracle.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("SourceEndpointOracleSID")]
        [Validation(Required=false)]
        public string SourceEndpointOracleSID { get; set; }

        /// <summary>
        /// <para>The password.</para>
        /// <remarks>
        /// <para>This parameter is optional when the database type is <b>Redis</b>, or when the database location is <b>agent</b> and the database type is <b>SQL Server</b>. It is required in other scenarios.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testPassword</para>
        /// </summary>
        [NameInMap("SourceEndpointPassword")]
        [Validation(Required=false)]
        public string SourceEndpointPassword { get; set; }

        /// <summary>
        /// <para>The database port. Call the <a href="https://help.aliyun.com/document_detail/2869825.html">DescribeBackupPlanList</a> API to get this parameter\&quot;s value.</para>
        /// <remarks>
        /// <para>This parameter is required when <b>SourceEndpoint</b>.<b>InstanceType</b> is <b>express</b>, <b>agent</b>, <b>other</b>, or <b>ECS</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3306</para>
        /// </summary>
        [NameInMap("SourceEndpointPort")]
        [Validation(Required=false)]
        public int? SourceEndpointPort { get; set; }

        /// <summary>
        /// <para>The region of the database. Call the <a href="https://help.aliyun.com/document_detail/2869825.html">DescribeBackupPlanList</a> API to get this parameter\&quot;s value.</para>
        /// <remarks>
        /// <para>This parameter is required when <b>SourceEndpointInstanceType</b> is RDS, ECS, DDS, Express, or Agent.</para>
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
        /// <para>This parameter is optional when the database type is <b>Redis</b>, or when the database location is <b>agent</b> and the database type is <b>SQL Server</b>. It is required in other scenarios.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testRDS</para>
        /// </summary>
        [NameInMap("SourceEndpointUserName")]
        [Validation(Required=false)]
        public string SourceEndpointUserName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE----- ... -----END CERTIFICATE-----</para>
        /// </summary>
        [NameInMap("SslCaPem")]
        [Validation(Required=false)]
        public string SslCaPem { get; set; }

    }

}
