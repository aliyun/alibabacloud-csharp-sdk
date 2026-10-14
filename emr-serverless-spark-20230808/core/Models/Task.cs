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
        /// <para>The temporary URL for accessing the resource file.</para>
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
        /// <para>The category business ID.</para>
        /// </summary>
        [NameInMap("categoryBizId")]
        [Validation(Required=false)]
        public string CategoryBizId { get; set; }

        /// <summary>
        /// <para>The Spark job content.</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The creator UID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>150978934701****</para>
        /// </summary>
        [NameInMap("creator")]
        [Validation(Required=false)]
        public long? Creator { get; set; }

        /// <summary>
        /// <para>The direct upload information for OSS.</para>
        /// </summary>
        [NameInMap("credential")]
        [Validation(Required=false)]
        public TaskCredential Credential { get; set; }
        public class TaskCredential : TeaModel {
            /// <summary>
            /// <para>access id</para>
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
            /// <para>policy</para>
            /// </summary>
            [NameInMap("policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }

            /// <summary>
            /// <para>security token</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("defaultDatabase")]
        [Validation(Required=false)]
        public string DefaultDatabase { get; set; }

        /// <summary>
        /// <para>The ID of the default task queue.</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>env-cpv569tlhtgndjl8****</para>
        /// </summary>
        [NameInMap("environmentId")]
        [Validation(Required=false)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// <para>The IDs of additional Spark resources.</para>
        /// </summary>
        [NameInMap("extraArtifactIds")]
        [Validation(Required=false)]
        public List<string> ExtraArtifactIds { get; set; }

        /// <summary>
        /// <para>The custom Spark submit parameters.</para>
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
        /// <para>The Fusion status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("fusion")]
        [Validation(Required=false)]
        public bool? Fusion { get; set; }

        /// <summary>
        /// <para>The creation time.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-03-10T02:02:41.000+00:00</para>
        /// </summary>
        [NameInMap("gmtCreated")]
        [Validation(Required=false)]
        public string GmtCreated { get; set; }

        /// <summary>
        /// <para>The last modified time.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-03-10T02:02:41.000+00:00</para>
        /// </summary>
        [NameInMap("gmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <para>The change status after the last commit.</para>
        /// </summary>
        [NameInMap("hasChanged")]
        [Validation(Required=false)]
        public bool? HasChanged { get; set; }

        /// <summary>
        /// <para>The commit status.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("hasCommited")]
        [Validation(Required=false)]
        public bool? HasCommited { get; set; }

        /// <summary>
        /// <para>The streaming task status.</para>
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
        /// <para>The ID of the resource queue for the last run.</para>
        /// </summary>
        [NameInMap("lastRunResourceQueueId")]
        [Validation(Required=false)]
        public string LastRunResourceQueueId { get; set; }

        /// <summary>
        /// <para>The UID of the last updater.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>150978934701****</para>
        /// </summary>
        [NameInMap("modifier")]
        [Validation(Required=false)]
        public long? Modifier { get; set; }

        /// <summary>
        /// <para>The task name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ods_transform_task</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("params")]
        [Validation(Required=false)]
        public Dictionary<string, string> Params { get; set; }

        /// <summary>
        /// <para>The PyFiles for PySpark dependencies.</para>
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

        /// <summary>
        /// <para>The Ray cluster head node parameters.</para>
        /// </summary>
        [NameInMap("rayHeadSpec")]
        [Validation(Required=false)]
        public TaskRayHeadSpec RayHeadSpec { get; set; }
        public class TaskRayHeadSpec : TeaModel {
            /// <summary>
            /// <para>The number of CPU cores.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("cpu")]
            [Validation(Required=false)]
            public string Cpu { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable auto scaling for worker nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("enableAutoScaling")]
            [Validation(Required=false)]
            public bool? EnableAutoScaling { get; set; }

            /// <summary>
            /// <para>The environment variables for Ray nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MY_ENV=123456</para>
            /// </summary>
            [NameInMap("env")]
            [Validation(Required=false)]
            public string Env { get; set; }

            /// <summary>
            /// <para>The GPU instance type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.gn6i-c4g1.xlarge</para>
            /// </summary>
            [NameInMap("gpuSpec")]
            [Validation(Required=false)]
            public string GpuSpec { get; set; }

            /// <summary>
            /// <para>The idle timeout period for worker nodes after auto scaling is enabled, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("idleTimeoutSeconds")]
            [Validation(Required=false)]
            public long? IdleTimeoutSeconds { get; set; }

            /// <summary>
            /// <para>The memory size, in GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8Gi</para>
            /// </summary>
            [NameInMap("memory")]
            [Validation(Required=false)]
            public string Memory { get; set; }

            /// <summary>
            /// <para>The queue name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>root_queue</para>
            /// </summary>
            [NameInMap("queueName")]
            [Validation(Required=false)]
            public string QueueName { get; set; }

            /// <summary>
            /// <para>The Ray startup parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>--num-cpus=0</para>
            /// </summary>
            [NameInMap("rayStartParams")]
            [Validation(Required=false)]
            public string RayStartParams { get; set; }

            /// <summary>
            /// <para>The database engine version of the Ray DPI engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>err-1.3.0 (Ray 2.55.1, Python 3.12)</para>
            /// </summary>
            [NameInMap("rayVersion")]
            [Validation(Required=false)]
            public string RayVersion { get; set; }

            /// <summary>
            /// <para>The number of head nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
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

        /// <summary>
        /// <para>The database engine version of the Ray DPI engine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>err-1.3.0 (Ray 2.55.1, Python 3.12)</para>
        /// </summary>
        [NameInMap("rayVersion")]
        [Validation(Required=false)]
        public string RayVersion { get; set; }

        [NameInMap("rayVolumeIds")]
        [Validation(Required=false)]
        public List<string> RayVolumeIds { get; set; }

        /// <summary>
        /// <para>The list of worker node parameters for the Ray cluster. A maximum of 50 groups are supported.</para>
        /// </summary>
        [NameInMap("rayWorkerSpec")]
        [Validation(Required=false)]
        public List<TaskRayWorkerSpec> RayWorkerSpec { get; set; }
        public class TaskRayWorkerSpec : TeaModel {
            /// <summary>
            /// <para>The number of CPU cores.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("cpu")]
            [Validation(Required=false)]
            public string Cpu { get; set; }

            /// <summary>
            /// <para>The environment variables for Ray.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MY_ENV=123456</para>
            /// </summary>
            [NameInMap("env")]
            [Validation(Required=false)]
            public string Env { get; set; }

            /// <summary>
            /// <para>The GPU instance type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.gn6i-c4g1.xlarge</para>
            /// </summary>
            [NameInMap("gpuSpec")]
            [Validation(Required=false)]
            public string GpuSpec { get; set; }

            /// <summary>
            /// <para>The worker group name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WorkerGroup1</para>
            /// </summary>
            [NameInMap("groupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The maximum number of worker nodes after auto scaling is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("maxReplica")]
            [Validation(Required=false)]
            public int? MaxReplica { get; set; }

            /// <summary>
            /// <para>The memory size, in GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16Gi</para>
            /// </summary>
            [NameInMap("memory")]
            [Validation(Required=false)]
            public string Memory { get; set; }

            /// <summary>
            /// <para>The minimum number of worker nodes after auto scaling is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("minReplica")]
            [Validation(Required=false)]
            public int? MinReplica { get; set; }

            /// <summary>
            /// <para>The queue name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>root_queue</para>
            /// </summary>
            [NameInMap("queueName")]
            [Validation(Required=false)]
            public string QueueName { get; set; }

            /// <summary>
            /// <para>The Ray startup parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>--num-cpus=0</para>
            /// </summary>
            [NameInMap("rayStartParams")]
            [Validation(Required=false)]
            public string RayStartParams { get; set; }

            /// <summary>
            /// <para>The database engine version of the Ray DPI engine.</para>
            /// 
            /// <b>Example:</b>
            /// <para>err-1.3.0 (Ray 2.55.1, Python 3.12)</para>
            /// </summary>
            [NameInMap("rayVersion")]
            [Validation(Required=false)]
            public string RayVersion { get; set; }

            /// <summary>
            /// <para>The number of worker nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("replica")]
            [Validation(Required=false)]
            public int? Replica { get; set; }

        }

        [NameInMap("rayWorkingDir")]
        [Validation(Required=false)]
        public string RayWorkingDir { get; set; }

        /// <summary>
        /// <para>The interactive job session ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234abcd-12ab-34cd-56ef-1234567890ab</para>
        /// </summary>
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
        /// <para>The Spark configuration list.</para>
        /// </summary>
        [NameInMap("sparkConf")]
        [Validation(Required=false)]
        public List<SparkConf> SparkConf { get; set; }

        /// <summary>
        /// <para>The number of Spark driver cores.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("sparkDriverCores")]
        [Validation(Required=false)]
        public int? SparkDriverCores { get; set; }

        /// <summary>
        /// <para>The Spark driver memory.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1073741824</para>
        /// </summary>
        [NameInMap("sparkDriverMemory")]
        [Validation(Required=false)]
        public long? SparkDriverMemory { get; set; }

        /// <summary>
        /// <para>The Spark entry point.</para>
        /// </summary>
        [NameInMap("sparkEntrypoint")]
        [Validation(Required=false)]
        public string SparkEntrypoint { get; set; }

        /// <summary>
        /// <para>The number of Spark executor cores.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("sparkExecutorCores")]
        [Validation(Required=false)]
        public int? SparkExecutorCores { get; set; }

        /// <summary>
        /// <para>The Spark executor memory.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1073741824</para>
        /// </summary>
        [NameInMap("sparkExecutorMemory")]
        [Validation(Required=false)]
        public long? SparkExecutorMemory { get; set; }

        /// <summary>
        /// <para>The Spark log level.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>INFO</para>
        /// </summary>
        [NameInMap("sparkLogLevel")]
        [Validation(Required=false)]
        public string SparkLogLevel { get; set; }

        /// <summary>
        /// <para>The Spark log path.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://your_bucket/path/to/your/log</para>
        /// </summary>
        [NameInMap("sparkLogPath")]
        [Validation(Required=false)]
        public string SparkLogPath { get; set; }

        /// <summary>
        /// <para>The Spark submit statement.</para>
        /// </summary>
        [NameInMap("sparkSubmitClause")]
        [Validation(Required=false)]
        public string SparkSubmitClause { get; set; }

        /// <summary>
        /// <para>The Spark version.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>esr-4.1.1</para>
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
        /// <para>The task timeout.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1200</para>
        /// </summary>
        [NameInMap("timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        /// <summary>
        /// <para>The task type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SQL</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
