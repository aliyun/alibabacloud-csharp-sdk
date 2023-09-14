// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class TriggerCondition : TeaModel {
        /// <summary>
        /// 比较符。取值范围：
        /// - EQ:等于。
        /// - NE:不等于。
        /// - GT:大于。
        /// - LT:小于。
        /// - GE:大于等于。
        /// - LE:小于等于。
        /// </summary>
        [NameInMap("ComparisonOperator")]
        [Validation(Required=false)]
        public string ComparisonOperator { get; set; }

        /// <summary>
        /// 指标名称。指标名称需要在 ListAutoScalingMetrics 接口返回的指标名称列表中。
        /// </summary>
        [NameInMap("MetricName")]
        [Validation(Required=false)]
        public string MetricName { get; set; }

        /// <summary>
        /// 统计量名称。取值范围：
        /// - MAX：最大值。
        /// - MIN：最小值。
        /// - AVG：平均值。
        /// </summary>
        [NameInMap("Statistics")]
        [Validation(Required=false)]
        public string Statistics { get; set; }

        /// <summary>
        /// 指标Tag。
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// 阈值。
        /// </summary>
        [NameInMap("Threshold")]
        [Validation(Required=false)]
        public double? Threshold { get; set; }

    }

}
