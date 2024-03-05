// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class SubmitServerlessJobRequest : TeaModel {
        /// <summary>
        /// The configuration of the array job.
        /// 
        /// >  The value of an array job index is passed to a serverless job container through the environment variable `EHPC_ARRAY_TASK_ID`. Users can access the container from business programs.
        /// </summary>
        [NameInMap("ArrayProperties")]
        [Validation(Required=false)]
        public SubmitServerlessJobRequestArrayProperties ArrayProperties { get; set; }
        public class SubmitServerlessJobRequestArrayProperties : TeaModel {
            /// <summary>
            /// The end value of the array job index. Valid values: 0 to 4999. The value must be greater than or equal to the value of IndexStart.
            /// </summary>
            [NameInMap("IndexEnd")]
            [Validation(Required=false)]
            public long? IndexEnd { get; set; }

            /// <summary>
            /// The start value of the array job index. Valid values: 0 to 4999.
            /// </summary>
            [NameInMap("IndexStart")]
            [Validation(Required=false)]
            public long? IndexStart { get; set; }

            /// <summary>
            /// The interval of the array job index.
            /// 
            /// >  If the array job property is IndexStart=1,IndexEnd=5, and IndexStep=2, the array job contains three subtasks. The values of the subtask indexes are 1,3, and 5.
            /// </summary>
            [NameInMap("IndexStep")]
            [Validation(Required=false)]
            public long? IndexStep { get; set; }

        }

        /// <summary>
        /// The ID of the E-HPC cluster.
        /// 
        /// You can call the [ListClusters](~~87116~~) operation to query the cluster ID.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The properties of the serverless job container.
        /// </summary>
        [NameInMap("Container")]
        [Validation(Required=false)]
        public SubmitServerlessJobRequestContainer Container { get; set; }
        public class SubmitServerlessJobRequestContainer : TeaModel {
            /// <summary>
            /// The arguments of the container startup command. You can specify up to 10 arguments.
            /// </summary>
            [NameInMap("Arg")]
            [Validation(Required=false)]
            public List<string> Arg { get; set; }

            /// <summary>
            /// The container startup commands.
            /// </summary>
            [NameInMap("Command")]
            [Validation(Required=false)]
            public List<string> Command { get; set; }

            /// <summary>
            /// The environment variable of the container.
            /// </summary>
            [NameInMap("EnvironmentVar")]
            [Validation(Required=false)]
            public List<SubmitServerlessJobRequestContainerEnvironmentVar> EnvironmentVar { get; set; }
            public class SubmitServerlessJobRequestContainerEnvironmentVar : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// The value of the environment variable for the container. The value must be 0 to 256 characters in length.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// The number of GPUs of the container.
            /// </summary>
            [NameInMap("Gpu")]
            [Validation(Required=false)]
            public int? Gpu { get; set; }

            /// <summary>
            /// The image of the container.
            /// </summary>
            [NameInMap("Image")]
            [Validation(Required=false)]
            public string Image { get; set; }

            /// <summary>
            /// The data volumes mounted to the container.
            /// </summary>
            [NameInMap("VolumeMount")]
            [Validation(Required=false)]
            public List<SubmitServerlessJobRequestContainerVolumeMount> VolumeMount { get; set; }
            public class SubmitServerlessJobRequestContainerVolumeMount : TeaModel {
                [NameInMap("FlexVolumeDriver")]
                [Validation(Required=false)]
                public string FlexVolumeDriver { get; set; }

                [NameInMap("FlexVolumeOptions")]
                [Validation(Required=false)]
                public string FlexVolumeOptions { get; set; }

                /// <summary>
                /// The directory to which the volume is mounted.
                /// 
                /// > The data stored in this directory is overwritten by the data on the volume. Specify this parameter with caution.
                /// </summary>
                [NameInMap("MountPath")]
                [Validation(Required=false)]
                public string MountPath { get; set; }

            }

            /// <summary>
            /// The working directory of the container.
            /// </summary>
            [NameInMap("WorkingDir")]
            [Validation(Required=false)]
            public string WorkingDir { get; set; }

        }

        /// <summary>
        /// The vCPU size of the serverless job container. Unit: cores.
        /// </summary>
        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public float? Cpu { get; set; }

        /// <summary>
        /// The serverless job dependencies.
        /// </summary>
        [NameInMap("DependsOn")]
        [Validation(Required=false)]
        public List<SubmitServerlessJobRequestDependsOn> DependsOn { get; set; }
        public class SubmitServerlessJobRequestDependsOn : TeaModel {
            /// <summary>
            /// The ID of the dependent job.
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// The type of the dependency. Valid values:
            /// 
            /// *   AfterSucceeded: **All subtasks** of the array job or the dependent job are successfully run. The exit code is 0.
            /// *   AfterFailed: **Any subtask** of the array job or the dependent job fails. The exit code is not 0.
            /// *   AfterAny: The dependent job completes.
            /// *   AfterCorresponding: The subtasks of the array job is successfully run. The exit code is 0.
            /// 
            /// Default value: AfterSucceeded.
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// The size of the temporary storage that is added to the serverless job container. Unit: GiB.
        /// 
        /// >  By default, the serverless job container provides 30 GiB of free storage quota. If you require storage of more than 30 GiB, you can use this parameter to specify the temporary storage to add to the job container.
        /// </summary>
        [NameInMap("EphemeralStorage")]
        [Validation(Required=false)]
        public int? EphemeralStorage { get; set; }

        /// <summary>
        /// The ECS instance types used by the serverless job container.
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public List<string> InstanceType { get; set; }

        /// <summary>
        /// The name of the serverless job.
        /// </summary>
        [NameInMap("JobName")]
        [Validation(Required=false)]
        public string JobName { get; set; }

        /// <summary>
        /// The scheduling priority of the serverless job. Valid values: 0 to 999. A greater value indicates a higher priority.
        /// </summary>
        [NameInMap("JobPriority")]
        [Validation(Required=false)]
        public long? JobPriority { get; set; }

        /// <summary>
        /// The memory size of the serverless job container. Unit: GiB.
        /// </summary>
        [NameInMap("Memory")]
        [Validation(Required=false)]
        public float? Memory { get; set; }

        /// <summary>
        /// The name of the RAM role that is associated with the serverless job container.
        /// </summary>
        [NameInMap("RamRoleName")]
        [Validation(Required=false)]
        public string RamRoleName { get; set; }

        [NameInMap("RetryStrategy")]
        [Validation(Required=false)]
        public SubmitServerlessJobRequestRetryStrategy RetryStrategy { get; set; }
        public class SubmitServerlessJobRequestRetryStrategy : TeaModel {
            [NameInMap("Attempts")]
            [Validation(Required=false)]
            public int? Attempts { get; set; }

            [NameInMap("EvaluateOnExit")]
            [Validation(Required=false)]
            public List<SubmitServerlessJobRequestRetryStrategyEvaluateOnExit> EvaluateOnExit { get; set; }
            public class SubmitServerlessJobRequestRetryStrategyEvaluateOnExit : TeaModel {
                [NameInMap("Action")]
                [Validation(Required=false)]
                public string Action { get; set; }

                [NameInMap("OnExitCode")]
                [Validation(Required=false)]
                public string OnExitCode { get; set; }

            }

        }

        /// <summary>
        /// The maximum hourly price of the preemptible instance. The value can contain up to three decimal places.
        /// 
        /// If you set SpotStrategy to SpotWithPriceLimit, you must specify the SpotPriceLimit parameter.
        /// </summary>
        [NameInMap("SpotPriceLimit")]
        [Validation(Required=false)]
        public float? SpotPriceLimit { get; set; }

        /// <summary>
        /// The bidding policy for the instance. Valid values:
        /// 
        /// *   NoSpot: The instance is created as a pay-as-you-go instance.
        /// *   SpotWithPriceLimit: The instance is created as a preemptible instance with a user-defined maximum hourly price.
        /// *   SpotAsPriceGo: The instance is created as a preemptible instance for which the market price at the time of purchase is used as the bid price.
        /// 
        /// Default value: NoSpot.
        /// </summary>
        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

        /// <summary>
        /// The validity period of the serverless job. After the validity period expires, the job is forcibly terminated. Unit: seconds.
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public long? Timeout { get; set; }

        /// <summary>
        /// The IDs of the vSwitches to which the serverless job container belongs.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public List<string> VSwitchId { get; set; }

    }

}
