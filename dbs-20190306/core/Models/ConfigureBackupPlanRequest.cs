// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20190306.Models
{
    public class ConfigureBackupPlanRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the automatic backup feature.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables the automatic backup feature.</description></item>
        /// <item><description><b>false</b>: disables the automatic backup feature.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoStartBackup")]
        [Validation(Required=false)]
        public bool? AutoStartBackup { get; set; }

        /// <summary>
        /// <para>The backup gateway ID. You can call the <a href="https://help.aliyun.com/document_detail/2869825.html">DescribeBackupPlanList</a> operation to obtain it.</para>
        /// <remarks>
        /// <para> If you set <b>SourceEndpointInstanceType</b> to <b>Agent</b>, this parameter is required.</para>
        /// </remarks>
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
        /// <para> Only physical backup supports this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("BackupLogIntervalSeconds")]
        [Validation(Required=false)]
        public int? BackupLogIntervalSeconds { get; set; }

        /// <summary>
        /// <para>The objects to be backed up. You can call the <a href="https://help.aliyun.com/document_detail/2869825.html">DescribeBackupPlanList</a> operation to obtain the objects.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[ { &quot;DBName&quot;:&quot;Name of the database to be backed up&quot;, &quot;SchemaName&quot;:&quot;Name of the schema to be backed up&quot;, &quot;TableIncludes&quot;:[{ &quot;TableName&quot;:&quot;Name of the table to be backed up&quot; }], &quot;TableExcludes&quot;:[{ &quot;TableName&quot;:&quot;Name of the table to be excluded during the backup&quot; }] } ]</para>
        /// </summary>
        [NameInMap("BackupObjects")]
        [Validation(Required=false)]
        public string BackupObjects { get; set; }

        /// <summary>
        /// <para>The day of each week when the full backup task runs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Monday</b></description></item>
        /// <item><description><b>Tuesday</b></description></item>
        /// <item><description><b>Wednesday</b></description></item>
        /// <item><description><b>Thursday</b></description></item>
        /// <item><description><b>Friday</b></description></item>
        /// <item><description><b>Saturday</b></description></item>
        /// <item><description><b>Sunday</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Monday</para>
        /// </summary>
        [NameInMap("BackupPeriod")]
        [Validation(Required=false)]
        public string BackupPeriod { get; set; }

        /// <summary>
        /// <para>The ID of the backup schedule. You can call the <a href="https://help.aliyun.com/document_detail/2869825.html">DescribeBackupPlanList</a> operation to obtain it.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dbstooi0*******</para>
        /// </summary>
        [NameInMap("BackupPlanId")]
        [Validation(Required=false)]
        public string BackupPlanId { get; set; }

        /// <summary>
        /// <para>The name of the backup schedule. You can call the <a href="https://help.aliyun.com/document_detail/2869825.html">DescribeBackupPlanList</a> operation to obtain the name.</para>
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
        /// <para>This parameter takes effect only when physical backups for MySQL databases are performed.</para>
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
        /// <para>The disk I/O limit. Unit: KB/s.</para>
        /// <remarks>
        /// <para> This parameter takes effect only during the physical backup of a MySQL database.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>262144</para>
        /// </summary>
        [NameInMap("BackupSpeedLimit")]
        [Validation(Required=false)]
        public long? BackupSpeedLimit { get; set; }

        /// <summary>
        /// <para>The start time of the full backup. Specify the time in the <em>HH:mm</em>Z format. The time must be in UTC. You can call the <a href="https://help.aliyun.com/document_detail/2869825.html">DescribeBackupPlanList</a> operation to obtain the start time of full backup tasks.</para>
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
        /// <item><description>system: The system stores backup data in the built-in OSS bucket of DBS.</description></item>
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
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCzxxxxxxx</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The unique ID (UID) of the Alibaba Cloud account to which the backup schedule belongs. You can call the <a href="https://help.aliyun.com/document_detail/2869838.html">DescribeRestoreTaskList</a> operation to obtain the UID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2xxx7778xxxxxxxxxx</para>
        /// </summary>
        [NameInMap("CrossAliyunId")]
        [Validation(Required=false)]
        public string CrossAliyunId { get; set; }

        /// <summary>
        /// <para>The name of the RAM role that is used to perform backup across Alibaba Cloud accounts. You can call the <a href="https://help.aliyun.com/document_detail/2869838.html">DescribeRestoreTaskList</a> operation to obtain the RAM role.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test123</para>
        /// </summary>
        [NameInMap("CrossRoleName")]
        [Validation(Required=false)]
        public string CrossRoleName { get; set; }

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
        /// <para>The name of the OSS bucket.</para>
        /// <remarks>
        /// <para> By default, the system automatically generates an OSS bucket name.</para>
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
        /// <para>The source database name. You can call the <a href="https://help.aliyun.com/document_detail/2869825.html">DescribeBackupPlanList</a> operation to obtain it.</para>
        /// <remarks>
        /// <para> If the source database runs the <b>PostgreSQL</b> database engine or <b>MongoDB</b> database engine, this parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testRDS</para>
        /// </summary>
        [NameInMap("SourceEndpointDatabaseName")]
        [Validation(Required=false)]
        public string SourceEndpointDatabaseName { get; set; }

        /// <summary>
        /// <para>The source database endpoint. You can call the <a href="https://help.aliyun.com/document_detail/2869825.html">DescribeBackupPlanList</a> operation to obtain it.</para>
        /// <remarks>
        /// <para> If you set <b>SourceEndpointInstanceType</b> to <b>Express</b>, <b>Agent</b>, or <b>Other</b>, this parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5*******.mysql.rds.aliyuncs.com</para>
        /// </summary>
        [NameInMap("SourceEndpointIP")]
        [Validation(Required=false)]
        public string SourceEndpointIP { get; set; }

        /// <summary>
        /// <para>The database instance ID. You can call the <a href="https://help.aliyun.com/document_detail/2869825.html">DescribeBackupPlanList</a> operation to obtain the ID.</para>
        /// <remarks>
        /// <para> If you set <b>SourceEndpoint****InstanceType</b> to <b>RDS</b>, <b>ECS</b>, <b>DDS</b>, or <b>Express</b>, this parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5*********</para>
        /// </summary>
        [NameInMap("SourceEndpointInstanceID")]
        [Validation(Required=false)]
        public string SourceEndpointInstanceID { get; set; }

        /// <summary>
        /// <para>The location of the database. You can call the <a href="https://help.aliyun.com/document_detail/2869825.html">DescribeBackupPlanList</a> operation to obtain the location. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>RDS</b></description></item>
        /// <item><description><b>ECS</b></description></item>
        /// <item><description><b>Express</b>: The database is connected to Database Backup (DBS) via Express Connect, VPN Gateway, or Smart Access Gateway.</description></item>
        /// <item><description><b>Agent</b>: The database is connected over a DBS backup gateway.</description></item>
        /// <item><description><b>DDS</b>: The database is an ApsaraDB for MongoDB database.</description></item>
        /// <item><description><b>Other</b>: The database is connected to DBS by using the IP address and port of the database.</description></item>
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
        /// <para>The system ID (SID) of the Oracle database.</para>
        /// <remarks>
        /// <para>This parameter is required if the database is an Oracle database.</para>
        /// </remarks>
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
        /// <para>This parameter is required except that the database is an <b>SQL Server</b> database that is connected to DBS over a DBS backup gateway or a <b>Redis</b> database.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testPassword</para>
        /// </summary>
        [NameInMap("SourceEndpointPassword")]
        [Validation(Required=false)]
        public string SourceEndpointPassword { get; set; }

        /// <summary>
        /// <para>The port that is used to connect to the source database. You can call the <a href="https://help.aliyun.com/document_detail/2869825.html">DescribeBackupPlanList</a> operation to obtain the port.</para>
        /// <remarks>
        /// <para> If you set <b>SourceEndpoint****InstanceType</b> to <b>Express</b>, <b>Agent</b>, <b>Other</b>, or <b>ECS</b>, this parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3306</para>
        /// </summary>
        [NameInMap("SourceEndpointPort")]
        [Validation(Required=false)]
        public int? SourceEndpointPort { get; set; }

        /// <summary>
        /// <para>The region in which the source database resides. You can call the <a href="https://help.aliyun.com/document_detail/2869825.html">DescribeBackupPlanList</a> operation to obtain the region.</para>
        /// <remarks>
        /// <para> If you set <b>SourceEndpointInstanceType</b> to RDS, ECS, DDS, Express, or Agent, this parameter is required.</para>
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
        /// <para>This parameter is required except that the database is an <b>SQL Server</b> database that is connected to DBS over a DBS backup gateway or a <b>Redis</b> database.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testRDS</para>
        /// </summary>
        [NameInMap("SourceEndpointUserName")]
        [Validation(Required=false)]
        public string SourceEndpointUserName { get; set; }

    }

}
