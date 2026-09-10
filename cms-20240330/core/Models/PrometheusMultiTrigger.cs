// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class PrometheusMultiTrigger : TeaModel {
        /// <summary>
        /// <para>The list of sub-conditions. This parameter is used when expressionType is set to COMPOSITE. Each item contains queryName, operator, and threshold.</para>
        /// </summary>
        [NameInMap("conditions")]
        [Validation(Required=false)]
        public List<PrometheusSimpleExpression> Conditions { get; set; }

        /// <summary>
        /// <para>The duration, in seconds, for which the data must continuously meet the condition before the alert is triggered. If this parameter is not specified, the value of conditionConfig.durationSecs is inherited.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("durationSecs")]
        [Validation(Required=false)]
        public int? DurationSecs { get; set; }

        /// <summary>
        /// <para>The expression type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SIMPLE: single-query threshold.</description></item>
        /// <item><description>COMPOSITE: multi-query AND/OR/UNLESS combination.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SIMPLE</para>
        /// </summary>
        [NameInMap("expressionType")]
        [Validation(Required=false)]
        public string ExpressionType { get; set; }

        /// <summary>
        /// <para>The logical operator. This parameter is used when expressionType is set to COMPOSITE. Valid values: AND, OR, and UNLESS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AND</para>
        /// </summary>
        [NameInMap("logicOperator")]
        [Validation(Required=false)]
        public string LogicOperator { get; set; }

        /// <summary>
        /// <para>The comparison operator. This parameter is used when expressionType is set to SIMPLE. Valid values: GT, GE, LT, LE, EQ, and NE.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GT</para>
        /// </summary>
        [NameInMap("operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        /// <summary>
        /// <para>The referenced query name. This parameter is used when expressionType is set to SIMPLE. The value corresponds to QueryConfigUnified.queries[].name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SampleName</para>
        /// </summary>
        [NameInMap("queryName")]
        [Validation(Required=false)]
        public string QueryName { get; set; }

        /// <summary>
        /// <para>The alert severity level. Severity levels in descending priority: CRITICAL &gt; ERROR &gt; WARN / WARNING &gt; INFO. When multiple triggers are configured, they are sorted by this priority, and the first match fires the alert.</para>
        /// 
        /// <b>Example:</b>
        /// <para>INFO</para>
        /// </summary>
        [NameInMap("severity")]
        [Validation(Required=false)]
        public string Severity { get; set; }

        /// <summary>
        /// <para>The comparison threshold. This parameter is used when expressionType is set to SIMPLE.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.0</para>
        /// </summary>
        [NameInMap("threshold")]
        [Validation(Required=false)]
        public double? Threshold { get; set; }

    }

}
