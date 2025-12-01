// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20190306.Models
{
    public class CreateRestoreTaskRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the backup gateway.</para>
        /// <remarks>
        /// <para>This parameter is required if the DestinationEndpointInstanceType parameter is set to Agent.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>4312****</para>
        /// </summary>
        [NameInMap("BackupGatewayId")]
        [Validation(Required=false)]
        public long? BackupGatewayId { get; set; }

        /// <summary>
        /// <para>The ID of the backup schedule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dbs1hvb0ww****</para>
        /// </summary>
        [NameInMap("BackupPlanId")]
        [Validation(Required=false)]
        public string BackupPlanId { get; set; }

        /// <summary>
        /// <para>The ID of the full backup set.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dbs1hvb0w*****</para>
        /// </summary>
        [NameInMap("BackupSetId")]
        [Validation(Required=false)]
        public string BackupSetId { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOC********</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The unique ID (UID) of the Alibaba Cloud account to which the source database belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2749528728********</para>
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
        /// <para>The name of the database.</para>
        /// <remarks>
        /// <para>This parameter is required if the database is a PostgreSQL database or a MongoDB database.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("DestinationEndpointDatabaseName")]
        [Validation(Required=false)]
        public string DestinationEndpointDatabaseName { get; set; }

        /// <summary>
        /// <para>The endpoint that is used to connect to the database.</para>
        /// <remarks>
        /// <para>This parameter is required if the DestinationEndpointInstanceType parameter is set to Express, Agent, or Other.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp*****9jv8pxero.mysql.rds.aliyuncs.com</para>
        /// </summary>
        [NameInMap("DestinationEndpointIP")]
        [Validation(Required=false)]
        public string DestinationEndpointIP { get; set; }

        /// <summary>
        /// <para>The ID of the database instance.</para>
        /// <remarks>
        /// <para>This parameter is required if the DestinationEndpointInstanceType parameter is set to RDS, ECS, DDS, or Express.</para>
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
        /// <item><description><b>RDS</b>: The database is deployed on an ApsaraDB RDS instance.</description></item>
        /// <item><description><b>ECS</b>: The database is deployed on an Elastic Compute Service (ECS) instance.</description></item>
        /// <item><description><b>Express</b>: The database is connected to Database Backup (DBS) by using Express Connect, VPN Gateway, or Smart Access Gateway.</description></item>
        /// <item><description><b>Agent</b>: The database is connected over a DBS backup gateway.</description></item>
        /// <item><description><b>DDS</b>: The database is an ApsaraDB for MongoDB database.</description></item>
        /// <item><description><b>Other</b>: The database is connected to DBS by using the IP address and port of the database.</description></item>
        /// <item><description><b>dg</b>: The database is a self-managed database that does not have public IP addresses or port numbers and is connected to DBS over Database Gateway.</description></item>
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
        /// <para>The system ID (SID) of the Oracle database.</para>
        /// <remarks>
        /// <para>This parameter is required if the source database is an Oracle database.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("DestinationEndpointOracleSID")]
        [Validation(Required=false)]
        public string DestinationEndpointOracleSID { get; set; }

        /// <summary>
        /// <para>The password of the account that is used to connect to the source database.</para>
        /// <remarks>
        /// <para>This parameter is required except that the database is an SQL Server database that is connected to DBS over a DBS backup gateway or a Redis database.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Test</para>
        /// </summary>
        [NameInMap("DestinationEndpointPassword")]
        [Validation(Required=false)]
        public string DestinationEndpointPassword { get; set; }

        /// <summary>
        /// <para>The port of the database.</para>
        /// <remarks>
        /// <para>This parameter is required if the DestinationEndpointInstanceType parameter is set to Express, Agent, Other, or ECS.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3306</para>
        /// </summary>
        [NameInMap("DestinationEndpointPort")]
        [Validation(Required=false)]
        public int? DestinationEndpointPort { get; set; }

        /// <summary>
        /// <para>The region ID of the destination database instance.</para>
        /// <remarks>
        /// <para> You must specify this parameter if <b>DestinationEndpointInstanceType</b> is set to RDS, ECS, DDS, Express, or Agent.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("DestinationEndpointRegion")]
        [Validation(Required=false)]
        public string DestinationEndpointRegion { get; set; }

        /// <summary>
        /// <para>The username of the account that is used to connect to the database.</para>
        /// <remarks>
        /// <para>This parameter is required except that the database is an SQL Server database that is connected to DBS over a DBS backup gateway or a Redis database.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("DestinationEndpointUserName")]
        [Validation(Required=false)]
        public string DestinationEndpointUserName { get; set; }

        /// <summary>
        /// <para>The method of processing objects with the same name. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>failure: The restore task fails if the system detects objects with the same name. This is the default value.</description></item>
        /// <item><description>renamenew: The restore task renames objects with the same name starting from the second occurrence.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>renamenew</para>
        /// </summary>
        [NameInMap("DuplicateConflict")]
        [Validation(Required=false)]
        public string DuplicateConflict { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>This parameter is required if the DestinationEndpointInstanceType parameter is set to Agent and the backup object of the backup schedule is a MySQL database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("RestoreDir")]
        [Validation(Required=false)]
        public string RestoreDir { get; set; }

        /// <summary>
        /// <para>The program directory of the database.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("RestoreHome")]
        [Validation(Required=false)]
        public string RestoreHome { get; set; }

        /// <summary>
        /// <para>The objects to be restored.</para>
        /// <remarks>
        /// <para>This parameter is required except that the DestinationEndpointInstanceType parameter is set to Agent. For information about the parameter definition, see RestoreObjects.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[ { &quot;DBName&quot;:&quot;Name of the database to be restored&quot;, &quot;NewDBName&quot;:&quot;Name of the database to which the objects will be restored&quot;, &quot;SchemaName&quot;:&quot;Schema name of the database to be restored&quot;, &quot;NewSchemaName&quot;:&quot;Schema name of the destination database to which the objects will be restored&quot;}]</para>
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
        /// <para>The time to run the restore task, such as 1554560477000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1554560477000</para>
        /// </summary>
        [NameInMap("RestoreTime")]
        [Validation(Required=false)]
        public long? RestoreTime { get; set; }

    }

}
