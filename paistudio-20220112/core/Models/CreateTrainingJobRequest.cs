// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class CreateTrainingJobRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ev_classification</para>
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
        /// <para>v1.0.0</para>
        /// </summary>
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
            public CreateTrainingJobRequestComputeResourceInstanceSpec InstanceSpec { get; set; }
            public class CreateTrainingJobRequestComputeResourceInstanceSpec : TeaModel {
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
            /// <para>quotam670lixikcs</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            [NameInMap("SpotSpec")]
            [Validation(Required=false)]
            public CreateTrainingJobRequestComputeResourceSpotSpec SpotSpec { get; set; }
            public class CreateTrainingJobRequestComputeResourceSpotSpec : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>9</para>
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

        [NameInMap("Environments")]
        [Validation(Required=false)]
        public Dictionary<string, string> Environments { get; set; }

        [NameInMap("ExperimentConfig")]
        [Validation(Required=false)]
        public CreateTrainingJobRequestExperimentConfig ExperimentConfig { get; set; }
        public class CreateTrainingJobRequestExperimentConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>exp-ds9aefia90v</para>
            /// </summary>
            [NameInMap("ExperimentId")]
            [Validation(Required=false)]
            public string ExperimentId { get; set; }

        }

        [NameInMap("HyperParameters")]
        [Validation(Required=false)]
        public List<CreateTrainingJobRequestHyperParameters> HyperParameters { get; set; }
        public class CreateTrainingJobRequestHyperParameters : TeaModel {
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
        public List<CreateTrainingJobRequestInputChannels> InputChannels { get; set; }
        public class CreateTrainingJobRequestInputChannels : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>d-475megosidivjfgfq6</para>
            /// </summary>
            [NameInMap("DatasetId")]
            [Validation(Required=false)]
            public string DatasetId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>oss://pai-quickstart-cn-hangzhou.oss-cn-hangzhou-internal.aliyuncs.com/modelscope/models/qwen2-0.5b/main/</para>
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

        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<CreateTrainingJobRequestLabels> Labels { get; set; }
        public class CreateTrainingJobRequestLabels : TeaModel {
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

        [NameInMap("OutputChannels")]
        [Validation(Required=false)]
        public List<CreateTrainingJobRequestOutputChannels> OutputChannels { get; set; }
        public class CreateTrainingJobRequestOutputChannels : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>d-475megosidivjfgfq6</para>
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
            /// <para>oss://pai-quickstart-cn-hangzhou.oss-cn-hangzhou-internal.aliyuncs.com/modelscope/models/qwen2-0.5b/main/</para>
            /// </summary>
            [NameInMap("OutputUri")]
            [Validation(Required=false)]
            public string OutputUri { get; set; }

            [NameInMap("VersionName")]
            [Validation(Required=false)]
            public string VersionName { get; set; }

        }

        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        [NameInMap("PythonRequirements")]
        [Validation(Required=false)]
        public List<string> PythonRequirements { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>acs:ram::1157703270994901:role/aliyunserviceroleforpaiworkspace</para>
        /// </summary>
        [NameInMap("RoleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        [NameInMap("Scheduler")]
        [Validation(Required=false)]
        public CreateTrainingJobRequestScheduler Scheduler { get; set; }
        public class CreateTrainingJobRequestScheduler : TeaModel {
            [NameInMap("MaxRunningTimeInMinutes")]
            [Validation(Required=false)]
            public long? MaxRunningTimeInMinutes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("MaxRunningTimeInSeconds")]
            [Validation(Required=false)]
            public long? MaxRunningTimeInSeconds { get; set; }

        }

        [NameInMap("Settings")]
        [Validation(Required=false)]
        public JobSettings Settings { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>qwen large language model training</para>
        /// </summary>
        [NameInMap("TrainingJobDescription")]
        [Validation(Required=false)]
        public string TrainingJobDescription { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen_llm</para>
        /// </summary>
        [NameInMap("TrainingJobName")]
        [Validation(Required=false)]
        public string TrainingJobName { get; set; }

        [NameInMap("UserVpc")]
        [Validation(Required=false)]
        public CreateTrainingJobRequestUserVpc UserVpc { get; set; }
        public class CreateTrainingJobRequestUserVpc : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>eth0</para>
            /// </summary>
            [NameInMap("DefaultRoute")]
            [Validation(Required=false)]
            public string DefaultRoute { get; set; }

            [NameInMap("ExtendedCIDRs")]
            [Validation(Required=false)]
            public List<string> ExtendedCIDRs { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>sg-qdfasd13sdasf</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vs-icrc813vdsfol</para>
            /// </summary>
            [NameInMap("SwitchId")]
            [Validation(Required=false)]
            public string SwitchId { get; set; }

            /// <summary>
            /// <para>VPC ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-dxiflssjx978sl</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
