// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeMigrationJobStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The status of full data migration.</para>
        /// </summary>
        [NameInMap("DataInitializationStatus")]
        [Validation(Required=false)]
        public DescribeMigrationJobStatusResponseBodyDataInitializationStatus DataInitializationStatus { get; set; }
        public class DescribeMigrationJobStatusResponseBodyDataInitializationStatus : TeaModel {
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
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The status of incremental data migration.</para>
        /// </summary>
        [NameInMap("DataSynchronizationStatus")]
        [Validation(Required=false)]
        public DescribeMigrationJobStatusResponseBodyDataSynchronizationStatus DataSynchronizationStatus { get; set; }
        public class DescribeMigrationJobStatusResponseBodyDataSynchronizationStatus : TeaModel {
            /// <summary>
            /// <para>The UNIX timestamp generated when the latest incremental data is migrated. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1612507847</para>
            /// </summary>
            [NameInMap("Checkpoint")]
            [Validation(Required=false)]
            public string Checkpoint { get; set; }

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
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The connection settings of the destination instance.</para>
        /// </summary>
        [NameInMap("DestinationEndpoint")]
        [Validation(Required=false)]
        public DescribeMigrationJobStatusResponseBodyDestinationEndpoint DestinationEndpoint { get; set; }
        public class DescribeMigrationJobStatusResponseBodyDestinationEndpoint : TeaModel {
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
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

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

            /// <summary>
            /// <para>The system ID (SID) of the Oracle database.</para>
            /// <remarks>
            /// <para> This parameter is returned only if the database type of the destination instance is <b>Oracle</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>testsid</para>
            /// </summary>
            [NameInMap("oracleSID")]
            [Validation(Required=false)]
            public string OracleSID { get; set; }

        }

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
        /// <para>dtsz2v12jfo309****</para>
        /// </summary>
        [NameInMap("MigrationJobId")]
        [Validation(Required=false)]
        public string MigrationJobId { get; set; }

        /// <summary>
        /// <para>The name of the data migration task.</para>
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
        public DescribeMigrationJobStatusResponseBodyMigrationMode MigrationMode { get; set; }
        public class DescribeMigrationJobStatusResponseBodyMigrationMode : TeaModel {
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
            [NameInMap("dataInitialization")]
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
            [NameInMap("dataSynchronization")]
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
            [NameInMap("structureInitialization")]
            [Validation(Required=false)]
            public bool? StructureInitialization { get; set; }

        }

        /// <summary>
        /// <para>The objects that are migrated by the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;DBName\&quot;:\&quot;dtstestdata\&quot;,\&quot;TableIncludes\&quot;:[{\&quot;TableName\&quot;:\&quot;customer\&quot;}]}]</para>
        /// </summary>
        [NameInMap("MigrationObject")]
        [Validation(Required=false)]
        public string MigrationObject { get; set; }

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
        [NameInMap("PrecheckStatus")]
        [Validation(Required=false)]
        public DescribeMigrationJobStatusResponseBodyPrecheckStatus PrecheckStatus { get; set; }
        public class DescribeMigrationJobStatusResponseBodyPrecheckStatus : TeaModel {
            /// <summary>
            /// <para>The result of each precheck item.</para>
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
                    /// <para>The precheck result. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>Success</b>: The task passed the precheck.</description></item>
                    /// <item><description><b>Failed</b>: The task failed to pass the precheck.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Success</para>
                    /// </summary>
                    [NameInMap("CheckStatus")]
                    [Validation(Required=false)]
                    public string CheckStatus { get; set; }

                    /// <summary>
                    /// <para>The error message returned if the task failed to pass the precheck.</para>
                    /// <remarks>
                    /// <para> This parameter is returned only if the return value of the <b>CheckStatus</b> parameter is <b>Failed</b>.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Original error: Access denied for user \&quot;dtstest\&quot;@\&quot;100.104.***.**\&quot; (using password: YES)</para>
                    /// </summary>
                    [NameInMap("ErrorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                    /// <summary>
                    /// <para>The name of the precheck item.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CHECK_CONN_SRC</para>
                    /// </summary>
                    [NameInMap("ItemName")]
                    [Validation(Required=false)]
                    public string ItemName { get; set; }

                    /// <summary>
                    /// <para>The method to fix the precheck failure.</para>
                    /// <remarks>
                    /// <para> This parameter is returned only if the return value of the <b>CheckStatus</b> parameter is <b>Failed</b>.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CHECK_ERROR_DEST_CONN_REPAIR2</para>
                    /// </summary>
                    [NameInMap("RepairMethod")]
                    [Validation(Required=false)]
                    public string RepairMethod { get; set; }

                }

            }

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
            /// <para>The precheck status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>NotStarted</b></description></item>
            /// <item><description><b>Suspending</b>:</description></item>
            /// <item><description><b>Checking</b></description></item>
            /// <item><description><b>Failed</b></description></item>
            /// <item><description><b>Finished</b></description></item>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A032E3B4-929B-48E9-97B9-37587CBF****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The connection settings of the source instance.</para>
        /// </summary>
        [NameInMap("SourceEndpoint")]
        [Validation(Required=false)]
        public DescribeMigrationJobStatusResponseBodySourceEndpoint SourceEndpoint { get; set; }
        public class DescribeMigrationJobStatusResponseBodySourceEndpoint : TeaModel {
            /// <summary>
            /// <para>The name of the database to which the migration object in the source instance belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dtstestdatabase</para>
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
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The type of the source instance.</para>
            /// <list type="bullet">
            /// <item><description><b>RDS</b>: ApsaraDB RDS instance</description></item>
            /// <item><description><b>ECS</b>: self-managed database that is hosted on Elastic Compute Service (ECS)</description></item>
            /// <item><description><b>LocalInstance</b>: self-managed database with a public IP address</description></item>
            /// <item><description><b>Express</b>: self-managed database that is connected over Express Connect, VPN Gateway, or Smart Access Gateway</description></item>
            /// <item><description><b>MongoDB</b>: ApsaraDB for MongoDB instance</description></item>
            /// <item><description><b>POLARDB</b>: PolarDB for MySQL cluster (available only for the China site)</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RDS</para>
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

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

            /// <summary>
            /// <para>The SID of the Oracle database.</para>
            /// <remarks>
            /// <para> This parameter is returned only if the database type of the source instance is <b>Oracle</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>dtstestdatabase</para>
            /// </summary>
            [NameInMap("oracleSID")]
            [Validation(Required=false)]
            public string OracleSID { get; set; }

        }

        /// <summary>
        /// <para>The status of schema migration.</para>
        /// </summary>
        [NameInMap("StructureInitializationStatus")]
        [Validation(Required=false)]
        public DescribeMigrationJobStatusResponseBodyStructureInitializationStatus StructureInitializationStatus { get; set; }
        public class DescribeMigrationJobStatusResponseBodyStructureInitializationStatus : TeaModel {
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
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

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
        /// <b>Example:</b>
        /// <para>z2v12jfo309****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
