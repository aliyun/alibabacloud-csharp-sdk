// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ScalingRuleV1 : TeaModel {
        /// <summary>
        /// <para>调整类型。</para>
        /// 
        /// <b>Example:</b>
        /// <para>QUANTITY_CHANGE_IN_CAPACITY</para>
        /// </summary>
        [NameInMap("AdjustmentType")]
        [Validation(Required=false)]
        public string AdjustmentType { get; set; }

        /// <summary>
        /// <para>调整值,正数为扩容,负数为缩容。</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AdjustmentValue")]
        [Validation(Required=false)]
        public int? AdjustmentValue { get; set; }

        /// <summary>
        /// <para>冷却时间,单位秒。</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("CoolDownTime")]
        [Validation(Required=false)]
        public int? CoolDownTime { get; set; }

        /// <summary>
        /// <para>规则名称。</para>
        /// 
        /// <b>Example:</b>
        /// <para>tule1</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>规则参数。</para>
        /// </summary>
        [NameInMap("RuleParam")]
        [Validation(Required=false)]
        public ScalingRuleV1RuleParam RuleParam { get; set; }
        public class ScalingRuleV1RuleParam : TeaModel {
            /// <summary>
            /// <para>[负载触发参数] 比较符。</para>
            /// 
            /// <b>Example:</b>
            /// <remarks>
            /// </remarks>
            /// </summary>
            [NameInMap("ComparisonOperator")]
            [Validation(Required=false)]
            public string ComparisonOperator { get; set; }

            /// <summary>
            /// <para>[负载触发参数] 统计次数。</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("EvaluationCount")]
            [Validation(Required=false)]
            public int? EvaluationCount { get; set; }

            /// <summary>
            /// <para>[时间调度参数] 周期类型周期过期时间。</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("LaunchExpirationTime")]
            [Validation(Required=false)]
            public int? LaunchExpirationTime { get; set; }

            /// <summary>
            /// <para>[时间调度参数] 周期类型周期开始时间。</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-09-15T04:02Z</para>
            /// </summary>
            [NameInMap("LaunchTime")]
            [Validation(Required=false)]
            public string LaunchTime { get; set; }

            /// <summary>
            /// <para>[负载触发参数] 度量名称。</para>
            /// 
            /// <b>Example:</b>
            /// <para>YarnRootAvailableVCores</para>
            /// </summary>
            [NameInMap("MetricName")]
            [Validation(Required=false)]
            public string MetricName { get; set; }

            /// <summary>
            /// <para>[负载触发参数] 统计时长,单位分钟。</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Period")]
            [Validation(Required=false)]
            public int? Period { get; set; }

            /// <summary>
            /// <para>[时间调度参数] 周期类型周期结束时间。</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-09-16T05:02Z</para>
            /// </summary>
            [NameInMap("RecurrenceEndTime")]
            [Validation(Required=false)]
            public string RecurrenceEndTime { get; set; }

            /// <summary>
            /// <para>[时间调度参数] 周期类型。</para>
            /// 
            /// <b>Example:</b>
            /// <para>Daily</para>
            /// </summary>
            [NameInMap("RecurrenceType")]
            [Validation(Required=false)]
            public string RecurrenceType { get; set; }

            /// <summary>
            /// <para>[时间调度参数] 周期类型周期值。</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RecurrenceValue")]
            [Validation(Required=false)]
            public string RecurrenceValue { get; set; }

            /// <summary>
            /// <para>[负载触发参数] 统计方式。</para>
            /// 
            /// <b>Example:</b>
            /// <para>Average</para>
            /// </summary>
            [NameInMap("Statistics")]
            [Validation(Required=false)]
            public string Statistics { get; set; }

            /// <summary>
            /// <para>[负载触发参数] 阈值。</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public int? Threshold { get; set; }

        }

        /// <summary>
        /// <para>规则类型。</para>
        /// 
        /// <b>Example:</b>
        /// <para>BY_LOAD</para>
        /// </summary>
        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public string RuleType { get; set; }

        /// <summary>
        /// <para>弹性规则配置ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>SCB-DCD96BCCFED1****</para>
        /// </summary>
        [NameInMap("ScalingConfigBizId")]
        [Validation(Required=false)]
        public string ScalingConfigBizId { get; set; }

    }

}
