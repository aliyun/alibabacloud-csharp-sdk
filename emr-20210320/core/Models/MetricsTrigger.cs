// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class MetricsTrigger : TeaModel {
        /// <summary>
        /// <para>The logical relationship between multiple metrics. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>And</description></item>
        /// <item><description>Or (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Or</para>
        /// </summary>
        [NameInMap("ConditionLogicOperator")]
        [Validation(Required=false)]
        public string ConditionLogicOperator { get; set; }

        /// <summary>
        /// <para>The trigger conditions for the metric.</para>
        /// </summary>
        [NameInMap("Conditions")]
        [Validation(Required=false)]
        public List<TriggerCondition> Conditions { get; set; }

        /// <summary>
        /// <para>The cooldown interval. Unit: seconds. Valid values: 0 to 10800.</para>
        /// 
        /// <b>Example:</b>
        /// <para>300</para>
        /// </summary>
        [NameInMap("CoolDownInterval")]
        [Validation(Required=false)]
        public int? CoolDownInterval { get; set; }

        /// <summary>
        /// <para>The number of times that the statistics are collected. This parameter is required. Valid values: 1 to 5.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("EvaluationCount")]
        [Validation(Required=false)]
        public int? EvaluationCount { get; set; }

        /// <summary>
        /// <para>The limits on time.</para>
        /// </summary>
        [NameInMap("TimeConstraints")]
        [Validation(Required=false)]
        public List<TimeConstraint> TimeConstraints { get; set; }

        /// <summary>
        /// <para>The time window for statistics. This parameter is required. Unit: seconds. Valid values: 30 to 1800.</para>
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
