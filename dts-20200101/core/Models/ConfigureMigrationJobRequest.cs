// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class ConfigureMigrationJobRequest : TeaModel {
        [NameInMap("DestinationEndpoint")]
        [Validation(Required=false)]
        public ConfigureMigrationJobRequestDestinationEndpoint DestinationEndpoint { get; set; }
        public class ConfigureMigrationJobRequestDestinationEndpoint : TeaModel {
            /// <summary>
            /// <para>The region ID of the destination database.</para>
            /// <remarks>
            /// <para> If the <b>DestinationEndpoint.InstanceType</b> parameter is set to <b>LocalInstance</b>, you can enter <b>cn-hangzhou</b> or the ID of the region closest to the self-managed database. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">List of supported regions</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>dtstestdatabase</para>
            /// </summary>
            [NameInMap("DataBaseName")]
            [Validation(Required=false)]
            public string DataBaseName { get; set; }

            /// <summary>
            /// <para>The authorized RAM role of the source instance. You must specify the RAM role only if the source instance and the destination instance belong to different Alibaba Cloud accounts. You can use the RAM role to allow the Alibaba Cloud account that owns the destination instance to access the source instance.</para>
            /// <remarks>
            /// <para> For information about the permissions and authorization methods of the RAM role, see <a href="https://help.aliyun.com/document_detail/48468.html">Configure RAM authorization for cross-account data migration and synchronization</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>MySQL</para>
            /// </summary>
            [NameInMap("EngineName")]
            [Validation(Required=false)]
            public string EngineName { get; set; }

            /// <summary>
            /// <para>The ID of the instance that hosts the destination database.</para>
            /// <remarks>
            /// <para> You must specify the instance ID only if the <b>DestinationEndpoint.InstanceType</b> parameter is set to <b>RDS</b>, <b>ECS</b>, <b>MongoDB</b>, <b>Redis</b>, <b>DRDS</b>, <b>PetaData</b>, <b>OceanBase</b>, <b>POLARDB</b>, <b>PolarDB_o</b>, <b>AnalyticDB</b>, or <b>Greenplum</b>. For example, if the DestinationEndpoint.InstanceType parameter is set to <b>ECS</b>, you must specify the ID of the ECS instance.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>172.16.88.***</para>
            /// </summary>
            [NameInMap("IP")]
            [Validation(Required=false)]
            public string IP { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account to which the source instance belongs.</para>
            /// <remarks>
            /// <para> You must specify this parameter only when you configure data migration across different Alibaba Cloud accounts.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>rm-bp1r46452ai50****</para>
            /// </summary>
            [NameInMap("InstanceID")]
            [Validation(Required=false)]
            public string InstanceID { get; set; }

            /// <summary>
            /// <para>The password of the source database account.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RDS</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The reserved parameter of DTS. The value is a JSON string. You can specify this parameter to meet special requirements, for example, whether to automatically start a precheck. For more information, see <a href="https://help.aliyun.com/document_detail/176470.html">MigrationReserved</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testsid</para>
            /// </summary>
            [NameInMap("OracleSID")]
            [Validation(Required=false)]
            public string OracleSID { get; set; }

            /// <summary>
            /// <para>The service port number of the destination database.</para>
            /// <remarks>
            /// <para> You must specify the service port number only if the <b>DestinationEndpoint.InstanceType</b> parameter is set to <b>ECS</b>, <b>LocalInstance</b>, or <b>Express</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Test123456</para>
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <para>The engine type of the destination database. Valid values: <b>MySQL</b>, <b>DRDS</b>, <b>SQLServer</b>, <b>PostgreSQL</b>, <b>PPAS</b>, <b>MongoDB</b>, <b>Redis</b>, <b>POLARDB</b>, and <b>polardb_pg</b>.</para>
            /// <remarks>
            /// <para> You must specify the engine type only if the <b>DestinationEndpoint.InstanceType</b> parameter is set to <b>RDS</b>, <b>POLARDB</b>, <b>ECS</b>, <b>LocalInstance</b>, or <b>Express</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>3306</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// <para>The instance type of the destination database. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ECS</b>: self-managed database that is hosted on Elastic Compute Service (ECS)</description></item>
            /// <item><description><b>LocalInstance</b>: self-managed database with a public IP address</description></item>
            /// <item><description><b>RDS</b>: ApsaraDB RDS instance</description></item>
            /// <item><description><b>DRDS</b>: PolarDB-X instance</description></item>
            /// <item><description><b>MongoDB</b>: ApsaraDB for MongoDB instance</description></item>
            /// <item><description><b>Redis</b>: ApsaraDB for Redis instance</description></item>
            /// <item><description><b>PetaData</b>: HybridDB for MySQL instance</description></item>
            /// <item><description><b>POLARDB</b>: PolarDB for MySQL cluster or PolarDB for PostgreSQL cluster</description></item>
            /// <item><description><b>PolarDB_o</b>: PolarDB O Edition cluster</description></item>
            /// <item><description><b>AnalyticDB</b>: AnalyticDB for MySQL cluster V3.0 or V2.0</description></item>
            /// <item><description><b>Greenplum</b>: AnalyticDB for PostgreSQL instance</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The endpoint of the destination database.</para>
            /// <remarks>
            /// <para> You must specify the endpoint only if the <b>DestinationEndpoint.InstanceType</b> parameter is set to <b>LocalInstance</b> or <b>Express</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>dtstestaccount</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        [NameInMap("MigrationMode")]
        [Validation(Required=false)]
        public ConfigureMigrationJobRequestMigrationMode MigrationMode { get; set; }
        public class ConfigureMigrationJobRequestMigrationMode : TeaModel {
            /// <summary>
            /// <para>The database account of the destination database.</para>
            /// <remarks>
            /// <para> The permissions that are required for database accounts vary with the migration scenario. For more information, see <a href="https://help.aliyun.com/document_detail/26618.html">Overview of data migration scenarios</a>.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DataIntialization")]
            [Validation(Required=false)]
            public bool? DataIntialization { get; set; }

            /// <summary>
            /// <para>The password of the destination database account.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DataSynchronization")]
            [Validation(Required=false)]
            public bool? DataSynchronization { get; set; }

            /// <summary>
            /// <para>The name of the destination database or the authentication database.</para>
            /// <remarks>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>You must specify the database name only if the <b>DestinationEndpoint.EngineName</b> parameter is set to <b>PostgreSQL</b>, <b>DRDS</b>, or <b>MongoDB</b>.</description></item>
            /// <item><description>If the <b>DestinationEndpoint.EngineName</b> parameter is set to <b>PostgreSQL</b> or <b>DRDS</b>, specify the name of the destination database. If the DestinationEndpoint.EngineName parameter is set to <b>MongoDB</b>, specify the name of the authentication database.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("StructureIntialization")]
            [Validation(Required=false)]
            public bool? StructureIntialization { get; set; }

        }

        [NameInMap("SourceEndpoint")]
        [Validation(Required=false)]
        public ConfigureMigrationJobRequestSourceEndpoint SourceEndpoint { get; set; }
        public class ConfigureMigrationJobRequestSourceEndpoint : TeaModel {
            /// <summary>
            /// <para>The endpoint of the source database.</para>
            /// <remarks>
            /// <para> You must specify the endpoint only if the <b>SourceEndpoint.InstanceType</b> parameter is set to <b>LocalInstance</b> or <b>Express</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>dtstestdatabase</para>
            /// </summary>
            [NameInMap("DatabaseName")]
            [Validation(Required=false)]
            public string DatabaseName { get; set; }

            /// <summary>
            /// <para>The instance type of the source database. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>RDS</b>: ApsaraDB RDS instance</description></item>
            /// <item><description><b>ECS</b>: self-managed database that is hosted on ECS</description></item>
            /// <item><description><b>LocalInstance</b>: self-managed database with a public IP address</description></item>
            /// <item><description><b>Express</b>: self-managed database that is connected over Express Connect, VPN Gateway, or Smart Access Gateway</description></item>
            /// <item><description><b>dg</b>: self-managed database that is connected over Database Gateway</description></item>
            /// <item><description><b>cen</b>: self-managed database that is connected over Cloud Enterprise Network (CEN)</description></item>
            /// <item><description><b>MongoDB</b>: ApsaraDB for MongoDB instance</description></item>
            /// <item><description><b>POLARDB</b>: PolarDB for MySQL cluster or PolarDB for PostgreSQL cluster</description></item>
            /// <item><description><b>PolarDB_o</b>: PolarDB O Edition cluster</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>MySQL</para>
            /// </summary>
            [NameInMap("EngineName")]
            [Validation(Required=false)]
            public string EngineName { get; set; }

            /// <summary>
            /// <para>rm-bp1i99e8l7913****</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.16.88.***</para>
            /// </summary>
            [NameInMap("IP")]
            [Validation(Required=false)]
            public string IP { get; set; }

            /// <summary>
            /// <para>dtsl3m1213ye7l****</para>
            /// 
            /// <b>Example:</b>
            /// <para>The name of the data migration task. The name can be up to 32 characters in length. We recommend that you specify an informative name to identify the task. You do not need to use a unique task name.</para>
            /// </summary>
            [NameInMap("InstanceID")]
            [Validation(Required=false)]
            public string InstanceID { get; set; }

            /// <summary>
            /// <para>The ID of the data migration instance. You can call the <b>DescribeMigrationJobs</b> operation to query the instance ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RDS</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// <para>The region ID of the source database.</para>
            /// <remarks>
            /// <para> If the <b>SourceEndpoint.InstanceType</b> parameter is set to <b>LocalInstance</b>, you can enter <b>cn-hangzhou</b> or the ID of the region closest to the self-managed database. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">List of supported regions</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>testsid</para>
            /// </summary>
            [NameInMap("OracleSID")]
            [Validation(Required=false)]
            public string OracleSID { get; set; }

            /// <summary>
            /// <para>The name of the source database or the authentication database.</para>
            /// <remarks>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>You must specify the database name only if the <b>SourceEndpoint.EngineName</b> parameter is set to <b>PostgreSQL</b> or <b>MongoDB</b>.</description></item>
            /// <item><description>If the <b>SourceEndpoint.EngineName</b> parameter is set to <b>PostgreSQL</b>, specify the name of the source database. If the SourceEndpoint.EngineName parameter is set to <b>MongoDB</b>, specify the name of the authentication database.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>140692647406****</para>
            /// </summary>
            [NameInMap("OwnerID")]
            [Validation(Required=false)]
            public string OwnerID { get; set; }

            /// <summary>
            /// <para>The system ID (SID) of the Oracle database.</para>
            /// <remarks>
            /// <para> You must specify this parameter only if the <b>SourceEndpoint.EngineName</b> parameter is set to <b>Oracle</b> and the <b>Oracle</b> database is deployed in a non-RAC architecture.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>Test123456</para>
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// <para>The engine type of the source database. Valid values: <b>MySQL</b>, <b>TiDB</b>, <b>SQLServer</b>, <b>PostgreSQL</b>, <b>Oracle</b>, <b>MongoDB</b>, <b>Redis</b>, <b>POLARDB</b>, and <b>polardb_pg</b>.</para>
            /// <remarks>
            /// <para> You must specify the engine type only if the <b>DestinationEndpoint.InstanceType</b> parameter is set to <b>RDS</b>, <b>POLARDB</b>, <b>ECS</b>, <b>LocalInstance</b>, or <b>Express</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>3306</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// <para>The ID of the instance that hosts the source database.</para>
            /// <remarks>
            /// </remarks>
            /// <list type="bullet">
            /// <item><description>You must specify the instance ID only if the <b>SourceEndpoint.InstanceType</b> parameter is set to <b>RDS</b>, <b>ECS</b>, <b>Express</b>, <b>MongoDB</b>, <b>POLARDB</b>, or <b>PolarDB_o</b>. For example, if the SourceEndpoint.InstanceType parameter is set to <b>ECS</b>, you must specify the ID of the ECS instance.</description></item>
            /// <item><description>If the <b>SourceEndpoint.InstanceType</b> parameter is set to <b>Express</b>, you must specify the ID of the virtual private cloud (VPC).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// <para>The database account of the source database.</para>
            /// <remarks>
            /// <para> The permissions that are required for database accounts vary with the migration scenario. For more information, see <a href="https://help.aliyun.com/document_detail/26618.html">Overview of data migration scenarios</a>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>ram-for-dts</para>
            /// </summary>
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// <para>The service port number of the source database.</para>
            /// <remarks>
            /// <para> You must specify the service port number only if the <b>SourceEndpoint.InstanceType</b> parameter is set to <b>ECS</b>, <b>LocalInstance</b>, or <b>Express</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>dtstestaccount</para>
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// <para>The objects that you want to migrate. The value is a JSON string and can contain regular expressions.</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/141227.html">MigrationObject</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12323344****</para>
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform incremental data migration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: yes</description></item>
        /// <item><description><b>false</b>: no</description></item>
        /// </list>
        /// <remarks>
        /// <para> For more information about databases that support incremental data migration, see <a href="https://help.aliyun.com/document_detail/26618.html">Supported databases and migration types</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>111</para>
        /// </summary>
        [NameInMap("Checkpoint")]
        [Validation(Required=false)]
        public string Checkpoint { get; set; }

        /// <summary>
        /// <para>system</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The operation that you want to perform. Set the value to <b>ConfigureMigrationJob</b>.</para>
        /// </summary>
        [NameInMap("MigrationJobId")]
        [Validation(Required=false)]
        public string MigrationJobId { get; set; }

        /// <summary>
        /// <para>The ID of the region where the data migration instance resides. For more information, see <a href="https://help.aliyun.com/document_detail/141033.html">List of supported regions</a>.</para>
        /// <remarks>
        /// <para> The region ID of the data migration instance is the same as that of the destination database.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL_TO_RDS</para>
        /// </summary>
        [NameInMap("MigrationJobName")]
        [Validation(Required=false)]
        public string MigrationJobName { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform schema migration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: yes</description></item>
        /// <item><description><b>false</b>: no</description></item>
        /// </list>
        /// <remarks>
        /// <para> For more information about databases that support schema migration, see <a href="https://help.aliyun.com/document_detail/26618.html">Supported databases and migration types</a>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;DBName&quot;:&quot;dtstestdata&quot;,&quot;TableIncludes&quot;:[{&quot;TableName&quot;:&quot;customer&quot;}]}]</para>
        /// </summary>
        [NameInMap("MigrationObject")]
        [Validation(Required=false)]
        public string MigrationObject { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform full data migration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: yes</description></item>
        /// <item><description><b>false</b>: no</description></item>
        /// </list>
        /// <remarks>
        /// <para> For more information about databases that support full data migration, see <a href="https://help.aliyun.com/document_detail/26618.html">Supported databases and migration types</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{     &quot;autoStartModulesAfterConfig&quot;: &quot;none&quot;,     &quot;targetTableMode&quot;: 2 }</para>
        /// </summary>
        [NameInMap("MigrationReserved")]
        [Validation(Required=false)]
        public string MigrationReserved { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Resource GroupId</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmzawhxxc****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
