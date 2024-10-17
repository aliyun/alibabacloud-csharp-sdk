// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class MetricsTrigger : TeaModel {
        /// <summary>
        /// <para>多指标逻辑关系。默认：Or。取值范围：</para>
        /// <list type="bullet">
        /// <item><description>And:与</description></item>
        /// <item><description>Or：或</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Or</para>
        /// </summary>
        [NameInMap("ConditionLogicOperator")]
        [Validation(Required=false)]
        public string ConditionLogicOperator { get; set; }

        /// <summary>
        /// <para>指标触发条件列表。</para>
        /// </summary>
        [NameInMap("Conditions")]
        [Validation(Required=false)]
        public List<TriggerCondition> Conditions { get; set; }

        /// <summary>
        /// <para>冷却时间。 单位为秒</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("CoolDownInterval")]
        [Validation(Required=false)]
        public int? CoolDownInterval { get; set; }

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
        /// <para>时间限制。</para>
        /// </summary>
        [NameInMap("TimeConstraints")]
        [Validation(Required=false)]
        public List<TimeConstraint> TimeConstraints { get; set; }

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

}
