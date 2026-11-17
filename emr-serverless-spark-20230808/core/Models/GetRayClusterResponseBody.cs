// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class GetRayClusterResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the Ray cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ray-k7nm8ahl5te4tg91</para>
        /// </summary>
        [NameInMap("clusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The creation time. The value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1750327083303</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>The user ID of the cluster creator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>202077646755523991</para>
        /// </summary>
        [NameInMap("creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

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
        /// <para>The URL of the Ray cluster dashboard.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://emr-ray-gateway-cn-hangzhou.aliyuncs.com/workspace/w-xxxxxxxx/raycluster/ray-xxxxxx/dashboard?token=xxxxxx">https://emr-ray-gateway-cn-hangzhou.aliyuncs.com/workspace/w-xxxxxxxx/raycluster/ray-xxxxxx/dashboard?token=xxxxxx</a></para>
        /// </summary>
        [NameInMap("dashboardUrl")]
        [Validation(Required=false)]
        public string DashboardUrl { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ray Cluster for dev.</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The Ray DPI engine version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ray-1.0.0 (Ray 2.47.1, Python 3.12)</para>
        /// </summary>
        [NameInMap("displayReleaseVersion")]
        [Validation(Required=false)]
        public string DisplayReleaseVersion { get; set; }

        /// <summary>
        /// <para>Specifies whether to upload metrics.</para>
        /// </summary>
        [NameInMap("enableMetricsUpload")]
        [Validation(Required=false)]
        public bool? EnableMetricsUpload { get; set; }

        /// <summary>
        /// <para>The extra parameters in JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("extraParam")]
        [Validation(Required=false)]
        public string ExtraParam { get; set; }

        /// <summary>
        /// <para>The internal gRPC endpoint. The domain name in the endpoint can also be used to submit Ray jobs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ray://emr-spark-ray-gateway-cn-hangzhou-internal.emr.aliyuncs.com:80</para>
        /// </summary>
        [NameInMap("grpcEndpoint")]
        [Validation(Required=false)]
        public string GrpcEndpoint { get; set; }

        /// <summary>
        /// <para>The head node parameters of the Ray cluster.</para>
        /// </summary>
        [NameInMap("headSpec")]
        [Validation(Required=false)]
        public GetRayClusterResponseBodyHeadSpec HeadSpec { get; set; }
        public class GetRayClusterResponseBodyHeadSpec : TeaModel {
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
            /// <para>The Ray DPI engine version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>err-1.3.0 (Ray 2.55.1, Python 3.12)</para>
            /// </summary>
            [NameInMap("displayReleaseVersion")]
            [Validation(Required=false)]
            public string DisplayReleaseVersion { get; set; }

            /// <summary>
            /// <para>Specifies whether auto-scaling is enabled for worker nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("enableAutoScaling")]
            [Validation(Required=false)]
            public bool? EnableAutoScaling { get; set; }

            /// <summary>
            /// <para>The environment variables.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MY_ENV=123456</para>
            /// </summary>
            [NameInMap("env")]
            [Validation(Required=false)]
            public string Env { get; set; }

            /// <summary>
            /// <para>The GCS fault tolerance configuration.</para>
            /// </summary>
            [NameInMap("gftConfig")]
            [Validation(Required=false)]
            public GetRayClusterResponseBodyHeadSpecGftConfig GftConfig { get; set; }
            public class GetRayClusterResponseBodyHeadSpecGftConfig : TeaModel {
                /// <summary>
                /// <para>The Redis password.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("redisPassword")]
                [Validation(Required=false)]
                public string RedisPassword { get; set; }

                /// <summary>
                /// <para>The Redis endpoint.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.4.5.6:6789</para>
                /// </summary>
                [NameInMap("redisUrl")]
                [Validation(Required=false)]
                public string RedisUrl { get; set; }

                /// <summary>
                /// <para>The Redis username.</para>
                /// 
                /// <b>Example:</b>
                /// <para>default</para>
                /// </summary>
                [NameInMap("redisUsername")]
                [Validation(Required=false)]
                public string RedisUsername { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether GCS fault tolerance is enabled.</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("gftEnabled")]
            [Validation(Required=false)]
            public bool? GftEnabled { get; set; }

            /// <summary>
            /// <para>The GPU driver version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>550</para>
            /// </summary>
            [NameInMap("gpuDriverVersion")]
            [Validation(Required=false)]
            public string GpuDriverVersion { get; set; }

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
            /// <para>The idle timeout period for worker nodes when auto-scaling is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("idleTimeoutSeconds")]
            [Validation(Required=false)]
            public int? IdleTimeoutSeconds { get; set; }

            /// <summary>
            /// <para>The memory size. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8Gi</para>
            /// </summary>
            [NameInMap("memory")]
            [Validation(Required=false)]
            public string Memory { get; set; }

            /// <summary>
            /// <para>The name of the queue.</para>
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
        /// <para>The IDs of the nodes in the Ray cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ray-k7nm8ahl5te4tg93-xxxxxxx</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The IDs of the nodes in the Ray cluster.</para>
        /// </summary>
        [NameInMap("instances")]
        [Validation(Required=false)]
        public List<GetRayClusterResponseBodyInstances> Instances { get; set; }
        public class GetRayClusterResponseBodyInstances : TeaModel {
            /// <summary>
            /// <para>The primary container exit code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>137</para>
            /// </summary>
            [NameInMap("containerExitCode")]
            [Validation(Required=false)]
            public int? ContainerExitCode { get; set; }

            /// <summary>
            /// <para>The primary container state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("containerState")]
            [Validation(Required=false)]
            public string ContainerState { get; set; }

            /// <summary>
            /// <para>The primary container status message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ContainerExit</para>
            /// </summary>
            [NameInMap("containerStateMessage")]
            [Validation(Required=false)]
            public string ContainerStateMessage { get; set; }

            /// <summary>
            /// <para>The primary container information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ok</para>
            /// </summary>
            [NameInMap("containerStateReason")]
            [Validation(Required=false)]
            public string ContainerStateReason { get; set; }

            /// <summary>
            /// <para>The creation time. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1735870116167</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The node ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ray-uiulpgow9xljim10-head-7cgta</para>
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The node pod status message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ok</para>
            /// </summary>
            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The node pod state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("phase")]
            [Validation(Required=false)]
            public string Phase { get; set; }

            /// <summary>
            /// <para>The node information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OOMKilled</para>
            /// </summary>
            [NameInMap("reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>The start time. The value is a UNIX timestamp in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1762946698000</para>
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The node type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Head</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The public endpoint for submitting Ray jobs.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://emr-spark-ray-gateway-cn-hangzhou.aliyuncs.com">https://emr-spark-ray-gateway-cn-hangzhou.aliyuncs.com</a></para>
        /// </summary>
        [NameInMap("jobUrl")]
        [Validation(Required=false)]
        public string JobUrl { get; set; }

        /// <summary>
        /// <para>The internal URL for submitting Ray jobs.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://emr-spark-ray-gateway-cn-hangzhou-internal.emr.aliyuncs.com">http://emr-spark-ray-gateway-cn-hangzhou-internal.emr.aliyuncs.com</a></para>
        /// </summary>
        [NameInMap("jobUrlInner")]
        [Validation(Required=false)]
        public string JobUrlInner { get; set; }

        /// <summary>
        /// <para>The error message returned when the status is Error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Specifies whether the configuration has been modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("modified")]
        [Validation(Required=false)]
        public bool? Modified { get; set; }

        /// <summary>
        /// <para>The update time. The value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1754274541693</para>
        /// </summary>
        [NameInMap("modifiedTime")]
        [Validation(Required=false)]
        public long? ModifiedTime { get; set; }

        /// <summary>
        /// <para>The user ID of the cluster updater.</para>
        /// 
        /// <b>Example:</b>
        /// <para>202077646755523991</para>
        /// </summary>
        [NameInMap("modifier")]
        [Validation(Required=false)]
        public string Modifier { get; set; }

        /// <summary>
        /// <para>The nickname of the updater.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alice</para>
        /// </summary>
        [NameInMap("modifierName")]
        [Validation(Required=false)]
        public string ModifierName { get; set; }

        /// <summary>
        /// <para>The name of the Ray cluster.</para>
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
        /// <para>The Logstore for uploading metrics. The Logstore must be a Metricstore.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myMetricsStore</para>
        /// </summary>
        [NameInMap("slsLogStore")]
        [Validation(Required=false)]
        public string SlsLogStore { get; set; }

        /// <summary>
        /// <para>The Simple Log Service (SLS) project for uploading metrics.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mySLSProject</para>
        /// </summary>
        [NameInMap("slsProject")]
        [Validation(Required=false)]
        public string SlsProject { get; set; }

        /// <summary>
        /// <para>The start time. The value is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1750327083303</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The session status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Starting: The session is starting.</description></item>
        /// <item><description>Running: The session is running.</description></item>
        /// <item><description>Stopping: The session is stopping.</description></item>
        /// <item><description>Stopped: The session is stopped.</description></item>
        /// <item><description>Error: The session has failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <para>The authentication token for submitting Ray jobs. You must include this token in the request header in the following format: &quot;ray-token&quot;: &quot;token&quot;.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1d06484d3b424f7fa4ab7082a4076da2</para>
        /// </summary>
        [NameInMap("submitToken")]
        [Validation(Required=false)]
        public string SubmitToken { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID of the creator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789012</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The list of managed file IDs.</para>
        /// </summary>
        [NameInMap("volumeIds")]
        [Validation(Required=false)]
        public List<string> VolumeIds { get; set; }

        /// <summary>
        /// <para>The Ray cluster worker node information.</para>
        /// </summary>
        [NameInMap("workerSpec")]
        [Validation(Required=false)]
        public List<GetRayClusterResponseBodyWorkerSpec> WorkerSpec { get; set; }
        public class GetRayClusterResponseBodyWorkerSpec : TeaModel {
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
            /// <para>The DPI engine version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ray-1.2.0 (Ray 2.55.1, Python 3.12)</para>
            /// </summary>
            [NameInMap("displayReleaseVersion")]
            [Validation(Required=false)]
            public string DisplayReleaseVersion { get; set; }

            /// <summary>
            /// <para>The environment variables for Ray.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MY_ENV=12456</para>
            /// </summary>
            [NameInMap("env")]
            [Validation(Required=false)]
            public string Env { get; set; }

            /// <summary>
            /// <para>The GPU driver type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>550</para>
            /// </summary>
            [NameInMap("gpuDriverVersion")]
            [Validation(Required=false)]
            public string GpuDriverVersion { get; set; }

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
            /// <para>The worker node group name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WorkerGroup1</para>
            /// </summary>
            [NameInMap("groupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The actual group name in Kubernetes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>worker1</para>
            /// </summary>
            [NameInMap("kubernetesGroupName")]
            [Validation(Required=false)]
            public string KubernetesGroupName { get; set; }

            /// <summary>
            /// <para>The maximum number of worker nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("maxReplica")]
            [Validation(Required=false)]
            public int? MaxReplica { get; set; }

            /// <summary>
            /// <para>The memory size. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8Gi</para>
            /// </summary>
            [NameInMap("memory")]
            [Validation(Required=false)]
            public string Memory { get; set; }

            /// <summary>
            /// <para>The minimum number of worker nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("minReplica")]
            [Validation(Required=false)]
            public int? MinReplica { get; set; }

            /// <summary>
            /// <para>The name of the queue.</para>
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
            /// <para>The number of worker nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("replica")]
            [Validation(Required=false)]
            public int? Replica { get; set; }

            /// <summary>
            /// <para>The worker node group type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CPU</para>
            /// </summary>
            [NameInMap("workerType")]
            [Validation(Required=false)]
            public string WorkerType { get; set; }

        }

    }

}
