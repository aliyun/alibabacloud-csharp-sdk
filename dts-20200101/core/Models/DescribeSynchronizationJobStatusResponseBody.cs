// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class DescribeSynchronizationJobStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The UNIX timestamp generated when the latest data record was synchronized.</para>
        /// <remarks>
        /// <para> You can use a search engine to obtain a UNIX timestamp converter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1610616144</para>
        /// </summary>
        [NameInMap("Checkpoint")]
        [Validation(Required=false)]
        public string Checkpoint { get; set; }

        /// <summary>
        /// <para>Indicates whether full data synchronization is performed. Valid values:</para>
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
        public string DataInitialization { get; set; }

        /// <summary>
        /// <para>The status of full data synchronization.</para>
        /// </summary>
        [NameInMap("DataInitializationStatus")]
        [Validation(Required=false)]
        public DescribeSynchronizationJobStatusResponseBodyDataInitializationStatus DataInitializationStatus { get; set; }
        public class DescribeSynchronizationJobStatusResponseBodyDataInitializationStatus : TeaModel {
            /// <summary>
            /// <para>The error message returned if full data synchronization failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>java.lang.NumberFormatException: For input string: &quot;&quot;</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The progress of full data synchronization. Unit: %.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Percent")]
            [Validation(Required=false)]
            public string Percent { get; set; }

            /// <summary>
            /// <para>The number of records that have been synchronized during full data synchronization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200001</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            /// <summary>
            /// <para>The status of full data synchronization. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>NotStarted</b>: Full data synchronization is not started.</description></item>
            /// <item><description><b>Migrating</b>: Full data synchronization is in progress.</description></item>
            /// <item><description><b>Failed</b>: Full data synchronization failed.</description></item>
            /// <item><description><b>Finished</b>: Full data synchronization is completed.</description></item>
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
            /// <para>The UNIX timestamp generated when the latest data record was synchronized.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1610709865</para>
            /// </summary>
            [NameInMap("Checkpoint")]
            [Validation(Required=false)]
            public string Checkpoint { get; set; }

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
            /// <para>856</para>
            /// </summary>
            [NameInMap("DelayMillis")]
            [Validation(Required=false)]
            public long? DelayMillis { get; set; }

            /// <summary>
            /// <para>The error message returned if incremental data synchronization failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DTS-070211: Connect Source DB failed. cause by [com.mysql.jdbc.exceptions.jdbc4.MySQLNonTransientConnectionException:Could not create connection to database server. Attempted reconnect 3 times. Giving up.][com.mysql.jdbc.exceptions.jdbc4.CommunicationsException:Communications link failure\n\nThe last packet sent successfully to the server was 0 milliseconds ago. The driver has not received any packets from the server.][java.net.ConnectException:Connection timed out (Connection timed out)] About more information in [<a href="https://yq.aliyun.com/articles/499178%5D">https://yq.aliyun.com/articles/499178]</a>.</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The progress of incremental data synchronization. Unit: %.</para>
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
            /// <item><description><b>NotStarted</b>: Incremental data synchronization is not started.</description></item>
            /// <item><description><b>Migrating</b>: Incremental data synchronization is in progress.</description></item>
            /// <item><description><b>Failed</b>: Incremental data synchronization failed.</description></item>
            /// <item><description><b>Finished</b>: Incremental data synchronization is completed.</description></item>
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
        /// <para>The synchronization delay, in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>506</para>
        /// </summary>
        [NameInMap("DelayMillis")]
        [Validation(Required=false)]
        public long? DelayMillis { get; set; }

        /// <summary>
        /// <para>The connection settings of the destination instance.</para>
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
            /// <para>The ID of the destination instance.</para>
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
        /// <para>The error message returned if data synchronization failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DTS-070211: Connect Source DB failed. cause by [com.mysql.jdbc.exceptions.jdbc4.MySQLNonTransientConnectionException:Could not create connection to database server. Attempted reconnect 3 times. Giving up.][com.mysql.jdbc.exceptions.jdbc4.CommunicationsException:Communications link failure\n\nThe last packet sent successfully to the server was 0 milliseconds ago. The driver has not received any packets from the server.][java.net.ConnectException:Connection timed out (Connection timed out)] About more information in [<a href="https://yq.aliyun.com/articles/499178%5D">https://yq.aliyun.com/articles/499178]</a>.</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The time when the data synchronization instance expires. The time is displayed in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format in UTC.</para>
        /// <remarks>
        /// <para> This parameter is returned only if the return value of the <b>PayType</b> parameter is <b>PrePaid</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2021-03-07T16:00:00Z</para>
        /// </summary>
        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        /// <summary>
        /// <para>The billing method of the data synchronization instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PrePaid</b>: subscription</description></item>
        /// <item><description><b>PostPaid</b>: pay-as-you-go</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PrePaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The performance of the data synchronization instance.</para>
        /// </summary>
        [NameInMap("Performance")]
        [Validation(Required=false)]
        public DescribeSynchronizationJobStatusResponseBodyPerformance Performance { get; set; }
        public class DescribeSynchronizationJobStatusResponseBodyPerformance : TeaModel {
            /// <summary>
            /// <para>The data traffic that is synchronized per second. Unit: MB/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("FLOW")]
            [Validation(Required=false)]
            public string FLOW { get; set; }

            /// <summary>
            /// <para>The number of times SQL statements are synchronized per second, including BEGIN, COMMIT, DML, and DDL statements. DML statements include INSERT, DELETE, and UPDATE.</para>
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
            /// <para>The result of each precheck item.</para>
            /// </summary>
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public List<DescribeSynchronizationJobStatusResponseBodyPrecheckStatusDetail> Detail { get; set; }
            public class DescribeSynchronizationJobStatusResponseBodyPrecheckStatusDetail : TeaModel {
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DACDF659-AFC6-4DC8-ADB8-4569419A4****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The connection settings of the source instance.</para>
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
        /// <para>The status of the data synchronization task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>NotStarted</b>: The task is not started.</description></item>
        /// <item><description><b>Prechecking</b>: The task is being prechecked.</description></item>
        /// <item><description><b>PrecheckFailed</b>: The task failed to pass the precheck.</description></item>
        /// <item><description><b>Initializing</b>: The task is performing initial synchronization.</description></item>
        /// <item><description><b>InitializeFailed</b>: Initial synchronization failed.</description></item>
        /// <item><description><b>Synchronizing</b>: The task is synchronizing data.</description></item>
        /// <item><description><b>Failed</b>: The task failed to synchronize data.</description></item>
        /// <item><description><b>Suspending</b>: The task is paused.</description></item>
        /// <item><description><b>Modifying</b>: The objects in the task are being modified.</description></item>
        /// <item><description><b>Finished</b>: The task is completed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>synchronizing</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Indicates whether schema synchronization is performed. Valid values:</para>
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
        public string StructureInitialization { get; set; }

        /// <summary>
        /// <para>The status of schema synchronization.</para>
        /// </summary>
        [NameInMap("StructureInitializationStatus")]
        [Validation(Required=false)]
        public DescribeSynchronizationJobStatusResponseBodyStructureInitializationStatus StructureInitializationStatus { get; set; }
        public class DescribeSynchronizationJobStatusResponseBodyStructureInitializationStatus : TeaModel {
            /// <summary>
            /// <para>The error message returned if schema synchronization failed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DTS-1020042 Execute sql error sql: ERROR: type &quot;geometry&quot; does not exist;</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The progress of schema synchronization. Unit: %.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Percent")]
            [Validation(Required=false)]
            public string Percent { get; set; }

            /// <summary>
            /// <para>The number of tables whose schemas have been synchronized.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Progress")]
            [Validation(Required=false)]
            public string Progress { get; set; }

            /// <summary>
            /// <para>The status of schema synchronization. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>NotStarted</b>: Schema synchronization is not started.</description></item>
            /// <item><description><b>Migrating</b>: Schema synchronization is in progress.</description></item>
            /// <item><description><b>Failed</b>: Schema synchronization failed.</description></item>
            /// <item><description><b>Finished</b>: Schema synchronization is completed.</description></item>
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
        /// <para>The synchronization direction. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Forward</b></description></item>
        /// <item><description><b>Reverse</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Forward</para>
        /// </summary>
        [NameInMap("SynchronizationDirection")]
        [Validation(Required=false)]
        public string SynchronizationDirection { get; set; }

        /// <summary>
        /// <para>The specification of the data synchronization instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>large</para>
        /// </summary>
        [NameInMap("SynchronizationJobClass")]
        [Validation(Required=false)]
        public string SynchronizationJobClass { get; set; }

        /// <summary>
        /// <para>The ID of the data synchronization instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dtsexjk1alb116****</para>
        /// </summary>
        [NameInMap("SynchronizationJobId")]
        [Validation(Required=false)]
        public string SynchronizationJobId { get; set; }

        /// <summary>
        /// <para>The name of the data synchronization task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dtstest</para>
        /// </summary>
        [NameInMap("SynchronizationJobName")]
        [Validation(Required=false)]
        public string SynchronizationJobName { get; set; }

        /// <summary>
        /// <para>The objects that are synchronized by the task.</para>
        /// </summary>
        [NameInMap("SynchronizationObjects")]
        [Validation(Required=false)]
        public List<DescribeSynchronizationJobStatusResponseBodySynchronizationObjects> SynchronizationObjects { get; set; }
        public class DescribeSynchronizationJobStatusResponseBodySynchronizationObjects : TeaModel {
            /// <summary>
            /// <para>The database name that is used in the destination instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>newdtstestdatabase</para>
            /// </summary>
            [NameInMap("NewSchemaName")]
            [Validation(Required=false)]
            public string NewSchemaName { get; set; }

            /// <summary>
            /// <para>The name of the synchronized database.</para>
            /// 
            /// <b>Example:</b>
            /// <para>dtstestdatabase</para>
            /// </summary>
            [NameInMap("SchemaName")]
            [Validation(Required=false)]
            public string SchemaName { get; set; }

            /// <summary>
            /// <para>The source tables that are excluded from the data synchronization task.</para>
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
            /// <para>The tables that are synchronized by the task.</para>
            /// </summary>
            [NameInMap("TableIncludes")]
            [Validation(Required=false)]
            public List<DescribeSynchronizationJobStatusResponseBodySynchronizationObjectsTableIncludes> TableIncludes { get; set; }
            public class DescribeSynchronizationJobStatusResponseBodySynchronizationObjectsTableIncludes : TeaModel {
                /// <summary>
                /// <para>The name of the synchronized table.</para>
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
        /// <b>Example:</b>
        /// <para>exjk1alb116****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
