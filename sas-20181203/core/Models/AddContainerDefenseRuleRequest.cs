// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class AddContainerDefenseRuleRequest : TeaModel {
        /// <summary>
        /// <para>The description of the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-proc-defense</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The action that is performed when the rule is hit. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: alert</description></item>
        /// <item><description><b>2</b>: block</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("RuleAction")]
        [Validation(Required=false)]
        public int? RuleAction { get; set; }

        /// <summary>
        /// <para>The ID of the rule. You do not need to manually specify the ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>500018</para>
        /// </summary>
        [NameInMap("RuleId")]
        [Validation(Required=false)]
        public long? RuleId { get; set; }

        /// <summary>
        /// <para>The name of the rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>auto-test-rule-lt9umq</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The switch of the rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: off</description></item>
        /// <item><description><b>1</b>: on</description></item>
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
        /// <item><description>2: user-defined rules</description></item>
        /// </list>
        /// <remarks>
        /// <para>Only the value 2 is supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public int? RuleType { get; set; }

        /// <summary>
        /// <para>The scope.</para>
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public List<AddContainerDefenseRuleRequestScope> Scope { get; set; }
        public class AddContainerDefenseRuleRequestScope : TeaModel {
            /// <summary>
            /// <para>Specifies whether to include all namespaces. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: You can use the Namespaces parameter to specify the namespaces to include.</description></item>
            /// <item><description><b>1</b>: All namespaces are included.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("AllNamespace")]
            [Validation(Required=false)]
            public int? AllNamespace { get; set; }

            /// <summary>
            /// <para>The ID of the cluster.</para>
            /// <remarks>
            /// <para> You can call the <a href="https://help.aliyun.com/document_detail/182997.html">DescribeGroupedContainerInstances</a> operation to query the IDs of clusters.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>8e2***75b</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The namespaces to include.</para>
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
        public AddContainerDefenseRuleRequestWhitelist Whitelist { get; set; }
        public class AddContainerDefenseRuleRequestWhitelist : TeaModel {
            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>The hash values of the files that need to be added to the whitelist.</para>
            /// <remarks>
            /// <para>This parameter is not supported.</para>
            /// </remarks>
            /// </summary>
            [NameInMap("Hash")]
            [Validation(Required=false)]
            [Obsolete]
            public List<string> Hash { get; set; }

            /// <summary>
            /// <para>The images that need to be added to the whitelist.</para>
            /// </summary>
            [NameInMap("Image")]
            [Validation(Required=false)]
            public List<string> Image { get; set; }

            /// <summary>
            /// <para>The paths to the files that need to be added to the whitelist.</para>
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public List<string> Path { get; set; }

        }

    }

}
