// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeCloudbenchTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The detailed information, including the total number of entries and error codes.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeCloudbenchTaskResponseBodyData Data { get; set; }
        public class DescribeCloudbenchTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The archiving task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>\&quot;202105211430070112231480820340758****</para>
            /// </summary>
            [NameInMap("ArchiveJobId")]
            [Validation(Required=false)]
            public string ArchiveJobId { get; set; }

            /// <summary>
            /// <para>The name of the archived OSS table.</para>
            /// 
            /// <b>Example:</b>
            /// <para>custins15546355_161604665****</para>
            /// </summary>
            [NameInMap("ArchiveOssTableName")]
            [Validation(Required=false)]
            public string ArchiveOssTableName { get; set; }

            /// <summary>
            /// <para>The SQL archiving state. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: not started.</description></item>
            /// <item><description><b>1</b>: completed.</description></item>
            /// <item><description><b>2</b>: error.</description></item>
            /// <item><description><b>3</b>: running.</description></item>
            /// <item><description><b>4</b>: no download required.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ArchiveState")]
            [Validation(Required=false)]
            public int? ArchiveState { get; set; }

            /// <summary>
            /// <para>The backup set ID. You can call the <a href="https://help.aliyun.com/document_detail/26273.html">DescribeBackups</a> operation to obtain the backup set ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>229132</para>
            /// </summary>
            [NameInMap("BackupId")]
            [Validation(Required=false)]
            public string BackupId { get; set; }

            /// <summary>
            /// <para>The backup type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>TIMESTAMP</b>: by backup time.</description></item>
            /// <item><description><b>BACKUPID</b>: by backup set ID.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TIMESTAMP</para>
            /// </summary>
            [NameInMap("BackupType")]
            [Validation(Required=false)]
            public string BackupType { get; set; }

            /// <summary>
            /// <para>The substep of the stress testing task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>NEW</b>: task initialization.</description></item>
            /// <item><description><b>WAIT_BUY_ECS</b>: purchasing an ECS instance.</description></item>
            /// <item><description><b>WAIT_START_ECS</b>: starting the ECS instance.</description></item>
            /// <item><description><b>WAIT_INSTALL_JDK</b>: installing JDK.</description></item>
            /// <item><description><b>WAIT_INSTALL_DBGATEWAY</b>: installing DBGateway.</description></item>
            /// <item><description><b>ADD_SECURITY_IPS_STEP</b>: configuring the security group whitelist.</description></item>
            /// <item><description><b>ARCHIVE</b>: archiving full SQL.</description></item>
            /// <item><description><b>DOWNLOAD</b>: downloading the full SQL file.</description></item>
            /// <item><description><b>PROCEED</b>: preprocessing the full SQL file.</description></item>
            /// <item><description><b>PRE_LOAD</b>: preloading the full SQL file.</description></item>
            /// <item><description><b>VALIDATE</b>: functional verification.</description></item>
            /// <item><description><b>PRESSURE</b>: performance stress testing.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PROCEED</para>
            /// </summary>
            [NameInMap("BenchStep")]
            [Validation(Required=false)]
            public string BenchStep { get; set; }

            /// <summary>
            /// <para>The status of the stress testing substep. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>NEW</b>: task initialization.</description></item>
            /// <item><description><b>RUNNING</b>: running.</description></item>
            /// <item><description><b>FAILED</b>: failed.</description></item>
            /// <item><description><b>FINISHED</b>: completed.</description></item>
            /// <item><description><b>Terminated</b>: terminated.</description></item>
            /// <item><description><b>Deleted</b>: deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>FINISHED</para>
            /// </summary>
            [NameInMap("BenchStepStatus")]
            [Validation(Required=false)]
            public string BenchStepStatus { get; set; }

            /// <summary>
            /// <para>The database gateway ID of the stress testing machine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>58598b2af48a0193dfc16fc6964ef****</para>
            /// </summary>
            [NameInMap("ClientGatewayId")]
            [Validation(Required=false)]
            public string ClientGatewayId { get; set; }

            /// <summary>
            /// <para>The type of the stress testing machine. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ECS</b>: You need to prepare the <a href="https://help.aliyun.com/document_detail/64905.html">Database Gateway</a> on your own.</description></item>
            /// <item><description><b>DAS_ECS</b>: an ECS instance automatically purchased and deployed by DAS.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ECS</para>
            /// </summary>
            [NameInMap("ClientType")]
            [Validation(Required=false)]
            public string ClientType { get; set; }

            /// <summary>
            /// <para>The description of the stress testing task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-das-bench-0501</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The unique identity of the target instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hdm_d887b5ccf99fa0dc9a1e5aaac368****</para>
            /// </summary>
            [NameInMap("DstInstanceUuid")]
            [Validation(Required=false)]
            public string DstInstanceUuid { get; set; }

            /// <summary>
            /// <para>The reserved parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("DstIp")]
            [Validation(Required=false)]
            public string DstIp { get; set; }

            /// <summary>
            /// <para>The port of the target instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3306</para>
            /// </summary>
            [NameInMap("DstPort")]
            [Validation(Required=false)]
            public int? DstPort { get; set; }

            /// <summary>
            /// <para>The type of the target instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Instance</b> (default): instance ID.</description></item>
            /// <item><description><b>ConnectionString</b>: endpoint of the instance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Instance</para>
            /// </summary>
            [NameInMap("DstType")]
            [Validation(Required=false)]
            public string DstType { get; set; }

            /// <summary>
            /// <para>The DTS task specification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>medium</para>
            /// </summary>
            [NameInMap("DtsJobClass")]
            [Validation(Required=false)]
            public string DtsJobClass { get; set; }

            /// <summary>
            /// <para>The ID of the DTS migration task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i03e3zty16i****</para>
            /// </summary>
            [NameInMap("DtsJobId")]
            [Validation(Required=false)]
            public string DtsJobId { get; set; }

            /// <summary>
            /// <para>The name of the Data Transmission Service (DTS) task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Migration between RDS instances</para>
            /// </summary>
            [NameInMap("DtsJobName")]
            [Validation(Required=false)]
            public string DtsJobName { get; set; }

            /// <summary>
            /// <para>The DTS task state. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>NOT_STARTED</b>: not started.</description></item>
            /// <item><description><b>PRE_CHECKING</b>: precheck in progress.</description></item>
            /// <item><description><b>PRE_CHECK_FAILED</b>: precheck failed.</description></item>
            /// <item><description><b>CHECKING</b>: checking.</description></item>
            /// <item><description><b>MIGRATING</b>: migrating.</description></item>
            /// <item><description><b>CATCHED</b>: caught up.</description></item>
            /// <item><description><b>SUSPENDING</b>: suspending.</description></item>
            /// <item><description><b>MIGRATION_FAILED</b>: migration failed.</description></item>
            /// <item><description><b>FINISHED</b>: completed.</description></item>
            /// <item><description><b>INITIALIZING</b>: synchronization initializing.</description></item>
            /// <item><description><b>INITIALIZE_FAILED</b>: synchronization initialization failed.</description></item>
            /// <item><description><b>SYNCHRONIZING</b>: synchronizing.</description></item>
            /// <item><description><b>MODIFYING</b>: modifying synchronization objects.</description></item>
            /// <item><description><b>SWITCHING</b>: switching.</description></item>
            /// <item><description><b>FAILED</b>: failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CHECKING</para>
            /// </summary>
            [NameInMap("DtsJobState")]
            [Validation(Required=false)]
            public int? DtsJobState { get; set; }

            /// <summary>
            /// <para>The DTS task state. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>NOT_STARTED</b>: not started.</description></item>
            /// <item><description><b>PRE_CHECKING</b>: precheck in progress.</description></item>
            /// <item><description><b>PRE_CHECK_FAILED</b>: precheck failed.</description></item>
            /// <item><description><b>CHECKING</b>: checking.</description></item>
            /// <item><description><b>MIGRATING</b>: migrating.</description></item>
            /// <item><description><b>CATCHED</b>: caught up.</description></item>
            /// <item><description><b>SUSPENDING</b>: suspending.</description></item>
            /// <item><description><b>MIGRATION_FAILED</b>: migration failed.</description></item>
            /// <item><description><b>FINISHED</b>: completed.</description></item>
            /// <item><description><b>INITIALIZING</b>: synchronization initializing.</description></item>
            /// <item><description><b>INITIALIZE_FAILED</b>: synchronization initialization failed.</description></item>
            /// <item><description><b>SYNCHRONIZING</b>: synchronizing.</description></item>
            /// <item><description><b>MODIFYING</b>: modifying synchronization objects.</description></item>
            /// <item><description><b>SWITCHING</b>: switching.</description></item>
            /// <item><description><b>FAILED</b>: failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PRE_CHECKING</para>
            /// </summary>
            [NameInMap("DtsJobStatus")]
            [Validation(Required=false)]
            public string DtsJobStatus { get; set; }

            /// <summary>
            /// <para>The ECS instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp1ecr5go2go1****</para>
            /// </summary>
            [NameInMap("EcsInstanceId")]
            [Validation(Required=false)]
            public string EcsInstanceId { get; set; }

            /// <summary>
            /// <para>The state after the stress testing task ends. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>WAIT_TARGET</b>: preparing the target instance for stress testing.</description></item>
            /// <item><description><b>WAIT_DBGATEWAY</b>: preparing the stress testing deployment.</description></item>
            /// <item><description><b>WAIT_SQL</b>: preparing full SQL.</description></item>
            /// <item><description><b>WAIT_LOGIC</b>: preparing to start traffic replay.</description></item>
            /// </list>
            /// <remarks>
            /// <para>After the stress testing task executes the state specified by EndState, the task directly reaches the completed state.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>WAIT_LOGIC</para>
            /// </summary>
            [NameInMap("EndState")]
            [Validation(Required=false)]
            public string EndState { get; set; }

            /// <summary>
            /// <para>The error code returned by the internal stress testing task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10910</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The error message returned when the task fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DTS-070211: Connect Source DB failed. cause by [com.mysql.jdbc.exceptions.jdbc4.MySQLNonTransientConnectionException:Could not create connection to database server. Attempted reconnect 3 times. Giving up.][com.mysql.jdbc.exceptions.jdbc4.CommunicationsException:Communications link failure\n\nThe last packet sent successfully to the server was 0 milliseconds ago. The driver has not received any packets from the server.][java.net.ConnectException:Connection timed out (Connection timed out)] About more information in [<a href="https://yq.aliyun.com/articles/499178%5D">https://yq.aliyun.com/articles/499178]</a>.</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The additional information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Null</para>
            /// </summary>
            [NameInMap("External")]
            [Validation(Required=false)]
            public string External { get; set; }

            /// <summary>
            /// <para>The stress testing rate multiplier. The replay rate must be a positive integer. Valid values: <b>0</b> to <b>30</b>. Default value: <b>1</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Rate")]
            [Validation(Required=false)]
            public long? Rate { get; set; }

            /// <summary>
            /// <para>The duration of the stress testing task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>864000</para>
            /// </summary>
            [NameInMap("RequestDuration")]
            [Validation(Required=false)]
            public long? RequestDuration { get; set; }

            /// <summary>
            /// <para>The generated stress testing duration. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>86400000</para>
            /// </summary>
            [NameInMap("SmartPressureTime")]
            [Validation(Required=false)]
            public int? SmartPressureTime { get; set; }

            /// <summary>
            /// <para>The task source. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>DAS</b>.</description></item>
            /// <item><description><b>OPEN_API</b>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DAS</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The reuse information of the full SQL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;sqlUuid&quot;:&quot;task_a37d2f07-45cb-<b><b>-a2a6-c66c62</b></b>&quot;,&quot;metaUuid&quot;:&quot;task_211e2561-5c0c-486b-864c-56b511****&quot;,&quot;sqlFile&quot;:&quot;cl-1620057600000-1800626.sc&quot;,&quot;metaFile&quot;:&quot;cl-1620057600000-180****.meta&quot;}</para>
            /// </summary>
            [NameInMap("SqlCompleteReuse")]
            [Validation(Required=false)]
            public string SqlCompleteReuse { get; set; }

            /// <summary>
            /// <para>The database type of the source instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RDS</para>
            /// </summary>
            [NameInMap("SrcInstanceArea")]
            [Validation(Required=false)]
            public string SrcInstanceArea { get; set; }

            /// <summary>
            /// <para>The UUID of the source instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a364e414-e68b-4e5c-9166-65b3a153****</para>
            /// </summary>
            [NameInMap("SrcInstanceUuid")]
            [Validation(Required=false)]
            public string SrcInstanceUuid { get; set; }

            /// <summary>
            /// <para>The reserved parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("SrcPublicIp")]
            [Validation(Required=false)]
            public string SrcPublicIp { get; set; }

            /// <summary>
            /// <para>The current state of the stress testing task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>WAIT_TARGET</b>: preparing the target instance for stress testing.</description></item>
            /// <item><description><b>WAIT_DBGATEWAY</b>: preparing the stress testing deployment.</description></item>
            /// <item><description><b>WAIT_SQL</b>: preparing full SQL.</description></item>
            /// <item><description><b>WAIT_LOGIC</b>: preparing to start traffic replay.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>WAIT_TARGET</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The running status of the stress testing task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>SUCCESS</b>: successful.</description></item>
            /// <item><description><b>IGNORED</b>: ignored.</description></item>
            /// <item><description><b>RUNNING</b>: running.</description></item>
            /// <item><description><b>EXCEPTION</b>: abnormal.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The table names involved in the stress testing task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;TABLE_NAME&quot;:&quot;customer1&quot;,&quot;TABLE_SCHEMA&quot;:&quot;tpcc&quot;}]</para>
            /// </summary>
            [NameInMap("TableSchema")]
            [Validation(Required=false)]
            public string TableSchema { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>e5cec704-0518-430f-8263-76f4dcds****</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The type of the stress testing task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>pressure test</b> (default): intelligent stress testing. The traffic captured from the target instance is replayed on the destination instance at the maximum speed supported by the destination instance specifications.</description></item>
            /// <item><description><b>smart pressure test</b>: generated stress testing. By analyzing and learning the traffic captured from the target instance within a short period of time, traffic that is consistent with the business model and traffic distribution of the original traffic is generated for continuous stress testing. This reduces the time required to collect data from the target instance and lowers storage costs and performance overhead.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>pressure test</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// <para>The Kafka consumption topic.</para>
            /// 
            /// <b>Example:</b>
            /// <para>das</para>
            /// </summary>
            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }

            /// <summary>
            /// <para>The Alibaba Cloud account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>109141182625****</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The version of the stress testing task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>V2.0</b></description></item>
            /// <item><description><b>V3.0</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>V3.0</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// <para>The temporary directory generated by the stress testing task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/tmp/bench/</para>
            /// </summary>
            [NameInMap("WorkDir")]
            [Validation(Required=false)]
            public string WorkDir { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// <remarks>
        /// <para>If the request is successful, <b>Successful</b> is returned. If the request fails, an error message is returned, such as an error code.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B6D17591-B48B-4D31-9CD6-9B9796B2****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request is successful.</description></item>
        /// <item><description><b>false</b>: The request fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
