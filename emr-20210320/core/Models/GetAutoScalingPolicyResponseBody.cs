// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class GetAutoScalingPolicyResponseBody : TeaModel {
        /// <summary>
        /// 请求ID。
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ScalingPolicy")]
        [Validation(Required=false)]
        public GetAutoScalingPolicyResponseBodyScalingPolicy ScalingPolicy { get; set; }
        public class GetAutoScalingPolicyResponseBodyScalingPolicy : TeaModel {
            /// <summary>
            /// 集群ID。
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// 最大最小值约束
            /// </summary>
            [NameInMap("Constraints")]
            [Validation(Required=false)]
            public GetAutoScalingPolicyResponseBodyScalingPolicyConstraints Constraints { get; set; }
            public class GetAutoScalingPolicyResponseBodyScalingPolicyConstraints : TeaModel {
                /// <summary>
                /// 最大值
                /// </summary>
                [NameInMap("MaxCapacity")]
                [Validation(Required=false)]
                public int? MaxCapacity { get; set; }

                /// <summary>
                /// 最小值
                /// </summary>
                [NameInMap("MinCapacity")]
                [Validation(Required=false)]
                public int? MinCapacity { get; set; }

            }

            /// <summary>
            /// 节点组ID。
            /// </summary>
            [NameInMap("NodeGroupId")]
            [Validation(Required=false)]
            public string NodeGroupId { get; set; }

            /// <summary>
            /// 伸缩策略ID。
            /// </summary>
            [NameInMap("ScalingPolicyId")]
            [Validation(Required=false)]
            public string ScalingPolicyId { get; set; }

            /// <summary>
            /// 伸缩规则列表
            /// </summary>
            [NameInMap("ScalingRules")]
            [Validation(Required=false)]
            public List<GetAutoScalingPolicyResponseBodyScalingPolicyScalingRules> ScalingRules { get; set; }
            public class GetAutoScalingPolicyResponseBodyScalingPolicyScalingRules : TeaModel {
                /// <summary>
                /// 伸缩类型。取值范围：
                /// - SCALE_OUT：扩容
                /// - SCALE_IN：缩容
                /// </summary>
                [NameInMap("ActivityType")]
                [Validation(Required=false)]
                public string ActivityType { get; set; }

                /// <summary>
                /// 调整类型。CHANGE_IN_CAPACITY/EXACT_CAPACITY。
                /// </summary>
                [NameInMap("AdjustmentType")]
                [Validation(Required=false)]
                public string AdjustmentType { get; set; }

                /// <summary>
                /// 调整值。需要为正数，代表需要扩容或者缩容的实例数量。
                /// </summary>
                [NameInMap("AdjustmentValue")]
                [Validation(Required=false)]
                public int? AdjustmentValue { get; set; }

                /// <summary>
                /// 按照负载伸缩描述。
                /// </summary>
                [NameInMap("MetricsTrigger")]
                [Validation(Required=false)]
                public MetricsTrigger MetricsTrigger { get; set; }

                /// <summary>
                /// 弹性伸缩规则名称。
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// 按照时间伸缩描述。
                /// </summary>
                [NameInMap("TimeTrigger")]
                [Validation(Required=false)]
                public TimeTrigger TimeTrigger { get; set; }

                /// <summary>
                /// 伸缩规则类型。取值范围：
                /// - TIME_TRIGGER: 按时间伸缩。
                /// - METRICS_TRIGGER: 按负载伸缩。
                /// </summary>
                [NameInMap("TriggerType")]
                [Validation(Required=false)]
                public string TriggerType { get; set; }

            }

        }

    }

}
