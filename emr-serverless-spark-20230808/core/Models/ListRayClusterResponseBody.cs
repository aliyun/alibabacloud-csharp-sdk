// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class ListRayClusterResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of Ray clusters.</para>
        /// </summary>
        [NameInMap("rayClusters")]
        [Validation(Required=false)]
        public List<ListRayClusterResponseBodyRayClusters> RayClusters { get; set; }
        public class ListRayClusterResponseBodyRayClusters : TeaModel {
            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ray-uiulpgow9xljimm1</para>
            /// </summary>
            [NameInMap("clusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The time when the cluster was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1723722279800</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <para>The UID of the user who created the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>202077646755123991</para>
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
            /// <para><a href="https://emr-spark-ray-gateway-cn-hangzhou.aliyuncs.com?token=xxxxxxxxx">https://emr-spark-ray-gateway-cn-hangzhou.aliyuncs.com?token=xxxxxxxxx</a></para>
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
            /// <para>The Ray engine version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ray-1.0.0 (Ray 2.47.1, Python 3.12)</para>
            /// </summary>
            [NameInMap("displayReleaseVersion")]
            [Validation(Required=false)]
            public string DisplayReleaseVersion { get; set; }

            /// <summary>
            /// <para>The gRPC endpoint for the internal network. The domain name can also be used to submit Ray jobs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ray://emr-spark-ray-gateway-cn-hanghzou-internal.emr.aliyuncs.com:80</para>
            /// </summary>
            [NameInMap("grpcEndpoint")]
            [Validation(Required=false)]
            public string GrpcEndpoint { get; set; }

            /// <summary>
            /// <para>The information about the head node of the Ray cluster.</para>
            /// </summary>
            [NameInMap("headSpec")]
            [Validation(Required=false)]
            public ListRayClusterResponseBodyRayClustersHeadSpec HeadSpec { get; set; }
            public class ListRayClusterResponseBodyRayClustersHeadSpec : TeaModel {
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
                /// <para>Indicates whether automatic scaling is enabled for worker nodes.</para>
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
                /// <para>The idle timeout period for worker nodes.</para>
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
            /// <para>The ID of the Ray cluster instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ray-uiulpgow9xljimm1-xxxxxxx</para>
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ok</para>
            /// </summary>
            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>Indicates whether the configuration has been modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("modified")]
            [Validation(Required=false)]
            public bool? Modified { get; set; }

            /// <summary>
            /// <para>The time when the cluster was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1723722279800</para>
            /// </summary>
            [NameInMap("modifiedTime")]
            [Validation(Required=false)]
            public long? ModifiedTime { get; set; }

            /// <summary>
            /// <para>The UID of the user who last updated the cluster.</para>
            /// 
            /// <b>Example:</b>
            /// <para>202077646755123991</para>
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
            /// <para>testRayCluster</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The name of the network connectivity service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc</para>
            /// </summary>
            [NameInMap("networkServiceName")]
            [Validation(Required=false)]
            public string NetworkServiceName { get; set; }

            /// <summary>
            /// <para>The startup time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1723722279800</para>
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <para>The cluster state.</para>
            /// <list type="bullet">
            /// <item><description><para>Starting: The cluster is starting.</para>
            /// </description></item>
            /// <item><description><para>Running: The cluster is running.</para>
            /// </description></item>
            /// <item><description><para>Stopping: The cluster is stopping.</para>
            /// </description></item>
            /// <item><description><para>Stopped: The cluster is stopped.</para>
            /// </description></item>
            /// <item><description><para>Error: The cluster has failed.</para>
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
            /// <para>The ID of the Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1234567890</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The information about the worker nodes of the Ray cluster.</para>
            /// </summary>
            [NameInMap("workerSpec")]
            [Validation(Required=false)]
            public List<ListRayClusterResponseBodyRayClustersWorkerSpec> WorkerSpec { get; set; }
            public class ListRayClusterResponseBodyRayClustersWorkerSpec : TeaModel {
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
                /// <b>Example:</b>
                /// <para>ecs.gn6i-c4g1.xlarge</para>
                /// </summary>
                [NameInMap("gpuSpec")]
                [Validation(Required=false)]
                public string GpuSpec { get; set; }

                /// <summary>
                /// <para>The name of the worker group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Group1</para>
                /// </summary>
                [NameInMap("groupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <para>The maximum number of worker nodes after automatic scaling is enabled.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("maxReplica")]
                [Validation(Required=false)]
                public int? MaxReplica { get; set; }

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
                /// <para>The minimum number of worker nodes after automatic scaling is enabled.</para>
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
                /// <para>The number of nodes.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("replica")]
                [Validation(Required=false)]
                public int? Replica { get; set; }

                /// <summary>
                /// <para>The worker type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CPU</para>
                /// </summary>
                [NameInMap("workerType")]
                [Validation(Required=false)]
                public string WorkerType { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C8944</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
