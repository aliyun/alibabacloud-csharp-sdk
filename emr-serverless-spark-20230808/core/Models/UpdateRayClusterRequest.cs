// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class UpdateRayClusterRequest : TeaModel {
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
        /// <para>The extra parameters. The value must be in JSON format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("extraParam")]
        [Validation(Required=false)]
        public string ExtraParam { get; set; }

        /// <summary>
        /// <para>The Ray cluster head node information.</para>
        /// </summary>
        [NameInMap("headSpec")]
        [Validation(Required=false)]
        public UpdateRayClusterRequestHeadSpec HeadSpec { get; set; }
        public class UpdateRayClusterRequestHeadSpec : TeaModel {
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
            /// <para>ray-1.2.0 (Ray 2.55.1, Python 3.12)</para>
            /// </summary>
            [NameInMap("displayReleaseVersion")]
            [Validation(Required=false)]
            public string DisplayReleaseVersion { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable automatic scaling.</para>
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
            /// <para>The GCS Fault Tolerance configuration.</para>
            /// </summary>
            [NameInMap("gftConfig")]
            [Validation(Required=false)]
            public UpdateRayClusterRequestHeadSpecGftConfig GftConfig { get; set; }
            public class UpdateRayClusterRequestHeadSpecGftConfig : TeaModel {
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
                /// <para>The Redis address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.4.5.6:6379</para>
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
            /// <para>Specifies whether to enable GCS Fault Tolerance.</para>
            /// 
            /// <b>if can be null:</b>
            /// <c>true</c>
            /// </summary>
            [NameInMap("gftEnabled")]
            [Validation(Required=false)]
            public bool? GftEnabled { get; set; }

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
            /// <para>The idle timeout period of workers after automatic scaling is enabled.</para>
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

        }

        /// <summary>
        /// <para>The Ray cluster name. The name must be 1 to 64 characters in length.</para>
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
        /// <para>The list of managed folder IDs to mount.</para>
        /// </summary>
        [NameInMap("volumeIds")]
        [Validation(Required=false)]
        public List<string> VolumeIds { get; set; }

        /// <summary>
        /// <para>The Ray cluster worker node information. A maximum of 50 groups are supported.</para>
        /// </summary>
        [NameInMap("workerSpec")]
        [Validation(Required=false)]
        public List<UpdateRayClusterRequestWorkerSpec> WorkerSpec { get; set; }
        public class UpdateRayClusterRequestWorkerSpec : TeaModel {
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
            /// <para>The Ray environment variables.</para>
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
            /// <para>The maximum number of workers. Minimum value: 1.</para>
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
            /// <para>The minimum number of workers. Minimum value: 1. The value must be less than or equal to maxReplica.</para>
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
            /// <para>The number of workers. Minimum value: 1.</para>
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

}
