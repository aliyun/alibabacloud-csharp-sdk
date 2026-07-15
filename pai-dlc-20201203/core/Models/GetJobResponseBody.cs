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
        /// <item><description>PUBLIC: Visible to all members in the workspace.</description></item>
        /// <item><description>PRIVATE (default): Visible only to you and administrators in the workspace.</description></item>
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
            /// <para>The code commit ID.</para>
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
        /// <para>The access credential configuration.</para>
        /// </summary>
        [NameInMap("CredentialConfig")]
        [Validation(Required=false)]
        public CredentialConfig CredentialConfig { get; set; }

        [NameInMap("CustomEnvs")]
        [Validation(Required=false)]
        public List<GetJobResponseBodyCustomEnvs> CustomEnvs { get; set; }
        public class GetJobResponseBodyCustomEnvs : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

            [NameInMap("Visible")]
            [Validation(Required=false)]
            public string Visible { get; set; }

        }

        /// <summary>
        /// <para>The list of data sources.</para>
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
            /// <para>The local mount path. This is an optional parameter. If left empty, the mount path specified in the data source is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/mnt/data/</para>
            /// </summary>
            [NameInMap("MountPath")]
            [Validation(Required=false)]
            public string MountPath { get; set; }

            /// <summary>
            /// <para>The data source path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://bucket.oss-cn-hangzhou-internal.aliyuncs.com/path/</para>
            /// </summary>
            [NameInMap("Uri")]
            [Validation(Required=false)]
            public string Uri { get; set; }

        }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

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
        /// <para>The job running duration, in seconds.</para>
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
        /// <para>Indicates whether the debugger job is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnabledDebugger")]
        [Validation(Required=false)]
        public bool? EnabledDebugger { get; set; }

        /// <summary>
        /// <para>The environment variable configuration.</para>
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
        /// <para>The time when the job failed (UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-12T15:36:08Z</para>
        /// </summary>
        [NameInMap("GmtFailedTime")]
        [Validation(Required=false)]
        public string GmtFailedTime { get; set; }

        /// <summary>
        /// <para>The time when the job finished (UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-12T15:36:08Z</para>
        /// </summary>
        [NameInMap("GmtFinishTime")]
        [Validation(Required=false)]
        public string GmtFinishTime { get; set; }

        /// <summary>
        /// <para>The time when the job started running (UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-12T14:36:21Z</para>
        /// </summary>
        [NameInMap("GmtRunningTime")]
        [Validation(Required=false)]
        public string GmtRunningTime { get; set; }

        /// <summary>
        /// <para>The time when the job was stopped (UTC).</para>
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
        /// <para>The time when the job completed successfully (UTC).</para>
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

        /// <summary>
        /// <para>The job replica statuses.</para>
        /// </summary>
        [NameInMap("JobReplicaStatuses")]
        [Validation(Required=false)]
        public List<JobReplicaStatus> JobReplicaStatuses { get; set; }

        /// <summary>
        /// <para>The node configurations in the job. For more information, see the <b>JobSpecs</b> parameter in the CreateJob API.</para>
        /// </summary>
        [NameInMap("JobSpecs")]
        [Validation(Required=false)]
        public List<JobSpec> JobSpecs { get; set; }

        /// <summary>
        /// <para>The job type. Specified by the JobType parameter in the <a href="https://help.aliyun.com/document_detail/459672.html">CreateJob</a> API.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TFJob</para>
        /// </summary>
        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        /// <summary>
        /// <para>All nodes running in the job.</para>
        /// </summary>
        [NameInMap("Pods")]
        [Validation(Required=false)]
        public List<GetJobResponseBodyPods> Pods { get; set; }
        public class GetJobResponseBodyPods : TeaModel {
            /// <summary>
            /// <para>The pod running duration.</para>
            /// </summary>
            [NameInMap("Duration")]
            [Validation(Required=false)]
            public double? Duration { get; set; }

            /// <summary>
            /// <para>The pod creation time (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-01-12T14:36:01Z</para>
            /// </summary>
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            /// <summary>
            /// <para>The node finish time (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-01-12T15:36:05Z</para>
            /// </summary>
            [NameInMap("GmtFinishTime")]
            [Validation(Required=false)]
            public string GmtFinishTime { get; set; }

            /// <summary>
            /// <para>The node start time (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-01-12T14:36:01Z</para>
            /// </summary>
            [NameInMap("GmtStartTime")]
            [Validation(Required=false)]
            public string GmtStartTime { get; set; }

            /// <summary>
            /// <para>The historical pods.</para>
            /// </summary>
            [NameInMap("HistoryPods")]
            [Validation(Required=false)]
            public List<GetJobResponseBodyPodsHistoryPods> HistoryPods { get; set; }
            public class GetJobResponseBodyPodsHistoryPods : TeaModel {
                /// <summary>
                /// <para>The pod running duration.</para>
                /// </summary>
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public double? Duration { get; set; }

                /// <summary>
                /// <para>The pod creation time (UTC).</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-01-12T14:36:01Z</para>
                /// </summary>
                [NameInMap("GmtCreateTime")]
                [Validation(Required=false)]
                public string GmtCreateTime { get; set; }

                /// <summary>
                /// <para>The pod finish time (UTC).</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-01-12T14:36:01Z</para>
                /// </summary>
                [NameInMap("GmtFinishTime")]
                [Validation(Required=false)]
                public string GmtFinishTime { get; set; }

                /// <summary>
                /// <para>The pod start time (UTC).</para>
                /// 
                /// <b>Example:</b>
                /// <para>2021-01-12T14:36:01Z</para>
                /// </summary>
                [NameInMap("GmtStartTime")]
                [Validation(Required=false)]
                public string GmtStartTime { get; set; }

                /// <summary>
                /// <para>Pod IP。</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.0.1.3</para>
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                /// <summary>
                /// <para>The node name.</para>
                /// </summary>
                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                /// <summary>
                /// <para>Pod ID。</para>
                /// 
                /// <b>Example:</b>
                /// <para>Worker</para>
                /// </summary>
                [NameInMap("PodId")]
                [Validation(Required=false)]
                public string PodId { get; set; }

                /// <summary>
                /// <para>The IP addresses of the pod.</para>
                /// </summary>
                [NameInMap("PodIps")]
                [Validation(Required=false)]
                public List<PodNetworkInterface> PodIps { get; set; }

                /// <summary>
                /// <para>Pod UID。</para>
                /// 
                /// <b>Example:</b>
                /// <para>fe846462-af2c-4521-bd6f-96787a57591d</para>
                /// </summary>
                [NameInMap("PodUid")]
                [Validation(Required=false)]
                public string PodUid { get; set; }

                /// <summary>
                /// <para>The pod resource usage type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Normal</para>
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                /// <summary>
                /// <para>The pod status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Failed</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The pod sub-status, such as preemption status. Valid values:</para>
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
                /// <para>The pod type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Worker</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The network IP address of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.0.1.2</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>The node name.</para>
            /// </summary>
            [NameInMap("NodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// <para>The node ID. You can use this ID with the GetPodLogs and GetPodEvents APIs to retrieve detailed logs and events for the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Worker</para>
            /// </summary>
            [NameInMap("PodId")]
            [Validation(Required=false)]
            public string PodId { get; set; }

            /// <summary>
            /// <para>The IP addresses of the pod.</para>
            /// </summary>
            [NameInMap("PodIps")]
            [Validation(Required=false)]
            public List<PodNetworkInterface> PodIps { get; set; }

            /// <summary>
            /// <para>Pod UID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>fe846462-af2c-4521-bd6f-96787a57591d</para>
            /// </summary>
            [NameInMap("PodUid")]
            [Validation(Required=false)]
            public string PodUid { get; set; }

            /// <summary>
            /// <para>The pod resource usage type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The node status. Valid values:</para>
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
            /// <para>The pod sub-status, such as preemption status. Valid values:</para>
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
            /// <para>The node type, which corresponds to a JobSpec in the JobSpecs parameter of the CreateJob API.</para>
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
        /// <para>The status detail code, which categorizes the sub-status under the current status (Status).</para>
        /// 
        /// <b>Example:</b>
        /// <para>JobStoppedByUser</para>
        /// </summary>
        [NameInMap("ReasonCode")]
        [Validation(Required=false)]
        public string ReasonCode { get; set; }

        /// <summary>
        /// <para>The detailed description of the status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Job is stopped by user.</para>
        /// </summary>
        [NameInMap("ReasonMessage")]
        [Validation(Required=false)]
        public string ReasonMessage { get; set; }

        /// <summary>
        /// <para>The request ID, used for diagnostics and troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-xxxxxxxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group in which the job runs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r******</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <para>The resource level used by the job at runtime.</para>
        /// 
        /// <b>Example:</b>
        /// <para>L0</para>
        /// </summary>
        [NameInMap("ResourceLevel")]
        [Validation(Required=false)]
        public string ResourceLevel { get; set; }

        /// <summary>
        /// <para>The resource type. Valid values: ECS, Lingjun, ACS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ECS</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The job restart records.</para>
        /// </summary>
        [NameInMap("RestartRecord")]
        [Validation(Required=false)]
        public List<GetJobResponseBodyRestartRecord> RestartRecord { get; set; }
        public class GetJobResponseBodyRestartRecord : TeaModel {
            /// <summary>
            /// <para>The error message list.</para>
            /// </summary>
            [NameInMap("DetailErrorInfoList")]
            [Validation(Required=false)]
            public List<GetJobResponseBodyRestartRecordDetailErrorInfoList> DetailErrorInfoList { get; set; }
            public class GetJobResponseBodyRestartRecordDetailErrorInfoList : TeaModel {
                /// <summary>
                /// <para>The job blacklist.</para>
                /// </summary>
                [NameInMap("AddJobLevelBlacklist")]
                [Validation(Required=false)]
                public bool? AddJobLevelBlacklist { get; set; }

                /// <summary>
                /// <para>The node blacklist.</para>
                /// </summary>
                [NameInMap("AddNodeToBlacklist")]
                [Validation(Required=false)]
                public bool? AddNodeToBlacklist { get; set; }

                /// <summary>
                /// <para>The detailed error message.</para>
                /// </summary>
                [NameInMap("DetailErrorMsg")]
                [Validation(Required=false)]
                public string DetailErrorMsg { get; set; }

                /// <summary>
                /// <para>The error code.</para>
                /// </summary>
                [NameInMap("ErrorCode")]
                [Validation(Required=false)]
                public string ErrorCode { get; set; }

                /// <summary>
                /// <para>The error message.</para>
                /// </summary>
                [NameInMap("ErrorMsg")]
                [Validation(Required=false)]
                public string ErrorMsg { get; set; }

                /// <summary>
                /// <para>The error source.</para>
                /// </summary>
                [NameInMap("ErrorSource")]
                [Validation(Required=false)]
                public string ErrorSource { get; set; }

                /// <summary>
                /// <para>The node.</para>
                /// </summary>
                [NameInMap("Node")]
                [Validation(Required=false)]
                public string Node { get; set; }

                /// <summary>
                /// <para>The instance.</para>
                /// </summary>
                [NameInMap("Pod")]
                [Validation(Required=false)]
                public string Pod { get; set; }

                /// <summary>
                /// <para>Indicates whether a restart is triggered.</para>
                /// </summary>
                [NameInMap("TriggerRestart")]
                [Validation(Required=false)]
                public bool? TriggerRestart { get; set; }

            }

            /// <summary>
            /// <para>The job restart count.</para>
            /// </summary>
            [NameInMap("JobRestartCount")]
            [Validation(Required=false)]
            public long? JobRestartCount { get; set; }

            /// <summary>
            /// <para>The phase in which the event occurred.</para>
            /// </summary>
            [NameInMap("OccurPhase")]
            [Validation(Required=false)]
            public string OccurPhase { get; set; }

            /// <summary>
            /// <para>The time when the event occurred.</para>
            /// </summary>
            [NameInMap("OccurTime")]
            [Validation(Required=false)]
            public string OccurTime { get; set; }

            /// <summary>
            /// <para>The reason.</para>
            /// </summary>
            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>The restart duration, in seconds.</para>
            /// </summary>
            [NameInMap("RestartDurationInSec")]
            [Validation(Required=false)]
            public long? RestartDurationInSec { get; set; }

            /// <summary>
            /// <para>The reason for the restart failure.</para>
            /// </summary>
            [NameInMap("RestartFailReason")]
            [Validation(Required=false)]
            public string RestartFailReason { get; set; }

            [NameInMap("RestartLevelType")]
            [Validation(Required=false)]
            public string RestartLevelType { get; set; }

            /// <summary>
            /// <para>The restart status.</para>
            /// </summary>
            [NameInMap("RestartStatus")]
            [Validation(Required=false)]
            public string RestartStatus { get; set; }

            /// <summary>
            /// <para>TriggerID</para>
            /// </summary>
            [NameInMap("TriggerID")]
            [Validation(Required=false)]
            public string TriggerID { get; set; }

        }

        /// <summary>
        /// <para>The number of retries used and the maximum number of retries for the job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0/10</para>
        /// </summary>
        [NameInMap("RestartTimes")]
        [Validation(Required=false)]
        public string RestartTimes { get; set; }

        [NameInMap("RoleSystemEnvs")]
        [Validation(Required=false)]
        public Dictionary<string, Dictionary<string, object>> RoleSystemEnvs { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Auto</para>
        /// </summary>
        [NameInMap("SchedulingStrategy")]
        [Validation(Required=false)]
        public string SchedulingStrategy { get; set; }

        /// <summary>
        /// <para>The additional parameter settings of the job.</para>
        /// </summary>
        [NameInMap("Settings")]
        [Validation(Required=false)]
        public JobSettings Settings { get; set; }

        /// <summary>
        /// <para>The job running status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Creating</description></item>
        /// <item><description>Queuing</description></item>
        /// <item><description>Bidding (currently only for Lingjun spot jobs)</description></item>
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
        /// <para>The historical statuses.</para>
        /// </summary>
        [NameInMap("StatusHistory")]
        [Validation(Required=false)]
        public List<StatusTransitionItem> StatusHistory { get; set; }

        /// <summary>
        /// <para>The job sub-status, such as preemption retry status.</para>
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
        /// <para>The folder that contains the third-party library (requirements.txt) file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/root/code/</para>
        /// </summary>
        [NameInMap("ThirdpartyLibDir")]
        [Validation(Required=false)]
        public string ThirdpartyLibDir { get; set; }

        /// <summary>
        /// <para>The list of third-party Python libraries to install.</para>
        /// </summary>
        [NameInMap("ThirdpartyLibs")]
        [Validation(Required=false)]
        public List<string> ThirdpartyLibs { get; set; }

        /// <summary>
        /// <para>The startup command for each node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>python /root/code/mnist.py</para>
        /// </summary>
        [NameInMap("UserCommand")]
        [Validation(Required=false)]
        public string UserCommand { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud UID of the job submitter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12*********</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The user VPC.</para>
        /// </summary>
        [NameInMap("UserVpc")]
        [Validation(Required=false)]
        public GetJobResponseBodyUserVpc UserVpc { get; set; }
        public class GetJobResponseBodyUserVpc : TeaModel {
            /// <summary>
            /// <para>The default routing. This parameter is valid only for general computing resources. Valid values:</para>
            /// <para>eth0: uses the default network interface controller (NIC) to access external networks through the public gateway.
            /// eth1: uses the user elastic network interfaces (ENIs) to access external networks through the private gateway.</para>
            /// </summary>
            [NameInMap("DefaultRoute")]
            [Validation(Required=false)]
            public string DefaultRoute { get; set; }

            /// <summary>
            /// <para>The extended CIDR blocks, for example, 192.168.0.1/24.</para>
            /// </summary>
            [NameInMap("ExtendedCidrs")]
            [Validation(Required=false)]
            public List<string> ExtendedCidrs { get; set; }

            /// <summary>
            /// <para>The ID of the user security group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-abcdef****</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The ID of the user vSwitch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vs-abcdef****</para>
            /// </summary>
            [NameInMap("SwitchId")]
            [Validation(Required=false)]
            public string SwitchId { get; set; }

            /// <summary>
            /// <para>The ID of the user VPC.</para>
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
