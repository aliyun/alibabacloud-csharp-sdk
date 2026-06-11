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
        /// <para>The time when the cluster was created. This is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1750327083303</para>
        /// </summary>
        [NameInMap("createTime")]
        [Validation(Required=false)]
        public long? CreateTime { get; set; }

        /// <summary>
        /// <para>The UID of the user who created the cluster.</para>
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
        /// <para>The URL of the Ray Dashboard for this cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://emr-ray-gateway-cn-hangzhou.aliyuncs.com/workspace/w-xxxxxxxx/raycluster/ray-xxxxxx/dashboard?token=xxxxxx">https://emr-ray-gateway-cn-hangzhou.aliyuncs.com/workspace/w-xxxxxxxx/raycluster/ray-xxxxxx/dashboard?token=xxxxxx</a></para>
        /// </summary>
        [NameInMap("dashboardUrl")]
        [Validation(Required=false)]
        public string DashboardUrl { get; set; }

        /// <summary>
        /// <para>The description of the Ray cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ray Cluster for dev.</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The version of the Ray engine.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ray-1.0.0 (Ray 2.47.1, Python 3.12)</para>
        /// </summary>
        [NameInMap("displayReleaseVersion")]
        [Validation(Required=false)]
        public string DisplayReleaseVersion { get; set; }

        /// <summary>
        /// <para>Additional parameters in JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("extraParam")]
        [Validation(Required=false)]
        public string ExtraParam { get; set; }

        /// <summary>
        /// <para>The gRPC endpoint for the internal network. You can also use the domain name in this endpoint to submit Ray jobs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ray://emr-spark-ray-gateway-cn-hangzhou-internal.emr.aliyuncs.com:80</para>
        /// </summary>
        [NameInMap("grpcEndpoint")]
        [Validation(Required=false)]
        public string GrpcEndpoint { get; set; }

        /// <summary>
        /// <para>The configuration of the head node.</para>
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
            /// <para>Specifies whether auto scaling is enabled for worker nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("enableAutoScaling")]
            [Validation(Required=false)]
            public bool? EnableAutoScaling { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ecs.gn6i-c4g1.xlarge</para>
            /// </summary>
            [NameInMap("gpuSpec")]
            [Validation(Required=false)]
            public string GpuSpec { get; set; }

            /// <summary>
            /// <para>The idle timeout period for worker nodes, in seconds. Applies only when auto scaling is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("idleTimeoutSeconds")]
            [Validation(Required=false)]
            public int? IdleTimeoutSeconds { get; set; }

            /// <summary>
            /// <para>The memory size. Unit: Gi.</para>
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
        /// <para>The ID of the Ray cluster node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ray-k7nm8ahl5te4tg93-xxxxxxx</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The list of nodes in the Ray cluster.</para>
        /// </summary>
        [NameInMap("instances")]
        [Validation(Required=false)]
        public List<GetRayClusterResponseBodyInstances> Instances { get; set; }
        public class GetRayClusterResponseBodyInstances : TeaModel {
            /// <summary>
            /// <para>The exit code of the main container.</para>
            /// 
            /// <b>Example:</b>
            /// <para>137</para>
            /// </summary>
            [NameInMap("containerExitCode")]
            [Validation(Required=false)]
            public int? ContainerExitCode { get; set; }

            /// <summary>
            /// <para>The state of the main container.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("containerState")]
            [Validation(Required=false)]
            public string ContainerState { get; set; }

            /// <summary>
            /// <para>The status message of the main container.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ContainerExit</para>
            /// </summary>
            [NameInMap("containerStateMessage")]
            [Validation(Required=false)]
            public string ContainerStateMessage { get; set; }

            /// <summary>
            /// <para>Additional information about the main container state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ok</para>
            /// </summary>
            [NameInMap("containerStateReason")]
            [Validation(Required=false)]
            public string ContainerStateReason { get; set; }

            /// <summary>
            /// <para>The time when the node was created. This is a UNIX timestamp in milliseconds.</para>
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
            /// <para>The status message of the node pod.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ok</para>
            /// </summary>
            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The phase of the node pod.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("phase")]
            [Validation(Required=false)]
            public string Phase { get; set; }

            /// <summary>
            /// <para>Additional information about the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>OOMKilled</para>
            /// </summary>
            [NameInMap("reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>The time when the node started. This is a UNIX timestamp in milliseconds.</para>
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
        /// <b>Example:</b>
        /// <para><a href="http://emr-spark-ray-gateway-cn-hangzhou-internal.emr.aliyuncs.com">http://emr-spark-ray-gateway-cn-hangzhou-internal.emr.aliyuncs.com</a></para>
        /// </summary>
        [NameInMap("jobUrlInner")]
        [Validation(Required=false)]
        public string JobUrlInner { get; set; }

        /// <summary>
        /// <para>The error message. Returned when <c>state</c> is <c>Error</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Indicates whether the configuration was modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("modified")]
        [Validation(Required=false)]
        public bool? Modified { get; set; }

        /// <summary>
        /// <para>The time when the cluster was last updated. This is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1754274541693</para>
        /// </summary>
        [NameInMap("modifiedTime")]
        [Validation(Required=false)]
        public long? ModifiedTime { get; set; }

        /// <summary>
        /// <para>The UID of the user who last updated the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>202077646755523991</para>
        /// </summary>
        [NameInMap("modifier")]
        [Validation(Required=false)]
        public string Modifier { get; set; }

        /// <summary>
        /// <para>The nickname of the modifier.</para>
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
        /// <para>The name of the network connection.</para>
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
        /// <para>The time when the cluster started. This is a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1750327083303</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The session state. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Starting: The session is starting.</para>
        /// </description></item>
        /// <item><description><para>Running: The session is running.</para>
        /// </description></item>
        /// <item><description><para>Stopping: The session is being stopped.</para>
        /// </description></item>
        /// <item><description><para>Stopped: The session is stopped.</para>
        /// </description></item>
        /// <item><description><para>Error: The session has failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("state")]
        [Validation(Required=false)]
        public string State { get; set; }

        /// <summary>
        /// <para>The authentication token for submitting Ray jobs. Add this token to the request header in the format <c>&quot;ray-token&quot;: &quot;token&quot;</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1d06484d3b424f7fa4ab7082a4076da2</para>
        /// </summary>
        [NameInMap("submitToken")]
        [Validation(Required=false)]
        public string SubmitToken { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account that created the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789012</para>
        /// </summary>
        [NameInMap("userId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("volumeIds")]
        [Validation(Required=false)]
        public List<string> VolumeIds { get; set; }

        /// <summary>
        /// <para>The list of worker node group configurations.</para>
        /// </summary>
        [NameInMap("workerSpec")]
        [Validation(Required=false)]
        public List<GetRayClusterResponseBodyWorkerSpec> WorkerSpec { get; set; }
        public class GetRayClusterResponseBodyWorkerSpec : TeaModel {
            /// <summary>
            /// <para>The number of CPU cores per worker node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("cpu")]
            [Validation(Required=false)]
            public string Cpu { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ecs.gn6i-c4g1.xlarge</para>
            /// </summary>
            [NameInMap("gpuSpec")]
            [Validation(Required=false)]
            public string GpuSpec { get; set; }

            /// <summary>
            /// <para>The name of the worker node group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WorkerGroup1</para>
            /// </summary>
            [NameInMap("groupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The maximum number of worker nodes in the group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("maxReplica")]
            [Validation(Required=false)]
            public int? MaxReplica { get; set; }

            /// <summary>
            /// <para>The memory size per worker node. Unit: Gi.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8Gi</para>
            /// </summary>
            [NameInMap("memory")]
            [Validation(Required=false)]
            public string Memory { get; set; }

            /// <summary>
            /// <para>The minimum number of worker nodes in the group.</para>
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
            /// <para>The number of worker nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("replica")]
            [Validation(Required=false)]
            public int? Replica { get; set; }

            /// <summary>
            /// <para>The type of the worker node group.</para>
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
