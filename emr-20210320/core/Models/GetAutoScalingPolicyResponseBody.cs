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
            /// The auto scaling rules.
            /// </summary>
            [NameInMap("ScalingRules")]
            [Validation(Required=false)]
            public List<GetAutoScalingPolicyResponseBodyScalingPolicyScalingRules> ScalingRules { get; set; }
            public class GetAutoScalingPolicyResponseBodyScalingPolicyScalingRules : TeaModel {
                /// <summary>
                /// The scaling type. Valid values:
                /// 
                /// *   SCALE_OUT
                /// *   SCALE_IN
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
                /// The adjustment value. The parameter value must be a positive integer, which indicates the number of instances that you want to add or remove.
                /// </summary>
                [NameInMap("AdjustmentValue")]
                [Validation(Required=false)]
                public int? AdjustmentValue { get; set; }

                /// <summary>
                /// The description of load-based scaling.
                /// </summary>
                [NameInMap("MetricsTrigger")]
                [Validation(Required=false)]
                public MetricsTrigger MetricsTrigger { get; set; }

                /// <summary>
                /// The name of the auto scaling rule.
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// The description of time-based scaling.
                /// </summary>
                [NameInMap("TimeTrigger")]
                [Validation(Required=false)]
                public TimeTrigger TimeTrigger { get; set; }

                /// <summary>
                /// The type of the auto scaling rule. Valid values:
                /// 
                /// *   TIME_TRIGGER: time-based scaling
                /// *   METRICS_TRIGGER: load-based scaling
                /// </summary>
                [NameInMap("TriggerType")]
                [Validation(Required=false)]
                public string TriggerType { get; set; }

            }

        }

    }

}
