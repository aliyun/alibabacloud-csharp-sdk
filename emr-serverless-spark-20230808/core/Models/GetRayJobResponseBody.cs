// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class GetRayJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The timeout period.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("activeDeadlineSeconds")]
        [Validation(Required=false)]
        public int? ActiveDeadlineSeconds { get; set; }

        /// <summary>
        /// <para>The number of failure retries. Currently fixed at 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("backoffLimit")]
        [Validation(Required=false)]
        public int? BackoffLimit { get; set; }

        /// <summary>
        /// <para>The status of the corresponding Ray cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Deleted: Deleted.</description></item>
        /// <item><description>Submitted: Submitted but not yet created.</description></item>
        /// <item><description>Pending: Being created.</description></item>
        /// <item><description>Running: Running.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("clusterState")]
        [Validation(Required=false)]
        public string ClusterState { get; set; }

        /// <summary>
        /// <para>The nickname of the creator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alice</para>
        /// </summary>
        [NameInMap("creatorName")]
        [Validation(Required=false)]
        public string CreatorName { get; set; }

        /// <summary>
        /// <para>The consumed CU resources. This value is returned 10 minutes after the cluster is released.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1899</para>
        /// </summary>
        [NameInMap("cuHours")]
        [Validation(Required=false)]
        public double? CuHours { get; set; }

        /// <summary>
        /// <para>The Ray cluster dashboard URL. When the Ray cluster is in Running state, this is the Runtime UI. After the cluster is deleted, this is the History UI. History UI is supported only in err-1.2.0 and later versions.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://emr-ray-gateway-cn-hangzhou.aliyuncs.com/workspace/w-xxxxxxxx/raycluster/ray-xxxxxx/dashboard?token=xxxxxx">https://emr-ray-gateway-cn-hangzhou.aliyuncs.com/workspace/w-xxxxxxxx/raycluster/ray-xxxxxx/dashboard?token=xxxxxx</a></para>
        /// </summary>
        [NameInMap("dashboardUrl")]
        [Validation(Required=false)]
        public string DashboardUrl { get; set; }

        /// <summary>
        /// <para>The extra dashboard UI URLs. Currently empty.</para>
        /// </summary>
        [NameInMap("dashboardUrlExtra")]
        [Validation(Required=false)]
        public List<string> DashboardUrlExtra { get; set; }

        /// <summary>
        /// <para>The Ray DPI engine version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>err-1.2.0 (Ray 2.55.1, Python 3.12)</para>
        /// </summary>
        [NameInMap("displayReleaseVersion")]
        [Validation(Required=false)]
        public string DisplayReleaseVersion { get; set; }

        /// <summary>
        /// <para>The job duration, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2459764</para>
        /// </summary>
        [NameInMap("duration")]
        [Validation(Required=false)]
        public long? Duration { get; set; }

        /// <summary>
        /// <para>The job end time. This value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1762949372000</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The startup command.</para>
        /// 
        /// <b>Example:</b>
        /// <para>python main.py</para>
        /// </summary>
        [NameInMap("entrypoint")]
        [Validation(Required=false)]
        public string Entrypoint { get; set; }

        /// <summary>
        /// <para>The memory size requested by the entrypoint task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4Gi</para>
        /// </summary>
        [NameInMap("entrypointMemory")]
        [Validation(Required=false)]
        public string EntrypointMemory { get; set; }

        /// <summary>
        /// <para>The number of CPUs requested by the entrypoint task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("entrypointNumCpus")]
        [Validation(Required=false)]
        public string EntrypointNumCpus { get; set; }

        /// <summary>
        /// <para>The number of GPUs requested by the entrypoint task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("entrypointNumGpus")]
        [Validation(Required=false)]
        public string EntrypointNumGpus { get; set; }

        /// <summary>
        /// <para>The custom resource request JSON string for the entrypoint task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;fpu&quot;: 1}</para>
        /// </summary>
        [NameInMap("entrypointResources")]
        [Validation(Required=false)]
        public string EntrypointResources { get; set; }

        /// <summary>
        /// <para>The extra parameters in JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;userDefinedFiles&quot;: &quot;oss://mybucket/artifact/config.json,oss://mybucket/artifact/config2.json&quot;, &quot;userRequirementsFile&quot;: &quot;oss://mybucket/requirements.txt&quot;}</para>
        /// </summary>
        [NameInMap("extraParam")]
        [Validation(Required=false)]
        public string ExtraParam { get; set; }

        /// <summary>
        /// <para>The consumed GPU hours. Currently empty.</para>
        /// </summary>
        [NameInMap("guHours")]
        [Validation(Required=false)]
        public GetRayJobResponseBodyGuHours GuHours { get; set; }
        public class GetRayJobResponseBodyGuHours : TeaModel {
            /// <summary>
            /// <para>The consumed GPU hours.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2.6</para>
            /// </summary>
            [NameInMap("gpuHours")]
            [Validation(Required=false)]
            public double? GpuHours { get; set; }

            /// <summary>
            /// <para>The GPU type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.gn6i-c4g1.xlarge</para>
            /// </summary>
            [NameInMap("gpuSpec")]
            [Validation(Required=false)]
            public string GpuSpec { get; set; }

        }

        /// <summary>
        /// <para>The Ray cluster head node parameters.</para>
        /// </summary>
        [NameInMap("headSpec")]
        [Validation(Required=false)]
        public GetRayJobResponseBodyHeadSpec HeadSpec { get; set; }
        public class GetRayJobResponseBodyHeadSpec : TeaModel {
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
            /// <para>Indicates whether auto scaling is enabled for worker nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("enableAutoScaling")]
            [Validation(Required=false)]
            public bool? EnableAutoScaling { get; set; }

            /// <summary>
            /// <para>The GPU type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.gn6i-c4g1.xlarge</para>
            /// </summary>
            [NameInMap("gpuSpec")]
            [Validation(Required=false)]
            public string GpuSpec { get; set; }

            /// <summary>
            /// <para>The idle timeout in seconds for worker nodes when auto scaling is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("idleTimeoutSeconds")]
            [Validation(Required=false)]
            public int? IdleTimeoutSeconds { get; set; }

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
            /// <para>The number of nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("replica")]
            [Validation(Required=false)]
            public int? Replica { get; set; }

        }

        /// <summary>
        /// <para>The name of the bucket that stores logs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ss-ray-cn-hangzhou</para>
        /// </summary>
        [NameInMap("logBucketName")]
        [Validation(Required=false)]
        public string LogBucketName { get; set; }

        /// <summary>
        /// <para>The path where logs are stored.</para>
        /// 
        /// <b>Example:</b>
        /// <para>w-xxxxxxx/ray/logs/xxxxxx/</para>
        /// </summary>
        [NameInMap("logPath")]
        [Validation(Required=false)]
        public string LogPath { get; set; }

        /// <summary>
        /// <para>The execution message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Job finished successfully.</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The job metadata JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;owner&quot;: &quot;alice&quot;}</para>
        /// </summary>
        [NameInMap("metadataJson")]
        [Validation(Required=false)]
        public string MetadataJson { get; set; }

        /// <summary>
        /// <para>The Ray cluster name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myRayCluster</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The network connectivity name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc</para>
        /// </summary>
        [NameInMap("networkServiceName")]
        [Validation(Required=false)]
        public string NetworkServiceName { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C8944</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The Ray runtime environment JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;pip&quot;:[&quot;requests==2.26.0&quot;,&quot;pendulum==2.1.2&quot;],&quot;env_vars&quot;:{&quot;KEY&quot;:&quot;VALUE&quot;}}</para>
        /// </summary>
        [NameInMap("runtimeEnvJson")]
        [Validation(Required=false)]
        public string RuntimeEnvJson { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically destroy the temporary cluster after the job finishes. Default value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("shutdownAfterJobFinishes")]
        [Validation(Required=false)]
        public bool? ShutdownAfterJobFinishes { get; set; }

        /// <summary>
        /// <para>The start time. This value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1750327083303</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The job status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Submitted: Submitted.</description></item>
        /// <item><description>Pending: The cluster is being created.</description></item>
        /// <item><description>Running: The job is running.</description></item>
        /// <item><description>Succeeded: The job succeeded.</description></item>
        /// <item><description>Failed: The job failed.</description></item>
        /// <item><description>Cancelling: Cancelling.</description></item>
        /// <item><description>Cancelled: Cancelled.</description></item>
        /// <item><description>Timeout: Timed out and cancelled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The ID of the Ray Job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rj-xxxxxxxxxx</para>
        /// </summary>
        [NameInMap("submissionId")]
        [Validation(Required=false)]
        public string SubmissionId { get; set; }

        /// <summary>
        /// <para>The job submission mode.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HTTPMode</para>
        /// </summary>
        [NameInMap("submissionMode")]
        [Validation(Required=false)]
        public string SubmissionMode { get; set; }

        /// <summary>
        /// <para>The job submission time. This value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1750327082303</para>
        /// </summary>
        [NameInMap("submitTime")]
        [Validation(Required=false)]
        public long? SubmitTime { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// <para>The data development task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TSK-682e0112f6f24d9f9305b92174846985</para>
        /// </summary>
        [NameInMap("taskBizId")]
        [Validation(Required=false)]
        public string TaskBizId { get; set; }

        /// <summary>
        /// <para>The number of seconds to wait before destroying the cluster. This parameter takes effect only when shutdownAfterJobFinishes is set to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("ttlSecondsAfterFinished")]
        [Validation(Required=false)]
        public int? TtlSecondsAfterFinished { get; set; }

        /// <summary>
        /// <para>The list of managed file IDs.</para>
        /// </summary>
        [NameInMap("volumeIds")]
        [Validation(Required=false)]
        public List<string> VolumeIds { get; set; }

        /// <summary>
        /// <para>The Ray cluster worker node information.</para>
        /// </summary>
        [NameInMap("workerSpecs")]
        [Validation(Required=false)]
        public List<GetRayJobResponseBodyWorkerSpecs> WorkerSpecs { get; set; }
        public class GetRayJobResponseBodyWorkerSpecs : TeaModel {
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
            /// <para>The GPU type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.gn6i-c4g1.xlarge</para>
            /// </summary>
            [NameInMap("gpuSpec")]
            [Validation(Required=false)]
            public string GpuSpec { get; set; }

            /// <summary>
            /// <para>The worker node group name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WorkerGroup1</para>
            /// </summary>
            [NameInMap("groupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The maximum number of workers.</para>
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
            /// <para>8Gi</para>
            /// </summary>
            [NameInMap("memory")]
            [Validation(Required=false)]
            public string Memory { get; set; }

            /// <summary>
            /// <para>The minimum number of workers.</para>
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
            /// <para>The number of worker nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("replica")]
            [Validation(Required=false)]
            public int? Replica { get; set; }

        }

        /// <summary>
        /// <para>The URL of the job code working directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://mybucket/hello.zip</para>
        /// </summary>
        [NameInMap("workingDir")]
        [Validation(Required=false)]
        public string WorkingDir { get; set; }

    }

}
