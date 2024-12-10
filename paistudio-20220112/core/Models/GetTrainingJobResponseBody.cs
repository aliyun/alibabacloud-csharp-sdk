// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class GetTrainingJobResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>algo-xsldfvu1334</para>
        /// </summary>
        [NameInMap("AlgorithmId")]
        [Validation(Required=false)]
        public string AlgorithmId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>llm_training</para>
        /// </summary>
        [NameInMap("AlgorithmName")]
        [Validation(Required=false)]
        public string AlgorithmName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pai</para>
        /// </summary>
        [NameInMap("AlgorithmProvider")]
        [Validation(Required=false)]
        public string AlgorithmProvider { get; set; }

        [NameInMap("AlgorithmSpec")]
        [Validation(Required=false)]
        public AlgorithmSpec AlgorithmSpec { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>v0.0.1</para>
        /// </summary>
        [NameInMap("AlgorithmVersion")]
        [Validation(Required=false)]
        public string AlgorithmVersion { get; set; }

        [NameInMap("ComputeResource")]
        [Validation(Required=false)]
        public GetTrainingJobResponseBodyComputeResource ComputeResource { get; set; }
        public class GetTrainingJobResponseBodyComputeResource : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("EcsCount")]
            [Validation(Required=false)]
            public long? EcsCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ecs.gn5-c8g1.2xlarge</para>
            /// </summary>
            [NameInMap("EcsSpec")]
            [Validation(Required=false)]
            public string EcsSpec { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("InstanceCount")]
            [Validation(Required=false)]
            public long? InstanceCount { get; set; }

            [NameInMap("InstanceSpec")]
            [Validation(Required=false)]
            public GetTrainingJobResponseBodyComputeResourceInstanceSpec InstanceSpec { get; set; }
            public class GetTrainingJobResponseBodyComputeResourceInstanceSpec : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("CPU")]
                [Validation(Required=false)]
                public string CPU { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("GPU")]
                [Validation(Required=false)]
                public string GPU { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>V100</para>
                /// </summary>
                [NameInMap("GPUType")]
                [Validation(Required=false)]
                public string GPUType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>32</para>
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public string Memory { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>32</para>
                /// </summary>
                [NameInMap("SharedMemory")]
                [Validation(Required=false)]
                public string SharedMemory { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>quotam670lixikcl</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            [NameInMap("ResourceName")]
            [Validation(Required=false)]
            public string ResourceName { get; set; }

            [NameInMap("SpotSpec")]
            [Validation(Required=false)]
            public GetTrainingJobResponseBodyComputeResourceSpotSpec SpotSpec { get; set; }
            public class GetTrainingJobResponseBodyComputeResourceSpotSpec : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0.9</para>
                /// </summary>
                [NameInMap("SpotDiscountLimit")]
                [Validation(Required=false)]
                public float? SpotDiscountLimit { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>SpotWithPriceLimit</para>
                /// </summary>
                [NameInMap("SpotStrategy")]
                [Validation(Required=false)]
                public string SpotStrategy { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("UseSpotInstance")]
            [Validation(Required=false)]
            public bool? UseSpotInstance { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7200</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public long? Duration { get; set; }

        [NameInMap("Environments")]
        [Validation(Required=false)]
        public Dictionary<string, string> Environments { get; set; }

        [NameInMap("ExperimentConfig")]
        [Validation(Required=false)]
        public GetTrainingJobResponseBodyExperimentConfig ExperimentConfig { get; set; }
        public class GetTrainingJobResponseBodyExperimentConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>exp-ds9aefia90v</para>
            /// </summary>
            [NameInMap("ExperimentId")]
            [Validation(Required=false)]
            public string ExperimentId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>large_language_model_train</para>
            /// </summary>
            [NameInMap("ExperimentName")]
            [Validation(Required=false)]
            public string ExperimentName { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-07-10T11:49:47Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2024-07-10T11:49:47Z</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        [NameInMap("HyperParameters")]
        [Validation(Required=false)]
        public List<GetTrainingJobResponseBodyHyperParameters> HyperParameters { get; set; }
        public class GetTrainingJobResponseBodyHyperParameters : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>learning_rate</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.0001</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("InputChannels")]
        [Validation(Required=false)]
        public List<GetTrainingJobResponseBodyInputChannels> InputChannels { get; set; }
        public class GetTrainingJobResponseBodyInputChannels : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>d-475megosidivjfgfq6</para>
            /// </summary>
            [NameInMap("DatasetId")]
            [Validation(Required=false)]
            public string DatasetId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>oss://test-bucket.oss-cn-hangzhou-internal.aliyuncs.com/path/to/input/model/</para>
            /// </summary>
            [NameInMap("InputUri")]
            [Validation(Required=false)]
            public string InputUri { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>model</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Options")]
            [Validation(Required=false)]
            public string Options { get; set; }

            [NameInMap("VersionName")]
            [Validation(Required=false)]
            public string VersionName { get; set; }

        }

        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<GetTrainingJobResponseBodyInstances> Instances { get; set; }
        public class GetTrainingJobResponseBodyInstances : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>train1oug3yehan4-master-0</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>master</para>
            /// </summary>
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Succeeded</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsTempAlgo")]
        [Validation(Required=false)]
        public bool? IsTempAlgo { get; set; }

        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<GetTrainingJobResponseBodyLabels> Labels { get; set; }
        public class GetTrainingJobResponseBodyLabels : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>CreatedBy</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>QuickStart</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("LatestMetrics")]
        [Validation(Required=false)]
        public List<GetTrainingJobResponseBodyLatestMetrics> LatestMetrics { get; set; }
        public class GetTrainingJobResponseBodyLatestMetrics : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>loss</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-07-10T11:49:47Z</para>
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public string Timestamp { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0.11</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public double? Value { get; set; }

        }

        [NameInMap("LatestProgress")]
        [Validation(Required=false)]
        public GetTrainingJobResponseBodyLatestProgress LatestProgress { get; set; }
        public class GetTrainingJobResponseBodyLatestProgress : TeaModel {
            [NameInMap("OverallProgress")]
            [Validation(Required=false)]
            public GetTrainingJobResponseBodyLatestProgressOverallProgress OverallProgress { get; set; }
            public class GetTrainingJobResponseBodyLatestProgressOverallProgress : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-07-04T13:20:18Z</para>
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public string Timestamp { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.75</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public float? Value { get; set; }

            }

            [NameInMap("RemainingTime")]
            [Validation(Required=false)]
            public GetTrainingJobResponseBodyLatestProgressRemainingTime RemainingTime { get; set; }
            public class GetTrainingJobResponseBodyLatestProgressRemainingTime : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-07-04T13:20:18Z</para>
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public string Timestamp { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>3600</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public long? Value { get; set; }

            }

        }

        [NameInMap("OutputChannels")]
        [Validation(Required=false)]
        public List<GetTrainingJobResponseBodyOutputChannels> OutputChannels { get; set; }
        public class GetTrainingJobResponseBodyOutputChannels : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>d-8o0hh35po15ejcdq2p</para>
            /// </summary>
            [NameInMap("DatasetId")]
            [Validation(Required=false)]
            public string DatasetId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>model</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>oss://test-bucket.oss-cn-hangzhou-internal.aliyuncs.com/path/to/output/model/</para>
            /// </summary>
            [NameInMap("OutputUri")]
            [Validation(Required=false)]
            public string OutputUri { get; set; }

            [NameInMap("VersionName")]
            [Validation(Required=false)]
            public string VersionName { get; set; }

        }

        [NameInMap("OutputModel")]
        [Validation(Required=false)]
        public GetTrainingJobResponseBodyOutputModel OutputModel { get; set; }
        public class GetTrainingJobResponseBodyOutputModel : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>model</para>
            /// </summary>
            [NameInMap("OutputChannelName")]
            [Validation(Required=false)]
            public string OutputChannelName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>oss://test-bucket.oss-cn-hangzhou-internal.aliyuncs.com/path/to/model/output/</para>
            /// </summary>
            [NameInMap("Uri")]
            [Validation(Required=false)]
            public string Uri { get; set; }

        }

        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        [NameInMap("PythonRequirements")]
        [Validation(Required=false)]
        public List<string> PythonRequirements { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>TrainingJobSucceed</para>
        /// </summary>
        [NameInMap("ReasonCode")]
        [Validation(Required=false)]
        public string ReasonCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("ReasonMessage")]
        [Validation(Required=false)]
        public string ReasonMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>acs:ram::{accountID}:role/{roleName}</para>
        /// </summary>
        [NameInMap("RoleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        [NameInMap("Scheduler")]
        [Validation(Required=false)]
        public GetTrainingJobResponseBodyScheduler Scheduler { get; set; }
        public class GetTrainingJobResponseBodyScheduler : TeaModel {
            [NameInMap("MaxRunningTimeInMinutes")]
            [Validation(Required=false)]
            public string MaxRunningTimeInMinutes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("MaxRunningTimeInSeconds")]
            [Validation(Required=false)]
            public string MaxRunningTimeInSeconds { get; set; }

        }

        [NameInMap("Settings")]
        [Validation(Required=false)]
        public JobSettings Settings { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("StatusTransitions")]
        [Validation(Required=false)]
        public List<GetTrainingJobResponseBodyStatusTransitions> StatusTransitions { get; set; }
        public class GetTrainingJobResponseBodyStatusTransitions : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-07-10T11:49:47Z</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>TrainingJobSucceed</para>
            /// </summary>
            [NameInMap("ReasonCode")]
            [Validation(Required=false)]
            public string ReasonCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>KubeDL job runs successfully</para>
            /// </summary>
            [NameInMap("ReasonMessage")]
            [Validation(Required=false)]
            public string ReasonMessage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-07-10T11:49:47Z</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Creating</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("TrainingJobDescription")]
        [Validation(Required=false)]
        public string TrainingJobDescription { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>traini6hhxiq69eo</para>
        /// </summary>
        [NameInMap("TrainingJobId")]
        [Validation(Required=false)]
        public string TrainingJobId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>qwen_llm</para>
        /// </summary>
        [NameInMap("TrainingJobName")]
        [Validation(Required=false)]
        public string TrainingJobName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://pai.console.aliyun.com/?regionId=cn-hangzhou&workspaceId=1234#/training/jobs/train1ouyadsl8n4">https://pai.console.aliyun.com/?regionId=cn-hangzhou&amp;workspaceId=1234#/training/jobs/train1ouyadsl8n4</a></para>
        /// </summary>
        [NameInMap("TrainingJobUrl")]
        [Validation(Required=false)]
        public string TrainingJobUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>123456789</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("UserVpc")]
        [Validation(Required=false)]
        public GetTrainingJobResponseBodyUserVpc UserVpc { get; set; }
        public class GetTrainingJobResponseBodyUserVpc : TeaModel {
            [NameInMap("ExtendedCIDRs")]
            [Validation(Required=false)]
            public List<string> ExtendedCIDRs { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>sg-abcdef****</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
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
        /// <b>Example:</b>
        /// <para>86995</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
