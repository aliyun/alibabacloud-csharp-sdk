// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class CreateTrainingJobRequest : TeaModel {
        /// <summary>
        /// <para>The algorithm name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ev_classification</para>
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
        /// <para>The algorithm configuration for the training job.</para>
        /// </summary>
        [NameInMap("AlgorithmSpec")]
        [Validation(Required=false)]
        public AlgorithmSpec AlgorithmSpec { get; set; }

        /// <summary>
        /// <para>The algorithm version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1.0.0</para>
        /// </summary>
        [NameInMap("AlgorithmVersion")]
        [Validation(Required=false)]
        public string AlgorithmVersion { get; set; }

        [NameInMap("AssignNodeSpec")]
        [Validation(Required=false)]
        public AssignNodeSpec AssignNodeSpec { get; set; }

        /// <summary>
        /// <para>The code directory for the training job.</para>
        /// </summary>
        [NameInMap("CodeDir")]
        [Validation(Required=false)]
        public Location CodeDir { get; set; }

        /// <summary>
        /// <para>The compute resource configuration.</para>
        /// </summary>
        [NameInMap("ComputeResource")]
        [Validation(Required=false)]
        public CreateTrainingJobRequestComputeResource ComputeResource { get; set; }
        public class CreateTrainingJobRequestComputeResource : TeaModel {
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
            /// <para>The number of instances used from the resource quota.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("InstanceCount")]
            [Validation(Required=false)]
            public long? InstanceCount { get; set; }

            /// <summary>
            /// <para>The instance specification for the resource quota.</para>
            /// </summary>
            [NameInMap("InstanceSpec")]
            [Validation(Required=false)]
            public CreateTrainingJobRequestComputeResourceInstanceSpec InstanceSpec { get; set; }
            public class CreateTrainingJobRequestComputeResourceInstanceSpec : TeaModel {
                /// <summary>
                /// <para>The number of CPU cores for the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8</para>
                /// </summary>
                [NameInMap("CPU")]
                [Validation(Required=false)]
                public string CPU { get; set; }

                /// <summary>
                /// <para>The number of GPUs for the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("GPU")]
                [Validation(Required=false)]
                public string GPU { get; set; }

                /// <summary>
                /// <para>The GPU type for the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>V100</para>
                /// </summary>
                [NameInMap("GPUType")]
                [Validation(Required=false)]
                public string GPUType { get; set; }

                /// <summary>
                /// <para>The memory size of the instance. Unit: GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>32</para>
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public string Memory { get; set; }

                /// <summary>
                /// <para>The shared memory size of the instance. Unit: GB.</para>
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
            /// <para>quotam670lixikcs</para>
            /// </summary>
            [NameInMap("ResourceId")]
            [Validation(Required=false)]
            public string ResourceId { get; set; }

            /// <summary>
            /// <para>The spot instance configuration.</para>
            /// </summary>
            [NameInMap("SpotSpec")]
            [Validation(Required=false)]
            public CreateTrainingJobRequestComputeResourceSpotSpec SpotSpec { get; set; }
            public class CreateTrainingJobRequestComputeResourceSpotSpec : TeaModel {
                /// <summary>
                /// <para>The maximum hourly price discount for the instance. This parameter takes effect only when SpotStrategy is set to SpotWithPriceLimit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9</para>
                /// </summary>
                [NameInMap("SpotDiscountLimit")]
                [Validation(Required=false)]
                public float? SpotDiscountLimit { get; set; }

                /// <summary>
                /// <para>The bidding strategy for the spot instance. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>SpotWithPriceLimit: a spot instance with a maximum price limit.</description></item>
                /// <item><description>SpotAsPriceGo: the system automatically bids at the current market price.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SpotWithPriceLimit</para>
                /// </summary>
                [NameInMap("SpotStrategy")]
                [Validation(Required=false)]
                public string SpotStrategy { get; set; }

            }

            /// <summary>
            /// <para>Specifies whether to use spot instances.</para>
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
        /// <para>The environment variables for the training job.</para>
        /// </summary>
        [NameInMap("Environments")]
        [Validation(Required=false)]
        public Dictionary<string, string> Environments { get; set; }

        /// <summary>
        /// <para>The experiment configuration associated with the training job.</para>
        /// </summary>
        [NameInMap("ExperimentConfig")]
        [Validation(Required=false)]
        public CreateTrainingJobRequestExperimentConfig ExperimentConfig { get; set; }
        public class CreateTrainingJobRequestExperimentConfig : TeaModel {
            /// <summary>
            /// <para>The experiment ID associated with the training job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>exp-ds9aefia90v</para>
            /// </summary>
            [NameInMap("ExperimentId")]
            [Validation(Required=false)]
            public string ExperimentId { get; set; }

        }

        /// <summary>
        /// <para>The training hyperparameter settings.</para>
        /// </summary>
        [NameInMap("HyperParameters")]
        [Validation(Required=false)]
        public List<CreateTrainingJobRequestHyperParameters> HyperParameters { get; set; }
        public class CreateTrainingJobRequestHyperParameters : TeaModel {
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
        /// <para>The training input data configuration.</para>
        /// </summary>
        [NameInMap("InputChannels")]
        [Validation(Required=false)]
        public List<CreateTrainingJobRequestInputChannels> InputChannels { get; set; }
        public class CreateTrainingJobRequestInputChannels : TeaModel {
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
            /// <para>The input data URI.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://pai-quickstart-cn-hangzhou.oss-cn-hangzhou-internal.aliyuncs.com/modelscope/models/qwen2-0.5b/main/</para>
            /// </summary>
            [NameInMap("InputUri")]
            [Validation(Required=false)]
            public string InputUri { get; set; }

            /// <summary>
            /// <para>The input data name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>model</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The input data parameter settings.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;appendable&quot;: true}</para>
            /// </summary>
            [NameInMap("Options")]
            [Validation(Required=false)]
            public string Options { get; set; }

            [NameInMap("RoleArn")]
            [Validation(Required=false)]
            public string RoleArn { get; set; }

            [NameInMap("VersionName")]
            [Validation(Required=false)]
            public string VersionName { get; set; }

        }

        /// <summary>
        /// <para>The training job labels.</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<CreateTrainingJobRequestLabels> Labels { get; set; }
        public class CreateTrainingJobRequestLabels : TeaModel {
            /// <summary>
            /// <para>The key of the label.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CreatedBy</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the label.</para>
            /// 
            /// <b>Example:</b>
            /// <para>QuickStart</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The training output data configuration.</para>
        /// </summary>
        [NameInMap("OutputChannels")]
        [Validation(Required=false)]
        public List<CreateTrainingJobRequestOutputChannels> OutputChannels { get; set; }
        public class CreateTrainingJobRequestOutputChannels : TeaModel {
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
            /// <para>The output data name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>model</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The output data URI.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://pai-quickstart-cn-hangzhou.oss-cn-hangzhou-internal.aliyuncs.com/modelscope/models/qwen2-0.5b/main/</para>
            /// </summary>
            [NameInMap("OutputUri")]
            [Validation(Required=false)]
            public string OutputUri { get; set; }

            [NameInMap("RoleArn")]
            [Validation(Required=false)]
            public string RoleArn { get; set; }

            [NameInMap("VersionName")]
            [Validation(Required=false)]
            public string VersionName { get; set; }

        }

        /// <summary>
        /// <para>The priority of the training job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
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
        /// <para>The Alibaba Cloud Resource Name (ARN) of the RAM role. Format: acs:ram::$accountID:role/$roleName.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:ram::1157703270994901:role/aliyunserviceroleforpaiworkspace</para>
        /// </summary>
        [NameInMap("RoleArn")]
        [Validation(Required=false)]
        public string RoleArn { get; set; }

        /// <summary>
        /// <para>The training job scheduling configuration.</para>
        /// </summary>
        [NameInMap("Scheduler")]
        [Validation(Required=false)]
        public CreateTrainingJobRequestScheduler Scheduler { get; set; }
        public class CreateTrainingJobRequestScheduler : TeaModel {
            /// <summary>
            /// <para>The maximum training runtime in minutes. A value of 0 indicates no limit on the maximum runtime.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("MaxRunningTimeInMinutes")]
            [Validation(Required=false)]
            public long? MaxRunningTimeInMinutes { get; set; }

            /// <summary>
            /// <para>The maximum training runtime in seconds. A value of 0 indicates no limit on the maximum runtime.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("MaxRunningTimeInSeconds")]
            [Validation(Required=false)]
            public long? MaxRunningTimeInSeconds { get; set; }

        }

        /// <summary>
        /// <para>The additional parameter settings for the training node.</para>
        /// </summary>
        [NameInMap("Settings")]
        [Validation(Required=false)]
        public JobSettings Settings { get; set; }

        /// <summary>
        /// <para>The description of the training job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen large language model training</para>
        /// </summary>
        [NameInMap("TrainingJobDescription")]
        [Validation(Required=false)]
        public string TrainingJobDescription { get; set; }

        /// <summary>
        /// <para>The name of the training job.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qwen_llm</para>
        /// </summary>
        [NameInMap("TrainingJobName")]
        [Validation(Required=false)]
        public string TrainingJobName { get; set; }

        /// <summary>
        /// <para>The VPC configuration.</para>
        /// </summary>
        [NameInMap("UserVpc")]
        [Validation(Required=false)]
        public CreateTrainingJobRequestUserVpc UserVpc { get; set; }
        public class CreateTrainingJobRequestUserVpc : TeaModel {
            /// <summary>
            /// <para>The default route interface. eth0 indicates that the default route uses the PAI VPC. eth1 indicates that the default route uses the user VPC. Default value: eth0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eth0</para>
            /// </summary>
            [NameInMap("DefaultRoute")]
            [Validation(Required=false)]
            public string DefaultRoute { get; set; }

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
            /// <para>sg-qdfasd13sdasf</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The vSwitch ID.</para>
            /// 
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
        /// <para>The workspace ID.</para>
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
