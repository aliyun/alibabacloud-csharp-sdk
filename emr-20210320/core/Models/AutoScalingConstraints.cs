// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class AutoScalingConstraints : TeaModel {
        /// <summary>
        /// 按负载伸缩指标单位描述。
        /// </summary>
        [NameInMap("AutoScalingMetricUnits")]
        [Validation(Required=false)]
        public List<MetricUnitValue> AutoScalingMetricUnits { get; set; }

        /// <summary>
        /// 默认按负载弹性伸缩规则列表
        /// </summary>
        [NameInMap("DefaultMetricTriggeredRules")]
        [Validation(Required=false)]
        public List<ScalingRule> DefaultMetricTriggeredRules { get; set; }

        /// <summary>
        /// 单次伸缩活动最大扩缩容节点数量。
        /// </summary>
        [NameInMap("MaxAdjustmentValue")]
        [Validation(Required=false)]
        public int? MaxAdjustmentValue { get; set; }

        /// <summary>
        /// 按负载规则数量最大值。
        /// </summary>
        [NameInMap("MaxByLoadRuleCount")]
        [Validation(Required=false)]
        public int? MaxByLoadRuleCount { get; set; }

        /// <summary>
        /// 按时间规则数量最大值。
        /// </summary>
        [NameInMap("MaxByTimeRuleCount")]
        [Validation(Required=false)]
        public int? MaxByTimeRuleCount { get; set; }

        /// <summary>
        /// 支持的按负载弹性伸缩指标Tag列表。
        /// </summary>
        [NameInMap("SupportMetricTags")]
        [Validation(Required=false)]
        public List<AutoScalingConstraintsSupportMetricTags> SupportMetricTags { get; set; }
        public class AutoScalingConstraintsSupportMetricTags : TeaModel {
            /// <summary>
            /// 指标名称。
            /// </summary>
            [NameInMap("MetricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            /// <summary>
            /// 指标Tag。
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<Tag> Tags { get; set; }

        }

        /// <summary>
        /// 支持的按负载弹性伸缩指标列表。
        /// </summary>
        [NameInMap("SupportMetrics")]
        [Validation(Required=false)]
        public List<string> SupportMetrics { get; set; }

        /// <summary>
        /// 支持的弹性伸缩规则类型。
        /// </summary>
        [NameInMap("SupportRuleTypes")]
        [Validation(Required=false)]
        public List<string> SupportRuleTypes { get; set; }

    }

}
