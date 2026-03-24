// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeRuleGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>02E9A4B8-90FB-5F41-A049-C82277EB82FB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of regular expression rule groups.</para>
        /// </summary>
        [NameInMap("RuleGroups")]
        [Validation(Required=false)]
        public List<DescribeRuleGroupsResponseBodyRuleGroups> RuleGroups { get; set; }
        public class DescribeRuleGroupsResponseBodyRuleGroups : TeaModel {
            /// <summary>
            /// <para>The time when the rule group was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1664336364000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>The automatic update status of the rule group.</para>
            /// <list type="bullet">
            /// <item><description><para>1: Automatic updates are enabled.</para>
            /// </description></item>
            /// <item><description><para>2: Automatic updates are disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("IsSubscribe")]
            [Validation(Required=false)]
            public int? IsSubscribe { get; set; }

            /// <summary>
            /// <para>The ID of the rule group that the current rule group inherits.</para>
            /// <list type="bullet">
            /// <item><description><para>0: The rule group is created from scratch and does not inherit from another rule group.</para>
            /// </description></item>
            /// <item><description><para>1011: The Strict rule group.</para>
            /// </description></item>
            /// <item><description><para>1012: The Medium rule group.</para>
            /// </description></item>
            /// <item><description><para>1013: The Loose rule group.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1012</para>
            /// </summary>
            [NameInMap("ParentRuleGroupId")]
            [Validation(Required=false)]
            public long? ParentRuleGroupId { get; set; }

            /// <summary>
            /// <para>The ID of the rule group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>115361</para>
            /// </summary>
            [NameInMap("RuleGroupId")]
            [Validation(Required=false)]
            public long? RuleGroupId { get; set; }

            /// <summary>
            /// <para>The name of the rule group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ssssss</para>
            /// </summary>
            [NameInMap("RuleGroupName")]
            [Validation(Required=false)]
            public string RuleGroupName { get; set; }

            /// <summary>
            /// <para>The number of built-in rules.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4444</para>
            /// </summary>
            [NameInMap("RuleTotalCount")]
            [Validation(Required=false)]
            public int? RuleTotalCount { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>24</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
