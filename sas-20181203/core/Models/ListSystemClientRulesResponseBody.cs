// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListSystemClientRulesResponseBody : TeaModel {
        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListSystemClientRulesResponseBodyPageInfo PageInfo { get; set; }
        public class ListSystemClientRulesResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// The page number of the returned page.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The number of entries returned per page.
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
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// An array that consists of the system defense rules.
        /// </summary>
        [NameInMap("RuleList")]
        [Validation(Required=false)]
        public List<ListSystemClientRulesResponseBodyRuleList> RuleList { get; set; }
        public class ListSystemClientRulesResponseBodyRuleList : TeaModel {
            /// <summary>
            /// The name of the aggregation type for the system defense rule.
            /// </summary>
            [NameInMap("AggregationName")]
            [Validation(Required=false)]
            public string AggregationName { get; set; }

            /// <summary>
            /// The description of the system defense rule.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The type of the OS. Valid values:
            /// 
            /// *   **windows**: Windows
            /// *   **linux**: Linux
            /// *   **all**: all types
            /// </summary>
            [NameInMap("Platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            /// <summary>
            /// An array that consists of policies.
            /// </summary>
            [NameInMap("Policies")]
            [Validation(Required=false)]
            public List<ListSystemClientRulesResponseBodyRuleListPolicies> Policies { get; set; }
            public class ListSystemClientRulesResponseBodyRuleListPolicies : TeaModel {
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
            /// The ID of the system defense rule.
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public long? RuleId { get; set; }

            /// <summary>
            /// The name of the system defense rule.
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// The type of the system defense rule. Valid values:
            /// 
            /// *   **1**: alihips, process-specific defense
            /// *   **2**: alinet, network-specific defense
            /// </summary>
            [NameInMap("RuleType")]
            [Validation(Required=false)]
            public int? RuleType { get; set; }

            /// <summary>
            /// The status of the system defense rule. Valid values:
            /// 
            /// *   **online**: enabled
            /// *   **offline**: disabled
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// The switch ID of the system defense rule.
            /// </summary>
            [NameInMap("SwitchId")]
            [Validation(Required=false)]
            public string SwitchId { get; set; }

        }

    }

}
