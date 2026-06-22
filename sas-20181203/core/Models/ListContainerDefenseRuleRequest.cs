// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListContainerDefenseRuleRequest : TeaModel {
        /// <summary>
        /// <para>The list of conditions.</para>
        /// </summary>
        [NameInMap("Conditions")]
        [Validation(Required=false)]
        public List<ListContainerDefenseRuleRequestConditions> Conditions { get; set; }
        public class ListContainerDefenseRuleRequestConditions : TeaModel {
            /// <summary>
            /// <para>The condition type. The following type is supported:</para>
            /// <list type="bullet">
            /// <item><description><b>ruleName</b>: rule name.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ruleName</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The condition content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>auto-test-rule-**</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The page number of the page to return. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Specifies whether the rule is a system default rule.&gt;Notice: This parameter is deprecated..</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IsDefaultRule")]
        [Validation(Required=false)]
        public int? IsDefaultRule { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paging query. Default value: 20. If you leave this parameter empty, 20 entries are returned per page.</para>
        /// <remarks>
        /// <para>Do not leave PageSize empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The rule type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>1: system rule</description></item>
        /// <item><description>2: user rule.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public int? RuleType { get; set; }

    }

}
