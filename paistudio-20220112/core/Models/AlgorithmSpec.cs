// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiStudio20220112.Models
{
    public class AlgorithmSpec : TeaModel {
        [NameInMap("CodeDir")]
        [Validation(Required=false)]
        public Location CodeDir { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Command")]
        [Validation(Required=false)]
        public List<string> Command { get; set; }

        [NameInMap("ComputeResource")]
        [Validation(Required=false)]
        public AlgorithmSpecComputeResource ComputeResource { get; set; }
        public class AlgorithmSpecComputeResource : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public AlgorithmSpecComputeResourcePolicy Policy { get; set; }
            public class AlgorithmSpecComputeResourcePolicy : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

        }

        [NameInMap("Customization")]
        [Validation(Required=false)]
        public AlgorithmSpecCustomization Customization { get; set; }
        public class AlgorithmSpecCustomization : TeaModel {
            [NameInMap("CodeDir")]
            [Validation(Required=false)]
            public bool? CodeDir { get; set; }

        }

        [NameInMap("HyperParameters")]
        [Validation(Required=false)]
        public List<HyperParameterDefinition> HyperParameters { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Image")]
        [Validation(Required=false)]
        public string Image { get; set; }

        [NameInMap("InputChannels")]
        [Validation(Required=false)]
        public List<Channel> InputChannels { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        [NameInMap("MetricDefinitions")]
        [Validation(Required=false)]
        public List<MetricDefinition> MetricDefinitions { get; set; }

        [NameInMap("OutputChannels")]
        [Validation(Required=false)]
        public List<Channel> OutputChannels { get; set; }

        [NameInMap("ProgressDefinitions")]
        [Validation(Required=false)]
        public AlgorithmSpecProgressDefinitions ProgressDefinitions { get; set; }
        public class AlgorithmSpecProgressDefinitions : TeaModel {
            [NameInMap("OverallProgress")]
            [Validation(Required=false)]
            public AlgorithmSpecProgressDefinitionsOverallProgress OverallProgress { get; set; }
            public class AlgorithmSpecProgressDefinitionsOverallProgress : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Regex")]
                [Validation(Required=false)]
                public string Regex { get; set; }

            }

            [NameInMap("RemainingTime")]
            [Validation(Required=false)]
            public AlgorithmSpecProgressDefinitionsRemainingTime RemainingTime { get; set; }
            public class AlgorithmSpecProgressDefinitionsRemainingTime : TeaModel {
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Regex")]
                [Validation(Required=false)]
                public string Regex { get; set; }

            }

        }

        [NameInMap("ResourceRequirements")]
        [Validation(Required=false)]
        public List<ConditionExpression> ResourceRequirements { get; set; }

        [NameInMap("SupportedInstanceTypes")]
        [Validation(Required=false)]
        [Obsolete]
        public List<string> SupportedInstanceTypes { get; set; }

        [NameInMap("SupportsDistributedTraining")]
        [Validation(Required=false)]
        public bool? SupportsDistributedTraining { get; set; }

    }

}
