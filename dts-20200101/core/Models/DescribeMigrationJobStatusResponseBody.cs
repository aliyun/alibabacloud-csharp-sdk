// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeMigrationJobStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The execution status of full data migration.</para>
        /// </summary>
        [NameInMap("DataInitializationStatus")]
        [Validation(Required=false)]
        public DescribeMigrationJobStatusResponseBodyDataInitializationStatus DataInitializationStatus { get; set; }
        public class DescribeMigrationJobStatusResponseBodyDataInitializationStatus : TeaModel {
            /// <summary>
            /// <para>The error message returned when full data migration failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>java.lang.NumberFormatException: For input string: &quot;&quot;</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The progress of full data migration, in percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Percent")]
            [Validation(Required=false)]
            public string Percent { get; set; }

            /// <summary>
            /// <para>The number of records that have been migrated during initial full data synchronization.</para>
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
            /// <item><description><b>NotStarted</b>: not started.</description></item>
            /// <item><description><b>Migrating</b>: migrating.</description></item>
            /// <item><description><b>Failed</b>: migration failed.</description></item>
            /// <item><description><b>Finished</b>: migration completed.</description></item>
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
        /// <para>The execution status of incremental data migration.</para>
        /// </summary>
        [NameInMap("DataSynchronizationStatus")]
        [Validation(Required=false)]
        public DescribeMigrationJobStatusResponseBodyDataSynchronizationStatus DataSynchronizationStatus { get; set; }
        public class DescribeMigrationJobStatusResponseBodyDataSynchronizationStatus : TeaModel {
            /// <summary>
            /// <para>The timestamp of the latest incremental data that has been migrated. The value is a UNIX timestamp, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1571040679</para>
            /// </summary>
            [NameInMap("Checkpoint")]
            [Validation(Required=false)]
            public string Checkpoint { get; set; }

            /// <summary>
            /// <para>The migration latency of incremental data migration, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Delay")]
            [Validation(Required=false)]
            public string Delay { get; set; }

            /// <summary>
            /// <para>The error message returned when incremental data migration failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>任务失败太久 无法恢复</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The progress of incremental data migration, in percentage.</para>
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
            /// <item><description><b>NotStarted</b>: not started.</description></item>
            /// <item><description><b>Migrating</b>: migrating.</description></item>
            /// <item><description><b>Failed</b>: migration failed.</description></item>
            /// <item><description><b>Finished</b>: migration completed.</description></item>
            /// <item><description><b>Catched</b>: no latency.</description></item>
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
        /// <para>The connection information of the destination instance.</para>
        /// </summary>
        [NameInMap("DestinationEndpoint")]
        [Validation(Required=false)]
        public DescribeMigrationJobStatusResponseBodyDestinationEndpoint DestinationEndpoint { get; set; }
        public class DescribeMigrationJobStatusResponseBodyDestinationEndpoint : TeaModel {
            /// <summary>
            /// <para>The name of the database to which the objects to be migrated belong in the destination instance.</para>
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
            /// <para>The instance ID of the destination instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-bpxxxxxxxx</para>
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
            /// <para>The SID of the Oracle database.</para>
            /// <remarks>
            /// <para>This parameter is returned only when the database type of the destination instance is <b>Oracle</b>.</para>
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
        /// <para>The instance ID of the data migration instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dtsxxxxxxxx</para>
        /// </summary>
        [NameInMap("MigrationJobId")]
        [Validation(Required=false)]
        public string MigrationJobId { get; set; }

        /// <summary>
        /// <para>The name of the data migration instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySQL迁移</para>
        /// </summary>
        [NameInMap("MigrationJobName")]
        [Validation(Required=false)]
        public string MigrationJobName { get; set; }

        /// <summary>
        /// <para>The status of the data migration task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>NotStarted</b>: not started.</description></item>
        /// <item><description><b>Prechecking</b>: running the precheck.</description></item>
        /// <item><description><b>PrecheckFailed</b>: precheck failed.</description></item>
        /// <item><description><b>Migrating</b>: migrating.</description></item>
        /// <item><description><b>Suspending</b>: paused.</description></item>
        /// <item><description><b>MigrationFailed</b>: migration failed.</description></item>
        /// <item><description><b>Finished</b>: migration completed.</description></item>
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
            /// <item><description><b>true</b>: yes.</description></item>
            /// <item><description><b>false</b>: no.</description></item>
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
            /// <item><description><b>true</b>: yes.</description></item>
            /// <item><description><b>false</b>: no.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para><b>false</b>。</para>
            /// </summary>
            [NameInMap("dataSynchronization")]
            [Validation(Required=false)]
            public bool? DataSynchronization { get; set; }

            /// <summary>
            /// <para>Indicates whether schema migration is performed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: yes.</description></item>
            /// <item><description><b>false</b>: no.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para><b>false</b>。</para>
            /// </summary>
            [NameInMap("structureInitialization")]
            [Validation(Required=false)]
            public bool? StructureInitialization { get; set; }

        }

        /// <summary>
        /// <para>The migration objects.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;DBName\&quot;:\&quot;dtstestdata\&quot;,\&quot;TableIncludes\&quot;:[{\&quot;TableName\&quot;:\&quot;customer\&quot;}]}]</para>
        /// </summary>
        [NameInMap("MigrationObject")]
        [Validation(Required=false)]
        public string MigrationObject { get; set; }

        /// <summary>
        /// <para>The billing method of the data migration task. The return value is fixed as <b>PostPaid</b> (pay-as-you-go).</para>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The precheck status.</para>
        /// </summary>
        [NameInMap("PrecheckStatus")]
        [Validation(Required=false)]
        public DescribeMigrationJobStatusResponseBodyPrecheckStatus PrecheckStatus { get; set; }
        public class DescribeMigrationJobStatusResponseBodyPrecheckStatus : TeaModel {
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public DescribeMigrationJobStatusResponseBodyPrecheckStatusDetail Detail { get; set; }
            public class DescribeMigrationJobStatusResponseBodyPrecheckStatusDetail : TeaModel {
                [NameInMap("CheckItem")]
                [Validation(Required=false)]
                public List<DescribeMigrationJobStatusResponseBodyPrecheckStatusDetailCheckItem> CheckItem { get; set; }
                public class DescribeMigrationJobStatusResponseBodyPrecheckStatusDetailCheckItem : TeaModel {
                    [NameInMap("CheckStatus")]
                    [Validation(Required=false)]
                    public string CheckStatus { get; set; }

                    [NameInMap("ErrorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                    [NameInMap("ItemName")]
                    [Validation(Required=false)]
                    public string ItemName { get; set; }

                    [NameInMap("RepairMethod")]
                    [Validation(Required=false)]
                    public string RepairMethod { get; set; }

                }

            }

            /// <summary>
            /// <para>The overall progress of the precheck, in percentage.</para>
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
            /// <item><description><b>NotStarted</b>: not started.</description></item>
            /// <item><description><b>Checking</b>: running the precheck.</description></item>
            /// <item><description><b>Failed</b>: precheck failed.</description></item>
            /// <item><description><b>Finished</b>: precheck completed.</description></item>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A032E3B4-929B-48E9-97B9-37587CBF****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The connection information of the source instance.</para>
        /// </summary>
        [NameInMap("SourceEndpoint")]
        [Validation(Required=false)]
        public DescribeMigrationJobStatusResponseBodySourceEndpoint SourceEndpoint { get; set; }
        public class DescribeMigrationJobStatusResponseBodySourceEndpoint : TeaModel {
            /// <summary>
            /// <para>The name of the database to which the objects to be migrated belong in the source instance.</para>
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
            /// <para>The instance ID of the source instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rm-bp1i99e8l7913****</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The type of the source instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>RDS</b>: ApsaraDB RDS instance.</description></item>
            /// <item><description><b>ECS</b>: self-managed database hosted on ECS.</description></item>
            /// <item><description><b>LocalInstance</b>: self-managed database with a public IP address.</description></item>
            /// <item><description><b>Express</b>: self-managed database connected over Express Connect, VPN Gateway, or Smart Access Gateway.</description></item>
            /// <item><description><b>MongoDB</b>: ApsaraDB for MongoDB instance.</description></item>
            /// <item><description><b>POLARDB</b>: PolarDB for MySQL cluster (this value is applicable only to the China site).</description></item>
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
            /// <para>This parameter is returned only when the database type of the source instance is Oracle.</para>
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
        /// <para>The execution status of schema migration.</para>
        /// </summary>
        [NameInMap("StructureInitializationStatus")]
        [Validation(Required=false)]
        public DescribeMigrationJobStatusResponseBodyStructureInitializationStatus StructureInitializationStatus { get; set; }
        public class DescribeMigrationJobStatusResponseBodyStructureInitializationStatus : TeaModel {
            /// <summary>
            /// <para>The error message returned when schema migration failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DTS-1020042 Execute sql error sql: ERROR: type &quot;geometry&quot; does not exist;</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The progress of schema migration, in percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Percent")]
            [Validation(Required=false)]
            public string Percent { get; set; }

            /// <summary>
            /// <para>The number of tables for which schema migration has been completed.</para>
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
            /// <item><description><b>NotStarted</b>: not started.</description></item>
            /// <item><description><b>Migrating</b>: migrating.</description></item>
            /// <item><description><b>Failed</b>: migration failed.</description></item>
            /// <item><description><b>Finished</b>: migration completed.</description></item>
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
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// <para>The ID of the data migration task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>z2v12jfo309****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
