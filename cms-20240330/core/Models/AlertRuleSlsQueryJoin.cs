// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class AlertRuleSlsQueryJoin : TeaModel {
        /// <summary>
        /// <para>The list of join conditions.</para>
        /// </summary>
        [NameInMap("conditions")]
        [Validation(Required=false)]
        public List<AlertRuleSlsQueryJoinConditions> Conditions { get; set; }
        public class AlertRuleSlsQueryJoinConditions : TeaModel {
            /// <summary>
            /// <para>The left operand of the condition. The format is $\<query_idx>.\<field_name_in_result_set>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>$0.<b>topic</b></para>
            /// </summary>
            [NameInMap("firstField")]
            [Validation(Required=false)]
            public string FirstField { get; set; }

            /// <summary>
            /// <para>The comparison operator. Valid values are &lt;, &gt;, ==, !=, &lt;=, and &gt;=.</para>
            /// 
            /// <b>Example:</b>
            /// <para>==</para>
            /// </summary>
            [NameInMap("oper")]
            [Validation(Required=false)]
            public string Oper { get; set; }

            /// <summary>
            /// <para>The right operand of the condition. The format is $\<query_idx>.\<field_name_in_result_set>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>$0.<b>topic</b></para>
            /// </summary>
            [NameInMap("secondField")]
            [Validation(Required=false)]
            public string SecondField { get; set; }

        }

        /// <summary>
        /// <para>The type of the collection operation.</para>
        /// <list type="bullet">
        /// <item><description><para>CrossJoin: The Cartesian product.</para>
        /// </description></item>
        /// <item><description><para>FullJoin: The full join.</para>
        /// </description></item>
        /// <item><description><para>InnerJoin: The inner join.</para>
        /// </description></item>
        /// <item><description><para>LeftExclude: The left exclusion.</para>
        /// </description></item>
        /// <item><description><para>RightExclude: The right exclusion.</para>
        /// </description></item>
        /// <item><description><para>LeftJoin: The left join.</para>
        /// </description></item>
        /// <item><description><para>RightJoin: The right join.</para>
        /// </description></item>
        /// <item><description><para>NoJoin: No merge operation is performed.</para>
        /// </description></item>
        /// <item><description><para>Concat: Concatenation.</para>
        /// </description></item>
        /// </list>
        /// <para>For more information, see https\://www\.alibabacloud.com/help/en/sls/user-guide/set-operations.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CrossJoin</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
