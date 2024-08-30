// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class CreateTrainingJobRequest : TeaModel {
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

        [NameInMap("CodeDir")]
        [Validation(Required=false)]
        public Location CodeDir { get; set; }

        [NameInMap("ComputeResource")]
        [Validation(Required=false)]
        public CreateTrainingJobRequestComputeResource ComputeResource { get; set; }
        public class CreateTrainingJobRequestComputeResource : TeaModel {
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
            public CreateTrainingJobRequestComputeResourceInstanceSpec InstanceSpec { get; set; }
            public class CreateTrainingJobRequestComputeResourceInstanceSpec : TeaModel {
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

            [NameInMap("SpotSpec")]
            [Validation(Required=false)]
            public CreateTrainingJobRequestComputeResourceSpotSpec SpotSpec { get; set; }
            public class CreateTrainingJobRequestComputeResourceSpotSpec : TeaModel {
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

        [NameInMap("Environments")]
        [Validation(Required=false)]
        public Dictionary<string, string> Environments { get; set; }

        [NameInMap("ExperimentConfig")]
        [Validation(Required=false)]
        public CreateTrainingJobRequestExperimentConfig ExperimentConfig { get; set; }
        public class CreateTrainingJobRequestExperimentConfig : TeaModel {
            [NameInMap("ExperimentId")]
            [Validation(Required=false)]
            public string ExperimentId { get; set; }

        }

        [NameInMap("HyperParameters")]
        [Validation(Required=false)]
        public List<CreateTrainingJobRequestHyperParameters> HyperParameters { get; set; }
        public class CreateTrainingJobRequestHyperParameters : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("InputChannels")]
        [Validation(Required=false)]
        public List<CreateTrainingJobRequestInputChannels> InputChannels { get; set; }
        public class CreateTrainingJobRequestInputChannels : TeaModel {
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

        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<CreateTrainingJobRequestLabels> Labels { get; set; }
        public class CreateTrainingJobRequestLabels : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("OutputChannels")]
        [Validation(Required=false)]
        public List<CreateTrainingJobRequestOutputChannels> OutputChannels { get; set; }
        public class CreateTrainingJobRequestOutputChannels : TeaModel {
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

        [NameInMap("RoleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        [NameInMap("Scheduler")]
        [Validation(Required=false)]
        public CreateTrainingJobRequestScheduler Scheduler { get; set; }
        public class CreateTrainingJobRequestScheduler : TeaModel {
            [NameInMap("MaxRunningTimeInSeconds")]
            [Validation(Required=false)]
            public long? MaxRunningTimeInSeconds { get; set; }

        }

        [NameInMap("Settings")]
        [Validation(Required=false)]
        public CreateTrainingJobRequestSettings Settings { get; set; }
        public class CreateTrainingJobRequestSettings : TeaModel {
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

        [NameInMap("TrainingJobDescription")]
        [Validation(Required=false)]
        public string TrainingJobDescription { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("TrainingJobName")]
        [Validation(Required=false)]
        public string TrainingJobName { get; set; }

        [NameInMap("UserVpc")]
        [Validation(Required=false)]
        public CreateTrainingJobRequestUserVpc UserVpc { get; set; }
        public class CreateTrainingJobRequestUserVpc : TeaModel {
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

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
