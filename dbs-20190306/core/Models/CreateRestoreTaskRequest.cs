// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20190306.Models
{
    public class CreateRestoreTaskRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically start the instance after an Oracle physical backup is restored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoOpenDatabase")]
        [Validation(Required=false)]
        public string AutoOpenDatabase { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically shut down the instance after an Oracle physical backup is restored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoShutdownDatabase")]
        [Validation(Required=false)]
        public string AutoShutdownDatabase { get; set; }

        /// <summary>
        /// <para>The ID of the backup gateway.</para>
        /// <remarks>
        /// <para>This parameter is required if <b>DestinationEndpointInstanceType</b> is set to Agent.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>4312****</para>
        /// </summary>
        [NameInMap("BackupGatewayId")]
        [Validation(Required=false)]
        public long? BackupGatewayId { get; set; }

        /// <summary>
        /// <para>The ID of the backup plan.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dbs1hvb0ww****</para>
        /// </summary>
        [NameInMap("BackupPlanId")]
        [Validation(Required=false)]
        public string BackupPlanId { get; set; }

        /// <summary>
        /// <para>The ID of the full backup set used for restoration. This parameter and RestoreTime are mutually exclusive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dbs1hvb0w*****</para>
        /// </summary>
        [NameInMap("BackupSetId")]
        [Validation(Required=false)]
        public string BackupSetId { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request and prevent duplicate submissions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOC********</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The UID of the Alibaba Cloud account used for cross-account backup.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2749528728********</para>
        /// </summary>
        [NameInMap("CrossAliyunId")]
        [Validation(Required=false)]
        public string CrossAliyunId { get; set; }

        /// <summary>
        /// <para>The name of the RAM role used for cross-account backup.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test123</para>
        /// </summary>
        [NameInMap("CrossRoleName")]
        [Validation(Required=false)]
        public string CrossRoleName { get; set; }

        /// <summary>
        /// <para>The instance specifications of the new database instance to which data is restored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mysql.x4.large.2</para>
        /// </summary>
        [NameInMap("DestDatabaseInstanceClass")]
        [Validation(Required=false)]
        public string DestDatabaseInstanceClass { get; set; }

        /// <summary>
        /// <para>The database engine version of the new database instance to which data is restored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8.0</para>
        /// </summary>
        [NameInMap("DestDatabaseInstanceDatabaseVersion")]
        [Validation(Required=false)]
        public string DestDatabaseInstanceDatabaseVersion { get; set; }

        /// <summary>
        /// <para>The region of the new database instance to which data is restored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("DestDatabaseInstanceRegion")]
        [Validation(Required=false)]
        public string DestDatabaseInstanceRegion { get; set; }

        /// <summary>
        /// <para>The instance storage size of the new database to recover.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("DestDatabaseInstanceStorageSize")]
        [Validation(Required=false)]
        public string DestDatabaseInstanceStorageSize { get; set; }

        /// <summary>
        /// <para>The instance type of the new database to which data is restored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds</para>
        /// </summary>
        [NameInMap("DestDatabaseInstanceType")]
        [Validation(Required=false)]
        public string DestDatabaseInstanceType { get; set; }

        /// <summary>
        /// <para>The vSwitch of the new database instance to which data is restored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-xx</para>
        /// </summary>
        [NameInMap("DestDatabaseInstanceVSwitch")]
        [Validation(Required=false)]
        public string DestDatabaseInstanceVSwitch { get; set; }

        /// <summary>
        /// <para>The VPC of the new database instance to which data is restored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-xx</para>
        /// </summary>
        [NameInMap("DestDatabaseInstanceVpc")]
        [Validation(Required=false)]
        public string DestDatabaseInstanceVpc { get; set; }

        /// <summary>
        /// <para>The name of the database.</para>
        /// <remarks>
        /// <para>This parameter is required if the database engine is PostgreSQL or MongoDB.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("DestinationEndpointDatabaseName")]
        [Validation(Required=false)]
        public string DestinationEndpointDatabaseName { get; set; }

        /// <summary>
        /// <para>The database connection address.</para>
        /// <remarks>
        /// <para>This parameter is required if <b>DestinationEndpointInstanceType</b> is set to Express, Agent, or Other.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp*****9jv8pxero.mysql.rds.aliyuncs.com</para>
        /// </summary>
        [NameInMap("DestinationEndpointIP")]
        [Validation(Required=false)]
        public string DestinationEndpointIP { get; set; }

        /// <summary>
        /// <para>The instance ID of the database.</para>
        /// <remarks>
        /// <para>This parameter is required if <b>DestinationEndpointInstanceType</b> is set to RDS, ECS, DDS, or Express.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp1p8c29*****</para>
        /// </summary>
        [NameInMap("DestinationEndpointInstanceID")]
        [Validation(Required=false)]
        public string DestinationEndpointInstanceID { get; set; }

        /// <summary>
        /// <para>The location of the database. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>RDS</b></description></item>
        /// <item><description><b>ECS</b></description></item>
        /// <item><description><b>Express</b>: databases connected over Express Connect circuits, VPN gateways, or Smart Access Gateway (SAG)</description></item>
        /// <item><description><b>Agent</b>: databases connected over backup gateways</description></item>
        /// <item><description><b>DDS</b>: ApsaraDB for MongoDB</description></item>
        /// <item><description><b>Other</b>: databases connected by using IP addresses and port numbers</description></item>
        /// <item><description><b>dg</b>: self-managed databases that have no public IP addresses or port numbers and are connected over Database Gateway</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RDS</para>
        /// </summary>
        [NameInMap("DestinationEndpointInstanceType")]
        [Validation(Required=false)]
        public string DestinationEndpointInstanceType { get; set; }

        /// <summary>
        /// <para>The Oracle SID.</para>
        /// <remarks>
        /// <para>This parameter is required if the database engine is Oracle.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("DestinationEndpointOracleSID")]
        [Validation(Required=false)]
        public string DestinationEndpointOracleSID { get; set; }

        /// <summary>
        /// <para>The password of the database account.</para>
        /// <remarks>
        /// <para>This parameter is not required if the database engine is Redis, or if the database is connected over a backup gateway and the database engine is SQL Server. In other scenarios, this parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Test</para>
        /// </summary>
        [NameInMap("DestinationEndpointPassword")]
        [Validation(Required=false)]
        public string DestinationEndpointPassword { get; set; }

        /// <summary>
        /// <para>The port number of the database.</para>
        /// <remarks>
        /// <para>This parameter is required if <b>DestinationEndpointInstanceType</b> is set to Express, Agent, Other, or ECS.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3306</para>
        /// </summary>
        [NameInMap("DestinationEndpointPort")]
        [Validation(Required=false)]
        public int? DestinationEndpointPort { get; set; }

        /// <summary>
        /// <para>The region of the database instance.</para>
        /// <remarks>
        /// <para>This parameter is required if <b>DestinationEndpointInstanceType</b> is set to RDS, ECS, DDS, Express, or Agent.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("DestinationEndpointRegion")]
        [Validation(Required=false)]
        public string DestinationEndpointRegion { get; set; }

        /// <summary>
        /// <para>The username of the database account.</para>
        /// <remarks>
        /// <para>This parameter is not required if the database engine is Redis, or if the database is connected over a backup gateway and the database engine is SQL Server. In other scenarios, this parameter is required.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("DestinationEndpointUserName")]
        [Validation(Required=false)]
        public string DestinationEndpointUserName { get; set; }

        /// <summary>
        /// <para>The method used to handle conflicts between objects with the same name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>renamenew</b>: renames the object if an object with the same name exists.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>renamenew</para>
        /// </summary>
        [NameInMap("DuplicateConflict")]
        [Validation(Required=false)]
        public string DuplicateConflict { get; set; }

        /// <summary>
        /// <para>Specifies whether to connect to the destination by using an SSL-encrypted connection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableDestinationEndpointSsl")]
        [Validation(Required=false)]
        public bool? EnableDestinationEndpointSsl { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>The method used to restore data to the destination. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>EXIST_INSTANCE</b>: restores data to an existing instance.</description></item>
        /// <item><description><b>NEW_INSTANCE</b>: restores data to a new instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>EXIST_INSTANCE</para>
        /// </summary>
        [NameInMap("RestoreDestinationMode")]
        [Validation(Required=false)]
        public string RestoreDestinationMode { get; set; }

        /// <summary>
        /// <para>This parameter is required if <b>DestinationEndpointInstanceType</b> is set to Agent and the backup plan is for MySQL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("RestoreDir")]
        [Validation(Required=false)]
        public string RestoreDir { get; set; }

        /// <summary>
        /// <para>The directory of the database program.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("RestoreHome")]
        [Validation(Required=false)]
        public string RestoreHome { get; set; }

        /// <summary>
        /// <para>The objects to be restored.</para>
        /// <list type="bullet">
        /// <item><description>For more information, see the definition of the <b>RestoreObjects</b> parameter below. This parameter is not required if the database is connected over a backup gateway. In other scenarios, this parameter is required.</description></item>
        /// <item><description>Template: <c>[{ &quot;DBName&quot;: &quot;Name of the database to be restored&quot;, &quot;NewDBName&quot;: &quot;Name of the destination database&quot; }]</c></description></item>
        /// </list>
        /// <remarks>
        /// <para>Restoring objects by calling this API operation only supports restoration at the database level. To restore specific tables, go to the console. For more information, see <a href="https://help.aliyun.com/document_detail/85543.html">Restore a database</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Example of MySQL table-level restoration:
        /// [{\&quot;DBName\&quot;:\&quot;dbname\&quot;, \&quot;NewDBName\&quot;:\&quot;dbname1\&quot;}]</para>
        /// </summary>
        [NameInMap("RestoreObjects")]
        [Validation(Required=false)]
        public string RestoreObjects { get; set; }

        /// <summary>
        /// <para>The name of the restore task.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("RestoreTaskName")]
        [Validation(Required=false)]
        public string RestoreTaskName { get; set; }

        /// <summary>
        /// <para>The point in time to which you want to restore the database. The value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1554560477000</para>
        /// </summary>
        [NameInMap("RestoreTime")]
        [Validation(Required=false)]
        public long? RestoreTime { get; set; }

        /// <summary>
        /// <para>The credential for the SSL-encrypted connection to the destination.</para>
        /// 
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE----- ... -----END CERTIFICATE-----</para>
        /// </summary>
        [NameInMap("SslCaPem")]
        [Validation(Required=false)]
        public string SslCaPem { get; set; }

    }

}
