// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20190306.Models
{
    public class CreateRestoreTaskRequest : TeaModel {
        [NameInMap("AutoOpenDatabase")]
        [Validation(Required=false)]
        public string AutoOpenDatabase { get; set; }

        [NameInMap("AutoShutdownDatabase")]
        [Validation(Required=false)]
        public string AutoShutdownDatabase { get; set; }

        /// <summary>
        /// <para>backup gateway ID.</para>
        /// <remarks>
        /// <para>This parameter is required when <b>DestinationEndpointInstanceType</b> is agent.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>4312****</para>
        /// </summary>
        [NameInMap("BackupGatewayId")]
        [Validation(Required=false)]
        public long? BackupGatewayId { get; set; }

        /// <summary>
        /// <para>backup plan ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dbs1hvb0ww****</para>
        /// </summary>
        [NameInMap("BackupPlanId")]
        [Validation(Required=false)]
        public string BackupPlanId { get; set; }

        /// <summary>
        /// <para>The ID of the full backup set used for restoration. Mutually exclusive with RestoreTime.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dbs1hvb0w*****</para>
        /// </summary>
        [NameInMap("BackupSetId")]
        [Validation(Required=false)]
        public string BackupSetId { get; set; }

        /// <summary>
        /// <para>Ensures request idempotence and prevents duplicate submissions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOC********</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>UID for cross-Alibaba Cloud account backup.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2749528728********</para>
        /// </summary>
        [NameInMap("CrossAliyunId")]
        [Validation(Required=false)]
        public string CrossAliyunId { get; set; }

        /// <summary>
        /// <para>RAM role name for cross-Alibaba Cloud account backup.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test123</para>
        /// </summary>
        [NameInMap("CrossRoleName")]
        [Validation(Required=false)]
        public string CrossRoleName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>mysql.x4.large.2</para>
        /// </summary>
        [NameInMap("DestDatabaseInstanceClass")]
        [Validation(Required=false)]
        public string DestDatabaseInstanceClass { get; set; }

        [NameInMap("DestDatabaseInstanceDatabaseVersion")]
        [Validation(Required=false)]
        public string DestDatabaseInstanceDatabaseVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("DestDatabaseInstanceRegion")]
        [Validation(Required=false)]
        public string DestDatabaseInstanceRegion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>500</para>
        /// </summary>
        [NameInMap("DestDatabaseInstanceStorageSize")]
        [Validation(Required=false)]
        public string DestDatabaseInstanceStorageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rds</para>
        /// </summary>
        [NameInMap("DestDatabaseInstanceType")]
        [Validation(Required=false)]
        public string DestDatabaseInstanceType { get; set; }

        [NameInMap("DestDatabaseInstanceVSwitch")]
        [Validation(Required=false)]
        public string DestDatabaseInstanceVSwitch { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vpc-xx</para>
        /// </summary>
        [NameInMap("DestDatabaseInstanceVpc")]
        [Validation(Required=false)]
        public string DestDatabaseInstanceVpc { get; set; }

        /// <summary>
        /// <para>database name.</para>
        /// <remarks>
        /// <para>This parameter is required when the database type is PostgreSQL or MongoDB.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("DestinationEndpointDatabaseName")]
        [Validation(Required=false)]
        public string DestinationEndpointDatabaseName { get; set; }

        /// <summary>
        /// <para>database endpoint.</para>
        /// <remarks>
        /// <para>This parameter is required when <b>DestinationEndpointInstanceType</b> is express, agent, or other.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp*****9jv8pxero.mysql.rds.aliyuncs.com</para>
        /// </summary>
        [NameInMap("DestinationEndpointIP")]
        [Validation(Required=false)]
        public string DestinationEndpointIP { get; set; }

        /// <summary>
        /// <para>database instance ID.</para>
        /// <remarks>
        /// <para>This parameter is required when <b>DestinationEndpointInstanceType</b> is RDS, ECS, DDS, or Express.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rm-bp1p8c29*****</para>
        /// </summary>
        [NameInMap("DestinationEndpointInstanceID")]
        [Validation(Required=false)]
        public string DestinationEndpointInstanceID { get; set; }

        /// <summary>
        /// <para>database location. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>RDS</b></para>
        /// </description></item>
        /// <item><description><para><b>ECS</b></para>
        /// </description></item>
        /// <item><description><para><b>Express</b>: databases accessed via leased line/VPN Gateway/Smart Gateway</para>
        /// </description></item>
        /// <item><description><para><b>Agent</b>: databases accessed via backup gateway</para>
        /// </description></item>
        /// <item><description><para><b>DDS</b>: Cloud MongoDB</para>
        /// </description></item>
        /// <item><description><para><b>Other</b>: databases directly connected via IP:Port</para>
        /// </description></item>
        /// <item><description><para><b>dg</b>: self-managed databases without public IP:Port (accessed via Database Gateway DG)</para>
        /// </description></item>
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
        /// <para>Oracle SID name.</para>
        /// <remarks>
        /// <para>This parameter is required when the database type is Oracle.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("DestinationEndpointOracleSID")]
        [Validation(Required=false)]
        public string DestinationEndpointOracleSID { get; set; }

        /// <summary>
        /// <para>password.</para>
        /// <remarks>
        /// <para>This parameter is optional when the database type is Redis, or when the database location is agent and the database type is MSSQL. It is required in all other scenarios.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Test</para>
        /// </summary>
        [NameInMap("DestinationEndpointPassword")]
        [Validation(Required=false)]
        public string DestinationEndpointPassword { get; set; }

        /// <summary>
        /// <para>database port.</para>
        /// <remarks>
        /// <para>This parameter is required when <b>DestinationEndpointInstanceType</b> is express, agent, other, or ECS.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3306</para>
        /// </summary>
        [NameInMap("DestinationEndpointPort")]
        [Validation(Required=false)]
        public int? DestinationEndpointPort { get; set; }

        /// <summary>
        /// <para>region of the database instance.</para>
        /// <remarks>
        /// <para>This parameter is required when <b>DestinationEndpointInstanceType</b> is RDS, ECS, DDS, Express, or Agent.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("DestinationEndpointRegion")]
        [Validation(Required=false)]
        public string DestinationEndpointRegion { get; set; }

        /// <summary>
        /// <para>database account.</para>
        /// <remarks>
        /// <para>This parameter is optional when the database type is Redis, or when the database location is agent and the database type is MSSQL. It is required in all other scenarios.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("DestinationEndpointUserName")]
        [Validation(Required=false)]
        public string DestinationEndpointUserName { get; set; }

        /// <summary>
        /// <para>Conflict handling for objects with the same name. Currently supports:</para>
        /// <para><b>renamenew</b>: Rename objects if names conflict.</para>
        /// 
        /// <b>Example:</b>
        /// <para>renamenew</para>
        /// </summary>
        [NameInMap("DuplicateConflict")]
        [Validation(Required=false)]
        public string DuplicateConflict { get; set; }

        [NameInMap("EnableDestinationEndpointSsl")]
        [Validation(Required=false)]
        public bool? EnableDestinationEndpointSsl { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>exist_instance</para>
        /// </summary>
        [NameInMap("RestoreDestinationMode")]
        [Validation(Required=false)]
        public string RestoreDestinationMode { get; set; }

        /// <summary>
        /// <para>Required when <b>DestinationEndpointInstanceType</b> is agent and the backup plan is MySQL.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("RestoreDir")]
        [Validation(Required=false)]
        public string RestoreDir { get; set; }

        /// <summary>
        /// <para>database program directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("RestoreHome")]
        [Validation(Required=false)]
        public string RestoreHome { get; set; }

        /// <summary>
        /// <para>restore objects.</para>
        /// <list type="bullet">
        /// <item><description><para>For details, see the <b>RestoreObjects</b> parameter definition below. This parameter is optional when the database location is agent, and required in all other scenarios.</para>
        /// </description></item>
        /// <item><description><para>Input template: <c>[{ &quot;DBName&quot;: &quot;database name to be restored&quot;, &quot;NewDBName&quot;: &quot;target database name to be restored&quot; }]</c></para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This API only supports restoring objects at the database level. To configure table-level restoration, use the console. For details, see <a href="https://help.aliyun.com/document_detail/85543.html">Recover databases</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL表级别恢复示例如下：
        /// [{\&quot;DBName\&quot;:\&quot;dbname\&quot;, \&quot;NewDBName\&quot;:\&quot;dbname1\&quot;}]</para>
        /// </summary>
        [NameInMap("RestoreObjects")]
        [Validation(Required=false)]
        public string RestoreObjects { get; set; }

        /// <summary>
        /// <para>restore job name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("RestoreTaskName")]
        [Validation(Required=false)]
        public string RestoreTaskName { get; set; }

        /// <summary>
        /// <para>restore time. Value: 1554560477000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1554560477000</para>
        /// </summary>
        [NameInMap("RestoreTime")]
        [Validation(Required=false)]
        public long? RestoreTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>-----BEGIN CERTIFICATE----- ... -----END CERTIFICATE-----</para>
        /// </summary>
        [NameInMap("SslCaPem")]
        [Validation(Required=false)]
        public string SslCaPem { get; set; }

    }

}
