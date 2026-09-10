// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class MetricSetTriggerCompositeExpression : TeaModel {
        /// <summary>
        /// <para>The list of sub-conditions. Each item is a simple comparison expression.</para>
        /// </summary>
        [NameInMap("conditions")]
        [Validation(Required=false)]
        public List<MetricSetTriggerSimpleExpression> Conditions { get; set; }

        /// <summary>
        /// <para>The expression type, fixed as COMPOSITE.</para>
        /// 
        /// <b>Example:</b>
        /// <para>COMPOSITE</para>
        /// </summary>
        [NameInMap("expressionType")]
        [Validation(Required=false)]
        public string ExpressionType { get; set; }

        /// <summary>
        /// <para>The logical operator. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>AND: All conditions are met.</description></item>
        /// <item><description>OR: Any condition is met.</description></item>
        /// <item><description>UNLESS: The first condition is met and none of the remaining conditions are met.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AND</para>
        /// </summary>
        [NameInMap("logicOperator")]
        [Validation(Required=false)]
        public string LogicOperator { get; set; }

    }

}
