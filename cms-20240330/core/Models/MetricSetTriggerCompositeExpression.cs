// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class MetricSetTriggerCompositeExpression : TeaModel {
        /// <summary>
        /// <para>The list of sub-conditions, where each item is a simple comparison expression.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;expressionType&quot;:&quot;SIMPLE&quot;,&quot;queryName&quot;:&quot;cpuQuery&quot;,&quot;operator&quot;:&quot;GT&quot;,&quot;threshold&quot;:80}]</para>
        /// </summary>
        [NameInMap("conditions")]
        [Validation(Required=false)]
        public List<MetricSetTriggerSimpleExpression> Conditions { get; set; }

        /// <summary>
        /// <para>The expression type, which is fixed to COMPOSITE.</para>
        /// 
        /// <b>Example:</b>
        /// <para>COMPOSITE</para>
        /// </summary>
        [NameInMap("expressionType")]
        [Validation(Required=false)]
        public string ExpressionType { get; set; }

        /// <summary>
        /// <para>The logical operator. Valid values: AND (all conditions are met), OR (any condition is met), and UNLESS (the first condition is met and none of the others are met).</para>
        /// 
        /// <b>Example:</b>
        /// <para>AND</para>
        /// </summary>
        [NameInMap("logicOperator")]
        [Validation(Required=false)]
        public string LogicOperator { get; set; }

    }

}
