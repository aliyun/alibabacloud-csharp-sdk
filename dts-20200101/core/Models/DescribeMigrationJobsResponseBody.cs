// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeMigrationJobsResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code returned if the call failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InternalError</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the call failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The request processing has failed due to some unknown error.</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The list of data migration instances and the details of each instance.</para>
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
                /// <para>The details of full data migration.</para>
                /// </summary>
                [NameInMap("DataInitialization")]
                [Validation(Required=false)]
                public DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobDataInitialization DataInitialization { get; set; }
                public class DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobDataInitialization : TeaModel {
                    /// <summary>
                    /// <para>The error message returned if full data migration failed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>java.lang.NumberFormatException: For input string: &quot;&quot;</para>
                    /// </summary>
                    [NameInMap("ErrorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                    /// <summary>
                    /// <para>The migration progress. Unit: %.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("Percent")]
                    [Validation(Required=false)]
                    public string Percent { get; set; }

                    /// <summary>
                    /// <para>The number of records that have been migrated during full data migration.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>200001</para>
                    /// </summary>
                    [NameInMap("Progress")]
                    [Validation(Required=false)]
                    public string Progress { get; set; }

                    /// <summary>
                    /// <para>The status of full data migration. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>NotStarted</b>: Full data migration is not started.</description></item>
                    /// <item><description><b>Migrating</b>: Full data migration is in progress.</description></item>
                    /// <item><description><b>Failed</b>: Full data migration failed.</description></item>
                    /// <item><description><b>Finished</b>: Full data migration is completed.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Finished</para>
                    /// </summary>
                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

                /// <summary>
                /// <para>The details of incremental data migration.</para>
                /// </summary>
                [NameInMap("DataSynchronization")]
                [Validation(Required=false)]
                public DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobDataSynchronization DataSynchronization { get; set; }
                public class DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobDataSynchronization : TeaModel {
                    /// <summary>
                    /// <para>The latency of incremental data migration. Unit: seconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Delay")]
                    [Validation(Required=false)]
                    public string Delay { get; set; }

                    /// <summary>
                    /// <para>The error message returned if incremental data migration failed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Open: open \\\\?\\F:\\KINGDEE BACK\\AIS20221025151008_Data.mdf: The process cannot access the file because it is being used by another process.</para>
                    /// </summary>
                    [NameInMap("ErrorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                    /// <summary>
                    /// <para>The progress of incremental data migration. Unit: %.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>95</para>
                    /// </summary>
                    [NameInMap("Percent")]
                    [Validation(Required=false)]
                    public string Percent { get; set; }

                    /// <summary>
                    /// <para>The status of incremental data migration. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>NotStarted</b>: Incremental data migration is not started.</description></item>
                    /// <item><description><b>Migrating</b>: Incremental data migration is in progress.</description></item>
                    /// <item><description><b>Failed</b>: Incremental data migration failed.</description></item>
                    /// <item><description><b>Finished</b>: Incremental data migration is completed.</description></item>
                    /// <item><description><b>Catched</b>: Incremental data migration is not delayed.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Catched</para>
                    /// </summary>
                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

                /// <summary>
                /// <para>The connection settings of the destination instance.</para>
                /// </summary>
                [NameInMap("DestinationEndpoint")]
                [Validation(Required=false)]
                public DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobDestinationEndpoint DestinationEndpoint { get; set; }
                public class DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobDestinationEndpoint : TeaModel {
                    /// <summary>
                    /// <para>The name of the database to which the migration object in the destination instance belongs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dtstestdata</para>
                    /// </summary>
                    [NameInMap("DatabaseName")]
                    [Validation(Required=false)]
                    public string DatabaseName { get; set; }

                    /// <summary>
                    /// <para>The database type of the destination instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MySQL</para>
                    /// </summary>
                    [NameInMap("EngineName")]
                    [Validation(Required=false)]
                    public string EngineName { get; set; }

                    /// <summary>
                    /// <para>The endpoint of the destination instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>172.16.88.***</para>
                    /// </summary>
                    [NameInMap("IP")]
                    [Validation(Required=false)]
                    public string IP { get; set; }

                    /// <summary>
                    /// <para>The ID of the destination instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rm-bp1zc3iyqe3qw****</para>
                    /// </summary>
                    [NameInMap("InstanceID")]
                    [Validation(Required=false)]
                    public string InstanceID { get; set; }

                    /// <summary>
                    /// <para>The type of the destination instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>RDS</para>
                    /// </summary>
                    [NameInMap("InstanceType")]
                    [Validation(Required=false)]
                    public string InstanceType { get; set; }

                    /// <summary>
                    /// <para>This parameter is returned only if the database type of the destination instance is <b>Oracle</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>testsid</para>
                    /// </summary>
                    [NameInMap("OracleSID")]
                    [Validation(Required=false)]
                    public string OracleSID { get; set; }

                    /// <summary>
                    /// <para>The database service port of the destination instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3306</para>
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public string Port { get; set; }

                    /// <summary>
                    /// <para>The database account of the destination instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dtstest</para>
                    /// </summary>
                    [NameInMap("UserName")]
                    [Validation(Required=false)]
                    public string UserName { get; set; }

                }

                /// <summary>
                /// <para>The time when the data migration instance was created. The time is displayed in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-06-22T09:02:13Z</para>
                /// </summary>
                [NameInMap("InstanceCreateTime")]
                [Validation(Required=false)]
                public string InstanceCreateTime { get; set; }

                /// <summary>
                /// <para>The time when the data migration task was created. The time is displayed in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format in UTC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-06-22T08:53:55Z</para>
                /// </summary>
                [NameInMap("JobCreateTime")]
                [Validation(Required=false)]
                public string JobCreateTime { get; set; }

                /// <summary>
                /// <para>The specification of the data migration instance. Valid values: <b>small</b>, <b>medium</b>, <b>large</b>, <b>xlarge</b>, and <b>2xlarge</b>. For more information, see <a href="https://help.aliyun.com/document_detail/26606.html">Specifications of data migration instances</a>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2xlarge</para>
                /// </summary>
                [NameInMap("MigrationJobClass")]
                [Validation(Required=false)]
                public string MigrationJobClass { get; set; }

                /// <summary>
                /// <para>The ID of the data migration instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dtson2z28evm33****</para>
                /// </summary>
                [NameInMap("MigrationJobID")]
                [Validation(Required=false)]
                public string MigrationJobID { get; set; }

                /// <summary>
                /// <para>The name of the data migration task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dtstest</para>
                /// </summary>
                [NameInMap("MigrationJobName")]
                [Validation(Required=false)]
                public string MigrationJobName { get; set; }

                /// <summary>
                /// <para>The status of the data migration task. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>NotStarted</b>: The task is not started.</description></item>
                /// <item><description><b>Prechecking</b>: The task is being prechecked.</description></item>
                /// <item><description><b>PrecheckFailed</b>: The task failed to pass the precheck.</description></item>
                /// <item><description><b>Migrating</b>: The task is migrating data.</description></item>
                /// <item><description><b>Suspending</b>: The task is paused.</description></item>
                /// <item><description><b>MigrationFailed</b>: The task failed to migrate data.</description></item>
                /// <item><description><b>Finished</b>: The task is completed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Migrating</para>
                /// </summary>
                [NameInMap("MigrationJobStatus")]
                [Validation(Required=false)]
                public string MigrationJobStatus { get; set; }

                /// <summary>
                /// <para>The migration types.</para>
                /// </summary>
                [NameInMap("MigrationMode")]
                [Validation(Required=false)]
                public DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobMigrationMode MigrationMode { get; set; }
                public class DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobMigrationMode : TeaModel {
                    /// <summary>
                    /// <para>Indicates whether full data migration is performed. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b>: yes</description></item>
                    /// <item><description><b>false</b>: no</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("DataInitialization")]
                    [Validation(Required=false)]
                    public bool? DataInitialization { get; set; }

                    /// <summary>
                    /// <para>Indicates whether incremental data migration is performed. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b>: yes</description></item>
                    /// <item><description><b>false</b>: no</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("DataSynchronization")]
                    [Validation(Required=false)]
                    public bool? DataSynchronization { get; set; }

                    /// <summary>
                    /// <para>Indicates whether schema migration is performed. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>true</b>: yes</description></item>
                    /// <item><description><b>false</b>: no</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("StructureInitialization")]
                    [Validation(Required=false)]
                    public bool? StructureInitialization { get; set; }

                }

                /// <summary>
                /// <para>The objects that are migrated by the task.</para>
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
                        /// <para>The name of the database to which the migration object in the source instance belongs.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>dtstestdata</para>
                        /// </summary>
                        [NameInMap("DatabaseName")]
                        [Validation(Required=false)]
                        public string DatabaseName { get; set; }

                        /// <summary>
                        /// <para>The names of the migrated tables.</para>
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
                        /// <para>Indicates whether an entire database is migrated. Valid values:</para>
                        /// <list type="bullet">
                        /// <item><description><b>true</b>: yes</description></item>
                        /// <item><description><b>false</b>: no</description></item>
                        /// </list>
                        /// 
                        /// <b>Example:</b>
                        /// <para>false</para>
                        /// </summary>
                        [NameInMap("WholeDatabase")]
                        [Validation(Required=false)]
                        public string WholeDatabase { get; set; }

                    }

                }

                /// <summary>
                /// <para>The billing method of the data migration instance. The value is <b>PostPaid</b> (pay-as-you-go).</para>
                /// 
                /// <b>Example:</b>
                /// <para>PostPaid</para>
                /// </summary>
                [NameInMap("PayType")]
                [Validation(Required=false)]
                public string PayType { get; set; }

                /// <summary>
                /// <para>The precheck details.</para>
                /// </summary>
                [NameInMap("Precheck")]
                [Validation(Required=false)]
                public DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobPrecheck Precheck { get; set; }
                public class DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobPrecheck : TeaModel {
                    /// <summary>
                    /// <para>The precheck progress. Unit: %.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("Percent")]
                    [Validation(Required=false)]
                    public string Percent { get; set; }

                    /// <summary>
                    /// <para>The precheck result. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>Success</b>: The task passed the precheck.</description></item>
                    /// <item><description><b>Failed</b>: The task failed to pass the precheck.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Success</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

                /// <summary>
                /// <para>The connection settings of the source instance.</para>
                /// </summary>
                [NameInMap("SourceEndpoint")]
                [Validation(Required=false)]
                public DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobSourceEndpoint SourceEndpoint { get; set; }
                public class DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobSourceEndpoint : TeaModel {
                    /// <summary>
                    /// <para>The name of the database to which the migration object in the source instance belongs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dtstestdata</para>
                    /// </summary>
                    [NameInMap("DatabaseName")]
                    [Validation(Required=false)]
                    public string DatabaseName { get; set; }

                    /// <summary>
                    /// <para>The database type of the source instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MySQL</para>
                    /// </summary>
                    [NameInMap("EngineName")]
                    [Validation(Required=false)]
                    public string EngineName { get; set; }

                    /// <summary>
                    /// <para>The endpoint of the source instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>172.16.88.***</para>
                    /// </summary>
                    [NameInMap("IP")]
                    [Validation(Required=false)]
                    public string IP { get; set; }

                    /// <summary>
                    /// <para>The ID of the source instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>rm-bp1i99e8l7913****</para>
                    /// </summary>
                    [NameInMap("InstanceID")]
                    [Validation(Required=false)]
                    public string InstanceID { get; set; }

                    /// <summary>
                    /// <para>The type of the source instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>RDS</para>
                    /// </summary>
                    [NameInMap("InstanceType")]
                    [Validation(Required=false)]
                    public string InstanceType { get; set; }

                    /// <summary>
                    /// <para>This parameter is returned only if the database type of the source instance is <b>Oracle</b>.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>testsid</para>
                    /// </summary>
                    [NameInMap("OracleSID")]
                    [Validation(Required=false)]
                    public string OracleSID { get; set; }

                    /// <summary>
                    /// <para>The database service port of the source instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3306</para>
                    /// </summary>
                    [NameInMap("Port")]
                    [Validation(Required=false)]
                    public string Port { get; set; }

                    /// <summary>
                    /// <para>The database account of the source instance.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dtstest</para>
                    /// </summary>
                    [NameInMap("UserName")]
                    [Validation(Required=false)]
                    public string UserName { get; set; }

                }

                /// <summary>
                /// <para>The details of schema migration.</para>
                /// </summary>
                [NameInMap("StructureInitialization")]
                [Validation(Required=false)]
                public DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobStructureInitialization StructureInitialization { get; set; }
                public class DescribeMigrationJobsResponseBodyMigrationJobsMigrationJobStructureInitialization : TeaModel {
                    /// <summary>
                    /// <para>The error message returned if schema migration failed.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>DTS-1020042 Execute sql error sql: ERROR: type &quot;geometry&quot; does not exist;</para>
                    /// </summary>
                    [NameInMap("ErrorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                    /// <summary>
                    /// <para>The progress of schema migration. Unit: %.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100</para>
                    /// </summary>
                    [NameInMap("Percent")]
                    [Validation(Required=false)]
                    public string Percent { get; set; }

                    /// <summary>
                    /// <para>The number of tables whose schemas have been migrated.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Progress")]
                    [Validation(Required=false)]
                    public string Progress { get; set; }

                    /// <summary>
                    /// <para>The status of schema migration. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>NotStarted</b>: Schema migration is not started.</description></item>
                    /// <item><description><b>Migrating</b>: Schema migration is in progress.</description></item>
                    /// <item><description><b>Failed</b>: Schema migration failed.</description></item>
                    /// <item><description><b>Finished</b>: Schema migration is completed.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Finished</para>
                    /// </summary>
                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

                /// <summary>
                /// <para>The collection of tags.</para>
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
                        /// <para>The tag key.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>testkey1</para>
                        /// </summary>
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        /// <summary>
                        /// <para>The tag value that corresponds to the tag key.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>testvalue1</para>
                        /// </summary>
                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The maximum number of entries that can be displayed on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0ED4846D-ED60-435D-88C0-7EC0CE4D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// <para>The total number of data migration instances that belong to your Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public long? TotalRecordCount { get; set; }

    }

}
