// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class Rule : TeaModel {
        /// <summary>
        /// <para>The logical relationship between rules at the same level. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>AND</b>: All rules at the same level must be hit.</description></item>
        /// <item><description><b>OR</b>: Any one rule at the same level can be hit.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AND</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Combinator")]
        [Validation(Required=false)]
        public string Combinator { get; set; }

        /// <summary>
        /// <para>The rule ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1361</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The endpoint device attribute field to match. Required for leaf rules.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mac</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The matching operator. Required for leaf rules.</para>
        /// 
        /// <b>Example:</b>
        /// <para>equal</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        /// <summary>
        /// <para>The rule subtype.</para>
        /// 
        /// <b>Example:</b>
        /// <para>windows</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("RuleSubType")]
        [Validation(Required=false)]
        public string RuleSubType { get; set; }

        /// <summary>
        /// <para>The rule type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>device_info</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public string RuleType { get; set; }

        /// <summary>
        /// <para>The list of matching rules. At least one rule must be included.</para>
        /// </summary>
        [NameInMap("Rules")]
        [Validation(Required=false)]
        public List<Rule> Rules { get; set; }

        /// <summary>
        /// <para>The set of values to match. Required for leaf rules and cannot be empty.</para>
        /// </summary>
        [NameInMap("Values")]
        [Validation(Required=false)]
        public List<string> Values { get; set; }

    }

}
