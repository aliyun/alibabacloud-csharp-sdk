// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class GetAutoScalingPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C8944****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The Auto Scaling policy.</para>
        /// </summary>
        [NameInMap("ScalingPolicy")]
        [Validation(Required=false)]
        public GetAutoScalingPolicyResponseBodyScalingPolicy ScalingPolicy { get; set; }
        public class GetAutoScalingPolicyResponseBodyScalingPolicy : TeaModel {
            /// <summary>
            /// <para>The cluster ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c-b933c5aac8fe****</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The constraints on the minimum and maximum number of nodes in the node group.</para>
            /// </summary>
            [NameInMap("Constraints")]
            [Validation(Required=false)]
            public GetAutoScalingPolicyResponseBodyScalingPolicyConstraints Constraints { get; set; }
            public class GetAutoScalingPolicyResponseBodyScalingPolicyConstraints : TeaModel {
                /// <summary>
                /// <para>The maximum number of nodes in the node group.
                /// Default value: 2000.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2000</para>
                /// </summary>
                [NameInMap("MaxCapacity")]
                [Validation(Required=false)]
                public int? MaxCapacity { get; set; }

                /// <summary>
                /// <para>The minimum number of nodes in the node group.
                /// Default value: 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MinCapacity")]
                [Validation(Required=false)]
                public int? MinCapacity { get; set; }

            }

            /// <summary>
            /// <para>The node group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ng-869471354ecd****</para>
            /// </summary>
            [NameInMap("NodeGroupId")]
            [Validation(Required=false)]
            public string NodeGroupId { get; set; }

            /// <summary>
            /// <para>The scaling policy ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>asp-asduwe23znl***</para>
            /// </summary>
            [NameInMap("ScalingPolicyId")]
            [Validation(Required=false)]
            public string ScalingPolicyId { get; set; }

            /// <summary>
            /// <para>The list of scaling rules.</para>
            /// </summary>
            [NameInMap("ScalingRules")]
            [Validation(Required=false)]
            public List<GetAutoScalingPolicyResponseBodyScalingPolicyScalingRules> ScalingRules { get; set; }
            public class GetAutoScalingPolicyResponseBodyScalingPolicyScalingRules : TeaModel {
                /// <summary>
                /// <para>The type of the scaling activity. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>SCALE_OUT: scale-out.</para>
                /// </description></item>
                /// <item><description><para>SCALE_IN: scale-in.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>SCALE_OUT</para>
                /// </summary>
                [NameInMap("ActivityType")]
                [Validation(Required=false)]
                public string ActivityType { get; set; }

                /// <summary>
                /// <para>The adjustment type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CHANGE_IN_CAPACITY</para>
                /// </summary>
                [NameInMap("AdjustmentType")]
                [Validation(Required=false)]
                public string AdjustmentType { get; set; }

                /// <summary>
                /// <para>The adjustment value. The value must be a positive integer. It specifies the number of instances to add or remove.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("AdjustmentValue")]
                [Validation(Required=false)]
                public int? AdjustmentValue { get; set; }

                [NameInMap("CollationTimeZone")]
                [Validation(Required=false)]
                public CollationTimeZone CollationTimeZone { get; set; }

                /// <summary>
                /// <para>The description of the metric-based scaling rule.</para>
                /// </summary>
                [NameInMap("MetricsTrigger")]
                [Validation(Required=false)]
                public MetricsTrigger MetricsTrigger { get; set; }

                /// <summary>
                /// <para>The name of the scaling rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>scaling-out-memory</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// <para>The description of the time-based scaling rule.</para>
                /// </summary>
                [NameInMap("TimeTrigger")]
                [Validation(Required=false)]
                public TimeTrigger TimeTrigger { get; set; }

                /// <summary>
                /// <para>The type of the scaling rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><para>TIME_TRIGGER: a time-based scaling rule.</para>
                /// </description></item>
                /// <item><description><para>METRICS_TRIGGER: a metric-based scaling rule.</para>
                /// </description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>TIME_TRIGGER</para>
                /// </summary>
                [NameInMap("TriggerType")]
                [Validation(Required=false)]
                public string TriggerType { get; set; }

            }

        }

    }

}
