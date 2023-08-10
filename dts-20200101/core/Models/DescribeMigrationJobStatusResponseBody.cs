// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeMigrationJobStatusResponseBody : TeaModel {
        /// <summary>
        /// The status of full data migration.
        /// </summary>
        [NameInMap("DataInitializationStatus")]
        [Validation(Required=false)]
        public DescribeMigrationJobStatusResponseBodyDataInitializationStatus DataInitializationStatus { get; set; }
        public class DescribeMigrationJobStatusResponseBodyDataInitializationStatus : TeaModel {
            /// <summary>
            /// The error message returned if full data migration failed.
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// The migration progress. Unit: %.
            /// </summary>
            [NameInMap("Percent")]
            [Validation(Required=false)]
            public string Percent { get; set; }

            /// <summary>
            /// The number of records that have been migrated during full data migration.
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            /// <summary>
            /// The status of full data migration. Valid values:
            /// 
            /// *   **NotStarted**: Full data migration is not started.
            /// *   **Migrating**: Full data migration is in progress.
            /// *   **Failed**: Full data migration failed.
            /// *   **Finished**: Full data migration is completed.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The status of incremental data migration.
        /// </summary>
        [NameInMap("DataSynchronizationStatus")]
        [Validation(Required=false)]
        public DescribeMigrationJobStatusResponseBodyDataSynchronizationStatus DataSynchronizationStatus { get; set; }
        public class DescribeMigrationJobStatusResponseBodyDataSynchronizationStatus : TeaModel {
            /// <summary>
            /// The UNIX timestamp generated when the latest incremental data is migrated. Unit: seconds.
            /// </summary>
            [NameInMap("Checkpoint")]
            [Validation(Required=false)]
            public string Checkpoint { get; set; }

            /// <summary>
            /// The latency of incremental data migration. Unit: seconds.
            /// </summary>
            [NameInMap("Delay")]
            [Validation(Required=false)]
            public string Delay { get; set; }

            /// <summary>
            /// The error message returned if incremental data migration failed.
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// The progress of incremental data migration. Unit: %.
            /// </summary>
            [NameInMap("Percent")]
            [Validation(Required=false)]
            public string Percent { get; set; }

            /// <summary>
            /// The status of incremental data migration. Valid values:
            /// 
            /// *   **NotStarted**: Incremental data migration is not started.
            /// *   **Migrating**: Incremental data migration is in progress.
            /// *   **Failed**: Incremental data migration failed.
            /// *   **Finished**: Incremental data migration is completed.
            /// *   **Catched**: Incremental data migration is not delayed.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The connection settings of the destination instance.
        /// </summary>
        [NameInMap("DestinationEndpoint")]
        [Validation(Required=false)]
        public DescribeMigrationJobStatusResponseBodyDestinationEndpoint DestinationEndpoint { get; set; }
        public class DescribeMigrationJobStatusResponseBodyDestinationEndpoint : TeaModel {
            /// <summary>
            /// The name of the database to which the migration object in the destination instance belongs.
            /// </summary>
            [NameInMap("DatabaseName")]
            [Validation(Required=false)]
            public string DatabaseName { get; set; }

            /// <summary>
            /// The database type of the destination instance.
            /// </summary>
            [NameInMap("EngineName")]
            [Validation(Required=false)]
            public string EngineName { get; set; }

            /// <summary>
            /// The endpoint of the destination instance.
            /// </summary>
            [NameInMap("IP")]
            [Validation(Required=false)]
            public string IP { get; set; }

            /// <summary>
            /// The ID of the destination instance.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The type of the destination instance.
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// The database service port of the destination instance.
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// The database account of the destination instance.
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            /// <summary>
            /// The system ID (SID) of the Oracle database.
            /// 
            /// >  This parameter is returned only if the database type of the destination instance is **Oracle**.
            /// </summary>
            [NameInMap("oracleSID")]
            [Validation(Required=false)]
            public string OracleSID { get; set; }

        }

        /// <summary>
        /// The error code returned if the call failed.
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// The error message returned if the call failed.
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// The specification of the data migration instance. Valid values: **small**, **medium**, **large**, **xlarge**, and **2xlarge**. For more information, see [Specifications of data migration instances](~~26606~~).
        /// </summary>
        [NameInMap("MigrationJobClass")]
        [Validation(Required=false)]
        public string MigrationJobClass { get; set; }

        /// <summary>
        /// The ID of the data migration instance.
        /// </summary>
        [NameInMap("MigrationJobId")]
        [Validation(Required=false)]
        public string MigrationJobId { get; set; }

        /// <summary>
        /// The name of the data migration task.
        /// </summary>
        [NameInMap("MigrationJobName")]
        [Validation(Required=false)]
        public string MigrationJobName { get; set; }

        /// <summary>
        /// The status of the data migration task. Valid values:
        /// 
        /// *   **NotStarted**: The task is not started.
        /// *   **Prechecking**: The task is being prechecked.
        /// *   **PrecheckFailed**: The task failed to pass the precheck.
        /// *   **Migrating**: The task is migrating data.
        /// *   **Suspending**: The task is paused.
        /// *   **MigrationFailed**: The task failed to migrate data.
        /// *   **Finished**: The task is completed.
        /// </summary>
        [NameInMap("MigrationJobStatus")]
        [Validation(Required=false)]
        public string MigrationJobStatus { get; set; }

        /// <summary>
        /// The migration types.
        /// </summary>
        [NameInMap("MigrationMode")]
        [Validation(Required=false)]
        public DescribeMigrationJobStatusResponseBodyMigrationMode MigrationMode { get; set; }
        public class DescribeMigrationJobStatusResponseBodyMigrationMode : TeaModel {
            /// <summary>
            /// Indicates whether full data migration is performed. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false**: no
            /// </summary>
            [NameInMap("dataInitialization")]
            [Validation(Required=false)]
            public bool? DataInitialization { get; set; }

            /// <summary>
            /// Indicates whether incremental data migration is performed. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false**: no
            /// </summary>
            [NameInMap("dataSynchronization")]
            [Validation(Required=false)]
            public bool? DataSynchronization { get; set; }

            /// <summary>
            /// Indicates whether schema migration is performed. Valid values:
            /// 
            /// *   **true**: yes
            /// *   **false**: no
            /// </summary>
            [NameInMap("structureInitialization")]
            [Validation(Required=false)]
            public bool? StructureInitialization { get; set; }

        }

        /// <summary>
        /// The objects that are migrated by the task.
        /// </summary>
        [NameInMap("MigrationObject")]
        [Validation(Required=false)]
        public string MigrationObject { get; set; }

        /// <summary>
        /// The billing method of the data migration instance. The value is **PostPaid** (pay-as-you-go).
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// The precheck details.
        /// </summary>
        [NameInMap("PrecheckStatus")]
        [Validation(Required=false)]
        public DescribeMigrationJobStatusResponseBodyPrecheckStatus PrecheckStatus { get; set; }
        public class DescribeMigrationJobStatusResponseBodyPrecheckStatus : TeaModel {
            /// <summary>
            /// The result of each precheck item.
            /// </summary>
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public DescribeMigrationJobStatusResponseBodyPrecheckStatusDetail Detail { get; set; }
            public class DescribeMigrationJobStatusResponseBodyPrecheckStatusDetail : TeaModel {
                [NameInMap("CheckItem")]
                [Validation(Required=false)]
                public List<DescribeMigrationJobStatusResponseBodyPrecheckStatusDetailCheckItem> CheckItem { get; set; }
                public class DescribeMigrationJobStatusResponseBodyPrecheckStatusDetailCheckItem : TeaModel {
                    /// <summary>
                    /// The precheck result. Valid values:
                    /// 
                    /// *   **Success**: The task passed the precheck.
                    /// *   **Failed**: The task failed to pass the precheck.
                    /// </summary>
                    [NameInMap("CheckStatus")]
                    [Validation(Required=false)]
                    public string CheckStatus { get; set; }

                    /// <summary>
                    /// The error message returned if the task failed to pass the precheck.
                    /// 
                    /// >  This parameter is returned only if the return value of the **CheckStatus** parameter is **Failed**.
                    /// </summary>
                    [NameInMap("ErrorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                    /// <summary>
                    /// The name of the precheck item.
                    /// </summary>
                    [NameInMap("ItemName")]
                    [Validation(Required=false)]
                    public string ItemName { get; set; }

                    /// <summary>
                    /// The method to fix the precheck failure.
                    /// 
                    /// >  This parameter is returned only if the return value of the **CheckStatus** parameter is **Failed**.
                    /// </summary>
                    [NameInMap("RepairMethod")]
                    [Validation(Required=false)]
                    public string RepairMethod { get; set; }

                }

            }

            /// <summary>
            /// The precheck progress. Unit: %.
            /// </summary>
            [NameInMap("Percent")]
            [Validation(Required=false)]
            public string Percent { get; set; }

            /// <summary>
            /// The precheck status. Valid values:
            /// 
            /// *   **NotStarted**
            /// *   **Suspending**:
            /// *   **Checking**
            /// *   **Failed**
            /// *   **Finished**
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The connection settings of the source instance.
        /// </summary>
        [NameInMap("SourceEndpoint")]
        [Validation(Required=false)]
        public DescribeMigrationJobStatusResponseBodySourceEndpoint SourceEndpoint { get; set; }
        public class DescribeMigrationJobStatusResponseBodySourceEndpoint : TeaModel {
            /// <summary>
            /// The name of the database to which the migration object in the source instance belongs.
            /// </summary>
            [NameInMap("DatabaseName")]
            [Validation(Required=false)]
            public string DatabaseName { get; set; }

            /// <summary>
            /// The database type of the source instance.
            /// </summary>
            [NameInMap("EngineName")]
            [Validation(Required=false)]
            public string EngineName { get; set; }

            /// <summary>
            /// The endpoint of the source instance.
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
            /// The type of the source instance.
            /// 
            /// *   **RDS**: ApsaraDB RDS instance
            /// *   **ECS**: self-managed database that is hosted on Elastic Compute Service (ECS)
            /// *   **LocalInstance**: self-managed database with a public IP address
            /// *   **Express**: self-managed database that is connected over Express Connect, VPN Gateway, or Smart Access Gateway
            /// *   **MongoDB**: ApsaraDB for MongoDB instance
            /// *   **POLARDB**: PolarDB for MySQL cluster (available only for the China site)
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// The database service port of the source instance.
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public string Port { get; set; }

            /// <summary>
            /// The database account of the source instance.
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            /// <summary>
            /// The SID of the Oracle database.
            /// 
            /// >  This parameter is returned only if the database type of the source instance is **Oracle**.
            /// </summary>
            [NameInMap("oracleSID")]
            [Validation(Required=false)]
            public string OracleSID { get; set; }

        }

        /// <summary>
        /// The status of schema migration.
        /// </summary>
        [NameInMap("StructureInitializationStatus")]
        [Validation(Required=false)]
        public DescribeMigrationJobStatusResponseBodyStructureInitializationStatus StructureInitializationStatus { get; set; }
        public class DescribeMigrationJobStatusResponseBodyStructureInitializationStatus : TeaModel {
            /// <summary>
            /// The error message returned if schema migration failed.
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// The progress of schema migration. Unit: %.
            /// </summary>
            [NameInMap("Percent")]
            [Validation(Required=false)]
            public string Percent { get; set; }

            /// <summary>
            /// The number of tables whose schemas have been migrated.
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            /// <summary>
            /// The status of schema migration. Valid values:
            /// 
            /// *   **NotStarted**: Schema migration is not started.
            /// *   **Migrating**: Schema migration is in progress.
            /// *   **Failed**: Schema migration failed.
            /// *   **Finished**: Schema migration is completed.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// Indicates whether the call was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
