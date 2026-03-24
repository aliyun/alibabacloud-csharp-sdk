// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class AlertRuleSlsQueryJoin : TeaModel {
        /// <summary>
        /// <para>连接条件列表</para>
        /// </summary>
        [NameInMap("conditions")]
        [Validation(Required=false)]
        public List<AlertRuleSlsQueryJoinConditions> Conditions { get; set; }
        public class AlertRuleSlsQueryJoinConditions : TeaModel {
            /// <summary>
            /// <para>条件的左操作参数，格式为$<query_idx>.&lt;结果集字段名&gt;</para>
            /// 
            /// <b>Example:</b>
            /// <para>$0.<b>topic</b></para>
            /// </summary>
            [NameInMap("firstField")]
            [Validation(Required=false)]
            public string FirstField { get; set; }

            /// <summary>
            /// <para>比较操作符，取值范围：&lt;, &gt;, ==, !=, &lt;=, &gt;=</para>
            /// 
            /// <b>Example:</b>
            /// <para>==</para>
            /// </summary>
            [NameInMap("oper")]
            [Validation(Required=false)]
            public string Oper { get; set; }

            /// <summary>
            /// <para>条件的右操作参数，格式为$<query_idx>.&lt;结果集字段名&gt;</para>
            /// 
            /// <b>Example:</b>
            /// <para>$0.<b>topic</b></para>
            /// </summary>
            [NameInMap("secondField")]
            [Validation(Required=false)]
            public string SecondField { get; set; }

        }

        /// <summary>
        /// <para>集合操作类型。</para>
        /// <list type="bullet">
        /// <item><description>CrossJoin： 笛卡尔积</description></item>
        /// <item><description>FullJoin：全联</description></item>
        /// <item><description>InnerJoin：内联</description></item>
        /// <item><description>LeftExclude： 左斥</description></item>
        /// <item><description>RightExclude：右斥</description></item>
        /// <item><description>LeftJoin：左联</description></item>
        /// <item><description>RightJoin：右联</description></item>
        /// <item><description>NoJoin：不合并</description></item>
        /// <item><description>Concat： 拼接</description></item>
        /// </list>
        /// <para>参见：
        ///   <a href="https://help.aliyun.com/zh/sls/user-guide/set-query-statistics-statement">https://help.aliyun.com/zh/sls/user-guide/set-query-statistics-statement</a></para>
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
