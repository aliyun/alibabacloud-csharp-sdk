// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class ListTrainingJobsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("TrainingJobs")]
        [Validation(Required=false)]
        public List<ListTrainingJobsResponseBodyTrainingJobs> TrainingJobs { get; set; }
        public class ListTrainingJobsResponseBodyTrainingJobs : TeaModel {
            [NameInMap("AlgorithmName")]
            [Validation(Required=false)]
            public string AlgorithmName { get; set; }

            [NameInMap("AlgorithmProvider")]
            [Validation(Required=false)]
            public string AlgorithmProvider { get; set; }

            [NameInMap("AlgorithmVersion")]
            [Validation(Required=false)]
            public string AlgorithmVersion { get; set; }

            [NameInMap("ComputeResource")]
            [Validation(Required=false)]
            public ListTrainingJobsResponseBodyTrainingJobsComputeResource ComputeResource { get; set; }
            public class ListTrainingJobsResponseBodyTrainingJobsComputeResource : TeaModel {
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
                public ListTrainingJobsResponseBodyTrainingJobsComputeResourceInstanceSpec InstanceSpec { get; set; }
                public class ListTrainingJobsResponseBodyTrainingJobsComputeResourceInstanceSpec : TeaModel {
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

            }

            [NameInMap("Environments")]
            [Validation(Required=false)]
            public Dictionary<string, string> Environments { get; set; }

            [NameInMap("ExperimentConfig")]
            [Validation(Required=false)]
            public ListTrainingJobsResponseBodyTrainingJobsExperimentConfig ExperimentConfig { get; set; }
            public class ListTrainingJobsResponseBodyTrainingJobsExperimentConfig : TeaModel {
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
            public List<ListTrainingJobsResponseBodyTrainingJobsHyperParameters> HyperParameters { get; set; }
            public class ListTrainingJobsResponseBodyTrainingJobsHyperParameters : TeaModel {
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("InputChannels")]
            [Validation(Required=false)]
            public List<ListTrainingJobsResponseBodyTrainingJobsInputChannels> InputChannels { get; set; }
            public class ListTrainingJobsResponseBodyTrainingJobsInputChannels : TeaModel {
                [NameInMap("DatasetId")]
                [Validation(Required=false)]
                public string DatasetId { get; set; }

                [NameInMap("InputUri")]
                [Validation(Required=false)]
                public string InputUri { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("IsTempAlgo")]
            [Validation(Required=false)]
            public bool? IsTempAlgo { get; set; }

            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<ListTrainingJobsResponseBodyTrainingJobsLabels> Labels { get; set; }
            public class ListTrainingJobsResponseBodyTrainingJobsLabels : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("OutputChannels")]
            [Validation(Required=false)]
            public List<ListTrainingJobsResponseBodyTrainingJobsOutputChannels> OutputChannels { get; set; }
            public class ListTrainingJobsResponseBodyTrainingJobsOutputChannels : TeaModel {
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

            [NameInMap("PythonRequirements")]
            [Validation(Required=false)]
            public List<string> PythonRequirements { get; set; }

            [NameInMap("ReasonCode")]
            [Validation(Required=false)]
            public string ReasonCode { get; set; }

            [NameInMap("ReasonMessage")]
            [Validation(Required=false)]
            public string ReasonMessage { get; set; }

            [NameInMap("RoleArn")]
            [Validation(Required=false)]
            public string RoleArn { get; set; }

            [NameInMap("Scheduler")]
            [Validation(Required=false)]
            public ListTrainingJobsResponseBodyTrainingJobsScheduler Scheduler { get; set; }
            public class ListTrainingJobsResponseBodyTrainingJobsScheduler : TeaModel {
                [NameInMap("MaxRunningTimeInSeconds")]
                [Validation(Required=false)]
                public long? MaxRunningTimeInSeconds { get; set; }

            }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("StatusTransitions")]
            [Validation(Required=false)]
            public List<ListTrainingJobsResponseBodyTrainingJobsStatusTransitions> StatusTransitions { get; set; }
            public class ListTrainingJobsResponseBodyTrainingJobsStatusTransitions : TeaModel {
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

            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("UserVpc")]
            [Validation(Required=false)]
            public ListTrainingJobsResponseBodyTrainingJobsUserVpc UserVpc { get; set; }
            public class ListTrainingJobsResponseBodyTrainingJobsUserVpc : TeaModel {
                [NameInMap("DefaultRoute")]
                [Validation(Required=false)]
                public string DefaultRoute { get; set; }

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

}
