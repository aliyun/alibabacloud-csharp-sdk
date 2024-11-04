// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class AlertRuleSlsQueryJoin : TeaModel {
        [NameInMap("conditions")]
        [Validation(Required=false)]
        public List<AlertRuleSlsQueryJoinConditions> Conditions { get; set; }
        public class AlertRuleSlsQueryJoinConditions : TeaModel {
            /// <summary>
            /// <para>条件的左操作参数，格式为$<query_idx>.&lt;结果集字段名&gt;</para>
            /// </summary>
            [NameInMap("firstField")]
            [Validation(Required=false)]
            public string FirstField { get; set; }

            /// <summary>
            /// <para>&lt;, &gt;, ==, !=, &lt;=, &gt;=</para>
            /// </summary>
            [NameInMap("oper")]
            [Validation(Required=false)]
            public string Oper { get; set; }

            /// <summary>
            /// <para>条件的右操作参数，格式为$<query_idx>.&lt;结果集字段名&gt;</para>
            /// </summary>
            [NameInMap("secondField")]
            [Validation(Required=false)]
            public string SecondField { get; set; }

        }

        /// <summary>
        /// <para>集合操作类型。
        ///   ● CrossJoin： 笛卡尔积
        ///   ● FullJoin：全联
        ///   ● InnerJoin：内联
        ///   ● LeftExclude： 左斥
        ///   ● RightExclude：右斥
        ///   ● LeftJoin：左联
        ///   ● RightJoin：右联
        ///   ● NoJoin：不合并
        ///   ● Concat： 拼接
        ///   <a href="https://help.aliyun.com/zh/sls/user-guide/set-query-statistics-statement">https://help.aliyun.com/zh/sls/user-guide/set-query-statistics-statement</a></para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
