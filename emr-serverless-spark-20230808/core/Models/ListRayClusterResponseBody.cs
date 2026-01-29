// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class ListRayClusterResponseBody : TeaModel {
        [NameInMap("rayClusters")]
        [Validation(Required=false)]
        public List<ListRayClusterResponseBodyRayClusters> RayClusters { get; set; }
        public class ListRayClusterResponseBodyRayClusters : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ray-uiulpgow9xljimm1</para>
            /// </summary>
            [NameInMap("clusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1723722279800</para>
            /// </summary>
            [NameInMap("createTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>202077646755123991</para>
            /// </summary>
            [NameInMap("creator")]
            [Validation(Required=false)]
            public string Creator { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Alice</para>
            /// </summary>
            [NameInMap("creatorName")]
            [Validation(Required=false)]
            public string CreatorName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="https://emr-spark-ray-gateway-cn-hangzhou.aliyuncs.com?token=xxxxxxxxx">https://emr-spark-ray-gateway-cn-hangzhou.aliyuncs.com?token=xxxxxxxxx</a></para>
            /// </summary>
            [NameInMap("dashboardUrl")]
            [Validation(Required=false)]
            public string DashboardUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Ray Cluster for dev.</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ray-1.0.0 (Ray 2.47.1, Python 3.12)</para>
            /// </summary>
            [NameInMap("displayReleaseVersion")]
            [Validation(Required=false)]
            public string DisplayReleaseVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ray://emr-spark-ray-gateway-cn-hanghzou-internal.emr.aliyuncs.com:80</para>
            /// </summary>
            [NameInMap("grpcEndpoint")]
            [Validation(Required=false)]
            public string GrpcEndpoint { get; set; }

            [NameInMap("headSpec")]
            [Validation(Required=false)]
            public ListRayClusterResponseBodyRayClustersHeadSpec HeadSpec { get; set; }
            public class ListRayClusterResponseBodyRayClustersHeadSpec : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("cpu")]
                [Validation(Required=false)]
                public string Cpu { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("enableAutoScaling")]
                [Validation(Required=false)]
                public bool? EnableAutoScaling { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>60</para>
                /// </summary>
                [NameInMap("idleTimeoutSeconds")]
                [Validation(Required=false)]
                public int? IdleTimeoutSeconds { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>8Gi</para>
                /// </summary>
                [NameInMap("memory")]
                [Validation(Required=false)]
                public string Memory { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>root_queue</para>
                /// </summary>
                [NameInMap("queueName")]
                [Validation(Required=false)]
                public string QueueName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("replica")]
                [Validation(Required=false)]
                public int? Replica { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ray-uiulpgow9xljimm1-xxxxxxx</para>
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ok</para>
            /// </summary>
            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("modified")]
            [Validation(Required=false)]
            public bool? Modified { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1723722279800</para>
            /// </summary>
            [NameInMap("modifiedTime")]
            [Validation(Required=false)]
            public long? ModifiedTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>202077646755123991</para>
            /// </summary>
            [NameInMap("modifier")]
            [Validation(Required=false)]
            public string Modifier { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Alice</para>
            /// </summary>
            [NameInMap("modifierName")]
            [Validation(Required=false)]
            public string ModifierName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>testRayCluster</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vpc</para>
            /// </summary>
            [NameInMap("networkServiceName")]
            [Validation(Required=false)]
            public string NetworkServiceName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1723722279800</para>
            /// </summary>
            [NameInMap("startTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("state")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1234567890</para>
            /// </summary>
            [NameInMap("userId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("workerSpec")]
            [Validation(Required=false)]
            public List<ListRayClusterResponseBodyRayClustersWorkerSpec> WorkerSpec { get; set; }
            public class ListRayClusterResponseBodyRayClustersWorkerSpec : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("cpu")]
                [Validation(Required=false)]
                public string Cpu { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Group1</para>
                /// </summary>
                [NameInMap("groupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("maxReplica")]
                [Validation(Required=false)]
                public int? MaxReplica { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>8Gi</para>
                /// </summary>
                [NameInMap("memory")]
                [Validation(Required=false)]
                public string Memory { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("minReplica")]
                [Validation(Required=false)]
                public int? MinReplica { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>root_queue</para>
                /// </summary>
                [NameInMap("queueName")]
                [Validation(Required=false)]
                public string QueueName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("replica")]
                [Validation(Required=false)]
                public int? Replica { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CPU</para>
                /// </summary>
                [NameInMap("workerType")]
                [Validation(Required=false)]
                public string WorkerType { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C8944</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
