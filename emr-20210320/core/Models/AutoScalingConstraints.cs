// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class AutoScalingConstraints : TeaModel {
        /// <summary>
        /// <para>按负载伸缩指标单位描述。</para>
        /// </summary>
        [NameInMap("AutoScalingMetricUnits")]
        [Validation(Required=false)]
        public List<MetricUnitValue> AutoScalingMetricUnits { get; set; }

        /// <summary>
        /// <para>默认按负载弹性伸缩规则列表</para>
        /// </summary>
        [NameInMap("DefaultMetricTriggeredRules")]
        [Validation(Required=false)]
        public List<ScalingRule> DefaultMetricTriggeredRules { get; set; }

        /// <summary>
        /// <para>单次伸缩活动最大扩缩容节点数量。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("MaxAdjustmentValue")]
        [Validation(Required=false)]
        public int? MaxAdjustmentValue { get; set; }

        /// <summary>
        /// <para>按负载规则数量最大值。</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxByLoadRuleCount")]
        [Validation(Required=false)]
        public int? MaxByLoadRuleCount { get; set; }

        /// <summary>
        /// <para>按时间规则数量最大值。</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxByTimeRuleCount")]
        [Validation(Required=false)]
        public int? MaxByTimeRuleCount { get; set; }

        /// <summary>
        /// <para>支持的按负载弹性伸缩指标Tag列表。</para>
        /// </summary>
        [NameInMap("SupportMetricTags")]
        [Validation(Required=false)]
        public List<AutoScalingConstraintsSupportMetricTags> SupportMetricTags { get; set; }
        public class AutoScalingConstraintsSupportMetricTags : TeaModel {
            /// <summary>
            /// <para>指标名称。</para>
            /// </summary>
            [NameInMap("MetricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            /// <summary>
            /// <para>指标Tag。</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<Tag> Tags { get; set; }

        }

        /// <summary>
        /// <para>支持的按负载弹性伸缩指标列表。</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;YarnRootAvailableMemoryUsage&quot;,&quot;YarnRootAvailableVcores&quot;]</para>
        /// </summary>
        [NameInMap("SupportMetrics")]
        [Validation(Required=false)]
        public List<string> SupportMetrics { get; set; }

        /// <summary>
        /// <para>支持的弹性伸缩规则类型。</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;TIME_TRIGGER&quot;,&quot;METRICS_TRIGGER&quot;]</para>
        /// </summary>
        [NameInMap("SupportRuleTypes")]
        [Validation(Required=false)]
        public List<string> SupportRuleTypes { get; set; }

    }

}
