// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class AlertRuleSlsQueryJoin : TeaModel {
        /// <summary>
        /// <para>List of connection conditions.</para>
        /// </summary>
        [NameInMap("conditions")]
        [Validation(Required=false)]
        public List<AlertRuleSlsQueryJoinConditions> Conditions { get; set; }
        public class AlertRuleSlsQueryJoinConditions : TeaModel {
            /// <summary>
            /// <para>Left-hand operand of the condition, formatted as $<query_idx>.<result_set_field_name>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>$0.<b>topic</b></para>
            /// </summary>
            [NameInMap("firstField")]
            [Validation(Required=false)]
            public string FirstField { get; set; }

            /// <summary>
            /// <para>Comparison operator; valid values: &lt;, &gt;, ==, !=, &lt;=, &gt;=.</para>
            /// 
            /// <b>Example:</b>
            /// <para>==</para>
            /// </summary>
            [NameInMap("oper")]
            [Validation(Required=false)]
            public string Oper { get; set; }

            /// <summary>
            /// <para>Right-hand operand of the condition, formatted as $<query_idx>.<result_set_field_name>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>$0.<b>topic</b></para>
            /// </summary>
            [NameInMap("secondField")]
            [Validation(Required=false)]
            public string SecondField { get; set; }

        }

        /// <summary>
        /// <para>Set operation type.
        /// CrossJoin: Cartesian product
        /// FullJoin: Full outer join
        /// InnerJoin: Inner join
        /// LeftExclude: Left anti join
        /// RightExclude: Right anti join
        /// LeftJoin: Left outer join
        /// RightJoin: Right outer join
        /// NoJoin: No merge
        /// Concat: Concatenation</para>
        /// <para>See also: <a href="https://help.aliyun.com/zh/sls/user-guide/set-query-statistics-statement">https://help.aliyun.com/zh/sls/user-guide/set-query-statistics-statement</a></para>
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
