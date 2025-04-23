// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class SubmitServerlessJobRequest : TeaModel {
        /// <summary>
        /// <para>The configuration of the array job.</para>
        /// <remarks>
        /// <para> The value of an array job index is passed to a serverless job container through the environment variable <c>EHPC_ARRAY_TASK_ID</c>. Users can access the container from business programs.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ArrayProperties")]
        [Validation(Required=false)]
        public SubmitServerlessJobRequestArrayProperties ArrayProperties { get; set; }
        public class SubmitServerlessJobRequestArrayProperties : TeaModel {
            /// <summary>
            /// <para>The end value of the array job index. Valid values: 0 to 4999. The value must be greater than or equal to the value of IndexStart.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("IndexEnd")]
            [Validation(Required=false)]
            public long? IndexEnd { get; set; }

            /// <summary>
            /// <para>The starting value of the array job index. Valid values: 0 to 4999.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("IndexStart")]
            [Validation(Required=false)]
            public long? IndexStart { get; set; }

            /// <summary>
            /// <para>The interval of the array job index.</para>
            /// <remarks>
            /// <para> If the array job property is IndexStart=1,IndexEnd=5, and IndexStep=2, the array job contains three subtasks. The values of the subtask indexes are 1,3, and 5.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("IndexStep")]
            [Validation(Required=false)]
            public long? IndexStep { get; set; }

        }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/87116.html">ListClusters</a> operation to query the cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ehpc-hz-FYUr32****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The properties of the Serverless job container.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Container")]
        [Validation(Required=false)]
        public SubmitServerlessJobRequestContainer Container { get; set; }
        public class SubmitServerlessJobRequestContainer : TeaModel {
            /// <summary>
            /// <para>The arguments of the container startup command. You can specify up to 10 arguments.</para>
            /// </summary>
            [NameInMap("Arg")]
            [Validation(Required=false)]
            public List<string> Arg { get; set; }

            /// <summary>
            /// <para>The container startup commands.</para>
            /// </summary>
            [NameInMap("Command")]
            [Validation(Required=false)]
            public List<string> Command { get; set; }

            /// <summary>
            /// <para>The value of the environment variable for the container.</para>
            /// </summary>
            [NameInMap("EnvironmentVar")]
            [Validation(Required=false)]
            public List<SubmitServerlessJobRequestContainerEnvironmentVar> EnvironmentVar { get; set; }
            public class SubmitServerlessJobRequestContainerEnvironmentVar : TeaModel {
                /// <summary>
                /// <para>The name of the environment variable for the container. The name can be 1 to 128 characters in length and can contain letters, digits, and underscores (_). The name cannot start with a digit. Specify the name in the [0-9a-zA-Z] format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PATH</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of the environment variable for the container. The value must be 0 to 256 bits in length.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/usr/local/bin</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The number of GPUs used by the container.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Gpu")]
            [Validation(Required=false)]
            public int? Gpu { get; set; }

            /// <summary>
            /// <para>The container image.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>registry-vpc.cn-hangzhou.aliyuncs.com/ehpc/hpl:latest</para>
            /// </summary>
            [NameInMap("Image")]
            [Validation(Required=false)]
            public string Image { get; set; }

            /// <summary>
            /// <para>The data volumes that are mounted to the container.</para>
            /// </summary>
            [NameInMap("VolumeMount")]
            [Validation(Required=false)]
            public List<SubmitServerlessJobRequestContainerVolumeMount> VolumeMount { get; set; }
            public class SubmitServerlessJobRequestContainerVolumeMount : TeaModel {
                /// <summary>
                /// <para>The driver type when you use the FlexVolume plug-in to mount a volume. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>alicloud/nas: a NAS driver.</description></item>
                /// <item><description>alicloud/oss: an OSS driver.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>alicloud/oss</para>
                /// </summary>
                [NameInMap("FlexVolumeDriver")]
                [Validation(Required=false)]
                public string FlexVolumeDriver { get; set; }

                /// <summary>
                /// <para>The options of the FlexVolume object. Each option is a key-value pair in a JSON string.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;bucket&quot;:&quot;hpctest&quot;,&quot;url&quot;: &quot;oss-cn-hangzhou-internal.aliyuncs.com
                /// &quot;,&quot;path&quot;:&quot;/data&quot;,&quot;ramRole&quot;:&quot;AliyunECSInstanceForEHPCRole&quot;}</para>
                /// </summary>
                [NameInMap("FlexVolumeOptions")]
                [Validation(Required=false)]
                public string FlexVolumeOptions { get; set; }

                /// <summary>
                /// <para>The directory to which the volume is mounted.</para>
                /// <remarks>
                /// <para> The data stored in this directory is overwritten by the data on the volume. Exercise caution when you specify this parameter.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>/data</para>
                /// </summary>
                [NameInMap("MountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

            }

            /// <summary>
            /// <para>The working directory of the container.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/usr/local/</para>
            /// </summary>
            [NameInMap("WorkingDir")]
            [Validation(Required=false)]
            public string WorkingDir { get; set; }

        }

        /// <summary>
        /// <para>The vCPU size of the serverless job container. Unit: cores.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public float? Cpu { get; set; }

        /// <summary>
        /// <para>The dependencies of the serverless job.</para>
        /// </summary>
        [NameInMap("DependsOn")]
        [Validation(Required=false)]
        public List<SubmitServerlessJobRequestDependsOn> DependsOn { get; set; }
        public class SubmitServerlessJobRequestDependsOn : TeaModel {
            /// <summary>
            /// <para>The ID of the dependent job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The dependency type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>AfterSucceeded: <b>All subtasks</b> of the dependent job or array job succeed. The exit code is 0.</description></item>
            /// <item><description>AfterFailed: <b>All subtasks</b> of the dependent job or array job fail. The exit code is not 0.</description></item>
            /// <item><description>AfterAny: The dependent job completes (succeeds or fails).</description></item>
            /// <item><description>AfterCorresponding: The subtask corresponding to the dependent array job succeeds. The exit code is 0.</description></item>
            /// </list>
            /// <para>Default value: AfterSucceeded.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AfterAny</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The size of the temporary storage space added to the serverless job container. Unit: GiB.</para>
        /// <remarks>
        /// <para> By default, a space of 30 GiB is provided free of charge. If you require a larger space, you can pass this parameter to specify your required space size.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("EphemeralStorage")]
        [Validation(Required=false)]
        public int? EphemeralStorage { get; set; }

        /// <summary>
        /// <para>The Elastic Compute Service (ECS) instance types used by the serverless job container.</para>
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public List<string> InstanceType { get; set; }

        /// <summary>
        /// <para>The name of the serverless job.</para>
        /// <remarks>
        /// <para> The name can contain lowercase letters, digits, and hyphens (-). It cannot start or end with a hyphen.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testjob</para>
        /// </summary>
        [NameInMap("JobName")]
        [Validation(Required=false)]
        public string JobName { get; set; }

        /// <summary>
        /// <para>The scheduling priority of the serverless job. Valid values: 0 to 999. A greater value indicates a higher priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("JobPriority")]
        [Validation(Required=false)]
        public long? JobPriority { get; set; }

        /// <summary>
        /// <para>The memory size of the serverless job container. Unit: GiB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public float? Memory { get; set; }

        /// <summary>
        /// <para>The Resource Access Manamement (RAM) role that is associated with the Serverless job container.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testRamRoleName</para>
        /// </summary>
        [NameInMap("RamRoleName")]
        [Validation(Required=false)]
        public string RamRoleName { get; set; }

        /// <summary>
        /// <para>The retry policy of the serverless job.</para>
        /// </summary>
        [NameInMap("RetryStrategy")]
        [Validation(Required=false)]
        public SubmitServerlessJobRequestRetryStrategy RetryStrategy { get; set; }
        public class SubmitServerlessJobRequestRetryStrategy : TeaModel {
            /// <summary>
            /// <para>The number of retries for the serverless job. Valid values: 1 to 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Attempts")]
            [Validation(Required=false)]
            public int? Attempts { get; set; }

            /// <summary>
            /// <para>The retry rules for the serverless job. You can specify up to 10 rules.</para>
            /// </summary>
            [NameInMap("EvaluateOnExit")]
            [Validation(Required=false)]
            public List<SubmitServerlessJobRequestRetryStrategyEvaluateOnExit> EvaluateOnExit { get; set; }
            public class SubmitServerlessJobRequestRetryStrategyEvaluateOnExit : TeaModel {
                /// <summary>
                /// <para>The job action. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Retry: The job starts a retry when a specific exit code is hit.</description></item>
                /// <item><description>Exit: The job exits when a specific exit code is hit.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Retry</para>
                /// </summary>
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                /// <summary>
                /// <para>The job exit code, which is used together with Action to form a job retry rule. Valid values: 0 to 255.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("OnExitCode")]
                [Validation(Required=false)]
                public string OnExitCode { get; set; }

            }

        }

        /// <summary>
        /// <para>The maximum hourly price of the preemptible elastic container instance. The value can be accurate to three decimal places.</para>
        /// <para>If you set SpotStrategy to SpotWithPriceLimit, you must specify the SpotPriceLimit parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.062</para>
        /// </summary>
        [NameInMap("SpotPriceLimit")]
        [Validation(Required=false)]
        public float? SpotPriceLimit { get; set; }

        /// <summary>
        /// <para>The bidding policy of the ECS instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NoSpot: The instance is created as a pay-as-you-go instance.</description></item>
        /// <item><description>SpotWithPriceLimit: The instance is created as a preemptible instance for which you specify the maximum hourly price.</description></item>
        /// <item><description>SpotAsPriceGo: The instance is created as a preemptible instance for which the market price at the time of purchase is automatically used as the bid price.</description></item>
        /// </list>
        /// <para>Default value: NoSpot.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SpotWithPriceLimit</para>
        /// </summary>
        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

        /// <summary>
        /// <para>The validity period of the serverless job. After the validity period expires, the job is forcibly terminated. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public long? Timeout { get; set; }

        /// <summary>
        /// <para>The IDs of the vSwitches to which the serverless job container belongs.</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public List<string> VSwitchId { get; set; }

    }

}
