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
        /// <para>The information about the auto scaling policy.</para>
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
            /// <para>The maximum and minimum number of nodes in the node group.</para>
            /// </summary>
            [NameInMap("Constraints")]
            [Validation(Required=false)]
            public GetAutoScalingPolicyResponseBodyScalingPolicyConstraints Constraints { get; set; }
            public class GetAutoScalingPolicyResponseBodyScalingPolicyConstraints : TeaModel {
                /// <summary>
                /// <para>The maximum number of nodes in the node group. Default value: 2000.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2000</para>
                /// </summary>
                [NameInMap("MaxCapacity")]
                [Validation(Required=false)]
                public int? MaxCapacity { get; set; }

                /// <summary>
                /// <para>The minimum number of nodes in the node group. Default value: 0.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MinCapacity")]
                [Validation(Required=false)]
                public int? MinCapacity { get; set; }

            }

            /// <summary>
            /// <para>The ID of the node group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ng-869471354ecd****</para>
            /// </summary>
            [NameInMap("NodeGroupId")]
            [Validation(Required=false)]
            public string NodeGroupId { get; set; }

            /// <summary>
            /// <para>The ID of the scaling policy.</para>
            /// 
            /// <b>Example:</b>
            /// <para>asp-asduwe23znl***</para>
            /// </summary>
            [NameInMap("ScalingPolicyId")]
            [Validation(Required=false)]
            public string ScalingPolicyId { get; set; }

            /// <summary>
            /// <para>The auto scaling rules.</para>
            /// </summary>
            [NameInMap("ScalingRules")]
            [Validation(Required=false)]
            public List<GetAutoScalingPolicyResponseBodyScalingPolicyScalingRules> ScalingRules { get; set; }
            public class GetAutoScalingPolicyResponseBodyScalingPolicyScalingRules : TeaModel {
                /// <summary>
                /// <para>The scaling type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>SCALE_OUT</description></item>
                /// <item><description>SCALE_IN</description></item>
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
                /// <para>The adjustment value. The parameter value must be a positive integer, which indicates the number of instances that you want to add or remove.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("AdjustmentValue")]
                [Validation(Required=false)]
                public int? AdjustmentValue { get; set; }

                /// <summary>
                /// <para>The description of load-based scaling.</para>
                /// </summary>
                [NameInMap("MetricsTrigger")]
                [Validation(Required=false)]
                public MetricsTrigger MetricsTrigger { get; set; }

                /// <summary>
                /// <para>The name of the auto scaling rule.</para>
                /// 
                /// <b>Example:</b>
                /// <para>scaling-out-memory</para>
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// <para>The description of time-based scaling.</para>
                /// </summary>
                [NameInMap("TimeTrigger")]
                [Validation(Required=false)]
                public TimeTrigger TimeTrigger { get; set; }

                /// <summary>
                /// <para>The type of the auto scaling rule. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>TIME_TRIGGER: time-based scaling</description></item>
                /// <item><description>METRICS_TRIGGER: load-based scaling</description></item>
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
