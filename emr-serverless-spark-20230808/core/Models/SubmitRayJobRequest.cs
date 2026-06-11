// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class SubmitRayJobRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("activeDeadlineSeconds")]
        [Validation(Required=false)]
        public int? ActiveDeadlineSeconds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>err-1.2.0 (Ray 2.55.1, Python 3.12)</para>
        /// </summary>
        [NameInMap("displayReleaseVersion")]
        [Validation(Required=false)]
        public string DisplayReleaseVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>python -c &quot;print(\&quot;hello ray job\&quot;)&quot;</para>
        /// </summary>
        [NameInMap("entrypoint")]
        [Validation(Required=false)]
        public string Entrypoint { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4Gi</para>
        /// </summary>
        [NameInMap("entrypointMemory")]
        [Validation(Required=false)]
        public string EntrypointMemory { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("entrypointNumCpus")]
        [Validation(Required=false)]
        public string EntrypointNumCpus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("entrypointNumGpus")]
        [Validation(Required=false)]
        public string EntrypointNumGpus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;fpu&quot;: 1}</para>
        /// </summary>
        [NameInMap("entrypointResources")]
        [Validation(Required=false)]
        public string EntrypointResources { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;userDefinedFiles&quot;: &quot;oss://mybucket/artifact/config.json,oss://mybucket/artifact/config2.json&quot;, &quot;userRequirementsFile&quot;: &quot;oss://mybucket/requirements.txt&quot;}</para>
        /// </summary>
        [NameInMap("extraParam")]
        [Validation(Required=false)]
        public string ExtraParam { get; set; }

        [NameInMap("headSpec")]
        [Validation(Required=false)]
        public SubmitRayJobRequestHeadSpec HeadSpec { get; set; }
        public class SubmitRayJobRequestHeadSpec : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("cpu")]
            [Validation(Required=false)]
            public string Cpu { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
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

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;resourceName&quot;: &quot;test&quot;}</para>
        /// </summary>
        [NameInMap("metadataJson")]
        [Validation(Required=false)]
        public string MetadataJson { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>my-job</para>
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
        /// <para>{&quot;pip&quot;:[&quot;requests==2.26.0&quot;,&quot;pendulum==2.1.2&quot;],&quot;env_vars&quot;:{&quot;KEY&quot;:&quot;VALUE&quot;}}</para>
        /// </summary>
        [NameInMap("runtimeEnvJson")]
        [Validation(Required=false)]
        public string RuntimeEnvJson { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("shutdownAfterJobFinishes")]
        [Validation(Required=false)]
        public bool? ShutdownAfterJobFinishes { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>HTTPMode</para>
        /// </summary>
        [NameInMap("submissionMode")]
        [Validation(Required=false)]
        public string SubmissionMode { get; set; }

        [NameInMap("tags")]
        [Validation(Required=false)]
        public List<SubmitRayJobRequestTags> Tags { get; set; }
        public class SubmitRayJobRequestTags : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>jobname</para>
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("ttlSecondsAfterFinished")]
        [Validation(Required=false)]
        public int? TtlSecondsAfterFinished { get; set; }

        [NameInMap("volumeIds")]
        [Validation(Required=false)]
        public List<string> VolumeIds { get; set; }

        [NameInMap("workerSpec")]
        [Validation(Required=false)]
        public List<SubmitRayJobRequestWorkerSpec> WorkerSpec { get; set; }
        public class SubmitRayJobRequestWorkerSpec : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>4</para>
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
            /// <b>Example:</b>
            /// <para>WorkerGroup1</para>
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
            /// <para>16Gi</para>
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>oss://mybucket/rayjob.zip</para>
        /// </summary>
        [NameInMap("workingDir")]
        [Validation(Required=false)]
        public string WorkingDir { get; set; }

    }

}
