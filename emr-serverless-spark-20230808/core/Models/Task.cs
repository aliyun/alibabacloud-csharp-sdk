// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class Task : TeaModel {
        /// <summary>
        /// <para>The --archives parameter.</para>
        /// </summary>
        [NameInMap("archives")]
        [Validation(Required=false)]
        public List<string> Archives { get; set; }

        /// <summary>
        /// <para>The temporary URL to access the resource file.</para>
        /// </summary>
        [NameInMap("artifactUrl")]
        [Validation(Required=false)]
        public string ArtifactUrl { get; set; }

        /// <summary>
        /// <para>The business ID.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("bizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        /// <summary>
        /// <para>The business ID of the folder.</para>
        /// </summary>
        [NameInMap("categoryBizId")]
        [Validation(Required=false)]
        public string CategoryBizId { get; set; }

        /// <summary>
        /// <para>The content of the Spark job.</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The UID of the creator.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("creator")]
        [Validation(Required=false)]
        public long? Creator { get; set; }

        /// <summary>
        /// <para>The information for directly uploading files to Object Storage Service (OSS).</para>
        /// </summary>
        [NameInMap("credential")]
        [Validation(Required=false)]
        public TaskCredential Credential { get; set; }
        public class TaskCredential : TeaModel {
            /// <summary>
            /// <para>The AccessKey ID.</para>
            /// </summary>
            [NameInMap("accessId")]
            [Validation(Required=false)]
            public string AccessId { get; set; }

            /// <summary>
            /// <para>The access URL.</para>
            /// </summary>
            [NameInMap("accessUrl")]
            [Validation(Required=false)]
            public string AccessUrl { get; set; }

            /// <summary>
            /// <para>The expiration time.</para>
            /// </summary>
            [NameInMap("expire")]
            [Validation(Required=false)]
            public long? Expire { get; set; }

            /// <summary>
            /// <para>The domain name.</para>
            /// </summary>
            [NameInMap("host")]
            [Validation(Required=false)]
            public string Host { get; set; }

            /// <summary>
            /// <para>The path.</para>
            /// </summary>
            [NameInMap("path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// <para>The policy.</para>
            /// </summary>
            [NameInMap("policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            /// <summary>
            /// <para>The security token.</para>
            /// </summary>
            [NameInMap("securityToken")]
            [Validation(Required=false)]
            public string SecurityToken { get; set; }

            /// <summary>
            /// <para>The signature.</para>
            /// </summary>
            [NameInMap("signature")]
            [Validation(Required=false)]
            public string Signature { get; set; }

        }

        /// <summary>
        /// <para>The default catalog ID.</para>
        /// </summary>
        [NameInMap("defaultCatalogId")]
        [Validation(Required=false)]
        public string DefaultCatalogId { get; set; }

        /// <summary>
        /// <para>The default database.</para>
        /// </summary>
        [NameInMap("defaultDatabase")]
        [Validation(Required=false)]
        public string DefaultDatabase { get; set; }

        /// <summary>
        /// <para>The default queue ID for the task.</para>
        /// </summary>
        [NameInMap("defaultResourceQueueId")]
        [Validation(Required=false)]
        public string DefaultResourceQueueId { get; set; }

        /// <summary>
        /// <para>The default SQL session ID.</para>
        /// </summary>
        [NameInMap("defaultSqlComputeId")]
        [Validation(Required=false)]
        public string DefaultSqlComputeId { get; set; }

        /// <summary>
        /// <para>The deployment ID of the streaming task.</para>
        /// </summary>
        [NameInMap("deploymentId")]
        [Validation(Required=false)]
        public string DeploymentId { get; set; }

        /// <summary>
        /// <para>The environment ID.</para>
        /// </summary>
        [NameInMap("environmentId")]
        [Validation(Required=false)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// <para>The IDs of extra Spark resources.</para>
        /// </summary>
        [NameInMap("extraArtifactIds")]
        [Validation(Required=false)]
        public List<string> ExtraArtifactIds { get; set; }

        /// <summary>
        /// <para>The custom parameters for the spark-submit command.</para>
        /// </summary>
        [NameInMap("extraSparkSubmitParams")]
        [Validation(Required=false)]
        public string ExtraSparkSubmitParams { get; set; }

        /// <summary>
        /// <para>The --files parameter.</para>
        /// </summary>
        [NameInMap("files")]
        [Validation(Required=false)]
        public List<string> Files { get; set; }

        /// <summary>
        /// <para>Indicates whether to enable fusion.</para>
        /// </summary>
        [NameInMap("fusion")]
        [Validation(Required=false)]
        public bool? Fusion { get; set; }

        /// <summary>
        /// <para>The time when the task was created.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("gmtCreated")]
        [Validation(Required=false)]
        public string GmtCreated { get; set; }

        /// <summary>
        /// <para>The time when the task was last modified.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("gmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <para>Indicates whether the task has been changed since the last commit.</para>
        /// </summary>
        [NameInMap("hasChanged")]
        [Validation(Required=false)]
        public bool? HasChanged { get; set; }

        /// <summary>
        /// <para>Indicates whether the task has been committed.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("hasCommited")]
        [Validation(Required=false)]
        public bool? HasCommited { get; set; }

        /// <summary>
        /// <para>Indicates whether the task is a streaming task.</para>
        /// </summary>
        [NameInMap("isStreaming")]
        [Validation(Required=false)]
        public bool? IsStreaming { get; set; }

        /// <summary>
        /// <para>The --jars parameter.</para>
        /// </summary>
        [NameInMap("jars")]
        [Validation(Required=false)]
        public List<string> Jars { get; set; }

        [NameInMap("kernelId")]
        [Validation(Required=false)]
        public string KernelId { get; set; }

        /// <summary>
        /// <para>The ID of the resource queue that was used for the last run.</para>
        /// </summary>
        [NameInMap("lastRunResourceQueueId")]
        [Validation(Required=false)]
        public string LastRunResourceQueueId { get; set; }

        /// <summary>
        /// <para>The UID of the user who last updated the task.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("modifier")]
        [Validation(Required=false)]
        public long? Modifier { get; set; }

        /// <summary>
        /// <para>The task name.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("params")]
        [Validation(Required=false)]
        public Dictionary<string, string> Params { get; set; }

        /// <summary>
        /// <para>The PySpark dependency pyfiles.</para>
        /// </summary>
        [NameInMap("pyFiles")]
        [Validation(Required=false)]
        public List<string> PyFiles { get; set; }

        [NameInMap("rayActiveDeadlineSeconds")]
        [Validation(Required=false)]
        public long? RayActiveDeadlineSeconds { get; set; }

        [NameInMap("rayBackoffLimit")]
        [Validation(Required=false)]
        public int? RayBackoffLimit { get; set; }

        [NameInMap("rayEntrypoint")]
        [Validation(Required=false)]
        public string RayEntrypoint { get; set; }

        [NameInMap("rayEntrypointMemory")]
        [Validation(Required=false)]
        public string RayEntrypointMemory { get; set; }

        [NameInMap("rayEntrypointNumCpus")]
        [Validation(Required=false)]
        public string RayEntrypointNumCpus { get; set; }

        [NameInMap("rayEntrypointNumGpus")]
        [Validation(Required=false)]
        public string RayEntrypointNumGpus { get; set; }

        [NameInMap("rayEntrypointResources")]
        [Validation(Required=false)]
        public string RayEntrypointResources { get; set; }

        [NameInMap("rayExtraParam")]
        [Validation(Required=false)]
        public string RayExtraParam { get; set; }

        [NameInMap("rayHeadSpec")]
        [Validation(Required=false)]
        public TaskRayHeadSpec RayHeadSpec { get; set; }
        public class TaskRayHeadSpec : TeaModel {
            [NameInMap("cpu")]
            [Validation(Required=false)]
            public string Cpu { get; set; }

            [NameInMap("enableAutoScaling")]
            [Validation(Required=false)]
            public bool? EnableAutoScaling { get; set; }

            [NameInMap("gpuSpec")]
            [Validation(Required=false)]
            public string GpuSpec { get; set; }

            [NameInMap("idleTimeoutSeconds")]
            [Validation(Required=false)]
            public long? IdleTimeoutSeconds { get; set; }

            [NameInMap("memory")]
            [Validation(Required=false)]
            public string Memory { get; set; }

            [NameInMap("queueName")]
            [Validation(Required=false)]
            public string QueueName { get; set; }

            [NameInMap("replica")]
            [Validation(Required=false)]
            public int? Replica { get; set; }

        }

        [NameInMap("rayMetadataJson")]
        [Validation(Required=false)]
        public string RayMetadataJson { get; set; }

        [NameInMap("rayNetworkServiceName")]
        [Validation(Required=false)]
        public string RayNetworkServiceName { get; set; }

        [NameInMap("rayRuntimeEnvJson")]
        [Validation(Required=false)]
        public string RayRuntimeEnvJson { get; set; }

        [NameInMap("rayShutdownAfterJobFinishes")]
        [Validation(Required=false)]
        public bool? RayShutdownAfterJobFinishes { get; set; }

        [NameInMap("raySubmissionMode")]
        [Validation(Required=false)]
        public string RaySubmissionMode { get; set; }

        [NameInMap("rayTtlSecondsAfterFinished")]
        [Validation(Required=false)]
        public long? RayTtlSecondsAfterFinished { get; set; }

        [NameInMap("rayVersion")]
        [Validation(Required=false)]
        public string RayVersion { get; set; }

        [NameInMap("rayVolumeIds")]
        [Validation(Required=false)]
        public List<string> RayVolumeIds { get; set; }

        [NameInMap("rayWorkerSpec")]
        [Validation(Required=false)]
        public List<TaskRayWorkerSpec> RayWorkerSpec { get; set; }
        public class TaskRayWorkerSpec : TeaModel {
            [NameInMap("cpu")]
            [Validation(Required=false)]
            public string Cpu { get; set; }

            [NameInMap("gpuSpec")]
            [Validation(Required=false)]
            public string GpuSpec { get; set; }

            [NameInMap("groupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            [NameInMap("maxReplica")]
            [Validation(Required=false)]
            public int? MaxReplica { get; set; }

            [NameInMap("memory")]
            [Validation(Required=false)]
            public string Memory { get; set; }

            [NameInMap("minReplica")]
            [Validation(Required=false)]
            public int? MinReplica { get; set; }

            [NameInMap("queueName")]
            [Validation(Required=false)]
            public string QueueName { get; set; }

            [NameInMap("replica")]
            [Validation(Required=false)]
            public int? Replica { get; set; }

        }

        [NameInMap("rayWorkingDir")]
        [Validation(Required=false)]
        public string RayWorkingDir { get; set; }

        [NameInMap("sessionClusterId")]
        [Validation(Required=false)]
        public string SessionClusterId { get; set; }

        /// <summary>
        /// <para>The Spark parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("sparkArgs")]
        [Validation(Required=false)]
        public string SparkArgs { get; set; }

        /// <summary>
        /// <para>The list of Spark configurations.</para>
        /// </summary>
        [NameInMap("sparkConf")]
        [Validation(Required=false)]
        public List<SparkConf> SparkConf { get; set; }

        /// <summary>
        /// <para>The number of cores for the Spark driver.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("sparkDriverCores")]
        [Validation(Required=false)]
        public int? SparkDriverCores { get; set; }

        /// <summary>
        /// <para>The memory of the Spark driver.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("sparkDriverMemory")]
        [Validation(Required=false)]
        public long? SparkDriverMemory { get; set; }

        /// <summary>
        /// <para>The entrypoint of the Spark main class.</para>
        /// </summary>
        [NameInMap("sparkEntrypoint")]
        [Validation(Required=false)]
        public string SparkEntrypoint { get; set; }

        /// <summary>
        /// <para>The number of cores for the Spark executor.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("sparkExecutorCores")]
        [Validation(Required=false)]
        public int? SparkExecutorCores { get; set; }

        /// <summary>
        /// <para>The memory of the Spark executor.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("sparkExecutorMemory")]
        [Validation(Required=false)]
        public long? SparkExecutorMemory { get; set; }

        /// <summary>
        /// <para>The log level for Spark.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("sparkLogLevel")]
        [Validation(Required=false)]
        public string SparkLogLevel { get; set; }

        /// <summary>
        /// <para>The Spark log path.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("sparkLogPath")]
        [Validation(Required=false)]
        public string SparkLogPath { get; set; }

        /// <summary>
        /// <para>The spark-submit statement.</para>
        /// </summary>
        [NameInMap("sparkSubmitClause")]
        [Validation(Required=false)]
        public string SparkSubmitClause { get; set; }

        /// <summary>
        /// <para>The Spark version.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("sparkVersion")]
        [Validation(Required=false)]
        public string SparkVersion { get; set; }

        /// <summary>
        /// <para>The task tags.</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public Dictionary<string, string> Tags { get; set; }

        /// <summary>
        /// <para>The task timeout duration.</para>
        /// </summary>
        [NameInMap("timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// <para>The task type.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
