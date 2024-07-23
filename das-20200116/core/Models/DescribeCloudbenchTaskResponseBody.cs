// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.DAS20200116.Models
{
    public class DescribeCloudbenchTaskResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The detailed information, including the error codes and the number of entries that are returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeCloudbenchTaskResponseBodyData Data { get; set; }
        public class DescribeCloudbenchTaskResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the archiving task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>\&quot;202105211430070112231480820340758****</para>
            /// </summary>
            [NameInMap("ArchiveJobId")]
            [Validation(Required=false)]
            public string ArchiveJobId { get; set; }

            /// <summary>
            /// <para>The name of the table that was archived to Object Storage Service (OSS).</para>
            /// 
            /// <b>Example:</b>
            /// <para>custins15546355_161604665****</para>
            /// </summary>
            [NameInMap("ArchiveOssTableName")]
            [Validation(Required=false)]
            public string ArchiveOssTableName { get; set; }

            /// <summary>
            /// <para>The archiving state of the file that stores the analysis result of full SQL statistics. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: The file archiving is not started.</description></item>
            /// <item><description><b>1</b>: The file is archived.</description></item>
            /// <item><description><b>2</b>: An error occurred.</description></item>
            /// <item><description><b>3</b>: The file is being archived.</description></item>
            /// <item><description><b>4</b>: The archived file does not need to be downloaded.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ArchiveState")]
            [Validation(Required=false)]
            public int? ArchiveState { get; set; }

            /// <summary>
            /// <para>The ID of the backup set. You can call the <a href="https://help.aliyun.com/document_detail/26273.html">DescribeBackups</a> operation to query the ID of the backup set.</para>
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
            /// <item><description><b>TIMESTAMP</b></description></item>
            /// <item><description><b>BACKUPID</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>TIMESTAMP</para>
            /// </summary>
            [NameInMap("BackupType")]
            [Validation(Required=false)]
            public string BackupType { get; set; }

            /// <summary>
            /// <para>The substep in the stress testing task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>NEW</b>: initializes the stress testing task.</description></item>
            /// <item><description><b>WAIT_BUY_ECS</b>: purchases an ECS instance.</description></item>
            /// <item><description><b>WAIT_START_ECS</b>: starts an ECS instance.</description></item>
            /// <item><description><b>WAIT_INSTALL_JDK</b>: installs the Java Development Kit (JDK).</description></item>
            /// <item><description><b>WAIT_INSTALL_DBGATEWAY</b>: installs the database gateway (DBGateway).</description></item>
            /// <item><description><b>ADD_SECURITY_IPS_STEP</b>: configure a security group whitelist.</description></item>
            /// <item><description><b>ARCHIVE</b>: archives the full SQL statistics.</description></item>
            /// <item><description><b>DOWNLOAD</b>: downloads the file that stores the analysis result of full SQL statistics.</description></item>
            /// <item><description><b>PROCEED</b>: preprocesses the file that stores the analysis result of full SQL statistics.</description></item>
            /// <item><description><b>PRE_LOAD</b>: preloads the file that stores the analysis result of full SQL statistics.</description></item>
            /// <item><description><b>VALIDATE</b>: verifies the functionality of stress testing.</description></item>
            /// <item><description><b>PRESSURE</b>: starts the stress testing task.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PROCEED</para>
            /// </summary>
            [NameInMap("BenchStep")]
            [Validation(Required=false)]
            public string BenchStep { get; set; }

            /// <summary>
            /// <para>The status that indicates the substep performed on the stress testing task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>NEW</b>: The task is being initialized.</description></item>
            /// <item><description><b>RUNNING</b>: The task is running.</description></item>
            /// <item><description><b>FAILED</b>: The task failed.</description></item>
            /// <item><description><b>FINISHED</b>: The task is complete.</description></item>
            /// <item><description><b>Terminated</b>: The task is terminated.</description></item>
            /// <item><description><b>Deleted</b>: The task is deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>FINISHED</para>
            /// </summary>
            [NameInMap("BenchStepStatus")]
            [Validation(Required=false)]
            public string BenchStepStatus { get; set; }

            /// <summary>
            /// <para>The DBGateway ID of the stress testing client.</para>
            /// 
            /// <b>Example:</b>
            /// <para>58598b2af48a0193dfc16fc6964ef****</para>
            /// </summary>
            [NameInMap("ClientGatewayId")]
            [Validation(Required=false)]
            public string ClientGatewayId { get; set; }

            /// <summary>
            /// <para>The type of the stress testing client. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ECS</b>: indicates that you must create the <a href="https://help.aliyun.com/document_detail/64905.html">DBGateway</a>.</description></item>
            /// <item><description><b>DAS_ECS</b>: indicates that DAS automatically purchases and deploys an ECS instance for stress testing.</description></item>
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
            /// <para>The UUID of the destination instance.</para>
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
            /// <para>The port number of the destination instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3306</para>
            /// </summary>
            [NameInMap("DstPort")]
            [Validation(Required=false)]
            public int? DstPort { get; set; }

            /// <summary>
            /// <para>The type of the identifier that is used to indicate the destination instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Instance</b> (default): the instance ID.</description></item>
            /// <item><description><b>ConnectionString</b>: the endpoint of the instance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Instance</para>
            /// </summary>
            [NameInMap("DstType")]
            [Validation(Required=false)]
            public string DstType { get; set; }

            /// <summary>
            /// <para>The specification of the DTS task.</para>
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
            /// <para>RDS_TO_RDS_MIGRATION</para>
            /// </summary>
            [NameInMap("DtsJobName")]
            [Validation(Required=false)]
            public string DtsJobName { get; set; }

            /// <summary>
            /// <para>The state of the DTS task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>NOT_STARTED</b>: The task is not started.</description></item>
            /// <item><description><b>PRE_CHECKING</b>: The task is in precheck.</description></item>
            /// <item><description><b>PRE_CHECK_FAILED</b>: The precheck failed.</description></item>
            /// <item><description><b>CHECKING</b>: The task is being checked.</description></item>
            /// <item><description><b>MIGRATING</b>: The data is being migrated.</description></item>
            /// <item><description><b>CATCHED</b>: The data is migrated from the source instance to the destination instance.</description></item>
            /// <item><description><b>SUSPENDING</b>: The task is suspended.</description></item>
            /// <item><description><b>MIGRATION_FAILED</b>: The data failed to be migrated.</description></item>
            /// <item><description><b>FINISHED</b>: The task is complete.</description></item>
            /// <item><description><b>INITIALIZING</b>: The synchronization is being initialized.</description></item>
            /// <item><description><b>INITIALIZE_FAILED</b>: The synchronization failed to be initialized.</description></item>
            /// <item><description><b>SYNCHRONIZING</b>: The data is being synchronized.</description></item>
            /// <item><description><b>MODIFYING</b>: The objects to be synchronized are being changed.</description></item>
            /// <item><description><b>SWITCHING</b>: The roles of the instances are being switched.</description></item>
            /// <item><description><b>FAILED</b>: The task failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CHECKING</para>
            /// </summary>
            [NameInMap("DtsJobState")]
            [Validation(Required=false)]
            public int? DtsJobState { get; set; }

            /// <summary>
            /// <para>The state of the DTS task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>NOT_STARTED</b>: The task is not started.</description></item>
            /// <item><description><b>PRE_CHECKING</b>: The task is in precheck.</description></item>
            /// <item><description><b>PRE_CHECK_FAILED</b>: The precheck failed.</description></item>
            /// <item><description><b>CHECKING</b>: The task is being checked.</description></item>
            /// <item><description><b>MIGRATING</b>: The data is being migrated.</description></item>
            /// <item><description><b>CATCHED</b>: The data is migrated from the source instance to the destination instance.</description></item>
            /// <item><description><b>SUSPENDING</b>: The task is suspended.</description></item>
            /// <item><description><b>MIGRATION_FAILED</b>: The data failed to be migrated.</description></item>
            /// <item><description><b>FINISHED</b>: The task is complete.</description></item>
            /// <item><description><b>INITIALIZING</b>: The synchronization is being initialized.</description></item>
            /// <item><description><b>INITIALIZE_FAILED</b>: The synchronization failed to be initialized.</description></item>
            /// <item><description><b>SYNCHRONIZING</b>: The data is being synchronized.</description></item>
            /// <item><description><b>MODIFYING</b>: The objects to be synchronized are being changed.</description></item>
            /// <item><description><b>SWITCHING</b>: The roles of the instances are being switched.</description></item>
            /// <item><description><b>FAILED</b>: The task failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PRE_CHECKING</para>
            /// </summary>
            [NameInMap("DtsJobStatus")]
            [Validation(Required=false)]
            public string DtsJobStatus { get; set; }

            /// <summary>
            /// <para>The ID of the Elastic Compute Service (ECS) instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-bp1ecr5go2go1****</para>
            /// </summary>
            [NameInMap("EcsInstanceId")]
            [Validation(Required=false)]
            public string EcsInstanceId { get; set; }

            /// <summary>
            /// <para>The state that specifies the last operation that is performed for the stress testing task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>WAIT_TARGET</b>: prepares the destination instance.</description></item>
            /// <item><description><b>WAIT_DBGATEWAY</b>: prepares the DBGateway.</description></item>
            /// <item><description><b>WAIT_SQL</b>: prepares the full SQL statistics.</description></item>
            /// <item><description><b>WAIT_LOGIC</b>: prepares to replay the traffic.</description></item>
            /// </list>
            /// <remarks>
            /// <para> When the state of a stress testing task changes to the state that is specified by the EndState parameter, the stress testing task becomes completed.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>WAIT_LOGIC</para>
            /// </summary>
            [NameInMap("EndState")]
            [Validation(Required=false)]
            public string EndState { get; set; }

            /// <summary>
            /// <para>The error code returned for the substep of the stress testing task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10910</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The error message returned if the request failed.</para>
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
            /// <para>The rate at which the stress testing task replayed the traffic. The value is a positive integer. Valid values:<b>1</b> to <b>30</b>. Default value: <b>1</b>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Rate")]
            [Validation(Required=false)]
            public long? Rate { get; set; }

            /// <summary>
            /// <para>The duration of the stress testing task for which traffic was captured from the source instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>864000</para>
            /// </summary>
            [NameInMap("RequestDuration")]
            [Validation(Required=false)]
            public long? RequestDuration { get; set; }

            /// <summary>
            /// <para>The duration of the stress testing task for which the traffic was generated on the destination instance. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>86400000</para>
            /// </summary>
            [NameInMap("SmartPressureTime")]
            [Validation(Required=false)]
            public int? SmartPressureTime { get; set; }

            /// <summary>
            /// <para>The source of the task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>DAS</b></description></item>
            /// <item><description><b>OPEN_API</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DAS</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The reuse information about the analysis result of full SQL statistics.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;sqlUuid&quot;:&quot;task_a37d2f07-45cb-<b><b>-a2a6-c66c62</b></b>&quot;,&quot;metaUuid&quot;:&quot;task_211e2561-5c0c-486b-864c-56b511****&quot;,&quot;sqlFile&quot;:&quot;cl-1620057600000-1800626.sc&quot;,&quot;metaFile&quot;:&quot;cl-1620057600000-180****.meta&quot;}</para>
            /// </summary>
            [NameInMap("SqlCompleteReuse")]
            [Validation(Required=false)]
            public string SqlCompleteReuse { get; set; }

            /// <summary>
            /// <para>The database type of the source instance. Valid values:</para>
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
            /// <para>The state that indicates the operation performed for the stress testing task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>WAIT_TARGET</b>: prepares the destination instance.</description></item>
            /// <item><description><b>WAIT_DBGATEWAY</b>: prepares the DBGateway.</description></item>
            /// <item><description><b>WAIT_SQL</b>: prepares the full SQL statistics.</description></item>
            /// <item><description><b>WAIT_LOGIC</b>: prepares to replay the traffic.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>WAIT_TARGET</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The state of the stress testing task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>SUCCESS</b>: The task is successful.</description></item>
            /// <item><description><b>IGNORED</b>: The task is ignored.</description></item>
            /// <item><description><b>RUNNING</b>: The task is running.</description></item>
            /// <item><description><b>EXCEPTION</b>: An error occurred.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The name of the table that is used for stress testing.</para>
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
            /// <item><description><b>pressure test</b> (default): A task of this type replays the traffic that is captured from the source instance on the destination instance at the maximum playback rate that is supported by the destination instance.</description></item>
            /// <item><description><b>smart pressure test</b>: A task of this type analyzes the traffic that is captured from the source instance over a short period of time and generates traffic on the destination instance for continuous stress testing. The business model based on which the traffic is generated on the destination instance and the traffic distribution are consistent with those on the source instance. Stress testing tasks of this type can help you reduce the amount of time that is consumed to collect data from the source instance and reduce storage costs and performance overheads.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>pressure test</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

            /// <summary>
            /// <para>The topic that contains the consumed data. This topic is a topic in Message Queue for Apache Kafka.</para>
            /// 
            /// <b>Example:</b>
            /// <para>das</para>
            /// </summary>
            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account.</para>
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
        /// <para> If the request was successful, <b>Successful</b> is returned. If the request failed, an error message such as an error code is returned.</para>
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
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The request was successful.</description></item>
        /// <item><description><b>false</b>: The request failed.</description></item>
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
