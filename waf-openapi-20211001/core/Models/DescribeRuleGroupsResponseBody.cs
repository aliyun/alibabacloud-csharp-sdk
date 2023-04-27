// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeRuleGroupsResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// An array of regular expression rule groups.
        /// </summary>
        [NameInMap("RuleGroups")]
        [Validation(Required=false)]
        public List<DescribeRuleGroupsResponseBodyRuleGroups> RuleGroups { get; set; }
        public class DescribeRuleGroupsResponseBodyRuleGroups : TeaModel {
            /// <summary>
            /// The most recent time when the rule group was modified.
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// Indicates whether the automatic update feature is enabled for the rule group.
            /// 
            /// *   1: The automatic update feature is enabled for the rule group.
            /// *   2: The automatic update feature is disabled for the rule group.
            /// </summary>
            [NameInMap("IsSubscribe")]
            [Validation(Required=false)]
            public int? IsSubscribe { get; set; }

            /// <summary>
            /// The ID of the rule group.
            /// 
            /// *   0: The rule group is created from scratch.
            /// *   1011: The rule group is a strict rule group.
            /// *   1012: The rule group is a medium rule group.
            /// *   1013: The rue group is a loose rule group.
            /// </summary>
            [NameInMap("ParentRuleGroupId")]
            [Validation(Required=false)]
            public long? ParentRuleGroupId { get; set; }

            /// <summary>
            /// The ID of the regular expression rule group.
            /// </summary>
            [NameInMap("RuleGroupId")]
            [Validation(Required=false)]
            public long? RuleGroupId { get; set; }

            /// <summary>
            /// The name of the rule group.
            /// </summary>
            [NameInMap("RuleGroupName")]
            [Validation(Required=false)]
            public string RuleGroupName { get; set; }

            /// <summary>
            /// The number of built-in rules in the rule group.
            /// </summary>
            [NameInMap("RuleTotalCount")]
            [Validation(Required=false)]
            public int? RuleTotalCount { get; set; }

        }

        /// <summary>
        /// The total number of entries that are returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
