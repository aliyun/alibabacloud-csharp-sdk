// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ScalingRuleSpec : TeaModel {
        /// <summary>
        /// 调整值。需要为正数，代表需要扩容或者缩容的实例数量。
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("AdjustmentValue")]
        [Validation(Required=false)]
        public int? AdjustmentValue { get; set; }

        /// <summary>
        /// 按照负载伸缩描述。
        /// </summary>
        [NameInMap("ByLoadScalingRuleSpec")]
        [Validation(Required=false)]
        public ScalingRuleSpecByLoadScalingRuleSpec ByLoadScalingRuleSpec { get; set; }
        public class ScalingRuleSpecByLoadScalingRuleSpec : TeaModel {
            /// <summary>
            /// 比较符。
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("ComparisonOperator")]
            [Validation(Required=false)]
            public string ComparisonOperator { get; set; }

            /// <summary>
            /// 统计次数。
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("EvaluationCount")]
            [Validation(Required=false)]
            public int? EvaluationCount { get; set; }

            /// <summary>
            /// 指标名称。指标名称需要在 ListAutoScalingMetrics 接口返回的指标名称列表中。
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("MetricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            /// <summary>
            /// 统计量名称。
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Statistics")]
            [Validation(Required=false)]
            public string Statistics { get; set; }

            /// <summary>
            /// 阈值。
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public double? Threshold { get; set; }

            /// <summary>
            /// 统计窗口。单位为秒。
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("TimeWindow")]
            [Validation(Required=false)]
            public int? TimeWindow { get; set; }

        }

        /// <summary>
        /// 按照时间伸缩描述。
        /// </summary>
        [NameInMap("ByTimeScalingRuleSpec")]
        [Validation(Required=false)]
        public ScalingRuleSpecByTimeScalingRuleSpec ByTimeScalingRuleSpec { get; set; }
        public class ScalingRuleSpecByTimeScalingRuleSpec : TeaModel {
            /// <summary>
            /// 重复执行定时任务的结束时间戳。单位为毫秒。
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// 启动时间戳。单位为毫秒。
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("LaunchTime")]
            [Validation(Required=false)]
            public long? LaunchTime { get; set; }

            /// <summary>
            /// 指定时间规则的执行类型。
            /// </summary>
            [NameInMap("RecurrenceType")]
            [Validation(Required=false)]
            public string RecurrenceType { get; set; }

            /// <summary>
            /// 重复执行定时任务的数值。具体取值取决于 recurrenceType 设置。
            /// </summary>
            [NameInMap("RecurrenceValue")]
            [Validation(Required=false)]
            public string RecurrenceValue { get; set; }

        }

        /// <summary>
        /// 冷却时间。单位为秒，取值范围在30~10800秒之间。
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("CoolDownInterval")]
        [Validation(Required=false)]
        public int? CoolDownInterval { get; set; }

        /// <summary>
        /// 伸缩活动类型。
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ScalingActivityType")]
        [Validation(Required=false)]
        public string ScalingActivityType { get; set; }

        /// <summary>
        /// 规则名称。
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ScalingRuleName")]
        [Validation(Required=false)]
        public string ScalingRuleName { get; set; }

        /// <summary>
        /// 伸缩规则类型。
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("ScalingRuleType")]
        [Validation(Required=false)]
        public string ScalingRuleType { get; set; }

    }

}
