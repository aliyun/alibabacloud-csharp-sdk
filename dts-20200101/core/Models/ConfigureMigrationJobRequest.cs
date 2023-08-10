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
            /// The name of the destination database or the authentication database.
            /// 
            /// > 
            /// *   You must specify the database name only if the **DestinationEndpoint.EngineName** parameter is set to **PostgreSQL**, **DRDS**, or **MongoDB**.
            /// *   If the **DestinationEndpoint.EngineName** parameter is set to **PostgreSQL** or **DRDS**, specify the name of the destination database. If the DestinationEndpoint.EngineName parameter is set to **MongoDB**, specify the name of the authentication database.
            /// </summary>
            [NameInMap("DataBaseName")]
            [Validation(Required=false)]
            public string DataBaseName { get; set; }

            /// <summary>
            /// The engine type of the destination database. Valid values: **MySQL**, **DRDS**, **SQLServer**, **PostgreSQL**, **PPAS**, **MongoDB**, **Redis**, **POLARDB**, and **polardb_pg**.
            /// 
            /// >  You must specify the engine type only if the **DestinationEndpoint.InstanceType** parameter is set to **RDS**, **POLARDB**, **ECS**, **LocalInstance**, or **Express**.
            /// </summary>
            [NameInMap("EngineName")]
            [Validation(Required=false)]
            public string EngineName { get; set; }

            /// <summary>
            /// The endpoint of the destination database.
            /// 
            /// >  You must specify the endpoint only if the **DestinationEndpoint.InstanceType** parameter is set to **LocalInstance** or **Express**.
            /// </summary>
            [NameInMap("IP")]
            [Validation(Required=false)]
            public string IP { get; set; }

            /// <summary>
            /// The ID of the instance that hosts the destination database.
            /// 
            /// >  You must specify the instance ID only if the **DestinationEndpoint.InstanceType** parameter is set to **RDS**, **ECS**, **MongoDB**, **Redis**, **DRDS**, **PetaData**, **OceanBase**, **POLARDB**, **PolarDB_o**, **AnalyticDB**, or **Greenplum**. For example, if the DestinationEndpoint.InstanceType parameter is set to **ECS**, you must specify the ID of the ECS instance.
            /// </summary>
            [NameInMap("InstanceID")]
            [Validation(Required=false)]
            public string InstanceID { get; set; }

            /// <summary>
            /// The instance type of the destination database. Valid values:
            /// 
            /// *   **ECS**: self-managed database that is hosted on Elastic Compute Service (ECS)
            /// *   **LocalInstance**: self-managed database with a public IP address
            /// *   **RDS**: ApsaraDB RDS instance
            /// *   **DRDS**: PolarDB-X instance
            /// *   **MongoDB**: ApsaraDB for MongoDB instance
            /// *   **Redis**: ApsaraDB for Redis instance
            /// *   **PetaData**: HybridDB for MySQL instance
            /// *   **POLARDB**: PolarDB for MySQL cluster or PolarDB for PostgreSQL cluster
            /// *   **PolarDB_o**: PolarDB O Edition cluster
            /// *   **AnalyticDB**: AnalyticDB for MySQL cluster V3.0 or V2.0
            /// *   **Greenplum**: AnalyticDB for PostgreSQL instance
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// The SID of the Oracle database.
            /// 
            /// >  You must specify this parameter only if the **DestinationEndpoint.EngineName** parameter is set to **Oracle** and the **Oracle** database is deployed in a non-RAC architecture.
            /// </summary>
            [NameInMap("OracleSID")]
            [Validation(Required=false)]
            public string OracleSID { get; set; }

            /// <summary>
            /// The password of the destination database account.
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// The service port number of the destination database.
            /// 
            /// >  You must specify the service port number only if the **DestinationEndpoint.InstanceType** parameter is set to **ECS**, **LocalInstance**, or **Express**.
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// The region ID of the destination database.
            /// 
            /// >  If the **DestinationEndpoint.InstanceType** parameter is set to **LocalInstance**, you can enter **cn-hangzhou** or the ID of the region closest to the self-managed database. For more information, see [List of supported regions](~~141033~~).
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// The database account of the destination database.
            /// 
            /// >  The permissions that are required for database accounts vary with the migration scenario. For more information, see [Overview of data migration scenarios](~~26618~~).
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
            /// Specifies whether to perform full data migration. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false**: no
            /// 
            /// >  For more information about databases that support full data migration, see [Supported databases and migration types](~~26618~~).
            /// </summary>
            [NameInMap("DataIntialization")]
            [Validation(Required=false)]
            public bool? DataIntialization { get; set; }

            /// <summary>
            /// Specifies whether to perform incremental data migration. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false**: no
            /// 
            /// >  For more information about databases that support incremental data migration, see [Supported databases and migration types](~~26618~~).
            /// </summary>
            [NameInMap("DataSynchronization")]
            [Validation(Required=false)]
            public bool? DataSynchronization { get; set; }

            /// <summary>
            /// Specifies whether to perform schema migration. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false**: no
            /// 
            /// >  For more information about databases that support schema migration, see [Supported databases and migration types](~~26618~~).
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
            /// The name of the source database or the authentication database.
            /// 
            /// > 
            /// *   You must specify the database name only if the **SourceEndpoint.EngineName** parameter is set to **PostgreSQL** or **MongoDB**.
            /// *   If the **SourceEndpoint.EngineName** parameter is set to **PostgreSQL**, specify the name of the source database. If the SourceEndpoint.EngineName parameter is set to **MongoDB**, specify the name of the authentication database.
            /// </summary>
            [NameInMap("DatabaseName")]
            [Validation(Required=false)]
            public string DatabaseName { get; set; }

            /// <summary>
            /// The engine type of the source database. Valid values: **MySQL**, **TiDB**, **SQLServer**, **PostgreSQL**, **Oracle**, **MongoDB**, **Redis**, **POLARDB**, and **polardb_pg**.
            /// 
            /// >  You must specify the engine type only if the **DestinationEndpoint.InstanceType** parameter is set to **RDS**, **POLARDB**, **ECS**, **LocalInstance**, or **Express**.
            /// </summary>
            [NameInMap("EngineName")]
            [Validation(Required=false)]
            public string EngineName { get; set; }

            /// <summary>
            /// The endpoint of the source database.
            /// 
            /// >  You must specify the endpoint only if the **SourceEndpoint.InstanceType** parameter is set to **LocalInstance** or **Express**.
            /// </summary>
            [NameInMap("IP")]
            [Validation(Required=false)]
            public string IP { get; set; }

            /// <summary>
            /// The ID of the instance that hosts the source database.
            /// 
            /// > 
            /// *   You must specify the instance ID only if the **SourceEndpoint.InstanceType** parameter is set to **RDS**, **ECS**, **Express**, **MongoDB**, **POLARDB**, or **PolarDB_o**. For example, if the SourceEndpoint.InstanceType parameter is set to **ECS**, you must specify the ID of the ECS instance.
            /// *   If the **SourceEndpoint.InstanceType** parameter is set to **Express**, you must specify the ID of the virtual private cloud (VPC).
            /// </summary>
            [NameInMap("InstanceID")]
            [Validation(Required=false)]
            public string InstanceID { get; set; }

            /// <summary>
            /// The instance type of the source database. Valid values:
            /// 
            /// *   **RDS**: ApsaraDB RDS instance
            /// *   **ECS**: self-managed database that is hosted on ECS
            /// *   **LocalInstance**: self-managed database with a public IP address
            /// *   **Express**: self-managed database that is connected over Express Connect, VPN Gateway, or Smart Access Gateway
            /// *   **dg**: self-managed database that is connected over Database Gateway
            /// *   **cen**: self-managed database that is connected over Cloud Enterprise Network (CEN)
            /// *   **MongoDB**: ApsaraDB for MongoDB instance
            /// *   **POLARDB**: PolarDB for MySQL cluster or PolarDB for PostgreSQL cluster
            /// *   **PolarDB_o**: PolarDB O Edition cluster
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// The system ID (SID) of the Oracle database.
            /// 
            /// >  You must specify this parameter only if the **SourceEndpoint.EngineName** parameter is set to **Oracle** and the **Oracle** database is deployed in a non-RAC architecture.
            /// </summary>
            [NameInMap("OracleSID")]
            [Validation(Required=false)]
            public string OracleSID { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account to which the source instance belongs.
            /// 
            /// >  You must specify this parameter only when you configure data migration across different Alibaba Cloud accounts.
            /// </summary>
            [NameInMap("OwnerID")]
            [Validation(Required=false)]
            public string OwnerID { get; set; }

            /// <summary>
            /// The password of the source database account.
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// The service port number of the source database.
            /// 
            /// >  You must specify the service port number only if the **SourceEndpoint.InstanceType** parameter is set to **ECS**, **LocalInstance**, or **Express**.
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// The region ID of the source database.
            /// 
            /// >  If the **SourceEndpoint.InstanceType** parameter is set to **LocalInstance**, you can enter **cn-hangzhou** or the ID of the region closest to the self-managed database. For more information, see [List of supported regions](~~141033~~).
            /// </summary>
            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            /// <summary>
            /// The authorized RAM role of the source instance. You must specify the RAM role only if the source instance and the destination instance belong to different Alibaba Cloud accounts. You can use the RAM role to allow the Alibaba Cloud account that owns the destination instance to access the source instance.
            /// 
            /// >  For information about the permissions and authorization methods of the RAM role, see [Configure RAM authorization for cross-account data migration and synchronization](~~48468~~).
            /// </summary>
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// The database account of the source database.
            /// 
            /// >  The permissions that are required for database accounts vary with the migration scenario. For more information, see [Overview of data migration scenarios](~~26618~~).
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        /// <summary>
        /// The ID of the Alibaba Cloud account. You do not need to specify this parameter because this parameter will be removed in the future.
        /// </summary>
        [NameInMap("AccountId")]
        [Validation(Required=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// The start offset of incremental data migration. The value is a UNIX timestamp. Unit: seconds.
        /// </summary>
        [NameInMap("Checkpoint")]
        [Validation(Required=false)]
        public string Checkpoint { get; set; }

        /// <summary>
        /// The ID of the data migration instance. You can call the **DescribeMigrationJobs** operation to query the instance ID.
        /// </summary>
        [NameInMap("MigrationJobId")]
        [Validation(Required=false)]
        public string MigrationJobId { get; set; }

        /// <summary>
        /// The name of the data migration task. The name can be up to 32 characters in length. We recommend that you specify an informative name to identify the task. You do not need to use a unique task name.
        /// </summary>
        [NameInMap("MigrationJobName")]
        [Validation(Required=false)]
        public string MigrationJobName { get; set; }

        /// <summary>
        /// The objects that you want to migrate. The value is a JSON string and can contain regular expressions.
        /// 
        /// For more information, see [MigrationObject](~~141227~~).
        /// </summary>
        [NameInMap("MigrationObject")]
        [Validation(Required=false)]
        public string MigrationObject { get; set; }

        /// <summary>
        /// The reserved parameter of DTS. The value is a JSON string. You can specify this parameter to meet special requirements, for example, whether to automatically start a precheck. For more information, see [MigrationReserved](~~176470~~).
        /// </summary>
        [NameInMap("MigrationReserved")]
        [Validation(Required=false)]
        public string MigrationReserved { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// The ID of the region where the data migration instance resides. For more information, see [List of supported regions](~~141033~~).
        /// 
        /// >  The region ID of the data migration instance is the same as that of the destination database.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
