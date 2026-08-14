// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeSynchronizationJobsResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The maximum number of records that can be displayed on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageRecordCount")]
        [Validation(Required=false)]
        public int? PageRecordCount { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>92E1E99D-5224-4AD3-8C94-23A3516B****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of data synchronization instances and the details of each instance.</para>
        /// </summary>
        [NameInMap("SynchronizationInstances")]
        [Validation(Required=false)]
        public List<DescribeSynchronizationJobsResponseBodySynchronizationInstances> SynchronizationInstances { get; set; }
        public class DescribeSynchronizationJobsResponseBodySynchronizationInstances : TeaModel {
            /// <summary>
            /// <para>The time when the synchronization task was created, in the format of <i>yyyy-MM-dd HH:mm:ss</i>.0 (UTC+8).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-06-28 17:34:53.0</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>Indicates whether initial full data synchronization is performed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Yes.</description></item>
            /// <item><description><b>false</b>: No.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DataInitialization")]
            [Validation(Required=false)]
            public string DataInitialization { get; set; }

            /// <summary>
            /// <para>The status of initial full data synchronization.</para>
            /// </summary>
            [NameInMap("DataInitializationStatus")]
            [Validation(Required=false)]
            public DescribeSynchronizationJobsResponseBodySynchronizationInstancesDataInitializationStatus DataInitializationStatus { get; set; }
            public class DescribeSynchronizationJobsResponseBodySynchronizationInstancesDataInitializationStatus : TeaModel {
                /// <summary>
                /// <para>The error message returned when initial full data synchronization fails.</para>
                /// 
                /// <b>Example:</b>
                /// <para>java.lang.NumberFormatException: For input string: &quot;&quot;</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>The progress of initial full data synchronization, in percentage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Percent")]
                [Validation(Required=false)]
                public string Percent { get; set; }

                /// <summary>
                /// <para>The number of records that have been synchronized during initial full data synchronization.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200001</para>
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public string Progress { get; set; }

                /// <summary>
                /// <para>The status of initial full data synchronization. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>NotStarted</b>: not started.</description></item>
                /// <item><description><b>Migrating</b>: in progress.</description></item>
                /// <item><description><b>Failed</b>: failed.</description></item>
                /// <item><description><b>Finished</b>: completed.</description></item>
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
            /// <para>The status of incremental data synchronization.</para>
            /// <remarks>
            /// <para>This parameter set and its contained parameters have been discontinued.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("DataSynchronizationStatus")]
            [Validation(Required=false)]
            public DescribeSynchronizationJobsResponseBodySynchronizationInstancesDataSynchronizationStatus DataSynchronizationStatus { get; set; }
            public class DescribeSynchronizationJobsResponseBodySynchronizationInstancesDataSynchronizationStatus : TeaModel {
                /// <summary>
                /// <para>The synchronization latency of incremental data synchronization.</para>
                /// <remarks>
                /// <para>This parameter has been discontinued.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Delay")]
                [Validation(Required=false)]
                public string Delay { get; set; }

                /// <summary>
                /// <para>The error message returned when incremental data synchronization fails.</para>
                /// <remarks>
                /// <para>This parameter has been discontinued.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>任务失败太久无法恢复</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>The progress of incremental data synchronization.</para>
                /// <remarks>
                /// <para>This parameter has been discontinued.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Percent")]
                [Validation(Required=false)]
                public string Percent { get; set; }

                /// <summary>
                /// <para>The status of incremental data synchronization.</para>
                /// <remarks>
                /// <para>This parameter has been discontinued.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Finished</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The synchronization latency, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Delay")]
            [Validation(Required=false)]
            public string Delay { get; set; }

            /// <summary>
            /// <para>The connection information of the destination instance.</para>
            /// </summary>
            [NameInMap("DestinationEndpoint")]
            [Validation(Required=false)]
            public DescribeSynchronizationJobsResponseBodySynchronizationInstancesDestinationEndpoint DestinationEndpoint { get; set; }
            public class DescribeSynchronizationJobsResponseBodySynchronizationInstancesDestinationEndpoint : TeaModel {
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
                /// <para>rm-bp162d4tp0500****</para>
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

            }

            /// <summary>
            /// <para>The error message returned when data synchronization fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DTS-070211: Connect Source DB failed. cause by [com.mysql.jdbc.exceptions.jdbc4.MySQLNonTransientConnectionException:Could not create connection to database server. Attempted reconnect 3 times. Giving up.][com.mysql.jdbc.exceptions.jdbc4.CommunicationsException:Communications link failure\n\nThe last packet sent successfully to the server was 0 milliseconds ago. The driver has not received any packets from the server.][java.net.ConnectException:Connection timed out (Connection timed out)] About more information in [<a href="https://yq.aliyun.com/articles/499178%5D">https://yq.aliyun.com/articles/499178]</a>.</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The expiration time of the synchronization instance, in the format of <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z (UTC).</para>
            /// <remarks>
            /// <para>This parameter is returned only when the value of the <b>PayType</b> parameter is <b>PrePaid</b>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2021-07-07T16:00:00Z</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <para>The time when the synchronization instance was created, in the format of <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-06-28T09:36:32Z</para>
            /// </summary>
            [NameInMap("InstanceCreateTime")]
            [Validation(Required=false)]
            public string InstanceCreateTime { get; set; }

            /// <summary>
            /// <para>The time when the synchronization task was created, in the format of <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-06-28T09:34:53Z</para>
            /// </summary>
            [NameInMap("JobCreateTime")]
            [Validation(Required=false)]
            public string JobCreateTime { get; set; }

            /// <summary>
            /// <para>The billing method of the synchronization instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>PrePaid</b>: subscription.</description></item>
            /// <item><description><b>PostPaid</b>: pay-as-you-go.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PrePaid</para>
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            /// <summary>
            /// <para>The overview information of the synchronization link.</para>
            /// </summary>
            [NameInMap("Performance")]
            [Validation(Required=false)]
            public DescribeSynchronizationJobsResponseBodySynchronizationInstancesPerformance Performance { get; set; }
            public class DescribeSynchronizationJobsResponseBodySynchronizationInstancesPerformance : TeaModel {
                /// <summary>
                /// <para>The volume of data synchronized per second, in MB/s.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("FLOW")]
                [Validation(Required=false)]
                public string FLOW { get; set; }

                /// <summary>
                /// <para>The number of SQL statements synchronized per second, including BEGIN, COMMIT, DML statements (INSERT, DELETE, and UPDATE), and DDL statements.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("RPS")]
                [Validation(Required=false)]
                public string RPS { get; set; }

            }

            /// <summary>
            /// <para>The precheck status.</para>
            /// </summary>
            [NameInMap("PrecheckStatus")]
            [Validation(Required=false)]
            public DescribeSynchronizationJobsResponseBodySynchronizationInstancesPrecheckStatus PrecheckStatus { get; set; }
            public class DescribeSynchronizationJobsResponseBodySynchronizationInstancesPrecheckStatus : TeaModel {
                /// <summary>
                /// <para>The execution details of each precheck item.</para>
                /// </summary>
                [NameInMap("Detail")]
                [Validation(Required=false)]
                public List<DescribeSynchronizationJobsResponseBodySynchronizationInstancesPrecheckStatusDetail> Detail { get; set; }
                public class DescribeSynchronizationJobsResponseBodySynchronizationInstancesPrecheckStatusDetail : TeaModel {
                    /// <summary>
                    /// <para>The check result. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>Success</b>: passed.</description></item>
                    /// <item><description><b>Failed</b>: failed.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Success</para>
                    /// </summary>
                    [NameInMap("CheckStatus")]
                    [Validation(Required=false)]
                    public string CheckStatus { get; set; }

                    /// <summary>
                    /// <para>The error message returned when the precheck fails.</para>
                    /// <remarks>
                    /// <para>This parameter is returned only when the value of the <b>CheckStatus</b> parameter is <b>Failed</b>.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Original error: Access denied for user \&quot;dtstest\&quot;@\&quot;100.104.***.**\&quot; (using password: YES)</para>
                    /// </summary>
                    [NameInMap("ErrorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                    /// <summary>
                    /// <para>The precheck item.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CHECK_CONN_SRC</para>
                    /// </summary>
                    [NameInMap("ItemName")]
                    [Validation(Required=false)]
                    public string ItemName { get; set; }

                    /// <summary>
                    /// <para>The repair method when the precheck fails.</para>
                    /// <remarks>
                    /// <para>This parameter is returned only when the value of the <b>CheckStatus</b> parameter is <b>Failed</b>.</para>
                    /// </remarks>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CHECK_ERROR_DEST_CONN_REPAIR2</para>
                    /// </summary>
                    [NameInMap("RepairMethod")]
                    [Validation(Required=false)]
                    public string RepairMethod { get; set; }

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
                /// <para>The precheck result. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>Success</b>: passed.</description></item>
                /// <item><description><b>Failed</b>: failed.</description></item>
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
            /// <para>The connection information of the source instance.</para>
            /// </summary>
            [NameInMap("SourceEndpoint")]
            [Validation(Required=false)]
            public DescribeSynchronizationJobsResponseBodySynchronizationInstancesSourceEndpoint SourceEndpoint { get; set; }
            public class DescribeSynchronizationJobsResponseBodySynchronizationInstancesSourceEndpoint : TeaModel {
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
                /// <para>The type of the source instance.</para>
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

            }

            /// <summary>
            /// <para>The status of the synchronization instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>NotStarted</b>: not started.</description></item>
            /// <item><description><b>Prechecking</b>: running the precheck.</description></item>
            /// <item><description><b>PrecheckFailed</b>: precheck failed.</description></item>
            /// <item><description><b>Initializating</b>: performing initial synchronization.</description></item>
            /// <item><description><b>InitializeFailed</b>: initial synchronization failed.</description></item>
            /// <item><description><b>Synchronizing</b>: synchronizing.</description></item>
            /// <item><description><b>Failed</b>: synchronization failed.</description></item>
            /// <item><description><b>Suspending</b>: paused.</description></item>
            /// <item><description><b>Modifying</b>: modifying synchronization objects.</description></item>
            /// <item><description><b>Finished</b>: completed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>synchronizing</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Indicates whether initial schema synchronization is performed. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Yes.</description></item>
            /// <item><description><b>false</b>: No.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("StructureInitialization")]
            [Validation(Required=false)]
            public string StructureInitialization { get; set; }

            /// <summary>
            /// <para>The status of initial schema synchronization.</para>
            /// </summary>
            [NameInMap("StructureInitializationStatus")]
            [Validation(Required=false)]
            public DescribeSynchronizationJobsResponseBodySynchronizationInstancesStructureInitializationStatus StructureInitializationStatus { get; set; }
            public class DescribeSynchronizationJobsResponseBodySynchronizationInstancesStructureInitializationStatus : TeaModel {
                /// <summary>
                /// <para>The error message returned when initial schema synchronization fails.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DTS-1020042 Execute sql error sql: ERROR: type &quot;geometry&quot; does not exist;</para>
                /// </summary>
                [NameInMap("ErrorMessage")]
                [Validation(Required=false)]
                public string ErrorMessage { get; set; }

                /// <summary>
                /// <para>The progress of initial schema synchronization, in percentage.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("Percent")]
                [Validation(Required=false)]
                public string Percent { get; set; }

                /// <summary>
                /// <para>The number of tables for which initial schema synchronization has been completed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Progress")]
                [Validation(Required=false)]
                public string Progress { get; set; }

                /// <summary>
                /// <para>The status of initial schema synchronization. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>NotStarted</b>: not started.</description></item>
                /// <item><description><b>Migrating</b>: in progress.</description></item>
                /// <item><description><b>Failed</b>: failed.</description></item>
                /// <item><description><b>Finished</b>: completed.</description></item>
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
            /// <para>The synchronization direction. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Forward</b>: forward.</description></item>
            /// <item><description><b>Reverse</b>: reverse.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Forward</para>
            /// </summary>
            [NameInMap("SynchronizationDirection")]
            [Validation(Required=false)]
            public string SynchronizationDirection { get; set; }

            /// <summary>
            /// <para>The specification of the synchronization link.</para>
            /// 
            /// <b>Example:</b>
            /// <para>large</para>
            /// </summary>
            [NameInMap("SynchronizationJobClass")]
            [Validation(Required=false)]
            public string SynchronizationJobClass { get; set; }

            /// <summary>
            /// <para>The instance ID of the data synchronization instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dtsexjk1alb116****</para>
            /// </summary>
            [NameInMap("SynchronizationJobId")]
            [Validation(Required=false)]
            public string SynchronizationJobId { get; set; }

            /// <summary>
            /// <para>The name of the synchronization instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MySQL同步</para>
            /// </summary>
            [NameInMap("SynchronizationJobName")]
            [Validation(Required=false)]
            public string SynchronizationJobName { get; set; }

            /// <summary>
            /// <para>The synchronization objects.</para>
            /// </summary>
            [NameInMap("SynchronizationObjects")]
            [Validation(Required=false)]
            public List<DescribeSynchronizationJobsResponseBodySynchronizationInstancesSynchronizationObjects> SynchronizationObjects { get; set; }
            public class DescribeSynchronizationJobsResponseBodySynchronizationInstancesSynchronizationObjects : TeaModel {
                /// <summary>
                /// <para>The name of the database to which the objects are mapped in the destination database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>newdtstestdatabase</para>
                /// </summary>
                [NameInMap("NewSchemaName")]
                [Validation(Required=false)]
                public string NewSchemaName { get; set; }

                /// <summary>
                /// <para>The name of the database to be synchronized.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dtstestdatabase</para>
                /// </summary>
                [NameInMap("SchemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

                /// <summary>
                /// <para>The tables that are excluded from the database to be synchronized. These tables are not synchronized.</para>
                /// </summary>
                [NameInMap("TableExcludes")]
                [Validation(Required=false)]
                public List<DescribeSynchronizationJobsResponseBodySynchronizationInstancesSynchronizationObjectsTableExcludes> TableExcludes { get; set; }
                public class DescribeSynchronizationJobsResponseBodySynchronizationInstancesSynchronizationObjectsTableExcludes : TeaModel {
                    /// <summary>
                    /// <para>The name of the excluded table.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>order</para>
                    /// </summary>
                    [NameInMap("TableName")]
                    [Validation(Required=false)]
                    public string TableName { get; set; }

                }

                /// <summary>
                /// <para>The tables to be synchronized.</para>
                /// </summary>
                [NameInMap("TableIncludes")]
                [Validation(Required=false)]
                public List<DescribeSynchronizationJobsResponseBodySynchronizationInstancesSynchronizationObjectsTableIncludes> TableIncludes { get; set; }
                public class DescribeSynchronizationJobsResponseBodySynchronizationInstancesSynchronizationObjectsTableIncludes : TeaModel {
                    /// <summary>
                    /// <para>The name of the table to be synchronized.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>customer</para>
                    /// </summary>
                    [NameInMap("TableName")]
                    [Validation(Required=false)]
                    public string TableName { get; set; }

                }

            }

            /// <summary>
            /// <para>The tag collection.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<DescribeSynchronizationJobsResponseBodySynchronizationInstancesTags> Tags { get; set; }
            public class DescribeSynchronizationJobsResponseBodySynchronizationInstancesTags : TeaModel {
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

        /// <summary>
        /// <para>The total number of data synchronization instances that meet the specified conditions under the Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public long? TotalRecordCount { get; set; }

    }

}
