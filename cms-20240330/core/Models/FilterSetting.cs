// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class FilterSetting : TeaModel {
        /// <summary>
        /// <para>The subscription conditions.</para>
        /// </summary>
        [NameInMap("conditions")]
        [Validation(Required=false)]
        public List<FilterSettingConditions> Conditions { get; set; }
        public class FilterSettingConditions : TeaModel {
            /// <summary>
            /// <para>The JSON path of the event field. Dot-notation nesting is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>labels.alertname</para>
            /// </summary>
            [NameInMap("field")]
            [Validation(Required=false)]
            public string Field { get; set; }

            /// <summary>
            /// <para>The comparison operator.</para>
            /// 
            /// <b>Example:</b>
            /// <para>EQ</para>
            /// </summary>
            [NameInMap("op")]
            [Validation(Required=false)]
            public string Op { get; set; }

            /// <summary>
            /// <para>The matching value. Separate multiple values with commas when using IN or NOT_IN.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CRITICAL</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>Use either expression or relation. If expression is not empty, it takes precedence and relation is ignored. If expression is empty or not specified, relation (AND or OR) is used to perform a simple AND/OR operation on all conditions. Condition numbers correspond to the indexes of the conditions array (starting from 1). Each condition evaluates whether a single event field matches by using field (the event field path, which supports dot-notation nesting such as resource.tags.pod), op (the operator, such as CONTAIN, EQ, or IN), and value (the matching value).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1 and 2 or 3</para>
        /// </summary>
        [NameInMap("expression")]
        [Validation(Required=false)]
        public string Expression { get; set; }

        /// <summary>
        /// <para>The logical relationship between conditions. This parameter takes effect when expression is empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AND</para>
        /// </summary>
        [NameInMap("relation")]
        [Validation(Required=false)]
        public string Relation { get; set; }

    }

}
