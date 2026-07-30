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
        /// <para>The list of detailed information, including the total number of information items and error codes.</para>
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
            /// <para>The OSS table name for archiving.</para>
            /// 
            /// <b>Example:</b>
            /// <para>custins15546355_161604665****</para>
            /// </summary>
            [NameInMap("ArchiveOssTableName")]
            [Validation(Required=false)]
            public string ArchiveOssTableName { get; set; }

            /// <summary>
            /// <para>The SQL archiving status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: Not started.</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: Completed.</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: Error.</para>
            /// </description></item>
            /// <item><description><para><b>3</b>: Running.</para>
            /// </description></item>
            /// <item><description><para><b>4</b>: No download required.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ArchiveState")]
            [Validation(Required=false)]
            public int? ArchiveState { get; set; }

            /// <summary>
            /// <para>The backup set ID. You can obtain it by calling the <a href="https://help.aliyun.com/document_detail/26273.html">DescribeBackups</a> operation to query the backup list.</para>
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
            /// <item><description><para><b>TIMESTAMP</b>: By backup time.</para>
            /// </description></item>
            /// <item><description><para><b>BACKUPID</b>: By backup set ID.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TIMESTAMP</para>
            /// </summary>
            [NameInMap("BackupType")]
            [Validation(Required=false)]
            public string BackupType { get; set; }

            /// <summary>
            /// <para>The substep of stress testing. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>NEW</b>: task initialization.</para>
            /// </description></item>
            /// <item><description><para><b>WAIT_BUY_ECS</b>: purchase a new ECS instance.</para>
            /// </description></item>
            /// <item><description><para><b>WAIT_START_ECS</b>: start the ECS instance.</para>
            /// </description></item>
            /// <item><description><para><b>WAIT_INSTALL_JDK</b>: install JDK.</para>
            /// </description></item>
            /// <item><description><para><b>WAIT_INSTALL_DBGATEWAY</b>: install Database Gateway.</para>
            /// </description></item>
            /// <item><description><para><b>ADD_SECURITY_IPS_STEP</b>: configure security group whitelist.</para>
            /// </description></item>
            /// <item><description><para><b>ARCHIVE</b>: full SQL archiving.</para>
            /// </description></item>
            /// <item><description><para><b>DOWNLOAD</b>: download the full SQL file.</para>
            /// </description></item>
            /// <item><description><para><b>PROCEED</b>: pre-process the full SQL file.</para>
            /// </description></item>
            /// <item><description><para><b>PRE_LOAD</b>: preload the full SQL file.</para>
            /// </description></item>
            /// <item><description><para><b>VALIDATE</b>: feature validation.</para>
            /// </description></item>
            /// <item><description><para><b>PRESSURE</b>: performance stress testing.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PROCEED</para>
            /// </summary>
            [NameInMap("BenchStep")]
            [Validation(Required=false)]
            public string BenchStep { get; set; }

            /// <summary>
            /// <para>The status of the stress testing child step. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>NEW</b>: task initialization.</para>
            /// </description></item>
            /// <item><description><para><b>RUNNING</b>: executing.</para>
            /// </description></item>
            /// <item><description><para><b>FAILED</b>: failed.</para>
            /// </description></item>
            /// <item><description><para><b>FINISHED</b>: completed.</para>
            /// </description></item>
            /// <item><description><para><b>Terminated</b>: terminated.</para>
            /// </description></item>
            /// <item><description><para><b>Deleted</b>: deleted.</para>
            /// </description></item>
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
            /// <para>The stress testing machine type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>ECS</b>: You need to prepare your own <a href="https://help.aliyun.com/document_detail/64905.html">Database Gateway</a>.</para>
            /// </description></item>
            /// <item><description><para><b>DAS_ECS</b>: ECS automatically purchased and deployed by DAS.</para>
            /// </description></item>
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
            /// <para>The unique identifier of the destination instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hdm_d887b5ccf99fa0dc9a1e5aaac368****</para>
            /// </summary>
            [NameInMap("DstInstanceUuid")]
            [Validation(Required=false)]
            public string DstInstanceUuid { get; set; }

            /// <summary>
            /// <para>Reserved parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("DstIp")]
            [Validation(Required=false)]
            public string DstIp { get; set; }

            /// <summary>
            /// <para>The port of the destination instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3306</para>
            /// </summary>
            [NameInMap("DstPort")]
            [Validation(Required=false)]
            public int? DstPort { get; set; }

            /// <summary>
            /// <para>The type of the destination instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>Instance</b> (default): instance ID.</para>
            /// </description></item>
            /// <item><description><para><b>ConnectionString</b>: connection address of the instance.</para>
            /// </description></item>
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
            /// <para>The DTS migration task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i03e3zty16i****</para>
            /// </summary>
            [NameInMap("DtsJobId")]
            [Validation(Required=false)]
            public string DtsJobId { get; set; }

            /// <summary>
            /// <para>The DTS task name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Migration between RDS instances</para>
            /// </summary>
            [NameInMap("DtsJobName")]
            [Validation(Required=false)]
            public string DtsJobName { get; set; }

            /// <summary>
            /// <para>The DTS task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>NOT_STARTED</b>: not started.</para>
            /// </description></item>
            /// <item><description><para><b>PRE_CHECKING</b>: precheck in progress.</para>
            /// </description></item>
            /// <item><description><para><b>PRE_CHECK_FAILED</b>: precheck failed.</para>
            /// </description></item>
            /// <item><description><para><b>CHECKING</b>: check in progress.</para>
            /// </description></item>
            /// <item><description><para><b>MIGRATING</b>: migration in progress.</para>
            /// </description></item>
            /// <item><description><para><b>CATCHED</b>: caught up.</para>
            /// </description></item>
            /// <item><description><para><b>SUSPENDING</b>: pausing.</para>
            /// </description></item>
            /// <item><description><para><b>MIGRATION_FAILED</b>: migration failed.</para>
            /// </description></item>
            /// <item><description><para><b>FINISHED</b>: completed.</para>
            /// </description></item>
            /// <item><description><para><b>INITIALIZING</b>: initial synchronization.</para>
            /// </description></item>
            /// <item><description><para><b>INITIALIZE_FAILED</b>: initial synchronization failed.</para>
            /// </description></item>
            /// <item><description><para><b>SYNCHRONIZING</b>: synchronization in progress.</para>
            /// </description></item>
            /// <item><description><para><b>MODIFYING</b>: synchronization object change in progress.</para>
            /// </description></item>
            /// <item><description><para><b>SWITCHING</b>: switching in progress.</para>
            /// </description></item>
            /// <item><description><para><b>FAILED</b>: failed.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CHECKING</para>
            /// </summary>
            [NameInMap("DtsJobState")]
            [Validation(Required=false)]
            public int? DtsJobState { get; set; }

            /// <summary>
            /// <para>The DTS task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>NOT_STARTED</b>: not started.</para>
            /// </description></item>
            /// <item><description><para><b>PRE_CHECKING</b>: lrecheck in progress.</para>
            /// </description></item>
            /// <item><description><para><b>PRE_CHECK_FAILED</b>: precheck failed.</para>
            /// </description></item>
            /// <item><description><para><b>CHECKING</b>: check in progress.</para>
            /// </description></item>
            /// <item><description><para><b>MIGRATING</b>: migration in progress.</para>
            /// </description></item>
            /// <item><description><para><b>CATCHED</b>: caught up.</para>
            /// </description></item>
            /// <item><description><para><b>SUSPENDING</b>: pausing.</para>
            /// </description></item>
            /// <item><description><para><b>MIGRATION_FAILED</b>: migration failed.</para>
            /// </description></item>
            /// <item><description><para><b>FINISHED</b>: completed.</para>
            /// </description></item>
            /// <item><description><para><b>INITIALIZING</b>: initial synchronization.</para>
            /// </description></item>
            /// <item><description><para><b>INITIALIZE_FAILED</b>: initial synchronization failed.</para>
            /// </description></item>
            /// <item><description><para><b>SYNCHRONIZING</b>: synchronization in progress.</para>
            /// </description></item>
            /// <item><description><para><b>MODIFYING</b>: synchronization object change in progress.</para>
            /// </description></item>
            /// <item><description><para><b>SWITCHING</b>: switching in progress.</para>
            /// </description></item>
            /// <item><description><para><b>FAILED</b>: failed.</para>
            /// </description></item>
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
            /// <para>The status after the stress testing task ends. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>WAIT_TARGET</b>: prepare the destination instance for stress testing.</para>
            /// </description></item>
            /// <item><description><para><b>WAIT_DBGATEWAY</b>: prepare for stress testing deployment.</para>
            /// </description></item>
            /// <item><description><para><b>WAIT_SQL</b>: prepare the full SQL.</para>
            /// </description></item>
            /// <item><description><para><b>WAIT_LOGIC</b>: prepare to start replaying traffic.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>When the stress testing task completes the status set in EndState, the task will directly reach the completed status.</para>
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
            /// <para>The error message for a failed task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DTS-070211: Connect Source DB failed. cause by [com.mysql.jdbc.exceptions.jdbc4.MySQLNonTransientConnectionException:Could not create connection to database server. Attempted reconnect 3 times. Giving up.][com.mysql.jdbc.exceptions.jdbc4.CommunicationsException:Communications link failure\n\nThe last packet sent successfully to the server was 0 milliseconds ago. The driver has not received any packets from the server.][java.net.ConnectException:Connection timed out (Connection timed out)] About more information in [<a href="https://yq.aliyun.com/articles/499178%5D">https://yq.aliyun.com/articles/499178]</a>.</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>Additional information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Null</para>
            /// </summary>
            [NameInMap("External")]
            [Validation(Required=false)]
            public string External { get; set; }

            /// <summary>
            /// <para>The stress testing multiplier. The replay multiplier must be a positive integer ranging from <b>0</b> to <b>30</b>. The default value is <b>1</b>.</para>
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
            /// <para>The generated stress testing time in milliseconds.</para>
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
            /// <item><description><para><b>DAS</b>.</para>
            /// </description></item>
            /// <item><description><para><b>OPEN_API</b>.</para>
            /// </description></item>
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
            /// <para>The unique identifier of the source instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a364e414-e68b-4e5c-9166-65b3a153****</para>
            /// </summary>
            [NameInMap("SrcInstanceUuid")]
            [Validation(Required=false)]
            public string SrcInstanceUuid { get; set; }

            /// <summary>
            /// <para>Reserved parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>None</para>
            /// </summary>
            [NameInMap("SrcPublicIp")]
            [Validation(Required=false)]
            public string SrcPublicIp { get; set; }

            /// <summary>
            /// <para>The current status of the stress testing task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>WAIT_TARGET</b>: prepare the destination instance for stress testing.</para>
            /// </description></item>
            /// <item><description><para><b>WAIT_DBGATEWAY</b>: prepare for stress testing deployment.</para>
            /// </description></item>
            /// <item><description><para><b>WAIT_SQL</b>: prepare the full SQL.</para>
            /// </description></item>
            /// <item><description><para><b>WAIT_LOGIC</b>: prepare to start replaying traffic.</para>
            /// </description></item>
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
            /// <item><description><para><b>SUCCESS</b>: successful.</para>
            /// </description></item>
            /// <item><description><para><b>IGNORED</b>: ignored.</para>
            /// </description></item>
            /// <item><description><para><b>RUNNING</b>: running.</para>
            /// </description></item>
            /// <item><description><para><b>EXCEPTION</b>: abnormal.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The table names involved in stress testing.</para>
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
            /// <para>The stress testing task type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>pressure test</b> (default): Intelligent stress testing. The traffic captured from the source instance is replayed on the destination instance at the maximum speed supported by the destination instance type.</para>
            /// </description></item>
            /// <item><description><para><b>smart pressure test</b>: Generated stress testing. By analyzing and learning the traffic captured from the source instance in a short period of time, traffic with business models and traffic distribution similar to the original traffic is generated for continuous stress testing. This reduces the time required to collect data from the source instance and lowers storage costs and performance overhead.</para>
            /// </description></item>
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
            /// <para>The stress testing task version. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>V2.0</b></para>
            /// </description></item>
            /// <item><description><para><b>V3.0</b></para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>V3.0</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

            /// <summary>
            /// <para>The temporary directory generated for stress testing.</para>
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
        /// <list type="bullet">
        /// <item><description><para>When the request is successful, this parameter returns <b>Successful</b>.</para>
        /// </description></item>
        /// <item><description><para>When the request fails, this parameter returns exception information such as error codes.</para>
        /// </description></item>
        /// </list>
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
        /// <para>Indicates whether the request was successful:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The request was successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The request failed.</para>
        /// </description></item>
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
