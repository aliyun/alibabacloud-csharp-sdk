// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class JobItem : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>PUBLIC</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("CodeSource")]
        [Validation(Required=false)]
        public JobItemCodeSource CodeSource { get; set; }
        public class JobItemCodeSource : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>master</para>
            /// </summary>
            [NameInMap("Branch")]
            [Validation(Required=false)]
            public string Branch { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>code-20210111103721-85qz78ia96lu</para>
            /// </summary>
            [NameInMap("CodeSourceId")]
            [Validation(Required=false)]
            public string CodeSourceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>44da109b59f8596152987eaa8f3b2487bb72ea63</para>
            /// </summary>
            [NameInMap("Commit")]
            [Validation(Required=false)]
            public string Commit { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>/mnt/data</para>
            /// </summary>
            [NameInMap("MountPath")]
            [Validation(Required=false)]
            public string MountPath { get; set; }

        }

        [NameInMap("CredentialConfig")]
        [Validation(Required=false)]
        public CredentialConfig CredentialConfig { get; set; }

        [NameInMap("DataSources")]
        [Validation(Required=false)]
        public List<JobItemDataSources> DataSources { get; set; }
        public class JobItemDataSources : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>data-20210114104214-vf9lowjt3pso</para>
            /// </summary>
            [NameInMap("DataSourceId")]
            [Validation(Required=false)]
            public string DataSourceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>/mnt/data</para>
            /// </summary>
            [NameInMap("MountPath")]
            [Validation(Required=false)]
            public string MountPath { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>tf-mnist-test</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3602</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public long? Duration { get; set; }

        [NameInMap("ElasticSpec")]
        [Validation(Required=false)]
        public JobElasticSpec ElasticSpec { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnablePreemptibleJob")]
        [Validation(Required=false)]
        public bool? EnablePreemptibleJob { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnabledDebugger")]
        [Validation(Required=false)]
        public bool? EnabledDebugger { get; set; }

        [NameInMap("Envs")]
        [Validation(Required=false)]
        public Dictionary<string, string> Envs { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-01-12T14:35:01Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-01-12T14:35:01Z</para>
        /// </summary>
        [NameInMap("GmtFailedTime")]
        [Validation(Required=false)]
        public string GmtFailedTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-01-12T15:36:08Z</para>
        /// </summary>
        [NameInMap("GmtFinishTime")]
        [Validation(Required=false)]
        public string GmtFinishTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-01-12T15:36:08Z</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-01-12T14:35:01Z</para>
        /// </summary>
        [NameInMap("GmtRunningTime")]
        [Validation(Required=false)]
        public string GmtRunningTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-01-12T14:35:01Z</para>
        /// </summary>
        [NameInMap("GmtStoppedTime")]
        [Validation(Required=false)]
        public string GmtStoppedTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-01-12T14:35:01Z</para>
        /// </summary>
        [NameInMap("GmtSubmittedTime")]
        [Validation(Required=false)]
        public string GmtSubmittedTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2021-01-12T14:35:01Z</para>
        /// </summary>
        [NameInMap("GmtSuccessedTime")]
        [Validation(Required=false)]
        public string GmtSuccessedTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsDeleted")]
        [Validation(Required=false)]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dlc-20210126170216-mtl37ge7gkvdz</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("JobMaxRunningTimeMinutes")]
        [Validation(Required=false)]
        public long? JobMaxRunningTimeMinutes { get; set; }

        [NameInMap("JobSpecs")]
        [Validation(Required=false)]
        public List<JobSpec> JobSpecs { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>TFJob</para>
        /// </summary>
        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NodeCount")]
        [Validation(Required=false)]
        public string NodeCount { get; set; }

        [NameInMap("NodeNames")]
        [Validation(Required=false)]
        public List<string> NodeNames { get; set; }

        [NameInMap("Pods")]
        [Validation(Required=false)]
        public List<PodItem> Pods { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>JobStoppedByUser</para>
        /// </summary>
        [NameInMap("ReasonCode")]
        [Validation(Required=false)]
        public string ReasonCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Job is stopped by user.</para>
        /// </summary>
        [NameInMap("ReasonMessage")]
        [Validation(Required=false)]
        public string ReasonMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RequestCPU")]
        [Validation(Required=false)]
        public long? RequestCPU { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RequestGPU")]
        [Validation(Required=false)]
        public string RequestGPU { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1Gi</para>
        /// </summary>
        [NameInMap("RequestMemory")]
        [Validation(Required=false)]
        public string RequestMemory { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dlc-quota</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public string ResourceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>L0</para>
        /// </summary>
        [NameInMap("ResourceLevel")]
        [Validation(Required=false)]
        public string ResourceLevel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>my_resource_group</para>
        /// </summary>
        [NameInMap("ResourceName")]
        [Validation(Required=false)]
        public string ResourceName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("ResourceQuotaName")]
        [Validation(Required=false)]
        public string ResourceQuotaName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ECS</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RestartTimes")]
        [Validation(Required=false)]
        public string RestartTimes { get; set; }

        [NameInMap("Settings")]
        [Validation(Required=false)]
        public JobSettings Settings { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Stopped</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("StatusHistory")]
        [Validation(Required=false)]
        public List<StatusTransitionItem> StatusHistory { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Restarting</para>
        /// </summary>
        [NameInMap("SubStatus")]
        [Validation(Required=false)]
        public string SubStatus { get; set; }

        [NameInMap("SystemEnvs")]
        [Validation(Required=false)]
        public Dictionary<string, string> SystemEnvs { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>/root/code/</para>
        /// </summary>
        [NameInMap("ThirdpartyLibDir")]
        [Validation(Required=false)]
        public string ThirdpartyLibDir { get; set; }

        [NameInMap("ThirdpartyLibs")]
        [Validation(Required=false)]
        public List<string> ThirdpartyLibs { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("UseOversoldResource")]
        [Validation(Required=false)]
        public bool? UseOversoldResource { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>python /root/code/mnist.py</para>
        /// </summary>
        [NameInMap("UserCommand")]
        [Validation(Required=false)]
        public string UserCommand { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123456789</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ls</para>
        /// </summary>
        [NameInMap("UserScript")]
        [Validation(Required=false)]
        public string UserScript { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>vpc-1</para>
        /// </summary>
        [NameInMap("UserVpc")]
        [Validation(Required=false)]
        public string UserVpc { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pai-dlc-role</para>
        /// </summary>
        [NameInMap("Username")]
        [Validation(Required=false)]
        public string Username { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>/mnt/data</para>
        /// </summary>
        [NameInMap("WorkingDir")]
        [Validation(Required=false)]
        public string WorkingDir { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>268</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dlc-workspace</para>
        /// </summary>
        [NameInMap("WorkspaceName")]
        [Validation(Required=false)]
        public string WorkspaceName { get; set; }

    }

}
