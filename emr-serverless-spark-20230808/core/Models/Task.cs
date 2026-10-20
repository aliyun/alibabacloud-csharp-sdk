// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class Task : TeaModel {
        [NameInMap("archives")]
        [Validation(Required=false)]
        public List<string> Archives { get; set; }

        [NameInMap("artifactUrl")]
        [Validation(Required=false)]
        public string ArtifactUrl { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("bizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("categoryBizId")]
        [Validation(Required=false)]
        public string CategoryBizId { get; set; }

        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("creator")]
        [Validation(Required=false)]
        public long? Creator { get; set; }

        [NameInMap("credential")]
        [Validation(Required=false)]
        public TaskCredential Credential { get; set; }
        public class TaskCredential : TeaModel {
            [NameInMap("accessId")]
            [Validation(Required=false)]
            public string AccessId { get; set; }

            [NameInMap("accessUrl")]
            [Validation(Required=false)]
            public string AccessUrl { get; set; }

            [NameInMap("expire")]
            [Validation(Required=false)]
            public long? Expire { get; set; }

            [NameInMap("host")]
            [Validation(Required=false)]
            public string Host { get; set; }

            [NameInMap("path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            [NameInMap("policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            [NameInMap("securityToken")]
            [Validation(Required=false)]
            public string SecurityToken { get; set; }

            [NameInMap("signature")]
            [Validation(Required=false)]
            public string Signature { get; set; }

        }

        [NameInMap("defaultCatalogId")]
        [Validation(Required=false)]
        public string DefaultCatalogId { get; set; }

        [NameInMap("defaultDatabase")]
        [Validation(Required=false)]
        public string DefaultDatabase { get; set; }

        [NameInMap("defaultResourceQueueId")]
        [Validation(Required=false)]
        public string DefaultResourceQueueId { get; set; }

        [NameInMap("defaultSqlComputeId")]
        [Validation(Required=false)]
        public string DefaultSqlComputeId { get; set; }

        [NameInMap("deploymentId")]
        [Validation(Required=false)]
        public string DeploymentId { get; set; }

        [NameInMap("environmentId")]
        [Validation(Required=false)]
        public string EnvironmentId { get; set; }

        [NameInMap("extraArtifactIds")]
        [Validation(Required=false)]
        public List<string> ExtraArtifactIds { get; set; }

        [NameInMap("extraSparkSubmitParams")]
        [Validation(Required=false)]
        public string ExtraSparkSubmitParams { get; set; }

        [NameInMap("files")]
        [Validation(Required=false)]
        public List<string> Files { get; set; }

        [NameInMap("fusion")]
        [Validation(Required=false)]
        public bool? Fusion { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("gmtCreated")]
        [Validation(Required=false)]
        public string GmtCreated { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("gmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        [NameInMap("hasChanged")]
        [Validation(Required=false)]
        public bool? HasChanged { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("hasCommited")]
        [Validation(Required=false)]
        public bool? HasCommited { get; set; }

        [NameInMap("isStreaming")]
        [Validation(Required=false)]
        public bool? IsStreaming { get; set; }

        [NameInMap("jars")]
        [Validation(Required=false)]
        public List<string> Jars { get; set; }

        [NameInMap("kernelId")]
        [Validation(Required=false)]
        public string KernelId { get; set; }

        [NameInMap("lastRunResourceQueueId")]
        [Validation(Required=false)]
        public string LastRunResourceQueueId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("modifier")]
        [Validation(Required=false)]
        public long? Modifier { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("params")]
        [Validation(Required=false)]
        public Dictionary<string, string> Params { get; set; }

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

            /// <summary>
            /// <b>Example:</b>
            /// <para>MY_ENV=123456</para>
            /// </summary>
            [NameInMap("env")]
            [Validation(Required=false)]
            public string Env { get; set; }

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

            /// <summary>
            /// <b>Example:</b>
            /// <para>--num-cpus=0</para>
            /// </summary>
            [NameInMap("rayStartParams")]
            [Validation(Required=false)]
            public string RayStartParams { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>err-1.3.0 (Ray 2.55.1, Python 3.12)</para>
            /// </summary>
            [NameInMap("rayVersion")]
            [Validation(Required=false)]
            public string RayVersion { get; set; }

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

            /// <summary>
            /// <b>Example:</b>
            /// <para>MY_ENV=123456</para>
            /// </summary>
            [NameInMap("env")]
            [Validation(Required=false)]
            public string Env { get; set; }

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

            /// <summary>
            /// <b>Example:</b>
            /// <para>--num-cpus=0</para>
            /// </summary>
            [NameInMap("rayStartParams")]
            [Validation(Required=false)]
            public string RayStartParams { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>err-1.3.0 (Ray 2.55.1, Python 3.12)</para>
            /// </summary>
            [NameInMap("rayVersion")]
            [Validation(Required=false)]
            public string RayVersion { get; set; }

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
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("sparkArgs")]
        [Validation(Required=false)]
        public string SparkArgs { get; set; }

        [NameInMap("sparkConf")]
        [Validation(Required=false)]
        public List<SparkConf> SparkConf { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("sparkDriverCores")]
        [Validation(Required=false)]
        public int? SparkDriverCores { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("sparkDriverMemory")]
        [Validation(Required=false)]
        public long? SparkDriverMemory { get; set; }

        [NameInMap("sparkEntrypoint")]
        [Validation(Required=false)]
        public string SparkEntrypoint { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("sparkExecutorCores")]
        [Validation(Required=false)]
        public int? SparkExecutorCores { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("sparkExecutorMemory")]
        [Validation(Required=false)]
        public long? SparkExecutorMemory { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("sparkLogLevel")]
        [Validation(Required=false)]
        public string SparkLogLevel { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("sparkLogPath")]
        [Validation(Required=false)]
        public string SparkLogPath { get; set; }

        [NameInMap("sparkSubmitClause")]
        [Validation(Required=false)]
        public string SparkSubmitClause { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("sparkVersion")]
        [Validation(Required=false)]
        public string SparkVersion { get; set; }

        [NameInMap("tags")]
        [Validation(Required=false)]
        public Dictionary<string, string> Tags { get; set; }

        [NameInMap("timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
