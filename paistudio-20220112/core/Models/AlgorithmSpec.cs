// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class AlgorithmSpec : TeaModel {
        /// <summary>
        /// <para>The custom code configuration.</para>
        /// </summary>
        [NameInMap("CodeDir")]
        [Validation(Required=false)]
        public Location CodeDir { get; set; }

        /// <summary>
        /// <para>The list of commands to run the training task.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Command")]
        [Validation(Required=false)]
        public List<string> Command { get; set; }

        /// <summary>
        /// <para>The compute resource definition.</para>
        /// </summary>
        [NameInMap("ComputeResource")]
        [Validation(Required=false)]
        public AlgorithmSpecComputeResource ComputeResource { get; set; }
        public class AlgorithmSpecComputeResource : TeaModel {
            /// <summary>
            /// <para>Computing resource configuration policy for the algorithm.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public AlgorithmSpecComputeResourcePolicy Policy { get; set; }
            public class AlgorithmSpecComputeResourcePolicy : TeaModel {
                /// <summary>
                /// <para>Policy content, serialized from a JSON array.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{\&quot;MinTotalCount\&quot;:1,\&quot;MaxTotalCount\&quot;:4,\&quot;RolePolicies\&quot;:{\&quot;chief\&quot;:{\&quot;Count\&quot;:1},\&quot;ps\&quot;:{\&quot;Count\&quot;:1},\&quot;worker\&quot;:{\&quot;Percentage\&quot;:100}}},{\&quot;MinTotalCount\&quot;:5,\&quot;MaxTotalCount\&quot;:10,\&quot;RolePolicies\&quot;:{\&quot;chief\&quot;:{\&quot;Count\&quot;:1},\&quot;ps\&quot;:{\&quot;Percentage\&quot;:20},\&quot;worker\&quot;:{\&quot;Percentage\&quot;:80}}},{\&quot;MinTotalCount\&quot;:11,\&quot;RolePolicies\&quot;:{\&quot;chief\&quot;:{\&quot;Count\&quot;:1},\&quot;ps\&quot;:{\&quot;Percentage\&quot;:40},\&quot;worker\&quot;:{\&quot;Percentage\&quot;:60}}}]</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                /// <summary>
                /// <para>Policy version.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>V1</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

        }

        /// <summary>
        /// <para>The custom configuration.</para>
        /// </summary>
        [NameInMap("Customization")]
        [Validation(Required=false)]
        public AlgorithmSpecCustomization Customization { get; set; }
        public class AlgorithmSpecCustomization : TeaModel {
            /// <summary>
            /// <para>Indicates whether custom-mounted code is used.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CodeDir")]
            [Validation(Required=false)]
            public bool? CodeDir { get; set; }

        }

        /// <summary>
        /// <para>The list of hyperparameter definitions.</para>
        /// </summary>
        [NameInMap("HyperParameters")]
        [Validation(Required=false)]
        public List<HyperParameterDefinition> HyperParameters { get; set; }

        /// <summary>
        /// <para>The training runtime image.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>registry.cn-shanghai.aliyuncs.com/pai-training/kmeans:v1.0.0</para>
        /// </summary>
        [NameInMap("Image")]
        [Validation(Required=false)]
        public string Image { get; set; }

        /// <summary>
        /// <para>The list of input channels for the algorithm.</para>
        /// </summary>
        [NameInMap("InputChannels")]
        [Validation(Required=false)]
        public List<Channel> InputChannels { get; set; }

        /// <summary>
        /// <para>The job type.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TFJob</para>
        /// </summary>
        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        /// <summary>
        /// <para>The list of metric definitions for the training task.</para>
        /// </summary>
        [NameInMap("MetricDefinitions")]
        [Validation(Required=false)]
        public List<MetricDefinition> MetricDefinitions { get; set; }

        /// <summary>
        /// <para>The list of output channels for the algorithm.</para>
        /// </summary>
        [NameInMap("OutputChannels")]
        [Validation(Required=false)]
        public List<Channel> OutputChannels { get; set; }

        /// <summary>
        /// <para>You can use this feature to monitor the training progress.</para>
        /// </summary>
        [NameInMap("ProgressDefinitions")]
        [Validation(Required=false)]
        public AlgorithmSpecProgressDefinitions ProgressDefinitions { get; set; }
        public class AlgorithmSpecProgressDefinitions : TeaModel {
            /// <summary>
            /// <para>Monitors training progress.</para>
            /// </summary>
            [NameInMap("OverallProgress")]
            [Validation(Required=false)]
            public AlgorithmSpecProgressDefinitionsOverallProgress OverallProgress { get; set; }
            public class AlgorithmSpecProgressDefinitionsOverallProgress : TeaModel {
                /// <summary>
                /// <para>The description of the monitoring definition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>training progress</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The regular expression for monitoring.</para>
                /// 
                /// <b>Example:</b>
                /// <para>^[0-9]+([.][0-9]+){0,1}$</para>
                /// </summary>
                [NameInMap("Regex")]
                [Validation(Required=false)]
                public string Regex { get; set; }

            }

            /// <summary>
            /// <para>The definition for monitoring the remaining training time.</para>
            /// </summary>
            [NameInMap("RemainingTime")]
            [Validation(Required=false)]
            public AlgorithmSpecProgressDefinitionsRemainingTime RemainingTime { get; set; }
            public class AlgorithmSpecProgressDefinitionsRemainingTime : TeaModel {
                /// <summary>
                /// <para>The description of the monitoring definition.</para>
                /// 
                /// <b>Example:</b>
                /// <para>training remaining time</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The regular expression for monitoring.</para>
                /// 
                /// <b>Example:</b>
                /// <para>^[0-9]+([.][0-9]+){0,1}$</para>
                /// </summary>
                [NameInMap("Regex")]
                [Validation(Required=false)]
                public string Regex { get; set; }

            }

        }

        /// <summary>
        /// <para>The resource requirements.</para>
        /// </summary>
        [NameInMap("ResourceRequirements")]
        [Validation(Required=false)]
        public List<ConditionExpression> ResourceRequirements { get; set; }

        /// <summary>
        /// <para>The list of supported elastic computing instance types for training.</para>
        /// </summary>
        [NameInMap("SupportedInstanceTypes")]
        [Validation(Required=false)]
        public List<string> SupportedInstanceTypes { get; set; }

        /// <summary>
        /// <para>Indicates whether distributed training is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SupportsDistributedTraining")]
        [Validation(Required=false)]
        public bool? SupportsDistributedTraining { get; set; }

    }

}
