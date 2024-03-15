// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class GetAutoScalingPolicyResponseBody : TeaModel {
        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information about the auto scaling policy.
        /// </summary>
        [NameInMap("ScalingPolicy")]
        [Validation(Required=false)]
        public GetAutoScalingPolicyResponseBodyScalingPolicy ScalingPolicy { get; set; }
        public class GetAutoScalingPolicyResponseBodyScalingPolicy : TeaModel {
            /// <summary>
            /// The cluster ID.
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// The maximum and minimum numbers of node groups.
            /// </summary>
            [NameInMap("Constraints")]
            [Validation(Required=false)]
            public GetAutoScalingPolicyResponseBodyScalingPolicyConstraints Constraints { get; set; }
            public class GetAutoScalingPolicyResponseBodyScalingPolicyConstraints : TeaModel {
                /// <summary>
                /// The maximum number of nodes in the node group. Default value: 2000.
                /// </summary>
                [NameInMap("MaxCapacity")]
                [Validation(Required=false)]
                public int? MaxCapacity { get; set; }

                /// <summary>
                /// The minimum number of nodes in the node group. Default value: 0.
                /// </summary>
                [NameInMap("MinCapacity")]
                [Validation(Required=false)]
                public int? MinCapacity { get; set; }

            }

            /// <summary>
            /// The ID of the node group.
            /// </summary>
            [NameInMap("NodeGroupId")]
            [Validation(Required=false)]
            public string NodeGroupId { get; set; }

            /// <summary>
            /// The ID of the scaling policy.
            /// </summary>
            [NameInMap("ScalingPolicyId")]
            [Validation(Required=false)]
            public string ScalingPolicyId { get; set; }

            /// <summary>
            /// The scaling rules.
            /// </summary>
            [NameInMap("ScalingRules")]
            [Validation(Required=false)]
            public List<GetAutoScalingPolicyResponseBodyScalingPolicyScalingRules> ScalingRules { get; set; }
            public class GetAutoScalingPolicyResponseBodyScalingPolicyScalingRules : TeaModel {
                /// <summary>
                /// The type of the scaling activity. Valid values:
                /// 
                /// *   SCALE_OUT: scale-out rules
                /// *   SCALE_IN: scale-in rules
                /// </summary>
                [NameInMap("ActivityType")]
                [Validation(Required=false)]
                public string ActivityType { get; set; }

                /// <summary>
                /// The adjustment type.
                /// </summary>
                [NameInMap("AdjustmentType")]
                [Validation(Required=false)]
                public string AdjustmentType { get; set; }

                /// <summary>
                /// The adjustment value. The value must be a positive number, which indicates the number of instances to be scaled out or in.
                /// </summary>
                [NameInMap("AdjustmentValue")]
                [Validation(Required=false)]
                public int? AdjustmentValue { get; set; }

                /// <summary>
                /// The description of scaling by load.
                /// </summary>
                [NameInMap("MetricsTrigger")]
                [Validation(Required=false)]
                public MetricsTrigger MetricsTrigger { get; set; }

                [NameInMap("MinAdjustmentValue")]
                [Validation(Required=false)]
                public int? MinAdjustmentValue { get; set; }

                /// <summary>
                /// The name of the auto scaling rule.
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// The description of scaling by time.
                /// </summary>
                [NameInMap("TimeTrigger")]
                [Validation(Required=false)]
                public TimeTrigger TimeTrigger { get; set; }

                /// <summary>
                /// The type of the scaling rule. Valid values:
                /// 
                /// *   TIME_TRIGGER: scaling by time.
                /// *   METRICS_TRIGGER: scaling by load.
                /// </summary>
                [NameInMap("TriggerType")]
                [Validation(Required=false)]
                public string TriggerType { get; set; }

            }

        }

    }

}
