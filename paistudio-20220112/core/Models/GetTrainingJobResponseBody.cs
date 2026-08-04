// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class GetTrainingJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The training algorithm ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>algo-xsldfvu1334</para>
        /// </summary>
        [NameInMap("AlgorithmId")]
        [Validation(Required=false)]
        public string AlgorithmId { get; set; }

        /// <summary>
        /// <para>The algorithm name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm_training</para>
        /// </summary>
        [NameInMap("AlgorithmName")]
        [Validation(Required=false)]
        public string AlgorithmName { get; set; }

        /// <summary>
        /// <para>The algorithm provider.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pai</para>
        /// </summary>
        [NameInMap("AlgorithmProvider")]
        [Validation(Required=false)]
        public string AlgorithmProvider { get; set; }

        /// <summary>
        /// <para>The temporary algorithm definition.</para>
        /// </summary>
        [NameInMap("AlgorithmSpec")]
        [Validation(Required=false)]
        public AlgorithmSpec AlgorithmSpec { get; set; }

        /// <summary>
        /// <para>The algorithm version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v0.0.1</para>
        /// </summary>
        [NameInMap("AlgorithmVersion")]
        [Validation(Required=false)]
        public string AlgorithmVersion { get; set; }

        [NameInMap("AssignNodeSpec")]
        [Validation(Required=false)]
        public AssignNodeSpec AssignNodeSpec { get; set; }

        /// <summary>
        /// <para>The compute resource configuration.</para>
        /// </summary>
        [NameInMap("ComputeResource")]
        [Validation(Required=false)]
        public GetTrainingJobResponseBodyComputeResource ComputeResource { get; set; }
        public class GetTrainingJobResponseBodyComputeResource : TeaModel {
            /// <summary>
            /// <para>The number of ECS instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("EcsCount")]
            [Validation(Required=false)]
            public long? EcsCount { get; set; }

            /// <summary>
            /// <para>The ECS instance type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs.gn5-c8g1.2xlarge</para>
            /// </summary>
            [NameInMap("EcsSpec")]
            [Validation(Required=false)]
            public string EcsSpec { get; set; }

            /// <summary>
            /// <para>The number of instances used by the resource quota.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("InstanceCount")]
            [Validation(Required=false)]
            public long? InstanceCount { get; set; }

            /// <summary>
            /// <para>The instance specification of the resource quota.</para>
            /// </summary>
            [NameInMap("InstanceSpec")]
            [Validation(Required=false)]
            public GetTrainingJobResponseBodyComputeResourceInstanceSpec InstanceSpec { get; set; }
            public class GetTrainingJobResponseBodyComputeResourceInstanceSpec : TeaModel {
                /// <summary>
                /// <para>The number of CPU cores of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("CPU")]
                [Validation(Required=false)]
                public string CPU { get; set; }

                /// <summary>
                /// <para>The number of GPUs of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("GPU")]
                [Validation(Required=false)]
                public string GPU { get; set; }

                /// <summary>
                /// <para>The GPU type of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>V100</para>
                /// </summary>
                [NameInMap("GPUType")]
                [Validation(Required=false)]
                public string GPUType { get; set; }

                /// <summary>
                /// <para>The memory size of the instance, in GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>32</para>
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public string Memory { get; set; }

                /// <summary>
                /// <para>The shared memory size of the instance, in GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>32</para>
                /// </summary>
                [NameInMap("SharedMemory")]
                [Validation(Required=false)]
                public string SharedMemory { get; set; }

            }

            /// <summary>
            /// <para>The resource quota ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>quotam670lixikcl</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The resource quota name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>quota</para>
            /// </summary>
            [NameInMap("ResourceName")]
            [Validation(Required=false)]
            public string ResourceName { get; set; }

            /// <summary>
            /// <para>The spot instance configuration.</para>
            /// </summary>
            [NameInMap("SpotSpec")]
            [Validation(Required=false)]
            public GetTrainingJobResponseBodyComputeResourceSpotSpec SpotSpec { get; set; }
            public class GetTrainingJobResponseBodyComputeResourceSpotSpec : TeaModel {
                /// <summary>
                /// <para>The maximum hourly price discount for the instance. This parameter takes effect only when SpotStrategy is set to SpotWithPriceLimit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.9</para>
                /// </summary>
                [NameInMap("SpotDiscountLimit")]
                [Validation(Required=false)]
                public float? SpotDiscountLimit { get; set; }

                /// <summary>
                /// <para>SpotStrategy: The bidding policy of the instance. Valid values:</para>
                /// 
                /// <b>Example:</b>
                /// <para>SpotWithPriceLimit</para>
                /// </summary>
                [NameInMap("SpotStrategy")]
                [Validation(Required=false)]
                public string SpotStrategy { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether spot instances are used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("UseSpotInstance")]
            [Validation(Required=false)]
            public bool? UseSpotInstance { get; set; }

        }

        [NameInMap("CredentialConfig")]
        [Validation(Required=false)]
        public CredentialConfig CredentialConfig { get; set; }

        /// <summary>
        /// <para>The running duration of the training job. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7200</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public long? Duration { get; set; }

        /// <summary>
        /// <para>The environment variables of the training job.</para>
        /// </summary>
        [NameInMap("Environments")]
        [Validation(Required=false)]
        public Dictionary<string, string> Environments { get; set; }

        /// <summary>
        /// <para>The experiment configuration associated with the training job.</para>
        /// </summary>
        [NameInMap("ExperimentConfig")]
        [Validation(Required=false)]
        public GetTrainingJobResponseBodyExperimentConfig ExperimentConfig { get; set; }
        public class GetTrainingJobResponseBodyExperimentConfig : TeaModel {
            /// <summary>
            /// <para>The experiment ID associated with the training job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>exp-ds9aefia90v</para>
            /// </summary>
            [NameInMap("ExperimentId")]
            [Validation(Required=false)]
            public string ExperimentId { get; set; }

            /// <summary>
            /// <para>The experiment name associated with the training job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>large_language_model_train</para>
            /// </summary>
            [NameInMap("ExperimentName")]
            [Validation(Required=false)]
            public string ExperimentName { get; set; }

        }

        /// <summary>
        /// <para>The time when the training job was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-07-10T11:49:47Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>The time when the training job status was last updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-07-10T11:49:47Z</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <para>The training hyperparameter settings.</para>
        /// </summary>
        [NameInMap("HyperParameters")]
        [Validation(Required=false)]
        public List<GetTrainingJobResponseBodyHyperParameters> HyperParameters { get; set; }
        public class GetTrainingJobResponseBodyHyperParameters : TeaModel {
            /// <summary>
            /// <para>The parameter name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>learning_rate</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The parameter value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0001</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The training input data configurations.</para>
        /// </summary>
        [NameInMap("InputChannels")]
        [Validation(Required=false)]
        public List<GetTrainingJobResponseBodyInputChannels> InputChannels { get; set; }
        public class GetTrainingJobResponseBodyInputChannels : TeaModel {
            /// <summary>
            /// <para>The dataset ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d-475megosidivjfgfq6</para>
            /// </summary>
            [NameInMap("DatasetId")]
            [Validation(Required=false)]
            public string DatasetId { get; set; }

            /// <summary>
            /// <para>The URI of the input data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://test-bucket.oss-cn-hangzhou-internal.aliyuncs.com/path/to/input/model/</para>
            /// </summary>
            [NameInMap("InputUri")]
            [Validation(Required=false)]
            public string InputUri { get; set; }

            /// <summary>
            /// <para>The name of the input data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>model</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The file system parameters of the input data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ossAppendable=true</para>
            /// </summary>
            [NameInMap("Options")]
            [Validation(Required=false)]
            public string Options { get; set; }

            [NameInMap("RoleArn")]
            [Validation(Required=false)]
            public string RoleArn { get; set; }

            /// <summary>
            /// <para>The dataset version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("VersionName")]
            [Validation(Required=false)]
            public string VersionName { get; set; }

        }

        /// <summary>
        /// <para>The list of training job instances.</para>
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<GetTrainingJobResponseBodyInstances> Instances { get; set; }
        public class GetTrainingJobResponseBodyInstances : TeaModel {
            /// <summary>
            /// <para>The instance name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>train1oug3yehan4-master-0</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The instance role.</para>
            /// 
            /// <b>Example:</b>
            /// <para>master</para>
            /// </summary>
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// <para>The instance status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Succeeded</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether a temporary algorithm is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsTempAlgo")]
        [Validation(Required=false)]
        public bool? IsTempAlgo { get; set; }

        /// <summary>
        /// <para>The list of training job labels.</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<GetTrainingJobResponseBodyLabels> Labels { get; set; }
        public class GetTrainingJobResponseBodyLabels : TeaModel {
            /// <summary>
            /// <para>The label name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CreatedBy</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The label value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>QuickStart</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The list of training job metrics.</para>
        /// </summary>
        [NameInMap("LatestMetrics")]
        [Validation(Required=false)]
        public List<GetTrainingJobResponseBodyLatestMetrics> LatestMetrics { get; set; }
        public class GetTrainingJobResponseBodyLatestMetrics : TeaModel {
            /// <summary>
            /// <para>The metric name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>loss</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The time when the metric was collected.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-07-10T11:49:47Z</para>
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public string Timestamp { get; set; }

            /// <summary>
            /// <para>The metric value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.11</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public double? Value { get; set; }

        }

        /// <summary>
        /// <para>The latest progress of the training job.</para>
        /// </summary>
        [NameInMap("LatestProgress")]
        [Validation(Required=false)]
        public GetTrainingJobResponseBodyLatestProgress LatestProgress { get; set; }
        public class GetTrainingJobResponseBodyLatestProgress : TeaModel {
            /// <summary>
            /// <para>The overall progress of the training job execution.</para>
            /// </summary>
            [NameInMap("OverallProgress")]
            [Validation(Required=false)]
            public GetTrainingJobResponseBodyLatestProgressOverallProgress OverallProgress { get; set; }
            public class GetTrainingJobResponseBodyLatestProgressOverallProgress : TeaModel {
                /// <summary>
                /// <para>The progress timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-07-04T13:20:18Z</para>
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public string Timestamp { get; set; }

                /// <summary>
                /// <para>The progress value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.75</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public float? Value { get; set; }

            }

            /// <summary>
            /// <para>The estimated remaining time for the training job execution, in seconds.</para>
            /// </summary>
            [NameInMap("RemainingTime")]
            [Validation(Required=false)]
            public GetTrainingJobResponseBodyLatestProgressRemainingTime RemainingTime { get; set; }
            public class GetTrainingJobResponseBodyLatestProgressRemainingTime : TeaModel {
                /// <summary>
                /// <para>The progress timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-07-04T13:20:18Z</para>
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public string Timestamp { get; set; }

                /// <summary>
                /// <para>The remaining time, in seconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3600</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public long? Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The training output data configurations.</para>
        /// </summary>
        [NameInMap("OutputChannels")]
        [Validation(Required=false)]
        public List<GetTrainingJobResponseBodyOutputChannels> OutputChannels { get; set; }
        public class GetTrainingJobResponseBodyOutputChannels : TeaModel {
            /// <summary>
            /// <para>The dataset ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d-8o0hh35po15ejcdq2p</para>
            /// </summary>
            [NameInMap("DatasetId")]
            [Validation(Required=false)]
            public string DatasetId { get; set; }

            /// <summary>
            /// <para>The name of the output data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>model</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The URI of the output data.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://test-bucket.oss-cn-hangzhou-internal.aliyuncs.com/path/to/output/model/</para>
            /// </summary>
            [NameInMap("OutputUri")]
            [Validation(Required=false)]
            public string OutputUri { get; set; }

            [NameInMap("RoleArn")]
            [Validation(Required=false)]
            public string RoleArn { get; set; }

            /// <summary>
            /// <para>The dataset version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("VersionName")]
            [Validation(Required=false)]
            public string VersionName { get; set; }

        }

        /// <summary>
        /// <para>The model produced by the training job.</para>
        /// </summary>
        [NameInMap("OutputModel")]
        [Validation(Required=false)]
        public GetTrainingJobResponseBodyOutputModel OutputModel { get; set; }
        public class GetTrainingJobResponseBodyOutputModel : TeaModel {
            /// <summary>
            /// <para>The OutputChannel name corresponding to the model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>model</para>
            /// </summary>
            [NameInMap("OutputChannelName")]
            [Validation(Required=false)]
            public string OutputChannelName { get; set; }

            /// <summary>
            /// <para>The model URI.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://test-bucket.oss-cn-hangzhou-internal.aliyuncs.com/path/to/model/output/</para>
            /// </summary>
            [NameInMap("Uri")]
            [Validation(Required=false)]
            public string Uri { get; set; }

        }

        /// <summary>
        /// <para>The job priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The Python package configuration for the training job.</para>
        /// </summary>
        [NameInMap("PythonRequirements")]
        [Validation(Required=false)]
        public List<string> PythonRequirements { get; set; }

        /// <summary>
        /// <para>The status code of the training job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TrainingJobSucceed</para>
        /// </summary>
        [NameInMap("ReasonCode")]
        [Validation(Required=false)]
        public string ReasonCode { get; set; }

        /// <summary>
        /// <para>The error message of the training job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("ReasonMessage")]
        [Validation(Required=false)]
        public string ReasonMessage { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ARN of the RAM role used for proxy authorization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::{accountID}:role/{roleName}</para>
        /// </summary>
        [NameInMap("RoleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        /// <summary>
        /// <para>The scheduling configuration of the training job.</para>
        /// </summary>
        [NameInMap("Scheduler")]
        [Validation(Required=false)]
        public GetTrainingJobResponseBodyScheduler Scheduler { get; set; }
        public class GetTrainingJobResponseBodyScheduler : TeaModel {
            /// <summary>
            /// <para>The maximum runtime in minutes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("MaxRunningTimeInMinutes")]
            [Validation(Required=false)]
            public string MaxRunningTimeInMinutes { get; set; }

            /// <summary>
            /// <para>The maximum training runtime in seconds. A value of 0 indicates no limit on the maximum runtime.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("MaxRunningTimeInSeconds")]
            [Validation(Required=false)]
            public string MaxRunningTimeInSeconds { get; set; }

        }

        /// <summary>
        /// <para>The additional parameter settings for the training node.</para>
        /// </summary>
        [NameInMap("Settings")]
        [Validation(Required=false)]
        public JobSettings Settings { get; set; }

        /// <summary>
        /// <para>The task status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The list of training job status transitions.</para>
        /// </summary>
        [NameInMap("StatusTransitions")]
        [Validation(Required=false)]
        public List<GetTrainingJobResponseBodyStatusTransitions> StatusTransitions { get; set; }
        public class GetTrainingJobResponseBodyStatusTransitions : TeaModel {
            /// <summary>
            /// <para>The end time of the status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-07-10T11:49:47Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The status code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TrainingJobSucceed</para>
            /// </summary>
            [NameInMap("ReasonCode")]
            [Validation(Required=false)]
            public string ReasonCode { get; set; }

            /// <summary>
            /// <para>The status update message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>KubeDL job runs successfully</para>
            /// </summary>
            [NameInMap("ReasonMessage")]
            [Validation(Required=false)]
            public string ReasonMessage { get; set; }

            /// <summary>
            /// <para>The start time of the status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-07-10T11:49:47Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The training job status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Creating</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The description of the training job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Qwen2 large language model training.</para>
        /// </summary>
        [NameInMap("TrainingJobDescription")]
        [Validation(Required=false)]
        public string TrainingJobDescription { get; set; }

        /// <summary>
        /// <para>The training job ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>traini6hhxiq69eo</para>
        /// </summary>
        [NameInMap("TrainingJobId")]
        [Validation(Required=false)]
        public string TrainingJobId { get; set; }

        /// <summary>
        /// <para>The name of the training job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen_llm</para>
        /// </summary>
        [NameInMap("TrainingJobName")]
        [Validation(Required=false)]
        public string TrainingJobName { get; set; }

        /// <summary>
        /// <para>The URL of the training job details page.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://pai.console.aliyun.com/?regionId=cn-hangzhou&workspaceId=1234#/training/jobs/train1ouyadsl8n4">https://pai.console.aliyun.com/?regionId=cn-hangzhou&amp;workspaceId=1234#/training/jobs/train1ouyadsl8n4</a></para>
        /// </summary>
        [NameInMap("TrainingJobUrl")]
        [Validation(Required=false)]
        public string TrainingJobUrl { get; set; }

        /// <summary>
        /// <para>The user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The user VPC configuration.</para>
        /// </summary>
        [NameInMap("UserVpc")]
        [Validation(Required=false)]
        public GetTrainingJobResponseBodyUserVpc UserVpc { get; set; }
        public class GetTrainingJobResponseBodyUserVpc : TeaModel {
            /// <summary>
            /// <para>The extended CIDR block configuration.</para>
            /// </summary>
            [NameInMap("ExtendedCIDRs")]
            [Validation(Required=false)]
            public List<string> ExtendedCIDRs { get; set; }

            /// <summary>
            /// <para>The security group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-abcdef****</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The vSwitch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vs-abcdef****</para>
            /// </summary>
            [NameInMap("SwitchId")]
            [Validation(Required=false)]
            public string SwitchId { get; set; }

            /// <summary>
            /// <para>VPC ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-abcdef****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86995</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
