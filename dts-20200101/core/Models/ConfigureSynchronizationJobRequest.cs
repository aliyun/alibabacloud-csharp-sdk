// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class ConfigureSynchronizationJobRequest : TeaModel {
        [NameInMap("DestinationEndpoint")]
        [Validation(Required=false)]
        public ConfigureSynchronizationJobRequestDestinationEndpoint DestinationEndpoint { get; set; }
        public class ConfigureSynchronizationJobRequestDestinationEndpoint : TeaModel {
            /// <summary>
            /// The name of the database to which the synchronization object in the destination instance belongs.
            /// </summary>
            [NameInMap("DataBaseName")]
            [Validation(Required=false)]
            public string DataBaseName { get; set; }

            /// <summary>
            /// The IP address of the destination database.
            /// 
            /// >  You must specify this parameter only if the **DestinationEndpoint.InstanceType** parameter is set to **Express**, **dg**, or **cen**.
            /// </summary>
            [NameInMap("IP")]
            [Validation(Required=false)]
            public string IP { get; set; }

            /// <summary>
            /// The ID of the destination instance.
            /// 
            /// >  If the **DestinationEndpoint.InstanceType** parameter is set to **MaxCompute** or **DataHub**, you must specify the name of the MaxCompute project or the DataHub project.
            /// 
            /// If the destination instance is an AnalyticDB for MySQL cluster, specify the ID of the AnalyticDB for MySQL cluster.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The type of the destination instance. Valid values:
            /// 
            /// *   **Redis**: ApsaraDB for Redis instance
            /// *   **RDS**: ApsaraDB RDS instance
            /// *   **PolarDB**: PolarDB for MySQL cluster or PolarDB O Edition cluster
            /// *   **ECS**: self-managed database that is hosted on ECS
            /// *   **Express**: self-managed database that is connected over Express Connect
            /// *   **DataHub**: DataHub project
            /// *   **MaxCompute**: MaxCompute project
            /// *   **AnalyticDB**: AnalyticDB for MySQL cluster V3.0 or V2.0
            /// *   **Greenplum**: AnalyticDB for PostgreSQL instance
            /// 
            /// >  The default value is **RDS**.
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// The password of the destination database account.
            /// 
            /// > 
            /// *   If the **DestinationEndpoint.InstanceType** parameter is set to **ECS**, **Express**, **dg**, or **cen**, you must specify the DestinationEndpoint.Password parameter.
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// The service port number of the destination database.
            /// 
            /// >  You must specify this parameter only if the **DestinationEndpoint.InstanceType** parameter is set to **ECS**, **Express**, **dg**, or **cen**.
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// The database account of the destination database.
            /// 
            /// > 
            /// *   The permissions that are required for database accounts vary with the synchronization scenario. For more information, see [Overview of data synchronization scenarios](~~140954~~).
            /// *   If the **DestinationEndpoint.InstanceType** parameter is set to **ECS**, **Express**, **dg**, or **cen**, you must specify the DestinationEndpoint.UserName parameter.
            /// *   If the **DestinationEndpoint.InstanceType** parameter is set to RDS and the database version is MySQL 5.5 or MySQL 5.6, you do not need to specify the DestinationEndpoint.UserName and **DestinationEndpoint.Password** parameters.
            /// *   If the **DestinationEndpoint.InstanceType** parameter is set to **Redis**, you do not need to specify the DestinationEndpoint.UserName parameter.
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

        }

        [NameInMap("PartitionKey")]
        [Validation(Required=false)]
        public ConfigureSynchronizationJobRequestPartitionKey PartitionKey { get; set; }
        public class ConfigureSynchronizationJobRequestPartitionKey : TeaModel {
            /// <summary>
            /// Specifies whether the incremental data table contains partitions defined by the modifytime_day field. Valid values: **true** and **false**.
            /// 
            /// >  This parameter is available only if the **DestinationEndpoint.InstanceType** parameter is set to **MaxCompute**.
            /// </summary>
            [NameInMap("ModifyTime_Day")]
            [Validation(Required=false)]
            public bool? ModifyTimeDay { get; set; }

            /// <summary>
            /// Specifies whether the incremental data table contains partitions defined by the modifytime_hour field. Valid values: **true** and **false**.
            /// 
            /// >  This parameter is available only if the **DestinationEndpoint.InstanceType** parameter is set to **MaxCompute**.
            /// </summary>
            [NameInMap("ModifyTime_Hour")]
            [Validation(Required=false)]
            public bool? ModifyTimeHour { get; set; }

            /// <summary>
            /// Specifies whether the incremental data table contains partitions defined by the modifytime_minute field. Valid values: **true** and **false**.
            /// 
            /// >  This parameter is available only if the **DestinationEndpoint.InstanceType** parameter is set to **MaxCompute**.
            /// </summary>
            [NameInMap("ModifyTime_Minute")]
            [Validation(Required=false)]
            public bool? ModifyTimeMinute { get; set; }

            /// <summary>
            /// Specifies whether the incremental data table contains partitions defined by the modifytime_month field. Valid values: **true** and **false**.
            /// 
            /// >  This parameter is available only if the **DestinationEndpoint.InstanceType** parameter is set to **MaxCompute**.
            /// </summary>
            [NameInMap("ModifyTime_Month")]
            [Validation(Required=false)]
            public bool? ModifyTimeMonth { get; set; }

            /// <summary>
            /// Specifies whether the incremental data table contains partitions defined by the modifytime_year field. Valid values: **true** and **false**.
            /// 
            /// >  This parameter is available only if the **DestinationEndpoint.InstanceType** parameter is set to **MaxCompute**.
            /// </summary>
            [NameInMap("ModifyTime_Year")]
            [Validation(Required=false)]
            public bool? ModifyTimeYear { get; set; }

        }

        [NameInMap("SourceEndpoint")]
        [Validation(Required=false)]
        public ConfigureSynchronizationJobRequestSourceEndpoint SourceEndpoint { get; set; }
        public class ConfigureSynchronizationJobRequestSourceEndpoint : TeaModel {
            /// <summary>
            /// The name of the database to which the synchronization object in the source instance belongs.
            /// </summary>
            [NameInMap("DatabaseName")]
            [Validation(Required=false)]
            public string DatabaseName { get; set; }

            /// <summary>
            /// The IP address of the source database.
            /// 
            /// >  You must specify this parameter only if the **SourceEndpoint.InstanceType** parameter is set to **ECS**, **Express**, **dg**, or **cen**.
            /// </summary>
            [NameInMap("IP")]
            [Validation(Required=false)]
            public string IP { get; set; }

            /// <summary>
            /// The ID of the source instance.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The type of the source instance. Valid values:
            /// 
            /// *   **RDS**: ApsaraDB RDS instance
            /// *   **Redis**: ApsaraDB for Redis instance
            /// *   **PolarDB**: PolarDB for MySQL cluster or PolarDB O Edition cluster
            /// *   **ECS**: self-managed database that is hosted on Elastic Compute Service (ECS)
            /// *   **Express**: self-managed database that is connected over Express Connect
            /// *   **dg**: self-managed database that is connected over Database Gateway
            /// *   **cen**: self-managed database that is connected over Cloud Enterprise Network (CEN)
            /// 
            /// >  The default value is **RDS**.
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account that owns the source RDS instance.
            /// 
            /// >  You can specify this parameter to synchronize data across different Alibaba Cloud accounts. In this case, you also need to specify the **SourceEndpoint.Role** parameter.
            /// </summary>
            [NameInMap("OwnerID")]
            [Validation(Required=false)]
            public string OwnerID { get; set; }

            /// <summary>
            /// The password of the source database account.
            /// 
            /// >  You must specify this parameter only if the **SourceEndpoint.InstanceType** parameter is set to **ECS**, **Express**, **dg**, or **cen**.
            /// </summary>
            [NameInMap("Password")]
            [Validation(Required=false)]
            public string Password { get; set; }

            /// <summary>
            /// The service port number of the source database.
            /// 
            /// >  You must specify this parameter only if the **SourceEndpoint.InstanceType** parameter is set to **ECS**, **Express**, **dg**, or **cen**.
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// The name of the RAM role configured for the Alibaba Cloud account that owns the source instance.
            /// 
            /// >  You must specify this parameter when you synchronize data across different Alibaba Cloud accounts. For information about the permissions and authorization methods of the RAM role, see [Configure RAM authorization for cross-account data migration and synchronization](~~48468~~).
            /// </summary>
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// The database account of the source database.
            /// 
            /// > 
            /// *   You must specify this parameter only if the **SourceEndpoint.InstanceType** parameter is set to **ECS**, **Express**, **dg**, or **cen**.
            /// *   If the **SourceEndpoint.InstanceType** parameter is set to **Redis**, you do not need to specify the database account.
            /// *   The permissions that are required for database accounts vary with the synchronization scenario. For more information, see [Overview of data synchronization scenarios](~~140954~~).
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
        /// The synchronization checkpoint.
        /// </summary>
        [NameInMap("Checkpoint")]
        [Validation(Required=false)]
        public string Checkpoint { get; set; }

        /// <summary>
        /// Specifies whether to perform initial full data synchronization. Valid values:
        /// 
        /// *   **true**: yes
        /// *   **false**: no
        /// 
        /// >  Default value: **true**.
        /// </summary>
        [NameInMap("DataInitialization")]
        [Validation(Required=false)]
        public bool? DataInitialization { get; set; }

        /// <summary>
        /// The reserved parameter of DTS. The value is a JSON string. You can specify this parameter to meet special requirements, for example, whether to automatically start a precheck. For more information, see [MigrationReserved](~~176470~~).
        /// 
        /// >  This parameter can be used for data synchronization between ApsaraDB for Redis Enterprise Edition instances. For more information, see [Use OpenAPI Explorer to configure one-way or two-way data synchronization between ApsaraDB for Redis Enterprise Edition instances](~~155967~~).
        /// </summary>
        [NameInMap("MigrationReserved")]
        [Validation(Required=false)]
        public string MigrationReserved { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// Specifies whether to perform initial schema synchronization. Valid values:
        /// 
        /// *   **true**: yes
        /// *   **false**: no
        /// 
        /// >  Default value: **true**.
        /// </summary>
        [NameInMap("StructureInitialization")]
        [Validation(Required=false)]
        public bool? StructureInitialization { get; set; }

        /// <summary>
        /// The synchronization direction. Valid values:
        /// 
        /// *   **Forward**
        /// *   **Reverse**
        /// 
        /// > 
        /// *   Default value: **Forward**.
        /// *   The value **Reverse** takes effect only if the topology of the data synchronization instance is two-way synchronization.
        /// </summary>
        [NameInMap("SynchronizationDirection")]
        [Validation(Required=false)]
        public string SynchronizationDirection { get; set; }

        /// <summary>
        /// The ID of the data synchronization instance. You can call the [DescribeSynchronizationJobs](~~49454~~) operation to query the instance ID.
        /// </summary>
        [NameInMap("SynchronizationJobId")]
        [Validation(Required=false)]
        public string SynchronizationJobId { get; set; }

        /// <summary>
        /// The name of the data synchronization task.
        /// 
        /// >  We recommend that you specify an informative name for easy identification. You do not need to use a unique task name.
        /// </summary>
        [NameInMap("SynchronizationJobName")]
        [Validation(Required=false)]
        public string SynchronizationJobName { get; set; }

        /// <summary>
        /// The objects that you want to synchronize. The value is a JSON string and can contain regular expressions. For more information, see [SynchronizationObjects](~~141901~~).
        /// </summary>
        [NameInMap("SynchronizationObjects")]
        [Validation(Required=false)]
        public string SynchronizationObjects { get; set; }

    }

}
