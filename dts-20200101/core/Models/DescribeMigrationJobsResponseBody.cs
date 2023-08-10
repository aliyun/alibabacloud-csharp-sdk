// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeMigrationJobsResponseBody : TeaModel {
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
        /// The list of data migration instances and the details of each instance.
        /// </summary>
        [NameInMap("MigrationJobs")]
        [Validation(Required=false)]
        public DescribeMigrationJobsResponseBodyMigrationJobs MigrationJobs { get; set; }
        public class DescribeMigrationJobsResponseBodyMigrationJobs : TeaModel {
            [NameInMap("MigrationJob")]
            [Validation(Required=false)]
            public List<DescribeMigrationJobsResponseBodyMigrationJobsMigrationJob> MigrationJob { get; set; }
            public class DescribeMigrationJobsResponseBodyMigrationJobsMigrationJob : TeaModel {
                /// <summary>
                /// The details of full data migration.
                /// </summary>
                [NameInMap("DataInitialization")]
                [Validation(Required=false)]
                public DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobDataInitialization DataInitialization { get; set; }
                public class DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobDataInitialization : TeaModel {
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
                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

                /// <summary>
                /// The details of incremental data migration.
                /// </summary>
                [NameInMap("DataSynchronization")]
                [Validation(Required=false)]
                public DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobDataSynchronization DataSynchronization { get; set; }
                public class DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobDataSynchronization : TeaModel {
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
                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

                /// <summary>
                /// The connection settings of the destination instance.
                /// </summary>
                [NameInMap("DestinationEndpoint")]
                [Validation(Required=false)]
                public DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobDestinationEndpoint DestinationEndpoint { get; set; }
                public class DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobDestinationEndpoint : TeaModel {
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
                    [NameInMap("InstanceID")]
                    [Validation(Required=false)]
                    public string InstanceID { get; set; }

                    /// <summary>
                    /// The type of the destination instance.
                    /// </summary>
                    [NameInMap("InstanceType")]
                    [Validation(Required=false)]
                    public string InstanceType { get; set; }

                    /// <summary>
                    /// This parameter is returned only if the database type of the destination instance is **Oracle**.
                    /// </summary>
                    [NameInMap("OracleSID")]
                    [Validation(Required=false)]
                    public string OracleSID { get; set; }

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

                }

                /// <summary>
                /// The time when the data migration instance was created. The time is displayed in the *yyyy-MM-dd*T*HH:mm:ss*Z format in UTC.
                /// </summary>
                [NameInMap("InstanceCreateTime")]
                [Validation(Required=false)]
                public string InstanceCreateTime { get; set; }

                /// <summary>
                /// The time when the data migration task was created. The time is displayed in the *yyyy-MM-dd*T*HH:mm:ss*Z format in UTC.
                /// </summary>
                [NameInMap("JobCreateTime")]
                [Validation(Required=false)]
                public string JobCreateTime { get; set; }

                /// <summary>
                /// The specification of the data migration instance. Valid values: **small**, **medium**, **large**, **xlarge**, and **2xlarge**. For more information, see [Specifications of data migration instances](~~26606~~).
                /// </summary>
                [NameInMap("MigrationJobClass")]
                [Validation(Required=false)]
                public string MigrationJobClass { get; set; }

                /// <summary>
                /// The ID of the data migration instance.
                /// </summary>
                [NameInMap("MigrationJobID")]
                [Validation(Required=false)]
                public string MigrationJobID { get; set; }

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
                public DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobMigrationMode MigrationMode { get; set; }
                public class DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobMigrationMode : TeaModel {
                    /// <summary>
                    /// Indicates whether full data migration is performed. Valid values:
                    /// 
                    /// *   **true**: yes
                    /// *   **false**: no
                    /// </summary>
                    [NameInMap("DataInitialization")]
                    [Validation(Required=false)]
                    public bool? DataInitialization { get; set; }

                    /// <summary>
                    /// Indicates whether incremental data migration is performed. Valid values:
                    /// 
                    /// *   **true**: yes
                    /// *   **false**: no
                    /// </summary>
                    [NameInMap("DataSynchronization")]
                    [Validation(Required=false)]
                    public bool? DataSynchronization { get; set; }

                    /// <summary>
                    /// Indicates whether schema migration is performed. Valid values:
                    /// 
                    /// *   **true**: yes
                    /// *   **false**: no
                    /// </summary>
                    [NameInMap("StructureInitialization")]
                    [Validation(Required=false)]
                    public bool? StructureInitialization { get; set; }

                }

                /// <summary>
                /// The objects that are migrated by the task.
                /// </summary>
                [NameInMap("MigrationObject")]
                [Validation(Required=false)]
                public DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobMigrationObject MigrationObject { get; set; }
                public class DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobMigrationObject : TeaModel {
                    [NameInMap("SynchronousObject")]
                    [Validation(Required=false)]
                    public List<DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobMigrationObjectSynchronousObject> SynchronousObject { get; set; }
                    public class DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobMigrationObjectSynchronousObject : TeaModel {
                        /// <summary>
                        /// The name of the database to which the migration object in the source instance belongs.
                        /// </summary>
                        [NameInMap("DatabaseName")]
                        [Validation(Required=false)]
                        public string DatabaseName { get; set; }

                        /// <summary>
                        /// The names of the migrated tables.
                        /// </summary>
                        [NameInMap("TableList")]
                        [Validation(Required=false)]
                        public DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobMigrationObjectSynchronousObjectTableList TableList { get; set; }
                        public class DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobMigrationObjectSynchronousObjectTableList : TeaModel {
                            [NameInMap("Table")]
                            [Validation(Required=false)]
                            public List<string> Table { get; set; }

                        }

                        /// <summary>
                        /// Indicates whether an entire database is migrated. Valid values:
                        /// 
                        /// *   **true**: yes
                        /// *   **false**: no
                        /// </summary>
                        [NameInMap("WholeDatabase")]
                        [Validation(Required=false)]
                        public string WholeDatabase { get; set; }

                    }

                }

                /// <summary>
                /// The billing method of the data migration instance. The value is **PostPaid** (pay-as-you-go).
                /// </summary>
                [NameInMap("PayType")]
                [Validation(Required=false)]
                public string PayType { get; set; }

                /// <summary>
                /// The precheck details.
                /// </summary>
                [NameInMap("Precheck")]
                [Validation(Required=false)]
                public DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobPrecheck Precheck { get; set; }
                public class DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobPrecheck : TeaModel {
                    /// <summary>
                    /// The precheck progress. Unit: %.
                    /// </summary>
                    [NameInMap("Percent")]
                    [Validation(Required=false)]
                    public string Percent { get; set; }

                    /// <summary>
                    /// The precheck result. Valid values:
                    /// 
                    /// *   **Success**: The task passed the precheck.
                    /// *   **Failed**: The task failed to pass the precheck.
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

                /// <summary>
                /// The connection settings of the source instance.
                /// </summary>
                [NameInMap("SourceEndpoint")]
                [Validation(Required=false)]
                public DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobSourceEndpoint SourceEndpoint { get; set; }
                public class DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobSourceEndpoint : TeaModel {
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
                    [NameInMap("InstanceID")]
                    [Validation(Required=false)]
                    public string InstanceID { get; set; }

                    /// <summary>
                    /// The type of the source instance.
                    /// </summary>
                    [NameInMap("InstanceType")]
                    [Validation(Required=false)]
                    public string InstanceType { get; set; }

                    /// <summary>
                    /// This parameter is returned only if the database type of the source instance is **Oracle**.
                    /// </summary>
                    [NameInMap("OracleSID")]
                    [Validation(Required=false)]
                    public string OracleSID { get; set; }

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

                }

                /// <summary>
                /// The details of schema migration.
                /// </summary>
                [NameInMap("StructureInitialization")]
                [Validation(Required=false)]
                public DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobStructureInitialization StructureInitialization { get; set; }
                public class DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobStructureInitialization : TeaModel {
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
                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

                /// <summary>
                /// The collection of tags.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobTags Tags { get; set; }
                public class DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobTagsTag> Tag { get; set; }
                    public class DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobTagsTag : TeaModel {
                        /// <summary>
                        /// The tag key.
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// The tag value that corresponds to the tag key.
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The maximum number of entries that can be displayed on the current page.
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the call was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// The total number of data migration instances that belong to your Alibaba Cloud account.
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public long? TotalRecordCount { get; set; }

    }

}
