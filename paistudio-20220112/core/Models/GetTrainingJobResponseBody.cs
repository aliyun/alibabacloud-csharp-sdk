// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class GetTrainingJobResponseBody : TeaModel {
        [NameInMap("AlgorithmId")]
        [Validation(Required=false)]
        public string AlgorithmId { get; set; }

        [NameInMap("AlgorithmName")]
        [Validation(Required=false)]
        public string AlgorithmName { get; set; }

        [NameInMap("AlgorithmProvider")]
        [Validation(Required=false)]
        public string AlgorithmProvider { get; set; }

        [NameInMap("AlgorithmSpec")]
        [Validation(Required=false)]
        public AlgorithmSpec AlgorithmSpec { get; set; }

        [NameInMap("AlgorithmVersion")]
        [Validation(Required=false)]
        public string AlgorithmVersion { get; set; }

        [NameInMap("ComputeResource")]
        [Validation(Required=false)]
        public GetTrainingJobResponseBodyComputeResource ComputeResource { get; set; }
        public class GetTrainingJobResponseBodyComputeResource : TeaModel {
            [NameInMap("EcsCount")]
            [Validation(Required=false)]
            public long? EcsCount { get; set; }

            [NameInMap("EcsSpec")]
            [Validation(Required=false)]
            public string EcsSpec { get; set; }

            [NameInMap("InstanceCount")]
            [Validation(Required=false)]
            public long? InstanceCount { get; set; }

            [NameInMap("InstanceSpec")]
            [Validation(Required=false)]
            public GetTrainingJobResponseBodyComputeResourceInstanceSpec InstanceSpec { get; set; }
            public class GetTrainingJobResponseBodyComputeResourceInstanceSpec : TeaModel {
                [NameInMap("CPU")]
                [Validation(Required=false)]
                public string CPU { get; set; }

                [NameInMap("GPU")]
                [Validation(Required=false)]
                public string GPU { get; set; }

                [NameInMap("GPUType")]
                [Validation(Required=false)]
                public string GPUType { get; set; }

                [NameInMap("Memory")]
                [Validation(Required=false)]
                public string Memory { get; set; }

                [NameInMap("SharedMemory")]
                [Validation(Required=false)]
                public string SharedMemory { get; set; }

            }

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
                [NameInMap("SpotDiscountLimit")]
                [Validation(Required=false)]
                public float? SpotDiscountLimit { get; set; }

                [NameInMap("SpotStrategy")]
                [Validation(Required=false)]
                public string SpotStrategy { get; set; }

            }

            [NameInMap("UseSpotInstance")]
            [Validation(Required=false)]
            public bool? UseSpotInstance { get; set; }

        }

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
            [NameInMap("ExperimentId")]
            [Validation(Required=false)]
            public string ExperimentId { get; set; }

            [NameInMap("ExperimentName")]
            [Validation(Required=false)]
            public string ExperimentName { get; set; }

        }

        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        [NameInMap("HyperParameters")]
        [Validation(Required=false)]
        public List<GetTrainingJobResponseBodyHyperParameters> HyperParameters { get; set; }
        public class GetTrainingJobResponseBodyHyperParameters : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("InputChannels")]
        [Validation(Required=false)]
        public List<GetTrainingJobResponseBodyInputChannels> InputChannels { get; set; }
        public class GetTrainingJobResponseBodyInputChannels : TeaModel {
            [NameInMap("DatasetId")]
            [Validation(Required=false)]
            public string DatasetId { get; set; }

            [NameInMap("InputUri")]
            [Validation(Required=false)]
            public string InputUri { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Options")]
            [Validation(Required=false)]
            public string Options { get; set; }

        }

        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<GetTrainingJobResponseBodyInstances> Instances { get; set; }
        public class GetTrainingJobResponseBodyInstances : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("IsTempAlgo")]
        [Validation(Required=false)]
        public bool? IsTempAlgo { get; set; }

        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<GetTrainingJobResponseBodyLabels> Labels { get; set; }
        public class GetTrainingJobResponseBodyLabels : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("LatestMetrics")]
        [Validation(Required=false)]
        public List<GetTrainingJobResponseBodyLatestMetrics> LatestMetrics { get; set; }
        public class GetTrainingJobResponseBodyLatestMetrics : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public string Timestamp { get; set; }

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
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public string Timestamp { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public float? Value { get; set; }

            }

            [NameInMap("RemainingTime")]
            [Validation(Required=false)]
            public GetTrainingJobResponseBodyLatestProgressRemainingTime RemainingTime { get; set; }
            public class GetTrainingJobResponseBodyLatestProgressRemainingTime : TeaModel {
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public string Timestamp { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public long? Value { get; set; }

            }

        }

        [NameInMap("OutputChannels")]
        [Validation(Required=false)]
        public List<GetTrainingJobResponseBodyOutputChannels> OutputChannels { get; set; }
        public class GetTrainingJobResponseBodyOutputChannels : TeaModel {
            [NameInMap("DatasetId")]
            [Validation(Required=false)]
            public string DatasetId { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("OutputUri")]
            [Validation(Required=false)]
            public string OutputUri { get; set; }

        }

        [NameInMap("OutputModel")]
        [Validation(Required=false)]
        public GetTrainingJobResponseBodyOutputModel OutputModel { get; set; }
        public class GetTrainingJobResponseBodyOutputModel : TeaModel {
            [NameInMap("OutputChannelName")]
            [Validation(Required=false)]
            public string OutputChannelName { get; set; }

            [NameInMap("Uri")]
            [Validation(Required=false)]
            public string Uri { get; set; }

        }

        [NameInMap("PythonRequirements")]
        [Validation(Required=false)]
        public List<string> PythonRequirements { get; set; }

        [NameInMap("ReasonCode")]
        [Validation(Required=false)]
        public string ReasonCode { get; set; }

        [NameInMap("ReasonMessage")]
        [Validation(Required=false)]
        public string ReasonMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RoleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        [NameInMap("Scheduler")]
        [Validation(Required=false)]
        public GetTrainingJobResponseBodyScheduler Scheduler { get; set; }
        public class GetTrainingJobResponseBodyScheduler : TeaModel {
            [NameInMap("MaxRunningTimeInSeconds")]
            [Validation(Required=false)]
            public long? MaxRunningTimeInSeconds { get; set; }

        }

        [NameInMap("Settings")]
        [Validation(Required=false)]
        public GetTrainingJobResponseBodySettings Settings { get; set; }
        public class GetTrainingJobResponseBodySettings : TeaModel {
            [NameInMap("AIMasterType")]
            [Validation(Required=false)]
            public string AIMasterType { get; set; }

            [NameInMap("EnableErrorMonitoringInAIMaster")]
            [Validation(Required=false)]
            public bool? EnableErrorMonitoringInAIMaster { get; set; }

            [NameInMap("ErrorMonitoringArgs")]
            [Validation(Required=false)]
            public string ErrorMonitoringArgs { get; set; }

            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

        }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("StatusTransitions")]
        [Validation(Required=false)]
        public List<GetTrainingJobResponseBodyStatusTransitions> StatusTransitions { get; set; }
        public class GetTrainingJobResponseBodyStatusTransitions : TeaModel {
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("ReasonCode")]
            [Validation(Required=false)]
            public string ReasonCode { get; set; }

            [NameInMap("ReasonMessage")]
            [Validation(Required=false)]
            public string ReasonMessage { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("TrainingJobDescription")]
        [Validation(Required=false)]
        public string TrainingJobDescription { get; set; }

        [NameInMap("TrainingJobId")]
        [Validation(Required=false)]
        public string TrainingJobId { get; set; }

        [NameInMap("TrainingJobName")]
        [Validation(Required=false)]
        public string TrainingJobName { get; set; }

        [NameInMap("TrainingJobUrl")]
        [Validation(Required=false)]
        public string TrainingJobUrl { get; set; }

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

            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            [NameInMap("SwitchId")]
            [Validation(Required=false)]
            public string SwitchId { get; set; }

            /// <summary>
            /// VPC ID。
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
