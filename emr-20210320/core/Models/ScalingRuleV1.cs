// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ScalingRuleV1 : TeaModel {
        /// <summary>
        /// 调整类型。
        /// </summary>
        [NameInMap("AdjustmentType")]
        [Validation(Required=false)]
        public string AdjustmentType { get; set; }

        /// <summary>
        /// 调整值,正数为扩容,负数为缩容。
        /// </summary>
        [NameInMap("AdjustmentValue")]
        [Validation(Required=false)]
        public int? AdjustmentValue { get; set; }

        /// <summary>
        /// 冷却时间,单位秒。
        /// </summary>
        [NameInMap("CoolDownTime")]
        [Validation(Required=false)]
        public int? CoolDownTime { get; set; }

        /// <summary>
        /// 规则名称。
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// 规则参数。
        /// </summary>
        [NameInMap("RuleParam")]
        [Validation(Required=false)]
        public ScalingRuleV1RuleParam RuleParam { get; set; }
        public class ScalingRuleV1RuleParam : TeaModel {
            /// <summary>
            /// [负载触发参数] 比较符。
            /// </summary>
            [NameInMap("ComparisonOperator")]
            [Validation(Required=false)]
            public string ComparisonOperator { get; set; }

            /// <summary>
            /// [负载触发参数] 统计次数。
            /// </summary>
            [NameInMap("EvaluationCount")]
            [Validation(Required=false)]
            public int? EvaluationCount { get; set; }

            /// <summary>
            /// [时间调度参数] 周期类型周期过期时间。
            /// </summary>
            [NameInMap("LaunchExpirationTime")]
            [Validation(Required=false)]
            public int? LaunchExpirationTime { get; set; }

            /// <summary>
            /// [时间调度参数] 周期类型周期开始时间。
            /// </summary>
            [NameInMap("LaunchTime")]
            [Validation(Required=false)]
            public string LaunchTime { get; set; }

            /// <summary>
            /// [负载触发参数] 度量名称。
            /// </summary>
            [NameInMap("MetricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            /// <summary>
            /// [负载触发参数] 统计时长,单位分钟。
            /// </summary>
            [NameInMap("Period")]
            [Validation(Required=false)]
            public int? Period { get; set; }

            /// <summary>
            /// [时间调度参数] 周期类型周期结束时间。
            /// </summary>
            [NameInMap("RecurrenceEndTime")]
            [Validation(Required=false)]
            public string RecurrenceEndTime { get; set; }

            /// <summary>
            /// [时间调度参数] 周期类型。
            /// </summary>
            [NameInMap("RecurrenceType")]
            [Validation(Required=false)]
            public string RecurrenceType { get; set; }

            /// <summary>
            /// [时间调度参数] 周期类型周期值。
            /// </summary>
            [NameInMap("RecurrenceValue")]
            [Validation(Required=false)]
            public string RecurrenceValue { get; set; }

            /// <summary>
            /// [负载触发参数] 统计方式。
            /// </summary>
            [NameInMap("Statistics")]
            [Validation(Required=false)]
            public string Statistics { get; set; }

            /// <summary>
            /// [负载触发参数] 阈值。
            /// </summary>
            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public int? Threshold { get; set; }

        }

        /// <summary>
        /// 规则类型。
        /// </summary>
        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public string RuleType { get; set; }

        /// <summary>
        /// 弹性规则配置ID。
        /// </summary>
        [NameInMap("ScalingConfigBizId")]
        [Validation(Required=false)]
        public string ScalingConfigBizId { get; set; }

    }

}
