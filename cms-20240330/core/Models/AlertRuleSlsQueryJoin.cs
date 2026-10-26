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
            /// <para>The left operand of the condition, in the format of $<query_idx>.<result set field name>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>$0.<b>topic</b></para>
            /// </summary>
            [NameInMap("firstField")]
            [Validation(Required=false)]
            public string FirstField { get; set; }

            /// <summary>
            /// <para>The comparison operator. Valid values: &lt;, &gt;, ==, !=, &lt;=, and &gt;=.</para>
            /// 
            /// <b>Example:</b>
            /// <para>==</para>
            /// </summary>
            [NameInMap("oper")]
            [Validation(Required=false)]
            public string Oper { get; set; }

            /// <summary>
            /// <para>The right operand of the condition, in the format of $<query_idx>.<result set field name>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>$0.<b>topic</b></para>
            /// </summary>
            [NameInMap("secondField")]
            [Validation(Required=false)]
            public string SecondField { get; set; }

        }

        /// <summary>
        /// <para>The set operation type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CrossJoin: Cartesian product</description></item>
        /// <item><description>FullJoin: full join</description></item>
        /// <item><description>InnerJoin: inner join</description></item>
        /// <item><description>LeftExclude: left exclude</description></item>
        /// <item><description>RightExclude: right exclude</description></item>
        /// <item><description>LeftJoin: left join</description></item>
        /// <item><description>RightJoin: right join</description></item>
        /// <item><description>NoJoin: no join</description></item>
        /// <item><description>Concat: concatenation</description></item>
        /// </list>
        /// <para>For more information, see <a href="https://www.alibabacloud.com/help/en/sls/user-guide/set-query-statistics-statement">https://www.alibabacloud.com/help/en/sls/user-guide/set-query-statistics-statement</a>.</para>
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
