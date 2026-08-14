// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeSynchronizationJobStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The timestamp of the latest synchronized data, in UNIX timestamp format.</para>
        /// <remarks>
        /// <para>You can use a search engine to find a UNIX timestamp converter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1610616144</para>
        /// </summary>
        [NameInMap("Checkpoint")]
        [Validation(Required=false)]
        public string Checkpoint { get; set; }

        /// <summary>
        /// <para>Indicates whether initial full data synchronization was performed. Valid values:</para>
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
        public DescribeSynchronizationJobStatusResponseBodyDataInitializationStatus DataInitializationStatus { get; set; }
        public class DescribeSynchronizationJobStatusResponseBodyDataInitializationStatus : TeaModel {
            /// <summary>
            /// <para>The error message returned when initial full data synchronization failed.</para>
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
        /// </summary>
        [NameInMap("DataSynchronizationStatus")]
        [Validation(Required=false)]
        public DescribeSynchronizationJobStatusResponseBodyDataSynchronizationStatus DataSynchronizationStatus { get; set; }
        public class DescribeSynchronizationJobStatusResponseBodyDataSynchronizationStatus : TeaModel {
            /// <summary>
            /// <para>The timestamp of the latest synchronized data, in UNIX timestamp format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1610709865</para>
            /// </summary>
            [NameInMap("Checkpoint")]
            [Validation(Required=false)]
            public string Checkpoint { get; set; }

            /// <summary>
            /// <para>The synchronization latency of incremental data synchronization, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Delay")]
            [Validation(Required=false)]
            public string Delay { get; set; }

            /// <summary>
            /// <para>The synchronization latency of incremental data synchronization, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>856</para>
            /// </summary>
            [NameInMap("DelayMillis")]
            [Validation(Required=false)]
            public long? DelayMillis { get; set; }

            /// <summary>
            /// <para>The error message returned when incremental data synchronization failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>任务失败太久无法恢复</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The progress of incremental data synchronization, in percentage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Percent")]
            [Validation(Required=false)]
            public string Percent { get; set; }

            /// <summary>
            /// <para>The status of incremental data synchronization. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>NotStarted</b>: not started.</description></item>
            /// <item><description><b>Migrating</b>: synchronizing.</description></item>
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
        /// <para>The synchronization latency, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Delay")]
        [Validation(Required=false)]
        public string Delay { get; set; }

        /// <summary>
        /// <para>The synchronization latency, in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>506</para>
        /// </summary>
        [NameInMap("DelayMillis")]
        [Validation(Required=false)]
        public long? DelayMillis { get; set; }

        /// <summary>
        /// <para>The connection information of the destination instance.</para>
        /// </summary>
        [NameInMap("DestinationEndpoint")]
        [Validation(Required=false)]
        public DescribeSynchronizationJobStatusResponseBodyDestinationEndpoint DestinationEndpoint { get; set; }
        public class DescribeSynchronizationJobStatusResponseBodyDestinationEndpoint : TeaModel {
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
        /// <para>The error code returned when the call failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>InternalError</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message returned when the call failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The request processing has failed due to some unknown error.</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The error message returned when data synchronization failed.</para>
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
        /// <para>2021-03-07T16:00:00Z</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

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
        /// <para>The overview of the synchronization link.</para>
        /// </summary>
        [NameInMap("Performance")]
        [Validation(Required=false)]
        public DescribeSynchronizationJobStatusResponseBodyPerformance Performance { get; set; }
        public class DescribeSynchronizationJobStatusResponseBodyPerformance : TeaModel {
            /// <summary>
            /// <para>The data flow rate of synchronization per second, in MB/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("FLOW")]
            [Validation(Required=false)]
            public string FLOW { get; set; }

            /// <summary>
            /// <para>The number of SQL statements synchronized per second, including BEGIN, COMMIT, DML statements (INSERT, DELETE, UPDATE), and DDL statements.</para>
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
        public DescribeSynchronizationJobStatusResponseBodyPrecheckStatus PrecheckStatus { get; set; }
        public class DescribeSynchronizationJobStatusResponseBodyPrecheckStatus : TeaModel {
            /// <summary>
            /// <para>The details of each precheck item.</para>
            /// </summary>
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public List<DescribeSynchronizationJobStatusResponseBodyPrecheckStatusDetail> Detail { get; set; }
            public class DescribeSynchronizationJobStatusResponseBodyPrecheckStatusDetail : TeaModel {
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
                /// <para>The error message returned when the precheck failed.</para>
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
                /// <para>The repair method when the precheck failed.</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DACDF659-AFC6-4DC8-ADB8-4569419A4****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The connection information of the source instance.</para>
        /// </summary>
        [NameInMap("SourceEndpoint")]
        [Validation(Required=false)]
        public DescribeSynchronizationJobStatusResponseBodySourceEndpoint SourceEndpoint { get; set; }
        public class DescribeSynchronizationJobStatusResponseBodySourceEndpoint : TeaModel {
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
        /// <item><description><b>notStarted</b>: not started.</description></item>
        /// <item><description><b>prechecking</b>: running a precheck.</description></item>
        /// <item><description><b>precheckFailed</b>: precheck failed.</description></item>
        /// <item><description><b>initializating</b>: performing initial synchronization.</description></item>
        /// <item><description><b>initializeFailed</b>: initial synchronization failed.</description></item>
        /// <item><description><b>synchronizing</b>: synchronizing.</description></item>
        /// <item><description><b>failed</b>: synchronization failed.</description></item>
        /// <item><description><b>suspending</b>: paused.</description></item>
        /// <item><description><b>modifying</b>: modifying synchronization objects.</description></item>
        /// <item><description><b>finished</b>: completed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>synchronizing</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Indicates whether initial schema synchronization was performed. Valid values:</para>
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
        public DescribeSynchronizationJobStatusResponseBodyStructureInitializationStatus StructureInitializationStatus { get; set; }
        public class DescribeSynchronizationJobStatusResponseBodyStructureInitializationStatus : TeaModel {
            /// <summary>
            /// <para>The error message returned when initial schema synchronization encountered an exception.</para>
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
            /// <para>The number of tables that have completed initial schema synchronization.</para>
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
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

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
        public List<DescribeSynchronizationJobStatusResponseBodySynchronizationObjects> SynchronizationObjects { get; set; }
        public class DescribeSynchronizationJobStatusResponseBodySynchronizationObjects : TeaModel {
            /// <summary>
            /// <para>The name mapped to the database to be synchronized in the destination database.</para>
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
            /// <para>The tables excluded from the database to be synchronized. These tables will not be synchronized.</para>
            /// </summary>
            [NameInMap("TableExcludes")]
            [Validation(Required=false)]
            public List<DescribeSynchronizationJobStatusResponseBodySynchronizationObjectsTableExcludes> TableExcludes { get; set; }
            public class DescribeSynchronizationJobStatusResponseBodySynchronizationObjectsTableExcludes : TeaModel {
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
            public List<DescribeSynchronizationJobStatusResponseBodySynchronizationObjectsTableIncludes> TableIncludes { get; set; }
            public class DescribeSynchronizationJobStatusResponseBodySynchronizationObjectsTableIncludes : TeaModel {
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
        /// <para>The ID of the data synchronization task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exjk1alb116****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
