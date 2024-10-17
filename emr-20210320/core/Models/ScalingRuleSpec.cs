// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ScalingRuleSpec : TeaModel {
        /// <summary>
        /// <para>调整值。需要为正数，代表需要扩容或者缩容的实例数量。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("AdjustmentValue")]
        [Validation(Required=false)]
        public int? AdjustmentValue { get; set; }

        /// <summary>
        /// <para>按照负载伸缩描述。</para>
        /// </summary>
        [NameInMap("ByLoadScalingRuleSpec")]
        [Validation(Required=false)]
        public ScalingRuleSpecByLoadScalingRuleSpec ByLoadScalingRuleSpec { get; set; }
        public class ScalingRuleSpecByLoadScalingRuleSpec : TeaModel {
            /// <summary>
            /// <para>比较符。</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>LT</para>
            /// </summary>
            [NameInMap("ComparisonOperator")]
            [Validation(Required=false)]
            public string ComparisonOperator { get; set; }

            /// <summary>
            /// <para>统计次数。</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("EvaluationCount")]
            [Validation(Required=false)]
            public int? EvaluationCount { get; set; }

            /// <summary>
            /// <para>指标名称。指标名称需要在 ListAutoScalingMetrics 接口返回的指标名称列表中。</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yarn_resourcemanager_root_availablememoryusage</para>
            /// </summary>
            [NameInMap("MetricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            /// <summary>
            /// <para>统计量名称。</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AVG</para>
            /// </summary>
            [NameInMap("Statistics")]
            [Validation(Required=false)]
            public string Statistics { get; set; }

            /// <summary>
            /// <para>阈值。</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12.5</para>
            /// </summary>
            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public double? Threshold { get; set; }

            /// <summary>
            /// <para>统计窗口。单位为秒。</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("TimeWindow")]
            [Validation(Required=false)]
            public int? TimeWindow { get; set; }

        }

        /// <summary>
        /// <para>按照时间伸缩描述。</para>
        /// </summary>
        [NameInMap("ByTimeScalingRuleSpec")]
        [Validation(Required=false)]
        public ScalingRuleSpecByTimeScalingRuleSpec ByTimeScalingRuleSpec { get; set; }
        public class ScalingRuleSpecByTimeScalingRuleSpec : TeaModel {
            /// <summary>
            /// <para>重复执行定时任务的结束时间戳。单位为毫秒。</para>
            /// 
            /// <b>Example:</b>
            /// <para>1639714800000</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            /// <summary>
            /// <para>启动时间戳。单位为毫秒。</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1639714634819</para>
            /// </summary>
            [NameInMap("LaunchTime")]
            [Validation(Required=false)]
            public long? LaunchTime { get; set; }

            /// <summary>
            /// <para>指定时间规则的执行类型。</para>
            /// 
            /// <b>Example:</b>
            /// <para>WEEKLY</para>
            /// </summary>
            [NameInMap("RecurrenceType")]
            [Validation(Required=false)]
            public string RecurrenceType { get; set; }

            /// <summary>
            /// <para>重复执行定时任务的数值。具体取值取决于 recurrenceType 设置。</para>
            /// 
            /// <b>Example:</b>
            /// <para>MON,FRI,SUN</para>
            /// </summary>
            [NameInMap("RecurrenceValue")]
            [Validation(Required=false)]
            public string RecurrenceValue { get; set; }

        }

        /// <summary>
        /// <para>冷却时间。单位为秒，取值范围在30~10800秒之间。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("CoolDownInterval")]
        [Validation(Required=false)]
        public int? CoolDownInterval { get; set; }

        /// <summary>
        /// <para>伸缩活动类型。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SCALE_IN</para>
        /// </summary>
        [NameInMap("ScalingActivityType")]
        [Validation(Required=false)]
        public string ScalingActivityType { get; set; }

        /// <summary>
        /// <para>规则名称。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>scale-out-memory</para>
        /// </summary>
        [NameInMap("ScalingRuleName")]
        [Validation(Required=false)]
        public string ScalingRuleName { get; set; }

        /// <summary>
        /// <para>伸缩规则类型。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BY_TIME</para>
        /// </summary>
        [NameInMap("ScalingRuleType")]
        [Validation(Required=false)]
        public string ScalingRuleType { get; set; }

    }

}
