// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class AddContainerDefenseRuleShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-proc-defense</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The action to take when the rule is matched. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: Alert.</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: Block.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RuleAction")]
        [Validation(Required=false)]
        public int? RuleAction { get; set; }

        /// <summary>
        /// <para>The rule ID. You do not need to specify this parameter when creating a rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500018</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

        /// <summary>
        /// <para>The rule name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>auto-test-rule-lt9umq</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The rule switch. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: Disabled.</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: Enabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RuleSwitch")]
        [Validation(Required=false)]
        public int? RuleSwitch { get; set; }

        /// <summary>
        /// <para>The rule type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>2: user rule</description></item>
        /// </list>
        /// <remarks>
        /// <para>Notice: Only the value 2 is supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public int? RuleType { get; set; }

        /// <summary>
        /// <para>The scope. This parameter is required. Specify at least one Scope entry, such as Scope.1.AllNamespace=1, which indicates that the rule applies to all namespaces. If this parameter is not specified, the API returns a 400 error.</para>
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public List<AddContainerDefenseRuleShrinkRequestScope> Scope { get; set; }
        public class AddContainerDefenseRuleShrinkRequestScope : TeaModel {
            /// <summary>
            /// <para>Specifies whether to include all namespaces. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>0</b>: Specifies the namespaces to include by using the Namespaces parameter.</para>
            /// </description></item>
            /// <item><description><para><b>1</b>: Includes all namespaces.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AllNamespace")]
            [Validation(Required=false)]
            public int? AllNamespace { get; set; }

            /// <summary>
            /// <para>The cluster ID.</para>
            /// <remarks>
            /// <para>You can call the <a href="https://help.aliyun.com/document_detail/182997.html">DescribeGroupedContainerInstances</a> operation to obtain this parameter.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>8e2***75b</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The list of included namespaces.</para>
            /// </summary>
            [NameInMap("Namespaces")]
            [Validation(Required=false)]
            public List<string> Namespaces { get; set; }

        }

        /// <summary>
        /// <para>The whitelist.</para>
        /// </summary>
        [NameInMap("Whitelist")]
        [Validation(Required=false)]
        public string WhitelistShrink { get; set; }

    }

}
