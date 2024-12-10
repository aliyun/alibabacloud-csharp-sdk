// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class ListTrainingJobsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("TrainingJobs")]
        [Validation(Required=false)]
        public List<ListTrainingJobsResponseBodyTrainingJobs> TrainingJobs { get; set; }
        public class ListTrainingJobsResponseBodyTrainingJobs : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>llm_train</para>
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

            /// <summary>
            /// <b>Example:</b>
            /// <para>v0.0.1</para>
            /// </summary>
            [NameInMap("AlgorithmVersion")]
            [Validation(Required=false)]
            public string AlgorithmVersion { get; set; }

            [NameInMap("ComputeResource")]
            [Validation(Required=false)]
            public ListTrainingJobsResponseBodyTrainingJobsComputeResource ComputeResource { get; set; }
            public class ListTrainingJobsResponseBodyTrainingJobsComputeResource : TeaModel {
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
                public ListTrainingJobsResponseBodyTrainingJobsComputeResourceInstanceSpec InstanceSpec { get; set; }
                public class ListTrainingJobsResponseBodyTrainingJobsComputeResourceInstanceSpec : TeaModel {
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

            }

            [NameInMap("Environments")]
            [Validation(Required=false)]
            public Dictionary<string, string> Environments { get; set; }

            [NameInMap("ExperimentConfig")]
            [Validation(Required=false)]
            public ListTrainingJobsResponseBodyTrainingJobsExperimentConfig ExperimentConfig { get; set; }
            public class ListTrainingJobsResponseBodyTrainingJobsExperimentConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>exp-ds9aefia90v</para>
                /// </summary>
                [NameInMap("ExperimentId")]
                [Validation(Required=false)]
                public string ExperimentId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>large_language_model</para>
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
            public List<ListTrainingJobsResponseBodyTrainingJobsHyperParameters> HyperParameters { get; set; }
            public class ListTrainingJobsResponseBodyTrainingJobsHyperParameters : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>learning_rate</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.001</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("InputChannels")]
            [Validation(Required=false)]
            public List<ListTrainingJobsResponseBodyTrainingJobsInputChannels> InputChannels { get; set; }
            public class ListTrainingJobsResponseBodyTrainingJobsInputChannels : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>d-475megosidivjfgfq6</para>
                /// </summary>
                [NameInMap("DatasetId")]
                [Validation(Required=false)]
                public string DatasetId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>oss://test-bucket.oss-cn-hangzhou-internal.aliyuncs.com/path/to/input/channel/</para>
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

                [NameInMap("VersionName")]
                [Validation(Required=false)]
                public string VersionName { get; set; }

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
            public List<ListTrainingJobsResponseBodyTrainingJobsLabels> Labels { get; set; }
            public class ListTrainingJobsResponseBodyTrainingJobsLabels : TeaModel {
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
            public List<ListTrainingJobsResponseBodyTrainingJobsOutputChannels> OutputChannels { get; set; }
            public class ListTrainingJobsResponseBodyTrainingJobsOutputChannels : TeaModel {
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
                /// <para>oss://test-bucket.oss-cn-hangzhou-internal.aliyuncs.com/path/to/output/channel/</para>
                /// </summary>
                [NameInMap("OutputUri")]
                [Validation(Required=false)]
                public string OutputUri { get; set; }

                [NameInMap("VersionName")]
                [Validation(Required=false)]
                public string VersionName { get; set; }

            }

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
            /// <para>acs:ram::{accountID}:role/{roleName}</para>
            /// </summary>
            [NameInMap("RoleArn")]
            [Validation(Required=false)]
            public string RoleArn { get; set; }

            [NameInMap("Scheduler")]
            [Validation(Required=false)]
            public ListTrainingJobsResponseBodyTrainingJobsScheduler Scheduler { get; set; }
            public class ListTrainingJobsResponseBodyTrainingJobsScheduler : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MaxRunningTimeInSeconds")]
                [Validation(Required=false)]
                public long? MaxRunningTimeInSeconds { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("StatusTransitions")]
            [Validation(Required=false)]
            public List<ListTrainingJobsResponseBodyTrainingJobsStatusTransitions> StatusTransitions { get; set; }
            public class ListTrainingJobsResponseBodyTrainingJobsStatusTransitions : TeaModel {
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
            /// <para>train1layo6js8ra</para>
            /// </summary>
            [NameInMap("TrainingJobId")]
            [Validation(Required=false)]
            public string TrainingJobId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>qwen2-7b</para>
            /// </summary>
            [NameInMap("TrainingJobName")]
            [Validation(Required=false)]
            public string TrainingJobName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123456789</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("UserVpc")]
            [Validation(Required=false)]
            public ListTrainingJobsResponseBodyTrainingJobsUserVpc UserVpc { get; set; }
            public class ListTrainingJobsResponseBodyTrainingJobsUserVpc : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>eth1</para>
                /// </summary>
                [NameInMap("DefaultRoute")]
                [Validation(Required=false)]
                public string DefaultRoute { get; set; }

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
            /// <para>1234</para>
            /// </summary>
            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

    }

}
