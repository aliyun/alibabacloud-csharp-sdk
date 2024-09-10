// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListAegisContainerPluginRuleResponseBody : TeaModel {
        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListAegisContainerPluginRuleResponseBodyPageInfo PageInfo { get; set; }
        public class ListAegisContainerPluginRuleResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The page number.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The number of entries per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The rules.
        /// </summary>
        [NameInMap("RuleList")]
        [Validation(Required=false)]
        public List<ListAegisContainerPluginRuleResponseBodyRuleList> RuleList { get; set; }
        public class ListAegisContainerPluginRuleResponseBodyRuleList : TeaModel {
            /// <summary>
            /// The time when the rule was created. Unit: milliseconds.
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// The time when the rule was modified. Unit: milliseconds.
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// The action of the rule. Valid values:
            /// 
            /// *   **1**: Alert
            /// *   **2**: Block
            /// </summary>
            [NameInMap("Mode")]
            [Validation(Required=false)]
            public int? Mode { get; set; }

            /// <summary>
            /// An array that consists of policies.
            /// </summary>
            [NameInMap("Policies")]
            [Validation(Required=false)]
            public List<ListAegisContainerPluginRuleResponseBodyRuleListPolicies> Policies { get; set; }
            public class ListAegisContainerPluginRuleResponseBodyRuleListPolicies : TeaModel {
                /// <summary>
                /// The policy key.
                /// </summary>
                [NameInMap("PolicyKey")]
                [Validation(Required=false)]
                public string PolicyKey { get; set; }

                /// <summary>
                /// The name of the policy.
                /// </summary>
                [NameInMap("PolicyName")]
                [Validation(Required=false)]
                public string PolicyName { get; set; }

            }

            /// <summary>
            /// The description of the rule.
            /// </summary>
            [NameInMap("RuleDescription")]
            [Validation(Required=false)]
            public string RuleDescription { get; set; }

            /// <summary>
            /// The ID of the rule.
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public long? RuleId { get; set; }

            /// <summary>
            /// The name of the rule.
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// The ID of the rule template. The ListSystemClientRules operation returns the ID of a rule template.
            /// </summary>
            [NameInMap("RuleTemplateId")]
            [Validation(Required=false)]
            public string RuleTemplateId { get; set; }

            /// <summary>
            /// The name of the rule template.
            /// </summary>
            [NameInMap("RuleTemplateName")]
            [Validation(Required=false)]
            public string RuleTemplateName { get; set; }

            /// <summary>
            /// The fields in the value of the rule subtype.
            /// </summary>
            [NameInMap("SelectedPolicy")]
            [Validation(Required=false)]
            public List<string> SelectedPolicy { get; set; }

            /// <summary>
            /// The switch ID of the rule.
            /// </summary>
            [NameInMap("SwitchId")]
            [Validation(Required=false)]
            public string SwitchId { get; set; }

            /// <summary>
            /// The images that are added to the whitelist of the rule.
            /// </summary>
            [NameInMap("WhiteImages")]
            [Validation(Required=false)]
            public List<string> WhiteImages { get; set; }

        }

    }

}
