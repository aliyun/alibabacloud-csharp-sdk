// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListAegisContainerPluginRuleResponseBody : TeaModel {
        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListAegisContainerPluginRuleResponseBodyPageInfo PageInfo { get; set; }
        public class ListAegisContainerPluginRuleResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>69</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CE500770-42D3-442E-9DDD-156E0F9F3B45</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The rules.</para>
        /// </summary>
        [NameInMap("RuleList")]
        [Validation(Required=false)]
        public List<ListAegisContainerPluginRuleResponseBodyRuleList> RuleList { get; set; }
        public class ListAegisContainerPluginRuleResponseBodyRuleList : TeaModel {
            /// <summary>
            /// <para>The time when the rule was created. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1676355025000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the rule was modified. Unit: milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1681985833000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>The action of the rule. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Alert</description></item>
            /// <item><description><b>2</b>: Block</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public int? Mode { get; set; }

            /// <summary>
            /// <para>An array that consists of policies.</para>
            /// </summary>
            [NameInMap("Policies")]
            [Validation(Required=false)]
            public List<ListAegisContainerPluginRuleResponseBodyRuleListPolicies> Policies { get; set; }
            public class ListAegisContainerPluginRuleResponseBodyRuleListPolicies : TeaModel {
                /// <summary>
                /// <para>The policy key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>system_auto_****</para>
                /// </summary>
                [NameInMap("PolicyKey")]
                [Validation(Required=false)]
                public string PolicyKey { get; set; }

                /// <summary>
                /// <para>The name of the policy.</para>
                /// 
                /// <b>Example:</b>
                /// <para>System self-starting task\<em>\</em>\<em>\</em></para>
                /// </summary>
                [NameInMap("PolicyName")]
                [Validation(Required=false)]
                public string PolicyName { get; set; }

            }

            /// <summary>
            /// <para>The description of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>system_call</para>
            /// </summary>
            [NameInMap("RuleDescription")]
            [Validation(Required=false)]
            public string RuleDescription { get; set; }

            /// <summary>
            /// <para>The ID of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30****</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public long? RuleId { get; set; }

            /// <summary>
            /// <para>The name of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-18****</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The ID of the rule template. The ListSystemClientRules operation returns the ID of a rule template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>868**</para>
            /// </summary>
            [NameInMap("RuleTemplateId")]
            [Validation(Required=false)]
            public string RuleTemplateId { get; set; }

            /// <summary>
            /// <para>The name of the rule template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>system_call</para>
            /// </summary>
            [NameInMap("RuleTemplateName")]
            [Validation(Required=false)]
            public string RuleTemplateName { get; set; }

            /// <summary>
            /// <para>The fields in the value of the rule subtype.</para>
            /// </summary>
            [NameInMap("SelectedPolicy")]
            [Validation(Required=false)]
            public List<string> SelectedPolicy { get; set; }

            /// <summary>
            /// <para>The switch ID of the rule.</para>
            /// 
            /// <b>Example:</b>
            /// <para>USER-ENABLE-SWITCH-TYPE_****</para>
            /// </summary>
            [NameInMap("SwitchId")]
            [Validation(Required=false)]
            public string SwitchId { get; set; }

            /// <summary>
            /// <para>The images that are added to the whitelist of the rule.</para>
            /// </summary>
            [NameInMap("WhiteImages")]
            [Validation(Required=false)]
            public List<string> WhiteImages { get; set; }

        }

    }

}
