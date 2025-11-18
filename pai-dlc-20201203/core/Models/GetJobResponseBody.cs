// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class GetJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The visibility of the job. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PUBLIC: The code is public in the workspace.</description></item>
        /// <item><description>PRIVATE: The workspace is visible only to you and the administrator of the workspace. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PRIVATE</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a*****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The code source.</para>
        /// </summary>
        [NameInMap("CodeSource")]
        [Validation(Required=false)]
        public GetJobResponseBodyCodeSource CodeSource { get; set; }
        public class GetJobResponseBodyCodeSource : TeaModel {
            /// <summary>
            /// <para>The code branch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>master</para>
            /// </summary>
            [NameInMap("Branch")]
            [Validation(Required=false)]
            public string Branch { get; set; }

            /// <summary>
            /// <para>The code source ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>code******</para>
            /// </summary>
            [NameInMap("CodeSourceId")]
            [Validation(Required=false)]
            public string CodeSourceId { get; set; }

            /// <summary>
            /// <para>The code commit ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>44da109b59f8596152987eaa8f3b2487xxxxxx</para>
            /// </summary>
            [NameInMap("Commit")]
            [Validation(Required=false)]
            public string Commit { get; set; }

            /// <summary>
            /// <para>The local mount path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/mnt/data</para>
            /// </summary>
            [NameInMap("MountPath")]
            [Validation(Required=false)]
            public string MountPath { get; set; }

        }

        /// <summary>
        /// <para>The access credential configurations.</para>
        /// </summary>
        [NameInMap("CredentialConfig")]
        [Validation(Required=false)]
        public CredentialConfig CredentialConfig { get; set; }

        /// <summary>
        /// <para>The data sources.</para>
        /// </summary>
        [NameInMap("DataSources")]
        [Validation(Required=false)]
        public List<GetJobResponseBodyDataSources> DataSources { get; set; }
        public class GetJobResponseBodyDataSources : TeaModel {
            /// <summary>
            /// <para>The data source ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d*******</para>
            /// </summary>
            [NameInMap("DataSourceId")]
            [Validation(Required=false)]
            public string DataSourceId { get; set; }

            /// <summary>
            /// <para>The local mount path. This parameter is optional. The default value is empty, which specifies that the mount path in the data source is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/mnt/data/</para>
            /// </summary>
            [NameInMap("MountPath")]
            [Validation(Required=false)]
            public string MountPath { get; set; }

            /// <summary>
            /// <para>The data source URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://bucket.oss-cn-hangzhou-internal.aliyuncs.com/path/</para>
            /// </summary>
            [NameInMap("Uri")]
            [Validation(Required=false)]
            public string Uri { get; set; }

        }

        /// <summary>
        /// <para>The job name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tf-mnist-test</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>The duration of the job (seconds).</para>
        /// 
        /// <b>Example:</b>
        /// <para>3602</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public long? Duration { get; set; }

        /// <summary>
        /// <para>The elastic job parameters.</para>
        /// </summary>
        [NameInMap("ElasticSpec")]
        [Validation(Required=false)]
        public JobElasticSpec ElasticSpec { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the debugger job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnabledDebugger")]
        [Validation(Required=false)]
        public bool? EnabledDebugger { get; set; }

        /// <summary>
        /// <para>The configurations of environment variables.</para>
        /// </summary>
        [NameInMap("Envs")]
        [Validation(Required=false)]
        public Dictionary<string, string> Envs { get; set; }

        /// <summary>
        /// <para>The time when the job was created (UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-12T14:35:01Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>The time of the job failed (UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-12T15:36:08Z</para>
        /// </summary>
        [NameInMap("GmtFailedTime")]
        [Validation(Required=false)]
        public string GmtFailedTime { get; set; }

        /// <summary>
        /// <para>The time when the job ended (UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-12T15:36:08Z</para>
        /// </summary>
        [NameInMap("GmtFinishTime")]
        [Validation(Required=false)]
        public string GmtFinishTime { get; set; }

        /// <summary>
        /// <para>The start time of the job (UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-12T14:36:21Z</para>
        /// </summary>
        [NameInMap("GmtRunningTime")]
        [Validation(Required=false)]
        public string GmtRunningTime { get; set; }

        /// <summary>
        /// <para>The time when the job stopped (UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-12T15:36:08Z</para>
        /// </summary>
        [NameInMap("GmtStoppedTime")]
        [Validation(Required=false)]
        public string GmtStoppedTime { get; set; }

        /// <summary>
        /// <para>The time when the job was submitted to the cluster (UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-12T14:36:01Z</para>
        /// </summary>
        [NameInMap("GmtSubmittedTime")]
        [Validation(Required=false)]
        public string GmtSubmittedTime { get; set; }

        /// <summary>
        /// <para>The time when the job succeeded (UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-12T15:36:08Z</para>
        /// </summary>
        [NameInMap("GmtSuccessedTime")]
        [Validation(Required=false)]
        public string GmtSuccessedTime { get; set; }

        /// <summary>
        /// <para>The job ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dlc*******</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        [NameInMap("JobReplicaStatuses")]
        [Validation(Required=false)]
        public List<JobReplicaStatus> JobReplicaStatuses { get; set; }

        /// <summary>
        /// <para>The node configuration of the job, which is <b>JobSpecs</b> in the CreateJob operation.</para>
        /// </summary>
        [NameInMap("JobSpecs")]
        [Validation(Required=false)]
        public List<JobSpec> JobSpecs { get; set; }

        /// <summary>
        /// <para>The job type. Specified by the JobType parameter of the <a href="https://help.aliyun.com/document_detail/459672.html">CreateJob</a> operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TFJob</para>
        /// </summary>
        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        /// <summary>
        /// <para>All running nodes of the job.</para>
        /// </summary>
        [NameInMap("Pods")]
        [Validation(Required=false)]
        public List<GetJobResponseBodyPods> Pods { get; set; }
        public class GetJobResponseBodyPods : TeaModel {
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public double? Duration { get; set; }

            /// <summary>
            /// <para>The time when the node was created (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-01-12T14:36:01Z</para>
            /// </summary>
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            /// <summary>
            /// <para>The end time of the node (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-01-12T15:36:05Z</para>
            /// </summary>
            [NameInMap("GmtFinishTime")]
            [Validation(Required=false)]
            public string GmtFinishTime { get; set; }

            /// <summary>
            /// <para>The start time of the node (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-01-12T14:36:01Z</para>
            /// </summary>
            [NameInMap("GmtStartTime")]
            [Validation(Required=false)]
            public string GmtStartTime { get; set; }

            /// <summary>
            /// <para>The historical nodes.</para>
            /// </summary>
            [NameInMap("HistoryPods")]
            [Validation(Required=false)]
            public List<GetJobResponseBodyPodsHistoryPods> HistoryPods { get; set; }
            public class GetJobResponseBodyPodsHistoryPods : TeaModel {
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public double? Duration { get; set; }

                /// <summary>
                /// <para>The time when the node was created (UTC).</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-01-12T14:36:01Z</para>
                /// </summary>
                [NameInMap("GmtCreateTime")]
                [Validation(Required=false)]
                public string GmtCreateTime { get; set; }

                /// <summary>
                /// <para>The end time of the node (UTC).</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-01-12T14:36:01Z</para>
                /// </summary>
                [NameInMap("GmtFinishTime")]
                [Validation(Required=false)]
                public string GmtFinishTime { get; set; }

                /// <summary>
                /// <para>The start time of the node (UTC).</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-01-12T14:36:01Z</para>
                /// </summary>
                [NameInMap("GmtStartTime")]
                [Validation(Required=false)]
                public string GmtStartTime { get; set; }

                /// <summary>
                /// <para>The IP address of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.0.1.3</para>
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                /// <summary>
                /// <para>The ID of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Worker</para>
                /// </summary>
                [NameInMap("PodId")]
                [Validation(Required=false)]
                public string PodId { get; set; }

                [NameInMap("PodIps")]
                [Validation(Required=false)]
                public List<PodNetworkInterface> PodIps { get; set; }

                /// <summary>
                /// <para>The UID of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fe846462-af2c-4521-bd6f-96787a57591d</para>
                /// </summary>
                [NameInMap("PodUid")]
                [Validation(Required=false)]
                public string PodUid { get; set; }

                /// <summary>
                /// <para>The resource type of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// <para>The status of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Failed</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The sub-status of the node, such as its preemption status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Normal</description></item>
                /// <item><description>Evicted</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("SubStatus")]
                [Validation(Required=false)]
                public string SubStatus { get; set; }

                /// <summary>
                /// <para>The type of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Worker</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The IP address of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.1.2</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// <para>The node ID. It can be used in the GetPodLogs and GetPodEvents operations to obtain the detailed logs and events of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Worker</para>
            /// </summary>
            [NameInMap("PodId")]
            [Validation(Required=false)]
            public string PodId { get; set; }

            [NameInMap("PodIps")]
            [Validation(Required=false)]
            public List<PodNetworkInterface> PodIps { get; set; }

            /// <summary>
            /// <para>The UID of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fe846462-af2c-4521-bd6f-96787a57591d</para>
            /// </summary>
            [NameInMap("PodUid")]
            [Validation(Required=false)]
            public string PodUid { get; set; }

            /// <summary>
            /// <para>The resource type of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The status of the node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Pending</description></item>
            /// <item><description>Running</description></item>
            /// <item><description>Succeeded</description></item>
            /// <item><description>Failed</description></item>
            /// <item><description>Unknown</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The sub-status of the node, such as its preemption status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Normal</description></item>
            /// <item><description>Evicted</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("SubStatus")]
            [Validation(Required=false)]
            public string SubStatus { get; set; }

            /// <summary>
            /// <para>The node type, which corresponds to a specific JobSpec in JobSpecs of the CreateJob operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Worker</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The priority of the job. Valid values: 1 to 9.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The status detail code, which is a sub-status under the current status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>JobStoppedByUser</para>
        /// </summary>
        [NameInMap("ReasonCode")]
        [Validation(Required=false)]
        public string ReasonCode { get; set; }

        /// <summary>
        /// <para>The description of the status detail code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Job is stopped by user.</para>
        /// </summary>
        [NameInMap("ReasonMessage")]
        [Validation(Required=false)]
        public string ReasonMessage { get; set; }

        /// <summary>
        /// <para>The request ID, which can be used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-xxxxxxxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the job belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r******</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The resource level that the job uses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>L0</para>
        /// </summary>
        [NameInMap("ResourceLevel")]
        [Validation(Required=false)]
        public string ResourceLevel { get; set; }

        /// <summary>
        /// <para>The resource type. Valid values: ECS, Lingjun, and ACS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        [NameInMap("RestartRecord")]
        [Validation(Required=false)]
        public List<GetJobResponseBodyRestartRecord> RestartRecord { get; set; }
        public class GetJobResponseBodyRestartRecord : TeaModel {
            [NameInMap("DetailErrorInfoList")]
            [Validation(Required=false)]
            public List<GetJobResponseBodyRestartRecordDetailErrorInfoList> DetailErrorInfoList { get; set; }
            public class GetJobResponseBodyRestartRecordDetailErrorInfoList : TeaModel {
                [NameInMap("AddJobLevelBlacklist")]
                [Validation(Required=false)]
                public bool? AddJobLevelBlacklist { get; set; }

                [NameInMap("AddNodeToBlacklist")]
                [Validation(Required=false)]
                public bool? AddNodeToBlacklist { get; set; }

                [NameInMap("DetailErrorMsg")]
                [Validation(Required=false)]
                public string DetailErrorMsg { get; set; }

                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                [NameInMap("ErrorMsg")]
                [Validation(Required=false)]
                public string ErrorMsg { get; set; }

                [NameInMap("ErrorSource")]
                [Validation(Required=false)]
                public string ErrorSource { get; set; }

                [NameInMap("Node")]
                [Validation(Required=false)]
                public string Node { get; set; }

                [NameInMap("Pod")]
                [Validation(Required=false)]
                public string Pod { get; set; }

                [NameInMap("TriggerRestart")]
                [Validation(Required=false)]
                public bool? TriggerRestart { get; set; }

            }

            [NameInMap("JobRestartCount")]
            [Validation(Required=false)]
            public long? JobRestartCount { get; set; }

            [NameInMap("OccurPhase")]
            [Validation(Required=false)]
            public string OccurPhase { get; set; }

            [NameInMap("OccurTime")]
            [Validation(Required=false)]
            public string OccurTime { get; set; }

            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            [NameInMap("RestartDurationInSec")]
            [Validation(Required=false)]
            public long? RestartDurationInSec { get; set; }

            [NameInMap("RestartFailReason")]
            [Validation(Required=false)]
            public string RestartFailReason { get; set; }

            [NameInMap("RestartStatus")]
            [Validation(Required=false)]
            public string RestartStatus { get; set; }

            [NameInMap("TriggerID")]
            [Validation(Required=false)]
            public string TriggerID { get; set; }

        }

        /// <summary>
        /// <para>The number of retries and the maximum number of retries used by the job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0/10</para>
        /// </summary>
        [NameInMap("RestartTimes")]
        [Validation(Required=false)]
        public string RestartTimes { get; set; }

        /// <summary>
        /// <para>The additional parameter configurations of the job.</para>
        /// </summary>
        [NameInMap("Settings")]
        [Validation(Required=false)]
        public JobSettings Settings { get; set; }

        /// <summary>
        /// <para>The status of the job. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Creating</description></item>
        /// <item><description>Queuing</description></item>
        /// <item><description>Bidding (Only for Lingjun preemptible jobs)</description></item>
        /// <item><description>EnvPreparing</description></item>
        /// <item><description>SanityChecking</description></item>
        /// <item><description>Running</description></item>
        /// <item><description>Restarting</description></item>
        /// <item><description>Stopping</description></item>
        /// <item><description>SucceededReserving</description></item>
        /// <item><description>FailedReserving</description></item>
        /// <item><description>Succeeded</description></item>
        /// <item><description>Failed</description></item>
        /// <item><description>Stopped</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Stopped</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The status history.</para>
        /// </summary>
        [NameInMap("StatusHistory")]
        [Validation(Required=false)]
        public List<StatusTransitionItem> StatusHistory { get; set; }

        /// <summary>
        /// <para>The sub-status of the job, such as its preemption status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Restarting</para>
        /// </summary>
        [NameInMap("SubStatus")]
        [Validation(Required=false)]
        public string SubStatus { get; set; }

        /// <summary>
        /// <para>The tenant ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GAR***W134</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The directory that contains requirements.txt.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/root/code/</para>
        /// </summary>
        [NameInMap("ThirdpartyLibDir")]
        [Validation(Required=false)]
        public string ThirdpartyLibDir { get; set; }

        /// <summary>
        /// <para>The third-party Python libraries to be installed.</para>
        /// </summary>
        [NameInMap("ThirdpartyLibs")]
        [Validation(Required=false)]
        public List<string> ThirdpartyLibs { get; set; }

        /// <summary>
        /// <para>The command that is run to start each node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>python /root/code/mnist.py</para>
        /// </summary>
        [NameInMap("UserCommand")]
        [Validation(Required=false)]
        public string UserCommand { get; set; }

        /// <summary>
        /// <para>The UID of the Alibaba Cloud account who submitted the job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12*********</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The VPC of the user.</para>
        /// </summary>
        [NameInMap("UserVpc")]
        [Validation(Required=false)]
        public GetJobResponseBodyUserVpc UserVpc { get; set; }
        public class GetJobResponseBodyUserVpc : TeaModel {
            /// <summary>
            /// <para>The default router. This parameter is valid only for general-purpose computing resources. Valid values:</para>
            /// <para>eth0: The default network interface is used to access the Internet through the public gateway. eth1: The user\&quot;s Elastic Network Interface is used to access the Internet through the private gateway.</para>
            /// </summary>
            [NameInMap("DefaultRoute")]
            [Validation(Required=false)]
            public string DefaultRoute { get; set; }

            /// <summary>
            /// <para>The extended CIDR block. Example: 192.168.0.1/24.</para>
            /// </summary>
            [NameInMap("ExtendedCidrs")]
            [Validation(Required=false)]
            public List<string> ExtendedCidrs { get; set; }

            /// <summary>
            /// <para>The security group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-abcdef****</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The vSwitch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vs-abcdef****</para>
            /// </summary>
            [NameInMap("SwitchId")]
            [Validation(Required=false)]
            public string SwitchId { get; set; }

            /// <summary>
            /// <para>The VPC ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-abcdef****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the workspace to which the job belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>268</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// <para>The name of the workspace to which the job belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dlc-workspace</para>
        /// </summary>
        [NameInMap("WorkspaceName")]
        [Validation(Required=false)]
        public string WorkspaceName { get; set; }

    }

}
